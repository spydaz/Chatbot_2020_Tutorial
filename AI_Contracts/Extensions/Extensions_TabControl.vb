Imports System.IO
Imports System.Net
''' <summary>
''' Tab control Extensions 
''' Tab controllers provided here require Tabpages integer - This is the Current Count of Tabpages
''' </summary>
Public Module TabControl_Extensions
#Region "Text Tabs"
#Region "Text Tab Functions"
    ''' <summary>
    ''' Returns text held in current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <returns>text</returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetCurrentTabRichTextBox(ByRef Sender As TabControl) As RichTextBox
        If IsTextTab(Sender) = True Then
            Return CType(Sender.SelectedTab.Controls.Item("Body"), RichTextBox)
        Else
        End If
        Return Nothing
    End Function
#End Region

    ''' <summary>
    ''' Checks if tab is web or text
    ''' </summary>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function IsTextTab(ByRef Sender As TabControl) As Boolean
        If CType(Sender.SelectedTab.Controls.Item("Body"), RichTextBox) IsNot Nothing Then
            IsTextTab = True
        Else
            IsTextTab = False
        End If
    End Function

#Region "Add Text TAB"
    ''' <summary>
    ''' Adds new tab with data
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of pages</param>
    ''' <param name="Text">data</param>
    ''' <param name="Title">title</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddTextTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Text As String, ByRef Title As String)
        Dim Body As New RichTextBox With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill

        Body.Text = Text
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ForeColor = Color.MidnightBlue

        Dim DocumentText As String = Title & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        Sender.TabPages.Add(NewPage)
        NewPage.Text = "TextBox"
        Sender.SelectedTab = NewPage
    End Sub
    ''' <summary>
    ''' Adds a current new tab(document) (Empty)
    ''' </summary>
    ''' <param name="Sender">tab control</param>
    ''' <param name="Tabcount">tab count</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddTextTab(ByRef Sender As TabControl, ByRef Tabcount As Integer)
        Dim Body As New RichTextBox With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ForeColor = Color.MidnightBlue

        Dim DocumentText As String = "Document " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        Sender.TabPages.Add(NewPage)
        NewPage.Text = "TextBox"
        Sender.SelectedTab = NewPage
    End Sub
#End Region
#Region "SAVE TextFile"
    ''' <summary>
    ''' saves data in current tab to file
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Filename">filename</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SaveCurrentTextTab(ByRef Sender As TabControl, ByRef Filename As String)
        If IsTextTab(Sender) = True Then
            GetCurrentTabRichTextBox(Sender).SaveFile(Filename, RichTextBoxStreamType.RichText)
        Else
        End If
    End Sub
