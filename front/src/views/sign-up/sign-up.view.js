import { MmtTextInput } from '@components';
import { emailValidationMixin, requiredValidationMixin } from '@mixins';

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
        minPassLen: v => v.length >= 8 || 'Не менее 8 символов',
        samePass: () => this.firstPass === this.secondPass || 'Пароли должны совпадать',
        existingEmail: () => !this.existingEmail || 'Этот e-mail уже занят. Попробуйте другой.'
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
