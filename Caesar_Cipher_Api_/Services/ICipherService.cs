namespace Caesar_Cipher_Api_.Services
{
    public interface ICipherService
    {
        string Encrypt(string? message, int offset);
        string Decrypt(string? encryptedMessage, int offset);
    }
}
