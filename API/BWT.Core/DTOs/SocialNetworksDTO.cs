namespace BWT.Core.DTOs
{
    public partial class SocialNetworksDTO
    {
        public int Id { get; set; }
        public int FkUserInfo { get; set; }
        public string Twitch { get; set; }
        public string Youtube { get; set; }
        public string Facebook { get; set; }
        public string Instragram { get; set; }
        public string Tiktok { get; set; }
        public string Twitter { get; set; }
    }
}
