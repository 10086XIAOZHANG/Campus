using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://localhost:14259/";
            var client = new HttpClient();
            var dict = new SortedDictionary<string, string>();
            dict.Add("client_id", "irving");
            dict.Add("client_secret", "123456");
            dict.Add("grant_type", "client_credentials");
            //var rst = await(@"http://" + Request.RequestUri.Authority + @"/token").PostUrlEncodedAsync(dict).ReceiveJson<Token>();
            // Console.WriteLine(_httpClient.PostAsync("/token", new FormUrlEncodedContent(parameters)).Result.Content.ReadAsStringAsync().Result);
            var rst = client.PostAsync(url + "token", new FormUrlEncodedContent(dict)).Result.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject<Token>(rst);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obj.AccessToken);
            rst = client.GetStringAsync(url + "api/values").Result;
            UserModel um = new UserModel();
            var o = JsonConvert.DeserializeObject<UserModel>(rst);
            Console.WriteLine(o.UserName);
            Console.ReadLine();
        }
        public class Token
        {
            [JsonProperty("Access_Token")]
            public string AccessToken { get; set; }
        }
    }
}
