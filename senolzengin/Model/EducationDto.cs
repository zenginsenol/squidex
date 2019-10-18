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
  public class EducationDto {
    /// <summary>
    /// Gets or Sets SchoolName
    /// </summary>
    [DataMember(Name="SchoolName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SchoolName")]
    public EducationSchoolNameProperty SchoolName { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public EducationDescriptionProperty Description { get; set; }

    /// <summary>
    /// Gets or Sets OrderNo
    /// </summary>
    [DataMember(Name="OrderNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OrderNo")]
    public EducationOrderNoProperty OrderNo { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="Date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Date")]
    public EducationDateProperty Date { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EducationDto {\n");
      sb.Append("  SchoolName: ").Append(SchoolName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
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
