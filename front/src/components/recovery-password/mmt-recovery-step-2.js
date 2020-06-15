import { MmtTextInput } from '@components';
import { requiredValidationMixin } from '@mixins';

export default {
  mixins: [ requiredValidationMixin ],
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
        minPassLen: v => v.length >= 8 || this.$t('recoveryPassword.restriction'),
        samePass: () => this.password === this.passwordConfirmation
          || this.$t('recoveryPassword.passwordMustIdentity')
      }
    };
  },
  methods: {
    sendPassword () {
      this.valid = false;
      this.$store.dispatch('recoveryPassword/recoveryPasswordSendPassword',
        {
          password: this.passwordConfirmation,
          token: this.$route.params.token
        }).then(this.$emit('stepDone'));
    }
  }
};
