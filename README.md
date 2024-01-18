# Caesar_Cipher_Api

.NET Web Api that incorpotate my previous Cipher program main class to encrypt and decrypt messages using a caesar cipher method.

## Routes

### encrypting route :
Encrypt a message
```
POST http://localhost/encrypt
```
body :
```json
{
  "offset": 3,
  "message": "HelloWorld"
}
```
parameters :
- offset: integer that indicates how much the letters are goin to be shifted
- message: the message that you want to encrypt

### decrypting route :
Decrypt a message
```
POST http://localhost/encrypt
```
body : 
```json
{
  "offset": 3,
  "message": "EfsfqGeqs"
}
```
parameters :
- offset: integer that indicates how much the letters are goin to be shifted
- message: the message that you want to decrypt