#End Region
#Region "OPEN TextFile"
    ''' <summary>
    ''' loads file data into current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Filename">data file</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub OpenFileInCurrent(ByRef Sender As TabControl, ByRef Filename As String)

        GetCurrentTabRichTextBox(Sender).LoadFile(Filename, RichTextBoxStreamType.PlainText)

    End Sub
    ''' <summary>
    ''' opens file in new tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of tabs</param>
    ''' <param name="Filename">file location</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub OpenFileInNewTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Filename As String)
        Dim Body As New RichTextBox With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Body.ForeColor = Color.MidnightBlue


        Dim NewPage As New TabPage()
        Tabcount += 1

        Dim DocumentText As String = "Document " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.LoadFile(Filename, RichTextBoxStreamType.PlainText)
        Sender.TabPages.Add(NewPage)
        NewPage.Text = "TextBox"
    End Sub
#End Region
#Region "TextBox Text Function"
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Bold(ByRef Sender As TabControl)
        Dim BoldFont As New Font(GetCurrentTabRichTextBox(Sender).SelectionFont.Name, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, FontStyle.Bold)
        Dim RegularFont As New Font(GetCurrentTabRichTextBox(Sender).SelectionFont.Name, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, FontStyle.Regular)

        GetCurrentTabRichTextBox(Sender).SelectionFont = If(GetCurrentTabRichTextBox(Sender).SelectionFont.Bold, RegularFont, BoldFont)

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Itallic(ByRef Sender As TabControl)
        Dim ItalicFont As New Font(GetCurrentTabRichTextBox(Sender).SelectionFont.Name, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, FontStyle.Italic)
        Dim RegularFont As New Font(GetCurrentTabRichTextBox(Sender).SelectionFont.Name, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, FontStyle.Regular)

        GetCurrentTabRichTextBox(Sender).SelectionFont = If(GetCurrentTabRichTextBox(Sender).SelectionFont.Italic, RegularFont, ItalicFont)
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub UnderLine(ByRef Sender As TabControl)
        Dim UnderlineFont As New Font(GetCurrentTabRichTextBox(Sender).SelectionFont.Name, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, FontStyle.Underline)
        Dim RegularFont As New Font(GetCurrentTabRichTextBox(Sender).SelectionFont.Name, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, FontStyle.Regular)

        GetCurrentTabRichTextBox(Sender).SelectionFont = If(GetCurrentTabRichTextBox(Sender).SelectionFont.Underline, RegularFont, UnderlineFont)
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub UpperCase(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).SelectedText = GetCurrentTabRichTextBox(Sender).SelectedText.ToUpper()
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub LowerCase(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).SelectedText = GetCurrentTabRichTextBox(Sender).SelectedText.ToLower()
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Undo(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).Undo()

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Redo(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).Redo()

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Cut(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).Cut()
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Copy(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).Copy()
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Paste(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).Paste()
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SelectAll(ByRef Sender As TabControl)
        GetCurrentTabRichTextBox(Sender).SelectAll()
    End Sub
#End Region
#End Region
#Region "ALL TABS"

#Region "Remove TABs"
    ''' <summary>
    ''' Closes all tabs
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of tabs</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub RemoveAllTabs(ByRef Sender As TabControl, ByRef Tabcount As Integer)

        For Each Page As TabPage In Sender.TabPages
            Sender.TabPages.Remove(Page)
        Next
        Tabcount = 0
        AddTextTab(Sender, Tabcount)
    End Sub
    ''' <summary>
    ''' removes all tabs except current
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="TabCount">number of tabs</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub RemoveAllTabsButThis(ByRef Sender As TabControl, ByRef TabCount As Integer)
        For Each Page As TabPage In Sender.TabPages
            If Not Page.Name = Sender.SelectedTab.Name Then
                Sender.TabPages.Remove(Page)
                TabCount = 0 + 1
            Else
            End If
        Next
    End Sub
#End Region
#Region "Save Tab"
    Public Sub SaveTab(ByRef Sender As TabControl)
        Dim alltext As String = ""
        Try
            If IsTextTab(Sender) = True Then
                Dim SwBrowser = GetCurrentTabRichTextBox(Sender)
                alltext = SwBrowser.Text
                Dim ScriptFile As String = ""
                Dim S As New SaveFileDialog
                With S
                    .Filter = "Enter Filename : (*.txt)|*.Txt"
                    If (.ShowDialog() = DialogResult.OK) Then
                        ScriptFile = .FileName
                    End If
                End With
                My.Computer.FileSystem.WriteAllText(ScriptFile, alltext, True)
            End If

            If IsWebTab(Sender) = True Then
                Dim SwBrowser = GetCurrentTabWebBrowser(Sender)
                alltext = SwBrowser.DocumentText
                Dim ScriptFile As String = ""
                Dim S As New SaveFileDialog
                With S
                    .Filter = "Enter Filename : (*.Html)|*.Html"
                    If (.ShowDialog() = DialogResult.OK) Then
                        ScriptFile = .FileName
                    End If
                End With
                My.Computer.FileSystem.WriteAllText(ScriptFile, alltext, True)



            End If

        Catch ex As Exception

        End Try


    End Sub
#End Region
#End Region
#Region "WebTabs"

#Region "WebTab Functions"
    ''' <summary>
    ''' Gets and displays search results on current tab
    ''' </summary>
    ''' <param name="Sender">Gets current Tab</param>
    ''' <param name="SearchTxt">Item to search</param>
    ''' <param name="Search">SearchTerm</param>
    Public Sub Search(ByRef Sender As TabControl, ByRef SearchTxt As String, ByRef Search As SearchEngine)
        Dim Engine = ""
        Dim SearchString As String = ""
        Dim SearchChoice As String = ""
        Select Case Search
            Case 1
                SearchChoice = SearchTextAol
                Engine = "AOL"
            Case = 2
                SearchChoice = SearchTextGoogle
                Engine = "Google"
            Case 3
                SearchChoice = SearchTextBing
                Engine = "Bing"
            Case = 4
                SearchChoice = Searchwikipedia
                Engine = "WikiPedia"
                SearchString = Searchwikipedia & SearchTxt & "&fulltext=Search"
            Case 5
                SearchChoice = SearchYoutube
                Engine = "YouTube"
            Case = 6
                SearchChoice = SearchGoogleMaps
                Engine = "GoogleMaps"
            Case = 7
                SearchChoice = SearchWolfram
                Engine = "WolframAlpha"
        End Select
        If Search = SearchEngine.Searchwikipedia = False Then
            SearchString = SearchChoice & SearchTxt
        Else
        End If

        Dim TITLE As String = Engine & ": " & SearchTxt
        Navigate(Sender, SearchString)


    End Sub
    ''' <summary>
    ''' Navigate Url - Navigates current WebTab
    ''' </summary>
    ''' <param name="Sender">Tabcontrol</param>
    ''' <param name="Text"></param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Navigate(ByRef Sender As TabControl, ByRef Text As String)
        Dim swbrowser As WebBrowser = GetCurrentTabWebBrowser(Sender)
        swbrowser.Navigate(Text)
    End Sub
    ''' <summary>
    ''' Returns text held in current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <returns>text</returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetCurrentTabWebBrowser(ByRef Sender As TabControl) As System.Windows.Forms.WebBrowser
        If IsWebTab(Sender) = True Then
            Return CType(Sender.SelectedTab.Controls.Item("Body"), System.Windows.Forms.WebBrowser)
        Else
        End If
        Return Nothing
    End Function
