<%@ Page Title="서원폐차장" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="SeowoncarASP.Services" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



  <main id="main">

    <!-- ======= Our Services Section ======= -->
    <section class="breadcrumbs">
      <div class="container">

        <div class="d-flex justify-content-between align-items-center">
          <h2>폐차안내</h2>
          <ol>
            <li><a href="default.aspx">Home</a></li>
            <li>폐차안내</li>
          </ol>
        </div>

      </div>
    </section><!-- End Our Services Section -->

    <!-- ======= Services Section ======= -->
    <section class="services">
      <div class="container">

        <div class="row">
          <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up">
            <div class="icon-box icon-box-pink">
              <div class="icon"><i class="bx bxl-dribbble"></i></div>
              <h4 class="title"><a href="">1.폐차신청</a></h4>
              <p class="description">아래 연락처로 폐차신청 <br><br>전화 031) 541-7700<br>팩스 031) 541-3706 <br><br>신청 시 차량위치, 차종, 차량번호, 연락처, 폐차대금 입금계좌번호를 알려주셔야 합니다.</p>
            </div>
          </div>

          <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up" data-aos-delay="100">
            <div class="icon-box icon-box-cyan">
              <div class="icon"><i class="bx bx-file"></i></div>
              <h4 class="title"><a href="">2. 차량등록원부 조회</a></h4>
              <p class="description">압류, 저당설정 여부 확인(주정차위반, 자동차세, 속도위반 등) 압류사항 확인후 지정된 시간에 무료견인 압류사항이 있으면 조회결과를 고객에게 전화 및 이메일 통보 ​압류해제는 본인이 직접 하시거나 압류해제 대행 의뢰를 하실 수 있습니다.</p>
            </div>
          </div>

          <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up" data-aos-delay="200">
            <div class="icon-box icon-box-green">
              <div class="icon"><i class="bx bx-tachometer"></i></div>
              <h4 class="title"><a href="">3.견인</a></h4>
              <p class="description">개인차량 > 자동차등록증, 주민등록 초본이나 신분증(주민등록증,면허증) 앞뒤 사본<br><br>법인차량 > 법인 인감, 법인등기부등본, 사업자등록증(사본), 지방세 완납증명서, 차량등록증(법인 인감, 법인등기부등본[말소사항포함]은 발행기간이 1개월 이내인것만 유효합니다.)<br><br> 개인사업장차량 > 차량등록증, 신분증 사본, 사업사실증명서(말소 사항 포함)→관할세무소에서 발행</p>
            </div>
          </div>

          <div class="col-md-6 col-lg-3 d-flex align-items-stretch" data-aos="fade-up" data-aos-delay="200">
            <div class="icon-box icon-box-blue">
              <div class="icon"><i class="bx bx-world"></i></div>
              <h4 class="title"><a href="">4. 폐차 현금지급 및 말소증 송부</a></h4>
              <p class="description">견인 완료 후 바로 On-line 송금 <br> 견인 완료 후 2~5일 이내 말소등록완료, 등기 우편 또는 FAX로 발송 </p>
            </div>
          </div>

        </div>

      </div>
    </section><!-- End Services Section -->

    <!-- ======= Why Us Section ======= -->
    <section class="why-us section-bg" data-aos="fade-up" date-aos-delay="200" style="display: none">
      <div class="container" >

        <div class="row" >
          <div class="col-lg-6 video-box">
            <img src="assets/img/why-us.jpg" class="img-fluid" alt="">
            <a href="https://www.youtube.com/watch?v=jDDaplaOz7Q" class="venobox play-btn mb-4" data-vbtype="video" data-autoplay="true"></a>
          </div>

          <div class="col-lg-6 d-flex flex-column justify-content-center p-5">

            <div class="icon-box">
              <div class="icon"><i class="bx bx-fingerprint"></i></div>
              <h4 class="title"><a href="">Lorem Ipsum</a></h4>
              <p class="description">Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident</p>
            </div>

            <div class="icon-box">
              <div class="icon"><i class="bx bx-gift"></i></div>
              <h4 class="title"><a href="">Nemo Enim</a></h4>
              <p class="description">At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque</p>
            </div>

          </div>
        </div>

      </div>
    </section><!-- End Why Us Section -->

    <!-- ======= Service Details Section ======= -->
    <section class="service-details">
      <div class="container">

        <div class="row">
          <div class="col-md-6 d-flex align-items-stretch" data-aos="fade-up">
            <div class="card">
              <div class="card-img">
                <img src="assets/img/service-details-1.jpg" alt="...">
              </div>
              <div class="card-body">
                <h5 class="card-title"><a href="#">조기 폐차</a></h5>
                <p class="card-text">
