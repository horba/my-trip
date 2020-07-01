import { format, parse } from 'date-fns';
import MmtTextInput from '@/components/controls/mmt-text-input/mmt-text-input.component.vue';

const DEFAULT_DATE = '',
      DEFAULT_TIME = '00:00:00',
      DEFAULT_DATE_FORMAT = 'yyyy-MM-dd',
      DEFAULT_TIME_FORMAT = 'HH:mm:ss',
      DEFAULT_DIALOG_WIDTH = 340,
      DEFAULT_CLEAR_TEXT = 'CLEAR',
      DEFAULT_OK_TEXT = 'OK';

export default {
  name: 'mmt-datetime-picker',
  components: {
    MmtTextInput
  },
  model: {
    prop: 'datetime',
    event: 'input'
  },
  props: {
    datetime: {
      type: [Date, String],
      default: null
    },
    label: {
      type: String,
      default: ''
    },
    rules: {
      type: Array,
      default: []
    },
    dialogWidth: {
      type: Number,
      default: DEFAULT_DIALOG_WIDTH
    },
    dateFormat: {
      type: String,
      default: DEFAULT_DATE_FORMAT
    },
    timeFormat: {
      type: String,
      default: 'HH:mm'
    },
    clearText: {
      type: String,
      default: DEFAULT_CLEAR_TEXT
    },
    okText: {
      type: String,
      default: DEFAULT_OK_TEXT
    },
    textFieldProps: {
      type: Object
    },
    datePickerProps: {
      type: Object
    },
    timePickerProps: {
      type: Object
    }
  },
  data () {
    return {
      display: false,
      activeTab: 0,
      date: DEFAULT_DATE,
      time: DEFAULT_TIME
    };
  },
  mounted () {
    this.init();
  },
  computed: {
    dateTimeFormat () {
      return this.dateFormat + ' ' + this.timeFormat;
    },
    defaultDateTimeFormat () {
      return DEFAULT_DATE_FORMAT + ' ' + DEFAULT_TIME_FORMAT;
    },
    formattedDatetime () {
      return this.selectedDatetime
        ? this.$options.filters.date(this.selectedDatetime, this.dateTimeFormat)
        : '';
    },
    selectedDatetime () {
      if (this.date && this.time) {
        let datetimeString = this.date + ' ' + this.time;
        if (this.time.length === 5) {
          datetimeString += ':00';
        }
        return parse(datetimeString, this.defaultDateTimeFormat, new Date());
      } else {
        return null;
      }
    },
    dateSelected () {
      return !this.date;
    },
    language () {
      return this.$store.state.locale.language;
    }
  },
  methods: {
    init () {
      if (!this.datetime) {
        return;
      }

      let initDateTime;
      if (this.datetime instanceof Date) {
        initDateTime = this.datetime;
      } else if (typeof this.datetime === 'string' || this.datetime instanceof String) {
        const rawDateStr = this.datetime.replace('T', ' ').split('.')[0];
        initDateTime = parse(rawDateStr,
          DEFAULT_DATE_FORMAT + ' ' + DEFAULT_TIME_FORMAT,
          new Date());
      }
      this.date = format(initDateTime, DEFAULT_DATE_FORMAT);
      this.time = format(initDateTime, DEFAULT_TIME_FORMAT);
    },
    select () {
      this.resetPicker();
      const datetimeString = this.date + ' ' + this.time,
            formatedDate = format(new Date(datetimeString),
              DEFAULT_DATE_FORMAT + ' ' + DEFAULT_TIME_FORMAT)
              .replace(' ', 'T');
      this.$emit('input', formatedDate);
    },
    clear () {
      this.resetPicker();
      this.date = DEFAULT_DATE;
      this.time = DEFAULT_TIME;
      this.$emit('input', null);
    },
    resetPicker () {
      this.display = false;
      this.activeTab = 0;
      if (this.$refs.timer) {
        this.$refs.timer.selectingHour = true;
      }
    },
    showTimePicker () {
      this.activeTab = 1;
    }
  },
  watch: {
    datetime: function () {
      this.init();
    }
  }
};
