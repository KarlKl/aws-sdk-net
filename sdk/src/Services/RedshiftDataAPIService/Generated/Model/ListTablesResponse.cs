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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// This is the response object from the ListTables operation.
    /// </summary>
    public partial class ListTablesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TableMember> _tables = new List<TableMember>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Tables. 
        /// <para>
        /// The tables that match the request pattern. 
        /// </para>
        /// </summary>
        public List<TableMember> Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }

        // Check to see if Tables property is set
        internal bool IsSetTables()
        {
            return this._tables != null && this._tables.Count > 0; 
        }

    }
}