﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.ServicioColaborador {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://servicios.org/", ConfigurationName="ServicioColaborador.ServicioColaborador")]
    public interface ServicioColaborador {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/ObtenerColaboradorresRequest", ReplyAction="http://servicios.org/ServicioColaborador/ObtenerColaboradorresResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioColaborador.ObtenerColaboradorresResponse ObtenerColaboradorres(ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/ObtenerColaboradorresRequest", ReplyAction="http://servicios.org/ServicioColaborador/ObtenerColaboradorresResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.ObtenerColaboradorresResponse> ObtenerColaboradorresAsync(ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/ObtenerCargosRequest", ReplyAction="http://servicios.org/ServicioColaborador/ObtenerCargosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioColaborador.ObtenerCargosResponse ObtenerCargos(ProyectoFinal.ServicioColaborador.ObtenerCargosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/ObtenerCargosRequest", ReplyAction="http://servicios.org/ServicioColaborador/ObtenerCargosResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.ObtenerCargosResponse> ObtenerCargosAsync(ProyectoFinal.ServicioColaborador.ObtenerCargosRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/eliminarColaboradorRequest", ReplyAction="http://servicios.org/ServicioColaborador/eliminarColaboradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioColaborador.eliminarColaboradorResponse eliminarColaborador(ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/eliminarColaboradorRequest", ReplyAction="http://servicios.org/ServicioColaborador/eliminarColaboradorResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.eliminarColaboradorResponse> eliminarColaboradorAsync(ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/actualizarColaboradorRequest", ReplyAction="http://servicios.org/ServicioColaborador/actualizarColaboradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioColaborador.actualizarColaboradorResponse actualizarColaborador(ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/actualizarColaboradorRequest", ReplyAction="http://servicios.org/ServicioColaborador/actualizarColaboradorResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.actualizarColaboradorResponse> actualizarColaboradorAsync(ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/insertarColaboradorRequest", ReplyAction="http://servicios.org/ServicioColaborador/insertarColaboradorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioColaborador.insertarColaboradorResponse insertarColaborador(ProyectoFinal.ServicioColaborador.insertarColaboradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServicioColaborador/insertarColaboradorRequest", ReplyAction="http://servicios.org/ServicioColaborador/insertarColaboradorResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.insertarColaboradorResponse> insertarColaboradorAsync(ProyectoFinal.ServicioColaborador.insertarColaboradorRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.org/")]
    public partial class modelColaboradores : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private string cargoField;
        
        private string dPIField;
        
        private string domicilioField;
        
        private bool estadoField;
        
        private string fechaContratacionField;
        
        private string fechaNacimientoField;
        
        private int idCargoField;
        
        private int idColaboradorField;
        
        private string nombreField;
        
        private string placaField;
        
        private string telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cargo {
            get {
                return this.cargoField;
            }
            set {
                this.cargoField = value;
                this.RaisePropertyChanged("cargo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string DPI {
            get {
                return this.dPIField;
            }
            set {
                this.dPIField = value;
                this.RaisePropertyChanged("DPI");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
                this.RaisePropertyChanged("domicilio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string fechaContratacion {
            get {
                return this.fechaContratacionField;
            }
            set {
                this.fechaContratacionField = value;
                this.RaisePropertyChanged("fechaContratacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
                this.RaisePropertyChanged("fechaNacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int idCargo {
            get {
                return this.idCargoField;
            }
            set {
                this.idCargoField = value;
                this.RaisePropertyChanged("idCargo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int idColaborador {
            get {
                return this.idColaboradorField;
            }
            set {
                this.idColaboradorField = value;
                this.RaisePropertyChanged("idColaborador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerColaboradorres", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class ObtenerColaboradorresRequest {
        
        public ObtenerColaboradorresRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerColaboradorresResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class ObtenerColaboradorresResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoFinal.ServicioColaborador.modelColaboradores[] @return;
        
        public ObtenerColaboradorresResponse() {
        }
        
        public ObtenerColaboradorresResponse(ProyectoFinal.ServicioColaborador.modelColaboradores[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerCargos", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class ObtenerCargosRequest {
        
        public ObtenerCargosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerCargosResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class ObtenerCargosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoFinal.ServicioColaborador.modelColaboradores[] @return;
        
        public ObtenerCargosResponse() {
        }
        
        public ObtenerCargosResponse(ProyectoFinal.ServicioColaborador.modelColaboradores[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarColaborador", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class eliminarColaboradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarColaboradorRequest() {
        }
        
        public eliminarColaboradorRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarColaboradorResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class eliminarColaboradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public eliminarColaboradorResponse() {
        }
        
        public eliminarColaboradorResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarColaborador", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class actualizarColaboradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NOMBRE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APELLIDO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DPI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ID_CARGO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FCH_NAC;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FCH_CONTRAT;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DOMICILIO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TELEFONO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PLACA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=10)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ESTADO;
        
        public actualizarColaboradorRequest() {
        }
        
        public actualizarColaboradorRequest(int ID, string NOMBRE, string APELLIDO, string DPI, int ID_CARGO, string FCH_NAC, string FCH_CONTRAT, string DOMICILIO, string TELEFONO, string PLACA, bool ESTADO) {
            this.ID = ID;
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.DPI = DPI;
            this.ID_CARGO = ID_CARGO;
            this.FCH_NAC = FCH_NAC;
            this.FCH_CONTRAT = FCH_CONTRAT;
            this.DOMICILIO = DOMICILIO;
            this.TELEFONO = TELEFONO;
            this.PLACA = PLACA;
            this.ESTADO = ESTADO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarColaboradorResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class actualizarColaboradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public actualizarColaboradorResponse() {
        }
        
        public actualizarColaboradorResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarColaborador", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class insertarColaboradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NOMBRE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APELLIDO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DPI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ID_CARGO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FCH_NAC;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FCH_CONTRAT;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DOMICILIO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TELEFONO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PLACA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ESTADO;
        
        public insertarColaboradorRequest() {
        }
        
        public insertarColaboradorRequest(string NOMBRE, string APELLIDO, string DPI, int ID_CARGO, string FCH_NAC, string FCH_CONTRAT, string DOMICILIO, string TELEFONO, string PLACA, bool ESTADO) {
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.DPI = DPI;
            this.ID_CARGO = ID_CARGO;
            this.FCH_NAC = FCH_NAC;
            this.FCH_CONTRAT = FCH_CONTRAT;
            this.DOMICILIO = DOMICILIO;
            this.TELEFONO = TELEFONO;
            this.PLACA = PLACA;
            this.ESTADO = ESTADO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarColaboradorResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class insertarColaboradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public insertarColaboradorResponse() {
        }
        
        public insertarColaboradorResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioColaboradorChannel : ProyectoFinal.ServicioColaborador.ServicioColaborador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioColaboradorClient : System.ServiceModel.ClientBase<ProyectoFinal.ServicioColaborador.ServicioColaborador>, ProyectoFinal.ServicioColaborador.ServicioColaborador {
        
        public ServicioColaboradorClient() {
        }
        
        public ServicioColaboradorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioColaboradorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioColaboradorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioColaboradorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioColaborador.ObtenerColaboradorresResponse ProyectoFinal.ServicioColaborador.ServicioColaborador.ObtenerColaboradorres(ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest request) {
            return base.Channel.ObtenerColaboradorres(request);
        }
        
        public ProyectoFinal.ServicioColaborador.modelColaboradores[] ObtenerColaboradorres() {
            ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest inValue = new ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest();
            ProyectoFinal.ServicioColaborador.ObtenerColaboradorresResponse retVal = ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).ObtenerColaboradorres(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.ObtenerColaboradorresResponse> ProyectoFinal.ServicioColaborador.ServicioColaborador.ObtenerColaboradorresAsync(ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest request) {
            return base.Channel.ObtenerColaboradorresAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.ObtenerColaboradorresResponse> ObtenerColaboradorresAsync() {
            ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest inValue = new ProyectoFinal.ServicioColaborador.ObtenerColaboradorresRequest();
            return ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).ObtenerColaboradorresAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioColaborador.ObtenerCargosResponse ProyectoFinal.ServicioColaborador.ServicioColaborador.ObtenerCargos(ProyectoFinal.ServicioColaborador.ObtenerCargosRequest request) {
            return base.Channel.ObtenerCargos(request);
        }
        
        public ProyectoFinal.ServicioColaborador.modelColaboradores[] ObtenerCargos() {
            ProyectoFinal.ServicioColaborador.ObtenerCargosRequest inValue = new ProyectoFinal.ServicioColaborador.ObtenerCargosRequest();
            ProyectoFinal.ServicioColaborador.ObtenerCargosResponse retVal = ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).ObtenerCargos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.ObtenerCargosResponse> ProyectoFinal.ServicioColaborador.ServicioColaborador.ObtenerCargosAsync(ProyectoFinal.ServicioColaborador.ObtenerCargosRequest request) {
            return base.Channel.ObtenerCargosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.ObtenerCargosResponse> ObtenerCargosAsync() {
            ProyectoFinal.ServicioColaborador.ObtenerCargosRequest inValue = new ProyectoFinal.ServicioColaborador.ObtenerCargosRequest();
            return ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).ObtenerCargosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioColaborador.eliminarColaboradorResponse ProyectoFinal.ServicioColaborador.ServicioColaborador.eliminarColaborador(ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest request) {
            return base.Channel.eliminarColaborador(request);
        }
        
        public bool eliminarColaborador(int id) {
            ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest inValue = new ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest();
            inValue.id = id;
            ProyectoFinal.ServicioColaborador.eliminarColaboradorResponse retVal = ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).eliminarColaborador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.eliminarColaboradorResponse> ProyectoFinal.ServicioColaborador.ServicioColaborador.eliminarColaboradorAsync(ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest request) {
            return base.Channel.eliminarColaboradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.eliminarColaboradorResponse> eliminarColaboradorAsync(int id) {
            ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest inValue = new ProyectoFinal.ServicioColaborador.eliminarColaboradorRequest();
            inValue.id = id;
            return ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).eliminarColaboradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioColaborador.actualizarColaboradorResponse ProyectoFinal.ServicioColaborador.ServicioColaborador.actualizarColaborador(ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest request) {
            return base.Channel.actualizarColaborador(request);
        }
        
        public bool actualizarColaborador(int ID, string NOMBRE, string APELLIDO, string DPI, int ID_CARGO, string FCH_NAC, string FCH_CONTRAT, string DOMICILIO, string TELEFONO, string PLACA, bool ESTADO) {
            ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest inValue = new ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest();
            inValue.ID = ID;
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.DPI = DPI;
            inValue.ID_CARGO = ID_CARGO;
            inValue.FCH_NAC = FCH_NAC;
            inValue.FCH_CONTRAT = FCH_CONTRAT;
            inValue.DOMICILIO = DOMICILIO;
            inValue.TELEFONO = TELEFONO;
            inValue.PLACA = PLACA;
            inValue.ESTADO = ESTADO;
            ProyectoFinal.ServicioColaborador.actualizarColaboradorResponse retVal = ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).actualizarColaborador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.actualizarColaboradorResponse> ProyectoFinal.ServicioColaborador.ServicioColaborador.actualizarColaboradorAsync(ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest request) {
            return base.Channel.actualizarColaboradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.actualizarColaboradorResponse> actualizarColaboradorAsync(int ID, string NOMBRE, string APELLIDO, string DPI, int ID_CARGO, string FCH_NAC, string FCH_CONTRAT, string DOMICILIO, string TELEFONO, string PLACA, bool ESTADO) {
            ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest inValue = new ProyectoFinal.ServicioColaborador.actualizarColaboradorRequest();
            inValue.ID = ID;
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.DPI = DPI;
            inValue.ID_CARGO = ID_CARGO;
            inValue.FCH_NAC = FCH_NAC;
            inValue.FCH_CONTRAT = FCH_CONTRAT;
            inValue.DOMICILIO = DOMICILIO;
            inValue.TELEFONO = TELEFONO;
            inValue.PLACA = PLACA;
            inValue.ESTADO = ESTADO;
            return ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).actualizarColaboradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioColaborador.insertarColaboradorResponse ProyectoFinal.ServicioColaborador.ServicioColaborador.insertarColaborador(ProyectoFinal.ServicioColaborador.insertarColaboradorRequest request) {
            return base.Channel.insertarColaborador(request);
        }
        
        public bool insertarColaborador(string NOMBRE, string APELLIDO, string DPI, int ID_CARGO, string FCH_NAC, string FCH_CONTRAT, string DOMICILIO, string TELEFONO, string PLACA, bool ESTADO) {
            ProyectoFinal.ServicioColaborador.insertarColaboradorRequest inValue = new ProyectoFinal.ServicioColaborador.insertarColaboradorRequest();
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.DPI = DPI;
            inValue.ID_CARGO = ID_CARGO;
            inValue.FCH_NAC = FCH_NAC;
            inValue.FCH_CONTRAT = FCH_CONTRAT;
            inValue.DOMICILIO = DOMICILIO;
            inValue.TELEFONO = TELEFONO;
            inValue.PLACA = PLACA;
            inValue.ESTADO = ESTADO;
            ProyectoFinal.ServicioColaborador.insertarColaboradorResponse retVal = ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).insertarColaborador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.insertarColaboradorResponse> ProyectoFinal.ServicioColaborador.ServicioColaborador.insertarColaboradorAsync(ProyectoFinal.ServicioColaborador.insertarColaboradorRequest request) {
            return base.Channel.insertarColaboradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioColaborador.insertarColaboradorResponse> insertarColaboradorAsync(string NOMBRE, string APELLIDO, string DPI, int ID_CARGO, string FCH_NAC, string FCH_CONTRAT, string DOMICILIO, string TELEFONO, string PLACA, bool ESTADO) {
            ProyectoFinal.ServicioColaborador.insertarColaboradorRequest inValue = new ProyectoFinal.ServicioColaborador.insertarColaboradorRequest();
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.DPI = DPI;
            inValue.ID_CARGO = ID_CARGO;
            inValue.FCH_NAC = FCH_NAC;
            inValue.FCH_CONTRAT = FCH_CONTRAT;
            inValue.DOMICILIO = DOMICILIO;
            inValue.TELEFONO = TELEFONO;
            inValue.PLACA = PLACA;
            inValue.ESTADO = ESTADO;
            return ((ProyectoFinal.ServicioColaborador.ServicioColaborador)(this)).insertarColaboradorAsync(inValue);
        }
    }
}
