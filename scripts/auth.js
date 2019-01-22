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
          minlength: 'Password must be at least 4 characters long'
        }

      },
      submitHandler: function (form) {
        //form.submit();
        
        $.ajax({
          url: `http://localhost:54617/Services.svc/Airoport/API/Auth/Login?Email=${$("#email").val()}&password=${$("#password").val()}`, 
          data: $(form).serialize(),
          success: function(data){
            alert($("#email").val()+" "+$("#password").val());
            alert(data.LoginResult.Messege);
        if(data.LoginResult.Messege==="OK")
        window.location.href = "index.html";
            
            
          },
          error: function(request, status, error){
              alert(request.responseText);
          }
        }

        )
      
  
      }
    });


  })


    


    

    
    