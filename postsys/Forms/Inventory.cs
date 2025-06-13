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
        private const string BaseURL = "http://localhost:8000/";
        private const string ProductsEndpoint = $"{BaseURL}products";
        private const string CategoriesEndpoint = $"{BaseURL}categories";

        public Inventory()
        {
            InitializeComponent();
            LoadDataInTableInventory();
            LoadDynamicCategories();
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
                var response = await client.GetAsync($"{ProductsEndpoint}/products_list");
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

        public async Task LoadDataInTableInventory()
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
                var response = await client.PostAsync($"{ProductsEndpoint}/add_product", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataInTableInventory();
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
        private async Task<List<Category>> GetAllCategories()
        {
            using var client = new HttpClient();
            try
            {
                using var response = await client.GetAsync($"{CategoriesEndpoint}/categories_list");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var categories = JsonSerializer.Deserialize<List<Category>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return categories ?? new List<Category>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Category>();
            }
        }
        private async Task LoadDynamicCategories()
        {
            cmbCategory.DataSource = await GetAllCategories();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
        }

        private async Task AddCategorie(string name)
        {
            var category = new Category
            {
                name = name
            };
            var json = JsonSerializer.Serialize(category);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            try
            {
                var response = await client.PostAsync($"{CategoriesEndpoint}/register_category", content);
                var responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Categoría agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDynamicCategories();
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoría: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnAddCategories_Click(object sender, EventArgs e)
        {
            string categoryName = textCategories.Text.Trim();
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Por favor, ingrese un nombre de categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await AddCategorie(categoryName);
            textCategories.Clear();

        }
    }
}
