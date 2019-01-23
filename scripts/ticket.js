$(function (){
  $('.modal').modal();
  $('select').formSelect();


  $.ajax(
    {
        url:"http://localhost:54617/Services.svc/Airoport/API/Data/GetAllFlight",
        type: "GET",
        success: function (data){


            var i=0;
            $('#cityfrom').append(`<option value="" disabled selected>Choose your destination</option>`);
           data.GetAllFlightResult.forEach(element => {
           i++;
          $('#cityfrom').append(`<option value="${i}">${element.From}</option>`);
           });
        }
    }
)



});