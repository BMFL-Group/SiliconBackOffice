using SiliconBackOffice.Models.Courses;

namespace SiliconBackOffice.Factories;

public static class CourseFactory
{
    public static FormCourseModel ConvertToFormCourse(Course oldCourse)
    {
        return new FormCourseModel
        {
            Id = oldCourse.Id,
            Title = oldCourse.Title,
            Ingress = oldCourse.Ingress,
            ImageUri = oldCourse.ImageUri,
            AltText = oldCourse.AltText,
            BestSeller = oldCourse.BestSeller,
            IsDigital = oldCourse.IsDigital,
            Category1 = oldCourse.Categories != null && oldCourse.Categories.Length > 0 ? oldCourse.Categories[0] : string.Empty,
            Category2 = oldCourse.Categories != null && oldCourse.Categories.Length > 1 ? oldCourse.Categories[1] : string.Empty,
            Category3 = oldCourse.Categories != null && oldCourse.Categories.Length > 2 ? oldCourse.Categories[2] : string.Empty,
            Category4 = oldCourse.Categories != null && oldCourse.Categories.Length > 3 ? oldCourse.Categories[3] : string.Empty,
            Currency = oldCourse.Currency,
            Price = oldCourse.Price,
            DiscountPrice = oldCourse.DiscountPrice,
            LengthInHours = oldCourse.LengthInHours,
            RatingInPercentage = oldCourse.RatingInPercentage,
            NumberOfReviews = oldCourse.NumberOfReviews,
            NumberOfLikes = oldCourse.NumberOfLikes,
            Author1Name = oldCourse.Authors != null && oldCourse.Authors.Count > 0 ? oldCourse.Authors[0].Name : string.Empty,
            Author2Name = oldCourse.Authors != null && oldCourse.Authors.Count > 1 ? oldCourse.Authors[1].Name : string.Empty,
            ContentDescription = oldCourse.Content?.Description ?? string.Empty,
            CourseInclude1 = oldCourse.Content?.Courseincludes != null && oldCourse.Content.Courseincludes.Length > 0 ? oldCourse.Content.Courseincludes[0] : string.Empty,
            CourseInclude2 = oldCourse.Content?.Courseincludes != null && oldCourse.Content.Courseincludes.Length > 1 ? oldCourse.Content.Courseincludes[1] : string.Empty,
            CourseInclude3 = oldCourse.Content?.Courseincludes != null && oldCourse.Content.Courseincludes.Length > 2 ? oldCourse.Content.Courseincludes[2] : string.Empty,
            CourseInclude4 = oldCourse.Content?.Courseincludes != null && oldCourse.Content.Courseincludes.Length > 3 ? oldCourse.Content.Courseincludes[3] : string.Empty,
            CourseInclude5 = oldCourse.Content?.Courseincludes != null && oldCourse.Content.Courseincludes.Length > 4 ? oldCourse.Content.Courseincludes[4] : string.Empty,
            WhatYouLearn1 = oldCourse.Content?.WhatYouLearn != null && oldCourse.Content.WhatYouLearn.Length > 0 ? oldCourse.Content.WhatYouLearn[0] : string.Empty,
            WhatYouLearn2 = oldCourse.Content?.WhatYouLearn != null && oldCourse.Content.WhatYouLearn.Length > 1 ? oldCourse.Content.WhatYouLearn[1] : string.Empty,
            WhatYouLearn3 = oldCourse.Content?.WhatYouLearn != null && oldCourse.Content.WhatYouLearn.Length > 2 ? oldCourse.Content.WhatYouLearn[2] : string.Empty,
            WhatYouLearn4 = oldCourse.Content?.WhatYouLearn != null && oldCourse.Content.WhatYouLearn.Length > 3 ? oldCourse.Content.WhatYouLearn[3] : string.Empty,
            WhatYouLearn5 = oldCourse.Content?.WhatYouLearn != null && oldCourse.Content.WhatYouLearn.Length > 4 ? oldCourse.Content.WhatYouLearn[4] : string.Empty,
            ProgramDetail1Id = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 0 ? oldCourse.Content.ProgramDetails[0].Id : null,
            ProgramDetail1Title = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 0 ? oldCourse.Content.ProgramDetails[0].Title : string.Empty,
            ProgramDetail1Description1 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 0 && oldCourse.Content.ProgramDetails[0].Description != null && oldCourse.Content.ProgramDetails[0].Description.Length > 0 ? oldCourse.Content.ProgramDetails[0].Description[0] : string.Empty,
            ProgramDetail1Description2 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 0 && oldCourse.Content.ProgramDetails[0].Description != null && oldCourse.Content.ProgramDetails[0].Description.Length > 1 ? oldCourse.Content.ProgramDetails[0].Description[1] : string.Empty,
            ProgramDetail2Id = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 1 ? oldCourse.Content.ProgramDetails[1].Id : null,
            ProgramDetail2Title = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 1 ? oldCourse.Content.ProgramDetails[1].Title : string.Empty,
            ProgramDetail2Description1 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 1 && oldCourse.Content.ProgramDetails[1].Description != null && oldCourse.Content.ProgramDetails[1].Description.Length > 0 ? oldCourse.Content.ProgramDetails[1].Description[0] : string.Empty,
            ProgramDetail2Description2 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 1 && oldCourse.Content.ProgramDetails[1].Description != null && oldCourse.Content.ProgramDetails[1].Description.Length > 1 ? oldCourse.Content.ProgramDetails[1].Description[1] : string.Empty,
            ProgramDetail3Id = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 2 ? oldCourse.Content.ProgramDetails[2].Id : null,
            ProgramDetail3Title = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 2 ? oldCourse.Content.ProgramDetails[2].Title : string.Empty,
            ProgramDetail3Description1 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 2 && oldCourse.Content.ProgramDetails[2].Description != null && oldCourse.Content.ProgramDetails[2].Description.Length > 0 ? oldCourse.Content.ProgramDetails[2].Description[0] : string.Empty,
            ProgramDetail3Description2 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 2 && oldCourse.Content.ProgramDetails[2].Description != null && oldCourse.Content.ProgramDetails[2].Description.Length > 1 ? oldCourse.Content.ProgramDetails[2].Description[1] : string.Empty,
            ProgramDetail4Id = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 3 ? oldCourse.Content.ProgramDetails[3].Id : null,
            ProgramDetail4Title = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 3 ? oldCourse.Content.ProgramDetails[3].Title : string.Empty,
            ProgramDetail4Description1 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 3 && oldCourse.Content.ProgramDetails[3].Description != null && oldCourse.Content.ProgramDetails[3].Description.Length > 0 ? oldCourse.Content.ProgramDetails[3].Description[0] : string.Empty,
            ProgramDetail4Description2 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 3 && oldCourse.Content.ProgramDetails[3].Description != null && oldCourse.Content.ProgramDetails[3].Description.Length > 1 ? oldCourse.Content.ProgramDetails[3].Description[1] : string.Empty,
            ProgramDetail5Id = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 4 ? oldCourse.Content.ProgramDetails[4].Id : null,
            ProgramDetail5Title = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 4 ? oldCourse.Content.ProgramDetails[4].Title : string.Empty,
            ProgramDetail5Description1 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 4 && oldCourse.Content.ProgramDetails[4].Description != null && oldCourse.Content.ProgramDetails[4].Description.Length > 0 ? oldCourse.Content.ProgramDetails[4].Description[0] : string.Empty,
            ProgramDetail5Description2 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 4 && oldCourse.Content.ProgramDetails[4].Description != null && oldCourse.Content.ProgramDetails[4].Description.Length > 1 ? oldCourse.Content.ProgramDetails[4].Description[1] : string.Empty,
            ProgramDetail6Id = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 5 ? oldCourse.Content.ProgramDetails[5].Id : null,
            ProgramDetail6Title = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 5 ? oldCourse.Content.ProgramDetails[5].Title : string.Empty,
            ProgramDetail6Description1 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 5 && oldCourse.Content.ProgramDetails[5].Description != null && oldCourse.Content.ProgramDetails[5].Description.Length > 0 ? oldCourse.Content.ProgramDetails[5].Description[0] : string.Empty,
            ProgramDetail6Description2 = oldCourse.Content?.ProgramDetails != null && oldCourse.Content.ProgramDetails.Count > 5 && oldCourse.Content.ProgramDetails[5].Description != null && oldCourse.Content.ProgramDetails[5].Description.Length > 1 ? oldCourse.Content.ProgramDetails[5].Description[1] : string.Empty,
        };
    }

