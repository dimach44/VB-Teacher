Imports System.CodeDom.Compiler
Imports System.Net.Mime.MediaTypeNames

Module Module1

    Sub Main()

        Console.WriteLine("----------------------------")
        Console.WriteLine("(C) Christopher Gorsky 2015")
        Console.WriteLine("----------------------------")

        Dim progName As String = "VBProg.exe"
        Dim appPath As String

        Dim codeProvider As New VBCodeProvider()
        Dim icc As ICodeCompiler = codeProvider.CreateCompiler

        Dim parameters As New CompilerParameters()
        Dim results As CompilerResults

        Dim clArgs() As String = Environment.GetCommandLineArgs()
        Dim strSrc As String = String.Empty

        If clArgs.Count >= 2 Then

            If clArgs(1).CompareTo("-r") = 0 Then
                Try
                    appPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) & "\" & clArgs(2)
                    Console.WriteLine("Compiling: '" & appPath & "'")
                    strSrc = My.Computer.FileSystem.ReadAllText(appPath)
                Catch ex As Exception
                    Console.WriteLine(ex.ToString)
                End Try

            End If
        Else
            Console.WriteLine("Ivalid number of arguments")
        End If

        parameters.GenerateExecutable = True
        parameters.OutputAssembly = progName
        results = icc.CompileAssemblyFromSource(parameters, strSrc)

        If results.Errors.Count > 0 Then
            'There were compiler errors
            Dim CompErr As CompilerError
            Dim strError As String = String.Empty

            For Each CompErr In results.Errors
                strError = "" & "Line number " & CompErr.Line & ", " & CompErr.ErrorText & ";" & Environment.NewLine & Environment.NewLine
                Console.WriteLine(strError)
            Next
        Else
            Console.WriteLine("Success!")
            Process.Start(progName)
            Environment.Exit(0)
        End If

        Console.ReadLine()
    End Sub

End Module
