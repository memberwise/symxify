//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1182.0 using the following command:
// xscgen C:\Users\tbuese\Desktop\Symxchange\CollateralService/*.xsd --sf --un --uc --order --cn -0 --collectionSettersMode=Public -o C:\Users\tbuese\Desktop\Symxchange\CollateralService\generated-output -n CollateralService
namespace CollateralService
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
    [XmlTypeAttribute("UpdateCollateralDocumentTrackingByIDRequest", Namespace="http://www.symxchange.generated.symitar.com/crud/collateral")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class UpdateCollateralDocumentTrackingByIdRequest
    {
        
        [XmlElementAttribute("CollateralNumber", Order=0, Form=XmlSchemaForm.Unqualified)]
        public string CollateralNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CollateralDocumentLocator", Order=1, Form=XmlSchemaForm.Unqualified)]
        public int CollateralDocumentLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CollateralDocumentLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CollateralDocumentLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> CollateralDocumentLocator
        {
            get
            {
                if (this.CollateralDocumentLocatorValueSpecified)
                {
                    return this.CollateralDocumentLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CollateralDocumentLocatorValue = value.GetValueOrDefault();
                this.CollateralDocumentLocatorValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CollateralDocumentTrackingLocator", Order=2, Form=XmlSchemaForm.Unqualified)]
        public int CollateralDocumentTrackingLocatorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CollateralDocumentTrackingLocator property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CollateralDocumentTrackingLocatorValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> CollateralDocumentTrackingLocator
        {
            get
            {
                if (this.CollateralDocumentTrackingLocatorValueSpecified)
                {
                    return this.CollateralDocumentTrackingLocatorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CollateralDocumentTrackingLocatorValue = value.GetValueOrDefault();
                this.CollateralDocumentTrackingLocatorValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("Credentials", Order=3, Form=XmlSchemaForm.Unqualified)]
        public CollateralService.AdminCredentialsChoice Credentials { get; set; }
        
        [XmlElementAttribute("DeviceInformation", Order=4, Form=XmlSchemaForm.Unqualified)]
        public CollateralService.DeviceInformation DeviceInformation { get; set; }
        
        [XmlElementAttribute("CollateralDocumentTrackingFields", Order=5, Form=XmlSchemaForm.Unqualified)]
        public CollateralService.CollateralDocumentTrackingFields_2 CollateralDocumentTrackingFields { get; set; }
        
        [XmlElementAttribute("Version_1", Order=6, Form=XmlSchemaForm.Unqualified)]
        public CollateralService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=7)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UpdateCollateralDocumentTrackingByIdRequest" /> class.</para>
        /// </summary>
        public UpdateCollateralDocumentTrackingByIdRequest()
        {
            this._any = new Collection<XmlElement>();
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("MessageId")]
        public string MessageId { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("BranchId", Namespace="http://www.symxchange.generated.symitar.com/crud/collateral", Form=XmlSchemaForm.Qualified)]
        public short BranchIdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchId property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BranchIdValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> BranchId
        {
            get
            {
                if (this.BranchIdValueSpecified)
                {
                    return this.BranchIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchIdValue = value.GetValueOrDefault();
                this.BranchIdValueSpecified = value.HasValue;
            }
        }
    }
}
