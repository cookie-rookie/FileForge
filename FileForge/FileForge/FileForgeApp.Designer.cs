using System.Windows.Forms;

namespace FileForge
{
    partial class FileForgeApp
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label newSizeLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.newSizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.resizeButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(10, 10);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(300, 22);
            this.filePathTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(325, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click_1);
            // 
            // newSizeLabel
            // 
            this.newSizeLabel.Location = new System.Drawing.Point(10, 40);
            this.newSizeLabel.Name = "newSizeLabel";
            this.newSizeLabel.Size = new System.Drawing.Size(75, 23);
            this.newSizeLabel.TabIndex = 2;
            this.newSizeLabel.Text = "New Size:";
            this.newSizeLabel.Click += new System.EventHandler(this.newSizeLabel_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(91, 38);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.sizeTextBox.TabIndex = 3;
            // 
            // resizeButton
            // 
            this.resizeButton.Location = new System.Drawing.Point(274, 38);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(75, 23);
            this.resizeButton.TabIndex = 4;
            this.resizeButton.Text = "Resize";
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(10, 80);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.Visible = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(10, 110);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bytes",
            "KB",
            "MB",
            "GB"});
            this.comboBox1.Location = new System.Drawing.Point(197, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FileForgeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 123);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.newSizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.encryptButton);
            this.Name = "FileForgeApp";
            this.Text = "FileForge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox comboBox1;
    }
}
