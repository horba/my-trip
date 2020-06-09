<template>
  <v-content>
    <slot />
  </v-content>
</template>

<script>
export default {
  mounted () {
    if (!this.$store.getters['auth/isLoggedIn']) {
      this.$router.push('/');
    } else {
      this.$store.dispatch('userSettings/loadUserSettings');
    }
  }
};
</script>
