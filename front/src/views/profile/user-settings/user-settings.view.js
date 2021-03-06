import { MmtTextInput } from '@components';
import { mapState, mapGetters } from 'vuex';
import { VFileInput, VIcon } from 'vuetify/lib';
import { emailValidationMixin, requiredValidationMixin } from '@mixins';
const { MAX_AVATAR_SIZE_MB } = require('@constants'),
      MAX_AVATAR_SIZE_KB = 1024 * 1024 * MAX_AVATAR_SIZE_MB;

export default {
  mixins: [emailValidationMixin, requiredValidationMixin],
  components: {
    MmtTextInput,
    VFileInput,
    VIcon
  },
  data () {
    return {
      editedUserSettings: {},
      formValidity: true,
      emailIsAlreadyTaken: false,
      fileUploadError: '',
      avatarRules: [
        value => !value || value.size < MAX_AVATAR_SIZE_KB
          || `${this.$t('fileUpload.fileIsToBig')}.
          ${this.$t('fileUpload.correctFileSize')}: ${MAX_AVATAR_SIZE_MB} mb.`
      ]
    };
  },
  computed: {
    ...mapState('userSettings', [ 'userSettings' ]),
    ...mapGetters('dictionaries', ['genders', 'countries', 'languages']),
    isLoaded () {
      return !!Object.keys(this.editedUserSettings).length;
    }
  },
  watch: {
    userSettings (data) {
      if (!this.isLoaded) {
        this.editedUserSettings = Object.assign({}, data);
      }
    }
  },
  methods: {
    applySettings () {
      this.$store.dispatch('userSettings/updateUserSettings', this.editedUserSettings)
        .catch(error => {
          this.emailIsAlreadyTaken = error.response.data.isEmailUsed;
        });
    },
    avatarUpload (file) {
      this.fileUploadError = null;

      if (file && file.size < MAX_AVATAR_SIZE_KB) {
        const formData = new FormData();
        formData.append('file', file);

        this.$store.dispatch('userSettings/uploadUserAvatarFile', formData)
          .then(r => {
            this.editedUserSettings.avatarFileName = r.data;
          })
          .catch((error) => {
            this.fileUploadError = error.response.data;
          });
      }
    },
    avatarClear () {
      this.$store.dispatch('userSettings/deleteUserAvatarFile',
        this.editedUserSettings.avatarFileName)
        .then(() => {
          this.editedUserSettings.avatarFileName = null;
        });
    }
  },
  created () {
    // if settings are available in store - fill fields
    if (this.userSettings) {
      this.editedUserSettings = Object.assign({}, this.userSettings);
    }
  }
};
