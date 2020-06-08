import { VAppBar, VNavigationDrawer, VBtn, VIcon, VContainer } from 'vuetify/lib';

export default {
  name: 'mmt-header',
  components: {
    VAppBar,
    VNavigationDrawer,
    VBtn,
    VIcon,
    VContainer
  },
  data: () => ({
    drawer: false
  }),
  computed: {
    isAuthorize () {
      return this.$store.getters['auth/isLoggedIn'];
    },
    links () {
      return [
        { title: 'menu.accommodation', route: '/accommodation', isVisible: true },
        { title: 'menu.transport', route: '/transport', isVisible: true },
        { title: 'menu.leisure', route: '/leisure', isVisible: true },
        { title: 'menu.food', route: '/food', isVisible: true },
        { title: 'menu.hotTours', route: '/hot-tours', isVisible: true },
        { title: 'menu.articles', route: '/articles', isVisible: true },
        { title: 'menu.signin', route: '/login', isVisible: !this.isAuthorize },
        { title: 'menu.signup', route: '/signup', isVisible: !this.isAuthorize }
      ];
    }
  }
};
