import { MmtTextInput } from '@components';
export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      email: '',
      step: 1,
      firstPass: '',
      secondPass: '',
      valid: true,
      showPass: false,
      serverError: '',
      rules: {
        isEmpty: v => !!v || this.$t('recoverypassword.noempty'),
        minPassLen: v => v.length >= 8 || this.$t('recoverypassword.restriction'),
        validEmail: v => /.+@.+\..+/.test(v) || this.$t('recoverypassword.thisnoemail'),
        samePass: () => this.firstPass === this.secondPass
          || this.$t('recoverypassword.passmastidentity')
      }
    };
  },
  methods: {
    onInput (input) {
      this.serverError = '';
    },
    recoveryPassword () {
      this.$store.dispatch('recoveryPasswordSendEmail', { email: this.email })
        .then(this.valid = false);
    },
    SendPassword () {
      this.$store.dispatch('recoveryPasswordSendPassword',
        {
          password: this.secondPass,
          token: this.$route.params.token
        }).then(this.step = 3);
    }
  },
  mounted () {
    if (this.$route.params.token !== undefined) {
      this.step = 2;
      this.email = localStorage.getItem('email');
    }
  }
};
