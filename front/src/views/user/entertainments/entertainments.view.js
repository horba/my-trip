import { MmtStepper } from '@components';
import { gmapApi } from 'vue2-google-maps';

/* eslint-disable */
export default {
  components: {
    MmtStepper
  },
  computed: {
    google: gmapApi
  },
  data () {
    return {
      places: [
        {
          photo: 'photo',
          title: 'Title1',
          rating: '5,0',
          placeGraph: 'График работы',
          placeState: 'Открыто',
          description: 'Слово'
        },
        {
          photo: 'photo',
          title: 'Title2',
          rating: '5,0',
          placeGraph: 'График работы',
          placeState: 'Открыто',
          description: 'Слово'
        },
        {
          photo: 'photo',
          title: 'Title3',
          rating: '5,0',
          placeGraph: 'График работы',
          placeState: 'Открыто',
          description: 'Слово'
        },
        {
          photo: 'photo',
          title: 'Title4',
          rating: '5,0',
          placeGraph: 'График работы',
          placeState: 'Открыто',
          description: 'Слово'
        }
      ],
      mapCenter: { 
        lat: 48.459322,
        lng: 35.052729
      },
      markers: []
    };
  },
  mounted () {
    this.geolocate();
  },
  methods: {
    geolocate () {
      navigator.geolocation.getCurrentPosition(position => {
        const pos = { lat: position.coords.latitude, lng: position.coords.longitude };
        this.mapCenter = pos;
        this.$refs.mapRef.$mapPromise.then((map) => {
          map.setCenter(pos);
        });
        this.gmapNearbySearch();
      });
    },
    getPlacesFromBounds () {
      const request = {
        location: this.mapCenter,
        radius: 1000,
        keyword: ['restaurant', 'bar', 'kebab', 'bakery', 'meal_takeaway']
      };
      this.gmapNearbySearch(request, true);
    },
    gmapNearbySearch (req, setCenter) {
      let service;
      const request = {
        types:  [ 'restaurant' ],
        location: this.mapCenter,
        radius: 1000
      };
      setCenter = true;
      this.$refs.mapRef.$mapPromise.then((map) => {
        service = new this.google.maps.places.PlacesService(map);
        service.nearbySearch(request,(results, status) => {
          if (status === this.google.maps.places.PlacesServiceStatus.OK) {
            results.forEach(el => {
              this.markers.push({
                position: {
                  lat: el.geometry.location.lat(),
                  lng: el.geometry.location.lng()
                }
              });
            });
            if (setCenter) {
              map.setCenter(results[0].geometry.location);
            }
          }
        });
      });
    }
  }
};
