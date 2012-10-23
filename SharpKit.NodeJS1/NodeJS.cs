
using SharpKit.JavaScript;

namespace SharpKit.NodeJS1
{
    //TODO: Assertion Testing

    //TODO: may think Buffer is also a namespace

    /// <summary>
    /// The Buffer class is a global type for dealing with binary data directly. It can be constructed in a variety of ways.
    /// </summary>
    public class Buffer
    {
        /// <summary>
        /// Allocates a new buffer of size octets.
        /// </summary>
        /// <param name="size"></param>
        public Buffer(JsNumber size) { }

        /// <summary>
        /// Allocates a new buffer using an array of octets.
        /// </summary>
        /// <param name="array"></param>
        public Buffer(JsArray array) { }

        /// <summary>
        /// Allocates a new buffer containing the given str. encoding defaults to 'utf8'.
        /// </summary>
        /// <param name="str">string to encode</param>
        /// <param name="encoding"> encoding to use, Optional</param>
        public Buffer(JsString str, JsString encoding) { }

        /// <summary>
        /// Allocates a new buffer containing the given str. encoding defaults to 'utf8'.
        /// </summary>
        /// <param name="str">string to encode</param>
        public Buffer(JsString str) { }

        /// <summary>
        /// Writes string to the buffer at offset using the given encoding. offset defaults to 0, encoding defaults to 'utf8'.
        /// length is the number of bytes to write. Returns number of octets written. 
        /// If buffer did not contain enough space to fit the entire string, it will write a partial amount of the string.
        /// length defaults to buffer.length - offset. The method will not write partial characters.
        /// </summary>
        /// <param name="string">data to be written to buffer</param>
        /// <param name="offset"> Optional, Default: 0</param>
        /// <param name="length"> Optional, Default: buffer.length - offset</param>
        /// <param name="encoding"> Optional, Default: 'utf8'</param>
        /// <example>
        /// <code>
        /// buf = new Buffer(256);
        /// len = buf.write('\u00bd + \u00bc = \u00be', 0);
        /// console.log(len + " bytes: " + buf.toString('utf8', 0, len));
        /// </code>
        /// </example>
        public void write(JsString @string, JsNumber offset, JsNumber length, JsString encoding) { }
        /// <summary>
        /// Writes string to the buffer at offset using the given encoding. offset defaults to 0, encoding defaults to 'utf8'.
        /// length is the number of bytes to write. Returns number of octets written. 
        /// If buffer did not contain enough space to fit the entire string, it will write a partial amount of the string.
        /// length defaults to buffer.length - offset. The method will not write partial characters.
        /// </summary>
        /// <param name="string">data to be written to buffer</param>
        /// <param name="offset"> Optional, Default: 0</param>
        /// <param name="length"> Optional, Default: buffer.length - offset</param>
        /// <example>
        /// <code>
        /// buf = new Buffer(256);
        /// len = buf.write('\u00bd + \u00bc = \u00be', 0);
        /// console.log(len + " bytes: " + buf.toString('utf8', 0, len));
        /// </code>
        /// </example>
        public void write(JsString @string, JsNumber offset, JsNumber length) { }
        /// <summary>
        /// Writes string to the buffer at offset using the given encoding. offset defaults to 0, encoding defaults to 'utf8'.
        /// length is the number of bytes to write. Returns number of octets written. 
        /// If buffer did not contain enough space to fit the entire string, it will write a partial amount of the string.
        /// length defaults to buffer.length - offset. The method will not write partial characters.
        /// </summary>
        /// <param name="string">data to be written to buffer</param>
        /// <param name="offset"> Optional, Default: 0</param>
        /// <example>
        /// <code>
        /// buf = new Buffer(256);
        /// len = buf.write('\u00bd + \u00bc = \u00be', 0);
        /// console.log(len + " bytes: " + buf.toString('utf8', 0, len));
        /// </code>
        /// </example>
        public void write(JsString @string, JsNumber offset) { }
        /// <summary>
        /// Writes string to the buffer at offset using the given encoding. offset defaults to 0, encoding defaults to 'utf8'.
        /// length is the number of bytes to write. Returns number of octets written. 
        /// If buffer did not contain enough space to fit the entire string, it will write a partial amount of the string.
        /// length defaults to buffer.length - offset. The method will not write partial characters.
        /// </summary>
        /// <param name="string">data to be written to buffer</param>
        /// <example>
        /// <code>
        /// buf = new Buffer(256);
        /// len = buf.write('\u00bd + \u00bc = \u00be', 0);
        /// console.log(len + " bytes: " + buf.toString('utf8', 0, len));
        /// </code>
        /// </example>
        public void write(JsString @string) { }

