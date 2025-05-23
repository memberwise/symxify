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
    [XmlTypeAttribute("DivIndexLocal", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DivIndexLocal", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class DivIndexLocal
    {
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalBackdatedFlag> _backdatedFlag;
        
        [XmlElementAttribute("BackdatedFlag", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalBackdatedFlag> BackdatedFlag
        {
            get
            {
                return _backdatedFlag;
            }
            set
            {
                _backdatedFlag = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the BackdatedFlag collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BackdatedFlagSpecified
        {
            get
            {
                return ((this.BackdatedFlag != null) 
                            && (this.BackdatedFlag.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DivIndexLocal" /> class.</para>
        /// </summary>
        public DivIndexLocal()
        {
            this._backdatedFlag = new Collection<DivIndexLocalBackdatedFlag>();
            this._balanceCutoff = new Collection<DivIndexLocalBalanceCutoff>();
            this._balanceStatus = new Collection<DivIndexLocalBalanceStatus>();
            this._indexDate = new Collection<DivIndexLocalIndexDate>();
            this._indexRate = new Collection<DivIndexLocalIndexRate>();
            this._pendingBalance = new Collection<DivIndexLocalPendingBalance>();
            this._pendingRate = new Collection<DivIndexLocalPendingRate>();
            this._status = new Collection<DivIndexLocalStatus>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalBalanceCutoff> _balanceCutoff;
        
        [XmlElementAttribute("BalanceCutoff", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalBalanceCutoff> BalanceCutoff
        {
            get
            {
                return _balanceCutoff;
            }
            set
            {
                _balanceCutoff = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the BalanceCutoff collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BalanceCutoffSpecified
        {
            get
            {
                return ((this.BalanceCutoff != null) 
                            && (this.BalanceCutoff.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalBalanceStatus> _balanceStatus;
        
        [XmlElementAttribute("BalanceStatus", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalBalanceStatus> BalanceStatus
        {
            get
            {
                return _balanceStatus;
            }
            set
            {
                _balanceStatus = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the BalanceStatus collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BalanceStatusSpecified
        {
            get
            {
                return ((this.BalanceStatus != null) 
                            && (this.BalanceStatus.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CurrentMonthAvgRate", Order=3, Form=XmlSchemaForm.Unqualified)]
        public decimal CurrentMonthAvgRateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CurrentMonthAvgRate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CurrentMonthAvgRateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> CurrentMonthAvgRate
        {
            get
            {
                if (this.CurrentMonthAvgRateValueSpecified)
                {
                    return this.CurrentMonthAvgRateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CurrentMonthAvgRateValue = value.GetValueOrDefault();
                this.CurrentMonthAvgRateValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Description", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("DividendIndexTable", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short DividendIndexTableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DividendIndexTable property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DividendIndexTableValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> DividendIndexTable
        {
            get
            {
                if (this.DividendIndexTableValueSpecified)
                {
                    return this.DividendIndexTableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DividendIndexTableValue = value.GetValueOrDefault();
                this.DividendIndexTableValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("InactiveStatusDate", Order=6, Form=XmlSchemaForm.Unqualified, DataType="date")]
        public DateTime InactiveStatusDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InactiveStatusDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InactiveStatusDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> InactiveStatusDate
        {
            get
            {
                if (this.InactiveStatusDateValueSpecified)
                {
                    return this.InactiveStatusDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InactiveStatusDateValue = value.GetValueOrDefault();
                this.InactiveStatusDateValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalIndexDate> _indexDate;
        
        [XmlElementAttribute("IndexDate", Order=7, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalIndexDate> IndexDate
        {
            get
            {
                return _indexDate;
            }
            set
            {
                _indexDate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the IndexDate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IndexDateSpecified
        {
            get
            {
                return ((this.IndexDate != null) 
                            && (this.IndexDate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalIndexRate> _indexRate;
        
        [XmlElementAttribute("IndexRate", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalIndexRate> IndexRate
        {
            get
            {
                return _indexRate;
            }
            set
            {
                _indexRate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the IndexRate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IndexRateSpecified
        {
            get
            {
                return ((this.IndexRate != null) 
                            && (this.IndexRate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalPendingBalance> _pendingBalance;
        
        [XmlElementAttribute("PendingBalance", Order=9, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalPendingBalance> PendingBalance
        {
            get
            {
                return _pendingBalance;
            }
            set
            {
                _pendingBalance = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PendingBalance collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PendingBalanceSpecified
        {
            get
            {
                return ((this.PendingBalance != null) 
                            && (this.PendingBalance.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalPendingRate> _pendingRate;
        
        [XmlElementAttribute("PendingRate", Order=10, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalPendingRate> PendingRate
        {
            get
            {
                return _pendingRate;
            }
            set
            {
                _pendingRate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PendingRate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PendingRateSpecified
        {
            get
            {
                return ((this.PendingRate != null) 
                            && (this.PendingRate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<DivIndexLocalStatus> _status;
        
        [XmlElementAttribute("Status", Order=11, Form=XmlSchemaForm.Unqualified)]
        public Collection<DivIndexLocalStatus> Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Status collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return ((this.Status != null) 
                            && (this.Status.Count != 0));
            }
        }
        
        [XmlElementAttribute("Version_1", Order=12, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=13)]
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
