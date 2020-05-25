import { VBreadcrumbs, VBtn, VIcon, VSwitch, VTextField } from 'vuetify/lib';

import LeisureMap from './leisure.map.vue';
import { MmtTextInput } from '@components/';

export default {
  components: {
    MmtTextInput,
    LeisureMap,
    VBreadcrumbs,
    VIcon,
    VBtn,
    VTextField,
    VSwitch
  },
  data () {
    return {
      like: false,
      showMap: true,
      places: [
        {
          title: 'Музей',
          discription: 'Disc',
          rating: 4.0,
          state: 'Открыто',
          price: 2
        },
        {
          title: 'Музей2',
          discription: 'Disc',
          rating: 4.0,
          state: 'Открыто',
          price: 2
        },
        {
          title: 'Музей3',
          discription: 'Disc',
          rating: 4.0,
          state: 'Открыто',
          price: 2
        }
      ]
    };
  },
  mounted () {}
};
