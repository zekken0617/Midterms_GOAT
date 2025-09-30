namespace MainForm
{
    partial class OrderingApp
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
            girl = new GroupBox();
            g3 = new CheckBox();
            g2 = new CheckBox();
            g1 = new CheckBox();
            girlrbt = new RadioButton();
            berry = new GroupBox();
            b4 = new CheckBox();
            b3 = new CheckBox();
            b2 = new CheckBox();
            b1 = new CheckBox();
            berryrbt = new RadioButton();
            minionrbt = new RadioButton();
            minion = new GroupBox();
            m3 = new CheckBox();
            m2 = new CheckBox();
            m1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label12 = new Label();
            DisplayPictureBox = new PictureBox();
            textBox3 = new TextBox();
            label13 = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            button2 = new Button();
            girl.SuspendLayout();
            berry.SuspendLayout();
            minion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // girl
            // 
            girl.BackgroundImageLayout = ImageLayout.None;
            girl.Controls.Add(g3);
            girl.Controls.Add(g2);
            girl.Controls.Add(g1);
            girl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            girl.Location = new Point(562, 411);
            girl.Name = "girl";
            girl.RightToLeft = RightToLeft.No;
            girl.Size = new Size(200, 117);
            girl.TabIndex = 38;
            girl.TabStop = false;
            girl.Text = "I'm Just a Girl";
            // 
            // g3
            // 
            g3.AutoSize = true;
            g3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g3.Location = new Point(20, 82);
            g3.Name = "g3";
            g3.Size = new Size(94, 19);
            g3.TabIndex = 2;
            g3.Text = "Matcha Berry";
            g3.UseVisualStyleBackColor = true;
            // 
            // g2
            // 
            g2.AutoSize = true;
            g2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g2.Location = new Point(20, 57);
            g2.Name = "g2";
            g2.Size = new Size(97, 19);
            g2.TabIndex = 1;
            g2.Text = "Lucky Charms";
            g2.UseVisualStyleBackColor = true;
            // 
            // g1
            // 
            g1.AutoSize = true;
            g1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g1.Location = new Point(20, 31);
            g1.Name = "g1";
            g1.RightToLeft = RightToLeft.No;
            g1.Size = new Size(138, 19);
            g1.TabIndex = 0;
            g1.Text = "Strawberry Cheesecake";
            g1.UseVisualStyleBackColor = true;
            // 
            // girlrbt
            // 
            girlrbt.AutoSize = true;
            girlrbt.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            girlrbt.Location = new Point(265, 190);
            girlrbt.Name = "girlrbt";
            girlrbt.Size = new Size(93, 19);
            girlrbt.TabIndex = 41;
            girlrbt.TabStop = true;
            girlrbt.Text = "I'm Just a Girl";
            girlrbt.UseVisualStyleBackColor = true;
            girlrbt.CheckedChanged += girlrbt_CheckedChanged;
            // 
            // berry
            // 
            berry.BackgroundImageLayout = ImageLayout.None;
            berry.Controls.Add(b4);
            berry.Controls.Add(b3);
            berry.Controls.Add(b2);
            berry.Controls.Add(b1);
            berry.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            berry.Location = new Point(562, 256);
            berry.Name = "berry";
            berry.RightToLeft = RightToLeft.No;
            berry.Size = new Size(200, 137);
            berry.TabIndex = 37;
            berry.TabStop = false;
            berry.Text = "I Love U Berry Much";
            // 
            // b4
            // 
            b4.AutoSize = true;
            b4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b4.Location = new Point(20, 107);
            b4.Name = "b4";
            b4.Size = new Size(94, 19);
            b4.TabIndex = 3;
            b4.Text = "Matcha Berry";
            b4.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.AutoSize = true;
            b3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3.Location = new Point(20, 82);
            b3.Name = "b3";
            b3.Size = new Size(79, 19);
            b3.TabIndex = 2;
            b3.Text = "Taro Berry";
            b3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2.Location = new Point(20, 57);
            b2.Name = "b2";
            b2.Size = new Size(96, 19);
            b2.TabIndex = 1;
            b2.Text = "Blended Berry";
            b2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1.Location = new Point(20, 31);
            b1.Name = "b1";
            b1.RightToLeft = RightToLeft.No;
            b1.Size = new Size(108, 19);
            b1.TabIndex = 0;
            b1.Text = "Raspberry Berry";
            b1.UseVisualStyleBackColor = true;
            // 
            // berryrbt
            // 
            berryrbt.AutoSize = true;
            berryrbt.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            berryrbt.Location = new Point(265, 165);
            berryrbt.Name = "berryrbt";
            berryrbt.Size = new Size(131, 19);
            berryrbt.TabIndex = 40;
            berryrbt.TabStop = true;
            berryrbt.Text = "I Love U Berry Much";
            berryrbt.UseVisualStyleBackColor = true;
            berryrbt.CheckedChanged += berryrbt_CheckedChanged;
            // 
            // minionrbt
            // 
            minionrbt.AutoSize = true;
            minionrbt.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minionrbt.Location = new Point(265, 140);
            minionrbt.Name = "minionrbt";
            minionrbt.Size = new Size(137, 19);
            minionrbt.TabIndex = 39;
            minionrbt.TabStop = true;
            minionrbt.Text = "MINION SEASONAL";
            minionrbt.UseVisualStyleBackColor = true;
            minionrbt.CheckedChanged += minionrbt_CheckedChanged;
            // 
            // minion
            // 
            minion.BackgroundImageLayout = ImageLayout.None;
            minion.Controls.Add(m3);
            minion.Controls.Add(m2);
            minion.Controls.Add(m1);
            minion.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minion.Location = new Point(562, 122);
            minion.Name = "minion";
            minion.RightToLeft = RightToLeft.No;
            minion.Size = new Size(200, 117);
            minion.TabIndex = 36;
            minion.TabStop = false;
            minion.Text = "MINION SEASONAL";
            // 
            // m3
            // 
            m3.AutoSize = true;
            m3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m3.Location = new Point(20, 82);
            m3.Name = "m3";
            m3.Size = new Size(96, 19);
            m3.TabIndex = 2;
            m3.Text = "Birthday Cake";
            m3.UseVisualStyleBackColor = true;
            // 
            // m2
            // 
            m2.AutoSize = true;
            m2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m2.Location = new Point(20, 57);
            m2.Name = "m2";
            m2.Size = new Size(124, 19);
            m2.TabIndex = 1;
            m2.Text = "Nutella and Bananas";
            m2.UseVisualStyleBackColor = true;
            // 
            // m1
            // 
            m1.AutoSize = true;
            m1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m1.Location = new Point(20, 31);
            m1.Name = "m1";
            m1.Size = new Size(124, 19);
            m1.TabIndex = 0;
            m1.Text = "Reese's and Bananas";
            m1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 122);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 35;
            label2.Text = "Food order choices:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 64);
            label1.Name = "label1";
            label1.Size = new Size(268, 24);
            label1.TabIndex = 34;
            label1.Text = "ZEKKE Food Ordering Application";
            // 
            // button1
            // 
            button1.Location = new Point(223, 543);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 59;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(247, 402);
            label12.Name = "label12";
            label12.Size = new Size(38, 30);
            label12.TabIndex = 66;
            label12.Text = "Order \r\nImage:";
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Image = Properties.Resources.white;
            DisplayPictureBox.Location = new Point(307, 340);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(161, 163);
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayPictureBox.TabIndex = 65;
            DisplayPictureBox.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 301);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 64;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(247, 304);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 63;
            label13.Text = "Discount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 62;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(247, 275);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 61;
            label14.Text = "Price:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(223, 243);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(77, 15);
            label15.TabIndex = 60;
            label15.Text = "Order Details";
            // 
            // button2
            // 
            button2.Location = new Point(307, 543);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 67;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderingApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 667);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(DisplayPictureBox);
            Controls.Add(textBox3);
            Controls.Add(label13);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(button1);
            Controls.Add(girl);
            Controls.Add(girlrbt);
            Controls.Add(berry);
            Controls.Add(berryrbt);
            Controls.Add(minionrbt);
            Controls.Add(minion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderingApp";
            Text = "OrderingApp";
            Load += OrderingApp_Load;
            girl.ResumeLayout(false);
            girl.PerformLayout();
            berry.ResumeLayout(false);
            berry.PerformLayout();
            minion.ResumeLayout(false);
            minion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox girl;
        private CheckBox g3;
        private CheckBox g2;
        private CheckBox g1;
        private RadioButton girlrbt;
        private GroupBox berry;
        private CheckBox b4;
        private CheckBox b3;
        private CheckBox b2;
        private CheckBox b1;
        private RadioButton berryrbt;
        private RadioButton minionrbt;
        private GroupBox minion;
        private CheckBox m3;
        private CheckBox m2;
        private CheckBox m1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label12;
        private PictureBox DisplayPictureBox;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox1;
        private Label label14;
        private Label label15;
        private Button button2;
    }
}