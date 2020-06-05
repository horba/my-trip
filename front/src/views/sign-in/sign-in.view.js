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
      process,
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
    },
    googleRedirect () {
      window.location = 'https://accounts.google.com/o/oauth2/v2/auth?scope=email'
      + '&include_granted_scopes=true&response_type=code&state=google-oauth'
      + `&redirect_uri=${window.location.origin}`
      + `&client_id=${process.env.VUE_APP_GOOGLE_OAUTH_CLIENT_ID}`;
    }
  }
};
