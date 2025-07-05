using System.Runtime.InteropServices;
using System.Windows.Forms; // Corregido
using Dashboard;
using postsys.Forms;
using Timer = System.Windows.Forms.Timer; // Este es el correcto

namespace postsys
{
    public partial class Form1 : Form
    {
        private int borderSize = 2;

        // Botón activo y colores
        private Button botonActivo = null;
        private readonly Color colorNormal = Color.FromArgb(26, 211, 238);
        private readonly Color colorHover = Color.FromArgb(0, 153, 204);
        private readonly Color colorActivo = Color.FromArgb(0, 102, 153);

        // Animación
        private Dictionary<Button, Timer> animaciones = new();
        private readonly int duracionAnimacion = 8;

        public Form1()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(34, 211, 238);
            this.Load += Form1_Load;
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
                return;
            base.WndProc(ref m);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "  " + btn.Tag?.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        // Open the forms when buttons are clicked
        private void btnSales_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSales);
            OpenForm(new Sales());
        }

        private void btnClientForm_Click(object sender, EventArgs e)
        {
            ActiveButton(btnClientForm);
            OpenForm(new ClientForm());
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            ActiveButton(btnUserForm);
            OpenForm(new UserForm());
        }
        private void iconInventory_Click(object sender, EventArgs e)
        {
            ActiveButton(btnInventory);
            OpenForm(new Inventory());
        }


        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm(Form form)
        {
            if (panelDesktop.Controls.Count > 0)
                panelDesktop.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.Show();
        }

        // Animations 
        private void AnimationColor(Button btn, Color destino)
        {
            if (animaciones.ContainsKey(btn))
            {
                animaciones[btn].Stop();
                animaciones.Remove(btn);
            }

            Timer t = new Timer();
            int paso = 0;
            Color origen = btn.BackColor;
            t.Interval = 15;

            t.Tick += (s, e) =>
            {
                paso++;
                float porc = paso / (float)duracionAnimacion;
                if (porc >= 1)
                {
                    btn.BackColor = destino;
                    t.Stop();
                    animaciones.Remove(btn);
                }
                else
                {
                    btn.BackColor = ColorAnimationHelper.Lerp(origen, destino, porc);
                }
            };

            animaciones[btn] = t;
            t.Start();
        }

        private void StandButtonMenu(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn != botonActivo)
                AnimationColor(btn, colorHover);
        }

        private void RestoreColorMenu(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn != botonActivo)
                AnimationColor(btn, colorNormal);
        }

        private void ActiveButton(Button btn)
        {
            foreach (Button b in panelMenu.Controls.OfType<Button>())
            {
                if (b != btn)
                    AnimationColor(b, colorNormal);
            }
            botonActivo = btn;
            AnimationColor(btn, colorActivo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button btn in panelMenu.Controls.OfType<Button>())
            {
                btn.MouseEnter += StandButtonMenu;
                btn.MouseLeave += RestoreColorMenu;
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ActiveButton(btnInvoice);
            OpenForm(new Invoice());
        }
    }

    public static class ColorAnimationHelper
    {
        public static Color Lerp(Color from, Color to, float amount)
        {
            int r = (int)(from.R + (to.R - from.R) * amount);
            int g = (int)(from.G + (to.G - from.G) * amount);
            int b = (int)(from.B + (to.B - from.B) * amount);
            return Color.FromArgb(r, g, b);
        }
    }
}
