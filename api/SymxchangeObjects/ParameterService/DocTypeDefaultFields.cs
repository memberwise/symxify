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
    [XmlTypeAttribute("DocTypeDefaultFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("DocTypeDefaultFields", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class DocTypeDefaultFields
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Description", Order=0, Form=XmlSchemaForm.Unqualified)]
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
        [XmlElementAttribute("DocumentType", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool DocumentTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DocumentType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DocumentTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> DocumentType
        {
            get
            {
                if (this.DocumentTypeValueSpecified)
                {
                    return this.DocumentTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DocumentTypeValue = value.GetValueOrDefault();
                this.DocumentTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExcpNoticeCountCpWork", Order=2, Form=XmlSchemaForm.Unqualified)]
        public bool ExcpNoticeCountCpWorkValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExcpNoticeCountCpWork property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExcpNoticeCountCpWorkValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExcpNoticeCountCpWork
        {
            get
            {
                if (this.ExcpNoticeCountCpWorkValueSpecified)
                {
                    return this.ExcpNoticeCountCpWorkValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExcpNoticeCountCpWorkValue = value.GetValueOrDefault();
                this.ExcpNoticeCountCpWorkValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExcpNoticeOption", Order=3, Form=XmlSchemaForm.Unqualified)]
        public bool ExcpNoticeOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExcpNoticeOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExcpNoticeOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExcpNoticeOption
        {
            get
            {
                if (this.ExcpNoticeOptionValueSpecified)
                {
                    return this.ExcpNoticeOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExcpNoticeOptionValue = value.GetValueOrDefault();
                this.ExcpNoticeOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("ExpireDate", Order=4, Form=XmlSchemaForm.Unqualified)]
        public bool ExpireDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ExpireDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ExpireDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ExpireDate
        {
            get
            {
                if (this.ExpireDateValueSpecified)
                {
                    return this.ExpireDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ExpireDateValue = value.GetValueOrDefault();
                this.ExpireDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Type", Order=5, Form=XmlSchemaForm.Unqualified)]
        public bool TypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Type property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Type
        {
            get
            {
                if (this.TypeValueSpecified)
                {
                    return this.TypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TypeValue = value.GetValueOrDefault();
                this.TypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserChar1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public bool UserChar1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserChar1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserChar1ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserChar1
        {
            get
            {
                if (this.UserChar1ValueSpecified)
                {
                    return this.UserChar1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserChar1Value = value.GetValueOrDefault();
                this.UserChar1ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserChar2", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool UserChar2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserChar2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserChar2ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserChar2
        {
            get
            {
                if (this.UserChar2ValueSpecified)
                {
                    return this.UserChar2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserChar2Value = value.GetValueOrDefault();
                this.UserChar2ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserChar3", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool UserChar3Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserChar3 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserChar3ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserChar3
        {
            get
            {
                if (this.UserChar3ValueSpecified)
                {
                    return this.UserChar3Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserChar3Value = value.GetValueOrDefault();
                this.UserChar3ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserChar4", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool UserChar4Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserChar4 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserChar4ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserChar4
        {
            get
            {
                if (this.UserChar4ValueSpecified)
                {
                    return this.UserChar4Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserChar4Value = value.GetValueOrDefault();
                this.UserChar4ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserChar5", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool UserChar5Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserChar5 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserChar5ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserChar5
        {
            get
            {
                if (this.UserChar5ValueSpecified)
                {
                    return this.UserChar5Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserChar5Value = value.GetValueOrDefault();
                this.UserChar5ValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("UserChar6", Order=11, Form=XmlSchemaForm.Unqualified)]
        public bool UserChar6Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserChar6 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool UserChar6ValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> UserChar6
        {
            get
            {
                if (this.UserChar6ValueSpecified)
                {
                    return this.UserChar6Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserChar6Value = value.GetValueOrDefault();
                this.UserChar6ValueSpecified = value.HasValue;
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
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DocTypeDefaultFields" /> class.</para>
        /// </summary>
        public DocTypeDefaultFields()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
