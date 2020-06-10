const {
  COLOR_LANDSCAPE,
  COLOR_BORDERS,
  COLOR_WATER,
  COLOR_LINE,
  COLOR_POINT_FILL,
  COLOR_SELECTED_POINT
} = require('@/config/config.map.color.json'),
      COLORS = {
        BORDERS: COLOR_BORDERS,
        LANDSCAPE: COLOR_LANDSCAPE,
        LINE: COLOR_LINE,
        POINT: COLOR_SELECTED_POINT,
        POINT_FILL: COLOR_POINT_FILL,
        WATER: COLOR_WATER
      },
      POINT_MARKER_ICON_CONFIG = {
        path: 'M 0, 0 m -5, 0 a 5,5 0 1,0 10,0 a 5,5 0 1,0 -10,0',
        strokeOpacity: 0.7,
        strokeWeight: 4,
        strokeColor: COLORS.POINT,
        fillColor: COLORS.POINT_FILL,
        fillOpacity: 0.7,
        scale: 1
      },
      LINE_SYMBOL_CONFIG = {
        path: 'M 0,-2 0,2',
        strokeOpacity: 1,
        strokeWeight: 2,
        scale: 1
      },
      LINE_PATH_CONFIG = {
        clickable: true,
        geodesic: true,
        strokeOpacity: 0,
        strokeColor: COLORS.LINE,
        icons: [
          {
            icon: LINE_SYMBOL_CONFIG,
            repeat: '10px'
          }
        ]
      },
      mapSettings = {
        clickableIcons: true,
        streetViewControl: true,
        panControlOptions: true,
        fullscreenControl: false,
        zoomControl: true,
        gestureHandling: 'cooperative',
        backgroundColor: COLORS.LANDSCAPE,
        mapTypeControl: false,
        zoomControlOptions: {
          style: 'SMALL'
        },
        zoom: 15,
        minZoom: 0,
        maxZoom: 20
      };

export { mapSettings, LINE_PATH_CONFIG, POINT_MARKER_ICON_CONFIG };
