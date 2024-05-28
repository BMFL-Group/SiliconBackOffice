using SiliconBackOffice.Models.Courses;

namespace SiliconBackOffice.Models.SavedCourses;

public class SavedCoursesModel
{
    public int Id { get; set; }
    public string CourseId { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public bool IsBookmarked { get; set; } = false;
    public bool HasJoined { get; set; } = false;
    //public string CourseId { get; set; } = null!;
    //public string Title { get; set; } = null!;
    //public string UserId { get; set; } = null!;
    //public bool IsBookmarked { get; set; }
    //public bool HasJoined { get; set; }
    //public Course Course { get; set; } = null!;
}