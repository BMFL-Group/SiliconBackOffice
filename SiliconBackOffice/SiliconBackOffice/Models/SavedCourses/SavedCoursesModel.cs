﻿namespace SiliconBackOffice.Models.SavedCourses;

public class SavedCoursesModel
{
    public string CourseId { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public bool IsBookmarked { get; set; }
    public bool HasJoined { get; set; }
}
