using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.crypto
{
    class Utils
    {
        /// <summary>
        /// Creates and returns a hmac object, a cryptographic hmac with the given algorithm and key.
        ///
        /// algorithm is dependent on the available algorithms supported by OpenSSL - see createHash above. key is the hmac key to be used.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Hmac createHmac(object algorithm, JsString key) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm and password.
        /// </summary>
        /// <param name="algorithm">algorithm is dependent on OpenSSL, examples are 'aes192', etc. On recent releases, openssl list-cipher-algorithms will display the available cipher algorithms. </param>
        /// <param name="password">password is used to derive key and IV, which must be a 'binary' encoded string or a buffer.</param>
        /// <returns></returns>
        public Cipher createCipher(JsString algorithm, JsString password) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm and password.
        /// </summary>
        /// <param name="algorithm">algorithm is dependent on OpenSSL, examples are 'aes192', etc. On recent releases, openssl list-cipher-algorithms will display the available cipher algorithms. </param>
        /// <param name="password">password is used to derive key and IV, which must be a 'binary' encoded string or a buffer.</param>
        /// <returns></returns>
        public Cipher createCipher(JsString algorithm, Buffer password) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm, key and iv.
        /// </summary>
        /// <param name="algorithm">algorithm is the same as the argument to createCipher().</param>
        /// <param name="key">key is the raw key used by the algorithm. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <param name="iv">iv is an initialization vector. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <returns></returns>
        public Cipher createCipheriv(JsString algorithm, JsString key, JsString iv) { return null; }
        /// <summary>
        /// Creates and returns a cipher object, with the given algorithm, key and iv.
        /// </summary>
        /// <param name="algorithm">algorithm is the same as the argument to createCipher().</param>
        /// <param name="key">key is the raw key used by the algorithm. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <param name="iv">iv is an initialization vector. key and iv must be 'binary' encoded strings or buffers.</param>
        /// <returns></returns>
        public Cipher createCipheriv(JsString algorithm, Buffer key, Buffer iv) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm and key. This is the mirror of the createCipher() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Decipher createDecipher(JsString algorithm, JsString password) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm and key. This is the mirror of the createCipher() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Decipher createDecipher(JsString algorithm, Buffer password) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm, key and iv. This is the mirror of the createCipheriv() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public Decipher createfDecipheriv(JsString algorithm, JsString key, JsString iv) { return null; }
        /// <summary>
        /// Creates and returns a decipher object, with the given algorithm, key and iv. This is the mirror of the createCipheriv() above.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public Decipher createfDecipheriv(JsString algorithm, Buffer key, Buffer iv) { return null; }
        /// <summary>
        /// Creates and returns a signing object, with the given algorithm. On recent OpenSSL releases, openssl list-public-key-algorithms will display the available signing algorithms.
        /// Examples are 'RSA-SHA256'.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        public Signer createSign(JsString algorithm) { return null; }
        /// <summary>
        /// Class for verifying signatures.
        ///
        /// Returned by crypto.createVerify.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        public Verify createVerify(JsString algorithm) { return null; }
        /// <summary>
        /// Creates a Diffie-Hellman key exchange object and generates a prime of the given bit length. The generator used is 2.
        /// </summary>
        /// <param name="prime_length"></param>
        /// <returns></returns>
        public DiffieHellman createDiffieHallman(JsNumber prime_length) { return null; }
        /// <summary>
        /// Creates a Diffie-Hellman key exchange object using the supplied prime. The generator used is 2. 
        /// </summary>
        /// <param name="prime"></param>
        /// <param name="encoding">Encoding can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        /// <returns></returns>
        public DiffieHellman createDiffieHallman(JsNumber prime, JsString encoding) { return null; }
    }
}