<pre>[수도권대기환경개선에 관한 특별법] 및 [대기환경보존법]에 의거하여 수도권내 대기환경을 보호하기 위해 특정경유자동차를 폐차하는 경우 일정 기준에 부합하면 보조금을 지급하여 공해차량의 폐차를 적극적으로 유도하는 제도로써 수도권 지자체(서울, 인천, 경기) 주관으로 시행되고 있는 제도
				  
조기폐차 대상차량

01. 대기관리권역에 2년 이상 연속하여 등록된 경유자동차

02. 검사결과가 [대기환경보전법] 63조 규정에 의한 운행차 정밀검사의 배출허용기준 이내인 자동차

03. 서울특별시장등 또는 절차대행자가 발급한 '중고자동차 성능점검 결과표'상 정상가동 판정이 있는 자동차

04. 정부지원(일부지원 포함)을 통해 배출가스점검장치를 부착하거나 저공해 엔진으로 개조한 사실이 없는 자동차

05. 주행을 목적으로 하는 경유 자동차

06. 최종 소유자의 소유기간이 6개월 이상인 경유 자동차

07.차령 7년 이상인 자동차

대기관리권역

제1권역 : 고양시, 파주시, 연천군, 동두천시
제2권역 : 양주시, 포천시, 의정부시, 가평군, 남양주시, 양평군
제3권역 : 인천광역시, 김포시, 부천시, 시흥시, 안산시, 광명시, 과천시, 군포시, 안양시, 수원시
제4권역 : 의왕시, 화성시, 오산시, 평택시, 용인시
제5권역 : 구리시, 하남시, 성남시, 광주시, 이천시, 여주시, 안성시

운행경유차 정밀검사 배출허용기준
					
					<table class="basic" cellspacing="0" cellpadding="0" width="100%" border="1"><tbody>
<tr>
<th rowspan="2">구분</th>
<th rowspan="2">제작일자</th>
<th colspan="3">매연농도</th></tr>
<tr>
<th width="120">1모드</th>
<th width="120">2모드</th>
<th width="120">3모드</th></tr>
<tr>
<td rowspan="2" align="center">차량 총중량 5.5톤 이하</td>
<td align="center">1995.12.31.이전</td>
<td colspan="3" align="center">70%</td></tr>
<tr>
<td align="center">1996.01.01.이후</td>
<td colspan="3" align="center">60%</td></tr>
<tr>
<td rowspan="4" align="center">차량 총중량 5.5톤 초과</td>
<td align="center">1995.12.31.이전</td>
<td colspan="3" align="center">50%</td></tr>
<tr>
<td align="center">1996.1.1 ~ 2000.12.31</td>
<td colspan="3" align="center">45%</td></tr>
<tr>
<td align="center">2001.1.1~2007.12.31</td>
<td colspan="3" align="center">30%</td></tr>
<tr>
<td align="center">2008.01.01. 이후</td>
<td colspan="3" align="center">20%</td></tr></tbody></table>
				  
<img	src ="https://static.wixstatic.com/media/584927_d827522e1ffc4be7bcb5cb4378e6d180~mv2.jpg/v1/fill/w_600,h_300,al_c,q_80,usm_0.66_1.00_0.01/584927_d827522e1ffc4be7bcb5cb4378e6d180~mv2.webp">

지원금액

​차종 및 연시에 따라 보험개발원이 산정한 분기별 차량 기준가액의 80%까지 지원하되 아래의 보조금 상한액 범위 내에세 지원
(단, 저소득층은 90% 지원)

