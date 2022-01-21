<%@ Page Title="서원폐차장 부품 둘러보기" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Portfolio.aspx.cs" Inherits="SeowoncarASP.Portfolio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




  <main id="main">

    <!-- ======= Our Portfolio Section ======= -->
    <section class="breadcrumbs">
      <div class="container">

        <div class="d-flex justify-content-between align-items-center">
          <h2>부품 둘러보기</h2>
          <ol>
            <li><a href="default.aspx">Home</a></li>
            <li>부품 둘러보기</li>
          </ol>
        </div>

      </div>
    </section><!-- End Our Portfolio Section -->

    <!-- ======= Portfolio Section ======= -->
    <section class="portfolio"  id ="divCategory" runat="server">
      <div class="container">
        <div class="row">
          <div class="col-lg-12"  >
            <ul id="portfolio-flters">
              <li data-filter="*" class="filter-active">전체</li>
              <li data-filter=".filter-hyundai">현대</li>
              <li data-filter=".filter-kia">기아</li>
              <li data-filter=".filter-samsung">르노삼성</li>
              <li data-filter=".filter-daewoo">대우</li>
              <li data-filter=".filter-daechang">대창</li>
              <li data-filter=".filter-chevrolet">쉐보레GM</li>
              <li data-filter=".filter-ssangyong">쌍용</li>
              <li data-filter=".filter-foreign">수입</li>
            </ul>
          </div>
        </div>

        <div class="row portfolio-container" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
          <div class="col-lg-4 col-md-6 filter-현대">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-1.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-1.jpg" data-gall="portfolioGallery" class="venobox" title="현대">현대</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-1.jpg" data-gall="portfolioGallery" class="venobox" title="현대"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-르노">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-2.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-2.jpg" data-gall="portfolioGallery" class="venobox" title="기아">기아</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-2.jpg" data-gall="portfolioGallery" class="venobox" title="기아"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-르노">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-3.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-3.jpg" data-gall="portfolioGallery" class="venobox" title="삼성">삼성</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-3.jpg" data-gall="portfolioGallery" class="venobox" title="삼성"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>			
          
          <div class="col-lg-4 col-md-6 filter-르노">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-4.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-4.jpg" data-gall="portfolioGallery" class="venobox" title="대우">대우</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-4.jpg" data-gall="portfolioGallery" class="venobox" title="대우"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>			
          
          <div class="col-lg-4 col-md-6 filter-현대">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-5.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-5.jpg" data-gall="portfolioGallery" class="venobox" title="대창">대창</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-5.jpg" data-gall="portfolioGallery" class="venobox" title="대창"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-현대">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-6.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-6.jpg" data-gall="portfolioGallery" class="venobox" title="쉐보레">쉐보레</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-6.jpg" data-gall="portfolioGallery" class="venobox" title="쉐보레"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-BMW">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-7.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-7.jpg" data-gall="portfolioGallery" class="venobox" title="쌍용">쌍용</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-7.jpg" data-gall="portfolioGallery" class="venobox" title="쌍용"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-BMW">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-8.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-8.jpg" data-gall="portfolioGallery" class="venobox" title="외제차">외제차</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-8.jpg" data-gall="portfolioGallery" class="venobox" title="외제차"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-현대">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-9.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-9.jpg" data-gall="portfolioGallery" class="venobox" title="외제차">외제차</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-9.jpg" data-gall="portfolioGallery" class="venobox" title="외제차"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-BMW">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-10.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-10.jpg" data-gall="portfolioGallery" class="venobox" title="현대 1">현대</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-10.jpg" data-gall="portfolioGallery" class="venobox" title="현대 1"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-르노">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-11.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-11.jpg" data-gall="portfolioGallery" class="venobox" title="기아 3">기아</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-11.jpg" data-gall="portfolioGallery" class="venobox" title="기아 3"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 filter-현대">
            <div class="portfolio-item">
              <img src="assets/img/portfolio/portfolio-12.jpg" class="img-fluid" alt="" />
              <div class="portfolio-info">
                <h3><a href="assets/img/portfolio/portfolio-12.jpg" data-gall="portfolioGallery" class="venobox" title="기아">기아</a></h3>
                <div>
                  <a href="assets/img/portfolio/portfolio-12.jpg" data-gall="portfolioGallery" class="venobox" title="기아"><i class="bx bx-plus"></i></a>
                  <a href="portfolio-details.aspx" title="Portfolio Details"><i class="bx bx-link"></i></a>
                </div>
              </div>
            </div>
          </div>

        </div>

      </div>
    </section><!-- End Portfolio Section -->


      <script>
    $(function() {
        $("#Domestic").on("click", function() {
            $(".Domestic").show();
            $(".Import").hide();
        })
        $("#Import").on("click", function() {
            $(".Import").show();
            $(".Domestic").hide();
        })
        $("#allCar").on("click", function () {
            $(".Import").show();
            $(".Domestic").show();
        })

        

    })
      </script>

  </main><!-- End #main -->




</asp:Content>
