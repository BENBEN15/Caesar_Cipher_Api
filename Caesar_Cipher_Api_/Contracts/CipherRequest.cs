namespace Caesar_Cipher_Api.Contracts
{
    public class CipherRequest
    {
        public CipherRequest(int offset, string? message)
        {
            this.Offset = offset;
            this.Message = message;
        }

        public int Offset { get; set; }
        public string Message { get; set; }
    }
}
