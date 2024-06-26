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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class ModifyDBInstanceClassRequest : RpcAcsRequest<ModifyDBInstanceClassResponse>
    {
        public ModifyDBInstanceClassRequest()
            : base("polardbx", "2020-02-02", "ModifyDBInstanceClass", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string specifiedDNSpecMapJson;

		private string cnClass;

		private string targetDBInstanceClass;

		private bool? specifiedDNScale;

		private string dBInstanceName;

		private string clientToken;

		private string switchTimeMode;

		private string switchTime;

		private string dnClass;

		public string SpecifiedDNSpecMapJson
		{
			get
			{
				return specifiedDNSpecMapJson;
			}
			set	
			{
				specifiedDNSpecMapJson = value;
				DictionaryUtil.Add(QueryParameters, "SpecifiedDNSpecMapJson", value);
			}
		}

		public string CnClass
		{
			get
			{
				return cnClass;
			}
			set	
			{
				cnClass = value;
				DictionaryUtil.Add(QueryParameters, "CnClass", value);
			}
		}

		public string TargetDBInstanceClass
		{
			get
			{
				return targetDBInstanceClass;
			}
			set	
			{
				targetDBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "TargetDBInstanceClass", value);
			}
		}

		public bool? SpecifiedDNScale
		{
			get
			{
				return specifiedDNScale;
			}
			set	
			{
				specifiedDNScale = value;
				DictionaryUtil.Add(QueryParameters, "SpecifiedDNScale", value.ToString());
			}
		}

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

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

		public string SwitchTimeMode
		{
			get
			{
				return switchTimeMode;
			}
			set	
			{
				switchTimeMode = value;
				DictionaryUtil.Add(QueryParameters, "SwitchTimeMode", value);
			}
		}

		public string SwitchTime
		{
			get
			{
				return switchTime;
			}
			set	
			{
				switchTime = value;
				DictionaryUtil.Add(QueryParameters, "SwitchTime", value);
			}
		}

		public string DnClass
		{
			get
			{
				return dnClass;
			}
			set	
			{
				dnClass = value;
				DictionaryUtil.Add(QueryParameters, "DnClass", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDBInstanceClassResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceClassResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
