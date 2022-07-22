jQuery('document').ready(function(){

    var testFirst;

    testFirst = prompt('Please enter your name:');

    jQuery('#result').html(testFirst);

    jQuery('button').on('click', function(){
        var firstNum, secondNum, thirdNum;
        firstNum = jQuery('#first').val();
        secondNum = jQuery('#second').val();

        firstNum = parseInt(firstNum);
        secondNum = parseInt(secondNum);

        thirdNum = firstNum + secondNum;
        alert(thirdNum);
    });
});