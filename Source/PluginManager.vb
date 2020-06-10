Imports AI_Contracts

Module PluginManager
#Region "Plugins"
    Public PLUGIN_FOLDER As String = Application.StartupPath & "\Plugins"

    ''' <summary>
    ''' Scans and Loads Plugins
    ''' </summary>
    Public Function ScanPlugins() As ICollection(Of IPlugin)
        Return GET_PLUGINS(PLUGIN_FOLDER)
    End Function
    ''' <summary>
    ''' Resets the plugin folder and reloads plugins found
    ''' </summary>
    ''' <param name="Path"></param>
    Public Sub SET_PLUGIN_FOLDER(ByRef Path As String)
        PLUGIN_FOLDER = Path
        ScanPlugins()
    End Sub
    ''' <summary>
    ''' This populates the Plugins Responses Variable with all the responses and Plugins names
    ''' </summary>
    ''' <param name="_userInput"></param>
    ''' <remarks></remarks>
    Public Function ExecutePlugins(ByVal _userInput As String, ByRef Plugins As ICollection(Of IPlugin)) As String
        Dim Str As String = ""

        'Plugins
        If Plugins IsNot Nothing Then
            For Each NewPlugin In Plugins
                NewPlugin.GetResponse(_userInput)
                If IsNotTest(NewPlugin.Response) = True Then
                    If NewPlugin.Response <> "" Or NewPlugin.Response <> " " Then
                        Str &= LCase(RTrim(LTrim(Str)) & NewPlugin.Response)
                    End If
                Else
                End If
            Next
        End If

        Return Str
    End Function
    Private Function IsNotTest(ByVal _Response As String) As Boolean
        If LCase(_Response).Contains(LCase("plugintest")) = False Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Loads the plugins into the class
    ''' </summary>
    ''' <param name="path">Pathname directory which contains files of type</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GET_PLUGINS(path As String) As ICollection(Of IPlugin)
        On Error Resume Next
        Dim dllFileNames As String()
        If IO.Directory.Exists(path) Then
            dllFileNames = IO.Directory.GetFiles(path, "*.dll")
            Dim assemblies As ICollection(Of Reflection.Assembly) = New List(Of Reflection.Assembly)(dllFileNames.Length)
            For Each dllFile As String In dllFileNames
                Dim an As Reflection.AssemblyName = Reflection.AssemblyName.GetAssemblyName(dllFile)
                Dim assembly As Reflection.Assembly = Reflection.Assembly.Load(an)
                assemblies.Add(assembly)
            Next
            Dim pluginType As Type = GetType(IPlugin)
            Dim pluginTypes As ICollection(Of Type) = New List(Of Type)
            For Each assembly As Reflection.Assembly In assemblies
                If assembly <> Nothing Then
                    Dim types As Type() = assembly.GetTypes()
                    For Each type As Type In types
                        If type.IsInterface Or type.IsAbstract Then
                            Continue For
                        Else
                            If type.GetInterface(pluginType.FullName) <> Nothing Then
                                pluginTypes.Add(type)
                            End If
                        End If
                    Next
                End If
            Next
            Dim plugins As ICollection(Of IPlugin) = New List(Of IPlugin)(pluginTypes.Count)
            For Each type As Type In pluginTypes
                Dim plugin As IPlugin = Activator.CreateInstance(type)
                plugins.Add(plugin)
            Next
            Return plugins
        End If
        Return Nothing
    End Function
#End Region
End Module
