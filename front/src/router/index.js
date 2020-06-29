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
  UserSettings, UserCabinet, MyHistoryTripList,
  MyHistoryTripRoute, RecoveryPassword,
  AddEditRouteForm, AddTripForm
} from '@views';
import store from '@store';

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
    component: UserCabinet,
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
        component: MyHistoryTripList,
        meta: { layout: 'authorize' }
      },
      {
        path: 'history/future',
        name: 'MyHistoryNext',
        component: MyHistoryTripList,
        meta: { layout: 'authorize' }
      },
      {
        path: 'history/future/add',
        name: 'MyHistoryAdd',
        component: AddTripForm,
        meta: { layout: 'authorize' }
      },
      {
        path: 'history/future/:id/route',
        name: 'MyHistoryFututeRoute',
        component: MyHistoryTripRoute,
        meta: { layout: 'authorize' },
        props: true
      },
      {
        path: 'history/prev/:id/route',
        name: 'MyHistoryPrevRoute',
        component: MyHistoryTripRoute,
        meta: { layout: 'authorize' },
        props: true
      },
      {
        path: 'history/future/:id/route/add',
        name: 'MyHistoryAddRoute',
        component: AddEditRouteForm,
        meta: { layout: 'authorize' },
        props: true
      },
      {
        path: 'history/future/:id/route/:waypointId/edit',
        name: 'MyHistoryEditRoute',
        component: AddEditRouteForm,
        meta: { layout: 'authorize' },
        props: true
      },
      {
        path: 'settings',
        name: 'MySettings',
        component: UserSettings,
        meta: {
          layout: 'authorize',
          allowUnknownUsers: false
        }
      },
      {
        path: 'notifications',
        name: 'MyNotifications',
        component: MyTickets,
        meta: { layout: 'authorize' }
      }
    ]
  },
  {
    path: '/recovery-password/:token?',
    name: 'recovery-password',
    component: RecoveryPassword,
    meta: { layout: 'default' }
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

router.beforeEach((to, from, next) => { // Auth Guards
  if (to.query.state === 'google-oauth') {
    store.dispatch('auth/loginWithGoogle', to.query.code)
      .then(() => next('/'))
      .catch(() => next({ name: 'Login' }));
    return;
  }

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
