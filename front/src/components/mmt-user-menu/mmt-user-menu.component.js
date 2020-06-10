import { VBtn, VIcon, VList, VNavigationDrawer, VSwitch } from 'vuetify/lib';

import MmtAvatar from '../controls/mmt-avatar/mmt-avatar.component.vue';

export default {
  name: 'mmt-user-menu',
  components: {
    VNavigationDrawer,
    VList,
    VBtn,
    VSwitch,
    VIcon,
    MmtAvatar
  },
  computed: {
    user () {
      return this.$store.getters['userSettings/getUserProfile'];
    }
  },
  data: () => ({
    items: [
      {
        title: 'menu.tickets',
        icon: 'mdi-ticket',
        link: '/my/tickets'
      },
      {
        title: 'menu.accommodation',
        icon: 'mdi-home',
        link: '/my/accommodation'
      },
      {
        title: 'menu.food',
        icon: 'mdi-food',
        link: '/my/food'
      },
      {
        title: 'menu.transport',
        icon: 'mdi-car',
        link: '/my/transport'
      },
      {
        title: 'menu.leisure',
        icon: 'mdi-airballoon',
        link: '/my/entertainments'
      },
      {
        title: 'menu.travelRoute',
        icon: 'mdi-bag-personal',
        link: '/my/travel-route'
      },
      {
        title: 'menu.bookmarks',
        icon: 'mdi-heart',
        route: '/my/bookmarks'
      },
      {
        title: 'menu.scheduler',
        icon: 'mdi-calendar-multiple-check',
        link: '/my/scheduler'
      },
      {
        title: 'menu.history',
        icon: 'mdi-history',
        link: '/my/history'
      },
      {
        title: 'menu.historyPrev',
        icon: 'mdi-rotate-left',
        link: '/my/history/prev',
        isChild: true
      },
      {
        title: 'menu.historyNext',
        icon: 'mdi-rotate-right',
        link: '/my/history/next',
        isChild: true
      },
      {
        title: 'menu.settings',
        icon: 'mdi-cog',
        link: '/my/settings'
      },
      {
        title: 'menu.notifications',
        icon: 'mdi-bell',
        link: '/my/notifications',
        switch: false
      },
      {
        title: 'menu.signout',
        icon: 'mdi-arrow-left-bold-circle-outline',
        type: 'signout'
      }
    ]
  }),
  methods: {
    itemSelected (item) {
      if (item.type === 'signout') {
        this.$store.dispatch('auth/logout');
      }
    }
  }
};
