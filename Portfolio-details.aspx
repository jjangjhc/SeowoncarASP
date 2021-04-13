<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Portfolio-details.aspx.cs" Inherits="SeowoncarASP.Portfolio_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
  <main id="main">
      
    <!-- ======= Our Portfolio Section ======= -->
    <section class="breadcrumbs">
      <div class="container">

        <div class="d-flex justify-content-between align-items-center">
          <h2>부품 상세보기</h2>
          <ol>
            <li><a href="default.aspx">Home</a></li>
            <li><a href="portfolio.aspx">부품 둘러보기</a></li>
            <li>부품 상세보기</li>
          </ol>
        </div>

      </div>
    </section><!-- End Our Portfolio Section -->

    <!-- ======= Portfolio Details Section ======= -->
    <section class="portfolio-details">
      <div class="container">

        <div class="portfolio-details-container">

          <div class="owl-carousel portfolio-details-carousel" id="imgParent" runat="server">
            <img src="board/upload/2021/04/062250123_1.jpg" class="img-fluid" alt="">
            <img src="board/upload/2021/04/062250123_2.jpg" class="img-fluid" alt="">
            <img src="board/upload/2021/04/062250123_3.jpg" class="img-fluid" alt="">
          </div>
            
          <div class="portfolio-info">
            <h3>제품 정보</h3>
            <ul>
              <li><strong>제조사</strong>: <asp:Label ID="lblMANUFACTURER" runat="server" Text="Label"></asp:Label> </li>
              <li><strong>차량명</strong>: <asp:Label ID="lblNAME" runat="server" Text="Label"></asp:Label> </li>
              <li><strong>연식</strong>: <asp:Label ID="lblYEAR" runat="server" Text="Label"></asp:Label> </li>
              <li><strong>파트넘버</strong>: <asp:Label ID="lblPARTNUM" runat="server" Text="Label"></asp:Label> </li>
              
              <li><strong>차대번호</strong>: <a href="#"> <asp:Label ID="lblVIN" runat="server" Text="Label"></asp:Label> </a></li>
                <li><strong>상품정보</strong>: <asp:Label ID="lblPRODUCTINFO" runat="server" Text="Label"></asp:Label> </li>
                <li><strong>관리번호</strong>: <asp:Label ID="lblPRODUCTID" runat="server" Text="Label"></asp:Label> </li>

            </ul>
          </div>

        </div>
          
        <div class="portfolio-description">
          <h2>상세정보</h2>
          <p>
              <asp:Label ID="lblMOREINFO" runat="server" Text="Label"></asp:Label>
          </p>
        </div>

          
        <div class="portfolio-description">
          <h2>보증 및 반품 교환</h2>
          <p>
            <asp:Label ID="lblRETURNINFO" runat="server" Text="Label"></asp:Label> 
          </p>
        </div>

        <div class="portfolio-description">
          <h2>배송안내</h2>
          <p>
            <asp:Label ID="lblSHIPPINGINFO" runat="server" Text="Label"></asp:Label> 
          </p>
        </div>

        <div class="portfolio-description">
          <h2>상품QNA</h2>
          <p>
            - 
          </p>
        </div>

      </div>
    </section><!-- End Portfolio Details Section -->






  </main><!-- End #main -->

</asp:Content>
