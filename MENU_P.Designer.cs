namespace ATTEDEYV
{
    partial class MENU_P
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_P));
            lbl_Reloj = new Label();
            txt_Nombre = new TextBox();
            txt_Codigo = new TextBox();
            lbl_estado = new Label();
            SuspendLayout();
            // 
            // lbl_Reloj
            // 
            lbl_Reloj.AutoSize = true;
            lbl_Reloj.BackColor = Color.Black;
            lbl_Reloj.BorderStyle = BorderStyle.FixedSingle;
            lbl_Reloj.Font = new Font("Digital-7", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Reloj.ForeColor = Color.Lime;
            lbl_Reloj.Location = new Point(450, 9);
            lbl_Reloj.Name = "lbl_Reloj";
            lbl_Reloj.Size = new Size(346, 101);
            lbl_Reloj.TabIndex = 0;
            lbl_Reloj.Text = "00:00:00";
            lbl_Reloj.Click += label1_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.FromArgb(224, 224, 224);
            txt_Nombre.Enabled = false;
            txt_Nombre.Font = new Font("Consolas", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Nombre.Location = new Point(12, 257);
            txt_Nombre.Multiline = true;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.ReadOnly = true;
            txt_Nombre.Size = new Size(1248, 233);
            txt_Nombre.TabIndex = 1;
            txt_Nombre.Text = "DEYVID JORDAN MUÑOZ ROMERO";
            txt_Nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.White;
            txt_Codigo.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Codigo.Location = new Point(349, 158);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.ReadOnly = true;
            txt_Codigo.Size = new Size(532, 64);
            txt_Codigo.TabIndex = 2;
            txt_Codigo.KeyDown += txt_Codigo_KeyDown;
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.FromArgb(224, 224, 224);
            lbl_estado.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_estado.Location = new Point(544, 508);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(154, 56);
            lbl_estado.TabIndex = 3;
            lbl_estado.Text = "12345";
            // 
            // MENU_P
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 617);
            Controls.Add(lbl_estado);
            Controls.Add(txt_Codigo);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Reloj);
            Font = new Font("Digital-7", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MENU_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE ASISTENCIA";
            Load += MENU_P_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Reloj;
        private TextBox txt_Nombre;
        private TextBox txt_Codigo;
        private Label lbl_estado;
    }
}
