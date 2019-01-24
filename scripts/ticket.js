$(function () {
    $('.modal').modal();
    $('select').formSelect();




    $.ajax(
        {
            url: "http://localhost:54617/Services.svc/Airoport/API/Data/GetAllFlight",
            type: "GET",
            success: function (data) {
                //var i=0;
                //$('#cityfrom').append(`<option value='0' disabled></option>`);
                let newOpt = $("<option>").attr("value", "").text('Choose your flight');
                $('#cityfrom').empty();
                $('#cityfrom').append(newOpt);
                $("#cityfrom").find('option[value=""]').prop('selected', true);




                data.GetAllFlightResult.forEach((element, index) => {
                    $('#cityfrom').append(`<option value="${index + 1}">${element.ID}.From ${element.From} To ${element.To} {${moment(moment(element.Date).toDate(), 'llll')}} </option>`);


                    $('select').formSelect();



                });

            }
        }
    )

    $("#confirm").click(function () {





        var name = $("#cityfrom option:selected").text();

        var id = name.match(/(\d+)/g);
        var n = $("input[name='group1']:checked + span").text();
        var radioValue = $("input[name='group1']:checked").val();


        $("#main_info").html(`<p><b>${name}</b> <span>  ${n}</span></p>`)

        $("#price").html()
        $("#agree").click(function () {
           

               if($("#credit_card").val()!=="")
                {
                    var card = $("#credit_card").val();
                    var login=window.localStorage.getItem("Login");
                    
                    $.ajax(
                        {
                            url: `http://localhost:54617/Services.svc/Airoport/API/Data/SET/MakeOrder?Email=${login}&Card=${card}&Class=${radioValue}&IdFlight=${id[0]}`,
                            type: "GET",
                            success: function (data) {
                                
                                if (data.MakeOrderResult.Messege === "OK") {
                                    alert("Ordered!");
                                }
                                else
                                    alert(data.MakeOrderResult.Messege);

                            },
                            error: function(request, status, error){
                                alert(request.responseText);
                        }
                    }

                    )
                }
                    else
                    alert("Input card");

                
                })
        }
        );


    });



