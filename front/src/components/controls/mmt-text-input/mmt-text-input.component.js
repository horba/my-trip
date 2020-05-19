export default {
  props: {
    mmtLabel: {
      required: false,
      type: String,
      default: ''
    },
    mmtDense: {
      required: false,
      type: Boolean,
      default: false
    }
  },
  inheritAttrs: false,
  data () {
    return {
      isLabelError: false
    };
  },
  methods: {
    validateLabel (value) {
      const rules = this.$attrs.rules;
      this.isLabelError = rules ? rules.some(rule => rule(value) !== true) : false;
    }
  }
};
