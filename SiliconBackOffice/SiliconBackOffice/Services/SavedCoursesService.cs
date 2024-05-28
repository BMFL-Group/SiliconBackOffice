using Newtonsoft.Json;
using SiliconBackOffice.Models.SavedCourses;
using System.Diagnostics;
using System.Text;

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

    public async Task<bool> UpdateSavedCourses(SavedCoursesModel savedCourse)
    {
        try
        {
            var json = JsonConvert.SerializeObject(savedCourse);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_configuration.GetConnectionString("SavedCoursesApi")}api/SavedCourses/{savedCourse.Id}", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
        }
        catch (Exception ex)
        {

            Debug.WriteLine(ex.Message);
        }
        return false;
    }

    public async Task<bool> DeleteSavedCourses(SavedCoursesModel savedCourse)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"{_configuration.GetConnectionString("SavedCoursesApi")}api/SavedCourses/{savedCourse.Id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
        }
        catch (Exception ex)
        {

            Debug.WriteLine(ex.Message);
        }
        return false;
    }
}
