using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
namespace WenMax.Security.AuthServer
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client {
                    ClientId ="ajoseph",
                    AllowedGrantTypes =GrantTypes.ClientCredentials,
                    ClientSecrets = {new Secret("password123".Sha256()) },
                    AllowedScopes = { "api1","api2" }
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource> { new ApiResource("api1","My API") };
        }
    }
}
