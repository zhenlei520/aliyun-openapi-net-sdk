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
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class ApproveOtaTaskRequest : RpcAcsRequest<ApproveOtaTaskResponse>
    {
        public ApproveOtaTaskRequest()
            : base("appstream-center", "2021-09-01", "ApproveOtaTask")
        {
			Method = MethodType.POST;
        }

		private string bizRegionId;

		private string otaType;

		private string startTime;

		private string appInstanceGroupId;

		private string taskId;

		public string BizRegionId
		{
			get
			{
				return bizRegionId;
			}
			set	
			{
				bizRegionId = value;
				DictionaryUtil.Add(BodyParameters, "BizRegionId", value);
			}
		}

		public string OtaType
		{
			get
			{
				return otaType;
			}
			set	
			{
				otaType = value;
				DictionaryUtil.Add(BodyParameters, "OtaType", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		public string AppInstanceGroupId
		{
			get
			{
				return appInstanceGroupId;
			}
			set	
			{
				appInstanceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "AppInstanceGroupId", value);
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

        public override ApproveOtaTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApproveOtaTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
