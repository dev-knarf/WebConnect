namespace WebConnect.Services.Utility
{
    public class ServiceResponse
    {
        public bool Success { get; set; } = true;
        public string Messsage { get; set; } = "Successful";

        public ServiceResponse(){}

        public ServiceResponse(string message)
        {
            Messsage = message;
        }

        public ServiceResponse(bool success, string message)
        {
            Success = success;
            Messsage = message;
        }

    }
}