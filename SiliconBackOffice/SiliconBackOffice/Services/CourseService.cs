using Microsoft.AspNetCore.Cors.Infrastructure;
using Newtonsoft.Json;
using SiliconBackOffice.Components.Pages;
using SiliconBackOffice.Models.Courses;
using System.Text;

namespace SiliconBackOffice.Services;

public class CourseService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public CourseService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<CourseResult> GetAllCoursesAsync(string category = "all", string searchQuery = "", int pageNumber = 1, int pageSize = 6)
    {
        try
        {
            #region GRAPHQL QUERY

            var query = new
            {
                query = @"
                query($filterQuery: CourseFiltersInput!) {
                    getCourses(filterQuery: $filterQuery) {
                        courses {
                            id
                            title
                            imageUri
                            altText
                            bestSeller                    
                            categories
                            currency
                            price
                            discountPrice
                            lengthInHours
                            ratingInPercentage
                            numberOfReviews
                            numberOfLikes
                            authors {
                                name
                            }                    
                        },
                        pagination {
                            currentPage
                            pageNumber
                            totalItems
                            pageSize
                            totalPages    
                        }
                    }
                }",
                variables = new
                {
                    filterQuery = new
                    {
                        category = category,
                        searchQuery = searchQuery,
                        pageSize = pageSize,
                        pageNumber = pageNumber,
                    }
                }
            };

            var queryJson = JsonConvert.SerializeObject(query);
            var content = new StringContent(queryJson, Encoding.UTF8, "application/json");
            var allCoursesResponse = await _httpClient.PostAsync($"{_configuration["ConnectionStrings:GraphQlApi"]}", content);
            if (allCoursesResponse.IsSuccessStatusCode)
            {
                var json = await allCoursesResponse.Content.ReadAsStringAsync();
                var graphQLResponse = JsonConvert.DeserializeObject<GraphQLResponse>(json);
                if (graphQLResponse != null && graphQLResponse.Data != null && graphQLResponse.Data.GetCourses != null && graphQLResponse.Data.GetCourses.Pagination != null)
                {
                    return new CourseResult()
                    {
                        Pagination = graphQLResponse.Data.GetCourses.Pagination,
                        Courses = graphQLResponse.Data.GetCourses.Courses,

                        Category = new()
                        {
                            CategoryName = category,
                        }
                    };
                }
            }
            else
            {
                return new CourseResult();
            }

            #endregion
        }
        catch (Exception ex) { }
        return null!;
    }

    public async Task<Course> GetOneCourseByIdAsync(string id)
    {
        try
        {
            #region GRAPHQL QUERY
            var query = new
            {
                query = @"
                query GetCourseById($id: String!) {
                    getCourseById(id: $id) {
                        id
                        title
                        ingress
                        imageUri
                        altText
                        bestSeller
                        categories
                        currency
                        price
                        discountPrice
                        lengthInHours
                        ratingInPercentage
                        numberOfReviews
                        numberOfLikes
                        authors {
                            name
                        }
                        content {
                            description
                            courseIncludes
                            whatYouLearn
                            programDetails {
                                id
                                title
                                description
                            }
                        }
                    }
                }",
                variables = new
                {
                    id = id
                }
            };

            var queryJson = JsonConvert.SerializeObject(query);
            var content = new StringContent(queryJson, Encoding.UTF8, "application/json");

            var singleCourseResponse = await _httpClient.PostAsync($"{_configuration["ConnectionStrings:GraphQlApi"]}", content);
            if (singleCourseResponse.IsSuccessStatusCode)
            {
                var json = await singleCourseResponse.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<GraphQLResponse>(json);
                if (result != null && result.Data != null && result.Data.GetCourseById != null)
                {
                    Course resultCourse = result.Data.GetCourseById;
                    if (resultCourse != null)
                    {
                        return resultCourse;
                    }
                }
            }
            #endregion
        }
        catch (Exception ex) { }
        return null!;
    }
}
