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
          url: "", 
          data: $(form).serialize(),
          success: function(data){



            
            window.location.href = "index.html";
          },
          error: function(){

          }
        }

        )
      
  
      }
    });


  })


    


    

    
    