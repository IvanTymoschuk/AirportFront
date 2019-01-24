$(function () {
    $('#password').val(window.localStorage.getItem("Password"));
    $('#email').val(window.localStorage.getItem("Login"));
    M.updateTextFields();  
    $('#auth_form').validate({
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
        }
       
        
      },
      messages: {
       
        email: 'Email must be valid',
        password: {
          minlength: 'Password must be at least 8 characters long'
        }

      },
      submitHandler: function (form) {
        //form.submit();
        
        $.ajax({
          url: `http://localhost:54617/Services.svc/Airoport/API/Auth/Login?Email=${$("#email").val()}&password=${$("#password").val()}`, 
      
          success: function(data){
          
        if(data.LoginResult.Messege==="OK"){

          window.localStorage.setItem("Login",$('#email').val());
          window.localStorage.setItem("Password",$('#password').val());
        window.location.href = "index.html";
        
      }
        else
        $("#error").html("dich");
            
          },
          error: function(request, status, error){
              alert(request.responseText);
          }
        }

        )
      
  
      }
    });


  })


    


    

    
    