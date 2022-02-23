
namespace Pizzeria
{
    partial class Form1
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
            this.button1_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Menu
            // 
            this.button1_Menu.Location = new System.Drawing.Point(346, 195);
            this.button1_Menu.Name = "button1_Menu";
            this.button1_Menu.Size = new System.Drawing.Size(137, 63);
            this.button1_Menu.TabIndex = 0;
            this.button1_Menu.Text = "Menüválaszték";
            this.button1_Menu.UseVisualStyleBackColor = true;
            this.button1_Menu.Click += new System.EventHandler(this.button1_Menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Menu;
    }
}

