//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\UserService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\UserService\generated-output -n UserService
namespace UserService
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
    [XmlTypeAttribute("UserPrivilege", Namespace="http://www.symxchange.generated.symitar.com/crud/user/dto/retrieve", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("UserPrivilege", Namespace="http://www.symxchange.generated.symitar.com/crud/user/dto/retrieve")]
    public partial class UserPrivilege
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("EntryId", Order=0, Form=XmlSchemaForm.Unqualified)]
        public short EntryIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EntryId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EntryIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> EntryId
        {
            get
            {
                if (this.EntryIdValueSpecified)
                {
                    return this.EntryIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EntryIdValue = value.GetValueOrDefault();
                this.EntryIdValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Privilege", Order=1, Form=XmlSchemaForm.Unqualified)]
        public bool PrivilegeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Privilege property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrivilegeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Privilege
        {
            get
            {
                if (this.PrivilegeValueSpecified)
                {
                    return this.PrivilegeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrivilegeValue = value.GetValueOrDefault();
                this.PrivilegeValueSpecified = value.HasValue;
            }
        }
    }
}
