<template>
  <v-content>
    <mmt-header></mmt-header>
    <v-container fluid>
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
