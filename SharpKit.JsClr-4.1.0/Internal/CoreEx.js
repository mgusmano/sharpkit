//kernel.js
var isIE = navigator.userAgent.toLowerCase().indexOf("msie") > -1;
var isMoz = document.implementation && document.implementation.createDocument;
var isWebkit = navigator.userAgent.indexOf("WebKit") > -1; //navigator.vendor == "Apple Computer, Inc.";
//TODO: Add all the rest, or find another way
if (!isMoz)
{
    HTMLImageElement = null;
    HTMLInputElement = null;
}
String.Format = function(format, varargs)
{
    return String.format.apply(String, arguments);
}
String.prototype.startsWith = function(str)
{
    return this.indexOf(str) == 0;
}
String.prototype.endsWith = function(str)
{
    return this.substr(this.length - str.length, str.length) == str;
}
Object.ctor = Object;
Array.ctor = Array;
Date.ctor = Date;
Function.ctor = Function;
Date.prototype.ToString = Date.prototype.toString;
Number.prototype.ToString = Number.prototype.toString;
Error.prototype.ToString = function()
{
    return this.name + " : " + this.message;
}
//Error.prototype.ToString = Error.prototype.toString;
if (typeof (ActiveXObject) != "undefined")
    ActiveXObject.ctor$$String = ActiveXObject;
Number.prototype.get_Value = function() //nullable support
{
    return this;
}
Number.prototype.ToString$$String = function(format)
{
    var s = this.toString();
    for (var i = 0; i < format.length; i++)
    {
        var ch = format.charAt(i);
        if (ch == "0")
        {
            if (s.length < i + 1)
                s = "0" + s;
        }
        else
            throw new Error("not implemented");
    }
    return s;
}
//whether to wrap functions with profiler functions
var ENABLE_PROFILER = typeof (appConfig) == "object" ? appConfig.enableProfiler : false;
//can be changed in runtime - whether to profile functions that are running
var ENABLE_PROFILING = typeof (appConfig) == "object" ? appConfig.enableProfiling : false;
if (ENABLE_PROFILER)
{
    BeforeCompilation(Profiler.Initialize, Profiler);
}
var envDebugFunction = (typeof (Debug) != "undefined" && Debug != null && Debug.writeln) ||
											 (typeof (console) != "undefined" && console != null && console.log) ||
											 function(t) { };
Debug = { writeln: envDebugFunction }
Array.parse = function(value)
{
    return eval('(' + value + ')');
}
JsTypes.push(
{fullname:"System.Object", definition:
{
    ctor: function()
    {
    },
    toString: function()
    {
        return this.ToString();
    },
    ToString: function()
    {
        return "{" + this.constructor._type.get_FullName() + "}";
    },
    construct: function()
    {
        arguments.callee.caller._type.baseType.ctor.apply(this, arguments);
    },
    GetType: function()
    {
        return System.Type._TypeOf(this.constructor._type);
    },
    getType: function()
    {
        return this.constructor._type;
    },
    getTypeName: function()
    {
        return this.constructor._type.name;
    },
    base: function()
    {
        return arguments.callee.caller._type.baseType.ctor.prototype[arguments.callee.caller._name].apply(this, arguments);
    },
    callBase: function(methodName)
    {
        return arguments.callee.caller._type.baseType.ctor.prototype[methodName].apply(this, Arguments.from(arguments, 1));
    }
},staticDefinition:
{
    Equals$$Object: function(x, y)
    {
    //TODO: check value types for valueOf()
        return x == y;
    }
}});

JsTypes.push({fullname:"Object"});

