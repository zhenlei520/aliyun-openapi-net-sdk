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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QueryAccountTransactionsRequest : RpcAcsRequest<QueryAccountTransactionsResponse>
    {
        public QueryAccountTransactionsRequest()
            : base("BssOpenApi", "2017-12-14", "QueryAccountTransactions", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNum;

		private string transactionType;

		private string createTimeEnd;

		private string recordID;

		private int? pageSize;

		private string transactionChannel;

		private string transactionChannelSN;

		private string createTimeStart;

		private string transactionNumber;

		private string transactionFlow;

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TransactionType")]
		public string TransactionType
		{
			get
			{
				return transactionType;
			}
			set	
			{
				transactionType = value;
				DictionaryUtil.Add(QueryParameters, "TransactionType", value);
			}
		}

		[JsonProperty(PropertyName = "CreateTimeEnd")]
		public string CreateTimeEnd
		{
			get
			{
				return createTimeEnd;
			}
			set	
			{
				createTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeEnd", value);
			}
		}

		[JsonProperty(PropertyName = "RecordID")]
		public string RecordID
		{
			get
			{
				return recordID;
			}
			set	
			{
				recordID = value;
				DictionaryUtil.Add(QueryParameters, "RecordID", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TransactionChannel")]
		public string TransactionChannel
		{
			get
			{
				return transactionChannel;
			}
			set	
			{
				transactionChannel = value;
				DictionaryUtil.Add(QueryParameters, "TransactionChannel", value);
			}
		}

		[JsonProperty(PropertyName = "TransactionChannelSN")]
		public string TransactionChannelSN
		{
			get
			{
				return transactionChannelSN;
			}
			set	
			{
				transactionChannelSN = value;
				DictionaryUtil.Add(QueryParameters, "TransactionChannelSN", value);
			}
		}

		[JsonProperty(PropertyName = "CreateTimeStart")]
		public string CreateTimeStart
		{
			get
			{
				return createTimeStart;
			}
			set	
			{
				createTimeStart = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeStart", value);
			}
		}

		[JsonProperty(PropertyName = "TransactionNumber")]
		public string TransactionNumber
		{
			get
			{
				return transactionNumber;
			}
			set	
			{
				transactionNumber = value;
				DictionaryUtil.Add(QueryParameters, "TransactionNumber", value);
			}
		}

		[JsonProperty(PropertyName = "TransactionFlow")]
		public string TransactionFlow
		{
			get
			{
				return transactionFlow;
			}
			set	
			{
				transactionFlow = value;
				DictionaryUtil.Add(QueryParameters, "TransactionFlow", value);
			}
		}

        public override QueryAccountTransactionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryAccountTransactionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
