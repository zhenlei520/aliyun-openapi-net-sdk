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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class CheckAliyunAccountExistsResponseUnmarshaller
    {
        public static CheckAliyunAccountExistsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckAliyunAccountExistsResponse checkAliyunAccountExistsResponse = new CheckAliyunAccountExistsResponse();

			checkAliyunAccountExistsResponse.HttpResponse = _ctx.HttpResponse;
			checkAliyunAccountExistsResponse.ErrorMsg = _ctx.StringValue("CheckAliyunAccountExists.ErrorMsg");
			checkAliyunAccountExistsResponse.RequestId = _ctx.StringValue("CheckAliyunAccountExists.RequestId");
			checkAliyunAccountExistsResponse._Object = _ctx.BooleanValue("CheckAliyunAccountExists.Object");
			checkAliyunAccountExistsResponse.Successful = _ctx.BooleanValue("CheckAliyunAccountExists.Successful");
			checkAliyunAccountExistsResponse.ErrorCode = _ctx.StringValue("CheckAliyunAccountExists.ErrorCode");
        
			return checkAliyunAccountExistsResponse;
        }
    }
}
