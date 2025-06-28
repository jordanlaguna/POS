using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using postsys.model;

namespace postsys.Forms
{
    public partial class Sales : Form
    {
        private Product? currentProduct;
        decimal IVA = 0; // IVA del 13%

        public Sales()
        {
            InitializeComponent();

            // Ascign event handlers
            textCode.KeyDown += txtBarCodeSearch;
            textQuantity.KeyDown += txtQuantity_KeyDown;
        }

        private async void txtBarCodeSearch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await SearchProductByBarcodeAsync(textCode.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private async Task SearchProductByBarcodeAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Por favor, ingrese un código de barras válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync($"http://localhost:8000/products/product/{name}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    currentProduct = JsonSerializer.Deserialize<Product>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (currentProduct != null)
                    {
                        // Add product to the sale table
                        AddProductToSaleTable(currentProduct, 0);
                        textQuantity.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentProduct = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentProduct = null;
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && currentProduct != null)
            {
                if (!int.TryParse(textQuantity.Text.Trim(), out int qty))
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (qty > currentProduct.stock)
                {
                    MessageBox.Show("La cantidad ingresada supera el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Search for existing product in the sale table
                foreach (DataGridViewRow row in tableSale.Rows)
                {
                    if (row.Cells["barcode"].Value?.ToString() == currentProduct.barcode)
                    {
                        row.Cells["quantity"].Value = qty;
                        row.Cells["totalPrice"].Value = (currentProduct.price * qty).ToString("0.00");
                        break;
                    }
                }

                // clean up input fields
                textCode.Clear();
                textQuantity.Clear();
                textCode.Focus();
                currentProduct = null;
                e.SuppressKeyPress = true;
            }
            CalculateTotalNew();
        }


        private void AddProductToSaleTable(Product product, int qty)
        {
            foreach (DataGridViewRow row in tableSale.Rows)
            {
                if (row.Cells["barcode"].Value?.ToString() == product.barcode)
                {
                    // Ok, product already exists in the table, update quantity and total price
                    if (int.TryParse(row.Cells["quantity"].Value?.ToString(), out int existingQty))
                    {
                        int newQty = existingQty + qty;

                        if (newQty > product.stock)
                        {
                            MessageBox.Show("La cantidad total supera el stock disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        row.Cells["quantity"].Value = newQty.ToString();
                        row.Cells["totalPrice"].Value = (product.price * newQty).ToString("0.00");
                        return;
                    }
                }
            }

            // If not found, add a new row
            decimal total = product.price * qty;

            tableSale.Rows.Add(
                product.barcode,
                product.name,
                product.price.ToString("0.00"),
                qty.ToString(),
                total.ToString("0.00"),
                product.stock
            );
        }
        private void CalculateTotalNew()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in tableSale.Rows)
            {
                if (decimal.TryParse(row.Cells["totalPrice"].Value?.ToString(), out decimal totalFila))
                {
                    subtotal += totalFila;
                }
            }

            IVA = subtotal * 0.13m;
            decimal totalFinal = subtotal + IVA;

            label6.Text = $"₡{subtotal:0.00}";
            label8.Text = $"₡{IVA:0.00}";
            label5.Text = $"₡{totalFinal:0.00}";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            List<BillsProduct> products = GetProductsFromTable();
            decimal subtotal = decimal.Parse(label6.Text.Replace("₡", "").Trim());
            decimal iva = decimal.Parse(label8.Text.Replace("₡", "").Trim());
            decimal totalAmount = decimal.Parse(label5.Text.Replace("₡", "").Trim());
            string total = label5.Text.Replace("₡", "").Trim();
            Bills bills = new Bills(products, total, iva, subtotal, totalAmount);
            bills.ShowDialog();
        }
        private List<BillsProduct> GetProductsFromTable()
        {
            List<BillsProduct> products = new List<BillsProduct>();
            foreach (DataGridViewRow row in tableSale.Rows)
            {
                if (row.Cells["barCode"].Value != null)
                {
                    products.Add(new BillsProduct
                    {
                        name = row.Cells["Descripcion"].Value.ToString(),
                        quantity = int.Parse(row.Cells["quantity"].Value.ToString()),
                        price = decimal.Parse(row.Cells["price"].Value.ToString())
                    });
                }

            }
            return products;
        }
    }
}
