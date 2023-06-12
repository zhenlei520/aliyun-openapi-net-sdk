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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
	public class AddFaceVideoTemplateResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private AddFaceVideoTemplate_Date date;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public AddFaceVideoTemplate_Date Date
		{
			get
			{
				return date;
			}
			set	
			{
				date = value;
			}
		}

		public class AddFaceVideoTemplate_Date
		{

			private string templateId;

			private List<AddFaceVideoTemplate_FaceInfosItem> faceInfos;

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public List<AddFaceVideoTemplate_FaceInfosItem> FaceInfos
			{
				get
				{
					return faceInfos;
				}
				set	
				{
					faceInfos = value;
				}
			}

			public class AddFaceVideoTemplate_FaceInfosItem
			{

				private string templateFaceID;

				private string templateFaceURL;

				public string TemplateFaceID
				{
					get
					{
						return templateFaceID;
					}
					set	
					{
						templateFaceID = value;
					}
				}

				public string TemplateFaceURL
				{
					get
					{
						return templateFaceURL;
					}
					set	
					{
						templateFaceURL = value;
					}
				}
			}
		}
	}
}
