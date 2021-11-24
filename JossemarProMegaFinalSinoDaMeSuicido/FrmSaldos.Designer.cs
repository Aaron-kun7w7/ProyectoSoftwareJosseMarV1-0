﻿namespace JossemarProMegaFinalSinoDaMeSuicido
{
    partial class FrmSaldos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMensual = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDiario = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHoy = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDev = new System.Windows.Forms.Label();
            this.PnlBarraSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.LblIdUsuario = new System.Windows.Forms.Label();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensual)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PnlBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMensual);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo Mensual";
            // 
            // dgvMensual
            // 
            this.dgvMensual.BackgroundColor = System.Drawing.Color.White;
            this.dgvMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensual.Location = new System.Drawing.Point(6, 19);
            this.dgvMensual.Name = "dgvMensual";
            this.dgvMensual.Size = new System.Drawing.Size(215, 265);
            this.dgvMensual.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDiario);
            this.groupBox2.Location = new System.Drawing.Point(294, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo Diario";
            // 
            // dgvDiario
            // 
            this.dgvDiario.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiario.Location = new System.Drawing.Point(6, 19);
            this.dgvDiario.Name = "dgvDiario";
            this.dgvDiario.Size = new System.Drawing.Size(215, 265);
            this.dgvDiario.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblHoy);
            this.groupBox3.Location = new System.Drawing.Point(587, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 108);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ganancias de hoy";
            // 
            // lblHoy
            // 
            this.lblHoy.AutoSize = true;
            this.lblHoy.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHoy.Location = new System.Drawing.Point(31, 30);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(216, 56);
            this.lblHoy.TabIndex = 0;
            this.lblHoy.Text = "C$ 0.000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDev);
            this.groupBox4.Location = new System.Drawing.Point(587, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Devoluciones";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.lblDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDev.Location = new System.Drawing.Point(31, 22);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(216, 56);
            this.lblDev.TabIndex = 1;
            this.lblDev.Text = "C$ 0.000";
            // 
            // PnlBarraSuperior
            // 
            this.PnlBarraSuperior.Controls.Add(this.LblIdUsuario);
            this.PnlBarraSuperior.Controls.Add(this.BtnSalir);
            this.PnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraSuperior.FillColor = System.Drawing.Color.Gray;
            this.PnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraSuperior.Name = "PnlBarraSuperior";
            this.PnlBarraSuperior.ShadowDecoration.Parent = this.PnlBarraSuperior;
            this.PnlBarraSuperior.Size = new System.Drawing.Size(942, 31);
            this.PnlBarraSuperior.TabIndex = 5;
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.AutoSize = true;
            this.LblIdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblIdUsuario.Location = new System.Drawing.Point(495, 9);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(13, 13);
            this.LblIdUsuario.TabIndex = 65;
            this.LblIdUsuario.Text = "a";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FillColor = System.Drawing.Color.Gray;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(897, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ShadowDecoration.Parent = this.BtnSalir;
            this.BtnSalir.Size = new System.Drawing.Size(45, 31);
            this.BtnSalir.TabIndex = 0;
            // 
            // FrmSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 376);
            this.Controls.Add(this.PnlBarraSuperior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaldos";
            this.Text = "FrmSaldos";
            this.Load += new System.EventHandler(this.FrmSaldos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensual)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PnlBarraSuperior.ResumeLayout(false);
            this.PnlBarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMensual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDiario;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.Label lblDev;
        private Guna.UI2.WinForms.Guna2Panel PnlBarraSuperior;
        private System.Windows.Forms.Label LblIdUsuario;
        private Guna.UI2.WinForms.Guna2ControlBox BtnSalir;
    }
}