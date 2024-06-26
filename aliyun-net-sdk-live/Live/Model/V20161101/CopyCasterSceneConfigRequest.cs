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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class CopyCasterSceneConfigRequest : RpcAcsRequest<CopyCasterSceneConfigResponse>
    {
        public CopyCasterSceneConfigRequest()
            : base("live", "2016-11-01", "CopyCasterSceneConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fromSceneId;

		private string toSceneId;

		private string casterId;

		private long? ownerId;

		[JsonProperty(PropertyName = "FromSceneId")]
		public string FromSceneId
		{
			get
			{
				return fromSceneId;
			}
			set	
			{
				fromSceneId = value;
				DictionaryUtil.Add(QueryParameters, "FromSceneId", value);
			}
		}

		[JsonProperty(PropertyName = "ToSceneId")]
		public string ToSceneId
		{
			get
			{
				return toSceneId;
			}
			set	
			{
				toSceneId = value;
				DictionaryUtil.Add(QueryParameters, "ToSceneId", value);
			}
		}

		[JsonProperty(PropertyName = "CasterId")]
		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override CopyCasterSceneConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CopyCasterSceneConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
