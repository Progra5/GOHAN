﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSNegocio.SRBaseDatos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRBaseDatos.BaseDatosSoap")]
    public interface BaseDatosSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WSNegocio.SRBaseDatos.HelloWorldResponse HelloWorld(WSNegocio.SRBaseDatos.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarCuerpo", ReplyAction="*")]
        WSNegocio.SRBaseDatos.InsertarCuerpoResponse InsertarCuerpo(WSNegocio.SRBaseDatos.InsertarCuerpoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento descripcion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarTipo", ReplyAction="*")]
        WSNegocio.SRBaseDatos.insertarTipoResponse insertarTipo(WSNegocio.SRBaseDatos.insertarTipoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento archivo del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarFoto", ReplyAction="*")]
        WSNegocio.SRBaseDatos.InsertarFotoResponse InsertarFoto(WSNegocio.SRBaseDatos.InsertarFotoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ConsultaCuerposResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultaCuerpos", ReplyAction="*")]
        WSNegocio.SRBaseDatos.ConsultaCuerposResponse ConsultaCuerpos(WSNegocio.SRBaseDatos.ConsultaCuerposRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento consultarTiposResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultarTipos", ReplyAction="*")]
        WSNegocio.SRBaseDatos.consultarTiposResponse consultarTipos(WSNegocio.SRBaseDatos.consultarTiposRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento InsertarAsociadosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarAsociados", ReplyAction="*")]
        WSNegocio.SRBaseDatos.InsertarAsociadosResponse InsertarAsociados(WSNegocio.SRBaseDatos.InsertarAsociadosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WSNegocio.SRBaseDatos.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WSNegocio.SRBaseDatos.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarCuerpoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarCuerpo", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.InsertarCuerpoRequestBody Body;
        
        public InsertarCuerpoRequest() {
        }
        
        public InsertarCuerpoRequest(WSNegocio.SRBaseDatos.InsertarCuerpoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarCuerpoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string descubridor;
        
        public InsertarCuerpoRequestBody() {
        }
        
        public InsertarCuerpoRequestBody(string nombre, string descubridor) {
            this.nombre = nombre;
            this.descubridor = descubridor;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarCuerpoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarCuerpoResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.InsertarCuerpoResponseBody Body;
        
        public InsertarCuerpoResponse() {
        }
        
        public InsertarCuerpoResponse(WSNegocio.SRBaseDatos.InsertarCuerpoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarCuerpoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertarCuerpoResult;
        
        public InsertarCuerpoResponseBody() {
        }
        
        public InsertarCuerpoResponseBody(int InsertarCuerpoResult) {
            this.InsertarCuerpoResult = InsertarCuerpoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertarTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertarTipo", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.insertarTipoRequestBody Body;
        
        public insertarTipoRequest() {
        }
        
        public insertarTipoRequest(WSNegocio.SRBaseDatos.insertarTipoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertarTipoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string descripcion;
        
        public insertarTipoRequestBody() {
        }
        
        public insertarTipoRequestBody(string descripcion) {
            this.descripcion = descripcion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertarTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertarTipoResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.insertarTipoResponseBody Body;
        
        public insertarTipoResponse() {
        }
        
        public insertarTipoResponse(WSNegocio.SRBaseDatos.insertarTipoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertarTipoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string insertarTipoResult;
        
        public insertarTipoResponseBody() {
        }
        
        public insertarTipoResponseBody(string insertarTipoResult) {
            this.insertarTipoResult = insertarTipoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarFotoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarFoto", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.InsertarFotoRequestBody Body;
        
        public InsertarFotoRequest() {
        }
        
        public InsertarFotoRequest(WSNegocio.SRBaseDatos.InsertarFotoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarFotoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int num;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public byte[] archivo;
        
        public InsertarFotoRequestBody() {
        }
        
        public InsertarFotoRequestBody(int num, byte[] archivo) {
            this.num = num;
            this.archivo = archivo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarFotoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarFotoResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.InsertarFotoResponseBody Body;
        
        public InsertarFotoResponse() {
        }
        
        public InsertarFotoResponse(WSNegocio.SRBaseDatos.InsertarFotoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarFotoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarFotoResult;
        
        public InsertarFotoResponseBody() {
        }
        
        public InsertarFotoResponseBody(string InsertarFotoResult) {
            this.InsertarFotoResult = InsertarFotoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaCuerposRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaCuerpos", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.ConsultaCuerposRequestBody Body;
        
        public ConsultaCuerposRequest() {
        }
        
        public ConsultaCuerposRequest(WSNegocio.SRBaseDatos.ConsultaCuerposRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConsultaCuerposRequestBody {
        
        public ConsultaCuerposRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaCuerposResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaCuerposResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.ConsultaCuerposResponseBody Body;
        
        public ConsultaCuerposResponse() {
        }
        
        public ConsultaCuerposResponse(WSNegocio.SRBaseDatos.ConsultaCuerposResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsultaCuerposResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsultaCuerposResult;
        
        public ConsultaCuerposResponseBody() {
        }
        
        public ConsultaCuerposResponseBody(string ConsultaCuerposResult) {
            this.ConsultaCuerposResult = ConsultaCuerposResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultarTiposRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultarTipos", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.consultarTiposRequestBody Body;
        
        public consultarTiposRequest() {
        }
        
        public consultarTiposRequest(WSNegocio.SRBaseDatos.consultarTiposRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class consultarTiposRequestBody {
        
        public consultarTiposRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultarTiposResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultarTiposResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.consultarTiposResponseBody Body;
        
        public consultarTiposResponse() {
        }
        
        public consultarTiposResponse(WSNegocio.SRBaseDatos.consultarTiposResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class consultarTiposResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string consultarTiposResult;
        
        public consultarTiposResponseBody() {
        }
        
        public consultarTiposResponseBody(string consultarTiposResult) {
            this.consultarTiposResult = consultarTiposResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarAsociadosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarAsociados", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.InsertarAsociadosRequestBody Body;
        
        public InsertarAsociadosRequest() {
        }
        
        public InsertarAsociadosRequest(WSNegocio.SRBaseDatos.InsertarAsociadosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarAsociadosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idCuerpo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int idAsociado;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int idtipo;
        
        public InsertarAsociadosRequestBody() {
        }
        
        public InsertarAsociadosRequestBody(int idCuerpo, int idAsociado, int idtipo) {
            this.idCuerpo = idCuerpo;
            this.idAsociado = idAsociado;
            this.idtipo = idtipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarAsociadosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarAsociadosResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.InsertarAsociadosResponseBody Body;
        
        public InsertarAsociadosResponse() {
        }
        
        public InsertarAsociadosResponse(WSNegocio.SRBaseDatos.InsertarAsociadosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarAsociadosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarAsociadosResult;
        
        public InsertarAsociadosResponseBody() {
        }
        
        public InsertarAsociadosResponseBody(string InsertarAsociadosResult) {
            this.InsertarAsociadosResult = InsertarAsociadosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BaseDatosSoapChannel : WSNegocio.SRBaseDatos.BaseDatosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BaseDatosSoapClient : System.ServiceModel.ClientBase<WSNegocio.SRBaseDatos.BaseDatosSoap>, WSNegocio.SRBaseDatos.BaseDatosSoap {
        
        public BaseDatosSoapClient() {
        }
        
        public BaseDatosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BaseDatosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BaseDatosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BaseDatosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.HelloWorldResponse WSNegocio.SRBaseDatos.BaseDatosSoap.HelloWorld(WSNegocio.SRBaseDatos.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WSNegocio.SRBaseDatos.HelloWorldRequest inValue = new WSNegocio.SRBaseDatos.HelloWorldRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.HelloWorldRequestBody();
            WSNegocio.SRBaseDatos.HelloWorldResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.InsertarCuerpoResponse WSNegocio.SRBaseDatos.BaseDatosSoap.InsertarCuerpo(WSNegocio.SRBaseDatos.InsertarCuerpoRequest request) {
            return base.Channel.InsertarCuerpo(request);
        }
        
        public int InsertarCuerpo(string nombre, string descubridor) {
            WSNegocio.SRBaseDatos.InsertarCuerpoRequest inValue = new WSNegocio.SRBaseDatos.InsertarCuerpoRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.InsertarCuerpoRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.descubridor = descubridor;
            WSNegocio.SRBaseDatos.InsertarCuerpoResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).InsertarCuerpo(inValue);
            return retVal.Body.InsertarCuerpoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.insertarTipoResponse WSNegocio.SRBaseDatos.BaseDatosSoap.insertarTipo(WSNegocio.SRBaseDatos.insertarTipoRequest request) {
            return base.Channel.insertarTipo(request);
        }
        
        public string insertarTipo(string descripcion) {
            WSNegocio.SRBaseDatos.insertarTipoRequest inValue = new WSNegocio.SRBaseDatos.insertarTipoRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.insertarTipoRequestBody();
            inValue.Body.descripcion = descripcion;
            WSNegocio.SRBaseDatos.insertarTipoResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).insertarTipo(inValue);
            return retVal.Body.insertarTipoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.InsertarFotoResponse WSNegocio.SRBaseDatos.BaseDatosSoap.InsertarFoto(WSNegocio.SRBaseDatos.InsertarFotoRequest request) {
            return base.Channel.InsertarFoto(request);
        }
        
        public string InsertarFoto(int num, byte[] archivo) {
            WSNegocio.SRBaseDatos.InsertarFotoRequest inValue = new WSNegocio.SRBaseDatos.InsertarFotoRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.InsertarFotoRequestBody();
            inValue.Body.num = num;
            inValue.Body.archivo = archivo;
            WSNegocio.SRBaseDatos.InsertarFotoResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).InsertarFoto(inValue);
            return retVal.Body.InsertarFotoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.ConsultaCuerposResponse WSNegocio.SRBaseDatos.BaseDatosSoap.ConsultaCuerpos(WSNegocio.SRBaseDatos.ConsultaCuerposRequest request) {
            return base.Channel.ConsultaCuerpos(request);
        }
        
        public string ConsultaCuerpos() {
            WSNegocio.SRBaseDatos.ConsultaCuerposRequest inValue = new WSNegocio.SRBaseDatos.ConsultaCuerposRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.ConsultaCuerposRequestBody();
            WSNegocio.SRBaseDatos.ConsultaCuerposResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).ConsultaCuerpos(inValue);
            return retVal.Body.ConsultaCuerposResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.consultarTiposResponse WSNegocio.SRBaseDatos.BaseDatosSoap.consultarTipos(WSNegocio.SRBaseDatos.consultarTiposRequest request) {
            return base.Channel.consultarTipos(request);
        }
        
        public string consultarTipos() {
            WSNegocio.SRBaseDatos.consultarTiposRequest inValue = new WSNegocio.SRBaseDatos.consultarTiposRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.consultarTiposRequestBody();
            WSNegocio.SRBaseDatos.consultarTiposResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).consultarTipos(inValue);
            return retVal.Body.consultarTiposResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.InsertarAsociadosResponse WSNegocio.SRBaseDatos.BaseDatosSoap.InsertarAsociados(WSNegocio.SRBaseDatos.InsertarAsociadosRequest request) {
            return base.Channel.InsertarAsociados(request);
        }
        
        public string InsertarAsociados(int idCuerpo, int idAsociado, int idtipo) {
            WSNegocio.SRBaseDatos.InsertarAsociadosRequest inValue = new WSNegocio.SRBaseDatos.InsertarAsociadosRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.InsertarAsociadosRequestBody();
            inValue.Body.idCuerpo = idCuerpo;
            inValue.Body.idAsociado = idAsociado;
            inValue.Body.idtipo = idtipo;
            WSNegocio.SRBaseDatos.InsertarAsociadosResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).InsertarAsociados(inValue);
            return retVal.Body.InsertarAsociadosResult;
        }
    }
}
