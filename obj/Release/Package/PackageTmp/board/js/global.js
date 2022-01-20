(function ($) {
    'use strict';

    /*[ File Input Config ]
        ===========================================================*/
    
    try {
    
        var file_input_container = $('.js-input-file');
    
        if (file_input_container[0]) {
    
            file_input_container.each(function () {
    
                var that = $(this);
    
                var fileInput = that.find(".input-file");
                var info = that.find(".input-file__info");
    
                fileInput.on("change", function () {



                    var files = $(this)[0].files;
                    var sFileNames = "";

                    for (var i = 0; i < files.length; i++) {
                        //alert('file_name :' + files[i].name);

                        //if (fileName.substring(3, 11) == 'fakepath') {
                        //    fileName = fileName.substring(12);
                        //}

                        if (files[i].name == "") {
                            info.text("No file chosen");
                        } else {
                            sFileNames = sFileNames + "<br>" + files[i].name;
                        }
                    }

                    info[0].innerHTML = sFileNames.trim() + "<br> - -   -   - : " + files.length;
                    
                    /*
                    var fileName;
                    fileName = $(this).val();
    
                    if (fileName.substring(3,11) == 'fakepath') {
                        fileName = fileName.substring(12);
                    }
    
                    if(fileName == "") {
                        info.text("No file chosen");
                    } else {
                        info.text(fileName);
                    }
                    */
    
                })
    
            });
    
        }
    
    
    
    }
    catch (e) {
        console.log(e);
    }

})(jQuery);