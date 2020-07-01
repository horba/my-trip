import GoogleMapsApiLoader from 'google-maps-api-loader';
import { mapSettings } from '@constants';

export const accommodationGoogleApiMixin = {
  data () {
    return {
      apiKey: process.env.VUE_APP_GOOGLE_MAP_API,
      google: null,
      map: null,
      placesService: null,
      placeAutocomplete: null,
      markers: [],
      libraries: [ 'places' ],
      placesTypes: [ 'lodging' ],
      autocompletePlacesTypes: [ '(cities)' ],
      mapSelector: null,
      autocompleteSelector: null,
      mapCenter: { lat: 48.459286, lng: 35.052698 },
      place: {
        results: [],
        selected: null
      }
    };
  },
  computed: {
    mapConfig () {
      return {
        ...mapSettings,
        zoom: 13
      };
    },
    selectedPlace () {
      return this.place.selected;
    }
  },
  methods: {
    nearbySearch (search, callback) {
      this.placesService.nearbySearch(search, (places, status) => {
        if (status === this.google.maps.places.PlacesServiceStatus.OK) {
          if (callback) {
            callback.call(this, places);
          } else {
            this.searchSuccessCallback(places);
          }
        }
      });
    },
    getPlaceDetails (placeId, query, callback) {
      if (!placeId) {
        this.findPlace(query, callback);
      } else {
        this.placesService.getDetails({ placeId: placeId },
          (place, status) => {
            if (status === this.google.maps.places.PlacesServiceStatus.OK) {
              if (callback) {
                callback.call(this, [ place ]);
              } else {
                this.searchSuccessCallback([ place ]);
              }
            } else {
              this.findPlace(query, callback);
            }
          });
      }
    },
    findPlace (query, callback) {
      const searchRequest = {
        query: query,
        fields: [
          'geometry',
          'name',
          'formatted_address',
          'rating'
        ]
      };

      this.placesService.findPlaceFromQuery(searchRequest, (places, status) => {
        if (status === this.google.maps.places.PlacesServiceStatus.OK) {
          if (callback) {
            callback.call(this, places);
          } else {
            this.searchSuccessCallback(places);
          }
        }
      });
    },
    searchSuccessCallback (places) {
      if (places && places[0].geometry) {
        this.place = {
          results: places,
          selected: places[0]
        };
        this.map.setCenter(this.place.selected.geometry.location);
        this.map.setZoom(16);
        this.refreshMapMarkers(places);
      }
    },
    initPlaceSuccessCallback (places) {
      if (places && places[0].geometry) {
        this.map.setCenter(places[0].geometry.location);
        this.map.setZoom(16);
        this.refreshMapMarkers(places);
      }
    },
    refreshMapMarkers (results) {
      this.markers.forEach((marker) => {
        if (marker) {
          marker.setMap(null);
        }
      });
      this.markers = [];

      results.forEach((place, i) => {
        this.markers[i] = new this.google.maps.Marker({
          map: this.map,
          position: place.geometry.location,
          animation: this.google.maps.Animation.DROP
        });
        this.markers[i].placeResult = place;
      });
    },
    placeChanged () {
      this.place = {
        results: []
      };
      const place = this.placeAutocomplete.getPlace();
      if (place.geometry) {
        this.map.panTo(place.geometry.location);
        this.nearbySearch({
          bounds: this.map.getBounds(),
          types: this.placesTypes
        });
      }
    },
    selectPlace (selectedPlace) {
      if (selectedPlace.place_id) {
        this.getPlaceDetails(selectedPlace.place_id, null, (places) => {
          this.place.selected = places[0];
          this.map.setCenter(this.place.selected.geometry.location);
          this.map.setZoom(15);
          this.refreshMapMarkers(places);
        });
      }
    },
    async initialize () {
      if (this.mapSelector && this.$refs[this.mapSelector]) {
        this.google = await GoogleMapsApiLoader({
          libraries: this.libraries,
          apiKey: this.apiKey
        });

        this.map = new this.google.maps.Map(this.$refs[this.mapSelector], this.mapConfig);
        navigator.geolocation.getCurrentPosition((position) => {
          if (position) {
            const pos = {
              lat: position.coords.latitude,
              lng: position.coords.longitude
            };
            this.mapCenter = pos;
            this.map.setCenter(this.mapCenter);
          } else {
            this.map.setCenter(this.mapCenter);
          }
        });

        this.placesService = new this.google.maps.places.PlacesService(this.map);

        if (this.autocompleteSelector) {
          this.placeAutocomplete = new this.google.maps.places.Autocomplete(
            document.getElementById(this.autocompleteSelector), {
              types: this.autocompletePlacesTypes
            });

          this.placeAutocomplete.addListener('place_changed', this.placeChanged);
        }
      }
    }
  },
  async mounted () {
    await this.initialize();
  }
};
