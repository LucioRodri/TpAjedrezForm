
namespace TpAjedrezForm
{
    partial class Tablero
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
            this.btn_proximoTablero = new System.Windows.Forms.Button();
            this.btn_fatales = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tablero:";
            // 
            // btn_proximoTablero
            // 
            this.btn_proximoTablero.Location = new System.Drawing.Point(12, 570);
            this.btn_proximoTablero.Name = "btn_proximoTablero";
            this.btn_proximoTablero.Size = new System.Drawing.Size(219, 61);
            this.btn_proximoTablero.TabIndex = 1;
            this.btn_proximoTablero.Text = "Proximo Tablero";
            this.btn_proximoTablero.UseVisualStyleBackColor = true;
            this.btn_proximoTablero.Click += new System.EventHandler(this.btn_proximoTablero_Click);
            // 
            // btn_fatales
            // 
            this.btn_fatales.Location = new System.Drawing.Point(265, 570);
            this.btn_fatales.Name = "btn_fatales";
            this.btn_fatales.Size = new System.Drawing.Size(219, 61);
            this.btn_fatales.TabIndex = 2;
            this.btn_fatales.Text = "Mostrar Casillas Fatales";
            this.btn_fatales.UseVisualStyleBackColor = true;
            this.btn_fatales.Click += new System.EventHandler(this.btn_fatales_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(856, 570);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(219, 61);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 643);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_fatales);
            this.Controls.Add(this.btn_proximoTablero);
            this.Controls.Add(this.label1);
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.Load += new System.EventHandler(this.Tablero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proximoTablero;
        private System.Windows.Forms.Button btn_fatales;
        private System.Windows.Forms.Button btn_exit;
    }
}