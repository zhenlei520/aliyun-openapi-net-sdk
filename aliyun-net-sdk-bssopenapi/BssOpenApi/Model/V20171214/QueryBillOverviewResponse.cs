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
	public class QueryBillOverviewResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryBillOverview_Data data;

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

		public QueryBillOverview_Data Data
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

		public class QueryBillOverview_Data
		{

			private string billingCycle;

			private string accountID;

			private string accountName;

			private List<QueryBillOverview_Item> items;

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

			public string AccountID
			{
				get
				{
					return accountID;
				}
				set	
				{
					accountID = value;
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

			public List<QueryBillOverview_Item> Items
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

			public class QueryBillOverview_Item
			{

				private string roundDownDiscount;

				private string item;

				private string currency;

				private string subscriptionType;

				private float? deductedByCashCoupons;

				private string billAccountName;

				private string bizType;

				private float? deductedByCoupons;

				private float? outstandingAmount;

				private float? afterTaxAmount;

				private float? pretaxAmountLocal;

				private float? tax;

				private string pipCode;

				private float? pretaxAmount;

				private string productName;

				private string commodityCode;

				private float? adjustAmount;

				private string productDetail;

				private string paymentCurrency;

				private string ownerID;

				private float? deductedByPrepaidCard;

				private string productType;

				private float? invoiceDiscount;

				private float? paymentAmount;

				private string billAccountID;

				private float? pretaxGrossAmount;

				private float? cashAmount;

				private string productCode;

				public string RoundDownDiscount
				{
					get
					{
						return roundDownDiscount;
					}
					set	
					{
						roundDownDiscount = value;
					}
				}

				public string Item
				{
					get
					{
						return item;
					}
					set	
					{
						item = value;
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

				public float? DeductedByCashCoupons
				{
					get
					{
						return deductedByCashCoupons;
					}
					set	
					{
						deductedByCashCoupons = value;
					}
				}

				public string BillAccountName
				{
					get
					{
						return billAccountName;
					}
					set	
					{
						billAccountName = value;
					}
				}

				public string BizType
				{
					get
					{
						return bizType;
					}
					set	
					{
						bizType = value;
					}
				}

				public float? DeductedByCoupons
				{
					get
					{
						return deductedByCoupons;
					}
					set	
					{
						deductedByCoupons = value;
					}
				}

				public float? OutstandingAmount
				{
					get
					{
						return outstandingAmount;
					}
					set	
					{
						outstandingAmount = value;
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

				public string PipCode
				{
					get
					{
						return pipCode;
					}
					set	
					{
						pipCode = value;
					}
				}

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

				public string ProductName
				{
					get
					{
						return productName;
					}
					set	
					{
						productName = value;
					}
				}

				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				public float? AdjustAmount
				{
					get
					{
						return adjustAmount;
					}
					set	
					{
						adjustAmount = value;
					}
				}

				public string ProductDetail
				{
					get
					{
						return productDetail;
					}
					set	
					{
						productDetail = value;
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

				public float? DeductedByPrepaidCard
				{
					get
					{
						return deductedByPrepaidCard;
					}
					set	
					{
						deductedByPrepaidCard = value;
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

				public float? InvoiceDiscount
				{
					get
					{
						return invoiceDiscount;
					}
					set	
					{
						invoiceDiscount = value;
					}
				}

				public float? PaymentAmount
				{
					get
					{
						return paymentAmount;
					}
					set	
					{
						paymentAmount = value;
					}
				}

				public string BillAccountID
				{
					get
					{
						return billAccountID;
					}
					set	
					{
						billAccountID = value;
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

				public float? CashAmount
				{
					get
					{
						return cashAmount;
					}
					set	
					{
						cashAmount = value;
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
