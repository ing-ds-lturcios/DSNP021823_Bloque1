Module Ejercicio4
    Sub Main()
        Dim numero, suma As Int32
        Dim impresion As String = ""
        MenuPrincipal.imprimirSeparador(60)
        Console.WriteLine("Sumar números consecutivos desde el 1")
        Console.Write("Por favor, ingrese un número: ")
        Dim input = Console.ReadLine
        If Int32.TryParse(input, numero) Then
            MenuPrincipal.imprimirSeparador(60)
            For i = 1 To numero
                suma += i
                If i < numero Then
                    impresion += i.ToString + " + "
                Else
                    impresion += i.ToString + " = " + suma.ToString
                End If
            Next
            Console.WriteLine(impresion)
            Console.WriteLine("La suma de los numeros naturales del 1 al " + numero.ToString + " es igual a " + suma.ToString)
        Else
            Console.WriteLine("El valor que ingresó no es un número, lo siento.")
        End If
        Console.WriteLine("")
        MenuPrincipal.imprimirSeparador(60)
        Console.WriteLine("Puedes presionar cualquier tecla para salir.")
        Console.ReadKey(True)

    End Sub
End Module