#End Region

    ''' <summary>
    ''' Checks if tab is web or text
    ''' </summary>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function IsWebTab(ByRef Sender As TabControl) As Boolean
        IsWebTab = False
        If Sender.SelectedTab.Text = "Browser" Then Return True
    End Function

#Region "Add WebTab"
    ''' <summary>
    ''' adds Webtab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <param name="Tabcount">number of pages</param>
    ''' <param name="Source">html source text</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddWebSourceTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Source As String)
        Dim Body As New System.Windows.Forms.WebBrowser With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Body.ScriptErrorsSuppressed = True
        SuppressScriptErrorsOnly(Body)
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.DocumentText = Source
        Body.Refresh()
        Dim DocumentText As String = "Web:" & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.Tag = TAB()
        NewPage.Text = "Browser"
        Sender.TabPages.Add(NewPage)
        Sender.SelectedTab = NewPage
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddWebTab(ByRef Sender As TabControl, ByRef Tabcount As Integer)
        Dim Body As New System.Windows.Forms.WebBrowser With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Body.ScriptErrorsSuppressed = True
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.GoHome()
        SuppressScriptErrorsOnly(Body)
        Dim DocumentText As String = "Web: " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.Tag = TAB()
        NewPage.Text = "Browser"
        Sender.TabPages.Add(NewPage)
        Sender.SelectedTab = NewPage

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddWebTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Url As String)
        Dim Body As New System.Windows.Forms.WebBrowser With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.ScriptErrorsSuppressed = True
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        SuppressScriptErrorsOnly(Body)
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.Navigate(Url)

        Dim DocumentText As String = "Web: " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.Tag = TAB()
        NewPage.Text = Url
        Sender.TabPages.Add(NewPage)
        Sender.SelectedTab = NewPage

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddWebTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Title As String, ByRef Url As String)
        Dim Body As New System.Windows.Forms.WebBrowser With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ScriptErrorsSuppressed = True
        Body.Navigate(Url)

        Dim DocumentText As String = "Web: " & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)
        Body.Tag = TAB()
        NewPage.Text = Title
        Sender.TabPages.Add(NewPage)
        Sender.SelectedTab = NewPage

    End Sub
