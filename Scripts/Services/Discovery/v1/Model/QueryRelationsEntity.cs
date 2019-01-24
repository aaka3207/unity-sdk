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

using FullSerializer;

namespace IBM.Watson.Discovery.v1.Model
{
    /// <summary>
    /// QueryRelationsEntity.
    /// </summary>
    public class QueryRelationsEntity
    {
        /// <summary>
        /// Entity text content.
        /// </summary>
        [fsProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// The type of the specified entity.
        /// </summary>
        [fsProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// If false, implicit querying is performed. The default is `false`.
        /// </summary>
        [fsProperty("exact")]
        public bool? Exact { get; set; }
    }


}
