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
  public class ExperienceContentDto {
    /// <summary>
    /// The id of the experience content.
    /// </summary>
    /// <value>The id of the experience content.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public ExperienceDto Data { get; set; }

    /// <summary>
    /// Gets or Sets DataDraft
    /// </summary>
    [DataMember(Name="dataDraft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataDraft")]
    public ExperienceDto DataDraft { get; set; }

    /// <summary>
    /// The version of the experience.
    /// </summary>
    /// <value>The version of the experience.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public decimal? Version { get; set; }

    /// <summary>
    /// The date and time when the experience content has been created.
    /// </summary>
    /// <value>The date and time when the experience content has been created.</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// The user that has created the experience content.
    /// </summary>
    /// <value>The user that has created the experience content.</value>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// The date and time when the experience content has been modified last.
    /// </summary>
    /// <value>The date and time when the experience content has been modified last.</value>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public DateTime? LastModified { get; set; }

    /// <summary>
    /// The user that has updated the experience content last.
    /// </summary>
    /// <value>The user that has updated the experience content last.</value>
    [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModifiedBy")]
    public string LastModifiedBy { get; set; }

    /// <summary>
    /// The status of the content.
    /// </summary>
    /// <value>The status of the content.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExperienceContentDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  DataDraft: ").Append(DataDraft).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
      sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
