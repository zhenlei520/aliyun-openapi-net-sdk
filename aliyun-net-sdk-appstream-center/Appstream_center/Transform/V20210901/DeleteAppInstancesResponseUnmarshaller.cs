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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class DeleteAppInstancesResponseUnmarshaller
    {
        public static DeleteAppInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteAppInstancesResponse deleteAppInstancesResponse = new DeleteAppInstancesResponse();

			deleteAppInstancesResponse.HttpResponse = _ctx.HttpResponse;
			deleteAppInstancesResponse.RequestId = _ctx.StringValue("DeleteAppInstances.RequestId");

			List<DeleteAppInstancesResponse.DeleteAppInstances_Data> deleteAppInstancesResponse_deleteAppInstanceModels = new List<DeleteAppInstancesResponse.DeleteAppInstances_Data>();
			for (int i = 0; i < _ctx.Length("DeleteAppInstances.DeleteAppInstanceModels.Length"); i++) {
				DeleteAppInstancesResponse.DeleteAppInstances_Data data = new DeleteAppInstancesResponse.DeleteAppInstances_Data();
				data.AppInstanceId = _ctx.StringValue("DeleteAppInstances.DeleteAppInstanceModels["+ i +"].AppInstanceId");
				data.Success = _ctx.BooleanValue("DeleteAppInstances.DeleteAppInstanceModels["+ i +"].Success");
				data.Code = _ctx.StringValue("DeleteAppInstances.DeleteAppInstanceModels["+ i +"].Code");
				data.Message = _ctx.StringValue("DeleteAppInstances.DeleteAppInstanceModels["+ i +"].Message");

				deleteAppInstancesResponse_deleteAppInstanceModels.Add(data);
			}
			deleteAppInstancesResponse.DeleteAppInstanceModels = deleteAppInstancesResponse_deleteAppInstanceModels;
        
			return deleteAppInstancesResponse;
        }
    }
}
