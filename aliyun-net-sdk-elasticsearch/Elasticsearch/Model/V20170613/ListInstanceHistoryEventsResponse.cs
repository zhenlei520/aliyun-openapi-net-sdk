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
	public class ListInstanceHistoryEventsResponse : AcsResponse
	{

		private string requestId;

		private List<ListInstanceHistoryEvents_ResultItem> result;

		private ListInstanceHistoryEvents_Headers headers;

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

		public List<ListInstanceHistoryEvents_ResultItem> Result
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

		public ListInstanceHistoryEvents_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListInstanceHistoryEvents_ResultItem
		{

			private string eventCreateTime;

			private string eventCycleStatus;

			private string eventExecuteTime;

			private string eventFinashTime;

			private string eventLevel;

			private string instanceId;

			private string nodeIP;

			private string eventType;

			private string regionId;

			private string ecsId;

			public string EventCreateTime
			{
				get
				{
					return eventCreateTime;
				}
				set	
				{
					eventCreateTime = value;
				}
			}

			public string EventCycleStatus
			{
				get
				{
					return eventCycleStatus;
				}
				set	
				{
					eventCycleStatus = value;
				}
			}

			public string EventExecuteTime
			{
				get
				{
					return eventExecuteTime;
				}
				set	
				{
					eventExecuteTime = value;
				}
			}

			public string EventFinashTime
			{
				get
				{
					return eventFinashTime;
				}
				set	
				{
					eventFinashTime = value;
				}
			}

			public string EventLevel
			{
				get
				{
					return eventLevel;
				}
				set	
				{
					eventLevel = value;
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

			public string NodeIP
			{
				get
				{
					return nodeIP;
				}
				set	
				{
					nodeIP = value;
				}
			}

			public string EventType
			{
				get
				{
					return eventType;
				}
				set	
				{
					eventType = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string EcsId
			{
				get
				{
					return ecsId;
				}
				set	
				{
					ecsId = value;
				}
			}
		}

		public class ListInstanceHistoryEvents_Headers
		{

			private long? xTotalCount;

			private long? xTotalFailed;

			private long? xTotalSuccess;

			public long? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}

			public long? XTotalFailed
			{
				get
				{
					return xTotalFailed;
				}
				set	
				{
					xTotalFailed = value;
				}
			}

			public long? XTotalSuccess
			{
				get
				{
					return xTotalSuccess;
				}
				set	
				{
					xTotalSuccess = value;
				}
			}
		}
	}
}
