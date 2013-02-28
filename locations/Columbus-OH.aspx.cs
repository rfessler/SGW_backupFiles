using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using SeasCleanDataAccess;

namespace SearsGarageWeb.locations
{
	public partial class Columbus_OH : BasePageWithLeftNav
	{
		private Guid _webpageid;

		public Guid WebPageID
		{
			get { return _webpageid; }
			set { _webpageid = value; }
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				this.MasterPage.SetNavigation((SearsGarageWeb.TopNavSelection)SearsGarageWeb.TopNavSelection.GarageDoorAccess, (SearsGarageWeb.TopNavSelected)SearsGarageWeb.TopNavSelected.GarageDoors, (SearsGarageWeb.LeftNavSelection)SearsGarageWeb.LeftNavSelection.None, (SearsGarageWeb.LeftNavSelected)SearsGarageWeb.LeftNavSelection.None);

				FetchGalleryArticles();
			}
		}

		public enum LeftNavSelected { None, Overview, TraditionalSeries, CarriageHouseSeries, SafetyFeatures, Warranty };

		public enum LeftNavSelection { None, GarageDoorAccess };

		protected void FetchGalleryArticles()
		{
			List<SCUCWEB_WebPageContent> mediagallery = DataHelper.FetchGalleryContent(_webpageid);
			int count = mediagallery.Count;
		}
	}
}