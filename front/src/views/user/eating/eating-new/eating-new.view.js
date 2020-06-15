import { MmtTextInput } from '@/components';
import {
  VCol,
  VRow,
  VBtn,
  VIcon,
  VTextField,
  VMenu,
  VDatePicker,
  VTimePicker,
  VForm
} from 'vuetify/lib';

import { gmapApi } from 'vue2-google-maps';
export default {
  components: {
    VCol,
    VRow,
    VBtn,
    VIcon,
    VTextField,
    VMenu,
    VDatePicker,
    MmtTextInput,
    VTimePicker,
    VForm
  },
  data () {
    return {
      date: new Date().toISOString().substr(0, 10),
      dateFormatted: this.formatDate(new Date().toISOString().substr(0, 10)),
      menuDatePicker: false,
      time: '12:00',
      menuTimePicker: false
    };
  },
  computed: {
    google: gmapApi,
    computedDateFormatted () {
      return this.formatDate(this.date);
    }
  },

  watch: {
    date (val) {
      this.dateFormatted = this.formatDate(this.date);
    }
  },

  methods: {
    formatDate (date) {
      if (!date) {
        return null;
      }

      const [year, month, day] = date.split('-');
      return `${month}/${day}/${year}`;
    },
    parseDate (date) {
      if (!date) {
        return null;
      }

      const [month, day, year] = date.split('/');
      return `${year}-${month.padStart(2, '0')}-${day.padStart(2, '0')}`;
    }
  }
};
