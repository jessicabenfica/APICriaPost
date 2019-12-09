using RestSharp;
using jsonplaceholder.Bases;
using jsonplaceholder.Helpers;
using System.IO;
using System.Text;

namespace jsonplaceholder.Requests
{
    public class CriarPostRequest : RequestBase
    {
        public CriarPostRequest()
        {
            requestService = "/posts";
            method = Method.POST;
        }

        public void setJsonBody(string title, string body, string userId)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/CriarPostJson.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$title", title).Replace("$body", body).Replace("$userId", userId);                                                                                     

        }
    }
}
