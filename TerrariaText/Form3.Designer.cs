namespace TerrariaText
{
    partial class Form3
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
            richTextBox1 = new RichTextBox();
            button59 = new Button();
            button62 = new Button();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.FromArgb(100, 128, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(16, 16);
            richTextBox1.Margin = new Padding(2, 1, 2, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(547, 516);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // button59
            // 
            button59.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button59.BackColor = Color.Transparent;
            button59.Enabled = false;
            button59.FlatAppearance.BorderSize = 4;
            button59.FlatStyle = FlatStyle.Flat;
            button59.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button59.ForeColor = Color.Black;
            button59.Location = new Point(12, 12);
            button59.Name = "button59";
            button59.Size = new Size(555, 524);
            button59.TabIndex = 23;
            button59.Text = "Set Custom";
            button59.UseVisualStyleBackColor = false;
            // 
            // button62
            // 
            button62.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button62.FlatAppearance.BorderColor = Color.Black;
            button62.FlatAppearance.BorderSize = 2;
            button62.FlatStyle = FlatStyle.Flat;
            button62.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button62.ForeColor = Color.White;
            button62.Location = new Point(12, 546);
            button62.Name = "button62";
            button62.Size = new Size(177, 65);
            button62.TabIndex = 24;
            button62.Text = "Copy Highlighted Text to Clipboard";
            button62.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(206, 546);
            label11.Name = "label11";
            label11.Size = new Size(103, 25);
            label11.TabIndex = 25;
            label11.Text = "Leading";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(206, 572);
            button1.Name = "button1";
            button1.Size = new Size(176, 35);
            button1.TabIndex = 26;
            button1.Text = "Sort By IDs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(388, 572);
            button2.Name = "button2";
            button2.Size = new Size(176, 35);
            button2.TabIndex = 27;
            button2.Text = "Sort By Names";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 64, 163);
            ClientSize = new Size(579, 623);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(button62);
            Controls.Add(richTextBox1);
            Controls.Add(button59);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button59;
        private Button button62;
        private Label label11;
        private Button button1;
        private Button button2;
    }
}