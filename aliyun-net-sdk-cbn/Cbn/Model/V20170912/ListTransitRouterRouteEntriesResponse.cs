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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class ListTransitRouterRouteEntriesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<ListTransitRouterRouteEntries_TransitRouterRouteEntry> transitRouterRouteEntries;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public int? TotalCount
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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListTransitRouterRouteEntries_TransitRouterRouteEntry> TransitRouterRouteEntries
		{
			get
			{
				return transitRouterRouteEntries;
			}
			set	
			{
				transitRouterRouteEntries = value;
			}
		}

		public class ListTransitRouterRouteEntries_TransitRouterRouteEntry
		{

			private string transitRouterRouteEntryId;

			private string transitRouterRouteEntryDestinationCidrBlock;

			private string transitRouterRouteEntryType;

			private string createTime;

			private string transitRouterRouteEntryName;

			private string transitRouterRouteEntryStatus;

			private string transitRouterRouteEntryNextHopType;

			private string transitRouterRouteEntryNextHopId;

			private string transitRouterRouteEntryDescription;

			private bool? operationalMode;

			private string tag;

			public string TransitRouterRouteEntryId
			{
				get
				{
					return transitRouterRouteEntryId;
				}
				set	
				{
					transitRouterRouteEntryId = value;
				}
			}

			public string TransitRouterRouteEntryDestinationCidrBlock
			{
				get
				{
					return transitRouterRouteEntryDestinationCidrBlock;
				}
				set	
				{
					transitRouterRouteEntryDestinationCidrBlock = value;
				}
			}

			public string TransitRouterRouteEntryType
			{
				get
				{
					return transitRouterRouteEntryType;
				}
				set	
				{
					transitRouterRouteEntryType = value;
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

			public string TransitRouterRouteEntryName
			{
				get
				{
					return transitRouterRouteEntryName;
				}
				set	
				{
					transitRouterRouteEntryName = value;
				}
			}

			public string TransitRouterRouteEntryStatus
			{
				get
				{
					return transitRouterRouteEntryStatus;
				}
				set	
				{
					transitRouterRouteEntryStatus = value;
				}
			}

			public string TransitRouterRouteEntryNextHopType
			{
				get
				{
					return transitRouterRouteEntryNextHopType;
				}
				set	
				{
					transitRouterRouteEntryNextHopType = value;
				}
			}

			public string TransitRouterRouteEntryNextHopId
			{
				get
				{
					return transitRouterRouteEntryNextHopId;
				}
				set	
				{
					transitRouterRouteEntryNextHopId = value;
				}
			}

			public string TransitRouterRouteEntryDescription
			{
				get
				{
					return transitRouterRouteEntryDescription;
				}
				set	
				{
					transitRouterRouteEntryDescription = value;
				}
			}

			public bool? OperationalMode
			{
				get
				{
					return operationalMode;
				}
				set	
				{
					operationalMode = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}
		}
	}
}
