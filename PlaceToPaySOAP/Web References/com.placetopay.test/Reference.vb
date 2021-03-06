'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace com.placetopay.test
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WebServiceResTransaccionesBinding", [Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class WebServiceResTransaccionesService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private consultaTransaccionesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.PlaceToPaySOAP.My.MySettings.Default.PlaceToPaySOAP_com_placetopay_test_WebServiceResTransaccionesService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event consultaTransaccionesCompleted As consultaTransaccionesCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://www.athservices.net/servicios/WebServiceResTransacciones", ResponseNamespace:="http://www.athservices.net/servicios/WebServiceResTransacciones", Use:=System.Web.Services.Description.SoapBindingUse.Literal)>  _
        Public Function consultaTransacciones(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String) As <System.Xml.Serialization.XmlElementAttribute("return")> resultadoRespuestaTransacciones
            Dim results() As Object = Me.Invoke("consultaTransacciones", New Object() {x_sequence, x_amount, x_date})
            Return CType(results(0),resultadoRespuestaTransacciones)
        End Function
        
        '''<remarks/>
        Public Overloads Sub consultaTransaccionesAsync(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String)
            Me.consultaTransaccionesAsync(x_sequence, x_amount, x_date, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub consultaTransaccionesAsync(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String, ByVal userState As Object)
            If (Me.consultaTransaccionesOperationCompleted Is Nothing) Then
                Me.consultaTransaccionesOperationCompleted = AddressOf Me.OnconsultaTransaccionesOperationCompleted
            End If
            Me.InvokeAsync("consultaTransacciones", New Object() {x_sequence, x_amount, x_date}, Me.consultaTransaccionesOperationCompleted, userState)
        End Sub
        
        Private Sub OnconsultaTransaccionesOperationCompleted(ByVal arg As Object)
            If (Not (Me.consultaTransaccionesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent consultaTransaccionesCompleted(Me, New consultaTransaccionesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class resultadoRespuestaTransacciones
        Inherits resultado
        
        Private respuestaTransaccionesField As transaccion
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property respuestaTransacciones() As transaccion
            Get
                Return Me.respuestaTransaccionesField
            End Get
            Set
                Me.respuestaTransaccionesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class transaccion
        
        Private x_MD5_hashField As String
        
        Private x_amountField As String
        
        Private x_auth_codeField As String
        
        Private x_dateField As String
        
        Private x_invoice_numField As String
        
        Private x_iso_error_codeField As String
        
        Private x_iso_error_descriptionField As String
        
        Private x_loginField As String
        
        Private x_response_codeField As String
        
        Private x_response_reason_codeField As String
        
        Private x_response_reason_textField As String
        
        Private x_trans_idField As String
        
        Private x_typeField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_MD5_hash() As String
            Get
                Return Me.x_MD5_hashField
            End Get
            Set
                Me.x_MD5_hashField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_amount() As String
            Get
                Return Me.x_amountField
            End Get
            Set
                Me.x_amountField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_auth_code() As String
            Get
                Return Me.x_auth_codeField
            End Get
            Set
                Me.x_auth_codeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_date() As String
            Get
                Return Me.x_dateField
            End Get
            Set
                Me.x_dateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_invoice_num() As String
            Get
                Return Me.x_invoice_numField
            End Get
            Set
                Me.x_invoice_numField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_iso_error_code() As String
            Get
                Return Me.x_iso_error_codeField
            End Get
            Set
                Me.x_iso_error_codeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_iso_error_description() As String
            Get
                Return Me.x_iso_error_descriptionField
            End Get
            Set
                Me.x_iso_error_descriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_login() As String
            Get
                Return Me.x_loginField
            End Get
            Set
                Me.x_loginField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_response_code() As String
            Get
                Return Me.x_response_codeField
            End Get
            Set
                Me.x_response_codeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_response_reason_code() As String
            Get
                Return Me.x_response_reason_codeField
            End Get
            Set
                Me.x_response_reason_codeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_response_reason_text() As String
            Get
                Return Me.x_response_reason_textField
            End Get
            Set
                Me.x_response_reason_textField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_trans_id() As String
            Get
                Return Me.x_trans_idField
            End Get
            Set
                Me.x_trans_idField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property x_type() As String
            Get
                Return Me.x_typeField
            End Get
            Set
                Me.x_typeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(resultadoRespuestaTransacciones)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class resultado
        
        Private mensajesField() As mensaje
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("mensajes", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property mensajes() As mensaje()
            Get
                Return Me.mensajesField
            End Get
            Set
                Me.mensajesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class mensaje
        
        Private keyField As String
        
        Private codigoField As Integer
        
        Private descripcionField As String
        
        Private tipoMensajeField As tipoMensaje
        
        Private tipoMensajeFieldSpecified As Boolean
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property key() As String
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property codigo() As Integer
            Get
                Return Me.codigoField
            End Get
            Set
                Me.codigoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property descripcion() As String
            Get
                Return Me.descripcionField
            End Get
            Set
                Me.descripcionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property tipoMensaje() As tipoMensaje
            Get
                Return Me.tipoMensajeField
            End Get
            Set
                Me.tipoMensajeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property tipoMensajeSpecified() As Boolean
            Get
                Return Me.tipoMensajeFieldSpecified
            End Get
            Set
                Me.tipoMensajeFieldSpecified = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Public Enum tipoMensaje
        
        '''<remarks/>
        [ERROR]
        
        '''<remarks/>
        INFORMACION
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")>  _
    Public Delegate Sub consultaTransaccionesCompletedEventHandler(ByVal sender As Object, ByVal e As consultaTransaccionesCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class consultaTransaccionesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As resultadoRespuestaTransacciones
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),resultadoRespuestaTransacciones)
            End Get
        End Property
    End Class
End Namespace
