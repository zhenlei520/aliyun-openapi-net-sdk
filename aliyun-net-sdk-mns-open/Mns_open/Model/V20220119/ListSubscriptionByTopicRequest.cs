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
using Aliyun.Acs.Mns_open.Transform;
using Aliyun.Acs.Mns_open.Transform.V20220119;

namespace Aliyun.Acs.Mns_open.Model.V20220119
{
    public class ListSubscriptionByTopicRequest : RpcAcsRequest<ListSubscriptionByTopicResponse>
    {
        public ListSubscriptionByTopicRequest()
            : base("Mns-open", "2022-01-19", "ListSubscriptionByTopic", "mns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Mns_open.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Mns_open.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string subscriptionName;

		private string topicName;

		private long? pageNum;

		private long? pageSize;

		public string SubscriptionName
		{
			get
			{
				return subscriptionName;
			}
			set	
			{
				subscriptionName = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionName", value);
			}
		}

		public string TopicName
		{
			get
			{
				return topicName;
			}
			set	
			{
				topicName = value;
				DictionaryUtil.Add(QueryParameters, "TopicName", value);
			}
		}

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListSubscriptionByTopicResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSubscriptionByTopicResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
