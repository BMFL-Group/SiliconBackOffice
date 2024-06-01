namespace SiliconBackOffice.Models
{
    public class NewsletterModel
    {
        public string email { get; set; }
        public bool dailyNewsletter { get; set; }
        public bool advertisingUpdates { get; set; }
        public bool weekInReview { get; set; }
        public bool eventUpdates { get; set; }
        public bool startupsWeekly { get; set; }
        public bool podcasts { get; set; }

    }
}
