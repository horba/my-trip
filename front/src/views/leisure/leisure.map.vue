<template>
  <GoogleMapLoader
    :map-config="mapConfig"
    api-key="AIzaSyDuiiLqO-HTj8vP0POPrsBGJdWc7esHdOY"
  >
    // insert your google maps api key to render styled map
    <template slot-scope="{ google, map }">
      <GoogleMapMarker
        v-for="marker in markers"
        :key="marker.id"
        :marker="marker"
        :google="google"
        :map="map"
      />
      <GoogleMapLine
        v-for="line in lines"
        :key="line.id"
        :path.sync="line.path"
        :google="google"
        :map="map"
      />
    </template>
  </GoogleMapLoader>
</template>

<script>
import GoogleMapLoader from '@/components/google-map/GoogleMapLoader';
import GoogleMapMarker from '@/components/google-map/GoogleMapMarker';
import GoogleMapLine from '@/components/google-map/GoogleMapLine';

import { mapSettings } from '@/constants/mapSettings';

export default {
  components: {
    GoogleMapLoader,
    GoogleMapMarker,
    GoogleMapLine
  },
  data () {
    return {
      markers: [],
      lines: []
    };
  },
  computed: {
    mapConfig () {
      return {
        ...mapSettings,
        zoom: 13
      };
    }
  }
};
</script>
