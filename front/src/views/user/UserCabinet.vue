<template>
  <v-container fluid primary lighten-5>
    <div class="d-flex flex-row align-stretch">
      <div class="align-self-start">
        <mmt-user-menu></mmt-user-menu>
      </div>
      <div class="align-self-stretch flex-grow-1 pa-5">
        <router-view />
      </div>
    </div>
  </v-container>
</template>

<script>
import { MmtUserMenu } from '@components';
export default {
  components: {
    MmtUserMenu
  }
};
</script>
