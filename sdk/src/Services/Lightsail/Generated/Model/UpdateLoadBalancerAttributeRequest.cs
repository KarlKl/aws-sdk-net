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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLoadBalancerAttribute operation.
    /// Updates the specified attribute for a load balancer. You can only update one attribute
    /// at a time.
    /// 
    ///  
    /// <para>
    /// The <code>update load balancer attribute</code> operation supports tag-based access
    /// control via resource tags applied to the resource identified by <code>load balancer
    /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLoadBalancerAttributeRequest : AmazonLightsailRequest
    {
        private LoadBalancerAttributeName _attributeName;
        private string _attributeValue;
        private string _loadBalancerName;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoadBalancerAttributeName AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value that you want to specify for the attribute name.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported depending on what you specify for the <code>attributeName</code>
        /// request parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <code>HealthCheckPath</code> for the <code>attributeName</code> request
        /// parameter, then the <code>attributeValue</code> request parameter must be the path
        /// to ping on the target (for example, <code>/weather/us/wa/seattle</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>SessionStickinessEnabled</code> for the <code>attributeName</code>
        /// request parameter, then the <code>attributeValue</code> request parameter must be
        /// <code>true</code> or <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>SessionStickiness_LB_CookieDurationSeconds</code> for the <code>attributeName</code>
        /// request parameter, then the <code>attributeValue</code> request parameter must be
        /// an interger that represents the cookie duration in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>HttpsRedirectionEnabled</code> for the <code>attributeName</code>
        /// request parameter, then the <code>attributeValue</code> request parameter must be
        /// <code>true</code> or <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>TlsPolicyName</code> for the <code>attributeName</code> request
        /// parameter, then the <code>attributeValue</code> request parameter must be <code>TLS
        /// version 1.0, 1.1, and 1.2</code> or <code>TLS version 1.2</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer that you want to modify (e.g., <code>my-load-balancer</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

    }
}