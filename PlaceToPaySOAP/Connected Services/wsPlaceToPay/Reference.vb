﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace wsPlaceToPay
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones", ConfigurationName:="wsPlaceToPay.WebServiceResTransacciones")>  _
    Public Interface WebServiceResTransacciones
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults:=true)>  _
        Function consultaTransacciones(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> wsPlaceToPay.resultadoRespuestaTransacciones
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function consultaTransaccionesAsync(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> System.Threading.Tasks.Task(Of wsPlaceToPay.resultadoRespuestaTransacciones)
    End Interface
    
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
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property respuestaTransacciones() As transaccion
            Get
                Return Me.respuestaTransaccionesField
            End Get
            Set
                Me.respuestaTransaccionesField = value
                Me.RaisePropertyChanged("respuestaTransacciones")
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
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
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
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property x_MD5_hash() As String
            Get
                Return Me.x_MD5_hashField
            End Get
            Set
                Me.x_MD5_hashField = value
                Me.RaisePropertyChanged("x_MD5_hash")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property x_amount() As String
            Get
                Return Me.x_amountField
            End Get
            Set
                Me.x_amountField = value
                Me.RaisePropertyChanged("x_amount")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property x_auth_code() As String
            Get
                Return Me.x_auth_codeField
            End Get
            Set
                Me.x_auth_codeField = value
                Me.RaisePropertyChanged("x_auth_code")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property x_date() As String
            Get
                Return Me.x_dateField
            End Get
            Set
                Me.x_dateField = value
                Me.RaisePropertyChanged("x_date")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property x_invoice_num() As String
            Get
                Return Me.x_invoice_numField
            End Get
            Set
                Me.x_invoice_numField = value
                Me.RaisePropertyChanged("x_invoice_num")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property x_iso_error_code() As String
            Get
                Return Me.x_iso_error_codeField
            End Get
            Set
                Me.x_iso_error_codeField = value
                Me.RaisePropertyChanged("x_iso_error_code")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property x_iso_error_description() As String
            Get
                Return Me.x_iso_error_descriptionField
            End Get
            Set
                Me.x_iso_error_descriptionField = value
                Me.RaisePropertyChanged("x_iso_error_description")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>  _
        Public Property x_login() As String
            Get
                Return Me.x_loginField
            End Get
            Set
                Me.x_loginField = value
                Me.RaisePropertyChanged("x_login")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>  _
        Public Property x_response_code() As String
            Get
                Return Me.x_response_codeField
            End Get
            Set
                Me.x_response_codeField = value
                Me.RaisePropertyChanged("x_response_code")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>  _
        Public Property x_response_reason_code() As String
            Get
                Return Me.x_response_reason_codeField
            End Get
            Set
                Me.x_response_reason_codeField = value
                Me.RaisePropertyChanged("x_response_reason_code")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=10)>  _
        Public Property x_response_reason_text() As String
            Get
                Return Me.x_response_reason_textField
            End Get
            Set
                Me.x_response_reason_textField = value
                Me.RaisePropertyChanged("x_response_reason_text")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=11)>  _
        Public Property x_trans_id() As String
            Get
                Return Me.x_trans_idField
            End Get
            Set
                Me.x_trans_idField = value
                Me.RaisePropertyChanged("x_trans_id")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=12)>  _
        Public Property x_type() As String
            Get
                Return Me.x_typeField
            End Get
            Set
                Me.x_typeField = value
                Me.RaisePropertyChanged("x_type")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(resultadoRespuestaTransacciones)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class resultado
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private mensajesField() As mensaje
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("mensajes", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property mensajes() As mensaje()
            Get
                Return Me.mensajesField
            End Get
            Set
                Me.mensajesField = value
                Me.RaisePropertyChanged("mensajes")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.athservices.net/servicios/WebServiceResTransacciones")>  _
    Partial Public Class mensaje
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private keyField As String
        
        Private codigoField As Integer
        
        Private descripcionField As String
        
        Private tipoMensajeField As tipoMensaje
        
        Private tipoMensajeFieldSpecified As Boolean
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property key() As String
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
                Me.RaisePropertyChanged("key")
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
                Me.RaisePropertyChanged("codigo")
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
                Me.RaisePropertyChanged("descripcion")
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
                Me.RaisePropertyChanged("tipoMensaje")
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
                Me.RaisePropertyChanged("tipoMensajeSpecified")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
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
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebServiceResTransaccionesChannel
        Inherits wsPlaceToPay.WebServiceResTransacciones, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebServiceResTransaccionesClient
        Inherits System.ServiceModel.ClientBase(Of wsPlaceToPay.WebServiceResTransacciones)
        Implements wsPlaceToPay.WebServiceResTransacciones
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function consultaTransacciones(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String) As wsPlaceToPay.resultadoRespuestaTransacciones Implements wsPlaceToPay.WebServiceResTransacciones.consultaTransacciones
            Return MyBase.Channel.consultaTransacciones(x_sequence, x_amount, x_date)
        End Function
        
        Public Function consultaTransaccionesAsync(ByVal x_sequence As String, ByVal x_amount As String, ByVal x_date As String) As System.Threading.Tasks.Task(Of wsPlaceToPay.resultadoRespuestaTransacciones) Implements wsPlaceToPay.WebServiceResTransacciones.consultaTransaccionesAsync
            Return MyBase.Channel.consultaTransaccionesAsync(x_sequence, x_amount, x_date)
        End Function
    End Class
End Namespace
