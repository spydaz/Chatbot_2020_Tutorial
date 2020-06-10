

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

