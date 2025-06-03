namespace _02_WinForms_Beginning
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.flat_750x_075_f_pad_750x1000_f8f8f8;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("ProggyCleanTT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(354, 111);
            button1.Name = "button1";
            button1.Size = new Size(341, 139);
            button1.TabIndex = 0;
            button1.Text = "UwU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("SimSun", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(479, 45);
            label1.Name = "label1";
            label1.Size = new Size(160, 47);
            label1.TabIndex = 1;
            label1.Text = "UwUwni";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(85, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Cursor = Cursors.Cross;
            button2.FlatStyle = FlatStyle.System;
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(63, 78);
            button2.Name = "button2";
            button2.Size = new Size(158, 24);
            button2.TabIndex = 3;
            button2.Text = "Сказать привеееееееееет";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(189, 50);
            label2.TabIndex = 4;
            label2.Text = "привет, ";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.WaitCursor;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("ProggyVector", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(166, 257);
            button3.Name = "button3";
            button3.Size = new Size(200, 48);
            button3.TabIndex = 5;
            button3.Text = "и з м и н и т ь с в е т";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private Button button3;
    }
}
