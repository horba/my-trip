import { MmtTextInput, MmtSelect, MmtSubmitButton } from '@components';
import { mapActions, mapGetters } from 'vuex';
const { emailRegex } = require('@/config/constants.json');

export default {
  components: {
    MmtTextInput,
    MmtSelect,
    MmtSubmitButton
  },
  data () {
    return {
      lastName: '',
      firstName: '',
      email: '',
      gender: '',
      language: '',
      country: '',
      isLoaded: false,
      emailIsAlreadyTaken: false,
      formValidity: true,
      emailRules: [
        email => RegExp(emailRegex).test(email)
        || this.$t('userSettings.enterCorrectEmail')
      ]
    };
  },
  computed: {
    genders () {
      return [
        {
          text: this.$t('userSettings.genderIsNotSpecified'),
          value: 'NotSpecified'
        },
        {
          text: this.$t('userSettings.male'),
          value: 'Male'
        },
        {
          text: this.$t('userSettings.female'),
          value: 'Female'
        },
        {
          text: this.$t('userSettings.otherGender'),
          value: 'Other'
        }
      ];
    },
    countries () {
      return [
        {
          text: this.$t('userSettings.countryIsNotSpecified'),
          value: 'NotSpecified'
        },
        {
          text: this.$t('userSettings.ukraine'),
          value: 'Ukraine'
        },
        {
          text: this.$t('userSettings.poland'),
          value: 'Poland'
        },
        {
          text: this.$t('userSettings.germany'),
          value: 'Germany'
        },
        {
          text: this.$t('userSettings.russia'),
          value: 'Russia'
        }
      ];
    },
    languages () {
      return [
        {
          text: this.$t('locale.ru'),
          value: 'Russian'
        },
        {
          text: this.$t('locale.ua'),
          value: 'Ukrainian'
        },
        {
          text: this.$t('locale.en'),
          value: 'English'
        },
        {
          text: this.$t('locale.de'),
          value: 'German'
        }
      ];
    },
    ...mapGetters('userSettings', [ 'userSettings' ])
  },
  watch: {
    userSettings (data) {
      if (!this.isLoaded) {
        this.fillLoadedFields(data);
      }
    }
  },
  methods: {
    ...mapActions('userSettings', [ 'updateUserSettings' ]),
    applySettings () {
      this.updateUserSettings(
        {
          lastName: this.lastName,
          firstName: this.firstName,
          email: this.email,
          gender: this.gender,
          language: this.language,
          country: this.country
        }
      )
        .catch(error => {
          this.emailIsAlreadyTaken = error.response.data === 'Email is already taken';
        });
    },
    fillLoadedFields (data) {
      this.gender = data.gender;
      this.language = data.language;
      this.country = data.country;
      this.email = data.email;
      this.firstName = data.firstName;
      this.lastName = data.lastName;
      this.isLoaded = true;
    }
  },
  created () {
    // if settings are available in store - fill fields
    if (this.userSettings != null) {
      this.fillLoadedFields(this.userSettings);
    }
  }
};
