import {
  AccommodationSearch, EntertainmentsSearch,
  Entertainments, PlaceToEatSearch, Eating,
  AboutUs, PrivacyPolicy, CookiePolicy,
  TermsOfUse, ForTourOperators, Contacts,
  ReviewNew, MyTickets, MyAccommodation,
  ScheduleEntertainments, SignIn, SignUp,
  UserSettings, UserCabinet, MyHistoryTripList,
  MyHistoryTripRoute, RecoveryPassword,
  AddEditRouteForm, AddTripForm,
  AccommodationEditor, ScheduleEatingPlace
} from '@views';

import Vue from 'vue';
import VueRouter from 'vue-router';
import store from '@store';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    redirect: '/accommodation'
  },
  {
    path: '/accommodation',
    name: 'Accommodation',
    component: AccommodationSearch
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
    path: '/entertainments',
    name: 'EntertainmentsSearch',
    component: EntertainmentsSearch
  },
  {
    path: '/eating',
    name: 'eating',
    component: PlaceToEatSearch
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
    meta: { layout: 'authorize' },
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
        path: 'eating',
        name: 'ScheduleEatingPlace',
        component: Eating,
        meta: { layout: 'authorize' }
      },
      {
        path: 'eating/new',
        name: 'ScheduleEatingPlaceNew',
        component: ScheduleEatingPlace,
        meta: { layout: 'authorize' }
      },
      {
        path: 'eating/:id',
        name: 'EditScheduleEatingPlace',
        component: ScheduleEatingPlace,
        meta: { layout: 'authorize' }
      },
      {
        path: 'accommodation/new',
        name: 'AddAccommodation',
        component: AccommodationEditor,
        meta: { layout: 'authorize' }
      },
      {
        path: 'accommodation/:id',
        name: 'ManageAccommodation',
        component: AccommodationEditor,
        meta: { layout: 'authorize' }
      },
      {
        path: 'entertainments',
        name: 'Entertainments',
        component: Entertainments,
        meta: { layout: 'authorize' }
      },
      {
        path: 'entertainments/schedule/:id?',
        name: 'EntertainmentsNew',
        component: ScheduleEntertainments,
        meta: { layout: 'authorize' }
      },
      {
        path: 'travel-route',
        name: 'MyTravelRoute',
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
