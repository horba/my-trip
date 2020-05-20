export default {
  computed: {
    attrs () {
      const { rounded, depressed, large, ...other } = this.$attrs;
      return other;
    }
  }
};
