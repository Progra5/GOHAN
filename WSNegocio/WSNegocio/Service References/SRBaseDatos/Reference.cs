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
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento datos del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarCuerpo", ReplyAction="*")]
        WSNegocio.SRBaseDatos.InsertarCuerpoResponse InsertarCuerpo(WSNegocio.SRBaseDatos.InsertarCuerpoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento descripcion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarTipo", ReplyAction="*")]
        WSNegocio.SRBaseDatos.insertarTipoResponse insertarTipo(WSNegocio.SRBaseDatos.insertarTipoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ConsultaCuerposResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultaCuerpos", ReplyAction="*")]
        WSNegocio.SRBaseDatos.ConsultaCuerposResponse ConsultaCuerpos(WSNegocio.SRBaseDatos.ConsultaCuerposRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento consultarTiposResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultarTipos", ReplyAction="*")]
        WSNegocio.SRBaseDatos.consultarTiposResponse consultarTipos(WSNegocio.SRBaseDatos.consultarTiposRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento datos del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarAsociados", ReplyAction="*")]
        WSNegocio.SRBaseDatos.InsertarAsociadosResponse InsertarAsociados(WSNegocio.SRBaseDatos.InsertarAsociadosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento consultarTotalCuerposResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultarTotalCuerpos", ReplyAction="*")]
        WSNegocio.SRBaseDatos.consultarTotalCuerposResponse consultarTotalCuerpos(WSNegocio.SRBaseDatos.consultarTotalCuerposRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento consultarAsociadosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultarAsociados", ReplyAction="*")]
        WSNegocio.SRBaseDatos.consultarAsociadosResponse consultarAsociados(WSNegocio.SRBaseDatos.consultarAsociadosRequest request);
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
        public string datos;
        
        public InsertarCuerpoRequestBody() {
        }
        
        public InsertarCuerpoRequestBody(string datos) {
            this.datos = datos;
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarCuerpoResult;
        
        public InsertarCuerpoResponseBody() {
        }
        
        public InsertarCuerpoResponseBody(string InsertarCuerpoResult) {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string datos;
        
        public InsertarAsociadosRequestBody() {
        }
        
        public InsertarAsociadosRequestBody(string datos) {
            this.datos = datos;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultarTotalCuerposRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultarTotalCuerpos", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.consultarTotalCuerposRequestBody Body;
        
        public consultarTotalCuerposRequest() {
        }
        
        public consultarTotalCuerposRequest(WSNegocio.SRBaseDatos.consultarTotalCuerposRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class consultarTotalCuerposRequestBody {
        
        public consultarTotalCuerposRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultarTotalCuerposResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultarTotalCuerposResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.consultarTotalCuerposResponseBody Body;
        
        public consultarTotalCuerposResponse() {
        }
        
        public consultarTotalCuerposResponse(WSNegocio.SRBaseDatos.consultarTotalCuerposResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class consultarTotalCuerposResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string consultarTotalCuerposResult;
        
        public consultarTotalCuerposResponseBody() {
        }
        
        public consultarTotalCuerposResponseBody(string consultarTotalCuerposResult) {
            this.consultarTotalCuerposResult = consultarTotalCuerposResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultarAsociadosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultarAsociados", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.consultarAsociadosRequestBody Body;
        
        public consultarAsociadosRequest() {
        }
        
        public consultarAsociadosRequest(WSNegocio.SRBaseDatos.consultarAsociadosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class consultarAsociadosRequestBody {
        
        public consultarAsociadosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class consultarAsociadosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="consultarAsociadosResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSNegocio.SRBaseDatos.consultarAsociadosResponseBody Body;
        
        public consultarAsociadosResponse() {
        }
        
        public consultarAsociadosResponse(WSNegocio.SRBaseDatos.consultarAsociadosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class consultarAsociadosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string consultarAsociadosResult;
        
        public consultarAsociadosResponseBody() {
        }
        
        public consultarAsociadosResponseBody(string consultarAsociadosResult) {
            this.consultarAsociadosResult = consultarAsociadosResult;
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
        
        public string InsertarCuerpo(string datos) {
            WSNegocio.SRBaseDatos.InsertarCuerpoRequest inValue = new WSNegocio.SRBaseDatos.InsertarCuerpoRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.InsertarCuerpoRequestBody();
            inValue.Body.datos = datos;
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
        
        public string InsertarAsociados(string datos) {
            WSNegocio.SRBaseDatos.InsertarAsociadosRequest inValue = new WSNegocio.SRBaseDatos.InsertarAsociadosRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.InsertarAsociadosRequestBody();
            inValue.Body.datos = datos;
            WSNegocio.SRBaseDatos.InsertarAsociadosResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).InsertarAsociados(inValue);
            return retVal.Body.InsertarAsociadosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.consultarTotalCuerposResponse WSNegocio.SRBaseDatos.BaseDatosSoap.consultarTotalCuerpos(WSNegocio.SRBaseDatos.consultarTotalCuerposRequest request) {
            return base.Channel.consultarTotalCuerpos(request);
        }
        
        public string consultarTotalCuerpos() {
            WSNegocio.SRBaseDatos.consultarTotalCuerposRequest inValue = new WSNegocio.SRBaseDatos.consultarTotalCuerposRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.consultarTotalCuerposRequestBody();
            WSNegocio.SRBaseDatos.consultarTotalCuerposResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).consultarTotalCuerpos(inValue);
            return retVal.Body.consultarTotalCuerposResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSNegocio.SRBaseDatos.consultarAsociadosResponse WSNegocio.SRBaseDatos.BaseDatosSoap.consultarAsociados(WSNegocio.SRBaseDatos.consultarAsociadosRequest request) {
            return base.Channel.consultarAsociados(request);
        }
        
        public string consultarAsociados() {
            WSNegocio.SRBaseDatos.consultarAsociadosRequest inValue = new WSNegocio.SRBaseDatos.consultarAsociadosRequest();
            inValue.Body = new WSNegocio.SRBaseDatos.consultarAsociadosRequestBody();
            WSNegocio.SRBaseDatos.consultarAsociadosResponse retVal = ((WSNegocio.SRBaseDatos.BaseDatosSoap)(this)).consultarAsociados(inValue);
            return retVal.Body.consultarAsociadosResult;
        }
    }
}
