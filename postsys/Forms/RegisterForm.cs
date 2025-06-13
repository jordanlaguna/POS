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
using Dashboard;

namespace postsys.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private async Task RegisterAsync(DateTime birth_date, string identification, string name, string lastName, string secondName, string telephone, string email, string password)
        {
            var registerData = new
            {
                birth_date = birth_date.ToString("yyyy-MM-dd"),
                identification = identification.ToString(),
                name = name,
                lastName = lastName,
                secondName = secondName,
                telephone = telephone.ToString(),
                email = email,
                password = password
            };

            var json = JsonSerializer.Serialize(registerData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            try
            {
                var response = await client.PostAsync("http://localhost:8000/persons/register", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario: " + responseBody, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Login loginForm = new Login(); ;
            loginForm.Show();
            this.Hide();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime bith_date = dateTimePicker1.Value;
            string identification = textIdentification.Text;
            string name = textName.Text;
            string lastName = textLastName.Text;
            string secondName = textSecondName.Text;
            string telephone = textTelephone.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await RegisterAsync(bith_date, identification, name, lastName, secondName, telephone, email, password);

        }
    }
}
