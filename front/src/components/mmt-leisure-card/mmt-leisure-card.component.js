import { VIcon, VRating } from 'vuetify/lib';

export default {
  components: {
    VRating,
    VIcon
  },
  name: 'mmt-leisure-card',
  props: ['place', 'isActive'],
  filters: {
    splitTypes (value) {
      return value.join(', ');
    },
    trimString (value, count) {
      return value.length > count ? value.substr(0, count) + '...' : value;
    }
  }
};
