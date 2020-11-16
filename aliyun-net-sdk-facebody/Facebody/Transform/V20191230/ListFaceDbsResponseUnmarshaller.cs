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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class ListFaceDbsResponseUnmarshaller
    {
        public static ListFaceDbsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceDbsResponse listFaceDbsResponse = new ListFaceDbsResponse();

			listFaceDbsResponse.HttpResponse = context.HttpResponse;
			listFaceDbsResponse.RequestId = context.StringValue("ListFaceDbs.RequestId");

			ListFaceDbsResponse.ListFaceDbs_Data data = new ListFaceDbsResponse.ListFaceDbs_Data();

			List<ListFaceDbsResponse.ListFaceDbs_Data.ListFaceDbs_DbListItem> data_dbList = new List<ListFaceDbsResponse.ListFaceDbs_Data.ListFaceDbs_DbListItem>();
			for (int i = 0; i < context.Length("ListFaceDbs.Data.DbList.Length"); i++) {
				ListFaceDbsResponse.ListFaceDbs_Data.ListFaceDbs_DbListItem dbListItem = new ListFaceDbsResponse.ListFaceDbs_Data.ListFaceDbs_DbListItem();
				dbListItem.Name = context.StringValue("ListFaceDbs.Data.DbList["+ i +"].Name");

				data_dbList.Add(dbListItem);
			}
			data.DbList = data_dbList;
			listFaceDbsResponse.Data = data;
        
			return listFaceDbsResponse;
        }
    }
}