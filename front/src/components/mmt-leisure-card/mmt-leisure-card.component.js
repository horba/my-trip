import { VIcon, VRating } from 'vuetify/lib';

import i18n from '@/plugins/i18n';

export default {
  components: {
    VRating,
    VIcon
  },
  name: 'mmt-leisure-card',
  props: ['place', 'isActive'],
  filters: {
    splitTypes (value) {
      const result = [];
      value.forEach(e => {
        result.push(i18n.t(`entertainmentType.${e}`));
      });
      return result.join(', ');
    }
  }
};
