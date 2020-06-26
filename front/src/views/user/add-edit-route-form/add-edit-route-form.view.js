import { MmtTextInput } from '@components';
import { requiredValidationMixin } from '@mixins';
import { mapGetters } from 'vuex';
import { baseUrl, waypointFilesSuffix } from '@config';
import dateLocalizer from '@services/date-localizer';
const { MAX_WAYPOINT_SIZE_MB, MAX_WAYPOINT_FILE_COUNT } = require('@constants'),
      MAX_WAYPOINT_SIZE_KB = 1024 * 1024 * MAX_WAYPOINT_SIZE_MB;

export default {
  props: ['id', 'waypointId'],
  mixins: [
    requiredValidationMixin
  ],
  components: {
    MmtTextInput
  },
  data () {
    return {
      newWaypointValues: {
        departureDate: this.$options.filters.date(new Date(), 'yyyy-MM-dd'),
        arrivalDate: this.$options.filters.date(new Date(), 'yyyy-MM-dd'),
        departureTime: this.$options.filters.date(new Date(), 'HH:mm'),
        arrivalTime: this.$options.filters.date(new Date(), 'HH:mm'),
        transport: 0
      },
      calendarLocale: {
        'header-date-format': dt => this.$options.filters.date(dt, 'LLL yyyy'),
        'month-format': dt => this.$options.filters.date(dt, 'LLL'),
        'title-date-format': dt => this.$options.filters.date(dt, 'iiiiii LLL dd'),
        'weekday-format': dt => this.$options.filters.date(dt, 'EEEEEE')
      },
      formValidity: false,
      baseUrl,
      waypointFilesSuffix,
      MAX_WAYPOINT_FILE_COUNT,
      MAX_WAYPOINT_SIZE_MB,
      fileSizeError: false,
      tempFiles: [],
      sendBtnDisable: false
    };
  },
  computed: {
    ...mapGetters('dictionaries', [ 'transportTypes' ]),
    files () {
      const targetWaypoint = this.$store.state.waypoints.waypoints
        .find(waypoint => waypoint.id === +this.waypointId);
      return targetWaypoint ? targetWaypoint.files : [];
    },
    isEditForm () {
      return this.$route.name === 'MyHistoryEditRoute';
    }
  },
  methods: {
    onTempFilePicked (file) {
      if (file) {
        if (file.size < MAX_WAYPOINT_SIZE_KB) {
          this.tempFiles.push(file);
        } else {
          this.fileSizeError = true;
        }
      }
    },
    onFilePicked (file) {
      if (file) {
        if (file.size < MAX_WAYPOINT_SIZE_KB) {
          const formData = new FormData();
          formData.append('file', file);

          this.$store.dispatch('waypoints/addFile', [formData, file.name, +this.waypointId]);
        } else {
          this.fileSizeError = true;
        }
      }
    },
    onPickFile () {
      this.$refs.fileInput.click();
    },
    deleteFile (fileName) {
      this.$store.dispatch('waypoints/deleteFile', [fileName, +this.waypointId]);
    },
    createWaypoint () {
      this.$refs.form.validate();
      if (!this.formValidity) {
        return;
      }
      this.sendBtnDisable = true;
      const { departureTime, arrivalTime, ...rest } = this.newWaypointValues;
      this.$store.dispatch(
        this.isEditForm ? 'waypoints/updateWaypoint' : 'waypoints/insertWaypoint', {
          ...rest,
          departureDate: dateLocalizer.toUtc(
            `${this.newWaypointValues.departureDate}T${this.newWaypointValues.departureTime}`),
          arrivalDate: dateLocalizer.toUtc(
            `${this.newWaypointValues.arrivalDate}T${this.newWaypointValues.arrivalTime}`),
          pathLength: +this.newWaypointValues.pathLength,
          tripId: +this.id,
          newId: +this.waypointId || 0
        })
        .then((r) => {
          if (this.tempFiles.length === 0 || this.isEditForm) {
            return Promise.resolve();
          }
          const formData = new FormData();
          this.tempFiles.forEach(file => {
            formData.append('files', file);
          });

          return this.$store.dispatch('waypoints/sendMultipleFiles', [formData, r.data]);
        })
        .then(() => this.$store.dispatch('waypoints/loadWaypoints', [+this.id, true]))
        .then(() => this.$router.push({ name: 'MyHistoryFututeRoute' }));
    }
  },
  created () {
    if (this.isEditForm) {
      this.$store.dispatch('waypoints/loadWaypoints', [ +this.id ])
        .then(() => {
          const waypoints = this.$store.state.waypoints.waypoints,
                currentWaypoint = waypoints.find(waypoint => waypoint.id === +this.waypointId),
                nextWaypoint
                 = waypoints[waypoints.findIndex(waypoint => waypoint === currentWaypoint) + 1];

          this.newWaypointValues.departureCity = currentWaypoint.city;
          this.newWaypointValues.departureDate
          = this.$options.filters.date(currentWaypoint.departureDate, 'yyyy-MM-dd');
          this.newWaypointValues.departureTime
          = this.$options.filters.date(currentWaypoint.departureDate, 'HH:mm');

          this.newWaypointValues.arrivalCity = nextWaypoint.city;
          this.newWaypointValues.arrivalDate
          = this.$options.filters.date(currentWaypoint.arrivalDate, 'yyyy-MM-dd');
          this.newWaypointValues.arrivalTime
          = this.$options.filters.date(currentWaypoint.arrivalDate, 'HH:mm');

          this.newWaypointValues.pathLength = currentWaypoint.pathLength;
          this.newWaypointValues.pathTime
          = `${currentWaypoint.pathTime.hours}:${currentWaypoint.pathTime.minutes}`;
          this.newWaypointValues.details = currentWaypoint.details;
          this.newWaypointValues.transport = currentWaypoint.transport;

          this.$forceUpdate();
        });
    }
  }
};
