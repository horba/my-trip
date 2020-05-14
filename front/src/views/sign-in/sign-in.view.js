import { MmtTextInput } from '@components';
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
        }).catch((error) => {
          this.serverError = error.response.data || 'Invalid password';
        });
    },
    onInput () {
      this.serverError = '';
    }
  }
};