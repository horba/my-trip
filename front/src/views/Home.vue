<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png">
    <hello-world msg="We are happy to see you! :)"/>
    <hello-world-one-file
      msg="Welcome to Your Vue.js App from HelloWorld one file component (OFC)"
    ></hello-world-one-file>
  </div>
</template>

<script>
// @ is an alias to /src
import { HelloWorld, HelloWorldOneFile } from '@components';

export default {
  name: 'Home',
  components: {
    HelloWorld,
    HelloWorldOneFile
  }
};
</script>
