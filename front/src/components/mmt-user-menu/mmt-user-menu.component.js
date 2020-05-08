import { VNavigationDrawer, VList, VBtn, VSwitch, VIcon } from 'vuetify/lib';

export default {
  name: 'mmt-user-menu',
  components: {
    VNavigationDrawer,
    VList,
    VBtn,
    VSwitch,
    VIcon
  },
  data: () => ({
    user: {
      fullName: 'OKSANA BEREZNIEVATA',
      email: 'oksana@gmail.com',
      avatar: 'https://randomuser.me/api/portraits/women/85.jpg'
    },
    items: [
      { title: 'Билеты', icon: 'mdi-ticket', link: '/my/tickets' },
      { title: 'Жилье', icon: 'mdi-home', link: '/my/accommodation' },
      { title: 'Еда', icon: 'mdi-food', link: '/my/food' },
      { title: 'Транспорт', icon: 'mdi-car', link: '/my/transport' },
      { title: 'Досуг', icon: 'mdi-airballoon', link: '/my/leisure' },
      { title: 'Маршрут', icon: 'mdi-bag-personal', link: '/my/travel-route' },
      { title: 'Закладки', icon: 'mdi-heart', route: '/my/bookmarks' },
      { title: 'Планер', icon: 'mdi-calendar-multiple-check', link: '/my/scheduler' },
      { title: 'История', icon: 'mdi-history', link: '/my/history' },
      { title: 'Предыдущие', icon: 'mdi-rotate-left', link: '/my/history/prev', isChild: true },
      { title: 'Предстоящие', icon: 'mdi-rotate-right', link: '/my/history/next', isChild: true },
      { title: 'Настройки', icon: 'mdi-cog', link: '/my/settings' },
      { title: 'Уведомления', icon: 'mdi-bell', link: '/my/notifications', switch: false },
      { title: 'Выход', icon: 'mdi-arrow-left-bold-circle-outline', link: '/signout' }
    ]
  })
};
