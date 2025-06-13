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
    public partial class Inventory : Form
    {
        private bool barcodeCompleted = false;

        public Inventory()
        {
            InitializeComponent();
            LoadDataInTableInventory();
            LoadStaticCategories();
            textBarCode.TextChanged += textBarCode_TextChanged;

            // Button to add product
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            tableInventory.Columns.Add(btnEditar);
        }

        private async Task<List<Product>> GetAllInformationProducts()
        {
            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync("http://localhost:8000/products/products_list");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var productList = JsonSerializer.Deserialize<List<Product>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return productList ?? new List<Product>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Product>();
            }
        }

        public async void LoadDataInTableInventory()
        {
            var products = await GetAllInformationProducts();
            tableInventory.DataSource = null;
            tableInventory.DataSource = products;
            tableInventory.Columns["id_product"].Visible = false;
            tableInventory.Columns["category_id"].Visible = false;
        }

        private void Inventory_Load(object sender, EventArgs e) { }

        private async Task AddProduct(string name, string description, decimal price, int stock, string barcode, DateTime created_at)
        {
            var category_id = (int)cmbCategory.SelectedValue;
            var product = new Product
            {
                name = name,
                description = description,
                price = price,
                stock = stock,
                barcode = barcode,
                created_at = created_at,
                category_id = category_id
            };

            var json = JsonSerializer.Serialize(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            try
            {
                var response = await client.PostAsync("http://localhost:8000/products/add_product", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataInTableInventory();
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string description = textDescription.Text.Trim();
            decimal price;
            int stock;
            string barcode = textBarCode.Text.Trim();
            DateTime created_at = DateTime.Now;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(barcode) ||
                !decimal.TryParse(textPrice.Text, out price) || !int.TryParse(textStock.Text, out stock))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await AddProduct(name, description, price, stock, barcode, created_at);
        }

        private void textBarCode_TextChanged(object sender, EventArgs e)
        {
            if (!barcodeCompleted && textBarCode.Text.Length == 3)
            {
                Random rnd = new Random();
                string randomDigits = rnd.Next(100000, 999999).ToString(); 
                textBarCode.Text += randomDigits;
                textBarCode.SelectionStart = textBarCode.Text.Length;
                barcodeCompleted = true;
            }

            if (textBarCode.Text.Length < 3)
            {
                barcodeCompleted = false;
            }
        }
        private void LoadStaticCategories()
        {
            var categories = new List<Category>
            {
            new Category { id = 1, name = "Bebidas" },
            new Category { id = 2, name = "Snacks" },
            new Category { id = 3, name = "Carnes" },
            new Category { id = 4, name = "Helados" },
            new Category { id = 5, name = "Enlatados"}
            };

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
        }

    }
}
