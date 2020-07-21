import { MmtTextInput } from '@/components';
import { format } from 'date-fns';
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
  VFileInput,
  VSnackbar
} from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';
const SNACK_BAR_TIMEOUT = 4000;
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
    VFileInput,
    VSnackbar
  },
  data () {
    return {
      menuDatePicker: false,
      menuTimePicker: false,
      isValid: false,
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
      snackBarMessage: '',
      showSnackBar: false,
      snackBarColor: ''
    };
  },
  computed: {
    google: gmapApi,
    isEditMode: vm => !!vm.$route.params.id,
    header: vm => vm.isEditMode
      ? vm.$t('scheduledPlaceToEatCreateOrEdit.edit')
      : vm.$t('scheduledPlaceToEatCreateOrEdit.addCafe')
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
      return format(new Date(date), 'yyyy-mm-dd');
    },
    onSaveSuccess () {
      const textForSnackbar = this.isEditMode
        ? this.$t('scheduledPlaceToEatCreateOrEdit.successfullyEdited')
        : this.$t('scheduledPlaceToEatCreateOrEdit.successfullySaved'),
            colorForSnackbar = 'success';
      this.showSnackbar(colorForSnackbar, textForSnackbar)
        .then(() => this.$router.push({ name: 'ScheduleEatingPlace' }));
    },
    onSaveError (error) {
      this.showSnackbar('error', error.data.title);
    },
    save () {
      if (this.isValid) {
        const payload = {
          dateTime: `${this.date}T${this.time}`,
          placeName: this.placeName,
          notes: this.notes,
          link: this.link,
          googlePlaceId: this.googlePlaceId,
          lat: this.lat,
          lng: this.lng
        };
        if (this.isEditMode) {
          payload.id = Number(this.$route.params.id);
          this.$store.dispatch('eating/updateEating', payload)
            .then(() => {
              if (this.files.length > 0) {
                return this.$store.dispatch('eating/uploadNewFilesEating', {
                  files: this.files,
                  eatingId: payload.id
                });
              }
            }).then(() => this.onSaveSuccess())
            .catch(error => this.onSaveError(error));
        } else {
          this.$store.dispatch('eating/createNewEating', payload)
            .then(r => {
              this.onSaveSuccess();
              return this.$store.dispatch('eating/uploadNewFilesEating', {
                files: this.files,
                eatingId: r.data
              });
            })
            .then(() => this.onSaveSuccess())
            .catch(error => this.onSaveError(error));
        }
      } else {
        this.$refs.form.validate();
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
    },
    showSnackbar (color, message) {
      this.snackBarColor = color;
      this.snackBarMessage = message;
      this.showSnackBar = true;
      return new Promise(function (resolve, reject) {
        setTimeout(() => resolve(true), SNACK_BAR_TIMEOUT);
      });
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
