Imports System

Module Module1

    Sub Main()
        Dim AData(10) As Integer
        Dim Rnd As New Random()
        Dim nArrayLen = AData.Length
        Dim nMediane = 0
        Dim nModes = New List(Of Integer)()
        '----------------------------------------------------------------------------------------------------
        nModes.Clear()
        Console.WriteLine("Generating Statictic Data:")
        For i = 0 To nArrayLen - 1
            AData(i) = Rnd.Next(40)
            Console.Write("{0} ", AData(i))
        Next
        Array.Sort(AData)
        Console.WriteLine()
        Console.WriteLine("Sorted Data:")
        For i = 0 To nArrayLen - 1
            Console.Write("{0} ", AData(i))
        Next
        '----------------------------------------------------------------------------------------------------
        If (nArrayLen Mod 2 = 0) Then
            Dim nIndex1 = nArrayLen / 2 - 1
            Dim nIndex2 = nIndex1 + 1
            nMediane = Convert.ToInt32((AData(nIndex1) + AData(nIndex2)) / 2)
        Else
            Dim nIndex = Convert.ToInt32((nArrayLen + 1) / 2) - 1
            nMediane = AData(nIndex)
        End If
        '----------------------------------------------------------------------------------------------------
        For i = 0 To nArrayLen - 1
            Dim nSameElems = 0
            For j = 0 To nArrayLen - 1
                If (AData(i) = AData(j)) Then
                    nSameElems += 1
                End If
            Next
            If (nSameElems > 1) Then
                nModes.Add(AData(i))
            End If
        Next
        '----------------------------------------------------------------------------------------------------
        Console.WriteLine()
        Console.WriteLine("Statistic Charectiristics:")
        Console.WriteLine("Count:{0}", nArrayLen)
        Console.WriteLine("Minimum:{0}", AData.Min())
        Console.WriteLine("Maximum:{0}", AData.Max())
        Console.WriteLine("Amplitude:{0}", AData.Max() - AData.Min())
        Console.WriteLine("Average Value:{0}", AData.Average())
        Console.WriteLine("Mediane:{0}", nMediane)
        If (nModes.Count > 0) Then
            Dim nModesCount = nModes.Count
            Console.Write("Mode:")
            For i = 0 To nModesCount - 1
                Console.Write("{0} ", nModes(i))
            Next
            Console.WriteLine()
        End If
    End Sub

End Module
