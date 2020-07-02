import { MmtTextInput } from '@components';
import { emailValidationMixin, requiredValidationMixin } from '@mixins';

export default {
  mixins: [emailValidationMixin, requiredValidationMixin],
  components: {
    MmtTextInput
  },
  data () {
    return {
      showFirstPassword: false,
      email: '',
      password: '',
      serverError: '',
      formValidity: true,
      process
    };
  },
  methods: {
    login () {
      this.$store.dispatch('auth/login', {
        email: this.email,
        password: this.password
      })
        .then(() => {
          this.$router.push('/');
        }).catch(err => {
          if (err.status === 401 || err.status === 400) {
            this.serverError = this.$t('signIn.invalidCredentials');
          } else {
            this.serverError = this.$t('signIn.unknownApiError');
          }
        });
    },
    onInput () {
      this.serverError = '';
    }
  },
  computed: {
    googleOauthUri () {
      return 'https://accounts.google.com/o/oauth2/v2/auth?scope=email'
      + '&include_granted_scopes=true&response_type=code&state=google-oauth'
      + `&redirect_uri=${window.location.origin}`
      + `&client_id=${process.env.VUE_APP_GOOGLE_OAUTH_CLIENT_ID}`;
    }
  }
};
