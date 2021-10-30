using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
         new Client[]
         {
            new Client
            {
                ClientId = "orderClient",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("{2757F911-4C83-4722-BB6E-5A030FFDEC2C}".Sha256())
                },
                AllowedScopes = { "orderApi" }
            },
            new Client
            {
                ClientId = "productClient",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("{2757F911-4C83-4722-BB6E-5A030FFDEC2C}".Sha256())
                },
                AllowedScopes = { "productApi" }
            },
            new Client
            {
                ClientId = "userClient",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("{2757F911-4C83-4722-BB6E-5A030FFDEC2C}".Sha256())
                },
                AllowedScopes = { "userApi" }
            }
         };

        public static IEnumerable<ApiScope> ApiScopes =>
         new ApiScope[]
         {
              new ApiScope("orderApi", "Order API"),
              new ApiScope("productApi", "Product API"),
              new ApiScope("userApi", "User API"),
         };

        public static IEnumerable<ApiResource> ApiResources =>
         new ApiResource[]
         {
         };

        public static IEnumerable<IdentityResource> IdentityResources =>
         new IdentityResource[]
         {
         };

        public static List<TestUser> TestUsers =>
         new List<TestUser>
         {
         };
    }
}
