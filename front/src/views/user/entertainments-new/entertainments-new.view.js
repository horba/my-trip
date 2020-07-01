import { MmtLeisureCard, MmtTextInput } from '@components';
import {
  VBtn,
  VDatePicker,
  VFileInput,
  VIcon,
  VImg,
  VMenu,
  VTextField,
  VTextarea,
  VTimePicker
} from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';
import { requiredValidationMixin } from '@mixins';

const { baseUrl } = require('@/config/config.dev.json');
const { SERVER_ENTERTAINMENT_PATH } = require('@constants');

export default {
  mixins: [ requiredValidationMixin ],
  computed: {
    google: gmapApi,
    entertainmentsList () {
      return this.$store.getters['userEntertainments/entertainments'];
    }
  },
  components: {
    VDatePicker,
    VFileInput,
    VTimePicker,
    VMenu,
    VTextField,
    VBtn,
    VImg,
    VIcon,
    VTextarea,
    MmtLeisureCard,
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
      placeId: null,
      peopleCount: 2,
      note: '',
      place: null,
      menu: false,
      menu2: false,
      photo: '',
      visitDate: new Date().toISOString().substr(0, 10),
      visitTime: new Date().toTimeString().substr(0, 5)
    };
  },
  async mounted () {
    this.geolocate();
    this.initMapClickEvent();
    this.initMarkerDragendEvent();
    if (this.$route.params.id) {
      await this.$store.dispatch('entertainment/getEntertainment', this.$route.params.id)
        .then((response) => {
          const place = response.data;
          this.placeTitle = place.title;
          this.placeId = place.placeId;
          this.peopleCount = place.peopleCount;
          this.note = place.note;
          this.photo = place.entertainmentFilePath;
          this.visitDate = place.visitDate.split('T')[0];
          this.visitTime = place.visitDate.split('T')[1].substr(0, 5);
          if (place.locationLat) {
            this.markerPos = {
              lat: place.locationLat,
              lng: place.locationLng
            };
          }
        });
    }
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
    setPlace (place) {
      this.place = place;
      this.placeTitle = place.name;
      this.placeId = place.place_id;
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
    getFilePath (fileName) {
      return !fileName.startsWith('http')
        ? `${baseUrl}/${SERVER_ENTERTAINMENT_PATH}/${fileName}`
        : fileName;
    },
    fileUpload (files) {
      if (files && files.length) {
        files.forEach(file => {
          const formData = new FormData();
          formData.append('file', file);

          this.$store.dispatch('entertainment/uploadFile', formData)
            .then(r => {
              this.photo = r.data;
            });
        });
      }
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
        if (this.place) {
          this.placeTitle = '';
          this.place = null;
        }
      } else {
        this.markerPos = null;
      }
    },
    clearPlaceFields () {
      if (this.place) {
        this.place = null;
        this.placeTitle = '';
        this.note = '';
      }
    },
    async savePlace () {
      let body = {};
      if (this.place) {
        body = {
          locationLat: this.place.geometry.location.lat(),
          locationLng: this.place.geometry.location.lng()
        };
      } else if (this.markerPos) {
        body = {
          locationLat: this.markerPos.lat,
          locationLng: this.markerPos.lng
        };
      }
      body.placeId = this.placeId;
      body.title = this.placeTitle;
      body.visitDate = `${this.visitDate}T${this.visitTime}`;
      body.note = this.note;
      body.peopleCount = parseInt(this.peopleCount);
      if (this.photo) {
        body.entertainmentFilePath = this.photo;
      }
      if (this.$route.params.id) {
        body.id = parseInt(this.$route.params.id);
      }

      await this.$store.dispatch('entertainment/addOrUpdateEntertainment', body)
        .then(() => {
          this.$router.push('/my/entertainments');
        });
    },
    removePhoto () {
      this.photo = '';
      this.$store.dispatch('entertainment/deleteFile', this.photo);
      this.$store.dispatch('entertainment/deleteFilePath', this.$route.params.id);
    }
  }
};
