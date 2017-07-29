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
    /// Name
    /// </summary>
    [DataContract]
    public partial class Name :  IEquatable<Name>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        /// <param name="First">First.</param>
        /// <param name="Last">Last.</param>
        /// <param name="Middle">Middle.</param>
        public Name(string First = default(string), string Last = default(string), string Middle = default(string))
        {
            this.First = First;
            this.Last = Last;
            this.Middle = Middle;
        }
        
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }

        /// <summary>
        /// Gets or Sets Middle
        /// </summary>
        [DataMember(Name="middle", EmitDefaultValue=false)]
        public string Middle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Name {\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Middle: ").Append(Middle).Append("\n");
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
            return this.Equals(obj as Name);
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="other">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
                ) && 
                (
                    this.Middle == other.Middle ||
                    this.Middle != null &&
                    this.Middle.Equals(other.Middle)
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
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                if (this.Middle != null)
                    hash = hash * 59 + this.Middle.GetHashCode();
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