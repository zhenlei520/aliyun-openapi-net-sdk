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
using Aliyun.Acs.dms_dg;
using Aliyun.Acs.dms_dg.Transform;
using Aliyun.Acs.dms_dg.Transform.V20230914;

namespace Aliyun.Acs.dms_dg.Model.V20230914
{
    public class DeleteDatabaseRequest : RpcAcsRequest<DeleteDatabaseResponse>
    {
        public DeleteDatabaseRequest()
            : base("dms-dg", "2023-09-14", "DeleteDatabase")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string instanceId;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

        public override DeleteDatabaseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteDatabaseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
