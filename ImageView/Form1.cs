using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageView
{
	public partial class Form1 : Form
	{
		int ImgCount = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.picImg.Image = this.ImageList.Images[ImgCount];
			this.lblName.Text = (this.ImgCount + 1) + " / " + this.ImageList.Images.Count;
		}

		private void BtnNext_Click(object sender, EventArgs e)
		{
			this.ImgCount++;
			if(this.ImgCount >= this.ImageList.Images.Count)
			{
				this.ImgCount = 0;
			}
			this.picImg.Image = this.ImageList.Images[ImgCount];
			this.lblName.Text = (this.ImgCount + 1) + " / " + this.ImageList.Images.Count;
		}

		private void BtnPrev_Click(object sender, EventArgs e)
		{
			this.ImgCount--;
			if (this.ImgCount <= 0)
			{
				this.ImgCount = this.ImageList.Images.Count - 1;
			}
			this.picImg.Image = this.ImageList.Images[ImgCount];
			this.lblName.Text = (this.ImgCount + 1) + " / " + this.ImageList.Images.Count;
		}
	}
}
