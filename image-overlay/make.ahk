
#NoEnv
SendMode Input
SetWorkingDir %A_ScriptDir%

f1::
Gui Add, Edit, w930 r1 vLocalpath, C:\
Gui Add, Button, x+6 yp w44 Default, Go
Gui Add, ActiveX, xm w980 h640 vWB, Shell.Explorer
ComObjConnect(WB, WB_events)  ; Connect WB's events to the WB_events class object.
Gui Show
; Continue on to load the initial page:
ButtonGo:
Gui Submit, NoHide
WB.Navigate(Localpath)
return

class WB_events
{
    NavigateComplete2(wb, NewLocalpath)
    {
        GuiControl,, Localpath, %NewLocalpath%  ; Update the Localpath edit control.
    }
}

GuiClose:
ExitApp