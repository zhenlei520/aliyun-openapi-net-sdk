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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ModifyUserResponseUnmarshaller
    {
        public static ModifyUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyUserResponse modifyUserResponse = new ModifyUserResponse();

			modifyUserResponse.HttpResponse = _ctx.HttpResponse;
			modifyUserResponse.RequestId = _ctx.StringValue("ModifyUser.RequestId");
			modifyUserResponse.Success = _ctx.BooleanValue("ModifyUser.Success");
			modifyUserResponse.Code = _ctx.StringValue("ModifyUser.Code");
			modifyUserResponse.Message = _ctx.StringValue("ModifyUser.Message");
			modifyUserResponse.HttpStatusCode = _ctx.IntegerValue("ModifyUser.HttpStatusCode");
        
			return modifyUserResponse;
        }
    }
}