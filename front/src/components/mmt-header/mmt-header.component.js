import { VAppBar, VNavigationDrawer, VBtn, VIcon } from 'vuetify/lib';

export default {
  name: 'mmt-header',
  components: {
    VAppBar,
    VNavigationDrawer,
    VBtn,
    VIcon
  },
  computed: {
    isAuthorize () {
      return this.$store.getters.isLoggedIn;
    }
  },
  data: () => ({
    drawer: false,
    links: [
      { title: 'menu.accommodation', route: '/accommodation' },
      { title: 'menu.transport', route: '/transport' },
      { title: 'menu.leisure', route: '/leisure' },
      { title: 'menu.food', route: '/food' },
      { title: 'menu.hotTours', route: '/hot-tours' },
      { title: 'menu.articles', route: '/articles' },
      { title: 'menu.signin', route: '/my/tickets', isAuthorize: false },
      { title: 'menu.signup', route: '/signup', isAuthorize: false },
      { title: 'menu.signout', route: '/logout', isAuthorize: true }
    ]
  })
};
