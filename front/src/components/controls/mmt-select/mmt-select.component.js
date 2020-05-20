export default {
  inheritAttrs: false,
  computed: {
    attrs () {
      const { rounded, filled, hideDetails, dense, ...other } = this.$attrs;
      return other;
    }
  }
};
