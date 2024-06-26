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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeBackupPolicyResponse : AcsResponse
	{

		private string preferredBackupPeriod;

		private string requestId;

		private string preferredBackupTime;

		private string backupRetentionPeriod;

		private string preferredNextBackupTime;

		private int? enableBackupLog;

		private int? logBackupRetentionPeriod;

		private string snapshotBackupType;

		private int? backupInterval;

		private string highFrequencyBackupRetention;

		private int? backupRetentionPolicyOnClusterDeletion;

		private string srcRegion;

		private string destRegion;

		private string crossRetentionType;

		private int? crossRetentionValue;

		private string crossBackupPeriod;

		private int? enableCrossLogBackup;

		private string crossLogRetentionType;

		private int? crossLogRetentionValue;

		public string PreferredBackupPeriod
		{
			get
			{
				return preferredBackupPeriod;
			}
			set	
			{
				preferredBackupPeriod = value;
			}
		}

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

		public string PreferredBackupTime
		{
			get
			{
				return preferredBackupTime;
			}
			set	
			{
				preferredBackupTime = value;
			}
		}

		public string BackupRetentionPeriod
		{
			get
			{
				return backupRetentionPeriod;
			}
			set	
			{
				backupRetentionPeriod = value;
			}
		}

		public string PreferredNextBackupTime
		{
			get
			{
				return preferredNextBackupTime;
			}
			set	
			{
				preferredNextBackupTime = value;
			}
		}

		public int? EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
			}
		}

		public int? LogBackupRetentionPeriod
		{
			get
			{
				return logBackupRetentionPeriod;
			}
			set	
			{
				logBackupRetentionPeriod = value;
			}
		}

		public string SnapshotBackupType
		{
			get
			{
				return snapshotBackupType;
			}
			set	
			{
				snapshotBackupType = value;
			}
		}

		public int? BackupInterval
		{
			get
			{
				return backupInterval;
			}
			set	
			{
				backupInterval = value;
			}
		}

		public string HighFrequencyBackupRetention
		{
			get
			{
				return highFrequencyBackupRetention;
			}
			set	
			{
				highFrequencyBackupRetention = value;
			}
		}

		public int? BackupRetentionPolicyOnClusterDeletion
		{
			get
			{
				return backupRetentionPolicyOnClusterDeletion;
			}
			set	
			{
				backupRetentionPolicyOnClusterDeletion = value;
			}
		}

		public string SrcRegion
		{
			get
			{
				return srcRegion;
			}
			set	
			{
				srcRegion = value;
			}
		}

		public string DestRegion
		{
			get
			{
				return destRegion;
			}
			set	
			{
				destRegion = value;
			}
		}

		public string CrossRetentionType
		{
			get
			{
				return crossRetentionType;
			}
			set	
			{
				crossRetentionType = value;
			}
		}

		public int? CrossRetentionValue
		{
			get
			{
				return crossRetentionValue;
			}
			set	
			{
				crossRetentionValue = value;
			}
		}

		public string CrossBackupPeriod
		{
			get
			{
				return crossBackupPeriod;
			}
			set	
			{
				crossBackupPeriod = value;
			}
		}

		public int? EnableCrossLogBackup
		{
			get
			{
				return enableCrossLogBackup;
			}
			set	
			{
				enableCrossLogBackup = value;
			}
		}

		public string CrossLogRetentionType
		{
			get
			{
				return crossLogRetentionType;
			}
			set	
			{
				crossLogRetentionType = value;
			}
		}

		public int? CrossLogRetentionValue
		{
			get
			{
				return crossLogRetentionValue;
			}
			set	
			{
				crossLogRetentionValue = value;
			}
		}
	}
}
