//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.openim
{
	 
	public class QueryStateResult : QCloudIMResult
	{
		
	    [JsonProperty("QueryResult")]
        public  IList<OnlineStatus> QueryResult { get; set; }
	}

    public class OnlineStatus
    {


        [JsonProperty("To_Account")]
        public  string ToAccount { get; set; }

        [JsonProperty("State")]
        public  string State { get; set; }
    }

}