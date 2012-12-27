using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.dns
{
    [JsType(JsMode.Prototype, Export = false, Name = "dns")]
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
        /// <summary>
        /// The same as dns.resolve(), but only for mail exchange queries (MX records).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of MX records, each with a priority and an exchange attribute (e.g. [{'priority': 10, 'exchange': 'mx.example.com'},...]).
        /// </param>
        /// <returns></returns>
        public object resolveMx(JsString domain, JsAction<JsError, JsArray<MxRecordsOptions>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for text queries (TXT records). addresses is an array of the text records available for domain (e.g., ['v=spf1 ip4:0.0.0.0 ~all']).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object resolveTxt(JsString domain, JsAction<JsError, JsString> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for service records (SRV records).
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of the SRV records available for domain. 
        /// Properties of SRV records are priority, weight, port, and name (e.g., [{'priority': 10, {'weight': 5, 'port': 21223, 'name': 'service.example.com'}, ...]).
        /// </param>
        /// <returns></returns>
        public object resolveSrv(JsString domain, JsAction<JsError, SrvRecordsOptions> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for name server records (NS records). 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of the name server records available for domain 
        /// (e.g., ['ns1.example.com', 'ns2.example.com']).
        /// </param>
        /// <returns></returns>
        public object resolveNs(JsString domain, JsAction<JsError, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// The same as dns.resolve(), but only for canonical name records (CNAME records). 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="callback">the callback has arguments(err, address).
        /// addresses is an array of the canonical name records available for domain (e.g., ['bar.example.com']).
        /// </param>
        /// <returns></returns>
        public object resolveCname(JsString domain, JsAction<JsError, JsArray<JsString>> callback) { return null; }
        /// <summary>
        /// Reverse resolves an ip address to an array of domain names.
        /// On error, err is an Error object, where err.code is one of the error codes listed below.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="callback">The callback has arguments (err, domains).</param>
        /// <returns></returns>
        public object reverse(JsString ip, JsAction<JsError, JsArray<JsString>> callback) { return null; }
    }
    [JsType(JsMode.Json)]
    public partial class SrvRecordsOptions
    {
        public JsNumber priority { get; set; }
        public JsNumber weight { get; set; }
        public JsNumber port { get; set; }
        public JsString name { get; set; }
    }

    [JsType(JsMode.Json)]
    public partial class MxRecordsOptions
    {
        public JsNumber priority { get; set; }
        public JsString exchange { get; set; }
    }

    //TODO: Error codes
    //    Each DNS query can return one of the following error codes:

    //dns.NODATA: DNS server returned answer with no data.
    //dns.FORMERR: DNS server claims query was misformatted.
    //dns.SERVFAIL: DNS server returned general failure.
    //dns.NOTFOUND: Domain name not found.
    //dns.NOTIMP: DNS server does not implement requested operation.
    //dns.REFUSED: DNS server refused query.
    //dns.BADQUERY: Misformatted DNS query.
    //dns.BADNAME: Misformatted domain name.
    //dns.BADFAMILY: Unsupported address family.
    //dns.BADRESP: Misformatted DNS reply.
    //dns.CONNREFUSED: Could not contact DNS servers.
    //dns.TIMEOUT: Timeout while contacting DNS servers.
    //dns.EOF: End of file.
    //dns.FILE: Error reading file.
    //dns.NOMEM: Out of memory.
    //dns.DESTRUCTION: Channel is being destroyed.
    //dns.BADSTR: Misformatted string.
    //dns.BADFLAGS: Illegal flags specified.
    //dns.NONAME: Given hostname is not numeric.
    //dns.BADHINTS: Illegal hints flags specified.
    //dns.NOTINITIALIZED: c-ares library initialization not yet performed.
    //dns.LOADIPHLPAPI: Error loading iphlpapi.dll.
    //dns.ADDRGETNETWORKPARAMS: Could not find GetNetworkParams function.
    //dns.CANCELLED: DNS query cancelled.
}
