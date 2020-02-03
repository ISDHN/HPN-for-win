namespace HPN_for_win
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.message = new System.Windows.Forms.Label();
            this.message1 = new System.Windows.Forms.Label();
            this.esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("华文行楷", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(0, 0);
            this.message.Name = "message";
            this.message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message.Size = new System.Drawing.Size(600, 282);
            this.message.TabIndex = 0;
            this.message.Text = "2020\r\n一定行！";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // message1
            // 
            this.message1.AutoSize = true;
            this.message1.Font = new System.Drawing.Font("华文行楷", 32F, System.Drawing.FontStyle.Bold);
            this.message1.ForeColor = System.Drawing.Color.Red;
            this.message1.Location = new System.Drawing.Point(-58, 282);
            this.message1.Name = "message1";
            this.message1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.message1.Size = new System.Drawing.Size(980, 45);
            this.message1.TabIndex = 1;
            this.message1.Text = "祝您2020身体健康，万事如意，中考取得好成绩！";
            this.message1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esc
            // 
            this.esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esc.Location = new System.Drawing.Point(397, 420);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(75, 23);
            this.esc.TabIndex = 2;
            this.esc.Text = "退出";
            this.esc.UseVisualStyleBackColor = true;
            this.esc.Click += new System.EventHandler(this.Esc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label message1;
        private System.Windows.Forms.Button esc;
    }
}

