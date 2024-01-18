namespace Caesar_Cipher_Api.Contracts
{
    public class CipherResponse
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
