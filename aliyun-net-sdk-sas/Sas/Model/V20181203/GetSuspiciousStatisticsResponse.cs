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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class GetSuspiciousStatisticsResponse : AcsResponse
	{

		private int? suspiciousCount;

		private int? remindCount;

		private string requestId;

		private int? temindCount;

		private int? seriousCount;

		private int? totalCount;

		public int? SuspiciousCount
		{
			get
			{
				return suspiciousCount;
			}
			set	
			{
				suspiciousCount = value;
			}
		}

		public int? RemindCount
		{
			get
			{
				return remindCount;
			}
			set	
			{
				remindCount = value;
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

		public int? TemindCount
		{
			get
			{
				return temindCount;
			}
			set	
			{
				temindCount = value;
			}
		}

		public int? SeriousCount
		{
			get
			{
				return seriousCount;
			}
			set	
			{
				seriousCount = value;
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
	}
}