#End Region
#Region "WebURL"
    Public VHF As String = "http://www.vrconsulting.it/vhf/"
    Public AIDreams As String = "http://aidreams.co.uk/"
    Public SpydazWeb As String = "http://www.spydazweb.co.uk/"
    Public Roslin As String = "http://source.roslyn.io/"
    Public GitHub As String = "https://github.com/"
    Public W3Schools As String = "https://www.w3schools.com/"
    Public MVA As String = "https://mva.microsoft.com/"
    Public SearchTextAol As String = "http://search.aol.co.uk/aol/search?s_chn=hp&enabled_terms=&s_it=aoluk-homePage50&q="
    Public SearchTextGoogle As String = "https://www.google.co.uk/webhp?sourceid=chrome-instant&ion=1&espv=2&es_th=1&ie=UTF-8#q="
    Public SearchTextBing As String = "http://www.bing.com/search?q=cat&go=Submit&qs=n&form=QBLH&pq="
    Public Searchwikipedia As String = "http://en.wikipedia.org/w/index.php?title=Special%3ASearch&profile=default&search="
    Public SearchYoutube As String = "https://www.youtube.com/results?search_query="
    Public SearchGoogleMaps As String = "https://www.google.co.uk/maps/place/"
    Public SearchWolfram As String = "http://www.wolframalpha.com/input/?"

    Enum SearchEngine
        SearchTextAol
        SearchTextGoogle
        SearchTextBing
        Searchwikipedia
        SearchYoutube
        SearchGoogleMaps
        SearchWolfram
    End Enum
#End Region
#Region "WebBrowser Events"

    ' Hides script errors without hiding other dialog boxes.
    Private Sub SuppressScriptErrorsOnly(ByVal browser As WebBrowser)

        ' Ensure that ScriptErrorsSuppressed is set to false.
        browser.ScriptErrorsSuppressed = False

        ' Handle DocumentCompleted to gain access to the Document object.
        AddHandler browser.DocumentCompleted,
        AddressOf Browser_DocumentCompleted

    End Sub
    Private Sub Browser_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)

        AddHandler CType(sender, WebBrowser).Document.Window.Error,
        AddressOf Window_Error

    End Sub
    Private Sub Window_Error(ByVal sender As Object,
    ByVal e As HtmlElementErrorEventArgs)

        ' Ignore the error and suppress the error dialog box. 
        e.Handled = True

    End Sub

