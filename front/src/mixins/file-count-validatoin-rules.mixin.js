const { MAX_FILE_COUNT_SCHEDULET_PLACE_TO_EAT } = require('@constants'),
      filesCountValidMixin = {
        data () {
          return {
            rules: {
              filesCountValid: v => {
                if (v) {
                  return v.length <= MAX_FILE_COUNT_SCHEDULET_PLACE_TO_EAT
                    || this.$t('validationRules.tooManyAttachments'
                      , [ MAX_FILE_COUNT_SCHEDULET_PLACE_TO_EAT ]);
                } else {
                  return true;
                }
              }
            }
          };
        }
      };

export { filesCountValidMixin };
