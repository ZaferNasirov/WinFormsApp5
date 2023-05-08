namespace WinFormsApp5
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(223, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 344);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(66, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 57);
            button1.TabIndex = 1;
            button1.Text = "Ad Elave et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(66, 263);
            button2.Name = "button2";
            button2.Size = new Size(94, 56);
            button2.TabIndex = 2;
            button2.Text = "Tip elave et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(66, 186);
            button3.Name = "button3";
            button3.Size = new Size(94, 55);
            button3.TabIndex = 4;
            button3.Text = "aciqlama elave et";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(522, 186);
            button4.Name = "button4";
            button4.Size = new Size(94, 55);
            button4.TabIndex = 9;
            button4.Text = "aciqlama elave et";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(487, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(522, 263);
            button5.Name = "button5";
            button5.Size = new Size(94, 56);
            button5.TabIndex = 7;
            button5.Text = "Tip elave et";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(522, 108);
            button6.Name = "button6";
            button6.Size = new Size(94, 57);
            button6.TabIndex = 6;
            button6.Text = "Ad Elave et";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(684, 59);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(209, 344);
            listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 547);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Button button5;
        private Button button6;
        private ListBox listBox2;
    }
}