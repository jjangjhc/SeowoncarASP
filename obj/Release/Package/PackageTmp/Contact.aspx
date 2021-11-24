<%@ Page Title="서원폐차장 고객센터" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SeowoncarASP.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




  <main id="main">

    <!-- ======= Contact Section ======= -->
    <section class="breadcrumbs">
      <div class="container">

        <div class="d-flex justify-content-between align-items-center">
          <h2>고객센터</h2>
          <ol>
            <li><a href="default.aspx">Home</a></li>
            <li>고객센터</li>
          </ol>
        </div>

      </div>
    </section><!-- End Contact Section -->

    <!-- ======= Contact Section ======= -->
    <section class="contact" data-aos="fade-up" data-aos-easing="ease-in-out" data-aos-duration="500">
      <div class="container">

        <div class="row">

          <div class="col-lg-6">

            <div class="row">
              <div class="col-md-12">
                <div class="info-box">
                  <i class="bx bx-map"></i>
                  <h3>방문 주소</h3>
                  <p>경기도 포천시 호국로 901-62 (설운동 83번지)</p>
                </div>
              </div>
              <div class="col-md-6">
                <div class="info-box">
                  <i class="bx bx-envelope"></i>
                  <h3>이메일 주소</h3>
                  <p>replay8509@hanmail.net<br>redj@kakao.com</p>
                </div>
              </div>
              <div class="col-md-6">
                <div class="info-box">
                  <i class="bx bx-phone-call"></i>
                  <h3>전화번호</h3>
                  <p>일반) 031-541-7700<br>FAX) 031-541-3706</p>
                </div>
              </div>
            </div>

          </div>

          <div class="col-lg-6" id="sendMail" runat="server">
            <div role="form" class="php-email-form">
              <div class="form-row">
                <div class="col-md-6 form-group">
                  <input type="text" name="name" class="form-control" id="name" placeholder="이름" data-rule="minlen:4" data-msg="Please enter at least 4 chars" required />
                  <div class="validate"></div>
                </div>
                <div class="col-md-6 form-group">
                  <input type="email" class="form-control" name="email" id="email" placeholder="이메일 주소" data-rule="email" data-msg="Please enter a valid email" required />
                  <div class="validate"></div>
                </div>
              </div>
              <div class="form-group">
                <input type="text" class="form-control" name="subject" id="subject" placeholder="제목" data-rule="minlen:4" data-msg="Please enter at least 8 chars of subject" required />
                <div class="validate"></div>
              </div>
              <div class="form-group">
                <textarea class="form-control" name="message" rows="5" data-rule="required" data-msg="Please write something for us" placeholder="보낼 메시지" required></textarea>
                <div class="validate"></div>
              </div>
              <div class="mb-3">
                <div class="loading">Loading</div>
                <div class="error-message"></div>
                <div class="sent-message">Your message has been sent. Thank you!</div>
              </div>
              <div class="text-center"><button type="submit">메일 보내기</button></div>
            </div>
          </div>
    
          <div class="col-lg-6" id="sendMailNone"  runat="server">
              <div class="col-md-12">
                <div class="info-box">
                  <i class="bx bx-comment-check"></i>
                  <h3>메일 보내기가 완료되었습니다.</h3>
                </div>
              </div>              
              
          </div>

        </div>

      </div>
    </section><!-- End Contact Section -->

    <!-- ======= Map Section ======= -->
    <section class="map mt-2">
      <div class="container-fluid p-0">
		  <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3150.5560139296217!2d127.15727341531964!3d37.84727867974627!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x357cd04f0c90d55b%3A0xe6b29659eb3d66c0!2z6rK96riw64-EIO2PrOyynOyLnCDshKTsmrTrj5kg7Zi46rWt66GcIDkwMS02Mg!5e0!3m2!1sko!2skr!4v1617028484610!5m2!1sko!2skr" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
        <!--<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3024.2219901290355!2d-74.00369368400567!3d40.71312937933185!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c25a23e28c1191%3A0x49f75d3281df052a!2s150%20Park%20Row%2C%20New%20York%2C%20NY%2010007%2C%20USA!5e0!3m2!1sen!2sbg!4v1579767901424!5m2!1sen!2sbg" frameborder="0" style="border:0;" allowfullscreen=""></iframe>-->
      </div>
    </section><!-- End Map Section -->

  </main><!-- End #main -->

    


</asp:Content>
