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
    [XmlTypeAttribute("Cdm", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("Cdm", Namespace="http://www.symxchange.generated.symitar.com/crud/parameter/dto/update")]
    [XmlIncludeAttribute(typeof(CdmFields_2))]
    public partial class Cdm_2
    {
        
        [XmlIgnoreAttribute()]
        private Collection<CdmCassDenom6DuressAuto1Notes_2> _cassDenom6DuressAuto1Notes;
        
        [XmlElementAttribute("CassDenom6DuressAuto1Notes", Order=0, Form=XmlSchemaForm.Unqualified)]
        public Collection<CdmCassDenom6DuressAuto1Notes_2> CassDenom6DuressAuto1Notes
        {
            get
            {
                return _cassDenom6DuressAuto1Notes;
            }
            set
            {
                _cassDenom6DuressAuto1Notes = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CassDenom6DuressAuto1Notes collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CassDenom6DuressAuto1NotesSpecified
        {
            get
            {
                return ((this.CassDenom6DuressAuto1Notes != null) 
                            && (this.CassDenom6DuressAuto1Notes.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Cdm_2" /> class.</para>
        /// </summary>
        public Cdm_2()
        {
            this._cassDenom6DuressAuto1Notes = new Collection<CdmCassDenom6DuressAuto1Notes_2>();
            this._cassDenom6DuressAuto2Notes = new Collection<CdmCassDenom6DuressAuto2Notes_2>();
            this._cassDenom6DuressAuto3Notes = new Collection<CdmCassDenom6DuressAuto3Notes_2>();
            this._cassetteDenomAutomixNotes = new Collection<CdmCassetteDenomAutomixNotes_2>();
            this._cassetteDenomination = new Collection<CdmCassetteDenomination_2>();
            this._any = new Collection<XmlElement>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CdmCassDenom6DuressAuto2Notes_2> _cassDenom6DuressAuto2Notes;
        
        [XmlElementAttribute("CassDenom6DuressAuto2Notes", Order=1, Form=XmlSchemaForm.Unqualified)]
        public Collection<CdmCassDenom6DuressAuto2Notes_2> CassDenom6DuressAuto2Notes
        {
            get
            {
                return _cassDenom6DuressAuto2Notes;
            }
            set
            {
                _cassDenom6DuressAuto2Notes = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CassDenom6DuressAuto2Notes collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CassDenom6DuressAuto2NotesSpecified
        {
            get
            {
                return ((this.CassDenom6DuressAuto2Notes != null) 
                            && (this.CassDenom6DuressAuto2Notes.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CdmCassDenom6DuressAuto3Notes_2> _cassDenom6DuressAuto3Notes;
        
        [XmlElementAttribute("CassDenom6DuressAuto3Notes", Order=2, Form=XmlSchemaForm.Unqualified)]
        public Collection<CdmCassDenom6DuressAuto3Notes_2> CassDenom6DuressAuto3Notes
        {
            get
            {
                return _cassDenom6DuressAuto3Notes;
            }
            set
            {
                _cassDenom6DuressAuto3Notes = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CassDenom6DuressAuto3Notes collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CassDenom6DuressAuto3NotesSpecified
        {
            get
            {
                return ((this.CassDenom6DuressAuto3Notes != null) 
                            && (this.CassDenom6DuressAuto3Notes.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CdmCassetteDenomAutomixNotes_2> _cassetteDenomAutomixNotes;
        
        [XmlElementAttribute("CassetteDenomAutomixNotes", Order=3, Form=XmlSchemaForm.Unqualified)]
        public Collection<CdmCassetteDenomAutomixNotes_2> CassetteDenomAutomixNotes
        {
            get
            {
                return _cassetteDenomAutomixNotes;
            }
            set
            {
                _cassetteDenomAutomixNotes = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CassetteDenomAutomixNotes collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CassetteDenomAutomixNotesSpecified
        {
            get
            {
                return ((this.CassetteDenomAutomixNotes != null) 
                            && (this.CassetteDenomAutomixNotes.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<CdmCassetteDenomination_2> _cassetteDenomination;
        
        [XmlElementAttribute("CassetteDenomination", Order=4, Form=XmlSchemaForm.Unqualified)]
        public Collection<CdmCassetteDenomination_2> CassetteDenomination
        {
            get
            {
                return _cassetteDenomination;
            }
            set
            {
                _cassetteDenomination = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CassetteDenomination collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CassetteDenominationSpecified
        {
            get
            {
                return ((this.CassetteDenomination != null) 
                            && (this.CassetteDenomination.Count != 0));
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Cdm", Order=5, Form=XmlSchemaForm.Unqualified)]
        public short CdmPropertyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CdmProperty property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CdmPropertyValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> CdmProperty
        {
            get
            {
                if (this.CdmPropertyValueSpecified)
                {
                    return this.CdmPropertyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CdmPropertyValue = value.GetValueOrDefault();
                this.CdmPropertyValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CdmDuressDispAmt", Order=6, Form=XmlSchemaForm.Unqualified)]
        public decimal CdmDuressDispAmtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CdmDuressDispAmt property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CdmDuressDispAmtValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<decimal> CdmDuressDispAmt
        {
            get
            {
                if (this.CdmDuressDispAmtValueSpecified)
                {
                    return this.CdmDuressDispAmtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CdmDuressDispAmtValue = value.GetValueOrDefault();
                this.CdmDuressDispAmtValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("CdmDuressSilentAlarm", Order=7, Form=XmlSchemaForm.Unqualified)]
        public bool CdmDuressSilentAlarmValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CdmDuressSilentAlarm property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool CdmDuressSilentAlarmValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> CdmDuressSilentAlarm
        {
            get
            {
                if (this.CdmDuressSilentAlarmValueSpecified)
                {
                    return this.CdmDuressSilentAlarmValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CdmDuressSilentAlarmValue = value.GetValueOrDefault();
                this.CdmDuressSilentAlarmValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("ConsoleFileName", Order=8, Form=XmlSchemaForm.Unqualified)]
        public string ConsoleFileName { get; set; }
        
        [XmlElementAttribute("ConsoleFileNameExt", Order=9, Form=XmlSchemaForm.Unqualified)]
        public string ConsoleFileNameExt { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("LeftCoinDispenser", Order=10, Form=XmlSchemaForm.Unqualified)]
        public bool LeftCoinDispenserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LeftCoinDispenser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LeftCoinDispenserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> LeftCoinDispenser
        {
            get
            {
                if (this.LeftCoinDispenserValueSpecified)
                {
                    return this.LeftCoinDispenserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LeftCoinDispenserValue = value.GetValueOrDefault();
                this.LeftCoinDispenserValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("MachineType", Order=11, Form=XmlSchemaForm.Unqualified)]
        public short MachineTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MachineType property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MachineTypeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<short> MachineType
        {
            get
            {
                if (this.MachineTypeValueSpecified)
                {
                    return this.MachineTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MachineTypeValue = value.GetValueOrDefault();
                this.MachineTypeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Recycler", Order=12, Form=XmlSchemaForm.Unqualified)]
        public bool RecyclerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Recycler property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RecyclerValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> Recycler
        {
            get
            {
                if (this.RecyclerValueSpecified)
                {
                    return this.RecyclerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RecyclerValue = value.GetValueOrDefault();
                this.RecyclerValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RemoteDevice", Order=13, Form=XmlSchemaForm.Unqualified)]
        public bool RemoteDeviceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RemoteDevice property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RemoteDeviceValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RemoteDevice
        {
            get
            {
                if (this.RemoteDeviceValueSpecified)
                {
                    return this.RemoteDeviceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RemoteDeviceValue = value.GetValueOrDefault();
                this.RemoteDeviceValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("RightCoinDispenser", Order=14, Form=XmlSchemaForm.Unqualified)]
        public bool RightCoinDispenserValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RightCoinDispenser property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RightCoinDispenserValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> RightCoinDispenser
        {
            get
            {
                if (this.RightCoinDispenserValueSpecified)
                {
                    return this.RightCoinDispenserValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RightCoinDispenserValue = value.GetValueOrDefault();
                this.RightCoinDispenserValueSpecified = value.HasValue;
            }
        }
        
        [XmlElementAttribute("UserIds", Order=15, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.BitMap UserIds { get; set; }
        
        [XmlElementAttribute("Version_1", Order=16, Form=XmlSchemaForm.Unqualified)]
        public ParameterService.VersionType Version1 { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<XmlElement> _any;
        
        [XmlAnyElementAttribute(Order=17)]
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
