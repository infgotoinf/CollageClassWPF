namespace _03._5_Clicker
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            label5 = new Label();
            hScrollBar2 = new HScrollBar();
            label3 = new Label();
            label2 = new Label();
            hScrollBar1 = new HScrollBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 372);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Images";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(768, 344);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(hScrollBar2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(hScrollBar1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(280, 200);
            label4.Name = "label4";
            label4.Size = new Size(24, 30);
            label4.TabIndex = 6;
            label4.Text = "5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(34, 200);
            label5.Name = "label5";
            label5.Size = new Size(240, 30);
            label5.TabIndex = 5;
            label5.Text = "Second count for a click:";
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new Point(34, 240);
            hScrollBar2.Maximum = 60;
            hScrollBar2.Minimum = 1;
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(676, 21);
            hScrollBar2.TabIndex = 4;
            hScrollBar2.Value = 5;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(207, 63);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 3;
            label3.Text = "1:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 2;
            label2.Text = "Timer start value:";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(34, 103);
            hScrollBar1.Maximum = 300;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(676, 21);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Value = 60;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 65);
            label1.TabIndex = 1;
            label1.Text = "0:00";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer2;
        private HScrollBar hScrollBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private HScrollBar hScrollBar2;
    }
}
