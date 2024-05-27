﻿using Newtonsoft.Json;
using SiliconBackOffice.Models.SavedCourses;
using System.Diagnostics;

namespace SiliconBackOffice.Services;

public class SavedCoursesService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public SavedCoursesService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<IEnumerable<SavedCoursesModel>> GetSavedCoursesAsync(string userId)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{_configuration.GetConnectionString("SavedCoursesApi")}api/SavedCourses/user/{userId}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<SavedCoursesModel>>(json);
            if (result != null && result.Any())
            {
                return result;
            }
        }
        catch (Exception ex)
        {

            Debug.WriteLine(ex.Message);
        }
        return null!;
    }
}
