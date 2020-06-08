<template>
  <div>
    <mmt-stepper></mmt-stepper>
    <mmt-tickets-list :ticket-items="ticketsList"/>
  </div>
</template>

<script>
// @ is an alias to /src
import { MmtStepper, MmtTicketsList } from '@components';

export default {
  components: {
    MmtStepper,
    MmtTicketsList
  },
  computed: {
    ticketsList () {
      return this.$store.getters['userTickets/tickets'];
    }
  },
  mounted () {
    this.$store.dispatch('userTickets/refreshTickets');
  }
};
</script>
