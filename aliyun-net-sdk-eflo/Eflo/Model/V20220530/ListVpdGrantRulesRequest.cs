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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class ListVpdGrantRulesRequest : RpcAcsRequest<ListVpdGrantRulesResponse>
    {
        public ListVpdGrantRulesRequest()
            : base("eflo", "2022-05-30", "ListVpdGrantRules", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string grantTenantId;

		private int? pageNumber;

		private string resourceGroupId;

		private string grantRuleId;

		private int? pageSize;

		private string erId;

		private bool? forSelect;

		private string instanceId;

		private string instanceName;

		private bool? enablePage;

		public string GrantTenantId
		{
			get
			{
				return grantTenantId;
			}
			set	
			{
				grantTenantId = value;
				DictionaryUtil.Add(BodyParameters, "GrantTenantId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupId", value);
			}
		}

		public string GrantRuleId
		{
			get
			{
				return grantRuleId;
			}
			set	
			{
				grantRuleId = value;
				DictionaryUtil.Add(BodyParameters, "GrantRuleId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string ErId
		{
			get
			{
				return erId;
			}
			set	
			{
				erId = value;
				DictionaryUtil.Add(BodyParameters, "ErId", value);
			}
		}

		public bool? ForSelect
		{
			get
			{
				return forSelect;
			}
			set	
			{
				forSelect = value;
				DictionaryUtil.Add(BodyParameters, "ForSelect", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(BodyParameters, "InstanceName", value);
			}
		}

		public bool? EnablePage
		{
			get
			{
				return enablePage;
			}
			set	
			{
				enablePage = value;
				DictionaryUtil.Add(BodyParameters, "EnablePage", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListVpdGrantRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVpdGrantRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
