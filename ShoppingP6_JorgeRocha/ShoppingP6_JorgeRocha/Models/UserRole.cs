using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShoppingP6_JorgeRocha.Models
{
    public class UserRole
    {
        public RestRequest request { get; set; }

        const string mimeType = "application/json";
        const string contentType = "Content-Type";

        public UserRole()
        {
            //Users = new HashSet<User>();
        }

        public int IduserRole { get; set; }
        public string UserRoleDescription { get; set; } = null!;

        //public virtual ICollection<User> Users { get; set; }

        public async Task<List<UserRole>> getUserRoles()
        {
            try
            {
                string routeSufix = string.Format("UserRoles");
                string finalUrl  = Services.CnnToP6API.productionUrl + routeSufix;

                RestClient client = new RestClient(finalUrl);

                request  = new RestRequest(finalUrl,Method.Get);

                request.AddHeader(Services.CnnToP6API.apiKeyName,Services.CnnToP6API.apiKeyValue);

                request.AddHeader(contentType,mimeType);

                RestResponse response = await client.ExecuteAsync(request);

               HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (System.Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }
    }
}
