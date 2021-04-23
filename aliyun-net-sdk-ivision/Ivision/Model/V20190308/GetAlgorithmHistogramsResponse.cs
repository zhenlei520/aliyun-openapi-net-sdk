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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class GetAlgorithmHistogramsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private bool? success;

		private GetAlgorithmHistograms_Data data;

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

		public GetAlgorithmHistograms_Data Data
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

		public class GetAlgorithmHistograms_Data
		{

			private int? failureCount;

			private int? successCount;

			private List<GetAlgorithmHistograms_HistogramsItem> histograms;

			public int? FailureCount
			{
				get
				{
					return failureCount;
				}
				set	
				{
					failureCount = value;
				}
			}

			public int? SuccessCount
			{
				get
				{
					return successCount;
				}
				set	
				{
					successCount = value;
				}
			}

			public List<GetAlgorithmHistograms_HistogramsItem> Histograms
			{
				get
				{
					return histograms;
				}
				set	
				{
					histograms = value;
				}
			}

			public class GetAlgorithmHistograms_HistogramsItem
			{

				private int? failureCount;

				private string time;

				private int? successCount;

				public int? FailureCount
				{
					get
					{
						return failureCount;
					}
					set	
					{
						failureCount = value;
					}
				}

				public string Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				public int? SuccessCount
				{
					get
					{
						return successCount;
					}
					set	
					{
						successCount = value;
					}
				}
			}
		}
	}
}
