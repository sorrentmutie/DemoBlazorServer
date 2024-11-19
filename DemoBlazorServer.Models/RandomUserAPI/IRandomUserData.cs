namespace DemoBlazorServer.Models.RandomUserAPI;

public interface IRandomUserData
{
    Task<RandomUserAPIResponse?> GetRandomUser();
}
