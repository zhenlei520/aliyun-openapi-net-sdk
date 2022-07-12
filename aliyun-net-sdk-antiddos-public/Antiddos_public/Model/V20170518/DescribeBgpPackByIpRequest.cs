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
using Aliyun.Acs.antiddos_public;
using Aliyun.Acs.antiddos_public.Transform;
using Aliyun.Acs.antiddos_public.Transform.V20170518;

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
    public class DescribeBgpPackByIpRequest : RpcAcsRequest<DescribeBgpPackByIpResponse>
    {
        public DescribeBgpPackByIpRequest()
            : base("antiddos-public", "2017-05-18", "DescribeBgpPackByIp")
        {
			Method = MethodType.POST;
        }

		private string ddosRegionId;

		private string ip;

		public string DdosRegionId
		{
			get
			{
				return ddosRegionId;
			}
			set	
			{
				ddosRegionId = value;
				DictionaryUtil.Add(QueryParameters, "DdosRegionId", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

        public override DescribeBgpPackByIpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeBgpPackByIpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
