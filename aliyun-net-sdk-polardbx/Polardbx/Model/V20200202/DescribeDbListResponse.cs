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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeDbListResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private bool? success;

		private List<DescribeDbList_DB> data;

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

		public List<DescribeDbList_DB> Data
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

		public class DescribeDbList_DB
		{

			private string dBName;

			private string dBDescription;

			private string dBInstanceName;

			private string characterSetName;

			private List<DescribeDbList_Account> accounts;

			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
				}
			}

			public string DBDescription
			{
				get
				{
					return dBDescription;
				}
				set	
				{
					dBDescription = value;
				}
			}

			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			public string CharacterSetName
			{
				get
				{
					return characterSetName;
				}
				set	
				{
					characterSetName = value;
				}
			}

			public List<DescribeDbList_Account> Accounts
			{
				get
				{
					return accounts;
				}
				set	
				{
					accounts = value;
				}
			}

			public class DescribeDbList_Account
			{

				private string accountPrivilege;

				private string accountName;

				public string AccountPrivilege
				{
					get
					{
						return accountPrivilege;
					}
					set	
					{
						accountPrivilege = value;
					}
				}

				public string AccountName
				{
					get
					{
						return accountName;
					}
					set	
					{
						accountName = value;
					}
				}
			}
		}
	}
}
