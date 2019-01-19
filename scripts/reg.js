function Send() {
let login=$('#email').val();
let pass=$('#password').val();
let cpass=$('#cpassword').val();

if(pass!==cpass)
{
   
    $( "div" ).data( "error" ) === "wrong";
   
}

window.localStorage.setItem("Login",login);
window.localStorage.setItem("Password",pass);

window.location.href = "Authorization.html";
  }


document.addEventListener('DOMContentLoaded', function () {
    var options = {
       
        setDefaultDate: true,
        minDate:new Date(1900, 1, 1),
        showClearBtn: true
    };
    
    var elems = document.querySelector('.datepicker');
    var instance = M.Datepicker.init(elems, options);
    
    
});



   

