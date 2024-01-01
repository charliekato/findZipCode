namespace findZipCode
{
    partial class Form1
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
            this.lbxPref = new System.Windows.Forms.ListBox();
            this.lbxCity = new System.Windows.Forms.ListBox();
            this.lbxStreet = new System.Windows.Forms.ListBox();
            this.lblPref = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxPref
            // 
            this.lbxPref.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbxPref.FormattingEnabled = true;
            this.lbxPref.ItemHeight = 33;
            this.lbxPref.Location = new System.Drawing.Point(133, 40);
            this.lbxPref.Name = "lbxPref";
            this.lbxPref.Size = new System.Drawing.Size(207, 763);
            this.lbxPref.TabIndex = 0;
            this.lbxPref.SelectedIndexChanged += new System.EventHandler(this.lbxPref_SelectedIndexChanged);
            // 
            // lbxCity
            // 
            this.lbxCity.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbxCity.FormattingEnabled = true;
            this.lbxCity.ItemHeight = 33;
            this.lbxCity.Location = new System.Drawing.Point(454, 40);
            this.lbxCity.Name = "lbxCity";
            this.lbxCity.Size = new System.Drawing.Size(302, 763);
            this.lbxCity.TabIndex = 1;
            this.lbxCity.SelectedIndexChanged += new System.EventHandler(this.lbxCity_SelectedIndexChanged);
            // 
            // lbxStreet
            // 
            this.lbxStreet.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbxStreet.FormattingEnabled = true;
            this.lbxStreet.ItemHeight = 33;
            this.lbxStreet.Location = new System.Drawing.Point(874, 40);
            this.lbxStreet.Name = "lbxStreet";
            this.lbxStreet.Size = new System.Drawing.Size(645, 763);
            this.lbxStreet.TabIndex = 2;
            this.lbxStreet.SelectedIndexChanged += new System.EventHandler(this.lbxStreet_SelectedIndexChanged);
            // 
            // lblPref
            // 
            this.lblPref.AutoSize = true;
            this.lblPref.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPref.Location = new System.Drawing.Point(51, 40);
            this.lblPref.Name = "lblPref";
            this.lblPref.Size = new System.Drawing.Size(47, 33);
            this.lblPref.TabIndex = 3;
            this.lblPref.Text = "県";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCity.Location = new System.Drawing.Point(383, 40);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 33);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "市";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStreet.Location = new System.Drawing.Point(801, 40);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(47, 33);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "町";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPostalCode.Location = new System.Drawing.Point(257, 824);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(0, 40);
            this.lblPostalCode.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 929);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPref);
            this.Controls.Add(this.lbxStreet);
            this.Controls.Add(this.lbxCity);
            this.Controls.Add(this.lbxPref);
            this.Name = "Form1";
            this.Text = "郵便番号検索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPref;
        private System.Windows.Forms.ListBox lbxCity;
        private System.Windows.Forms.ListBox lbxStreet;
        private System.Windows.Forms.Label lblPref;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostalCode;
    }
}

