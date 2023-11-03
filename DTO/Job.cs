namespace DTO
{
    public class Job
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int companyid { get; set; }
    }
}