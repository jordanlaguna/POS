
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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            LoadDataInTableUsers();
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
