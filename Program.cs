// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ConsumeAPI;

class Program
{
    private const string Url = "https://investor.jeddah.gov.sa/api/IAM/IAMURL/1";

    static async Task Main()
    {
        using HttpClient httpClient = new HttpClient();

        try
        {
            var response = await httpClient.GetStringAsync(Url);
            var apiResponse = JsonSerializer.Deserialize<ApiResponse>(response);
            
            string dataValue = apiResponse.data;

            Console.WriteLine($"Data Value: {dataValue}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
