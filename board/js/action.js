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


function fnImageChange(str, num) {

    
    let imgs = document.getElementsByTagName('img');
    let i = 0;

    

    for (let im of imgs) {
        
        if (im.id.search('MainContent_img') >= 0) {
            i++;
        }
    }





    if (str == 'next') {
        if (num + 2 > i) {

            
            return;
        }

        let img = document.getElementById('MainContent_img' + num);
        let imgNext = document.getElementById('MainContent_img' + (num+1));
        let imgTemp = '';

        imgTemp = imgNext.src
        imgNext.src = img.src;
        img.src = imgTemp;

    } else if (str=='pre'){

        if (num <= 1) {
            return;
        }

        let img = document.getElementById('MainContent_img' + num);
        let imgPre = document.getElementById('MainContent_img' + (num - 1));
        let imgTemp = '';

        imgTemp = imgPre.src
        imgPre.src = img.src;
        img.src = imgTemp;

    }


    //값 구해서 txt상자에 넣기
    let imgChangeText = document.getElementById('MainContent_ImageChange');
    imgChangeText.value = '';

    for (let im of imgs) {

        if (im.id.search('MainContent_img') >= 0) {
            imgChangeText.value += ';' + im.src;
        }
    }

}




function fnUpdateSubmit(){

    let retVal = confirm("수정 하시겠습니까?");
    if (retVal == true) {
        document.forms[0].submit();
    } else {
        return;
    }

}

