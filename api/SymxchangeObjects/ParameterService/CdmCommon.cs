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
    [XmlTypeAttribute("CdmCommon", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CdmCommon", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class CdmCommon
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashMachineRelease", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short CashMachineReleaseValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashMachineRelease property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashMachineReleaseValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> CashMachineRelease
        {
            get
            {
                if (this.CashMachineReleaseValueSpecified)
                {
                    return this.CashMachineReleaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashMachineReleaseValue = value.GetValueOrDefault();
                this.CashMachineReleaseValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CdmCommonCdmDuressAutoMixDescr> _cdmDuressAutoMixDescr;
        
        [XmlElementAttribute("CdmDuressAutoMixDescr", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<CdmCommonCdmDuressAutoMixDescr> CdmDuressAutoMixDescr
        {
            get
            {
                return _cdmDuressAutoMixDescr;
            }
            set
            {
                _cdmDuressAutoMixDescr = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CdmDuressAutoMixDescr collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdmDuressAutoMixDescrSpecified
        {
            get
            {
                return ((this.CdmDuressAutoMixDescr != null) 
                            && (this.CdmDuressAutoMixDescr.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CdmCommon" /> class.</para>
        /// </summary>
        public CdmCommon()
        {
            this._cdmDuressAutoMixDescr = new Collection<CdmCommonCdmDuressAutoMixDescr>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlElementAttribute("ExternalHostName", Order=2, Form=XmlSchemaForm.Unqualified)]
        public string ExternalHostName { get; set; }
        
        [XmlElementAttribute("ExternalHostNameExt", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string ExternalHostNameExt { get; set; }
        
        [XmlElementAttribute("ExternalKeystorePassword", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string ExternalKeystorePassword { get; set; }
        
        [XmlElementAttribute("ExternalUserName", Order=5, Form=XmlSchemaForm.Unqualified)]
        public string ExternalUserName { get; set; }
        
        [XmlElementAttribute("ExternalUserPassword", Order=6, Form=XmlSchemaForm.Unqualified)]
        public string ExternalUserPassword { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LowCassetteAutoDispCash", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool LowCassetteAutoDispCashValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LowCassetteAutoDispCash property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LowCassetteAutoDispCashValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LowCassetteAutoDispCash
        {
            get
            {
                if (this.LowCassetteAutoDispCashValueSpecified)
                {
                    return this.LowCassetteAutoDispCashValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LowCassetteAutoDispCashValue = value.GetValueOrDefault();
                this.LowCassetteAutoDispCashValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MaximumCdmAmount", Order=8, Form=XmlSchemaForm.Unqualified)]
        public decimal MaximumCdmAmountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaximumCdmAmount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaximumCdmAmountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> MaximumCdmAmount
        {
            get
            {
                if (this.MaximumCdmAmountValueSpecified)
                {
                    return this.MaximumCdmAmountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaximumCdmAmountValue = value.GetValueOrDefault();
                this.MaximumCdmAmountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TcrDuressDispAmt", Order=9, Form=XmlSchemaForm.Unqualified)]
        public decimal TcrDuressDispAmtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TcrDuressDispAmt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TcrDuressDispAmtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> TcrDuressDispAmt
        {
            get
            {
                if (this.TcrDuressDispAmtValueSpecified)
                {
                    return this.TcrDuressDispAmtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TcrDuressDispAmtValue = value.GetValueOrDefault();
                this.TcrDuressDispAmtValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("TwinSafeGlobalUserId", Order=10, Form=XmlSchemaForm.Unqualified)]
        public string TwinSafeGlobalUserId { get; set; }
        
        [XmlElementAttribute("Version_1", Order=11, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=12)]
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
