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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveRegistrantProfileRequest : RpcAcsRequest<SaveRegistrantProfileResponse>
    {
        public SaveRegistrantProfileRequest()
            : base("Domain", "2018-01-29", "SaveRegistrantProfile", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string country;

		private string city;

		private long? registrantProfileId;

		private string zhCity;

		private string telExt;

		private string province;

		private string zhRegistrantName;

		private string postalCode;

		private string lang;

		private string email;

		private string zhRegistrantOrganization;

		private string address;

		private string telArea;

		private string zhAddress;

		private string registrantType;

		private string registrantProfileType;

		private string telephone;

		private bool? defaultRegistrantProfile;

		private string zhProvince;

		private string registrantOrganization;

		private string userClientIp;

		private string registrantName;

		[JsonProperty(PropertyName = "Country")]
		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		[JsonProperty(PropertyName = "City")]
		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantProfileId")]
		public long? RegistrantProfileId
		{
			get
			{
				return registrantProfileId;
			}
			set	
			{
				registrantProfileId = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ZhCity")]
		public string ZhCity
		{
			get
			{
				return zhCity;
			}
			set	
			{
				zhCity = value;
				DictionaryUtil.Add(QueryParameters, "ZhCity", value);
			}
		}

		[JsonProperty(PropertyName = "TelExt")]
		public string TelExt
		{
			get
			{
				return telExt;
			}
			set	
			{
				telExt = value;
				DictionaryUtil.Add(QueryParameters, "TelExt", value);
			}
		}

		[JsonProperty(PropertyName = "Province")]
		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(QueryParameters, "Province", value);
			}
		}

		[JsonProperty(PropertyName = "ZhRegistrantName")]
		public string ZhRegistrantName
		{
			get
			{
				return zhRegistrantName;
			}
			set	
			{
				zhRegistrantName = value;
				DictionaryUtil.Add(QueryParameters, "ZhRegistrantName", value);
			}
		}

		[JsonProperty(PropertyName = "PostalCode")]
		public string PostalCode
		{
			get
			{
				return postalCode;
			}
			set	
			{
				postalCode = value;
				DictionaryUtil.Add(QueryParameters, "PostalCode", value);
			}
		}

		[JsonProperty(PropertyName = "Lang")]
		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		[JsonProperty(PropertyName = "Email")]
		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "ZhRegistrantOrganization")]
		public string ZhRegistrantOrganization
		{
			get
			{
				return zhRegistrantOrganization;
			}
			set	
			{
				zhRegistrantOrganization = value;
				DictionaryUtil.Add(QueryParameters, "ZhRegistrantOrganization", value);
			}
		}

		[JsonProperty(PropertyName = "Address")]
		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		[JsonProperty(PropertyName = "TelArea")]
		public string TelArea
		{
			get
			{
				return telArea;
			}
			set	
			{
				telArea = value;
				DictionaryUtil.Add(QueryParameters, "TelArea", value);
			}
		}

		[JsonProperty(PropertyName = "ZhAddress")]
		public string ZhAddress
		{
			get
			{
				return zhAddress;
			}
			set	
			{
				zhAddress = value;
				DictionaryUtil.Add(QueryParameters, "ZhAddress", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantType")]
		public string RegistrantType
		{
			get
			{
				return registrantType;
			}
			set	
			{
				registrantType = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantType", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantProfileType")]
		public string RegistrantProfileType
		{
			get
			{
				return registrantProfileType;
			}
			set	
			{
				registrantProfileType = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileType", value);
			}
		}

		[JsonProperty(PropertyName = "Telephone")]
		public string Telephone
		{
			get
			{
				return telephone;
			}
			set	
			{
				telephone = value;
				DictionaryUtil.Add(QueryParameters, "Telephone", value);
			}
		}

		[JsonProperty(PropertyName = "DefaultRegistrantProfile")]
		public bool? DefaultRegistrantProfile
		{
			get
			{
				return defaultRegistrantProfile;
			}
			set	
			{
				defaultRegistrantProfile = value;
				DictionaryUtil.Add(QueryParameters, "DefaultRegistrantProfile", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ZhProvince")]
		public string ZhProvince
		{
			get
			{
				return zhProvince;
			}
			set	
			{
				zhProvince = value;
				DictionaryUtil.Add(QueryParameters, "ZhProvince", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantOrganization")]
		public string RegistrantOrganization
		{
			get
			{
				return registrantOrganization;
			}
			set	
			{
				registrantOrganization = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantOrganization", value);
			}
		}

		[JsonProperty(PropertyName = "UserClientIp")]
		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantName")]
		public string RegistrantName
		{
			get
			{
				return registrantName;
			}
			set	
			{
				registrantName = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantName", value);
			}
		}

        public override SaveRegistrantProfileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveRegistrantProfileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
