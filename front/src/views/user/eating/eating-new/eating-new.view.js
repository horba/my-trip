import { MmtTextInput } from '@/components';
import {
  requiredValidationMixin,
  filesSizeValidMixin,
  linkValidMixin,
  filesCountValidMixin
} from '@mixins';
import {
  MAX_FILE_SIZE_SCHEDULET_PLACE_TO_EAT
} from '@constants';
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
  mixins: [
    requiredValidationMixin,
    filesSizeValidMixin,
    linkValidMixin,
    filesCountValidMixin
  ],
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
        maxLengthName: v => v.length <= 200
          || this.$t('scheduledPlaceToEatCreateOrEdit.maxLengthName'),
        maxLengthNotes: v => v.length <= 2000
          || this.$t('scheduledPlaceToEatCreateOrEdit.maxLengthNotes')
      },
      date: new Date().toISOString().substr(0, 10),
      time: new Date().toTimeString().substr(0, 5),
      notes: '',
      link: '',
      placeName: '',
      googlePlaceId: '',
      lat: 0,
      lng: 0,
      files: new FormData(),
      textForSnackbar: '',
      showSnackbar: false,
      colorForSnackbar: ''
    };
  },
  computed: {
    google: gmapApi,
    isEditMode: vm => !vm.$route.params.id,
    header: vm => vm.isEditMode
      ? vm.$t('scheduledPlaceToEatCreateOrEdit.addCafe')
      : vm.$t('scheduledPlaceToEatCreateOrEdit.edit')
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
    onSaveSuccess () {
      this.textForSnackbar = this.isEditMode
        ? this.$t('scheduledPlaceToEatCreateOrEdit.successfullySaved')
        : this.$t('scheduledPlaceToEatCreateOrEdit.successfullyEdited');
      this.showSnackbar = true;
      this.colorForSnackbar = 'success';
      this.$nextTick(() => this.$router.push({ name: 'ScheduleEatingPlace' }));
    },
    onSaveError (error) {
      this.textForSnackbar = error;
      this.showSnackbar = true;
      this.colorForSnackbar = 'error';
    },
    save () {
      if (this.formValid) {
        const payload = {
          dateTime: `${this.date}T${this.time}`,
          placeName: this.placeName,
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
              this.onSaveSuccess();
              return this.$store.dispatch('eating/uploadNewFilesEating', {
                files: this.files,
                eatingId: payload.id
              });
            }).then(() => this.$router.push({ name: 'ScheduleEatingPlace' })
              .catch(error => this.onSaveError(error)));
        } else {
          this.$store.dispatch('eating/createNewEating', payload)
            .then(r => {
              this.onSaveSuccess();
              return this.$store.dispatch('eating/uploadNewFilesEating', {
                files: this.files,
                eatingId: r.data
              });
            })
            .then(() => this.$router.push({ name: 'ScheduleEatingPlace' }))
            .catch(error => this.onSaveError(error));
        }
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
          this.notes = infoFromServer.data.notes ?? '';
          this.link = infoFromServer.data.link ?? '';
          this.date = infoFromServer.data.dateTime.substr(0, 10);
          this.time = infoFromServer.data.dateTime.substr(11, 5);
          this.placeName = infoFromServer.data.placeName;
          this.googlePlaceId = infoFromServer.data.googlePlaceId;
          this.files = infoFromServer.data.fileNames;
        });
    }
  }
};