JsTypes.push({fullname:"Array", baseTypeName:"Object",definition:
{
    GetEnumerator: function()
    {
        return new ArrayEnumerator.ctor(this);
    },
    getItem: function(index)
    {
        return this[index];
    },
    getCount: function()
    {
        return this.length;
    },
    get_Count: function()
    {
        return this.length;
    },
    ///
    /// returns an array that contains the values of the specified 
    /// property name from each item
    ///
    selectSingle: function(propName)
    {
        var result = [];
        for (var i = 0; i < this.length; i++)
        {
            var item = this[i];
            var value = item[propName]; //TODO: support getValue
            if (value === undefined) //array cannot contain undefined.
                value = null;
            result.push(value);
        }
        return result;
    },
    Clone: function()
    {
        return this.concat();
    },
    toArray: function()
    {
        return this;
    },
    Add: function(item)
    {
        this.push(item);
    },
    AddRange: function(items)
    {
        var length = items.length;
        var thisLength = this.length;
        for (var i = 0; i < length; i++)
        {
            this[thisLength] = items[i]; //Keep order
            thisLength++;
        }
    },
    Clear: function()
    {
        if (this.length > 0)
        {
            this.splice(0, this.length);
        }
    },
    clone: function()
    {
        return this.slice(0);
    },
    contains: function(item)
    {
        var index = this.indexOf(item);
        return (index >= 0);
    },
    Contains$$Object: function(item)
    {
        var index = this.indexOf(item);
        return (index >= 0);
    },
    dequeue: function()
    {
        return this.shift();
    },
    indexOf: function(item, startFrom)
    {
        if (startFrom == null)
            startFrom = 0;
        var length = this.length;
        if (length != 0)
        {
            for (var index = startFrom; index < length; index++)
            {
                if (this[index] == item)
                {
                    return index;
                }
            }
        }
        return -1;
    },
    insert: function(index, item)
    {
        this.splice(index, 0, item);
    },
    addAt: function(index, item)
    {
        this.splice(index, 0, item);
    },
    queue: function(item)
    {
        this.push(item);
    },
    Remove$$Object: function(item)
    {
        return this.Remove(item);
    },
    Remove: function(item)
    {
        var index = this.indexOf(item);
        if (index >= 0)
        {
            this.splice(index, 1);
        }
        return index;
    },
    RemoveAt: function(index)
    {
        this.splice(index, 1);
    },
    copyTo: function(target, startIndex)
    {
        for (var i = startIndex; i < this.length; i++)
        {
            target.push(this[i]);
        }
    },
    filter: function(pred)
    {
        var item, i = 0;
        for (var i = 0, j = this.length; i < j; i++)
        {
            item = this[i];
            if (!pred(item))
            {
                this.splice(i, 1);
                i--; //prevent increase
                j--; //length is decreased
            }
        }
        return this;
    },
    filterOut: function(pred)
    {
        return this.filter(function(item) { return !pred(item); });
    },
    apply: function(modifier)
    {
        for (var i = 0, j = this.length; i < j; i++)
        {
            this[i] = modifier(this[i]);
        }
        return this;
    },
    findFirst: function(pred)
    {
        var item;
        for (var i = 0, j = this.length; i < j; i++)
        {
            item = this[i];
            if (pred(item))
                return item;
        }
        return null;
    },
    ToArray: function()
    {
        return this;
    },
    peek: function()
    {
        return this[this.length - 1];
    },
    getLast: function()
    {
        return this[this.length - 1];
    },
    getIterator: function()
    {
        return new ArrayIterator(this);
    },
    get_Length: function()
    {
        return this.length;
    },
    get_Item: function(index)
    {
        return this[index];
    },
    get_Item$$Int32: function(index)
    {
        return this[index];
    }
}
});
JsTypes.push({fullname:"ArrayEnumerator", baseTypeName:"System.Object", definition://TODO: implement IEnumerator
{
ctor: function(array)
{
    this._array = array;
    this._idx = -1;
},
Reset: function()
{
    this._idx = -1;
},
get_Current: function()
{
    return this._array[this._idx];
},
MoveNext: function()
{
    this._idx++;
    return this._array.length > this._idx;
},
Dispose: function()
{
    //TODO
}
}
});
AfterCompilation(function()
{
    if (window["System.DateTime"] != null)
    {
        var minDate = new Date(0);
        minDate.setUTCFullYear(1, 0, 1);
        var minDateTime = new System.DateTime.ctor$$Date(minDate);
        System.DateTime.MinValue = minDateTime;
        System.DateTime.commonPrototype.MinValue = minDateTime;
    }
});
JsTypes.push({fullname:"System.Boolean", baseTypeName:"System.ValueType",definition:
{
    ctor: Boolean,
    ToString: function()
    {
        return this == true ? "true" : "false";
    }
}, staticDefinition:
{
    tryParse: function(s)
    {
        if (s == null)
            return false;
        return s.toLowerCase().trim() == "true";
    }
}
});
JsTypes.push({fullname:"System.Int32", baseTypeName:"System.ValueType",definition:
{
    ctor: Number,
    ToString: function()
    {
        return String(Number(this));
    }
}, staticDefinition:
{
    tryParse: function(s)
    {
        return parseInt(s);
    },
    Parse$$String: function(s)
    {
        return parseInt(s);
    }
}
});
JsTypes.push({fullname:"System.Decimal", baseTypeName:"System.ValueType",definition:
{
    ctor: function(x) { return new Number(x); },
    ToString: function()
    {
        return this.toString();
    }
}, staticDefinition:
{
    tryParse: function(s)
    {
        return parseFloat(s);
    }
}});
String.prototype._toString = String.prototype.toString;
JsTypes.push({fullname:"System.String", baseTypeName:"System.Object", definition:
{
    ctor: String,
    GetEnumerator: function()
    {
        return new System.CharEnumerator.ctor$$String(this);
    },
    GetType: function()
    {
        return Typeof(System.String);
    },
    Insert$$Int32$$String: function(startIndex, str)
    {
        var sub1 = this.substring(0, startIndex);
        var sub2 = this.substring(startIndex);
        return sub1 + str + sub2;
    },
    Split$$Char$Array: function(varargs)
    {
        if (arguments.length != 1)
        {
            var re = "[";
            for (var i = 0; i < arguments.length; i++)
            {
                re += arguments[i];
            }
            re += "]";
            var regExp = new RegExp(re);
            var arr = this.split(regExp);
            ////////////////////// Fix for FireFox
            if (isMoz)
            {
                var arr2 = [];
                for (var i = 0, j = arr.length; i < j; i++)
                {
                    if (arr[i].length > 0)
                        arr2.push(arr[i]);
                }
                arr = arr2;
            }
            ////////////////////////
            return arr;
        }
        var firstArg = varargs;
        return this.split(firstArg); //TODO: escape new value?
    },
    ReplaceFirst: function(find, replace)
    {
        return this.replace(find, replace);
    },
    Replace$$Char$$Char: function(oldValue, newValue)
    {
        return this.Replace(oldValue, newValue);
    },
    Replace$$String$$String: function(oldValue, newValue)
    {
        return this.Replace(oldValue, newValue);
    },
    Replace: function(oldValue, newValue)
    {
        //TODO: var regExp = new RegExp(RegExp.Escape(oldValue), "g");
        var last = this;
        var replaced = this.replace(oldValue, newValue);
        while (last != replaced)
        {
            last = replaced;
            replaced = replaced.replace(oldValue, newValue);
        }
        return replaced;
    },
    Substring$$Int32: function(startIndex)
    {
        return this.substr(startIndex);
    },
    Substring$$Int32$$Int32: function(startIndex, length)
    {
        return this.substr(startIndex, length);
    },
    Substring: function(startIndex, length)
    {
        return this.substr(startIndex, length);
    },
    ToLower$$: function()
    {
        return this.toLowerCase();
    },
    ToLower: function()
    {
        return this.toLowerCase();
    },
    ToUpper: function()
    {
        return this.toUpperCase();
    },
    getItem: function(index)
    {
        return this.charAt(index);
    },
    IndexOf$$String: function(s)
    {
        return this.indexOf(s);
    },
    IndexOf$$Char: function(ch)
    {
        return this.indexOf(ch);
    },
    Split$$Char$Array$$StringSplitOptions: function(charArray, stringSplitOptions)
    {
        if (stringSplitOptions == System.StringSplitOptions.None)
            throw new Error("Not Implemented");
        return this.Split$$Char$Array.apply(this, charArray);
    },
    IndexOfAny$$Char$Array: function(charArray)
    {
        //TODO: Convert to RegExp
        var s = charArray.join("");
        for (var i = 0; i < this.length; i++)
        {
            var ch = this.charAt(i);
            if (s.search(ch) >= 0)
                return i;
        }
        return -1;
    },
    IndexOf: function(value, startIndex)
    {
        return this.indexOf.apply(this, arguments);
    },
    LastIndexOf: function(value, startIndex)
    {
        return this.lastIndexOf.apply(this, arguments);
    },
    LastIndexOf$$Char: function(ch)
    {
        return this.lastIndexOf(ch);
    },
    LastIndexOf$$String: function(s)
    {
        return this.lastIndexOf(s);
    },
    Remove$$Int32$$Int32: function(start, count)
    {
        return this.substr(0, start) + this.substr(start + count);
    },
    StartsWith$$String: function(str)
    {
        if (str == null)
            throw new System.ArgumentNullException.ctor();
        return this.indexOf(str) == 0;
    },
    EndsWith$$String: function(str)
    {
        return this.lastIndexOf(str) == this.length - str.length;
    },
    Contains: function(s)
    {
        return this.indexOf(s) != -1;
    },
    ToString: function()
    {
        return this._toString();
    },
    toString: function()
    {
        return this._toString();
    },
    getLength: function()
    {
        return this.length;
    },
    get_Chars$$Int32: String.prototype.charAt,
    get_Chars: String.prototype.charAt,
    get_Length: function()
    {
        return this.length;
    },
    trim: function()
    {
        return this.replace(/^\s+|\s+$/g, "");
    },
    Trim: function()
    {
        return this.replace(/^\s+|\s+$/g, "");
    },
    ltrim: function()
    {
        return this.replace(/^\s+/, "");
    },
    rtrim: function()
    {
        return this.replace(/\s+$/, "");
    },
    FormatObject$$String$$Object$Array: function(formatStr, object)
    {
        var r = /{[A-Za-z]+}/g;
        var s = formatStr;
        var matches = s.match(r);
        for (var i = 0, j = matches.length; i < j; i++)
        {
            var m = matches[i];
            var n = m.substring(1, m.length - 1);
            var v = dataObject["get" + n]();
            s = s.split(m).join(v);
        }
        return s;
    }
}, staticDefinition:
{
    Empty: "",
    FormatCache: [],
    Format: function(format, varargs)
    {
        var cache = System.String.FormatCache;
        var format = arguments[0];
        for (var i = 1; i < arguments.length; i++)
        {
            var re = cache[i - 1];
            if (re == null)
            {
                re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
                cache.push(re);
            }
            format = format.replace(re, arguments[i]);
        }
        return format;
    },
    Format$$String$$Object$Array: function(format, varargs)
    {
        return System.String.Format.apply(null, arguments); //TODO: make native
    },
    Format$$String$$Object$$Object: function(s, obj1, obj2)
    {
        return this.Format(s, obj1, obj2);
    },
    Format$$String$$Object: function(s, obj1)
    {
        return this.Format(s, obj1);
    },
    Join$$String$$String$Array: function(separator, values)
    {
        return values.join(separator);
    },
    Compare$$String$$String$$Boolean: function(s1, s2, ignoreCase)
    {
        if (ignoreCase)
        {
            s1 = s1.toLowerCase();
            s2 = s2.toLowerCase();
        }
        if (s1 > s2)
            return 1;
        else if (s1 < s2)
            return -1;
        else
            return 0;
    }
}
});
Arguments = function()
{
}
//TODO: this method doesn't work good when argsObject contains undefineds
Arguments.from = function(argsObject, start)
{
    //1;
    return Array.prototype.slice.call(argsObject, start);
    //	var end = argsObject.length;
    //	var list = new Array();
    //	for(var i=start;i<end;i++)
    //	{
    //		list.push(argsObject[i] || null);
    //	}
    //	return list;
}
Arguments.Range = function(argsObject, start, end)
{
    if (end == null)
        end = argsObject.length - 1;
    var list = new Array();
    for (var i = start; i <= end; i++)
    {
        list.push(argsObject[i]);
    }
    return list;
}
Arguments.Contains = function(arguments, object)
{
    for (var i = 0; i < arguments.length; i++)
    {
        if (arguments[i] == object)
            return true;
    }
    return false;
}
JsTypes.push({fullname:"Date", definition:
{
    removeTime: function()
    {
        return new Date(this.getFullYear(), this.getMonth(), this.getDate());
    },
    getStartMonthDayOfWeek: function()
    {
        return new Date(this.getFullYear(), this.getMonth(), 1).getDay();
    },
    getShortDayOfWeek: function()
    {
        return Date.shortDays[this.getDay()];
    },
    addMonths: function(months)
    {
        return new Date(this.getFullYear(), this.getMonth() + months, this.getDate(), this.getHours(), this.getMinutes(), this.getSeconds(), this.getMilliseconds());
    },
    addDays: function(days)
    {
        return new Date(this.getFullYear(), this.getMonth(), this.getDate() + days, this.getHours(), this.getMinutes(), this.getSeconds(), this.getMilliseconds());
    },
    isInMonth: function(date)
    {
        return this.getFullYear() == date.getFullYear() && this.getMonth() == date.getMonth();
    }
}, staticDefinition:
{
    shortDays: ["Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"],
    getNow: function()
    {
        return new Date();
    },
    getToday: function()
    {
        return new Date().removeTime();
    }
}});
//THIS file is for backward compatability and should be deprecated
JsTypes.push({fullname:"VM",  definition:
{
}, staticDefinition:
{
    tryParse: function(text, ctor)
    {
        if (ctor == null)
            return null;
        var type = ctor._type;
        return this._TryParse(text, type);
    },
    TryParse: function(text, type)
    {
        if (typeof (type) == "string")
            type = Typeof(type);
        if (type == null)
            return null;
        return this._TryParse(text, type._JsType);
    },
    _TryParse: function(text, jsType)
    {
        if (jsType == null)
            return null;
        if (typeof (jsType) == "string")
        {
            jsType = this.getType(jsType);
            if (jsType == null)
                return null;
        }
        if (jsType.tryParse == null)
            return null;
        return jsType.tryParse(text);
    },
    PropertyIs: function(object, propertyName, typeName)
    {
        var propertyCtor = VM.getPropertyType(object, propertyName);
        if (propertyCtor != null)//TODO: recieved ctor
        {
            var propertyType = propertyCtor._type;
            var type = Type.GetType(typeName, true);
            return TypeIs(propertyType, type);
        }
        return false;
    }
}
});
JsTypes.push({fullname:"SharpKit.DataModel.NotifyCollectionChangedEventArgs", baseTypeName:"System.Object", definition:
{
    ctor: function(action, changedItem)
    {
        if (arguments.length == 0)
            return; //TODO: Support serialization constructors
        this._Action = action;
        if (action == "Add")
        {
            this._NewItems = [changedItem];
        }
        else if (action == "Remove")
        {
            this._OldItems = [changedItem];
        }
        else
            throw new Error("Not implemented");
    },
    get_OldItems: function()
    {
        return this._OldItems;
    },
    get_NewItems: function()
    {
        return this._NewItems;
    },
    get_Action: function()
    {
        return this._Action;
    }
}
});
