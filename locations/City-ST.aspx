<%@ Page Title="" Language="C#" MasterPageFile="~/Overview.Master" AutoEventWireup="true" CodeBehind="LocalPages.aspx.cs" Inherits="SearsGarageWeb.LocalPagesBasePage" %>

<%@ Register Src="/UserControls/LocalPage/SpecialOfferGallery.ascx" TagPrefix="uc" TagName="SpecialOfferGallery" %>
<%@ Register Src="/UserControls/LocalPage/AboutUsGallery.ascx" TagPrefix="uc" TagName="AboutUsGallery" %>
<%@ Register Src="/UserControls/LocalPage/LinkGallery.ascx" TagPrefix="uc" TagName="LinkGallery" %>
<%@ Register Src="/UserControls/LocalPage/ArticleGallery.ascx" TagPrefix="uc" TagName="ArticleGallery" %>
<%@ Register Src="/UserControls/LocalPage/AssociationGallery.ascx" TagPrefix="uc" TagName="AssociationGallery" %>
<%@ Register Src="/UserControls/LocalPage/MediaGallery.ascx" TagPrefix="uc" TagName="MediaGallery" %>
<%@ Register Src="/UserControls/Navigation/LocalOffers.ascx" TagPrefix="uc" TagName="ucLocalOffers" %>
<%@ Register Src="/UserControls/Navigation/LeftNavLocalPage.ascx" TagPrefix="uc" TagName="ucLeftNavLocalPage" %>
<script runat="server">
	void Page_Init(object sender, System.EventArgs e)
	{
		base.WebPageID = new Guid("29F72EF0-FFD7-4961-BFA2-B8A074C222DA");
	}
</script>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<div id="ucholder" runat="server">
	</div>
	<asp:PlaceHolder ID="GalleryPlaceholder" runat="server"></asp:PlaceHolder>
</asp:Content>