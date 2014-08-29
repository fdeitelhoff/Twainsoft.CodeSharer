using System;
using System.Collections.Generic;

namespace Twainsoft.CodeSharer.GitHub.Model.Authorization
{
    public class AuthorizationResponse
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<string> Scopes { get; set; }
        public string Token { get; set; }
        public string Note { get; set; }
        public string NoteUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
