import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '@views/Home.vue';
import LoginCard from '@components/LoginCard.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/login',
    name: 'Login',
    component: LoginCard,
    meta: {
      allowUnknownUsers: true, // default is true
      allowLoggedUsers: false // default is true
    }
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
