//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\AccountService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\AccountService\generated-output -n AccountService
namespace AccountService
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
    [XmlTypeAttribute("SiteCashOrderTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("SiteCashOrderTypeFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class SiteCashOrderTypeFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ActiveFlag", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool ActiveFlagValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ActiveFlag property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ActiveFlagValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ActiveFlag
        {
            get
            {
                if (this.ActiveFlagValueSpecified)
                {
                    return this.ActiveFlagValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ActiveFlagValue = value.GetValueOrDefault();
                this.ActiveFlagValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ApplyHandlingFee", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool ApplyHandlingFeeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ApplyHandlingFee property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ApplyHandlingFeeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ApplyHandlingFee
        {
            get
            {
                if (this.ApplyHandlingFeeValueSpecified)
                {
                    return this.ApplyHandlingFeeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ApplyHandlingFeeValue = value.GetValueOrDefault();
                this.ApplyHandlingFeeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _cashOrderTypeCoinBag;
        
        [XmlElementAttribute("CashOrderTypeCoinBag", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CashOrderTypeCoinBag
        {
            get
            {
                return _cashOrderTypeCoinBag;
            }
            set
            {
                _cashOrderTypeCoinBag = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CashOrderTypeCoinBag collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CashOrderTypeCoinBagSpecified
        {
            get
            {
                return ((this.CashOrderTypeCoinBag != null) 
                            && (this.CashOrderTypeCoinBag.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SiteCashOrderTypeFields" /> class.</para>
        /// </summary>
        public SiteCashOrderTypeFields()
        {
            this._cashOrderTypeCoinBag = new Collection<short>();
            this._cashOrderTypeCoinRoll = new Collection<short>();
            this._cashOrderTypeComment = new Collection<short>();
            this._cashOrderTypeCurrFit = new Collection<short>();
            this._cashOrderTypeCurrNew = new Collection<short>();
            this._deliveryDays = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _cashOrderTypeCoinRoll;
        
        [XmlElementAttribute("CashOrderTypeCoinRoll", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CashOrderTypeCoinRoll
        {
            get
            {
                return _cashOrderTypeCoinRoll;
            }
            set
            {
                _cashOrderTypeCoinRoll = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CashOrderTypeCoinRoll collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CashOrderTypeCoinRollSpecified
        {
            get
            {
                return ((this.CashOrderTypeCoinRoll != null) 
                            && (this.CashOrderTypeCoinRoll.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _cashOrderTypeComment;
        
        [XmlElementAttribute("CashOrderTypeComment", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CashOrderTypeComment
        {
            get
            {
                return _cashOrderTypeComment;
            }
            set
            {
                _cashOrderTypeComment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CashOrderTypeComment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CashOrderTypeCommentSpecified
        {
            get
            {
                return ((this.CashOrderTypeComment != null) 
                            && (this.CashOrderTypeComment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _cashOrderTypeCurrFit;
        
        [XmlElementAttribute("CashOrderTypeCurrFit", Order=5, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CashOrderTypeCurrFit
        {
            get
            {
                return _cashOrderTypeCurrFit;
            }
            set
            {
                _cashOrderTypeCurrFit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CashOrderTypeCurrFit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CashOrderTypeCurrFitSpecified
        {
            get
            {
                return ((this.CashOrderTypeCurrFit != null) 
                            && (this.CashOrderTypeCurrFit.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _cashOrderTypeCurrNew;
        
        [XmlElementAttribute("CashOrderTypeCurrNew", Order=6, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> CashOrderTypeCurrNew
        {
            get
            {
                return _cashOrderTypeCurrNew;
            }
            set
            {
                _cashOrderTypeCurrNew = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CashOrderTypeCurrNew collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CashOrderTypeCurrNewSpecified
        {
            get
            {
                return ((this.CashOrderTypeCurrNew != null) 
                            && (this.CashOrderTypeCurrNew.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashOrderTypeDelCharge", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool CashOrderTypeDelChargeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashOrderTypeDelCharge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashOrderTypeDelChargeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashOrderTypeDelCharge
        {
            get
            {
                if (this.CashOrderTypeDelChargeValueSpecified)
                {
                    return this.CashOrderTypeDelChargeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashOrderTypeDelChargeValue = value.GetValueOrDefault();
                this.CashOrderTypeDelChargeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashOrderTypeMaxOrder", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool CashOrderTypeMaxOrderValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashOrderTypeMaxOrder property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashOrderTypeMaxOrderValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashOrderTypeMaxOrder
        {
            get
            {
                if (this.CashOrderTypeMaxOrderValueSpecified)
                {
                    return this.CashOrderTypeMaxOrderValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashOrderTypeMaxOrderValue = value.GetValueOrDefault();
                this.CashOrderTypeMaxOrderValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashOrderTypeMinOrder", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool CashOrderTypeMinOrderValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashOrderTypeMinOrder property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashOrderTypeMinOrderValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashOrderTypeMinOrder
        {
            get
            {
                if (this.CashOrderTypeMinOrderValueSpecified)
                {
                    return this.CashOrderTypeMinOrderValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashOrderTypeMinOrderValue = value.GetValueOrDefault();
                this.CashOrderTypeMinOrderValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashOrderTypeName", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool CashOrderTypeNameValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashOrderTypeName property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashOrderTypeNameValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashOrderTypeName
        {
            get
            {
                if (this.CashOrderTypeNameValueSpecified)
                {
                    return this.CashOrderTypeNameValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashOrderTypeNameValue = value.GetValueOrDefault();
                this.CashOrderTypeNameValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CashOrderTypeSpecDelCharge", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool CashOrderTypeSpecDelChargeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CashOrderTypeSpecDelCharge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CashOrderTypeSpecDelChargeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CashOrderTypeSpecDelCharge
        {
            get
            {
                if (this.CashOrderTypeSpecDelChargeValueSpecified)
                {
                    return this.CashOrderTypeSpecDelChargeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CashOrderTypeSpecDelChargeValue = value.GetValueOrDefault();
                this.CashOrderTypeSpecDelChargeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CloseDate", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool CloseDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CloseDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CloseDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CloseDate
        {
            get
            {
                if (this.CloseDateValueSpecified)
                {
                    return this.CloseDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CloseDateValue = value.GetValueOrDefault();
                this.CloseDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DelFrequency", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool DelFrequencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DelFrequency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DelFrequencyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DelFrequency
        {
            get
            {
                if (this.DelFrequencyValueSpecified)
                {
                    return this.DelFrequencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DelFrequencyValue = value.GetValueOrDefault();
                this.DelFrequencyValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<short> _deliveryDays;
        
        [XmlElementAttribute("DeliveryDays", Order=14, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> DeliveryDays
        {
            get
            {
                return _deliveryDays;
            }
            set
            {
                _deliveryDays = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryDays collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryDaysSpecified
        {
            get
            {
                return ((this.DeliveryDays != null) 
                            && (this.DeliveryDays.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LocationCode", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool LocationCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LocationCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocationCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LocationCode
        {
            get
            {
                if (this.LocationCodeValueSpecified)
                {
                    return this.LocationCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocationCodeValue = value.GetValueOrDefault();
                this.LocationCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=16, Form=XmlSchemaForm.Unqualified)]
        public bool LocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Locator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Locator
        {
            get
            {
                if (this.LocatorValueSpecified)
                {
                    return this.LocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LocatorValue = value.GetValueOrDefault();
                this.LocatorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OrderLimiting", Order=17, Form=XmlSchemaForm.Unqualified)]
        public bool OrderLimitingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OrderLimiting property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OrderLimitingValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> OrderLimiting
        {
            get
            {
                if (this.OrderLimitingValueSpecified)
                {
                    return this.OrderLimitingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OrderLimitingValue = value.GetValueOrDefault();
                this.OrderLimitingValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RecordChangeDate", Order=18, Form=XmlSchemaForm.Unqualified)]
        public bool RecordChangeDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RecordChangeDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecordChangeDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RecordChangeDate
        {
            get
            {
                if (this.RecordChangeDateValueSpecified)
                {
                    return this.RecordChangeDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecordChangeDateValue = value.GetValueOrDefault();
                this.RecordChangeDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SpecHandlingFee", Order=19, Form=XmlSchemaForm.Unqualified)]
        public bool SpecHandlingFeeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SpecHandlingFee property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SpecHandlingFeeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> SpecHandlingFee
        {
            get
            {
                if (this.SpecHandlingFeeValueSpecified)
                {
                    return this.SpecHandlingFeeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SpecHandlingFeeValue = value.GetValueOrDefault();
                this.SpecHandlingFeeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VendorNumber", Order=20, Form=XmlSchemaForm.Unqualified)]
        public bool VendorNumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VendorNumber property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VendorNumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VendorNumber
        {
            get
            {
                if (this.VendorNumberValueSpecified)
                {
                    return this.VendorNumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VendorNumberValue = value.GetValueOrDefault();
                this.VendorNumberValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Version_1", Order=21, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
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
