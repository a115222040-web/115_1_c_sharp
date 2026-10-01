namespace tutorial2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itaiianButton = new System.Windows.Forms.Label();
            this.spanishButton = new System.Windows.Forms.Label();
            this.germanyButton = new System.Windows.Forms.Label();
            this.translateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 163);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎麼說\"早安\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 5;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // itaiianButton
            // 
            this.itaiianButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itaiianButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.itaiianButton.Location = new System.Drawing.Point(1, 366);
            this.itaiianButton.Name = "itaiianButton";
            this.itaiianButton.Size = new System.Drawing.Size(216, 43);
            this.itaiianButton.TabIndex = 6;
            this.itaiianButton.Text = "義大利";
            this.itaiianButton.Click += new System.EventHandler(this.label7_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spanishButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spanishButton.Location = new System.Drawing.Point(286, 366);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(216, 43);
            this.spanishButton.TabIndex = 7;
            this.spanishButton.Text = "西班牙";
            this.spanishButton.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // germanyButton
            // 
            this.germanyButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanyButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.germanyButton.Location = new System.Drawing.Point(553, 366);
            this.germanyButton.Name = "germanyButton";
            this.germanyButton.Size = new System.Drawing.Size(216, 43);
            this.germanyButton.TabIndex = 8;
            this.germanyButton.Text = "德國";
            this.germanyButton.Click += new System.EventHandler(this.germanyButton_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translateLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translateLabel.Location = new System.Drawing.Point(102, 200);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(510, 79);
            this.translateLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.germanyButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.itaiianButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label itaiianButton;
        private System.Windows.Forms.Label spanishButton;
        private System.Windows.Forms.Label germanyButton;
        private System.Windows.Forms.Label translateLabel;
    }
}

