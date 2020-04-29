import { VCard, VCardTitle, VCardSubtitle, VCardText } from 'vuetify/lib';

export default {
  name: 'hello-world',
  components: {
    VCard,
    VCardTitle,
    VCardSubtitle,
    VCardText
  },
  props: {
    msg: String
  }
};
