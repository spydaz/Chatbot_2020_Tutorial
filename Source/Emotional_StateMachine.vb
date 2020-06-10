Public Class Emotional_StateMachine
    ''' <summary>
    ''' Current emotion
    ''' </summary>
    Public CurrentState As EmotionType
    ''' <summary>
    ''' Current emotion as STRING
    ''' </summary>
    Public CurrentStateStr As String = "Neutral"
    ''' <summary>
    ''' If state has changed mood has changed
    ''' </summary>
    Private StateChanged As Boolean = False
    ''' <summary>
    ''' Current detected state
    ''' </summary>
    Private DetectedState As EmotionType
    ''' <summary>
    ''' New state has been detected
    ''' </summary>
    Private StateDetected As Boolean = False
    ''' <summary>
    ''' Intensity of emotion increases if emotional state remains the same and is reduced if At JOY 3 and state is detected Neutral is reduced
    ''' Intensity can rise and fall eventually becomming neutral - Even neutrality and indifference can be intesified: 
    ''' Perhaps if neutrality reaches a certain point then BORDEM can SET IN!
    ''' </summary>
    Public CurrentQuotient As Integer = 1
    'PROCESS: PRESERVE VARIABLES
    'EMOTION
    ''' <summary>
    ''' Used to make a Generic Emotional Response 
    ''' </summary>
    ''' <param name="FoundEmotion">Provided emotion (HAPPY)</param>
    ''' <returns></returns>
    Public Shared Function MakeEmotionalResponse(ByVal FoundEmotion As String) As String
        MakeEmotionalResponse = ""
        Randomize()
        Dim C As Short = Int(Rnd() * 6 + 1)
        Select Case C
            Case 1
                MakeEmotionalResponse = "I detect emotion in your tone, you are feeling " & LCase(FoundEmotion) & " perhaps"
            Case 2
                MakeEmotionalResponse = "Are you feeling " & LCase(FoundEmotion) & " ?"
            Case 3
                MakeEmotionalResponse = "Perhaps ? you can tell me more about why you are feeling ? " & LCase(FoundEmotion)
            Case 4
                MakeEmotionalResponse = "Detecting " & LCase(FoundEmotion) & " maybe?"
            Case 5
                MakeEmotionalResponse = "feeling a bit " & LCase(FoundEmotion) & " ?"
            Case 6
                MakeEmotionalResponse = "" & LCase(FoundEmotion) & " "
        End Select
    End Function
    ''' <summary>
    ''' Used to make a Emotional response fromt he currently held Emotion
    ''' </summary>
    ''' <returns></returns>
    Public Function MakeEmotionalResponse() As String
        Dim FoundEmotion As String = CurrentStateStr
        MakeEmotionalResponse = ""
        Randomize()
        Dim C As Short = Int(Rnd() * 6 + 1)
        Select Case C
            Case 1
                MakeEmotionalResponse = "I detect emotion in your tone, you are feeling " & LCase(FoundEmotion) & " perhaps"
            Case 2
                MakeEmotionalResponse = "Are you feeling " & LCase(FoundEmotion) & " ?"
            Case 3
                MakeEmotionalResponse = "Perhaps ? you can tell me more about why you are feeling ? " & LCase(FoundEmotion)
            Case 4
                MakeEmotionalResponse = "Detecting " & LCase(FoundEmotion) & " maybe?"
            Case 5
                MakeEmotionalResponse = "feeling a bit " & LCase(FoundEmotion) & " ?"
            Case 6
                MakeEmotionalResponse = "" & LCase(FoundEmotion) & " "
        End Select
    End Function
    ''' <summary>
    ''' Resets Indicator values for determining state change
    ''' </summary>
    Private Sub ResetStateCounters()
        'Reset Counters
        StateChanged = False
        DetectedState = EmotionType.Neutral
        StateDetected = False
    End Sub
    ''' <summary>
    ''' Increases or Decreases current intensity of emotion held
    ''' </summary>
    Private Sub SetCurrentQuotient()
        'Check if neutral - Then reduce current Quotient
        If Handler.DetectedEmotion = EmotionType.Neutral Then
            CurrentQuotient -= 1
            If CurrentQuotient = 0 Then
                'Reset State
                CurrentState = EmotionType.Neutral
                CurrentStateStr = "Neutral"
                StateChanged = True
            Else
            End If
        End If
    End Sub
    ''' <summary>
    ''' Shared between functions holding the currently detected emotions and Created intefaces(STATES)
    ''' </summary>
    Private Handler As New EmotionHandler
    ''' <summary>
    ''' Determines and sets the current state and intensity of state: 
    ''' The Quotient value can be used to determine how much of a particular emotion is experienced, 
    ''' the value is increased as emotion is repeatly detected.
    ''' as the conversation returns to neutrality if another emotion is ot detected the Qujotient is decreased
    ''' At point of 0 intensity the state is returned to Neutral
    ''' </summary>
    ''' <param name="UserInput"></param>
    Private Sub SetEmotionState(ByRef UserInput As String)
        'Reset the indicators for Detected ans State Change
        ResetStateCounters()

        'Start - Emotion Test
        If Handler.DetectEmotion(UserInput) = True Then
            'Updates Quotient If No Changes have been Detected +/- (intensity of emotion)
            SetCurrentQuotient()

            'Get State
            DetectedState = Handler.DetectedEmotion
            StateDetected = True

            'IF State is the same Increase Intensity
            If DetectedState = CurrentState Then
                CurrentQuotient += 1
                'Update State "DATA" 
                CurrentStateStr = Handler.DetectedEmotionStr
                CurrentState = DetectedState
            Else
                'IF State is the differnt then change (Update State Data)
                CurrentStateStr = Handler.DetectedEmotionStr
                CurrentState = DetectedState
                StateChanged = True
                'Reset Intensity
                CurrentQuotient = 1
            End If
        End If
    End Sub
    ''' <summary>
    ''' Used to See if an emotion has been detected 
    ''' </summary>
    ''' <param name="Userinput"></param>
    ''' <returns></returns>
    Public Function NewEmotionDetected(ByRef Userinput As String) As Boolean
        SetEmotionState(Userinput)
        If StateChanged = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
