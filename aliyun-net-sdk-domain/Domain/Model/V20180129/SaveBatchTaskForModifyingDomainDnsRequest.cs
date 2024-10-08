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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveBatchTaskForModifyingDomainDnsRequest : RpcAcsRequest<SaveBatchTaskForModifyingDomainDnsResponse>
    {
        public SaveBatchTaskForModifyingDomainDnsRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForModifyingDomainDns", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> domainNames = new List<string>(){ };

		private bool? aliyunDns;

		private string userClientIp;

		private List<string> domainNameServers = new List<string>(){ };

		private string lang;

		[JsonProperty(PropertyName = "DomainName")]
		public List<string> DomainNames
		{
			get
			{
				return domainNames;
			}

			set
			{
				domainNames = value;
			}
		}

		[JsonProperty(PropertyName = "AliyunDns")]
		public bool? AliyunDns
		{
			get
			{
				return aliyunDns;
			}
			set	
			{
				aliyunDns = value;
				DictionaryUtil.Add(QueryParameters, "AliyunDns", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UserClientIp")]
		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		[JsonProperty(PropertyName = "DomainNameServer")]
		public List<string> DomainNameServers
		{
			get
			{
				return domainNameServers;
			}

			set
			{
				domainNameServers = value;
			}
		}

		[JsonProperty(PropertyName = "Lang")]
		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForModifyingDomainDnsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForModifyingDomainDnsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
