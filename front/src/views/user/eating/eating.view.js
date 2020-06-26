import { MmtStepper } from '@components';
import { gmapApi } from 'vue2-google-maps';
import { VCol, VRow, VCard, VRating, VBtn, VIcon } from 'vuetify/lib';

export default {
  components: {
    MmtStepper,
    VRow,
    VCol,
    VCard,
    VRating,
    VBtn,
    VIcon
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
      defaultImage: '@/assets/default-image.jpg'
    };
  },
  computed: {
    google: gmapApi
  },
  created () {
    this.$store.dispatch('eating/getEatingUser')
      .then(r => {
        this.scheduledPlacesList = r.data;
        this.scheduledPlacesList
          .forEach(serverInfo => {
            this.gmapAddDetails(serverInfo);
            serverInfo.isActive = false;
          });
      });
  },
  methods: {
    gmapAddDetails (serverInfo) {
      if (serverInfo.googlePlaceId !== '') {
        const request = {
          placeId: serverInfo.googlePlaceId,
          fields:
            [
              'geometry',
              'rating',
              'opening_hours',
              'photos',
              'user_ratings_total',
              'types',
              'utc_offset_minutes'
            ]
        };
        this.$refs.mapRef.$mapPromise.then((map) => {
          const service = new this.google.maps.places.PlacesService(map);
          service.getDetails(request, (place, status) => {
            if (status === this.google.maps.places.PlacesServiceStatus.OK) {
              serverInfo.googleDetails = place;
            }
          });
        });
      } else {
        serverInfo.googleDetails = undefined;
      }
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
    replacementTypes (types) {
      const replaceTypes = [];
      types.forEach((type) => {
        if (type === 'food') {
          type = this.$t('eating.food');
          replaceTypes.push(type);
        } else if (type === 'restaurant') {
          type = this.$t('eating.restaurant');
          replaceTypes.push(type);
        } else if (type === 'bar') {
          type = this.$t('eating.bar');
          replaceTypes.push(type);
        } else if (type === 'establishment') {
          type = this.$t('eating.establishment');
          replaceTypes.push(type);
        } else if (type === 'cafe') {
          type = this.$t('eating.cafe');
          replaceTypes.push(type);
        } else if (type === 'meal_delivery') {
          type = this.$t('eating.meal_delivery');
          replaceTypes.push(type);
        } else if (type === 'meal_takeaway') {
          type = this.$t('eating.meal_takeaway');
          replaceTypes.push(type);
        } else { }
      });
      return replaceTypes.slice(0, 3);
    },
    selectPlace (index) {
      this.scheduledPlacesList.forEach(card => {
        card.isActive = false;
        if (card === this.scheduledPlacesList[index]) {
          card.isActive = true;
          if (card.googleDetails !== null) {
            this.options.center.lat = card.googleDetails.geometry.location.lat();
            this.options.center.lng = card.googleDetails.geometry.location.lng();
          }
        }
      });
    }
  },
  filters: {
    trimString (value) {
      return value.length > 10 ? value.substr(0, 10) + '...' : value;
    }
  }
};
