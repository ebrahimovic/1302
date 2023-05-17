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
            multiply = new Button();
            textBox1 = new TextBox();
            history = new ListBox();
            divide = new Button();
            minus = new Button();
            plus = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // multiply
            // 
            multiply.Location = new Point(384, 246);
            multiply.Name = "multiply";
            multiply.Size = new Size(96, 37);
            multiply.TabIndex = 9;
            multiply.Text = "x";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += button12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // history
            // 
            history.FormattingEnabled = true;
            history.ItemHeight = 15;
            history.Location = new Point(557, 108);
            history.Name = "history";
            history.Size = new Size(193, 274);
            history.TabIndex = 13;
            // 
            // divide
            // 
            divide.Location = new Point(221, 246);
            divide.Name = "divide";
            divide.Size = new Size(96, 37);
            divide.TabIndex = 16;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // minus
            // 
            minus.Location = new Point(384, 302);
            minus.Name = "minus";
            minus.Size = new Size(96, 37);
            minus.TabIndex = 15;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.Location = new Point(221, 302);
            plus.Name = "plus";
            plus.Size = new Size(96, 37);
            plus.TabIndex = 14;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 23);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 90);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 19;
            label1.Text = "Enter a number here";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 161);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 20;
            label2.Text = "Enter a second number here";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(divide);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(history);
            Controls.Add(textBox1);
            Controls.Add(multiply);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button multiply;
        private TextBox textBox1;
        private ListBox history;
        private Button divide;
        private Button minus;
        private Button plus;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}