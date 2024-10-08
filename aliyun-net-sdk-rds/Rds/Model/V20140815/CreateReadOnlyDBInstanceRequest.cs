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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class CreateReadOnlyDBInstanceRequest : RpcAcsRequest<CreateReadOnlyDBInstanceResponse>
    {
        public CreateReadOnlyDBInstanceRequest()
            : base("Rds", "2014-08-15", "CreateReadOnlyDBInstance", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? dBInstanceStorage;

		private bool? autoCreateProxy;

		private string engineVersion;

		private bool? deletionProtection;

		private string resourceGroupId;

		private string targetDedicatedHostIdForMaster;

		private string dBInstanceDescription;

		private string gdnInstanceName;

		private string tddlBizType;

		private string period;

		private long? ownerId;

		private string dBInstanceClass;

		private string vSwitchId;

		private string privateIpAddress;

		private string autoRenew;

		private string port;

		private string zoneId;

		private string instanceNetworkType;

		private string clientToken;

		private string instructionSetArch;

		private string ioAccelerationEnabled;

		private string tddlRegionConfig;

		private string dBInstanceId;

		private string dBInstanceStorageType;

		private string dedicatedHostGroupId;

		private bool? autoPay;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string usedTime;

		private bool? burstingEnabled;

		private string vPCId;

		private string category;

		private string payType;

		private string bpeEnabled;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DBInstanceStorage")]
		public int? DBInstanceStorage
		{
			get
			{
				return dBInstanceStorage;
			}
			set	
			{
				dBInstanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AutoCreateProxy")]
		public bool? AutoCreateProxy
		{
			get
			{
				return autoCreateProxy;
			}
			set	
			{
				autoCreateProxy = value;
				DictionaryUtil.Add(QueryParameters, "AutoCreateProxy", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EngineVersion")]
		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		[JsonProperty(PropertyName = "DeletionProtection")]
		public bool? DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
				DictionaryUtil.Add(QueryParameters, "DeletionProtection", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "TargetDedicatedHostIdForMaster")]
		public string TargetDedicatedHostIdForMaster
		{
			get
			{
				return targetDedicatedHostIdForMaster;
			}
			set	
			{
				targetDedicatedHostIdForMaster = value;
				DictionaryUtil.Add(QueryParameters, "TargetDedicatedHostIdForMaster", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceDescription")]
		public string DBInstanceDescription
		{
			get
			{
				return dBInstanceDescription;
			}
			set	
			{
				dBInstanceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceDescription", value);
			}
		}

		[JsonProperty(PropertyName = "GdnInstanceName")]
		public string GdnInstanceName
		{
			get
			{
				return gdnInstanceName;
			}
			set	
			{
				gdnInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "GdnInstanceName", value);
			}
		}

		[JsonProperty(PropertyName = "TddlBizType")]
		public string TddlBizType
		{
			get
			{
				return tddlBizType;
			}
			set	
			{
				tddlBizType = value;
				DictionaryUtil.Add(QueryParameters, "TddlBizType", value);
			}
		}

		[JsonProperty(PropertyName = "Period")]
		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
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

		[JsonProperty(PropertyName = "DBInstanceClass")]
		public string DBInstanceClass
		{
			get
			{
				return dBInstanceClass;
			}
			set	
			{
				dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
			}
		}

		[JsonProperty(PropertyName = "VSwitchId")]
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

		[JsonProperty(PropertyName = "PrivateIpAddress")]
		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		[JsonProperty(PropertyName = "AutoRenew")]
		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value);
			}
		}

		[JsonProperty(PropertyName = "Port")]
		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value);
			}
		}

		[JsonProperty(PropertyName = "ZoneId")]
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

		[JsonProperty(PropertyName = "InstanceNetworkType")]
		public string InstanceNetworkType
		{
			get
			{
				return instanceNetworkType;
			}
			set	
			{
				instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "InstructionSetArch")]
		public string InstructionSetArch
		{
			get
			{
				return instructionSetArch;
			}
			set	
			{
				instructionSetArch = value;
				DictionaryUtil.Add(QueryParameters, "InstructionSetArch", value);
			}
		}

		[JsonProperty(PropertyName = "IoAccelerationEnabled")]
		public string IoAccelerationEnabled
		{
			get
			{
				return ioAccelerationEnabled;
			}
			set	
			{
				ioAccelerationEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IoAccelerationEnabled", value);
			}
		}

		[JsonProperty(PropertyName = "TddlRegionConfig")]
		public string TddlRegionConfig
		{
			get
			{
				return tddlRegionConfig;
			}
			set	
			{
				tddlRegionConfig = value;
				DictionaryUtil.Add(QueryParameters, "TddlRegionConfig", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceStorageType")]
		public string DBInstanceStorageType
		{
			get
			{
				return dBInstanceStorageType;
			}
			set	
			{
				dBInstanceStorageType = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorageType", value);
			}
		}

		[JsonProperty(PropertyName = "DedicatedHostGroupId")]
		public string DedicatedHostGroupId
		{
			get
			{
				return dedicatedHostGroupId;
			}
			set	
			{
				dedicatedHostGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "AutoPay")]
		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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

		[JsonProperty(PropertyName = "UsedTime")]
		public string UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value);
			}
		}

		[JsonProperty(PropertyName = "BurstingEnabled")]
		public bool? BurstingEnabled
		{
			get
			{
				return burstingEnabled;
			}
			set	
			{
				burstingEnabled = value;
				DictionaryUtil.Add(QueryParameters, "BurstingEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "VPCId")]
		public string VPCId
		{
			get
			{
				return vPCId;
			}
			set	
			{
				vPCId = value;
				DictionaryUtil.Add(QueryParameters, "VPCId", value);
			}
		}

		[JsonProperty(PropertyName = "Category")]
		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		[JsonProperty(PropertyName = "PayType")]
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

		[JsonProperty(PropertyName = "BpeEnabled")]
		public string BpeEnabled
		{
			get
			{
				return bpeEnabled;
			}
			set	
			{
				bpeEnabled = value;
				DictionaryUtil.Add(QueryParameters, "BpeEnabled", value);
			}
		}

        public override CreateReadOnlyDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateReadOnlyDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
