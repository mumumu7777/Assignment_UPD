namespace EXec2_star
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
			this.userinputBox = new System.Windows.Forms.TextBox();
			this.printbuttom = new System.Windows.Forms.Button();
			this.starBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// userinputBox
			// 
			this.userinputBox.Location = new System.Drawing.Point(74, 104);
			this.userinputBox.Multiline = true;
			this.userinputBox.Name = "userinputBox";
			this.userinputBox.Size = new System.Drawing.Size(326, 22);
			this.userinputBox.TabIndex = 0;
			// 
			// printbuttom
			// 
			this.printbuttom.Location = new System.Drawing.Point(515, 104);
			this.printbuttom.Name = "printbuttom";
			this.printbuttom.Size = new System.Drawing.Size(75, 23);
			this.printbuttom.TabIndex = 1;
			this.printbuttom.Text = "Print";
			this.printbuttom.UseVisualStyleBackColor = true;
			this.printbuttom.Click += new System.EventHandler(this.printbuttom_Click);
			// 
			// starBox
			// 
			this.starBox.Location = new System.Drawing.Point(74, 155);
			this.starBox.Multiline = true;
			this.starBox.Name = "starBox";
			this.starBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.starBox.Size = new System.Drawing.Size(326, 251);
			this.starBox.TabIndex = 2;
			this.starBox.WordWrap = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.starBox);
			this.Controls.Add(this.printbuttom);
			this.Controls.Add(this.userinputBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userinputBox;
		private System.Windows.Forms.Button printbuttom;
		private System.Windows.Forms.TextBox starBox;
	}
}

