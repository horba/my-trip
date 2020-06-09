export const requiredValidationMixin = {
  data () {
    return {
      rules: {
        required: value => !!value || this.$t('validationRules.noEmpty')
      }
    };
  }
};
