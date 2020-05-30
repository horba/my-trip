export default {
  created () {
    this.$store.dispatch('loginWithGoogle', this.$route.query.code)
      .then(() => this.$router.replace('/'))
      .catch(() => this.$router.replace({ name: 'Login' }));
  }
};
