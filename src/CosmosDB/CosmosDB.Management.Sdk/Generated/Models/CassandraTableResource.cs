// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    /// <summary>
    /// Cosmos DB Cassandra table resource object
    /// </summary>
    public partial class CassandraTableResource
    {
        /// <summary>
        /// Initializes a new instance of the CassandraTableResource class.
        /// </summary>
        public CassandraTableResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CassandraTableResource class.
        /// </summary>

        /// <param name="id">Name of the Cosmos DB Cassandra table
        /// </param>

        /// <param name="defaultTtl">Time to live of the Cosmos DB Cassandra table
        /// </param>

        /// <param name="schema">Schema of the Cosmos DB Cassandra table
        /// </param>

        /// <param name="analyticalStorageTtl">Analytical TTL.
        /// </param>
        public CassandraTableResource(string id, int? defaultTtl = default(int?), CassandraSchema schema = default(CassandraSchema), int? analyticalStorageTtl = default(int?))

        {
            this.Id = id;
            this.DefaultTtl = defaultTtl;
            this.Schema = schema;
            this.AnalyticalStorageTtl = analyticalStorageTtl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the Cosmos DB Cassandra table
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets time to live of the Cosmos DB Cassandra table
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultTtl")]
        public int? DefaultTtl {get; set; }

        /// <summary>
        /// Gets or sets schema of the Cosmos DB Cassandra table
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schema")]
        public CassandraSchema Schema {get; set; }

        /// <summary>
        /// Gets or sets analytical TTL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "analyticalStorageTtl")]
        public int? AnalyticalStorageTtl {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }


        }
    }
}