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
      { title: 'Жилье', route: '/accommodation' },
      { title: 'Транспорт', route: '/transport' },
      { title: 'Досуг', route: '/leisure' },
      { title: 'Еда', route: '/food' },
      { title: 'Горящие туры', route: '/hot-tours' },
      { title: 'Статьи', route: '/articles' },
      { title: 'Вход', route: '/login', isAuthorize: false },
      { title: 'Регистрация', route: '/signup', isAuthorize: false },
      { title: 'Выход', route: '/logout', isAuthorize: true }
    ]
  })
};
