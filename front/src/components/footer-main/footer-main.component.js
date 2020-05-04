import { VFooter, VRow, VCol, VTextField, VBtn, VIcon } from 'vuetify/lib';

export default {
  name: 'footer-main',
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
      { title: 'Жилье', route: '/housing' },
      { title: 'Транспорт', route: '/transport' },
      { title: 'Досуг', route: 'tleisure' },
      { title: 'Еда', route: '/food' },
      { title: 'Горящие туры', route: '/tot-tours' },
      { title: 'Статьи', route: '/articles' }
    ],
    links2: [
      { title: 'Политика конфиденциальности', route: '/privacy-policy' },
      { title: 'Политика использования Cookie', route: '/cookie-policy' },
      { title: 'Пользовательское соглашение', route: '/terms-of-use' },
      { title: 'Туроператорам', route: '/for-tour-operators' },
      { title: 'Контакты', route: '/vontacts' },
      { title: 'Оставить отзыв о сайте', route: '/leave-review' }
    ]
  })
};
