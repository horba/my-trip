import { MmtTextInput } from '@components';
export default {
  components: {
    MmtTextInput
  },
  data () {
    return {
      error: false,
      success: false,
      email: '',
      serverError: '',
      formValidity: true,
      rules: [ value => !!value || 'Поле не должно быть пустым' ]
    };
  },
  methods: {
    onInput () {
      this.serverError = '';
    }
  }
};
