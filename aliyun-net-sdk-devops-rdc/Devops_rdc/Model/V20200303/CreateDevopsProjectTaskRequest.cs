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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class CreateDevopsProjectTaskRequest : RpcAcsRequest<CreateDevopsProjectTaskResponse>
    {
        public CreateDevopsProjectTaskRequest()
            : base("devops-rdc", "2020-03-03", "CreateDevopsProjectTask", "1.9.6", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string note;

		private string visible;

		private string executorId;

		private string taskFlowStatusId;

		private string startDate;

		private int? priority;

		private string parentTaskId;

		private string orgId;

		private string content;

		private string sprintId;

		private string dueDate;

		private string scenarioFieldConfigId;

		private string projectId;

		private string taskListId;

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
				DictionaryUtil.Add(BodyParameters, "Note", value);
			}
		}

		public string Visible
		{
			get
			{
				return visible;
			}
			set	
			{
				visible = value;
				DictionaryUtil.Add(BodyParameters, "Visible", value);
			}
		}

		public string ExecutorId
		{
			get
			{
				return executorId;
			}
			set	
			{
				executorId = value;
				DictionaryUtil.Add(BodyParameters, "ExecutorId", value);
			}
		}

		public string TaskFlowStatusId
		{
			get
			{
				return taskFlowStatusId;
			}
			set	
			{
				taskFlowStatusId = value;
				DictionaryUtil.Add(BodyParameters, "TaskFlowStatusId", value);
			}
		}

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(BodyParameters, "StartDate", value);
			}
		}

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(BodyParameters, "Priority", value.ToString());
			}
		}

		public string ParentTaskId
		{
			get
			{
				return parentTaskId;
			}
			set	
			{
				parentTaskId = value;
				DictionaryUtil.Add(BodyParameters, "ParentTaskId", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(BodyParameters, "Content", value);
			}
		}

		public string SprintId
		{
			get
			{
				return sprintId;
			}
			set	
			{
				sprintId = value;
				DictionaryUtil.Add(BodyParameters, "SprintId", value);
			}
		}

		public string DueDate
		{
			get
			{
				return dueDate;
			}
			set	
			{
				dueDate = value;
				DictionaryUtil.Add(BodyParameters, "DueDate", value);
			}
		}

		public string ScenarioFieldConfigId
		{
			get
			{
				return scenarioFieldConfigId;
			}
			set	
			{
				scenarioFieldConfigId = value;
				DictionaryUtil.Add(BodyParameters, "ScenarioFieldConfigId", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value);
			}
		}

		public string TaskListId
		{
			get
			{
				return taskListId;
			}
			set	
			{
				taskListId = value;
				DictionaryUtil.Add(BodyParameters, "TaskListId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDevopsProjectTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDevopsProjectTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
