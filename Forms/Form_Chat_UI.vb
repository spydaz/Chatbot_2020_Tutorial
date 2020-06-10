Imports System.IO
Imports System.speech

''' <summary>
''' This is the Main Communications Center
''' </summary>
Public Class Form_Chat_UI
    Private Speechout As New Speech.Synthesis.SpeechSynthesizer
    Public Newpoint As New Point

    'Methods for form positioning
    Public x, y As Integer

    Private mInputText As String = ""

    Private mloaded As Boolean = False

    Public Event TEXTRECIEVED(ByVal Text As String)

    Public ReadOnly Property Loaded As Boolean
        Get
            Return mloaded
        End Get
    End Property

    Public ReadOnly Property RecievedText As String
        Get
            Return mInputText
        End Get

    End Property
    Public Sub EffectActuators(ByRef Text As String)
        If Loaded = True Then

            Speechout.Speak(Text)
        End If

    End Sub
    Public Sub DISPLAYOUTPUT(ByRef NewText As String)
        EffectActuators(NewText)
        TextOut.Text += "User: " & mInputText & vbNewLine & "AI: " & NewText & vbNewLine
    End Sub

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        mInputText = TextIn.Text
        TextIn.Text = ""
        RaiseEvent TEXTRECIEVED(mInputText)
    End Sub

    Private Sub Form_Chat_UI_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mloaded = False
    End Sub

    Private Sub Form_Chat_UI_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Close()
    End Sub

    Private Sub Form_Chat_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Height = 50
        mloaded = True
        Me.Height = 383
        Me.Width = 907
    End Sub

    Private Sub FrmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ' Form movement set integers
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub FrmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ' Form movement movement
        If e.Button = MouseButtons.Left Then
            Newpoint = Control.MousePosition
            Newpoint.X -= (x)
            Newpoint.Y -= (y)
            Me.Location = Newpoint
        End If
    End Sub
    Dim MindQA As New FormMind_QA

    Private Sub ButtonMindQA_Click(sender As Object, e As EventArgs) Handles ButtonMindQA.Click
        MindQA.Show()
    End Sub
    Dim QAMind As New FormQA_Mind
    Private Sub ButtonQA_Mind_Click(sender As Object, e As EventArgs) Handles ButtonQA_Mind.Click
        QAMind.Show()
    End Sub
    Dim PM As New FormPluginManager
    Private Sub ButtonCreatePlugin_Click(sender As Object, e As EventArgs) Handles ButtonCreatePlugin.Click
        PM.Show()
    End Sub

    Private Sub GroupBox2_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox2.DoubleClick
        GroupBox2.Height = If(GroupBox2.Height <> 20, 20, 50)
    End Sub

End Class