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
      markers: [],
      defaultImage: '@/assets/default-image.jpg'
    };
  },
  computed: {
    google: gmapApi
  },
  mounted () {
    this.geolocate();
  },
  methods: {
    geolocate () {
      navigator.geolocation.getCurrentPosition(position => {
        const pos = { lat: position.coords.latitude, lng: position.coords.longitude };
        this.PosMarker = pos;
        this.options.center = pos;
        this.$refs.mapRef.$mapPromise.then((map) => {
          map.setCenter(pos);
          map.setZoom(16);
          this.getNearbyPlacesFromCenter();
        });
      });
    },
    getNearbyPlacesFromCenter () {
      const request = {
        location: this.options.center,
        radius: 1000,
        types: [
          'food',
          'restaurant',
          'bar',
          'establishment',
          'cafe',
          'meal_delivery',
          'meal_takeaway'
        ]
      };
      this.gmapNearbySearch(request, true);
    },
    gmapNearbySearch (req, setCenter) {
      let service;
      const request = req;
      this.$refs.mapRef.$mapPromise.then((map) => {
        service = new this.google.maps.places.PlacesService(map);
        service.nearbySearch(request, (results, status) => {
          if (status === this.google.maps.places.PlacesServiceStatus.OK) {
            results.forEach(el => {
              this.gmapGetDetails(el);
            });
            if (setCenter) {
              map.setCenter(results[0].geometry.location);
            };
          }
        });
      });
    },
    gmapGetDetails (el) {
      const request = {
        placeId: el.place_id,
        fields:
          [
            'name',
            'rating',
            'vicinity',
            'geometry',
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
            if (!place.photos) {
              place.photos = [];
              place.photos.push({ getUrl () { return this.defaultImage; } });
            }
            place.isActive = false;
            this.markers.push(place);
          }
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
    selectPlace (place) {
      this.markers.forEach((marker) => {
        marker.isActive = false;
      });
      place.isActive = true;
      this.$refs.mapRef.$mapPromise.then((map) => {
        map.setCenter(place.geometry.location);
      });
    }
  },
  filters: {
    trimString (value) {
      return value.length > 10 ? value.substr(0, 10) + '...' : value;
    }
  }
};
