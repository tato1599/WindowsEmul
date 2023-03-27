namespace Windows
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbdorn_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbdorn_fecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdorn_hora
            // 
            this.lbdorn_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdorn_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbdorn_hora.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdorn_hora.ForeColor = System.Drawing.Color.White;
            this.lbdorn_hora.Location = new System.Drawing.Point(341, 94);
            this.lbdorn_hora.Name = "lbdorn_hora";
            this.lbdorn_hora.Size = new System.Drawing.Size(282, 116);
            this.lbdorn_hora.TabIndex = 0;
            this.lbdorn_hora.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbdorn_fecha
            // 
            this.lbdorn_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdorn_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbdorn_fecha.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdorn_fecha.ForeColor = System.Drawing.Color.White;
            this.lbdorn_fecha.Location = new System.Drawing.Point(341, 210);
            this.lbdorn_fecha.Name = "lbdorn_fecha";
            this.lbdorn_fecha.Size = new System.Drawing.Size(240, 44);
            this.lbdorn_fecha.TabIndex = 1;
            this.lbdorn_fecha.Text = "Lunes 27 de marzo";
            this.lbdorn_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackgroundImage = global::Windows.Properties.Resources.img102;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 575);
            this.Controls.Add(this.lbdorn_fecha);
            this.Controls.Add(this.lbdorn_hora);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbdorn_hora;
        private System.Windows.Forms.Timer timer1;
        private Label lbdorn_fecha;
    }
}