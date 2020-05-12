<template>
  <div>
    <mmt-stepper></mmt-stepper>
    <MmtTicketsList></MmtTicketsList>
  </div>
</template>

<script>
// @ is an alias to /src
import { MmtStepper, MmtTicketsList } from '@components';

export default {
  components: {
    MmtStepper,
    MmtTicketsList
  }
};
</script>
