import { MmtTextInput } from '@components';
import { fetchServer } from '@/services/fetchServer.js';

export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      email: '',
      password: '',
      serverError: '',
      formValidity: true,
      rules: [
        value => !!value || 'Поле не должно быть пустым'
      ]
    };
  },
  methods: {
    login () {
      this.$store.dispatch('login', {
        email: this.email,
        password: this.password
      })
        .then(() => {
          fetchServer();
          this.$router.push('/');
        }).catch(() => {
          this.serverError = 'Invalid credentials';
        });
    },
    onInput () {
      this.serverError = '';
    }
  }
};
