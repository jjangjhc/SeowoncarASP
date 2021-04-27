<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="product_insert.aspx.cs" Inherits="SeowoncarASP.board.product_insert" validateRequest="false" %>


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
          <h2>상품등록</h2>
          <ol>
            <li><a href="/default.aspx">Home</a></li>
            <li>상품등록</li>
          </ol>
        </div>

      </div>
    </section><!-- End About Us Section -->

      <div class="page-wrapper bg-dark p-t-100 p-b-50">
        <div class="wrapper wrapper--w900">
            <div class="card card-6">
                <!--
                <div class="card-heading">
                    <h2 class="title">상품등록</h2>
                </div>
                -->
                <div class="card-body">
                    
                        <div class="form-row">
                            <div class="name"><a href="javascript:fnAutoInsert()">제조사</a></div>
                            <div class="value">
                                <asp:TextBox ID="txtMANUFACTURER" runat="server" CssClass ="input--style-6" placeholder="현대" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">자동차 이름</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtNAME" runat="server" CssClass ="input--style-6" placeholder="소나타"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">연식</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtYEAR" runat="server" CssClass ="input--style-6"  placeholder="2002"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">차대번호(VIN)</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtVIN" runat="server" CssClass ="input--style-6" placeholder="KMHWF35H32A582256"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">파트번호</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtPARTNUM" runat="server" CssClass ="input--style-6" placeholder="246552E000"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">상품정보(간략)</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtPRODUCTINFO" runat="server" CssClass ="input--style-6" placeholder="DMB가능 네비게이션 작동확인 SD 카드포함 사진참고"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                    <!--
                        <div class="form-row">
                            <div class="name">관리번호(자동)</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtPRODUCTID" runat="server" CssClass ="input--style-6" placeholder="202104062250123" ReadOnly ="true"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    -->
                        <div class="form-row">
                            <div class="name">상세정보<br />(HTML가능)</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtMOREINFO" runat="server" TextMode="MultiLine" CssClass ="input--style-6" placeholder="재사용 자동차 부품의 사용은 신품대비 저렴한 가격에 구입이 가능해서 가계에 도움이 될 뿐만 아니라 하나뿐인 지구를 살리는 길이고 후손에게 아름다운 지구 환경을 물려주는 시작점 입니다. 긍지를 가지고 구매 하시고 주변에 널리 알려 주시기 바랍니다." ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">보증 및 반품 교환<br />(HTML가능)</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtRETURNINFO" runat="server"  TextMode="MultiLine" CssClass ="input--style-6" placeholder="보증 및 반품 교환 정보를 입력하세요"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">배송안내<br />(HTML가능)</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtSHIPPINGINFO" runat="server" TextMode="MultiLine" CssClass ="input--style-6" placeholder="배송 정보를 입력하세요"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    <!--
                        <div class="form-row">
                            <div class="name">작성자</div>
                            <div class="value">
                                <div class="input-group">
                                    <asp:TextBox ID="txtPUBLISHER" runat="server" CssClass ="input--style-6" placeholder="작성자"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    -->
                        <div class="form-row">
                            <div class="name">이미지첨부1</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload CssClass="input-file" ID="FileUpload1" runat="server" />
                                    <label class="label--file" for="MainContent_FileUpload1">Choose file</label>
                                    <span class="input-file__info">No file chosen</span>
                                </div>
                                <!--<div class="label--desc">이미지 사이즈가 크면 자동조절됨(아직안됨)</div>-->
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">이미지첨부2</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload CssClass="input-file" ID="FileUpload2" runat="server" />
                                    <label class="label--file" for="MainContent_FileUpload2">Choose file</label>
                                    <span class="input-file__info">No file chosen</span>
                                </div>
                                <!--<div class="label--desc">이미지 사이즈가 크면 자동조절됨(아직안됨)</div>-->
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">이미지첨부3</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload CssClass="input-file" ID="FileUpload3" runat="server" />
                                    <label class="label--file" for="MainContent_FileUpload3">Choose file</label>
                                    <span class="input-file__info">No file chosen</span>
                                </div>
                                <!--<div class="label--desc">이미지 사이즈가 크면 자동조절됨(아직안됨)</div>-->
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">이미지첨부4</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload CssClass="input-file" ID="FileUpload4" runat="server" />
                                    <label class="label--file" for="MainContent_FileUpload4">Choose file</label>
                                    <span class="input-file__info">No file chosen</span>
                                </div>
                                <!--<div class="label--desc">이미지 사이즈가 크면 자동조절됨(아직안됨)</div>-->
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="name">이미지첨부5</div>
                            <div class="value">
                                <div class="input-group js-input-file">
                                    <asp:FileUpload CssClass="input-file" ID="FileUpload5" runat="server" />
                                    <label class="label--file" for="MainContent_FileUpload5">Choose file</label>
                                    <span class="input-file__info">No file chosen</span>
                                </div>
                                <!--<div class="label--desc">이미지 사이즈가 크면 자동조절됨(아직안됨)</div>-->
                            </div>
                        </div>
                        
                </div>
                <div class="card-footer">
                    <button class="btn btn--radius-2 btn--blue-2" type="submit">등록완료</button>
                </div>
            </div>
        </div>
    </div>
      
      </main>
    <!-- Main JS-->
    <script src="js/global.js"></script>
    <script src="js/action.js"></script>

</asp:Content>
