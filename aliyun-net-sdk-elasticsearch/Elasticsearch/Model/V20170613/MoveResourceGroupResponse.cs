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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class MoveResourceGroupResponse : AcsResponse
	{

		private string requestId;

		private MoveResourceGroup_Result result;

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

		public MoveResourceGroup_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class MoveResourceGroup_Result
		{

			private int? nodeAmount;

			private string publicDomain;

			private string createdAt;

			private string status;

			private int? publicPort;

			private int? kibanaPort;

			private string paymentType;

			private string domain;

			private string description;

			private string esVersion;

			private string kibanaDomain;

			private string updatedAt;

			private string instanceId;

			private List<MoveResourceGroup_DictListItem> dictList;

			private List<MoveResourceGroup_SynonymsDictsItem> synonymsDicts;

			private MoveResourceGroup_NodeSpec nodeSpec;

			private MoveResourceGroup_NetworkConfig networkConfig;

			private MoveResourceGroup_KibanaConfiguration kibanaConfiguration;

			private MoveResourceGroup_MasterConfiguration masterConfiguration;

			public int? NodeAmount
			{
				get
				{
					return nodeAmount;
				}
				set	
				{
					nodeAmount = value;
				}
			}

			public string PublicDomain
			{
				get
				{
					return publicDomain;
				}
				set	
				{
					publicDomain = value;
				}
			}

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public int? PublicPort
			{
				get
				{
					return publicPort;
				}
				set	
				{
					publicPort = value;
				}
			}

			public int? KibanaPort
			{
				get
				{
					return kibanaPort;
				}
				set	
				{
					kibanaPort = value;
				}
			}

			public string PaymentType
			{
				get
				{
					return paymentType;
				}
				set	
				{
					paymentType = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

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

			public string EsVersion
			{
				get
				{
					return esVersion;
				}
				set	
				{
					esVersion = value;
				}
			}

			public string KibanaDomain
			{
				get
				{
					return kibanaDomain;
				}
				set	
				{
					kibanaDomain = value;
				}
			}

			public string UpdatedAt
			{
				get
				{
					return updatedAt;
				}
				set	
				{
					updatedAt = value;
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
				}
			}

			public List<MoveResourceGroup_DictListItem> DictList
			{
				get
				{
					return dictList;
				}
				set	
				{
					dictList = value;
				}
			}

			public List<MoveResourceGroup_SynonymsDictsItem> SynonymsDicts
			{
				get
				{
					return synonymsDicts;
				}
				set	
				{
					synonymsDicts = value;
				}
			}

			public MoveResourceGroup_NodeSpec NodeSpec
			{
				get
				{
					return nodeSpec;
				}
				set	
				{
					nodeSpec = value;
				}
			}

			public MoveResourceGroup_NetworkConfig NetworkConfig
			{
				get
				{
					return networkConfig;
				}
				set	
				{
					networkConfig = value;
				}
			}

			public MoveResourceGroup_KibanaConfiguration KibanaConfiguration
			{
				get
				{
					return kibanaConfiguration;
				}
				set	
				{
					kibanaConfiguration = value;
				}
			}

			public MoveResourceGroup_MasterConfiguration MasterConfiguration
			{
				get
				{
					return masterConfiguration;
				}
				set	
				{
					masterConfiguration = value;
				}
			}

			public class MoveResourceGroup_DictListItem
			{

				private long? fileSize;

				private string sourceType;

				private string name;

				private string type;

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

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
			}

			public class MoveResourceGroup_SynonymsDictsItem
			{

				private long? fileSize;

				private string sourceType;

				private string name;

				private string type;

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

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
			}

			public class MoveResourceGroup_NodeSpec
			{

				private string spec;

				private int? disk;

				private string diskType;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}
			}

			public class MoveResourceGroup_NetworkConfig
			{

				private string vpcId;

				private string vsArea;

				private string type;

				private string vswitchId;

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string VsArea
				{
					get
					{
						return vsArea;
					}
					set	
					{
						vsArea = value;
					}
				}

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

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}
			}

			public class MoveResourceGroup_KibanaConfiguration
			{

				private string spec;

				private int? amount;

				private int? disk;

				private string diskType;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}
			}

			public class MoveResourceGroup_MasterConfiguration
			{

				private string spec;

				private int? amount;

				private int? disk;

				private string diskType;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}
			}
		}
	}
}
