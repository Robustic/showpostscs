using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ShowPostsCs
{
    public class PostClass
    {
        public string Date { get; set; }
        public string Topic { get; set; }
        public string Type2 { get; set; }
        public string Title { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
    }

    public class RestSharpConnection
    {
        public static List<PostClass> PrintJSON()
        {
            var client = new RestClient("https://guarded-mountain-76807.herokuapp.com");
            var request = new RestRequest("api/posts", Method.GET);
            
            // Add HTTP headers
            request.AddHeader("User-Agent", "Nothing");          

            // Execute the request and automatically deserialize the result.
            var posts = client.Execute<List<PostClass>>(request);

            return posts.Data;
        }
    }
}
