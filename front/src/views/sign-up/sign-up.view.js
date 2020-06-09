import { MmtTextInput } from '@components';

export default {
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
        isEmpty: v => !!v || 'Заполните поле.',
        minPassLen: v => v.length >= 8 || 'Не менее 8 символов',
        validEmail: v => /.+@.+\..+/.test(v) || 'Не действительный e-mail',
        samePass: () => this.firstPass === this.secondPass || 'Пароли должны совпадать',
        existingEmail: () => !this.existingEmail || 'Этот e-mail уже занят. Попробуйте другой.'
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
      this.$refs.signUpForm.validate();
    }
  }
};
