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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryResellerUserAlarmThresholdResponse : AcsResponse
	{

		private int? count;

		private bool? success;

		private string code;

		private string message;

		private string requestId;

		private List<QueryResellerUserAlarmThreshold_DataItem> data;

		[JsonProperty(PropertyName = "Count")]
		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		[JsonProperty(PropertyName = "Data")]
		public List<QueryResellerUserAlarmThreshold_DataItem> Data
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

		public class QueryResellerUserAlarmThreshold_DataItem
		{

			private int? thresholdType;

			private string thresholdAmount;

			private int? numerator;

			private int? denominator;

			[JsonProperty(PropertyName = "ThresholdType")]
			public int? ThresholdType
			{
				get
				{
					return thresholdType;
				}
				set	
				{
					thresholdType = value;
				}
			}

			[JsonProperty(PropertyName = "ThresholdAmount")]
			public string ThresholdAmount
			{
				get
				{
					return thresholdAmount;
				}
				set	
				{
					thresholdAmount = value;
				}
			}

			[JsonProperty(PropertyName = "Numerator")]
			public int? Numerator
			{
				get
				{
					return numerator;
				}
				set	
				{
					numerator = value;
				}
			}

			[JsonProperty(PropertyName = "Denominator")]
			public int? Denominator
			{
				get
				{
					return denominator;
				}
				set	
				{
					denominator = value;
				}
			}
		}
	}
}
