import axios from 'axios';

import { MmtTextInput } from '@components';
export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      valid: true,
      email: '',
      firstPass: '',
      secondPass: '',
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
    signUp () {
      if (this.valid) {
        this.showHint = !this.showHint;
        const body = {
          email: this.email,
          password: this.firstPass
        };

        axios.post('https://localhost:5001/api/auth/signup', body)
          .then(() => this.$router.push('/login'))
          .catch(e => {
            if (e && e.response.status === 422) {
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
