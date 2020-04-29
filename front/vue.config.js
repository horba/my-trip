var path = require('path');

module.exports = {
  chainWebpack: config => {
    config.resolve.alias
      .set('@components', path.resolve('src/components/'))
      .set('@views', path.resolve('src/views/'))
      .set('@router', path.resolve('src/router/'))
      .set('@store', path.resolve('src/store/'))
      .set('@styles', path.resolve('src/styles/'));
  },
};
