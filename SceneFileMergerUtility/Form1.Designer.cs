namespace SceneFileMergerUtility
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ofdscene = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic;
            pictureBox1.Location = new Point(24, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(386, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(386, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(461, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 67);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 3;
            label1.Text = "Source Scene file to mod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 172);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 4;
            label2.Text = "Destination Scene file";
            // 
            // button1
            // 
            button1.Location = new Point(865, 88);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 5;
            button1.Text = "Browse!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(865, 192);
            button2.Name = "button2";
            button2.Size = new Size(131, 30);
            button2.TabIndex = 6;
            button2.Text = "Browse!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(567, 256);
            button3.Name = "button3";
            button3.Size = new Size(237, 81);
            button3.TabIndex = 7;
            button3.Text = "Merge!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ofdscene
            // 
            ofdscene.FileName = "openFileDialog";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 369);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "SceneFileMergerUtility";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog ofdscene;
        private OpenFileDialog openFileDialog1;
    }
}
