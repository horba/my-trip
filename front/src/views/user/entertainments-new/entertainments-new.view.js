import { MmtLeisureCard, MmtTextInput } from '@components';
import { VBtn, VDatePicker, VIcon, VMenu, VTextField } from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';

export default {
  computed: {
    google: gmapApi
  },
  components: {
    VDatePicker,
    VMenu,
    VTextField,
    VBtn,
    VIcon,
    MmtLeisureCard,
    MmtTextInput
  },
  data () {
    return {
      mapCenter: {
        lat: 48.459322,
        lng: 35.052729
      },
      markerPos: {
        lat: null,
        lng: null
      },
      placeName: '',
      peopleCount: '',
      placeDescription: '',
      place: null,
      menu: false,
      date: new Date().toISOString().substr(0, 10)
    };
  },
  mounted () {
    this.geolocate();
    this.initMapClickEvent();
    this.initMarkerDragendEvent();
  },
  methods: {
    initMapClickEvent () {
      this.$refs.mapRef2.$mapPromise.then((map) => {
        this.map = map;
        this.google.maps.event.addListener(map, 'click', this.mapClickHandler);
      });
    },
    mapClickHandler (e) {
      const service = new this.google.maps.places.PlacesService(this.map);
      service.getDetails({
        placeId: e.placeId
      },
      this.setPlace);
    },
    initMarkerDragendEvent () {
      this.$refs.placeMarker.$markerPromise.then((marker) => {
        this.google.maps.event.addListener(marker, 'dragend', this.mapDragendHandler);
      });
    },
    mapDragendHandler (e) {
      this.clearPlaceFields();
      this.markerPos = {
        lat: e.latLng.lat(),
        lng: e.latLng.lng()
      };
    },
    geolocate () {
      navigator.geolocation.getCurrentPosition(position => {
        this.mapCenter = { lat: position.coords.latitude, lng: position.coords.longitude };
        this.setMapCenter(this.mapCenter);
      });
    },
    setPlace (place, status) {
      this.place = place;
      this.placeName = place.name;
    },
    findPlace (place) {
      if (place.geometry) {
        const center = this.getLatLng(place);
        this.setMapCenter(center);
      }
    },
    setMapCenter (position) {
      this.$refs.mapRef2.$mapPromise.then((map) => {
        map.setCenter(position);
      });
    },
    getLatLng (place) {
      return {
        lat: place.geometry.location.lat(),
        lng: place.geometry.location.lng()
      };
    },
    setCenterMarker () {
      const mapCenter = this.map.getCenter();
      this.mapCenter = {
        lat: mapCenter.lat(),
        lng: mapCenter.lng()
      };
    },
    clearPlaceFields () {
      this.place = null;
      this.placeName = '';
      this.placeDescription = '';
    },
    savePlace () {
      console.log(this.date);
      console.log(this.place);
      console.log(this.mapCenter);
      console.log(this.markerPos);
      console.log(this.placeName);
      console.log(this.peopleCount);
      console.log(this.placeDescription);
    }
  }
};
