<%@ Page Title="" Language="C#" MasterPageFile="../Overview.Master" AutoEventWireup="true" CodeBehind="~/locations/Columbus-OH.aspx.cs" Inherits="SearsGarageWeb.locations.Columbus_OH %>

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
<asp:Content ID="LeftNav" ContentPlaceHolderID="leftNav" runat="server">
	<uc:ucLeftNavLocalPage runat="server" ID="ucLeftNavLocalPage" />
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="pagetitle">
		Columbus Garage Doors, Garage Door Openers, and Garage Door Repair
	</div>
	<!-- end of pagetitle -->
	<div id="LocalpageHeader" class="groupcontainer edgetoedge-all">
		<div class="hide containercaption">
		</div>
		<div class="duoBlock-10 block">
			<div class="subcontainer leftside image">
				<img src="../images/Doors_515/StlCarr_515/StlCarrBBMoonltBlRdgHndl_515.jpg" alt="" />
			</div>
			<div class="subcontainer rightside _edgetoedge-all localsOfferContent sectionmargin">
				<uc:ucLocalOffers runat="server" ID="ucLocalOffers" OfferCountToReturn="1" />
			</div>
			<!-- estimateform -->
		</div>
	</div>
	<!-- end of LocalpageHeader -->
	<uc:SpecialOfferGallery runat="server" ID="ucSpecialOfferGallery" />
	<div id="RepairsOffered" class="groupcontainer edgetoedge">
		<div class="containercaption">
			Learn More About Columbus Garage Door Products & Services
		</div>
		<div class="triBlock edgetoedge">
			<div class="subcontainer leftside border">
				<div class="image seperator">
					<img src="../images/GDO_225/GDO_53990_3_4HPChain_225.jpg" alt="" />
				</div>
				<div class="article">
					<div class="articlecaption">
						Sears Garage Doors
					</div>
					<div class="articletext">
						Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dapibus facilisis massa, placerat vehicula libero laoreet eget.
					</div>
				</div>
				<input id="Button6" class="buttonasbutton fixed" type="button" name="locateGarageDoor" value="View Garage Door Openers" />
			</div>
			<!-- end of subcontainer.first -->
			<div class="subcontainer border">
				<div class="image seperator">
					<img src="../images/GDO_225/GDO53915_1_2HPBelt_225.jpg" alt="" />
				</div>
				<div class="_article">
					<div class="articlecaption">
						Garage Door Openers
					</div>
					<div class="articletext">
						Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dapibus facilisis massa, placerat vehicula libero laoreet eget.
					</div>
				</div>
				<input id="Button7" class="buttonasbutton fixed" type="button" name="locateGarageDoorOpener" value="View Garage Door Openers" />
			</div>
			<!-- end of subcontainer -->
			<div class="subcontainer rightside border">
				<div class="image seperator">
					<img src="../images/GDO_225/GDO_Assurelink3043_225.jpg" alt="" />
				</div>
				<div class="article">
					<div class="articlecaption">
						Garage Door Repair
					</div>
					<div class="articletext">
						Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dapibus facilisis massa, placerat vehicula libero laoreet eget.
					</div>
				</div>
				<input id="Button8" class="buttonasbutton fixed" type="button" name="locateRepairService" value="View Garage Door Openers" />
			</div>
			<!-- end of subcontainer.last -->
		</div>
	</div>
	<!-- end of RepairsOffered -->
	<uc:MediaGallery runat="server" ID="ucMediaGallery" />
	<div class="groupcontainer">
		<div class="containercaption underline">
			Columbus Garage Door Frequently Asked Questions
		</div>
		<div class="uniBlock subcontainer">
			Most garage door springs should last about 5 years. The basic garage door spring should last for 10,000 to 15,000 cycles while the extended life spring
			can last for 100,000 cycles.
		</div>
	</div>
	<!-- end of FAQ -->
	<uc:AssociationGallery runat="server" ID="ucAssociationGallery" />
	<uc:ArticleGallery runat="server" ID="ucArticleGallery" />
	<uc:LinkGallery runat="server" ID="ucLinkGallery" />
	<uc:AboutUsGallery runat="server" ID="ucAboutUsGallery" />
</asp:Content>