    public static Course ConvertToCourse(FormCourseModel newCourse)
    {
        return new Course
        {
            Id = newCourse.Id,
            Title = newCourse.Title,
            Ingress = newCourse.Ingress,
            ImageUri = newCourse.ImageUri,
            AltText = newCourse.AltText,
            BestSeller = newCourse.BestSeller,
            IsDigital = newCourse.IsDigital,
            Categories = new[] { newCourse.Category1, newCourse.Category2, newCourse.Category3, newCourse.Category4 },
            Currency = newCourse.Currency,
            Price = newCourse.Price,
            DiscountPrice = newCourse.DiscountPrice,
            LengthInHours = newCourse.LengthInHours,
            RatingInPercentage = newCourse.RatingInPercentage,
            NumberOfReviews = newCourse.NumberOfReviews,
            NumberOfLikes = newCourse.NumberOfLikes,
            Authors = new List<Author>
            {
                new Author { Name = newCourse.Author1Name },
                new Author { Name = newCourse.Author2Name }
            },
            Content = new Content
            {
                Description = newCourse.ContentDescription,
                Courseincludes = new[] { newCourse.CourseInclude1, newCourse.CourseInclude2, newCourse.CourseInclude3, newCourse.CourseInclude4, newCourse.CourseInclude5 },
                WhatYouLearn = new[] { newCourse.WhatYouLearn1, newCourse.WhatYouLearn2, newCourse.WhatYouLearn3, newCourse.WhatYouLearn4, newCourse.WhatYouLearn5 },
                ProgramDetails = new List<ProgramDetails>
                {
                    new ProgramDetails { Id = newCourse.ProgramDetail1Id, Title = newCourse.ProgramDetail1Title, Description = new[] { newCourse.ProgramDetail1Description1, newCourse.ProgramDetail1Description2 } },
                    new ProgramDetails { Id = newCourse.ProgramDetail2Id, Title = newCourse.ProgramDetail2Title, Description = new[] { newCourse.ProgramDetail2Description1, newCourse.ProgramDetail2Description2 } },
                    new ProgramDetails { Id = newCourse.ProgramDetail3Id, Title = newCourse.ProgramDetail3Title, Description = new[] { newCourse.ProgramDetail3Description1, newCourse.ProgramDetail3Description2 } },
                    new ProgramDetails { Id = newCourse.ProgramDetail4Id, Title = newCourse.ProgramDetail4Title, Description = new[] { newCourse.ProgramDetail4Description1, newCourse.ProgramDetail4Description2 } },
                    new ProgramDetails { Id = newCourse.ProgramDetail5Id, Title = newCourse.ProgramDetail5Title, Description = new[] { newCourse.ProgramDetail5Description1, newCourse.ProgramDetail5Description2 } },
                    new ProgramDetails { Id = newCourse.ProgramDetail6Id, Title = newCourse.ProgramDetail6Title, Description = new[] { newCourse.ProgramDetail6Description1, newCourse.ProgramDetail6Description2 } },
                }
            }
        };
    }
}

