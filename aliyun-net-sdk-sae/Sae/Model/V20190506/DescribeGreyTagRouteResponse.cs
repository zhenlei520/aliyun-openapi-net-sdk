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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeGreyTagRouteResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeGreyTagRoute_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public DescribeGreyTagRoute_Data Data
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

		public class DescribeGreyTagRoute_Data
		{

			private long? greyTagRouteId;

			private string name;

			private string description;

			private long? createTime;

			private long? updateTime;

			private string appId;

			private List<DescribeGreyTagRoute_ScRule> scRules;

			private List<DescribeGreyTagRoute_AlbRule> albRules;

			private List<DescribeGreyTagRoute_DubboRule> dubboRules;

			public long? GreyTagRouteId
			{
				get
				{
					return greyTagRouteId;
				}
				set	
				{
					greyTagRouteId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public List<DescribeGreyTagRoute_ScRule> ScRules
			{
				get
				{
					return scRules;
				}
				set	
				{
					scRules = value;
				}
			}

			public List<DescribeGreyTagRoute_AlbRule> AlbRules
			{
				get
				{
					return albRules;
				}
				set	
				{
					albRules = value;
				}
			}

			public List<DescribeGreyTagRoute_DubboRule> DubboRules
			{
				get
				{
					return dubboRules;
				}
				set	
				{
					dubboRules = value;
				}
			}

			public class DescribeGreyTagRoute_ScRule
			{

				private string path;

				private string condition;

				private List<DescribeGreyTagRoute_Scrulesitem> items;

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public string Condition
				{
					get
					{
						return condition;
					}
					set	
					{
						condition = value;
					}
				}

				public List<DescribeGreyTagRoute_Scrulesitem> Items
				{
					get
					{
						return items;
					}
					set	
					{
						items = value;
					}
				}

				public class DescribeGreyTagRoute_Scrulesitem
				{

					private string type;

					private string name;

					private string _operator;

					private string _value;

					private string cond;

					private int? index;

					private string expr;

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public string Cond
					{
						get
						{
							return cond;
						}
						set	
						{
							cond = value;
						}
					}

					public int? Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
						}
					}

					public string Expr
					{
						get
						{
							return expr;
						}
						set	
						{
							expr = value;
						}
					}
				}
			}

			public class DescribeGreyTagRoute_AlbRule
			{

				private string serviceId;

				private string ingressId;

				private string condition;

				private List<DescribeGreyTagRoute_Scrulesitem2> items1;

				public string ServiceId
				{
					get
					{
						return serviceId;
					}
					set	
					{
						serviceId = value;
					}
				}

				public string IngressId
				{
					get
					{
						return ingressId;
					}
					set	
					{
						ingressId = value;
					}
				}

				public string Condition
				{
					get
					{
						return condition;
					}
					set	
					{
						condition = value;
					}
				}

				public List<DescribeGreyTagRoute_Scrulesitem2> Items1
				{
					get
					{
						return items1;
					}
					set	
					{
						items1 = value;
					}
				}

				public class DescribeGreyTagRoute_Scrulesitem2
				{

					private string type;

					private string name;

					private string _operator;

					private string _value;

					private string cond;

					private int? index;

					private string expr;

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public string Cond
					{
						get
						{
							return cond;
						}
						set	
						{
							cond = value;
						}
					}

					public int? Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
						}
					}

					public string Expr
					{
						get
						{
							return expr;
						}
						set	
						{
							expr = value;
						}
					}
				}
			}

			public class DescribeGreyTagRoute_DubboRule
			{

				private string serviceName;

				private string group;

				private string version;

				private string methodName;

				private string condition;

				private List<DescribeGreyTagRoute_Item> items3;

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string Group
				{
					get
					{
						return group;
					}
					set	
					{
						group = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string MethodName
				{
					get
					{
						return methodName;
					}
					set	
					{
						methodName = value;
					}
				}

				public string Condition
				{
					get
					{
						return condition;
					}
					set	
					{
						condition = value;
					}
				}

				public List<DescribeGreyTagRoute_Item> Items3
				{
					get
					{
						return items3;
					}
					set	
					{
						items3 = value;
					}
				}

				public class DescribeGreyTagRoute_Item
				{

					private int? index;

					private string expr;

					private string _operator;

					private string _value;

					private string cond;

					private string type;

					private string name;

					public int? Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
						}
					}

					public string Expr
					{
						get
						{
							return expr;
						}
						set	
						{
							expr = value;
						}
					}

					public string _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public string Cond
					{
						get
						{
							return cond;
						}
						set	
						{
							cond = value;
						}
					}

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}
				}
			}
		}
	}
}
