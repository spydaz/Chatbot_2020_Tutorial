Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports Microsoft.VisualBasic.ApplicationServices

Public Module StringExtensions
#Region "Freq"
    ''' <summary>
    ''' Used for WordFrequncys Function
    ''' </summary>
    Private Structure WordFrequecys
        Public frequency As Integer
        Public word As String
    End Structure
    ''' <summary>
    ''' Gets Token Frequecys for text
    ''' </summary>
    ''' <param name="_Text">To be searched</param>
    ''' <param name="Delimiter">Seperator</param>
    ''' <returns>WordFrequecies Word:Frequency (Object)</returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetWordFrequecys(ByVal _Text As String, ByVal Delimiter As String)
        Dim Words As New WordFrequecys
        Dim TempArray() As String = _Text.Split(Delimiter)
        Dim WordList As New List(Of String)
        Dim ListOfWordFrequecys As New List(Of WordFrequecys)
        For Each word As String In TempArray
            WordList.Add(word)
        Next
        Dim groups = WordList.GroupBy(Function(value) value)
        For Each grp In groups
            Words.word = grp(0)
            Words.frequency = grp.Count
            ListOfWordFrequecys.Add(Words)
        Next
        Return ListOfWordFrequecys
    End Function
#End Region
#Region "DATA"
    Public ReadOnly AlphaBet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
    "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
    "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Public ReadOnly CodePunctuation() As String = {"\", "#", "@", "^"}
    Public ReadOnly EncapuslationPunctuationEnd() As String = {"}", "]", ">", ")"}
    Public ReadOnly EncapuslationPunctuationStart() As String = {"{", "[", "<", "("}
    Public ReadOnly GramaticalPunctuation() As String = {".", "?", "!", ":", ";"}
    Public ReadOnly MathPunctuation() As String = {"+", "-", "=", "/", "*", "%", "PLUS", "ADD", "MINUS", "SUBTRACT", "DIVIDE", "DIFFERENCE", "TIMES", "MULTIPLY", "PERCENT", "EQUALS"}
    Public ReadOnly MoneyPunctuation() As String = {"£", "$"}
    Public ReadOnly Number() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
"30", "40", "50", "60", "70", "80", "90", "00", "000", "0000", "00000", "000000", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
"nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand", "million", "Billion"}
    ' these are the common word delimiters
    Public Delimiters() As Char = {CType(" ", Char), CType(".", Char),
                CType(",", Char), CType("?", Char),
                CType("!", Char), CType(";", Char),
                CType(":", Char), Chr(10), Chr(13), vbTab}
    Public ReadOnly SeperatorPunctuation() = {" ", ",", "|"}

    ''' <summary>
    ''' Recognized Tokens
    ''' </summary>
    Public Enum TokenType
        GramaticalPunctuation
        EncapuslationPunctuationStart
        EncapuslationPunctuationEnd
        MoneyPunctuation
        MathPunctuation
        CodePunctuation
        AlphaBet
        Number
        SeperatorPunctuation
        Ignore
    End Enum
