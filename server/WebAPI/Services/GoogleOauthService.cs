using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Services
{
  public class GoogleOauthService
  {
    private readonly JSONExtractor _jsonExtractor;
    private readonly GooleOauthConfiguration _configuration;

    public GoogleOauthService(JSONExtractor jsonExtractor, GooleOauthConfiguration configuration)
    {
      _configuration = configuration;
      _jsonExtractor = jsonExtractor;
    }

    public async Task<string> GetToken(string code)
    {
      var client = new HttpClient();

      var formData = new List<KeyValuePair<string, string>>
      {
        new KeyValuePair<string, string>("client_id", _configuration.ClientId),
        new KeyValuePair<string, string>("client_secret", _configuration.ClientSecret),
        new KeyValuePair<string, string>("grant_type", "authorization_code"),
        new KeyValuePair<string, string>("redirect_uri", _configuration.RedirectUrl),
        new KeyValuePair<string, string>("code", code)
      };

      var request = new HttpRequestMessage(HttpMethod.Post, "https://oauth2.googleapis.com/token")
        { Content = new FormUrlEncodedContent(formData) };

      var response = await client.SendAsync(request);

      string responseBody = await response.Content.ReadAsStringAsync();

      return _jsonExtractor.GetValue("access_token", responseBody);
    }

    public async Task<string> GetEmail(string bearer)
    {
      var client = new HttpClient();
      var request = new HttpRequestMessage(HttpMethod.Get, "https://www.googleapis.com/oauth2/v2/userinfo");
      request.Headers.Authorization = AuthenticationHeaderValue.Parse($"Bearer {bearer}");

      var response = await client.SendAsync(request);

      string responseBody = await response.Content.ReadAsStringAsync();

      return _jsonExtractor.GetValue("email", responseBody);
    }
  }
}
