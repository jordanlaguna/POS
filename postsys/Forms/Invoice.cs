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
    public partial class Invoice : Form
    {
        private const string BaseURL = "http://localhost:8000/";
        public Invoice()
        {
            InitializeComponent();
            tableInvoice.CellClick += tableInvoice_CellClick;

            // button show more information
            DataGridViewButtonColumn btnShowMore = new DataGridViewButtonColumn();
            btnShowMore.HeaderText = "Ver más";
            btnShowMore.Name = "btnShowMore";
            btnShowMore.Text = "Ver más";
            btnShowMore.UseColumnTextForButtonValue = true;
            tableInvoice.Columns.Add(btnShowMore);
            LoadDataTableSale();
        }

        private async Task<List<Sale>> GetAllInformationSales()
        {
            using var client = new HttpClient();

            try
            {
                var response = await client.GetAsync(BaseURL + "sales/sales_list");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var salesList = JsonSerializer.Deserialize<List<Sale>> (responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return salesList ?? new List<Sale>();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Sale>();
            }
        }

        public async Task LoadDataTableSale()
        {
            var sales = await GetAllInformationSales();
            tableInvoice.DataSource = null;
            tableInvoice.DataSource = sales;

       
            if (tableInvoice.Columns.Contains("id"))
            {
                tableInvoice.Columns["id"].Visible = false;
            }
        }
        private void tableInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableInvoice.Columns[e.ColumnIndex].Name == "btnShowMore")
            {
                var saleId = tableInvoice.Rows[e.RowIndex].Cells["id"].Value?.ToString();

                if (!string.IsNullOrEmpty(saleId))
                {
                    string url = $"{BaseURL}sales/pdf/{saleId}";
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
            }
        }

    }
}
