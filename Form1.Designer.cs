namespace AnimeDownloader
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
            this.txtAnimeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutoDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnimeName
            // 
            this.txtAnimeName.Location = new System.Drawing.Point(54, 74);
            this.txtAnimeName.Name = "txtAnimeName";
            this.txtAnimeName.Size = new System.Drawing.Size(245, 20);
            this.txtAnimeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter anime name";
            // 
            // btnAutoDownload
            // 
            this.btnAutoDownload.Location = new System.Drawing.Point(374, 116);
            this.btnAutoDownload.Name = "btnAutoDownload";
            this.btnAutoDownload.Size = new System.Drawing.Size(75, 23);
            this.btnAutoDownload.TabIndex = 2;
            this.btnAutoDownload.Text = "download";
            this.btnAutoDownload.UseVisualStyleBackColor = true;
            this.btnAutoDownload.Click += new System.EventHandler(this.btnAutoDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutoDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnimeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnimeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutoDownload;
    }
}

