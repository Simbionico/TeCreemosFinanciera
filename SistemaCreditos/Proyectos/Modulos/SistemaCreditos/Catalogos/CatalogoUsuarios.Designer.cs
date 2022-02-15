
namespace SistemaCreditos
{
    partial class frmCatalogoUsuarios
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
            this.lbNombreCatalogo = new System.Windows.Forms.Label();
            this.dgvCatalogoUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombreCatalogo
            // 
            this.lbNombreCatalogo.AutoSize = true;
            this.lbNombreCatalogo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCatalogo.Location = new System.Drawing.Point(20, 20);
            this.lbNombreCatalogo.Name = "lbNombreCatalogo";
            this.lbNombreCatalogo.Size = new System.Drawing.Size(327, 45);
            this.lbNombreCatalogo.TabIndex = 0;
            this.lbNombreCatalogo.Text = "Catalogo de usuarios";
            // 
            // dgvCatalogoUsuarios
            // 
            this.dgvCatalogoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoUsuarios.Location = new System.Drawing.Point(30, 70);
            this.dgvCatalogoUsuarios.Name = "dgvCatalogoUsuarios";
            this.dgvCatalogoUsuarios.ReadOnly = true;
            this.dgvCatalogoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoUsuarios.Size = new System.Drawing.Size(670, 300);
            this.dgvCatalogoUsuarios.TabIndex = 1;
            this.dgvCatalogoUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogoUsuarios_CellClick);
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
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCatalogoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCatalogoUsuarios);
            this.Controls.Add(this.lbNombreCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCatalogoUsuarios";
            this.Text = "CatalogoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreCatalogo;
        private System.Windows.Forms.DataGridView dgvCatalogoUsuarios;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}