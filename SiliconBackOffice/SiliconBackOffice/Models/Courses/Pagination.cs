﻿namespace SiliconBackOffice.Models.Courses;

public class Pagination
{
    public int CurrentPage { get; set; }

    public int PageNumber { get; set; }

    public int TotalItems { get; set; }

    public int PageSize { get; set; }

    public int TotalPages { get; set; }

    public void UpdateTotalPages()
    {
        TotalPages = (int)Math.Ceiling((double)TotalItems / PageSize);
    }
}
