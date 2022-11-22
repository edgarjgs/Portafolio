$(function(){
var ctrClicked = 0;
    $('#btnClick').click(function(){
        if (++ctrClicked == 1){
        $('.especial').html('hello world')
        .css('color','red')
        .css('background-color','pink')     
        .css('border-bottom-style','double');
        }
        else {
            $('h1.especial').html('sup world')
        }
        /*$('h1').html('hello world')
            .css('color','red')
            .css('background-color','pink')     
            .css('border-bottom-style','double');*/
     /* $('h1').css('color','red');
        $('h1').css('background-color','pink');        
        $('h1').css('border-bottom-style','double');*/
      });

  });