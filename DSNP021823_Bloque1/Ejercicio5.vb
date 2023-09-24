Module Ejercicio5
    Sub Main()
        Dim ancho As SByte = 60
        Dim numero As SByte
        Dim mensaje As String = "Asistente generador de Tabla de Multiplicación"
        MenuPrincipal.centrarTexto(mensaje, ancho)
        MenuPrincipal.imprimirSeparador(ancho)
        Console.WriteLine(mensaje)
        MenuPrincipal.imprimirSeparador(ancho)
        Console.Write("Necesito que ingrese un número: ")
        Dim input = Console.ReadLine
        If SByte.TryParse(input, numero) Then
            Dim espacio As String
            For i = 1 To 10
                If i < 10 Then
                    espacio = " "
                Else
                    espacio = ""
                End If
                Console.WriteLine(StrDup(5, " ") + numero.ToString + " x " + espacio + i.ToString + " = " + (numero * i).ToString)
            Next
        Else
            Console.WriteLine("El valor que ingresó no es un número, no puedo generar la tabla!")
        End If
        MenuPrincipal.imprimirSeparador(ancho)
        Console.WriteLine("")
        Console.WriteLine("Puedes presionar cualquier tecla para salir.")
        Console.ReadKey(True)

    End Sub
End Module
