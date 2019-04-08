// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GruntTask
    {
        /// <summary>
        /// Initializes a new instance of the GruntTask class.
        /// </summary>
        public GruntTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GruntTask class.
        /// </summary>
        public GruntTask(int? id = default(int?), string name = default(string), string description = default(string), bool? tokenTask = default(bool?), string code = default(string), IList<string> referenceAssemblies = default(IList<string>), IList<string> referenceSourceLibraries = default(IList<string>), IList<string> embeddedResources = default(IList<string>), IList<GruntTaskOption> options = default(IList<GruntTaskOption>))
        {
            Id = id;
            Name = name;
            Description = description;
            TokenTask = tokenTask;
            Code = code;
            ReferenceAssemblies = referenceAssemblies;
            ReferenceSourceLibraries = referenceSourceLibraries;
            EmbeddedResources = embeddedResources;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tokenTask")]
        public bool? TokenTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "referenceAssemblies")]
        public IList<string> ReferenceAssemblies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "referenceSourceLibraries")]
        public IList<string> ReferenceSourceLibraries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "embeddedResources")]
        public IList<string> EmbeddedResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IList<GruntTaskOption> Options { get; set; }

    }
}
