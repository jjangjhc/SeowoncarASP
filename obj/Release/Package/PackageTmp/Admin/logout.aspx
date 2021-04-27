<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="SeowoncarASP.Admin.logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <main id="main">

        <!-- ======= About Us Section ======= -->
        <section class="breadcrumbs">
            <div class="container">

                <div class="d-flex justify-content-between align-items-center">
                    <h2>로그인</h2>
                    <ol>
                        <li><a href="default.aspx">Home</a></li>
                        <li>로그인</li>
                    </ol>
                </div>

            </div>
        </section>
        <!-- End About Us Section -->
        <!-- ======= Contact Section ======= -->
        <section class="contact aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
            <div class="container">

                <div class="row">
                    <div id="MainContent_sendMail" class="col-lg-12">
                        <div role="form" class="php-email-form">
                            <asp:Label ID="lblREF" runat="server" Text="" Visible="false"></asp:Label>

                            <div class="text-center">
                                <button type="button">로그아웃 되었습니다.</button>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </section>
        <!-- End Contact Section -->

    </main>

</asp:Content>
