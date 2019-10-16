using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ErrorDto {
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public List<string> Details { get; set; }

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [DataMember(Name="statusCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusCode")]
    public int? StatusCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorDto {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
