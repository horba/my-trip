<template>
  <v-content>
    <header-main></header-main>
    <v-container fluid>
      <slot />
    </v-container>
    <footer-main></footer-main>
  </v-content>
</template>

<script>
// @ is an alias to /src
import { FooterMain, HeaderMain } from '@components';

export default {
  components: {
    FooterMain,
    HeaderMain
  }
};
</script>
