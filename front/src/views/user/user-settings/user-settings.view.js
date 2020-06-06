import { MmtTextInput } from '@components';
import { mapState, mapGetters } from 'vuex';
const { emailRegex } = require('@/config/constants.json');

export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      editedUserSettings: {},
      formValidity: true,
      emailIsAlreadyTaken: false,
      emailRules: [
        email => RegExp(emailRegex).test(email)
        || this.$t('userSettings.enterCorrectEmail')
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
    }
  },
  created () {
    // if settings are available in store - fill fields
    if (this.userSettings) {
      this.editedUserSettings = Object.assign({}, this.userSettings);
    }
  }
};
