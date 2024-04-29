(function(){
    var password1 = document.getElementById("password");
    var password2 = document.getElementById("password_confirm");
    var checkPasswordValidity = function(){
        if(password1.value != password2.value){
            password2.setCustomValidity('Mật khẩu phải trùng nhau.');
        } else {
            password2.setCustomValidity('');
        }
        
    };
    password1.onchange = checkPasswordValidity;
    password2.onchange = checkPasswordValidity;
}());

function quantity(){
    var limit = document.getElementById("numQuantity");
    if(limit.value !="" || limit.value > 0){
    
     
        if(limit.value < 1  || limit.value >=10){
            
            window.alert("Số lượng nằm trong khoảng từ 1 đến 10")
        

        } else {
            window.alert("Cập nhật thành công")
        }
    } else {
        window.alert("Vui lòng nhập số lượng")
    }

};

function checkPhone(){
    var limit = document.getElementById("phoneNumber").value;
    var phone_number = /^(0)\d{9}$/;
    if(limit !=""){
    
     
        if(limit.match(phone_number)){
            
            window.alert("Cập nhật thành công")
        

        } else {
            window.alert("Số điện thoại không hợp lệ")
        }
    } else {
        window.alert("Vui lòng nhập đầy đủ thông tin")
    }

}