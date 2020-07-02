import { VFooter, VRow, VCol, VTextField, VBtn, VIcon } from 'vuetify/lib';

export default {
  name: 'mmt-footer',
  components: {
    VFooter,
    VRow,
    VCol,
    VTextField,
    VBtn,
    VIcon,
    MmtLocaleSwitcher: () => import('../mmt-locale-switcher/mmt-locale-switcher.component.vue')
  },
  data: () => ({
    links1: [
      { title: 'menu.accommodation', route: '/accommodation' },
      { title: 'menu.leisure', route: 'leisure' },
      { title: 'menu.food', route: '/food' }
    ],
    links2: [
      { title: 'menu.privacyPolicy', route: '/privacy-policy' },
      { title: 'menu.cookiePolicy', route: '/cookie-policy' },
      { title: 'menu.termsOfUse', route: '/terms-of-use' },
      { title: 'menu.forTourOperators', route: '/for-tour-operators' },
      { title: 'menu.contacts', route: '/contacts' },
      { title: 'menu.reviewNew', route: '/review/new' }
    ]
  })
};
