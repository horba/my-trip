import { VFooter, VRow, VCol, VTextField, VBtn, VIcon } from 'vuetify/lib';

export default {
  name: 'mmt-footer',
  components: {
    VFooter,
    VRow,
    VCol,
    VTextField,
    VBtn,
    VIcon
  },
  data: () => ({
    links1: [
      { title: 'Жилье', route: '/accommodation' },
      { title: 'Транспорт', route: '/transport' },
      { title: 'Досуг', route: 'leisure' },
      { title: 'Еда', route: '/food' },
      { title: 'Горящие туры', route: '/hot-tours' },
      { title: 'Статьи', route: '/articles' }
    ],
    links2: [
      { title: 'Политика конфиденциальности', route: '/privacy-policy' },
      { title: 'Политика использования Cookie', route: '/cookie-policy' },
      { title: 'Пользовательское соглашение', route: '/terms-of-use' },
      { title: 'Туроператорам', route: '/for-tour-operators' },
      { title: 'Контакты', route: '/contacts' },
      { title: 'Оставить отзыв о сайте', route: '/review/new' }
    ]
  })
};
