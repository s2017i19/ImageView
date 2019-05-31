namespace ImageView
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.picImg = new System.Windows.Forms.PictureBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
			this.SuspendLayout();
			// 
			// picImg
			// 
			this.picImg.Location = new System.Drawing.Point(12, 12);
			this.picImg.Name = "picImg";
			this.picImg.Size = new System.Drawing.Size(256, 144);
			this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picImg.TabIndex = 0;
			this.picImg.TabStop = false;
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblName.Location = new System.Drawing.Point(114, 162);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 52);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "/";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(12, 162);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(94, 52);
			this.btnPrev.TabIndex = 2;
			this.btnPrev.Text = "이전";
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(172, 162);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(96, 52);
			this.btnNext.TabIndex = 3;
			this.btnNext.Text = "다음";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// ImageList
			// 
			this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
			this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList.Images.SetKeyName(0, "1.jpg");
			this.ImageList.Images.SetKeyName(1, "2.JPG");
			this.ImageList.Images.SetKeyName(2, "3.JPG");
			this.ImageList.Images.SetKeyName(3, "4.JPG");
			this.ImageList.Images.SetKeyName(4, "5.JPG");
			this.ImageList.Images.SetKeyName(5, "6.JPG");
			this.ImageList.Images.SetKeyName(6, "7.JPG");
			this.ImageList.Images.SetKeyName(7, "8.jpg");
			this.ImageList.Images.SetKeyName(8, "9.JPG");
			this.ImageList.Images.SetKeyName(9, "10.JPG");
			this.ImageList.Images.SetKeyName(10, "11.JPG");
			this.ImageList.Images.SetKeyName(11, "12.JPG");
			this.ImageList.Images.SetKeyName(12, "13.JPG");
			this.ImageList.Images.SetKeyName(13, "14.JPG");
			this.ImageList.Images.SetKeyName(14, "15.JPG");
			this.ImageList.Images.SetKeyName(15, "16.JPG");
			this.ImageList.Images.SetKeyName(16, "17.JPG");
			this.ImageList.Images.SetKeyName(17, "18.JPG");
			this.ImageList.Images.SetKeyName(18, "19.JPG");
			this.ImageList.Images.SetKeyName(19, "20.JPG");
			this.ImageList.Images.SetKeyName(20, "21.JPG");
			this.ImageList.Images.SetKeyName(21, "22.JPG");
			this.ImageList.Images.SetKeyName(22, "23.JPG");
			this.ImageList.Images.SetKeyName(23, "24.JPG");
			this.ImageList.Images.SetKeyName(24, "25.JPG");
			this.ImageList.Images.SetKeyName(25, "26.JPG");
			this.ImageList.Images.SetKeyName(26, "27.JPG");
			this.ImageList.Images.SetKeyName(27, "28.JPG");
			this.ImageList.Images.SetKeyName(28, "29.JPG");
			this.ImageList.Images.SetKeyName(29, "30.JPG");
			this.ImageList.Images.SetKeyName(30, "31.JPG");
			this.ImageList.Images.SetKeyName(31, "32.JPG");
			this.ImageList.Images.SetKeyName(32, "33.JPG");
			this.ImageList.Images.SetKeyName(33, "34.JPG");
			this.ImageList.Images.SetKeyName(34, "35.JPG");
			this.ImageList.Images.SetKeyName(35, "36.JPG");
			this.ImageList.Images.SetKeyName(36, "37.JPG");
			this.ImageList.Images.SetKeyName(37, "38.JPG");
			this.ImageList.Images.SetKeyName(38, "39.JPG");
			this.ImageList.Images.SetKeyName(39, "40.JPG");
			this.ImageList.Images.SetKeyName(40, "41.JPG");
			this.ImageList.Images.SetKeyName(41, "42.JPG");
			this.ImageList.Images.SetKeyName(42, "43.JPG");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 227);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picImg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "사진첩";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picImg;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.ImageList ImageList;
	}
}