<table class="basic" cellspacing="0" cellpadding="0" width="100%" border="1"><tbody>
<tr>
<th width="53%">구분</th>
<th width="47%">조기폐차 보조금 상한액</th></tr>
<tr>
<td align="center">총중량 3.5톤 미만</td>
<td align="center">100</td></tr>
<tr>
<td align="center">총중량 3.5톤 이상 중 적재중량<br>2.5톤급(배기량 3,000cc~6,000cc) </td>
<td align="center">300</td></tr>
<tr>
<td align="center">총중량 3.5톤 이상 중 배기량 6,000cc 초과</td>
<td align="center">600</td></tr>
<tr>
<td colspan="2" align="center">* 저소득층 : 종합소득금액이 2,400만원 이하인 자영업자 및 연봉 3,600만원 이하인 근로자를 말함 <br>(관할 세무서 발급)</td></tr></tbody></table>

차종별 조기폐차 보조금 상한액

차종분류는 자동차등록증에 기재된 출고 당시의 차종 형식 중 기본형으로 함

당해 연도 분기별 차량기준가액표에 적시된 금액을 차량기준가액으로 하고, 당해 연도 기준가액표에 표기되지 않은 연식의 차량가액은 당해 연식이 기재된 최근 연도 기준가액에 매년 20%의 감가상각을 적용하여 산정

산정된 기준가액의 최소지급 단위는 만원으 하고, 만원 이하 단위는 절삭

차량기준가액표에 표기되지 아니한 차량의 경우에는 제작사, 차명, 형식(외형), 차량용도, 차령을 기준으로 가장 유사한 기준가액을 적용

​차량용도 구분은 자동차등록증에 기재된 것을 기준으로 하되, 영업용으로 사용된 이력이 있는 차량은 이를 영업용으로 적용

					</pre>
				  
				  
				  
				  
				  
				  </p>
                <div class="read-more"><a href="#"><i class="icofont-arrow-right"></i> Read More</a></div>
              </div>
            </div>
          </div>
          <div class="col-md-6 d-flex align-items-stretch" data-aos="fade-up">
            <div class="card">
              <div class="card-img">
                <img src="assets/img/service-details-2.jpg" alt="...">
              </div>
              <div class="card-body">
                <h5 class="card-title"><a href="#">중기 폐차</a></h5>
                <p class="card-text"></p>
<pre>
건설 중기 폐차 견인에서 말소까지 원스톱 무료서비스

건설 중기 폐차
건설 기계의 소유권에 대한 공정증명과 사용의 허가를 소멸케 하는 행정행위를 말하며 소유자의 신청이나 등록 관청이 직원을 통하여 말소할 수 있다.

1. 건설 중기 폐차 절차 주의사항

01. 필요서류를 준비 후 폐차장으로 신청합니다. (전화 031) 541-7700 또는 팩스 031) 541-3706)
02. 견인시 견인기사님께 필요서류를 전달합니다.
03. 폐차장에서 서류 처리 및 행정적 시간 소요는 5~10분입니다.
04. 신고된 폐차장에서 폐기하시고 "폐기대상건설기계인수증명서" 를 발급받아야 합니다. 만약 무허가업소에 폐기대행을 의뢰한 경우 "폐기대상건설기계인수증명서"를 발급 받을 수 없으며 문제 발생시 모든 책임은 건설기계소유자에게 있으므로 반드시 등록된 폐기사업장에 신청하셔야 합니다.

​

* 말소등록 신청시한 : 사유발생일로 1개월 이내(기한 경과시 과태료 20만원)
* 말소등록을 하셔야만 건설기계 소유자에 따른 제반의 의무사항(각종 세금, 검사등)이 소멸됩니다.

2. 폐기 불가능 건설 중기

01. 저당권이 설정되었거나 압류등록이 된 경우

- 이해관계인 해지증서 및 인감증명서를 제출하는 경우에는 폐기가 가능합니다.
- 할부건설기계의 할부금이 완납되었다 하더라도 저당권을 해지해야만 폐기가 가능합니다.

​

02. 차대번호등 등록사항이 건설기계 등록원부의 기재내용과 다른 경우에는 폐기를 할 수 없습니다.

3. 필요서류

개인소유

건설기계등록증
건설기계등록원부
차주인감증명서 1통

​

법인소유

건설기계등록증
건설기계등록원부
법인인감증명서 1통
사업자등록증명원​

3-1. 말소 사유에 따른 추가 구비서류

건설기계 멸실시 

(건설기계를 정비하여 다시 사용할 수 없음을 입증하는 진술서)멸실증명서 

​

건설기계 용도폐지시 

