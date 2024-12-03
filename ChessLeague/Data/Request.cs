using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;

public class Request
{
    public static bool test = false;
    public static async Task<string> SendPostRequest(string url, string content)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine("Making Post Request: " + "https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "") + "&page_size=999"  + "\nContent:\n" + content);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "")  + "&page_size=999" , httpContent);

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
            Console.WriteLine("Making Get Request:" + "https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "") + "&page_size=999" );
            var response = await client.GetAsync("https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "") + "&page_size=999" );

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
    public static async Task<string> SendUpdateRequest(string url, string content)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine("Making Put Request: " + "https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "")  + "\nContent:\n" + content);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://lrs-chess-ratings.com/" + url + (url.Contains('?') ? "&" : '?') + (test ? "test=true" : "") , httpContent);

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
    
    public static async Task<Season[]> getSeasonsList()
    {
        List<Season> seasonList = new List<Season>();

        int nextPage = 0;
        //while (true)
        //{
            string responseContent = File.ReadAllText("c:\\Users\\conle\\Documents\\Software\\ChessLeagueDashboard\\ChessLeague\\StaticJsonResponses\\getSeasonList.json");;
            SeasonsResponse? response = JsonSerializer.Deserialize<SeasonsResponse>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            // if (response == null)
            // {
            //     break;
            // }
            // if (response.Items == null
            // ||  response.Items.Length == 0)
            // {
            //     break;
            // }

            seasonList.AddRange(response.Items);

            // if (response.NextPage == 0)
            // {
            //     break;
            // }

            // nextPage = response.NextPage;
        //}

        return seasonList.ToArray();
    }
    public static async Task<List<Player>> getAllPlayersList()
    {
        List<Player> playerList = new List<Player>();

        // int nextPage = 0;
        // while (true)
        // {
            string responseContent = File.ReadAllText("c:\\Users\\conle\\Documents\\Software\\ChessLeagueDashboard\\ChessLeague\\StaticJsonResponses\\getAllPlayersList.json");
            allPlayersResponse? response = JsonSerializer.Deserialize<allPlayersResponse>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            // if (response == null)
            // {
            //     break;
            // }
        //     if (response.Items == null
        //     ||  response.Items.Length == 0)
        //     {
        //         break;
        //     }

            playerList.AddRange(response.Items);

        //     if (response.NextPage == 0)
        //     {
        //         break;
        //     }

        //     nextPage = response.NextPage;
        // }

        return playerList;
    }
    public static async Task<Game[]> getSeasonGames(uint seasonId)
    {
        string responseContent = File.ReadAllText("c:\\Users\\conle\\Documents\\Software\\ChessLeagueDashboard\\ChessLeague\\StaticJsonResponses\\getGames.json");
        return JsonSerializer.Deserialize<Game[]>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public static async Task<PlayerStats[]>? postParticitpants(uint seasonId)
    {
        string responseContent = File.ReadAllText("c:\\Users\\conle\\Documents\\Software\\ChessLeagueDashboard\\ChessLeague\\StaticJsonResponses\\getParticipants.json");
        return JsonSerializer.Deserialize<PlayerStats[]>(responseContent,
                                                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
    public static async Task<PlayerStats[]> postUpdateRatings(uint seasonId)
    {
        List<Season> seasonList = new List<Season>();

        return JsonSerializer.Deserialize<PlayerStats[]>(await Request.SendPostRequest("season/" + seasonId + ":updateRatings", ""),
                                                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    
    public class SeasonsResponse
    {
        public Season[] Items { get; set; }
        public int NextPage { get; set; }
    }
    
    public class allPlayersResponse
    {
        public Player[] Items { get; set; }
        public int NextPage { get; set; }
    }

}
