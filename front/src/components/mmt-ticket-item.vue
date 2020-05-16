<template>
  <v-card class="ticket">
    <mmt-ticket-route v-for="route in ticketItem.routes" :key="route.id" :route-item="route"/>
    <div class="line"/>
    <div class="footer">
      <div class="price">
        <div class="text-small">{{ ticketItem.price }}</div>
        <div class="text-small not-accented" >Цена за {{ ticketItem.adults }} взрослого</div>
      </div>
      <v-btn rounded class="details accent lighten-1">Подробнее</v-btn>
    </div>
  </v-card>
</template>

<script>
import MmtTicketRoute from '@components/mmt-ticket-route';
export default {
  name: 'MmtTicketItem',
  components: { MmtTicketRoute },
  props: {
    ticketItem: Object
  }
};
</script>

<style scoped>
  .ticket {
    width: 350px;
    height: 250px;
    margin-top: 20px;
    margin-right: 23px;
    padding-top: 8px;
  }
  .line {
    margin-top: 16px;
    border: 1px solid var(--mmt-color-light-gray)
  }
  .footer {
    display: flex;
    align-items: center;
    justify-content: space-between;
    height: 72px;
  }
  .price {
    margin-left: 72px;
  }
  .details {
    margin-right: 16px;
  }
</style>
