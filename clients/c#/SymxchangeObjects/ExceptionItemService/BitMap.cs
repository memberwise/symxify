//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\ExceptionItemService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\ExceptionItemService\generated-output -n ExceptionItemService
namespace ExceptionItemService
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
    [XmlTypeAttribute("BitMap", Namespace="http://www.symxchange.generated.symitar.com/symxcommon")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class BitMap
    {
        
        [XmlIgnoreAttribute()]
        private Collection<short> _bit;
        
        [XmlElementAttribute("Bit", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<short> Bit
        {
            get
            {
                return _bit;
            }
            set
            {
                _bit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Bit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BitSpecified
        {
            get
            {
                return ((this.Bit != null) 
                            && (this.Bit.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BitMap" /> class.</para>
        /// </summary>
        public BitMap()
        {
            this._bit = new Collection<short>();
        }
        
        [XmlIgnoreAttribute()]
        private bool _all = false;
        
        [DefaultValueAttribute(false)]
        [XmlAttributeAttribute("all")]
        public bool All
        {
            get
            {
                return _all;
            }
            set
            {
                _all = value;
            }
        }
    }
}
