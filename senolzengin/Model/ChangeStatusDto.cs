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
  public class ChangeStatusDto {
    /// <summary>
    /// The new status.
    /// </summary>
    /// <value>The new status.</value>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// The due time.
    /// </summary>
    /// <value>The due time.</value>
    [DataMember(Name="DueTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueTime")]
    public DateTime? DueTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChangeStatusDto {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  DueTime: ").Append(DueTime).Append("\n");
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
