import { MmtTextInput } from '@components';
import { mapState } from 'vuex';
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
    genders () {
      return [
        {
          text: this.$t('userSettings.genderIsNotSpecified'),
          value: 0
        },
        {
          text: this.$t('userSettings.male'),
          value: 1
        },
        {
          text: this.$t('userSettings.female'),
          value: 2
        },
        {
          text: this.$t('userSettings.otherGender'),
          value: 3
        }
      ];
    },
    countries () {
      return [
        {
          text: this.$t('userSettings.countryIsNotSpecified'),
          value: null
        },
        {
          text: this.$t('countries.Albania'),
          value: 1
        },
        {
          text: this.$t('countries.Canada'),
          value: 2
        },
        {
          text: this.$t('countries.Colombia'),
          value: 3
        },
        {
          text: this.$t('countries.Cyprus'),
          value: 4
        },
        {
          text: this.$t('countries.Dominica'),
          value: 5
        },
        {
          text: this.$t('countries.Egypt'),
          value: 6
        },
        {
          text: this.$t('countries.France'),
          value: 7
        },
        {
          text: this.$t('countries.Ukraine'),
          value: 8
        }
      ];
    },
    languages () {
      return [
        {
          text: this.$t('userSettings.languageIsNotSpecified'),
          value: null
        },
        {
          text: this.$t('locale.en'),
          value: 1
        },
        {
          text: this.$t('locale.ru'),
          value: 2
        },
        {
          text: this.$t('locale.ua'),
          value: 3
        }
      ];
    },
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
