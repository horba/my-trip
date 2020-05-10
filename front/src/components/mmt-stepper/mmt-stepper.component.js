import { VDivider, VIcon } from 'vuetify/lib';

export default {
  name: 'mmt-stepper',
  components: {
    VDivider,
    VIcon
  },
  data: () => ({
    items: [
      {
        title: 'Tickets',
        icon: 'mdi-ticket',
        link: '/my/tickets',
        details: 'Kiev-Krakov 4-9 may $ 44'
      },
      {
        title: 'Accommodation',
        icon: 'mdi-home',
        link: '/my/accommodation'
      },
      {
        title: 'Food',
        icon: 'mdi-food',
        link: '/my/food'
      },
      {
        title: 'Transport',
        icon: 'mdi-car',
        link: '/my/transport'
      },
      {
        title: 'Leisure',
        icon: 'mdi-airballoon',
        link: '/my/leisure'
      }
    ]
  }),
  methods: {
    getIconClass (item) {
      return this.getStep(item.link) <= this.getCurrentStep()
        ? 'primary'
        : 'accent lighten-2';
    },
    getPverClass (item, n) {
      return n === 0 ? 'white'
        : this.getStep(item.link) <= this.getCurrentStep() + 1
          ? 'primary'
          : 'accent lighten-2';
    },
    getNextClass (item, n) {
      return n === this.items.length - 1 ? 'white'
        : this.getStep(item.link) <= this.getCurrentStep()
          ? 'primary'
          : 'accent lighten-2';
    },
    getCurrentStep () {
      return this.getStep(this.$route.path);
    },
    getStep (path) {
      return this.items.findIndex((el) => path === el.link) + 1;
    }
  }
};
