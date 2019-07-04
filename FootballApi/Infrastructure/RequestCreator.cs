using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace FootballApi.Infrastructure
{
    public class RequestCreator
    {
        private readonly string _token = "63390b4579bf4a84b13e0c560880c1cc";
        private string urlToSend;
        private WebRequest request;

        private void setUpWebRequest(string targetUrl)
        {
            request = WebRequest.Create(targetUrl);
            request.Headers["X-Auth-Token"] = _token;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ContentType = "application/json;charset=UTF-8";
        }
        public async Task<string> CreateRequest(string targetUrl)
        {
            setUpWebRequest(targetUrl);
            string result = null;

            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse,
                           request.EndGetResponse, null)
                               .ContinueWith(task =>
                               {
                                   WebResponse response = task.Result;

                                   using (Stream dataStream = response.GetResponseStream())
                                   {

                                       StreamReader reader = new StreamReader(dataStream);
                                       result = reader.ReadToEnd();
                                   }
                                   
                               });
            return result;
        }
    }
}
