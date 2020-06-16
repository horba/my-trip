import { MmtTextInput } from '@components';
import { VFileInput, VIcon, VAutocomplete, VMenu, VDatePicker } from 'vuetify/lib';
import { requiredValidationMixin, accommodationGoogleApiMixin } from '@mixins';
const { baseUrl } = require('@/config/config.dev.json');
const { MAX_ACCOMODATION_SIZE_MB, SERVER_ACCOMODATIONS_PATH } = require('@constants'),
      MAX_ACCOMODATION_SIZE_KB = 1024 * 1024 * MAX_ACCOMODATION_SIZE_MB;

export default {
  mixins: [requiredValidationMixin, accommodationGoogleApiMixin],
  components: {
    MmtTextInput,
    VFileInput,
    VIcon,
    VAutocomplete,
    VMenu,
    VDatePicker
  },
  data () {
    return {
      accommodation: Object,
      accommodationInit: Object,
      formValidity: true,
      menuArrivalDateTime: false,
      menuDepartureDateTime: false,
      mapSelector: 'map-holder',
      autocompleteSelector: 'placeAutocomplete',
      fileUploadError: '',
      fileUploadRules: [
        value => !value || value.filter(f => f.size < MAX_ACCOMODATION_SIZE_KB).length
          || `${this.$t('fileUpload.fileIsToBig')}.
          ${this.$t('fileUpload.correctFileSize')}: ${MAX_ACCOMODATION_SIZE_MB} mb.`
      ]
    };
  },
  watch: {
    selectedPlace () {
      if (this.place.selected) {
        this.accommodation.address = this.place.selected.formatted_address
          ? this.place.selected.formatted_address : null;
        this.accommodation.link = this.place.selected.website
          ? this.place.selected.website : null;
        this.accommodation.note = this.place.selected.formatted_phone_number
          ? this.place.selected.formatted_phone_number : null;
        this.accommodation.rating = this.place.selected.rating
          ? this.place.selected.rating : null;
        this.accommodation.ratingTotal = this.place.selected.user_ratings_total
          ? this.place.selected.user_ratings_total : null;
        this.accommodation.priceLevel = this.place.selected.price_level
          ? this.place.selected.price_level : null;
        this.accommodation.locationLat = this.place.selected.geometry.location.lat
          ? this.place.selected.geometry.location.lat : null;
        this.accommodation.locationLng = this.place.selected.geometry.location.lng
          ? this.place.selected.geometry.location.lng : null;
        this.accommodation.googlePlaceId = this.place.selected.place_id;
        this.accommodation.photos
          .filter(photo => photo.startsWith('http'))
          .forEach(photo => {
            this.accommodation.photos.pop(photo);
          });
        this.place.selected.photos.forEach(photo => {
          this.accommodation.photos.push(photo.getUrl());
        });
      } else {
        this.accommodation = Object.assign({}, this.accommodationInit);
      }
    }
  },
  methods: {
    async initAccommodation () {
      if (this.$route.params.id) {
        await this.$store.dispatch('accommodations/getAccommodation',
          this.$route.params.id)
          .then((response) => {
            this.accommodation = response.data;
            this.accommodation.place = this.accommodation.name;
            this.accommodation.arrivalDateTime = this.accommodation.arrivalDateTime
              .split('T')[0];
            this.accommodation.departureDateTime = this.accommodation.departureDateTime
              .split('T')[0];
            this.accommodationInit = this.accommodation;
          });
      } else {
        this.accommodation = {
          guestCount: 2,
          roomsCount: 1,
          arrivalDateTime: new Date().toISOString().substr(0, 10),
          departureDateTime: new Date().toISOString().substr(0, 10),
          photos: []
        };
        this.accommodationInit = this.accommodation;
      }
    },
    async saveAccommodation () {
      const formData = Object.assign({}, this.accommodation);
      if (!this.accommodation.name && this.accommodation.place) {
        formData.name = this.accommodation.place;
      } else if (this.accommodation.name.name) {
        formData.name = this.accommodation.name.name;
      }
      await this.$store.dispatch('accommodations/addOrUpdateAccommodation', formData)
        .then(() => {
          this.$router.push('/my/accommodation');
        });
    },
    getFilePath (fileName) {
      return !fileName.startsWith('http')
        ? `${baseUrl}/${SERVER_ACCOMODATIONS_PATH}/${fileName}`
        : fileName;
    },
    fileUpload (files) {
      this.fileUploadError = null;
      if (files && files.length) {
        files.forEach(file => {
          const formData = new FormData();
          formData.append('file', file);

          this.$store.dispatch('accommodations/uploadFile', formData)
            .then(r => {
              this.accommodation.photos.push(r.data);
            })
            .catch((error) => {
              this.fileUploadError = error.response.data;
            });
        });
      }
    },
    fileUploadClear () {
      this.accommodation.photos.forEach(fileName => {
        this.$store.dispatch('accommodations/deleteFile', fileName)
          .then(() => {
            this.accommodation.photos.pop(fileName);
          });
      });
    }
  },
  async created () {
    await this.initAccommodation();
  }
};
