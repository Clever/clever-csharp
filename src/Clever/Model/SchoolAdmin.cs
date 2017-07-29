/* 
 * Clever API
 *
 * The Clever API
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Clever.Client.SwaggerDateConverter;

namespace Clever.Model
{
    /// <summary>
    /// SchoolAdmin
    /// </summary>
    [DataContract]
    public partial class SchoolAdmin :  IEquatable<SchoolAdmin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolAdmin" /> class.
        /// </summary>
        /// <param name="Credentials">Credentials.</param>
        /// <param name="District">District.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Schools">Schools.</param>
        /// <param name="StaffId">StaffId.</param>
        /// <param name="Title">Title.</param>
        public SchoolAdmin(Credentials Credentials = default(Credentials), string District = default(string), string Email = default(string), string Id = default(string), Name Name = default(Name), List<string> Schools = default(List<string>), string StaffId = default(string), string Title = default(string))
        {
            this.Credentials = Credentials;
            this.District = District;
            this.Email = Email;
            this.Id = Id;
            this.Name = Name;
            this.Schools = Schools;
            this.StaffId = StaffId;
            this.Title = Title;
        }
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Name Name { get; set; }

        /// <summary>
        /// Gets or Sets Schools
        /// </summary>
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<string> Schools { get; set; }

        /// <summary>
        /// Gets or Sets StaffId
        /// </summary>
        [DataMember(Name="staff_id", EmitDefaultValue=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolAdmin {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  StaffId: ").Append(StaffId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SchoolAdmin);
        }

        /// <summary>
        /// Returns true if SchoolAdmin instances are equal
        /// </summary>
        /// <param name="other">Instance of SchoolAdmin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolAdmin other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Credentials == other.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.Equals(other.Credentials)
                ) && 
                (
                    this.District == other.District ||
                    this.District != null &&
                    this.District.Equals(other.District)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Schools == other.Schools ||
                    this.Schools != null &&
                    this.Schools.SequenceEqual(other.Schools)
                ) && 
                (
                    this.StaffId == other.StaffId ||
                    this.StaffId != null &&
                    this.StaffId.Equals(other.StaffId)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Credentials != null)
                    hash = hash * 59 + this.Credentials.GetHashCode();
                if (this.District != null)
                    hash = hash * 59 + this.District.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Schools != null)
                    hash = hash * 59 + this.Schools.GetHashCode();
                if (this.StaffId != null)
                    hash = hash * 59 + this.StaffId.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}