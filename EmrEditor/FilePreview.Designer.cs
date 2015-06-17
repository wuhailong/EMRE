namespace EmrEditor
{
    partial class FilePreview
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
            this.wb_preview = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wb_preview
            // 
            this.wb_preview.Location = new System.Drawing.Point(145, 12);
            this.wb_preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_preview.Name = "wb_preview";
            this.wb_preview.Size = new System.Drawing.Size(719, 706);
            this.wb_preview.TabIndex = 0;
            // 
            // FilePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.wb_preview);
            this.Name = "FilePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预览";
            this.Load += new System.EventHandler(this.FilePreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_preview;
    }
}