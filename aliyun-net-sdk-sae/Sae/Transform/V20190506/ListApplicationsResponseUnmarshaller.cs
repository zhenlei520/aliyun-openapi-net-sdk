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
    public class ListApplicationsResponseUnmarshaller
    {
        public static ListApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationsResponse listApplicationsResponse = new ListApplicationsResponse();

			listApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationsResponse.Message = _ctx.StringValue("ListApplications.Message");
			listApplicationsResponse.RequestId = _ctx.StringValue("ListApplications.RequestId");
			listApplicationsResponse.ErrorCode = _ctx.StringValue("ListApplications.ErrorCode");
			listApplicationsResponse.Code = _ctx.StringValue("ListApplications.Code");
			listApplicationsResponse.Success = _ctx.BooleanValue("ListApplications.Success");
			listApplicationsResponse.CurrentPage = _ctx.IntegerValue("ListApplications.CurrentPage");
			listApplicationsResponse.TotalSize = _ctx.IntegerValue("ListApplications.TotalSize");
			listApplicationsResponse.PageSize = _ctx.IntegerValue("ListApplications.PageSize");

			ListApplicationsResponse.ListApplications_Data data = new ListApplicationsResponse.ListApplications_Data();
			data.CurrentPage = _ctx.IntegerValue("ListApplications.Data.CurrentPage");
			data.TotalSize = _ctx.IntegerValue("ListApplications.Data.TotalSize");
			data.PageSize = _ctx.IntegerValue("ListApplications.Data.PageSize");

			List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application> data_applications = new List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application>();
			for (int i = 0; i < _ctx.Length("ListApplications.Data.Applications.Length"); i++) {
				ListApplicationsResponse.ListApplications_Data.ListApplications_Application application = new ListApplicationsResponse.ListApplications_Data.ListApplications_Application();
				application.AppName = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].AppName");
				application.NamespaceId = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].NamespaceId");
				application.AppDeletingStatus = _ctx.BooleanValue("ListApplications.Data.Applications["+ i +"].AppDeletingStatus");
				application.AppId = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].AppId");
				application.ScaleRuleEnabled = _ctx.BooleanValue("ListApplications.Data.Applications["+ i +"].ScaleRuleEnabled");
				application.ScaleRuleType = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].ScaleRuleType");
				application.RunningInstances = _ctx.IntegerValue("ListApplications.Data.Applications["+ i +"].RunningInstances");
				application.Instances = _ctx.IntegerValue("ListApplications.Data.Applications["+ i +"].Instances");
				application.RegionId = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].RegionId");
				application.AppDescription = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].AppDescription");
				application.Cpu = _ctx.IntegerValue("ListApplications.Data.Applications["+ i +"].Cpu");
				application.Mem = _ctx.IntegerValue("ListApplications.Data.Applications["+ i +"].Mem");

				List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem> application_tags = new List<ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListApplications.Data.Applications["+ i +"].Tags.Length"); j++) {
					ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem tagsItem = new ListApplicationsResponse.ListApplications_Data.ListApplications_Application.ListApplications_TagsItem();
					tagsItem.Key = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].Tags["+ j +"].Key");
					tagsItem._Value = _ctx.StringValue("ListApplications.Data.Applications["+ i +"].Tags["+ j +"].Value");

					application_tags.Add(tagsItem);
				}
				application.Tags = application_tags;

				data_applications.Add(application);
			}
			data.Applications = data_applications;
			listApplicationsResponse.Data = data;
        
			return listApplicationsResponse;
        }
    }
}
