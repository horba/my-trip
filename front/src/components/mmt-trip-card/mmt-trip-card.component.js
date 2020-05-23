import { VCard, VCardTitle, VCardSubtitle, VCardText, VBtn } from 'vuetify/lib';

export default {
  name: 'mmt-history-trip-card',
  components: {
    VCard,
    VCardTitle,
    VCardSubtitle,
    VCardText,
    VBtn
  },
  props: [ 'trip' ]
};
