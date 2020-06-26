import { zonedTimeToUtc, utcToZonedTime } from 'date-fns-tz';
const timeZone = Intl.DateTimeFormat().resolvedOptions().timeZone;

export default {
  toUtc (time) {
    return zonedTimeToUtc(time, timeZone);
  },
  toZonedTime (time) {
    return utcToZonedTime(time, timeZone);
  }
};
