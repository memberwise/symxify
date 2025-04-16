//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ParameterService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ParameterService\generated-output -n ParameterService
namespace ParameterService
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1182.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("AcsServiceFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("AcsServiceFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class AcsServiceFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AcquireItems", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool AcquireItemsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AcquireItems property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AcquireItemsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AcquireItems
        {
            get
            {
                if (this.AcquireItemsValueSpecified)
                {
                    return this.AcquireItemsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AcquireItemsValue = value.GetValueOrDefault();
                this.AcquireItemsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AcquireOption", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool AcquireOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AcquireOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AcquireOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AcquireOption
        {
            get
            {
                if (this.AcquireOptionValueSpecified)
                {
                    return this.AcquireOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AcquireOptionValue = value.GetValueOrDefault();
                this.AcquireOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AcsServiceType", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool AcsServiceTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AcsServiceType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AcsServiceTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AcsServiceType
        {
            get
            {
                if (this.AcsServiceTypeValueSpecified)
                {
                    return this.AcsServiceTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AcsServiceTypeValue = value.GetValueOrDefault();
                this.AcsServiceTypeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _action;
        
        [XmlElementAttribute("Action", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Action
        {
            get
            {
                return _action;
            }
            set
            {
                _action = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Action collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return ((this.Action != null) 
                            && (this.Action.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AcsServiceFields" /> class.</para>
        /// </summary>
        public AcsServiceFields()
        {
            this._action = new Collection<short>();
            this._actionCreateRecord = new Collection<short>();
            this._actionCreateText = new Collection<short>();
            this._actionCreateType = new Collection<short>();
            this._compDataType = new Collection<short>();
            this._compareNum = new Collection<short>();
            this._comparisonMethod = new Collection<short>();
            this._comparisonValue = new Collection<short>();
            this._criteria12 = new Collection<short>();
            this._criteriaOperator = new Collection<short>();
            this._menuOption = new Collection<short>();
            this._script = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _actionCreateRecord;
        
        [XmlElementAttribute("ActionCreateRecord", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ActionCreateRecord
        {
            get
            {
                return _actionCreateRecord;
            }
            set
            {
                _actionCreateRecord = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ActionCreateRecord collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ActionCreateRecordSpecified
        {
            get
            {
                return ((this.ActionCreateRecord != null) 
                            && (this.ActionCreateRecord.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _actionCreateText;
        
        [XmlElementAttribute("ActionCreateText", Order=5, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ActionCreateText
        {
            get
            {
                return _actionCreateText;
            }
            set
            {
                _actionCreateText = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ActionCreateText collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ActionCreateTextSpecified
        {
            get
            {
                return ((this.ActionCreateText != null) 
                            && (this.ActionCreateText.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _actionCreateType;
        
        [XmlElementAttribute("ActionCreateType", Order=6, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ActionCreateType
        {
            get
            {
                return _actionCreateType;
            }
            set
            {
                _actionCreateType = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ActionCreateType collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ActionCreateTypeSpecified
        {
            get
            {
                return ((this.ActionCreateType != null) 
                            && (this.ActionCreateType.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _compDataType;
        
        [XmlElementAttribute("CompDataType", Order=7, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CompDataType
        {
            get
            {
                return _compDataType;
            }
            set
            {
                _compDataType = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CompDataType collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CompDataTypeSpecified
        {
            get
            {
                return ((this.CompDataType != null) 
                            && (this.CompDataType.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _compareNum;
        
        [XmlElementAttribute("CompareNum", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CompareNum
        {
            get
            {
                return _compareNum;
            }
            set
            {
                _compareNum = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CompareNum collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CompareNumSpecified
        {
            get
            {
                return ((this.CompareNum != null) 
                            && (this.CompareNum.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _comparisonMethod;
        
        [XmlElementAttribute("ComparisonMethod", Order=9, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ComparisonMethod
        {
            get
            {
                return _comparisonMethod;
            }
            set
            {
                _comparisonMethod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ComparisonMethod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ComparisonMethodSpecified
        {
            get
            {
                return ((this.ComparisonMethod != null) 
                            && (this.ComparisonMethod.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _comparisonValue;
        
        [XmlElementAttribute("ComparisonValue", Order=10, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> ComparisonValue
        {
            get
            {
                return _comparisonValue;
            }
            set
            {
                _comparisonValue = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ComparisonValue collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ComparisonValueSpecified
        {
            get
            {
                return ((this.ComparisonValue != null) 
                            && (this.ComparisonValue.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ConsolidateMax", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool ConsolidateMaxValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ConsolidateMax property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ConsolidateMaxValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ConsolidateMax
        {
            get
            {
                if (this.ConsolidateMaxValueSpecified)
                {
                    return this.ConsolidateMaxValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ConsolidateMaxValue = value.GetValueOrDefault();
                this.ConsolidateMaxValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _criteria12;
        
        [XmlElementAttribute("Criteria12", Order=12, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Criteria12
        {
            get
            {
                return _criteria12;
            }
            set
            {
                _criteria12 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Criteria12 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Criteria12Specified
        {
            get
            {
                return ((this.Criteria12 != null) 
                            && (this.Criteria12.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _criteriaOperator;
        
        [XmlElementAttribute("CriteriaOperator", Order=13, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CriteriaOperator
        {
            get
            {
                return _criteriaOperator;
            }
            set
            {
                _criteriaOperator = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CriteriaOperator collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CriteriaOperatorSpecified
        {
            get
            {
                return ((this.CriteriaOperator != null) 
                            && (this.CriteriaOperator.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Description", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool DescriptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Description property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DescriptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Description
        {
            get
            {
                if (this.DescriptionValueSpecified)
                {
                    return this.DescriptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DescriptionValue = value.GetValueOrDefault();
                this.DescriptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExcludeMatch", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool ExcludeMatchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExcludeMatch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExcludeMatchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExcludeMatch
        {
            get
            {
                if (this.ExcludeMatchValueSpecified)
                {
                    return this.ExcludeMatchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExcludeMatchValue = value.GetValueOrDefault();
                this.ExcludeMatchValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("FactsLetterfile", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool FactsLetterfileValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FactsLetterfile property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FactsLetterfileValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> FactsLetterfile
        {
            get
            {
                if (this.FactsLetterfileValueSpecified)
                {
                    return this.FactsLetterfileValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FactsLetterfileValue = value.GetValueOrDefault();
                this.FactsLetterfileValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _menuOption;
        
        [XmlElementAttribute("MenuOption", Order=17, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> MenuOption
        {
            get
            {
                return _menuOption;
            }
            set
            {
                _menuOption = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the MenuOption collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MenuOptionSpecified
        {
            get
            {
                return ((this.MenuOption != null) 
                            && (this.MenuOption.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NewLoanType", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool NewLoanTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NewLoanType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NewLoanTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NewLoanType
        {
            get
            {
                if (this.NewLoanTypeValueSpecified)
                {
                    return this.NewLoanTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NewLoanTypeValue = value.GetValueOrDefault();
                this.NewLoanTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Points", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool PointsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Points property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PointsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Points
        {
            get
            {
                if (this.PointsValueSpecified)
                {
                    return this.PointsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PointsValue = value.GetValueOrDefault();
                this.PointsValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _script;
        
        [XmlElementAttribute("Script", Order=20, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Script
        {
            get
            {
                return _script;
            }
            set
            {
                _script = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Script collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ScriptSpecified
        {
            get
            {
                return ((this.Script != null) 
                            && (this.Script.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=21, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=22)]
        public Collection<XmlElement> Any
        {
            get
            {
                return _any;
            }
            set
            {
                _any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get
            {
                return ((this.Any != null) 
                            && (this.Any.Count != 0));
            }
        }
    }
}
