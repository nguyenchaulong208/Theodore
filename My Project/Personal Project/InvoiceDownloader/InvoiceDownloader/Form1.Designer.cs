namespace InvoiceDownloader
{
	partial class InvoiceDownloader
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
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_matracuu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tải hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 101);
            this.textBox1.TabIndex = 1;
            // 
            // lb_matracuu
            // 
            this.lb_matracuu.AllowDrop = true;
            this.lb_matracuu.AutoEllipsis = true;
            this.lb_matracuu.AutoSize = true;
            this.lb_matracuu.Location = new System.Drawing.Point(238, 109);
            this.lb_matracuu.Name = "lb_matracuu";
            this.lb_matracuu.Padding = new System.Windows.Forms.Padding(20);
            this.lb_matracuu.Size = new System.Drawing.Size(98, 53);
            this.lb_matracuu.TabIndex = 2;
            this.lb_matracuu.Text = "Mã tra cứu";
            // 
            // InvoiceDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1021, 576);
            this.Controls.Add(this.lb_matracuu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "InvoiceDownloader";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_matracuu;
    }
}

