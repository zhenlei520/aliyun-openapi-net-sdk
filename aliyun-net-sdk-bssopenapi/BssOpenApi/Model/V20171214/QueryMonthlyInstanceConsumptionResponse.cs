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
	public class QueryMonthlyInstanceConsumptionResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryMonthlyInstanceConsumption_Data data;

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

		public QueryMonthlyInstanceConsumption_Data Data
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

		public class QueryMonthlyInstanceConsumption_Data
		{

			private int? pageNum;

			private string billingCycle;

			private int? pageSize;

			private int? totalCount;

			private List<QueryMonthlyInstanceConsumption_Item> items;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			public string BillingCycle
			{
				get
				{
					return billingCycle;
				}
				set	
				{
					billingCycle = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
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

			public List<QueryMonthlyInstanceConsumption_Item> Items
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

			public class QueryMonthlyInstanceConsumption_Item
			{

				private float? pretaxAmount;

				private float? discountAmount;

				private string payerAccount;

				private string tag;

				private string instanceID;

				private string currency;

				private string subscriptionType;

				private string paymentCurrency;

				private string ownerID;

				private string productType;

				private string region;

				private float? afterTaxAmount;

				private float? pretaxGrossAmount;

				private string resourceGroup;

				private float? tax;

				private float? pretaxAmountLocal;

				private string productCode;

				public float? PretaxAmount
				{
					get
					{
						return pretaxAmount;
					}
					set	
					{
						pretaxAmount = value;
					}
				}

				public float? DiscountAmount
				{
					get
					{
						return discountAmount;
					}
					set	
					{
						discountAmount = value;
					}
				}

				public string PayerAccount
				{
					get
					{
						return payerAccount;
					}
					set	
					{
						payerAccount = value;
					}
				}

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public string InstanceID
				{
					get
					{
						return instanceID;
					}
					set	
					{
						instanceID = value;
					}
				}

				public string Currency
				{
					get
					{
						return currency;
					}
					set	
					{
						currency = value;
					}
				}

				public string SubscriptionType
				{
					get
					{
						return subscriptionType;
					}
					set	
					{
						subscriptionType = value;
					}
				}

				public string PaymentCurrency
				{
					get
					{
						return paymentCurrency;
					}
					set	
					{
						paymentCurrency = value;
					}
				}

				public string OwnerID
				{
					get
					{
						return ownerID;
					}
					set	
					{
						ownerID = value;
					}
				}

				public string ProductType
				{
					get
					{
						return productType;
					}
					set	
					{
						productType = value;
					}
				}

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

				public float? AfterTaxAmount
				{
					get
					{
						return afterTaxAmount;
					}
					set	
					{
						afterTaxAmount = value;
					}
				}

				public float? PretaxGrossAmount
				{
					get
					{
						return pretaxGrossAmount;
					}
					set	
					{
						pretaxGrossAmount = value;
					}
				}

				public string ResourceGroup
				{
					get
					{
						return resourceGroup;
					}
					set	
					{
						resourceGroup = value;
					}
				}

				public float? Tax
				{
					get
					{
						return tax;
					}
					set	
					{
						tax = value;
					}
				}

				public float? PretaxAmountLocal
				{
					get
					{
						return pretaxAmountLocal;
					}
					set	
					{
						pretaxAmountLocal = value;
					}
				}

				public string ProductCode
				{
					get
					{
						return productCode;
					}
					set	
					{
						productCode = value;
					}
				}
			}
		}
	}
}
