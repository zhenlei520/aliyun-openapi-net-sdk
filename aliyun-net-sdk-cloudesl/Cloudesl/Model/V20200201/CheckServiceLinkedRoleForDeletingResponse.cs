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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class CheckServiceLinkedRoleForDeletingResponse : AcsResponse
	{

		private bool? deletable;

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private string errorMessage;

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private List<CheckServiceLinkedRoleForDeleting_RoleUsage> roleUsages;

		public bool? Deletable
		{
			get
			{
				return deletable;
			}
			set	
			{
				deletable = value;
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public List<CheckServiceLinkedRoleForDeleting_RoleUsage> RoleUsages
		{
			get
			{
				return roleUsages;
			}
			set	
			{
				roleUsages = value;
			}
		}

		public class CheckServiceLinkedRoleForDeleting_RoleUsage
		{

			private string region;

			private string resources;

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}
		}
	}
}
