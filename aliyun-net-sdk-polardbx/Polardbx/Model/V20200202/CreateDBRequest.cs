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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class CreateDBRequest : RpcAcsRequest<CreateDBResponse>
    {
        public CreateDBRequest()
            : base("polardbx", "2020-02-02", "CreateDB", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBInstanceName;

		private string charset;

		private string securityAccountPassword;

		private string accountPrivilege;

		private string mode;

		private string accountName;

		private string securityAccountName;

		private string dbDescription;

		private string dbName;

		private string storagePoolName;

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		public string Charset
		{
			get
			{
				return charset;
			}
			set	
			{
				charset = value;
				DictionaryUtil.Add(QueryParameters, "Charset", value);
			}
		}

		public string SecurityAccountPassword
		{
			get
			{
				return securityAccountPassword;
			}
			set	
			{
				securityAccountPassword = value;
				DictionaryUtil.Add(QueryParameters, "SecurityAccountPassword", value);
			}
		}

		public string AccountPrivilege
		{
			get
			{
				return accountPrivilege;
			}
			set	
			{
				accountPrivilege = value;
				DictionaryUtil.Add(QueryParameters, "AccountPrivilege", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
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
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string SecurityAccountName
		{
			get
			{
				return securityAccountName;
			}
			set	
			{
				securityAccountName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityAccountName", value);
			}
		}

		public string DbDescription
		{
			get
			{
				return dbDescription;
			}
			set	
			{
				dbDescription = value;
				DictionaryUtil.Add(QueryParameters, "DbDescription", value);
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(QueryParameters, "DbName", value);
			}
		}

		public string StoragePoolName
		{
			get
			{
				return storagePoolName;
			}
			set	
			{
				storagePoolName = value;
				DictionaryUtil.Add(QueryParameters, "StoragePoolName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDBResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDBResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
