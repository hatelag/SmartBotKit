﻿
#Region " Option Statements "

Option Strict On
Option Explicit On
Option Infer Off

#End Region

#Region " Windows Messages "

Namespace SmartBotKit.Interop.Win32

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' The system sends or posts a system-defined message when it communicates with an application. 
    ''' <para></para>
    ''' It uses these messages to control the operations of applications and to provide input and other information for applications to process. 
    ''' <para></para>
    ''' An application can also send or post system-defined messages.
    ''' <para></para>
    ''' Applications generally use these messages to control the operation of control windows created by using preregistered window classes.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <remarks>
    ''' <see href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms644927%28v=vs.85%29.aspx"/>
    ''' </remarks>
    ''' ----------------------------------------------------------------------------------------------------
    Public Enum WindowsMessages As Integer

        ' *****************************************************************************
        '                            WARNING!, NEED TO KNOW...
        '
        '  THIS ENUMERATION IS PARTIALLY DEFINED TO MEET THE PURPOSES OF THIS API
        ' *****************************************************************************

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The <see cref="Null"/> message performs no operation.
        ''' <para></para>
        ''' An application sends the <see cref="Null"/> message if it wants to 
        ''' post a message that the recipient window will ignore.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Null = &H0

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Posted when the user presses a hot key registered by the <see cref="NativeMethods.RegisterHotKey"/> function. 
        ''' <para></para>
        ''' The message is placed at the top of the message queue associated with the thread that registered the hot key.
        ''' <para></para>
        ''' 
        ''' <c>wParam</c> 
        ''' The identifier of the hot key that generated the message.
        ''' If the message was generated by a system-defined hot key.
        ''' <para></para>
        ''' 
        ''' <c>lParam</c> 
        ''' The low-order word specifies the keys that were to be pressed in 
        ''' combination with the key specified by the high-order word to generate the 
        ''' <see cref="WindowsMessages.WM_Hotkey"/> message.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms646279%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        WM_Hotkey = &H312

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Instructs a window to provide a static bitmap to use as a thumbnail representation of that window.
        ''' <para></para>
        ''' Desktop Window Manager (DWM) sends this message to a window if all of the following situations are true: 
        ''' <para></para>
        ''' <c>DWM</c> is displaying an iconic representation of the window.
        ''' <para></para>
        ''' The <see cref="DwmWindowAttribute.HasIconicBitmap"/> and <see cref="DwmWindowAttribute.ForceIconicRepresentation"/> attributes are set on the window.
        ''' <para></para>
        ''' The window did not set a cached bitmap.
        ''' <para></para>
        ''' There is room in the cache for another bitmap.
        ''' <para></para>
        ''' 
        ''' <c>wParam</c> 
        ''' Not used. 
        ''' <para></para>
        ''' 
        ''' <c>lParam</c> 
        ''' The <c>HIWORD</c> of this value is the maximum possible width of the thumbnail.
        ''' <para></para>
        ''' The <c>LOWORD</c> is the maximum possible height.
        ''' <para></para>
        ''' If a thumbnail has a dimension that exceeds one or both of these values, 
        ''' the <c>DWM</c> does not accept the thumbnail.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/dd938875%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        WM_DwmSendIconicThumbnail = &H323

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Instructs a window to provide a static bitmap to use as a live preview (also known as a <c>Peek preview</c>) 
        ''' of that window.
        ''' <para></para>
        ''' Desktop Window Manager (DWM) sends this message to a window if all of the following situations are true: 
        ''' <para></para>
        ''' Live preview has been invoked on the window
        ''' <para></para>
        ''' The <see cref="DwmWindowAttribute.HasIconicBitmap"/> and <see cref="DwmWindowAttribute.ForceIconicRepresentation"/> attributes are set on the window.
        ''' <para></para>
        ''' An iconic representation is the only one that exists for this window.
        ''' <para></para>
        ''' 
        ''' <c>wParam</c> 
        ''' Not used. 
        ''' <para></para>
        ''' 
        ''' <c>lParam</c> 
        ''' Not used.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <remarks>
        ''' <see href="https://msdn.microsoft.com/en-us/library/windows/desktop/dd938874%28v=vs.85%29.aspx"/>
        ''' </remarks>
        ''' ----------------------------------------------------------------------------------------------------
        WM_DwmSendIconicLivePreviewBitmap = &H326

    End Enum

End Namespace

#End Region
