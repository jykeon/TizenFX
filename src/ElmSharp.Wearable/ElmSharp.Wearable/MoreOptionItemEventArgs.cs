/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
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

namespace ElmSharp.Wearable
{
    /// <summary>
    /// The MoreOptionItemEventArgs is an event arguments class for the MoreOptionItem.
    /// Inherits EventArgs
    /// </summary>
    /// <since_tizen> preview </since_tizen>
    [Obsolete("This has been deprecated in API12")]
    public class MoreOptionItemEventArgs : EventArgs
    {
        /// <summary>
        /// Sets or gets the more option item.
        /// </summary>
        /// <since_tizen> preview </since_tizen>
        [Obsolete("This has been deprecated in API12")]
        public MoreOptionItem Item { get; set; }
    }
}
