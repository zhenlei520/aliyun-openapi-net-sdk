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
using Aliyun.Acs.nis.Model.V20211216;

namespace Aliyun.Acs.nis.Transform.V20211216
{
    public class GetNetworkReachableAnalysisResponseUnmarshaller
    {
        public static GetNetworkReachableAnalysisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNetworkReachableAnalysisResponse getNetworkReachableAnalysisResponse = new GetNetworkReachableAnalysisResponse();

			getNetworkReachableAnalysisResponse.HttpResponse = _ctx.HttpResponse;
			getNetworkReachableAnalysisResponse.NetworkPathId = _ctx.StringValue("GetNetworkReachableAnalysis.NetworkPathId");
			getNetworkReachableAnalysisResponse.NetworkReachableAnalysisId = _ctx.StringValue("GetNetworkReachableAnalysis.NetworkReachableAnalysisId");
			getNetworkReachableAnalysisResponse.NetworkReachableAnalysisStatus = _ctx.StringValue("GetNetworkReachableAnalysis.NetworkReachableAnalysisStatus");
			getNetworkReachableAnalysisResponse.NetworkReachableAnalysisResult = _ctx.StringValue("GetNetworkReachableAnalysis.NetworkReachableAnalysisResult");
			getNetworkReachableAnalysisResponse.Reachable = _ctx.BooleanValue("GetNetworkReachableAnalysis.Reachable");
			getNetworkReachableAnalysisResponse.CreateTime = _ctx.StringValue("GetNetworkReachableAnalysis.CreateTime");
			getNetworkReachableAnalysisResponse.AliUid = _ctx.LongValue("GetNetworkReachableAnalysis.AliUid");
			getNetworkReachableAnalysisResponse.RequestId = _ctx.StringValue("GetNetworkReachableAnalysis.RequestId");
			getNetworkReachableAnalysisResponse.NetworkPathParameter = _ctx.StringValue("GetNetworkReachableAnalysis.NetworkPathParameter");
        
			return getNetworkReachableAnalysisResponse;
        }
    }
}
