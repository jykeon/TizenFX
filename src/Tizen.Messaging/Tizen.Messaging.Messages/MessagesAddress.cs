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

namespace Tizen.Messaging.Messages
{
    /// <summary>
    /// This class is used to manage the information of the message address.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    [Obsolete("Deprecated since API11. Might be removed in API13.")]
    public class MessagesAddress
    {
        internal RecipientType Type;
        /// <summary>
        /// The address of the sender/recipient.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string Number { get; }

        /// <summary>
        /// Creates a message address.
        /// </summary>
        /// <param name="number">The recipient's address to receive a message.</param>
        /// <since_tizen> 3 </since_tizen>
        [Obsolete("Deprecated since API11. Might be removed in API13.")]
        public MessagesAddress(string number)
        {
            Number = number;
        }

        internal MessagesAddress(RecipientType type, string number)
        {
            Type = type;
            Number = number;
        }
    }
}
