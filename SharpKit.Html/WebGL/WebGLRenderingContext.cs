namespace SharpKit.Html
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "WebGLRenderingContext")]
    public partial class WebGLRenderingContext
    {

        // WebGLRenderingContext
        public const int DEPTH_BUFFER_BIT = 0x00000100;
        public const int STENCIL_BUFFER_BIT = 0x00000400;
        public const int COLOR_BUFFER_BIT = 0x00004000;
        public const int POINTS = 0x0000;
        public const int LINES = 0x0001;
        public const int LINE_LOOP = 0x0002;
        public const int LINE_STRIP = 0x0003;
        public const int TRIANGLES = 0x0004;
        public const int TRIANGLE_STRIP = 0x0005;
        public const int TRIANGLE_FAN = 0x0006;
        public const int ZERO = 0;
        public const int ONE = 1;
        public const int SRC_COLOR = 0x0300;
        public const int ONE_MINUS_SRC_COLOR = 0x0301;
        public const int SRC_ALPHA = 0x0302;
        public const int ONE_MINUS_SRC_ALPHA = 0x0303;
        public const int DST_ALPHA = 0x0304;
        public const int ONE_MINUS_DST_ALPHA = 0x0305;
        public const int DST_COLOR = 0x0306;
        public const int ONE_MINUS_DST_COLOR = 0x0307;
        public const int SRC_ALPHA_SATURATE = 0x0308;
        public const int FUNC_ADD = 0x8006;
        public const int BLEND_EQUATION = 0x8009;
        public const int BLEND_EQUATION_RGB = 0x8009;
        public const int BLEND_EQUATION_ALPHA = 0x883D;
        public const int FUNC_SUBTRACT = 0x800A;
        public const int FUNC_REVERSE_SUBTRACT = 0x800B;
        public const int BLEND_DST_RGB = 0x80C8;
        public const int BLEND_SRC_RGB = 0x80C9;
        public const int BLEND_DST_ALPHA = 0x80CA;
        public const int BLEND_SRC_ALPHA = 0x80CB;
        public const int CONSTANT_COLOR = 0x8001;
        public const int ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const int CONSTANT_ALPHA = 0x8003;
        public const int ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const int BLEND_COLOR = 0x8005;
        public const int ARRAY_BUFFER = 0x8892;
        public const int ELEMENT_ARRAY_BUFFER = 0x8893;
        public const int ARRAY_BUFFER_BINDING = 0x8894;
        public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const int STREAM_DRAW = 0x88E0;
        public const int STATIC_DRAW = 0x88E4;
        public const int DYNAMIC_DRAW = 0x88E8;
        public const int BUFFER_SIZE = 0x8764;
        public const int BUFFER_USAGE = 0x8765;
        public const int CURRENT_VERTEX_ATTRIB = 0x8626;
        public const int FRONT = 0x0404;
        public const int BACK = 0x0405;
        public const int FRONT_AND_BACK = 0x0408;
        public const int TEXTURE_2D = 0x0DE1;
        public const int CULL_FACE = 0x0B44;
        public const int BLEND = 0x0BE2;
        public const int DITHER = 0x0BD0;
        public const int STENCIL_TEST = 0x0B90;
        public const int DEPTH_TEST = 0x0B71;
        public const int SCISSOR_TEST = 0x0C11;
        public const int POLYGON_OFFSET_FILL = 0x8037;
        public const int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const int SAMPLE_COVERAGE = 0x80A0;
        public const int NO_ERROR = 0;
        public const int INVALID_ENUM = 0x0500;
        public const int INVALID_VALUE = 0x0501;
        public const int INVALID_OPERATION = 0x0502;
        public const int OUT_OF_MEMORY = 0x0505;
        public const int CW = 0x0900;
        public const int CCW = 0x0901;
        public const int LINE_WIDTH = 0x0B21;
        public const int ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const int ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const int CULL_FACE_MODE = 0x0B45;
        public const int FRONT_FACE = 0x0B46;
        public const int DEPTH_RANGE = 0x0B70;
        public const int DEPTH_WRITEMASK = 0x0B72;
        public const int DEPTH_CLEAR_VALUE = 0x0B73;
        public const int DEPTH_FUNC = 0x0B74;
        public const int STENCIL_CLEAR_VALUE = 0x0B91;
        public const int STENCIL_FUNC = 0x0B92;
        public const int STENCIL_FAIL = 0x0B94;
        public const int STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const int STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const int STENCIL_REF = 0x0B97;
        public const int STENCIL_VALUE_MASK = 0x0B93;
        public const int STENCIL_WRITEMASK = 0x0B98;
        public const int STENCIL_BACK_FUNC = 0x8800;
        public const int STENCIL_BACK_FAIL = 0x8801;
        public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const int STENCIL_BACK_REF = 0x8CA3;
        public const int STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const int STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const int VIEWPORT = 0x0BA2;
        public const int SCISSOR_BOX = 0x0C10;
        public const int COLOR_CLEAR_VALUE = 0x0C22;
        public const int COLOR_WRITEMASK = 0x0C23;
        public const int UNPACK_ALIGNMENT = 0x0CF5;
        public const int PACK_ALIGNMENT = 0x0D05;
        public const int MAX_TEXTURE_SIZE = 0x0D33;
        public const int MAX_VIEWPORT_DIMS = 0x0D3A;
        public const int SUBPIXEL_BITS = 0x0D50;
        public const int RED_BITS = 0x0D52;
        public const int GREEN_BITS = 0x0D53;
        public const int BLUE_BITS = 0x0D54;
        public const int ALPHA_BITS = 0x0D55;
        public const int DEPTH_BITS = 0x0D56;
        public const int STENCIL_BITS = 0x0D57;
        public const int POLYGON_OFFSET_UNITS = 0x2A00;
        public const int POLYGON_OFFSET_FACTOR = 0x8038;
        public const int TEXTURE_BINDING_2D = 0x8069;
        public const int SAMPLE_BUFFERS = 0x80A8;
        public const int SAMPLES = 0x80A9;
        public const int SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const int SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const int COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const int DONT_CARE = 0x1100;
        public const int FASTEST = 0x1101;
        public const int NICEST = 0x1102;
        public const int GENERATE_MIPMAP_HINT = 0x8192;
        public const int BYTE = 0x1400;
        public const int UNSIGNED_BYTE = 0x1401;
        public const int SHORT = 0x1402;
        public const int UNSIGNED_SHORT = 0x1403;
        public const int INT = 0x1404;
        public const int UNSIGNED_INT = 0x1405;
        public const int FLOAT = 0x1406;
        public const int DEPTH_COMPONENT = 0x1902;
        public const int ALPHA = 0x1906;
        public const int RGB = 0x1907;
        public const int RGBA = 0x1908;
        public const int LUMINANCE = 0x1909;
        public const int LUMINANCE_ALPHA = 0x190A;
        public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const int UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const int FRAGMENT_SHADER = 0x8B30;
        public const int VERTEX_SHADER = 0x8B31;
        public const int MAX_VERTEX_ATTRIBS = 0x8869;
        public const int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const int MAX_VARYING_VECTORS = 0x8DFC;
        public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const int SHADER_TYPE = 0x8B4F;
        public const int DELETE_STATUS = 0x8B80;
        public const int LINK_STATUS = 0x8B82;
        public const int VALIDATE_STATUS = 0x8B83;
        public const int ATTACHED_SHADERS = 0x8B85;
        public const int ACTIVE_UNIFORMS = 0x8B86;
        public const int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const int ACTIVE_ATTRIBUTES = 0x8B89;
        public const int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const int SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const int CURRENT_PROGRAM = 0x8B8D;
        public const int NEVER = 0x0200;
        public const int LESS = 0x0201;
        public const int EQUAL = 0x0202;
        public const int LEQUAL = 0x0203;
        public const int GREATER = 0x0204;
        public const int NOTEQUAL = 0x0205;
        public const int GEQUAL = 0x0206;
        public const int ALWAYS = 0x0207;
        public const int KEEP = 0x1E00;
        public const int REPLACE = 0x1E01;
        public const int INCR = 0x1E02;
        public const int DECR = 0x1E03;
        public const int INVERT = 0x150A;
        public const int INCR_WRAP = 0x8507;
        public const int DECR_WRAP = 0x8508;
        public const int VENDOR = 0x1F00;
        public const int RENDERER = 0x1F01;
        public const int VERSION = 0x1F02;
        public const int EXTENSIONS = 0x1F03;
        public const int NEAREST = 0x2600;
        public const int LINEAR = 0x2601;
        public const int NEAREST_MIPMAP_NEAREST = 0x2700;
        public const int LINEAR_MIPMAP_NEAREST = 0x2701;
        public const int NEAREST_MIPMAP_LINEAR = 0x2702;
        public const int LINEAR_MIPMAP_LINEAR = 0x2703;
        public const int TEXTURE_MAG_FILTER = 0x2800;
        public const int TEXTURE_MIN_FILTER = 0x2801;
        public const int TEXTURE_WRAP_S = 0x2802;
        public const int TEXTURE_WRAP_T = 0x2803;
        public const int TEXTURE = 0x1702;
        public const int TEXTURE_CUBE_MAP = 0x8513;
        public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const int TEXTURE0 = 0x84C0;
        public const int TEXTURE1 = 0x84C1;
        public const int TEXTURE2 = 0x84C2;
        public const int TEXTURE3 = 0x84C3;
        public const int TEXTURE4 = 0x84C4;
        public const int TEXTURE5 = 0x84C5;
        public const int TEXTURE6 = 0x84C6;
        public const int TEXTURE7 = 0x84C7;
        public const int TEXTURE8 = 0x84C8;
        public const int TEXTURE9 = 0x84C9;
        public const int TEXTURE10 = 0x84CA;
        public const int TEXTURE11 = 0x84CB;
        public const int TEXTURE12 = 0x84CC;
        public const int TEXTURE13 = 0x84CD;
        public const int TEXTURE14 = 0x84CE;
        public const int TEXTURE15 = 0x84CF;
        public const int TEXTURE16 = 0x84D0;
        public const int TEXTURE17 = 0x84D1;
        public const int TEXTURE18 = 0x84D2;
        public const int TEXTURE19 = 0x84D3;
        public const int TEXTURE20 = 0x84D4;
        public const int TEXTURE21 = 0x84D5;
        public const int TEXTURE22 = 0x84D6;
        public const int TEXTURE23 = 0x84D7;
        public const int TEXTURE24 = 0x84D8;
        public const int TEXTURE25 = 0x84D9;
        public const int TEXTURE26 = 0x84DA;
        public const int TEXTURE27 = 0x84DB;
        public const int TEXTURE28 = 0x84DC;
        public const int TEXTURE29 = 0x84DD;
        public const int TEXTURE30 = 0x84DE;
        public const int TEXTURE31 = 0x84DF;
        public const int ACTIVE_TEXTURE = 0x84E0;
        public const int REPEAT = 0x2901;
        public const int CLAMP_TO_EDGE = 0x812F;
        public const int MIRRORED_REPEAT = 0x8370;
        public const int FLOAT_VEC2 = 0x8B50;
        public const int FLOAT_VEC3 = 0x8B51;
        public const int FLOAT_VEC4 = 0x8B52;
        public const int INT_VEC2 = 0x8B53;
        public const int INT_VEC3 = 0x8B54;
        public const int INT_VEC4 = 0x8B55;
        public const int BOOL = 0x8B56;
        public const int BOOL_VEC2 = 0x8B57;
        public const int BOOL_VEC3 = 0x8B58;
        public const int BOOL_VEC4 = 0x8B59;
        public const int FLOAT_MAT2 = 0x8B5A;
        public const int FLOAT_MAT3 = 0x8B5B;
        public const int FLOAT_MAT4 = 0x8B5C;
        public const int SAMPLER_2D = 0x8B5E;
        public const int SAMPLER_CUBE = 0x8B60;
        public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const int COMPILE_STATUS = 0x8B81;
        public const int INFO_LOG_LENGTH = 0x8B84;
        public const int SHADER_SOURCE_LENGTH = 0x8B88;
        public const int SHADER_COMPILER = 0x8DFA;
        public const int LOW_FLOAT = 0x8DF0;
        public const int MEDIUM_FLOAT = 0x8DF1;
        public const int HIGH_FLOAT = 0x8DF2;
        public const int LOW_INT = 0x8DF3;
        public const int MEDIUM_INT = 0x8DF4;
        public const int HIGH_INT = 0x8DF5;
        public const int FRAMEBUFFER = 0x8D40;
        public const int RENDERBUFFER = 0x8D41;
        public const int RGBA4 = 0x8056;
        public const int RGB5_A1 = 0x8057;
        public const int RGB565 = 0x8D62;
        public const int DEPTH_COMPONENT16 = 0x81A5;
        public const int STENCIL_INDEX = 0x1901;
        public const int STENCIL_INDEX8 = 0x8D48;
        public const int DEPTH_STENCIL = 0x84F9;
        public const int RENDERBUFFER_WIDTH = 0x8D42;
        public const int RENDERBUFFER_HEIGHT = 0x8D43;
        public const int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const int RENDERBUFFER_RED_SIZE = 0x8D50;
        public const int RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const int RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const int RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const int RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const int RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const int COLOR_ATTACHMENT0 = 0x8CE0;
        public const int DEPTH_ATTACHMENT = 0x8D00;
        public const int STENCIL_ATTACHMENT = 0x8D20;
        public const int DEPTH_STENCIL_ATTACHMENT = 0x821A;
        public const int NONE = 0;
        public const int FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public const int FRAMEBUFFER_BINDING = 0x8CA6;
        public const int RENDERBUFFER_BINDING = 0x8CA7;
        public const int MAX_RENDERBUFFER_SIZE = 0x84E8;
        public const int INVALID_FRAMEBUFFER_OPERATION = 0x0506;
        public HtmlCanvasElement canvas { get; private set; }
        public WebGLContextAttributes contextAttributes { get; private set; }
        public bool isContextLost() { return default(bool); }
        public bool resetContext() { return default(bool); }
        public void activeTexture(int texture) { }
        public void attachShader(WebGLProgram program, WebGLShader shader) { }
        public void bindAttribLocation(WebGLProgram program, int index, string name) { }
        public void bindBuffer(int target, WebGLBuffer buffer) { }
        public void bindFramebuffer(int target, WebGLFramebuffer framebuffer) { }
        public void bindRenderbuffer(int target, WebGLRenderbuffer renderbuffer) { }
        public void bindTexture(int target, WebGLTexture texture) { }
        public void blendColor(float red, float green, float blue, float alpha) { }
        public void blendEquation(int mode) { }
        public void blendEquationSeparate(int modeRGB, int modeAlpha) { }
        public void blendFunc(int sfactor, int dfactor) { }
        public void blendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha) { }
        public void bufferData(int target, int size, int usage) { }
        public void bufferData(int target, WebGLArray data, int usage) { }
        public void bufferData(int target, WebGLArrayBuffer data, int usage) { }
        public void bufferSubData(int target, int offset, WebGLArray data) { }
        public void bufferSubData(int target, int offset, WebGLArrayBuffer data) { }
        public int checkFramebufferStatus(int target) { return default(int); }
        public void clear(int mask) { }
        public void clearColor(float red, float green, float blue, float alpha) { }
        public void clearDepth(float depth) { }
        public void clearStencil(int s) { }
        public void colorMask(bool red, bool green, bool blue, bool alpha) { }
        public void compileShader(WebGLShader shader) { }
        public void copyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border) { }
        public void copyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height) { }
        public WebGLBuffer createBuffer() { return default(WebGLBuffer); }
        public WebGLFramebuffer createFramebuffer() { return default(WebGLFramebuffer); }
        public WebGLProgram createProgram() { return default(WebGLProgram); }
        public WebGLRenderbuffer createRenderbuffer() { return default(WebGLRenderbuffer); }
        public WebGLShader createShader(int type) { return default(WebGLShader); }
        public WebGLTexture createTexture() { return default(WebGLTexture); }
        public void cullFace(int mode) { }
        public void deleteBuffer(WebGLBuffer buffer) { }
        public void deleteFramebuffer(WebGLFramebuffer framebuffer) { }
        public void deleteProgram(WebGLProgram program) { }
        public void deleteRenderbuffer(WebGLRenderbuffer renderbuffer) { }
        public void deleteShader(WebGLShader shader) { }
        public void deleteTexture(WebGLTexture texture) { }
        public void depthFunc(int func) { }
        public void depthMask(bool flag) { }
        public void depthRange(float zNear, float zFar) { }
        public void detachShader(WebGLProgram program, WebGLShader shader) { }
        public void disable(int cap) { }
        public void disableVertexAttribArray(int index) { }
        public void drawArrays(int mode, int first, int count) { }
        public void drawElements(int mode, int count, int type, int offset) { }
        public void enable(int cap) { }
        public void enableVertexAttribArray(int index) { }
        public void finish() { }
        public void flush() { }
        public void framebufferRenderbuffer(int target, int attachment, int renderbuffertarget, WebGLRenderbuffer renderbuffer) { }
        public void framebufferTexture2D(int target, int attachment, int textarget, WebGLTexture texture, int level) { }
        public void frontFace(int mode) { }
        public void generateMipmap(int target) { }
        public WebGLActiveInfo getActiveAttrib(int program, int index) { return default(WebGLActiveInfo); }
        public WebGLActiveInfo getActiveUniform(int program, int index) { return default(WebGLActiveInfo); }
        public WebGLObjectArray getAttachedShaders(int program) { return default(WebGLObjectArray); }
        public int getAttribLocation(WebGLProgram program, string name) { return default(int); }
        public object getParameter(int pname) { return default(object); }
        public object getBufferParameter(int target, int pname) { return default(object); }
        public int error { get; private set; }
        public object getFramebufferAttachmentParameter(int target, int attachment, int pname) { return default(object); }
        public object getProgramParameter(WebGLProgram program, int pname) { return default(object); }
        public JsString getProgramInfoLog(WebGLProgram program) { return default(JsString); }
        public object getRenderbufferParameter(int target, int pname) { return default(object); }
        public object getShaderParameter(WebGLShader shader, int pname) { return default(object); }
        public JsString getShaderInfoLog(WebGLShader shader) { return default(JsString); }
        public JsString getShaderSource(WebGLShader shader) { return default(JsString); }
        public JsString getString(int name) { return default(JsString); }
        public object getTexParameter(int target, int pname) { return default(object); }
        public object getUniform(WebGLProgram program, WebGLUniformLocation location) { return default(object); }
        public WebGLUniformLocation getUniformLocation(WebGLProgram program, string name) { return default(WebGLUniformLocation); }
        public object getVertexAttrib(int index, int pname) { return default(object); }
        public int getVertexAttribOffset(int index, int pname) { return default(int); }
        public void hint(int target, int mode) { }
        public bool isBuffer(WebGLBuffer buffer) { return default(bool); }
        public bool isEnabled(int cap) { return default(bool); }
        public bool isFramebuffer(WebGLFramebuffer framebuffer) { return default(bool); }
        public bool isProgram(WebGLProgram program) { return default(bool); }
        public bool isRenderbuffer(WebGLRenderbuffer renderbuffer) { return default(bool); }
        public bool isShader(WebGLShader shader) { return default(bool); }
        public bool isTexture(WebGLTexture texture) { return default(bool); }
        public void lineWidth(float width) { }
        public void linkProgram(WebGLProgram program) { }
        public void pixelStorei(int pname, int param) { }
        public void polygonOffset(float factor, float units) { }
        public WebGLArray readPixels(int x, int y, int width, int height, int format, int type) { return default(WebGLArray); }
        public void renderbufferStorage(int target, int internalformat, int width, int height) { }
        public void sampleCoverage(float value, bool invert) { }
        public void scissor(int x, int y, int width, int height) { }
        public void shaderSource(WebGLShader shader, string source) { }
        public void stencilFunc(int func, int @ref, int mask) { }
        public void stencilFuncSeparate(int face, int func, int @ref, int mask) { }
        public void stencilMask(int mask) { }
        public void stencilMaskSeparate(int face, int mask) { }
        public void stencilOp(int fail, int zfail, int zpass) { }
        public void stencilOpSeparate(int face, int fail, int zfail, int zpass) { }
        public void texImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, WebGLArray pixels) { }
        public void texImage2D(int target, int level, ImageData pixels) { }
        public void texImage2D(int target, int level, ImageData pixels, bool flipY) { }
        public void texImage2D(int target, int level, ImageData pixels, bool flipY, bool asPremultipliedAlpha) { }
        public void texImage2D(int target, int level, HtmlImageElement image) { }
        public void texImage2D(int target, int level, HtmlImageElement image, bool flipY) { }
        public void texImage2D(int target, int level, HtmlImageElement image, bool flipY, bool asPremultipliedAlpha) { }
        public void texImage2D(int target, int level, HtmlCanvasElement canvas) { }
        public void texImage2D(int target, int level, HtmlCanvasElement canvas, bool flipY) { }
        public void texImage2D(int target, int level, HtmlCanvasElement canvas, bool flipY, bool asPremultipliedAlpha) { }
        public void texImage2D(int target, int level, HtmlVideoElement video) { }
        public void texImage2D(int target, int level, HtmlVideoElement video, bool flipY) { }
        public void texImage2D(int target, int level, HtmlVideoElement video, bool flipY, bool asPremultipliedAlpha) { }
        public void texParameterf(int target, int pname, float param) { }
        public void texParameteri(int target, int pname, int param) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, WebGLArray pixels) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, ImageData pixels) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, ImageData pixels, bool flipY) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, ImageData pixels, bool flipY, bool asPremultipliedAlpha) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlImageElement image) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlImageElement image, bool flipY) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlImageElement image, bool flipY, bool asPremultipliedAlpha) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlCanvasElement canvas) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlCanvasElement canvas, bool flipY) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlCanvasElement canvas, bool flipY, bool asPremultipliedAlpha) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlVideoElement video) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlVideoElement video, bool flipY) { }
        public void texSubImage2D(int target, int level, int xoffset, int yoffset, HtmlVideoElement video, bool flipY, bool asPremultipliedAlpha) { }
        public void uniform1f(WebGLUniformLocation location, float x) { }
        public void uniform1fv(WebGLUniformLocation location, WebGLFloatArray v) { }
        public void uniform1fv(WebGLUniformLocation location, float[] v) { }
        public void uniform1i(WebGLUniformLocation location, int x) { }
        public void uniform1iv(WebGLUniformLocation location, WebGLIntArray v) { }
        public void uniform1iv(WebGLUniformLocation location, int[] v) { }
        public void uniform2f(WebGLUniformLocation location, float x, float y) { }
        public void uniform2fv(WebGLUniformLocation location, WebGLFloatArray v) { }
        public void uniform2fv(WebGLUniformLocation location, float[] v) { }
        public void uniform2i(WebGLUniformLocation location, int x, int y) { }
        public void uniform2iv(WebGLUniformLocation location, WebGLIntArray v) { }
        public void uniform2iv(WebGLUniformLocation location, int[] v) { }
        public void uniform3f(WebGLUniformLocation location, float x, float y, float z) { }
        public void uniform3fv(WebGLUniformLocation location, WebGLFloatArray v) { }
        public void uniform3fv(WebGLUniformLocation location, float[] v) { }
        public void uniform3i(WebGLUniformLocation location, int x, int y, int z) { }
        public void uniform3iv(WebGLUniformLocation location, WebGLIntArray v) { }
        public void uniform3iv(WebGLUniformLocation location, int[] v) { }
        public void uniform4f(WebGLUniformLocation location, float x, float y, float z, float w) { }
        public void uniform4fv(WebGLUniformLocation location, WebGLFloatArray v) { }
        public void uniform4fv(WebGLUniformLocation location, float[] v) { }
        public void uniform4i(WebGLUniformLocation location, int x, int y, int z, int w) { }
        public void uniform4iv(WebGLUniformLocation location, WebGLIntArray v) { }
        public void uniform4iv(WebGLUniformLocation location, int[] v) { }
        public void uniformMatrix2fv(WebGLUniformLocation location, bool transpose, WebGLFloatArray value) { }
        public void uniformMatrix2fv(WebGLUniformLocation location, bool transpose, float[] value) { }
        public void uniformMatrix3fv(WebGLUniformLocation location, bool transpose, WebGLFloatArray value) { }
        public void uniformMatrix3fv(WebGLUniformLocation location, bool transpose, float[] value) { }
        public void uniformMatrix4fv(WebGLUniformLocation location, bool transpose, WebGLFloatArray value) { }
        public void uniformMatrix4fv(WebGLUniformLocation location, bool transpose, float[] value) { }
        public void useProgram(WebGLProgram program) { }
        public void validateProgram(WebGLProgram program) { }
        public void vertexAttrib1f(int indx, float x) { }
        public void vertexAttrib1fv(int indx, WebGLFloatArray values) { }
        public void vertexAttrib1fv(int indx, float[] values) { }
        public void vertexAttrib2f(int indx, float x, float y) { }
        public void vertexAttrib2fv(int indx, WebGLFloatArray values) { }
        public void vertexAttrib2fv(int indx, float[] values) { }
        public void vertexAttrib3f(int indx, float x, float y, float z) { }
        public void vertexAttrib3fv(int indx, WebGLFloatArray values) { }
        public void vertexAttrib3fv(int indx, float[] values) { }
        public void vertexAttrib4f(int indx, float x, float y, float z, float w) { }
        public void vertexAttrib4fv(int indx, WebGLFloatArray values) { }
        public void vertexAttrib4fv(int indx, float[] values) { }
        public void vertexAttribPointer(int indx, int size, int type, bool normalized, int stride, int offset) { }
        public void viewport(int x, int y, int width, int height) { }
    }

}