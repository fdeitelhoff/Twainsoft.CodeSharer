using System.Collections.Generic;

namespace Twainsoft.CodeSharer.GitHub.Model.Authorization
{
    public class AuthorizationInput
    {
        public List<string> Scopes { get; set; }
        public string Note { get; set; }
        public string NoteUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
