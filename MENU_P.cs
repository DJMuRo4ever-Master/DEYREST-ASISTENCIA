using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ATTEDEYV
{
    public partial class MENU_P : Form
    {
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
            CentrarControl(lbl_estado, this);
            CentrarControl(lbl_Reloj, this);
            CentrarControl(txt_Nombre, this);
            CentrarControl(txt_Codigo, this);


            
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
    }
}
