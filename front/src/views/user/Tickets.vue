<template>
  <div>
    <mmt-stepper></mmt-stepper>
    <mmt-tickets-list :ticket-items="tickets"/>
  </div>
</template>

<script>
// @ is an alias to /src
import { MmtStepper } from '@components';
import MmtTicketsList from '@components/mmt-tickets-list';

export default {
  components: {
    MmtStepper,
    MmtTicketsList
  },
  data () {
    return {
      tickets: [
        {
          id: 1,
          price: '1500$',
          adults: 1,
          children: 0,
          routes: [
            {
              id: 0,
              date: '04 мая, Пн',
              departureTime: '18:15',
              arrivalTime: '18:55',
              departureCode: 'KBP',
              arrivalCode: 'KRK',
              travelTime: '1 час 40 мин'
            },
            {
              id: 1,
              date: '09 мая, Сб',
              departureTime: '16:30',
              arrivalTime: '18:05',
              departureCode: 'KRK',
              arrivalCode: 'KBK',
              travelTime: '1 час 35 мин'
            }
          ]
        },
        {
          id: 2,
          price: '1500$',
          adults: 1,
          children: 0,
          routes: [
            {
              id: 0,
              date: '04 мая, Пн',
              departureTime: '18:15',
              arrivalTime: '18:55',
              departureCode: 'KBP',
              arrivalCode: 'KRK',
              travelTime: '1 час 40 мин'
            },
            {
              id: 1,
              date: '09 мая, Сб',
              departureTime: '16:30',
              arrivalTime: '18:05',
              departureCode: 'KRK',
              arrivalCode: 'KBK',
              travelTime: '1 час 35 мин'
            }
          ]
        },
        {
          id: 3,
          price: '1500$',
          adults: 1,
          children: 0,
          routes: [
            {
              id: 0,
              date: '04 мая, Пн',
              departureTime: '18:15',
              arrivalTime: '18:55',
              departureCode: 'KBP',
              arrivalCode: 'KRK',
              travelTime: '1 час 40 мин'
            },
            {
              id: 1,
              date: '09 мая, Сб',
              departureTime: '16:30',
              arrivalTime: '18:05',
              departureCode: 'KRK',
              arrivalCode: 'KBK',
              travelTime: '1 час 35 мин'
            }
          ]
        },
        {
          id: 4,
          price: '1500$',
          adults: 1,
          children: 0,
          routes: [
            {
              id: 0,
              date: '04 мая, Пн',
              departureTime: '18:15',
              arrivalTime: '18:55',
              departureCode: 'KBP',
              arrivalCode: 'KRK',
              travelTime: '1 час 40 мин'
            },
            {
              id: 1,
              date: '09 мая, Сб',
              departureTime: '16:30',
              arrivalTime: '18:05',
              departureCode: 'KRK',
              arrivalCode: 'KBK',
              travelTime: '1 час 35 мин'
            }
          ]
        },
        {
          id: 5,
          price: '1500$',
          adults: 1,
          children: 0,
          routes: [
            {
              id: 0,
              date: '04 мая, Пн',
              departureTime: '18:15',
              arrivalTime: '18:55',
              departureCode: 'KBP',
              arrivalCode: 'KRK',
              travelTime: '1 час 40 мин'
            },
            {
              id: 1,
              date: '09 мая, Сб',
              departureTime: '16:30',
              arrivalTime: '18:05',
              departureCode: 'KRK',
              arrivalCode: 'KBK',
              travelTime: '1 час 35 мин'
            }
          ]
        }
      ]
    };
  }
};
</script>
