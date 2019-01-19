$(function () {
    $('#password').val(window.localStorage.getItem("Password"));
    $('#email').val(window.localStorage.getItem("Login"));
    M.updateTextFields();  
})

function Send() {
    let login=$('#email').val();
    let pass=$('#password').val();

    


    
    window.location.href = "index.html";
      }
    