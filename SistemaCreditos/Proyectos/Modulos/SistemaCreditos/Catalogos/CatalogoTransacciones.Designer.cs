
namespace SistemaCreditos
{
    partial class frmCatalogoTransacciones
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
            this.dgvCatalogoTransacciones = new System.Windows.Forms.DataGridView();
            this.lbNombreCatalogo = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogoTransacciones
            // 
            this.dgvCatalogoTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoTransacciones.Location = new System.Drawing.Point(30, 70);
            this.dgvCatalogoTransacciones.Name = "dgvCatalogoTransacciones";
            this.dgvCatalogoTransacciones.ReadOnly = true;
            this.dgvCatalogoTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoTransacciones.Size = new System.Drawing.Size(670, 300);
            this.dgvCatalogoTransacciones.TabIndex = 4;
            this.dgvCatalogoTransacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogoTransacciones_CellClick);
            // 
            // lbNombreCatalogo
            // 
            this.lbNombreCatalogo.AutoSize = true;
            this.lbNombreCatalogo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCatalogo.Location = new System.Drawing.Point(20, 20);
            this.lbNombreCatalogo.Name = "lbNombreCatalogo";
            this.lbNombreCatalogo.Size = new System.Drawing.Size(392, 45);
            this.lbNombreCatalogo.TabIndex = 3;
            this.lbNombreCatalogo.Text = "Registro de transacciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(650, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 51);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCatalogoTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCatalogoTransacciones);
            this.Controls.Add(this.lbNombreCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCatalogoTransacciones";
            this.Text = "CatalogoTransacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.DataGridView dgvCatalogoTransacciones;
        private System.Windows.Forms.Label lbNombreCatalogo;
    }
}