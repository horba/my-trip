import { MmtLeisureCard, MmtStepper } from '@components';
import { VBtn, VIcon, VPagination } from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';

export default {
  components: {
    MmtStepper,
    MmtLeisureCard,
    VPagination,
    VBtn,
    VIcon
  },
  computed: {
    google: gmapApi,
    entertainments () {
      return this.$store.state.entertainment.entertainments;
    }
  },
  data () {
    return {
      mapCenter: {
        lat: 48.459322,
        lng: 35.052729
      },
      places: [],
      markers: [],
      map: null,
      placeService: null,
      selectedPlaceIndex: null,
      markerPos: null,
      pageNumber: 1,
      totalEntertainmentsPagesCount: 1
    };
  },
  async mounted () {
    await this.initMap();
    await this.getEntertainments(0);
    this.geolocate();
  },
  methods: {
    async initMap () {
      await this.$refs.entertainmentMap.$mapPromise.then(map => {
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
      this.markers = [];
      this.places = [];
      if (place.geometry) {
        this.mapCenter = this.getLatLng(place);
        this.setMapCenter(this.mapCenter);
      }
    },
    getDetailsCallback (place, entertainment) {
      this.places.push({
        id: entertainment.id,
        title: place.name,
        rating: place.rating,
        locationLat: place.geometry.location.lat(),
        locationLng: place.geometry.location.lng(),
        types: place.types,
        opening_hours: place.opening_hours,
        utc_offset_minutes: place.utc_offset_minutes,
        photo: place.photos[0].getUrl()
      });
    },
    getLatLng (place) {
      return {
        lat: place.geometry.location.lat(),
        lng: place.geometry.location.lng()
      };
    },
    getPlaces () {
      this.entertainments.forEach((e, i) => {
        if (e.placeId) {
          this.placeService.getDetails({
            placeId: e.placeId,
            language: 'ru',
            region: 'ru'
          }, p => this.getDetailsCallback(p, e));
        } else {
          this.places.push(e);
        }
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
    },
    async getEntertainments (pageNumber) {
      console.log(pageNumber);
      await this.$store.dispatch('entertainment/getEntertainments', pageNumber)
        .then(r => {
          this.totalEntertainmentsPagesCount = r.totalCount;
          this.pageNumber = r.pageNumber + 1;
        });
      this.places = [];
      this.getPlaces();
    }
  }
};
