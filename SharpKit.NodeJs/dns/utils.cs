using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.dns
{
    class utils
    {
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into the first found A (IPv4) or AAAA (IPv6) record. 
        /// On error, err is an Error object, where err.code is the error code. 
        /// Keep in mind that err.code will be set to 'ENOENT' not only when the domain does not exist but also when the lookup fails in other ways such as no available file descriptors.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">The callback has arguments (err, address, family). 
        /// The address argument is a string representation of a IP v4 or v6 address. T
        /// he family argument is either the integer 4 or 6 and denotes the family of address (not necessarily the value initially passed to lookup).</param>
        /// <returns></returns>
        public object lookup(JsString domain, JsAction<JsError, JsString, JsNumber> callback) { return null; }
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into the first found A (IPv4) or AAAA (IPv6) record. 
        /// On error, err is an Error object, where err.code is the error code. 
        /// Keep in mind that err.code will be set to 'ENOENT' not only when the domain does not exist but also when the lookup fails in other ways such as no available file descriptors.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="family">The family can be the integer 4 or 6. Defaults to null that indicates both Ip v4 and v6 address family.</param>
        /// <param name="callback">The callback has arguments (err, address, family). 
        /// The address argument is a string representation of a IP v4 or v6 address. T
        /// he family argument is either the integer 4 or 6 and denotes the family of address (not necessarily the value initially passed to lookup).</param>
        /// <returns></returns>
        public object lookup(JsString domain, object family, JsAction<JsError, JsString, JsNumber> callback) { return null; }
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into an array of the record types specified by rrtype.
        /// On error, err is an Error object, where err.code is one of the error codes listed below.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">
        /// The callback has arguments (err, addresses). The type of each item in addresses is determined by the record type, 
        /// and described in the documentation for the corresponding lookup methods below.
        /// </param>
        /// <returns></returns>
        public object resolve(JsString domain, JsAction<JsError, JsString> callback) { return null; }
        /// <summary>
        /// Resolves a domain (e.g. 'google.com') into an array of the record types specified by rrtype.
        /// On error, err is an Error object, where err.code is one of the error codes listed below.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="rrtype">
        ///  Valid rrtypes are 'A' (IPV4 addresses, default), 'AAAA' (IPV6 addresses), 'MX' (mail exchange records), 
        ///  'TXT' (text records), 'SRV' (SRV records), 'PTR' (used for reverse IP lookups), 'NS' (name server records) and 'CNAME' (canonical name records).
        /// </param>
        /// <param name="callback">
        /// The callback has arguments (err, addresses). The type of each item in addresses is determined by the record type, 
        /// and described in the documentation for the corresponding lookup methods below.
        /// </param>
        /// <returns></returns>
        public object resolve(JsString domain, JsString rrtype, JsAction<JsError, object> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for IPv4 queries (A records). 
        /// addresses is an array of IPv4 addresses (e.g. ['74.125.79.104', '74.125.79.105', '74.125.79.106']).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object resolve4(JsString domain, JsAction<JsError, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve4() except for IPv6 queries (an AAAA query).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object resolve6(JsString domain, JsAction<JsError, JsArray<JsString>> callback) { return null; }
        //public object 
    }
}
