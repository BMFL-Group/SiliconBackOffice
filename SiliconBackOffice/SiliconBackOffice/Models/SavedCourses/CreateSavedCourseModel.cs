namespace SiliconBackOffice.Models.SavedCourses;

public class CreateSavedCourseModel
{
    public string Email { get; set; } = null!;
    public string CourseId { get; set; } = null!;
    public bool IsBookmarked { get; set; }
    public bool HasJoined { get; set; }
}
