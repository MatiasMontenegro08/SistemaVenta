namespace PRESENTACION
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSistVent = new System.Windows.Forms.Label();
            this.ipbLogo = new FontAwesome.Sharp.IconPictureBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblNdocumento = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.ibtnIngresar = new FontAwesome.Sharp.IconButton();
            this.ibtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 236);
            this.label1.TabIndex = 0;
            // 
            // lblSistVent
            // 
            this.lblSistVent.AutoSize = true;
            this.lblSistVent.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSistVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistVent.ForeColor = System.Drawing.Color.White;
            this.lblSistVent.Location = new System.Drawing.Point(9, 165);
            this.lblSistVent.Name = "lblSistVent";
            this.lblSistVent.Size = new System.Drawing.Size(205, 24);
            this.lblSistVent.TabIndex = 1;
            this.lblSistVent.Text = "SISTEMA DE VENTAS";
            // 
            // ipbLogo
            // 
            this.ipbLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.ipbLogo.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.ipbLogo.IconColor = System.Drawing.Color.White;
            this.ipbLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbLogo.IconSize = 112;
            this.ipbLogo.Location = new System.Drawing.Point(49, 50);
            this.ipbLogo.Name = "ipbLogo";
            this.ipbLogo.Size = new System.Drawing.Size(128, 112);
            this.ipbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ipbLogo.TabIndex = 2;
            this.ipbLogo.TabStop = false;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(249, 50);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(252, 20);
            this.txtNumDoc.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(249, 104);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(252, 20);
            this.txtContrasenia.TabIndex = 4;
            // 
            // lblNdocumento
            // 
            this.lblNdocumento.AutoSize = true;
            this.lblNdocumento.Location = new System.Drawing.Point(246, 34);
            this.lblNdocumento.Name = "lblNdocumento";
            this.lblNdocumento.Size = new System.Drawing.Size(118, 13);
            this.lblNdocumento.TabIndex = 5;
            this.lblNdocumento.Text = "Número de documento:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(246, 88);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // ibtnIngresar
            // 
            this.ibtnIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.ibtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnIngresar.ForeColor = System.Drawing.Color.White;
            this.ibtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnIngresar.IconColor = System.Drawing.Color.White;
            this.ibtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnIngresar.IconSize = 21;
            this.ibtnIngresar.Location = new System.Drawing.Point(249, 152);
            this.ibtnIngresar.Name = "ibtnIngresar";
            this.ibtnIngresar.Size = new System.Drawing.Size(115, 37);
            this.ibtnIngresar.TabIndex = 7;
            this.ibtnIngresar.Text = "INGRESAR";
            this.ibtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnIngresar.UseVisualStyleBackColor = false;
            this.ibtnIngresar.Click += new System.EventHandler(this.ibtnIngresar_Click);
            // 
            // ibtnCancelar
            // 
            this.ibtnCancelar.BackColor = System.Drawing.Color.Magenta;
            this.ibtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCancelar.ForeColor = System.Drawing.Color.White;
            this.ibtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnCancelar.IconColor = System.Drawing.Color.White;
            this.ibtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCancelar.IconSize = 21;
            this.ibtnCancelar.Location = new System.Drawing.Point(386, 152);
            this.ibtnCancelar.Name = "ibtnCancelar";
            this.ibtnCancelar.Size = new System.Drawing.Size(115, 37);
            this.ibtnCancelar.TabIndex = 8;
            this.ibtnCancelar.Text = "CANCELAR";
            this.ibtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCancelar.UseVisualStyleBackColor = false;
            this.ibtnCancelar.Click += new System.EventHandler(this.ibtnCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 236);
            this.Controls.Add(this.ibtnCancelar);
            this.Controls.Add(this.ibtnIngresar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNdocumento);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.ipbLogo);
            this.Controls.Add(this.lblSistVent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ipbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSistVent;
        private FontAwesome.Sharp.IconPictureBox ipbLogo;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblNdocumento;
        private System.Windows.Forms.Label lblContraseña;
        private FontAwesome.Sharp.IconButton ibtnIngresar;
        private FontAwesome.Sharp.IconButton ibtnCancelar;
    }
}