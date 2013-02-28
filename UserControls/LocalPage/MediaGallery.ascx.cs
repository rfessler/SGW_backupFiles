using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using SeasCleanDataAccess;

namespace SearsGarageWeb
{
	public partial class MediaGallery : LocalPagesGalleryBase
	{
		#region PROPERTIES

		private string _headertext;
		private List<SCUCWEB_WebPageContent> _pagecontent;
		private List<SCUCWEB_WebPageContentDetail> _pageitems;

		public string HeaderText
		{
			set { _headertext = value; }
		}

		public List<SCUCWEB_WebPageContent> PageContent
		{
			set { _pagecontent = value; }
		}

		public List<SCUCWEB_WebPageContentDetail> PageItems
		{
			get { return _pageitems; }
			set { _pageitems = value; }
		}

		#endregion PROPERTIES

		#region VARIABLES

		#endregion VARIABLES

		#region PAGE_EVENTS

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		#endregion PAGE_EVENTS

		#region HELPER_METHODS

		#endregion HELPER_METHODS

		#region PUBLIC_METHODS

		public void AddGalleryHeader(string headertext)
		{
			GalleryTitle.InnerHtml = headertext;
		}

		//public List<SCUCWEB_WebPageContent> GetContent(List<SCUCWEB_WebPageContent> pagecontent)
		//{
		//    return base.GetContent(pagecontent, SCUCConstants.SW_WPCTR_MediaGallery);
		//}

		#endregion PUBLIC_METHODS
	}  // ends  class MediaGallery
}	// ends namespace SearsGarageWeb