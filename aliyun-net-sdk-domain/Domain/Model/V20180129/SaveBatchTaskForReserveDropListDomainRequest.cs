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
using Aliyun.Acs.Domain;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveBatchTaskForReserveDropListDomainRequest : RpcAcsRequest<SaveBatchTaskForReserveDropListDomainResponse>
    {
        public SaveBatchTaskForReserveDropListDomainRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForReserveDropListDomain")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Domains> domainss = new List<Domains>(){ };

		private string contactTemplateId;

		public List<Domains> Domainss
		{
			get
			{
				return domainss;
			}

			set
			{
				domainss = value;
				for (int i = 0; i < domainss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Domains." + (i + 1) + ".DomainName", domainss[i].DomainName);
				}
			}
		}

		public string ContactTemplateId
		{
			get
			{
				return contactTemplateId;
			}
			set	
			{
				contactTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContactTemplateId", value);
			}
		}

		public class Domains
		{

			private string domainName;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForReserveDropListDomainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForReserveDropListDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}