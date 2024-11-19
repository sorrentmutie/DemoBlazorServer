using DemoBlazorServer.Models.RandomUserAPI;
using System.Net.Http.Json;

namespace DemoBlazorWASM.Services;

public class ServizioWASMRandomUser : IRandomUserData
{
    private readonly HttpClient httpClient;
    private readonly IConfiguration configuration;

    public ServizioWASMRandomUser(HttpClient httpClient, IConfiguration configuration)
    {
        this.httpClient = httpClient;
        this.configuration = configuration;
    }

    public async Task<RandomUserAPIResponse?> GetRandomUser()
    {
        var url = configuration["IndirizzoRandomUserData"];
        var response = await httpClient.GetAsync(url!);
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var x = await response.Content.ReadFromJsonAsync<RandomUserAPIResponse>();
            return x;
        }
        return null;
    }
}