건설기계를 운행하지 아니하는 사실증명 

​

건설기계 도난시 

경찰서장이 발행한 도난 신고 접수 확인원 

​

건설기계 폐기한때 (직권말소)

폐기업자가 발행한 폐기 증명서

</pre>				  
				  
                <div class="read-more"><a href="#"><i class="icofont-arrow-right"></i> Read More</a></div>
              </div>
            </div>

          </div>
          <div class="col-md-6 d-flex align-items-stretch" data-aos="fade-up">
            <div class="card">
              <div class="card-img">
                <img src="assets/img/service-details-3.jpg" alt="...">
              </div>
              <div class="card-body">
                <h5 class="card-title"><a href="#">압류 폐차</a></h5>
                <p class="card-text">
<pre>
압류 폐차, 견인에서 말소까지 원스톱 무료 서비스

차량초과 말소 관련 법령
자동차 등록령 법 제 13조 1항 7호에 의하여 대통령이 정하는 기준에 의하여 환가 가치가 남아 있지 아니하다고 인정되는 경우 압류등록된 차량이라도 차령초과말소신청에 의하여 압류촉탁자에 의하여 권리행사를 진행하지 않는 차량은 말소가 가능하다.

1. 압류 차랑 폐차 조건(차량연식)

소형 - 승용 - 1500cc 미만 - 11년
소형 - 화물 - 1ton 미만 - 10년
소형 - 승합 - 10인 이하 - 10년

​

중형 - 승용 - 2000cc 미만 - 11년
중형 - 화물 - 1ton~5ton 이하 - 12년
중형 - 승합 - 10~35인 - 10년

​

대형 - 승용 - 2000cc 미만 - 11년
대형 - 화물 - 5ton 이상 - 12년
대형 - 승합 - 35인 이상 - 10년

2. 압류 차량 폐차 필요서류

- 자동차 등록증 원본
- 신분증 사본
- 인감증명서

3. 압류 차량 폐차 절차 및 방법

01. 폐차신청

전화 031)541-7700 또는 팩스 031)541-3706 으로 폐차 신청

​

02. 차량등록원부조회

즉시 조회하여 고객님 연락처로 통보합니다.

​

03. 서원폐차장에 서류 접수


고객님께 필요서류를 저희에게 FAX로 발송해 주시고, 팩스를 보내시면 서원에서 입고신청서를 발부합니다.

(필요서류 : 자동차 등록증, 신분증 사본, 서원 FAX : 031) 541-3706)

​

04. 견인

견인시 서원의 견인기사님께 인감증명서를 전달하시고 서원에서 입고신청서를 고객님께 전달합니다.

​

05. 구청에 서류 접수

고객님이 현재 살고 계시는 관할구청에 가셔서 차량등록계에 입고신청서, 자동차등록증 원본, 인감증명서(대리인 위임장)을 접수하시면 됩니다.

​

06. 통보

40~50일 후 말소공문이 떨어지면 서원에서 말소 신청 후 차주님께 말소 사실을 통보해 드립니다.

더 자세한 내용이나 궁금한 사항은 전화로 문의주시면 친절히 상담해 드립니다.
</pre>				  
				  
				  </p>
                <div class="read-more"><a href="#"><i class="icofont-arrow-right"></i> Read More</a></div>
              </div>
            </div>
          </div>
         
		  
          <div class="col-md-6 d-flex align-items-stretch" data-aos="fade-up">
            <div class="card">
              <div class="card-img">
                <img src="assets/img/service-details-4.jpg" alt="...">
              </div>
              <div class="card-body">
                <h5 class="card-title"><a href="#">구비서류</a></h5>
                <p class="card-text">
<pre>
폐차시 구비서류

개 인

- 자동차 등록증(검사증)
- 자동차 등록원부(폐차요청 3일 이내)
- 신분증(주민등록증, 여권, 운전면허증 등)
- 자동차 소유자 인감증명서(대리인)

​

법 인

- 자동차 등록증(검사증)
- 자동차 등록원부(폐차요청 3일 이내)
- 신분증(주민등록증, 여권, 운전면허증 등)
- 사업자등록증
- 법인 인감증명서

말소시 구비서류

