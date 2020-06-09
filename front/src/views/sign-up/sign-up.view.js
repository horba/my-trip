import { MmtTextInput } from '@components';

export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      email: 'user7@email.com',
      firstPass: 'password',
      secondPass: 'password',
      valid: true,
      showPass: false,
      existingEmail: false,
      rules: {
        isEmpty: v => !!v || this.$t('signUp.fillField'),
        minPassLen: v => v.length >= 8 || this.$t('signUp.leastCharacters'),
        validEmail: v => /.+@.+\..+/.test(v) || this.$t('signUp.invalidEmail'),
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
      this.$refs.signUpForm.validate();
    }
  }
};
