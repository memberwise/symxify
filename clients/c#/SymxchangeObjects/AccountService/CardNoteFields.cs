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
    [XmlTypeAttribute("CardNoteFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CardNoteFields", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    public partial class CardNoteFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Code", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool CodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Code property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Code
        {
            get
            {
                if (this.CodeValueSpecified)
                {
                    return this.CodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CodeValue = value.GetValueOrDefault();
                this.CodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnterDate", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool EnterDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnterDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnterDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EnterDate
        {
            get
            {
                if (this.EnterDateValueSpecified)
                {
                    return this.EnterDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnterDateValue = value.GetValueOrDefault();
                this.EnterDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EnterTime", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool EnterTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EnterTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EnterTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> EnterTime
        {
            get
            {
                if (this.EnterTimeValueSpecified)
                {
                    return this.EnterTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnterTimeValue = value.GetValueOrDefault();
                this.EnterTimeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExpirationDate", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool ExpirationDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExpirationDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpirationDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExpirationDate
        {
            get
            {
                if (this.ExpirationDateValueSpecified)
                {
                    return this.ExpirationDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpirationDateValue = value.GetValueOrDefault();
                this.ExpirationDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Id", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool IdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Id property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Id
        {
            get
            {
                if (this.IdValueSpecified)
                {
                    return this.IdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdValue = value.GetValueOrDefault();
                this.IdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("IdType", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool IdTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IdType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool IdTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> IdType
        {
            get
            {
                if (this.IdTypeValueSpecified)
                {
                    return this.IdTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdTypeValue = value.GetValueOrDefault();
                this.IdTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Locator", Order=6, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("RecordChangeDate", Order=7, Form=XmlSchemaForm.Unqualified)]
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
        
        [XmlIgnoreAttribute()]
        private Collection<short> _text;
        
        [XmlElementAttribute("Text", Order=8, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Text collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TextSpecified
        {
            get
            {
                return ((this.Text != null) 
                            && (this.Text.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CardNoteFields" /> class.</para>
        /// </summary>
        public CardNoteFields()
        {
            this._text = new Collection<short>();
            this._any = new Collection<XmlElement>();
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("TextLineCount", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool TextLineCountValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TextLineCount property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TextLineCountValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> TextLineCount
        {
            get
            {
                if (this.TextLineCountValueSpecified)
                {
                    return this.TextLineCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TextLineCountValue = value.GetValueOrDefault();
                this.TextLineCountValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserId", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool UserIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserId
        {
            get
            {
                if (this.UserIdValueSpecified)
                {
                    return this.UserIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserIdValue = value.GetValueOrDefault();
                this.UserIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VoidFlag", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool VoidFlagValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VoidFlag property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VoidFlagValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VoidFlag
        {
            get
            {
                if (this.VoidFlagValueSpecified)
                {
                    return this.VoidFlagValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VoidFlagValue = value.GetValueOrDefault();
                this.VoidFlagValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("VoidedBy", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool VoidedByValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VoidedBy property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool VoidedByValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> VoidedBy
        {
            get
            {
                if (this.VoidedByValueSpecified)
                {
                    return this.VoidedByValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VoidedByValue = value.GetValueOrDefault();
                this.VoidedByValueSpecified = value.HasValue;
            }
        }
        
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
