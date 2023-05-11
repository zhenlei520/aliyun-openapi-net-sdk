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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class BatchCheckVehicleDeviceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private BatchCheckVehicleDevice_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public BatchCheckVehicleDevice_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class BatchCheckVehicleDevice_Data
		{

			private List<BatchCheckVehicleDevice_InvalidDetailListItem> invalidDetailList;

			private List<string> invalidManufacturerList;

			private List<string> invalidDeviceModelList;

			private List<string> invalidDeviceIdList;

			private List<string> repeatedDeviceIdList;

			private List<string> invalidDeviceNameList;

			private List<string> repeatedDeviceNameList;

			public List<BatchCheckVehicleDevice_InvalidDetailListItem> InvalidDetailList
			{
				get
				{
					return invalidDetailList;
				}
				set	
				{
					invalidDetailList = value;
				}
			}

			public List<string> InvalidManufacturerList
			{
				get
				{
					return invalidManufacturerList;
				}
				set	
				{
					invalidManufacturerList = value;
				}
			}

			public List<string> InvalidDeviceModelList
			{
				get
				{
					return invalidDeviceModelList;
				}
				set	
				{
					invalidDeviceModelList = value;
				}
			}

			public List<string> InvalidDeviceIdList
			{
				get
				{
					return invalidDeviceIdList;
				}
				set	
				{
					invalidDeviceIdList = value;
				}
			}

			public List<string> RepeatedDeviceIdList
			{
				get
				{
					return repeatedDeviceIdList;
				}
				set	
				{
					repeatedDeviceIdList = value;
				}
			}

			public List<string> InvalidDeviceNameList
			{
				get
				{
					return invalidDeviceNameList;
				}
				set	
				{
					invalidDeviceNameList = value;
				}
			}

			public List<string> RepeatedDeviceNameList
			{
				get
				{
					return repeatedDeviceNameList;
				}
				set	
				{
					repeatedDeviceNameList = value;
				}
			}

			public class BatchCheckVehicleDevice_InvalidDetailListItem
			{

				private string manufacturer;

				private string deviceModel;

				private string deviceId;

				private string deviceName;

				private string errorMsg;

				public string Manufacturer
				{
					get
					{
						return manufacturer;
					}
					set	
					{
						manufacturer = value;
					}
				}

				public string DeviceModel
				{
					get
					{
						return deviceModel;
					}
					set	
					{
						deviceModel = value;
					}
				}

				public string DeviceId
				{
					get
					{
						return deviceId;
					}
					set	
					{
						deviceId = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public string ErrorMsg
				{
					get
					{
						return errorMsg;
					}
					set	
					{
						errorMsg = value;
					}
				}
			}
		}
	}
}
