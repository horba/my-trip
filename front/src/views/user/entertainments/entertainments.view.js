import { MmtLeisureCard, MmtStepper } from '@components';

import { gmapApi } from 'vue2-google-maps';

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
      }
    },
    getLatLng (place) {
      return {
        lat: place.geometry.location.lat(),
        lng: place.geometry.location.lng()
      };
    }
  }
};
