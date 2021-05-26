<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SeowoncarASP.Admin.login" %>
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
                        <li><a href="/default.aspx">Home</a></li>
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
                            <div class="form-group">
                                <asp:Label ID="Label1" runat="server" Text="아이디"></asp:Label>
                                <asp:TextBox ID="txtID" CssClass="form-control" runat="server"  data-rule="minlen:4" required=""></asp:TextBox>
                                <asp:Label ID="lblID" runat="server" Text="" CssClass="validate" Visible ="false"></asp:Label>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="비밀번호"></asp:Label>
                                <asp:TextBox ID="txtPW" TextMode="Password" CssClass="form-control" runat="server"  data-rule="minlen:8" data-msg="비밀번호는 8글자 이상입니다." required=""></asp:TextBox>
                                <asp:Label ID="lblPW" runat="server" Text="" CssClass="validate" Visible ="false"></asp:Label>
                            </div>
                            <div class="text-center">
                                <button type="submit">로 그 인</button>
                                <button type="button" onclick="window.open('/admin/signup','_top')">회원가입</button></div>
                        </div>
                    </div>
                </div>

            </div>
        </section>
        <!-- End Contact Section -->

    </main>

</asp:Content>
