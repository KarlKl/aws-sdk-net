/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part of the
    /// web request that identifies a resource. For example, <code>/images/daily-ad.jpg</code>.
    /// 
    ///  
    /// <para>
    /// This is used only in the <a>FieldToMatch</a> specification for some web request component
    /// types. 
    /// </para>
    ///  
    /// <para>
    /// JSON specification: <code>"UriPath": {}</code> 
    /// </para>
    /// </summary>
    public partial class UriPath
    {

    }
}