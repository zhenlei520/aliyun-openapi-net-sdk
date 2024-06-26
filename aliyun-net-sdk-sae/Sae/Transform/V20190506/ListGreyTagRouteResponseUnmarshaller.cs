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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListGreyTagRouteResponseUnmarshaller
    {
        public static ListGreyTagRouteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGreyTagRouteResponse listGreyTagRouteResponse = new ListGreyTagRouteResponse();

			listGreyTagRouteResponse.HttpResponse = _ctx.HttpResponse;
			listGreyTagRouteResponse.RequestId = _ctx.StringValue("ListGreyTagRoute.RequestId");
			listGreyTagRouteResponse.Message = _ctx.StringValue("ListGreyTagRoute.Message");
			listGreyTagRouteResponse.TraceId = _ctx.StringValue("ListGreyTagRoute.TraceId");
			listGreyTagRouteResponse.ErrorCode = _ctx.StringValue("ListGreyTagRoute.ErrorCode");
			listGreyTagRouteResponse.Code = _ctx.StringValue("ListGreyTagRoute.Code");
			listGreyTagRouteResponse.Success = _ctx.BooleanValue("ListGreyTagRoute.Success");

			ListGreyTagRouteResponse.ListGreyTagRoute_Data data = new ListGreyTagRouteResponse.ListGreyTagRoute_Data();
			data.CurrentPage = _ctx.IntegerValue("ListGreyTagRoute.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("ListGreyTagRoute.Data.PageSize");
			data.TotalSize = _ctx.LongValue("ListGreyTagRoute.Data.TotalSize");

			List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem> data_result = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListGreyTagRoute.Data.Result.Length"); i++) {
				ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem resultItem = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem();
				resultItem.GreyTagRouteId = _ctx.LongValue("ListGreyTagRoute.Data.Result["+ i +"].GreyTagRouteId");
				resultItem.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].Name");
				resultItem.Description = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].Description");
				resultItem.CreateTime = _ctx.LongValue("ListGreyTagRoute.Data.Result["+ i +"].CreateTime");
				resultItem.UpdateTime = _ctx.LongValue("ListGreyTagRoute.Data.Result["+ i +"].UpdateTime");

				List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule> resultItem_scRules = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule>();
				for (int j = 0; j < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].ScRules.Length"); j++) {
					ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule scRule = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule();
					scRule.Path = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].path");
					scRule.Condition = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].condition");

					List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item> scRule_items = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item>();
					for (int k = 0; k < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items.Length"); k++) {
						ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item item = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_ScRule.ListGreyTagRoute_Item();
						item.Type = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].type");
						item.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].name");
						item._Operator = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].operator");
						item._Value = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].value");
						item.Cond = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].cond");
						item.Index = _ctx.IntegerValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].index");
						item.Expr = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].ScRules["+ j +"].Items["+ k +"].expr");

						scRule_items.Add(item);
					}
					scRule.Items = scRule_items;

					resultItem_scRules.Add(scRule);
				}
				resultItem.ScRules = resultItem_scRules;

				List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule> resultItem_albRules = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule>();
				for (int j = 0; j < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].AlbRules.Length"); j++) {
					ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule albRule = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule();
					albRule.ServiceId = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].serviceId");
					albRule.IngressId = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].ingressId");
					albRule.Condition = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].condition");
					albRule.ServiceName = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].serviceName");

					List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule.ListGreyTagRoute_Item2> albRule_items1 = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule.ListGreyTagRoute_Item2>();
					for (int k = 0; k < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items.Length"); k++) {
						ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule.ListGreyTagRoute_Item2 item2 = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_AlbRule.ListGreyTagRoute_Item2();
						item2.Type = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].type");
						item2.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].name");
						item2._Operator = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].operator");
						item2._Value = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].value");
						item2.Cond = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].cond");
						item2.Index = _ctx.IntegerValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].index");
						item2.Expr = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].AlbRules["+ j +"].Items["+ k +"].expr");

						albRule_items1.Add(item2);
					}
					albRule.Items1 = albRule_items1;

					resultItem_albRules.Add(albRule);
				}
				resultItem.AlbRules = resultItem_albRules;

				List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule> resultItem_dubboRules = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule>();
				for (int j = 0; j < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].DubboRules.Length"); j++) {
					ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule dubboRule = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule();
					dubboRule.ServiceName = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].serviceName");
					dubboRule.Group = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].group");
					dubboRule.Version = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].version");
					dubboRule.MethodName = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].methodName");
					dubboRule.Condition = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].condition");

					List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item4> dubboRule_items3 = new List<ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item4>();
					for (int k = 0; k < _ctx.Length("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items.Length"); k++) {
						ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item4 item4 = new ListGreyTagRouteResponse.ListGreyTagRoute_Data.ListGreyTagRoute_ResultItem.ListGreyTagRoute_DubboRule.ListGreyTagRoute_Item4();
						item4.Index = _ctx.IntegerValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].index");
						item4.Expr = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].expr");
						item4._Operator = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].operator");
						item4._Value = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].value");
						item4.Cond = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].cond");
						item4.Type = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].type");
						item4.Name = _ctx.StringValue("ListGreyTagRoute.Data.Result["+ i +"].DubboRules["+ j +"].Items["+ k +"].name");

						dubboRule_items3.Add(item4);
					}
					dubboRule.Items3 = dubboRule_items3;

					resultItem_dubboRules.Add(dubboRule);
				}
				resultItem.DubboRules = resultItem_dubboRules;

				data_result.Add(resultItem);
			}
			data.Result = data_result;
			listGreyTagRouteResponse.Data = data;
        
			return listGreyTagRouteResponse;
        }
    }
}
