import { MmtStepper } from '@components';
import { gmapApi } from 'vue2-google-maps';
import { VCol, VRow, VCard, VRating, VBtn, VIcon, VSnackbar } from 'vuetify/lib';

const fields = [
  'geometry',
  'rating',
  'opening_hours',
  'photos',
  'user_ratings_total',
  'types',
  'utc_offset_minutes'
];

export default {
  components: {
    MmtStepper,
    VRow,
    VCol,
    VCard,
    VRating,
    VBtn,
    VIcon,
    VSnackbar
  },
  data () {
    return {
      options: {
        zoom: 10,
        center: {
          lat: 0,
          lng: 0
        },
        mapTypeId: 'roadmap',
        ref: 'mapRef'
      },
      scheduledPlacesList: [],
      defaultImage: '@/assets/default-sheduled-place-to-eat-image.jpg',
      selectedId: 0,
      text: '',
      snackbar: false,
      color: ''
    };
  },
  computed: {
    google: gmapApi
  },
  created () {
    this.responseDataFromServer();
  },
  methods: {
    responseDataFromServer () {
      this.$store.dispatch('eating/getEatingUser')
        .then(response => {
          this.scheduledPlacesList = response.data
            .map(serverPlaceInfo => {
              return {
                serverInfo: serverPlaceInfo, googleDetails: null
              };
            });
          return Promise.all(this.scheduledPlacesList.map(this.addGoogleMapDetails));
        });
    },
    addGoogleMapDetails (place) {
      return place.serverInfo.googlePlaceId
        ? this.getGoogleDetails(place.serverInfo.googlePlaceId)
          .then(googleDetails => { place.googleDetails = googleDetails || null; })
        : Promise.resolve(place);
    },
    getGoogleDetails (googlePlaceId) {
      const request = {
        placeId: googlePlaceId,
        fields
      };
      return this.$refs.mapRef.$mapPromise.then((map) => {
        const service = new this.google.maps.places.PlacesService(map);
        return new Promise((resolve, reject) => {
          service.getDetails(request, (place, status) => {
            if (status === this.google.maps.places.PlacesServiceStatus.OK) {
              return resolve(place);
            } else {
              return resolve(null);
            }
          });
        });
      });
    },
    isOpen (place) {
      place.opening_hours && place.opening_hours.isOpen();
    },
    onSelectPlace (selectedPlace) {
      if (selectedPlace.googleDetails !== null) {
        this.options.center.lat = selectedPlace.googleDetails.geometry.location.lat();
        this.options.center.lng = selectedPlace.googleDetails.geometry.location.lng();
      }
      this.selectedId = selectedPlace.serverInfo.id;
    },
    deletePlace (id) {
      this.$store.dispatch('eating/deleteEating', { id })
        .then(() => {
          this.text = this.$t('eating.successfullyDelete');
          this.snackbar = true;
          this.color = 'success';
          this.responseDataFromServer();
        })
        .catch(error => {
          this.text = error;
          this.snackbar = true;
          this.color = 'error';
        });
    }
  },
  mounted () {
    navigator.geolocation.getCurrentPosition(r => {
      this.options.center.lat = r.coords.latitude;
      this.options.center.lng = r.coords.longitude;
    });
  }
};