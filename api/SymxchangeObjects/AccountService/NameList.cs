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
    [XmlTypeAttribute("NameList", Namespace="http://www.symxchange.generated.symitar.com/crud/account/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class NameList
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("hasReachedMaximumListSize", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool HasReachedMaximumListSizeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HasReachedMaximumListSize property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HasReachedMaximumListSizeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> HasReachedMaximumListSize
        {
            get
            {
                if (this.HasReachedMaximumListSizeValueSpecified)
                {
                    return this.HasReachedMaximumListSizeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HasReachedMaximumListSizeValue = value.GetValueOrDefault();
                this.HasReachedMaximumListSizeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<Name> _name;
        
        [XmlElementAttribute("Name", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<Name> Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Name collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return ((this.Name != null) 
                            && (this.Name.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="NameList" /> class.</para>
        /// </summary>
        public NameList()
        {
            this._name = new Collection<Name>();
        }
    }
}
