import { MmtTextInput } from '@components';
import { emailValidationMixin, requiredValidationMixin } from '@mixins';
import { VSnackbar } from 'vuetify/lib';

export default {
  mixins: [emailValidationMixin, requiredValidationMixin],
  components: {
    MmtTextInput,
    VSnackbar
  },
  name: 'mmt-recovery-step-1',
  data () {
    return {
      email: '',
      valid: false,
      snackBarShow: false,
      snackBarColor: '',
      snackBarMessage: ''
    };
  },
  methods: {
    recoveryPassword () {
      this.valid = false;
      this.$store.dispatch('recoveryPassword/recoveryPasswordSendEmail', { email: this.email })
        .then(() => {
          this.snackBarShow = true;
          this.snackBarMessage = this.$t('recoveryPassword.successfulSend');
          this.snackBarColor = 'success';
          this.valid = false;
        })
        .catch(error => {
          this.snackBarShow = true;
          this.snackBarMessage = error.data.title;
          this.snackBarColor = 'error';
          this.valid = true;
        });
    }
  }
};
