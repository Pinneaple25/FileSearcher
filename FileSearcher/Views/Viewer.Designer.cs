namespace FileSearcher.Views
{
    partial class Viewer
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
            web1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)web1).BeginInit();
            SuspendLayout();
            // 
            // web1
            // 
            web1.AllowExternalDrop = true;
            web1.CreationProperties = null;
            web1.DefaultBackgroundColor = Color.White;
            web1.Dock = DockStyle.Fill;
            web1.Location = new Point(0, 0);
            web1.Name = "web1";
            web1.Size = new Size(800, 450);
            web1.Source = new Uri("file:///C:/Users/calbe/OneDrive/Documents/%2311F500.pdf", UriKind.Absolute);
            web1.TabIndex = 2;
            web1.ZoomFactor = 1D;
            // 
            // Viewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(web1);
            Name = "Viewer";
            Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)web1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 web1;
    }
}