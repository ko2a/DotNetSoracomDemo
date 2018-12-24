namespace SoracomDemo
{
    partial class FormSoracom
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblElem1 = new System.Windows.Forms.Label();
            this.lblElem2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblElem1Value = new System.Windows.Forms.Label();
            this.lblElem2Value = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 370);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 22);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 33);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = -15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(278, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lblElem1
            // 
            this.lblElem1.AutoSize = true;
            this.lblElem1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblElem1.Location = new System.Drawing.Point(12, 9);
            this.lblElem1.Name = "lblElem1";
            this.lblElem1.Size = new System.Drawing.Size(82, 21);
            this.lblElem1.TabIndex = 1;
            this.lblElem1.Text = "Element 1:";
            // 
            // lblElem2
            // 
            this.lblElem2.AutoSize = true;
            this.lblElem2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblElem2.Location = new System.Drawing.Point(12, 81);
            this.lblElem2.Name = "lblElem2";
            this.lblElem2.Size = new System.Drawing.Size(82, 21);
            this.lblElem2.TabIndex = 3;
            this.lblElem2.Text = "Element 2:";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(12, 105);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar2.Maximum = 150;
            this.trackBar2.Minimum = -150;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(278, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // lblElem1Value
            // 
            this.lblElem1Value.AutoSize = true;
            this.lblElem1Value.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblElem1Value.Location = new System.Drawing.Point(105, 9);
            this.lblElem1Value.Name = "lblElem1Value";
            this.lblElem1Value.Size = new System.Drawing.Size(19, 21);
            this.lblElem1Value.TabIndex = 9;
            this.lblElem1Value.Text = "0";
            this.lblElem1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblElem2Value
            // 
            this.lblElem2Value.AutoSize = true;
            this.lblElem2Value.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblElem2Value.Location = new System.Drawing.Point(105, 81);
            this.lblElem2Value.Name = "lblElem2Value";
            this.lblElem2Value.Size = new System.Drawing.Size(19, 21);
            this.lblElem2Value.TabIndex = 10;
            this.lblElem2Value.Text = "0";
            this.lblElem2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSend.Location = new System.Drawing.Point(12, 154);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(278, 39);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_ClickAsync);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 231);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(278, 135);
            this.txtResponse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Response:";
            // 
            // FormSoracom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 404);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblElem2Value);
            this.Controls.Add(this.lblElem1Value);
            this.Controls.Add(this.lblElem2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.lblElem1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSoracom";
            this.Text = "SORACOM Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSoracom_FormClosing);
            this.Load += new System.EventHandler(this.FormSoracom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblElem1;
        private System.Windows.Forms.Label lblElem2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblElem1Value;
        private System.Windows.Forms.Label lblElem2Value;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label1;
    }
}

