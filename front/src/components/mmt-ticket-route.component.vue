<template>
  <div class="route">
    <label class="routeDate text-body-regular">{{ routeItem.date }}</label>
    <br/>
    <div class="h-centered route-line">
      <label class="departureTime text-small text-semi-bold">{{ routeItem.departureTime }}</label>
      <span class="line"/>
      <label class="arrivalTime text-small text-semi-bold">{{ routeItem.arrivalTime }}</label>
    </div>
    <br/>
    <div class="h-centered route-line not-accented">
      <label class="departureCode text-small">{{ routeItem.departureCode }}</label>
      <span class="travel-time" >
        <label class="text-small">{{ $t('tickets.ticketItem.travelTimeLabel') }}</label>
        <br/>
        <label class="text-small">
          {{ $t('tickets.ticketItem.travelTime', routeItem) }}
        </label>
      </span>
      <label class="arrivalCode text-small">{{ routeItem.arrivalCode }}</label>
    </div>
  </div>
</template>

<script>
export default {
  name: 'mmt-ticket-route',
  props: {
    routeItem: Object
  }
};
</script>

<style scoped>
  .route {
    margin-top: 4px;
    margin-left: 12px;
    margin-right: 12px;
    height: 72px;
    position: relative;
  }
  .routeDate {
    float: right;
  }
  .arrivalTime, .arrivalCode {
    float: right;
  }
  .h-centered {
    position: absolute;
    left: 50%;
    margin-right: -50%;
    transform: translate(-50%, -50%)
  }
  .route-line {
    display: flex;
    align-items: center;
    margin-top: 12px;
  }
  .line {
    height: 1px;
    margin: 8px;
    padding: 0;
    width: 100px;
    border-top: 1px solid var(--mmt-color-light-gray);
  }
  .travel-time {
    text-align: center;
    width: 100px;
    margin-right: 8px;
    margin-left: 8px;
  }
</style>
