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
      isLabelError: false,
      requiredAsterisk: true
    };
  },
  computed: {
    isRequired () {
      return this.requiredAsterisk && (this.$attrs.rules || [])
        .some(rule => rule && rule.name === 'required');
    }
  },
  methods: {
    validateLabel (value) {
      const rules = this.$attrs.rules;
      this.isLabelError = rules ? rules.some(rule => rule(value) !== true) : false;
    }
  }
};
