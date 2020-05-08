<template>
  <v-card class="auth-card">
    <v-card-title class="auth-card-title">
      <div>
        Добро пожаловать!
      </div>
    </v-card-title>
    <v-card-text>
      <v-form style="width: 248px;" class="mx-auto">
        <div class="input-group">
          <label
            for="email-input"
            :class="{'label-error': isEmailEmpty || serverError}"
          >E-mail</label>
          <v-text-field
            id="email-input"
            class="input"
            rounded
            filled
            single-line
            dense
            placeholder="Введите Ваш e-mail"
            @input="isEmailEmpty = false; serverError = '';"
            :error-messages="isEmailEmpty ? 'E-mail не должен быть пустым' : ''"
            v-model="email"
          />
        </div>
        <div class="input-group">
          <label
            for="password-input"
            :class="{'label-error': isPasswordEmpty || serverError}"
          >Password</label>
          <label for="password-input"/>
          <v-text-field
            id="password-input"
            class="input"
            rounded
            filled
            single-line
            dense
            placeholder="Введите Ваш пароль"
            type="password"
            @input="isPasswordEmpty = false; serverError = '';"
            :error-messages="serverError ? serverError :
              isPasswordEmpty ? 'Пароль не должен быть пустым' : ''"
            v-model="password"
          />
        </div>
        <v-btn
          class="continue-button"
          rounded
          depressed
          large
          @click="login"
        >Продолжить</v-btn>
        <div class="forget-password">Забыли пароль?</div>
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
      isEmailEmpty: false,
      isPasswordEmpty: false,
      serverError: ''
    };
  },
  methods: {
    login () {
      if (!this.validateFields()) {
        return;
      }
      this.$store.dispatch('login', {
        email: this.email,
        password: this.password
      })
        .then(() => {
          this.$router.push('/');
        }).catch((error) => {
          this.serverError = error.response.data || 'Invalid password';
        });
    },
    validateFields () {
      this.isEmailEmpty = !this.email;
      this.isPasswordEmpty = !this.password;
      return !this.isPasswordEmpty && !this.isEmailEmpty;
    }
  }
};
</script>

<style scoped src="@styles/common.css" />
