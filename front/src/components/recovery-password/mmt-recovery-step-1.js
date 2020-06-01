import { MmtTextInput } from '@components';
export default {
  components: {
    MmtTextInput
  },
  name: 'mmt-recovery-step-1',
  data () {
    return {
      email: '',
      valid: false,
      serverError: '',
      rules: {
        isEmpty: v => !!v || this.$t('recoveryPassword.noEmpty'),
        validEmail: v => /.+@.+\..+/.test(v) || this.$t('recoveryPassword.thisNoEmail')
      }
    };
  },
  methods: {
    onInput (input) {
      this.serverError = '';
    },
    recoveryPassword () {
      this.$store.dispatch('recoveryPassword/recoveryPasswordSendEmail', { email: this.email })
        .then(this.valid = false)
        .catch(this.valid = true);
    }
  }
};
