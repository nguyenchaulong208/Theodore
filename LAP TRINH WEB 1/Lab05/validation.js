(function(){
    var password1 = document.getElementById('password').value;
    var password2 = document.getElementById('password_confirm').value;
    var checkPassword  = function(){
        if(password1.value != password2.value){
            password2.setCustomValidity('Passwords must match');
        } else {
            password2.setCustomValidity('');
        }
        
    };
    password1.onchange = checkPasswordValidation;
        password2.onchange = checkPasswordValidation;
}());