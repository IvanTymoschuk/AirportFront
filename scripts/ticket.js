$(function (){
  $('.modal').modal();
  $('select').formSelect();

 
   $.ajax(
    {
        url:"http://localhost:54617/Services.svc/Airoport/API/Data/GetAllFlight",
        type: "GET",
        success: function (data){
            //var i=0;
            //$('#cityfrom').append(`<option value='0' disabled></option>`);
            let newOpt = $("<option>").attr("value","").text('Choose your flight');
            $('#cityfrom').append(newOpt);
            $("#cityfrom").find('option[value=""]').prop('selected', true);

          
         

            data.GetAllFlightResult.forEach((element, index) => {            
            $('#cityfrom').append(`<option value="${index+1}">From ${element.From} To ${element.To} {${moment(moment(element.Date).toDate(),'llll')}} </option>`);
             

            $('select').formSelect();



           });
              
        }
    }
)
});
$('select').on('change', function() {
    $.ajax(
        {
            url:"http://localhost:54617/Services.svc/Airoport/API/Data/GetAllFlight",
            type: "GET",
            success: function (data){

                let newOpt = $("<option>").attr("value","").text('Choose your destination');
                $('#cityto').append(newOpt);
                $("#cityto").find('option[value=""]').prop('selected', true);
                    let i=0;
    
                data.GetAllFlightResult.forEach((element, index) => {            

                if(element.From===$( "#cityfrom option:selected" ).text())
                $('#cityto').append(`<option value="${i}">${element.To}</option>`);
    
                $('select').formSelect();
    
    
    
               });
                  
            }
        })
  });
