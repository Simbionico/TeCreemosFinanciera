
namespace SistemaCreditos
{
    partial class frmPanelCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelCentral));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnTransacciones = new FontAwesome.Sharp.IconButton();
            this.ibtnCuentas = new FontAwesome.Sharp.IconButton();
            this.ibtnUsuario = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.pnlMenu.Controls.Add(this.ibtnTransacciones);
            this.pnlMenu.Controls.Add(this.ibtnCuentas);
            this.pnlMenu.Controls.Add(this.ibtnUsuario);
            this.pnlMenu.Controls.Add(this.ibtnHome);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 666);
            this.pnlMenu.TabIndex = 0;
            // 
            // ibtnTransacciones
            // 
            this.ibtnTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTransacciones.FlatAppearance.BorderSize = 0;
            this.ibtnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTransacciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTransacciones.ForeColor = System.Drawing.SystemColors.Window;
            this.ibtnTransacciones.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.ibtnTransacciones.IconColor = System.Drawing.SystemColors.Window;
            this.ibtnTransacciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTransacciones.IconSize = 30;
            this.ibtnTransacciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTransacciones.Location = new System.Drawing.Point(0, 150);
            this.ibtnTransacciones.Name = "ibtnTransacciones";
            this.ibtnTransacciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnTransacciones.Size = new System.Drawing.Size(150, 50);
            this.ibtnTransacciones.TabIndex = 6;
            this.ibtnTransacciones.Text = "Depositos y retiros";
            this.ibtnTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTransacciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTransacciones.UseVisualStyleBackColor = true;
            this.ibtnTransacciones.Click += new System.EventHandler(this.ibtnTransacciones_Click);
            // 
            // ibtnCuentas
            // 
            this.ibtnCuentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCuentas.FlatAppearance.BorderSize = 0;
            this.ibtnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCuentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCuentas.ForeColor = System.Drawing.SystemColors.Window;
            this.ibtnCuentas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtnCuentas.IconColor = System.Drawing.SystemColors.Window;
            this.ibtnCuentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCuentas.IconSize = 30;
            this.ibtnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCuentas.Location = new System.Drawing.Point(0, 100);
            this.ibtnCuentas.Name = "ibtnCuentas";
            this.ibtnCuentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnCuentas.Size = new System.Drawing.Size(150, 50);
            this.ibtnCuentas.TabIndex = 5;
            this.ibtnCuentas.Text = "Cuentas";
            this.ibtnCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCuentas.UseVisualStyleBackColor = true;
            this.ibtnCuentas.Click += new System.EventHandler(this.ibtnCuentas_Click);
            // 
            // ibtnUsuario
            // 
            this.ibtnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnUsuario.FlatAppearance.BorderSize = 0;
            this.ibtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.ibtnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibtnUsuario.IconColor = System.Drawing.SystemColors.Window;
            this.ibtnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUsuario.IconSize = 30;
            this.ibtnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUsuario.Location = new System.Drawing.Point(0, 50);
            this.ibtnUsuario.Name = "ibtnUsuario";
            this.ibtnUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnUsuario.Size = new System.Drawing.Size(150, 50);
            this.ibtnUsuario.TabIndex = 4;
            this.ibtnUsuario.Text = "Usuarios";
            this.ibtnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUsuario.UseVisualStyleBackColor = true;
            this.ibtnUsuario.Click += new System.EventHandler(this.ibtnUsuario_Click);
            // 
            // ibtnHome
            // 
            this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHome.ForeColor = System.Drawing.SystemColors.Window;
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnHome.IconColor = System.Drawing.SystemColors.Window;
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.IconSize = 30;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.Location = new System.Drawing.Point(0, 0);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnHome.Size = new System.Drawing.Size(150, 50);
            this.ibtnHome.TabIndex = 3;
            this.ibtnHome.Text = "Inicio";
            this.ibtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHome.UseVisualStyleBackColor = true;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.pnlHeader.Controls.Add(this.pbxLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(147, 44);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(150, 50);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(730, 500);
            this.pnlBody.TabIndex = 4;
            // 
            // frmPanelCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.MaximizeBox = false;
            this.Name = "frmPanelCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de creditos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPanelCentral_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private FontAwesome.Sharp.IconButton ibtnTransacciones;
        private FontAwesome.Sharp.IconButton ibtnCuentas;
        private FontAwesome.Sharp.IconButton ibtnUsuario;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private System.Windows.Forms.Panel pnlBody;
    }
}