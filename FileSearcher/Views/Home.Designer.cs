namespace FileSearcher
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(88, 94);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(133, 29);
            BtnBuscar.TabIndex = 0;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += this.BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(30, 38);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(421, 34);
            TxtBuscar.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(259, 94);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 2;
            button1.Text = "Configuración";
            button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 170);
            Controls.Add(button1);
            Controls.Add(TxtBuscar);
            Controls.Add(BtnBuscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscar;
        private TextBox TxtBuscar;
        private Button button1;
    }
}
