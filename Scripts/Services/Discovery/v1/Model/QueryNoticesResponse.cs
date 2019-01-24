/**
* Copyright 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using FullSerializer;

namespace IBM.Watson.Discovery.v1.Model
{
    /// <summary>
    /// QueryNoticesResponse.
    /// </summary>
    public class QueryNoticesResponse
    {
        /// <summary>
        /// Gets or Sets MatchingResults
        /// </summary>
        [fsProperty("matching_results")]
        public long? MatchingResults { get; set; }
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [fsProperty("results")]
        public List<QueryNoticesResult> Results { get; set; }
        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [fsProperty("aggregations")]
        public List<QueryAggregation> Aggregations { get; set; }
        /// <summary>
        /// Gets or Sets Passages
        /// </summary>
        [fsProperty("passages")]
        public List<QueryPassages> Passages { get; set; }
        /// <summary>
        /// Gets or Sets DuplicatesRemoved
        /// </summary>
        [fsProperty("duplicates_removed")]
        public long? DuplicatesRemoved { get; set; }
    }


}
