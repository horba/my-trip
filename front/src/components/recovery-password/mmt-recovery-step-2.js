import { MmtTextInput } from '@components';
export default {
  components: {
    MmtTextInput
  },
  name: 'mmt-recovery-step-2',
  data () {
    return {
      password: '',
      passwordConfirmation: '',
      valid: false,
      showPassword: false,
      showPasswordConfirmation: false,
      serverError: '',
      rules: {
        isEmpty: v => !!v || this.$t('recoveryPassword.noEmpty'),
        minPassLen: v => v.length >= 8 || this.$t('recoveryPassword.restriction'),
        samePass: () => this.password === this.passwordConfirmation
          || this.$t('recoveryPassword.passwordMustIdentity')
      }
    };
  },
  methods: {
    onInput (input) {
      this.serverError = '';
    },
    sendPassword () {
      this.valid = false;
      this.$store.dispatch('recoveryPassword/recoveryPasswordSendPassword',
        {
          password: this.passwordConfirmation,
          token: this.$route.params.token
        }).then(this.step = 3).catch(() => {
        this.step = 2;
        this.valid = true;
      });
    }
  }
};
