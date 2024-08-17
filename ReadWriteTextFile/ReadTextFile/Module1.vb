Module Module1
    Dim filePath As String = Nothing
    Dim textContent As String = Nothing
    Public Sub Main(args As String())
        ' Komut satırından geçilen dosya yolunu alın
        If args.Length <> 2 Then
            Console.WriteLine("Dosya yolu parametresi gereklidir!")
            Return
        End If
        filePath = args(0)
        textContent = args(1)
        ' ReadFile()
        WriteFile()
    End Sub
    Sub ReadFile()
        ' Dosyayı okuyup konsola yazdırın
        If System.IO.File.Exists(filePath) Then
            Dim fileContents As String = System.IO.File.ReadAllText(filePath)
            Console.WriteLine(fileContents)
            MsgBox(fileContents)
        Else
            Console.WriteLine("Dosya bulunamadı!")
            MsgBox("File not found!")
        End If
    End Sub
    Sub WriteFile()
        If String.IsNullOrEmpty(filePath) OrElse String.IsNullOrEmpty(textContent) Then
            Throw New ArgumentException("Geçersiz parametreler!")
        End If
        System.IO.File.WriteAllText(filePath, textContent)
    End Sub

End Module
