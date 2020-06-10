Module SyS
    '1 - Create Instance Of AI BRAIN
    Public Chatbot As New AI_AgentModel
    'Here we will load the Main AI


    ''' <summary>
    ''' Used as Start point to hand;e events centrally
    ''' </summary>
    Sub Main()

        LoadUI()
    End Sub

#Region "UI"
    ''' <summary>
    ''' Text IN      >>> Get Response From Brain 
    ''' </summary>
    Public WithEvents ChatbotUI As New Form_Chat_UI
    ''' <summary>
    ''' TEXT OUT   >>> Pass Response To UI TextOut
    ''' </summary>
    ''' <param name="Text"></param>
    Private Sub UI_TEXT_RECIEVED(ByVal Text As String) Handles ChatbotUI.TEXTRECIEVED
        'Get Response 
        ChatbotUI.DISPLAYOUTPUT(Chatbot.GET_RESPONSE(Text))
    End Sub
    ''' <summary>
    ''' The Load Function Enables for external instansation of form
    ''' </summary>
    Public Sub LoadUI()

        ChatbotUI.Show()
    End Sub
#End Region
End Module
