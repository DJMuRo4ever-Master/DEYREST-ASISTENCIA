using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using ATTEDEYV.Models;
using ATTEDEYV.Services;

namespace ATTEDEYV
{
    public partial class MENU_P : Form
    {
        DatabaseService databaseService = new DatabaseService();

        public MENU_P()
        {
            InitializeComponent();
        }

        private void MENU_P_Load(object sender, EventArgs e)
        {
            string cliente = "default"; // Podrías cargar esto desde archivo o base de datos
            string rutaFondo = Path.Combine(Application.StartupPath, "Fondos", cliente + ".jpg");

            if (File.Exists(rutaFondo))
            {
                this.BackgroundImage = Image.FromFile(rutaFondo);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Puedes cambiar a Zoom o Center
            }
            else
            {
                // Si no hay fondo, lo dejamos sin imagen o con un color de fondo
                this.BackgroundImage = null;
                this.BackColor = Color.DarkGray;
            }
            CargarFuenteDigital();
            timer_Reloj.Start();
            CentrarControl(lbl_estado, this);
            CentrarControl(lbl_Reloj, this);
            CentrarControl(txt_Apellidos, this);
            CentrarControl(txt_Codigo, this);
            CentrarControl(txt_Nombres, this);
        }

        PrivateFontCollection pfc = new PrivateFontCollection();

        private void CargarFuenteDigital()
        {
            using (Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ATTEDEYV.Resources.digital-7.ttf"))
            {
                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, (int)fontStream.Length);

                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                pfc.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);
            }

            lbl_Reloj.Font = new Font(pfc.Families[0], 72, FontStyle.Bold);
        }
        private void CentrarControl(Control ctrl, Form form)
        {
            // Medir el texto con la fuente del control
            Size textoSize = TextRenderer.MeasureText(ctrl.Text, ctrl.Font);

            // Cambiar el tamaño si el control lo permite (como Label)
            if (ctrl is Label || ctrl is Button)
            {
                ctrl.Width = textoSize.Width;
            }
            else if (ctrl is TextBox)
            {
                // En TextBox puede que no quieras cambiar el ancho, opcional
                // ctrl.Width = textoSize.Width + 10; // con padding si deseas
            }

            // Centrar horizontalmente dentro del formulario
            ctrl.Left = (form.ClientSize.Width - ctrl.Width) / 2;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarCodigo();
                e.Handled = true;
                e.SuppressKeyPress = true; // Evita el sonido del Enter
            }

        }
        private void ValidarCodigo()
        {
            if (string.IsNullOrWhiteSpace(txt_Codigo.Text))
            {
                MessageBox.Show("Por favor, ingresa un código.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Codigo.Text = "";
                txt_Codigo.Focus();
                fallaRegistro();
                return;
            }
            else
            {
                Persona persona = databaseService.ObtenerNombrePorDNI(txt_Codigo.Text);
                if (persona.Nombres == "" && persona.Apellidos == "")
                {
                    txt_Apellidos.Text = "DNI O CARNÉ";
                    txt_Nombres.Text = "NO IDENTIFICADO";
                    txt_Codigo.Text = "";
                    txt_Nombres.Text = "";
                    txt_Apellidos.Text = "";
                    txt_Codigo.Focus();
                    fallaRegistro();
                }
                else
                {
                    txt_Codigo.Text = "";
                    txt_Codigo.Focus();
                    txt_Apellidos.Text = persona.Apellidos;
                    txt_Nombres.Text = persona.Nombres;
                    CentrarControl(txt_Apellidos, this);
                    CentrarControl(txt_Nombres, this);
                    lbl_estado.Text = "ACCESO CORRECTO";
                    lbl_estado.ForeColor = Color.Green;
                    CentrarControl(lbl_estado, this);
                    return;

                }
            }

            // Aquí va tu lógica para procesar el código
            //ProcesarCodigo(txt_Codigo.Text);
        }

        private void fallaRegistro()
        {
            lbl_estado.Text = "ACCESO FALLIDO";
            lbl_estado.ForeColor = Color.Red;
            CentrarControl(lbl_estado, this);
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Reloj_Tick(object sender, EventArgs e)
        {
            lbl_Reloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
