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
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            button10 = new Button();
            button11 = new Button();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(44, 28);
            b1.Name = "b1";
            b1.Size = new Size(100, 100);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += buttonClick;
            // 
            // b2
            // 
            b2.Location = new Point(150, 28);
            b2.Name = "b2";
            b2.Size = new Size(100, 100);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += buttonClick;
            // 
            // b3
            // 
            b3.Location = new Point(256, 28);
            b3.Name = "b3";
            b3.Size = new Size(100, 100);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += buttonClick;
            // 
            // b4
            // 
            b4.Location = new Point(44, 134);
            b4.Name = "b4";
            b4.Size = new Size(100, 100);
            b4.TabIndex = 3;
            b4.Text = "\r\n\r\n\r\n";
            b4.UseVisualStyleBackColor = true;
            b4.Click += buttonClick;
            // 
            // b5
            // 
            b5.Location = new Point(150, 134);
            b5.Name = "b5";
            b5.Size = new Size(100, 100);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += buttonClick;
            // 
            // b6
            // 
            b6.Location = new Point(256, 134);
            b6.Name = "b6";
            b6.Size = new Size(100, 100);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += buttonClick;
            // 
            // b7
            // 
            b7.Location = new Point(44, 240);
            b7.Name = "b7";
            b7.Size = new Size(100, 100);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += buttonClick;
            // 
            // b8
            // 
            b8.Location = new Point(150, 240);
            b8.Name = "b8";
            b8.Size = new Size(100, 100);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += buttonClick;
            // 
            // b9
            // 
            b9.Location = new Point(256, 240);
            b9.Name = "b9";
            b9.Size = new Size(100, 100);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += buttonClick;
            // 
            // lbl1
            // 
            lbl1.Location = new Point(0, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(100, 23);
            lbl1.TabIndex = 14;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(371, 66);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(30, 25);
            lbl2.TabIndex = 10;
            lbl2.Text = "O:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(371, 103);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(107, 25);
            lbl3.TabIndex = 11;
            lbl3.Text = "Gleichstand:";
            // 
            // button10
            // 
            button10.Location = new Point(371, 153);
            button10.Name = "button10";
            button10.Size = new Size(161, 62);
            button10.TabIndex = 12;
            button10.Text = "Neues Spiel";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(371, 240);
            button11.Name = "button11";
            button11.Size = new Size(161, 62);
            button11.TabIndex = 13;
            button11.Text = "Restart";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(371, 28);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(27, 25);
            lbl4.TabIndex = 15;
            lbl4.Text = "X:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 374);
            Controls.Add(lbl4);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Button button10;
        private Button button11;
        private Label lbl4;
    }
}
