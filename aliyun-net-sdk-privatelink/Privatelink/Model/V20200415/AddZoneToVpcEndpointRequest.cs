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
using Aliyun.Acs.Privatelink.Transform;
using Aliyun.Acs.Privatelink.Transform.V20200415;

namespace Aliyun.Acs.Privatelink.Model.V20200415
{
    public class AddZoneToVpcEndpointRequest : RpcAcsRequest<AddZoneToVpcEndpointResponse>
    {
        public AddZoneToVpcEndpointRequest()
            : base("Privatelink", "2020-04-15", "AddZoneToVpcEndpoint", "privatelink", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Privatelink.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string clientToken;

		private string endpointId;

		private bool? dryRun;

		private string vSwitchId;

		private string zoneId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string EndpointId
		{
			get
			{
				return endpointId;
			}
			set	
			{
				endpointId = value;
				DictionaryUtil.Add(QueryParameters, "EndpointId", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddZoneToVpcEndpointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddZoneToVpcEndpointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}