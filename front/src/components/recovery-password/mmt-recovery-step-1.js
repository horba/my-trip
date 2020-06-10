import { MmtTextInput } from '@components';
import { emailValidationMixin, requiredValidationMixin } from '@mixins';

export default {
  mixins: [emailValidationMixin, requiredValidationMixin],
  components: {
    MmtTextInput
  },
  name: 'mmt-recovery-step-1',
  data () {
    return {
      email: '',
      valid: false
    };
  },
  methods: {
    recoveryPassword () {
      this.valid = false;
      this.$store.dispatch('recoveryPassword/recoveryPasswordSendEmail', { email: this.email })
        .catch(this.valid = true);
    }
  }
};
