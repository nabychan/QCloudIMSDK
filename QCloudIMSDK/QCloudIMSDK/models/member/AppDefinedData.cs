//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.member
{
 
	public class AppDefinedData
	{
 
        [JsonProperty("Key")]
	    public virtual string Key { get; set; }

	    [JsonProperty("Value")]
        public virtual string Value { get; set; }
	}

}