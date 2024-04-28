using System;

namespace CalculadoradeCuotas
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
            this.txtmont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcuo = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmont
            // 
            this.txtmont.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmont.Location = new System.Drawing.Point(398, 63);
            this.txtmont.Margin = new System.Windows.Forms.Padding(4);
            this.txtmont.Name = "txtmont";
            this.txtmont.Size = new System.Drawing.Size(132, 22);
            this.txtmont.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto";
            // 
            // txtint
            // 
            this.txtint.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtint.Location = new System.Drawing.Point(398, 124);
            this.txtint.Margin = new System.Windows.Forms.Padding(4);
            this.txtint.Name = "txtint";
            this.txtint.Size = new System.Drawing.Size(132, 22);
            this.txtint.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interes %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuotas";
            // 
            // txtcuo
            // 
            this.txtcuo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcuo.Location = new System.Drawing.Point(398, 189);
            this.txtcuo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcuo.Name = "txtcuo";
            this.txtcuo.Size = new System.Drawing.Size(132, 22);
            this.txtcuo.TabIndex = 5;
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalc.Location = new System.Drawing.Point(401, 256);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(129, 70);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.Btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtcuo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmont);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Desafio 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 

        #endregion

        private System.Windows.Forms.TextBox txtmont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcuo;
        private System.Windows.Forms.Button btncalc;
    }
}