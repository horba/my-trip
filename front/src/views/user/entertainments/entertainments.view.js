import { MmtLeisureCard, MmtStepper } from '@components';

import { gmapApi } from 'vue2-google-maps';

/* eslint-disable */
export default {
  components: {
    MmtStepper,
    MmtLeisureCard
  },
  computed: {
    google: gmapApi
  },
  data () {
    return {
      places: [],
      mapCenter: {
        lat: 48.459322,
        lng: 35.052729
      },
      markers: []
    };
  },
  mounted () {
    this.geolocate();
  },
  methods: {
    geolocate () {
      navigator.geolocation.getCurrentPosition(position => {
        this.mapCenter = { lat: position.coords.latitude, lng: position.coords.longitude };
        this.setMapCenter(this.mapCenter);
        this.nearbySearch();
      });
    },
    setMapCenter (position) {
      this.$refs.mapRef.$mapPromise.then((map) => {
        map.setCenter(position);
      });
    },
    setPlace (place) {
      this.markers = [];
      this.places = [];
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
      const request = {
        types: [ 'restaurant' ],
        location: this.mapCenter,
        radius: 1000
      };
      this.$refs.mapRef.$mapPromise.then((map) => {
        service = new this.google.maps.places.PlacesService(map);
        service.nearbySearch(request, (results, status) => {
          if (status === this.google.maps.places.PlacesServiceStatus.OK) {
            results.forEach(el => {
              this.places.push(el);
              this.markers.push({
                position: this.getLatLng(el)
              });
            });
            map.setCenter(results[0].geometry.location);
          }
        });
      });
    }
  }
};
