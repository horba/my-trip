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
      showFirstPassword: false,
      showSecondPassword: false,
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
        const body = {
          email: this.email,
          password: this.firstPass
        };

        this.$store.dispatch('auth/signUp', body)
          .then(() => {
            this.$store.dispatch('auth/login', body);
            this.$router.push('/');
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
