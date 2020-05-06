<template>
  <v-card class="mx-auto mt-10" width="560" height="623" color="blue lighten-5">
    <v-card-title class="justify-center headline pt-6">
      Добро пожаловать!
    </v-card-title>
    <v-spacer/>
    <v-card-text>
      <v-form style="width: 248px;" class="mx-auto" v-model="formValidity">
        <v-text-field
          rounded
          filled
          flat
          dense
          label="E-mail"
          placeholder="Введите Ваш e-mail"
          :rules="emailRules"
          @input="errorMessage = ''"
          v-model="email"
        />
        <v-text-field
          rounded
          filled
          flat
          dense
          label="Password"
          placeholder="Введите Ваш пароль"
          type="password"
          :rules="passwordRules"
          :error-messages="errorMessage"
          @input="errorMessage = ''"
          v-model="password"
        />
        <v-btn rounded
               depressed
               large
               class="mb-3"
               :disabled="!formValidity"
               @click="login"
        >Продолжить</v-btn>
        <v-btn text>Забыли пароль?</v-btn>
      </v-form>
    </v-card-text>
  </v-card>
</template>

<script>
export default {
  data () {
    return {
      email: '',
      password: '',
      emailRules: [
        value => !!value || 'Fill this field!'
      ],
      passwordRules: [
        value => !!value || 'Fill this field!'
      ],
      formValidity: false,
      errorMessage: ''
    };
  },
  methods: {
    login () {
      this.$store.dispatch('login', {
        email: this.email,
        password: this.password
      })
        .then(() => {
          this.$router.push('/');
        }).catch((error) => {
          this.errorMessage = error.response.data;
        });
    }
  }
};
</script>
