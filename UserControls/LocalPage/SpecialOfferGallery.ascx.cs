using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using SeasCleanDataAccess;

namespace SearsGarageWeb
{
	public partial class SpecialOfferGallery : LocalPagesGalleryBase
	{
		#region Properties

		private GalleryControls uc = new GalleryControls();
		private List<SCUCWEB_WebPageContent> _pagecontent;
		private string _headertext;
		private List<SCUCWEB_WebPageContentDetail> _pageitems;

		public List<SCUCWEB_WebPageContent> PageContent
		{
			set { _pagecontent = value; }
		}

		public List<SCUCWEB_WebPageContentDetail> PageItems
		{
			get { return _pageitems; }
			set { _pageitems = value; }
		}

		public string HeaderText
		{
			set { _headertext = value; }
		}

		#endregion Properties

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		public void AddGalleryHeader(string headertext)
		{
			GalleryTitle.InnerHtml = headertext;
		}

		public List<SCUCWEB_WebPageContent> GetContent(List<SCUCWEB_WebPageContent> pagecontent)
		{
			return base.GetContent(pagecontent, SCUCConstants.SW_WPCTR_SpecialOfferGallery);
		}
	} // ends  class SpecialOfferGallery
}// ends namespace SearsGarageWeb