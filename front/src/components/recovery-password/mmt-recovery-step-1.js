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
      rules: {
        isEmpty: v => !!v || this.$t('recoveryPassword.noEmpty'),
        validEmail: v => /.+@.+\..+/.test(v) || this.$t('recoveryPassword.thisNoEmail')
      }
    };
  },
  methods: {
    recoveryPassword () {
      this.$store.dispatch('recoveryPassword/recoveryPasswordSendEmail', { email: this.email })
        .then(this.valid = false)
        .catch(this.valid = true);
    }
  }
};
