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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class CreateFilePredictResponseUnmarshaller
    {
        public static CreateFilePredictResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFilePredictResponse createFilePredictResponse = new CreateFilePredictResponse();

			createFilePredictResponse.HttpResponse = _ctx.HttpResponse;
			createFilePredictResponse.RequestId = _ctx.StringValue("CreateFilePredict.RequestId");
			createFilePredictResponse.Message = _ctx.StringValue("CreateFilePredict.Message");
			createFilePredictResponse.Code = _ctx.StringValue("CreateFilePredict.Code");

			CreateFilePredictResponse.CreateFilePredict_Data data = new CreateFilePredictResponse.CreateFilePredict_Data();
			data.TaskId = _ctx.StringValue("CreateFilePredict.Data.TaskId");
			createFilePredictResponse.Data = data;
        
			return createFilePredictResponse;
        }
    }
}
