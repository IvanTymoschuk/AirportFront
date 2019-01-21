

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
          minlength: 4,
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
        first_name: 'This field is required',
        last_name: 'This field is required',
        email: 'Enter a valid email',
        password: {
          minlength: 'Password must be at least 4 characters long'
        },
        cpassword: 'Password fields must be equal',
        Birthdate:'This field is required'

      },
      submitHandler: function (form) {
        form.submit();
        window.localStorage.setItem("Login",$('email').val());
        window.localStorage.setItem("Password",$('password').val());
        window.location.href = "Authorization.html";
  
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



   

