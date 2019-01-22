

$(function () {

    $.ajax(
        {
            url:"http://localhost:54617/Services.svc/Airoport/API/Data/GetAllFlight",
            type: "GET",
            success: function (data){


                
               data.GetAllFlightResult.forEach(element => {
               
                var realTime=moment(moment(element.Date).toDate(),'llll');
                $('#table_body').append(`<tr><td>${realTime}</td><td>${element.Plen}</td><td>${element.From}</td><td>${element.To}</td><td>${element.Count}</td></tr>`);
               });
            }
        }
    )
    
})