폐차 후에는 말소신고를 하고 말소가 정확히 되었는 지 확인하신 후 말소등록을 하셔야 자동차소유자의 제반 의무사항(자동차세, 검사 등)이 소멸됩니다.

 

말소등록 신청기한
폐차 인수증 발급 후 1개월 이내에 관할 시/도 등록관청에 반드시 말소등록을 하셔야 합니다.(기한 경과시 과태료 50만원)

​

개 인
- 폐차인수증명서 
- 자동차 등록증(검사증) 
- 주민등록 초본 
- 지방세 완납 증명서 1부
   (서울자동차일경우 제외)
- 인감증명서(대행시) 


법 인
- 폐차인수증명서 
- 자동차등록증(검사증) 
- 사업자등록증(사본) 
- 등기부 등본 
- 지방세 완납 증명서 1부
  (서울자동차일경우제외)
- 법인인감 


</pre>				  
				  </p>
                <div class="read-more"><a href="#"><i class="icofont-arrow-right"></i> Read More</a></div>
              </div>
            </div>
          </div>		


          <div class="col-md-6 d-flex align-items-stretch" data-aos="fade-up">
            <div class="card">
              <div class="card-img">
                <img src="assets/img/service-details-5.jpg" alt="...">
              </div>
              <div class="card-body">
                <h5 class="card-title"><a href="#">과태료</a></h5>
                <p class="card-text">
<pre>
가산금 적용항목
<table class="basic" cellspacing="0" cellpadding="0" width="100%" border="1"><tbody>
<tr>
<th width="188"><strong>위반사항</strong></th>
<th width="130"><strong>유효기간</strong></th>
<th width="166"><strong>위반기간</strong></th>
<th width="196"><strong>과태료 및 벌금</strong></th></tr>
<tr>
<td rowspan="3">임시운행기간(10일) 경과</td>
<td rowspan="3">10일</td>
<td>허가기간 만료일부터 <br>10일이내</td>
<td>과태료 및 벌금</td></tr>
<tr>
<td rowspan="2">11일 이상일때</td>
<td>매 1일 초과시마다 1만원씩 <br>가산</td></tr>
<tr>
<td>최고 100만원</td></tr>
<tr>
<td rowspan="3">
<p align="left">소유권 이전 등록기간 경과 <br>(매매: 15일 증여:20일<br>상속:3월) </p></td>
<td rowspan="3">매매: 15일<br>증여:20일<br>상속:3월</td>
<td>이전등록 만료일부터 <br>10일 이내</td>
<td>10만원 </td></tr>
<tr>
<td rowspan="2">11일 이상일때</td>
<td>매 1일 초과시마다 1만원씩 <br>가산</td></tr>
<tr>
<td>최고 50만원</td></tr>
<tr>
<td rowspan="3">정기 검사기간(30일) 경과</td>
<td rowspan="3">검사일부터<br>15일 이내</td>
<td>초과 30일간</td>
<td>2만원 </td></tr>
<tr>
<td rowspan="2">31일 이상일때</td>
<td>매 3일 초과시 1만원씩 가산</td></tr>
<tr>
<td>최고 30만원</td></tr>
<tr>
<td rowspan="2">주소변경등록기간 (15일)경과<br>개인 : 전입일부터 <br></td>
<td rowspan="2">15일</td>
<td>변경등록기간 만료일부터<br>90일 이내</td>
<td>2만원</td></tr>
<tr>
<td>91일 이상일때</td>
<td>매 3일 초과시 1만원씩 가산</td></tr>
<tr>
<td>범인 : 등기발생일</td>
<td></td>
<td></td>
<td>최고 30만원</td></tr>
<tr>
<td rowspan="6">책임보험 미가입 <br>(계약기간 만료일과 갱신 가입일 <br>사이 1일 이상 공백시)</td>
<td rowspan="6">
<p align="left">계약일 만료일과 <br>갱신가입일 사이 1일 <br>공백시</p></td>
<td rowspan="3">
<p align="left">만료일부터 10일 이내 11일<br>이상일때(자가용)</p></td>
<td>10,000원</td></tr>
<tr>
<td>매 1일 초과시마다 4,000원씩 가산</td></tr>
<tr>
<td>최고 600,000원</td></tr>
<tr>
<td rowspan="3">만료일부터 10일 이내 11일<br>이상일때(사업용)</td>
<td>30,000원</td></tr>
<tr>
<td>매 1일 초과시마다 8,000원씩 가산</td></tr>
<tr>
<td>최고 1,000,000원</td></tr>
<tr>
<td rowspan="3">대물보험 미가입</td>
<td rowspan="3">계약일 만료일과 <br>갱신가입일 사이 1일 <br>공백시</td>
<td rowspan="3">만료일부터 10일 이내 <br>11일 이상일때<br>(사업자와 개인 동일적용)</td>
<td>5,000원</td></tr>
<tr>
<td>1일초과시마다 2,000원씩 <br>가산</td></tr>
<tr>
<td>최고 30만원</td></tr></tbody></table>

