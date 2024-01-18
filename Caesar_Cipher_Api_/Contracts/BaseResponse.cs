namespace Caesar_Cipher_Api.Contracts
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
    }
}
