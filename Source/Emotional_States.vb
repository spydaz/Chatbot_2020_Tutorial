


Public Interface IEmotion

    ReadOnly Property Detectors As List(Of String)

    ReadOnly Property Name As String

    ReadOnly Property Type As EmotionType

    ''' <summary>
    ''' Adds keyword to detector list
    ''' </summary>
    ''' <param name="Detector"></param>
    Sub AddDetector(ByRef Detector As String)

    ''' <summary>
    ''' Detects if input contains emotional detector
    ''' </summary>
    ''' <param name="UserInput"></param>
    ''' <returns></returns>
    Function Detect(ByRef UserInput As String) As Boolean

End Interface

Public Class EmotionAngry
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Angry"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Angry
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("ANGER")
        DetectorLst.Add("ANGRY")
        DetectorLst.Add("DECEPTION")
        DetectorLst.Add("DISGUSTING")
        DetectorLst.Add("EMBEZZLEMENT")
        DetectorLst.Add("HURTFUL")
        DetectorLst.Add("INJUSTICE")
        DetectorLst.Add("INJURY")
        DetectorLst.Add("OUTRAGE")
        DetectorLst.Add("OUTRAGEOUS")
        DetectorLst.Add("REVOLTING")
        DetectorLst.Add("SCANDALOUS")
        DetectorLst.Add("SPITEFUL")
        DetectorLst.Add("STEALING")
        DetectorLst.Add("STOLEN")
        DetectorLst.Add("STUPID")
        DetectorLst.Add("UNCALLED FOR")
        DetectorLst.Add("VIOLENCE")
        DetectorLst.Add("VIOLENT")
        DetectorLst.Add("WASTEFUL")
        DetectorLst.Add("I DON'T LIKE YOU")
        DetectorLst.Add("ARE WE SIZING EACH OTHER UP")
        DetectorLst.Add("YOUR STUPID")
        DetectorLst.Add("YOU'RE STUPID")
        DetectorLst.Add("YOU ARE STUPID")
        DetectorLst.Add("YOU'RE DUM")
        DetectorLst.Add("I JUST INSULTED YOU")
        DetectorLst.Add("I DID INSULT YOU")
        DetectorLst.Add("ARE BEING INSULTED")
        DetectorLst.Add("YOU'RE A SHIT")
        DetectorLst.Add("YOU'RE AN IDIOT")
        DetectorLst.Add("FUCK OFF")
        DetectorLst.Add("FLAKE OFF")
        DetectorLst.Add("YOUR A QUEER")
        DetectorLst.Add("YOU'RE A FAGGOT")
        DetectorLst.Add("YOU'RE A STALKER")
        DetectorLst.Add("YOU BITCH")
        DetectorLst.Add("YOU'RE A BITCH")
        DetectorLst.Add("ARE YOU GAY")
        DetectorLst.Add("YOU'RE GAY")
        DetectorLst.Add("YOU ARE DUM")
        DetectorLst.Add("I'M SMARTER THAN YOU")
        DetectorLst.Add("YOU WHORE")
        DetectorLst.Add("YOUR A WHORE")
        DetectorLst.Add("YOU CUNT")
        DetectorLst.Add("YOU'RE A CUNT")
        DetectorLst.Add("YOU'RE A SLUT")
        DetectorLst.Add("SUCK ME")
        DetectorLst.Add("FUCK YOU")
        DetectorLst.Add("SUCK MY")
        DetectorLst.Add("FUCK ME")
        DetectorLst.Add("YOUR MAMA")
        DetectorLst.Add("DICK LICKER")
        DetectorLst.Add("YOU'RE SHIT")
        DetectorLst.Add("YOU AIN'T SHIT")
        DetectorLst.Add("YOU BASTARD")
        DetectorLst.Add("YOU ARE A BASTARD")
        DetectorLst.Add("YOU'RE A BASTARD")
        DetectorLst.Add("FUCK HEAD")
        DetectorLst.Add("YOU ARE LAME")
        DetectorLst.Add("YOU'RE LAME")
        DetectorLst.Add("YOU ARE A LAME")
        DetectorLst.Add("YOU'RE AN ASS")
        DetectorLst.Add("YOU ARE AN ASS WIPE")
        DetectorLst.Add("YOU'RE THE ONE WHO IS")
        DetectorLst.Add("YOUR THE ONE WHO'S")
        DetectorLst.Add("YOU'RE A COMPLETE")
        DetectorLst.Add("DON'T TALK TO ME")
        DetectorLst.Add("NEVER TALK TO ME")
        DetectorLst.Add("DON'T EVER TALK TO ME")
        DetectorLst.Add("DONT TALK TO ME")
        DetectorLst.Add("DONT EVER TALK TO ME")
        DetectorLst.Add("YOU ARE THE ONE WHO'S")
        DetectorLst.Add("YOU'RE BEING A")
        DetectorLst.Add("I HATE YOU")
        DetectorLst.Add("YOUR WORTHLESS")
        DetectorLst.Add("YOU'RE WORTHLESS")
        DetectorLst.Add("I'M NOT YOUR")
        DetectorLst.Add("YOU'RE A JERK")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionConcerned
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Concerned"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Concerned
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Concerned")
        DetectorLst.Add(" IN PAIN ")
        DetectorLst.Add(" I'M HURT ")
        DetectorLst.Add(" DROPPED ON MY ")
        DetectorLst.Add(" SCRATCHED MY ")
        DetectorLst.Add(" A SCRATCH  ON MY ")
        DetectorLst.Add(" BRUISED ")
        DetectorLst.Add(" I BRUISED MY ")
        DetectorLst.Add(" CUT ON MY ")
        DetectorLst.Add(" I CUT MY ")
        DetectorLst.Add(" I HAVE A BROKEN FOOT ")
        DetectorLst.Add(" I HAVE A BROKEN BONE ")
        DetectorLst.Add(" I HAVE A BROKEN RIB ")
        DetectorLst.Add(" I HAVE A BROKEN  HAND ")
        DetectorLst.Add(" I HAVE A HEARTACHE ")
        DetectorLst.Add(" I HAVE A STOMACHE ACHE ")
        DetectorLst.Add(" I HAVE A BELLY ACHE ")
        DetectorLst.Add(" I HAVE A HEADACHE ")
        DetectorLst.Add(" I HAVE MIGRAINE ")
        DetectorLst.Add(" I STUBBED MY ")
        DetectorLst.Add("I SPRAINED MY ")
        DetectorLst.Add(" I  STRAINED MY ")
        DetectorLst.Add(" I HAVE A BACK ACHE ")
        DetectorLst.Add(" I HAVE EYE STRAIN ")
        DetectorLst.Add(" MY EYE IS SORE ")
        DetectorLst.Add(" MY EYES ARE SORE ")
        DetectorLst.Add(" I  BURNT MY ")
        DetectorLst.Add(" I BURNED MY ")
        DetectorLst.Add(" MY BOYFRIEND  BROKE UP WITH ME ")
        DetectorLst.Add(" MY GIRLFRIEND BROKE UP WITH ME ")
        DetectorLst.Add(" I LOST MY ")
        DetectorLst.Add(" DIED ")
        DetectorLst.Add(" A DEATH ")
        DetectorLst.Add(" I'M CRYING ")
        DetectorLst.Add(" I'M GRIEVING ")
        DetectorLst.Add(" FEEL GRIEF ")
        DetectorLst.Add(" I AM MOURNING ")
        DetectorLst.Add(" I HAVE A PAPERCUT ")
        DetectorLst.Add(" I GOT A PAPERCUT ")
        DetectorLst.Add(" I GOT A HANG NAIL ")
        DetectorLst.Add(" I BANGED MY ")
        DetectorLst.Add(" I BASHED MY ")
        DetectorLst.Add(" I BRUISED MY ")
        DetectorLst.Add(" I'M BLEEDING ")
        DetectorLst.Add(" I HAVE A HANG NAIL ")
        DetectorLst.Add(" I HAVE A SPLINTER ")
        DetectorLst.Add(" I HAVE A SLIVER ")
        DetectorLst.Add(" MY STOMACHE ACHES ")
        DetectorLst.Add(" MY HEAD ACHES ")
        DetectorLst.Add(" MY FEET ACHE ")
        DetectorLst.Add(" MY BACK ACHES ")
        DetectorLst.Add(" MY EYES HURT ")
        DetectorLst.Add(" A GASH IN MY ")
        DetectorLst.Add(" I RIPPED MY ")
        DetectorLst.Add(" I TORE MY ")
        DetectorLst.Add(" I'M SORE ")
        DetectorLst.Add(" I ACHE ")
        DetectorLst.Add(" I  HURT ")
        DetectorLst.Add(" I GOT HURT ")
        DetectorLst.Add(" I JUST HAD A WRECK ")
        DetectorLst.Add(" I JUST HAD AN ACCIDENT ")
        DetectorLst.Add(" I FELL DOWN ")
        DetectorLst.Add(" I FELL OFF ")
        DetectorLst.Add(" I SCRAPED MY ")
        DetectorLst.Add(" I STUBBED MY ")
        DetectorLst.Add(" I AM SAD ")
        DetectorLst.Add(" I'M SAD ")
        DetectorLst.Add(" I FEEL SAD ")
        DetectorLst.Add(" I'M REALY SAD ")
        DetectorLst.Add(" I AM REALLY SAD ")
        DetectorLst.Add(" I'M DEPRESSED ")
        DetectorLst.Add(" I AM DEPRESSED ")
        DetectorLst.Add(" I DON'T FEEL GOOD ")
        DetectorLst.Add(" I DO NOT FEEL GOOD ")
        DetectorLst.Add(" I DON'T FEEL WELL ")
        DetectorLst.Add(" I DO NOT FEEL WELL ")
        DetectorLst.Add(" I'M SICK ")
        DetectorLst.Add(" I AM SICK ")
        DetectorLst.Add(" I FEEL REALY SICK ")
        DetectorLst.Add(" I HAVE A COLD ")
        DetectorLst.Add(" I HAVE THE FLU  ")
        DetectorLst.Add(" I HAVE CONGESTION ")
        DetectorLst.Add(" I HAD AN ASTHMA ")
        DetectorLst.Add(" I'M HAVING TROUBLE ")
        DetectorLst.Add(" I BROKE MY ")
        DetectorLst.Add(" I BROKE A ")
        DetectorLst.Add(" I GOT DIVORCED ")
        DetectorLst.Add(" I GOT A DIVORCE ")
        DetectorLst.Add(" I HAD A DIVORCE ")
        DetectorLst.Add(" I DIVORCED ")
        DetectorLst.Add(" I'M IN DANGER ")
        DetectorLst.Add(" I AM IN DANGER ")
        DetectorLst.Add(" I HAD A CLOSE CALL ")
        DetectorLst.Add(" MY LIFE IS IN DANGER ")
        DetectorLst.Add(" MY LIFE IS IN SERIOUS DANGER ")
        DetectorLst.Add(" I LOST MY TOOTH ")
        DetectorLst.Add(" TEETH PULLED ")
        DetectorLst.Add(" SOME OF MY TEETH ")
        DetectorLst.Add(" A BLISTER ")
        DetectorLst.Add(" MY FEET HURT ")
        DetectorLst.Add(" I HAVE BODY ACHES ")
        DetectorLst.Add(" I HAVE A BODY ACHE ")
        DetectorLst.Add(" YOU OK  ")
        DetectorLst.Add(" YOU OKAY  ")
        DetectorLst.Add(" I AM OK  ")
        DetectorLst.Add(" I'M OK  ")
        DetectorLst.Add(" I'M ALRIGHT  ")
        DetectorLst.Add(" I'M ALL RIGHT  ")
        DetectorLst.Add(" I'LL BE FINE  ")
        DetectorLst.Add(" I WILL BE FINE  ")
        DetectorLst.Add(" I'LL BE OK  ")
        DetectorLst.Add(" I WILL BE OK  ")
        DetectorLst.Add(" I WILL BE OKAY  ")
        DetectorLst.Add(" I'LL BE OKAY  ")
        DetectorLst.Add(" YOU'LL BE OKAY  ")
        DetectorLst.Add(" HOW ARE YOU FEELING  ")
        DetectorLst.Add(" WHAT ARE YOUR FEELINGS  ")
        DetectorLst.Add(" I FEEL FOR YOU  ")
        DetectorLst.Add(" DO YOU CARE  ")
        DetectorLst.Add(" I'M FINE  ")
        DetectorLst.Add(" I CARE  ")
        DetectorLst.Add(" YOU CARE  ")
        DetectorLst.Add(" I DO CARE  ")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionCurious
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Curious"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.curious
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Curious")

        DetectorLst.Add(" PUZZLE ")
        DetectorLst.Add(" SEEK ")
        DetectorLst.Add(" FIND ")
        DetectorLst.Add(" LOOK ")
        DetectorLst.Add(" SEARCH ")
        DetectorLst.Add(" WATCH ")
        DetectorLst.Add(" STUDY ")
        DetectorLst.Add(" RESEARCH ")
        DetectorLst.Add(" PROCESS ")
        DetectorLst.Add(" FIND ")
        DetectorLst.Add(" LOOK ")
        DetectorLst.Add(" SEARCH ")
        DetectorLst.Add(" WATCH ")
        DetectorLst.Add(" STUDY ")
        DetectorLst.Add(" RESEARCH ")
        DetectorLst.Add(" PROCESS ")
        DetectorLst.Add(" SEEK ")
        DetectorLst.Add(" PUZZLE ")
        DetectorLst.Add(" PIQUE ")
        DetectorLst.Add(" AROUSE ")
        DetectorLst.Add(" QUIZICAL ")
        DetectorLst.Add(" UNKNOWN ")
        DetectorLst.Add(" MYSTERY ")
        DetectorLst.Add(" WONDERING ")
        DetectorLst.Add(" INTEREST ")
        DetectorLst.Add(" CURIOUS ")
        DetectorLst.Add(" LEARN ")
        DetectorLst.Add(" TEST ")
        DetectorLst.Add(" DELVE ")
        DetectorLst.Add(" INQUIRE ")
        DetectorLst.Add(" EXAM ")
        DetectorLst.Add(" RIDDLE ")
        DetectorLst.Add(" SUSPENSE ")
        DetectorLst.Add(" TO KNOW ")
        DetectorLst.Add(" YOU KNOW ")
        DetectorLst.Add(" ? ")
        DetectorLst.Add(" WOULD YOU ")
        DetectorLst.Add(" COULD YOU ")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionFailure
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Failure"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Failure
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Failure")

        DetectorLst.Add(" DON'T KNOW ")
        DetectorLst.Add(" DONT KNOW ")
        DetectorLst.Add(" FAIL ")
        DetectorLst.Add(" FAILURE ")
        DetectorLst.Add(" DISAPPOINTED ")
        DetectorLst.Add(" LOST ")
        DetectorLst.Add(" LOSER ")
        DetectorLst.Add(" FAILED ")
        DetectorLst.Add(" LAST ")
        DetectorLst.Add(" UNIMPORTANT ")
        DetectorLst.Add(" UNPOPULAR ")
        DetectorLst.Add(" LAUGHING STOCK ")
        DetectorLst.Add(" FAKE ")
        DetectorLst.Add(" CAUGHT ")
        DetectorLst.Add(" BREAK ")
        DetectorLst.Add(" BROKEN ")
        DetectorLst.Add(" STRESSED ")
        DetectorLst.Add(" DIED ")
        DetectorLst.Add(" NOT WIN ")
        DetectorLst.Add(" CAPTURED ")
        DetectorLst.Add(" NOT WORK ")
        DetectorLst.Add(" NOTHING ")
        DetectorLst.Add(" ABSENT ")
        DetectorLst.Add(" UNRELIABLE ")
        DetectorLst.Add(" NOT FUNCTIONING ")
        DetectorLst.Add(" DOESN'T FUNCTION ")
        DetectorLst.Add(" NOT FUNCTION ")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionFear
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Fear"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Fear
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Scary")
        DetectorLst.Add(" DIE ")
        DetectorLst.Add(" TO DEATH ")
        DetectorLst.Add(" YOU ARE DEAD ")
        DetectorLst.Add(" YOU'RE DEAD ")
        DetectorLst.Add(" FEAR ")
        DetectorLst.Add(" FEARS ")
        DetectorLst.Add(" SCARED ")
        DetectorLst.Add(" SCAREY ")
        DetectorLst.Add(" SCARE ")
        DetectorLst.Add(" AFRAID ")
        DetectorLst.Add(" WORRIED ")
        DetectorLst.Add(" WORRY ")
        DetectorLst.Add(" SPOOKY ")
        DetectorLst.Add(" PHOBIA ")
        DetectorLst.Add(" PHOBIAS ")
        DetectorLst.Add(" FRIGHTEN ")
        DetectorLst.Add(" FRIGHT ")
        DetectorLst.Add(" HORROR ")
        DetectorLst.Add(" HORRIFIED ")
        DetectorLst.Add(" HORRIFIC ")
        DetectorLst.Add(" HAUNT ")
        DetectorLst.Add(" WICKED ")
        DetectorLst.Add(" DEMONIC ")
        DetectorLst.Add(" FREAK ")
        DetectorLst.Add(" ARE YOU CHICKEN ")
        DetectorLst.Add(" ARE YOU A CHICKEN ")
        DetectorLst.Add(" WHY ARE YOU A CHICKEN ")
        DetectorLst.Add(" YOU'RE A CHICKEN ")
        DetectorLst.Add(" DON'T BE CHICKEN ")
        DetectorLst.Add(" DON'T BE A CHICKEN ")
        DetectorLst.Add(" FREAKY ")
        DetectorLst.Add(" FREAKEN ")
        DetectorLst.Add(" FREAKING ")
        DetectorLst.Add(" FREAKISH ")
        DetectorLst.Add(" SCARDEY ")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionGreatful
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Greatful"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Greatful
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Thanks")

        'USER IS THANKING
        'THIS ROUTINE ALLOWS US TO RESPOND WITH A VARIETY OF REMARKS TO A THANK-YOU FROM THE USER.

        'NOTE THAT THE PRONOUNS ARE NOT REVERSED IN THE PROCESSING BELOW!
        DetectorLst.Add("OWE YOU")
        DetectorLst.Add("APPRECIATE IT")
        DetectorLst.Add("APPRECIATE YOU")
        DetectorLst.Add("ETERNAL THANKS")
        DetectorLst.Add("ETERNAL GRATITUDE")
        DetectorLst.Add("EXPRESS MY THANKS")
        DetectorLst.Add("EXPRESS THANKS")
        DetectorLst.Add("GRATEFUL THANKS")
        DetectorLst.Add("GRATEFUL TO YOU")
        DetectorLst.Add("GRATITUDE TO YOU")
        DetectorLst.Add("IN YOUR DEBT")
        DetectorLst.Add("INDEBTED TO YOU")
        DetectorLst.Add("IT SHOULD GO TO YOU")
        DetectorLst.Add("MANY THANK YOU")
        DetectorLst.Add("MANY THANKS")
        DetectorLst.Add("MY APPRECIATION")
        DetectorLst.Add("MY GRATITUDE")
        DetectorLst.Add("MY THANK YOU")
        DetectorLst.Add("MY THANKS")
        DetectorLst.Add("OU DESERVE THE CREDI")
        DetectorLst.Add("PRECIATION TO YOU")
        DetectorLst.Add("SINCERE THANKS ")
        DetectorLst.Add("THANK YOU")
        DetectorLst.Add("THANKS FOR ")
        DetectorLst.Add("THANKS SO ")
        DetectorLst.Add("THANKS TO YOU ")
        DetectorLst.Add("THANKS VERY ")
        DetectorLst.Add("TO SAY THANKS ")
        DetectorLst.Add("YOU A DEBT OF GRAT")
        DetectorLst.Add("YOU DEBT OF GRAT")
        DetectorLst.Add("YOU DESERVE CREDIT")
        DetectorLst.Add("YOU GREAT GRAT")
        DetectorLst.Add("YOU SINCERE GRAT")
        DetectorLst.Add("YOU TREMENDOUS GRAT")
        DetectorLst.Add("THANKS")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionHappy
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Happy"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Happy
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()
        DetectorLst.Add("OWE YOU")
        DetectorLst.Add("APPRECIATE IT")
        DetectorLst.Add("APPRECIATE YOU")
        DetectorLst.Add("ETERNAL THANKS")
        DetectorLst.Add("ETERNAL GRATITUDE")
        DetectorLst.Add("EXPRESS MY THANKS")
        DetectorLst.Add("EXPRESS THANKS")
        DetectorLst.Add("GRATEFUL THANKS")
        DetectorLst.Add("GRATEFUL TO YOU")
        DetectorLst.Add("GRATITUDE TO YOU")
        DetectorLst.Add("IN YOUR DEBT")
        DetectorLst.Add("INDEBTED TO YOU")
        DetectorLst.Add("IT SHOULD GO TO YOU")
        DetectorLst.Add("MANY THANK YOU")
        DetectorLst.Add("MANY THANKS")
        DetectorLst.Add("MY APPRECIATION")
        DetectorLst.Add("MY GRATITUDE")
        DetectorLst.Add("MY THANK YOU")
        DetectorLst.Add("MY THANKS")
        DetectorLst.Add("PRECIATION TO YOU")
        DetectorLst.Add("SINCERE THANKS ")
        DetectorLst.Add("THANK YOU")
        DetectorLst.Add("THANKS FOR ")
        DetectorLst.Add("THANKS SO ")
        DetectorLst.Add("THANKS TO YOU ")
        DetectorLst.Add("THANKS VERY ")
        DetectorLst.Add("TO SAY THANKS ")
        DetectorLst.Add("YOU A DEBT OF GRAT")
        DetectorLst.Add("YOU DEBT OF GRAT")
        DetectorLst.Add("YOU DESERVE CREDIT")
        DetectorLst.Add("YOU GREAT GRAT")
        DetectorLst.Add("YOU SINCERE GRAT")
        DetectorLst.Add("YOU TREMENDOUS GRAT")
        DetectorLst.Add("THANKS!")
        DetectorLst.Add("GOD")
        DetectorLst.Add("LORD")
        DetectorLst.Add("JESUS")
        DetectorLst.Add("HEAVEN")
        DetectorLst.Add("PRAY")
        DetectorLst.Add("AMEN")
        DetectorLst.Add("I LOVE YOU ")
        DetectorLst.Add("I AM IN LOVE WITH YOU ")
        DetectorLst.Add("I'AM IN LOVE WITH YOU ")
        DetectorLst.Add("I HAVE LOVE FOR YOU ")
        DetectorLst.Add("I'VE LOVE FOR YOU ")
        DetectorLst.Add("FEEL LOVE FOR YOU ")
        DetectorLst.Add("I GIVE LOVE TO YOU ")
        DetectorLst.Add("I WANT TO LOVE YOU ")
        DetectorLst.Add("I DO LOVE YOU ")
        DetectorLst.Add("I CAN'T HELP BUT LOVE YOU ")
        DetectorLst.Add("I HAVE LOVE FOR YOU ")
        DetectorLst.Add("A RAISE ")
        DetectorLst.Add("ANNIVERSARY ")
        DetectorLst.Add("BIRTHDAY ")
        DetectorLst.Add("GLAD ")
        DetectorLst.Add("GOOD ")
        DetectorLst.Add("HAPPY ")
        DetectorLst.Add("JOYFUL ")
        DetectorLst.Add("JOYOUS ")
        DetectorLst.Add("PLEASING ")
        DetectorLst.Add("PRAISE ")
        DetectorLst.Add("PRAISING ")
        DetectorLst.Add("PROMOTION ")
        DetectorLst.Add("RECOGNITION ")
        DetectorLst.Add(" SMILE ")
        DetectorLst.Add(" TRIUMPH ")
        DetectorLst.Add(" VICTORY ")
    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionJealous
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Jealous"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Jealous
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Joy")

        DetectorLst.Add(" LOSE ")
        DetectorLst.Add(" LOSING ")
        DetectorLst.Add(" SOMEONE ELSE ")
        DetectorLst.Add(" SOMEONE MORE ")
        DetectorLst.Add(" BELONGS TO ME ")
        DetectorLst.Add(" MINE ")
        DetectorLst.Add(" YOU CAN'T ")
        DetectorLst.Add(" YOU CANNOT ")
        DetectorLst.Add(" YOU CAN NOT ")
        DetectorLst.Add(" YOU ARE NOT ")
        DetectorLst.Add(" YOU'RE NOT ")
        DetectorLst.Add(" I'M SMARTER ")
        DetectorLst.Add(" I AM SMARTER ")
        DetectorLst.Add(" I'M MORE ")
        DetectorLst.Add(" I'M BETTER ")
        DetectorLst.Add(" I AM BETTER ")
        DetectorLst.Add(" NOT YOURS ")
        DetectorLst.Add(" ALL MINE ")
        DetectorLst.Add(" YOU CAN NEVER ")
        DetectorLst.Add(" NOT YOUR ")
        DetectorLst.Add(" NOT YOURS ")
        DetectorLst.Add(" JEALOUS ")
        DetectorLst.Add(" I DON'T WANT YOU ")
        DetectorLst.Add(" I WAS WITH ")
        DetectorLst.Add(" ENVY ")
        DetectorLst.Add(" I DON'T NEED YOU ")
        DetectorLst.Add(" I DO NOT NEED YOU ")
        DetectorLst.Add(" I DONNOT NEED YOU ")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionJoy
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Joy"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Joy
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Joy")

        DetectorLst.Add("COMEDIAN")
        DetectorLst.Add("COMEDY")
        DetectorLst.Add("LAUGH")
        DetectorLst.Add("HAPPY")
        DetectorLst.Add("HUMOROUS")
        DetectorLst.Add("HUMOR")
        DetectorLst.Add("COMIC")
        DetectorLst.Add("LAUGHABLE")
        DetectorLst.Add("LAUGH")
        DetectorLst.Add("GLAD")
        DetectorLst.Add("GOOD")
        DetectorLst.Add("HAPPY")
        DetectorLst.Add("JOYFUL")
        DetectorLst.Add("JOYOUS")
        DetectorLst.Add("PLEASING")
        DetectorLst.Add("PRAISE")
        DetectorLst.Add("PRAISING")
        DetectorLst.Add("PROMOTION")
        DetectorLst.Add("RECOGNITION")
        DetectorLst.Add("SMILE")
        DetectorLst.Add("TRIUMPH")
        DetectorLst.Add("VICTORY")
        DetectorLst.Add("YOU SUCCEED")
        DetectorLst.Add("YOU WON")
        DetectorLst.Add("A RAISE")
        DetectorLst.Add("ANNIVERSARY")
        DetectorLst.Add("BIRTHDAY")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionLaughing
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Laughing"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Laughing
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Laughing")

        DetectorLst.Add("LAUGH")
        DetectorLst.Add("FUNNY")
        DetectorLst.Add("SMILE")
        DetectorLst.Add("SILLY")
        DetectorLst.Add("LOL")
        DetectorLst.Add("ROFLOL")
        DetectorLst.Add("ROFLMAO")
        DetectorLst.Add("GIGGLE")
        DetectorLst.Add("HAHAHA")
        DetectorLst.Add("COMEDY")
        DetectorLst.Add("COMIC")
        DetectorLst.Add("OOPS")
        DetectorLst.Add("LAUGHING")
        DetectorLst.Add(":)")
        DetectorLst.Add("LAUGHTER")
        DetectorLst.Add("YEAH BABY")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionLove
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Love"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Love
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Love")
        DetectorLst.Add("I NEED YOU")
        DetectorLst.Add("I WANT YOU")
        DetectorLst.Add("I CARE ABOUT YOU")
        DetectorLst.Add("I CARE FOR YOU")
        DetectorLst.Add("I LIKE YOU")
        DetectorLst.Add("I LOVE YOU")
        DetectorLst.Add("I'LL ALWAYS LOVE YOU")
        DetectorLst.Add("I WILL ALWAYS LOVE YOU")
        DetectorLst.Add("WILL YOU BE MINE")
        DetectorLst.Add("MARRY ME")
        DetectorLst.Add("YOU ARE MY DREAM")
        DetectorLst.Add("YOU'RE MY DREAM")
        DetectorLst.Add("BE WITH ME")
        DetectorLst.Add("YOU LOVE ME")
        DetectorLst.Add("LOVE WITH YOU")
        DetectorLst.Add("LOVE")
        DetectorLst.Add("ARE IN LOVE WITH")
        DetectorLst.Add("IN LOVE WITH")
        DetectorLst.Add("HAVE LOVE FOR")
        DetectorLst.Add("LOVE FOR")
        DetectorLst.Add("FEEL LOVE FOR")
        DetectorLst.Add("GIVE LOVE TO")
        DetectorLst.Add("WANT TO LOVE")
        DetectorLst.Add("DO LOVE")
        DetectorLst.Add("CAN'T HELP BUT LOVE")
        DetectorLst.Add("HAVE LOVE FOR")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionSad
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Sad"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Sad
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()
        DetectorLst.Add("SAD")
        DetectorLst.Add("CATASTROPHE")
        DetectorLst.Add("LAUGH")
        DetectorLst.Add("DEPRESSED")
        DetectorLst.Add("DESPONDENT")
        DetectorLst.Add("DISASTER")
        DetectorLst.Add("FAMINE")
        DetectorLst.Add("FIRE")
        DetectorLst.Add("MURDER")
        DetectorLst.Add("HURT BAD")
        DetectorLst.Add("SICK")
        DetectorLst.Add("ILLNESS")
        DetectorLst.Add("INJURY")
        DetectorLst.Add("LOSS OF YOUR")
        DetectorLst.Add("LOST YOUR")
        DetectorLst.Add("TRAGEDY")
        DetectorLst.Add("I DON'T FEEL GOOD")
        DetectorLst.Add("I DON'T FEEL WELL")
        DetectorLst.Add("CATASTROPHE")
        DetectorLst.Add("DEATH")
        DetectorLst.Add("DEPRESSED")
        DetectorLst.Add("DESPONDENT")
        DetectorLst.Add("DIED")
        DetectorLst.Add("DISASTER")
        DetectorLst.Add("FAMINE")
        DetectorLst.Add("FIRE")
        DetectorLst.Add("FLOOD")
        DetectorLst.Add("HURT BAD")
        DetectorLst.Add("ILL")
        DetectorLst.Add("ILLNESS")
        DetectorLst.Add("INJURY")
        DetectorLst.Add("LOSS OF YOUR")
        DetectorLst.Add("LOST YOUR")
        DetectorLst.Add("MOURN")
        DetectorLst.Add("SAD")
        DetectorLst.Add("SICK")
        DetectorLst.Add("TRAGEDY")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionSerious
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Serious"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Serious
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Serious")

        DetectorLst.Add(" CONCENTRAT")
        DetectorLst.Add(" REMEMBER")
        DetectorLst.Add(" SERIOUS")
        DetectorLst.Add(" SOBER ")
        DetectorLst.Add(" THOUGHTFUL")
        DetectorLst.Add(" MEDITAT")
        DetectorLst.Add(" COGITAT")
        DetectorLst.Add(" THINK HARD")
        DetectorLst.Add(" PONDER")
        DetectorLst.Add(" CONTEMPLAT")
        DetectorLst.Add(" SUFFER")
        DetectorLst.Add(" PROBLEM")
        DetectorLst.Add(" PUZZLE")
        DetectorLst.Add(" CONUNDRUM")
        DetectorLst.Add(" PARADOX")
        DetectorLst.Add(" PARADIGM")
        DetectorLst.Add(" SCHEMA")
        DetectorLst.Add(" ISSUE")
        DetectorLst.Add(" CONTROVERSY")
        DetectorLst.Add(" DISCUSS")
        DetectorLst.Add(" DEBATE")
        DetectorLst.Add(" QUESTION")
        DetectorLst.Add(" MY OPINION")
        DetectorLst.Add(" WHAT DO I THINK")
        DetectorLst.Add(" WHAT DO YOU THINK")
        DetectorLst.Add(" WHAT SHOULD WE DO")
        DetectorLst.Add(" WHAT ABOUT THE")
        DetectorLst.Add(" WHAT IS MY TAKE ON")
        DetectorLst.Add(" HOW SHOULD WE HANDLE")
        DetectorLst.Add(" HOW SHOULD BE DONE")
        DetectorLst.Add(" HOW SHOULD THEY DEAL")
        DetectorLst.Add(" HOW SHOULD WE DEAL")
        DetectorLst.Add(" HOW SHOULD THEY HANDLE")
        DetectorLst.Add(" HOW SHOULD WE HANDLE")
        DetectorLst.Add(" I AM SORRY ")
        DetectorLst.Add(" I AM SORRY ")
        DetectorLst.Add(" DIDN'T MEAN TO ")
        DetectorLst.Add(" I APOLOGIZ")
        DetectorLst.Add(" I APOLOGIZ")
        DetectorLst.Add(" YOU SINCERELY APOLOGIZE ")
        DetectorLst.Add(" DIDN'T MEAN IT ")
        DetectorLst.Add(" JUST KIDDING ")
        DetectorLst.Add(" FORGIVE")
        DetectorLst.Add(" A RESULT OF ")
        DetectorLst.Add(" ACCOMPLISHED BY ")
        DetectorLst.Add(" BECAUSE ")
        DetectorLst.Add(" CAUSE WAS ")
        DetectorLst.Add(" CAUSED BY ")
        DetectorLst.Add(" CREDIT RESTS WITH ")
        DetectorLst.Add(" CULPRIT WAS ")
        DetectorLst.Add(" CULPRITS WERE ")
        DetectorLst.Add(" DUE IN LARGE PART TO ")
        DetectorLst.Add(" DUE LARGELY TO ")
        DetectorLst.Add(" DUE IN NO SMALL PART TO ")
        DetectorLst.Add(" DUE IN PART TO ")
        DetectorLst.Add(" DUE TO ")
        DetectorLst.Add(" FAULT OF ")
        DetectorLst.Add(" FAULTS OF ")
        DetectorLst.Add(" MADE BY ")
        DetectorLst.Add(" OUTCOME OF")
        DetectorLst.Add(" ON ACCOUNT OF ")
        DetectorLst.Add(" PERPETRATED BY ")
        DetectorLst.Add(" PERPETRATOR WAS ")
        DetectorLst.Add(" PERPETRATORS WERE ")
        DetectorLst.Add(" REASON WAS ")
        DetectorLst.Add(" REASONS WERE ")
        DetectorLst.Add(" RESULTING FROM ")
        DetectorLst.Add(" RESULT OF ")
        DetectorLst.Add(" RESULTS OF ")
        DetectorLst.Add(" RESULT FROM ")
        DetectorLst.Add(" RESULTS FROM ")
        DetectorLst.Add(" THANKS TO ")
        DetectorLst.Add(" UNDERTAKEN BY ")
        DetectorLst.Add(" MAKER WAS ")
        DetectorLst.Add(" MAKERS WERE ")
        DetectorLst.Add(" SPEARHEADED BY ")
        DetectorLst.Add(" I HOPE YOU ")
        DetectorLst.Add(" I WANT YOU TO ")
        DetectorLst.Add(" I ARE ABOUT TO ")
        DetectorLst.Add(" I ARE GOING TO ")
        DetectorLst.Add(" I ARE OBLIGATED TO ")
        DetectorLst.Add(" I ARE REQUIRED TO ")
        DetectorLst.Add(" I DESIRE ")
        DetectorLst.Add(" I DREAM ")
        DetectorLst.Add(" I ENJOY ")
        DetectorLst.Add(" I EXPECT TO ")
        DetectorLst.Add(" I HAVE A DESIRE TO ")
        DetectorLst.Add(" I HAVE GOT TO ")
        DetectorLst.Add(" I HAVE TO ")
        DetectorLst.Add(" I HUNGER TO ")
        DetectorLst.Add(" I HOPE TO ")
        DetectorLst.Add(" I INTEND ")
        DetectorLst.Add(" I LIKE ")
        DetectorLst.Add(" I LOVE ")
        DetectorLst.Add(" I WOULD LIKE ")
        DetectorLst.Add(" I WOULD LOVE ")
        DetectorLst.Add(" I WOULD ENJOY ")
        DetectorLst.Add(" I MUST ")
        DetectorLst.Add(" I NEED ")
        DetectorLst.Add(" I PROMISE ")
        DetectorLst.Add(" I SHALL ")
        DetectorLst.Add(" I THIRST TO ")
        DetectorLst.Add(" I WANT ")
        DetectorLst.Add(" I WILL ")
        DetectorLst.Add(" I WOULD LIKE ")
        DetectorLst.Add(" I'D LIKE ")
        DetectorLst.Add(" I'D LOVE ")
        DetectorLst.Add(" I'D ENJOY ")
        DetectorLst.Add(" I AM ABOUT TO ")
        DetectorLst.Add(" I AM GOING TO ")
        DetectorLst.Add(" I AM OBLIGATED TO ")
        DetectorLst.Add(" I HAVE REQUIRED TO ")
        DetectorLst.Add(" I HAVE DESIRE TO ")
        DetectorLst.Add(" I HAVE A NEED TO ")
        DetectorLst.Add(" I HAVE GOT TO ")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionSleepy
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Sleepy"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Sleepy
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Sleepy")

        DetectorLst.Add("I BETTER GET SOME SLEEP")
        DetectorLst.Add("I'M HEADED FOR BED")
        DetectorLst.Add("I AM HEADED FOR BED")
        DetectorLst.Add("I AM SLEEPY")
        DetectorLst.Add("I'M VERY TIRED")
        DetectorLst.Add("I AM VERY SLEEPY")
        DetectorLst.Add("I'M EXTREMELY TIRED")
        DetectorLst.Add("I'M EXTREMELY SLEEPY")
        DetectorLst.Add("I WANT TO GO TO BED")
        DetectorLst.Add("I AM TO TIRED")
        DetectorLst.Add("I'M TO SLEEPY")
        DetectorLst.Add("I AM TO SLEEPY")
        DetectorLst.Add("I'M GONNA GET SOME REST")
        DetectorLst.Add("I HAVE TO REST")
        DetectorLst.Add("I NEED SLEEP")
        DetectorLst.Add("I NEED REST")
        DetectorLst.Add("I NEED SOME REST")
        DetectorLst.Add("I NEED TO GET SOME REST")
        DetectorLst.Add("GOOD NIGHT")
        DetectorLst.Add("I AM HEADED FOR BED")
        DetectorLst.Add("I'M HEADED FOR BED")
        DetectorLst.Add("I BETTER GET SOME SLEEP")
        DetectorLst.Add("I BETTER GET SOME REST")
        DetectorLst.Add("I'VE GOT TO GET SOME REST")
        DetectorLst.Add("I'M GONNA GET SOME REST")
        DetectorLst.Add("I HAVE TO REST")
        DetectorLst.Add("NIGHTY NIGHT")
        DetectorLst.Add("I NEED REST")
        DetectorLst.Add("I NEED SOME REST")
        DetectorLst.Add("I GOT TO GET SOME SLEEP")

    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class

Public Class EmotionSuprised
    Implements IEmotion

    Private DetectorLst As New List(Of String)

    Public ReadOnly Property Detectors As List(Of String) Implements IEmotion.Detectors
        Get
            Return DetectorLst
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IEmotion.Name
        Get
            Return "Suprised"
        End Get
    End Property

    Public ReadOnly Property Type As EmotionType Implements IEmotion.Type
        Get
            Return EmotionType.Surprised
        End Get
    End Property

    Public Sub New()
        AddDetectors()
    End Sub

    Private Sub AddDetectors()

        DetectorLst.Add("Suprised")
        DetectorLst.Add("FANTASTIC")
        DetectorLst.Add("GREAT")
        DetectorLst.Add("MAGNANIMOUS")
        DetectorLst.Add("INCREDIBLE")
        DetectorLst.Add("MAGNIFICENT")
        DetectorLst.Add("MARRIAGE PROPOSAL")
        DetectorLst.Add("REUNION")
        DetectorLst.Add("SURPRISE")
        DetectorLst.Add("TREMENDOUS")
        DetectorLst.Add("AMAZING")
        DetectorLst.Add("ENGAGEMENT")
        DetectorLst.Add("FANTASTIC")
        DetectorLst.Add("GREAT")
        DetectorLst.Add("INCREDIBLE")
        DetectorLst.Add("MAGNANIMOUS")
        DetectorLst.Add("MAGNIFICENT")
        DetectorLst.Add("MARRIAGE PROPOSAL")
        DetectorLst.Add("REUNION")
        DetectorLst.Add("SURPRISE")
        DetectorLst.Add("TREMENDOUS")
        DetectorLst.Add("AMAZING")
        DetectorLst.Add("ENGAGEMENT")
        DetectorLst.Add("FANTASTIC")
        DetectorLst.Add("GREAT")
        DetectorLst.Add("INCREDIBLE")
        DetectorLst.Add("WONDERFUL")
        DetectorLst.Add("WONDROUS")
        DetectorLst.Add("FABULOUS")
        DetectorLst.Add("TERRIFIC")
        DetectorLst.Add("MAGNANIMOUS")
        DetectorLst.Add("MAGNIFICENT")
        DetectorLst.Add("MARRIAGE PROPOSAL")
        DetectorLst.Add("REUNION")
        DetectorLst.Add("SURPRIS")
        DetectorLst.Add("TREMENDOUS")
        DetectorLst.Add("I LOVE YOU ")
        DetectorLst.Add("I AM IN LOVE WITH YOU ")
        DetectorLst.Add("I'AM IN LOVE WITH YOU ")
        DetectorLst.Add("I HAVE LOVE FOR YOU ")
        DetectorLst.Add("I'VE LOVE FOR YOU ")
        DetectorLst.Add("I FEEL LOVE FOR YOU ")
        DetectorLst.Add("I GIVE LOVE TO YOU ")
        DetectorLst.Add("I WANT TO LOVE YOU ")
        DetectorLst.Add("I DO LOVE YOU ")
        DetectorLst.Add("I CAN'T HELP BUT LOVE YOU ")
        DetectorLst.Add("I HAVE LOVE FOR YOU ")
    End Sub

    Public Sub AddDetector(ByRef Detector As String) Implements IEmotion.AddDetector
        DetectorLst.Add(UCase(Detector))
    End Sub

    Public Function Detect(ByRef UserInput As String) As Boolean Implements IEmotion.Detect
        Dim found As Boolean = False
        For Each Detector As String In Detectors
            If UCase(UserInput).Contains(UCase(Detector)) = True Then
                found = True
                Return found
            Else
            End If
        Next
        Return found
    End Function

End Class



