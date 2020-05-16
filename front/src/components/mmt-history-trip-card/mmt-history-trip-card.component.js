import { VCard, VCardTitle, VCardSubtitle, VCardText, VBtn } from 'vuetify/lib';
import { format } from 'date-fns';

export default {
  name: 'mmt-history-trip-card',
  components: {
    VCard,
    VCardTitle,
    VCardSubtitle,
    VCardText,
    VBtn
  },
  filters: {
    date: function (value) {
      if (!value) {
        return '';
      }

      return format(new Date(value), 'dd MMMM');
    }
  },
  props: [ 'trip' ]
};
