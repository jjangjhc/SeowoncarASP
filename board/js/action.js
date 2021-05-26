function fnAutoInsert(){

    $("#MainContent_txtMANUFACTURER").val("BMW");
    $("#MainContent_txtNAME").val("X6");
    $("#MainContent_txtYEAR").val("2012");
    $("#MainContent_txtVIN").val("-");
    $("#MainContent_txtPARTNUM").val("원동기형식-N57D30A");
    $("#MainContent_txtPRODUCTINFO").val("-");
    $("#MainContent_txtMOREINFO").val("-");
    $("#MainContent_txtRETURNINFO").val("-");
    $("#MainContent_txtSHIPPINGINFO").val("-");
}

function fnInsertProductid(sProductid) {

    $("#productid").val(sProductid);
    $("#dmltype").val("update");
    document.forms[0].submit();


}

function fnDeleteProductid(sProductid) {

    $("#productid").val(sProductid);
    $("#dmltype").val("delete");

    let retVal = confirm("삭제 하시겠습니까?\n\n상품번호 : " + sProductid);
    if (retVal == true) {
        document.forms[0].submit();
    } else {
        return;
    }

}

function fnBoardOpen(sProductid) {
    $("#hftempid").val(sProductid);
    //아이디 받고 모달창 열기
    fnModalOpen();

    

}

function fnModalOpen() {
    document.querySelector('.modal_wrap').style.display = 'block';
    document.querySelector('.black_bg').style.display = 'block';
}
function fnModalClose() {
    document.querySelector('.modal_wrap').style.display = 'none';
    document.querySelector('.black_bg').style.display = 'none';
    $("#txtPASSWORD_CHECK").val('');
    $("#lblCheckPassword").hide();

}



function fnPasswordCheck() {

    sID = $("#hftempid").val();
    sPASSWORD = $("#txtPASSWORD_CHECK").val();
    
    window.open("board_list_check?id=" + sID + "&password=" + sPASSWORD, "ifrCheck");

    

}