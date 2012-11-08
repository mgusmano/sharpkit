using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html5Sdk;
using Ext.direct;
using SharpKit.Html;


namespace AttHtml5SdkSamples.demos
{
    [JsType(JsMode.ExtJs)]
    public class Prov
    {
        
      
        public static void OnReady()
        {
             //object provider;
             //provider =  Ext.create("Att.Provider");
             // provider.As<Provider>().authorizeApp(new AuthorizeOptions {
             //       authScope = "TL,MOBO,MIM,DC",
             //        //TODO: apiBasePath:        "att"
             // },

            AuthorizeOptions config = new AuthorizeOptions
            {
                authScope = "TL,MOBO,MIM,DC",
                //TODO: apiBasePath:        "att"
            };
        
                

        }
        /*
         * Given a phone number, returns true or false if the phone number is in a valid format.
         * @param {String} phone the phone number to validate
         * @return {Boolean}
         * @static
         */
        static bool isValidPhoneNumber(JsString phone)
        {
            var regex = new JsRegExp("^(1?([ -]?\\(?\\d{3})\\)?[ -]?)?(\\d{3})([ -]?\\d{4})$");
            return regex.test(phone);
        }
         /**
         * Given an email, returns true or false if the it is in a valid format.
         * @param {String} email the email to validate
         * @return {Boolean}
         * @static
         */
            static bool isValidEmail(JsString email)
        {
            var regex = new JsRegExp("^[a-zA-Z]\\w+(.\\w+)*@\\w+(.[0-9a-zA-Z]+)*.[a-zA-Z]{2,4}$", "i");
            return regex.test(email);
        }
        /**
         * Given a shortcode, returns true or false if the it is in a valid format.
         * @param {String} shortcode the short code to validate
         * @return {Boolean}
         * @static
         */
         static bool isValidShortCode(JsString shortcode ) {
            JsRegExp regex = new JsRegExp("^\\d{3,8}$");
            return regex.test(shortcode);
        }
         /**
         * Given an address will determine if it is a valid phone, email or shortcode.
         * @param address {String} the address to validate
         * @returns {Boolean}
         * @static
         */
        static bool isValidAddress(JsString address)
        {
            return _Provider.isValidPhoneNumber(address) || 
                _Provider.isValidEmail(address) ||  
                _Provider.isValidShortCode(address);    
        }

         /**
         * Given a phone number, returns the phone number with all characters, other than numbers, stripped
         * @param {String} phone the phone number to normalize
         * @return {String} the normalized phone number
         * @static
         */
        static JsString normalizePhoneNumber(JsString phone) {
        phone = phone.toString();
            JsRegExp regex =new JsRegExp("[^\\d]", "g");
            return phone.replace(regex, "");
        }

         /**
         * Given a valid address, if it is a phone number will return the normalized phone number. See {@link Att.Provider#normalizePhoneNumber} 
         * Otherwise, returns the address as it is.
         * @param address {String} the address to normalize.
         * @returns {String} the normalize phone number or address.
         * @static 
         */
        static JsString normalizeAddress(JsString address) {
            address = address.toString();
            if(_Provider.isValidPhoneNumber(address)) {
                address = _Provider.normalizePhoneNumber(address);
            }
            return address;
        }
         /**
         * This helper routine will return a properly formatted URL to the SDK routine which will provide the source content (image, text, etc)
         * for the specified message number and part. 
         * @param {string} messageId The message id of the message
         * @param {string} partNumber The part number to retrieve
         * @return {string} The source URL which returns the content of the message part along with appropriate content headers.
         * @static
         */ 
        static JsString getContentSrc(JsString messageId, JsString partNumber) {
            return "/att/content?messageId=" + messageId + "&partNumber=" + partNumber;
        }

        static void constructor(object config) {
            //JsContext.@this.initConfig(config);
            Manager.addProvider(new RemotingProviderConfig {
                // TODO: type = "remoting",
                enableBuffer = false,
                @namespace = "Att"
                //TODO:  url: this.getApiBasePath() + "/direct_router",
                // actions = new                                     // each property within the actions object represents a Class
            //    ServiceProvider: [                         // array of methods within each server side Class
            //        {
            //            name: "oauthUrl",
            //            len: 1
            //        },
            //        {
            //            name: "deviceInfo",
            //            len: 0
            //        },
            //        {
            //            name: "deviceLocation",
            //            len: 3
            //        },
            //        {
            //            name: "sendSms",
            //            len: 2
            //        },
            //        {
            //            name: "smsStatus",
            //            len: 1
            //        },
            //        {
            //            name: "receiveSms",
            //            len: 1
            //        },
            //        {
            //            name: "sendMms",
            //            len: 4
            //        },
            //        {
            //            name: "mmsStatus",
            //            len: 1
            //        },
            //        {
            //            name: 'wapPush',
            //            len: 2
            //        },
            //        {
            //            name: 'requestChargeAuth',
            //            len: 2
            //        },
            //        {
            //            name: "transactionStatus",
            //            len: 2
            //        },
            //        {
            //            name: "subscriptionStatus",
            //            len: 2
            //        },
            //        {
            //            name: "refundTransaction",
            //            len: 2
            //        },
            //        {
            //            name: "commitTransaction",
            //            len: 2
            //        },
            //        {
            //            name: "subscriptionDetails",
            //            len: 2
            //        },
            //        {
            //            name: "signPayload",
            //            len: 1
            //        },
            //        {
            //            name: "sendMobo",
            //            len: 5
            //        },
            //        {
            //            name: "getMessageHeaders",
            //            len: 2
            //        },
            //        {
            //            name: "speechToText",
            //            len: 5
            //        },
            //        {
            //            name: "cmsCreateSession",
            //            len: 1
            //        },
            //        {
            //            name: "cmsSendSignal",
            //            len: 2
            //        },
            //        {
            //            name: 'getAd',
            //            len: 2
            //        }
            //    ]
            //},
            //"namespace":"Att"
            });
                
        }
        //static void authorizeApp(AuthorizeOptions options) {
        //    var me = JsContext.@this;
        //    var successCallback = options.success;
        //    var failureCallback = options.failure;
        //    //TODO: var scope = options.scope
        //    var sheet = MyExt.create("Att.AuthorizationSheet", new 
        //    {
                
        //}
        static void requestPaidSubscription(JsAction options)
        {
            
        }
        
    }
}