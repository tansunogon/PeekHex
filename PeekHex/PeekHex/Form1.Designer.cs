namespace PeekHex
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
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.hexView1 = new HexView.HexView();
			this.SuspendLayout();
			// 
			// hexView1
			// 
			this.hexView1.BackColor = System.Drawing.SystemColors.Info;
			this.hexView1.Location = new System.Drawing.Point(50, 77);
			this.hexView1.Name = "hexView1";
			this.hexView1.Size = new System.Drawing.Size(856, 160);
			this.hexView1.TabIndex = 0;
			this.hexView1.Text = "hexView1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 261);
			this.Controls.Add(this.hexView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private HexView.HexView hexView1;
	}
}

