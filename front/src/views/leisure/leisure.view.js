import { VBreadcrumbs, VIcon, VBtn, VTextField, VSwitch } from 'vuetify/lib';
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
      breadcrumbs: [
        {
          text: 'Досуг',
          disabled: false,
          href: 'breadcrumbs_dashboard'
        },
        {
          text: 'Экскурсии',
          disabled: false,
          href: 'breadcrumbs_link_1'
        },
        {
          text: 'Музеи и выставки',
          disabled: true,
          href: 'breadcrumbs_link_2'
        }
      ],
      leisureType: [
        'Активный отдых, экстрим',
        'Музеи и выставки',
        'Кинотеатры, театры',
        'Красота, здоровье, Spa',
        'Отдых для детей',
        'Отдых для компании',
        'Игровые клубы, квесты'
      ],
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
