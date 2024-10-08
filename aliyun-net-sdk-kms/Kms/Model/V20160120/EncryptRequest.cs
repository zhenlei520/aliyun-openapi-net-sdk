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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class EncryptRequest : RpcAcsRequest<EncryptResponse>
    {
        public EncryptRequest()
            : base("Kms", "2016-01-20", "Encrypt", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string dryRun;

		private string keyId;

		private string plaintext;

		private string encryptionContext;

		[JsonProperty(PropertyName = "DryRun")]
		public string DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value);
			}
		}

		[JsonProperty(PropertyName = "KeyId")]
		public string KeyId
		{
			get
			{
				return keyId;
			}
			set	
			{
				keyId = value;
				DictionaryUtil.Add(QueryParameters, "KeyId", value);
			}
		}

		[JsonProperty(PropertyName = "Plaintext")]
		public string Plaintext
		{
			get
			{
				return plaintext;
			}
			set	
			{
				plaintext = value;
				DictionaryUtil.Add(QueryParameters, "Plaintext", value);
			}
		}

		[JsonProperty(PropertyName = "EncryptionContext")]
		public string EncryptionContext
		{
			get
			{
				return encryptionContext;
			}
			set	
			{
				encryptionContext = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionContext", value);
			}
		}

        public override EncryptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EncryptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
