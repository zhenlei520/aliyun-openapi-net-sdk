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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class GetVpnGatewayDiagnoseResultResponseUnmarshaller
    {
        public static GetVpnGatewayDiagnoseResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpnGatewayDiagnoseResultResponse getVpnGatewayDiagnoseResultResponse = new GetVpnGatewayDiagnoseResultResponse();

			getVpnGatewayDiagnoseResultResponse.HttpResponse = _ctx.HttpResponse;
			getVpnGatewayDiagnoseResultResponse.BeginTime = _ctx.StringValue("GetVpnGatewayDiagnoseResult.BeginTime");
			getVpnGatewayDiagnoseResultResponse.DiagnoseId = _ctx.StringValue("GetVpnGatewayDiagnoseResult.DiagnoseId");
			getVpnGatewayDiagnoseResultResponse.FinishTime = _ctx.StringValue("GetVpnGatewayDiagnoseResult.FinishTime");
			getVpnGatewayDiagnoseResultResponse.FinishedCount = _ctx.IntegerValue("GetVpnGatewayDiagnoseResult.FinishedCount");
			getVpnGatewayDiagnoseResultResponse.RequestId = _ctx.StringValue("GetVpnGatewayDiagnoseResult.RequestId");
			getVpnGatewayDiagnoseResultResponse.ResourceInstanceId = _ctx.StringValue("GetVpnGatewayDiagnoseResult.ResourceInstanceId");
			getVpnGatewayDiagnoseResultResponse.ResourceType = _ctx.StringValue("GetVpnGatewayDiagnoseResult.ResourceType");
			getVpnGatewayDiagnoseResultResponse.TotalCount = _ctx.IntegerValue("GetVpnGatewayDiagnoseResult.TotalCount");
			getVpnGatewayDiagnoseResultResponse.VpnGatewayId = _ctx.StringValue("GetVpnGatewayDiagnoseResult.VpnGatewayId");

			List<GetVpnGatewayDiagnoseResultResponse.GetVpnGatewayDiagnoseResult_DiagnoseResultItem> getVpnGatewayDiagnoseResultResponse_diagnoseResult = new List<GetVpnGatewayDiagnoseResultResponse.GetVpnGatewayDiagnoseResult_DiagnoseResultItem>();
			for (int i = 0; i < _ctx.Length("GetVpnGatewayDiagnoseResult.DiagnoseResult.Length"); i++) {
				GetVpnGatewayDiagnoseResultResponse.GetVpnGatewayDiagnoseResult_DiagnoseResultItem diagnoseResultItem = new GetVpnGatewayDiagnoseResultResponse.GetVpnGatewayDiagnoseResult_DiagnoseResultItem();
				diagnoseResultItem.DiagnoseName = _ctx.StringValue("GetVpnGatewayDiagnoseResult.DiagnoseResult["+ i +"].DiagnoseName");
				diagnoseResultItem.DiagnoseResultDescription = _ctx.StringValue("GetVpnGatewayDiagnoseResult.DiagnoseResult["+ i +"].DiagnoseResultDescription");
				diagnoseResultItem.DiagnoseResultLevel = _ctx.StringValue("GetVpnGatewayDiagnoseResult.DiagnoseResult["+ i +"].DiagnoseResultLevel");

				getVpnGatewayDiagnoseResultResponse_diagnoseResult.Add(diagnoseResultItem);
			}
			getVpnGatewayDiagnoseResultResponse.DiagnoseResult = getVpnGatewayDiagnoseResultResponse_diagnoseResult;
        
			return getVpnGatewayDiagnoseResultResponse;
        }
    }
}
