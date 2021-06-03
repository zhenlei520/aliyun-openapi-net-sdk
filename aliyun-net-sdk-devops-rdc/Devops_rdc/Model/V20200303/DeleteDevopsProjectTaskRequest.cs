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
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class DeleteDevopsProjectTaskRequest : RpcAcsRequest<DeleteDevopsProjectTaskResponse>
    {
        public DeleteDevopsProjectTaskRequest()
            : base("devops-rdc", "2020-03-03", "DeleteDevopsProjectTask", "1.9.6", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string orgId;

		private string taskId;

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "TaskId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteDevopsProjectTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteDevopsProjectTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
