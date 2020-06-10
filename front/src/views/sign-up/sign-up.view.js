import { emailValidationMixin, requiredValidationMixin } from '@mixins';

import { MmtTextInput } from '@components';

export default {
  mixins: [emailValidationMixin, requiredValidationMixin],
  components: {
    MmtTextInput
  },
  data () {
    return {
      email: '',
      firstPass: '',
      secondPass: '',
      valid: true,
      showPass: false,
      existingEmail: false,
      rules: {
        minPassLen: v => v.length >= 8 || this.$t('signUp.leastCharacters'),
        samePass: () => this.firstPass === this.secondPass || this.$t('signUp.passwordCoincide'),
        existingEmail: () => !this.existingEmail || this.$t('signUp.anotherEmail')
      }
    };
  },
  methods: {
    signUp () {
      if (this.valid) {
        this.$store.dispatch('auth/signUp', {
          email: this.email,
          password: this.firstPass
        })
          .then(() => {
            this.$router.push('/login');
          })
          .catch(err => {
            if (err.status === 422) {
              this.existingEmail = true;
              this.validate();
              this.existingEmail = false;
            }
          });
      }
    },
    validate () {
      console.log('validate');
      this.$refs.signUpForm.validate();
    }
  }
};
