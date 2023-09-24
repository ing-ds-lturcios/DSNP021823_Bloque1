Module MenuPrincipal
    Sub Main()
        Console.Clear()
        Dim ancho = 60
        Dim opcion As SByte
        imprimirSeparador(ancho)
        Dim saludo As String = "Bienvenido al Proyecto del Bloque 1"

        centrarTexto(saludo, ancho)
        Console.WriteLine(saludo)
        imprimirSeparador(ancho)
        Console.WriteLine("1. Determinar si eres mayor de edad")
        Console.WriteLine("2. Determinar si un número es positivo")
        Console.WriteLine("3. Calcular descuento de una compra")
        Console.WriteLine("4. Calcular suma de números consecutivos")
        Console.WriteLine("5. Desplegar tabla de multiplicar")
        Console.WriteLine("6. Salir del Proyecto Bloque1")
        While (True)
            Dim input As ConsoleKeyInfo = Console.ReadKey(True)
            If input.Key = ConsoleKey.D1 Or input.Key = ConsoleKey.NumPad1 Then
                Console.Clear()
                Ejercicio1.Main()
                Main()
            End If
            If input.Key = ConsoleKey.D2 Or input.Key = ConsoleKey.NumPad2 Then
                Console.Clear()
                Ejercicio2.Main()
                Main()
            End If
            If input.Key = ConsoleKey.D3 Or input.Key = ConsoleKey.NumPad3 Then
                Console.Clear()
                Ejercicio3.Main()
                Main()
            End If
            If input.Key = ConsoleKey.D4 Or input.Key = ConsoleKey.NumPad4 Then
                Console.Clear()
                Ejercicio4.Main()
                Main()
            End If
            If input.Key = ConsoleKey.D5 Or input.Key = ConsoleKey.NumPad5 Then
                Console.Clear()
                Ejercicio5.Main()
                Main()
            End If
            If input.Key = ConsoleKey.D6 Or input.Key = ConsoleKey.NumPad6 Then
                Console.Clear()
                despedida(ancho)
                Exit While
            End If
        End While
        Console.ReadKey(True)
        Environment.Exit(0)
    End Sub

    Sub despedida(ByVal ancho As SByte)
        Dim despedida1 As String = "Gracias por utilizar nuestros productos"
        Dim despedida2 As String = "Esperamos seguir contando con su confianza"
        Dim despedida3 As String = "Presione cualquier tecla para salir"
        centrarTexto(despedida1, ancho)
        centrarTexto(despedida2, ancho)
        centrarTexto(despedida3, ancho)
        imprimirSeparador(ancho)
        Console.WriteLine(despedida1)
        Console.WriteLine(despedida2)
        Console.WriteLine(despedida3)
        imprimirSeparador(ancho)
    End Sub

    Sub imprimirSeparador(ByVal repeticiones As SByte)
        For i = 1 To repeticiones
            Console.Write("*")
        Next
        Console.WriteLine("")
    End Sub

    Sub centrarTexto(ByRef texto As String, ByVal ancho As SByte)
        Dim izq As SByte = (ancho - texto.Length) / 2
        texto = StrDup(izq, " ") + texto + StrDup(ancho - texto.Length - izq, " ")
    End Sub

    Function columnasTexto(ByVal columna1 As String, ByVal columna2 As String, ByVal ancho As SByte) As String
        Dim usado As SByte = columna1.Trim.Length + columna2.Trim.Length
        Return StrDup(5, " ") + columna1.Trim + StrDup((ancho - usado) - 10, " ") + columna2.Trim
    End Function

End Module
