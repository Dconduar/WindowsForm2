using System;

namespace CalculadoraCapitalFinal
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
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblcap = new System.Windows.Forms.Label();
            this.lblinte = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lblperi = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.btmcalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(444, 70);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(132, 22);
            this.txtCapital.TabIndex = 0;
            // 
            // lblcap
            // 
            this.lblcap.AutoSize = true;
            this.lblcap.Location = new System.Drawing.Point(456, 50);
            this.lblcap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcap.Name = "lblcap";
            this.lblcap.Size = new System.Drawing.Size(86, 16);
            this.lblcap.TabIndex = 1;
            this.lblcap.Text = "Capital Inicial";
            this.lblcap.Click += new System.EventHandler(this.lblcap_Click);
            // 
            // lblinte
            // 
            this.lblinte.AutoSize = true;
            this.lblinte.Location = new System.Drawing.Point(476, 108);
            this.lblinte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinte.Name = "lblinte";
            this.lblinte.Size = new System.Drawing.Size(62, 16);
            this.lblinte.TabIndex = 2;
            this.lblinte.Text = "Interes %";
            this.lblinte.Click += new System.EventHandler(this.lblinte_Click);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(443, 128);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(132, 22);
            this.txtInteres.TabIndex = 3;
            // 
            // lblperi
            // 
            this.lblperi.AutoSize = true;
            this.lblperi.Location = new System.Drawing.Point(456, 199);
            this.lblperi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblperi.Name = "lblperi";
            this.lblperi.Size = new System.Drawing.Size(106, 16);
            this.lblperi.TabIndex = 4;
            this.lblperi.Text = "Periodo en años";
            this.lblperi.Click += new System.EventHandler(this.lblperi_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(444, 219);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(132, 22);
            this.txtPeriodo.TabIndex = 5;
            // 
            // btmcalc
            // 
            this.btmcalc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btmcalc.Location = new System.Drawing.Point(443, 273);
            this.btmcalc.Margin = new System.Windows.Forms.Padding(4);
            this.btmcalc.Name = "btmcalc";
            this.btmcalc.Size = new System.Drawing.Size(133, 57);
            this.btmcalc.TabIndex = 6;
            this.btmcalc.Text = "Calcular";
            this.btmcalc.UseVisualStyleBackColor = false;
            this.btmcalc.Click += new System.EventHandler(this.btmcalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btmcalc);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblperi);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.lblinte);
            this.Controls.Add(this.lblcap);
            this.Controls.Add(this.txtCapital);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblperi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblinte_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblcap_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lblcap;
        private System.Windows.Forms.Label lblinte;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblperi;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Button btmcalc;
    }
}
