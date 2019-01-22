$(document).ready(function(){
    $('.parallax').parallax();
  });
function myMap() {
    var mapProp= {
        center:new google.maps.LatLng(50.596701, 26.156060),
        zoom:4
    };
    var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(50.596701, 26.156060),
        map: map,
        title: 'Rivne Airport!'
      });
    }