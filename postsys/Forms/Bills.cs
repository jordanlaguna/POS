using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using postsys.model;

namespace postsys.Forms
{
    public partial class Bills : Form
    {
        decimal collect = 0.00m;
        decimal total = 0.00m;
        private List<BillsProduct> products;
        private decimal subtotal = 0.00m;
        private decimal IVA = 0.00m;
        private decimal totalAmount = 0.00m;

        public Bills(List<BillsProduct> product, string total, decimal IVA, decimal subtotal, decimal totalAmount)
        {
            InitializeComponent();
            label3.Text = total;
            LoadMethoPay();
            textPay.TextChanged += (s, e) => CalculateTotal(); // listening for changes in the textPay TextBox
            this.products = product;
            this.subtotal = subtotal;
            this.IVA = IVA;
            this.totalAmount = totalAmount;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Bills.ActiveForm.Close();
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbMethodPay.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textPay.Text, out decimal cash))
            {
                MessageBox.Show("Monto en efectivo inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal change = cash - totalAmount;

            if (change < 0)
            {
                MessageBox.Show("Pago insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string method = cmbMethodPay.SelectedItem.ToString();
            string invoiceNumber = DateTime.Now.ToString("yyyyMMddHHmmss");

            // Create the invoice model
            BillsModel invoice = new BillsModel
            {
                Number = invoiceNumber,
                Date_now = DateTime.Now,
                Product = products,
                Subtotal = subtotal,
                IVA = IVA,
                Pay_method = method,
                Total = totalAmount,
                Cash = cash,
                Change = change
            };

            // Confirm the invoice generation
            var result = MessageBox.Show("¿Desea generar la factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                BillsExport exporter = new BillsExport();
                exporter.BillsExportAsPdf(invoice);

                MessageBox.Show($"Pago exitoso con {method}. Factura {invoiceNumber} generada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Save the sale to the database
            await AddSale(invoiceNumber, subtotal, IVA, method, cash, change, DateTime.Now);

            this.Close();
        }

        private async Task AddSale(string sale_number, decimal subtotal, decimal tax, string payment_method, decimal cash_received, decimal change_given, DateTime created_at)
        {
            var sale = new
            {
                sale_number = sale_number,
                client_id = 1,
                user_id = 1,  
                total = subtotal + tax,
                subtotal = subtotal,
                tax = tax,
                payment_method = payment_method,
                cash_received = cash_received,
                change_given = change_given,
                created_at = created_at
            };

            var json = JsonSerializer.Serialize(sale);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            try
            {
                var response = await client.PostAsync("http://localhost:8000/sales/add_sale", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CalculateTotal()
        {
            collect = 0.00m;
            total = 0.00m;

            if (decimal.TryParse(textPay.Text, out collect))
            {
                try
                {
                    decimal totalFactura = decimal.Parse(label3.Text.Replace("₡", "").Trim());
                    total = collect - totalFactura;

                    if (total < 0)
                    {
                        label7.Text = "₡0.00";
                    }
                    else
                    {
                        label7.Text = total.ToString("C2");
                    }
                }
                catch
                {
                    label7.Text = "₡0.00";
                }
            }
            else
            {
                label7.Text = "₡0.00";
            }
        }

        private void LoadMethoPay()
        {
            cmbMethodPay.Items.Add("Efectivo");
            cmbMethodPay.Items.Add("Tarjeta de crédito");
            cmbMethodPay.Items.Add("Transferencia bancaria");
            cmbMethodPay.Items.Add("Pago móvil");
            cmbMethodPay.SelectedIndex = 0;
        }
    }
}

