Module SyS
    Public Chatbot As New AI_AgentModel
    'Here we will load the Main AI

    Sub Main()
        '1 - Create Instance Of AI UI
        LoadUI()

        '2- Create Instance OF MainBrain >> (Public Chatbot As New AI_AgentModel)


        '3-On Event Text UI in >> (Public WithEvents ChatbotUI As New Form_Chat_UI)
        '>>> Get Response From Brain 
        '>>> Pass Response To UI TextOut
        '           SUB ( Private Sub UI_TEXT_RECIEVED(ByVal Text As String) Handles ChatbotUI.TEXTRECIEVED)



    End Sub

#Region "UI"
    ''' <summary>
    ''' Text IN 
    ''' </summary>
    Public WithEvents ChatbotUI As New Form_Chat_UI
    ''' <summary>
    ''' TEXT OUT
    ''' </summary>
    ''' <param name="Text"></param>
    Private Sub UI_TEXT_RECIEVED(ByVal Text As String) Handles ChatbotUI.TEXTRECIEVED
        'Get Response 
        ChatbotUI.DISPLAYOUTPUT(Chatbot.GET_RESPONSE(Text))
    End Sub

    Public Sub LoadUI()

        ChatbotUI.Show()
    End Sub
#End Region
End Module
