<template>
  <v-card>
    <div>
      {{ ticketItem }}
      <!--      <mmt-ticket-route/>
      <mmt-ticket-route/>-->
      <hr/>
      <p>500$</p>
      <p>Цена за 1 взрослого</p>
      <v-btn>Подробнее</v-btn>
    </div>
  </v-card>
</template>

<script>
// import { MmtTicketRoute } from '@/components/index.js';
export default {
  name: 'MmtTicketItem',
  //  components: { MmtTicketRoute },
  props: [ 'ticketItem' ]
};
</script>

<style scoped>
  .v-card {
    width: 350px;
    height: 250px;
    margin-top: 20px;
    margin-right: 23px;
  }
</style>
