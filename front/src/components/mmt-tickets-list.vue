<template>
  <div class="cards-list">
    <MmtTicketItem v-for="ticket in tickets" :key="ticket.id" ticket-item="ticket"/>
  </div>
</template>

<script>
import { MmtTicketItem } from '@components';
export default {
  name: 'MmtTicketsList',
  components: {
    MmtTicketItem
  },
  data () {
    return {
      tickets: [
        { id: 1 },
        { id: 2 },
        { id: 3 },
        { id: 4 },
        { id: 5 }
      ]
    };
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
