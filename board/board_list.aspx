<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="board_list.aspx.cs" Inherits="SeowoncarASP.board.board_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    <link href="css/table.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <main id="main">
        <!-- ======= About Us Section ======= -->
        <section class="breadcrumbs">
            <div class="container">
                <div class="d-flex justify-content-between align-items-center">
                    <h2>문의 게시판</h2>
                    <ol>
                        <li><a href="/default.aspx">Home</a></li>
                        <li>문의 게시판</li>
                    </ol>
                </div>

            </div>
        </section>
        <!-- End About Us Section -->

        

        <section id="secContentBody" runat="server" class="contact aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="php-email-form">
                            <div class="form-group mt-3">
                                <asp:Label ID="Label1" runat="server" Text="작성자" AssociatedControlID="txtUSER_ID"></asp:Label>
                                <asp:TextBox ID="txtUSER_ID" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group mt-3">
                                <asp:Label ID="Label2" runat="server" Text="제목" AssociatedControlID="txtTITLE"></asp:Label>
                                <asp:TextBox ID="txtTITLE" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group mt-3">
                                <asp:Label ID="Label3" runat="server" Text="문의 내용" AssociatedControlID="txtCONTENT_BOARD"></asp:Label>
                                <asp:TextBox ID="txtCONTENT_BOARD" runat="server" CssClass="form-control" TextMode="MultiLine" Height="200px"></asp:TextBox>
                            </div>
                            <div class="text-center" style="display:none;" >
                                <button type="button">작성완료</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>




        <section class="team aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500" style="padding-bottom: 20px ;">
            <div class="container">
                <table class="table table--block" cellspacing="0" cellpadding="0">
                    <thead>
                        <tr>
                            <th style="width:7%">No</th>
                            <th style="width:44%">제목</th>
                            <th style="width:12%">작성자</th>
                            <th style="width:23%;">작성일</th>
                            <th style="width:7%">조회</th>
                            <th style="width:7%">추천</th>
                        </tr>
                    </thead>
                    <tbody id="tbody" runat="server">
                    </tbody>
                </table>
            </div>
        </section>

        <section class="team aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500" style="padding:0 0 20px 0;">
            <div class="container">
                <div class="row">
                    
                    <div id="search" class="col-lg-3 col-md-3" style="visibility:hidden"> 
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="검색"  />
                    </div>
                    <div id="pager_main" class="col-lg-6 col-md-6 d-flex align-items-stretch" style="visibility:hidden" >
                        <ul class="pagination">
                            <li class="page-item disabled"><a class="page-link" href="#">이전</a></li>
                            <li class="page-item"><a class="page-link" href="#">1</a></li>
                            <li class="page-item"><a class="page-link" href="#">2</a></li>
                            <li class="page-item active"><a class="page-link" href="#">3</a></li>
                            <li class="page-item"><a class="page-link" href="#">4</a></li>
                            <li class="page-item"><a class="page-link" href="#">5</a></li>
                            <li class="page-item"><a class="page-link" href="#">다음</a></li>
                        </ul>
                    </div>

                    <div id="write" class="col-lg-3 col-md-3 d-flex" style="height:30px">
                        <input id="hfBOARD_ID" name="hfBOARD_ID" type="hidden" value="1" />
                        <input id="btnBoardInsert" type="button" value="글쓰기" onclick="window.open('board_insert','_top')" />
                    </div>

                </div>
            </div>

        </section>



    </main>


    <script src="js/action.js"></script>

</asp:Content>
