
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using postsys;
using postsys.Forms;
using postsys.model;
using postsys.services;
using static System.Windows.Forms.DataFormats;

namespace Dashboard
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }
        private async Task LoginAsync(string email, string password)
        {
            var loginData = new
            {
                email = email,
                password = password
            };

            var json = JsonSerializer.Serialize(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            try
            {
                var response = await client.PostAsync("http://localhost:8000/users/login", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var loginResult = JsonSerializer.Deserialize<LoginResponse>(responseBody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    // save the access token and user ID in the AuthSession
                    AuthSession.AccessToken = loginResult.access_token;
                    AuthSession.UserId = loginResult.user_id;

                    MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 v = new Form1();
                    v.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            /*MySqlConnection conn = ConexionDB.ConexionDB.GetConnection();


            string email, password;
            email = txtEmail.Text;
            password = txtPassword.Text;

            string sql = "select email, password from user where email = '" + email + "' AND password = '" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 v = new Form1();
                v.Show();
                this.Hide();
                v.SetEmail(txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Usuario no existe ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } */

            string email = txtEmail.Text;
            string password = txtPassword.Text;
            await LoginAsync(email, password);

        }

        private void lblOpenFormRegister_Click(object sender, EventArgs e)
        {
            RegisterForm v = new RegisterForm();
            v.Show();
            this.Hide();
        }
    }
}
