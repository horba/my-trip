<template>
  <v-content>
    <v-container fluid primary lighten-5>
      <div class="d-flex flex-row align-stretch">
        <div class="align-self-start">
          <mmt-user-menu></mmt-user-menu>
        </div>
        <div class="align-self-stretch flex-grow-1 pa-5">
          <slot />
        </div>
      </div>
    </v-container>
  </v-content>
</template>

<script>
// @ is an alias to /src
import { MmtUserMenu } from '@components';

export default {
  components: {
    MmtUserMenu
  }
};
</script>
