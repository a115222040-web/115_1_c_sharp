namespace StringCompare
{
    partial class Form1
    {
        private Label string1Label;
        private Label string2Label;
        private TextBox string1TextBox;
        private TextBox string2TextBox;
        private Button compareButton;
        private Button exitButton;

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
            this.string1Label = new Label();
            this.string2Label = new Label();
            this.string1TextBox = new TextBox();
            this.string2TextBox = new TextBox();
            this.compareButton = new Button();
            this.exitButton = new Button();
            this.SuspendLayout();
            // string1Label
            this.string1Label.AutoSize = true;
            this.string1Label.Location = new Point(50, 45);
            this.string1Label.Name = "string1Label";
            this.string1Label.Size = new Size(49, 19);
            this.string1Label.TabIndex = 0;
            this.string1Label.Text = "字串1";
            // string2Label
            this.string2Label.AutoSize = true;
            this.string2Label.Location = new Point(50, 95);
            this.string2Label.Name = "string2Label";
            this.string2Label.Size = new Size(49, 19);
            this.string2Label.TabIndex = 1;
            this.string2Label.Text = "字串2";
            // string1TextBox
            this.string1TextBox.Location = new Point(125, 40);
            this.string1TextBox.Name = "string1TextBox";
            this.string1TextBox.Size = new Size(260, 27);
            this.string1TextBox.TabIndex = 2;
            // string2TextBox
            this.string2TextBox.Location = new Point(125, 90);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new Size(260, 27);
            this.string2TextBox.TabIndex = 3;
            // compareButton
            this.compareButton.Location = new Point(125, 145);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new Size(100, 35);
            this.compareButton.TabIndex = 4;
            this.compareButton.Text = "比較";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new EventHandler(this.compareButton_Click);
            // exitButton
            this.exitButton.Location = new Point(285, 145);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new Size(100, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new EventHandler(this.exitButton_Click);
            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 225);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.string2TextBox);
            this.Controls.Add(this.string1TextBox);
            this.Controls.Add(this.string2Label);
            this.Controls.Add(this.string1Label);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "字串比較";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
