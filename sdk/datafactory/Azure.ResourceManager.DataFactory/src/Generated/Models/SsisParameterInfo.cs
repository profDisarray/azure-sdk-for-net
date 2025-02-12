// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Ssis parameter. </summary>
    public partial class SsisParameterInfo
    {
        /// <summary> Initializes a new instance of SsisParameterInfo. </summary>
        internal SsisParameterInfo()
        {
        }

        /// <summary> Initializes a new instance of SsisParameterInfo. </summary>
        /// <param name="id"> Parameter id. </param>
        /// <param name="name"> Parameter name. </param>
        /// <param name="description"> Parameter description. </param>
        /// <param name="dataType"> Parameter type. </param>
        /// <param name="isRequired"> Whether parameter is required. </param>
        /// <param name="isSensitive"> Whether parameter is sensitive. </param>
        /// <param name="designDefaultValue"> Design default value of parameter. </param>
        /// <param name="defaultValue"> Default value of parameter. </param>
        /// <param name="sensitiveDefaultValue"> Default sensitive value of parameter. </param>
        /// <param name="valueType"> Parameter value type. </param>
        /// <param name="hasValueSet"> Parameter value set. </param>
        /// <param name="variable"> Parameter reference variable. </param>
        internal SsisParameterInfo(long? id, string name, string description, string dataType, bool? isRequired, bool? isSensitive, string designDefaultValue, string defaultValue, string sensitiveDefaultValue, string valueType, bool? hasValueSet, string variable)
        {
            Id = id;
            Name = name;
            Description = description;
            DataType = dataType;
            IsRequired = isRequired;
            IsSensitive = isSensitive;
            DesignDefaultValue = designDefaultValue;
            DefaultValue = defaultValue;
            SensitiveDefaultValue = sensitiveDefaultValue;
            ValueType = valueType;
            HasValueSet = hasValueSet;
            Variable = variable;
        }

        /// <summary> Parameter id. </summary>
        public long? Id { get; }
        /// <summary> Parameter name. </summary>
        public string Name { get; }
        /// <summary> Parameter description. </summary>
        public string Description { get; }
        /// <summary> Parameter type. </summary>
        public string DataType { get; }
        /// <summary> Whether parameter is required. </summary>
        public bool? IsRequired { get; }
        /// <summary> Whether parameter is sensitive. </summary>
        public bool? IsSensitive { get; }
        /// <summary> Design default value of parameter. </summary>
        public string DesignDefaultValue { get; }
        /// <summary> Default value of parameter. </summary>
        public string DefaultValue { get; }
        /// <summary> Default sensitive value of parameter. </summary>
        public string SensitiveDefaultValue { get; }
        /// <summary> Parameter value type. </summary>
        public string ValueType { get; }
        /// <summary> Parameter value set. </summary>
        public bool? HasValueSet { get; }
        /// <summary> Parameter reference variable. </summary>
        public string Variable { get; }
    }
}
