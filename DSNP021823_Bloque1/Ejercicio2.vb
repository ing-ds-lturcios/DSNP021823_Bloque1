Module Ejercicio2
    Sub Main()
        Dim numero As Integer
        Console.WriteLine("Bienvenido/a, necesitaré que ingreses un número a continuación.")
        Console.WriteLine("Soy una IA preparada para evaluar e indicarte si es positivo.")
        Console.Write("Por favor, escribe un número: ")
        Dim input = Console.ReadLine()
        If Int32.TryParse(input, numero) Then
            numero = Convert.ToInt32(input)
            Console.WriteLine("Estoy evaluando tu número, en breve te daré mi respuesta...")
            Threading.Thread.Sleep(1000)
            Console.WriteLine("Puedo asegurarte que el número " + numero.ToString + If(numero < 0, " es Negativo", " es Positivo"))
        Else
            Console.WriteLine("Lo siento, mi algoritmo no logra identificar como número lo que ingresaste")
        End If
        Console.WriteLine("")
        Console.WriteLine("Presiona cualquier tecla y regresarás al menú principal")
        Console.ReadKey(True)
    End Sub
End Module
