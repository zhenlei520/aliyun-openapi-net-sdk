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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class BatchSetLiveDomainConfigsRequest : RpcAcsRequest<BatchSetLiveDomainConfigsResponse>
    {
        public BatchSetLiveDomainConfigsRequest()
            : base("live", "2016-11-01", "BatchSetLiveDomainConfigs", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string functions;

		private string domainNames;

		private string ownerAccount;

		private long? ownerId;

		private string securityToken;

		[JsonProperty(PropertyName = "Functions")]
		public string Functions
		{
			get
			{
				return functions;
			}
			set	
			{
				functions = value;
				DictionaryUtil.Add(QueryParameters, "Functions", value);
			}
		}

		[JsonProperty(PropertyName = "DomainNames")]
		public string DomainNames
		{
			get
			{
				return domainNames;
			}
			set	
			{
				domainNames = value;
				DictionaryUtil.Add(QueryParameters, "DomainNames", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerAccount")]
		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

        public override BatchSetLiveDomainConfigsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchSetLiveDomainConfigsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