#End Region
#Region "ListOfString"
    ''' <summary>
    ''' Returns a delimited string from the list.
    ''' </summary>
    ''' <param name="ls"></param>
    ''' <param name="delimiter"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function ToDelimitedString(ls As List(Of String), delimiter As String) As String
        Dim sb As New StringBuilder
        For Each buf As String In ls
            sb.Append(buf)
            sb.Append(delimiter)
        Next
        Return sb.ToString.Trim(CChar(delimiter))
    End Function
#End Region
#Region "Affix"
    ''' <summary>
    ''' Adds string to end of string (no spaces)
    ''' </summary>
    ''' <param name="Str">base string</param>
    ''' <param name="Prefix">Add before (no spaces)</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function AddPrefix(ByRef Str As String, ByVal Prefix As String) As String
        Return Prefix & Str
    End Function
    ''' <summary>
    ''' Adds Suffix to String (No Spaces)
    ''' </summary>
    ''' <param name="Str">Base string</param>
    ''' <param name="Suffix">To be added After</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function AddSuffix(ByRef Str As String, ByVal Suffix As String) As String
        Return Str & Suffix
    End Function
    ''' <summary>
    ''' Gets the string before the given string parameter.
    ''' </summary>
    ''' <param name="value">The default value.</param>
    ''' <param name="x">The given string parameter.</param>
    ''' <returns></returns>
    ''' <remarks>Unlike GetBetween and GetAfter, this does not Trim the result.</remarks>
    <System.Runtime.CompilerServices.Extension>
    Public Function GetBefore(value As String, x As String) As String
        Dim xPos = value.IndexOf(x, StringComparison.Ordinal)
        Return If(xPos = -1, [String].Empty, value.Substring(0, xPos))
    End Function
    ''' <summary>
    ''' Gets the string between the given string parameters.
    ''' </summary>
    ''' <param name="value">The source value.</param>
    ''' <param name="x">The left string sentinel.</param>
    ''' <param name="y">The right string sentinel</param>
    ''' <returns></returns>
    ''' <remarks>Unlike GetBefore, this method trims the result</remarks>
    <System.Runtime.CompilerServices.Extension>
    Public Function GetBetween(value As String, x As String, y As String) As String
        Dim xPos = value.IndexOf(x, StringComparison.Ordinal)
        Dim yPos = value.LastIndexOf(y, StringComparison.Ordinal)
        If xPos = -1 OrElse xPos = -1 Then
            Return [String].Empty
        End If
        Dim startIndex = xPos + x.Length
        Return If(startIndex >= yPos, [String].Empty, value.Substring(startIndex, yPos - startIndex).Trim())
    End Function
    ''' <summary>
    ''' Gets the string after the given string parameter.
    ''' </summary>
    ''' <param name="value">The default value.</param>
    ''' <param name="x">The given string parameter.</param>
    ''' <returns></returns>
    ''' <remarks>Unlike GetBefore, this method trims the result</remarks>
    <System.Runtime.CompilerServices.Extension>
    Public Function GetAfter(value As String, x As String) As String
        Dim xPos = value.LastIndexOf(x, StringComparison.Ordinal)
        If xPos = -1 Then
            Return [String].Empty
        End If
        Dim startIndex = xPos + x.Length
        Return If(startIndex >= value.Length, [String].Empty, value.Substring(startIndex).Trim())
    End Function
    ''' <summary>
    ''' Gets Words between StartStr And StopStr
    ''' </summary>
    ''' <param name="InputStr">Containing</param>
    ''' <param name="StartStr">StartLoc</param>
    ''' <param name="StopStr">Stop Loc</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function GetWordsBetween(ByRef InputStr As String, ByRef StartStr As String, ByRef StopStr As String)
        Return InputStr.ExtractStringBetween(StartStr, StopStr)
    End Function
    ''' <summary>
    ''' extracts string between defined strings
    ''' </summary>
    ''' <param name="value">base sgtring</param>
    ''' <param name="strStart">Start string</param>
    ''' <param name="strEnd">End string</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function ExtractStringBetween(ByVal value As String, ByVal strStart As String, ByVal strEnd As String) As String
        If Not String.IsNullOrEmpty(value) Then
            Dim i As Integer = value.IndexOf(strStart)
            Dim j As Integer = value.IndexOf(strEnd)
            Return value.Substring(i, j - i)
        Else
            Return value
        End If
    End Function
    ''' <summary>
    ''' gets the last word
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetSuffix(ByRef InputStr As String) As String
        Dim TempArr() As String = Split(InputStr, " ")
        Dim Count As Integer = TempArr.Count - 1
        Return TempArr(Count)
    End Function
    ''' <summary>
    ''' Returns the first Word
    ''' </summary>
    ''' <param name="Statement"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetPrefix(ByRef Statement As String) As String
        Dim StrArr() As String = Split(Statement, " ")
        Return StrArr(0)
    End Function
    ''' <summary>
    ''' Extract words Either side of Divider 
    ''' ie : Cat And Dog
    ''' </summary>
    ''' <param name="TextStr"></param>
    ''' <param name="Divider"></param>
    ''' <param name="Mode">Front = F Back =B</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function ExtractWordsEitherSide(ByRef TextStr As String, ByRef Divider As String, ByRef Mode As String) As String
        ExtractWordsEitherSide = ""
        Select Case Mode
            Case "F"
                Return ExtractWordsEitherSide(TextStr, Divider, "F")
            Case "B"
                Return ExtractWordsEitherSide(TextStr, Divider, "B")
        End Select

    End Function
    ''' <summary>
    ''' Returns first word in String
    ''' </summary>
    ''' <param name="Statement"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function ExtractFirstWord(ByRef Statement As String) As String
        Dim StrArr() As String = Split(Statement, " ")
        Return StrArr(0)
    End Function
    ''' <summary>
    ''' Gets last character from String
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function ExtractLastChar(ByRef InputStr As String) As String

        ExtractLastChar = Right(InputStr, 1)
    End Function
    ''' <summary>
    ''' Returns The last word in String
    ''' NOTE: String ois converted to Array then the last element is extracted Count-1
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <returns>String</returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function ExtractLastWord(ByRef InputStr As String) As String
        Dim TempArr() As String = Split(InputStr, " ")
        Dim Count As Integer = TempArr.Count - 1
        Return TempArr(Count)
    End Function

#End Region
#Region "Search"

    ''' <summary>
    ''' Advanced search String pattern Wildcard denotes which position 1st =1 or 2nd =2 Send
    ''' Original input &gt; Search pattern to be used &gt; Wildcard requred SPattern = "WHAT
    ''' COLOUR DO YOU LIKE * OR *" Textstr = "WHAT COLOUR DO YOU LIKE red OR black" ITEM_FOUND =
    ''' = SearchPattern(USERINPUT, SPattern, 1) ---- RETURNS RED ITEM_FOUND = =
    ''' SearchPattern(USERINPUT, SPattern, 1) ---- RETURNS black
    ''' </summary>
    ''' <param name="TextSTR">
    ''' TextStr Required. String.EG: "WHAT COLOUR DO YOU LIKE red OR black"
    ''' </param>
    ''' <param name="SPattern">
    ''' SPattern Required. String.EG: "WHAT COLOUR DO YOU LIKE * OR *"
    ''' </param>
    ''' <param name="Wildcard">Wildcard Required. Integer.EG: 1st =1 or 2nd =2</param>
    ''' <returns></returns>
    ''' <remarks>* in search pattern</remarks>
    <Runtime.CompilerServices.Extension()>
    Public Function SearchPattern(ByRef TextSTR As String, ByRef SPattern As String, ByRef Wildcard As Short) As String
        Dim SearchP2 As String
        Dim SearchP1 As String
        Dim TextStrp3 As String
        Dim TextStrp4 As String
        SearchPattern = ""
        SearchP2 = ""
        SearchP1 = ""
        TextStrp3 = ""
        TextStrp4 = ""
        If TextSTR Like SPattern = True Then
            Select Case Wildcard
                Case 1
                    Call SplitPhrase(SPattern, "*", SearchP1, SearchP2)
                    TextSTR = Replace(TextSTR, SearchP1, "", 1, -1, CompareMethod.Text)

                    SearchP2 = Replace(SearchP2, "*", "", 1, -1, CompareMethod.Text)
                    Call SplitPhrase(TextSTR, SearchP2, TextStrp3, TextStrp4)

                    TextSTR = TextStrp3

                Case 2
                    Call SplitPhrase(SPattern, "*", SearchP1, SearchP2)
                    SPattern = Replace(SPattern, SearchP1, " ", 1, -1, CompareMethod.Text)
                    TextSTR = Replace(TextSTR, SearchP1, " ", 1, -1, CompareMethod.Text)

                    Call SplitPhrase(SearchP2, "*", SearchP1, SearchP2)
                    Call SplitPhrase(TextSTR, SearchP1, TextStrp3, TextStrp4)

                    TextSTR = TextStrp4

            End Select

            SearchPattern = TextSTR
            LTrim(SearchPattern)
            RTrim(SearchPattern)
        Else
        End If

    End Function
    ''' <summary>
    ''' DETECT IF STATMENT IS AN IF/THEN DETECT IF STATMENT IS AN IF/THEN -- -RETURNS PARTS DETIFTHEN
    ''' = DETECTLOGIC(USERINPUT, "IF", "THEN", IFPART, THENPART)
    ''' </summary>
    ''' <param name="userinput"></param>
    ''' <param name="LOGICA">"IF", can also be replace by "IT CAN BE SAID THAT</param>
    ''' <param name="LOGICB">"THEN" can also be replaced by "it must follow that"</param>
    ''' <param name="IFPART">supply empty string to be used to hold part</param>
    ''' <param name="THENPART">supply empty string to be used to hold part</param>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function DetectLOGIC(ByRef userinput As String, ByRef LOGICA As String, ByRef LOGICB As String, ByRef IFPART As String, ByRef THENPART As String) As Boolean
        If InStr(1, userinput, LOGICA, 1) > 0 And InStr(1, userinput, " " & LOGICB & " ", 1) > 0 Then
            'SPLIT USER INPUT
            Call SplitPhrase(userinput, " " & LOGICB & " ", IFPART, THENPART)

            IFPART = Replace(IFPART, LOGICA, "", 1, -1, CompareMethod.Text)
            THENPART = Replace(THENPART, " " & LOGICB & " ", "", 1, -1, CompareMethod.Text)
            DetectLOGIC = True
        Else
            DetectLOGIC = False
        End If
    End Function
    ''' <summary>
    ''' Advanced search String pattern Wildcard denotes which position 1st =1 or 2nd =2 Send
    ''' Original input &gt; Search pattern to be used &gt; Wildcard requred SPattern = "WHAT
    ''' COLOUR DO YOU LIKE * OR *" Textstr = "WHAT COLOUR DO YOU LIKE red OR black" ITEM_FOUND =
    ''' = SearchPattern(USERINPUT, SPattern, 1) ---- RETURNS RED ITEM_FOUND = =
    ''' SearchPattern(USERINPUT, SPattern, 2) ---- RETURNS black
    ''' </summary>
    ''' <param name="TextSTR">TextStr = "Pick Red OR Blue" . String.</param>
    ''' <param name="SPattern">Search String = ("Pick * OR *") String.</param>
    ''' <param name="Wildcard">Wildcard Required. Integer. = 1= Red / 2= Blue</param>
    ''' <returns></returns>
    ''' <remarks>finds the * in search pattern</remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function SearchStringbyPattern(ByRef TextSTR As String, ByRef SPattern As String, ByRef Wildcard As Short) As String
        Dim SearchP2 As String
        Dim SearchP1 As String
        Dim TextStrp3 As String
        Dim TextStrp4 As String
        SearchStringbyPattern = ""
        SearchP2 = ""
        SearchP1 = ""
        TextStrp3 = ""
        TextStrp4 = ""
        If TextSTR Like SPattern = True Then
            Select Case Wildcard
                Case 1
                    Call SplitString(SPattern, "*", SearchP1, SearchP2)
                    TextSTR = Replace(TextSTR, SearchP1, "", 1, -1, CompareMethod.Text)

                    SearchP2 = Replace(SearchP2, "*", "", 1, -1, CompareMethod.Text)
                    Call SplitString(TextSTR, SearchP2, TextStrp3, TextStrp4)

                    TextSTR = TextStrp3

                Case 2
                    Call SplitString(SPattern, "*", SearchP1, SearchP2)
                    SPattern = Replace(SPattern, SearchP1, " ", 1, -1, CompareMethod.Text)
                    TextSTR = Replace(TextSTR, SearchP1, " ", 1, -1, CompareMethod.Text)

                    Call SplitString(SearchP2, "*", SearchP1, SearchP2)
                    Call SplitString(TextSTR, SearchP1, TextStrp3, TextStrp4)

                    TextSTR = TextStrp4

            End Select

            SearchStringbyPattern = TextSTR
            LTrim(SearchStringbyPattern)
            RTrim(SearchStringbyPattern)
        Else
        End If

    End Function
    ''' <summary>
    ''' Define the search terms. This list could also be dynamically populated at runtime Find
    ''' sentences that contain all the terms in the wordsToMatch array Note that the number of
    ''' terms to match is not specified at compile time
    ''' </summary>
    ''' <param name="TextStr1">String to be searched</param>
    ''' <param name="Words">List of Words to be detected</param>
    ''' <returns>Sentences containing words</returns>
    <Runtime.CompilerServices.Extension()>
    Public Function FindSentencesContaining(ByRef TextStr1 As String, ByRef Words As List(Of String)) As List(Of String)
        ' Split the text block into an array of sentences.
        Dim sentences As String() = TextStr1.Split(New Char() {".", "?", "!"})

        Dim wordsToMatch(Words.Count) As String
        Dim I As Integer = 0
        For Each item In Words
            wordsToMatch(I) = item
            I += 1
        Next

        Dim sentenceQuery = From sentence In sentences
                            Let w = sentence.Split(New Char() {" ", ",", ".", ";", ":"},
                                               StringSplitOptions.RemoveEmptyEntries)
                            Where w.Distinct().Intersect(wordsToMatch).Count = wordsToMatch.Count()
                            Select sentence

        ' Execute the query

        Dim StrList As New List(Of String)
        For Each str As String In sentenceQuery
            StrList.Add(str)
        Next
        Return StrList
    End Function
    ''' <summary>
    ''' checks Str contains keyword regardless of case
    ''' </summary>
    ''' <param name="Userinput"></param>
    ''' <param name="Keyword"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function DetectKeyWord(ByRef Userinput As String, ByRef Keyword As String) As Boolean
        Dim mfound As Boolean = False
        If UCase(Userinput).Contains(UCase(Keyword)) = True Or
                InStr(Userinput, Keyword) > 1 Then
            mfound = True
        End If

        Return mfound
    End Function

#End Region
#Region "Tokenizor"
    ''' <summary>
    ''' Returns Characters in String as list
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function Tokenizer(ByRef InputStr As String) As List(Of String)
        Tokenizer = New List(Of String)
        InputStr = GetValidTokens(InputStr)

        Dim Endstr As Integer = InputStr.Length
        For i = 0 To Endstr
            Tokenizer.Add(InputStr(i))
        Next
    End Function
    ''' <summary>
    ''' Return Tokens in string divided by seperator
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <param name="Divider"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function Tokenizer(ByRef InputStr As String, ByRef Divider As String) As List(Of String)
        Tokenizer = New List(Of String)
        InputStr = GetValidTokens(InputStr)
        Dim Tokens() As String = InputStr.Split(Divider)
        For Each item In Tokens
            Tokenizer.Add(item)
        Next
    End Function
    ''' <summary>
    ''' each charcter can be defined as a particular token enabling for removal of unwanted
    ''' token types
    ''' </summary>
    ''' <param name="CharStr"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetTokenType(ByRef CharStr As String) As TokenType
        For Each item In SeperatorPunctuation
            If CharStr = item Then Return TokenType.SeperatorPunctuation
        Next
        For Each item In GramaticalPunctuation
            If CharStr = item Then Return TokenType.GramaticalPunctuation
        Next
        For Each item In EncapuslationPunctuationStart
            If CharStr = item Then Return TokenType.EncapuslationPunctuationStart
        Next
        For Each item In EncapuslationPunctuationEnd
            If CharStr = item Then Return TokenType.EncapuslationPunctuationEnd
        Next
        For Each item In MoneyPunctuation
            If CharStr = item Then Return TokenType.MoneyPunctuation
        Next
        For Each item In MathPunctuation
            If CharStr = item Then Return TokenType.MathPunctuation
        Next
        For Each item In CodePunctuation
            If CharStr = item Then Return TokenType.CodePunctuation
        Next
        For Each item In AlphaBet
            If CharStr = item Then Return TokenType.AlphaBet
        Next
        For Each item In Number
            If CharStr = item Then Return TokenType.Number
        Next
        Return TokenType.Ignore
    End Function
    ''' <summary>
    ''' Returns valid tokens only tokens that are not defined are removed
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetValidTokens(ByRef InputStr As String) As String
        Dim EndStr As Integer = InputStr.Length
        Dim CharStr As String = ""
        For i = 0 To EndStr - 1
            If GetTokenType(InputStr(i)) <> TokenType.Ignore Then
                CharStr = CharStr.AddSuffix(InputStr(i))
            Else

            End If
        Next
        Return CharStr
    End Function
    ''' <summary>
    ''' Removes Tokens From String by Type
    ''' </summary>
    ''' <param name="UserStr">String</param>
    ''' <param name="nType">Token Type - removes All Tokens Defined by this type</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function RemoveTokenType(ByRef UserStr As String, ByRef nType As TokenType) As String

        Select Case nType
            Case TokenType.GramaticalPunctuation
                For Each item In GramaticalPunctuation
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.AlphaBet
                For Each item In AlphaBet
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.CodePunctuation
                For Each item In CodePunctuation
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.EncapuslationPunctuationEnd
                For Each item In EncapuslationPunctuationEnd
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.EncapuslationPunctuationStart
                For Each item In EncapuslationPunctuationStart
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.Ignore
            Case TokenType.MathPunctuation
                For Each item In MathPunctuation
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.MoneyPunctuation
                For Each item In MoneyPunctuation
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.Number
                For Each item In Number
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next
            Case TokenType.SeperatorPunctuation
                For Each item In SeperatorPunctuation
                    If UCase(UserStr).Contains(UCase(item)) = True Then
                        UserStr = UCase(UserStr).Remove(UCase(item))
                    End If
                Next

        End Select
        Return UserStr
    End Function
    <Runtime.CompilerServices.Extension()>
    Public Function AlphanumericOnly(ByRef Str As String) As String
        Str = Str.GetValidTokens
        Str = RemoveTokenType(Str, TokenType.CodePunctuation)
        Str = RemoveTokenType(Str, TokenType.EncapuslationPunctuationEnd)
        Str = RemoveTokenType(Str, TokenType.EncapuslationPunctuationStart)
        Str = RemoveTokenType(Str, TokenType.MathPunctuation)
        Str = RemoveTokenType(Str, TokenType.MoneyPunctuation)
        Str = RemoveTokenType(Str, TokenType.GramaticalPunctuation)
        Str = Str.Remove(",")
        Str = Str.Remove("|")
        Str = Str.Remove("_")
        Return Str
    End Function
#End Region
#Region "Split"
    ''' <summary>
    ''' SPLITS THE GIVEN PHRASE UP INTO TWO PARTS by dividing word SplitPhrase(Userinput, "and",
    ''' Firstp, SecondP)
    ''' </summary>
    ''' <param name="PHRASE">Sentence to be divided</param>
    ''' <param name="DIVIDINGWORD">String: Word to divide sentence by</param>
    ''' <param name="FIRSTPART">String: firstpart of sentence to be populated</param>
    ''' <param name="SECONDPART">String: Secondpart of sentence to be populated</param>
    ''' <remarks></remarks>
    <Runtime.CompilerServices.Extension()>
    Public Sub SplitPhrase(ByVal PHRASE As String, ByRef DIVIDINGWORD As String, ByRef FIRSTPART As String, ByRef SECONDPART As String)
        Dim POS As Short
        POS = InStr(PHRASE, DIVIDINGWORD)
        If (POS > 0) Then
            FIRSTPART = Trim(Left(PHRASE, POS - 1))
            SECONDPART = Trim(Right(PHRASE, Len(PHRASE) - POS - Len(DIVIDINGWORD) + 1))
        Else
            FIRSTPART = ""
            SECONDPART = PHRASE
        End If
    End Sub
    ''' <summary>
    ''' Split string to List of strings
    ''' </summary>
    ''' <param name="Str">base string</param>
    ''' <param name="Seperator">to be seperated by</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function SplitToList(ByRef Str As String, ByVal Seperator As String) As List(Of String)
        Dim lst As New List(Of String)
        If Str <> "" = True And Seperator <> "" Then

            Dim Found() As String = Str.Split(Seperator)
            For Each item In Found
                lst.Add(item)
            Next
        Else

        End If
        Return lst
    End Function
    ''' <summary>
    ''' SPLITS THE GIVEN PHRASE UP INTO TWO PARTS by dividing word SplitPhrase(Userinput, "and",
    ''' Firstp, SecondP)
    ''' </summary>
    ''' <param name="PHRASE">String: Sentence to be divided</param>
    ''' <param name="DIVIDINGWORD">String: Word to divide sentence by</param>
    ''' <param name="FIRSTPART">String-Returned : firstpart of sentence to be populated</param>
    ''' <param name="SECONDPART">String-Returned : Secondpart of sentence to be populated</param>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SplitString(ByVal PHRASE As String, ByRef DIVIDINGWORD As String, ByRef FIRSTPART As String, ByRef SECONDPART As String)
        Dim POS As Short
        'Check Error
        If DIVIDINGWORD IsNot Nothing And PHRASE IsNot Nothing Then

            POS = InStr(PHRASE, DIVIDINGWORD)
            If (POS > 0) Then
                FIRSTPART = Trim(Left(PHRASE, POS - 1))
                SECONDPART = Trim(Right(PHRASE, Len(PHRASE) - POS - Len(DIVIDINGWORD) + 1))
            Else
                FIRSTPART = ""
                SECONDPART = PHRASE
            End If
        Else

        End If
    End Sub
#End Region
#Region "Count"
    ''' <summary>
    ''' Counts the number of elements in the text, useful for declaring arrays when the element
    ''' length is unknown could be used to split sentence on full stop Find Sentences then again
    ''' on comma(conjunctions) "Find Clauses" NumberOfElements = CountElements(Userinput, delimiter)
    ''' </summary>
    ''' <param name="PHRASE"></param>
    ''' <param name="Delimiter"></param>
    ''' <returns>Integer : number of elements found</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function CountElements(ByVal PHRASE As String, ByVal Delimiter As String) As Integer
        Dim PhraseArray As String()
        PhraseArray = PHRASE.Split(Delimiter)
        Dim elementcounter As Integer = UBound(PhraseArray)
        Return elementcounter
    End Function

    ''' <summary>
    ''' counts occurrences of a specific phoneme
    ''' </summary>
    ''' <param name="strIn"></param>
    ''' <param name="strFind"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Runtime.CompilerServices.Extension()>
    Public Function CountOccurrences(ByRef strIn As String, ByRef strFind As String) As Integer
        '**
        ' Returns: the number of times a string appears in a string
        '
        '@rem           Example code for CountOccurrences()
        '
        '  ' Counts the occurrences of "ow" in the supplied string.
        '
        '    strTmp = "How now, brown cow"
        '    Returns a value of 4
        '
        '
        'Debug.Print "CountOccurrences(): there are " &  CountOccurrences(strTmp, "ow") &
        '" occurrences of 'ow'" &    " in the string '" & strTmp & "'"
        '
        '@param        strIn Required. String.
        '@param        strFind Required. String.
        '@return       Long.

        Dim lngPos As Integer
        Dim lngWordCount As Integer

        On Error GoTo PROC_ERR

        lngWordCount = 1

        ' Find the first occurrence
        lngPos = InStr(strIn, strFind)

        Do While lngPos > 0
            ' Find remaining occurrences
            lngPos = InStr(lngPos + 1, strIn, strFind)
            If lngPos > 0 Then
                ' Increment the hit counter
                lngWordCount += 1
            End If
        Loop

        ' Return the value
        CountOccurrences = lngWordCount

