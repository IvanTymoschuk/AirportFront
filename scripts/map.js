
function myMap() {
    var mapProp= {
        center:new google.maps.LatLng(50.596701, 26.156060),
        zoom:18,
        mapTypeId:google.maps.MapTypeId.SATELLITE 
    };
    var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);
    
      var Rest = [
        {lat: 50.595938, lng: 26.156295},
        {lat: 50.595777, lng: 26.156370},
        
        {lat: 50.595722, lng: 26.156028},
        {lat: 50.595879, lng: 26.155948}
      ];

      var Hall = [
        {lat: 50.595722, lng: 26.156028},
        {lat: 50.595879, lng: 26.155948},
        {lat: 50.595685, lng:26.154880},
        {lat:50.595521, lng:26.154969}
        

      ];
      var Park = [
        {lat: 50.595295,lng: 26.154647},
        {lat: 50.595585, lng: 26.156303},
        {lat: 50.595108,lng: 26.156548},
        {lat:50.594781,lng: 26.154878}
        

      ];

      // Construct the polygon.
      var sq1 = new google.maps.Polygon({
        paths: Rest,
        strokeColor: '#FF0000',
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: '#FF0000',
        fillOpacity: 0.35
      }
    );

    var sq2 = new google.maps.Polygon(
        
      {
        paths: Hall,
        strokeColor: '#3C8D2F',
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: '#1E6912',
        fillOpacity: 0.35
      }
    );

    var sq3 = new google.maps.Polygon({
        paths: Park,
        strokeColor: '#cccc00',
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: '#fcfc23',
        fillOpacity: 0.35
      }
    );
    sq1.setMap(map);    
    sq2.setMap(map);
    sq3.setMap(map);
    }