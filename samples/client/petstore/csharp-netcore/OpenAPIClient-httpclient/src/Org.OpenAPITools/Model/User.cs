/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Org.OpenAPITools.Client.FileParameter;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="username">username.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="phone">phone.</param>
        /// <param name="userStatus">User Status.</param>
        /// <param name="objectWithNoDeclaredProps">test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value..</param>
        /// <param name="objectWithNoDeclaredPropsNullable">test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value..</param>
        /// <param name="anyTypeProp">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389.</param>
        /// <param name="anyTypePropNullable">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values..</param>
        public User(long id = default(long), string username = default(string), string firstName = default(string), string lastName = default(string), string email = default(string), string password = default(string), string phone = default(string), int userStatus = default(int), Object objectWithNoDeclaredProps = default(Object), Object objectWithNoDeclaredPropsNullable = default(Object), Object anyTypeProp = default(Object), Object anyTypePropNullable = default(Object))
        {
            this.Id = id;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.UserStatus = userStatus;
            this.ObjectWithNoDeclaredProps = objectWithNoDeclaredProps;
            this.ObjectWithNoDeclaredPropsNullable = objectWithNoDeclaredPropsNullable;
            this.AnyTypeProp = anyTypeProp;
            this.AnyTypePropNullable = anyTypePropNullable;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// User Status
        /// </summary>
        /// <value>User Status</value>
        [DataMember(Name = "userStatus", EmitDefaultValue = false)]
        public int UserStatus { get; set; }

        /// <summary>
        /// test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</value>
        [DataMember(Name = "objectWithNoDeclaredProps", EmitDefaultValue = false)]
        public Object ObjectWithNoDeclaredProps { get; set; }

        /// <summary>
        /// test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</value>
        [DataMember(Name = "objectWithNoDeclaredPropsNullable", EmitDefaultValue = true)]
        public Object ObjectWithNoDeclaredPropsNullable { get; set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</value>
        [DataMember(Name = "anyTypeProp", EmitDefaultValue = false)]
        public Object AnyTypeProp { get; set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</value>
        [DataMember(Name = "anyTypePropNullable", EmitDefaultValue = true)]
        public Object AnyTypePropNullable { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  ObjectWithNoDeclaredProps: ").Append(ObjectWithNoDeclaredProps).Append("\n");
            sb.Append("  ObjectWithNoDeclaredPropsNullable: ").Append(ObjectWithNoDeclaredPropsNullable).Append("\n");
            sb.Append("  AnyTypeProp: ").Append(AnyTypeProp).Append("\n");
            sb.Append("  AnyTypePropNullable: ").Append(AnyTypePropNullable).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as User).AreEqual;
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserStatus.GetHashCode();
                if (this.ObjectWithNoDeclaredProps != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectWithNoDeclaredProps.GetHashCode();
                }
                if (this.ObjectWithNoDeclaredPropsNullable != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectWithNoDeclaredPropsNullable.GetHashCode();
                }
                if (this.AnyTypeProp != null)
                {
                    hashCode = (hashCode * 59) + this.AnyTypeProp.GetHashCode();
                }
                if (this.AnyTypePropNullable != null)
                {
                    hashCode = (hashCode * 59) + this.AnyTypePropNullable.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
