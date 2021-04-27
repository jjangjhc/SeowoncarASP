<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="product_delete.aspx.cs" Inherits="SeowoncarASP.board.product_delete" validateRequest="false" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">

    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all">

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

  <main id="main">
        <!-- ======= About Us Section ======= -->
    <section class="breadcrumbs">
      <div class="container">

        <div class="d-flex justify-content-between align-items-center">
          <h2>상품삭제</h2>
          <ol>
            <li><a href="/default.aspx">Home</a></li>
            <li>상품삭제</li>
          </ol>
        </div>

      </div>
    </section><!-- End About Us Section -->
      <section class="contact aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
      <div class="container">

        <div class="row">

          <div class="col-lg-12">
            <div class="row">
              <div class="col-md-12">
                <div class="info-box">
                  <i class="bx bx-map"></i>
                  <h3>삭제되었습니다. </h3>
                  <p>3초뒤 목록으로 이동합니다.</p>
                </div>
              </div>
            </div>

          </div>


        </div>

      </div>
    </section>

                
      
      </main>
    <!-- Main JS-->
    <script src="js/global.js"></script>
    <script src="js/action.js"></script>

</asp:Content>
