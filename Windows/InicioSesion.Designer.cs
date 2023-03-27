namespace Windows
{
    partial class InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdorn_nombre = new System.Windows.Forms.Label();
            this.pbdorn_imgUser = new System.Windows.Forms.PictureBox();
            this.tbdorn_pin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbdorn_imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdorn_nombre
            // 
            this.lbdorn_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdorn_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbdorn_nombre.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdorn_nombre.ForeColor = System.Drawing.Color.White;
            this.lbdorn_nombre.Location = new System.Drawing.Point(281, 167);
            this.lbdorn_nombre.Name = "lbdorn_nombre";
            this.lbdorn_nombre.Size = new System.Drawing.Size(240, 44);
            this.lbdorn_nombre.TabIndex = 2;
            this.lbdorn_nombre.Text = "Usuario";
            this.lbdorn_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbdorn_imgUser
            // 
            this.pbdorn_imgUser.BackColor = System.Drawing.Color.Transparent;
            this.pbdorn_imgUser.Image = global::Windows.Properties.Resources.pngegg;
            this.pbdorn_imgUser.Location = new System.Drawing.Point(352, 69);
            this.pbdorn_imgUser.Name = "pbdorn_imgUser";
            this.pbdorn_imgUser.Size = new System.Drawing.Size(100, 95);
            this.pbdorn_imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdorn_imgUser.TabIndex = 3;
            this.pbdorn_imgUser.TabStop = false;
            // 
            // tbdorn_pin
            // 
            this.tbdorn_pin.Location = new System.Drawing.Point(376, 232);
            this.tbdorn_pin.Name = "tbdorn_pin";
            this.tbdorn_pin.PlaceholderText = "Pin";
            this.tbdorn_pin.Size = new System.Drawing.Size(100, 23);
            this.tbdorn_pin.TabIndex = 4;
            this.tbdorn_pin.UseSystemPasswordChar = true;
            this.tbdorn_pin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbdorn_pin_KeyDown);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows.Properties.Resources.img102;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbdorn_pin);
            this.Controls.Add(this.pbdorn_imgUser);
            this.Controls.Add(this.lbdorn_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbdorn_imgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbdorn_nombre;
        private PictureBox pbdorn_imgUser;
        private TextBox tbdorn_pin;
    }
}