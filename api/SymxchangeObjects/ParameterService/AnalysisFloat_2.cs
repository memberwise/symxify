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
    [XmlTypeAttribute("AnalysisFloat", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("AnalysisFloat", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(AnalysisFloatFields_2))]
    public partial class AnalysisFloat_2
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Branch", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short BranchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Branch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> Branch
        {
            get
            {
                if (this.BranchValueSpecified)
                {
                    return this.BranchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchValue = value.GetValueOrDefault();
                this.BranchValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BranchReference", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short BranchReferenceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchReference property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchReferenceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BranchReference
        {
            get
            {
                if (this.BranchReferenceValueSpecified)
                {
                    return this.BranchReferenceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchReferenceValue = value.GetValueOrDefault();
                this.BranchReferenceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("BranchValidCode", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short BranchValidCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchValidCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchValidCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BranchValidCode
        {
            get
            {
                if (this.BranchValidCodeValueSpecified)
                {
                    return this.BranchValidCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchValidCodeValue = value.GetValueOrDefault();
                this.BranchValidCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ForeignItemFloatDays", Order=3, Form=XmlSchemaForm.Unqualified)]
        public short ForeignItemFloatDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ForeignItemFloatDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ForeignItemFloatDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> ForeignItemFloatDays
        {
            get
            {
                if (this.ForeignItemFloatDaysValueSpecified)
                {
                    return this.ForeignItemFloatDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ForeignItemFloatDaysValue = value.GetValueOrDefault();
                this.ForeignItemFloatDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LocalFloatDays", Order=4, Form=XmlSchemaForm.Unqualified)]
        public short LocalFloatDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LocalFloatDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocalFloatDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> LocalFloatDays
        {
            get
            {
                if (this.LocalFloatDaysValueSpecified)
                {
                    return this.LocalFloatDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocalFloatDaysValue = value.GetValueOrDefault();
                this.LocalFloatDaysValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NonlocalFloatDays", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short NonlocalFloatDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NonlocalFloatDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NonlocalFloatDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NonlocalFloatDays
        {
            get
            {
                if (this.NonlocalFloatDaysValueSpecified)
                {
                    return this.NonlocalFloatDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NonlocalFloatDaysValue = value.GetValueOrDefault();
                this.NonlocalFloatDaysValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<AnalysisFloatRoutingNumberFloatDays_2> _routingNumberFloatDays;
        
        [XmlElementAttribute("RoutingNumberFloatDays", Order=6, Form=XmlSchemaForm.Unqualified)]
        public Collection<AnalysisFloatRoutingNumberFloatDays_2> RoutingNumberFloatDays
        {
            get
            {
                return _routingNumberFloatDays;
            }
            set
            {
                _routingNumberFloatDays = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RoutingNumberFloatDays collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RoutingNumberFloatDaysSpecified
        {
            get
            {
                return ((this.RoutingNumberFloatDays != null) 
                            && (this.RoutingNumberFloatDays.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AnalysisFloat_2" /> class.</para>
        /// </summary>
        public AnalysisFloat_2()
        {
            this._routingNumberFloatDays = new Collection<AnalysisFloatRoutingNumberFloatDays_2>();
            this._routingNumberPrefix = new Collection<AnalysisFloatRoutingNumberPrefix_2>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<AnalysisFloatRoutingNumberPrefix_2> _routingNumberPrefix;
        
        [XmlElementAttribute("RoutingNumberPrefix", Order=7, Form=XmlSchemaForm.Unqualified)]
        public Collection<AnalysisFloatRoutingNumberPrefix_2> RoutingNumberPrefix
        {
            get
            {
                return _routingNumberPrefix;
            }
            set
            {
                _routingNumberPrefix = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RoutingNumberPrefix collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RoutingNumberPrefixSpecified
        {
            get
            {
                return ((this.RoutingNumberPrefix != null) 
                            && (this.RoutingNumberPrefix.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=8, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=9)]
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
