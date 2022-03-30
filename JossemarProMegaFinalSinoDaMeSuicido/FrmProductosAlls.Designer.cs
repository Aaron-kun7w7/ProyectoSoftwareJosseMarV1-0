namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmProductosAlls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBarraSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GbxAgregarProv = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DgvProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DgvCaducidad = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GbxNum = new System.Windows.Forms.GroupBox();
            this.LblNombreFull = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnListo = new Guna.UI2.WinForms.Guna2Button();
            this.PnlBarraSuperior.SuspendLayout();
            this.GbxAgregarProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCaducidad)).BeginInit();
            this.GbxNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBarraSuperior
            // 
            this.PnlBarraSuperior.Controls.Add(this.BtnSalir);
            this.PnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraSuperior.FillColor = System.Drawing.Color.Transparent;
            this.PnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.PnlBarraSuperior.Name = "PnlBarraSuperior";
            this.PnlBarraSuperior.ShadowDecoration.Parent = this.PnlBarraSuperior;
            this.PnlBarraSuperior.Size = new System.Drawing.Size(1260, 38);
            this.PnlBarraSuperior.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FillColor = System.Drawing.Color.Red;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1200, 0);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ShadowDecoration.Parent = this.BtnSalir;
            this.BtnSalir.Size = new System.Drawing.Size(60, 38);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GbxAgregarProv
            // 
            this.GbxAgregarProv.Controls.Add(this.DgvProductos);
            this.GbxAgregarProv.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.GbxAgregarProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxAgregarProv.ForeColor = System.Drawing.Color.Black;
            this.GbxAgregarProv.Location = new System.Drawing.Point(0, 46);
            this.GbxAgregarProv.Margin = new System.Windows.Forms.Padding(4);
            this.GbxAgregarProv.Name = "GbxAgregarProv";
            this.GbxAgregarProv.ShadowDecoration.Parent = this.GbxAgregarProv;
            this.GbxAgregarProv.Size = new System.Drawing.Size(1936, 510);
            this.GbxAgregarProv.TabIndex = 7;
            this.GbxAgregarProv.Text = "Lotes";
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.DgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProductos.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProductos.EnableHeadersVisualStyles = false;
            this.DgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvProductos.Location = new System.Drawing.Point(0, 44);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProductos.MultiSelect = false;
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersVisible = false;
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(1260, 462);
            this.DgvProductos.TabIndex = 68;
            this.DgvProductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DgvProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvProductos.ThemeStyle.HeaderStyle.Height = 21;
            this.DgvProductos.ThemeStyle.ReadOnly = true;
            this.DgvProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvProductos.ThemeStyle.RowsStyle.Height = 22;
            this.DgvProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellClick);
            this.DgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellDoubleClick);
            // 
            // DgvCaducidad
            // 
            this.DgvCaducidad.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvCaducidad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCaducidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCaducidad.BackgroundColor = System.Drawing.Color.White;
            this.DgvCaducidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCaducidad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCaducidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCaducidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCaducidad.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCaducidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvCaducidad.EnableHeadersVisualStyles = false;
            this.DgvCaducidad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCaducidad.Location = new System.Drawing.Point(4, 564);
            this.DgvCaducidad.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCaducidad.Name = "DgvCaducidad";
            this.DgvCaducidad.RowHeadersVisible = false;
            this.DgvCaducidad.RowHeadersWidth = 51;
            this.DgvCaducidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCaducidad.Size = new System.Drawing.Size(320, 46);
            this.DgvCaducidad.TabIndex = 8;
            this.DgvCaducidad.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DgvCaducidad.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCaducidad.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCaducidad.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCaducidad.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCaducidad.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCaducidad.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCaducidad.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCaducidad.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvCaducidad.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCaducidad.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvCaducidad.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCaducidad.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvCaducidad.ThemeStyle.HeaderStyle.Height = 4;
            this.DgvCaducidad.ThemeStyle.ReadOnly = false;
            this.DgvCaducidad.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCaducidad.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCaducidad.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DgvCaducidad.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCaducidad.ThemeStyle.RowsStyle.Height = 22;
            this.DgvCaducidad.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCaducidad.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCaducidad.Visible = false;
            // 
            // GbxNum
            // 
            this.GbxNum.Controls.Add(this.BtnListo);
            this.GbxNum.Controls.Add(this.LblNombreFull);
            this.GbxNum.Controls.Add(this.TxtCantidad);
            this.GbxNum.Location = new System.Drawing.Point(379, 581);
            this.GbxNum.Name = "GbxNum";
            this.GbxNum.Size = new System.Drawing.Size(462, 100);
            this.GbxNum.TabIndex = 9;
            this.GbxNum.TabStop = false;
            this.GbxNum.Visible = false;
            // 
            // LblNombreFull
            // 
            this.LblNombreFull.AutoSize = true;
            this.LblNombreFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreFull.Location = new System.Drawing.Point(71, 22);
            this.LblNombreFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreFull.Name = "LblNombreFull";
            this.LblNombreFull.Size = new System.Drawing.Size(139, 20);
            this.LblNombreFull.TabIndex = 57;
            this.LblNombreFull.Text = "Digite Cantidad";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(51, 46);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantidad.MaxLength = 30;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(177, 26);
            this.TxtCantidad.TabIndex = 58;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreFull_KeyPress);
            // 
            // BtnListo
            // 
            this.BtnListo.CheckedState.Parent = this.BtnListo;
            this.BtnListo.CustomImages.Parent = this.BtnListo;
            this.BtnListo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnListo.ForeColor = System.Drawing.Color.White;
            this.BtnListo.HoverState.Parent = this.BtnListo;
            this.BtnListo.Location = new System.Drawing.Point(247, 27);
            this.BtnListo.Name = "BtnListo";
            this.BtnListo.ShadowDecoration.Parent = this.BtnListo;
            this.BtnListo.Size = new System.Drawing.Size(175, 45);
            this.BtnListo.TabIndex = 59;
            this.BtnListo.Text = "Listo";
            this.BtnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // FrmProductosAlls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 693);
            this.Controls.Add(this.GbxNum);
            this.Controls.Add(this.DgvCaducidad);
            this.Controls.Add(this.GbxAgregarProv);
            this.Controls.Add(this.PnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductosAlls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductosAlls";
            this.Load += new System.EventHandler(this.FrmProductosAlls_Load);
            this.PnlBarraSuperior.ResumeLayout(false);
            this.GbxAgregarProv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCaducidad)).EndInit();
            this.GbxNum.ResumeLayout(false);
            this.GbxNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlBarraSuperior;
        private Guna.UI2.WinForms.Guna2ControlBox BtnSalir;
        private Guna.UI2.WinForms.Guna2GroupBox GbxAgregarProv;
        private Guna.UI2.WinForms.Guna2DataGridView DgvProductos;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCaducidad;
        private System.Windows.Forms.GroupBox GbxNum;
        private System.Windows.Forms.Label LblNombreFull;
        private System.Windows.Forms.TextBox TxtCantidad;
        private Guna.UI2.WinForms.Guna2Button BtnListo;
    }
}