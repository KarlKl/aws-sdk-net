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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Configures the firewall policy deployment model for a third-party firewall. The deployment
    /// model can either be distributed or centralized.
    /// </summary>
    public partial class ThirdPartyFirewallFirewallPolicy
    {
        private string _firewallPolicyId;
        private string _firewallPolicyName;

        /// <summary>
        /// Gets and sets the property FirewallPolicyId. 
        /// <para>
        /// The ID of the specified firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirewallPolicyId
        {
            get { return this._firewallPolicyId; }
            set { this._firewallPolicyId = value; }
        }

        // Check to see if FirewallPolicyId property is set
        internal bool IsSetFirewallPolicyId()
        {
            return this._firewallPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyName. 
        /// <para>
        /// The name of the specified firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirewallPolicyName
        {
            get { return this._firewallPolicyName; }
            set { this._firewallPolicyName = value; }
        }

        // Check to see if FirewallPolicyName property is set
        internal bool IsSetFirewallPolicyName()
        {
            return this._firewallPolicyName != null;
        }

    }
}