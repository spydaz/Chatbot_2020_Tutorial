Public Class Emotional_State
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

''' <summary>
''' Loads Emotions: Emotion interface provides a platform for the template of an emotion the the
''' LoadEmotions; Function in The emotion handler will need to be adjusted for new emotions
''' designed; the emotion handler loads all the emotions and executes each detector in the
''' emotion set is a response is detected it is held in the handler. A response can then be
''' generated as required from the subclass or the handler. the emotion Objects and functions are
''' encapslated int this emotions Class Library.
''' </summary>
Public Class EmotionHandler

    Private iLoadedEmotions As New List(Of IEmotion)

    Private mDetectedEmotion As EmotionType

    Private mEmotion As String

    Public ReadOnly Property DetectedEmotion As EmotionType
        Get
            Return mDetectedEmotion
        End Get
    End Property

    Public ReadOnly Property DetectedEmotionStr As String
        Get
            Return mEmotion
        End Get

    End Property

    Public ReadOnly Property LoadedEmotions As List(Of IEmotion)
        Get
            Return iLoadedEmotions
        End Get
    End Property

    Public Sub New()
        iLoadedEmotions = LoadEmotions()
    End Sub

    Public Sub AddEmotion(ByRef Emo As IEmotion)
        iLoadedEmotions.Add(Emo)
    End Sub

    Public Function DetectEmotion(ByRef Userinput As String) As Boolean
        For Each emo As IEmotion In LoadedEmotions
            If emo.Detect(Userinput) = True Then
                mDetectedEmotion = emo.Type
                mEmotion = emo.Name
                Return True
            Else
                mDetectedEmotion = EmotionType.Neutral
                mEmotion = "Neutral"

            End If

        Next
        Return False
    End Function

    Public Function LoadEmotions() As List(Of IEmotion)
        Dim mLoadedEMOTIONs As New List(Of IEmotion) From {
                    New EmotionAngry,
                    New EmotionConcerned,
                    New EmotionCurious,
                    New EmotionFailure,
                    New EmotionFear,
                    New EmotionGreatful,
                    New EmotionHappy,
                    New EmotionJealous,
                    New EmotionJoy,
                    New EmotionLaughing,
                    New EmotionLove,
                    New EmotionSad,
                    New EmotionSerious,
                    New EmotionSleepy,
                    New EmotionSuprised
                }
        Return mLoadedEMOTIONs
    End Function

End Class

''' <summary>
''' The emotion type can be used to catagorize some of the basic emotions the list is just a
''' basic collection of emotiontypes ; the emotion finder class uses these basic emotion
''' types to describe the current emotion detected by the class. this type list is no a
''' complete list.
''' </summary>
Public Enum EmotionType
    Joy
    Happy
    Sad
    Love
    Laughing
    Surprised
    Sleepy
    Serious
    Angry
    Jealous
    curious
    Concerned
    Failure
    Fear
    Greatful
    Neutral
End Enum

