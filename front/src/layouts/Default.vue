<template>
  <v-content :class="($vuetify.breakpoint.mdAndUp) ? 'md' : ''">
    <mmt-header></mmt-header>
    <v-container fluid primary lighten-3 class="content-container">
      <slot />
    </v-container>
    <mmt-footer></mmt-footer>
  </v-content>
</template>

<script>
// @ is an alias to /src
import { MmtFooter, MmtHeader } from '@components';

export default {
  components: {
    MmtFooter,
    MmtHeader
  }
};
</script>
