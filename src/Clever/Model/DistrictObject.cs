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
    /// DistrictObject
    /// </summary>
    [DataContract]
    public partial class DistrictObject :  IEquatable<DistrictObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistrictObject" /> class.
        /// </summary>
        /// <param name="_Object">_Object.</param>
        public DistrictObject(District _Object = default(District))
        {
            this._Object = _Object;
        }
        
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public District _Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistrictObject {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DistrictObject);
        }

        /// <summary>
        /// Returns true if DistrictObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DistrictObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistrictObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                return hashCode;
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
