using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HexView
{
	class ViewInfo
	{
		public Font font;
		public SizeF charSize;

		public int spaceHeight = 0;

		public Rectangle entryRegion;
		public Rectangle addressRegion;
		public Rectangle dataRegion;
		public Rectangle stringRegion;

		public ViewInfo(Control control)
		{
			SetFont(control);
		}

		public void SetFont(Control control)
		{
			font = new Font(control.Font, FontStyle.Regular);
			using (var graphics = control.CreateGraphics())
			using (StringFormat sf = new StringFormat(StringFormat.GenericTypographic))
			{
				charSize = graphics.MeasureString("A", font, 100, sf);
			}
			//charSize = new SizeF((float)Math.Ceiling(charSize.Width), (float)Math.Ceiling(charSize.Height));
		}

		public void SetSize(Control control)
		{
			entryRegion.X = control.ClientRectangle.X;
			entryRegion.Y = control.ClientRectangle.Y;
			entryRegion.Width = control.ClientRectangle.Width;
			entryRegion.Height = (int)charSize.Height;

			addressRegion.X = control.ClientRectangle.X;
			addressRegion.Y = entryRegion.Bottom + spaceHeight;
			addressRegion.Width = (int)charSize.Width * 10;
			addressRegion.Height = (int)charSize.Height;

			dataRegion.X = addressRegion.Right;
			dataRegion.Y = entryRegion.Bottom + spaceHeight;
			dataRegion.Width = (int)(charSize.Width * (16 * 3));
			dataRegion.Height = (int)charSize.Height;

			stringRegion.X = dataRegion.Right;
			stringRegion.Y = entryRegion.Bottom + spaceHeight;
			stringRegion.Width = (int)(charSize.Width * 16);
			stringRegion.Height = (int)charSize.Height;
		}
	}
}
