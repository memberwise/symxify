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
    [XmlTypeAttribute("CpLetter", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("CpLetter", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class CpLetter
    {
        
        [XmlElementAttribute("Description", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LetterCode", Order=1, Form=XmlSchemaForm.Unqualified)]
        public short LetterCodeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LetterCode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LetterCodeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> LetterCode
        {
            get
            {
                if (this.LetterCodeValueSpecified)
                {
                    return this.LetterCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LetterCodeValue = value.GetValueOrDefault();
                this.LetterCodeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NextWorkDays", Order=2, Form=XmlSchemaForm.Unqualified)]
        public short NextWorkDaysValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NextWorkDays property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NextWorkDaysValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> NextWorkDays
        {
            get
            {
                if (this.NextWorkDaysValueSpecified)
                {
                    return this.NextWorkDaysValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NextWorkDaysValue = value.GetValueOrDefault();
                this.NextWorkDaysValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Specfile", Order=3, Form=XmlSchemaForm.Unqualified)]
        public string Specfile { get; set; }
        
        [XmlElementAttribute("Version_1", Order=4, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=5)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CpLetter" /> class.</para>
        /// </summary>
        public CpLetter()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
