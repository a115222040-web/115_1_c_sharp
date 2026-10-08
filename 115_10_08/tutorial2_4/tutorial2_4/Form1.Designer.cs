namespace tutorial2_4
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
            this.germanPictureBox = new System.Windows.Forms.PictureBox();
            this.finlandPictureBox2 = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // germanPictureBox
            // 
            this.germanPictureBox.Image = global::tutorial2_4.Properties.Resources.Germany;
            this.germanPictureBox.Location = new System.Drawing.Point(353, 283);
            this.germanPictureBox.Name = "germanPictureBox";
            this.germanPictureBox.Size = new System.Drawing.Size(241, 130);
            this.germanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanPictureBox.TabIndex = 2;
            this.germanPictureBox.TabStop = false;
            this.germanPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // finlandPictureBox2
            // 
            this.finlandPictureBox2.Image = global::tutorial2_4.Properties.Resources.Finland;
            this.finlandPictureBox2.Location = new System.Drawing.Point(690, 283);
            this.finlandPictureBox2.Name = "finlandPictureBox2";
            this.finlandPictureBox2.Size = new System.Drawing.Size(291, 142);
            this.finlandPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPictureBox2.TabIndex = 3;
            this.finlandPictureBox2.TabStop = false;
            this.finlandPictureBox2.Click += new System.EventHandler(this.finlandPictureBox2_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = global::tutorial2_4.Properties.Resources.France;
            this.francePictureBox.Location = new System.Drawing.Point(43, 283);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(260, 130);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 4;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLabel.Location = new System.Drawing.Point(372, 495);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(313, 117);
            this.countryLabel.TabIndex = 5;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(174, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "點選一個國旗，我告訴你是哪個國家";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox2);
            this.Controls.Add(this.germanPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox germanPictureBox;
        private System.Windows.Forms.PictureBox finlandPictureBox2;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
    }
}

