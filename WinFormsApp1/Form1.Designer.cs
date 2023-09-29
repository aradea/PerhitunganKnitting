namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox_inci = new TextBox();
            textBox_get = new TextBox();
            button1 = new Button();
            textBox_hasil = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox_inci
            // 
            textBox_inci.Location = new Point(56, 38);
            textBox_inci.Name = "textBox_inci";
            textBox_inci.Size = new Size(100, 23);
            textBox_inci.TabIndex = 0;
            textBox_inci.Text = "0";
            textBox_inci.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox_get
            // 
            textBox_get.Location = new Point(56, 70);
            textBox_get.Name = "textBox_get";
            textBox_get.Size = new Size(100, 23);
            textBox_get.TabIndex = 1;
            textBox_get.Text = "0";
            textBox_get.TextChanged += textBox2_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(192, 425);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox_hasil
            // 
            textBox_hasil.Location = new Point(56, 109);
            textBox_hasil.Name = "textBox_hasil";
            textBox_hasil.Size = new Size(100, 23);
            textBox_hasil.TabIndex = 4;
            textBox_hasil.Text = "0";
            textBox_hasil.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 5;
            label1.Text = "Inc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 6;
            label2.Text = "Get";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Hasil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_hasil);
            Controls.Add(button1);
            Controls.Add(textBox_get);
            Controls.Add(textBox_inci);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AsepKnitt";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_inci;
        private TextBox textBox_get;
        private Button button1;
        private TextBox textBox_hasil;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}