        /// <summary>
        /// Decodes and returns a string from buffer data encoded with encoding (defaults to 'utf8') 
        /// beginning at start (defaults to 0) and ending at end (defaults to buffer.length).
        /// </summary>
        /// <param name="encoding">Optional, Default: 'utf8'</param>
        /// <param name="start">Optional, Default: 0</param>
        /// <param name="end">Optional, Default: buffer.length</param>
        /// <returns> returns a string from buffer data encoded with encoding (defaults to 'utf8')</returns>
        public JsString toString(JsString encoding, JsNumber start, JsNumber end) { return null; }
        /// <summary>
        /// Decodes and returns a string from buffer data encoded with encoding (defaults to 'utf8') 
        /// beginning at start (defaults to 0) and ending at end (defaults to buffer.length).
        /// </summary>
        /// <param name="encoding">Optional, Default: 'utf8'</param>
        /// <param name="start">Optional, Default: 0</param>
        /// <returns> returns a string from buffer data encoded with encoding (defaults to 'utf8')</returns>
        public JsString toString(JsString encoding, JsNumber start) { return null; }
        /// <summary>
        /// Decodes and returns a string from buffer data encoded with encoding (defaults to 'utf8') 
        /// beginning at start (defaults to 0) and ending at end (defaults to buffer.length).
        /// </summary>
        /// <param name="encoding">Optional, Default: 'utf8'</param>
        /// <returns> returns a string from buffer data encoded with encoding (defaults to 'utf8')</returns>
        public JsString toString(JsString encoding) { return null; }
        /// <summary>
        /// Decodes and returns a string from buffer data encoded with encoding (defaults to 'utf8') 
        /// beginning at start (defaults to 0) and ending at end (defaults to buffer.length).
        /// </summary>
        /// <returns> returns a string from buffer data encoded with encoding (defaults to 'utf8')</returns>
        public JsString toString() { return null; }

        //TODO: buf[index]

        /// <summary>
        /// Tests if obj is a Buffer.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool isBuffer(object obj) { return false; }

        /// <summary>
        /// Gives the actual byte length of a string. encoding defaults to 'utf8'.
        /// This is not the same as String.prototype.length since that returns the number of characters in a string.
        /// </summary>
        /// <param name="string"></param>
        /// <param name="encoding"> Optional, Default: 'utf8'</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// str = '\u00bd + \u00bc = \u00be';
        /// console.log(str + ": " + str.length + " characters, " +
        ///   Buffer.byteLength(str, 'utf8') + " bytes");
        /// 
        /// // ½ + ¼ = ¾: 9 characters, 12 bytes
        /// </code>
        /// </example>
        public static JsNumber byteLength(JsString @string, JsNumber encoding) { return null; }
        /// <summary>
        /// Gives the actual byte length of a string. encoding defaults to 'utf8'.
        /// This is not the same as String.prototype.length since that returns the number of characters in a string.
        /// </summary>
        /// <param name="string"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// str = '\u00bd + \u00bc = \u00be';
        /// console.log(str + ": " + str.length + " characters, " +
        ///   Buffer.byteLength(str, 'utf8') + " bytes");
        /// 
        /// // ½ + ¼ = ¾: 9 characters, 12 bytes
        /// </code>
        /// </example>
        public static JsNumber byteLength(JsString @string) { return null; }