PROC_EXIT:
        Exit Function

PROC_ERR:
        MsgBox("Error: " & Err.Number & ". " & Err.Description, , NameOf(CountOccurrences))
        Resume PROC_EXIT

    End Function

    ''' <summary>
    ''' Counts the words in a given text
    ''' </summary>
    ''' <param name="NewText"></param>
    ''' <returns>integer: number of words</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function CountWords(NewText As String) As Integer
        Dim TempArray() As String = NewText.Split(" ")
        CountWords = UBound(TempArray)
        Return CountWords
    End Function

    ''' <summary>
    ''' Counts the vowels used (AEIOU)
    ''' </summary>
    ''' <param name="InputString"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Runtime.CompilerServices.Extension()>
    Public Function VowelCount(ByVal InputString As String) As Integer
        Dim v(9) As String 'Declare an array  of 10 elements 0 to 9
        Dim vcount As Short 'This variable will contain number of vowels
        Dim flag As Integer
        Dim strLen As Integer
        Dim i As Integer
        v(0) = "a" 'First element of array is assigned small a
        v(1) = "i"
        v(2) = "o"
        v(3) = "u"
        v(4) = "e"
        v(5) = "A" 'Sixth element is assigned Capital A
        v(6) = "I"
        v(7) = "O"
        v(8) = "U"
        v(9) = "E"
        strLen = Len(InputString)

        For flag = 1 To strLen 'It will get every letter of entered string and loop
            'will terminate when all letters have been examined

            For i = 0 To 9 'Takes every element of v(9) one by one
                'Check if current letter is a vowel
                If Mid(InputString, flag, 1) = v(i) Then
                    vcount += 1 ' If letter is equal to vowel
                    'then increment vcount by 1
                End If
            Next i 'Consider next value of v(i)
        Next flag 'Consider next letter of the enterd string

        VowelCount = vcount

    End Function
    ''' <summary>
    ''' Counts the vowels used (AEIOU)
    ''' </summary>
    ''' <param name="InputString"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Runtime.CompilerServices.Extension()>
    Public Function CountVowels(ByVal InputString As String) As Integer
        Dim v(9) As String 'Declare an array  of 10 elements 0 to 9
        Dim vcount As Short 'This variable will contain number of vowels
        Dim flag As Integer
        Dim strLen As Integer
        Dim i As Integer
        v(0) = "a" 'First element of array is assigned small a
        v(1) = "i"
        v(2) = "o"
        v(3) = "u"
        v(4) = "e"
        v(5) = "A" 'Sixth element is assigned Capital A
        v(6) = "I"
        v(7) = "O"
        v(8) = "U"
        v(9) = "E"
        strLen = Len(InputString)

        For flag = 1 To strLen 'It will get every letter of entered string and loop
            'will terminate when all letters have been examined

            For i = 0 To 9 'Takes every element of v(9) one by one
                'Check if current letter is a vowel
                If Mid(InputString, flag, 1) = v(i) Then
                    vcount += 1 ' If letter is equal to vowel
                    'then increment vcount by 1
                End If
            Next i 'Consider next value of v(i)
        Next flag 'Consider next letter of the enterd string

        CountVowels = vcount

    End Function
    ''' <summary>
    ''' Counts tokens in string
    ''' </summary>
    ''' <param name="Str">string to be searched</param>
    ''' <param name="Delimiter">delimiter such as space comma etc</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function CountTokensInString(ByRef Str As String, ByRef Delimiter As String) As Integer
        Dim Words() As String = Split(Str, Delimiter)
        Return Words.Count
    End Function
