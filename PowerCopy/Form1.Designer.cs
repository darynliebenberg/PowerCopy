namespace PowerCopy
{
    partial class PowerCopyForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourceButton = new System.Windows.Forms.Button();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SourceButton
            // 
            this.SourceButton.Location = new System.Drawing.Point(24, 21);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(75, 23);
            this.SourceButton.TabIndex = 0;
            this.SourceButton.Text = "Source";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // DestinationButton
            // 
            this.DestinationButton.Location = new System.Drawing.Point(293, 21);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(75, 23);
            this.DestinationButton.TabIndex = 1;
            this.DestinationButton.Text = "Destination";
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.DestinationButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(152, 76);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copy!";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PowerCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 151);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DestinationButton);
            this.Controls.Add(this.SourceButton);
            this.Name = "PowerCopyForm";
            this.Text = "PowerCopy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CopyButton;
    }
}

