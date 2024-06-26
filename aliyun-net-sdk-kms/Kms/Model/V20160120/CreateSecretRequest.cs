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
    public class CreateSecretRequest : RpcAcsRequest<CreateSecretResponse>
    {
        public CreateSecretRequest()
            : base("Kms", "2016-01-20", "CreateSecret", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Kms.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string secretType;

		private string description;

		private string rotationInterval;

		private bool? enableAutomaticRotation;

		private string encryptionKeyId;

		private string tags;

		private string extendedConfig;

		private string versionId;

		private string dKMSInstanceId;

		private string secretData;

		private string secretName;

		private string secretDataType;

		private string policy;

		[JsonProperty(PropertyName = "SecretType")]
		public string SecretType
		{
			get
			{
				return secretType;
			}
			set	
			{
				secretType = value;
				DictionaryUtil.Add(QueryParameters, "SecretType", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "RotationInterval")]
		public string RotationInterval
		{
			get
			{
				return rotationInterval;
			}
			set	
			{
				rotationInterval = value;
				DictionaryUtil.Add(QueryParameters, "RotationInterval", value);
			}
		}

		[JsonProperty(PropertyName = "EnableAutomaticRotation")]
		public bool? EnableAutomaticRotation
		{
			get
			{
				return enableAutomaticRotation;
			}
			set	
			{
				enableAutomaticRotation = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutomaticRotation", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EncryptionKeyId")]
		public string EncryptionKeyId
		{
			get
			{
				return encryptionKeyId;
			}
			set	
			{
				encryptionKeyId = value;
				DictionaryUtil.Add(QueryParameters, "EncryptionKeyId", value);
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "ExtendedConfig")]
		public string ExtendedConfig
		{
			get
			{
				return extendedConfig;
			}
			set	
			{
				extendedConfig = value;
				DictionaryUtil.Add(QueryParameters, "ExtendedConfig", value);
			}
		}

		[JsonProperty(PropertyName = "VersionId")]
		public string VersionId
		{
			get
			{
				return versionId;
			}
			set	
			{
				versionId = value;
				DictionaryUtil.Add(QueryParameters, "VersionId", value);
			}
		}

		[JsonProperty(PropertyName = "DKMSInstanceId")]
		public string DKMSInstanceId
		{
			get
			{
				return dKMSInstanceId;
			}
			set	
			{
				dKMSInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DKMSInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "SecretData")]
		public string SecretData
		{
			get
			{
				return secretData;
			}
			set	
			{
				secretData = value;
				DictionaryUtil.Add(QueryParameters, "SecretData", value);
			}
		}

		[JsonProperty(PropertyName = "SecretName")]
		public string SecretName
		{
			get
			{
				return secretName;
			}
			set	
			{
				secretName = value;
				DictionaryUtil.Add(QueryParameters, "SecretName", value);
			}
		}

		[JsonProperty(PropertyName = "SecretDataType")]
		public string SecretDataType
		{
			get
			{
				return secretDataType;
			}
			set	
			{
				secretDataType = value;
				DictionaryUtil.Add(QueryParameters, "SecretDataType", value);
			}
		}

		[JsonProperty(PropertyName = "Policy")]
		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
				DictionaryUtil.Add(QueryParameters, "Policy", value);
			}
		}

        public override CreateSecretResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSecretResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
