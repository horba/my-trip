<template>
  <div class="cards-list">
    <mmt-ticket-item v-for="ticket in ticketItems" :key="ticket.id" :ticket-item="ticket"/>
  </div>
</template>

<script>
import MmtTicketItem from '@components/mmt-ticket-item.component';
export default {
  name: 'MmtTicketsList',
  components: {
    MmtTicketItem
  },
  props: {
    ticketItems: Array
  }
};

</script>

<style scoped>
  .cards-list
  {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    justify-content: flex-start;
    align-items: stretch;
    align-content: flex-start;
  }
</style>
