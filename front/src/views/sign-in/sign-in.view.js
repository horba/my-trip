import { MmtTextInput } from '@components';
const { googleOauth } = require('@/config/constants.json');

export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      email: '',
      password: '',
      serverError: '',
      formValidity: true,
      googleOauth,
      rules: [
        value => !!value || 'Поле не должно быть пустым'
      ]
    };
  },
  methods: {
    login () {
      this.$store.dispatch('login', {
        email: this.email,
        password: this.password
      })
        .then(() => {
          this.$router.push('/');
        }).catch(() => {
          this.serverError = 'Invalid credentials';
        });
    },
    onInput () {
      this.serverError = '';
    }
  }
};
