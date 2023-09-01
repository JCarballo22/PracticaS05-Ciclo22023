Module Module1

    Sub Main()
        'FunMate()
        'CondicionalIfElseIfElse()
        'ComprobarNumeros()
        'ComprobarFecha()
        'ComprobarArray()
        'FunMatematica()
        FunRandom()

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
        Dim valor As String
        'Dim valor As Object

        ' valor = "98"  'Console.ReadLine()
        ' valor = Integer.Parse(Console.ReadLine())
        valor = Console.ReadLine()

        Dim valor2 As Object
        Dim verificarNum As Boolean

        ' valor2 = "48.3"
        ' valor2 = "48.3"
        valor2 = "48.3ds"
        verificarNum = IsNumeric(valor2)
        Console.WriteLine(verificarNum)

        'If valor = True Then
        If IsNumeric(valor) Then
            Console.WriteLine("Es un numero")
        Else
            Console.WriteLine("No es un numero")
        End If
    End Sub

    Sub ComprobarFecha()
        Dim fecha1, fecha2 As Date
        Dim soloTiempo, fechaHora, noFecha As String
        Dim numFecha As Integer
        Dim verificarFecha As Boolean

        fecha1 = CDate("Agosto 31, 2023")
        Console.WriteLine(fecha1)
        verificarFecha = IsDate(fecha1)
        Console.WriteLine(verificarFecha)

        fecha2 = "14 / 2 / 2023"
        Console.WriteLine(fecha2)
        verificarFecha = IsDate(fecha2)
        Console.WriteLine(verificarFecha)

        soloTiempo = "5:37 pm"
        Console.WriteLine(soloTiempo)
        verificarFecha = IsDate(soloTiempo)
        Console.WriteLine(verificarFecha)

        fechaHora = "Agosto 31, 2023 5:45 pm"
        Console.WriteLine(fechaHora)
        verificarFecha = IsDate(fechaHora)
        Console.WriteLine(verificarFecha)

        noFecha = "Hola esta lloviendo"
        Console.WriteLine(noFecha)
        verificarFecha = IsDate(noFecha)
        Console.WriteLine(verificarFecha)

        numFecha = 38
        Console.WriteLine(numFecha)
        verificarFecha = IsDate(numFecha)
        Console.WriteLine(verificarFecha)

        Dim fecha As String

        'fecha = Console.ReadLine()
        fecha = DateTime.Now

        Console.WriteLine(fecha)

        If IsDate(fecha) Then
            Console.WriteLine("Es una fecha correcta")
        Else
            Console.WriteLine("No es una fecha correcta")
        End If

    End Sub

    Sub ComprobarArray()
        Dim array1(2), array2(3) As Integer
        Dim varTexto As String = "Texto"
        Dim verificarArray As Boolean

        verificarArray = IsArray(array1)
        Console.WriteLine(verificarArray)
        verificarArray = IsArray(array2)
        Console.WriteLine(verificarArray)
        verificarArray = IsArray(varTexto)
        Console.WriteLine(verificarArray)


    End Sub

    Sub FunMatematica()
        Dim myNumeroInt As Integer
        myNumeroInt = Int(78.8)
        Console.WriteLine(myNumeroInt)
        myNumeroInt = Int(-78.8)
        Console.WriteLine(myNumeroInt)
        myNumeroInt = Int(-78.2)
        Console.WriteLine(myNumeroInt)

        Dim myNumeroFix As Integer
        myNumeroFix = Fix(4.7)
        Console.WriteLine(myNumeroFix)
        myNumeroFix = Fix(-4.7)
        Console.WriteLine(myNumeroFix)
        myNumeroFix = Fix(-4.1)
        Console.WriteLine(myNumeroFix)

        Dim myNumero As Integer
        myNumero = CInt(69.9)
        Console.WriteLine(myNumero)
        myNumero = CInt(-69.9)
        Console.WriteLine(myNumero)
        myNumero = CInt(-69.3)
        Console.WriteLine(myNumero)



    End Sub

    Sub FunRandom()
        'Dim miNumRandom As Integer
        Dim miNumRandom, valorRandom As Double
        Dim limiteSuperior As Integer

        Randomize()
        limiteSuperior = 6
        'valorRandom = Rnd()

        miNumRandom = Rnd()
        'miNumRandom = valorRandom
        Console.WriteLine(miNumRandom)

        miNumRandom = Rnd() * limiteSuperior
        'miNumRandom = valorRandom * limiteSuperior
        Console.WriteLine(miNumRandom)

        miNumRandom = Math.Ceiling(Rnd() * limiteSuperior)
        'miNumRandom = Math.Ceiling(valorRandom * limiteSuperior)
        Console.WriteLine(miNumRandom)

        miNumRandom = Math.Floor(Rnd() * limiteSuperior)
        'miNumRandom = Math.Floor(valorRandom * limiteSuperior)
        Console.WriteLine(miNumRandom)

        miNumRandom = Math.Round(Rnd() * limiteSuperior)
        'miNumRandom = Math.Round(valorRandom * limiteSuperior)
        Console.WriteLine(miNumRandom)

    End Sub

End Module
