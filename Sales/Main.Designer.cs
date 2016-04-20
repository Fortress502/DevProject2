namespace Sales
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Inventory Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddInventoryRecord);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit Inventory Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEditInventoryRecord);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "Check Inventory Level";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCheckStockLevel);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(463, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Generate Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnGenerateReport);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 457);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

