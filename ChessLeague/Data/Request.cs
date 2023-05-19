using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class Request
{
    public static bool test = true;
    public static async Task<string> SendPostRequest(string url, string content)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine("Making Post Request: " + "https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "")  + "\nContent:\n" + content);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "") , httpContent);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                throw new Exception($"HTTP **POST** request failed with status code: {response.StatusCode}");
            }
        }
    }
    public static async Task<string> SendGetRequest(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine("Making Get Request:" + "https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : ""));
            var response = await client.GetAsync("https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : ""));

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                throw new Exception($"HTTP **GET** request failed with status code: {response.StatusCode}");
            }
        }
    }
}
