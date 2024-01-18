using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caesar_Cipher_Api.Services;

namespace UnitTests
{
    public class CipherServiceTests
    {
        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Plain_Text()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "HelloWorld";
            string encryptedMessage = "KhoorZruog";
            int offset = 3;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Special_Chars()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "Hello,World!";
            string encryptedMessage = "Khoor,Zruog!";
            int offset = 3;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Spaces()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "Hello Wor ld ";
            string encryptedMessage = "Khoor Zru og ";
            int offset = 3;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Numbers()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "HelloWorld123";
            string encryptedMessage = "KhoorZruog123";
            int offset = 3;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_offset_More_Than_26()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "HelloWorld";
            string encryptedMessage = "LippsAsvph";
            int offset = 30;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_Null()
        {
            //Arrange
            ICipherService service = new CipherService();
            string encryptedMessage = "";
            int offset = 3;

            //Act
            string result = service.Encrypt(null, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_offset_Zero()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "HelloWorld";
            string encryptedMessage = "HelloWorld";
            int offset = 0;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Encrypt_Message_offset_High()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "HelloWorld";
            string encryptedMessage = "CzggjRjmgy";
            int offset = 12345;

            //Act
            string result = service.Encrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Plain_Text()
        {
            //Arrange
            ICipherService service = new CipherService();
            string encryptedMessage = "KhoorZruog";
            string decryptedMessage = "HelloWorld";
            int offset = 3;

            //Act
            string result = service.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Special_Chars()
        {
            //Arrange
            ICipherService service = new CipherService();
            string encryptedMessage = "Khoor,Zruog!";
            string decryptedMessage = "Hello,World!";
            int offset = 3;

            //Act
            string result = service.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Spaces()
        {
            //Arrange
            ICipherService service = new CipherService();
            string encryptedMessage = "Khoor Zru og";
            string decryptedMessage = "Hello Wor ld";
            int offset = 3;

            //Act
            string result = service.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Numbers()
        {
            //Arrange
            ICipherService service = new CipherService();
            string encryptedMessage = "KhoorZruog123";
            string decryptedMessage = "HelloWorld123";
            int offset = 3;

            //Act
            string result = service.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Numbers_offset_More_Than_26()
        {
            //Arrange
            ICipherService service = new CipherService();
            string encryptedMessage = "LippsAsvph";
            string decryptedMessage = "HelloWorld";
            int offset = 30;

            //Act
            string result = service.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_Null()
        {
            //Arrange
            ICipherService service = new CipherService();
            string decryptedMessage = "";
            int offset = 3;

            //Act
            string result = service.Decrypt(null, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_offset_Zero()
        {
            //Arrange
            ICipherService service = new CipherService();
            string message = "HelloWorld";
            string encryptedMessage = "HelloWorld";
            int offset = 0;

            //Act
            string result = service.Decrypt(message, offset);

            //Assert
            Assert.Equal(encryptedMessage, result);
        }

        [Fact]
        public void Caesar_Cipher_Decrypt_Message_offset_High()
        {
            //Arrange
            ICipherService service = new CipherService();
            string decryptedMessage = "HelloWorld";
            string encryptedMessage = "CzggjRjmgy";
            int offset = 12345;

            //Act
            string result = service.Decrypt(encryptedMessage, offset);

            //Assert
            Assert.Equal(decryptedMessage, result);
        }
    }
}
