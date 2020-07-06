import { MmtTextInput, MmtDatetimePicker } from '@components';
import { mapGetters } from 'vuex';
import {
  VFileInput,
  VIcon,
  VAutocomplete,
  VTextarea
} from 'vuetify/lib';
import {
  requiredValidationMixin,
  urlValidationMixin,
  accommodationGoogleApiMixin
} from '@mixins';
const { baseUrl } = require('@/config/config.dev.json');
const { MAX_ACCOMODATION_SIZE_MB, SERVER_ACCOMODATIONS_PATH } = require('@constants'),
      MAX_ACCOMODATION_SIZE_KB = 1024 * 1024 * MAX_ACCOMODATION_SIZE_MB;

export default {
  mixins: [requiredValidationMixin, urlValidationMixin, accommodationGoogleApiMixin],
  components: {
    MmtTextInput,
    MmtDatetimePicker,
    VFileInput,
    VIcon,
    VAutocomplete,
    VTextarea
  },
  data () {
    return {
      accommodation: {},
      accommodationInit: {},
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
      ],
      nameRules: {
        maxLength: value => !value || value.length <= 200 || this.$t('validationRules.maxLength')
          .replace('{0}', 200)
      },
      notesRules: {
        maxLength: value => !value || value.length <= 2000 || this.$t('validationRules.maxLength')
          .replace('{0}', 2000)
      },
      guestRules: {
        minValue: value => value >= 1 || this.$t('validationRules.minValue')
          .replace('{0}', 1),
        maxValue: value => value <= 30 || this.$t('validationRules.maxValue')
          .replace('{0}', 30)
      },
      roomRules: {
        minValue: value => value >= 1 || this.$t('validationRules.minValue')
          .replace('{0}', 1),
        maxValue: value => value <= 15 || this.$t('validationRules.maxValue')
          .replace('{0}', 15)
      },
      priceRules: {
        minValue: value => value >= 1 || this.$t('validationRules.minValue')
          .replace('{0}', 1),
        maxValue: value => value <= 1000000 || this.$t('validationRules.maxValue')
          .replace('{0}', 1000000)
      },
      departureDateTimeValidation: () => true
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
  computed: {
    ...mapGetters('dictionaries', [ 'countries' ])
  },
  methods: {
    async initAccommodation () {
      if (this.$route.params.id) {
        await this.$store.dispatch('accommodations/getAccommodation',
          this.$route.params.id)
          .then((response) => {
            this.accommodation = response.data;
            this.accommodation.place = this.accommodation.name;
            this.accommodationInit = this.accommodation;
            this.findPlace(this.accommodation.address, this.initPlaceSuccessCallback);
          });
      } else {
        this.accommodation = {
          guestCount: 2,
          roomsCount: 1,
          countryId: null,
          photos: [],
          arrivalDateTime: new Date(),
          departureDateTime: new Date()
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
    validateDepartureDateTime () {
      const valid = new Date(this.accommodation.departureDateTime)
        >= new Date(this.accommodation.arrivalDateTime);
      if (valid) {
        this.departureDateTimeValidation = true;
        return;
      }
      this.departureDateTimeValidation = this.$t('accommodations.departureArrivalDateValidation');
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
            this.deleteByFileName(fileName);
          });
      });
    },
    deleteFile (fileName) {
      if (!fileName.startsWith('http')) {
        this.$store.dispatch('accommodations/deleteFile', fileName)
          .then(() => {
            this.deleteByFileName(fileName);
          });
      } else {
        this.deleteByFileName(fileName);
      }
    },
    deleteByFileName (fileName) {
      const index = this.accommodation.photos.indexOf(fileName);
      if (index > -1) {
        this.accommodation.photos.splice(index, 1);
      }
    }
  },
  async created () {
    await this.initAccommodation();
  }
};
