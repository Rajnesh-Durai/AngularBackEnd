namespace BigBangAngular30thJune.Authentication
{
    public class RefreshTokenRequest
    {
        public string AccessToken { get; set; }=string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
