﻿//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{
	 
	public class GroupAddRequest : QCloudIMRequest
	{ 

            [JsonProperty("From_Account")]
	    public  string FromAccount { get; set; }


	    [JsonProperty("GroupName")]
        public  IList<string> GroupName { get; set; }


	    [JsonProperty("To_Account")]
        public  string ToAccount { get; set; }
	}

}