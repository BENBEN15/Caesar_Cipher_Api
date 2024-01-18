namespace Caesar_Cipher_Api.Contracts
{
    public class BaseResponse
    {
        public BaseResponse(bool success, int code, string? message, string? error)
        {
            this.Success = success;
            this.Code = code;
            this.Message = message;
            this.Error = error;
        }

        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
    }
}
