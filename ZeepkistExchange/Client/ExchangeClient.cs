using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ZeepkistExchange.Client;

public class ExchangeClient
{
    private readonly string _baseUri = System.Configuration.ConfigurationManager.AppSettings["base_uri"];
    private readonly HttpClient _exchangeClient;

    public ExchangeClient()
    {
        _exchangeClient = new HttpClient();
    }

    private string buildUri(string endpoint, Dictionary<string, string> args = null)
    {
        var uri = new Uri(new Uri(_baseUri), endpoint);
        if (args != null)
        {
            var builder = new UriBuilder(uri) { Query = ToQueryString(args) };
            return builder.ToString();
        }

        return uri.ToString();
    }
    
    private static string ToQueryString(Dictionary<string, string> args)
    {
        var array = HttpUtility.ParseQueryString(string.Empty);
        foreach (var key in args.Keys) array.Add(key, args[key]);

        return array.ToString();
    }

    public async Task<string> GetAsync(string endpoint, Dictionary<string, string> args = null)
    {
        var uri = buildUri(endpoint, args);
        var response = await _exchangeClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
    
    public async Task<string> PostAsync(string endpoint, string data)
    {
        var uri = buildUri(endpoint);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await _exchangeClient.PostAsync(uri, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> PutAsync(string endpoint, string data)
    {
        var uri = buildUri(endpoint);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await _exchangeClient.PutAsync(uri, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}