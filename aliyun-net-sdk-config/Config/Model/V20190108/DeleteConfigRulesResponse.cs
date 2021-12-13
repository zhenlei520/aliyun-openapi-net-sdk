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

namespace Aliyun.Acs.Config.Model.V20190108
{
	public class DeleteConfigRulesResponse : AcsResponse
	{

		private string requestId;

		private DeleteConfigRules_OperateRuleResult operateRuleResult;

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

		public DeleteConfigRules_OperateRuleResult OperateRuleResult
		{
			get
			{
				return operateRuleResult;
			}
			set	
			{
				operateRuleResult = value;
			}
		}

		public class DeleteConfigRules_OperateRuleResult
		{

			private List<DeleteConfigRules_OperateRuleItem> operateRuleItemList;

			public List<DeleteConfigRules_OperateRuleItem> OperateRuleItemList
			{
				get
				{
					return operateRuleItemList;
				}
				set	
				{
					operateRuleItemList = value;
				}
			}

			public class DeleteConfigRules_OperateRuleItem
			{

				private string errorCode;

				private bool? success;

				private string configRuleId;

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

				public string ConfigRuleId
				{
					get
					{
						return configRuleId;
					}
					set	
					{
						configRuleId = value;
					}
				}
			}
		}
	}
}
