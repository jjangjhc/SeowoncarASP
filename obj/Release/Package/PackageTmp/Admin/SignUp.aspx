<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SeowoncarASP.Admin.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <main id="main">
        <!-- ======= About Us Section ======= -->
        <section class="breadcrumbs">
            <div class="container">

                <div class="d-flex justify-content-between align-items-center">
                    <h2>회원 가입</h2>
                    <ol>
                        <li><a href="/default.aspx">Home</a></li>
                        <li>회원 가입</li>
                    </ol>
                </div>

            </div>
        </section>
        <!-- End About Us Section -->

        <section class="contact aos-init aos-animate" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
            <div class="container">

                <div class="row">

                    <div id="MainContent_sendMail" class="col-lg-12">
                        <div role="form" class="php-email-form">
                            <div class="form-group">
                                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" placeholder="아이디" data-rule="minlen:4" data-msg="아이디는 4자리 이상 입력바랍니다." required="" ></asp:TextBox>
                                <asp:Label ID="lblID" runat="server" Text="" CssClass="validate" Visible ="false"></asp:Label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox TextMode="Password" ID="txtPW1" CssClass="form-control" runat="server" placeholder="비밀번호" data-rule="minlen:4" data-msg="비밀번호는 4자리 이상 입력바랍니다." required="" ></asp:TextBox>
                                <asp:TextBox TextMode="Password" ID="txtPW2" CssClass="form-control" runat="server" placeholder="비밀번호 확인" data-rule="minlen:4" data-msg="비밀번호는 4자리 이상 입력바랍니다." required="" ></asp:TextBox>
                                <asp:Label ID="lblPW" runat="server" Text="" CssClass="validate" Visible ="false"></asp:Label>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtName" CssClass="form-control" runat="server" placeholder="이름" data-rule="minlen:4" data-msg="이름은 선택사항 입니다." ></asp:TextBox>
                                <div class="validate"></div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtEMAIL" CssClass="form-control" runat="server" placeholder="이메일 주소" data-rule="minlen:4" data-msg="이메일 형식에 맞게 입력 바랍니다." ></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtPHONE" CssClass="form-control" runat="server" placeholder="전화번호(연락처)" data-rule="minlen:4" data-msg="" ></asp:TextBox>
                                <div class="validate"></div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtADDRESS" CssClass="form-control" runat="server" placeholder="주소" data-rule="minlen:4" data-msg="주소는 선택사항입니다."  ></asp:TextBox>
                                <div class="validate"></div>
                            </div>
                            <div class="mb-3">
                                <div class="loading">Loading</div>
                                <div class="error-message"></div>
                                <div class="sent-message">Your message has been sent. Thank you!</div>
                            </div>
                            <div class="text-center">
                                <button type="submit">회원가입</button>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </section>
        <!-- End Contact Section -->

    </main>
</asp:Content>
