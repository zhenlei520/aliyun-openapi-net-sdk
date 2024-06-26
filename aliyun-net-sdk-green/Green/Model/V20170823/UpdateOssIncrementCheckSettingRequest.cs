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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateOssIncrementCheckSettingRequest : RpcAcsRequest<UpdateOssIncrementCheckSettingResponse>
    {
        public UpdateOssIncrementCheckSettingRequest()
            : base("Green", "2017-08-23", "UpdateOssIncrementCheckSetting", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string videoSceneList;

		private string imageSceneList;

		private string imagePornFreezeConfig;

		private string imageAdFreezeConfig;

		private string audioSceneList;

		private string imageTerrorismFreezeConfig;

		private bool? imageAutoFreezeOpened;

		private bool? audioAutoFreezeOpened;

		private string sourceIp;

		private long? audioScanLimit;

		private string callbackId;

		private long? videoScanLimit;

		private string imageScanLimit;

		private string videoLiveFreezeConfig;

		private string videoPornFreezeConfig;

		private string audioAntispamFreezeConfig;

		private string autoFreezeType;

		private string bucketConfigList;

		private int? videoMaxFrames;

		private string imageLiveFreezeConfig;

		private bool? scanImageNoFileType;

		private int? videoFrameInterval;

		private string videoTerrorismFreezeConfig;

		private string videoAutoFreezeSceneList;

		private int? audioMaxSize;

		private string lang;

		private string imageAutoFreeze;

		private bool? videoAutoFreezeOpened;

		private string videoAdFreezeConfig;

		private int? videoMaxSize;

		private string videoVoiceAntispamFreezeConfig;

		private string bizType;

		public string VideoSceneList
		{
			get
			{
				return videoSceneList;
			}
			set	
			{
				videoSceneList = value;
				DictionaryUtil.Add(QueryParameters, "VideoSceneList", value);
			}
		}

		public string ImageSceneList
		{
			get
			{
				return imageSceneList;
			}
			set	
			{
				imageSceneList = value;
				DictionaryUtil.Add(QueryParameters, "ImageSceneList", value);
			}
		}

		public string ImagePornFreezeConfig
		{
			get
			{
				return imagePornFreezeConfig;
			}
			set	
			{
				imagePornFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "ImagePornFreezeConfig", value);
			}
		}

		public string ImageAdFreezeConfig
		{
			get
			{
				return imageAdFreezeConfig;
			}
			set	
			{
				imageAdFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "ImageAdFreezeConfig", value);
			}
		}

		public string AudioSceneList
		{
			get
			{
				return audioSceneList;
			}
			set	
			{
				audioSceneList = value;
				DictionaryUtil.Add(QueryParameters, "AudioSceneList", value);
			}
		}

		public string ImageTerrorismFreezeConfig
		{
			get
			{
				return imageTerrorismFreezeConfig;
			}
			set	
			{
				imageTerrorismFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "ImageTerrorismFreezeConfig", value);
			}
		}

		public bool? ImageAutoFreezeOpened
		{
			get
			{
				return imageAutoFreezeOpened;
			}
			set	
			{
				imageAutoFreezeOpened = value;
				DictionaryUtil.Add(QueryParameters, "ImageAutoFreezeOpened", value.ToString());
			}
		}

		public bool? AudioAutoFreezeOpened
		{
			get
			{
				return audioAutoFreezeOpened;
			}
			set	
			{
				audioAutoFreezeOpened = value;
				DictionaryUtil.Add(QueryParameters, "AudioAutoFreezeOpened", value.ToString());
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public long? AudioScanLimit
		{
			get
			{
				return audioScanLimit;
			}
			set	
			{
				audioScanLimit = value;
				DictionaryUtil.Add(QueryParameters, "AudioScanLimit", value.ToString());
			}
		}

		public string CallbackId
		{
			get
			{
				return callbackId;
			}
			set	
			{
				callbackId = value;
				DictionaryUtil.Add(QueryParameters, "CallbackId", value);
			}
		}

		public long? VideoScanLimit
		{
			get
			{
				return videoScanLimit;
			}
			set	
			{
				videoScanLimit = value;
				DictionaryUtil.Add(QueryParameters, "VideoScanLimit", value.ToString());
			}
		}

		public string ImageScanLimit
		{
			get
			{
				return imageScanLimit;
			}
			set	
			{
				imageScanLimit = value;
				DictionaryUtil.Add(QueryParameters, "ImageScanLimit", value);
			}
		}

		public string VideoLiveFreezeConfig
		{
			get
			{
				return videoLiveFreezeConfig;
			}
			set	
			{
				videoLiveFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "VideoLiveFreezeConfig", value);
			}
		}

		public string VideoPornFreezeConfig
		{
			get
			{
				return videoPornFreezeConfig;
			}
			set	
			{
				videoPornFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "VideoPornFreezeConfig", value);
			}
		}

		public string AudioAntispamFreezeConfig
		{
			get
			{
				return audioAntispamFreezeConfig;
			}
			set	
			{
				audioAntispamFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "AudioAntispamFreezeConfig", value);
			}
		}

		public string AutoFreezeType
		{
			get
			{
				return autoFreezeType;
			}
			set	
			{
				autoFreezeType = value;
				DictionaryUtil.Add(QueryParameters, "AutoFreezeType", value);
			}
		}

		public string BucketConfigList
		{
			get
			{
				return bucketConfigList;
			}
			set	
			{
				bucketConfigList = value;
				DictionaryUtil.Add(QueryParameters, "BucketConfigList", value);
			}
		}

		public int? VideoMaxFrames
		{
			get
			{
				return videoMaxFrames;
			}
			set	
			{
				videoMaxFrames = value;
				DictionaryUtil.Add(QueryParameters, "VideoMaxFrames", value.ToString());
			}
		}

		public string ImageLiveFreezeConfig
		{
			get
			{
				return imageLiveFreezeConfig;
			}
			set	
			{
				imageLiveFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "ImageLiveFreezeConfig", value);
			}
		}

		public bool? ScanImageNoFileType
		{
			get
			{
				return scanImageNoFileType;
			}
			set	
			{
				scanImageNoFileType = value;
				DictionaryUtil.Add(QueryParameters, "ScanImageNoFileType", value.ToString());
			}
		}

		public int? VideoFrameInterval
		{
			get
			{
				return videoFrameInterval;
			}
			set	
			{
				videoFrameInterval = value;
				DictionaryUtil.Add(QueryParameters, "VideoFrameInterval", value.ToString());
			}
		}

		public string VideoTerrorismFreezeConfig
		{
			get
			{
				return videoTerrorismFreezeConfig;
			}
			set	
			{
				videoTerrorismFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "VideoTerrorismFreezeConfig", value);
			}
		}

		public string VideoAutoFreezeSceneList
		{
			get
			{
				return videoAutoFreezeSceneList;
			}
			set	
			{
				videoAutoFreezeSceneList = value;
				DictionaryUtil.Add(QueryParameters, "VideoAutoFreezeSceneList", value);
			}
		}

		public int? AudioMaxSize
		{
			get
			{
				return audioMaxSize;
			}
			set	
			{
				audioMaxSize = value;
				DictionaryUtil.Add(QueryParameters, "AudioMaxSize", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string ImageAutoFreeze
		{
			get
			{
				return imageAutoFreeze;
			}
			set	
			{
				imageAutoFreeze = value;
				DictionaryUtil.Add(QueryParameters, "ImageAutoFreeze", value);
			}
		}

		public bool? VideoAutoFreezeOpened
		{
			get
			{
				return videoAutoFreezeOpened;
			}
			set	
			{
				videoAutoFreezeOpened = value;
				DictionaryUtil.Add(QueryParameters, "VideoAutoFreezeOpened", value.ToString());
			}
		}

		public string VideoAdFreezeConfig
		{
			get
			{
				return videoAdFreezeConfig;
			}
			set	
			{
				videoAdFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "VideoAdFreezeConfig", value);
			}
		}

		public int? VideoMaxSize
		{
			get
			{
				return videoMaxSize;
			}
			set	
			{
				videoMaxSize = value;
				DictionaryUtil.Add(QueryParameters, "VideoMaxSize", value.ToString());
			}
		}

		public string VideoVoiceAntispamFreezeConfig
		{
			get
			{
				return videoVoiceAntispamFreezeConfig;
			}
			set	
			{
				videoVoiceAntispamFreezeConfig = value;
				DictionaryUtil.Add(QueryParameters, "VideoVoiceAntispamFreezeConfig", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateOssIncrementCheckSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateOssIncrementCheckSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
