﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.ServicioUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://servicios.org/", ConfigurationName="ServicioUsuario.ServiciosUsuario")]
    public interface ServiciosUsuario {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/LoginUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/LoginUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioUsuario.LoginUsuarioResponse LoginUsuario(ProyectoFinal.ServicioUsuario.LoginUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/LoginUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/LoginUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.LoginUsuarioResponse> LoginUsuarioAsync(ProyectoFinal.ServicioUsuario.LoginUsuarioRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/ObtenerUsuariosRequest", ReplyAction="http://servicios.org/ServiciosUsuario/ObtenerUsuariosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioUsuario.ObtenerUsuariosResponse ObtenerUsuarios(ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/ObtenerUsuariosRequest", ReplyAction="http://servicios.org/ServiciosUsuario/ObtenerUsuariosResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.ObtenerUsuariosResponse> ObtenerUsuariosAsync(ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/insertarUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/insertarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioUsuario.insertarUsuarioResponse insertarUsuario(ProyectoFinal.ServicioUsuario.insertarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/insertarUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/insertarUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.insertarUsuarioResponse> insertarUsuarioAsync(ProyectoFinal.ServicioUsuario.insertarUsuarioRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/eliminarUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/eliminarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioUsuario.eliminarUsuarioResponse eliminarUsuario(ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/eliminarUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/eliminarUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.eliminarUsuarioResponse> eliminarUsuarioAsync(ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/actualizarUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/actualizarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoFinal.ServicioUsuario.actualizarUsuarioResponse actualizarUsuario(ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios.org/ServiciosUsuario/actualizarUsuarioRequest", ReplyAction="http://servicios.org/ServiciosUsuario/actualizarUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.actualizarUsuarioResponse> actualizarUsuarioAsync(ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.org/")]
    public partial class modelUsuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private string contrasenaField;
        
        private string dPIField;
        
        private string emailField;
        
        private bool estadoField;
        
        private int idUsuarioField;
        
        private string nombreField;
        
        private int telefonoField;
        
        private int tipo_usuarioField;
        
        private string tipo_usuario_nombreField;
        
        private string usuario_aliasField;
        
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
        public string contrasena {
            get {
                return this.contrasenaField;
            }
            set {
                this.contrasenaField = value;
                this.RaisePropertyChanged("contrasena");
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("email");
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
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("idUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int tipo_usuario {
            get {
                return this.tipo_usuarioField;
            }
            set {
                this.tipo_usuarioField = value;
                this.RaisePropertyChanged("tipo_usuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string tipo_usuario_nombre {
            get {
                return this.tipo_usuario_nombreField;
            }
            set {
                this.tipo_usuario_nombreField = value;
                this.RaisePropertyChanged("tipo_usuario_nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string usuario_alias {
            get {
                return this.usuario_aliasField;
            }
            set {
                this.usuario_aliasField = value;
                this.RaisePropertyChanged("usuario_alias");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginUsuario", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class LoginUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string contrasena;
        
        public LoginUsuarioRequest() {
        }
        
        public LoginUsuarioRequest(string email, string contrasena) {
            this.email = email;
            this.contrasena = contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginUsuarioResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class LoginUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoFinal.ServicioUsuario.modelUsuario[] @return;
        
        public LoginUsuarioResponse() {
        }
        
        public LoginUsuarioResponse(ProyectoFinal.ServicioUsuario.modelUsuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerUsuarios", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class ObtenerUsuariosRequest {
        
        public ObtenerUsuariosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ObtenerUsuariosResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class ObtenerUsuariosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoFinal.ServicioUsuario.modelUsuario[] @return;
        
        public ObtenerUsuariosResponse() {
        }
        
        public ObtenerUsuariosResponse(ProyectoFinal.ServicioUsuario.modelUsuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuario", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class insertarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USUARIO_ALIAS;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NOMBRE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APELLIDO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMAIL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CONTRASENA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TELEFONO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TIPO_USUARIO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DPI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ESTADO;
        
        public insertarUsuarioRequest() {
        }
        
        public insertarUsuarioRequest(string USUARIO_ALIAS, string NOMBRE, string APELLIDO, string EMAIL, string CONTRASENA, int TELEFONO, int TIPO_USUARIO, string DPI, bool ESTADO) {
            this.USUARIO_ALIAS = USUARIO_ALIAS;
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.EMAIL = EMAIL;
            this.CONTRASENA = CONTRASENA;
            this.TELEFONO = TELEFONO;
            this.TIPO_USUARIO = TIPO_USUARIO;
            this.DPI = DPI;
            this.ESTADO = ESTADO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuarioResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class insertarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public insertarUsuarioResponse() {
        }
        
        public insertarUsuarioResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarUsuario", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class eliminarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarUsuarioRequest() {
        }
        
        public eliminarUsuarioRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarUsuarioResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class eliminarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public eliminarUsuarioResponse() {
        }
        
        public eliminarUsuarioResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarUsuario", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class actualizarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USUARIO_ALIAS;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NOMBRE;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APELLIDO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMAIL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CONTRASENA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TELEFONO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TIPO_USUARIO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DPI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ESTADO;
        
        public actualizarUsuarioRequest() {
        }
        
        public actualizarUsuarioRequest(int ID, string USUARIO_ALIAS, string NOMBRE, string APELLIDO, string EMAIL, string CONTRASENA, int TELEFONO, int TIPO_USUARIO, string DPI, bool ESTADO) {
            this.ID = ID;
            this.USUARIO_ALIAS = USUARIO_ALIAS;
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.EMAIL = EMAIL;
            this.CONTRASENA = CONTRASENA;
            this.TELEFONO = TELEFONO;
            this.TIPO_USUARIO = TIPO_USUARIO;
            this.DPI = DPI;
            this.ESTADO = ESTADO;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarUsuarioResponse", WrapperNamespace="http://servicios.org/", IsWrapped=true)]
    public partial class actualizarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public actualizarUsuarioResponse() {
        }
        
        public actualizarUsuarioResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiciosUsuarioChannel : ProyectoFinal.ServicioUsuario.ServiciosUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosUsuarioClient : System.ServiceModel.ClientBase<ProyectoFinal.ServicioUsuario.ServiciosUsuario>, ProyectoFinal.ServicioUsuario.ServiciosUsuario {
        
        public ServiciosUsuarioClient() {
        }
        
        public ServiciosUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioUsuario.LoginUsuarioResponse ProyectoFinal.ServicioUsuario.ServiciosUsuario.LoginUsuario(ProyectoFinal.ServicioUsuario.LoginUsuarioRequest request) {
            return base.Channel.LoginUsuario(request);
        }
        
        public ProyectoFinal.ServicioUsuario.modelUsuario[] LoginUsuario(string email, string contrasena) {
            ProyectoFinal.ServicioUsuario.LoginUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.LoginUsuarioRequest();
            inValue.email = email;
            inValue.contrasena = contrasena;
            ProyectoFinal.ServicioUsuario.LoginUsuarioResponse retVal = ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).LoginUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.LoginUsuarioResponse> ProyectoFinal.ServicioUsuario.ServiciosUsuario.LoginUsuarioAsync(ProyectoFinal.ServicioUsuario.LoginUsuarioRequest request) {
            return base.Channel.LoginUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.LoginUsuarioResponse> LoginUsuarioAsync(string email, string contrasena) {
            ProyectoFinal.ServicioUsuario.LoginUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.LoginUsuarioRequest();
            inValue.email = email;
            inValue.contrasena = contrasena;
            return ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).LoginUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioUsuario.ObtenerUsuariosResponse ProyectoFinal.ServicioUsuario.ServiciosUsuario.ObtenerUsuarios(ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest request) {
            return base.Channel.ObtenerUsuarios(request);
        }
        
        public ProyectoFinal.ServicioUsuario.modelUsuario[] ObtenerUsuarios() {
            ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest inValue = new ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest();
            ProyectoFinal.ServicioUsuario.ObtenerUsuariosResponse retVal = ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).ObtenerUsuarios(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.ObtenerUsuariosResponse> ProyectoFinal.ServicioUsuario.ServiciosUsuario.ObtenerUsuariosAsync(ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest request) {
            return base.Channel.ObtenerUsuariosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.ObtenerUsuariosResponse> ObtenerUsuariosAsync() {
            ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest inValue = new ProyectoFinal.ServicioUsuario.ObtenerUsuariosRequest();
            return ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).ObtenerUsuariosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioUsuario.insertarUsuarioResponse ProyectoFinal.ServicioUsuario.ServiciosUsuario.insertarUsuario(ProyectoFinal.ServicioUsuario.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuario(request);
        }
        
        public bool insertarUsuario(string USUARIO_ALIAS, string NOMBRE, string APELLIDO, string EMAIL, string CONTRASENA, int TELEFONO, int TIPO_USUARIO, string DPI, bool ESTADO) {
            ProyectoFinal.ServicioUsuario.insertarUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.insertarUsuarioRequest();
            inValue.USUARIO_ALIAS = USUARIO_ALIAS;
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.EMAIL = EMAIL;
            inValue.CONTRASENA = CONTRASENA;
            inValue.TELEFONO = TELEFONO;
            inValue.TIPO_USUARIO = TIPO_USUARIO;
            inValue.DPI = DPI;
            inValue.ESTADO = ESTADO;
            ProyectoFinal.ServicioUsuario.insertarUsuarioResponse retVal = ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).insertarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.insertarUsuarioResponse> ProyectoFinal.ServicioUsuario.ServiciosUsuario.insertarUsuarioAsync(ProyectoFinal.ServicioUsuario.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.insertarUsuarioResponse> insertarUsuarioAsync(string USUARIO_ALIAS, string NOMBRE, string APELLIDO, string EMAIL, string CONTRASENA, int TELEFONO, int TIPO_USUARIO, string DPI, bool ESTADO) {
            ProyectoFinal.ServicioUsuario.insertarUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.insertarUsuarioRequest();
            inValue.USUARIO_ALIAS = USUARIO_ALIAS;
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.EMAIL = EMAIL;
            inValue.CONTRASENA = CONTRASENA;
            inValue.TELEFONO = TELEFONO;
            inValue.TIPO_USUARIO = TIPO_USUARIO;
            inValue.DPI = DPI;
            inValue.ESTADO = ESTADO;
            return ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).insertarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioUsuario.eliminarUsuarioResponse ProyectoFinal.ServicioUsuario.ServiciosUsuario.eliminarUsuario(ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuario(request);
        }
        
        public bool eliminarUsuario(int id) {
            ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest();
            inValue.id = id;
            ProyectoFinal.ServicioUsuario.eliminarUsuarioResponse retVal = ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).eliminarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.eliminarUsuarioResponse> ProyectoFinal.ServicioUsuario.ServiciosUsuario.eliminarUsuarioAsync(ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.eliminarUsuarioResponse> eliminarUsuarioAsync(int id) {
            ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.eliminarUsuarioRequest();
            inValue.id = id;
            return ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).eliminarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoFinal.ServicioUsuario.actualizarUsuarioResponse ProyectoFinal.ServicioUsuario.ServiciosUsuario.actualizarUsuario(ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest request) {
            return base.Channel.actualizarUsuario(request);
        }
        
        public bool actualizarUsuario(int ID, string USUARIO_ALIAS, string NOMBRE, string APELLIDO, string EMAIL, string CONTRASENA, int TELEFONO, int TIPO_USUARIO, string DPI, bool ESTADO) {
            ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest();
            inValue.ID = ID;
            inValue.USUARIO_ALIAS = USUARIO_ALIAS;
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.EMAIL = EMAIL;
            inValue.CONTRASENA = CONTRASENA;
            inValue.TELEFONO = TELEFONO;
            inValue.TIPO_USUARIO = TIPO_USUARIO;
            inValue.DPI = DPI;
            inValue.ESTADO = ESTADO;
            ProyectoFinal.ServicioUsuario.actualizarUsuarioResponse retVal = ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).actualizarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.actualizarUsuarioResponse> ProyectoFinal.ServicioUsuario.ServiciosUsuario.actualizarUsuarioAsync(ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest request) {
            return base.Channel.actualizarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinal.ServicioUsuario.actualizarUsuarioResponse> actualizarUsuarioAsync(int ID, string USUARIO_ALIAS, string NOMBRE, string APELLIDO, string EMAIL, string CONTRASENA, int TELEFONO, int TIPO_USUARIO, string DPI, bool ESTADO) {
            ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest inValue = new ProyectoFinal.ServicioUsuario.actualizarUsuarioRequest();
            inValue.ID = ID;
            inValue.USUARIO_ALIAS = USUARIO_ALIAS;
            inValue.NOMBRE = NOMBRE;
            inValue.APELLIDO = APELLIDO;
            inValue.EMAIL = EMAIL;
            inValue.CONTRASENA = CONTRASENA;
            inValue.TELEFONO = TELEFONO;
            inValue.TIPO_USUARIO = TIPO_USUARIO;
            inValue.DPI = DPI;
            inValue.ESTADO = ESTADO;
            return ((ProyectoFinal.ServicioUsuario.ServiciosUsuario)(this)).actualizarUsuarioAsync(inValue);
        }
    }
}
