import { MmtTextInput } from '@/components';
import { requiredValidationMixin } from '@mixins';
import { LINK_REGEX, MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT } from '@constants';
import {
  VCol,
  VRow,
  VBtn,
  VIcon,
  VTextField,
  VMenu,
  VDatePicker,
  VTimePicker,
  VForm,
  VFileInput
} from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';
export default {
  mixins: [ requiredValidationMixin ],
  components: {
    VCol,
    VRow,
    VBtn,
    VIcon,
    VTextField,
    VMenu,
    VDatePicker,
    MmtTextInput,
    VTimePicker,
    VForm,
    VFileInput
  },
  data () {
    return {
      menuDatePicker: false,
      menuTimePicker: false,
      formValid: false,
      rules: {
        maxLengthName: v => v.length <= 200 || this.$t('eatingNew.maxLengthName'),
        maxLengthNotes: v => v.length <= 2000 || this.$t('eatingNew.maxLengthNotes'),
        linkValid: v => {
          if (v) {
            return RegExp(LINK_REGEX).test(v) || this.$t('eatingNew.isNoLink');
          } else {
            return true;
          }
        }, // правило на 10 мб
        fileValid: v => {
          if (v) {
            let valid = true;
            v.forEach(file => {
              if (file.size > MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT) {
                valid = false;
              }
            });
            return valid ? true : 'File size should be less than 10 MB!';
          } else {
            return true;
          }
        },
        fileLength: v => {
          if (v) {
            return v.length <= 10 || 'Количество вложений не должно быть больше 10';
          } else {
            return true;
          }
        }
      },
      date: new Date().toISOString().substr(0, 10), // new Date().toLocaleDateString()
      time: new Date().toTimeString().substr(0, 5),
      notes: '',
      link: '',
      namePlace: '',
      googlePlaceId: '',
      lat: 0,
      lng: 0,
      files: new FormData(),
      text: '',
      snackbar: false
    };
  },
  computed: {
    google: gmapApi
  },
  methods: {
    findPlace (place) {
      this.googlePlaceId = place.place_id || '';
      if (place.geometry) {
        this.lat = place.geometry.location.lat();
        this.lng = place.geometry.location.lng();
      }
    },
    parseDate (date) {
      if (!date) {
        return null;
      }

      const [month, day, year] = date.split('/');
      return `${year}-${month.padStart(2, '0')}-${day.padStart(2, '0')}`;
    },
    save () {
      const payload = {
        dateTime: `${this.date}T${this.time}`,
        namePlace: this.namePlace,
        notes: this.notes,
        link: this.link,
        googlePlaceId: this.googlePlaceId,
        lat: this.lat,
        lng: this.lng
      };
      if (this.$route.params.id) {
        payload.id = Number(this.$route.params.id);
        this.$store.dispatch('eating/updateEating', payload)
          .then(() => {
            this.text = this.$t('eatingNew.successfullyEdited');
            this.snackbar = true;
            this.$store.dispatch('eating/uploadNewFilesEating', {
              files: this.files,
              eatingId: payload.id
            });
          });
      } else {
        this.$store.dispatch('eating/createNewEating', payload)
          .then(r => {
            this.text = this.$t('eatingNew.successfullySaved');
            this.snackbar = true;
            this.$store.dispatch('eating/uploadNewFilesEating', {
              files: this.files,
              eatingId: r.data
            });
          });
      }
    },
    uploadFiles (files) {
      const tempFiles = new FormData();
      files.forEach(file => {
        if (file.size <= MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT) {
          tempFiles.append('file', file);
        }
      });
      this.files = tempFiles;
    }
  },
  mounted () {
    if (this.$route.params.id) {
      this.$store.dispatch('eating/getEatingUserByEatingId', { id: this.$route.params.id })
        .then(infoFromServer => {
          this.notes = infoFromServer.notes;
          this.link = infoFromServer.link;
          this.date = infoFromServer.dateTime.substr(0, 10);
          this.time = infoFromServer.dateTime.substr(11, 5);
          this.namePlace = infoFromServer.namePlace;
          this.googlePlaceId = infoFromServer.googlePlaceId;
        });
    }
  }
};
