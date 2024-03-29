//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.DataType_.Date_
{
    /// <summary>
    /// The Date.Locale class is a container for all localised date strings
    /// used by Y.DataType.Date. It is used internally, but may be extended
    /// to provide new date localisations.
    /// To create your own Locale, follow these steps:
    /// <ol>
    /// <li>Find an existing locale that matches closely with your needs</li>
    /// <li>Use this as your base class.  Use Y.DataType.Date.Locale["en"] if nothing
    /// matches.</li>
    /// <li>Create your own class as an extension of the base class using
    /// Y.merge, and add your own localisations where needed.</li>
    /// </ol>
    /// See the Y.DataType.Date.Locale["en-US"] and Y.DataType.Date.Locale["en-GB"]
    /// classes which extend Y.DataType.Date.Locale["en"].
    /// For example, to implement locales for French french and Canadian french,
    /// we would do the following:
    /// <ol>
    /// <li>For French french, we have no existing similar locale, so use
    /// Y.DataType.Date.Locale["en"] as the base, and extend it:
    /// <pre>
    /// Y.DataType.Date.Locale["fr"] = Y.merge(Y.DataType.Date.Locale["en"], {
    /// a: ["dim", "lun", "mar", "mer", "jeu", "ven", "sam"],
    /// A: ["dimanche", "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi"],
    /// b: ["jan", "f&eacute;v", "mar", "avr", "mai", "jun", "jui", "ao&ucirc;", "sep", "oct", "nov", "d&eacute;c"],
    /// B: ["janvier", "f&eacute;vrier", "mars", "avril", "mai", "juin", "juillet", "ao&ucirc;t", "septembre", "octobre", "novembre", "d&eacute;cembre"],
    /// c: "%a %d %b %Y %T %Z",
    /// p: ["", ""],
    /// P: ["", ""],
    /// x: "%d.%m.%Y",
    /// X: "%T"
    /// });
    /// </pre>
    /// </li>
    /// <li>For Canadian french, we start with French french and change the meaning of \%x:
    /// <pre>
    /// Y.DataType.Date.Locale["fr-CA"] = Y.merge(Y.DataType.Date.Locale["fr"], {
    /// x: "%Y-%m-%d"
    /// });
    /// </pre>
    /// </li>
    /// </ol>
    /// With that, you can use your new locales:
    /// <pre>
    /// var d = new Date("2008/04/22");
    /// Y.DataType.Date.format(d, { format: "%A, %d %B == %x", locale: "fr" });
    /// </pre>
    /// will return:
    /// <pre>
    /// mardi, 22 avril == 22.04.2008
    /// </pre>
    /// And
    /// <pre>
    /// Y.DataType.Date.format(d, {format: "%A, %d %B == %x", locale: "fr-CA" });
    /// </pre>
    /// Will return:
    /// <pre>
    /// mardi, 22 avril == 2008-04-22
    /// </pre>
    /// </summary>
    public partial class Locale
    {
    }
}