        /// <summary>
        /// Returns a buffer which is the result of concatenating all the buffers in the list together.
        /// If the list has no items, or if the totalLength is 0, then it returns a zero-length buffer.
        /// If the list has exactly one item, then the first item of the list is returned.
        /// If the list has more than one item, then a new Buffer is created.
        /// If totalLength is not provided, it is read from the buffers in the list.
        /// However, this adds an additional loop to the function, so it is faster to provide the length explicitly.
        /// </summary>
        /// <param name="list">List of Buffer objects to concat</param>
        /// <param name="totalLength">Total length of the buffers when concatenated</param>
        /// <returns></returns>
        public static Buffer concat(JsArray list, JsNumber totalLength) { return null; }
        /// <summary>
        /// Returns a buffer which is the result of concatenating all the buffers in the list together.
        /// If the list has no items, or if the totalLength is 0, then it returns a zero-length buffer.
        /// If the list has exactly one item, then the first item of the list is returned.
        /// If the list has more than one item, then a new Buffer is created.
        /// If totalLength is not provided, it is read from the buffers in the list.
        /// However, this adds an additional loop to the function, so it is faster to provide the length explicitly.
        /// </summary>
        /// <param name="list">List of Buffer objects to concat</param>
        /// <returns></returns>
        public static Buffer concat(JsArray list) { return null; }

        /// <summary>
        /// The size of the buffer in bytes. Note that this is not necessarily the size of the contents.
        /// length refers to the amount of memory allocated for the buffer object. It does not change when the contents of the buffer are changed.
        /// </summary>
        /// <example>
        /// <code>
        /// buf = new Buffer(1234);
        /// console.log(buf.length);
        /// buf.write("some string", 0, "ascii");
        /// console.log(buf.length);
        /// // 1234
        /// // 1234
        /// </code>
        /// </example>
        public JsNumber length { get; set; }

        /// <summary>
        /// Does copy between buffers. The source and target regions can be overlapped. targetStart and sourceStart default to 0. sourceEnd defaults to buffer.length.
        /// </summary>
        /// <param name="targetBuffer">Buffer to copy into</param>
        /// <param name="targetStart"> Number, Optional, Default: 0</param>
        /// <param name="sourceStart">Number, Optional, Default: 0</param>
        /// <param name="sourceEnd">Optional, Default: buffer.length</param>
        /// <example>
        /// <code>
        /// //Example: build two Buffers, then copy buf1 from byte 16 through byte 19 into buf2, starting at the 8th byte in buf2.
        /// buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// 
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        ///   buf2[i] = 33; // ASCII !
        /// }
        /// 
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// 
        /// // !!!!!!!!qrst!!!!!!!!!!!!!
        /// </code>
        /// </example>
        public void copy(Buffer targetBuffer, JsNumber targetStart, JsNumber sourceStart, JsNumber sourceEnd) { }
        /// <summary>
        /// Does copy between buffers. The source and target regions can be overlapped. targetStart and sourceStart default to 0. sourceEnd defaults to buffer.length.
        /// </summary>
        /// <param name="targetBuffer">Buffer to copy into</param>
        /// <param name="targetStart"> Number, Optional, Default: 0</param>
        /// <param name="sourceStart">Number, Optional, Default: 0</param>
        /// <example>
        /// <code>
        /// //Example: build two Buffers, then copy buf1 from byte 16 through byte 19 into buf2, starting at the 8th byte in buf2.
        /// buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// 
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        ///   buf2[i] = 33; // ASCII !
        /// }
        /// 
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// 
        /// // !!!!!!!!qrst!!!!!!!!!!!!!
        /// </code>
        /// </example>
        public void copy(Buffer targetBuffer, JsNumber targetStart, JsNumber sourceStart) { }
        /// <summary>
        /// Does copy between buffers. The source and target regions can be overlapped. targetStart and sourceStart default to 0. sourceEnd defaults to buffer.length.
        /// </summary>
        /// <param name="targetBuffer">Buffer to copy into</param>
        /// <param name="targetStart"> Number, Optional, Default: 0</param>         /// <summary>
        /// Does copy between buffers. The source and target regions can be overlapped. targetStart and sourceStart default to 0. sourceEnd defaults to buffer.length.
        /// </summary>
        /// <param name="targetBuffer">Buffer to copy into</param>
        /// <param name="targetStart"> Number, Optional, Default: 0</param>
        /// <param name="sourceStart">Number, Optional, Default: 0</param>
        ///         /// <example>
        /// <code>
        /// //Example: build two Buffers, then copy buf1 from byte 16 through byte 19 into buf2, starting at the 8th byte in buf2.
        /// buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// 
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        ///   buf2[i] = 33; // ASCII !
        /// }
        /// 
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// 
        /// // !!!!!!!!qrst!!!!!!!!!!!!!
        /// </code>
        /// </example>
        public void copy(Buffer targetBuffer, JsNumber targetStart) { }
        /// <summary>
        /// Does copy between buffers. The source and target regions can be overlapped. targetStart and sourceStart default to 0. sourceEnd defaults to buffer.length.
        /// </summary>
        /// <param name="targetBuffer">Buffer to copy into</param>
        /// <summary>
        /// Does copy between buffers. The source and target regions can be overlapped. targetStart and sourceStart default to 0. sourceEnd defaults to buffer.length.
        /// </summary>
        /// <param name="targetBuffer">Buffer to copy into</param>
        /// <param name="targetStart"> Number, Optional, Default: 0</param>
        /// <param name="sourceStart">Number, Optional, Default: 0</param>
        ///         /// <example>
        /// <code>
        /// //Example: build two Buffers, then copy buf1 from byte 16 through byte 19 into buf2, starting at the 8th byte in buf2.
        /// buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// 
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        ///   buf2[i] = 33; // ASCII !
        /// }
        /// 
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// 
        /// // !!!!!!!!qrst!!!!!!!!!!!!!
        /// </code>
        /// </example>
        public void copy(Buffer targetBuffer) { }


