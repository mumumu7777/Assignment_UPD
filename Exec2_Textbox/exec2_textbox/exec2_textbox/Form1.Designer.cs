namespace exec2_textbox
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
			this.yearbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.buttomconfirm = new System.Windows.Forms.Button();
			this.輸入生日 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// yearbox
			// 
			this.yearbox.Location = new System.Drawing.Point(99, 139);
			this.yearbox.Name = "yearbox";
			this.yearbox.Size = new System.Drawing.Size(225, 22);
			this.yearbox.TabIndex = 0;
			this.yearbox.Click += new System.EventHandler(this.yearbox_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(577, 181);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "查看是否";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// buttomconfirm
			// 
			this.buttomconfirm.Location = new System.Drawing.Point(387, 139);
			this.buttomconfirm.Name = "buttomconfirm";
			this.buttomconfirm.Size = new System.Drawing.Size(75, 23);
			this.buttomconfirm.TabIndex = 3;
			this.buttomconfirm.Text = "確認";
			this.buttomconfirm.UseVisualStyleBackColor = true;
			// 
			// 輸入生日
			// 
			this.輸入生日.AutoSize = true;
			this.輸入生日.Location = new System.Drawing.Point(206, 81);
			this.輸入生日.Name = "輸入生日";
			this.輸入生日.Size = new System.Drawing.Size(53, 12);
			this.輸入生日.TabIndex = 4;
			this.輸入生日.Text = "輸入生日";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.輸入生日);
			this.Controls.Add(this.buttomconfirm);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.yearbox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox yearbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttomconfirm;
		private System.Windows.Forms.Label 輸入生日;
	}
}

