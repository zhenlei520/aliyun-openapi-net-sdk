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
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class PubRequest : RpcAcsRequest<PubResponse>
    {
        public PubRequest()
            : base("Iot", "2018-01-20", "Pub")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<UserProp> userProps = new List<UserProp>(){ };

		private string messageContent;

		private int? qos;

		private string correlationData;

		private string iotInstanceId;

		private long? messageExpiryInterval;

		private string responseTopic;

		private string topicFullName;

		private int? payloadFormatIndicator;

		private string productKey;

		private string contentType;

		private bool? retained;

		private string deviceName;

		public List<UserProp> UserProps
		{
			get
			{
				return userProps;
			}

			set
			{
				userProps = value;
				for (int i = 0; i < userProps.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserProp." + (i + 1) + ".Value", userProps[i].Value);
					DictionaryUtil.Add(QueryParameters,"UserProp." + (i + 1) + ".Key", userProps[i].Key);
				}
			}
		}

		public string MessageContent
		{
			get
			{
				return messageContent;
			}
			set	
			{
				messageContent = value;
				DictionaryUtil.Add(BodyParameters, "MessageContent", value);
			}
		}

		public int? Qos
		{
			get
			{
				return qos;
			}
			set	
			{
				qos = value;
				DictionaryUtil.Add(QueryParameters, "Qos", value.ToString());
			}
		}

		public string CorrelationData
		{
			get
			{
				return correlationData;
			}
			set	
			{
				correlationData = value;
				DictionaryUtil.Add(QueryParameters, "CorrelationData", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public long? MessageExpiryInterval
		{
			get
			{
				return messageExpiryInterval;
			}
			set	
			{
				messageExpiryInterval = value;
				DictionaryUtil.Add(QueryParameters, "MessageExpiryInterval", value.ToString());
			}
		}

		public string ResponseTopic
		{
			get
			{
				return responseTopic;
			}
			set	
			{
				responseTopic = value;
				DictionaryUtil.Add(QueryParameters, "ResponseTopic", value);
			}
		}

		public string TopicFullName
		{
			get
			{
				return topicFullName;
			}
			set	
			{
				topicFullName = value;
				DictionaryUtil.Add(QueryParameters, "TopicFullName", value);
			}
		}

		public int? PayloadFormatIndicator
		{
			get
			{
				return payloadFormatIndicator;
			}
			set	
			{
				payloadFormatIndicator = value;
				DictionaryUtil.Add(QueryParameters, "PayloadFormatIndicator", value.ToString());
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string ContentType
		{
			get
			{
				return contentType;
			}
			set	
			{
				contentType = value;
				DictionaryUtil.Add(QueryParameters, "ContentType", value);
			}
		}

		public bool? Retained
		{
			get
			{
				return retained;
			}
			set	
			{
				retained = value;
				DictionaryUtil.Add(QueryParameters, "Retained", value.ToString());
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public class UserProp
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override PubResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PubResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
