Module Module1

    Sub Main()
        Dim mass() As Double = New Double(3) {}
        Dim count As Integer = 0
        Dim sum As Double = 0

        For i As Integer = 0 To 3
            Console.WriteLine("Введите эелемент массива")
            mass(i) = CDbl(Console.ReadLine())
        Next

        For i As Integer = 0 To 3
            If ((mass(i) > -0.5) And (mass(i) < 8.0)) Then
                count = count + 1 And sum = sum + mass(i)
            End If
        Next

        Console.Write("Среднее арифметическое: ")
        Console.Write(sum / count)

        Console.Read()


    End Sub

End Module
