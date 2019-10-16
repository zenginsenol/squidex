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
  public class InformationDto {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public InformationNameProperty Name { get; set; }

    /// <summary>
    /// Gets or Sets Surname
    /// </summary>
    [DataMember(Name="Surname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Surname")]
    public InformationSurnameProperty Surname { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public InformationEmailProperty Email { get; set; }

    /// <summary>
    /// Gets or Sets Telephone
    /// </summary>
    [DataMember(Name="Telephone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Telephone")]
    public InformationTelephoneProperty Telephone { get; set; }

    /// <summary>
    /// Gets or Sets HighSchool
    /// </summary>
    [DataMember(Name="HighSchool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HighSchool")]
    public InformationHighSchoolProperty HighSchool { get; set; }

    /// <summary>
    /// Gets or Sets University
    /// </summary>
    [DataMember(Name="University", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "University")]
    public InformationUniversityProperty University { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public InformationTitleProperty Title { get; set; }

    /// <summary>
    /// Gets or Sets Departman
    /// </summary>
    [DataMember(Name="Departman", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Departman")]
    public InformationDepartmanProperty Departman { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InformationDto {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Surname: ").Append(Surname).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Telephone: ").Append(Telephone).Append("\n");
      sb.Append("  HighSchool: ").Append(HighSchool).Append("\n");
      sb.Append("  University: ").Append(University).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Departman: ").Append(Departman).Append("\n");
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
