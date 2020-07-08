import { gmapApi } from 'vue2-google-maps';
import { MmtLeisureCard } from '@components';

export default {
  components: {
    MmtLeisureCard
  },
  computed: {
    google: gmapApi
  },
  data () {
    return {
      map: null,
      mapCenter: {
        lat: 48.459322,
        lng: 35.052729
      },
      places: [],
      markers: [],
      selectedPlaceIndex: null
    };
  },
  methods: {
    async initMap () {
      await this.$refs.foodMap.$mapPromise.then(map => {
        this.map = map;
      });
      this.placeService = new this.google.maps.places.PlacesService(this.map);
    },
    geolocate () {
      navigator.geolocation.getCurrentPosition(position => {
        this.mapCenter = { lat: position.coords.latitude, lng: position.coords.longitude };
        this.setMapCenter(this.mapCenter);
      });
    },
    setMapCenter (position) {
      this.map.setCenter(position);
    },
    setPlace (place) {
      if (place.geometry) {
        this.mapCenter = this.getLatLng(place);
        this.setMapCenter(this.mapCenter);
        this.nearbySearch();
      }
    },
    getLatLng (place) {
      return {
        lat: place.geometry.location.lat(),
        lng: place.geometry.location.lng()
      };
    },
    nearbySearch () {
      let service;
      this.places = [];
      const request = {
        types: [ 'restaurant' ],
        location: this.mapCenter,
        radius: 1000
      };
      this.$refs.foodMap.$mapPromise.then((map) => {
        service = new this.google.maps.places.PlacesService(map);
        service.nearbySearch(request, (results, status) => {
          if (status === this.google.maps.places.PlacesServiceStatus.OK) {
            results.forEach(el => {
              el.title = el.name;
              el.locationLat = el.geometry.location.lat();
              el.locationLng = el.geometry.location.lng();
              if (el.photos) {
                el.photo = el.photos[0].getUrl();
              }
              this.places.push(el);
              this.markers.push({
                position: this.getLatLng(el)
              });
            });
            map.setCenter(results[0].geometry.location);
          }
        });
      });
    },
    setActive (i) {
      if (this.selectedPlaceIndex === i + 1) {
        this.selectedPlaceIndex = null;
      } else {
        this.selectedPlaceIndex = i + 1;
        if (this.places[i].locationLat) {
          this.map.panTo({
            lat: this.places[i].locationLat,
            lng: this.places[i].locationLng
          });
        }
      }
    }
  },
  async mounted () {
    await this.initMap();
    this.geolocate();
    this.nearbySearch();
  }
};
