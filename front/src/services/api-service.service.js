import instance from './api-http-interceptor.service';

const api = {
  get (path) {
    return instance({
      url: path,
      method: 'GET'
    });
  },
  post (path, data) {
    return instance({
      url: path,
      method: 'POST',
      data: data
    });
  },
  put (path, data) {
    return instance({
      url: path,
      method: 'PUT',
      data: data
    });
  },
  delete (path, data) {
    return instance({
      url: path,
      method: 'DELETE',
      data: data
    });
  }
};

export default api;
