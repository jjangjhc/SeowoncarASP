<%@ Page Title="서원폐차장 문의게시판 글쓰기" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="board_insert.aspx.cs" Inherits="SeowoncarASP.board.board_insert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <main id="main">

        <!-- ======= Contact Section ======= -->
        <section class="breadcrumbs">
            <div class="container">

                <div class="d-flex justify-content-between align-items-center">
                    <h2>문의 게시판</h2>
                    <ol>
                        <li><a href="default.aspx">Home</a></li>
                        <li>문의 게시판</li>
                    </ol>
                </div>

            </div>
        </section>
        <!-- End Contact Section -->

        <!-- ======= Contact Section ======= -->
        <section class="contact aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="php-email-form">
                            <div class="form-group mt-3">
                                <asp:Label ID="Label1" runat="server" Text="작성자" AssociatedControlID="txtUSER_ID"></asp:Label>
                                <asp:TextBox ID="txtUSER_ID" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                            <div class="form-group mt-3">
                                <asp:Label ID="Label2" runat="server" Text="제목" AssociatedControlID="txtTITLE"></asp:Label>
                                <asp:TextBox ID="txtTITLE" runat="server" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                            <div class="form-group mt-3">
                                <asp:Label ID="Label3" runat="server" Text="문의 내용" AssociatedControlID="txtCONTENT_BOARD"></asp:Label>
                                <asp:TextBox ID="txtCONTENT_BOARD" runat="server" CssClass="form-control" required="" TextMode="MultiLine" Height="200px"></asp:TextBox>
                            </div>
                            <div class="form-group mt-3" id="divPASS1" runat="server">
                                <asp:Label ID="Label4" runat="server" Text="비밀번호" AssociatedControlID="txtPASSWORD"></asp:Label>
                                <asp:TextBox ID="txtPASSWORD" TextMode="Password" runat="server" CssClass="form-control" required="" ></asp:TextBox>
                            </div>
                            <div class="form-group mt-3"  id="divPASS2" runat="server">
                                <asp:Label ID="Label5" runat="server" Text="비밀번호 확인" AssociatedControlID="txtPASSWORD2"></asp:Label>
                                <asp:TextBox ID="txtPASSWORD2" TextMode="Password" runat="server" CssClass="form-control" required="" ></asp:TextBox>
                                <asp:Label ID="lblPASSWORD_ERROR" runat="server" Text="" CssClass="validate"></asp:Label>
                            </div>
                            <div class="text-center">
                                <button type="submit">작성완료</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Contact Section -->


    </main>
</asp:Content>
