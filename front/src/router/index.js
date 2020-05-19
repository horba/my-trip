import Vue from 'vue';
import VueRouter from 'vue-router';
import {
  Home, Accommodation, Transport,
  Leisure, Food, HotTours,
  Articles, AboutUs, PrivacyPolicy,
  CookiePolicy, TermsOfUse, ForTourOperators,
  Contacts, ReviewNew, MyTickets,
  MyAccommodation, MyFood, MyTransport,
  MyLeisure, SignIn, SignUp,
  UserSettings
} from '@views';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/signup',
    name: 'SignUp',
    component: SignUp
  },
  {
    path: '/settings',
    name: 'Settings',
    component: UserSettings,
    meta: {
      allowUnknownUsers: false
    }
  },
  {
    path: '/login',
    name: 'Login',
    component: SignIn,
    meta: {
      allowUnknownUsers: true, // default is true
      allowLoggedUsers: false // default is true
    }
  },
  {
    path: '/accommodation',
    name: 'Accommodation',
    component: Accommodation
  },
  {
    path: '/transport',
    name: 'Transport',
    component: Transport
  },
  {
    path: '/leisure',
    name: 'Leisure',
    component: Leisure
  },
  {
    path: '/food',
    name: 'Food',
    component: Food
  },
  {
    path: '/hot-tours',
    name: 'HotTours',
    component: HotTours
  },
  {
    path: '/articles',
    name: 'Articles',
    component: Articles
  },
  {
    path: '/about-us',
    name: 'AboutUs',
    component: AboutUs
  },
  {
    path: '/privacy-policy',
    name: 'PrivacyPolicy',
    component: PrivacyPolicy
  },
  {
    path: '/cookie-policy',
    name: 'CookiePolicy',
    component: CookiePolicy
  },
  {
    path: '/terms-of-use',
    name: 'TermsOfUse',
    component: TermsOfUse
  },
  {
    path: '/for-tour-operators',
    name: 'ForTourOperators',
    component: ForTourOperators
  },
  {
    path: '/contacts',
    name: 'Contacts',
    component: Contacts
  },
  {
    path: '/review/new',
    name: 'ReviewNew',
    component: ReviewNew
  },
  {
    path: '/my',
    name: 'My',
    component: MyTickets,
    children: [
      {
        path: 'tickets',
        name: 'MyTickets',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'accommodation',
        name: 'MyAccommodation',
        component: MyAccommodation,
        meta: { layout: 'authorize' }
      },
      {
        path: 'food',
        name: 'MyFood',
        component: MyFood,
        meta: { layout: 'authorize' }
      },
      {
        path: 'transport',
        name: 'MyTransport',
        component: MyTransport,
        meta: { layout: 'authorize' }
      },
      {
        path: 'leisure',
        name: 'MyLeisure',
        component: MyLeisure,
        meta: { layout: 'authorize' }
      },
      {
        path: 'travel-route',
        name: 'MyTravelRoute',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'bookmarks',
        name: 'MyBookmarks',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'scheduler',
        name: 'MyScheduler',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'history',
        name: 'MyHistory',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'history/prev',
        name: 'MyHistoryPrev',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'history/next',
        name: 'MyHistoryNext',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'settings',
        name: 'MySettings',
        component: MyTickets,
        meta: { layout: 'authorize' }
      },
      {
        path: 'notifications',
        name: 'MyNotifications',
        component: MyTickets,
        meta: { layout: 'authorize' }
      }
    ]
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

router.beforeEach((to, from, next) => { // Auth Guards
  const isLoggedIn = localStorage.getItem('user');

  if (isLoggedIn
    && to.matched.some(record => record.meta.allowLoggedUsers == null
      || record.meta.allowLoggedUsers)) {
    next();
  } else if (!isLoggedIn
    && to.matched.some(record => record.meta.allowUnknownUsers == null
      || record.meta.allowUnknownUsers)) {
    next();
  } else {
    next('/');
  }
});

export default router;
