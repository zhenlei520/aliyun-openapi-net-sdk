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
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20130221;

namespace Aliyun.Acs.Slb.Model.V20130221
{
    public class SetLoadBalancerListenerStatusRequest : RpcAcsRequest<SetLoadBalancerListenerStatusResponse>
    {
        public SetLoadBalancerListenerStatusRequest()
            : base("Slb", "2013-02-21", "SetLoadBalancerListenerStatus", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Slb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? listenerPort;

		private string ownerAccount;

		private string hostId;

		private string ownerId;

		private string listenerStatus;

		private string loadBalancerId;

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

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

		public string HostId
		{
			get
			{
				return hostId;
			}
			set	
			{
				hostId = value;
				DictionaryUtil.Add(QueryParameters, "HostId", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string ListenerStatus
		{
			get
			{
				return listenerStatus;
			}
			set	
			{
				listenerStatus = value;
				DictionaryUtil.Add(QueryParameters, "ListenerStatus", value);
			}
		}

		public string LoadBalancerId
		{
			get
			{
				return loadBalancerId;
			}
			set	
			{
				loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
			}
		}

        public override SetLoadBalancerListenerStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLoadBalancerListenerStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
