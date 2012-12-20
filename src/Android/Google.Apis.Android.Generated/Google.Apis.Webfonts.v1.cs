//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4984
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Webfonts.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Webfont {
        
        private string _family;
        
        private string _kind;
        
        private string _subsets;
        
        private string _variants;
        
        /// <summary>The name of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family {
            get {
                return this._family;
            }
            set {
                this._family = value;
            }
        }
        
        /// <summary>This kind represents a webfont object in the webfonts service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>The scripts supported by the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsets")]
        public virtual string Subsets {
            get {
                return this._subsets;
            }
            set {
                this._subsets = value;
            }
        }
        
        /// <summary>The available variants for the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual string Variants {
            get {
                return this._variants;
            }
            set {
                this._variants = value;
            }
        }
    }
    
    public class WebfontList : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<Webfont> _items;
        
        private string _kind;
        
        private string _ETag;
        
        /// <summary>The list of fonts currently served by the Google Fonts API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Webfont> Items {
            get {
                return this._items;
            }
            set {
                this._items = value;
            }
        }
        
        /// <summary>This kind represents a list of webfont objects in the webfonts service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Webfonts.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class WebfontsService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"etag\":\"\\\"a3GBuXuTtUYW9BV1SIieU5LiL7w/-NYZzVN" +
            "scWryV-b3u6PRKwWChcc\\\"\",\"discoveryVersion\":\"v1\",\"id\":\"webfonts:v1\",\"name\":\"webfo" +
            "nts\",\"version\":\"v1\",\"revision\":\"20120614\",\"title\":\"Google Web Fonts Developer AP" +
            "I\",\"description\":\"The Google Web Fonts Developer API.\",\"icons\":{\"x16\":\"http://ww" +
            "w.google.com/images/icons/feature/font_api-16.png\",\"x32\":\"http://www.google.com/" +
            "images/icons/feature/font_api-32.gif\"},\"documentationLink\":\"http://code.google.c" +
            "om/apis/webfonts/docs/developer_api.html\",\"protocol\":\"rest\",\"baseUrl\":\"https://w" +
            "ww.googleapis.com/webfonts/v1/\",\"basePath\":\"/webfonts/v1/\",\"rootUrl\":\"https://ww" +
            "w.googleapis.com/\",\"servicePath\":\"webfonts/v1/\",\"batchPath\":\"batch\",\"parameters\"" +
            ":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the response.\",\"default\"" +
            ":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with Content-Type of appl" +
            "ication/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Sele" +
            "ctor specifying which fields to include in a partial response.\",\"location\":\"quer" +
            "y\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API key identifies your " +
            "project and provides you with API access, quota, and reports. Required unless yo" +
            "u provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string" +
            "\",\"description\":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"pre" +
            "ttyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response with indentations an" +
            "d line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"string" +
            "\",\"description\":\"Available to use for quota purposes for server-side application" +
            "s. Can be any arbitrary string assigned to a user, but should not exceed 40 char" +
            "acters. Overrides userIp if both are provided.\",\"location\":\"query\"},\"userIp\":{\"t" +
            "ype\":\"string\",\"description\":\"IP address of the site where the request originates" +
            ". Use this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"schema" +
            "s\":{\"Webfont\":{\"id\":\"Webfont\",\"type\":\"object\",\"properties\":{\"family\":{\"type\":\"an" +
            "y\",\"description\":\"The name of the font.\"},\"kind\":{\"type\":\"string\",\"description\":" +
            "\"This kind represents a webfont object in the webfonts service.\",\"default\":\"webf" +
            "onts#webfont\"},\"subsets\":{\"type\":\"any\",\"description\":\"The scripts supported by t" +
            "he font.\"},\"variants\":{\"type\":\"any\",\"description\":\"The available variants for th" +
            "e font.\"}}},\"WebfontList\":{\"id\":\"WebfontList\",\"type\":\"object\",\"properties\":{\"ite" +
            "ms\":{\"type\":\"array\",\"description\":\"The list of fonts currently served by the Goo" +
            "gle Fonts API.\",\"items\":{\"$ref\":\"Webfont\"}},\"kind\":{\"type\":\"string\",\"description" +
            "\":\"This kind represents a list of webfont objects in the webfonts service.\",\"def" +
            "ault\":\"webfonts#webfontList\"}}}},\"resources\":{\"webfonts\":{\"methods\":{\"list\":{\"id" +
            "\":\"webfonts.webfonts.list\",\"path\":\"webfonts\",\"httpMethod\":\"GET\",\"description\":\"R" +
            "etrieves the list of fonts currently served by the Google Web Fonts Developer AP" +
            "I\",\"parameters\":{\"sort\":{\"type\":\"string\",\"description\":\"Enables sorting of the l" +
            "ist\",\"enum\":[\"alpha\",\"date\",\"popularity\",\"style\",\"trending\"],\"enumDescriptions\":" +
            "[\"Sort alphabetically\",\"Sort by date added\",\"Sort by popularity\",\"Sort by number" +
            " of styles\",\"Sort by trending\"],\"location\":\"query\"}},\"response\":{\"$ref\":\"Webfont" +
            "List\"}}}}}}";
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected WebfontsService(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._webfonts = new WebfontsResource(this, _authenticator);
        }
        
        public WebfontsService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public WebfontsService(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(WebfontsService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/webfonts/v1/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "webfonts";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/webfonts/v1/";
            }
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this._service.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(_authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            _service.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return _service.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return _service.DeserializeResponse<T>(response);
        }
    }
    
    public class WebfontsResource {
        
        private WebfontsService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "webfonts";
        
        public WebfontsResource(WebfontsService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Retrieves the list of fonts currently served by the Google Web Fonts Developer API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Enables sorting of the list</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Sort {
            
            /// <summary>Sort alphabetically</summary>
            [Google.Apis.Util.StringValueAttribute("alpha")]
            Alpha,
            
            /// <summary>Sort by date added</summary>
            [Google.Apis.Util.StringValueAttribute("date")]
            Date,
            
            /// <summary>Sort by popularity</summary>
            [Google.Apis.Util.StringValueAttribute("popularity")]
            Popularity,
            
            /// <summary>Sort by number of styles</summary>
            [Google.Apis.Util.StringValueAttribute("style")]
            Style,
            
            /// <summary>Sort by trending</summary>
            [Google.Apis.Util.StringValueAttribute("trending")]
            Trending,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Webfonts.v1.Data.WebfontList> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private System.Nullable<Sort> _sort;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Enables sorting of the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Sort> Sort {
                get {
                    return this._sort;
                }
                set {
                    this._sort = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webfonts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class WebfontsService {
        
        private const string Resource = "";
        
        private WebfontsResource _webfonts;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual WebfontsResource Webfonts {
            get {
                return this._webfonts;
            }
        }
    }
}
