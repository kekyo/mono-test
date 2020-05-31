using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWindowsForms.Models
{
    public static class Reddit
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<RedditPost[]> FetchNewPostsAsync(string name)
        {
            // Uses Reddit with Json API
            using (var response =
                await httpClient.
                    GetAsync($"https://www.reddit.com/{name}/new.json").ConfigureAwait(false))
            {
                using (var stream =
                    await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    var tr = new StreamReader(stream, Encoding.UTF8, true);
                    var jr = new JsonTextReader(tr);

                    var serializer = new JsonSerializer();

                    var root = serializer.Deserialize<JObject>(jr);

                    return root["data"]["children"].
                        Select(child => child["data"]).
                        Where(data =>
                            {
                                var ext = Path.GetExtension(((Uri)data["url"]).AbsolutePath);
                                switch (ext)
                                {
                                    case ".jpg": return true;
                                    case ".png": return true;
                                    default: return false;
                                }
                            }).
                        Select(data => new RedditPost((string)data["title"], (Uri)data["url"], (int)data["score"])).
                        ToArray();
                }
            }
        }

        private static async Task<Stream> InternalFetchAsync(Uri url)
        {
            using (var response =
                await httpClient.GetAsync(url).ConfigureAwait(false))
            {
                using (var stream =
                    await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    var ms = new MemoryStream();
                    await stream.CopyToAsync(ms).ConfigureAwait(false);

                    ms.Position = 0;

                    return ms;
                }
            }
        }

        public static async Task<Image> FetchImageAsync(Uri url)
        {
            return new Bitmap(await InternalFetchAsync(url));
        }
    }
}
