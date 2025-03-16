namespace eWolfAudioSiteBuilder.Data
{
    public class CastItem
    {
        public CastItem(string role, string name)
        {
            Role = role;
            FullName = name;
        }

        public DateTime? Birthday { get; set; }
        public DateTime? Death { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}