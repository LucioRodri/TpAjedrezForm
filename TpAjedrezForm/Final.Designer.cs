
namespace TpAjedrezForm
{
    partial class Final
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
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(12, 494);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(216, 75);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Text = "Volver al Menu Principal";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(721, 494);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(216, 75);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 581);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_menu);
            this.Name = "Final";
            this.Text = "Final";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_exit;
    }
}