        /// <summary>
        /// Returns a new buffer which references the same memory as the old, but offset and cropped by the start (defaults to 0) and end (defaults to buffer.length) indexes.
        /// Modifying the new buffer slice will modify memory in the original buffer!
        /// </summary>
        /// <param name="start">Optional, Default: 0</param>
        /// <param name="end">Optional, Default: buffer.length</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// // Example: build a Buffer with the ASCII alphabet, take a slice, then modify one byte from the original Buffer.
        /// var buf1 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        /// }
        /// var buf2 = buf1.slice(0, 3);
        /// console.log(buf2.toString('ascii', 0, buf2.length));
        /// buf1[0] = 33;
        /// console.log(buf2.toString('ascii', 0, buf2.length));
        /// // abc
        /// // !bc
        /// </code>
        /// </example>
        public Buffer slice(JsNumber start, JsNumber end) { return null; }
        /// <summary>
        /// Returns a new buffer which references the same memory as the old, but offset and cropped by the start (defaults to 0) and end (defaults to buffer.length) indexes.
        /// Modifying the new buffer slice will modify memory in the original buffer!
        /// </summary>
        /// <param name="start">Optional, Default: 0</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// // Example: build a Buffer with the ASCII alphabet, take a slice, then modify one byte from the original Buffer.
        /// var buf1 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        /// }
        /// var buf2 = buf1.slice(0, 3);
        /// console.log(buf2.toString('ascii', 0, buf2.length));
        /// buf1[0] = 33;
        /// console.log(buf2.toString('ascii', 0, buf2.length));
        /// // abc
        /// // !bc
        /// </code>
        /// </example>
        public Buffer slice(JsNumber start) { return null; }
        /// <summary>
        /// Returns a new buffer which references the same memory as the old, but offset and cropped by the start (defaults to 0) and end (defaults to buffer.length) indexes.
        /// Modifying the new buffer slice will modify memory in the original buffer!
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// // Example: build a Buffer with the ASCII alphabet, take a slice, then modify one byte from the original Buffer.
        /// var buf1 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        ///   buf1[i] = i + 97; // 97 is ASCII a
        /// }
        /// var buf2 = buf1.slice(0, 3);
        /// console.log(buf2.toString('ascii', 0, buf2.length));
        /// buf1[0] = 33;
        /// console.log(buf2.toString('ascii', 0, buf2.length));
        /// // abc
        /// // !bc
        /// </code>
        /// </example>
        public Buffer slice() { return null; }

        /// <summary>
        /// Reads an unsigned 8 bit integer from the buffer at the specified offset.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// for (ii = 0; ii &lt; buf.length; ii++) {
        ///   console.log(buf.readUInt8(ii));
        /// }
        /// // 0x3
        /// // 0x4
        /// // 0x23
        /// // 0x42
        /// </code>
        /// </example>
        public JsNumber readUInt8(JsNumber offset, bool noAssert) { return null; }

