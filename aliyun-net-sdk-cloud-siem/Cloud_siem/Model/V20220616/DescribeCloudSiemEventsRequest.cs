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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class DescribeCloudSiemEventsRequest : RpcAcsRequest<DescribeCloudSiemEventsResponse>
    {
        public DescribeCloudSiemEventsRequest()
            : base("cloud-siem", "2022-06-16", "DescribeCloudSiemEvents", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? startTime;

		private string eventName;

		private int? pageSize;

		private string orderField;

		private string order;

		private long? endTime;

		private int? currentPage;

		private List<string> threadLevels = new List<string>(){ };

		private string assetId;

		private string incidentUuid;

		private int? status;

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value.ToString());
			}
		}

		public string EventName
		{
			get
			{
				return eventName;
			}
			set	
			{
				eventName = value;
				DictionaryUtil.Add(BodyParameters, "EventName", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string OrderField
		{
			get
			{
				return orderField;
			}
			set	
			{
				orderField = value;
				DictionaryUtil.Add(BodyParameters, "OrderField", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(BodyParameters, "Order", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(BodyParameters, "CurrentPage", value.ToString());
			}
		}

		public List<string> ThreadLevels
		{
			get
			{
				return threadLevels;
			}

			set
			{
				threadLevels = value;
			}
		}

		public string AssetId
		{
			get
			{
				return assetId;
			}
			set	
			{
				assetId = value;
				DictionaryUtil.Add(BodyParameters, "AssetId", value);
			}
		}

		public string IncidentUuid
		{
			get
			{
				return incidentUuid;
			}
			set	
			{
				incidentUuid = value;
				DictionaryUtil.Add(BodyParameters, "IncidentUuid", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeCloudSiemEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCloudSiemEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
