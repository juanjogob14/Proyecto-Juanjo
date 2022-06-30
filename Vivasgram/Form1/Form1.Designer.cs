
namespace Form1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblContrasenha = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.txtpuerto = new System.Windows.Forms.TextBox();
            this.lblwip = new System.Windows.Forms.Label();
            this.lblwport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 340);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(12, 369);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(283, 22);
            this.txtMensaje.TabIndex = 1;
            this.txtMensaje.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(313, 369);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(90, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(97, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(54, 308);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(103, 23);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(235, 308);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(74, 349);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(97, 98);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(177, 22);
            this.txtPass.TabIndex = 2;
            // 
            // lblContrasenha
            // 
            this.lblContrasenha.AutoSize = true;
            this.lblContrasenha.Location = new System.Drawing.Point(21, 98);
            this.lblContrasenha.Name = "lblContrasenha";
            this.lblContrasenha.Size = new System.Drawing.Size(69, 17);
            this.lblContrasenha.TabIndex = 9;
            this.lblContrasenha.Text = "Password";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(24, 152);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(19, 17);
            this.lblIp.TabIndex = 10;
            this.lblIp.Text = "Ip";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(24, 202);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(50, 17);
            this.lblPuerto.TabIndex = 11;
            this.lblPuerto.Text = "Puerto";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(97, 149);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(177, 22);
            this.txtip.TabIndex = 12;
            // 
            // txtpuerto
            // 
            this.txtpuerto.Location = new System.Drawing.Point(97, 199);
            this.txtpuerto.Name = "txtpuerto";
            this.txtpuerto.Size = new System.Drawing.Size(177, 22);
            this.txtpuerto.TabIndex = 13;
            // 
            // lblwip
            // 
            this.lblwip.AutoSize = true;
            this.lblwip.Location = new System.Drawing.Point(294, 152);
            this.lblwip.Name = "lblwip";
            this.lblwip.Size = new System.Drawing.Size(0, 17);
            this.lblwip.TabIndex = 14;
            // 
            // lblwport
            // 
            this.lblwport.AutoSize = true;
            this.lblwport.Location = new System.Drawing.Point(297, 201);
            this.lblwport.Name = "lblwport";
            this.lblwport.Size = new System.Drawing.Size(0, 17);
            this.lblwport.TabIndex = 15;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(423, 403);
            this.Controls.Add(this.lblwport);
            this.Controls.Add(this.lblwip);
            this.Controls.Add(this.txtpuerto);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblContrasenha);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Log-in Vivasgram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblContrasenha;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtpuerto;
        private System.Windows.Forms.Label lblwip;
        private System.Windows.Forms.Label lblwport;
    }
}

