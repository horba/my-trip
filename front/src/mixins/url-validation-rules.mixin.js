const { URL_REGEX } = require('@constants'),
      urlValidationMixin = {
        data () {
          return {
            urlRules: {
              validUrl: value =>
                !value
                  || RegExp(URL_REGEX).test(value)
                  || this.$t('validationRules.enterCorrectURL')
            }
          };
        }
      };

export { urlValidationMixin };
