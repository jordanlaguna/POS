
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
using System.Xml.Linq;
using postsys.model;

namespace Dashboard
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            LoadDataInTableUsers();
            tableUsers.CellClick += tableUsers_CellClick;
        }
        private async Task<List<Person>> GetAllInformationPersons()
        {
            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync("http://localhost:8000/persons/persons_list");
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var personsList = JsonSerializer.Deserialize<List<Person>>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return personsList ?? new List<Person>();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Person>();
            }
        }
        private async void LoadDataInTableUsers()
        {
            var persons = await GetAllInformationPersons();
            tableUsers.DataSource = persons;
            tableUsers.Columns["id_user"].Visible = false;
            tableUsers.Columns["id_person"].Visible = false;



        }
        private async Task UpdatePerson()
        {
            int id_person = int.Parse(textBoxId.Text);
            Person person = new Person
            {
                identification = textBoxIdentification.Text,
                name = textBoxName.Text,
                lastName = txtLastName.Text,
                secondName = textBoxSecondName.Text,
                telephone = textBoxTelephone.Text,
                birth_date = dateTimePickerBirthDate.Value,
                email = textBoxEmail.Text
            };
            var json = JsonSerializer.Serialize(person);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();
            try
            {
                var response = await client.PutAsync($"http://localhost:8000/persons/update/{id_person}", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataInTableUsers();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdatePerson();
        }
        private void tableUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableUsers.Rows[e.RowIndex];
                textBoxId.Text = row.Cells["id_person"].Value?.ToString();
                textBoxIdentification.Text = row.Cells["ColumnIdentification"].Value?.ToString();
                textBoxName.Text = row.Cells["ColumnName"].Value?.ToString();
                txtLastName.Text = row.Cells["ColumnLastName"].Value?.ToString();
                textBoxSecondName.Text = row.Cells["ColumnSecondName"].Value?.ToString();
                textBoxTelephone.Text = row.Cells["ColumnTelephone"].Value?.ToString();
                dateTimePickerBirthDate.Value = row.Cells["ColumnBirthDate"].Value is DateTime date ? date : DateTime.Now;
                textBoxEmail.Text = row.Cells["ColumnEmail"].Value?.ToString();
            }
        }

        /*private void tableUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
{
   if (tableUsers.Columns[e.ColumnIndex].Name == "ColumnPassword")
   {
       if (e.Value != null)
       {
           string password = e.Value.ToString();
           e.Value = new string('*', password.Length);
           e.FormattingApplied = true;
       }
   }
}*/

    }
}
