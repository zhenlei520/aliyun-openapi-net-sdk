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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsConsumerTimeSpanResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsConsumerTimeSpan_Data data;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsConsumerTimeSpan_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class OnsConsumerTimeSpan_Data
		{

			private long? maxTimeStamp;

			private long? consumeTimeStamp;

			private string topic;

			private long? minTimeStamp;

			private string instanceId;

			public long? MaxTimeStamp
			{
				get
				{
					return maxTimeStamp;
				}
				set	
				{
					maxTimeStamp = value;
				}
			}

			public long? ConsumeTimeStamp
			{
				get
				{
					return consumeTimeStamp;
				}
				set	
				{
					consumeTimeStamp = value;
				}
			}

			public string Topic
			{
				get
				{
					return topic;
				}
				set	
				{
					topic = value;
				}
			}

			public long? MinTimeStamp
			{
				get
				{
					return minTimeStamp;
				}
				set	
				{
					minTimeStamp = value;
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
		}
	}
}
