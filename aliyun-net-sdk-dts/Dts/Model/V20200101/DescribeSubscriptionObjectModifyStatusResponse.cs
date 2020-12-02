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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeSubscriptionObjectModifyStatusResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private string percent;

		private string requestId;

		private string status;

		private string success;

		private List<DescribeSubscriptionObjectModifyStatus_CheckItem> detail;

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public string Percent
		{
			get
			{
				return percent;
			}
			set	
			{
				percent = value;
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string Success
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

		public List<DescribeSubscriptionObjectModifyStatus_CheckItem> Detail
		{
			get
			{
				return detail;
			}
			set	
			{
				detail = value;
			}
		}

		public class DescribeSubscriptionObjectModifyStatus_CheckItem
		{

			private string checkStatus;

			private string errorMessage;

			private string itemName;

			private string repairMethod;

			public string CheckStatus
			{
				get
				{
					return checkStatus;
				}
				set	
				{
					checkStatus = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string ItemName
			{
				get
				{
					return itemName;
				}
				set	
				{
					itemName = value;
				}
			}

			public string RepairMethod
			{
				get
				{
					return repairMethod;
				}
				set	
				{
					repairMethod = value;
				}
			}
		}
	}
}