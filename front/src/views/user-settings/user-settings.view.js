import { MmtTextInput } from '@components';
import axios from 'axios';
const { serverPath } = require('@/config/config.dev.json');

export default {
  components: {
    MmtTextInput
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
      isLoaded: false
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
        .then(() => alert('Updated'));
    }
  },
  created () {
    axios.get(`${serverPath}api/userSettings`)
      .then(({ data }) => {
        Object.assign(this, data);
        this.isLoaded = true;
      });
  }
};
