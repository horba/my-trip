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
          this.$store.dispatch('userSettings/loadUserSettings');
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
