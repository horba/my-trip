import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '@views/Home.vue';
import Housing from '@views/Housing.vue';
import Transport from '@views/Transport.vue';
import Leisure from '@views/Leisure.vue';
import Food from '@views/Food.vue';
import HotTours from '@views/HotTours.vue';
import Articles from '@views/Articles.vue';
import MyTickets from '@views/user/Tickets.vue';
import MyHousing from '@views/user/Housing.vue';
import MyFood from '@views/user/Food.vue';
import MyTransport from '@views/user/Transport.vue';
import MyLeisure from '@views/user/Leisure.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/housing',
    name: 'Housing',
    component: Housing
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
    path: '/my/tickets',
    name: 'MyTickets',
    component: MyTickets,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/housing',
    name: 'MyHousing',
    component: MyHousing,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/food',
    name: 'MyFood',
    component: MyFood,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/transport',
    name: 'MyTransport',
    component: MyTransport,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/leisure',
    name: 'MyLeisure',
    component: MyLeisure,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/travel-route',
    name: 'MyTravelRoute',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/bookmarks',
    name: 'MyBookmarks',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/scheduler',
    name: 'MyScheduler',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/history',
    name: 'MyHistory',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/history-prev',
    name: 'MyHistory',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/history-next',
    name: 'MyHistory',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/settings',
    name: 'MySettings',
    component: Home,
    meta: { layout: 'authorize' }
  },
  {
    path: '/my/notifications',
    name: 'MyNotifications',
    component: Home,
    meta: { layout: 'authorize' }
  }
],

      router = new VueRouter({
        mode: 'history',
        base: process.env.BASE_URL,
        routes
      });

export default router;
