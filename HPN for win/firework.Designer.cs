namespace HPN_for_win
{
    partial class Fireworks
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fireworks));
            this.firework = new System.Windows.Forms.PictureBox();
            this.fire = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // firework
            // 
            this.firework.Image = ((System.Drawing.Image)(resources.GetObject("firework.Image")));
            this.firework.Location = new System.Drawing.Point(0, 0);
            this.firework.Name = "firework";
            this.firework.Size = new System.Drawing.Size(39, 74);
            this.firework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firework.TabIndex = 2;
            this.firework.TabStop = false;
            // 
            // fire
            // 
            this.fire.Image = ((System.Drawing.Image)(resources.GetObject("fire.Image")));
            this.fire.Location = new System.Drawing.Point(0, 70);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(36, 47);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fire.TabIndex = 3;
            this.fire.TabStop = false;
            // 
            // Fireworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fire);
            this.Controls.Add(this.firework);
            this.Name = "Fireworks";
            this.Size = new System.Drawing.Size(36, 119);
            this.SizeChanged += new System.EventHandler(this.Fireworks_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.firework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox firework;
        private System.Windows.Forms.PictureBox fire;
    }
}
