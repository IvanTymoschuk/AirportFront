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
          minlength: 4,
        }
       
        
      },
      messages: {
       
        email: 'Enter a valid email',
        password: {
          minlength: 'Password must be at least 4 characters long'
        }

      },
      submitHandler: function (form) {
        form.submit();
        window.location.href = "index.html";
  
      }
    });
  })


    


    

    
    