#End Region
#Region "Web Download Functions"
    ''' <summary>
    ''' Grabs all hyperlinks Found on current Web Tab
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GrabLinks(Sender As TabControl) As List(Of String)
        Dim WebLinks As New List(Of String)
        Dim SwBrowser = GetCurrentTabWebBrowser(Sender)
        If SwBrowser IsNot Nothing Then

            Dim links = SwBrowser.Document.Links
            ' Dim images As HtmlElementCollection = SwBrowser.Document.Images

            For Each link As HtmlElement In links
                WebLinks.Add(link.GetAttribute("href").ToString)
                ' frmGrabber.Visible = False
            Next

        End If
        Return WebLinks
    End Function
    ''' <summary>
    ''' Grab Images Detected on Web tab
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GrabUrlImages(ByRef Sender As TabControl) As List(Of String)
        Dim SW_Browser = GetCurrentTabWebBrowser(Sender)
        'Dim links As HtmlElementCollection = SW_Browser.Document.Links
        Dim images As HtmlElementCollection = SW_Browser.Document.Images
        Dim LinkStr As New List(Of String)
        For Each link As HtmlElement In images
            LinkStr.Add(link.GetAttribute("img"))

        Next
        Return LinkStr
    End Function
    ''' <summary>
    ''' Saves image from given URL
    ''' </summary>
    ''' <param name="Url"></param>
    ''' <returns></returns>
    Public Function GetPicture(ByRef Url As String) As Image
        Using webClient = New WebClient()
            Dim image_stream As New MemoryStream(webClient.DownloadData(Url))
            Return Image.FromStream(image_stream)
        End Using
    End Function
    ''' <summary>
    ''' Gets Source Html Text From Current Web Tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetText(ByRef sender As TabControl) As String
        Dim SW_Browser = GetCurrentTabWebBrowser(sender)
        Return SW_Browser.Document.Body.InnerText
    End Function
    ''' <summary>
    ''' Downloads File from URL
    ''' </summary>
    ''' <param name="url"></param>
    ''' <param name="localFilePath"></param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub _DownloadFile(ByVal url As String,
                         ByVal localFilePath As String)

        Try
            If Not String.IsNullOrWhiteSpace(url) AndAlso
                Not String.IsNullOrWhiteSpace(localFilePath) Then

                Dim fi As New FileInfo(localFilePath)

                If fi.Exists Then
                    fi.Delete()
                End If

                Dim request As WebRequest = WebRequest.Create(url)

                Using response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
                    Using rStream As Stream = response.GetResponseStream
                        Using ms As New MemoryStream
                            rStream.CopyTo(ms)
                            Dim data As Byte() = ms.ToArray()
                            File.WriteAllBytes(fi.FullName, data)
                        End Using
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
                                          vbCrLf, ex.Message),
                                          "Exception Thrown",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning)

        End Try

    End Sub
    Public Sub DownloadFile(ByRef URl As String, ByRef filename As String)
        Using webClient = New WebClient()
            Dim bytes = webClient.DownloadData(URl) 'again variable here
            File.WriteAllBytes(filename, bytes) 'save to desktop or specialfolder.
        End Using
    End Sub
    ''' <summary>
    ''' Donloads Images from Tabcontrol
    ''' </summary>
    ''' <param name="FolderImages">Download Folder</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub DownloadImages(ByRef Sender As TabControl, ByRef FolderImages As String)
        Dim SW_Browser = GetCurrentTabWebBrowser(Sender)
        Dim wcObj As New System.Net.WebClient() 'Create New Web Client Object
        Dim hecImages As HtmlElementCollection = SW_Browser.Document.GetElementsByTagName("img") 'Browse Through HTML Tags
        Dim strWebTitle As String 'Web Page Title
        Dim strPath1 As String 'Folder Path
        Dim strPath2 As String 'Sub Folder Path
        Dim strPath3 As String 'Sub Folder Path
        strWebTitle = SW_Browser.DocumentTitle  'Obtain Web Page Title
        strPath1 = Application.StartupPath & "\" & "Downloads" 'Create Folder Named Web Page Title
        strPath2 = strPath1 & "\Images" 'Create Images Sub Folder
        strPath3 = strPath2 & "\" & FolderImages
        Dim diTitle As DirectoryInfo = Directory.CreateDirectory(strPath1)
        Dim diImages As DirectoryInfo = Directory.CreateDirectory(strPath2)
        Dim difiles As DirectoryInfo = Directory.CreateDirectory(strPath3)
        For i As Integer = 0 To hecImages.Count - 1 'Loop Through All IMG Elements Found

            'Download Image(s) To Specified Path

            wcObj.DownloadFile(hecImages(i).GetAttribute("src"), strPath3 & "\" & i.ToString() & ".jpg")
        Next

    End Sub
    ''' <summary>
    ''' Returns language code for language
    ''' </summary>
    ''' <param name="LanguageText"></param>
    ''' <returns></returns>
    Private Function Return_Language(LanguageText As String) As String

        Select Case LanguageText
            Case "Urdu"
                Return_Language = "ur"
            Case "Persian"
                Return_Language = "fa"
            Case "Arabic"
                Return_Language = "ar"
            Case "bulgarsk"
                Return_Language = "bg"
            Case "danish"
                Return_Language = "da"
            Case "English"
                Return_Language = "en"
            Case "finsk"
                Return_Language = "fi"
            Case "french"
                Return_Language = "fr"
            Case "greek"
                Return_Language = "el"
            Case "Hindi"
                Return_Language = "hi"
            Case "dutch"
                Return_Language = "nl"
            Case "italian"
                Return_Language = "it"
            Case "japansk"
                Return_Language = "ja"
            Case "kinisisk"
                Return_Language = "zh-CN"
            Case "koreansk"
                Return_Language = "ko" ' ----
            Case "norwegian"
                Return_Language = "no"
            Case "polish"
                Return_Language = "pl"
            Case "portuguese"
                Return_Language = "pt"
            Case "romanian"
                Return_Language = "ro"
            Case "russian"
                Return_Language = "ru"
            Case "spanish"
                Return_Language = "es"
            Case "swedish"
                Return_Language = "sv"
            Case "czech"
                Return_Language = "cs"
            Case "german"
                Return_Language = "de"
            Case Else
                Return_Language = "auto"
        End Select
    End Function
#End Region
#Region "Web SourceControl"
    ''' <summary>
    ''' Retruns Souce Code from Tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetHtmlSource(ByRef sender As TabControl) As String
        Dim _source As String = ""
        If IsWebTab(sender) = True Then
            Try
                Dim SwBrowser = GetCurrentTabWebBrowser(sender)
                _source = SwBrowser.DocumentText

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return _source
    End Function
    ''' <summary>
    ''' Opens Source File in Web Tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="Tabpages"></param>
    ''' <param name="_source"></param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub OpenHtmlSource(ByRef sender As TabControl, Tabpages As Integer, ByVal _source As String)
        AddWebTab(sender, Tabpages)
        Dim SwBrowser = GetCurrentTabWebBrowser(sender)
        SwBrowser.DocumentText = _source
    End Sub
    ''' <summary>
    ''' Saves Souce Code to File from Webtab
    ''' </summary>
    ''' <param name="Sender"></param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SaveSource(ByRef Sender As TabControl)
        Dim alltext As String = ""
        Try
            Try
                Dim SwBrowser = GetCurrentTabWebBrowser(Sender)
                alltext = SwBrowser.DocumentText
            Catch ex As Exception
                Dim SwBrowser = GetCurrentTabRichTextBox(Sender)
                alltext = SwBrowser.Text
            End Try

            Dim ScriptFile As String = ""
            Dim S As New SaveFileDialog
            With S
                .Filter = "Enter Filename : (*.txt)|*.txt"
                If (.ShowDialog() = DialogResult.OK) Then
                    ScriptFile = .FileName
                End If
            End With
            My.Computer.FileSystem.WriteAllText(ScriptFile, alltext, True)
        Catch ex As Exception

        End Try

    End Sub

#End Region
#End Region
#Region "Data Tabs"
#Region "Data Tab Functions"
    ''' <summary>
    ''' Returns text held in current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <returns>text</returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetCurrentTabDataGridView(ByRef Sender As TabControl) As DataGridView
        If IsDataTab(Sender) = True Then
            Return CType(Sender.SelectedTab.Controls.Item("Body"), DataGridView)
        Else
        End If
        Return Nothing
    End Function
    ''' <summary>
    ''' Returns text held in current tab
    ''' </summary>
    ''' <param name="Sender">tabcontrol</param>
    ''' <returns>text</returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function GetCurrentTabDataTable(ByRef Sender As TabControl) As DataTable
        Dim DGV As New DataGridView
        If IsDataTab(Sender) = True Then
            DGV = CType(Sender.SelectedTab.Controls.Item("Body"), DataGridView)
        Else
        End If
        If DGV IsNot Nothing Then
            Return Convert_DataGridToTable(DGV)
        End If
        Return Nothing
    End Function
    <System.Runtime.CompilerServices.Extension()>
    Public Function Convert_DataGridToTable(ByRef DGV As DataGridView) As DataTable
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

    ''' <summary>
    ''' Checks if tab is web or text or data
    ''' </summary>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension()>
    Public Function IsDataTab(ByRef Sender As TabControl) As Boolean
        IsDataTab = False
        If Sender.SelectedTab.Text = "Data" Then Return True
    End Function

#Region "ADD Data Tab"
    ''' <summary>
    ''' Adds a current new tab(document)
    ''' </summary>
    ''' <param name="Sender">tab control</param>
    ''' <param name="Tabcount">tab count</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddDataTab(ByRef Sender As TabControl, ByRef Tabcount As Integer)
        Dim Body As New DataGridView With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ForeColor = Color.MidnightBlue

        Dim DocumentText As String = "Data" & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        Sender.TabPages.Add(NewPage)
        NewPage.Text = "Data"
        Sender.SelectedTab = NewPage
    End Sub
    ''' <summary>
    ''' Adds a current new tab(document)
    ''' </summary>
    ''' <param name="Sender">tab control</param>
    ''' <param name="Tabcount">tab count</param>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub AddDataTab(ByRef Sender As TabControl, ByRef Tabcount As Integer, ByRef Data As Object)
        Dim Body As New DataGridView With {
            .Font = New Font(Sender.Font.Name, 12, FontStyle.Regular)
        }
        Body.Name = NameOf(Body)
        Body.Dock = DockStyle.Fill
        Dim NewPage As New TabPage()
        Tabcount += 1
        Body.ForeColor = Color.MidnightBlue
        Body.DataSource = Data
        Dim DocumentText As String = "Data" & Tabcount
        NewPage.Name = DocumentText
        NewPage.Text = DocumentText
        NewPage.Controls.Add(Body)

        Sender.TabPages.Add(NewPage)
        NewPage.Text = "Data"
        Sender.SelectedTab = NewPage
    End Sub
#End Region
#End Region
End Module
