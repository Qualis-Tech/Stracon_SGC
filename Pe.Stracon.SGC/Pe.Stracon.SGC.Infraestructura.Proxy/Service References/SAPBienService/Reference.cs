﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", ConfigurationName="SAPBienService.ZWS_ZETM_DATOS_EQUIPOS")]
    public interface ZWS_ZETM_DATOS_EQUIPOS {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación ZETM_DATOS_EQUIPOS no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:rfc:functions:ZWS_ZETM_DATOS_EQUIPOS:ZETM_DATOS_EQUIPOSR" +
            "equest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse1 ZETM_DATOS_EQUIPOS(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:rfc:functions:ZWS_ZETM_DATOS_EQUIPOS:ZETM_DATOS_EQUIPOSR" +
            "equest", ReplyAction="*")]
        System.Threading.Tasks.Task<Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse1> ZETM_DATOS_EQUIPOSAsync(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZETM_DATOS_EQUIPOS : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string i_MARCA_DESCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string I_MARCA_DESC {
            get {
                return this.i_MARCA_DESCField;
            }
            set {
                this.i_MARCA_DESCField = value;
                this.RaisePropertyChanged("I_MARCA_DESC");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class BAPIRET2 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tYPEField;
        
        private string idField;
        
        private string nUMBERField;
        
        private string mESSAGEField;
        
        private string lOG_NOField;
        
        private string lOG_MSG_NOField;
        
        private string mESSAGE_V1Field;
        
        private string mESSAGE_V2Field;
        
        private string mESSAGE_V3Field;
        
        private string mESSAGE_V4Field;
        
        private string pARAMETERField;
        
        private int rOWField;
        
        private string fIELDField;
        
        private string sYSTEMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string TYPE {
            get {
                return this.tYPEField;
            }
            set {
                this.tYPEField = value;
                this.RaisePropertyChanged("TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NUMBER {
            get {
                return this.nUMBERField;
            }
            set {
                this.nUMBERField = value;
                this.RaisePropertyChanged("NUMBER");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string MESSAGE {
            get {
                return this.mESSAGEField;
            }
            set {
                this.mESSAGEField = value;
                this.RaisePropertyChanged("MESSAGE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string LOG_NO {
            get {
                return this.lOG_NOField;
            }
            set {
                this.lOG_NOField = value;
                this.RaisePropertyChanged("LOG_NO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string LOG_MSG_NO {
            get {
                return this.lOG_MSG_NOField;
            }
            set {
                this.lOG_MSG_NOField = value;
                this.RaisePropertyChanged("LOG_MSG_NO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string MESSAGE_V1 {
            get {
                return this.mESSAGE_V1Field;
            }
            set {
                this.mESSAGE_V1Field = value;
                this.RaisePropertyChanged("MESSAGE_V1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string MESSAGE_V2 {
            get {
                return this.mESSAGE_V2Field;
            }
            set {
                this.mESSAGE_V2Field = value;
                this.RaisePropertyChanged("MESSAGE_V2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string MESSAGE_V3 {
            get {
                return this.mESSAGE_V3Field;
            }
            set {
                this.mESSAGE_V3Field = value;
                this.RaisePropertyChanged("MESSAGE_V3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string MESSAGE_V4 {
            get {
                return this.mESSAGE_V4Field;
            }
            set {
                this.mESSAGE_V4Field = value;
                this.RaisePropertyChanged("MESSAGE_V4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string PARAMETER {
            get {
                return this.pARAMETERField;
            }
            set {
                this.pARAMETERField = value;
                this.RaisePropertyChanged("PARAMETER");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int ROW {
            get {
                return this.rOWField;
            }
            set {
                this.rOWField = value;
                this.RaisePropertyChanged("ROW");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string FIELD {
            get {
                return this.fIELDField;
            }
            set {
                this.fIELDField = value;
                this.RaisePropertyChanged("FIELD");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string SYSTEM {
            get {
                return this.sYSTEMField;
            }
            set {
                this.sYSTEMField = value;
                this.RaisePropertyChanged("SYSTEM");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZST_DATOS_EQUIPOS_TEST : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string bUKRSField;
        
        private string tIDNRField;
        
        private string eQUNRField;
        
        private string eQKTXField;
        
        private string hERSTField;
        
        private string tYPBZField;
        
        private string sERGEField;
        
        private string aNSDTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string BUKRS {
            get {
                return this.bUKRSField;
            }
            set {
                this.bUKRSField = value;
                this.RaisePropertyChanged("BUKRS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TIDNR {
            get {
                return this.tIDNRField;
            }
            set {
                this.tIDNRField = value;
                this.RaisePropertyChanged("TIDNR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string EQUNR {
            get {
                return this.eQUNRField;
            }
            set {
                this.eQUNRField = value;
                this.RaisePropertyChanged("EQUNR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string EQKTX {
            get {
                return this.eQKTXField;
            }
            set {
                this.eQKTXField = value;
                this.RaisePropertyChanged("EQKTX");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string HERST {
            get {
                return this.hERSTField;
            }
            set {
                this.hERSTField = value;
                this.RaisePropertyChanged("HERST");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string TYPBZ {
            get {
                return this.tYPBZField;
            }
            set {
                this.tYPBZField = value;
                this.RaisePropertyChanged("TYPBZ");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string SERGE {
            get {
                return this.sERGEField;
            }
            set {
                this.sERGEField = value;
                this.RaisePropertyChanged("SERGE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ANSDT {
            get {
                return this.aNSDTField;
            }
            set {
                this.aNSDTField = value;
                this.RaisePropertyChanged("ANSDT");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZST_DATOS_EQUIPOS : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string hERSTField;
        
        private string tYPBZField;
        
        private string sERGEField;
        
        private string tIDNRField;
        
        private string eQKTXField;
        
        private string aNSDTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string HERST {
            get {
                return this.hERSTField;
            }
            set {
                this.hERSTField = value;
                this.RaisePropertyChanged("HERST");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TYPBZ {
            get {
                return this.tYPBZField;
            }
            set {
                this.tYPBZField = value;
                this.RaisePropertyChanged("TYPBZ");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string SERGE {
            get {
                return this.sERGEField;
            }
            set {
                this.sERGEField = value;
                this.RaisePropertyChanged("SERGE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string TIDNR {
            get {
                return this.tIDNRField;
            }
            set {
                this.tIDNRField = value;
                this.RaisePropertyChanged("TIDNR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string EQKTX {
            get {
                return this.eQKTXField;
            }
            set {
                this.eQKTXField = value;
                this.RaisePropertyChanged("EQKTX");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string ANSDT {
            get {
                return this.aNSDTField;
            }
            set {
                this.aNSDTField = value;
                this.RaisePropertyChanged("ANSDT");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZETM_DATOS_EQUIPOSResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ZST_DATOS_EQUIPOS[] t_RESULTADOField;
        
        private ZST_DATOS_EQUIPOS_TEST[] t_RESULTADO_TESTField;
        
        private BAPIRET2[] t_RETURNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZST_DATOS_EQUIPOS[] T_RESULTADO {
            get {
                return this.t_RESULTADOField;
            }
            set {
                this.t_RESULTADOField = value;
                this.RaisePropertyChanged("T_RESULTADO");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZST_DATOS_EQUIPOS_TEST[] T_RESULTADO_TEST {
            get {
                return this.t_RESULTADO_TESTField;
            }
            set {
                this.t_RESULTADO_TESTField = value;
                this.RaisePropertyChanged("T_RESULTADO_TEST");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public BAPIRET2[] T_RETURN {
            get {
                return this.t_RETURNField;
            }
            set {
                this.t_RETURNField = value;
                this.RaisePropertyChanged("T_RETURN");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZETM_DATOS_EQUIPOSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", Order=0)]
        public Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOS ZETM_DATOS_EQUIPOS;
        
        public ZETM_DATOS_EQUIPOSRequest() {
        }
        
        public ZETM_DATOS_EQUIPOSRequest(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOS ZETM_DATOS_EQUIPOS) {
            this.ZETM_DATOS_EQUIPOS = ZETM_DATOS_EQUIPOS;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZETM_DATOS_EQUIPOSResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:rfc:functions", Order=0)]
        public Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse ZETM_DATOS_EQUIPOSResponse;
        
        public ZETM_DATOS_EQUIPOSResponse1() {
        }
        
        public ZETM_DATOS_EQUIPOSResponse1(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse ZETM_DATOS_EQUIPOSResponse) {
            this.ZETM_DATOS_EQUIPOSResponse = ZETM_DATOS_EQUIPOSResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ZWS_ZETM_DATOS_EQUIPOSChannel : Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZWS_ZETM_DATOS_EQUIPOSClient : System.ServiceModel.ClientBase<Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS>, Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS {
        
        public ZWS_ZETM_DATOS_EQUIPOSClient() {
        }
        
        public ZWS_ZETM_DATOS_EQUIPOSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZWS_ZETM_DATOS_EQUIPOSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZWS_ZETM_DATOS_EQUIPOSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZWS_ZETM_DATOS_EQUIPOSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse1 Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS.ZETM_DATOS_EQUIPOS(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest request) {
            return base.Channel.ZETM_DATOS_EQUIPOS(request);
        }
        
        public Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse ZETM_DATOS_EQUIPOS(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOS ZETM_DATOS_EQUIPOS1) {
            Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest inValue = new Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest();
            inValue.ZETM_DATOS_EQUIPOS = ZETM_DATOS_EQUIPOS1;
            Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse1 retVal = ((Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS)(this)).ZETM_DATOS_EQUIPOS(inValue);
            return retVal.ZETM_DATOS_EQUIPOSResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse1> Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS.ZETM_DATOS_EQUIPOSAsync(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest request) {
            return base.Channel.ZETM_DATOS_EQUIPOSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSResponse1> ZETM_DATOS_EQUIPOSAsync(Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOS ZETM_DATOS_EQUIPOS) {
            Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest inValue = new Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZETM_DATOS_EQUIPOSRequest();
            inValue.ZETM_DATOS_EQUIPOS = ZETM_DATOS_EQUIPOS;
            return ((Pe.Stracon.SGC.Infraestructura.Proxy.SAPBienService.ZWS_ZETM_DATOS_EQUIPOS)(this)).ZETM_DATOS_EQUIPOSAsync(inValue);
        }
    }
}
