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
	public partial class ArticleGallery : LocalPagesGalleryBase
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		#region PUBLIC_METHODS

		public void AddGalleryHeader(string headertext)
		{
			GalleryTitle.InnerHtml = headertext;
		}

		public List<SCUCWEB_WebPageContent> GetContent(List<SCUCWEB_WebPageContent> pagecontent)
		{
			return base.GetContent(pagecontent, SCUCConstants.SW_WPCTR_AssociationGallery);
		}

		#endregion PUBLIC_METHODS
	}
}