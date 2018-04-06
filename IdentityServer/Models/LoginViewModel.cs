using System.Collections.Generic;
using System.Linq;
using IdentityServer4.Quickstart.UI;

namespace IdentityServer.Models
{
    public class LoginViewModel : LoginInputModel
    {
        public bool AllowRememberLogin { get; set; }

        public bool EnableLocalLogin { get; set; }
        
        public string ExternalLoginScheme { get; set; }

        public bool IsExternalLoginOnly { get; set; }
        
        public ExternalProvider[] ExternalProviders { get; set; }
    }
}
