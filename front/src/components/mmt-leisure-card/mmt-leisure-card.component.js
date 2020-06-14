import { VRating } from 'vuetify/lib';

export default {
  components: {
    VRating
  },
  name: 'mmt-leisure-card',
  props: [ 'place' ],
  rating: [],
  filters: {
    splitTypes (value) {
      return value.join(', ');
    },
    trimString (value, count) {
      return value.length > count ? value.substr(0, count) + '...' : value;
    }
  }
};
