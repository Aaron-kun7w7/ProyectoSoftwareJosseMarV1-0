namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.PnlBarraSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TxtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DgvInventario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalProductos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LblLeyenda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblSinStock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCantidadCaducado = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalSinstock = new System.Windows.Forms.Label();
            this.PnlBarraSuperior.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBarraSuperior
            // 
            this.PnlBarraSuperior.Controls.Add(this.BtnSalir);
            this.PnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraSuperior.FillColor = System.Drawing.Color.Gray;
            this.PnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraSuperior.Name = "PnlBarraSuperior";
            this.PnlBarraSuperior.ShadowDecoration.Parent = this.PnlBarraSuperior;
            this.PnlBarraSuperior.Size = new System.Drawing.Size(1386, 31);
            this.PnlBarraSuperior.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FillColor = System.Drawing.Color.Gray;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1341, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ShadowDecoration.Parent = this.BtnSalir;
            this.BtnSalir.Size = new System.Drawing.Size(45, 31);
            this.BtnSalir.TabIndex = 0;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderRadius = 15;
            this.TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.DefaultText = "";
            this.TxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscar.DisabledState.Parent = this.TxtBuscar;
            this.TxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.FocusedState.Parent = this.TxtBuscar;
            this.TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscar.HoverState.Parent = this.TxtBuscar;
            this.TxtBuscar.Location = new System.Drawing.Point(555, 48);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PlaceholderText = "";
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.ShadowDecoration.Parent = this.TxtBuscar;
            this.TxtBuscar.Size = new System.Drawing.Size(444, 39);
            this.TxtBuscar.TabIndex = 73;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.DgvInventario);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(189)))), ((int)(((byte)(180)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(5, 102);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1551, 457);
            this.guna2GroupBox2.TabIndex = 78;
            this.guna2GroupBox2.Text = "Inventario";
            // 
            // DgvInventario
            // 
            this.DgvInventario.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.DgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvInventario.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvInventario.EnableHeadersVisualStyles = false;
            this.DgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventario.Location = new System.Drawing.Point(0, 29);
            this.DgvInventario.Name = "DgvInventario";
            this.DgvInventario.ReadOnly = true;
            this.DgvInventario.RowHeadersVisible = false;
            this.DgvInventario.RowHeadersWidth = 51;
            this.DgvInventario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInventario.Size = new System.Drawing.Size(1551, 415);
            this.DgvInventario.TabIndex = 0;
            this.DgvInventario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvInventario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvInventario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvInventario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvInventario.ThemeStyle.HeaderStyle.Height = 32;
            this.DgvInventario.ThemeStyle.ReadOnly = true;
            this.DgvInventario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInventario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvInventario.ThemeStyle.RowsStyle.Height = 22;
            this.DgvInventario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventario_CellClick);
            this.DgvInventario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventario_CellContentDoubleClick);
            this.DgvInventario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvInventario_CellFormatting);
            this.DgvInventario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvInventario_CellPainting);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Productos:";
            // 
            // LblTotalProductos
            // 
            this.LblTotalProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalProductos.AutoSize = true;
            this.LblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalProductos.Location = new System.Drawing.Point(185, 19);
            this.LblTotalProductos.Name = "LblTotalProductos";
            this.LblTotalProductos.Size = new System.Drawing.Size(23, 25);
            this.LblTotalProductos.TabIndex = 2;
            this.LblTotalProductos.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblTotalProductos);
            this.groupBox1.Location = new System.Drawing.Point(352, 656);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 47);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Productos Caducados";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBuscar.Location = new System.Drawing.Point(503, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.PressedState.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(56, 39);
            this.BtnBuscar.TabIndex = 72;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblLeyenda
            // 
            this.LblLeyenda.AutoSize = true;
            this.LblLeyenda.Location = new System.Drawing.Point(153, 18);
            this.LblLeyenda.Name = "LblLeyenda";
            this.LblLeyenda.Size = new System.Drawing.Size(28, 13);
            this.LblLeyenda.TabIndex = 84;
            this.LblLeyenda.Text = "-------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblSinStock);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblLeyenda);
            this.groupBox2.Location = new System.Drawing.Point(12, 565);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 83);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            // 
            // LblSinStock
            // 
            this.LblSinStock.AutoSize = true;
            this.LblSinStock.Location = new System.Drawing.Point(153, 38);
            this.LblSinStock.Name = "LblSinStock";
            this.LblSinStock.Size = new System.Drawing.Size(28, 13);
            this.LblSinStock.TabIndex = 86;
            this.LblSinStock.Text = "-------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Productos Sin Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LblCantidadCaducado);
            this.groupBox3.Location = new System.Drawing.Point(624, 656);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 47);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Productos Caducados:";
            // 
            // LblCantidadCaducado
            // 
            this.LblCantidadCaducado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCantidadCaducado.AutoSize = true;
            this.LblCantidadCaducado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadCaducado.Location = new System.Drawing.Point(239, 16);
            this.LblCantidadCaducado.Name = "LblCantidadCaducado";
            this.LblCantidadCaducado.Size = new System.Drawing.Size(23, 25);
            this.LblCantidadCaducado.TabIndex = 2;
            this.LblCantidadCaducado.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.LblTotalSinstock);
            this.groupBox4.Location = new System.Drawing.Point(935, 656);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 47);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Productos Sin Stock:";
            // 
            // LblTotalSinstock
            // 
            this.LblTotalSinstock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalSinstock.AutoSize = true;
            this.LblTotalSinstock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSinstock.Location = new System.Drawing.Point(239, 16);
            this.LblTotalSinstock.Name = "LblTotalSinstock";
            this.LblTotalSinstock.Size = new System.Drawing.Size(23, 25);
            this.LblTotalSinstock.TabIndex = 2;
            this.LblTotalSinstock.Text = "0";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 722);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.PnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.PnlBarraSuperior.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlBarraSuperior;
        private Guna.UI2.WinForms.Guna2ControlBox BtnSalir;
        private Guna.UI2.WinForms.Guna2TextBox TxtBuscar;
        private Guna.UI2.WinForms.Guna2ImageButton BtnBuscar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView DgvInventario;
        private System.Windows.Forms.Label LblTotalProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblLeyenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblSinStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCantidadCaducado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotalSinstock;
    }
}