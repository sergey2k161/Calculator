namespace Calculator
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
            TextBox1 = new TextBox();
            n1 = new Button();
            n4 = new Button();
            n3 = new Button();
            n5 = new Button();
            n2 = new Button();
            n9 = new Button();
            n6 = new Button();
            n0 = new Button();
            n7 = new Button();
            n8 = new Button();
            dot = new Button();
            div = new Button();
            mult = new Button();
            sub = new Button();
            add = new Button();
            clear = new Button();
            equal = new Button();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            TextBox1.Location = new Point(12, 12);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(300, 54);
            TextBox1.TabIndex = 0;
            TextBox1.Text = "0";
            TextBox1.TextAlign = HorizontalAlignment.Right;
            TextBox1.TextChanged += TextBox1_TextChanged;
            // 
            // n1
            // 
            n1.BackColor = SystemColors.ActiveCaption;
            n1.FlatStyle = FlatStyle.Popup;
            n1.Font = new Font("Segoe UI", 25F);
            n1.Location = new Point(12, 83);
            n1.Name = "n1";
            n1.Size = new Size(64, 51);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n4
            // 
            n4.BackColor = SystemColors.ActiveCaption;
            n4.FlatStyle = FlatStyle.Popup;
            n4.Font = new Font("Segoe UI", 25F);
            n4.Location = new Point(12, 155);
            n4.Name = "n4";
            n4.Size = new Size(64, 51);
            n4.TabIndex = 2;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n3
            // 
            n3.BackColor = SystemColors.ActiveCaption;
            n3.FlatStyle = FlatStyle.Popup;
            n3.Font = new Font("Segoe UI", 25F);
            n3.Location = new Point(178, 83);
            n3.Name = "n3";
            n3.Size = new Size(64, 51);
            n3.TabIndex = 3;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n5
            // 
            n5.BackColor = SystemColors.ActiveCaption;
            n5.FlatStyle = FlatStyle.Popup;
            n5.Font = new Font("Segoe UI", 25F);
            n5.Location = new Point(96, 155);
            n5.Name = "n5";
            n5.Size = new Size(64, 51);
            n5.TabIndex = 4;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n2
            // 
            n2.BackColor = SystemColors.ActiveCaption;
            n2.FlatStyle = FlatStyle.Popup;
            n2.Font = new Font("Segoe UI", 25F);
            n2.Location = new Point(96, 83);
            n2.Name = "n2";
            n2.Size = new Size(64, 51);
            n2.TabIndex = 5;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n9
            // 
            n9.BackColor = SystemColors.ActiveCaption;
            n9.FlatStyle = FlatStyle.Popup;
            n9.Font = new Font("Segoe UI", 25F);
            n9.Location = new Point(178, 232);
            n9.Name = "n9";
            n9.Size = new Size(64, 51);
            n9.TabIndex = 6;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // n6
            // 
            n6.BackColor = SystemColors.ActiveCaption;
            n6.FlatStyle = FlatStyle.Popup;
            n6.Font = new Font("Segoe UI", 25F);
            n6.Location = new Point(178, 155);
            n6.Name = "n6";
            n6.Size = new Size(64, 51);
            n6.TabIndex = 7;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n0
            // 
            n0.BackColor = SystemColors.ActiveCaption;
            n0.FlatStyle = FlatStyle.Popup;
            n0.Font = new Font("Segoe UI", 25F);
            n0.Location = new Point(96, 306);
            n0.Name = "n0";
            n0.Size = new Size(64, 51);
            n0.TabIndex = 8;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // n7
            // 
            n7.BackColor = SystemColors.ActiveCaption;
            n7.FlatStyle = FlatStyle.Popup;
            n7.Font = new Font("Segoe UI", 25F);
            n7.Location = new Point(12, 232);
            n7.Name = "n7";
            n7.Size = new Size(64, 51);
            n7.TabIndex = 9;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.BackColor = SystemColors.ActiveCaption;
            n8.FlatStyle = FlatStyle.Popup;
            n8.Font = new Font("Segoe UI", 25F);
            n8.Location = new Point(96, 232);
            n8.Name = "n8";
            n8.Size = new Size(64, 51);
            n8.TabIndex = 10;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // dot
            // 
            dot.BackColor = SystemColors.ActiveCaption;
            dot.FlatStyle = FlatStyle.Popup;
            dot.Font = new Font("Segoe UI", 25F);
            dot.Location = new Point(12, 306);
            dot.Name = "dot";
            dot.Size = new Size(64, 51);
            dot.TabIndex = 11;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // div
            // 
            div.BackColor = SystemColors.ActiveCaption;
            div.FlatStyle = FlatStyle.Popup;
            div.Font = new Font("Segoe UI", 25F);
            div.Location = new Point(252, 306);
            div.Name = "div";
            div.Size = new Size(64, 51);
            div.TabIndex = 12;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += div_Click;
            // 
            // mult
            // 
            mult.BackColor = SystemColors.ActiveCaption;
            mult.FlatStyle = FlatStyle.Popup;
            mult.Font = new Font("Segoe UI", 25F);
            mult.Location = new Point(252, 232);
            mult.Name = "mult";
            mult.Size = new Size(64, 51);
            mult.TabIndex = 13;
            mult.Text = "*";
            mult.UseVisualStyleBackColor = false;
            mult.Click += mult_Click;
            // 
            // sub
            // 
            sub.BackColor = SystemColors.ActiveCaption;
            sub.FlatStyle = FlatStyle.Popup;
            sub.Font = new Font("Segoe UI", 25F);
            sub.Location = new Point(252, 155);
            sub.Name = "sub";
            sub.Size = new Size(64, 51);
            sub.TabIndex = 14;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += sub_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.ActiveCaption;
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Segoe UI", 25F);
            add.Location = new Point(252, 83);
            add.Name = "add";
            add.Size = new Size(64, 51);
            add.TabIndex = 15;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ActiveCaption;
            clear.FlatStyle = FlatStyle.Popup;
            clear.Font = new Font("Segoe UI", 25F);
            clear.Location = new Point(178, 306);
            clear.Name = "clear";
            clear.Size = new Size(64, 51);
            clear.TabIndex = 16;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.ActiveCaption;
            equal.FlatStyle = FlatStyle.Popup;
            equal.Font = new Font("Segoe UI", 25F);
            equal.Location = new Point(63, 376);
            equal.Name = "equal";
            equal.Size = new Size(198, 51);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 450);
            Controls.Add(equal);
            Controls.Add(clear);
            Controls.Add(add);
            Controls.Add(sub);
            Controls.Add(mult);
            Controls.Add(div);
            Controls.Add(dot);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n0);
            Controls.Add(n6);
            Controls.Add(n9);
            Controls.Add(n2);
            Controls.Add(n5);
            Controls.Add(n3);
            Controls.Add(n4);
            Controls.Add(n1);
            Controls.Add(TextBox1);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox1;
        private Button n1;
        private Button n4;
        private Button n3;
        private Button n5;
        private Button n2;
        private Button n9;
        private Button n6;
        private Button n0;
        private Button n7;
        private Button n8;
        private Button dot;
        private Button div;
        private Button mult;
        private Button sub;
        private Button add;
        private Button clear;
        private Button equal;
    }
}
