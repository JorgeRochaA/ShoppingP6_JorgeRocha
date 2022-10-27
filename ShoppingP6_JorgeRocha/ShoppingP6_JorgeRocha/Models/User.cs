using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingP6_JorgeRocha.Models
{
    public class User
    {
        public RestRequest request { get; set; }

        const string mimeType = "application/json";
        const string contentType = "Content-Type";

        public User()
        {
           // Invoices = new HashSet<Invoice>();
           // UserStores = new HashSet<UserStore>();
        }

        public int Iduser { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string BackUpEmail { get; set; } = null!;
        public string SecurityCode { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public bool? Active { get; set; }
        public int IduserRole { get; set; }
        public int Idcountry { get; set; }

        public virtual Country? IdcountryNavigation { get; set; } = null!;

        public virtual UserRole? IduserRoleNavigation { get; set; } = null!;

        //public virtual ICollection<Invoice> Invoices { get; set; }
        //public virtual ICollection<UserStore> UserStores { get; set; }

        public async Task<bool> addUser()
        {
            try
            {
                string routeSufix = string.Format("Users");
                string finalUrl = Services.CnnToP6API.productionUrl + routeSufix;

                RestClient client = new RestClient(finalUrl);

                request = new RestRequest(finalUrl, Method.Post);

                request.AddHeader(Services.CnnToP6API.apiKeyName, Services.CnnToP6API.apiKeyValue);

                request.AddHeader(contentType, mimeType);

                string serializedClass = JsonConvert.SerializeObject(this);

                request.AddBody(serializedClass,mimeType);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.Created)
                {
                    return true;
                }
                else
                {
                    return false;
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
