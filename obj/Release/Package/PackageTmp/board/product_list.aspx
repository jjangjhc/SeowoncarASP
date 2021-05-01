<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="product_list.aspx.cs" Inherits="SeowoncarASP.board.product_list" %>


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
                    <h2>상품관리</h2>
                    <ol>
                        <li><a href="/default.aspx">Home</a></li>
                        <li>상품관리</li>
                    </ol>
                </div>

            </div>
        </section>
        <!-- End About Us Section -->

        <section class="team aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
            <div class="container" id="divProuduct" runat="server">
                <div class="row">
                </div>
            </div>
        </section>
        <input id="productid" name="productid" type="hidden" value="" />
        <input id="dmltype" name="dmltype" type="hidden" value="" />
    </main>
    <script src="js/action.js"></script>
</asp:Content>
