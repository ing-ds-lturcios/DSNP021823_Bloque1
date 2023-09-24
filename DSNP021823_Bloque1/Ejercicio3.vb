Module Ejercicio3
    Sub Main()
        Dim expresaProducto As String = "Cantidad de productos facturados "
        Dim expresaTotal As String = "El monto total de su compra es "
        Dim expresaDescuento1 As String = "Descuento aplicado por su compra "
        Dim expresaPagar As String = "El valor total a pagar es "
        Dim ancho As SByte = 60
        Dim compra, total, porcentaje, descuento As Decimal
        Dim productos As SByte = 0
        Dim presenta1 As String = "Bienvenido/a al Sistema de Ventas LTDSNP"
        MenuPrincipal.centrarTexto(presenta1, ancho)
        Dim presenta2 As String = "Necesitas ingresar el valor de los productos"
        MenuPrincipal.centrarTexto(presenta2, ancho)
        Dim presenta3 As String = "Para finalizar ingresa como 0 (cero) como valor"
        MenuPrincipal.centrarTexto(presenta3, ancho)


        MenuPrincipal.imprimirSeparador(ancho)
        Console.WriteLine(presenta1)
        Console.WriteLine(presenta2)
        Console.WriteLine(presenta3)
        MenuPrincipal.imprimirSeparador(ancho)

        While (True)
            productos += 1
            Console.Write("Ingrese el valor total del producto (" + productos.ToString + ") $ ")
            Dim input = Console.ReadLine()
            If Decimal.TryParse(input, compra) Then
                If compra = 0 Then
                    productos -= 1
                    Exit While
                Else
                    total += compra
                End If
            Else
                Console.WriteLine("Lo siento, es necesario que ingrese un valor numérico")
                productos -= 1
            End If
        End While


        Select Case total
            Case >= 1000
                porcentaje = 0.3
            Case >= 500
                porcentaje = 0.2
            Case >= 250
                porcentaje = 0.1
            Case Else
                porcentaje = 0.05
        End Select
        descuento = total * porcentaje

        MenuPrincipal.imprimirSeparador(60)
        Console.WriteLine(MenuPrincipal.columnasTexto(expresaProducto, productos.ToString(), ancho))
        Console.WriteLine(MenuPrincipal.columnasTexto(expresaTotal, total.ToString("C"), ancho))
        Console.WriteLine(MenuPrincipal.columnasTexto(expresaDescuento1 + (porcentaje * 100).ToString() + "%", descuento.ToString("C"), ancho))
        Console.WriteLine(MenuPrincipal.columnasTexto(expresaPagar, (total - descuento).ToString("C"), ancho))
        Console.WriteLine("")
        Console.WriteLine("¡Gracias por tu compra! Presiona cualquier tecla para salir")
        Console.ReadKey(True)
    End Sub
End Module
