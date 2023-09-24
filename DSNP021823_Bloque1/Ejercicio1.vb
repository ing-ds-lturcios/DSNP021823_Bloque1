Module Ejercicio1

    Sub Main()
        Dim nombre As String
        Dim edad As Int16
        Console.Write("Bienvenido/a ¿Podrías decirme tu nombre? ")
        nombre = Console.ReadLine()
        PedirEdad(edad)
        If edad < 0 Then
            Console.WriteLine(nombre.Trim + ", parece que te has equivocado.")
            Console.WriteLine("Ya que no puedes tener " + edad.ToString() + " años.")
        ElseIf edad < 3 Then
            Console.WriteLine("Wow! " + nombre.Trim + ", me sorprende que estés usando una computadora.")
            Console.WriteLine("Lo digo porque apenas eres un(a) bebé, bien por tí ;)")
        ElseIf edad < 12 Then
            Console.WriteLine(nombre.Trim + ", déjame decirte que estás en una etapa muy bonita.")
            Console.WriteLine("Estás en tu infancia así que diviértete mucho, es  tu oportunidad.")
        ElseIf edad < 18 Then
            Console.WriteLine(nombre.Trim + ", ¡Ay la adolescencia! una período de cambios en todo ámbito")
            Console.WriteLine("Puedes divertirte sanamente, cuida tus pasos, la vida apenas empieza...")
        ElseIf edad < 66 Then
            Console.WriteLine(nombre.Trim + ", eres mayor de edad, persona adulta, no puedes equivocarte")
            Console.WriteLine("Recuerda que un gran poder conlleva una gran responsabilidad.")
        ElseIf edad < 81 Then
            Console.WriteLine(nombre.Trim + ", déjame decirte que ya eres un adulto bastante mayor.")
            Console.WriteLine("Espero que hayas disfrutado tu vida a plenitud, sigue cuidando tu salud.")
        Else
            Console.WriteLine(nombre + ", no sé como le haces para seguir frente a la computadora.")
            Console.WriteLine("Deberías estar descansando, has tenido una larga vida :)")
        End If

        Console.WriteLine("")
        Console.WriteLine("Ha sido un gusto, espero que vuelvas pronto por acá...")
        Console.WriteLine("Presiona cualquier tecla para regresar al menú principal")
        Console.ReadKey(True)

    End Sub

    Sub PedirEdad(ByRef edad As Int16)
        Console.Write("Me gustaría saber tu edad ¿Cuantos años tienes? ")
        Dim input = Console.ReadLine()
        If Int16.TryParse(input, edad) Then
            Return
        Else
            Console.WriteLine("Esperaba conocer tu edad; pero no ingresaste el valor correspondiente")
        End If
    End Sub

End Module
