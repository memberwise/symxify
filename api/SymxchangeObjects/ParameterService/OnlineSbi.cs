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
    [XmlTypeAttribute("OnlineSbi", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("OnlineSbi", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/retrieve")]
    public partial class OnlineSbi
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("AllowWdForCashedCheck", Order=0, Form=XmlSchemaForm.Unqualified)]
        public bool AllowWdForCashedCheckValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AllowWdForCashedCheck property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AllowWdForCashedCheckValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> AllowWdForCashedCheck
        {
            get
            {
                if (this.AllowWdForCashedCheckValueSpecified)
                {
                    return this.AllowWdForCashedCheckValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AllowWdForCashedCheckValue = value.GetValueOrDefault();
                this.AllowWdForCashedCheckValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("AvailBalApprExclList", Order=1, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap AvailBalApprExclList { get; set; }
        
        [XmlElementAttribute("AvailBalPostExclList", Order=2, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap AvailBalPostExclList { get; set; }
        
        [XmlElementAttribute("DepRestrictWarnCodeList", Order=3, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap DepRestrictWarnCodeList { get; set; }
        
        [XmlElementAttribute("FeeDescription", Order=4, Form=XmlSchemaForm.Unqualified)]
        public string FeeDescription { get; set; }
        
        [XmlElementAttribute("JointNameTypes", Order=5, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap JointNameTypes { get; set; }
        
        [XmlElementAttribute("LnExcludeList", Order=6, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap LnExcludeList { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MbrVfyInqSpPostOption", Order=7, Form=XmlSchemaForm.Unqualified)]
        public short MbrVfyInqSpPostOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MbrVfyInqSpPostOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MbrVfyInqSpPostOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MbrVfyInqSpPostOption
        {
            get
            {
                if (this.MbrVfyInqSpPostOptionValueSpecified)
                {
                    return this.MbrVfyInqSpPostOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MbrVfyInqSpPostOptionValue = value.GetValueOrDefault();
                this.MbrVfyInqSpPostOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NonIrsCertTranAccess", Order=8, Form=XmlSchemaForm.Unqualified)]
        public bool NonIrsCertTranAccessValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NonIrsCertTranAccess property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NonIrsCertTranAccessValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NonIrsCertTranAccess
        {
            get
            {
                if (this.NonIrsCertTranAccessValueSpecified)
                {
                    return this.NonIrsCertTranAccessValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NonIrsCertTranAccessValue = value.GetValueOrDefault();
                this.NonIrsCertTranAccessValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("NonIrsClubTranAccess", Order=9, Form=XmlSchemaForm.Unqualified)]
        public bool NonIrsClubTranAccessValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NonIrsClubTranAccess property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NonIrsClubTranAccessValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> NonIrsClubTranAccess
        {
            get
            {
                if (this.NonIrsClubTranAccessValueSpecified)
                {
                    return this.NonIrsClubTranAccessValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NonIrsClubTranAccessValue = value.GetValueOrDefault();
                this.NonIrsClubTranAccessValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("OutputSccComments", Order=10, Form=XmlSchemaForm.Unqualified)]
        public short OutputSccCommentsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OutputSccComments property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OutputSccCommentsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> OutputSccComments
        {
            get
            {
                if (this.OutputSccCommentsValueSpecified)
                {
                    return this.OutputSccCommentsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OutputSccCommentsValue = value.GetValueOrDefault();
                this.OutputSccCommentsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PayrollCheckHoldOption", Order=11, Form=XmlSchemaForm.Unqualified)]
        public short PayrollCheckHoldOptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PayrollCheckHoldOption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PayrollCheckHoldOptionValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> PayrollCheckHoldOption
        {
            get
            {
                if (this.PayrollCheckHoldOptionValueSpecified)
                {
                    return this.PayrollCheckHoldOptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PayrollCheckHoldOptionValue = value.GetValueOrDefault();
                this.PayrollCheckHoldOptionValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostInquiries", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool PostInquiriesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostInquiries property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostInquiriesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostInquiries
        {
            get
            {
                if (this.PostInquiriesValueSpecified)
                {
                    return this.PostInquiriesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostInquiriesValue = value.GetValueOrDefault();
                this.PostInquiriesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostMemberVerifications", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool PostMemberVerificationsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostMemberVerifications property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostMemberVerificationsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostMemberVerifications
        {
            get
            {
                if (this.PostMemberVerificationsValueSpecified)
                {
                    return this.PostMemberVerificationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostMemberVerificationsValue = value.GetValueOrDefault();
                this.PostMemberVerificationsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostSpecialPurchases", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool PostSpecialPurchasesValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostSpecialPurchases property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostSpecialPurchasesValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostSpecialPurchases
        {
            get
            {
                if (this.PostSpecialPurchasesValueSpecified)
                {
                    return this.PostSpecialPurchasesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostSpecialPurchasesValue = value.GetValueOrDefault();
                this.PostSpecialPurchasesValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("PostStatements", Order=15, Form=XmlSchemaForm.Unqualified)]
        public bool PostStatementsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PostStatements property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PostStatementsValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> PostStatements
        {
            get
            {
                if (this.PostStatementsValueSpecified)
                {
                    return this.PostStatementsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PostStatementsValue = value.GetValueOrDefault();
                this.PostStatementsValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RegCcPolicy", Order=16, Form=XmlSchemaForm.Unqualified)]
        public short RegCcPolicyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RegCcPolicy property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RegCcPolicyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> RegCcPolicy
        {
            get
            {
                if (this.RegCcPolicyValueSpecified)
                {
                    return this.RegCcPolicyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RegCcPolicyValue = value.GetValueOrDefault();
                this.RegCcPolicyValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("RestrictWarnCodeList", Order=17, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap RestrictWarnCodeList { get; set; }
        
        [XmlElementAttribute("SvExcludeList", Order=18, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap SvExcludeList { get; set; }
        
        [XmlElementAttribute("WdRestrictWarnCodeList", Order=19, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap WdRestrictWarnCodeList { get; set; }
        
        [XmlElementAttribute("Version_1", Order=20, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=21)]
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
        /// <para xml:lang="en">Initializes a new instance of the <see cref="OnlineSbi" /> class.</para>
        /// </summary>
        public OnlineSbi()
        {
            this._any = new Collection<XmlElement>();
        }
    }
}
