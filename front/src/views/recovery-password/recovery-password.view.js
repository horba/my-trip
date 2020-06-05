import { MmtTextInput } from '@components';
export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      email: '',
      step: 1,
      password: '',
      passwordConfirmation: '',
      valid: false,
      showPassword: false,
      showPasswordConfirmation: false,
      serverError: '',
      rules: {
        isEmpty: v => !!v || this.$t('recoveryPassword.noEmpty'),
        minPassLen: v => v.length >= 8 || this.$t('recoveryPassword.restriction'),
        validEmail: v => /.+@.+\..+/.test(v) || this.$t('recoveryPassword.thisNoEmail'),
        samePass: () => this.password === this.passwordConfirmation
          || this.$t('recoveryPassword.passwordMustIdentity')
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
    sendPassword () {
      this.valid = false;
      this.$store.dispatch('recoveryPasswordSendPassword',
        {
          password: this.passwordConfirmation,
          token: this.$route.params.token
        }).then(this.step = 3).catch(() => {
        this.step = 2;
        this.valid = true;
      });
    }
  },
  mounted () {
    if (this.$route.params.token !== undefined) {
      this.step = 2;
    }
  }
};
