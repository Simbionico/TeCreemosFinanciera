
namespace SistemaCreditos.Gestores
{
    partial class frmAltaTransacciones
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
            this.cbxCuentas = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblSaldoCredito = new System.Windows.Forms.Label();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.cbxTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.lblTipoTransaccion = new System.Windows.Forms.Label();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAgregar = new CustomControls.Controls.CustomButton();
            this.btnCancelar = new CustomControls.Controls.CustomButton();
            this.lblErrorCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCuentas
            // 
            this.cbxCuentas.FormattingEnabled = true;
            this.cbxCuentas.Location = new System.Drawing.Point(20, 85);
            this.cbxCuentas.Name = "cbxCuentas";
            this.cbxCuentas.Size = new System.Drawing.Size(265, 21);
            this.cbxCuentas.TabIndex = 32;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(20, 66);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 31;
            this.lblCuenta.Text = "Cuenta";
            // 
            // lblSaldoCredito
            // 
            this.lblSaldoCredito.AutoSize = true;
            this.lblSaldoCredito.Location = new System.Drawing.Point(20, 129);
            this.lblSaldoCredito.Name = "lblSaldoCredito";
            this.lblSaldoCredito.Size = new System.Drawing.Size(37, 13);
            this.lblSaldoCredito.TabIndex = 34;
            this.lblSaldoCredito.Text = "Monto";
            // 
            // txbMonto
            // 
            this.txbMonto.Location = new System.Drawing.Point(20, 148);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(265, 20);
            this.txbMonto.TabIndex = 33;
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblErrorMonto.Location = new System.Drawing.Point(20, 171);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(85, 13);
            this.lblErrorMonto.TabIndex = 35;
            this.lblErrorMonto.Text = "mensaje de error";
            this.lblErrorMonto.Visible = false;
            // 
            // cbxTipoTransaccion
            // 
            this.cbxTipoTransaccion.FormattingEnabled = true;
            this.cbxTipoTransaccion.Location = new System.Drawing.Point(20, 213);
            this.cbxTipoTransaccion.Name = "cbxTipoTransaccion";
            this.cbxTipoTransaccion.Size = new System.Drawing.Size(265, 21);
            this.cbxTipoTransaccion.TabIndex = 37;
            // 
            // lblTipoTransaccion
            // 
            this.lblTipoTransaccion.AutoSize = true;
            this.lblTipoTransaccion.Location = new System.Drawing.Point(20, 194);
            this.lblTipoTransaccion.Name = "lblTipoTransaccion";
            this.lblTipoTransaccion.Size = new System.Drawing.Size(86, 13);
            this.lblTipoTransaccion.TabIndex = 36;
            this.lblTipoTransaccion.Text = "Tipo transacción";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(20, 35);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(265, 21);
            this.cbxUsuario.TabIndex = 43;
            this.cbxUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxUsuario_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(161, 252);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 40);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(35, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 40);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblErrorCuenta
            // 
            this.lblErrorCuenta.AutoSize = true;
            this.lblErrorCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblErrorCuenta.Location = new System.Drawing.Point(20, 106);
            this.lblErrorCuenta.Name = "lblErrorCuenta";
            this.lblErrorCuenta.Size = new System.Drawing.Size(85, 13);
            this.lblErrorCuenta.TabIndex = 44;
            this.lblErrorCuenta.Text = "mensaje de error";
            this.lblErrorCuenta.Visible = false;
            // 
            // frmAltaTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(304, 322);
            this.Controls.Add(this.lblErrorCuenta);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbxTipoTransaccion);
            this.Controls.Add(this.lblTipoTransaccion);
            this.Controls.Add(this.lblErrorMonto);
            this.Controls.Add(this.lblSaldoCredito);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.cbxCuentas);
            this.Controls.Add(this.lblCuenta);
            this.Name = "frmAltaTransacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de transacciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCuentas;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblSaldoCredito;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label lblErrorMonto;
        private System.Windows.Forms.ComboBox cbxTipoTransaccion;
        private System.Windows.Forms.Label lblTipoTransaccion;
        private CustomControls.Controls.CustomButton btnAgregar;
        private CustomControls.Controls.CustomButton btnCancelar;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblErrorCuenta;
    }
}