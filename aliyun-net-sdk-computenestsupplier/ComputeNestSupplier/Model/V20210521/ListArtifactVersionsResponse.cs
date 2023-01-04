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

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
	public class ListArtifactVersionsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private string maxResults;

		private string totalCount;

		private List<ListArtifactVersions_Artifact> artifacts;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public string MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public string TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListArtifactVersions_Artifact> Artifacts
		{
			get
			{
				return artifacts;
			}
			set	
			{
				artifacts = value;
			}
		}

		public class ListArtifactVersions_Artifact
		{

			private string artifactId;

			private string artifactType;

			private string versionName;

			private string artifactVersion;

			private string status;

			private string artifactProperty;

			private string supportRegionIds;

			private string gmtModified;

			private string progress;

			private string gmtCreate;

			private string imageDelivery;

			private string securityAuditResult;

			private string resultFile;

			public string ArtifactId
			{
				get
				{
					return artifactId;
				}
				set	
				{
					artifactId = value;
				}
			}

			public string ArtifactType
			{
				get
				{
					return artifactType;
				}
				set	
				{
					artifactType = value;
				}
			}

			public string VersionName
			{
				get
				{
					return versionName;
				}
				set	
				{
					versionName = value;
				}
			}

			public string ArtifactVersion
			{
				get
				{
					return artifactVersion;
				}
				set	
				{
					artifactVersion = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ArtifactProperty
			{
				get
				{
					return artifactProperty;
				}
				set	
				{
					artifactProperty = value;
				}
			}

			public string SupportRegionIds
			{
				get
				{
					return supportRegionIds;
				}
				set	
				{
					supportRegionIds = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string ImageDelivery
			{
				get
				{
					return imageDelivery;
				}
				set	
				{
					imageDelivery = value;
				}
			}

			public string SecurityAuditResult
			{
				get
				{
					return securityAuditResult;
				}
				set	
				{
					securityAuditResult = value;
				}
			}

			public string ResultFile
			{
				get
				{
					return resultFile;
				}
				set	
				{
					resultFile = value;
				}
			}
		}
	}
}
