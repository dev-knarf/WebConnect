namespace WebConnect.Data.Model.Security
{
    public class Log : AbstractModel
    {
        public string Token { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
    }
}