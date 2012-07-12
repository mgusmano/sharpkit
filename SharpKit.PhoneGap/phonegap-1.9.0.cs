using System;
using SharpKit.JavaScript;
using SharpKit.Html4;




namespace SharpKit.PhoneGap
{
    /// <summary>
    /// Captures device motion in the x, y, and z direction.
    /// </summary>
    public class Accelerometer
    {
        public object getCurrentAcceleration(JsAction<Acceleration> onSuccess, JsAction onError) { return null; }

    }
    // TODO: FINISH Accelerometer

    public class AccelerometerOptions
    {
        public JsNumber frequency { get; set; }
    }

    /// <summary>
    /// Contains Accelerometer data captured at a specific point in time.
    /// </summary>
    public class Acceleration
    {
        /// <summary>
        /// Amount of acceleration on the x-axis. (in m/s^2) (Number) 
        /// </summary>
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber z { get; set; }
        public JsNumber timestamp { get; set; }
    }
    /// <summary>
    /// The camera object provides access to the device's default camera application.
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Takes a photo using the camera or retrieves a photo from the device's album.
        /// The image is returned as a base64 encoded String or as the URI of an image file.
        /// </summary>
        /// <param name="cameraSuccess">onSuccess callback function that provides the image data.</param>
        /// <param name="cameraError">onError callback function that provides an error message.</param>
        /// <param name="cameraOptions">Optional parameters to customize the camera settings.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// navigator.camera.getPicture(onSuccess, onFail, { quality: 50,
        ///     destinationType: Camera.DestinationType.DATA_URL
        /// }); 
        /// function onSuccess(imageData) {
        ///     var image = document.getElementById('myImage');
        ///     image.src = "data:image/jpeg;base64," + imageData;
        /// }
        /// function onFail(message) {
        ///     alert('Failed because: ' + message);
        /// }
        /// </code>
        /// </example>
        public JsString getPicture(CameraSuccess cameraSuccess, JsAction cameraError, CameraOptions cameraOptions) { return null; }
        /// <summary>
        /// Takes a photo using the camera or retrieves a photo from the device's album.
        /// The image is returned as a base64 encoded String or as the URI of an image file.
        /// </summary>
        /// <param name="cameraSuccess">onSuccess callback function that provides the image data.</param>
        /// <param name="cameraError">onError callback function that provides an error message.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// navigator.camera.getPicture(onSuccess, onFail, { quality: 50,
        /// destinationType: Camera.DestinationType.DATA_URL
        /// }); 
        /// function onSuccess(imageData) {
        /// var image = document.getElementById('myImage');
        /// image.src = "data:image/jpeg;base64," + imageData;
        /// }
        /// function onFail(message) {
        /// alert('Failed because: ' + message);
        /// }
        /// </code>
        /// </example>
        public object getPicture(JsAction cameraSuccess, JsAction cameraError) { return null; }
        /// <summary>
        /// Cleans up the image files that were taken by the camera, that were stored in a temporary storage location
        /// </summary>
        /// <param name="cameraSuccess">onSuccess callback function that provides the image data.</param>
        /// <param name="cameraError">onError callback function that provides an error message.</param>
        /// <example>
        /// usage
        /// <code>
        /// navigator.camera.cleanup(onSuccess, onFail); 
        /// function onSuccess() {
        /// console.log("Camera cleanup success.")
        /// }
        /// function onFail(message) {
        /// alert('Failed because: ' + message);
        /// }
        /// </code>
        /// </example>
        public void cleanup(JsAction cameraSuccess, JsAction cameraError) { }
    }

    public delegate void CameraSuccess(object imageData);
    /// <summary>
    /// Optional parameters to customize the camera settings.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// { quality : 75, 
    /// destinationType : Camera.DestinationType.DATA_URL, 
    /// sourceType : Camera.PictureSourceType.CAMERA, 
    /// allowEdit : true,
    /// encodingType: Camera.EncodingType.JPEG,
    /// targetWidth: 100,
    /// targetHeight: 100,
    /// popoverOptions: CameraPopoverOptions,
    /// saveToPhotoAlbum: false };
    /// </code>
    /// </example>
    public class CameraOptions
    {
        /// <summary>
        /// Quality of saved image. Range is [0, 100]
        /// </summary>
        public JsNumber quality { get; set; }
        /// <summary>
        ///  Choose the format of the return value. Defined in navigator.camera.DestinationType
        /// </summary>
        public CameraDestinationType destinationType { get; set; }
        /// <summary>
        /// Set the source of the picture. Defined in nagivator.camera.PictureSourceType (Number)
        /// </summary>
        public CameraPictureSourceType sourceType { get; set; }
        /// <summary>
        /// Allow simple editing of image before selection
        /// </summary>
        public bool allowEdit { get; set; }
        /// <summary>
        /// Choose the encoding of the returned image file. Defined in navigator.camera.EncodingType
        /// </summary>
        public CameraEncodingType encodingType { get; set; }
        /// <summary>
        /// Width in pixels to scale image. Must be used with targetHeight. Aspect ratio is maintained.
        /// </summary>
        public JsNumber targetWidth { get; set; }
        /// <summary>
        /// Height in pixels to scale image. Must be used with targetWidth. Aspect ratio is maintained.
        /// </summary>
        public JsNumber targetHeight { get; set; }
        /// <summary>
        /// Set the type of media to select from. Only works when PictureSourceType is PHOTOLIBRARY or SAVEDPHOTOALBUM. Defined in nagivator.camera.MediaType
        /// </summary>
        public CameraMediaType mediaType { get; set; }
        /// <summary>
        /// Rotate the image to correct for the orientation of the device during capture
        /// </summary>
        public bool correctOrientation { get; set; }
        /// <summary>
        /// Save the image to the photo album on the device after capture
        /// </summary>
        public bool saveToPhotoAlbum { get; set; }
        /// <summary>
        /// iOS only options to specify popover location in iPad. Defined in CameraPopoverOptions
        /// </summary>
        public CameraPopoverOptions popoverOptions { get; set; }
    }

    /// <summary>
    /// Choose the format of the return value. Defined in navigator.camera.DestinationType (Number)
    /// </summary>
    public enum CameraDestinationType
    {
        /// <summary>
        ///  Return image as base64 encoded string
        /// </summary>
        DATA_URL = 0,
        /// <summary>
        /// Return image file URI
        /// </summary>
        FILE_URI = 1,
    }

    public enum CameraPictureSourceType
    {
        PHOTOLIBRARY = 0,
        CAMERA = 1,
        SAVEDPHOTOALBUM = 2
    }

    public enum CameraEncodingType
    {
        /// <summary>
        /// Return JPEG encoded image
        /// </summary>
        JPEG = 0,
        /// <summary>
        /// Return PNG encoded image
        /// </summary>
        PNG = 1,
    }

    public enum CameraMediaType
    {
        /// <summary>
        /// allow selection of still pictures only. DEFAULT. Will return format specified via DestinationType
        /// </summary>
        PICTURE = 0,
        /// <summary>
        /// allow selection of video only, WILL ALWAYS RETURN FILE_URI
        /// </summary>
        VIDEO = 1,
        /// <summary>
        /// allow selection from all media types
        /// </summary>
        ALLMEDIA = 2,
    }


    /// <summary>
    /// Parameters only used by iOS to specify the anchor element location and arrow direction
    /// of popover used on iPad when selecting images from the library or album.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// { x : 0, 
    /// y :  32,
    /// width : 320,
    /// height : 480,
    /// arrowDir : Camera.PopoverArrowDirection.ARROW_ANY
    /// };
    /// </code>
    /// </example>
    public class CameraPopoverOptions
    {
        /// <summary>
        ///  x pixel coordinate of element on the screen to anchor popover onto.
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y pixel coordinate of element on the screen to anchor popover onto.
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// width, in pixels, of the element on the screen to anchor popover onto
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        ///  height, in pixels, of the element on the screen to anchor popover onto
        /// </summary>
        public CameraPopoverArrowDirection height { get; set; }
        /// <summary>
        /// Direction the arrow on the popover should point. Defined in Camera.PopoverArrowDirection
        /// </summary>
        public JsNumber arrowDir { get; set; }
    }

    public enum CameraPopoverArrowDirection
    {
        /// <summary>
        /// matches iOS UIPopoverArrowDirection constants
        /// </summary>
        ARROW_UP = 1,
        ARROW_DOWN = 2,
        ARROW_LEFT = 4,
        ARROW_RIGHT = 8,
        ARROW_ANY = 15
    }

    /// <summary>
    /// Provides access to the audio, image, and video capture capabilities of the device.
    /// </summary>
    public class Capture
    {
        /// <summary>
        /// Start the audio recorder application and return information about captured audio clip file(s).
        /// </summary>
        /// <param name="captureSuccess">This method starts an asynchronous operation to capture audio recordings using the device's default audio recording application.
        /// The operation allows the device user to capture multiple recordings in a single session.</param>
        /// <param name="captureError">The capture operation ends when either the user exits the audio recording application,
        /// or the maximum number of recordings, specified by the limit parameter in CaptureAudioOptions, has been reached.
        /// If no value is provided for the limit parameter, a default value of one (1) is used, and the capture operation will terminate after the user records a single audio clip.</param>
        /// <param name="options">When the capture operation is finished, it will invoke the CaptureCB callback with an array of MediaFile objects describing each captured audio clip file.
        /// If the operation is terminated by the user before an audio clip is captured,
        /// the CaptureErrorCB callback will be invoked with a CaptureError object with the CaptureError.CAPTURE_NO_MEDIA_FILES error code.</param>
        /// <returns></returns>
        public void captureAudio(CaptureCB captureSuccess, CaptureErrorCB captureError, CaptureAudioOptions options) { }

        /// <summary>
        /// Start the audio recorder application and return information about captured audio clip file(s).
        /// </summary>
        /// <param name="captureSuccess">This method starts an asynchronous operation to capture audio recordings using the device's default audio recording application.
        /// The operation allows the device user to capture multiple recordings in a single session.</param>
        /// <param name="captureError">The capture operation ends when either the user exits the audio recording application,
        /// or the maximum number of recordings, specified by the limit parameter in CaptureAudioOptions, has been reached.
        /// If no value is provided for the limit parameter, a default value of one (1) is used, and the capture operation will terminate after the user records a single audio clip.</param>
        /// <returns></returns>
        public void captureAudio(CaptureCB captureSuccess, CaptureErrorCB captureError) { }

        /// <summary>
        /// Start the camera application and return information about captured image file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start image capture
        /// navigator.device.capture.captureImage(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureImage(CaptureCB captureSuccess, CaptureErrorCB captureError, CaptureImageOptions options) { }


        /// <summary>
        /// Start the camera application and return information about captured image file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start image capture
        /// navigator.device.capture.captureImage(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureImage(CaptureCB captureSuccess, CaptureErrorCB captureError) { }

        /// <summary>
        /// Start the video recorder application and return information about captured video clip file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start video capture
        /// navigator.device.capture.captureVideo(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureVideo(CaptureCB captureSuccess, CaptureErrorCB captureError, CaptureVideoOptions options) { }

        /// <summary>
        /// Start the video recorder application and return information about captured video clip file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start video capture
        /// navigator.device.capture.captureVideo(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureVideo(CaptureCB captureSuccess, CaptureErrorCB captureError) { }

    }

    /// <summary>
    /// Encapsulates audio capture configuration options
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // limit capture operation to 3 media files, no longer than 10 seconds each
    /// var options = { limit: 3, duration: 10 };
    /// navigator.device.capture.captureAudio(captureSuccess, captureError, options);
    /// </code>
    /// </example>
    public class CaptureAudioOptions
    {
        /// <summary>
        ///  The maximum number of audio clips the device user can record in a single capture operation.
        ///  The value must be greater than or equal to 1 (defaults to 1).
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        /// The maximum duration of an audio sound clip, in seconds.
        /// </summary>
        public JsNumber duration { get; set; }
        /// <summary>
        /// The selected audio mode. The value must match one of the elements in capture.supportedAudioModes.
        /// </summary>
        public JsNumber mode { get; set; }
    }

    public delegate void MediaFileDataSuccessCB(MediaFileData mediaFileData);
    public delegate void MediaFileDataErrorCB();

    /// <summary>
    /// Encapsulates image capture configuration options.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // limit capture operation to 3 images
    /// var options = { limit: 3 };
    /// navigator.device.capture.captureImage(captureSuccess, captureError, options);
    /// </code></example>
    public class CaptureImageOptions
    {
        /// <summary>
        ///  The maximum number of images the device user can capture in a single capture operation.
        ///  The value must be greater than or equal to 1 (defaults to 1).
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        ///  The selected image mode. The value must match one of the elements in capture.supportedImageModes.
        /// </summary>
        public JsNumber mode { get; set; }
    }

    /// <summary>
    /// Encapsulates video capture configuration options.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // limit capture operation to 3 video clips
    /// var options = { limit: 3 };
    /// navigator.device.capture.captureVideo(captureSuccess, captureError, options);
    /// </code></example>
    public class CaptureVideoOptions
    {
        /// <summary>
        ///  The maximum number of video clips the device user can capture in a single capture operation.
        ///  The value must be greater than or equal to 1 (defaults to 1).
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        ///  The maximum duration of a video clip, in seconds.
        /// </summary>
        public JsNumber duration { get; set; }
        /// <summary>
        /// The selected video capture mode. The value must match one of the elements in capture.supportedVideoModes.
        /// </summary>
        public JsNumber mode { get; set; }
    }

    public class CaptureError
    {
        /// <summary>
        ///  One of the pre-defined error codes listed below
        /// </summary>
        public JsNumber code { get; set; }

        /// <summary>
        /// Camera or microphone failed to capture image or sound.
        /// </summary>
        public const CaptureError CAPTURE_INTERNAL_ERR = null;


        /// <summary>
        /// Camera application or audio capture application is currently serving other capture request.
        /// </summary>
        public const CaptureError CAPTURE_APPLICATION_BUSY = null;

        /// <summary>
        /// Invalid use of the API (e.g. limit parameter has value less than one).
        /// </summary>
        public const CaptureError CAPTURE_INVALID_ARGUMENT = null;

        /// <summary>
        /// User exited camera application or audio capture application before capturing anything.
        /// </summary>
        public const CaptureError CAPTURE_NO_MEDIA_FILES = null;

        /// <summary>
        /// he requested capture operation is not supported.
        /// </summary>
        public const CaptureError CAPTURE_NOT_SUPPORTED = null;

    }


    /// <summary>
    /// Invoked upon a successful media capture operation.
    /// </summary>
    /// <param name="mediaFiles"></param>
    /// <example>
    /// <code>
    /// // capture callback
    /// function captureSuccess(mediaFiles) {
    /// var i, path, len;
    /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1){
    /// path = mediaFiles[i].fullPath;
    /// do something interesting with the file
    /// }
    /// };
    /// </code></example>
    public delegate void CaptureCB(JsArray<MediaFile> mediaFiles);

    /// <summary>
    /// Invoked if an error occurs during a media capture operation.
    /// </summary>
    /// <param name="error"></param>
    /// <example>
    /// <code>
    /// // capture error callback
    /// var captureError = function(error) {
    /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
    /// };
    /// </code>
    /// </example>
    public delegate void CaptureErrorCB(JsArray<CaptureError> error);

    /// <summary>
    /// Encapsulates a set of media capture parameters that a device supports.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // retrieve supported image modes
    /// var imageModes = navigator.device.capture.supportedImageModes;
    /// // Select mode that has the highest horizontal resolution
    /// var width = 0;
    /// var selectedmode;
    /// for each (var mode in imageModes) {
    /// if (mode.width > width) {
    /// width = mode.width;
    /// selectedmode = mode;
    /// }
    /// }
    /// </code>
    /// </example>
    public class ConfigurationData
    {
        /// <summary>
        /// The ASCII-encoded string in lower case representing the media type.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The height of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber height { get; set; }
        /// <summary>
        ///  The width of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber width { get; set; }
    }

    /// <summary>
    /// Encapsulates properties of a media capture file
    /// </summary>
    public class MediaFile
    {
        /// <summary>
        /// The name of the file, without path information
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The full path of the file, including the name.
        /// </summary>
        public JsString fullPath { get; set; }
        /// <summary>
        /// The mime type
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The date and time that the file was last modified
        /// </summary>
        public JsDate lastModifiedDate { get; set; }
        /// <summary>
        ///  The size of the file, in bytes.
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// Retrieves the format information of the media file.
        /// </summary>
        /// <param name="successCallback"></param>
        /// <param name="errorCallback"></param>
        public void getFormatData(MediaFileDataSuccessCB successCallback, MediaFileDataErrorCB errorCallback) { }
        /// <summary>
        /// Retrieves the format information of the media file.
        /// </summary>
        /// <param name="successCallback"></param>
        public void getFormatData(MediaFileDataSuccessCB successCallback) { }

    }

    /// <summary>
    /// Encapsulates format information about a media file.
    /// </summary>
    public class MediaFileData
    {
        /// <summary>
        /// The actual format of the audio and video content
        /// </summary>
        public JsString codecs { get; set; }
        /// <summary>
        ///  The average bitrate of the content. In case of an image, this attribute has value 0. (Number)
        /// </summary>
        public JsNumber bitrate { get; set; }
        /// <summary>
        ///  The height of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber height { get; set; }
        /// <summary>
        ///   The width of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        ///  The length of the video or sound clip in seconds. In the case of an image, this attribute has value 0
        /// </summary>
        public JsNumber duration { get; set; }
    }

    public class Compass
    {


        /// <summary>
        /// The compass is a sensor that detects the direction or heading that the device is pointed. It measures the heading in degrees from 0 to 359.99.
        /// The compass heading information is returned via a CompassHeading object using the compassSuccess callback function.
        /// </summary>
        /// <param name="compassSuccess">onSuccess callback function that provides the compass heading information via a compassHeading object.</param>
        /// <param name="compassError">onError callback function for compass functions.</param>
        /// <param name="compassOptions">An optional parameter to customize the retrieval of the compass.</param>
        /// <example>
        /// uage
        /// <code>
        /// function onSuccess(heading) {
        /// //    alert('Heading: ' + heading.magneticHeading);
        /// //};
        /// //function onError(error) {
        /// //    alert('CompassError: ' + error.code);
        /// //};
        /// //navigator.compass.getCurrentHeading(onSuccess, onError);
        /// </code>
        /// </example>
        public void getCurrentHeading(CompassSuccess compassSuccess, CompassError compassError, CompassOptions compassOptions) { }
        /// <summary>
        /// At a regular interval, get the compass heading in degrees.
        /// </summary>
        /// <param name="compassSuccess">onSuccess callback function that provides the compass heading information via a compassHeading object.</param>
        /// <param name="compassError">onError callback function for compass functions.</param>
        /// <param name="compassOptions">An optional parameter to customize the retrieval of the compass.</param>
        /// <example>
        /// uage
        /// <code>
        /// function onSuccess(heading) {
        ///    var element = document.getElementById('heading');
        ///    element.innerHTML = 'Heading: ' + heading.magneticHeading;
        ///};
        ///function onError(compassError) {
        ///        alert('Compass error: ' + compassError.code);
        ///};
        ///var options = { frequency: 3000 };  // Update every 3 seconds
        ///var watchID = navigator.compass.watchHeading(onSuccess, onError, options);
        /// </code>
        /// </example>
        public JsString watchHeading(CompassSuccess compassSuccess, CompassError compassError, CompassOptions compassOptions){return null;}
        /// <summary>
        /// Stop watching the compass referenced by the watch ID parameter.
        /// </summary>
        /// <param name="watchID"> The ID returned by compass.watchHeading.</param>
        /// <example>
        /// usage
        /// <code>
        /// var watchID = navigator.compass.watchHeading(onSuccess, onError, options);
        /// // ... later on ...
        /// navigator.compass.clearWatch(watchID);
        /// </code>
        /// </example>
        public void clearWatch(JsString watchID) { }
        //TODO: really not sure about this one

    }
    //TODO: inside

    /// <summary>
    /// A CompassHeading object is returned to the compassSuccess callback function when an error occurs
    /// </summary>
    public class CompassHeading
    {
        /// <summary>
        ///  The heading in degrees from 0 - 359.99 at a single moment in time.
        /// </summary>
        public JsNumber magneticHeading { get; set; }
        /// <summary>
        /// The heading relative to the geographic North Pole in degrees 0 - 359.99 at a single moment in time.
        /// A negative value indicates that the true heading could not be determined.
        /// </summary>
        public JsNumber trueHeading { get; set; }
        /// <summary>
        ///  The deviation in degrees between the reported heading and the true heading.
        /// </summary>
        public JsNumber headingAccuracy { get; set; }
        /// <summary>
        /// The time at which this heading was determined. (milliseconds)
        /// </summary>
        public JsNumber timestamp { get; set; }
    }
    public delegate void CompassSuccess(JsArray<CompassHeading> error);
    public delegate void compassError(JsArray<CompassError> error);

    /// <summary>
    /// A CompassError object is returned to the compassError callback function when an error occurs.
    /// </summary>
    public class CompassError
    {
        /// <summary>
        /// One of the predefined error codes listed below.
        /// </summary>
        public JsCode code { get; set; }
        public const CompassError COMPASS_INTERNAL_ERR = null;
        public const CompassError COMPASS_NOT_SUPPORTED = null;
    }

    /// <summary>
    /// An optional parameter to customize the retrieval of the compass.
    /// </summary>
    public class CompassOptions
    {
        /// <summary>
        ///  How often to retrieve the compass heading in milliseconds.(Default: 100)
        /// </summary>
        public JsNumber frequency { get; set; }
        /// <summary>
        ///  The change in degrees required to initiate a watchHeading success callback
        /// </summary>
        public JsNumber filter { get; set; }

}

    public class Connection
    {
        public Connection type { get; set; }
        public const Connection UNKNOWN = null;
        public const Connection ETHERNET = null;
        public const Connection WIFI = null;
        public const Connection CELL_2G = null;
        public const Connection CELL_3G = null;
        public const Connection CELL_4G = null;
        public const Connection NONE = null;

    }



}