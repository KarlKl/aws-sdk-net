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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the ListGroupsOlderThanOrderingId operation.
    /// </summary>
    public partial class ListGroupsOlderThanOrderingIdResponse : AmazonWebServiceResponse
    {
        private List<GroupSummary> _groupsSummaries = new List<GroupSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GroupsSummaries. 
        /// <para>
        ///  Summary information for list of groups that are mapped to users before a given ordering
        /// or timestamp identifier. 
        /// </para>
        /// </summary>
        public List<GroupSummary> GroupsSummaries
        {
            get { return this._groupsSummaries; }
            set { this._groupsSummaries = value; }
        }

        // Check to see if GroupsSummaries property is set
        internal bool IsSetGroupsSummaries()
        {
            return this._groupsSummaries != null && this._groupsSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If the response is truncated, Amazon Kendra returns this token that you can use in
        /// the subsequent request to retrieve the next set of groups that are mapped to users
        /// before a given ordering or timestamp identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}