import { MmtTextInput, MmtSelect, MmtSubmitButton } from '@components';
import axios from 'axios';
const { serverPath, emailRegex } = require('@/config/config.dev.json');

export default {
  components: {
    MmtTextInput,
    MmtSelect,
    MmtSubmitButton
  },
  data () {
    return {
      genders: [],
      languages: [],
      countries: [],
      lastName: '',
      firstName: '',
      email: '',
      gender: '',
      language: '',
      country: '',
      isLoaded: false,
      emailAlreadyTaken: false,
      formValidity: true,
      emailRules: [
        email => RegExp(emailRegex).test(email)
        || this.$t('userSettings.email.errors.regexNotMatch')
      ]
    };
  },
  methods: {
    applySettings () {
      axios.put(`${serverPath}api/userSettings`,
        {
          lastName: this.lastName,
          firstName: this.firstName,
          email: this.email,
          gender: this.gender,
          language: this.language,
          country: this.country
        })
        .then(() => console.log('Settings updated'))
        .catch(error => {
          this.emailAlreadyTaken = error.response.data === 'Email already taken';
        });
    },
    fillLoadedFields (data) {
      this.genders = this.convertToSelectCompatible(data.genders, 'gender');
      this.languages = this.convertToSelectCompatible(data.languages, 'language');
      this.countries = this.convertToSelectCompatible(data.countries, 'country');
      this.gender = data.gender;
      this.language = data.language;
      this.country = data.country;
      this.email = data.email;
      this.firstName = data.firstName;
      this.lastName = data.lastName;
    },
    convertToSelectCompatible (arrOfValues, fieldType) {
      return arrOfValues.map(id => (
        {
          value: id,
          text: this.$t(`userSettings.${fieldType}.options.${id}`)
        }));
    }
  },
  created () {
    axios.get(`${serverPath}api/userSettings`)
      .then(({ data }) => {
        this.fillLoadedFields(data);
        this.isLoaded = true;
      });
  }
};
