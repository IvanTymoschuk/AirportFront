

$(function () {
    
    $('#reg_form').validate({
      rules: {
        first_name: 'required',
        last_name: 'required',
        email: {
          required: true,
          email: true,
        },
        password: {
          required: true,
          minlength: 8,
        },
        cpassword: {
            equalTo: "#password"
        },
        Birthdate:{
            required: true,
            date:true,
        }

        
      },
      messages: {
        first_name: 'First Name is required',
        last_name: 'Last Name field is required',
        email: 'Email is not valid',
        password: {
          minlength: 'Password must be at least 4 characters long'
        },
        cpassword: 'Confirm password fields must be equal',
        Birthdate:'Birthdate is required'

      },
      submitHandler: function (form) {

        

        $.ajax({
          url: 
          `http://localhost:54617/Services.svc/Airoport/API/Auth/Register?lname=${$("#last_name").val()}&fname=${$("#first_name").val()}
          &email=${$("#email").val()}&birthdate=${$("#Birthdate").val()}&gender=${$('input[type=radio][name=group1]:checked').val()}&pass=${$("#password").val()}`, 
      
          success: function(data){
         
        if(data.RegisterResult.Messege==="OK"){
          window.localStorage.setItem("Login",$('#email').val());
          window.localStorage.setItem("Password",$('#password').val());
          window.location.href = "Authorization.html";
       
        }
        
        else
        alert(data.RegisterResult.Messege);
       // $("#error").html("dich");
            
          },
          error: function(request, status, error){
            
              alert(request.responseText);
          }
        }

        )
        
  
      }
    });
  })

document.addEventListener('DOMContentLoaded', function () {
    var options = {
       
        setDefaultDate: true,
        minDate:new Date(1900, 1, 1),
        showClearBtn: true
    };
    
    var elems = document.querySelector('.datepicker');
    var instance = M.Datepicker.init(elems, options);
    
    
});



   

