import { MmtLeisureCard, MmtTextInput } from '@components';
import { VBtn, VDatePicker, VIcon, VMenu, VTextField, VTextarea } from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';

export default {
  computed: {
    google: gmapApi,
    entertainmentsList () {
      return this.$store.getters['userEntertainments/entertainments'];
    }
  },
  components: {
    VDatePicker,
    VMenu,
    VTextField,
    VBtn,
    VIcon,
    MmtLeisureCard,
    VTextarea,
    MmtTextInput
  },
  data () {
    return {
      mapCenter: {
        lat: 48.459322,
        lng: 35.052729
      },
      markerPos: null,
      placeTitle: '',
      peopleCount: '',
      note: '',
      place: null,
      menu: false,
      visitDate: new Date().toISOString().substr(0, 10)
    };
  },
  mounted () {
    this.geolocate();
    this.initMapClickEvent();
    this.initMarkerDragendEvent();
  },
  methods: {
    initMapClickEvent () {
      this.$refs.entertainmentsMap.$mapPromise.then((map) => {
        this.map = map;
        this.google.maps.event.addListener(map, 'click', this.mapClickHandler);
      });
    },
    mapClickHandler (e) {
      const service = new this.google.maps.places.PlacesService(this.map);
      service.getDetails({ placeId: e.placeId }, this.setPlace);
      this.markerPos = null;
    },
    initMarkerDragendEvent () {
      if (this.$refs.placeMarker) {
        this.$refs.placeMarker.$markerPromise.then((marker) => {
          this.google.maps.event.addListener(marker, 'dragend', this.mapDragendHandler);
        });
      }
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
      this.placeTitle = place.name;
    },
    findPlace (place) {
      if (place.geometry) {
        const center = this.getLatLng(place);
        this.setMapCenter(center);
      }
    },
    setMapCenter (position) {
      this.$refs.entertainmentsMap.$mapPromise.then((map) => {
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
      const mapCenter = {
        lat: this.map.getCenter().lat(),
        lng: this.map.getCenter().lng()
      };
      if (!this.markerPos
        || (this.markerPos.lat !== mapCenter.lat
        && this.markerPos.lng !== mapCenter.lng)) {
        this.markerPos = {
          lat: mapCenter.lat,
          lng: mapCenter.lng
        };
        this.place = null;
        this.placeTitle = '';
      } else {
        this.markerPos = null;
      }
    },
    clearPlaceFields () {
      this.place = null;
      this.placeTitle = '';
      this.note = '';
    },
    async savePlace () {
      let body = {};
      if (this.place) {
        body = {
          placeId: this.place.place_id,
          title: this.placeTitle,
          note: this.note,
          peopleCount: parseInt(this.peopleCount),
          visitDate: this.visitDate,
          locationLat: this.place.geometry.location.lat(),
          locationLng: this.place.geometry.location.lng(),
          EntertainmentFilePath: ''
        };
      } else if (this.markerPos) {
        body = {
          title: this.placeTitle,
          note: this.note,
          peopleCount: parseInt(this.peopleCount),
          visitDate: this.visitDate,
          locationLat: this.markerPos.lat,
          locationLng: this.markerPos.lng
        };
      } else {
        body = {
          title: this.placeTitle,
          note: this.note,
          peopleCount: parseInt(this.peopleCount),
          visitDate: this.visitDate
        };
      }
      await this.$store.dispatch('entertainment/addOrUpdateEntertainment', body)
        .then(() => {
          this.$router.push('/my/entertainments');
        });
    }
  }
};