가산금 적용항목

<table class="basic" cellspacing="0" cellpadding="0" width="100%" border="1"><tbody>
<tr>
<th width="186"><strong>위반사항</strong></th>
<th width="303"><strong>위반기간</strong></th>
<th width="191"><strong>과태료 및 벌금</strong></th></tr>
<tr>
<td rowspan="4">폐차후 말소 미등록</td>
<td>폐차인수 증명서 발급일부터 30일 초과시</td>
<td>매 1일 초과시마다 1만원씩 가산</td></tr>
<tr>
<td>초과후 10일까지 5만원</td>
<td>최고 50만원</td></tr>
<tr>
<td>수출말소 등록후 6개월 이내에 수출이행</td>
<td rowspan="2">최고 20만원</td></tr>
<tr>
<td>미신고시</td></tr>
<tr>
<td rowspan="3">명의 이전</td>
<td>자동차를 양도하고 이전등록신청에 <br>필요한 서류를 양수인에게 교부하지 아니한 때</td>
<td>20만원</td></tr>
<tr>
<td>자동차를 양수받은 자가 자기명의로 <br>이전 등록을 하지않고 이를 양도한 때</td>
<td>50만원</td></tr>
<tr>
<td>자동차를 인수하고 양도인이 요구하는 이전등록<br>신청에 필요한 서류를 양도인 에게 기한내에<br>교부하지 아니한 때 </td>
<td>10만원</td></tr>
<tr>
<td rowspan="3">등록번호판</td>
<td>자동차 소유자가 직접 자동차등록번호판을<br>붙이지 않거나 봉인을 하지 아니한 때</td>
<td>50만원</td></tr>
<tr>
<td>등록번호판을 부착하지 않거나 봉인을 하지않고 운행한 때</td>
<td>30만원</td></tr>
<tr>
<td>자동차 등록번호판 또는 봉인이 떨어지거나<br>알아보기 어렵게 된 때</td>
<td>10만원</td></tr>
<tr>
<td>등록증</td>
<td>자동차등록증을 비치하지 않고 자동차를 운행할때</td>
<td>10만원</td></tr>
<tr>
<td>자동차를 정당하게 폐차하지 않고 <br>노변 등에 무단 방치할 때 </td>
<td>&nbsp;</td>
<td>1년 이하의 징역또는 <br>100만원 이하의 벌금 </td></tr>
<tr>
<td>자동차의 외부, 내부를 허가없이 <br>임의로 구조변경할 때 </td>
<td>&nbsp;</td>
<td>1년 이하의 징역 또는 <br>100만원 이하의 벌금 </td></tr></tbody></table>
</pre>				  
				  </p>
                <div class="read-more"><a href="#"><i class="icofont-arrow-right"></i> Read More</a></div>
              </div>
            </div>
          </div>		
			  
	
		  <div class="col-md-6 d-flex align-items-stretch" data-aos="fade-up">
            <div class="card">
              <div class="card-img">
                <img src="assets/img/service-details-6.jpg" alt="...">
              </div>
              <div class="card-body">
                <h5 class="card-title"><a href="#">유의사항</a></h5>
                <p class="card-text">
<pre>

폐차시 유의사항

폐차 후 알아두실 사항

​

폐차처리는 등록 폐차업소에서만 폐차하셔야하며, 반드시 폐차인수증명서를 발급받으셔야 합니다.

무허가 영업소를 이용할 경우 폐차인수증명서를 발급받을 수 없으며 문제 발생시 자동차소유자에게 책임이 전가됩니다.

말소등록 신청(관할 관청)을 꼭 하셔야 합니다.

