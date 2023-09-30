using HackatonCode8.Domain.Entities;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackatonCode8.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JoinCourseController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public JoinCourseController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpPost]
    public async Task<Response> Join(DatModel datmodel)
    {
        var apiUrl = "http://127.0.0.2:8008/docs";

        var response = await _httpClient.PostAsJsonAsync(apiUrl, datmodel);

        if (response.IsSuccessStatusCode)
        {
            // Deserialize the JSON response
            return await response.Content.ReadFromJsonAsync<Response>();
        }
        else
        {
            throw new HttpRequestException($"Error: {response.StatusCode}");
        }
    }
}
