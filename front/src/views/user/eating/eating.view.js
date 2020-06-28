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
          lat: 48.459286,
          lng: 35.052698
        },
        mapTypeId: 'roadmap',
        ref: 'mapRef'
      },
      scheduledPlacesList: [],
      defaultImage: '@/assets/default-image.jpg',
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
          /// scheduledPlacesList: [{serverInfo, googleDetails}]
          /// for [{...serverPlaceInfo, googleDetails}] change into
          /// .map(serverPlaceInfo => { return { ..., googleDetails: null }; });
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
      let isOpen;
      try {
        isOpen = place.opening_hours.isOpen();
      } catch (e) {
        isOpen = true;
      }
      return isOpen;
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
          setTimeout(() => this.responseDataFromServer(), 3000);
        })
        .catch(error => {
          this.text = error;
          this.snackbar = true;
          this.color = 'error';
        });
    }
  },
  filters: {
    trimString (value) {
      return value.length > 10 ? value.substr(0, 10) + '...' : value;
    }
  }
};
