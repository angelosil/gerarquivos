using System;
using Microsoft.AspNetCore.Http;

namespace gerArquivos
{
    public class OAuthAuthorizationServerOptions
    {
        public PathString TokenEndpointPath { get; set; }
        public PathString AuthorizeEndpointPath { get; set; }
        public object Provider { get; set; }
        public TimeSpan AccessTokenExpireTimeSpan { get; set; }
        public bool AllowInsecureHttp { get; set; }
    }
}