#End Region
#Region "Punctuation"
    ''' <summary>
    ''' Removes Pucutation and other erroronius marks from the text
    ''' </summary>
    ''' <param name="text">Text to be interogated</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function TotalMarkRemoval(ByVal text As String) As String
        Dim str As String() = {",", "@", "(", ")", "*", "{", "}", "[", "]", "-", "+", "=", "\", "/", "<", ">", "_", "|", "#", "~", ":", ";", ".", "?", "!", Chr(10), Chr(13)}
        For Each item In str
            text.Remove(item)
        Next
        Return text
    End Function
    ''' <summary>
    ''' Add full stop to end of String
    ''' </summary>
    ''' <param name="MESSAGE"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function AddFullStop(ByRef MESSAGE As String) As String
        AddFullStop = MESSAGE
        If MESSAGE = "" Then Exit Function
        MESSAGE = Trim(MESSAGE)
        If MESSAGE Like "*." Then Exit Function
        AddFullStop = MESSAGE + "."
    End Function
    <Runtime.CompilerServices.Extension()>
    Public Function Capitalise(ByRef MESSAGE As String) As String
        Dim FirstLetter As String
        Capitalise = ""
        If MESSAGE = "" Then Exit Function
        FirstLetter = Left(MESSAGE, 1)
        FirstLetter = UCase(FirstLetter)
        MESSAGE = Right(MESSAGE, Len(MESSAGE) - 1)
        Capitalise = (FirstLetter + MESSAGE)
    End Function
    ''' <summary>
    ''' Capitalise the first letter of each word / Tilte Case
    ''' </summary>
    ''' <param name="words">A string - paragraph or sentence</param>
    ''' <returns>String</returns>
    <Runtime.CompilerServices.Extension()>
    Public Function CapitalizeWords(ByVal words As String)
        Dim output As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim exploded = words.Split(" ")
        If (exploded IsNot Nothing) Then
            For Each word As String In exploded
                If word IsNot Nothing Then
                    output.Append(word.Substring(0, 1).ToUpper).Append(word.Substring(1, word.Length - 1)).Append(" ")
                End If

            Next
        End If

        Return output.ToString()

    End Function
    ''' <summary>
    ''' Returns Propercase Sentence
    ''' </summary>
    ''' <param name="TheString">String to be formatted</param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function ProperCase(ByRef TheString As String) As String
        ProperCase = UCase(Left(TheString, 1))

        For i = 2 To Len(TheString)

            ProperCase = If(Mid(TheString, i - 1, 1) = " ", ProperCase & UCase(Mid(TheString, i, 1)), ProperCase & LCase(Mid(TheString, i, 1)))
        Next i
    End Function
    ''' <summary>
    ''' Capitalizes the text
    ''' </summary>
    ''' <param name="MESSAGE"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function CapitaliseTEXT(ByVal MESSAGE As String) As String
        CapitaliseTEXT = ""
        If MESSAGE = "" Then Exit Function
        Dim FirstLetter As String = Left(MESSAGE, 1)
        FirstLetter = UCase(FirstLetter)
        MESSAGE = Right(MESSAGE, Len(MESSAGE) - 1)
        CapitaliseTEXT = (FirstLetter + LCase(MESSAGE))
    End Function
    ''' <summary>
    ''' GO THROUGH EACH CHARACTER AND ' IF PUNCTUATION IE .!?,:'"; REPLACE WITH A SPACE ' IF ,
    ''' OR . THEN CHECK IF BETWEEN TWO NUMBERS, IF IT IS ' THEN LEAVE IT, ELSE REPLACE IT WITH A
    ''' SPACE '
    ''' </summary>
    ''' <param name="STRINPUT">String to be formatted</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function OnlyAlphaNumerical(ByRef STRINPUT As String) As String

        Dim A As Short
        For A = 1 To Len(STRINPUT)
            If Mid(STRINPUT, A, 1) = "." Or
            Mid(STRINPUT, A, 1) = "!" Or
            Mid(STRINPUT, A, 1) = "?" Or
            Mid(STRINPUT, A, 1) = "," Or
            Mid(STRINPUT, A, 1) = ":" Or
            Mid(STRINPUT, A, 1) = "'" Or
            Mid(STRINPUT, A, 1) = "[" Or
            Mid(STRINPUT, A, 1) = """" Or
            Mid(STRINPUT, A, 1) = ";" Then

                ' BEGIN CHECKING PERIODS AND COMMAS THAT ARE IN BETWEEN NUMBERS '
                If Mid(STRINPUT, A, 1) = "." Or Mid(STRINPUT, A, 1) = "," Then
                    If Not (A - 1 = 0 Or A = Len(STRINPUT)) Then
                        If Not (IsNumeric(Mid(STRINPUT, A - 1, 1)) Or IsNumeric(Mid(STRINPUT, A + 1, 1))) Then
                            STRINPUT = Mid(STRINPUT, 1, A - 1) & " " & Mid(STRINPUT, A + 1, Len(STRINPUT) - A)
                        End If
                    Else
                        STRINPUT = Mid(STRINPUT, 1, A - 1) & " " & Mid(STRINPUT, A + 1, Len(STRINPUT) - A)
                    End If
                Else
                    STRINPUT = Mid(STRINPUT, 1, A - 1) & " " & Mid(STRINPUT, A + 1, Len(STRINPUT) - A)
                End If

                ' END CHECKING PERIODS AND COMMAS IN BETWEEN NUMBERS '
            End If
        Next A
        ' RETURN PUNCTUATION STRIPPED STRING '
        OnlyAlphaNumerical = STRINPUT.Replace("  ", " ")
    End Function
#End Region
#Region "Morse Code"
    ''' <summary>
    ''' Converts string of words to morse
    ''' </summary>
    ''' <param name="Str"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function StrFromMorse(ByRef Str As String) As String
        StrFromMorse = ""
        Str = GetValidTokens(Str)

        Str = RemoveTokenType(Str, TokenType.CodePunctuation)
        Str = RemoveTokenType(Str, TokenType.EncapuslationPunctuationEnd)
        Str = RemoveTokenType(Str, TokenType.EncapuslationPunctuationStart)
        Str = RemoveTokenType(Str, TokenType.MathPunctuation)
        Str = RemoveTokenType(Str, TokenType.MoneyPunctuation)

        Dim Conv As Boolean = False
        For Each item In AlphaBet
            If Str.Contains(item) = True Then
                Conv = True
            Else
            End If
        Next

        If Conv = True Then

            Dim Wrds As List(Of String) = Tokenizer(Str, " ")
            For Each word In Wrds
                StrFromMorse = StrFromMorse.AddSuffix(CharToMorse(word))

            Next
            StrFromMorse = RemoveTokenType(StrFromMorse, TokenType.AlphaBet)
            StrFromMorse = RemoveTokenType(StrFromMorse, TokenType.Number)
        Else
        End If
    End Function


    'Morse Code
    Public MorseCode() As String = {".", "-"}
    ''' <summary>
    ''' converts charactert to Morse code
    ''' </summary>
    ''' <param name="Ch"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function CharToMorse(ByRef Ch As String) As String
        Select Case Ch
            Case "A", "a"
                CharToMorse = ".-"
            Case "B", "b"
                CharToMorse = "-..."
            Case "C", "c"
                CharToMorse = "-.-."
            Case "D", "d"
                CharToMorse = "-.."
            Case "E", "e"
                CharToMorse = "."
            Case "F", "f"
                CharToMorse = "..-."
            Case "G", "g"
                CharToMorse = "--."
            Case "H", "h"
                CharToMorse = "...."
            Case "I", "i"
                CharToMorse = ".."
            Case "J", "j"
                CharToMorse = ".---"
            Case "K", "k"
                CharToMorse = "-.-"
            Case "L", "l"
                CharToMorse = ".-.."
            Case "M", "m"
                CharToMorse = "--"
            Case "N", "n"
                CharToMorse = "-."
            Case "O", "o"
                CharToMorse = "---"
            Case "P", "p"
                CharToMorse = ".--."
            Case "Q", "q"
                CharToMorse = "--.-"
            Case "R", "r"
                CharToMorse = ".-."
            Case "S", "s"
                CharToMorse = "..."
            Case "T", "t"
                CharToMorse = "-"
            Case "U", "u"
                CharToMorse = "..-"
            Case "V", "v"
                CharToMorse = "...-"
            Case "W", "w"
                CharToMorse = ".--"
            Case "X", "x"
                CharToMorse = "-..-"
            Case "Y", "y"
                CharToMorse = "-.--"
            Case "Z", "z"
                CharToMorse = "--.."
            Case "1"
                CharToMorse = ".----"
            Case "2"
                CharToMorse = "..---"
            Case "3"
                CharToMorse = "...--"
            Case "4"
                CharToMorse = "....-"
            Case "5"
                CharToMorse = "....."
            Case "6"
                CharToMorse = "-...."
            Case "7"
                CharToMorse = "--..."
            Case "8"
                CharToMorse = "---.."
            Case "9"
                CharToMorse = "----."
            Case "0"
                CharToMorse = "-----"
            Case " "
                CharToMorse = "   "
            Case "."
                CharToMorse = "^"
            Case "-"
                CharToMorse = "~"
            Case Else
                CharToMorse = Ch
        End Select
    End Function

    ''' <summary>
    ''' Converts Morse code Character to Alphabet
    ''' </summary>
    ''' <param name="Ch"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function MorseToChar(ByRef Ch As String) As String
        Select Case Ch
            Case ".-"
                MorseToChar = "a"
            Case "-..."
                MorseToChar = "b"
            Case "-.-."
                MorseToChar = "c"
            Case "-.."
                MorseToChar = "d"
            Case "."
                MorseToChar = "e"
            Case "..-."
                MorseToChar = "f"
            Case "--."
                MorseToChar = "g"
            Case "...."
                MorseToChar = "h"
            Case ".."
                MorseToChar = "i"
            Case ".---"
                MorseToChar = "j"
            Case "-.-"
                MorseToChar = "k"
            Case ".-.."
                MorseToChar = "l"
            Case "--"
                MorseToChar = "m"
            Case "-."
                MorseToChar = "n"
            Case "---"
                MorseToChar = "o"
            Case ".--."
                MorseToChar = "p"
            Case "--.-"
                MorseToChar = "q"
            Case ".-."
                MorseToChar = "r"
            Case "..."
                MorseToChar = "s"
            Case "-"
                MorseToChar = "t"
            Case "..-"
                MorseToChar = "u"
            Case "...-"
                MorseToChar = "v"
            Case ".--"
                MorseToChar = "w"
            Case "-..-"
                MorseToChar = "x"
            Case "-.--"
                MorseToChar = "y"
            Case "--.."
                MorseToChar = "z"
            Case ".----"
                MorseToChar = "1"
            Case "..---"
                MorseToChar = "2"
            Case "...--"
                MorseToChar = "3"
            Case "....-"
                MorseToChar = "4"
            Case "....."
                MorseToChar = "5"
            Case "-...."
                MorseToChar = "6"
            Case "--..."
                MorseToChar = "7"
            Case "---.."
                MorseToChar = "8"
            Case "----."
                MorseToChar = "9"
            Case "-----"
                MorseToChar = "0"
            Case "   "
                MorseToChar = " "
            Case "^"
                MorseToChar = "."
            Case "~"
                MorseToChar = "-"
            Case Else
                MorseToChar = Ch
        End Select
    End Function

#End Region
#Region "Utilitys"
    ''' <summary>
    ''' Returns random character from string given length of the string to choose from
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="Length"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetRndChar(ByVal Source As String, ByVal Length As Integer) As String
        Dim rnd As New Random
        If Source Is Nothing Then Throw New ArgumentNullException(NameOf(Source), "Must contain a string,")
        If Length <= 0 Then Throw New ArgumentException("Length must be a least one.", NameOf(Length))
        Dim s As String = ""
        Dim builder As New System.Text.StringBuilder()
        builder.Append(s)
        For i = 1 To Length
            builder.Append(Source(rnd.Next(0, Source.Length)))
        Next
        s = builder.ToString()
        Return s
    End Function

    ''' <summary>
    ''' Expand a string such as a field name by inserting a space ahead of each capitalized
    ''' letter (where none exists).
    ''' TheHotTub = The Hot Tub
    ''' </summary>
    ''' <param name="inputString"></param>
    ''' <returns>Expanded string</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function ExpandToWords(ByVal inputString As String) As String
        If inputString Is Nothing Then Return Nothing
        Dim charArray = inputString.ToCharArray
        Dim outStringBuilder As New System.Text.StringBuilder(inputString.Length + 10)
        For index = 0 To charArray.GetUpperBound(0)
            If Char.IsUpper(charArray(index)) Then
                'If previous character is also uppercase, don't expand as this may be an acronym.
                If (index > 0) AndAlso Char.IsUpper(charArray(index - 1)) Then
                    outStringBuilder.Append(charArray(index))
                Else
                    outStringBuilder.Append(String.Concat(" ", charArray(index)))
                End If
            Else
                outStringBuilder.Append(charArray(index))
            End If
        Next

        Return outStringBuilder.ToString.Replace("_", " ").Trim

    End Function

    ''' <summary>
    ''' Checks if String Contains Letters
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function ContainsLetters(ByVal str As String) As Boolean
        For i = 0 To str.Length - 1
            If Char.IsLetter(str.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Checks if string is a reserved VBscipt Keyword
    ''' </summary>
    ''' <param name="keyword"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Function IsReservedWord(ByVal keyword As String) As Boolean
        Dim IsReserved = False
        Select Case LCase(keyword)
            Case "and" : IsReserved = True
            Case "as" : IsReserved = True
            Case "boolean" : IsReserved = True
            Case "byref" : IsReserved = True
            Case "byte" : IsReserved = True
            Case "byval" : IsReserved = True
            Case "call" : IsReserved = True
            Case "case" : IsReserved = True
            Case "class" : IsReserved = True
            Case "const" : IsReserved = True
            Case "currency" : IsReserved = True
            Case "debug" : IsReserved = True
            Case "dim" : IsReserved = True
            Case "do" : IsReserved = True
            Case "double" : IsReserved = True
            Case "each" : IsReserved = True
            Case "else" : IsReserved = True
            Case "elseif" : IsReserved = True
            Case "empty" : IsReserved = True
            Case "end" : IsReserved = True
            Case "endif" : IsReserved = True
            Case "enum" : IsReserved = True
            Case "eqv" : IsReserved = True
            Case "event" : IsReserved = True
            Case "exit" : IsReserved = True
            Case "false" : IsReserved = True
            Case "for" : IsReserved = True
            Case "function" : IsReserved = True
            Case "get" : IsReserved = True
            Case "goto" : IsReserved = True
            Case "if" : IsReserved = True
            Case "imp" : IsReserved = True
            Case "implements" : IsReserved = True
            Case "in" : IsReserved = True
            Case "integer" : IsReserved = True
            Case "is" : IsReserved = True
            Case "let" : IsReserved = True
            Case "like" : IsReserved = True
            Case "long" : IsReserved = True
            Case "loop" : IsReserved = True
            Case "lset" : IsReserved = True
            Case "me" : IsReserved = True
            Case "mod" : IsReserved = True
            Case "new" : IsReserved = True
            Case "next" : IsReserved = True
            Case "not" : IsReserved = True
            Case "nothing" : IsReserved = True
            Case "null" : IsReserved = True
            Case "on" : IsReserved = True
            Case "option" : IsReserved = True
            Case "optional" : IsReserved = True
            Case "or" : IsReserved = True
            Case "paramarray" : IsReserved = True
            Case "preserve" : IsReserved = True
            Case "private" : IsReserved = True
            Case "public" : IsReserved = True
            Case "raiseevent" : IsReserved = True
            Case "redim" : IsReserved = True
            Case "rem" : IsReserved = True
            Case "resume" : IsReserved = True
            Case "rset" : IsReserved = True
            Case "select" : IsReserved = True
            Case "set" : IsReserved = True
            Case "shared" : IsReserved = True
            Case "single" : IsReserved = True
            Case "static" : IsReserved = True
            Case "stop" : IsReserved = True
            Case "sub" : IsReserved = True
            Case "then" : IsReserved = True
            Case "to" : IsReserved = True
            Case "true" : IsReserved = True
            Case "type" : IsReserved = True
            Case "typeof" : IsReserved = True
            Case "until" : IsReserved = True
            Case "variant" : IsReserved = True
            Case "wend" : IsReserved = True
            Case "while" : IsReserved = True
            Case "with" : IsReserved = True
            Case "xor" : IsReserved = True
        End Select
        Return IsReserved
    End Function

    'Phonetics
    ''' <summary>
    ''' returns phonetic character for Letter a=Alpha
    ''' </summary>
    ''' <param name="InputStr"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function Phonetic(ByRef InputStr As String) As String
        Phonetic = ""
        If UCase(InputStr) = "A" Then
            Phonetic = "Alpha"
        End If
        If UCase(InputStr) = "B" Then
            Phonetic = "Bravo"
        End If
        If UCase(InputStr) = "C" Then
            Phonetic = "Charlie"
        End If
        If UCase(InputStr) = "D" Then
            Phonetic = "Delta"
        End If
        If UCase(InputStr) = "E" Then
            Phonetic = "Echo"
        End If
        If UCase(InputStr) = "F" Then
            Phonetic = "Foxtrot"
        End If
        If UCase(InputStr) = "G" Then
            Phonetic = "Golf"
        End If
        If UCase(InputStr) = "H" Then
            Phonetic = "Hotel"
        End If
        If UCase(InputStr) = "I" Then
            Phonetic = "India"
        End If
        If UCase(InputStr) = "J" Then
            Phonetic = "Juliet"
        End If
        If UCase(InputStr) = "K" Then
            Phonetic = "Kilo"
        End If
        If UCase(InputStr) = "L" Then
            Phonetic = "Lima"
        End If
        If UCase(InputStr) = "M" Then
            Phonetic = "Mike"
        End If
        If UCase(InputStr) = "N" Then
            Phonetic = "November"
        End If
        If UCase(InputStr) = "O" Then
            Phonetic = "Oscar"
        End If
        If UCase(InputStr) = "P" Then
            Phonetic = "Papa"
        End If
        If UCase(InputStr) = "Q" Then
            Phonetic = "Quebec"
        End If
        If UCase(InputStr) = "R" Then
            Phonetic = "Romeo"
        End If
        If UCase(InputStr) = "S" Then
            Phonetic = "Sierra"
        End If
        If UCase(InputStr) = "T" Then
            Phonetic = "Tango"
        End If
        If UCase(InputStr) = "U" Then
            Phonetic = "Uniform"
        End If
        If UCase(InputStr) = "V" Then
            Phonetic = "Victor"
        End If
        If UCase(InputStr) = "W" Then
            Phonetic = "Whiskey"
        End If
        If UCase(InputStr) = "X" Then
            Phonetic = "X-Ray"
        End If
        If UCase(InputStr) = "Y" Then
            Phonetic = "Yankee"
        End If
        If UCase(InputStr) = "Z" Then
            Phonetic = "Zulu"
        End If
    End Function

#End Region
#Region "TermDocumentMatrix"
    ''' <summary>
    ''' Gets frequecy of term in String
    ''' </summary>
    ''' <param name="Token">Term to define</param>
    ''' <param name="InputStr">Document String</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetTokenFrequency(ByRef InputStr As String, ByRef Token As String) As Integer
        GetTokenFrequency = 0
        InputStr = GetValidTokens(InputStr)
        If InputStr.Contains(Token) = True Then
            For Each item In GetWordFrequecys(InputStr, " ")
                If item.word = Token Then
                    GetTokenFrequency = item.frequency
                End If
            Next
        End If
    End Function
    ''' <summary>
    ''' Frequecy of Term (TF)
    ''' </summary>
    ''' <param name="Document"></param>
    ''' <param name="Term"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function TermFrequency(ByRef Document As String, ByRef Term As String) As Double
        Return Term.GetTokenFrequency(Document)
    End Function
    ''' <summary>
    ''' Counts The number of Documents Containing String
    ''' </summary>
    ''' <param name="Term">To be defined</param>
    ''' <param name="Documents">List of Documents(strings)</param>
    ''' <returns>Number of documents containing term</returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function CountTermInStrings(ByRef Term As String, ByRef Documents As List(Of String)) As Integer
        Dim count As Integer = 0
        For Each item In Documents
            If item.Contains(Term) Then count += 1
        Next
        Return count
    End Function
    ''' <summary>
    ''' (IDF)
    ''' The inverse document frequency of the word across a set of documents. 
    ''' This means, how common or rare a word is in the entire document set. 
    ''' The closer it is to 0, the more common a word is.
    ''' </summary>
    ''' <param name="Term">To define</param>
    ''' <param name="Documents">listof douments/strings</param>
    ''' <returns>The closer it is to 0, the more common a word is.</returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function InverseDocumentFrequency(ByRef Term As String, ByRef Documents As List(Of String)) As Double
        'This metric can be calculated by,   calculating the logarithm of. ( total number of documents, / the number of documents that contain a word)
        Return Math.Log(Documents.Count / CountTermInStrings(Term, Documents))
    End Function
    ''' <summary>
    ''' TF-IDF (term frequency-inverse document frequency) is a statistical measure that evaluates how relevant a word is to a document in a collection of documents. 
    ''' TF-IDF for a word in a document is calculated by multiplying two different metrics:
    ''' The term frequency of a word in a document. * The inverse document frequency of the word across a set of documents. 
    ''' </summary>
    ''' <param name="Term">to be defined</param>
    ''' <param name="Document">Current Document</param>
    ''' <param name="Documents">Document Collection</param>
    ''' <returns></returns>
    Public Function TF_IDF(ByRef Term As String, ByRef Document As String, ByRef Documents As List(Of String)) As Double
        Dim TF = Term.TermFrequency(Document)
        Dim IDF = Term.InverseDocumentFrequency(Documents)
        Return TF * IDF
    End Function
#End Region
#Region "Ngrams"
    ''' <summary>
    ''' Ngrams are Words grouped in to sets, they can be as long as the senence permits
    ''' </summary>
    ''' <param name="Str">String to be aynalized</param>
    ''' <param name="Ngrams">Size of token component Group (Must be &gt; 0)</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetNgrms(ByRef Str As String, ByRef Ngrams As Integer) As List(Of String)
        Dim NgramArr() As String = Split(Str, " ")
        Dim Length As Integer = NgramArr.Count
        Dim lst As New List(Of String)

        If Length - Ngrams > 0 Then

            For i = 0 To Length - Ngrams
                Dim Str2 As String = ""
                Dim builder As New System.Text.StringBuilder()
                builder.Append(Str2)
                For j = 0 To Ngrams - 1
                    builder.Append(NgramArr(i + j) & " ")
                Next
                Str2 = builder.ToString()
                lst.Add(Str2)
            Next
        Else

        End If
        Return lst
    End Function
#End Region
#Region "JSON / Dataset Functions"
    ''' <summary>
    ''' Used To Hold Json Properties
    ''' </summary>
    Private Structure JsonColum
        ''' <summary>
        ''' FeildName
        ''' </summary>
        Public ColumName As String
        ''' <summary>
        ''' Value Held
        ''' </summary>
        Public Data As String
    End Structure
    ''' <summary>
    ''' deserialize object from Json
    ''' </summary>
    ''' <param name="Str">json</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function DeSerializeJson(ByRef Str As String) As Object
        Try
            Dim Converter As New JavaScriptSerializer
            Dim diag As Object = Converter.Deserialize(Of Object)(Str)

            Return diag
        Catch ex As Exception
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(ex.Message, "ERROR", Buttons)
        End Try
        Return Nothing
    End Function
    Private Function CreateDataSet(ByRef JSON_TEXT As String) As List(Of JsonColum)
        On Error Resume Next
        'Deserialize
        Dim JsonType As Object = DeSerializeJson(JSON_TEXT)
        Dim JsonDataset As New List(Of JsonColum)
        For Each item In JsonType

            'New Colum (Feild)
            Dim Col As New JsonColum

            If item.value.GetType().ToString = "System.String" = True Then
                'Save colum and data held
                Col.ColumName = item.key.ToString
                Col.Data = item.value.ToString
                'Update Json DataSet
                JsonDataset.Add(Col)
            Else
                'Dim temp As String = item.value.GetType().ToString
                If item.value.GetType().ToString = "System.Object[]" Then
                    'Get Sub Table
                    'Dim Count As Integer = 1
                    'For Each SubItem In item.value
                    '    Col.ColumName = item.key & " " & Count
                    '    Col.Data = SubItem.ToString

                    '    '        'Update Json DataSet
                    '    JsonDataset.Add(Col)
                    '    Count += 1
                    'Next
                    Dim Count As Integer = 1
                    For Each SubItem In item.value
                        For Each pair In SubItem
                            Col.ColumName = pair.Key & " " & Count
                            Col.Data = pair.Value

                            '        'Update Json DataSet
                            JsonDataset.Add(Col)



                        Next
                        Count += 1
                    Next

                Else
                End If
            End If

        Next
        Return JsonDataset
    End Function
    ''' <summary>
    ''' Attempts to Get Dataset from Json
    ''' </summary>
    ''' <param name="JSON_TEXT"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function JsonToDatset(ByRef JSON_TEXT As String) As DataSet

        'Deserialize
        Dim JsonType As Object = DeSerializeJson(JSON_TEXT)
        'Prepare Datasets
        Dim DS As New DataSet
        'GET COLUMN NAMES
        Dim JsonDataset As List(Of JsonColum) = CreateDataSet(JSON_TEXT)

        ''Create Table
        DS.Tables.Add("Json")
        'Create Feilds
        For Each item In JsonDataset
            'Add ColumName
            DS.Tables("Json").Columns.Add(item.ColumName)
        Next

        'Create Datarow
        Dim dsNewRow As DataRow
        'Set Row For Json Table
        dsNewRow = DS.Tables("Json").NewRow()
        'Insert Data from JsonDataSet
        For Each item In JsonDataset
            'AddColumn
            dsNewRow.Item(item.ColumName) = item.Data
        Next
        'Add Row
        DS.Tables("Json").Rows.Add(dsNewRow)
        Return DS
    End Function
    ''' <summary>
    ''' Converts Datatable to Json String
    ''' </summary>
    ''' <param name="DT"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function DataTableToJson(ByRef DT As DataTable) As String
        Dim dict As New Dictionary(Of String, Object)
        'Get Rows
        Dim arr(DT.Rows.Count) As Object
        For i As Integer = 0 To DT.Rows.Count - 1
            arr(i) = DT.Rows(i).ItemArray
        Next
        'Add Row to Dictionary
        dict.Add(DT.TableName, arr)
        'Create JSON
        Dim json As New JavaScriptSerializer
        Return json.Serialize(dict)
    End Function
    ''' <summary>
    ''' Converts data held in Datagridview to Datatable 
    ''' </summary>
    ''' <param name="DGV"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function DataGridToTable(ByRef DGV As DataGridView) As DataTable
        'Creating DataTable.
        Dim dt As New DataTable()
        '     Dim DGV As DataGridView = GetCurrentTabDataGridView(TabDocumentBrowser)
        'Adding the Columns.
        For Each column As DataGridViewColumn In DGV.Columns
            dt.Columns.Add(column.HeaderText, column.ValueType)
        Next

        'Adding the Rows.
        For Each row As DataGridViewRow In DGV.Rows
            dt.Rows.Add()
            For Each cell As DataGridViewCell In row.Cells
                dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
            Next
        Next
        Return dt
    End Function


#End Region
#Region "API Calls GET"
    ''' <summary>
    ''' Get function With Credentials
    ''' </summary>
    ''' <param name="URL">REQUEST STRING URL</param>
    ''' <param name="UserAgentID">BROWSER IDENTIFIER</param>
    ''' <param name="UserName"></param>
    ''' <param name="Password"></param>
    ''' <returns>string response</returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetAPIReq(ByRef URL As String, ByRef UserName As String, ByRef Password As String,
                              Optional UserAgentID As String = "SpydazWebAI") As String
        Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URL)
        Request.Proxy = Nothing
        Request.UserAgent = UserAgentID
        Request.Credentials = New NetworkCredential(UserName, Password)

        Dim Response As System.Net.HttpWebResponse = Request.GetResponse
        Dim ResponseStream As IO.Stream = Response.GetResponseStream

        Dim Streamreader As New System.IO.StreamReader(ResponseStream)
        Dim Data As String = Streamreader.ReadToEnd
        Streamreader.Close()

        Return Data
    End Function
    ''' <summary>
    ''' Gets request response from API
    ''' </summary>
    ''' <param name="URL">REQUEST STRING URL</param>
    ''' <param name="UserAgentID">BROWSER IDENTIFIER</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function GetAPIReq(ByRef URL As String, Optional UserAgentID As String = "SpydazWebAI") As String
        Dim Request As HttpWebRequest = HttpWebRequest.Create(URL)
        Request.Proxy = Nothing
        Request.UserAgent = UserAgentID

        Dim Response As HttpWebResponse = Request.GetResponse
        Dim ResponseStream As IO.Stream = Response.GetResponseStream

        Dim Streamreader As New System.IO.StreamReader(ResponseStream)
        Dim Data As String = Streamreader.ReadToEnd
        Streamreader.Close()

        Return Data
    End Function
#End Region
#Region "API calls POST"
    ''' <summary>
    ''' POST FUNCTION With Credentials
    ''' </summary>
    ''' <param name="URL">REQUEST STRING URL</param>
    ''' <param name="UserAgentID">BROWSER IDENTIFIER</param>
    ''' <param name="Data"></param>
    ''' <param name="Username"></param>
    ''' <param name="Password"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function PostAPIReq(ByRef URL As String, ByRef Data As String, ByRef Username As String, ByRef Password As String,
                               Optional UserAgentID As String = "SpydazWebAI") As String
        Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URL)
        Dim DataReturned As String
        Request.Proxy = Nothing
        Request.UserAgent = UserAgentID
        Request.Credentials = New NetworkCredential(Username, Password)
        Request.Method = "POST"
        Request.ContentType = "text/plain;charset=utf-8"
        Dim encoding As New System.Text.UTF8Encoding()
        Dim bytes As Byte() = encoding.GetBytes(Data)
        Request.ContentLength = bytes.Length
        Using requestStream As Stream = Request.GetRequestStream()
            ' Send the data.  
            requestStream.Write(bytes, 0, bytes.Length)
            Dim Response As System.Net.HttpWebResponse = Request.GetResponse()
            Dim ResponseStream As IO.Stream = Response.GetResponseStream
            Dim Streamreader As New System.IO.StreamReader(ResponseStream)
            DataReturned = Streamreader.ReadToEnd
            Streamreader.Close()
        End Using
        'GetResponse
        Return DataReturned
    End Function
    ''' <summary>
    ''' Post Function
    ''' </summary>
    ''' <param name="URL">REQUEST STRING URL</param>
    ''' <param name="UserAgentID">BROWSER IDENTIFIER</param>
    ''' <param name="Data">Post data in Json Form</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Public Function PostAPIReq(ByRef URL As String, ByRef Data As String, Optional UserAgentID As String = "SpydazWebAI") As String
        Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URL)
        Dim DataReturned As String
        Request.Proxy = Nothing
        Request.UserAgent = UserAgentID

        Request.Method = "POST"
        Request.ContentType = "text/plain;charset=utf-8"
        Dim encoding As New System.Text.UTF8Encoding()
        Dim bytes As Byte() = encoding.GetBytes(Data)
        Request.ContentLength = bytes.Length
        Using requestStream As Stream = Request.GetRequestStream()
            ' Send the data.  
            requestStream.Write(bytes, 0, bytes.Length)
            Dim Response As System.Net.HttpWebResponse = Request.GetResponse()
            Dim ResponseStream As IO.Stream = Response.GetResponseStream
            Dim Streamreader As New System.IO.StreamReader(ResponseStream)
            DataReturned = Streamreader.ReadToEnd
            Streamreader.Close()
        End Using
        'GetResponse
        Return DataReturned
    End Function
#End Region

End Module



