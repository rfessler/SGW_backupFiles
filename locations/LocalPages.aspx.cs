#define DEBUG
#define LOCALPAGE

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
	public class GalleryControls
	{
		public global::SearsGarageWeb.MediaGallery ucMediaGallery;
		public global::SearsGarageWeb.LinkGallery ucLinkGallery;
		public global::SearsGarageWeb.SpecialOfferGallery ucSpecialOfferGallery;
		public global::SearsGarageWeb.SurveyGallery ucSurverGallery;
		public global::SearsGarageWeb.ArticleGallery ucArticleGallery;
		public global::SearsGarageWeb.AboutUsGallery ucAboutUsGallery;
		public global::SearsGarageWeb.AssociationGallery ucAssociationGallery;
	}

	public partial class LocalPagesBase : System.Web.UI.Page
	{
		//protected global::SearsGarageWeb.LeftNavLocalPage ucLeftNavLocalPage;
		//protected global::SearsGarageWeb.UserControls.Navigation.LocalOffers ucLocalOffers;

		#region VARIABLES

		private PlaceHolder ucGalleryPlaceholder = new PlaceHolder();
		private GalleryControls uc = new GalleryControls();
		private HtmlGenericControl ctrlText = new HtmlGenericControl();
		private HtmlImage ctrlImage = new HtmlImage();

		private LocalPagesGalleryBase helper = new LocalPagesGalleryBase();

		#endregion VARIABLES

		#region PROPERTIES

		private Guid _webpageid;

		public Guid WebPageID
		{
			get { return _webpageid; }
			set { _webpageid = value; }
		}

		#endregion PROPERTIES

		#region LeftNav Methods

		public enum LeftNavSelected { None, Overview, TraditionalSeries, CarriageHouseSeries, SafetyFeatures, Warranty };

		public enum LeftNavSelection { None, GarageDoorAccess };

		#endregion LeftNav Methods

		#region PAGE_EVENTS

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				//this.MasterPage.SetNavigation((SearsGarageWeb.TopNavSelection)SearsGarageWeb.TopNavSelection.GarageDoorAccess, (SearsGarageWeb.TopNavSelected)SearsGarageWeb.TopNavSelected.GarageDoors, (SearsGarageWeb.LeftNavSelection)SearsGarageWeb.LeftNavSelection.None, (SearsGarageWeb.LeftNavSelected)SearsGarageWeb.LeftNavSelection.None);

				CreateLocalWebPage();
			}
		}

		#endregion PAGE_EVENTS

		#region PUBLIC_METHODS

		public void CreateLocalWebPage()
		{
			List<SCUCWEB_WebPageContent> pagecontent = GetSortedWebPageContent();

			AddMediaGalleries(pagecontent);

			//AddSpecialOfferGallieries(pagecontent);
			//AddAssociationGallieries(pagecontent);
			//AddArticleGallieries(pagecontent);

			List<SCUCWEB_WebPageContentDetail> pageitem = GetSortedWebPageItems(pagecontent);
		}  // ends CreateLocalWebPage

		#endregion PUBLIC_METHODS

		#region HELPER_METHODS

		private List<SCUCWEB_WebPageContent> GetSortedWebPageContent()
		{
			List<SCUCWEB_WebPageContent> webpagecontents = DataHelper.GetWebPageContentInformation(_webpageid);
			IEnumerable<SCUCWEB_WebPageContent> sortedwebpagecontents = webpagecontents.OrderBy(SCUCWEB_WebPageContent => SCUCWEB_WebPageContent.SortOrder);
			return sortedwebpagecontents.ToList();
		}

		private List<SCUCWEB_WebPageContentDetail> GetSortedWebPageItems(List<SCUCWEB_WebPageContent> pagecontent)
		{
			//List<SCUCWEB_WebPageContentDetail> pageitemslist = pagecontent.SCUCWEB_WebPageContentDetails.ToList();
			//IEnumerable<SCUCWEB_WebPageContentDetail> sortedwebpagecontents = pagecontent.OrderBy(SCUCWEB_WebPageContent => SCUCWEB_WebPageContent.SortOrder);
			//return sortedwebpagecontents.ToList();
			return null;
		}

		/// <summary>
		/// Adds the galleries to the local page.
		/// </summary>
		/// <param name="pagecontent">The pagecontent.</param>
		/// <remarks>rfessler:2/27/2013</remarks>
		private void AddMediaGalleries(List<SCUCWEB_WebPageContent> pagecontent)
		{
			int previousgalleryid = -1;

			uc.ucMediaGallery = new MediaGallery();

			// get media gallery content only
			//List<SCUCWEB_WebPageContent> gallerycontent = uc.ucMediaGallery.GetContent(pagecontent);

			List<SCUCWEB_WebPageContent> gallerycontent = helper.GetContent(pagecontent, SCUCConstants.SW_WPCTR_MediaGallery);

			// get distint to create teh  galleries
			//IEnumerable<int> distinctGalleries = gallerycontent.Select(item => (int)item.SortOrder).Distinct();

			foreach (var gallery in gallerycontent)
			{
				int galleryid = (int)gallery.SortOrder;
				string headertext = (from item in pagecontent where (int)item.SortOrder == galleryid select item.HeaderText).FirstOrDefault();

				if (galleryid != previousgalleryid)
				{
					previousgalleryid = galleryid;
					uc.ucMediaGallery = (MediaGallery)LoadControl("/UserControls/LocalPage/MediaGallery.ascx");

					uc.ucMediaGallery.ID = string.Format("MediaGallery{0}", galleryid.ToString());
					uc.ucMediaGallery.AddGalleryHeader(headertext);

					//uc.ucMediaGallery.AddGalleryContent(gallery.SCUCWEB_WebPageContentDetails.ToList());
					ucGalleryPlaceholder.Controls.Add(uc.ucMediaGallery);
				}
			}
		}

		private void AddSpecialOfferGallieries(List<SCUCWEB_WebPageContent> pagecontent)
		{
			int previousgalleryid = -1;

			uc.ucSpecialOfferGallery = new SpecialOfferGallery();

			//List<SCUCWEB_WebPageContent> gallerycontent = uc.ucSpecialOfferGallery.GetContent(pagecontent);

			List<SCUCWEB_WebPageContent> gallerycontent = helper.GetContent(pagecontent, SCUCConstants.SW_WPCTR_SpecialOfferGallery);

			// get distint to create teh  galleries
			//IEnumerable<int> distinctGalleries = gallerycontent.Select(item => (int)item.SortOrder).Distinct();

			foreach (var gallery in gallerycontent)
			{
				int galleryid = (int)gallery.SortOrder;
				string headertext = (from item in pagecontent where (int)item.SortOrder == galleryid select item.HeaderText).FirstOrDefault();

				if (galleryid != previousgalleryid)
				{
					previousgalleryid = galleryid;
					uc.ucSpecialOfferGallery = (SpecialOfferGallery)LoadControl("/UserControls/LocalPage/SpecialOfferGallery.ascx");

					uc.ucSpecialOfferGallery.ID = string.Format("SpecialOfferGallery{0}", galleryid.ToString());
					uc.ucSpecialOfferGallery.AddGalleryHeader(headertext);
					ucGalleryPlaceholder.Controls.Add(uc.ucSpecialOfferGallery);
				}
			}
		}

		private void AddAssociationGallieries(List<SCUCWEB_WebPageContent> pagecontent)
		{
			int previousgalleryid = -1;
			uc.ucAssociationGallery = new AssociationGallery();

			List<SCUCWEB_WebPageContent> gallerycontent = helper.GetContent(pagecontent, SCUCConstants.SW_WPCTR_AssociationGallery);
			foreach (var gallery in gallerycontent)
			{
				int galleryid = (int)gallery.SortOrder;
				if (galleryid != previousgalleryid)
				{
					string headertext = (from item in gallerycontent where (int)item.SortOrder == galleryid select item.HeaderText).FirstOrDefault();
					previousgalleryid = galleryid;
					uc.ucAssociationGallery = (AssociationGallery)LoadControl("/UserControls/LocalPage/AssociationGallery.ascx");
					uc.ucAssociationGallery.ID = string.Format("AssociationGallery{0}", galleryid.ToString());
					uc.ucAssociationGallery.AddGalleryHeader(headertext);
					GalleryPlaceholder.Controls.Add(uc.ucAssociationGallery);
				}
			}
		}

		private void AddArticleGallieries(List<SCUCWEB_WebPageContent> pagecontent)
		{
			int previousgalleryid = -1;

			uc.ucArticleGallery = new ArticleGallery();

			//List<SCUCWEB_WebPageContent> gallerycontent = uc.ucArticleGallery.GetContent(pagecontent);

			List<SCUCWEB_WebPageContent> gallerycontent = helper.GetContent(pagecontent, SCUCConstants.SW_WPCTR_ArticleGallery);

			// get distint to create teh  galleries
			//IEnumerable<int> distinctGalleries = gallerycontent.Select(item => (int)item.SortOrder).Distinct();

			foreach (var gallery in gallerycontent)
			{
				int galleryid = (int)gallery.SortOrder;
				string headertext = (from item in pagecontent where (int)item.SortOrder == galleryid select item.HeaderText).FirstOrDefault();

				if (galleryid != previousgalleryid)
				{
					previousgalleryid = galleryid;
					uc.ucArticleGallery = (ArticleGallery)LoadControl("/UserControls/LocalPage/ArticleGallery.ascx");

					uc.ucArticleGallery.ID = string.Format("ArticleGallery{0}", galleryid.ToString());
					uc.ucArticleGallery.AddGalleryHeader(headertext);
					uc.ucArticleGallery.AddGalleryContent(gallery.SCUCWEB_WebPageContentDetails.ToList());

					ucGalleryPlaceholder.Controls.Add(uc.ucArticleGallery);
				}
			}
		}

		#endregion HELPER_METHODS
	} // ends class LocalPagesBase
} // ends namespace SearsGarageWeb