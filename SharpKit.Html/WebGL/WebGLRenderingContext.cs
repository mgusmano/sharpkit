namespace SharpKit.Html
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
    public partial class WebGLRenderingContext
    {

        // WebGLRenderingContext
        public int DEPTH_BUFFER_BIT = 0x00000100;
        public int STENCIL_BUFFER_BIT = 0x00000400;
        public int COLOR_BUFFER_BIT = 0x00004000;
        public int POINTS = 0x0000;
        public int LINES = 0x0001;
        public int LINE_LOOP = 0x0002;
        public int LINE_STRIP = 0x0003;
        public int TRIANGLES = 0x0004;
        public int TRIANGLE_STRIP = 0x0005;
        public int TRIANGLE_FAN = 0x0006;
        public int ZERO = 0;
        public int ONE = 1;
        public int SRC_COLOR = 0x0300;
        public int ONE_MINUS_SRC_COLOR = 0x0301;
        public int SRC_ALPHA = 0x0302;
        public int ONE_MINUS_SRC_ALPHA = 0x0303;
        public int DST_ALPHA = 0x0304;
        public int ONE_MINUS_DST_ALPHA = 0x0305;
        public int DST_COLOR = 0x0306;
        public int ONE_MINUS_DST_COLOR = 0x0307;
        public int SRC_ALPHA_SATURATE = 0x0308;
        public int FUNC_ADD = 0x8006;
        public int BLEND_EQUATION = 0x8009;
        public int BLEND_EQUATION_RGB = 0x8009;
        public int BLEND_EQUATION_ALPHA = 0x883D;
        public int FUNC_SUBTRACT = 0x800A;
        public int FUNC_REVERSE_SUBTRACT = 0x800B;
        public int BLEND_DST_RGB = 0x80C8;
        public int BLEND_SRC_RGB = 0x80C9;
        public int BLEND_DST_ALPHA = 0x80CA;
        public int BLEND_SRC_ALPHA = 0x80CB;
        public int CONSTANT_COLOR = 0x8001;
        public int ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public int CONSTANT_ALPHA = 0x8003;
        public int ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public int BLEND_COLOR = 0x8005;
        public int ARRAY_BUFFER = 0x8892;
        public int ELEMENT_ARRAY_BUFFER = 0x8893;
        public int ARRAY_BUFFER_BINDING = 0x8894;
        public int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public int STREAM_DRAW = 0x88E0;
        public int STATIC_DRAW = 0x88E4;
        public int DYNAMIC_DRAW = 0x88E8;
        public int BUFFER_SIZE = 0x8764;
        public int BUFFER_USAGE = 0x8765;
        public int CURRENT_VERTEX_ATTRIB = 0x8626;
        public int FRONT = 0x0404;
        public int BACK = 0x0405;
        public int FRONT_AND_BACK = 0x0408;
        public int TEXTURE_2D = 0x0DE1;
        public int CULL_FACE = 0x0B44;
        public int BLEND = 0x0BE2;
        public int DITHER = 0x0BD0;
        public int STENCIL_TEST = 0x0B90;
        public int DEPTH_TEST = 0x0B71;
        public int SCISSOR_TEST = 0x0C11;
        public int POLYGON_OFFSET_FILL = 0x8037;
        public int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public int SAMPLE_COVERAGE = 0x80A0;
        public int NO_ERROR = 0;
        public int INVALID_ENUM = 0x0500;
        public int INVALID_VALUE = 0x0501;
        public int INVALID_OPERATION = 0x0502;
        public int OUT_OF_MEMORY = 0x0505;
        public int CW = 0x0900;
        public int CCW = 0x0901;
        public int LINE_WIDTH = 0x0B21;
        public int ALIASED_POINT_SIZE_RANGE = 0x846D;
        public int ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public int CULL_FACE_MODE = 0x0B45;
        public int FRONT_FACE = 0x0B46;
        public int DEPTH_RANGE = 0x0B70;
        public int DEPTH_WRITEMASK = 0x0B72;
        public int DEPTH_CLEAR_VALUE = 0x0B73;
        public int DEPTH_FUNC = 0x0B74;
        public int STENCIL_CLEAR_VALUE = 0x0B91;
        public int STENCIL_FUNC = 0x0B92;
        public int STENCIL_FAIL = 0x0B94;
        public int STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public int STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public int STENCIL_REF = 0x0B97;
        public int STENCIL_VALUE_MASK = 0x0B93;
        public int STENCIL_WRITEMASK = 0x0B98;
        public int STENCIL_BACK_FUNC = 0x8800;
        public int STENCIL_BACK_FAIL = 0x8801;
        public int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public int STENCIL_BACK_REF = 0x8CA3;
        public int STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public int STENCIL_BACK_WRITEMASK = 0x8CA5;
        public int VIEWPORT = 0x0BA2;
        public int SCISSOR_BOX = 0x0C10;
        public int COLOR_CLEAR_VALUE = 0x0C22;
        public int COLOR_WRITEMASK = 0x0C23;
        public int UNPACK_ALIGNMENT = 0x0CF5;
        public int PACK_ALIGNMENT = 0x0D05;
        public int MAX_TEXTURE_SIZE = 0x0D33;
        public int MAX_VIEWPORT_DIMS = 0x0D3A;
        public int SUBPIXEL_BITS = 0x0D50;
        public int RED_BITS = 0x0D52;
        public int GREEN_BITS = 0x0D53;
        public int BLUE_BITS = 0x0D54;
        public int ALPHA_BITS = 0x0D55;
        public int DEPTH_BITS = 0x0D56;
        public int STENCIL_BITS = 0x0D57;
        public int POLYGON_OFFSET_UNITS = 0x2A00;
        public int POLYGON_OFFSET_FACTOR = 0x8038;
        public int TEXTURE_BINDING_2D = 0x8069;
        public int SAMPLE_BUFFERS = 0x80A8;
        public int SAMPLES = 0x80A9;
        public int SAMPLE_COVERAGE_VALUE = 0x80AA;
        public int SAMPLE_COVERAGE_INVERT = 0x80AB;
        public int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public int COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public int DONT_CARE = 0x1100;
        public int FASTEST = 0x1101;
        public int NICEST = 0x1102;
        public int GENERATE_MIPMAP_HINT = 0x8192;
        public int BYTE = 0x1400;
        public int UNSIGNED_BYTE = 0x1401;
        public int SHORT = 0x1402;
        public int UNSIGNED_SHORT = 0x1403;
        public int INT = 0x1404;
        public int UNSIGNED_INT = 0x1405;
        public int FLOAT = 0x1406;
        public int DEPTH_COMPONENT = 0x1902;
        public int ALPHA = 0x1906;
        public int RGB = 0x1907;
        public int RGBA = 0x1908;
        public int LUMINANCE = 0x1909;
        public int LUMINANCE_ALPHA = 0x190A;
        public int UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public int UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public int UNSIGNED_SHORT_5_6_5 = 0x8363;
        public int FRAGMENT_SHADER = 0x8B30;
        public int VERTEX_SHADER = 0x8B31;
        public int MAX_VERTEX_ATTRIBS = 0x8869;
        public int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public int MAX_VARYING_VECTORS = 0x8DFC;
        public int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public int MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public int SHADER_TYPE = 0x8B4F;
        public int DELETE_STATUS = 0x8B80;
        public int LINK_STATUS = 0x8B82;
        public int VALIDATE_STATUS = 0x8B83;
        public int ATTACHED_SHADERS = 0x8B85;
        public int ACTIVE_UNIFORMS = 0x8B86;
        public int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public int ACTIVE_ATTRIBUTES = 0x8B89;
        public int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public int SHADING_LANGUAGE_VERSION = 0x8B8C;
        public int CURRENT_PROGRAM = 0x8B8D;
        public int NEVER = 0x0200;
        public int LESS = 0x0201;
        public int EQUAL = 0x0202;
        public int LEQUAL = 0x0203;
        public int GREATER = 0x0204;
        public int NOTEQUAL = 0x0205;
        public int GEQUAL = 0x0206;
        public int ALWAYS = 0x0207;
        public int KEEP = 0x1E00;
        public int REPLACE = 0x1E01;
        public int INCR = 0x1E02;
        public int DECR = 0x1E03;
        public int INVERT = 0x150A;
        public int INCR_WRAP = 0x8507;
        public int DECR_WRAP = 0x8508;
        public int VENDOR = 0x1F00;
        public int RENDERER = 0x1F01;
        public int VERSION = 0x1F02;
        public int EXTENSIONS = 0x1F03;
        public int NEAREST = 0x2600;
        public int LINEAR = 0x2601;
        public int NEAREST_MIPMAP_NEAREST = 0x2700;
        public int LINEAR_MIPMAP_NEAREST = 0x2701;
        public int NEAREST_MIPMAP_LINEAR = 0x2702;
        public int LINEAR_MIPMAP_LINEAR = 0x2703;
        public int TEXTURE_MAG_FILTER = 0x2800;
        public int TEXTURE_MIN_FILTER = 0x2801;
        public int TEXTURE_WRAP_S = 0x2802;
        public int TEXTURE_WRAP_T = 0x2803;
        public int TEXTURE = 0x1702;
        public int TEXTURE_CUBE_MAP = 0x8513;
        public int TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public int TEXTURE0 = 0x84C0;
        public int TEXTURE1 = 0x84C1;
        public int TEXTURE2 = 0x84C2;
        public int TEXTURE3 = 0x84C3;
        public int TEXTURE4 = 0x84C4;
        public int TEXTURE5 = 0x84C5;
        public int TEXTURE6 = 0x84C6;
        public int TEXTURE7 = 0x84C7;
        public int TEXTURE8 = 0x84C8;
        public int TEXTURE9 = 0x84C9;
        public int TEXTURE10 = 0x84CA;
        public int TEXTURE11 = 0x84CB;
        public int TEXTURE12 = 0x84CC;
        public int TEXTURE13 = 0x84CD;
        public int TEXTURE14 = 0x84CE;
        public int TEXTURE15 = 0x84CF;
        public int TEXTURE16 = 0x84D0;
        public int TEXTURE17 = 0x84D1;
        public int TEXTURE18 = 0x84D2;
        public int TEXTURE19 = 0x84D3;
        public int TEXTURE20 = 0x84D4;
        public int TEXTURE21 = 0x84D5;
        public int TEXTURE22 = 0x84D6;
        public int TEXTURE23 = 0x84D7;
        public int TEXTURE24 = 0x84D8;
        public int TEXTURE25 = 0x84D9;
        public int TEXTURE26 = 0x84DA;
        public int TEXTURE27 = 0x84DB;
        public int TEXTURE28 = 0x84DC;
        public int TEXTURE29 = 0x84DD;
        public int TEXTURE30 = 0x84DE;
        public int TEXTURE31 = 0x84DF;
        public int ACTIVE_TEXTURE = 0x84E0;
        public int REPEAT = 0x2901;
        public int CLAMP_TO_EDGE = 0x812F;
        public int MIRRORED_REPEAT = 0x8370;
        public int FLOAT_VEC2 = 0x8B50;
        public int FLOAT_VEC3 = 0x8B51;
        public int FLOAT_VEC4 = 0x8B52;
        public int INT_VEC2 = 0x8B53;
        public int INT_VEC3 = 0x8B54;
        public int INT_VEC4 = 0x8B55;
        public int BOOL = 0x8B56;
        public int BOOL_VEC2 = 0x8B57;
        public int BOOL_VEC3 = 0x8B58;
        public int BOOL_VEC4 = 0x8B59;
        public int FLOAT_MAT2 = 0x8B5A;
        public int FLOAT_MAT3 = 0x8B5B;
        public int FLOAT_MAT4 = 0x8B5C;
        public int SAMPLER_2D = 0x8B5E;
        public int SAMPLER_CUBE = 0x8B60;
        public int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public int COMPILE_STATUS = 0x8B81;
        public int INFO_LOG_LENGTH = 0x8B84;
        public int SHADER_SOURCE_LENGTH = 0x8B88;
        public int SHADER_COMPILER = 0x8DFA;
        public int LOW_FLOAT = 0x8DF0;
        public int MEDIUM_FLOAT = 0x8DF1;
        public int HIGH_FLOAT = 0x8DF2;
        public int LOW_INT = 0x8DF3;
        public int MEDIUM_INT = 0x8DF4;
        public int HIGH_INT = 0x8DF5;
        public int FRAMEBUFFER = 0x8D40;
        public int RENDERBUFFER = 0x8D41;
        public int RGBA4 = 0x8056;
        public int RGB5_A1 = 0x8057;
        public int RGB565 = 0x8D62;
        public int DEPTH_COMPONENT16 = 0x81A5;
        public int STENCIL_INDEX = 0x1901;
        public int STENCIL_INDEX8 = 0x8D48;
        public int DEPTH_STENCIL = 0x84F9;
        public int RENDERBUFFER_WIDTH = 0x8D42;
        public int RENDERBUFFER_HEIGHT = 0x8D43;
        public int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public int RENDERBUFFER_RED_SIZE = 0x8D50;
        public int RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public int RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public int RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public int RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public int RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public int COLOR_ATTACHMENT0 = 0x8CE0;
        public int DEPTH_ATTACHMENT = 0x8D00;
        public int STENCIL_ATTACHMENT = 0x8D20;
        public int DEPTH_STENCIL_ATTACHMENT = 0x821A;
        public int NONE = 0;
        public int FRAMEBUFFER_COMPLETE = 0x8CD5;
        public int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public int FRAMEBUFFER_BINDING = 0x8CA6;
        public int RENDERBUFFER_BINDING = 0x8CA7;
        public int MAX_RENDERBUFFER_SIZE = 0x84E8;
        public int INVALID_FRAMEBUFFER_OPERATION = 0x0506;
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