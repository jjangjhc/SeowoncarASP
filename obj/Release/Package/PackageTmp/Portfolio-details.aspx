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

          <div class="owl-carousel portfolio-details-carousel">
            <img src="assets/img/portfolio/portfolio-details-1.jpg" class="img-fluid" alt="">
            <img src="assets/img/portfolio/portfolio-details-2.jpg" class="img-fluid" alt="">
            <img src="assets/img/portfolio/portfolio-details-3.jpg" class="img-fluid" alt="">
          </div>

          <div class="portfolio-info">
            <h3>제품 정보</h3>
            <ul>
              <li><strong>Category</strong>: - </li>
              <li><strong>Client</strong>: - </li>
              <li><strong>Project date</strong>: - </li>
              <li><strong>Project URL</strong>: <a href="#"> - </a></li>
            </ul>
          </div>

        </div>

        <div class="portfolio-description">
          <h2>상세설명 페이지는 아직 작업중입니다.</h2>
          <p>
            주비가 되면 안내하도록 하겠습니다. 감사합니다.
          </p>
        </div>
      </div>
    </section><!-- End Portfolio Details Section -->

  </main><!-- End #main -->

</asp:Content>
