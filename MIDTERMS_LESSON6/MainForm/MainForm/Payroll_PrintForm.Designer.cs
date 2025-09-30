namespace MainForm
{
    partial class Payroll_PrintForm
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
            priDisplayListbox = new ListBox();
            SuspendLayout();
            // 
            // priDisplayListbox
            // 
            priDisplayListbox.FormattingEnabled = true;
            priDisplayListbox.ItemHeight = 15;
            priDisplayListbox.Location = new Point(12, 12);
            priDisplayListbox.Name = "priDisplayListbox";
            priDisplayListbox.Size = new Size(451, 619);
            priDisplayListbox.TabIndex = 1;
            // 
            // Payroll_PrintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 641);
            Controls.Add(priDisplayListbox);
            Name = "Payroll_PrintForm";
            Text = "Payroll_PrintForm";
            Load += Payroll_PrintForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox priDisplayListbox;
    }
}