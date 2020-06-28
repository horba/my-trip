using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAPI.Services
{
  public interface IGooglePlacePhotoService
  {
    Task<string> GetPlaceImage(string placeName);
  }

  public class GooglePlacePhotoService : IGooglePlacePhotoService
  {
    private async Task<string> GetPhotoReference(string placeName)
    {
      var client = new HttpClient();
      var request = new HttpRequestMessage(HttpMethod.Get, $"https://maps.googleapis.com/maps/api/place/findplacefromtext/json?key={Environment.GetEnvironmentVariable("MY_TRIP_GOOGLE_API_KEY")}&input={placeName}&inputtype=textquery&fields=photo");

      var response = await client.SendAsync(request);
      string responseBody = await response.Content.ReadAsStringAsync();

      try
      {
        return JsonDocument.Parse(responseBody).RootElement.GetProperty("candidates")[0].GetProperty("photos")[0]
          .GetProperty("photo_reference").GetString();
      }
      catch
      {
        return null;
      }

    }

    private async Task<string> GetImageUrl(string photoReference)
    {
      var client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false });
      var request = new HttpRequestMessage(HttpMethod.Get, $"https://maps.googleapis.com/maps/api/place/photo?key={Environment.GetEnvironmentVariable("MY_TRIP_GOOGLE_API_KEY")}&photoreference={photoReference}&maxheight={500}");

      var response = await client.SendAsync(request);
      return response.Headers?.Location.ToString();
    }

    public async Task<string> GetPlaceImage(string placeName)
    {
      var photoRef = await GetPhotoReference(placeName);
      return photoRef == null ? "https://cdn.vuetifyjs.com/images/cards/plane.jpg" : await GetImageUrl(photoRef);
    }
  }
}
