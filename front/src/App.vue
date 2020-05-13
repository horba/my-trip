<template>
  <v-app id="app" light>
    <component :is="layout">
      <router-view/>
    </component>
  </v-app>
</template>

<script>
// @ is an alias to /src
import { VApp } from 'vuetify/lib';

const defaultLayout = 'default';

export default {
  name: 'App',
  components: {
    VApp
  },
  computed: {
    layout () {
      return (this.$route.meta.layout || defaultLayout) + '-layout';
    }
  }
};
</script>

<style src="@styles/variables.css"/>
