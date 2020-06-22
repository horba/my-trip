import { MmtTextInput } from '@/components';
import { requiredValidationMixin } from '@mixins';
import { LINK_REGEX } from '@constants';
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
              if (file.size > 10000000) {
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
      place_id: '',
      lat: 0,
      lng: 0,
      files: new FormData()
    };
  },
  computed: {
    google: gmapApi
  },
  methods: {
    findPlace (place) {
      this.place_id = place.place_id || '';
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
      this.$store.dispatch('eating/createNewEating',
        {
          dateTime: `${this.date}T${this.time}`,
          namePlace: this.namePlace,
          notes: this.notes,
          link: this.link,
          place_id: this.place_id,
          lat: this.lat,
          lng: this.lng,
          attachments: this.files
        });
    },
    uploadFiles (files) {
      files.forEach(file => {
        this.files.append('file', file);
      });
    }
  }
};