폐차후 30일 이내에 관할 시도 등록관청에 반드시 말소등록을 하여야 하고 등록기한을 넘겼을 경우 과태료(50만원)가 부과됩니다,

말소시 유의사항

말소등록 후 자동차 소유자가 꼭 하셔야 할 일

​

보험료의 환급 및 승계
자동차보험료의 환급 또는 말소등록 후 말소 증명원을 발급 받아 보험가입 기간 중 말소일 이후 남은 기간의 보험료를 돌려받거나 새차로 이전하실 수 있습니다. 보험계약 만료일 전에 자동차를 구입할 계획이 없거나 꼭 보험료를 환급 받아야 할 경우라면 자동차 등록 원부(갑)와 차주 통장사본(앞면)을 해당 보험사에 제출하시면 됩니다.(전화, FAX 가능)
보험료를 환급 받으면 경력이 1년 감소하게 되어 추후 보험 가입시 보험료가 상승하게 됩니다.

​

자동차세 납부
자동차세는 1년에 2회로 나누어서 고지되며 제 1기분 과세기간은 1월~6월이며 납기는 6월 16일-6월30일까지입니다.
제 2기분 과세기간은 7월~12월이며 납기는 12월16일-12월31일까지입니다.
(만약, 과세기간 중 폐차 등으로 인하여 말소된 차량은 지방세법 제 196조의 8규정에 따라 소유(사용)한 기간만큼 자동차세가 과세됩니다.)
</pre>				
				  </p>
                <div class="read-more"><a href="#"><i class="icofont-arrow-right"></i> Read More</a></div>
              </div>
            </div>
          </div>
	
        </div>

      </div>
    </section><!-- End Service Details Section -->

    <!-- ======= Pricing Section ======= -->
    <section class="pricing section-bg" data-aos="fade-up">
      <div class="container">

        <div class="section-title">
          <h2>가격안내</h2>
          <p>친절한 서비스와 정직한 가격으로 여러분을 모시겠습니다.</p>
        </div>

        <div class="row no-gutters">

          <div class="col-lg-4 box">
            <h3>폐차환급</h3>
            <h4>차량마다 다름<span>견인 완료 후</span></h4>
            <ul>
              <li><i class="bx bx-check"></i> 소형차 ? 만원</li>
              <li><i class="bx bx-check"></i> 조기폐차 ? 만원</li>
              <li><i class="bx bx-check"></i> 중기폐차 ? 만원</li>
              <li class="na"><i class="bx bx-x"></i> <span>과한비용 청구</span></li>
              <li class="na"><i class="bx bx-x"></i> <span>같은차량 다른 가격 </span></li>
            </ul>
            <a href="#" class="get-started-btn">031-541-7700</a>
          </div>

          <div class="col-lg-4 box featured">
            <h3>부품판매</h3>
            <h4>부품마다 다름<span>판매완료 후</span></h4>
            <ul>
              <li><i class="bx bx-check"></i> 온라인 거래(택배) 가능</li>
              <li><i class="bx bx-check"></i> 전화문의 주시면 빠른 응대해드립니다</li>
              <li><i class="bx bx-check"></i> 온라인 게시판을 이용하세요</li>
              <li><i class="bx bx-check"></i> 방문전 전화문의 주세요</li>
              <li><i class="bx bx-check"></i> 외상은 안됩니다</li>
            </ul>
            <a href="#" class="get-started-btn">031-541-7700</a>
          </div>

          <div class="col-lg-4 box">
            <h3>견인비용</h3>
            <h4>차량마다 다름<span>폐차환급금에서 제외</span></h4>
            <ul>
              <li><i class="bx bx-check"></i> 거리에 따라 차등&nbsp;</li>
              <li><i class="bx bx-check"></i> 대형 견인은 추가비용발생</li>
              <li><i class="bx bx-check"></i> 견인보험 가입되어있습니다</li>
              <li><i class="bx bx-check"></i> 제주 산간지역은 추가비용 발생합니다</li>
              <li><i class="bx bx-check"></i> 직접 몰고오셔도 됩니다</li>
            </ul>
            <a href="#" class="get-started-btn">031-541-7700</a>
          </div>
			
        </div>

      </div>
    </section><!-- End Pricing Section -->

  </main><!-- End #main -->

</asp:Content>
