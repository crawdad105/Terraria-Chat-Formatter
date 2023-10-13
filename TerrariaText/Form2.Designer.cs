namespace TerrariaText
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            richTextBox1 = new RichTextBox();
            button59 = new Button();
            button62 = new Button();
            label11 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.FromArgb(100, 128, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(16, 16);
            richTextBox1.Margin = new Padding(2, 1, 2, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(547, 516);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
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
            button62.Click += button62_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(206, 546);
            label11.Name = "label11";
            label11.Size = new Size(348, 23);
            label11.TabIndex = 25;
            label11.Text = "(Control + Scroll Wheal to zoom in and out)";
            label11.Visible = false;
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
            button1.Size = new Size(264, 35);
            button1.TabIndex = 26;
            button1.Text = "Do Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 64, 163);
            ClientSize = new Size(579, 623);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(button62);
            Controls.Add(richTextBox1);
            Controls.Add(button59);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button59;
        private Button button62;
        private Label label11;
        private Button button1;
    }
}