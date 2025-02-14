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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Rules are processed in order. If there are multiple rules that match the line item,
    /// then the first rule to match is used to determine that Cost Category value.
    /// </summary>
    public partial class CostCategoryRule
    {
        private CostCategoryInheritedValueDimension _inheritedValue;
        private Expression _rule;
        private CostCategoryRuleType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property InheritedValue. 
        /// <para>
        /// The value the line item is categorized as if the line item contains the matched dimension.
        /// </para>
        /// </summary>
        public CostCategoryInheritedValueDimension InheritedValue
        {
            get { return this._inheritedValue; }
            set { this._inheritedValue = value; }
        }

        // Check to see if InheritedValue property is set
        internal bool IsSetInheritedValue()
        {
            return this._inheritedValue != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object used to categorize costs. This supports dimensions, tags, and nested expressions.
        /// Currently the only dimensions supported are <code>LINKED_ACCOUNT</code>, <code>SERVICE_CODE</code>,
        /// <code>RECORD_TYPE</code>, and <code>LINKED_ACCOUNT_NAME</code>.
        /// </para>
        ///  
        /// <para>
        /// Root level <code>OR</code> isn't supported. We recommend that you create a separate
        /// rule instead.
        /// </para>
        ///  
        /// <para>
        ///  <code>RECORD_TYPE</code> is a dimension used for Cost Explorer APIs, and is also
        /// supported for Cost Category expressions. This dimension uses different terms, depending
        /// on whether you're using the console or API/JSON editor. For a detailed comparison,
        /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-cost-categories.html#cost-categories-terms">Term
        /// Comparisons</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        public Expression Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// You can define the <code>CostCategoryRule</code> rule type as either <code>REGULAR</code>
        /// or <code>INHERITED_VALUE</code>. The <code>INHERITED_VALUE</code> rule type adds the
        /// flexibility of defining a rule that dynamically inherits the cost category value from
        /// the dimension value defined by <code>CostCategoryInheritedValueDimension</code>. For
        /// example, if you want to dynamically group costs based on the value of a specific tag
        /// key, first choose an inherited value rule type, then choose the tag dimension and
        /// specify the tag key to use.
        /// </para>
        /// </summary>
        public CostCategoryRuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}