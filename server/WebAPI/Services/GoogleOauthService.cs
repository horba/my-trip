using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAPI.DTO;
using System.Text.Json;

namespace WebAPI.Services
{
  public interface IGoogleOauthService
  {
    Task<KeyValuePair<string, string>> GetGoogleUserData(string bearer);
    Task<string> GetToken(string code);
  }

  public class GoogleOauthService : IGoogleOauthService
  {
    private readonly FrontConfiguration _configuration;

    public GoogleOauthService(FrontConfiguration configuration)
    {
      _configuration = configuration;
    }

    public async Task<string> GetToken(string code)
    {
      var client = new HttpClient();

      var formData = new List<KeyValuePair<string, string>>
      {
        new KeyValuePair<string, string>("client_id", Environment.GetEnvironmentVariable("MY_TRIP_GOOGLE_OAUTH_CLIENT_ID")),
        new KeyValuePair<string, string>("client_secret", Environment.GetEnvironmentVariable("MY_TRIP_GOOGLE_OAUTH_SECRET")),
        new KeyValuePair<string, string>("grant_type", "authorization_code"),
        new KeyValuePair<string, string>("redirect_uri", _configuration.AddressFront),
        new KeyValuePair<string, string>("code", code)
      };

      var request = new HttpRequestMessage(HttpMethod.Post, "https://oauth2.googleapis.com/token")
      { Content = new FormUrlEncodedContent(formData) };

      var response = await client.SendAsync(request);

      string responseBody = await response.Content.ReadAsStringAsync();

      try
      {
        return JsonDocument.Parse(responseBody).RootElement.GetProperty("access_token").GetString();
      }
      catch
      {
        return null;
      }
    }

    public async Task<KeyValuePair<string, string>> GetGoogleUserData(string bearer)
    {
      var client = new HttpClient();
      var request = new HttpRequestMessage(HttpMethod.Get, "https://www.googleapis.com/oauth2/v2/userinfo");
      request.Headers.Authorization = AuthenticationHeaderValue.Parse($"Bearer {bearer}");

      var response = await client.SendAsync(request);

      string responseBody = await response.Content.ReadAsStringAsync();

      try
      {
        return new KeyValuePair<string, string>(
          JsonDocument.Parse(responseBody).RootElement.GetProperty("email").GetString(),
          JsonDocument.Parse(responseBody).RootElement.GetProperty("id").GetString());
      }
      catch
      {
        return new KeyValuePair<string, string>();
      }
    }
  }
}
