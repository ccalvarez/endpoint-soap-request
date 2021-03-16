Imports System.Net
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Xml

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim endpointConsultas As wsPlaceToPay.WebServiceResTransaccionesClient = New wsPlaceToPay.WebServiceResTransaccionesClient()

        ' Credenciales PlaceToPay TEST:
        endpointConsultas.ClientCredentials.UserName.UserName = "..."
        endpointConsultas.ClientCredentials.UserName.Password = "..."

        ' Credenciales PayGate:
        'endpointConsultas.ClientCredentials.UserName.UserName = "..."
        'endpointConsultas.ClientCredentials.UserName.Password = "..."



        Dim request As wsPlaceToPay.transaccion = Nothing  'request de consulta de la orden al PlaceToPay
        Dim response As wsPlaceToPay.resultadoRespuestaTransacciones = Nothing 'response de consulta de la orden al PlaceToPay


        request = New wsPlaceToPay.transaccion()

        request.x_invoice_num = "3345"
        request.x_amount = "2000"
        request.x_date = "20210308"

        Try
            'response = endpointConsultas.consultaTransacciones(request.x_invoice_num, request.x_amount, request.x_date)


            response = endpointConsultas.consultaTransacciones("3345", "2000", "20210308")


            If IsNothing(response.mensajes) Then  ' cuando la orden fue TRANSACCION DENEGADA o TRANSACCION EXITOSA, mensajes viene vacío

                If Not IsNothing(response.respuestaTransacciones.x_response_reason_text) Then
                    If response.respuestaTransacciones.x_response_reason_text <> String.Empty Then
                        lstResponses.Items.Add(response.respuestaTransacciones.x_response_reason_text)  ' en caso de null igualar a " "
                    Else
                        lstResponses.Items.Add(" ")
                    End If
                Else
                    lstResponses.Items.Add(" ")
                End If

            Else
                For Each msg As wsPlaceToPay.mensaje In response.mensajes
                    lstResponses.Items.Add("Endpoint de consultas ha reportado: tipoMensaje=" & msg.tipoMensaje.ToString() & ", descripcion=" & msg.descripcion & ", codigo=" & msg.codigo & ", key=" & msg.key & ".  Con los parámetros:  x_invoice_num=" & request.x_invoice_num & ", x_amount=" & request.x_amount & ", x_date=" & request.x_date)
                Next

            End If
        Catch ex As Exception
            lstResponses.Items.Add("Ocurrió un error: " & ex.Message & If(Not (IsNothing(ex.InnerException)), ex.InnerException.ToString(), ""))

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim endpointConsultas As New com.placetopay.test.WebServiceResTransaccionesService()

        ' Credenciales PayGate:
        'Dim credentials As ICredentials = New NetworkCredential("...", "...")

        ' Credenciales PlaceToPay:
        Dim credentials As ICredentials = New NetworkCredential("...", "...")


        endpointConsultas.Credentials = credentials




        Dim request As com.placetopay.test.transaccion = Nothing  'request de consulta de la orden al PlaceToPay
        Dim response As com.placetopay.test.resultadoRespuestaTransacciones = Nothing 'response de consulta de la orden al PlaceToPay



        request = New com.placetopay.test.transaccion()

        request.x_invoice_num = "3345"
        request.x_amount = "2000"
        request.x_date = "20210308"

        Try
            'response = endpointConsultas.consultaTransacciones(request.x_invoice_num, request.x_amount, request.x_date)
            response = endpointConsultas.consultaTransacciones("3345", "2000", "20210308")


            If IsNothing(response.mensajes) Then  ' cuando la orden fue TRANSACCION DENEGADA o TRANSACCION EXITOSA, mensajes viene vacío

                If Not IsNothing(response.respuestaTransacciones.x_response_reason_text) Then
                    If response.respuestaTransacciones.x_response_reason_text <> String.Empty Then
                        lstResponses.Items.Add(response.respuestaTransacciones.x_response_reason_text)  ' en caso de null igualar a " "
                    Else
                        lstResponses.Items.Add(" ")
                    End If
                Else
                    lstResponses.Items.Add(" ")
                End If

            Else
                For Each msg As com.placetopay.test.mensaje In response.mensajes
                    lstResponses.Items.Add("Endpoint de consultas ha reportado: tipoMensaje=" & msg.tipoMensaje.ToString() & ", descripcion=" & msg.descripcion & ", codigo=" & msg.codigo & ", key=" & msg.key & ".  Con los parámetros:  x_invoice_num=" & request.x_invoice_num & ", x_amount=" & request.x_amount & ", x_date=" & request.x_date)
                Next

            End If
        Catch ex As Exception
            lstResponses.Items.Add("Ocurrió un error: " & ex.Message & If(Not (IsNothing(ex.InnerException)), ex.InnerException.ToString(), ""))

        End Try

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lstResponses.Items.Clear()
    End Sub
End Class

