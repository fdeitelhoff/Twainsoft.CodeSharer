using System.Collections.Generic;
using RestSharp;
using Twainsoft.CodeSharer.GitHub.Model.Authorization;
using Twainsoft.CodeSharer.GitHub.Model.Gists;

namespace Twainsoft.CodeSharer.GitHub.Services
{
    public class GistsService
    {
        private string Username { get; set; }
        private string Password { get; set; }

        private string ClientId { get; set; }
        private string ClientSecret { get; set; }

        private string AppName { get; set; }

        private AuthorizationResponse AuthorizationResponse { get; set; }

        public GistsService(string username, string password, string clientId, string clientSecret)
        {
            Username = username;
            Password = password;

            ClientId = clientId;
            ClientSecret = clientSecret;

            AppName = "VS CodeSharer 0.1 beta";
        }

        public bool Authorize()
        {
            var client = new RestClient("https://api.github.com/")
                {
                    UserAgent = AppName,
                    Authenticator = new HttpBasicAuthenticator(Username, Password)
                };
            var request = new RestRequest("authorizations", Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            var input = new AuthorizationInput
                {
                    Scopes = new List<string> { "gist" },
                    Note = AppName,
                    NoteUrl = "https://vscodeshare.de",
                    ClientId = ClientId,
                    ClientSecret = ClientSecret
                };

            request.RequestFormat = DataFormat.Json;
            request.AddBody(input);
            var response = client.Execute<AuthorizationResponse>(request);

            AuthorizationResponse = response.Data;

            return AuthorizationResponse != null && !string.IsNullOrWhiteSpace(AuthorizationResponse.Token);
        }

        public List<Gist> Gists()
        {
            var client = new RestClient("https://api.github.com/")
            {
                UserAgent = AppName,
                Authenticator = new HttpBasicAuthenticator(Username, Password)
            };
            var request = new RestRequest(string.Format("users/{0}/gists", Username), Method.GET);
            request.AddHeader("token", AuthorizationResponse.Token);

            var response = client.Execute<List<Gist>>(request);

            return response.Data;
        }
    }
}
