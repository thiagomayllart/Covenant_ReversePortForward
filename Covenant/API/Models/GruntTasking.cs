// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GruntTasking
    {
        /// <summary>
        /// Initializes a new instance of the GruntTasking class.
        /// </summary>
        public GruntTasking()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GruntTasking class.
        /// </summary>
        /// <param name="type">Possible values include: 'Assembly', 'SetDelay',
        /// 'SetJitter', 'SetConnectAttempts', 'Kill', 'Connect', 'Disconnect',
        /// 'Jobs'</param>
        /// <param name="status">Possible values include: 'Uninitialized',
        /// 'Tasked', 'Progressed', 'Completed'</param>
        public GruntTasking(int? id = default(int?), string name = default(string), int? gruntId = default(int?), int? taskId = default(int?), GruntTaskingType? type = default(GruntTaskingType?), string taskingMessage = default(string), bool? tokenTask = default(bool?), string taskingCommand = default(string), string taskingUser = default(string), GruntTaskingStatus? status = default(GruntTaskingStatus?), string gruntTaskOutput = default(string), System.DateTime? taskingTime = default(System.DateTime?), System.DateTime? completionTime = default(System.DateTime?), GruntTaskingMessage gruntTaskingMessage = default(GruntTaskingMessage))
        {
            Id = id;
            Name = name;
            GruntId = gruntId;
            TaskId = taskId;
            Type = type;
            TaskingMessage = taskingMessage;
            TokenTask = tokenTask;
            TaskingCommand = taskingCommand;
            TaskingUser = taskingUser;
            Status = status;
            GruntTaskOutput = gruntTaskOutput;
            TaskingTime = taskingTime;
            CompletionTime = completionTime;
            GruntTaskingMessage = gruntTaskingMessage;
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
        [JsonProperty(PropertyName = "gruntId")]
        public int? GruntId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public int? TaskId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Assembly', 'SetDelay',
        /// 'SetJitter', 'SetConnectAttempts', 'Kill', 'Connect', 'Disconnect',
        /// 'Jobs'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public GruntTaskingType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskingMessage")]
        public string TaskingMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tokenTask")]
        public bool? TokenTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskingCommand")]
        public string TaskingCommand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskingUser")]
        public string TaskingUser { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Uninitialized', 'Tasked',
        /// 'Progressed', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public GruntTaskingStatus? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTaskOutput")]
        public string GruntTaskOutput { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskingTime")]
        public System.DateTime? TaskingTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completionTime")]
        public System.DateTime? CompletionTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTaskingMessage")]
        public GruntTaskingMessage GruntTaskingMessage { get; private set; }

    }
}
