/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListParameterVersionsResponse : AcsResponse
	{

		private string type;

		private string nextToken;

		private string requestId;

		private string description;

		private int? maxResults;

		private string createdBy;

		private string createdDate;

		private string name;

		private int? totalCount;

		private string id;

		private List<ListParameterVersions_ParameterVersion> parameterVersions;

		[JsonProperty(PropertyName = "Type")]
		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "CreatedBy")]
		public string CreatedBy
		{
			get
			{
				return createdBy;
			}
			set	
			{
				createdBy = value;
			}
		}

		[JsonProperty(PropertyName = "CreatedDate")]
		public string CreatedDate
		{
			get
			{
				return createdDate;
			}
			set	
			{
				createdDate = value;
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "Id")]
		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		[JsonProperty(PropertyName = "ParameterVersions")]
		public List<ListParameterVersions_ParameterVersion> ParameterVersions
		{
			get
			{
				return parameterVersions;
			}
			set	
			{
				parameterVersions = value;
			}
		}

		public class ListParameterVersions_ParameterVersion
		{

			private int? parameterVersion;

			private string _value;

			private string updatedDate;

			private string updatedBy;

			[JsonProperty(PropertyName = "ParameterVersion")]
			public int? ParameterVersion
			{
				get
				{
					return parameterVersion;
				}
				set	
				{
					parameterVersion = value;
				}
			}

			[JsonProperty(PropertyName = "_Value")]
			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			[JsonProperty(PropertyName = "UpdatedDate")]
			public string UpdatedDate
			{
				get
				{
					return updatedDate;
				}
				set	
				{
					updatedDate = value;
				}
			}

			[JsonProperty(PropertyName = "UpdatedBy")]
			public string UpdatedBy
			{
				get
				{
					return updatedBy;
				}
				set	
				{
					updatedBy = value;
				}
			}
		}
	}
}
