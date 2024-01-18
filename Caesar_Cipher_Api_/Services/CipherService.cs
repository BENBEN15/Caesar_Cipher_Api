using System.Text;

namespace Caesar_Cipher_Api_.Services
{
    public class CipherService : ICipherService
    {
        private const int ALPHABET_SIZE = 26;

        public CipherService() { }

        public string Encrypt(string? message, int offset)
        {
            //Parameters validation
            if (message == null) return "";
            if (string.IsNullOrEmpty(message) || offset == 0) return message;

            //Encrypting

            StringBuilder encryptedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (Char.IsLetter(c))
                {
                    //Defines where A sits in ASCII depending of uppercase or not
                    int baseChar = char.IsUpper(c) ? 'A' : 'a';

                    //Here we find the difference between our letter and A to know it's position within the aplhabet
                    //and then whe add the offset to crypt the letter, then we add back the base letter value to go back to ASCII
                    int offsetPosition = ((c - baseChar + offset) % ALPHABET_SIZE) + baseChar;

                    encryptedMessage.Append((char)offsetPosition);
                }
                else
                {
                    encryptedMessage.Append(c);
                }
            }

            return encryptedMessage.ToString();
        }

        public string Decrypt(string? encryptedMessage, int offset)
        {
            //Parameters validation
            if (encryptedMessage == null) return "";
            if (string.IsNullOrEmpty(encryptedMessage) || offset == 0) return encryptedMessage;

            //Decryptring

            StringBuilder decryptedMessage = new StringBuilder();

            foreach (char c in encryptedMessage)
            {
                if (Char.IsLetter(c))
                {
                    //Defines where A sits in ASCII depending of uppercase or not
                    int baseChar = char.IsUpper(c) ? 'A' : 'a';

                    //Here we do the same thing as encryption except that we substract the offset.
                    int initialResult = c - baseChar - offset;

                    //Modulus that handles potential negative value with the formula : ((a % b) + b) % b
                    int negativeModulus = ((initialResult % ALPHABET_SIZE) + ALPHABET_SIZE) % ALPHABET_SIZE;

                    //Redfine ASCII caracter 
                    int offsetPosition = negativeModulus + baseChar;

                    decryptedMessage.Append((char)offsetPosition);
                }
                else
                {
                    decryptedMessage.Append(c);
                }
            }

            return decryptedMessage.ToString();
        }
    }
}
