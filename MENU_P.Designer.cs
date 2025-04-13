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
            components = new System.ComponentModel.Container();
            lbl_Reloj = new Label();
            txt_Codigo = new TextBox();
            lbl_estado = new Label();
            txt_Apellidos = new Label();
            txt_Nombres = new Label();
            timer_Reloj = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl_Reloj
            // 
            lbl_Reloj.BackColor = Color.Black;
            lbl_Reloj.BorderStyle = BorderStyle.FixedSingle;
            lbl_Reloj.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Reloj.ForeColor = Color.Lime;
            lbl_Reloj.Location = new Point(450, 9);
            lbl_Reloj.Name = "lbl_Reloj";
            lbl_Reloj.Size = new Size(419, 110);
            lbl_Reloj.TabIndex = 0;
            lbl_Reloj.Text = "00:00:00";
            lbl_Reloj.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Reloj.Click += label1_Click;
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.White;
            txt_Codigo.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Codigo.Location = new Point(358, 158);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(532, 64);
            txt_Codigo.TabIndex = 2;
            txt_Codigo.TextAlign = HorizontalAlignment.Center;
            txt_Codigo.TextChanged += txt_Codigo_TextChanged;
            txt_Codigo.KeyDown += txt_Codigo_KeyDown;
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.WhiteSmoke;
            lbl_estado.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_estado.Location = new Point(544, 508);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(0, 56);
            lbl_estado.TabIndex = 3;
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.BackColor = Color.WhiteSmoke;
            txt_Apellidos.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Apellidos.Location = new Point(12, 249);
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(1250, 85);
            txt_Apellidos.TabIndex = 4;
            txt_Apellidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Nombres
            // 
            txt_Nombres.BackColor = Color.WhiteSmoke;
            txt_Nombres.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Nombres.Location = new Point(12, 353);
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(1250, 85);
            txt_Nombres.TabIndex = 6;
            txt_Nombres.TextAlign = ContentAlignment.MiddleCenter;
            txt_Nombres.Click += label2_Click;
            // 
            // timer_Reloj
            // 
            timer_Reloj.Enabled = true;
            timer_Reloj.Interval = 1000;
            timer_Reloj.Tick += timer_Reloj_Tick;
            // 
            // MENU_P
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1287, 617);
            Controls.Add(txt_Nombres);
            Controls.Add(txt_Apellidos);
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
        private Label txt_Apellidos;
        private Label txt_Nombres;
        private System.Windows.Forms.Timer timer_Reloj;
    }
}
