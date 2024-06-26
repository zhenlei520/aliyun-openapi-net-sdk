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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ComputeNest.Transform;
using Aliyun.Acs.ComputeNest.Transform.V20210601;

namespace Aliyun.Acs.ComputeNest.Model.V20210601
{
    public class ListServiceInstanceResourcesRequest : RpcAcsRequest<ListServiceInstanceResourcesResponse>
    {
        public ListServiceInstanceResourcesRequest()
            : base("ComputeNest", "2021-06-01", "ListServiceInstanceResources", "computenest", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNest.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string expireTimeEnd;

		private string nextToken;

		private string serviceInstanceResourceType;

		private List<string> resourceARNs = new List<string>(){ };

		private List<string> tags = new List<string>(){ };

		private string serviceInstanceId;

		private string expireTimeStart;

		private int? maxResults;

		private string payType;

		public string ExpireTimeEnd
		{
			get
			{
				return expireTimeEnd;
			}
			set	
			{
				expireTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "ExpireTimeEnd", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string ServiceInstanceResourceType
		{
			get
			{
				return serviceInstanceResourceType;
			}
			set	
			{
				serviceInstanceResourceType = value;
				DictionaryUtil.Add(QueryParameters, "ServiceInstanceResourceType", value);
			}
		}

		public List<string> ResourceARNs
		{
			get
			{
				return resourceARNs;
			}

			set
			{
				resourceARNs = value;
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public string ServiceInstanceId
		{
			get
			{
				return serviceInstanceId;
			}
			set	
			{
				serviceInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceInstanceId", value);
			}
		}

		public string ExpireTimeStart
		{
			get
			{
				return expireTimeStart;
			}
			set	
			{
				expireTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "ExpireTimeStart", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListServiceInstanceResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListServiceInstanceResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
