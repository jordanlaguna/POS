
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

namespace Dashboard
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            LoadDataInTableUsers();
            btnAgregar.Paint += btnAgregar_Paint;
            tableClients.CellClick += tableClients_CellClick;

        }

     

        private async Task<List<Client>> GetAllInformationClients()
        {
            using var client = new HttpClient();

            try
            {
                var response = await client.GetAsync("http://localhost:8000/clients/clients_list");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var clientList = JsonSerializer.Deserialize<List<Client>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return clientList ?? new List<Client>();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Client>();

            }
        }
        private async void LoadDataInTableUsers()
        {
            var clients = await GetAllInformationClients();
            tableClients.DataSource = null;
            tableClients.DataSource = clients;

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string identification = textIdentification.Text.Trim();
            string name = textName.Text.Trim();
            string last_name = textLastName.Text.Trim();
            string second_name = textSecondName.Text.Trim();
            string email = textEmail.Text.Trim();
            string telephoneText = textTelephone.Text.Trim();
            string address = textAddress.Text.Trim();
            DateTime register_date = dateTimeRegister.Value;

            // Validation of required fields
            if (string.IsNullOrEmpty(identification) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(last_name) ||
                string.IsNullOrEmpty(second_name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telephoneText) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation of telephone format
            if (!int.TryParse(telephoneText, out int telephoneInt))
            {
                MessageBox.Show("El teléfono debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await AddClient(identification, name, last_name, second_name, email, telephoneInt, address, register_date);
        }

        private async Task AddClient(string identification, string name, string last_name, string second_name, string email, int telephone, string address, DateTime register_date)
        {
            var clientData = new
            {
                identification,
                name,
                last_name,
                second_name,
                email,
                telephone,
                address,
                register_date = register_date.ToString("yyyy-MM-dd")
            };

            var json = JsonSerializer.Serialize(clientData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            try
            {
                var response = await client.PostAsync("http://localhost:8000/clients/register_client", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataInTableUsers();
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnAgregar.ClientRectangle,
                Color.DarkGreen, 3, ButtonBorderStyle.Solid,
                Color.DarkGreen, 3, ButtonBorderStyle.Solid,
                Color.DarkGreen, 3, ButtonBorderStyle.Solid,
                Color.DarkGreen, 3, ButtonBorderStyle.Solid);
        }


    

        private async Task UpdateClient()
        {
            int id_client = int.Parse(textBoxID.Text);
            Client clients = new Client
            {
                identification = textIdentification.Text.Trim(),
                name = textName.Text.Trim(),
                last_name = textLastName.Text.Trim(),
                second_name = textSecondName.Text.Trim(),
                email = textEmail.Text.Trim(),
                telephone = int.Parse(textTelephone.Text.Trim()),
                address = textAddress.Text.Trim(),
                register_date = dateTimeRegister.Value
            };
            var json = JsonSerializer.Serialize(clients);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            try
            {
                var response = await client.PutAsync($"http://localhost:8000/clients/update_client/{id_client}", content);
                var responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataInTableUsers();
                }
                else
                {
                    MessageBox.Show("Error al actualizar cliente: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private async void btnUpdateClient_Click(object sender, EventArgs e)
        {
            await UpdateClient();
        }

        private void tableClients_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tableClients.Rows.Count)
            {
                DataGridViewRow row = tableClients.Rows[e.RowIndex];
                textBoxID.Text = row.Cells["ColumnIdClient"].Value.ToString();
                textIdentification.Text = row.Cells["ColumnIdentification"].Value.ToString();
                textName.Text = row.Cells["ColumnName"].Value.ToString();
                textLastName.Text = row.Cells["ColumnLastName"].Value.ToString();
                textSecondName.Text = row.Cells["ColumnSecondName"].Value.ToString();
                textEmail.Text = row.Cells["ColumnEmail"].Value.ToString();
                textTelephone.Text = row.Cells["ColumnTelephone"].Value.ToString();
                textAddress.Text = row.Cells["ColumnAddress"].Value.ToString();
                dateTimeRegister.Value = Convert.ToDateTime(row.Cells["ColumnDate"].Value);
            }
        }
    }
}
