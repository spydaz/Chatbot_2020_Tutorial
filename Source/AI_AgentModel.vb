Imports System.Runtime.Remoting.Messaging
Imports AI_Contracts
Public Class AI_AgentModel
    'ShortTerm Memory
    Private PreviousResponses As New List(Of String)
    Private PreviousUserInputs As New List(Of String)

    'Working Memory 
    Public PreviousResponse As String
    Public PreviousUserInput As String
    Public UserInput As String
    Public Response As String


    Public Sentiment As New Emotional_StateMachine

    'Responses Are Genearated Externally
#Region "Responses"
    ''' <summary>
    ''' Responses will be generated from External Compiled Plugins
    ''' </summary>
    ''' <param name="UserInput"></param>
    ''' <returns></returns>
    Public Function GET_RESPONSE(ByRef UserInput As String) As String
        'Get External Responses
        GET_RESPONSE = GetPluginResponse(UserInput, PreviousUserInput, PreviousResponse)
        'IF NO RESPONSE TRY -  Question Answer Database
        If GET_RESPONSE = "" Then GetQAResponse(UserInput, GET_RESPONSE)
        'TRY EMOTIONAL RESPONSE
        If GET_RESPONSE = "" And Sentiment.NewEmotionDetected(UCase(UserInput)) = True Then
            GET_RESPONSE = Sentiment.MakeEmotionalResponse()
        End If

        'IF No Response Fallback Response
        If GET_RESPONSE = "" Then GET_RESPONSE = "Excuse me? Please, Rephrase?"

        'MainTain History
        PreviousUserInput = UserInput
        PreviousResponse = GET_RESPONSE
        PreviousUserInputs.Add(PreviousUserInput)
        PreviousResponses.Add(PreviousResponse)
    End Function
    Private Function GetPluginResponse(ByRef UserInput As String, ByRef PrevUSerInput As String, ByRef PrevResponse As String) As String
        GetPluginResponse = ExecutePlugins(UserInput, ScanPlugins)
    End Function
#End Region

    Public Sub New(ByRef Path As String)
        PLUGIN_FOLDER = Path

    End Sub
    Public Sub New()

    End Sub

End Class
