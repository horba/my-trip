<template>
  <v-content>
    <slot />
  </v-content>
</template>

<script>
export default {
  mounted () {
    if (!this.$store.getters.isLoggedIn) {
      this.$router.push('/');
    }
    this.$store.dispatch('userSettings/loadUserSettings');
  }
};
</script>
