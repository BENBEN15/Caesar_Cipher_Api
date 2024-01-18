namespace Caesar_Cipher_Api.Contracts
{
    public class CipherResponse
    {
        public CipherResponse(bool success, int code, int offset, string? message)
        {
            this.Success = success;
            this.Code = code;
            this.Offset = offset;
            this.Message = message;
        }

        public bool Success { get; set; }
        public int Code { get; set; }
        public int Offset { get; set; }
        public string Message { get; set; }
    }
}
