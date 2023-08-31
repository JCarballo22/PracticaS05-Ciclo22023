Module Module1

    Sub Main()
        'FunMate()
        'CondicionalIfElseIfElse()
        ComprobarNumeros()
        Console.Read()
    End Sub

    Sub FunMate()
        Console.WriteLine("Esta es la funcion Math.PI " & Math.PI)
        Console.WriteLine("Este es la funcion Math.E " & Math.E)
        Console.WriteLine("Este es la funcion Math.Min(5.9,5.4) " & Math.Min(5.9, 5.4))
        Console.WriteLine("Este es la funcion Math.Max(5.9,5.4) " & Math.Max(5.9, 5.4))
        Console.WriteLine("Esta es la funcion Math.Round(7.5) " & Math.Round(7.5))
        Console.WriteLine("Esta es la funcion Math.Round(-7.5) " & Math.Round(-7.5))
        Console.WriteLine("Esta es la funcion Math.celing(6.2) " & Math.Ceiling(6.2))
        Console.WriteLine("Esta es la funcion Math.celing(-6.2) " & Math.Ceiling(-6.2))
        Console.WriteLine("Esta es la funcion Math.Floor(4.7) " & Math.Floor(4.7))
        Console.WriteLine("Esta es la funcion Math.Floor(-4.7) " & Math.Floor(-4.7))
        Console.WriteLine("Esta es la funcion Math.Truncate(9.3) " & Math.Truncate(9.3))
        Console.WriteLine("Esta es la funcion Math.Truncate(-9.3) " & Math.Truncate(-9.3))
        Console.WriteLine("Esta es la funcion Math.Abs(-6.6) " & Math.Abs(-6.6))
        Console.WriteLine("Esta es la funcion Math.Abs(6.6) " & Math.Abs(6.6))
        Console.WriteLine("Esta es la funcion Math.Sign(-8.4) " & Math.Sign(-8.4))
        Console.WriteLine("Esta es la funcion Math.Sign(8.4) " & Math.Sign(8.4))
        Console.WriteLine("Esta es la funcion Math.Pow " & Math.Pow(3, 3))
        Console.WriteLine("Esta es la funcion Math.Sqrt " & Math.Sqrt(25))

    End Sub

    Sub CondicionalIfElseIfElse()
        Console.WriteLine("Estudiante, por favor, Ingresa tu nota debe ser entre 0 y 10")
        Dim calificacion = Double.Parse(Console.ReadLine())
        Dim calRedondeada = Convert.ToInt32(Math.Round(calificacion))
        If (calRedondeada >= 0) AndAlso (calRedondeada < 6) Then
            Console.WriteLine("El alumno no paso la materia de Progamación II")
        ElseIf calRedondeada >= 6 AndAlso calRedondeada <= 9 Then
            Console.WriteLine("El alumno si paso la materia de Progamación II")
        ElseIf calRedondeada = 10 Then
            Console.WriteLine("El alumno paso la materia de Progamación II con una nota perfecta")
        Else
            Console.WriteLine("No ingreso una nota entre 0 y 10")
        End If

    End Sub

    Sub ComprobarNumeros()
        'Dim valor As String
        Dim valor As Object

        ' valor = "98"  'Console.ReadLine()
        ' valor = Integer.Parse(Console.ReadLine())
        valor = Console.ReadLine()

        If IsNumeric(valor) Then
            Console.WriteLine("Es un numero")
        Else
            Console.WriteLine("No es un numero")
        End If
    End Sub

End Module
