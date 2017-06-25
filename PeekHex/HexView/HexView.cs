using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexView
{
	public partial class HexView : Control
	{
		private ViewInfo _viewInfo;

		public HexView()
		{
			InitializeComponent();
			_viewInfo = new ViewInfo(this);
		}

		#region EventHandler
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			new EntryRegion().Draw(pe.Graphics, _viewInfo, 0, 10);
			new AddressRegion().Draw(pe.Graphics, _viewInfo, 0, 10);
		}

		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			_viewInfo.SetFont(this);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			_viewInfo.SetSize(this);
		}
		#endregion
	}
}
