import {
  MmtTextInput,
  MmtRecoveryStep1,
  MmtRecoveryStep2,
  MmtRecoveryStep3
} from '@components';
export default {
  components: {
    MmtTextInput,
    MmtRecoveryStep1,
    MmtRecoveryStep2,
    MmtRecoveryStep3
  },
  data () {
    return {
      step: 1
    };
  },
  mounted () {
    if (this.$route.params.token !== undefined) {
      this.step = 2;
    }
  }
};
