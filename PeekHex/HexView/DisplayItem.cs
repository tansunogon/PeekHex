using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HexView
{
	interface IDisplayItem
	{
		void Draw(Graphics g, ViewInfo viewInfo, long lineBegin, long lineEnd);
	}

	class EntryRegion : IDisplayItem
	{
		public virtual void Draw(Graphics g, ViewInfo viewInfo, long lineBegin, long lineEnd)
		{
			Brush brush = new SolidBrush(Color.Black);
			g.DrawString("ADDRESS", viewInfo.font, brush, viewInfo.addressRegion.X, viewInfo.entryRegion.Y);

			for (byte i = 0; i < 16; ++i)
			{
				// data region entry
				string byteString = i.ToString("X2");
				g.DrawString(
					byteString,
					viewInfo.font,
					brush,
					viewInfo.dataRegion.X + viewInfo.charSize.Width * 3 * i,
					viewInfo.entryRegion.Y
					);

				// string region entry
				byteString = i.ToString("X");
				g.DrawString(
					byteString,
					viewInfo.font,
					brush,
					viewInfo.stringRegion.X + viewInfo.charSize.Width * i,
					viewInfo.entryRegion.Y
					);
			}
		}
	}

	class AddressRegion : IDisplayItem
	{
		public virtual void Draw(Graphics g, ViewInfo viewInfo, long lineBegin, long lineEnd)
		{
			Brush brush = new SolidBrush(Color.Black);

			for (long i = lineBegin; i < lineEnd; ++i)
			{
				string lineString = (i * 16).ToString("X10");
				g.DrawString(
					lineString,
					viewInfo.font,
					brush,
					viewInfo.addressRegion.X,
					viewInfo.addressRegion.Y + (i - lineBegin) * (viewInfo.charSize.Height + viewInfo.spaceHeight)
					);
			}
		}
	}
}
