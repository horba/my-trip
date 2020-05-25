import { MmtTextInput } from '@components';
import { mapActions, mapGetters } from 'vuex';
const { emailRegex } = require('@/config/constants.json');

export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      lastName: '',
      firstName: '',
      email: '',
      gender: 0,
      languageId: null,
      countryId: null,
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
          languageId: this.languageId,
          countryId: this.countryId
        }
      )
        .catch(error => {
          this.emailIsAlreadyTaken = error.response.data === 'Email is already taken';
        });
    },
    fillLoadedFields (data) {
      this.gender = data.gender;
      this.languageId = data.languageId;
      this.countryId = data.countryId;
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
