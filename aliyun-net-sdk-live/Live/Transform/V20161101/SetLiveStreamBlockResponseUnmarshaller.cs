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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class SetLiveStreamBlockResponseUnmarshaller
    {
        public static SetLiveStreamBlockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetLiveStreamBlockResponse setLiveStreamBlockResponse = new SetLiveStreamBlockResponse();

			setLiveStreamBlockResponse.HttpResponse = _ctx.HttpResponse;
			setLiveStreamBlockResponse.Description = _ctx.StringValue("SetLiveStreamBlock.Description");
			setLiveStreamBlockResponse.RequestId = _ctx.StringValue("SetLiveStreamBlock.RequestId");
			setLiveStreamBlockResponse.Status = _ctx.StringValue("SetLiveStreamBlock.Status");
        
			return setLiveStreamBlockResponse;
        }
    }
}
