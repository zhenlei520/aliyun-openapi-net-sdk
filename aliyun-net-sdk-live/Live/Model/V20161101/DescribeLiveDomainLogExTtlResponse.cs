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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDomainLogExTtlResponse : AcsResponse
	{

		private string domainName;

		private string requestId;

		private List<DescribeLiveDomainLogExTtl_DomainLogDetail> domainLogDetails;

		[JsonProperty(PropertyName = "DomainName")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "DomainLogDetails")]
		public List<DescribeLiveDomainLogExTtl_DomainLogDetail> DomainLogDetails
		{
			get
			{
				return domainLogDetails;
			}
			set	
			{
				domainLogDetails = value;
			}
		}

		public class DescribeLiveDomainLogExTtl_DomainLogDetail
		{

			private long? logCount;

			private List<DescribeLiveDomainLogExTtl_LogInfoDetail> logInfos;

			private DescribeLiveDomainLogExTtl_PageInfos pageInfos;

			[JsonProperty(PropertyName = "LogCount")]
			public long? LogCount
			{
				get
				{
					return logCount;
				}
				set	
				{
					logCount = value;
				}
			}

			[JsonProperty(PropertyName = "LogInfos")]
			public List<DescribeLiveDomainLogExTtl_LogInfoDetail> LogInfos
			{
				get
				{
					return logInfos;
				}
				set	
				{
					logInfos = value;
				}
			}

			[JsonProperty(PropertyName = "PageInfos")]
			public DescribeLiveDomainLogExTtl_PageInfos PageInfos
			{
				get
				{
					return pageInfos;
				}
				set	
				{
					pageInfos = value;
				}
			}

			public class DescribeLiveDomainLogExTtl_LogInfoDetail
			{

				private string endTime;

				private string logName;

				private string logPath;

				private long? logSize;

				private string startTime;

				[JsonProperty(PropertyName = "EndTime")]
				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				[JsonProperty(PropertyName = "LogName")]
				public string LogName
				{
					get
					{
						return logName;
					}
					set	
					{
						logName = value;
					}
				}

				[JsonProperty(PropertyName = "LogPath")]
				public string LogPath
				{
					get
					{
						return logPath;
					}
					set	
					{
						logPath = value;
					}
				}

				[JsonProperty(PropertyName = "LogSize")]
				public long? LogSize
				{
					get
					{
						return logSize;
					}
					set	
					{
						logSize = value;
					}
				}

				[JsonProperty(PropertyName = "StartTime")]
				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}
			}

			public class DescribeLiveDomainLogExTtl_PageInfos
			{

				private long? pageIndex;

				private long? pageSize;

				private long? total;

				[JsonProperty(PropertyName = "PageIndex")]
				public long? PageIndex
				{
					get
					{
						return pageIndex;
					}
					set	
					{
						pageIndex = value;
					}
				}

				[JsonProperty(PropertyName = "PageSize")]
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

				[JsonProperty(PropertyName = "Total")]
				public long? Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}
			}
		}
	}
}
