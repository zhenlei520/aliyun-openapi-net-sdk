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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class ListChatbotInstancesResponse : AcsResponse
	{

		private long? totalCount;

		private long? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<ListChatbotInstances_Bot> bots;

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<ListChatbotInstances_Bot> Bots
		{
			get
			{
				return bots;
			}
			set	
			{
				bots = value;
			}
		}

		public class ListChatbotInstances_Bot
		{

			private string introduction;

			private string avatar;

			private string timeZone;

			private string createTime;

			private string languageCode;

			private string instanceId;

			private string name;

			public string Introduction
			{
				get
				{
					return introduction;
				}
				set	
				{
					introduction = value;
				}
			}

			public string Avatar
			{
				get
				{
					return avatar;
				}
				set	
				{
					avatar = value;
				}
			}

			public string TimeZone
			{
				get
				{
					return timeZone;
				}
				set	
				{
					timeZone = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string LanguageCode
			{
				get
				{
					return languageCode;
				}
				set	
				{
					languageCode = value;
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
		}
	}
}
