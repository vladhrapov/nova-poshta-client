namespace NovaPoshta.Client.Models
{
    public sealed class ApiResponse<T>
    {
        public ResponsePayload<T> Payload { get; set; }
        public int StatusCode { get; set; }
    }
}
