



''' <summary>
''' Plug-in contract enables for updates to be executed by this class
''' </summary>
''' <remarks></remarks>
Public Interface IPlugin

        ''' <summary>
        ''' Info Regarding plugin actions and response types
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property Info() As String

        ''' <summary>
        ''' Name of Plugin
        ''' </summary>
        ''' <returns></returns>
        ReadOnly Property PluginName() As String

        ''' <summary>
        ''' Previous response from AI
        ''' </summary>
        ''' <returns></returns>
        Property PreviousResponse As String

        ''' <summary>
        ''' Previous Userinput from User
        ''' </summary>
        ''' <returns></returns>
        Property PreviousUserinput As String

        ''' <summary>
        ''' Current response from Plugin
        ''' </summary>
        ''' <returns></returns>
        Property Response As String

        ''' <summary>
        ''' User Response Function
        ''' </summary>
        ''' <param name="UserInput"></param>
        ''' <returns></returns>
        Function GetResponse(ByVal UserInput As String) As Boolean

    End Interface