        /// <summary>
        /// Reads an unsigned 8 bit integer from the buffer at the specified offset.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// for (ii = 0; ii &lt; buf.length; ii++) {
        ///   console.log(buf.readUInt8(ii));
        /// }
        /// // 0x3
        /// // 0x4
        /// // 0x23
        /// // 0x42
        /// </code>
        /// </example>
        public JsNumber readUInt8(JsNumber offset) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset">Optional, Default: false</param>
        /// <param name="noAssert"></param>
        /// <returns></returns>
        public JsNumber readUInt16LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readUInt16LE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads an unsigned 16 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt16BE(0));
        /// console.log(buf.readUInt16LE(0));
        /// console.log(buf.readUInt16BE(1));
        /// console.log(buf.readUInt16LE(1));
        /// console.log(buf.readUInt16BE(2));
        /// console.log(buf.readUInt16LE(2));
        /// // 0x0304
        /// // 0x0403
        /// // 0x0423
        /// // 0x2304
        /// // 0x2342
        /// // 0x4223
        /// </code>
        /// </example>
        public JsNumber readUInt16BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads an unsigned 16 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt16BE(0));
        /// console.log(buf.readUInt16LE(0));
        /// console.log(buf.readUInt16BE(1));
        /// console.log(buf.readUInt16LE(1));
        /// console.log(buf.readUInt16BE(2));
        /// console.log(buf.readUInt16LE(2));
        /// // 0x0304
        /// // 0x0403
        /// // 0x0423
        /// // 0x2304
        /// // 0x2342
        /// // 0x4223
        /// </code>
        /// </example>
        public JsNumber readUInt16BE(JsNumber offset) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readUInt32LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readUInt32LE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads an unsigned 32 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt32BE(0));
        /// console.log(buf.readUInt32LE(0));
        /// // 0x03042342
        /// // 0x42230403
        /// </code>
        /// </example>
        public JsNumber readUInt32BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads an unsigned 32 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt32BE(0));
        /// console.log(buf.readUInt32LE(0));
        /// // 0x03042342
        /// // 0x42230403
        /// </code>
        /// </example>
        public JsNumber readUInt32BE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads a signed 8 bit integer from the buffer at the specified offset.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// Works as buffer.readUInt8, except buffer contents are treated as two's complement signed values.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readInt8(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads a signed 8 bit integer from the buffer at the specified offset.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// Works as buffer.readUInt8, except buffer contents are treated as two's complement signed values.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readInt8(JsNumber offset) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readInt16LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readInt16LE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads a signed 16 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// Works as buffer.readUInt16*, except buffer contents are treated as two's complement signed values.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readInt16BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads a signed 16 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// Works as buffer.readUInt16*, except buffer contents are treated as two's complement signed values.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readInt16BE(JsNumber offset) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readInt32LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readInt32LE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads a signed 32 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// Works as buffer.readUInt32*, except buffer contents are treated as two's complement signed values.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readInt32BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads a signed 32 bit integer from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// Works as buffer.readUInt32*, except buffer contents are treated as two's complement signed values.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readInt32BE(JsNumber offset) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readFloatLE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readFloatLE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads a 32 bit float from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x00;
        /// buf[1] = 0x00;
        /// buf[2] = 0x80;
        /// buf[3] = 0x3f;
        /// console.log(buf.readFloatLE(0));
        /// // 0x01
        /// </code>
        /// </example>
        public JsNumber readFloatBE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads a 32 bit float from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf[0] = 0x00;
        /// buf[1] = 0x00;
        /// buf[2] = 0x80;
        /// buf[3] = 0x3f;
        /// console.log(buf.readFloatLE(0));
        /// // 0x01
        /// </code>
        /// </example>
        public JsNumber readFloatBE(JsNumber offset) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        public JsNumber readDoubleLE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public JsNumber readDoubleLE(JsNumber offset) { return null; }

        /// <summary>
        /// Reads a 64 bit double from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="noAssert"> Optional, Default: false</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(8);
        /// buf[0] = 0x55;
        /// buf[1] = 0x55;
        /// buf[2] = 0x55;
        /// buf[3] = 0x55;
        /// buf[4] = 0x55;
        /// buf[5] = 0x55;
        /// buf[6] = 0xd5;
        /// buf[7] = 0x3f;
        /// console.log(buf.readDoubleLE(0));
        /// // 0.3333333333333333
        /// </code>
        /// </example>
        public JsNumber readDoubleBE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// Reads a 64 bit double from the buffer at the specified offset with specified endian format.
        /// Set noAssert to true to skip validation of offset. This means that offset may be beyond the end of the buffer. Defaults to false.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var buf = new Buffer(8);
        /// buf[0] = 0x55;
        /// buf[1] = 0x55;
        /// buf[2] = 0x55;
        /// buf[3] = 0x55;
        /// buf[4] = 0x55;
        /// buf[5] = 0x55;
        /// buf[6] = 0xd5;
        /// buf[7] = 0x3f;
        /// console.log(buf.readDoubleLE(0));
        /// // 0.3333333333333333
        /// </code>
        /// </example>
        public JsNumber readDoubleBE(JsNumber offset) { return null; }

        /// <summary>
        /// Writes value to the buffer at the specified offset. Note, value must be a valid unsigned 8 bit integer.
        /// Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeUInt8(0x3, 0);
        /// buf.writeUInt8(0x4, 1);
        /// buf.writeUInt8(0x23, 2);
        /// buf.writeUInt8(0x42, 3);
        /// console.log(buf);
        /// // <Buffer 03 04 23 42>
        /// </code>
        /// </example>
        public void writeUInt8(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset. Note, value must be a valid unsigned 8 bit integer.
        /// Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeUInt8(0x3, 0);
        /// buf.writeUInt8(0x4, 1);
        /// buf.writeUInt8(0x23, 2);
        /// buf.writeUInt8(0x42, 3);
        /// console.log(buf);
        /// // <Buffer 03 04 23 42>
        /// </code>
        /// </example>
        public void writeUInt8(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeUInt16LE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeUInt16LE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid unsigned 16 bit integer.Set noAssert to true to skip validation of value and offset. 
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeUInt16BE(0xdead, 0);
        /// buf.writeUInt16BE(0xbeef, 2);
        /// console.log(buf);
        /// buf.writeUInt16LE(0xdead, 0);
        /// buf.writeUInt16LE(0xbeef, 2);
        /// console.log(buf);
        /// // <Buffer de ad be ef>
        /// // <Buffer ad de ef be>
        /// </code>
        /// </example>
        public void writeUInt16BE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid unsigned 16 bit integer.Set noAssert to true to skip validation of value and offset. 
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeUInt16BE(0xdead, 0);
        /// buf.writeUInt16BE(0xbeef, 2);
        /// console.log(buf);
        /// buf.writeUInt16LE(0xdead, 0);
        /// buf.writeUInt16LE(0xbeef, 2);
        /// console.log(buf);
        /// // <Buffer de ad be ef>
        /// // <Buffer ad de ef be>
        /// </code>
        /// </example>
        public void writeUInt16BE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeUInt32LE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeUInt32LE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid unsigned 32 bit integer.Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeUInt32BE(0xfeedface, 0);
        /// console.log(buf);
        /// buf.writeUInt32LE(0xfeedface, 0);
        /// console.log(buf);
        /// // <Buffer fe ed fa ce>
        /// // <Buffer ce fa ed fe>
        /// </code>
        /// </example>
        public void writeUInt32BE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid unsigned 32 bit integer.Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeUInt32BE(0xfeedface, 0);
        /// console.log(buf);
        /// buf.writeUInt32LE(0xfeedface, 0);
        /// console.log(buf);
        /// // <Buffer fe ed fa ce>
        /// // <Buffer ce fa ed fe>
        /// </code>
        /// </example>
        public void writeUInt32BE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// Writes value to the buffer at the specified offset. Note, value must be a valid signed 8 bit integer. Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// Works as buffer.writeUInt8, except value is written out as a two's complement signed integer into buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeInt8(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset. Note, value must be a valid signed 8 bit integer. Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// Works as buffer.writeUInt8, except value is written out as a two's complement signed integer into buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeInt8(JsNumber value, JsNumber offset) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeInt16LE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeInt16LE(JsNumber value, JsNumber offset) { }


        /// <summary>
        /// Writes value to the buffer at the specified offset. Note, value must be a valid signed 16 bit integer. Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// Works as buffer.writeUInt16*, except value is written out as a two's complement signed integer into buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeInt16BE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset. Note, value must be a valid signed 16 bit integer. Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// Works as buffer.writeUInt16*, except value is written out as a two's complement signed integer into buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeInt16BE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeInt32LE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeInt32LE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid signed 32 bit integer.Set noAssert to true to skip validation of value and offset. 
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// Works as buffer.writeUInt32*, except value is written out as a two's complement signed integer into buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeInt32BE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid signed 32 bit integer.Set noAssert to true to skip validation of value and offset. 
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// Works as buffer.writeUInt32*, except value is written out as a two's complement signed integer into buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeInt32BE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeFloatLE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeFloatLE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid 32 bit float.Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeFloatBE(0xcafebabe, 0);
        /// console.log(buf);
        /// buf.writeFloatLE(0xcafebabe, 0);
        /// console.log(buf);
        /// // <Buffer 4f 4a fe bb>
        /// // <Buffer bb fe 4a 4f>
        /// </code>
        /// </example>
        public void writeFloatBE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid 32 bit float.Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(4);
        /// buf.writeFloatBE(0xcafebabe, 0);
        /// console.log(buf);
        /// buf.writeFloatLE(0xcafebabe, 0);
        /// console.log(buf);
        /// // <Buffer 4f 4a fe bb>
        /// // <Buffer bb fe 4a 4f>
        /// </code>
        /// </example>
        public void writeFloatBE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        public void writeDoubleLE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        public void writeDoubleLE(JsNumber value, JsNumber offset) { }

        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid 64 bit double.Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <param name="noAssert">Optional, Default: false</param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(8);
        /// buf.writeDoubleBE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// buf.writeDoubleLE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// // <Buffer 43 eb d5 b7 dd f9 5f d7>
        /// // <Buffer d7 5f f9 dd b7 d5 eb 43>
        /// </code>
        /// </example>
        public void writeDoubleBE(JsNumber value, JsNumber offset, bool noAssert) { }
        /// <summary>
        /// Writes value to the buffer at the specified offset with specified endian format.
        /// Note, value must be a valid 64 bit double.Set noAssert to true to skip validation of value and offset.
        /// This means that value may be too large for the specific function and offset may be beyond the end of the buffer leading to the values being silently dropped.
        /// This should not be used unless you are certain of correctness. Defaults to false.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset"></param>
        /// <example>
        /// <code>
        /// var buf = new Buffer(8);
        /// buf.writeDoubleBE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// buf.writeDoubleLE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// // <Buffer 43 eb d5 b7 dd f9 5f d7>
        /// // <Buffer d7 5f f9 dd b7 d5 eb 43>
        /// </code>
        /// </example>
        public void writeDoubleBE(JsNumber value, JsNumber offset) { }

        // TODO: is "value" really an "object?" 
        /// <summary>
        /// Fills the buffer with the specified value. If the offset (defaults to 0) and end (defaults to buffer.length) are not given it will fill the entire buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset">Optional</param>
        /// <param name="end">Optional</param>
        /// <example>
        /// <code>
        /// var b = new Buffer(50);
        /// b.fill("h");
        /// </code>
        /// </example>
        public void fill(object value, JsNumber offset, JsNumber end) { }
        /// <summary>
        /// Fills the buffer with the specified value. If the offset (defaults to 0) and end (defaults to buffer.length) are not given it will fill the entire buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="offset">Optional</param>
        /// <example>
        /// <code>
        /// var b = new Buffer(50);
        /// b.fill("h");
        /// </code>
        /// </example>
        public void fill(object value, JsNumber offset) { }
        /// <summary>
        /// Fills the buffer with the specified value. If the offset (defaults to 0) and end (defaults to buffer.length) are not given it will fill the entire buffer.
        /// </summary>
        /// <param name="value"></param>
        /// <example>
        /// <code>
        /// var b = new Buffer(50);
        /// b.fill("h");
        /// </code>
        /// </example>
        public void fill(object value) { }


        // TODO: buffer.INSPECT_MAX_BYTES and Class: SlowBuffer ??










    }
}
