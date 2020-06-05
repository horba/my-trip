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
        isEmpty: v => !!v || 'Заполните поле.',
        minPassLen: v => v.length >= 8 || 'Не менее 8 символов',
        validEmail: v => /.+@.+\..+/.test(v) || 'Не действительный e-mail',
        samePass: () => this.firstPass === this.secondPass || 'Пароли должны совпадать',
        existingEmail: () => !this.existingEmail || 'Этот e-mail уже занят. Попробуйте другой.'
      }
    };
  },
  methods: {
    async signUp () {
      if (this.valid) {
        const response = await this.$store.dispatch('auth/signUp', {
          email: this.email,
          password: this.firstPass
        });
        if (response === 'Ok') {
          this.$router.push('/login');
        }
        if (response === 'UnprocessableEntity') {
          this.existingEmail = true;
          this.validate();
          this.existingEmail = false;
        }
      }
    },
    validate () {
      this.$refs.signUpForm.validate();
    }
  }
};
