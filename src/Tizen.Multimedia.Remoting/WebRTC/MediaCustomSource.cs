/*
 * Copyright (c) 2021 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using NativeWebRTC = Interop.NativeWebRTC;

namespace Tizen.Multimedia.Remoting
{
    /// <summary>
    /// Represents a media source that makes audio, video data internally.
    /// </summary>
    /// <remarks>
    /// This supports the product infrastructure and is not intended to be used directly from application code.
    /// </remarks>
    /// <seealso cref="WebRTC.AddSource"/>
    /// <seealso cref="WebRTC.AddSources"/>
    /// <since_tizen> 9 </since_tizen>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class MediaCustomSource : MediaSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaCustomSource"/> class.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public MediaCustomSource(MediaType type) : base(type) {}

        internal override void OnAttached(WebRTC webRtc)
        {
            Debug.Assert(webRtc != null);

            if (WebRtc != null)
            {
                throw new InvalidOperationException("The source is has already been assigned to another WebRTC.");
            }

            var type = MediaType == MediaType.Video ? CustomMediaSourceType.Video : CustomMediaSourceType.Audio;

            NativeWebRTC.AddCustomMediaSource(webRtc.Handle, type, out uint sourceId).
                    ThrowIfFailed($"Failed to add {MediaType.ToString()} MediaCustomSource.");

            WebRtc = webRtc;
            SourceId = sourceId;
        }

        internal override void OnDetached(WebRTC webRtc)
        {
            NativeWebRTC.RemoveMediaSource(webRtc.Handle, SourceId.Value).
                ThrowIfFailed($"Failed to remove {MediaType.ToString()} MediaCustomSource.");

            WebRtc = null;
        }
    }
}
