Imports AI_Contracts

Public Class Sample_Plugin_Chatbot_Tutorial
    Implements AI_Contracts.IPlugin

    Public ReadOnly Property Info As String Implements IPlugin.Info
        Get
            Return "Test Plug-in for Chatbot Tutorial 2000"
        End Get
    End Property

    Public ReadOnly Property PluginName As String Implements IPlugin.PluginName
        Get
            Return "Test Plug-In"
        End Get
    End Property

    Dim mPreviousResponse As String = ""
    Public Property PreviousResponse As String Implements IPlugin.PreviousResponse
        Get
            Return mPreviousResponse
        End Get
        Set(value As String)
            mPreviousResponse = value
        End Set
    End Property
    Dim mPreviousUserinput As String = ""
    Public Property PreviousUserinput As String Implements IPlugin.PreviousUserinput
        Get
            Return mPreviousUserinput
        End Get
        Set(value As String)
            mPreviousUserinput = value
        End Set
    End Property
    Private MResponse As String = ""
    Public Property Response As String Implements IPlugin.Response
        Get
            Return MResponse
        End Get
        Set(value As String)
            MResponse = value
        End Set
    End Property

    Public Function GetResponse(UserInput As String) As Boolean Implements IPlugin.GetResponse
        Dim NewResponse As String = ""
        If UCase(UserInput) = "HI" Then NewResponse = "YO BRO"
        If NewResponse IsNot Nothing Then
            Response = NewResponse
            Return True
        Else

        End If
        Return False
    End Function
End Class
