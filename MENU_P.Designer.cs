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
            lbl_Reloj = new Label();
            txt_Codigo = new TextBox();
            lbl_estado = new Label();
            txt_Nombre = new Label();
            SuspendLayout();
            // 
            // lbl_Reloj
            // 
            lbl_Reloj.AutoSize = true;
            lbl_Reloj.BackColor = Color.Black;
            lbl_Reloj.BorderStyle = BorderStyle.FixedSingle;
            lbl_Reloj.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Reloj.ForeColor = Color.Lime;
            lbl_Reloj.Location = new Point(450, 9);
            lbl_Reloj.Name = "lbl_Reloj";
            lbl_Reloj.Size = new Size(527, 137);
            lbl_Reloj.TabIndex = 0;
            lbl_Reloj.Text = "00:00:00";
            lbl_Reloj.Click += label1_Click;
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.White;
            txt_Codigo.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Codigo.Location = new Point(358, 158);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(532, 78);
            txt_Codigo.TabIndex = 2;
            txt_Codigo.TextAlign = HorizontalAlignment.Center;
            txt_Codigo.TextChanged += txt_Codigo_TextChanged;
            txt_Codigo.KeyDown += txt_Codigo_KeyDown;
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.FromArgb(224, 224, 224);
            lbl_estado.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_estado.Location = new Point(544, 508);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(0, 70);
            lbl_estado.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Nombre.Location = new Point(12, 298);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(1250, 180);
            txt_Nombre.TabIndex = 4;
            txt_Nombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // MENU_P
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1287, 617);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_estado);
            Controls.Add(txt_Codigo);
            Controls.Add(lbl_Reloj);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MENU_P";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE ASISTENCIA";
            Load += MENU_P_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Reloj;
        private TextBox txt_Codigo;
        private Label lbl_estado;
        private Label txt_Nombre;
    }
}
