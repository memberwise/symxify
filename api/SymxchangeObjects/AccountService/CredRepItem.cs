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
    [XmlTypeAttribute("CredRepItem", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class CredRepItem
    {
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemAmount> _amount;
        
        [XmlElementAttribute("Amount", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemAmount> Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Amount collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return ((this.Amount != null) 
                            && (this.Amount.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CredRepItem" /> class.</para>
        /// </summary>
        public CredRepItem()
        {
            this._amount = new Collection<CredRepItemAmount>();
            this._ch1 = new Collection<CredRepItemCh1>();
            this._ch10 = new Collection<CredRepItemCh10>();
            this._ch15 = new Collection<CredRepItemCh15>();
            this._ch2 = new Collection<CredRepItemCh2>();
            this._ch26 = new Collection<CredRepItemCh26>();
            this._ch4 = new Collection<CredRepItemCh4>();
            this._chLong = new Collection<CredRepItemChLong>();
            this._code = new Collection<CredRepItemCode>();
            this._date = new Collection<CredRepItemDate>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCh1> _ch1;
        
        [XmlElementAttribute("Ch1", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCh1> Ch1
        {
            get
            {
                return _ch1;
            }
            set
            {
                _ch1 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Ch1 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Ch1Specified
        {
            get
            {
                return ((this.Ch1 != null) 
                            && (this.Ch1.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCh10> _ch10;
        
        [XmlElementAttribute("Ch10", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCh10> Ch10
        {
            get
            {
                return _ch10;
            }
            set
            {
                _ch10 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Ch10 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Ch10Specified
        {
            get
            {
                return ((this.Ch10 != null) 
                            && (this.Ch10.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCh15> _ch15;
        
        [XmlElementAttribute("Ch15", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCh15> Ch15
        {
            get
            {
                return _ch15;
            }
            set
            {
                _ch15 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Ch15 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Ch15Specified
        {
            get
            {
                return ((this.Ch15 != null) 
                            && (this.Ch15.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCh2> _ch2;
        
        [XmlElementAttribute("Ch2", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCh2> Ch2
        {
            get
            {
                return _ch2;
            }
            set
            {
                _ch2 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Ch2 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Ch2Specified
        {
            get
            {
                return ((this.Ch2 != null) 
                            && (this.Ch2.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCh26> _ch26;
        
        [XmlElementAttribute("Ch26", Order=5, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCh26> Ch26
        {
            get
            {
                return _ch26;
            }
            set
            {
                _ch26 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Ch26 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Ch26Specified
        {
            get
            {
                return ((this.Ch26 != null) 
                            && (this.Ch26.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCh4> _ch4;
        
        [XmlElementAttribute("Ch4", Order=6, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCh4> Ch4
        {
            get
            {
                return _ch4;
            }
            set
            {
                _ch4 = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Ch4 collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool Ch4Specified
        {
            get
            {
                return ((this.Ch4 != null) 
                            && (this.Ch4.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemChLong> _chLong;
        
        [XmlElementAttribute("ChLong", Order=7, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemChLong> ChLong
        {
            get
            {
                return _chLong;
            }
            set
            {
                _chLong = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ChLong collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChLongSpecified
        {
            get
            {
                return ((this.ChLong != null) 
                            && (this.ChLong.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemCode> _code;
        
        [XmlElementAttribute("Code", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemCode> Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Code collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CodeSpecified
        {
            get
            {
                return ((this.Code != null) 
                            && (this.Code.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CredRepItemDate> _date;
        
        [XmlElementAttribute("Date", Order=9, Form=XmlSchemaForm.Unqualified)]
        public Collection<CredRepItemDate> Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Date collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DateSpecified
        {
            get
            {
                return ((this.Date != null) 
                            && (this.Date.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("SegExtended", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short SegExtendedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SegExtended property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SegExtendedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> SegExtended
        {
            get
            {
                if (this.SegExtendedValueSpecified)
                {
                    return this.SegExtendedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SegExtendedValue = value.GetValueOrDefault();
                this.SegExtendedValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("SegmentType", Order=11, Form=XmlSchemaForm.Unqualified)]
        public string SegmentType { get; set; }
        
        [XmlElementAttribute("SubsegmentType", Order=12, Form=XmlSchemaForm.Unqualified)]
        public string SubsegmentType { get; set; }
        
        [XmlElementAttribute("Version_1", Order=13, Form=XmlSchemaForm.Unqualified)]
        public AccountService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=14)]
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
