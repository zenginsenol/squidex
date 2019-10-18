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
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="Location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Location")]
    public InformationLocationProperty Location { get; set; }

    /// <summary>
    /// Gets or Sets Age
    /// </summary>
    [DataMember(Name="Age", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Age")]
    public InformationAgeProperty Age { get; set; }

    /// <summary>
    /// Gets or Sets Experience
    /// </summary>
    [DataMember(Name="Experience", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Experience")]
    public InformationExperienceProperty Experience { get; set; }

    /// <summary>
    /// Gets or Sets Department
    /// </summary>
    [DataMember(Name="Department", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Department")]
    public InformationDepartmentProperty Department { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public InformationCountryProperty Country { get; set; }

    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [DataMember(Name="Summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Summary")]
    public InformationSummaryProperty Summary { get; set; }


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
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Age: ").Append(Age).Append("\n");
      sb.Append("  Experience: ").Append(Experience).Append("\n");
      sb.Append("  Department: ").Append(Department).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
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
