
'
'
'      _                      _____               _                _  _              
'     | |                    / ____|             | |              | || |             
'   __| | _ __  ___   _ __  | |      ___   _ __  | |_  _ __  ___  | || |  ___  _ __    
'  / _` || '__|/ _ \ | '_ \ | |     / _ \ | '_ \ | __|| '__|/ _ \ | || | / _ \| '__|   
' | (_| || |  | (_) || |_) || |____| (_) || | | || |_ | |  | (_) || || ||  __/| |     
'  \__,_||_|   \___/ | .__/  \_____|\___/ |_| |_| \__||_|   \___/ |_||_| \___||_|        
'                    | |                                                                               
'                    |_|                                                                               
'
' 
'
' 2019-12-01 - 2019_006_001 Build 0.0.0.1
' changed loop mode wait time to seconds 1-99
' disabled the maximize button
' added a forum link to the Help menu
'
' 2019-04-20 - 2019_005 Build 0.0.0.1
' Added FT3
' dropController V3 requires firmare 2019_V3_005_01 or higher
'
' 2019-02-06 - 2019_004 Build 0.0.0.1
' First release combined app.  Now compatible with V2 and V3 devices (need firmware update on device)
'
'

'
'
' Reminders
' Set version in AssemblyInfo.vb file
' 





Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Reflection
Imports System.Drawing
Imports System.Text



Public Class mainForm

    Dim versionNumber As Version
    Dim versionString As String = ""

    Dim numOfValves As Integer = 6

    Dim comPORT As String
    Dim receivedData As String = ""


    Dim greyedOut As Color = Me.BackColor


    ' arrays to hold the various objects/elements
    Dim RowLabels As Label() = New Label() {}
    Dim SolCBs As ComboBox() = New ComboBox() {}
    Dim StartTimes As TextBox() = New TextBox() {}
    Dim StartIncDecBtns As Button() = New Button() {}
    Dim StartIncDecVals As TextBox() = New TextBox() {}
    Dim Sizes As TextBox() = New TextBox() {}
    Dim SizeIncDecBtns As Button() = New Button() {}
    Dim SizeIncDecVals As TextBox() = New TextBox() {}


    'Loop Mode
    Dim sequenceAborted As Boolean = False





    ' debug
    Dim DEBUG_MASTER As Boolean = False
    Dim displayDebugButton As Boolean = False
    Dim useDebugLogFile As Boolean = False
    Dim widthDebug As Integer = 1110
    Dim widthNormal As Integer = 844




    ' __  __
    '|  \/  |                    
    '| \  / |  ___  _ __   _   _ 
    '| |\/| | / _ \| '_ \ | | | |
    '| |  | ||  __/| | | || |_| |
    '|_|  |_| \___||_| |_| \__,_|
    '

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub OnlineHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineHelpToolStripMenuItem.Click
        Try
            Process.Start("https://www.dropcontroller.com")
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Process.Start("https://www.dropcontroller.com/forums/")
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub










    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        debug("Close X selected")
        closeProgram()
    End Sub

    Private Sub exitButton_BTN_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        debug("Menu Exit selected")
        Me.Close()
    End Sub










    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False



        If (DEBUG_MASTER = False) Then
            Me.Width = widthNormal
            displayDebugButton = False
            useDebugLogFile = False
        End If

        ' SET_DEBUG_BTN



        If (useDebugLogFile) Then
            openDebugLogFile()
        End If
        debug(vbCrLf & "Program start" & vbCrLf)


        ' Lazy programing. I do not use element(0) in arrays. 

        ' copy the object reference in to the arrays
        RowLabels = {D1Row_LBL, D1Row_LBL, D2Row_LBL, D3Row_LBL, D4Row_LBL, D5Row_LBL, D6Row_LBL, D7Row_LBL, D8Row_LBL, D9Row_LBL}
        SolCBs = {D1Sol_CB, D1Sol_CB, D2Sol_CB, D3Sol_CB, D4Sol_CB, D5Sol_CB, D6Sol_CB, D7Sol_CB, D8Sol_CB, D9Sol_CB}
        StartTimes = {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        StartIncDecBtns = {D1StartIncDec_BTN, D1StartIncDec_BTN, D2StartIncDec_BTN, D3StartIncDec_BTN, D4StartIncDec_BTN, D5StartIncDec_BTN, D6StartIncDec_BTN, D7StartIncDec_BTN, D8StartIncDec_BTN, D9StartIncDec_BTN}
        StartIncDecVals = {D1StartIncVal_TB, D1StartIncVal_TB, D2StartIncVal_TB, D3StartIncVal_TB, D4StartIncVal_TB, D5StartIncVal_TB, D6StartIncVal_TB, D7StartIncVal_TB, D8StartIncVal_TB, D9StartIncVal_TB}
        Sizes = {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}
        SizeIncDecBtns = {D1SizeIncDec_BTN, D1SizeIncDec_BTN, D2SizeIncDec_BTN, D3SizeIncDec_BTN, D4SizeIncDec_BTN, D5SizeIncDec_BTN, D6SizeIncDec_BTN, D7SizeIncDec_BTN, D8SizeIncDec_BTN, D9SizeIncDec_BTN}
        SizeIncDecVals = {D1SizeIncVal_TB, D1SizeIncVal_TB, D2SizeIncVal_TB, D3SizeIncVal_TB, D4SizeIncVal_TB, D5SizeIncVal_TB, D6SizeIncVal_TB, D7SizeIncVal_TB, D8SizeIncVal_TB, D9SizeIncVal_TB}

        ' set device version 3 as the default. Only used if there are no data files
        If Version_ComboBox.Items.Count > 0 Then
            Version_ComboBox.SelectedIndex = 1    ' The first item has index 0 '
        End If


        ' hide the loopPage
        Me.Height = 600

        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        '  versionString = "dropController build " & versionNumber.ToString()
        Me.Text = "dropController"


        ' About page
        About05_LBL.Text = "App version " & versionNumber.ToString() & vbCrLf
        About05_LBL.Text = About05_LBL.Text + vbCrLf & "Compatible with:" & vbCrLf & "- device V2 with sketch 2019_V2_001 or higher." & vbCrLf & "- device V3 with sketch 2019_V3_005_01 or higher."


        GroupBox1.Visible = False
        GroupBox1.Location = New Point(12, 40)
        GroupBox1.BringToFront()

        TestConnection_BTN.Enabled = False

        loadSettings()


        ' Open the debug panel
        If (SET_DEBUG_BTN.Text = "ON") Then
            turnDebugOn()
        Else
            turnDebugOff()
        End If


        loadDropData()

        If (Version_ComboBox.Text = "2") Then
            FT2_BUTTON.Text = "OFF"
            FT3_BUTTON.Text = "OFF"
        End If

        updateRows()
        updateLoopElements()

        If (displayDebugButton) Then
            SET_DEBUG_LBL.Visible = True
            SET_DEBUG_BTN.Visible = True
        Else
            SET_DEBUG_LBL.Visible = False
            SET_DEBUG_BTN.Visible = False
        End If


        startBTNoff()
        populateCOMport()

        debug("Initialised and ready to start" & vbCrLf)


    End Sub




    Private Sub closeProgram()
        debug("Program closing")
        closeValves()
        saveSettings()
        saveDropData()
        disconnect()

        If (useDebugLogFile) Then
            closeDebugLogFile()
        End If


    End Sub














    '  _____                                  _            
    ' / ____|                                | |              
    '| |      ___   _ __   _ __    ___   ___ | |_    
    '| |     / _ \ | '_ \ | '_ \  / _ \ / __|| __|  
    '| |____| (_) || | | || | | ||  __/| (__ | |_   
    ' \_____|\___/ |_| |_||_| |_| \___| \___| \__|                                                            
    '                                                                                                                               
    ' After connecting wait for the user to click the start button
    '

#Region "Connect & Disconnect"



    Private Sub refreshCOM_BTN_Click_1(sender As Object, e As EventArgs) Handles refreshCOM_BTN.Click
        populateCOMport()
    End Sub


    Private Sub populateCOMport()
        COMport_CB.Text = ""
        COMport_CB.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            COMport_CB.Items.Add(sp)
        Next

        debug("COM port list updated")

    End Sub




    Private Sub connect_BTN_Click_1(sender As Object, e As EventArgs) Handles connect_BTN.Click
        debug("connect_BTN_Click")
        debug("  SerialPort1.IsOpen= " & SerialPort1.IsOpen)


        If (connect_BTN.Text = "Connect" And SerialPort1.IsOpen) Then
            debug("  BTN.text = Connect & serial port is already open")
        End If



        If (connect_BTN.Text = "Connect") Then


            If (COMport_CB.SelectedItem = "") Then
                connect_BTN.Text = "Connect"
                debug("  ERROR: No COM port selected")
                MsgBox("Select a COM port first", , "ERROR")

            Else

                connect_BTN.Text = "Connecting..."
                connect_BTN.Enabled = False

                ' the timer takes care of the next bit
                ' without a timer, the button text changes is too fast (or does not happen)
                timer_updateConnectButton.Enabled = True

            End If

        ElseIf (connect_BTN.Text = "Dis-connect") Then
            disconnect()
        End If

    End Sub



    Private Sub timer_updateConnectButton_Tick(sender As Object, e As EventArgs) Handles timer_updateConnectButton.Tick

        ' this is used to change the CONNECT BUTTON text to "Connecting..."
        ' without a timer the text does not change.  The timer is set to 100ms

        timer_updateConnectButton.Enabled = False

        debug("timer_updateConnectButton_Tick")
        If (SerialPort1.IsOpen) Then
            debug("  Error: " & comPORT & " already open")
        End If


        comPORT = COMport_CB.SelectedItem

        If (Not SerialPort1.IsOpen) Then

            SerialPort1.PortName = comPORT
            SerialPort1.BaudRate = 9600
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.ReadTimeout = 10000

            'Arduino Leonardo
            ' Not really sure if I need to separate this bit or just include for all models

            If (SET_LEO_BUT.Text = "ON") Then
                SerialPort1.DtrEnable = True
                SerialPort1.RtsEnable = True
            End If

            ' check if device is avaiable: 
            Try
                SerialPort1.Open()
            Catch ex As Exception
                connect_BTN.Text = "Connect"
                connect_BTN.Enabled = True

                debug("  Failed to open" & comPORT)
                debug("  - Error = " & ex.Message)
                MsgBox("Error. Cannot open COM port: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try


        Else
            debug("  Error: " & comPORT & " already open")
        End If




        If (SerialPort1.IsOpen) Then

            SerialPort1.DiscardInBuffer()
            receivedData = ""

            debug("COM " & comPORT & " opened")


            'See if the dropController is there - send HELLO message and wait for a reply
            sendCommandToDropController("[HELLO]")
            debug("HELLO sent" & vbCrLf)


            ' start checkSerialData timer
            ' start connection timeout timer
            ' wait for a reply from the dropController or timeout if no reply received

            Timer_recieveSerialDataOn()
            Timer_ConnectionTimeoutON()


        End If

    End Sub






    Private Sub Timer_checkConnect_Tick(sender As Object, e As EventArgs) Handles Timer_ConnectionTimeout.Tick

        ' if this fires the HELLO message has not been  received
        ' show error message
        ' reset buttons etc

        Timer_ConnectionTimeoutOFF()

        connect_BTN.Text = "Connect"
        debug("HELLO reply message not received from the dropController")
        MsgBox("ERROR!" & vbCrLf & "Cannot connect to the dropController")


        If (SerialPort1.IsOpen) Then
            SerialPort1.Close()
            debug("Serial port closed")
        End If

        populateCOMport()
        connect_BTN.Enabled = True

    End Sub





    Private Sub disconnect()
        'close the connection a reset the button and timer labels

        Timer_ConnectionTimeoutOFF()


        If (SerialPort1.IsOpen) Then
            closeValves()
            sendCommandToDropController("[BYE]")
            'SerialPort1.Write("<BYE>")

            receivedData = ""
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
            debug("COM port closed")
        End If

        connect_BTN.Text = "Connect"
        COMport_CB.Enabled = True
        refreshCOM_BTN.Enabled = True
        startBTNoff()
        'populateCOMport()

        TestConnection_BTN.Enabled = False
        disableValveDrainButtons()
        'connected = False



    End Sub


    Private Sub TestConnection_BTN_Click(sender As Object, e As EventArgs) Handles TestConnection_BTN.Click
        TestConnection_BTN.Text = "Checking..."
        TestConnection_BTN.Enabled = False
        sendCommandToDropController("[AYT]")
        Timer_TestConnection_TimeoutON()
    End Sub



    Private Sub Timer_TestConnection_Timeout_Tick(sender As Object, e As EventArgs) Handles Timer_TestConnection_Timeout.Tick
        Timer_TestConnection_TimeoutOFF()

        MsgBox("No reply received", , "Check Connection")
        TestConnection_BTN.Text = "Test Connection"
        TestConnection_BTN.Enabled = True

    End Sub






#End Region 'Region "Connect & Disconnect"














    ' _                        _        _                           _         _         
    '| |                      | |      | |                         | |       | |        
    '| |      ___    __ _   __| |    __| | _ __  ___   _ __      __| |  __ _ | |_  __ _ 
    '| |     / _ \  / _` | / _` |   / _` || '__|/ _ \ | '_ \    / _` | / _` || __|/ _` |
    '| |____| (_) || (_| || (_| |  | (_| || |  | (_) || |_) |  | (_| || (_| || |_| (_| |
    '|______|\___/  \__,_| \__,_|   \__,_||_|   \___/ | .__/    \__,_| \__,_| \__|\__,_|
    '                                                 | |                               
    '                                                 |_|                               
    '
    Private Sub loadDropData()
        debug(vbCrLf & "Enter load drop data")

        Dim filename As String = "dropData.txt"
        Dim tmp As String = ""
        Dim foundPos As Integer = 0

        If My.Computer.FileSystem.FileExists(filename) Then
            debug(" - dropData file found")
        Else
            debug(" - dropData file not found")
        End If


        If Not System.IO.File.Exists(filename) Then
            ' file does not exist create new file

            debug(" - dropData file does not exist. Creating a new file.")
            saveDropData()
        End If


        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(filename)


        ' file header
        tmp = fileReader.ReadLine()

        While tmp <> "END"
            tmp = fileReader.ReadLine()

            debug("  dropData loaded = " & tmp)


            'if tmp contains "|" then parse
            foundPos = InStr(1, tmp, "|", CompareMethod.Text)

            If (foundPos > 0) Then
                Dim tmpSplit() As String = Split(tmp, "|", -1, CompareMethod.Text)

                'numDrops|2
                If (tmpSplit(0) = "numDrops") Then
                    Dim tmpVal As Integer = Val(tmpSplit(1))
                    If (tmpVal >= 1 And tmpVal <= 9) Then
                        NumDrops_CB.Text = " " & tmpSplit(1)
                    Else
                        NumDrops_CB.Text = " 1"
                    End If

                End If


                'FT1|1234|INC|000|OFF
                If (tmpSplit(0) = "FT1") Then

                    If (Val(tmpSplit(1) >= 0 And Val(tmpSplit(1)) <= 9999)) Then
                        FT1_Time_TB.Text = tmpSplit(1)
                    Else
                        FT1_Time_TB.Text = "0000"
                    End If

                    If (tmpSplit(1) = "INC" Or tmpSplit(2) = "DEC") Then
                        FT1_IncDec_BTN.Text = tmpSplit(2)
                    Else
                        FT1_IncDec_BTN.Text = "INC"
                    End If

                    If (Val(tmpSplit(3) >= 0 And tmpSplit(3) <= 999)) Then
                        FT1_IncDecTime_TB.Text = tmpSplit(3)
                    Else
                        FT1_IncDecTime_TB.Text = "000"
                    End If

                    If (tmpSplit(4) = "ON" Or tmpSplit(4) = "OFF") Then
                        FT1_BUTTON.Text = tmpSplit(4)
                    Else
                        FT1_BUTTON.Text = "OFF"
                    End If

                End If



                'FT2|1234|INC|000|OFF
                If (tmpSplit(0) = "FT2") Then

                    If (Val(tmpSplit(1) >= 0 And Val(tmpSplit(1)) <= 9999)) Then
                        FT2_Time_TB.Text = tmpSplit(1)
                    Else
                        FT2_Time_TB.Text = "0000"
                    End If

                    If (tmpSplit(1) = "INC" Or tmpSplit(2) = "DEC") Then
                        FT2_IncDec_BTN.Text = tmpSplit(2)
                    Else
                        FT2_IncDec_BTN.Text = "INC"
                    End If

                    If (Val(tmpSplit(3) >= 0 And tmpSplit(3) <= 999)) Then
                        FT2_IncDecTime_TB.Text = tmpSplit(3)
                    Else
                        FT2_IncDecTime_TB.Text = "000"
                    End If

                    If (tmpSplit(4) = "ON" Or tmpSplit(4) = "OFF") Then
                        FT2_BUTTON.Text = tmpSplit(4)
                    Else
                        FT2_BUTTON.Text = "OFF"
                    End If

                End If


                'FT3|1234|INC|000|OFF
                If (tmpSplit(0) = "FT3") Then

                    If (Val(tmpSplit(1) >= 0 And Val(tmpSplit(1)) <= 9999)) Then
                        FT3_Time_TB.Text = tmpSplit(1)
                    Else
                        FT3_Time_TB.Text = "0000"
                    End If

                    If (tmpSplit(1) = "INC" Or tmpSplit(2) = "DEC") Then
                        FT3_IncDec_BTN.Text = tmpSplit(2)
                    Else
                        FT3_IncDec_BTN.Text = "INC"
                    End If

                    If (Val(tmpSplit(3) >= 0 And tmpSplit(3) <= 999)) Then
                        FT3_IncDecTime_TB.Text = tmpSplit(3)
                    Else
                        FT3_IncDecTime_TB.Text = "000"
                    End If

                    If (tmpSplit(4) = "ON" Or tmpSplit(4) = "OFF") Then
                        FT3_BUTTON.Text = tmpSplit(4)
                    Else
                        FT3_BUTTON.Text = "OFF"
                    End If

                End If







                'Bulb Mode Button
                If (tmpSplit(0) = "Bulb") Then

                    If (tmpSplit(1) = "ON" Or tmpSplit(1) = "OFF") Then
                        BulbMode_BTN.Text = tmpSplit(1)
                    Else
                        BulbMode_BTN.Text = "OFF"
                    End If

                End If


                'CT|0250|INC|000
                If (tmpSplit(0) = "CT") Then
                    CT_StartTime_TB.Text = tmpSplit(1)
                    CT_IncDec_BTN.Text = tmpSplit(2)
                    CT_IncDecTime_TB.Text = tmpSplit(3)
                End If

                'Drop1| 1|0000|INC|000|0000|INC|000
                If (Microsoft.VisualBasic.Strings.Left(tmpSplit(0), 4) = "Drop") Then
                    Dim i As Integer = Val(Microsoft.VisualBasic.Strings.Right(tmpSplit(0), 1))
                    SolCBs(i).Text = tmpSplit(1)
                    StartTimes(i).Text = tmpSplit(2)
                    StartIncDecBtns(i).Text = tmpSplit(3)
                    StartIncDecVals(i).Text = tmpSplit(4)
                    Sizes(i).Text = tmpSplit(5)
                    SizeIncDecBtns(i).Text = tmpSplit(6)
                    SizeIncDecVals(i).Text = tmpSplit(7)
                End If

            End If
        End While
        fileReader.Close()

        debug("Exit load drop data")

        formatValues()

    End Sub








    '  _____                           _                           _         _         
    ' / ____|                         | |                         | |       | |        
    '| (___    __ _ __   __ ___     __| | _ __  ___   _ __      __| |  __ _ | |_  __ _ 
    ' \___ \  / _` |\ \ / // _ \   / _` || '__|/ _ \ | '_ \    / _` | / _` || __|/ _` |
    ' ____) || (_| | \ V /|  __/  | (_| || |  | (_) || |_) |  | (_| || (_| || |_| (_| |
    '|_____/  \__,_|  \_/  \___|   \__,_||_|   \___/ | .__/    \__,_| \__,_| \__|\__,_|
    '                                                | |                               
    '                                                |_|                               
    '
    Private Sub saveDropData()

        debug(vbCrLf & "Enter saveDropData()")

        formatValues()

        ' Dim RowLabels As Label() = New Label() {D1Row_LBL, D1Row_LBL, D2Row_LBL, D3Row_LBL, D4Row_LBL, D5Row_LBL, D6Row_LBL, D7Row_LBL, D8Row_LBL, D9Row_LBL}
        ' Dim SolCBs As ComboBox() = New ComboBox() {D1Sol_CB, D1Sol_CB, D2Sol_CB, D3Sol_CB, D4Sol_CB, D5Sol_CB, D6Sol_CB, D7Sol_CB, D8Sol_CB, D9Sol_CB}
        ' Dim StartTimes As TextBox() = New TextBox() {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        ' Dim StartIncDecBtns As Button() = New Button() {D1StartIncDec_BTN, D1StartIncDec_BTN, D2StartIncDec_BTN, D3StartIncDec_BTN, D4StartIncDec_BTN, D5StartIncDec_BTN, D6StartIncDec_BTN, D7StartIncDec_BTN, D8StartIncDec_BTN, D9StartIncDec_BTN}
        ' Dim StartIncDecVals As TextBox() = New TextBox() {D1StartIncVal_TB, D1StartIncVal_TB, D2StartIncVal_TB, D3StartIncVal_TB, D4StartIncVal_TB, D5StartIncVal_TB, D6StartIncVal_TB, D7StartIncVal_TB, D8StartIncVal_TB, D9StartIncVal_TB}
        ' Dim Sizes As TextBox() = New TextBox() {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}
        ' Dim SizeIncDecBtns As Button() = New Button() {D1SizeIncDec_BTN, D1SizeIncDec_BTN, D2SizeIncDec_BTN, D3SizeIncDec_BTN, D4SizeIncDec_BTN, D5SizeIncDec_BTN, D6SizeIncDec_BTN, D7SizeIncDec_BTN, D8SizeIncDec_BTN, D9SizeIncDec_BTN}
        ' Dim SizeIncDecTVals As TextBox() = New TextBox() {D1SizeIncVal_TB, D1SizeIncVal_TB, D2SizeIncVal_TB, D3SizeIncVal_TB, D4SizeIncVal_TB, D5SizeIncVal_TB, D6SizeIncVal_TB, D7SizeIncVal_TB, D8SizeIncVal_TB, D9SizeIncVal_TB}

        Dim objCurrentDate As Date = DateTime.Today
        Dim currentDate As String = Format(objCurrentDate, "dd/MM/yyyy")
        Dim objCurrentTime As Date = TimeOfDay
        Format(DateTime.Today, "dd/MM/yyyy")

        Dim tmpVar As Long = 0


        Dim filename As String = "dropData.txt"
        If (System.IO.File.Exists(filename) = False) Then
            System.IO.File.Create(filename).Dispose()
        End If

        Dim objWriter As New System.IO.StreamWriter(filename, False)

        objWriter.WriteLine("dropController: Drop data file")
        objWriter.WriteLine("Saved: " & currentDate & " " & objCurrentTime)
        objWriter.WriteLine("numDrops|" & Val(NumDrops_CB.Text))

        objWriter.WriteLine("Bulb|" & BulbMode_BTN.Text)
        objWriter.WriteLine("CT|" & CT_StartTime_TB.Text & "|" & CT_IncDec_BTN.Text & "|" & CT_IncDecTime_TB.Text)

        objWriter.WriteLine("FT1|" & FT1_Time_TB.Text & "|" & FT1_IncDec_BTN.Text & "|" & FT1_IncDecTime_TB.Text & "|" & FT1_BUTTON.Text)
        objWriter.WriteLine("FT2|" & FT2_Time_TB.Text & "|" & FT2_IncDec_BTN.Text & "|" & FT2_IncDecTime_TB.Text & "|" & FT2_BUTTON.Text)
        objWriter.WriteLine("FT3|" & FT3_Time_TB.Text & "|" & FT3_IncDec_BTN.Text & "|" & FT3_IncDecTime_TB.Text & "|" & FT3_BUTTON.Text)

        Dim fileString As String = ""
        fileString = "Drop -s-start-ID-val-size- ID-val "
        objWriter.WriteLine(fileString)

        For i As Integer = 1 To 9
            fileString = "Drop" & i & "|" & Val(SolCBs(i).Text) & "|" & StartTimes(i).Text & "|" & StartIncDecBtns(i).Text & "|" & StartIncDecVals(i).Text & "|" & Sizes(i).Text & "|" & SizeIncDecBtns(i).Text & "|" & SizeIncDecVals(i).Text
            objWriter.WriteLine(fileString)
        Next

        objWriter.WriteLine("END")
        objWriter.Close()


        debug("  numDrops|" & Val(NumDrops_CB.Text))
        debug("  FT1|" & FT1_Time_TB.Text & "|" & FT1_IncDec_BTN.Text & "|" & FT1_IncDecTime_TB.Text & "|" & FT1_BUTTON.Text)
        debug("  FT2|" & FT2_Time_TB.Text & "|" & FT2_IncDec_BTN.Text & "|" & FT2_IncDecTime_TB.Text & "|" & FT2_BUTTON.Text)
        debug("  FT3|" & FT3_Time_TB.Text & "|" & FT3_IncDec_BTN.Text & "|" & FT3_IncDecTime_TB.Text & "|" & FT3_BUTTON.Text)

        debug("  Bulb|" & BulbMode_BTN.Text)
        debug("  CT|" & CT_StartTime_TB.Text & "|" & CT_IncDec_BTN.Text & "|" & CT_IncDecTime_TB.Text)
        For i As Integer = 1 To 9
            fileString = "  Drop" & i & "|" & SolCBs(i).Text & "|" & StartTimes(i).Text & "|" & StartIncDecBtns(i).Text & "|" & StartIncDecVals(i).Text & "|" & Sizes(i).Text & "|" & SizeIncDecBtns(i).Text & "|" & SizeIncDecVals(i).Text
            debug(fileString)
        Next
        debug("Exit saveDropData()")

    End Sub












    '    __  __            _____  _   _       _____          _   _  ______  _      
    '   |  \/  |    /\    |_   _|| \ | |     |  __ \  /\    | \ | ||  ____|| |     
    '   | \  / |   /  \     | |  |  \| |     | |__) |/  \   |  \| || |__   | |     
    '   | |\/| |  / /\ \    | |  | . ` |     |  ___// /\ \  | . ` ||  __|  | |     
    '   | |  | | / ____ \  _| |_ | |\  |     | |   / ____ \ | |\  || |____ | |____ 
    '   |_|  |_|/_/    \_\|_____||_| \_|     |_|  /_/    \_\|_| \_||______||______|

#Region "MAIN PANEL"




    Private Sub D1Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D1Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D2Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D2Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D3Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D3Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D4Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D4Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D5Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D5Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D6Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D6Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D7Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D7Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D8Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D8Sol_CB.ForeColor = Color.Black
    End Sub

    Private Sub D9Sol_CB_SelectedIndexChanged(sender As Object, e As EventArgs)
        D9Sol_CB.ForeColor = Color.Black
    End Sub




    Private Sub updateIncDec_BTN(ByVal theClickedButton As Button)
        If theClickedButton.Text = "INC" Then
            theClickedButton.Text = "DEC"
        Else : theClickedButton.Text = "INC"
        End If


        Dim tmpBTN As Button = DirectCast(theClickedButton, Button)
        Dim name As String = tmpBTN.Name
        debug(name & " changed to " & theClickedButton.Text)


    End Sub


    Private Sub D1StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D1StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D1SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D1SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D2StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D2StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D2SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D2SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D3StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D3StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D3SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D3SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D4StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D4StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D4SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D4SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D5StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D5StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D5SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D5SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D6StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D6StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D6SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D6SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D7StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D7StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D7SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D7SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D8StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D8StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D8SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D8SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D9StartIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D9StartIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub

    Private Sub D9SizeIncDec_BTN_Click(sender As Object, e As EventArgs) Handles D9SizeIncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub


#End Region 'Region "MAIN PANEL"











    ' __      __     _  _      _         _           _    _                    _____                       _   
    ' \ \    / /    | |(_)    | |       | |         | |  | |                  |_   _|                     | |  
    '  \ \  / /__ _ | | _   __| |  __ _ | |_  ___   | |  | | ___   ___  _ __    | |   _ __   _ __   _   _ | |_ 
    '   \ \/ // _` || || | / _` | / _` || __|/ _ \  | |  | |/ __| / _ \| '__|   | |  | '_ \ | '_ \ | | | || __|
    '    \  /| (_| || || || (_| || (_| || |_|  __/  | |__| |\__ \|  __/| |     _| |_ | | | || |_) || |_| || |_ 
    '     \/  \__,_||_||_| \__,_| \__,_| \__|\___|   \____/ |___/ \___||_|    |_____||_| |_|| .__/  \__,_| \__|
    '                                                                                       | |                
    '                                                                                      |_|                

#Region "ValidateUserInput"


    '   __                                      _     _______   ____       __ __  
    '  / _|                                    | |   |__   __| |  _ \     / / \ \ 
    ' | |_    ___    _ __   _ __ ___     __ _  | |_     | |    | |_) |   | |   | |
    ' |  _|  / _ \  | '__| | '_ ` _ \   / _` | | __|    | |    |  _ <    | |   | |
    ' | |   | (_) | | |    | | | | | | | (_| | | |_     | |    | |_) |   | |   | |
    ' |_|    \___/  |_|    |_| |_| |_|  \__,_|  \__|    |_|    |____/    | |   | |
    '                                                                     \_\ /_/ 

    Private Sub formatTB(ByVal TB As TextBox, numDigits As Integer)
        If (numDigits = 2) Then
            TB.Text = Format(Val(TB.Text), "00")
        ElseIf (numDigits = 3) Then
            TB.Text = Format(Val(TB.Text), "000")
        ElseIf (numDigits = 4) Then
            TB.Text = Format(Val(TB.Text), "0000")
        End If

        Dim tmpTB As TextBox = DirectCast(TB, TextBox)
        Dim name As String = tmpTB.Name
        debug(name & " changed to " & TB.Text)
    End Sub


    Private Sub D1StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D1StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D2StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D2StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D3StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D3StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D4StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D4StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D5StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D5StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D6StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D6StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D7StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D7StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D8StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D8StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D9StartTime_TB_Leave(sender As Object, e As EventArgs) Handles D9StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub

    Private Sub D1Size_TB_Leave(sender As Object, e As EventArgs) Handles D1Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D2Size_TB_Leave(sender As Object, e As EventArgs) Handles D2Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D3Size_TB_Leave(sender As Object, e As EventArgs) Handles D3Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D4Size_TB_Leave(sender As Object, e As EventArgs) Handles D4Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D5Size_TB_Leave(sender As Object, e As EventArgs) Handles D5Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D6Size_TB_Leave(sender As Object, e As EventArgs) Handles D6Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D7Size_TB_Leave(sender As Object, e As EventArgs) Handles D7Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D8Size_TB_Leave(sender As Object, e As EventArgs) Handles D8Size_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub D9Size_TB_Leave(sender As Object, e As EventArgs) Handles D9Size_TB.Leave
        formatTB(sender, 4)
    End Sub



    Private Sub D1StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D1StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D2StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D2StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D3StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D3StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D4StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D4StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D5StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D5StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D6StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D6StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D7StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D7StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D8StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D8StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D9StartIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D9StartIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub



    Private Sub D1SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D1SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D2SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D2SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D3SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D3SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D4SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D4SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D5SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D5SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D6SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D6SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D7SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D7SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D8SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D8SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub D9SizeIncVal_TB_Leave(sender As Object, e As EventArgs) Handles D9SizeIncVal_TB.Leave
        formatTB(sender, 3)
    End Sub


    Private Sub FT1_Time_TB_Leave(sender As Object, e As EventArgs) Handles FT1_Time_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub FT1_IncDecTime_TB_Leave(sender As Object, e As EventArgs) Handles FT1_IncDecTime_TB.Leave
        formatTB(sender, 3)
    End Sub

    Private Sub FT2_Time_TB_Leave(sender As Object, e As EventArgs) Handles FT2_Time_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub FT2_IncDecTime_TB_Leave(sender As Object, e As EventArgs) Handles FT2_IncDecTime_TB.Leave
        formatTB(sender, 3)
    End Sub

    Private Sub FT3_Time_TB_Leave(sender As Object, e As EventArgs) Handles FT3_Time_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub FT3_IncDecTime_TB_Leave(sender As Object, e As EventArgs) Handles FT3_IncDecTime_TB.Leave
        formatTB(sender, 3)
    End Sub



    Private Sub ShutterTriggerTime_TB_Leave(sender As Object, e As EventArgs) Handles CT_StartTime_TB.Leave
        formatTB(sender, 4)
    End Sub
    Private Sub ShutterTriggerIncDecTime_TB_Leave(sender As Object, e As EventArgs) Handles CT_IncDecTime_TB.Leave
        formatTB(sender, 3)
    End Sub

    Private Sub LP_waitTimeVal_TB_Leave(sender As Object, e As EventArgs) Handles LP_waitTimeVal_TB.Leave
        formatTB(sender, 2)
    End Sub



    Private Sub mirrorLockupTime_TB_Leave(sender As Object, e As EventArgs) Handles mirrorLockupTime_TB.Leave
        formatTB(sender, 4)
    End Sub


    Private Sub FT1_Pulse_TB_Leave(sender As Object, e As EventArgs) Handles FT1_Pulse_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub FT2_Pulse_TB_Leave(sender As Object, e As EventArgs) Handles FT2_Pulse_TB.Leave
        formatTB(sender, 3)
    End Sub
    Private Sub FT3_Pulse_TB_Leave(sender As Object, e As EventArgs) Handles FT3_Pulse_TB.Leave
        formatTB(sender, 3)
    End Sub

    Private Sub CAM_Pulse_TB_Leave(sender As Object, e As EventArgs) Handles CT_Pulse_TB.Leave
        formatTB(sender, 3)
    End Sub

















    '   _  __  ______  __     __      _____    _____    ______    _____    _____ 
    '  | |/ / |  ____| \ \   / /     |  __ \  |  __ \  |  ____|  / ____|  / ____|
    '  | ' /  | |__     \ \_/ /      | |__) | | |__) | | |__    | (___   | (___  
    '  |  <   |  __|     \   /       |  ___/  |  _  /  |  __|    \___ \   \___ \ 
    '  | . \  | |____     | |        | |      | | \ \  | |____   ____) |  ____) |
    '  |_|\_\ |______|    |_|        |_|      |_|  \_\ |______| |_____/  |_____/ 

    ' allow only numeric characters

    Private Sub D1StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D1StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D2StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D2StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D3StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D3StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D4StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D4StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D5StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D5StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D6StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D6StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D7StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D7StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D8StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D8StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D9StartTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D9StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub D1StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D1StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D2StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D2StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D3StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D3StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D4StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D4StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D5StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D5StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D6StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D6StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D7StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D7StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D8StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D8StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D9StartIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D9StartIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub D1Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D1Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D2Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D2Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D3Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D3Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D4Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D4Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D5Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D5Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D6Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D6Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D7Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D7Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D8Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D8Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D9Size_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D9Size_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub D1SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D1SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D2SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D2SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D3SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D3SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D4SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D4SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D5SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D5SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D6SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D6SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D7SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D7SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D8SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D8SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub D9SizeIncVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D9SizeIncVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT1_Time_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT1_Time_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT1_IncDecTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT1_IncDecTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT2_Time_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT2_Time_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT2_IncDecTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT2_IncDecTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT3_Time_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT3_Time_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT3_IncDecTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT3_IncDecTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub ShutterTriggerTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CT_StartTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ShutterTriggerIncDecTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CT_IncDecTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    ' SETTINGS 

    Private Sub LP_waitTimeVal_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LP_waitTimeVal_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub mirrorLockupTime_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mirrorLockupTime_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT1_Pulse_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT1_Pulse_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FT2_Pulse_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT2_Pulse_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub FT3_Pulse_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FT3_Pulse_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub CT_Pulse_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CT_Pulse_TB.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




    '  _______           _     _____  _                                     _ 
    ' |__   __|         | |   / ____|| |                                   | |
    '    | |  ___ __  __| |_ | |     | |__    __ _  _ __    __ _   ___   __| |
    '    | | / _ \\ \/ /| __|| |     | '_ \  / _` || '_ \  / _` | / _ \ / _` |
    '    | ||  __/ >  < | |_ | |____ | | | || (_| || | | || (_| ||  __/| (_| |
    '    |_| \___|/_/\_\ \__| \_____||_| |_| \__,_||_| |_| \__, | \___| \__,_|
    '                                                       __/ |             
    '                                                      |___/              


    ' The below is probably not required since the user cannot enter non-numeric characters now

    Private Sub LP_waitTimeVal_TB_TextChanged(sender As Object, e As EventArgs) Handles LP_waitTimeVal_TB.TextChanged
        If (Val(LP_waitTimeVal_TB.Text) < 1) Then
            LP_waitTimeVal_TB.ForeColor = Color.Red
        Else
            LP_waitTimeVal_TB.ForeColor = Color.Black
        End If

    End Sub




    Private Sub mirrorLockupTime_TB_TextChanged(sender As Object, e As EventArgs) Handles mirrorLockupTime_TB.TextChanged
        If (Val(mirrorLockupTime_TB.Text) > 0) Then
            mirrorLockupTime_TB.ForeColor = Color.Black
        Else
            mirrorLockupTime_TB.ForeColor = Color.Red
        End If
    End Sub


    Private Sub flashPulseTime_TB_TextChanged(sender As Object, e As EventArgs) Handles FT1_Pulse_TB.TextChanged
        If (Val(FT1_Pulse_TB.Text) < 10) Then
            FT1_Pulse_TB.ForeColor = Color.Red
        Else
            FT1_Pulse_TB.ForeColor = Color.Black
        End If
    End Sub


    Private Sub FT2_Pulse_TB_TextChanged(sender As Object, e As EventArgs) Handles FT2_Pulse_TB.TextChanged
        If (Val(FT2_Pulse_TB.Text) < 10) Then
            FT2_Pulse_TB.ForeColor = Color.Red
        Else
            FT2_Pulse_TB.ForeColor = Color.Black
        End If
    End Sub
    Private Sub FT3_Pulse_TB_TextChanged(sender As Object, e As EventArgs) Handles FT3_Pulse_TB.TextChanged
        If (Val(FT3_Pulse_TB.Text) < 10) Then
            FT3_Pulse_TB.ForeColor = Color.Red
        Else
            FT3_Pulse_TB.ForeColor = Color.Black
        End If
    End Sub


    Private Sub CAM_Pulse_TB_TextChanged(sender As Object, e As EventArgs) Handles CT_Pulse_TB.TextChanged
        If (Val(CT_Pulse_TB.Text) < 10) Then
            CT_Pulse_TB.ForeColor = Color.Red
        Else
            CT_Pulse_TB.ForeColor = Color.Black
        End If
    End Sub





#End Region ' Region "ValidateUserInput"








    Private Sub formatValues()

        debug("Enter formatValues()")
        '  Dim StartTimes As TextBox() = New TextBox() {}
        '  StartTimes = {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}

        Dim mStartTimes As TextBox() = New TextBox() {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        Dim mStartIncDecVals As TextBox() = New TextBox() {D1StartIncVal_TB, D1StartIncVal_TB, D2StartIncVal_TB, D3StartIncVal_TB, D4StartIncVal_TB, D5StartIncVal_TB, D6StartIncVal_TB, D7StartIncVal_TB, D8StartIncVal_TB, D9StartIncVal_TB}
        Dim mSizes As TextBox() = New TextBox() {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}
        Dim mSizeIncDecVals As TextBox() = New TextBox() {D1SizeIncVal_TB, D1SizeIncVal_TB, D2SizeIncVal_TB, D3SizeIncVal_TB, D4SizeIncVal_TB, D5SizeIncVal_TB, D6SizeIncVal_TB, D7SizeIncVal_TB, D8SizeIncVal_TB, D9SizeIncVal_TB}


        Dim tmpVar As Long = 0

        For i As Integer = 1 To 9
            mStartTimes(i).Text = Format(Val(mStartTimes(i).Text), "0000")
            mStartIncDecVals(i).Text = Format(Val(mStartIncDecVals(i).Text), "000")
            mSizes(i).Text = Format(Val(mSizes(i).Text), "0000")
            mSizeIncDecVals(i).Text = Format(Val(mSizeIncDecVals(i).Text), "000")
        Next

        tmpVar = Val(LP_waitTimeVal_TB.Text)
        LP_waitTimeVal_TB.Text = Format(tmpVar, "00")

        tmpVar = Val(FT1_Time_TB.Text)
        FT1_Time_TB.Text = Format(tmpVar, "0000")
        tmpVar = Val(FT1_IncDecTime_TB.Text)
        FT1_IncDecTime_TB.Text = Format(tmpVar, "000")

        tmpVar = Val(FT2_Time_TB.Text)
        FT2_Time_TB.Text = Format(tmpVar, "0000")
        tmpVar = Val(FT2_IncDecTime_TB.Text)
        FT2_IncDecTime_TB.Text = Format(tmpVar, "000")

        tmpVar = Val(FT3_Time_TB.Text)
        FT3_Time_TB.Text = Format(tmpVar, "0000")
        tmpVar = Val(FT3_IncDecTime_TB.Text)
        FT3_IncDecTime_TB.Text = Format(tmpVar, "000")

        tmpVar = Val(CT_StartTime_TB.Text)
        CT_StartTime_TB.Text = Format(tmpVar, "0000")
        tmpVar = Val(CT_IncDecTime_TB.Text)
        CT_IncDecTime_TB.Text = Format(tmpVar, "000")

    End Sub

















    '  _____  _                _       ____          _    _                
    ' / ____|| |              | |     |  _ \        | |  | |               
    '| (___  | |_  __ _  _ __ | |_    | |_) | _   _ | |_ | |_  ___   _ __  
    ' \___ \ | __|/ _` || '__|| __|   |  _ < | | | || __|| __|/ _ \ | '_ \ 
    ' ____) || |_| (_| || |   | |_    | |_) || |_| || |_ | |_| (_) || | | |
    '|_____/  \__|\__,_||_|    \__|   |____/  \__,_| \__| \__|\___/ |_| |_|
    '
    '



    Private Sub startBTNoff()
        debug("MainStart_BTN OFF")
        MainStart_BTN.Enabled = False
        MainStart_BTN.BackColor = Color.FromArgb(200, 220, 200)
    End Sub

    Private Sub startBTNon()
        debug("MainStart_BTN ON")
        MainStart_BTN.Enabled = True
        MainStart_BTN.BackColor = Color.FromArgb(128, 255, 128)
    End Sub





    Private Sub MainStart_BTN_Click_1(sender As Object, e As EventArgs) Handles MainStart_BTN.Click

        debug(vbCrLf & "MainStart_BTN clicked")

        formatValues()
        saveDropData()

        Dim goodToGo As Boolean = True
        Dim errMSG As String = ""


        errMSG = checkDropTimes()

        If (errMSG <> "") Then
            errMSG = "Problem with one or more times. You must correct the problem(s) before starting the drop sequence." & vbCrLf & errMSG & vbCrLf
            goodToGo = False
        End If



        If (Not dropTimesOverlap()) Then

            errMSG = errMSG & vbCrLf & "Some of the drop times overlap" & vbCrLf

            goodToGo = False
        Else
            debug("  drop times are OK")
            receivedData = receivedData & getSerialInData()
            receivedData = ""
        End If


        ' this should never be false. The START button is only active when connected.
        'If (Not connected) Then
        '    errMSG = errMSG & vbCrLf & vbCrLf & "Not connected to the dopController" & vbCrLf
        '    goodToGo = False
        'End If



        If (Not goodToGo) Then
            MsgBox(errMSG, , "ERROR!")
        End If

        If (goodToGo) Then
            debug("  goodToGo - makeDrop()")
            makeDrop()
        End If



    End Sub





    Function checkDropTimes() As String

        debug("Enter checkDropTimes()")

        ' check values.
        ' sol must be 1 to 6
        ' start must be 0-9999
        ' start inc/dec must be 0-999
        ' size must be 0-9999
        ' size inc/dec must be 0-999

        ' FT1 must be 0-9999
        ' FT2 must be 0-9999
        ' FT3 must be 0-9999
        ' shutter trigger must be 0-9999

        Dim err As Boolean = False
        Dim message As String = ""

        For i = 1 To Val(NumDrops_CB.Text)

            ' Start time
            If (Val(StartTimes(i).Text) < 0 Or Val(StartTimes(i).Text) > 9999) Then
                StartTimes(i).ForeColor = Color.Red
                err = True
                message = message & "start time(s) out of range" & vbCrLf
                debug("  error in start time")
            Else
                StartTimes(i).ForeColor = Color.Black
            End If

            ' Start time inc/dec value
            If (Val(StartIncDecVals(i).Text) < 0 Or Val(StartIncDecVals(i).Text) > 999) Then
                StartIncDecVals(i).ForeColor = Color.Red
                err = True
                message = message & "Start time inc/dec value(s) out of range" & vbCrLf
                debug("  error in start time inc/dev value")
            Else
                StartIncDecVals(i).ForeColor = Color.Black
            End If

            ' Size time
            If (Val(Sizes(i).Text) < 0 Or Val(Sizes(i).Text) > 999) Then
                Sizes(i).ForeColor = Color.Red
                err = True
                message = message & "Size value(s)  out of range" & vbCrLf
                debug("  error in size value")
            Else
                Sizes(i).ForeColor = Color.Black
            End If

            ' Size time inc/dec val
            If (Val(SizeIncDecVals(i).Text) < 0 Or Val(SizeIncDecVals(i).Text) > 999) Then
                SizeIncDecVals(i).ForeColor = Color.Red
                err = True
                message = message & "Size inc/dec value(s) out of range" & vbCrLf
                debug("  error in size inc/dev value")
            Else
                Sizes(i).ForeColor = Color.Black
            End If

        Next i


        'FT1 time
        If (Val(FT1_Time_TB.Text) < 0 Or Val(FT1_Time_TB.Text) > 9999) Then
            FT1_Time_TB.ForeColor = Color.Red
            err = True
            message = message & "FT1 value out of range" & vbCrLf
            debug("  error in FT1 time")
        Else
            FT1_Time_TB.ForeColor = Color.Black
        End If

        'FT1 time inc val
        If (Val(FT1_IncDecTime_TB.Text) < 0 Or Val(FT1_IncDecTime_TB.Text) > 999) Then
            FT1_IncDecTime_TB.ForeColor = Color.Red
            err = True
            message = message & "Flash trigger inc/dec value out of range" & vbCrLf
            debug("  error in flash trigger inc/dec time")
        Else
            FT1_IncDecTime_TB.ForeColor = Color.Black
        End If



        'FT2 time
        If (Val(FT2_Time_TB.Text) < 0 Or Val(FT2_Time_TB.Text) > 9999) Then
            FT2_Time_TB.ForeColor = Color.Red
            err = True
            message = message & "FT2 value out of range" & vbCrLf
            debug("  error in flash trigger time")
        Else
            FT2_Time_TB.ForeColor = Color.Black
        End If

        'FT2 time inc val
        If (Val(FT2_IncDecTime_TB.Text) < 0 Or Val(FT2_IncDecTime_TB.Text) > 999) Then
            FT2_IncDecTime_TB.ForeColor = Color.Red
            err = True
            message = message & "FT2 inc/dec value out of range" & vbCrLf
            debug("  error in FT2 inc/dec time")
        Else
            FT2_IncDecTime_TB.ForeColor = Color.Black
        End If


        'FT3 time
        If (Val(FT3_Time_TB.Text) < 0 Or Val(FT3_Time_TB.Text) > 9999) Then
            FT3_Time_TB.ForeColor = Color.Red
            err = True
            message = message & "FT3 value out of range" & vbCrLf
            debug("  error in flash trigger time")
        Else
            FT3_Time_TB.ForeColor = Color.Black
        End If

        'FT3 time inc val
        If (Val(FT3_IncDecTime_TB.Text) < 0 Or Val(FT3_IncDecTime_TB.Text) > 999) Then
            FT3_IncDecTime_TB.ForeColor = Color.Red
            err = True
            message = message & "FT3 inc/dec value out of range" & vbCrLf
            debug("  error in FT3 inc/dec time")
        Else
            FT3_IncDecTime_TB.ForeColor = Color.Black
        End If





        'Shuuter trigger time
        If (Val(CT_StartTime_TB.Text) < 0 Or Val(CT_StartTime_TB.Text) > 9999) Then
            CT_StartTime_TB.ForeColor = Color.Red
            err = True
            message = message & "Camera trigger value out of range" & vbCrLf
            debug("  error in camera trigger time")
        Else
            CT_StartTime_TB.ForeColor = Color.Black
        End If

        'Shuuter trigger time inc time
        If (Val(CT_IncDecTime_TB.Text) < 0 Or Val(CT_IncDecTime_TB.Text) > 999) Then
            CT_IncDecTime_TB.ForeColor = Color.Red
            err = True
            message = message & "Camera trigger inc/dec value out of range" & vbCrLf
            debug("  error in camera trigger inc/dec time")
        Else
            CT_IncDecTime_TB.ForeColor = Color.Black
        End If


        'Loop timer time
        If (Val(LP_waitTimeVal_TB.Text) < 0 Or Val(LP_waitTimeVal_TB.Text) > 99) Then
            LP_waitTimeVal_TB.ForeColor = Color.Red
            err = True
            message = message & "Loop delay value out of range" & vbCrLf
            debug("  error in loop delay value")
        Else
            LP_waitTimeVal_TB.ForeColor = Color.Black
        End If


        debug("  checked values error = " & err)
        Return message

    End Function



    Private Function dropTimesOverlap() As Boolean

        Dim Sol_CB As ComboBox() = New ComboBox() {D1Sol_CB, D1Sol_CB, D2Sol_CB, D3Sol_CB, D4Sol_CB, D5Sol_CB, D6Sol_CB, D7Sol_CB, D8Sol_CB, D9Sol_CB}
        Dim StartTime As TextBox() = New TextBox() {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        Dim Size As TextBox() = New TextBox() {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}

        Dim numDrops As Integer = Val(NumDrops_CB.Text)
        Dim dropError As Boolean = False
        Dim stopTimeJ As Long = 0
        Dim stopTimeI As Long = 0

        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 1 To 9
            StartTime(j).ForeColor = Color.Black
            StartTime(i).ForeColor = Color.Black
        Next i

        If (numDrops > 1) Then

            For j = 1 To numDrops - 1
                For i = 1 To numDrops

                    If (i <> j) Then
                        ' only need to check if the the drops are from the same valve
                        If (Val(Sol_CB(j).Text) = Val(Sol_CB(i).Text)) Then

                            stopTimeJ = Val(StartTime(j).Text) + Val(Size(j).Text)
                            stopTimeI = Val(StartTime(i).Text) + Val(Size(i).Text)

                            If (Val(StartTime(j).Text) >= Val(StartTime(i).Text) And (Val(StartTime(j).Text) <= stopTimeI)) Then
                                dropError = True
                                StartTime(j).ForeColor = Color.Red
                                StartTime(i).ForeColor = Color.Red
                            End If

                            If (stopTimeJ >= Val(StartTime(i).Text) And (stopTimeJ <= stopTimeI)) Then
                                dropError = True
                                StartTime(j).ForeColor = Color.Red
                                StartTime(i).ForeColor = Color.Red
                            End If

                        End If

                    End If

                Next i
            Next j

        End If

        Return Not dropError
    End Function















































    '
    '   _____  _      _          _____                     _ 
    '  / ____|(_)    | |        |  __ \                   | |
    ' | (___   _   __| |  ___   | |__) |__ _  _ __    ___ | |
    '  \___ \ | | / _` | / _ \  |  ___// _` || '_ \  / _ \| |
    '  ____) || || (_| ||  __/  | |   | (_| || | | ||  __/| |
    ' |_____/ |_| \__,_| \___|  |_|    \__,_||_| |_| \___||_|
    '
    '


#Region "SIDE PANEL"



    ' _   _                    _                            __        _                         
    '| \ | |                  | |                          / _|      | |                        
    '|  \| | _   _  _ __ ___  | |__    ___  _ __     ___  | |_     __| | _ __  ___   _ __   ___ 
    '| . ` || | | || '_ ` _ \ | '_ \  / _ \| '__|   / _ \ |  _|   / _` || '__|/ _ \ | '_ \ / __|
    '| |\  || |_| || | | | | || |_) ||  __/| |     | (_) || |    | (_| || |  | (_) || |_) |\__ \
    '\_| \_/ \__,_||_| |_| |_||_.__/  \___||_|      \___/ |_|     \__,_||_|   \___/ | .__/ |___/
    '                                                                               | |         
    '                                                                               |_|         

    Private Sub NumDrops_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumDrops_CB.SelectedIndexChanged
        debug("Num Drops changed to " & NumDrops_CB.Text)

        updateRows()
    End Sub

    Private Sub CT_BUTTON_Click(sender As Object, e As EventArgs) Handles CT_BUTTON.Click
        If (CT_BUTTON.Text = "OFF") Then
            CT_BUTTON.Text = "ON"
        Else
            CT_BUTTON.Text = "OFF"
        End If
        updateSidePanel()
    End Sub

    Private Sub BulbMode_BTN_Click(sender As Object, e As EventArgs) Handles BulbMode_BTN.Click
        If (BulbMode_BTN.Text = "OFF") Then
            BulbMode_BTN.Text = "ON"
        Else
            BulbMode_BTN.Text = "OFF"
        End If
        updateSidePanel()
    End Sub

    Private Sub CT_IncDec_BTN_Click(sender As Object, e As EventArgs) Handles CT_IncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub



    Private Sub FT1_BUTTON_Click(sender As Object, e As EventArgs) Handles FT1_BUTTON.Click
        If (FT1_BUTTON.Text = "OFF") Then
            FT1_BUTTON.Text = "ON"
        Else
            FT1_BUTTON.Text = "OFF"
        End If
        updateSidePanel()
    End Sub

    Private Sub FT1_IncDec_BTN_Click(sender As Object, e As EventArgs) Handles FT1_IncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub


    Private Sub FT2_BUTTON_Click(sender As Object, e As EventArgs) Handles FT2_BUTTON.Click
        If (FT2_BUTTON.Text = "OFF") Then
            FT2_BUTTON.Text = "ON"
        Else
            FT2_BUTTON.Text = "OFF"
        End If
        updateSidePanel()
    End Sub

    Private Sub FT2_IncDec_BTN_Click(sender As Object, e As EventArgs) Handles FT2_IncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub



    Private Sub FT3_BUTTON_Click(sender As Object, e As EventArgs) Handles FT3_BUTTON.Click
        If (FT3_BUTTON.Text = "OFF") Then
            FT3_BUTTON.Text = "ON"
        Else
            FT3_BUTTON.Text = "OFF"
        End If
        updateSidePanel()
    End Sub


    Private Sub FT3_IncDec_BTN_Click(sender As Object, e As EventArgs) Handles FT3_IncDec_BTN.Click
        updateIncDec_BTN(sender)
    End Sub




    Private Sub updateSidePanel()



        If (CT_BUTTON.Text = "OFF") Then
            CT_StartTime_TB.Enabled = False
            CT_IncDec_BTN.Enabled = False
            CT_IncDecTime_TB.Enabled = False
            CT_IncDec_BTN.BackColor = greyedOut

            BulbMode_BTN.Enabled = False
            BulbMode_BTN.BackColor = greyedOut
        Else

            BulbMode_BTN.Enabled = True
            BulbMode_BTN.BackColor = Color.LightSkyBlue

            If (BulbMode_BTN.Text = "OFF") Then
                CT_StartTime_TB.Enabled = True
                CT_IncDec_BTN.Enabled = True
                CT_IncDecTime_TB.Enabled = True
                CT_IncDec_BTN.BackColor = Color.LightSkyBlue
            Else
                CT_StartTime_TB.Enabled = False
                CT_IncDec_BTN.Enabled = False
                CT_IncDecTime_TB.Enabled = False
                CT_IncDec_BTN.BackColor = greyedOut
            End If



        End If



        If (FT3_BUTTON.Text = "ON") Then
            FT3_Time_TB.Enabled = True
            FT3_IncDec_BTN.Enabled = True
            FT3_IncDecTime_TB.Enabled = True
            FT3_IncDec_BTN.BackColor = Color.LightSkyBlue
        Else
            FT3_Time_TB.Enabled = False
            FT3_IncDec_BTN.Enabled = False
            FT3_IncDecTime_TB.Enabled = False
            FT3_IncDec_BTN.BackColor = greyedOut
        End If


        If (FT2_BUTTON.Text = "ON") Then
            FT2_Time_TB.Enabled = True
            FT2_IncDec_BTN.Enabled = True
            FT2_IncDecTime_TB.Enabled = True
            FT2_IncDec_BTN.BackColor = Color.LightSkyBlue
        Else
            FT2_Time_TB.Enabled = False
            FT2_IncDec_BTN.Enabled = False
            FT2_IncDecTime_TB.Enabled = False
            FT2_IncDec_BTN.BackColor = greyedOut
        End If

        If (FT1_BUTTON.Text = "ON") Then
            FT1_Time_TB.Enabled = True
            FT1_IncDec_BTN.Enabled = True
            FT1_IncDecTime_TB.Enabled = True
            FT1_IncDec_BTN.BackColor = Color.LightSkyBlue
        Else
            FT1_Time_TB.Enabled = False
            FT1_IncDec_BTN.Enabled = False
            FT1_IncDecTime_TB.Enabled = False
            FT1_IncDec_BTN.BackColor = greyedOut
        End If

    End Sub





    '                   _         _         _____                        ____  
    '                  | |       | |       |  __ \                      / /\ \ 
    ' _   _  _ __    __| |  __ _ | |_  ___ | |__) | ___ __      __ ___ | |  | |
    '| | | || '_ \  / _` | / _` || __|/ _ \|  _  / / _ \\ \ /\ / // __|| |  | |
    '| |_| || |_) || (_| || (_| || |_|  __/| | \ \| (_) |\ V  V / \__ \| |  | |
    ' \__,_|| .__/  \__,_| \__,_| \__|\___||_|  \_\\___/  \_/\_/  |___/| |  | |
    '       | |                                                         \_\/_/ 
    '       |_|                                                                

    ' display the rows for the active drops only.
    ' Disable the rows for the non active drops

    Private Sub updateRows()

        debug("Enter updateRows()")

        ' need to work out why cannot use global arrays here....

        Dim RowLabels As Label() = New Label() {D1Row_LBL, D1Row_LBL, D2Row_LBL, D3Row_LBL, D4Row_LBL, D5Row_LBL, D6Row_LBL, D7Row_LBL, D8Row_LBL, D9Row_LBL}
        Dim SolCBs As ComboBox() = New ComboBox() {D1Sol_CB, D1Sol_CB, D2Sol_CB, D3Sol_CB, D4Sol_CB, D5Sol_CB, D6Sol_CB, D7Sol_CB, D8Sol_CB, D9Sol_CB}
        Dim StartTimes As TextBox() = New TextBox() {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        Dim StartIncDecBtns As Button() = New Button() {D1StartIncDec_BTN, D1StartIncDec_BTN, D2StartIncDec_BTN, D3StartIncDec_BTN, D4StartIncDec_BTN, D5StartIncDec_BTN, D6StartIncDec_BTN, D7StartIncDec_BTN, D8StartIncDec_BTN, D9StartIncDec_BTN}
        Dim StartIncVals As TextBox() = New TextBox() {D1StartIncVal_TB, D1StartIncVal_TB, D2StartIncVal_TB, D3StartIncVal_TB, D4StartIncVal_TB, D5StartIncVal_TB, D6StartIncVal_TB, D7StartIncVal_TB, D8StartIncVal_TB, D9StartIncVal_TB}
        Dim Sizes As TextBox() = New TextBox() {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}
        Dim SizeIncDecBtns As Button() = New Button() {D1SizeIncDec_BTN, D1SizeIncDec_BTN, D2SizeIncDec_BTN, D3SizeIncDec_BTN, D4SizeIncDec_BTN, D5SizeIncDec_BTN, D6SizeIncDec_BTN, D7SizeIncDec_BTN, D8SizeIncDec_BTN, D9SizeIncDec_BTN}
        Dim SizeIncTimes As TextBox() = New TextBox() {D1SizeIncVal_TB, D1SizeIncVal_TB, D2SizeIncVal_TB, D3SizeIncVal_TB, D4SizeIncVal_TB, D5SizeIncVal_TB, D6SizeIncVal_TB, D7SizeIncVal_TB, D8SizeIncVal_TB, D9SizeIncVal_TB}

        formatValues()
        updateSidePanel()


        Dim numDrops As Integer
        numDrops = Val(NumDrops_CB.Text)
        For i As Integer = 1 To 9
            If (i < numDrops + 1) Then
                RowLabels(i).Enabled = True
                SolCBs(i).Enabled = True
                StartTimes(i).Enabled = True
                StartIncDecBtns(i).Enabled = True
                StartIncDecBtns(i).BackColor = Color.LightSkyBlue
                StartIncVals(i).Enabled = True
                Sizes(i).Enabled = True
                SizeIncTimes(i).Enabled = True
                SizeIncDecBtns(i).Enabled = True
                SizeIncDecBtns(i).BackColor = Color.LightSkyBlue
            Else
                RowLabels(i).Enabled = False
                SolCBs(i).Enabled = False
                StartTimes(i).Enabled = False
                StartIncDecBtns(i).Enabled = False
                StartIncDecBtns(i).BackColor = greyedOut


                StartIncVals(i).Enabled = False
                Sizes(i).Enabled = False
                SizeIncTimes(i).Enabled = False
                SizeIncDecBtns(i).Enabled = False
                SizeIncDecBtns(i).BackColor = greyedOut


            End If
        Next

    End Sub



#End Region 'Region "SIDE PANEL"



























    '    _____  ______  _______  _______  _____  _   _   _____   _____       _______         ____  
    '   / ____||  ____||__   __||__   __||_   _|| \ | | / ____| / ____|     |__   __| /\    |  _ \ 
    '  | (___  | |__      | |      | |     | |  |  \| || |  __ | (___          | |   /  \   | |_) |
    '   \___ \ |  __|     | |      | |     | |  | . ` || | |_ | \___ \         | |  / /\ \  |  _ < 
    '   ____) || |____    | |      | |    _| |_ | |\  || |__| | ____) |        | | / ____ \ | |_) |
    '  |_____/ |______|   |_|      |_|   |_____||_| \_| \_____||_____/         |_|/_/    \_\|____/ 


#Region "SETTINGS TAB"

    Dim oldTab As Integer = 0
    Dim currentTab As Integer = 0


    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles GraphTabControl.Selecting


        Dim errMsg As String = ""


        If (e.TabPageIndex <> 1) Then

            ' NOT=1 means leaving the SETTINGS TAB
            If (oldTab = 1) Then
                If (Val(LP_waitTimeVal_TB.Text) < 1) Then
                    errMsg = "Loop delay time cannot be less than 1 second" & vbCrLf
                End If

                If (Val(FT1_Pulse_TB.Text) < 10) Then
                    errMsg = errMsg + "Flash trigger 1 pulse time cannot less than 10ms" & vbCrLf
                End If

                If (Val(FT2_Pulse_TB.Text) < 10) Then
                    errMsg = errMsg + "Flash trigger 2 pulse time cannot less than 10ms" & vbCrLf
                End If

                If (Val(FT3_Pulse_TB.Text) < 10) Then
                    errMsg = errMsg + "Flash trigger 3 pulse time cannot less than 10ms" & vbCrLf
                End If

                If (Val(CT_Pulse_TB.Text) < 10) Then
                    errMsg = errMsg + "Camera trigger pulse time cannot less than 10ms" & vbCrLf
                End If


            End If

        Else
            oldTab = e.TabPageIndex
        End If


        If (errMsg <> "") Then
            e.Cancel = True
            MsgBox(errMsg & vbCrLf)

        End If



    End Sub


    Private Sub SETTINGS_Enter(sender As Object, e As EventArgs) Handles TAB_SETTINGS.Enter
        debug(vbCrLf & "Enter Settings TAB")
        updateSettingsElements()
    End Sub


    Private Sub SETTINGS_Leave(sender As Object, e As EventArgs) Handles TAB_SETTINGS.Leave

        'check data
        formatSettings()
        saveSettings()
        closeValves()
        debug("  Exit Settings")


    End Sub



    Private Sub updateSettingsElements()
        formatSettings()
        updateML_Elements()
        'updateValveDrainButtons()
    End Sub




    ''  _____                        _____        _    _    _                    
    '' / ____|                      / ____|      | |  | |  (_)                   
    ''| (___    __ _ __   __ ___   | (___    ___ | |_ | |_  _  _ __    __ _  ___ 
    '' \___ \  / _` |\ \ / // _ \   \___ \  / _ \| __|| __|| || '_ \  / _` |/ __|
    '' ____) || (_| | \ V /|  __/   ____) ||  __/| |_ | |_ | || | | || (_| |\__ \
    ''|_____/  \__,_|  \_/  \___|  |_____/  \___| \__| \__||_||_| |_| \__, ||___/
    ''                                                                 __/ |     
    ''                                                                |___/      

    Private Sub saveSettings()

        debug(vbCrLf & "Enter saveSettings()")
        formatSettings()


        Dim filename As String = "settings.txt"
        If (System.IO.File.Exists(filename) = False) Then
            System.IO.File.Create(filename).Dispose()
        End If
        Dim objWriter As New System.IO.StreamWriter(filename, False)

        Dim objCurrentDate As Date = DateTime.Today
        Dim currentDate As String = Format(objCurrentDate, "dd/MM/yyyy")
        Dim objCurrentTime As Date = TimeOfDay
        Format(DateTime.Today, "dd/MM/yyyy")

        objWriter.WriteLine("dropController: Settings File")
        objWriter.WriteLine("Saved: " & currentDate & " " & objCurrentTime)

        objWriter.WriteLine("Version=" + Version_ComboBox.Text)

        objWriter.WriteLine("Loop=" + LoopMode_BTN.Text)
        objWriter.WriteLine("ButOrTimer=" & lp_TimerOrButton_BTN.Text)
        objWriter.WriteLine("WaitTime=" & LP_waitTimeVal_TB.Text)

        objWriter.WriteLine("MirrLockup=" + mirrorLockupOnOff_BTN.Text)
        objWriter.WriteLine("MirrLockTime=" + mirrorLockupTime_TB.Text)
        objWriter.WriteLine("CT_Pulse=" + CT_Pulse_TB.Text)
        objWriter.WriteLine("FT1_Pulse=" + FT1_Pulse_TB.Text)
        objWriter.WriteLine("FT2_Pulse=" + FT2_Pulse_TB.Text)
        objWriter.WriteLine("FT3_Pulse=" + FT3_Pulse_TB.Text)

        objWriter.WriteLine("Sound=" + SET_SOUND_BTN.Text)
        objWriter.WriteLine("Leo=" + SET_LEO_BUT.Text)
        objWriter.WriteLine("Debug=" + SET_DEBUG_BTN.Text)

        objWriter.WriteLine("END")
        objWriter.Close()

        debug("  settings saved")
    End Sub





    '' _                        _     _____        _    _    _                    
    ''| |                      | |   / ____|      | |  | |  (_)                   
    ''| |      ___    __ _   __| |  | (___    ___ | |_ | |_  _  _ __    __ _  ___ 
    ''| |     / _ \  / _` | / _` |   \___ \  / _ \| __|| __|| || '_ \  / _` |/ __|
    ''| |____| (_) || (_| || (_| |   ____) ||  __/| |_ | |_ | || | | || (_| |\__ \
    ''|______|\___/  \__,_| \__,_|  |_____/  \___| \__| \__||_||_| |_| \__, ||___/
    ''                                                                  __/ |     
    ''                                                                 |___/      
    Public Sub loadSettings()

        debug("Enter loadSettings()")


        Dim filename As String = "settings.txt"

        If Not System.IO.File.Exists(filename) Then
            ' file does not exist create new file
            resetSettings()
            saveSettings()
            debug("  settings file does not exist - new file created")
        End If


        Dim tmp As String = ""
        Dim foundPos As Integer = 0

        Dim found As Boolean = False


        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(filename)

        ' file header
        tmp = fileReader.ReadLine()

        While tmp <> "END"
            tmp = fileReader.ReadLine()

            'if tmp contains "=" then parse
            foundPos = InStr(1, tmp, "=", CompareMethod.Text)
            If (foundPos > 0) Then

                Dim tmpSplit() As String = Split(tmp, "=", -1, CompareMethod.Text)

                debug("    CMD=" & tmpSplit(0) & "  VAL=" & tmpSplit(1))



                If (tmpSplit(0) = "Version") Then
                    If (Val(tmpSplit(1)) = 2 Or Val(tmpSplit(1)) = 3) Then
                        Version_ComboBox.Text = tmpSplit(1)
                    Else
                        Version_ComboBox.Text = "2"
                    End If
                    found = True
                End If


                If (tmpSplit(0) = "Loop") Then
                    If (tmpSplit(1) = "ON" Or tmpSplit(1) = "OFF") Then
                        LoopMode_BTN.Text = tmpSplit(1)
                    Else
                        LoopMode_BTN.Text = "OFF"
                    End If
                    found = True
                End If
                If (tmpSplit(0) = "ButOrTimer") Then
                    lp_TimerOrButton_BTN.Text = tmpSplit(1)
                    found = True
                End If

                If (tmpSplit(0) = "WaitTime") Then
                    If (Val(tmpSplit(1)) < 0 Or Val(tmpSplit(1)) > 99) Then
                        tmpSplit(1) = "10"
                    End If
                    LP_waitTimeVal_TB.Text = tmpSplit(1)
                    found = True
                End If


                    If (tmpSplit(0) = "MirrLockup") Then
                    If (tmpSplit(1) = "ON" Or tmpSplit(1) = "OFF") Then
                        mirrorLockupOnOff_BTN.Text = tmpSplit(1)
                    Else
                        mirrorLockupOnOff_BTN.Text = "OFF"
                    End If
                    found = True
                End If

                If (tmpSplit(0) = "MirrLockTime") Then
                    If (Val(tmpSplit(1)) < 0 Or Val(tmpSplit(1)) > 9999) Then
                        tmpSplit(1) = "1000"
                    End If
                    mirrorLockupTime_TB.Text = tmpSplit(1)
                    found = True
                End If
                If (tmpSplit(0) = "FT1_Pulse") Then
                    If (Val(tmpSplit(1)) < 0 Or Val(tmpSplit(1)) > 999) Then
                        tmpSplit(1) = "050"
                    End If
                    FT1_Pulse_TB.Text = tmpSplit(1)
                    found = True
                End If
                If (tmpSplit(0) = "FT2_Pulse") Then
                    If (Val(tmpSplit(1)) < 0 Or Val(tmpSplit(1)) > 999) Then
                        tmpSplit(1) = "050"
                    End If
                    FT2_Pulse_TB.Text = tmpSplit(1)
                    found = True
                End If

                If (tmpSplit(0) = "FT3_Pulse") Then
                    If (Val(tmpSplit(1)) < 0 Or Val(tmpSplit(1)) > 999) Then
                        tmpSplit(1) = "050"
                    End If
                    FT3_Pulse_TB.Text = tmpSplit(1)
                    found = True
                End If



                If (tmpSplit(0) = "CT_Pulse") Then
                    If (Val(tmpSplit(1)) < 0 Or Val(tmpSplit(1)) > 999) Then
                        tmpSplit(1) = "050"
                    End If
                    CT_Pulse_TB.Text = tmpSplit(1)
                    found = True
                End If

                If (tmpSplit(0) = "Sound") Then
                    If (tmpSplit(1) = "ON" Or tmpSplit(1) = "OFF") Then
                        SET_SOUND_BTN.Text = tmpSplit(1)
                    Else
                        SET_SOUND_BTN.Text = "OFF"
                    End If
                    found = True
                End If

                If (tmpSplit(0) = "Debug") Then
                    If (tmpSplit(1) = "ON" Or tmpSplit(1) = "OFF") Then
                        SET_DEBUG_BTN.Text = tmpSplit(1)
                    Else
                        SET_DEBUG_BTN.Text = "OFF"
                    End If
                    found = True
                End If

                If (tmpSplit(0) = "Leo") Then
                    If (tmpSplit(1) = "YES" Or tmpSplit(1) = "NO") Then
                        SET_LEO_BUT.Text = tmpSplit(1)
                    Else
                        SET_LEO_BUT.Text = "NO"
                    End If
                    found = True
                End If


                If (Not found) Then
                    debug(tmp & " is not found")
                End If

            End If

        End While
        fileReader.Close()

        debug("  settings loaded")
        formatSettings()


    End Sub


    Private Sub formatSettings()
        debug("Enter formatSettings()")

        LP_waitTimeVal_TB.Text = Format(Val(LP_waitTimeVal_TB.Text), "00")

        mirrorLockupTime_TB.Text = Format(Val(mirrorLockupTime_TB.Text), "0000")
        FT1_Pulse_TB.Text = Format(Val(FT1_Pulse_TB.Text), "000")
        FT2_Pulse_TB.Text = Format(Val(FT2_Pulse_TB.Text), "000")
        FT3_Pulse_TB.Text = Format(Val(FT3_Pulse_TB.Text), "000")
        CT_Pulse_TB.Text = Format(Val(CT_Pulse_TB.Text), "000")

        BulbStartOffset_Time_TB.Text = Format(Val(BulbStartOffset_Time_TB.Text), "0000")
        BulbStopOffset_Time_TB.Text = Format(Val(BulbStopOffset_Time_TB.Text), "0000")

        If (Version_ComboBox.Text = "2") Then

            ' drop data panel - hide FT
            Label16.Visible = False
            FT2_BUTTON.Visible = False
            FT2_Time_TB.Visible = False
            FT2_IncDec_BTN.Visible = False
            FT2_IncDecTime_TB.Visible = False

            Label31.Visible = False
            FT3_BUTTON.Visible = False
            FT3_Time_TB.Visible = False
            FT3_IncDec_BTN.Visible = False
            FT3_IncDecTime_TB.Visible = False


            ' loop page = hide FT
            LP_FT2_LBL.Visible = False
            Loop_FT2_LBL.Visible = False
            LP_FT3_LBL.Visible = False
            Loop_FT3_LBL.Visible = False


            ' settings panel - hide FT
            FT2_Pulse_lbl.Visible = False
            FT2_Pulse_TB.Visible = False
            FT3_Pulse_lbl.Visible = False
            FT3_Pulse_TB.Visible = False


            ' graph panel handled in the graph tab function



        ElseIf (Version_ComboBox.Text = "3") Then

            ' drop data panel - show FT
            Label16.Visible = True
            FT2_BUTTON.Visible = True
            FT2_Time_TB.Visible = True
            FT2_IncDec_BTN.Visible = True
            FT2_IncDecTime_TB.Visible = True

            Label31.Visible = True
            FT3_BUTTON.Visible = True
            FT3_Time_TB.Visible = True
            FT3_IncDec_BTN.Visible = True
            FT3_IncDecTime_TB.Visible = True


            ' loop page = show FT2
            LP_FT2_LBL.Visible = True
            Loop_FT2_LBL.Visible = True
            LP_FT3_LBL.Visible = True
            Loop_FT3_LBL.Visible = True


            ' settings panel - show FT
            FT2_Pulse_lbl.Visible = True
            FT2_Pulse_TB.Visible = True
            FT3_Pulse_lbl.Visible = True
            FT3_Pulse_TB.Visible = True





            ' graph panel handled in the graph tab function


        End If

        updateSidePanel()
        updateLoopPage()


    End Sub





    Private Sub DeviceVersion_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Version_ComboBox.SelectedIndexChanged

        If (Version_ComboBox.Text = "2") Then
            FT2_BUTTON.Text = "OFF"
            FT3_BUTTON.Text = "OFF"
        End If

        formatSettings()
    End Sub





    Private Sub ResetAll_BTN_Click(sender As Object, e As EventArgs) Handles ResetAll_BTN.Click

        Dim reply = MsgBox("Are you sure you want to reset all values?", 4, "Reset All Values")

        If (reply = vbYes) Then
            debug(vbCrLf & "Enter ResetAll()")
            resetSettings()
            resetDropData()

            loadSettings()
            loadDropData()

            updateLoopElements()

            MsgBox("Reset complete", , "Reset All Values")

        End If

    End Sub



    Private Sub resetSettings()
        Dim filename As String = "settings.txt"
        If (System.IO.File.Exists(filename) = False) Then
            System.IO.File.Create(filename).Dispose()
        End If
        Dim objWriter As New System.IO.StreamWriter(filename, False)

        Dim objCurrentDate As Date = DateTime.Today
        Dim currentDate As String = Format(objCurrentDate, "dd/MM/yyyy")
        Dim objCurrentTime As Date = TimeOfDay
        Format(DateTime.Today, "dd/MM/yyyy")

        objWriter.WriteLine("dropController: Settings File")
        objWriter.WriteLine("Saved: " & currentDate & " " & objCurrentTime)

        objWriter.WriteLine("Version=" + Version_ComboBox.Text)

        objWriter.WriteLine("Loop=OFF")
        objWriter.WriteLine("ButOrTimer=BUTTON")
        objWriter.WriteLine("WaitTime=10")

        objWriter.WriteLine("MirrLockup=OFF")
        objWriter.WriteLine("MirrLockTime=1000")
        objWriter.WriteLine("CT_Pulse=50")
        objWriter.WriteLine("FT1_Pulse=50")
        objWriter.WriteLine("FT2_Pulse=50")


        objWriter.WriteLine("Sound=ON")
        objWriter.WriteLine("Debug=OFF")
        objWriter.WriteLine("Leo=NO")
        objWriter.WriteLine("END")
        objWriter.Close()

    End Sub

    Private Sub resetDropData()
        'dropController: Drop Data file
        'Saved: 07-02-2019 14:02:44
        'numDrops|9
        'Bulb|OFF
        'CT|0500|INC|000
        'FT1|0750|INC|000|On
        'FT2|1000|INC|000|On
        'FT3|1000|INC|000|On
        'Drop -s - start - ID - Val() - Size - ID - Val() 
        'Drop1|1|0100|INC|000|0050|INC|000
        'Drop2|2|0200|INC|000|0050|INC|000
        'Drop3|3|0300|INC|000|0050|INC|000
        'Drop4|4|0400|INC|000|0050|INC|000
        'Drop5|5|0500|INC|000|0050|INC|000
        'Drop6|6|0600|INC|000|0050|INC|000
        'Drop7|1|0700|INC|000|0050|INC|000
        'Drop8|2|0800|INC|000|0050|INC|000
        'Drop9|3|0900|INC|000|0050|INC|000
        'END


        Dim objCurrentDate As Date = DateTime.Today
        Dim currentDate As String = Format(objCurrentDate, "dd/MM/yyyy")
        Dim objCurrentTime As Date = TimeOfDay
        Format(DateTime.Today, "dd/MM/yyyy")


        Dim filename As String = "dropData.txt"
        If (System.IO.File.Exists(filename) = False) Then
            System.IO.File.Create(filename).Dispose()
        End If

        Dim objWriter As New System.IO.StreamWriter(filename, False)

        objWriter.WriteLine("dropController: Drop data file")
        objWriter.WriteLine("Saved: " & currentDate & " " & objCurrentTime)
        objWriter.WriteLine("numDrops|1")

        objWriter.WriteLine("Bulb|ON")
        objWriter.WriteLine("CT|0100|INC|000")

        objWriter.WriteLine("FT1|1000|INC|000|OFF")
        objWriter.WriteLine("FT2|1000|INC|000|OFF")
        objWriter.WriteLine("FT3|1000|INC|000|OFF")

        objWriter.WriteLine("Drop -s-start-ID-val-size- ID-val ")


        objWriter.WriteLine("Drop1|1|0100|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop2|2|0200|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop3|3|0300|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop4|4|0400|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop5|5|0500|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop6|6|0600|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop7|1|0700|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop8|2|0800|INC|000|0050|INC|000")
        objWriter.WriteLine("Drop9|3|0900|INC|000|0050|INC|000")
        objWriter.WriteLine("END")

        objWriter.Close()

    End Sub







    Private Sub LoopMode_BTN_Click(sender As Object, e As EventArgs) Handles LoopMode_BTN.Click
        If (LoopMode_BTN.Text = "ON") Then
            LoopMode_BTN.Text = "OFF"
        Else
            LoopMode_BTN.Text = "ON"
        End If
        updateLoopElements()
    End Sub

    Private Sub lp_TimerOrButton_BTN_Click(sender As Object, e As EventArgs) Handles lp_TimerOrButton_BTN.Click
        If (lp_TimerOrButton_BTN.Text = "BUTTON") Then
            lp_TimerOrButton_BTN.Text = "TIMER"
        Else
            lp_TimerOrButton_BTN.Text = "BUTTON"
        End If
        updateLoopElements()
    End Sub

    Private Sub updateLoopElements()
        If (LoopMode_BTN.Text = "OFF") Then
            timerButton_LBL.ForeColor = Color.Gray
            lp_TimerOrButton_BTN.Enabled = False
            lp_TimerOrButton_BTN.BackColor = greyedOut

        Else
            timerButton_LBL.ForeColor = Color.Black
            lp_TimerOrButton_BTN.Enabled = True
            lp_TimerOrButton_BTN.BackColor = Color.PaleGreen
        End If


        If (lp_TimerOrButton_BTN.Enabled = False Or lp_TimerOrButton_BTN.Text = "BUTTON") Then
            waitTime_LBL.ForeColor = Color.Gray
            LP_waitTimeVal_TB.Enabled = False
        Else
            waitTime_LBL.ForeColor = Color.Black
            LP_waitTimeVal_TB.Enabled = True
        End If
    End Sub

    ' Private Sub LoopTimerVal_TB_Leave(sender As Object, e As EventArgs)
    ' If (Val(LP_waitTimeVal_TB.Text) < 1) Then
    '        MsgBox("Wait time cannot be less than 1 second")
    '       LP_waitTimeVal_TB.Focus()
    'End If
    'End Sub

    Private Sub SET_LEO_BUT_Click(sender As Object, e As EventArgs) Handles SET_LEO_BUT.Click
        If (SET_LEO_BUT.Text = "NO") Then
            SET_LEO_BUT.Text = "YES"
        Else
            SET_LEO_BUT.Text = "NO"
        End If


    End Sub


    Private Sub activateValveDrainButtons()
        debug("Enter activateValveDrainButtons()")
        Dim VD_BUT As Button() = New Button() {valve1Drain_BTN, valve1Drain_BTN, valve2Drain_BTN, valve3Drain_BTN, valve4Drain_BTN, valve5Drain_BTN, valve6Drain_BTN}
        For i As Integer = 1 To numOfValves
            VD_BUT(i).Enabled = True
        Next i
    End Sub

    Private Sub disableValveDrainButtons()
        debug("Enter disableValveDrainButtons()")
        Dim VD_BUT As Button() = New Button() {valve1Drain_BTN, valve1Drain_BTN, valve2Drain_BTN, valve3Drain_BTN, valve4Drain_BTN, valve5Drain_BTN, valve6Drain_BTN}
        For i As Integer = 1 To numOfValves
            VD_BUT(i).Enabled = False
        Next i
    End Sub




    Private Sub mirrorLockupYesNo_BTN_Click(sender As Object, e As EventArgs) Handles mirrorLockupOnOff_BTN.Click
        If (mirrorLockupOnOff_BTN.Text = "ON") Then
            mirrorLockupOnOff_BTN.Text = "OFF"
        Else
            mirrorLockupOnOff_BTN.Text = "ON"

            If (Val(mirrorLockupTime_TB.Text) < 1) Then
                mirrorLockupTime_TB.ForeColor = Color.Red
            End If
        End If
        updateML_Elements()
    End Sub


    Private Sub updateML_Elements()
        If (mirrorLockupOnOff_BTN.Text = "OFF") Then
            ML_Time_LBL.ForeColor = Color.Gray
            mirrorLockupTime_TB.Enabled = False
        Else
            ML_Time_LBL.ForeColor = Color.Black
            mirrorLockupTime_TB.Enabled = True
        End If
    End Sub


    Private Sub soundsOnOff_BTN_Click(sender As Object, e As EventArgs) Handles SET_SOUND_BTN.Click
        If (SET_SOUND_BTN.Text = "ON") Then
            SET_SOUND_BTN.Text = "OFF"
        Else
            SET_SOUND_BTN.Text = "ON"
        End If
    End Sub

    Private Sub SET_DEBUG_BTN_Click(sender As Object, e As EventArgs) Handles SET_DEBUG_BTN.Click
        If (SET_DEBUG_BTN.Text = "ON") Then
            SET_DEBUG_BTN.Text = "OFF"
            turnDebugOff()
        Else
            SET_DEBUG_BTN.Text = "ON"
            turnDebugOn()
        End If
    End Sub






    Private Sub valve1Drain_BTN_Click(sender As Object, e As EventArgs) Handles valve1Drain_BTN.Click
        sendValveCommand(sender, 1)
    End Sub

    Private Sub valve2Drain_BTN_Click(sender As Object, e As EventArgs) Handles valve2Drain_BTN.Click
        sendValveCommand(sender, 2)
    End Sub

    Private Sub valve3Drain_BTN_Click(sender As Object, e As EventArgs) Handles valve3Drain_BTN.Click
        sendValveCommand(sender, 3)
    End Sub

    Private Sub valve4Drain_BTN_Click(sender As Object, e As EventArgs) Handles valve4Drain_BTN.Click
        sendValveCommand(sender, 4)
    End Sub

    Private Sub valve5Drain_BTN_Click(sender As Object, e As EventArgs) Handles valve5Drain_BTN.Click
        sendValveCommand(sender, 5)
    End Sub

    Private Sub valve6Drain_BTN_Click(sender As Object, e As EventArgs) Handles valve6Drain_BTN.Click
        sendValveCommand(sender, 6)
    End Sub


    Private Sub sendValveCommand(ByVal theClickedButton As Button, val As Integer)
        Dim command As String = ""

        If (theClickedButton.Text = "OPEN") Then
            theClickedButton.Text = "CLOSED"
            theClickedButton.BackColor = Color.FromArgb(255, 128, 128)

            command = "[O" & val & "0]"
        ElseIf (theClickedButton.Text = "CLOSED") Then
            theClickedButton.Text = "OPEN"
            theClickedButton.BackColor = Color.FromArgb(128, 255, 128)
            command = "[O" & val & "1]"
        End If

        sendCommandToDropController(command)
    End Sub





    Private Sub closeValves()
        debug(vbCrLf & "Enter closeValves()")

        If (SerialPort1.IsOpen) Then
            debug("  serial port is open")

            If (valve1Drain_BTN.Text = "OPEN") Then
                sendCommandToDropController("[V10]")
            End If
            If (valve2Drain_BTN.Text = "OPEN") Then
                sendCommandToDropController("[V20]")
            End If
            If (valve3Drain_BTN.Text = "OPEN") Then
                sendCommandToDropController("[V30]")
            End If
            If (valve4Drain_BTN.Text = "OPEN") Then
                sendCommandToDropController("[V40]")
            End If
            If (valve5Drain_BTN.Text = "OPEN") Then
                sendCommandToDropController("[V50]")
            End If
            If (valve6Drain_BTN.Text = "OPEN") Then
                sendCommandToDropController("[V60]")
            End If


            debug(vbCrLf & "disableValveDrainButtons()")
                Dim VD_BUT As Button() = New Button() {valve1Drain_BTN, valve1Drain_BTN, valve2Drain_BTN, valve3Drain_BTN, valve4Drain_BTN, valve5Drain_BTN, valve6Drain_BTN}
                For i As Integer = 1 To numOfValves
                    VD_BUT(i).Text = "CLOSED"
                    VD_BUT(i).BackColor = Color.FromArgb(255, 128, 128)
                Next i

            Else
                debug("  serial port is closed - Valve close cmd not sent")
        End If
    End Sub







#End Region '  "SETTINGS TAB"








    '    _____  _____             _____   _    _       _______         ____  
    '   / ____||  __ \     /\    |  __ \ | |  | |     |__   __| /\    |  _ \ 
    '  | |  __ | |__) |   /  \   | |__) || |__| |        | |   /  \   | |_) |
    '  | | |_ ||  _  /   / /\ \  |  ___/ |  __  |        | |  / /\ \  |  _ < 
    '  | |__| || | \ \  / ____ \ | |     | |  | |        | | / ____ \ | |_) |
    '   \_____||_|  \_\/_/    \_\|_|     |_|  |_|        |_|/_/    \_\|____/ 


    ' GGG

    Private Sub TAB_GRAPH_Enter(sender As Object, e As EventArgs) Handles TAB_GRAPH.Enter
        debug(vbCrLf & "Enter Graph TAB")
        ' all the work is done in the PictureBox1_Paint even
    End Sub



    Private Sub TAB_GRAPH_Paint(sender As Object, e As PaintEventArgs) Handles TAB_GRAPH.Paint
        debug("Enter graph tab - paint event")

        Dim graphSols() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim graphStartTimes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim graphSizeTimes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim graphStopTimes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

        For i As Integer = 1 To 9
            graphSols(i) = Val(SolCBs(i).Text)
            graphStartTimes(i) = Val(StartTimes(i).Text)
            graphSizeTimes(i) = Val(Sizes(i).Text)
            graphStopTimes(i) = graphStartTimes(i) + graphSizeTimes(i)
        Next i


        Dim Start_X As Integer = 70
        Dim Start_Y As Integer = 95

        Dim graphWidth As Integer = 700
        Dim GraphHeight As Integer = 340


        ' get longest time, round up to nearest 100 and scale the graph to longest
        Dim max_X As Integer = roundUpNearest100(getLongestTime())


        'if the max drop time < the width for the graph then use the graph width as the max value
        '    'If (max_X < PB_width) Then
        '    '    max_X = roundUpNearest100(PB_width)
        '    'End If


        Dim scale As Double = 1
        scale = max_X / graphWidth
        debug("  Scale = " & scale)



        Dim blackPen As Pen = New Pen(Brushes.Black, 1)
        Dim LightGreyPen = New Pen(Brushes.LightGray, 1)
        Dim LightGreyDashPen1 = New Pen(Brushes.LightGray, 1) : LightGreyDashPen1.DashStyle = 2

        e.Graphics.FillRectangle(Brushes.White, Start_X, Start_Y, graphWidth, GraphHeight)



        '    ' draw the horizontal lines
        For i As Integer = 0 To GraphHeight Step 30
            e.Graphics.DrawLine(LightGreyPen, Start_X, Start_Y + i, Start_X + graphWidth, Start_Y + i)
        Next i



        ' draw the vertical lines
        For i As Integer = 0 To max_X Step 100
            Dim x As Integer = i / scale
            e.Graphics.DrawLine(LightGreyPen, Start_X + x, Start_Y, Start_X + x, Start_Y + GraphHeight)

            ' draw dashed lines (sub divisions)
            If (max_X <= 2000) Then
                x = (i + 50) / scale
                e.Graphics.DrawLine(LightGreyDashPen1, Start_X + x, Start_Y, Start_X + x, Start_Y + GraphHeight)
            End If
        Next i

        ' draw the black border around the graph . Do this after the lines to overwrite the lines at the edges.
        e.Graphics.DrawRectangle(blackPen, Start_X, Start_Y, graphWidth, GraphHeight)




        '  draw the Y labels (SOL1, SOL2, etc)
        Dim y_lbl_Font As New System.Drawing.Font("Verdana", 10)
        Dim x_lbl_Font As New System.Drawing.Font("Verdana", 7)
        Dim drawFormat As New System.Drawing.StringFormat

        Dim lblArray() As String = {"nul", "SOL1", "SOL2", "SOL3", "SOL4", "SOL5", "SOL6", " ", "CAM", "FT1", "FT2", "FT3"}
        Dim y As Integer = 0
        For i As Integer = 1 To 11
            y = i * 30 + Start_Y - 20



            If (i < 10) Then

                e.Graphics.DrawString(lblArray(i), y_lbl_Font, Brushes.Black, 25, y, drawFormat)
            Else

                ' do not show the FT2 label if we are using version 2 dropController
                If (Version_ComboBox.Text = "2") Then
                    e.Graphics.DrawString(lblArray(i), y_lbl_Font, Brushes.LightGray, 25, y, drawFormat)
                Else
                    e.Graphics.DrawString(lblArray(i), y_lbl_Font, Brushes.Black, 25, y, drawFormat)
                End If


            End If


        Next i









        '    ' draw the X labels 
        '    ' if max_X is <  2,200          then use horizontal labels at every step
        '    ' if max_X is    2,201 - 5,000  then use vertical labels at every step
        '    ' if max_X is    5,501 - 10,000 then use vertical labels at every step
        '    ' if max_X is   10,000 - 15,000 then use vertical labels every 2 steps
        '    ' if max_X is > 15,000          then use vertical labels every 3 steps




        Dim labelStep As Integer = 0
        If (max_X <= 5500) Then
            labelStep = 1
        ElseIf (max_X <= 10000) Then
            labelStep = 2
        Else
            labelStep = 3
        End If
        debug("  labelStep = " & labelStep)


        Dim count As Integer = 0
        Dim lw As Integer = 0
        For i As Integer = 0 To max_X Step 100 * labelStep
            Dim x As Integer = i / scale
            Dim X_lbl_String As String = count * 100
            If (count = 0) Then
                X_lbl_String = "000"
            End If


            e.Graphics.DrawLine(blackPen, Start_X + x, Start_Y + GraphHeight - 6, Start_X + x, Start_Y + GraphHeight)

            If (max_X <= 2500) Then


                ' horizontal labels 

                ' this is half the width of the label

                If (i < 1000) Then
                    lw = 13
                Else
                    lw = 15
                End If

                'e.Graphics.DrawString(X_lbl_String, x_lbl_Font, Brushes.Black, Start_X + x - lw, 430, drawFormat)
                e.Graphics.DrawString(X_lbl_String, x_lbl_Font, Brushes.Black, Start_X + x - lw, 440, drawFormat)


            Else
                '            ' vertical labels 

                lw = 5
                For k = 0 To X_lbl_String.Length - 1
                    ' Ypos = 440 + (10 * k)
                    e.Graphics.DrawString(X_lbl_String(k), x_lbl_Font, Brushes.Black, x + Start_X - lw, 435 + (10 * k), drawFormat)
                Next k

            End If

            count = count + labelStep

        Next i





        Dim c1 As Color = Color.FromArgb(245, 98, 98)
        Dim c2 As Color = Color.FromArgb(98, 245, 98)
        Dim c3 As Color = Color.FromArgb(98, 98, 245)
        Dim c4 As Color = Color.FromArgb(245, 186, 98)
        Dim c5 As Color = Color.FromArgb(245, 98, 186)
        Dim c6 As Color = Color.FromArgb(186, 245, 98)
        Dim c7 As Color = Color.FromArgb(186, 98, 245)
        Dim c8 As Color = Color.FromArgb(98, 245, 186)
        Dim c9 As Color = Color.FromArgb(98, 186, 245)

        Dim dropPen1 = New Pen(c1, 20)
        Dim dropPen2 = New Pen(c2, 20)
        Dim dropPen3 = New Pen(c3, 20)
        Dim dropPen4 = New Pen(c4, 20)
        Dim dropPen5 = New Pen(c5, 20)
        Dim dropPen6 = New Pen(c6, 20)
        Dim dropPen7 = New Pen(c7, 20)
        Dim dropPen8 = New Pen(c8, 20)
        Dim dropPen9 = New Pen(c9, 20)
        Dim dropPens As Pen() = New Pen() {dropPen1, dropPen1, dropPen2, dropPen3, dropPen4, dropPen5, dropPen6, dropPen7, dropPen8, dropPen9}

        Dim triggerPen1 = New Pen(Brushes.Blue, 20)
        Dim triggerPen2 = New Pen(Brushes.Red, 20)



        'Dim graphSols() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        'Dim graphStartTimes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        'Dim graphSizeTimes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        'Dim graphStopTimes() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

        Dim tmpStart As Integer = 0
        Dim tmpSize As Integer = 0
        Dim tmpSol As Integer = 0
        Dim tmpStop As Integer = 0

        '    ' draw drop data
        For i As Integer = 1 To Val(NumDrops_CB.Text)
            tmpStart = graphStartTimes(i) / scale
            tmpSize = graphSizeTimes(i) / scale
            tmpSol = graphSols(i)

            tmpStart = tmpStart + Start_X


            y = (tmpSol - 1) * 30 + 20 + Start_Y
            e.Graphics.DrawLine(dropPens(i), tmpStart, y, tmpStart + tmpSize, y)
        Next


        ' camera trigger
        If (CT_BUTTON.Text = "ON") Then
            If (BulbMode_BTN.Text = "ON") Then
                tmpStart = Start_X
                tmpStop = getLongestTime() / scale
                tmpStop = tmpStop + Start_X


            Else
                tmpStart = Val(CT_StartTime_TB.Text) / scale
                tmpStart = tmpStart + Start_X
                tmpSize = Val(CT_Pulse_TB.Text) / scale
                tmpStop = tmpStart + tmpSize
            End If
            y = 7 * 30 + 20 + Start_Y
            e.Graphics.DrawLine(triggerPen2, tmpStart, y, tmpStop, y)
        End If


        ' Flash trigger 1
        If (FT1_BUTTON.Text = "ON") Then
            tmpStart = Val(FT1_Time_TB.Text) / scale
            tmpStart = tmpStart + Start_X
            tmpSize = Val(FT1_Pulse_TB.Text) / scale
            y = 8 * 30 + 20 + Start_Y
            e.Graphics.DrawLine(triggerPen1, tmpStart, y, tmpStart + tmpSize, y)
        End If


        ' Flash trigger 2
        ' do not show if using version 2

        If (Version_ComboBox.Text > "2") Then

            If (FT2_BUTTON.Text = "ON") Then
                tmpStart = Val(FT2_Time_TB.Text) / scale
                tmpStart = tmpStart + Start_X
                tmpSize = Val(FT2_Pulse_TB.Text) / scale
                y = 9 * 30 + 20 + Start_Y
                e.Graphics.DrawLine(triggerPen1, tmpStart, y, tmpStart + tmpSize, y)
            End If


            ' Flash trigger 2
            ' do not show if using version 2

            If (FT3_BUTTON.Text = "ON") Then
                tmpStart = Val(FT3_Time_TB.Text) / scale
                tmpStart = tmpStart + Start_X
                tmpSize = Val(FT3_Pulse_TB.Text) / scale
                y = 10 * 30 + 20 + Start_Y
                e.Graphics.DrawLine(triggerPen1, tmpStart, y, tmpStart + tmpSize, y)
            End If



        End If



    End Sub





    Private Function roundUpNearest100(tmpNum As Integer) As Integer

        Dim tmpFraction As Integer = tmpNum / 100
        tmpFraction = tmpFraction * 100

        If (tmpNum > tmpFraction) Then
            tmpFraction = tmpFraction + 100
        End If

        roundUpNearest100 = tmpFraction




    End Function




















    '              ____    ____   _    _  _______      _______         ____  
    '       /\    |  _ \  / __ \ | |  | ||__   __|    |__   __| /\    |  _ \ 
    '      /  \   | |_) || |  | || |  | |   | |          | |   /  \   | |_) |
    '     / /\ \  |  _ < | |  | || |  | |   | |          | |  / /\ \  |  _ < 
    '    / ____ \ | |_) || |__| || |__| |   | |          | | / ____ \ | |_) |
    '   /_/    \_\|____/  \____/  \____/    |_|          |_|/_/    \_\|____/ 
    '  


    Dim imageCount As Integer = 0
    Dim firwareUpdated As Boolean = False

    Private Sub TAB_ABOUT_Enter(sender As Object, e As EventArgs) Handles TAB_ABOUT.Enter
        debug(vbCrLf & "ENTER ABOUT TAB")

        Timer_LoadImages.Interval = 2000
        Timer_LoadImages.Enabled = True
        imageCount = 1

        If (Not firwareUpdated) Then
            sendCommandToDropController("[VERSION]")

        End If


    End Sub


    Private Sub TAB_ABOUT_Leave(sender As Object, e As EventArgs) Handles TAB_ABOUT.Leave
        Timer_LoadImages.Enabled = False
        debug("  image timer OFF")
    End Sub

    Private Sub Timer_LoadImages_Tick(sender As Object, e As EventArgs) Handles Timer_LoadImages.Tick
        imageCount = imageCount + 1
        If (imageCount > 3) Then
            imageCount = 1
        End If

        'debug("  imageCount = " & imageCount)
        If (imageCount = 1) Then
            AboutTab_Picture1.BringToFront()
        ElseIf (imageCount = 2) Then
            AboutTab_Picture2.BringToFront()
        ElseIf (imageCount = 3) Then
            AboutTab_Picture3.BringToFront()
        End If

    End Sub


    Private Sub ABOUT_LINK_LBL_Click(sender As Object, e As EventArgs) Handles ABOUT_LINK_LBL.Click
        Try
            Process.Start("http://www.dropcontroller.com")
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub ABOUT_LINK_LBL_MouseHover(sender As Object, e As EventArgs) Handles ABOUT_LINK_LBL.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub ABOUT_LINK_LBL_MouseLeave(sender As Object, e As EventArgs) Handles ABOUT_LINK_LBL.MouseLeave
        Me.Cursor = Cursors.Arrow
    End Sub




















    ' _______  _____  __  __  ______  _____    _____ 
    '|__   __||_   _||  \/  ||  ____||  __ \  / ____|
    '   | |     | |  | \  / || |__   | |__) || (___  
    '   | |     | |  | |\/| ||  __|  |  _  /  \___ \ 
    '   | |    _| |_ | |  | || |____ | | \ \  ____) |
    '   |_|   |_____||_|  |_||______||_|  \_\|_____/ 





    Private Sub Timer_ConnectionTimeoutON()
        Timer_ConnectionTimeout.Enabled = True
        timerConnectFlag.Text = "ON"
    End Sub

    Private Sub Timer_ConnectionTimeoutOFF()
        Timer_ConnectionTimeout.Enabled = False
        timerConnectFlag.Text = "OFF"
    End Sub




    Private Sub Timer_dropAckTimeoutON()
        Timer_dropAckTimeout.Interval = getLongestTime() + 3000
        debug("Timer_dropAckTimeout.Interval = " & getLongestTime() + 3000)

        Timer_dropAckTimeout.Enabled = True
        TimerACK_LBL.Text = "ON"
    End Sub

    Private Sub Timer_dropAckTimeoutOFF()
        Timer_dropAckTimeout.Enabled = False
        TimerACK_LBL.Text = "OFF"
    End Sub


    Private Sub TimerLoopDelayOn()
        Timer_LoopDelay.Enabled = True
        Timer_LoopDelay_LBL.Text = "ON"
    End Sub

    Private Sub TimerLoopDelayOff()
        Timer_LoopDelay.Enabled = False
        Timer_LoopDelay_LBL.Text = "OFF"
    End Sub


    Private Sub Timer_recieveSerialDataOn()
        Timer_recieveSerialData.Enabled = True
        Timer_SD_IN_LBL.Text = "ON"

    End Sub

    Private Sub Timer_recieveSerialDataOff()
        Timer_recieveSerialData.Enabled = False
        Timer_SD_IN_LBL.Text = "OFF"
    End Sub


    Private Sub Timer_TestConnection_TimeoutON()
        Timer_TestConnection_Timeout.Enabled = True
    End Sub

    Private Sub Timer_TestConnection_TimeoutOFF()
        Timer_TestConnection_Timeout.Enabled = False
    End Sub











    '
    '  __  __            _  __ ______    _____   _____    ____   _____  
    ' |  \/  |    /\    | |/ /|  ____|  |  __ \ |  __ \  / __ \ |  __ \ 
    ' | \  / |   /  \   | ' / | |__     | |  | || |__) || |  | || |__) |
    ' | |\/| |  / /\ \  |  <  |  __|    | |  | ||  _  / | |  | ||  ___/ 
    ' | |  | | / ____ \ | . \ | |____   | |__| || | \ \ | |__| || |     
    ' |_|  |_|/_/    \_\|_|\_\|______|  |_____/ |_|  \_\ \____/ |_|     


    ' the main start button has been clicked
    ' the drop data has been checked and is OK

    Private Sub makeDrop()

        SerialPort1.DiscardInBuffer()

        If (LoopMode_BTN.Text = "OFF") Then
            singleDrop()
        Else
            multiDrop()
        End If


    End Sub




    Private Sub singleDrop()

        debug(vbCrLf & "Enter singleDrop()")
        ' no need to open the loop page tab
        ' just make the drop(s)

        ' drop data already checked
        ' init - copy to temp variables ready for send

        ' disable MainStart_BTN
        ' enable ACTIVE button
        ' send data
        ' wait for ACK + timeout: If time out show error message
        ' activate START button

        LP_Sequence_LBL.Text = 1

        MainStart_BTN.Enabled = False
        MainStart_BTN.Text = "A C T I V E"
        MainStart_BTN.BackColor = Color.FromArgb(255, 182, 128)
        sendDropData()

        ' start Timer_dropAckTimeout
        Timer_dropAckTimeoutON()

    End Sub





    '
    '  _       ____    ____   _____      _____          _____  ______ 
    ' | |     / __ \  / __ \ |  __ \    |  __ \  /\    / ____||  ____|
    ' | |    | |  | || |  | || |__) |   | |__) |/  \  | |  __ | |__   
    ' | |    | |  | || |  | ||  ___/    |  ___// /\ \ | | |_ ||  __|  
    ' | |____| |__| || |__| || |        | |   / ____ \| |__| || |____ 
    ' |______|\____/  \____/ |_|        |_|  /_/    \_\\_____||______|
    '

#Region "Loop Page"

    Private Sub multiDrop()

        debug(vbCrLf & "Enter multiDrop()")


        GroupBox1.Visible = True
        debug("  GroupBox1.Visible = True")


        'show or hide drop data
        Dim lp_dropNum_LBLs As Label() = New Label() {LP_dropNum1_LBL, LP_dropNum1_LBL, LP_dropNum2_LBL, LP_dropNum3_LBL, LP_dropNum4_LBL, LP_dropNum5_LBL, LP_dropNum6_LBL, LP_dropNum7_LBL, LP_dropNum8_LBL, LP_dropNum9_LBL}
        Dim lp_dropData_LBLs As Label() = New Label() {drop1_LBL, drop1_LBL, drop2_LBL, drop3_LBL, drop4_LBL, drop5_LBL, drop6_LBL, drop7_LBL, drop8_LBL, drop9_LBL}
        For i = 1 To 9
            If (i <= Val(NumDrops_CB.Text)) Then
                lp_dropNum_LBLs(i).Visible = True
                lp_dropData_LBLs(i).Visible = True
            Else
                lp_dropNum_LBLs(i).Visible = False
                lp_dropData_LBLs(i).Visible = False
            End If

        Next i


        LP_Sequence_LBL.Text = 1
        updateLoopPage()


        'init all the controls and timers
        LP_START_BTN.Location = New Point(87, 450)
        LP_STOP_BTN.Location = New Point(258, 450)
        LP_RESET_BTN.Location = New Point(429, 450)
        LP_EXIT_BTN.Location = New Point(600, 450)


        LP_START_BTN.Enabled = True
        LP_START_BTN.Visible = True
        LP_START_BTN.Text = "S T A R T"
        LP_START_BTN.BackColor = Color.FromArgb(128, 255, 128)

        LP_RESET_BTN.Enabled = False
        LP_RESET_BTN.Visible = True


        LP_STOP_BTN.Enabled = False
        LP_STOP_BTN.Visible = False



        If (lp_TimerOrButton_BTN.Text = "BUTTON") Then
            debug("  init for button mode")

            progressBar_LBL.Visible = False
            LP_ProgressBar.Visible = False


        ElseIf (lp_TimerOrButton_BTN.Text = "TIMER") Then
            debug("  init for timer mode")

            progressBar_LBL.Visible = True
            LP_ProgressBar.Visible = True

            TimerLoopDelayOff()
            updateProgressBar(0)

        End If

        sequenceAborted = False
        debug("sequenceAborted = False")

    End Sub





    Private Sub updateLoopPage()
        debug(vbCrLf & "Enter updateLoopPage()")


        Dim lp_Sols As ComboBox() = New ComboBox() {D1Sol_CB, D1Sol_CB, D2Sol_CB, D3Sol_CB, D4Sol_CB, D5Sol_CB, D6Sol_CB, D7Sol_CB, D8Sol_CB, D9Sol_CB}
        Dim lp_StartTimes As TextBox() = New TextBox() {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        Dim lp_Sizes As TextBox() = New TextBox() {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}


        Dim lp_StartIncDecBtns As Button() = New Button() {D1StartIncDec_BTN, D1StartIncDec_BTN, D2StartIncDec_BTN, D3StartIncDec_BTN, D4StartIncDec_BTN, D5StartIncDec_BTN, D6StartIncDec_BTN, D7StartIncDec_BTN, D8StartIncDec_BTN, D9StartIncDec_BTN}
        Dim lp_StartIncDecVals As TextBox() = New TextBox() {D1StartIncVal_TB, D1StartIncVal_TB, D2StartIncVal_TB, D3StartIncVal_TB, D4StartIncVal_TB, D5StartIncVal_TB, D6StartIncVal_TB, D7StartIncVal_TB, D8StartIncVal_TB, D9StartIncVal_TB}

        Dim lp_SizeIncDecBtns As Button() = New Button() {D1SizeIncDec_BTN, D1SizeIncDec_BTN, D2SizeIncDec_BTN, D3SizeIncDec_BTN, D4SizeIncDec_BTN, D5SizeIncDec_BTN, D6SizeIncDec_BTN, D7SizeIncDec_BTN, D8SizeIncDec_BTN, D9SizeIncDec_BTN}
        Dim lp_SizeIncDecVals As TextBox() = New TextBox() {D1SizeIncVal_TB, D1SizeIncVal_TB, D2SizeIncVal_TB, D3SizeIncVal_TB, D4SizeIncVal_TB, D5SizeIncVal_TB, D6SizeIncVal_TB, D7SizeIncVal_TB, D8SizeIncVal_TB, D9SizeIncVal_TB}

        Dim lp_dropData_LBLs As Label() = New Label() {drop1_LBL, drop1_LBL, drop2_LBL, drop3_LBL, drop4_LBL, drop5_LBL, drop6_LBL, drop7_LBL, drop8_LBL, drop9_LBL}



        Dim sequence As Integer = Val(LP_Sequence_LBL.Text)

        ' add or subtract the delata values the copy drop data to LoopPage form

        Dim tmpSol As Integer = 0
        Dim tmpDropStartTime As Integer = 0
        Dim tmpdropSize As Integer = 0
        Dim tmpdropStopTime As Integer = 0

        Dim tmpStartIncDecVal As Integer = 0
        Dim tmpSizeIncDecVal As Integer = 0


        For i As Integer = 1 To Val(NumDrops_CB.Text)

            tmpSol = Val(lp_Sols(i).Text)
            tmpDropStartTime = Val(lp_StartTimes(i).Text)
            tmpdropSize = Val(lp_Sizes(i).Text)
            tmpdropStopTime = tmpDropStartTime + tmpdropSize

            tmpStartIncDecVal = Val(lp_StartIncDecVals(i).Text)
            tmpSizeIncDecVal = Val(lp_SizeIncDecVals(i).Text)



            ' if sequence = 1 then no need to calculate delta values

            ' add INC or subtract DEC times
            If (sequence > 1) Then

                If (tmpStartIncDecVal > 0) Then
                    If (lp_StartIncDecBtns(i).Text = "INC") Then
                        tmpDropStartTime = tmpDropStartTime + ((sequence - 1) * tmpStartIncDecVal)
                    ElseIf (lp_StartIncDecBtns(i).Text = "DEC") Then
                        tmpDropStartTime = tmpDropStartTime - ((sequence - 1) * tmpStartIncDecVal)
                    End If
                End If

                If (tmpDropStartTime < 0) Then
                    tmpDropStartTime = 0
                End If


                If (tmpSizeIncDecVal > 0) Then
                    If (lp_SizeIncDecBtns(i).Text = "INC") Then
                        tmpdropSize = tmpdropSize + ((sequence - 1) * tmpSizeIncDecVal)
                    ElseIf (lp_SizeIncDecBtns(i).Text = "DEC") Then
                        tmpdropSize = tmpdropSize - ((sequence - 1) * tmpSizeIncDecVal)
                    End If

                End If

                If (tmpdropSize < 0) Then
                    tmpdropSize = 0
                End If


            End If


            tmpdropStopTime = tmpDropStartTime + tmpdropSize
            'lp_dropData_LBLs(i).Text = "." & tmpSol & "." & "--" & Format(tmpdropSize, "0000") & "    " & Format(tmpDropStartTime, "0000") & "    " & Format(tmpdropStopTime, "00000")

            lp_dropData_LBLs(i).Text = tmpSol & "   " & Format(tmpdropSize, "0000") & " [-000]" & "  " & Format(tmpDropStartTime, "0000") & " [-000]" & "  " & Format(tmpdropStopTime, "00000")

        Next i



        Dim tmpSign As String = ""


        Dim tmpStart As Long = 0
        Dim tmpSize As Long = Val(CT_Pulse_TB.Text)
        Dim tmpIncVal As Long = 0


        ' CT_BUTTON
        If (CT_BUTTON.Text = "OFF") Then

            Loop_CT_LBL.Text = "OFF"

        ElseIf (BulbMode_BTN.Text = "ON") Then
            Loop_CT_LBL.Text = "BULB MODE ON"

        Else

            If (CT_IncDec_BTN.Text = "INC") Then
                tmpSign = "+"
            Else
                tmpSign = "-"
            End If

            tmpStart = Val(CT_StartTime_TB.Text)
            tmpSize = Val(CT_Pulse_TB.Text)
            tmpIncVal = Val(CT_IncDecTime_TB.Text)

            If (CT_IncDec_BTN.Text = "INC") Then
                tmpStart = tmpStart + (tmpIncVal * (sequence - 1))
            Else
                tmpStart = tmpStart - (tmpIncVal * (sequence - 1))
            End If

            If (tmpStart < 0) Then
                tmpStart = 0
            End If
            If (tmpStart > 9999) Then
                tmpStart = 9999
            End If
            Loop_CT_LBL.Text = Format(tmpStart, "0000") & " " & "[" & tmpSign & Format(tmpIncVal, "000") & "]"


        End If



        tmpIncVal = Val(FT1_IncDecTime_TB.Text)

        If (FT1_BUTTON.Text = "ON") Then

            If (FT1_IncDec_BTN.Text = "INC") Then
                tmpSign = "+"
            Else
                tmpSign = "-"
            End If

            tmpStart = Val(FT1_Time_TB.Text)


            If (FT1_IncDec_BTN.Text = "INC") Then
                tmpStart = Val(FT1_Time_TB.Text) + ((sequence - 1) * tmpIncVal)
            Else
                tmpStart = Val(FT1_Time_TB.Text) - ((sequence - 1) * tmpIncVal)
            End If

            If (tmpStart < 0) Then tmpStart = 0
            If (tmpStart) > 9999 Then tmpStart = 9999

            Loop_FT1_LBL.Text = Format(tmpStart, "0000") + " [" + tmpSign + Format(tmpIncVal, "000") + "]"
        Else
            Loop_FT1_LBL.Text = "OFF"
        End If


        tmpIncVal = Val(FT2_IncDecTime_TB.Text)
        If (FT2_BUTTON.Text = "ON") Then

            If (FT2_IncDec_BTN.Text = "INC") Then
                tmpSign = "+"
            Else
                tmpSign = "-"
            End If

            tmpStart = Val(FT2_Time_TB.Text)


            If (FT2_IncDec_BTN.Text = "INC") Then
                tmpStart = Val(FT2_Time_TB.Text) + ((sequence - 1) * tmpIncVal)
            Else
                tmpStart = Val(FT2_Time_TB.Text) - ((sequence - 1) * tmpIncVal)
            End If

            If (tmpStart < 0) Then tmpStart = 0
            If (tmpStart) > 9999 Then tmpStart = 9999

            Loop_FT2_LBL.Text = Format(tmpStart, "0000") + " [" + tmpSign + Format(tmpIncVal, "000") + "]"
        Else
            Loop_FT2_LBL.Text = "OFF"
        End If


        tmpIncVal = Val(FT3_IncDecTime_TB.Text)
        If (FT3_BUTTON.Text = "ON") Then

            If (FT3_IncDec_BTN.Text = "INC") Then
                tmpSign = "+"
            Else
                tmpSign = "-"
            End If

            tmpStart = Val(FT3_Time_TB.Text)


            If (FT3_IncDec_BTN.Text = "INC") Then
                tmpStart = Val(FT3_Time_TB.Text) + ((sequence - 1) * tmpIncVal)
            Else
                tmpStart = Val(FT3_Time_TB.Text) - ((sequence - 1) * tmpIncVal)
            End If

            If (tmpStart < 0) Then tmpStart = 0
            If (tmpStart) > 9999 Then tmpStart = 9999

            Loop_FT3_LBL.Text = Format(tmpStart, "0000") + " [" + tmpSign + Format(tmpIncVal, "000") + "]"
        Else
            Loop_FT3_LBL.Text = "OFF"
        End If








        If (mirrorLockupOnOff_BTN.Text = "ON") Then
            LP_ML_LBL.Text = Format(Val(mirrorLockupTime_TB.Text), "0000")
        Else
            LP_ML_LBL.Text = "OFF"
        End If



    End Sub










    '  after start button - when ACK received - if timer start timer not wait for button click
    '  Timer_waitACK
    '  remember to change to active button when sequence is active
    '  



    ' _       _____              _____  _______         _____  _______            ____  _______  _   _ 
    '| |     |  __ \            / ____||__   __| /\    |  __ \|__   __|          |  _ \|__   __|| \ | |
    '| |     | |__) |  ______  | (___     | |   /  \   | |__) |  | |     ______  | |_) |  | |   |  \| |
    '| |     |  ___/  |______|  \___ \    | |  / /\ \  |  _  /   | |    |______| |  _ <   | |   | . ` |
    '| |____ | |                ____) |   | | / ____ \ | | \ \   | |             | |_) |  | |   | |\  |
    '|______||_|               |_____/    |_|/_/    \_\|_|  \_\  |_|             |____/   |_|   |_| \_|


    Private Sub LP_START_BTN_Click(sender As Object, e As EventArgs) Handles LP_START_BTN.Click

        debug("LP_START_BTN clicked")



        If (LP_START_BTN.Text = "S T A R T") Then



            If (lp_TimerOrButton_BTN.Text = "BUTTON") Then
                debug("  button mode")

                LP_START_BTN.Enabled = False
                LP_START_BTN.Text = "A C T I V E"
                LP_START_BTN.BackColor = Color.FromArgb(255, 182, 128)


                LP_RESET_BTN.Enabled = False


                sendDropData()

                ' start Timer_dropAckTimeout
                Timer_dropAckTimeoutON()



            ElseIf (lp_TimerOrButton_BTN.Text = "TIMER") Then
                debug("  timer mode")



                LP_START_BTN.Enabled = True
                LP_START_BTN.Text = "S T O P"
                LP_START_BTN.BackColor = Color.FromArgb(255, 128, 128)

                LP_RESET_BTN.Enabled = False


                ' start the drop delay timer

                sendDropData()

                ' start Timer_dropAckTimeout
                Timer_dropAckTimeoutON()


                ' TimerLoopDelayOn()

            End If






        ElseIf (LP_START_BTN.Text = "S T O P") Then

            LP_START_BTN.Text = "S T A R T"
            LP_START_BTN.BackColor = Color.FromArgb(128, 255, 128)


            If (Timer_dropAckTimeout.Enabled) Then
                Timer_dropAckTimeoutOFF()
                sequenceAborted = True
                debug("sequenceAborted = True")

            End If

            TimerLoopDelayOff()
            updateProgressBar(0)
            PB_count = 0



        End If








    End Sub









    Private Sub LP_RESET_BTN_Click(sender As Object, e As EventArgs) Handles LP_RESET_BTN.Click


        If (Timer_dropAckTimeout.Enabled) Then
            Timer_dropAckTimeoutOFF()
            sequenceAborted = True
            debug("sequenceAborted = True")

        End If

        TimerLoopDelayOff()
        updateProgressBar(0)



        debug("LP RESET BTN clicked")
        ' the stop button stops the current loop and resets the sequence to 1

        LP_RESET_BTN.Enabled = False

        LP_START_BTN.Enabled = True
        LP_START_BTN.Text = "S T A R T"

        LP_STOP_BTN.Enabled = False
        LP_STOP_BTN.Visible = False
        LP_STOP_BTN.Text = "P A U S E"

        PB_count = 0
        LP_Sequence_LBL.Text = 1
        multiDrop()


    End Sub




    Private Sub LP_EXIT_BTN_Click(sender As Object, e As EventArgs) Handles LP_EXIT_BTN.Click
        debug("LP EXIT BTN clicked")

        ' stop all timers
        If (Timer_dropAckTimeout.Enabled) Then
            Timer_dropAckTimeoutOFF()
            sequenceAborted = True
            debug("sequenceAborted = True")

        End If


        TimerLoopDelayOff()
        updateProgressBar(0)


        LP_RESET_BTN.Enabled = False

        LP_START_BTN.Enabled = True
        LP_START_BTN.Visible = True

        LP_STOP_BTN.Enabled = False
        LP_STOP_BTN.Visible = False
        LP_STOP_BTN.Text = "P A U S E"



        PB_count = 0
        GroupBox1.Visible = False


    End Sub




    Private Sub LP_PAUSE_BTN_Click(sender As Object, e As EventArgs) Handles LP_STOP_BTN.Click

        debug("LP PAUSE BTN clicked")
        ' the pause button stop the current sequence only.
        ' on restart the current sequence is started again (including the timer)

        If (LP_STOP_BTN.Text = "P A U S E") Then
            LP_STOP_BTN.Text = "CONTINUE"
            ' stop timer
            TimerLoopDelayOff()
        Else
            LP_STOP_BTN.Text = "P A U S E"
            TimerLoopDelayOn()

        End If



    End Sub



    Private Sub initForNextDrop()

        If (LoopMode_BTN.Text = "OFF") Then

            MainStart_BTN.Text = "S T A R T"
            MainStart_BTN.BackColor = Color.FromArgb(128, 255, 128)
            MainStart_BTN.Enabled = True

        Else


            If (lp_TimerOrButton_BTN.Text = "BUTTON") Then

                LP_START_BTN.Enabled = True
                LP_START_BTN.Text = "S T A R T"
                LP_START_BTN.BackColor = Color.FromArgb(128, 255, 128)


                LP_RESET_BTN.Enabled = True

                LP_Sequence_LBL.Text = Val(LP_Sequence_LBL.Text) + 1
                updateLoopPage()

                ' wait for the START button


            ElseIf (lp_TimerOrButton_BTN.Text = "TIMER") Then

                '  LP_STOP_BTN.Enabled = True
                '  LP_STOP_BTN.Text = "S T O P"

                '  LP_ACTIVE_BTN.Enabled = False
                '  LP_ACTIVE_BTN.Visible = False

                LP_RESET_BTN.Enabled = True

                LP_Sequence_LBL.Text = Val(LP_Sequence_LBL.Text) + 1
                updateLoopPage()

                ' start the drop delay timer
                TimerLoopDelayOn()

            End If

        End If



    End Sub


















#End Region ' "Loop Page"
























    '                       _  _____                      _____          _            __ __  
    '                      | ||  __ \                    |  __ \        | |          / / \ \ 
    ' ___   ___  _ __    __| || |  | | _ __  ___   _ __  | |  | |  __ _ | |_  __ _  | |   | |
    '/ __| / _ \| '_ \  / _` || |  | || '__|/ _ \ | '_ \ | |  | | / _` || __|/ _` | | |   | |
    '\__ \|  __/| | | || (_| || |__| || |  | (_) || |_) || |__| || (_| || |_| (_| | | |   | |
    '|___/ \___||_| |_| \__,_||_____/ |_|   \___/ | .__/ |_____/  \__,_| \__|\__,_| | |   | |
    '                                             | |                                \_\ /_/ 
    '                                             |_|                                        


    Private Sub sendDropData()


        Dim sequence As Integer = Val(LP_Sequence_LBL.Text)
        debug(vbCrLf & "Enter sendDropData() - Seq=" & sequence)


        ' Dim longest As Long = 0
        ' Dim timeOut As Integer = 5000
        ' Dim timeOutCount As Long = 0


        Dim tmpSol() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim tmpStart() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim tmpSize() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim tmpStop() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        Dim tmpStartIncDecVal() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim tmpSizeIncDecVal() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        Dim dropCommandString() As String = {"", "", "", "", "", "", "", "", "", ""}


        Dim tmp_numDrops As Integer = NumDrops_CB.Text



        For i As Integer = 1 To 9

            tmpSol(i) = Val(SolCBs(i).Text)
            tmpStart(i) = Val(StartTimes(i).Text)
            tmpSize(i) = Val(Sizes(i).Text)

            tmpStartIncDecVal(i) = Val(StartIncDecVals(i).Text)
            tmpSizeIncDecVal(i) = Val(SizeIncDecVals(i).Text)


            ' add or subtract delta values
            If (StartIncDecBtns(i).Text = "INC") Then
                tmpStart(i) = tmpStart(i) + (tmpStartIncDecVal(i) * (sequence - 1))
            Else
                tmpStart(i) = tmpStart(i) - (tmpStartIncDecVal(i) * (sequence - 1))
            End If

            If (tmpStart(i) > 9999) Then
                tmpStart(i) = 9999
            End If

            If (tmpStart(i) < 0) Then
                tmpStart(i) = 0
            End If


            If (SizeIncDecBtns(i).Text = "INC") Then
                tmpSize(i) = tmpSize(i) + (tmpSizeIncDecVal(i) * (sequence - 1))
            Else
                tmpSize(i) = tmpSize(i) - (tmpSizeIncDecVal(i) * (sequence - 1))
            End If

            If (tmpSize(i) > 9999) Then
                tmpSize(i) = 9999
            End If

            If (tmpSize(i) < 0) Then
                tmpSize(i) = 0
            End If


            ' create drop command
            '[Dn, sol, start, size]
            '[D212341234]
            dropCommandString(i) = "[D" & i & tmpSol(i) & Format(tmpStart(i), "0000") & Format(tmpSize(i), "0000") & "]"

        Next i


        Dim tmpFT1_Start As Long = 0
        Dim tmpFT1_Size As Long = 0
        Dim tmpFT1_IncDecVal As Long = 0

        Dim tmpFT2_Start As Long = 0
        Dim tmpFT2_Size As Long = 0
        Dim tmpFT2_IncDecVal As Long = 0

        Dim tmpFT3_Start As Long = 0
        Dim tmpFT3_Size As Long = 0
        Dim tmpFT3_IncDecVal As Long = 0

        Dim tmpCT As Long = 0
        Dim tmpCTIncDec As String = ""
        Dim tmpCTIncVal As Long = 0

        Dim CT_Command As String = ""
        Dim FT1_Command As String = ""
        Dim FT2_Command As String = ""
        Dim FT3_Command As String = ""
        Dim ML_Command As String = ""



        'Dim tmpSign As String = ""


        Dim tmpCT_Start As Long = 0
        Dim tmpCT_Size As Long = Val(CT_Pulse_TB.Text)
        Dim tmpCT_IncDecVal As Long = 0


        ' CT_BUTTON
        If (CT_BUTTON.Text = "OFF") Then

            ' CT is OFF
            CT_Command = "[CN]"


        Else

            ' CT is ON


            If (BulbMode_BTN.Text = "ON") Then

                ' [CB 0200 0200]   
                Dim tmpVal1 As String = Format(Val(BulbStartOffset_Time_TB.Text), "0000")
                Dim tmpVal2 As String = Format(Val(BulbStopOffset_Time_TB.Text), "0000")
                CT_Command = "[CB" & tmpVal1 & tmpVal2 & "]"

                debug("tmp CT pre = ") : debug(tmpVal1)
                debug("tmp CT post = ") : debug(tmpVal2)

                debug("tmCT cmd = ") : debug(CT_Command)

            Else

                tmpCT_Start = Val(CT_StartTime_TB.Text)
                tmpCT_Size = Val(CT_Pulse_TB.Text)
                tmpCT_IncDecVal = Val(CT_IncDecTime_TB.Text)

                If (CT_IncDec_BTN.Text = "INC") Then
                    tmpCT_Start = tmpCT_Start + (tmpCT_IncDecVal * (sequence - 1))
                Else
                    tmpCT_Start = tmpCT_Start - (tmpCT_IncDecVal * (sequence - 1))
                End If

                If (tmpCT_Start < 0) Then
                    tmpCT_Start = 0
                End If
                If (tmpCT_Start > 9999) Then
                    tmpCT_Start = 9999
                End If

                CT_Command = "[CY" & Format(tmpCT_Start, "0000") & Format(tmpCT_Size, "000") & "]"


            End If  ' (CT_BUTTON.Text = "OFF") Then



        End If






        tmpFT1_Start = Val(FT1_Time_TB.Text)
        tmpFT1_Size = Val(FT1_Pulse_TB.Text)
        tmpFT1_IncDecVal = Val(FT1_IncDecTime_TB.Text)

        If (FT1_BUTTON.Text = "ON") Then

            If (FT1_IncDec_BTN.Text = "INC") Then
                tmpFT1_Start = tmpFT1_Start + (tmpFT1_IncDecVal * (sequence - 1))
            Else
                tmpFT1_Start = tmpFT1_Start - (tmpFT1_IncDecVal * (sequence - 1))
            End If

            If (tmpFT1_Start < 0) Then
                tmpFT1_Start = 0
            End If
            If (tmpFT1_Start > 9999) Then
                tmpFT1_Start = 9999
            End If

            debug("tmp FT1 start = ") : debug(tmpFT1_Start)


            ' [FT1 Y 1234 123]   
            FT1_Command = "[F1Y" & Format(tmpFT1_Start, "0000") & Format(tmpFT1_Size, "000") & "]"

        Else
            FT1_Command = "[F1N]"

        End If





        tmpFT2_Start = Val(FT2_Time_TB.Text)
        tmpFT2_Size = Val(FT2_Pulse_TB.Text)
        tmpFT2_IncDecVal = Val(FT2_IncDecTime_TB.Text)

        If (FT2_BUTTON.Text = "ON") Then

            If (FT2_IncDec_BTN.Text = "INC") Then
                tmpFT2_Start = tmpFT2_Start + (tmpFT2_IncDecVal * (sequence - 1))
            Else
                tmpFT2_Start = tmpFT2_Start - (tmpFT2_IncDecVal * (sequence - 1))
            End If

            If (tmpFT2_Start < 0) Then
                tmpFT2_Start = 0
            End If
            If (tmpFT2_Start > 9999) Then
                tmpFT2_Start = 9999
            End If

            ' [F2 Y,1234,123]   
            FT2_Command = "[F2Y" & Format(tmpFT2_Start, "0000") & Format(tmpFT2_Size, "000") & "]"


        Else
            FT2_Command = "[F2N]"
        End If





        tmpFT3_Start = Val(FT3_Time_TB.Text)
        tmpFT3_Size = Val(FT3_Pulse_TB.Text)
        tmpFT3_IncDecVal = Val(FT3_IncDecTime_TB.Text)

        If (FT3_BUTTON.Text = "ON") Then

            If (FT3_IncDec_BTN.Text = "INC") Then
                tmpFT3_Start = tmpFT3_Start + (tmpFT3_IncDecVal * (sequence - 1))
            Else
                tmpFT3_Start = tmpFT3_Start - (tmpFT3_IncDecVal * (sequence - 1))
            End If

            If (tmpFT3_Start < 0) Then
                tmpFT3_Start = 0
            End If
            If (tmpFT3_Start > 9999) Then
                tmpFT3_Start = 9999
            End If

            ' [F3 Y,1234,123]   
            FT3_Command = "[F3Y" & Format(tmpFT3_Start, "0000") & Format(tmpFT3_Size, "000") & "]"


        Else
            FT3_Command = "[F3N]"
        End If









        If (mirrorLockupOnOff_BTN.Text = "ON") Then
            ML_Command = "[MY" & Format(Val(mirrorLockupTime_TB.Text), "0000") & "]"
        Else
            ML_Command = "[MN]"
        End If





        For i As Integer = 1 To 9
            debug("  CMD =" & dropCommandString(i))
        Next i
        debug("  CMD =" & CT_Command)
        debug("  CMD =" & FT1_Command)
        debug("  CMD =" & FT2_Command)
        debug("  CMD =" & FT3_Command)


        sendCommandToDropController("[S" & sequence & "]")
        sendCommandToDropController("[N" & tmp_numDrops & "]")
        For i As Integer = 1 To tmp_numDrops
            sendCommandToDropController(dropCommandString(i))
        Next i

        Dim wasteSomeTime As Long = 0
        For j As Integer = 1 To 100000
            wasteSomeTime = wasteSomeTime + j * 2
        Next j

        sendCommandToDropController(ML_Command)
        sendCommandToDropController(CT_Command)
        sendCommandToDropController(FT1_Command)
        sendCommandToDropController(FT2_Command)
        sendCommandToDropController(FT3_Command)
        sendCommandToDropController("[EOD]")

        sendCommandToDropController("     ")


    End Sub







    '              _     _                                      _     _______  _                     ____  
    '             | |   | |                                    | |   |__   __|(_)                   / /\ \ 
    '  __ _   ___ | |_  | |      ___   _ __    __ _   ___  ___ | |_     | |    _  _ __ ___    ___  | |  | |
    ' / _` | / _ \| __| | |     / _ \ | '_ \  / _` | / _ \/ __|| __|    | |   | || '_ ` _ \  / _ \ | |  | |
    '| (_| ||  __/| |_  | |____| (_) || | | || (_| ||  __/\__ \| |_     | |   | || | | | | ||  __/ | |  | |
    ' \__, | \___| \__| |______|\___/ |_| |_| \__, | \___||___/ \__|    |_|   |_||_| |_| |_| \___| | |  | |
    '  __/ |                                   __/ |                                                \_\/_/ 
    ' |___/                                   |___/                                                        


    Public Function getLongestTime() As Long
        debug("Enter getLongestTime()")

        Dim longest As Long = 0
        Dim tmp As Long = 0

        Dim tmpStart() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim tmpSize() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim tmpStop() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

        Dim StartTimes As TextBox() = New TextBox() {D1StartTime_TB, D1StartTime_TB, D2StartTime_TB, D3StartTime_TB, D4StartTime_TB, D5StartTime_TB, D6StartTime_TB, D7StartTime_TB, D8StartTime_TB, D9StartTime_TB}
        Dim Sizes As TextBox() = New TextBox() {D1Size_TB, D1Size_TB, D2Size_TB, D3Size_TB, D4Size_TB, D5Size_TB, D6Size_TB, D7Size_TB, D8Size_TB, D9Size_TB}

        Dim numDrops As Integer = Val(NumDrops_CB.Text)


        For i As Integer = 1 To numDrops
            tmpStart(i) = Val(StartTimes(i).Text)
            tmpSize(i) = Val(Sizes(i).Text)
            tmpStop(i) = tmpStart(i) + tmpSize(i)
        Next i

        For i As Integer = 1 To numDrops
            If (tmpStop(i) > longest) Then
                longest = tmpStop(i)
            End If
        Next i

        If (FT1_BUTTON.Text = "ON") Then
            tmp = Val(FT1_Time_TB.Text) + Val(FT1_Pulse_TB.Text)
            If (tmp > longest) Then
                longest = tmp
            End If
        End If

        If (FT2_BUTTON.Text = "ON") Then
            tmp = Val(FT2_Time_TB.Text) + Val(FT2_Pulse_TB.Text)
            If (tmp > longest) Then
                longest = tmp
            End If
        End If

        If (FT3_BUTTON.Text = "ON") Then
            tmp = Val(FT3_Time_TB.Text) + Val(FT3_Pulse_TB.Text)
            If (tmp > longest) Then
                longest = tmp
            End If
        End If




        If (CT_BUTTON.Text = "ON") Then
            tmp = Val(CT_StartTime_TB.Text) + Val(CT_Pulse_TB.Text)
            If (tmp > longest) Then
                longest = tmp
            End If
        End If


        If (BulbMode_BTN.Text = "ON") Then
            ' bulb mode - close the shutter 200ms after longest
            longest = longest + Val(BulbStopOffset_Time_TB.Text)
        End If



        debug("  longest = " & longest)

        Return longest
    End Function












    ' _____   _____    ____    _____  _____   ______   _____   _____      ____            _____  
    '|  __ \ |  __ \  / __ \  / ____||  __ \ |  ____| / ____| / ____|    |  _ \    /\    |  __ \ 
    '| |__) || |__) || |  | || |  __ | |__) || |__   | (___  | (___      | |_) |  /  \   | |__) |
    '|  ___/ |  _  / | |  | || | |_ ||  _  / |  __|   \___ \  \___ \     |  _ <  / /\ \  |  _  / 
    '| |     | | \ \ | |__| || |__| || | \ \ | |____  ____) | ____) |    | |_) |/ ____ \ | | \ \ 
    '|_|     |_|  \_\ \____/  \_____||_|  \_\|______||_____/ |_____/     |____//_/    \_\|_|  \_\

#Region "Progress Bar"



    Dim PB_count
    Private Sub Timer_LoopDelay_Tick(sender As Object, e As EventArgs) Handles Timer_LoopDelay.Tick
        PB_count = PB_count + 1
        Dim PB_timePassed As Long = PB_count * 100
        Dim waitTime As Long = Val(LP_waitTimeVal_TB.Text) * 1000
        Dim percent As Integer = PB_timePassed / waitTime * 100

        updateProgressBar(percent)
    End Sub


    Private Sub updateProgressBar(tmpVal As Integer)
        If (tmpVal > 100) Then
            tmpVal = 100
        End If
        LP_ProgressBar.Value = 100 - tmpVal

        If (tmpVal = 100) Then
            TimerLoopDelayOff()
            PB_count = 0

            sendDropData()

            ' start Timer_dropAckTimeout
            Timer_dropAckTimeoutON()

        End If

    End Sub

#End Region    ' "Progress Bar"







    Private Sub Timer_waitACK_Tick(sender As Object, e As EventArgs) Handles Timer_dropAckTimeout.Tick

        Timer_dropAckTimeoutOFF()
        'Timer_recieveSerialDataOff()


        debug("Timer_dropAckTimeout.Tick")
        debug("drop Ack has timed out")

        MsgBox("No acknowledgement from the dropController. Do you want to continue?",, "ERROR")

        initForNextDrop()


    End Sub















    ' _____         _                   
    '|  __ \       | |                  
    '| |  | |  ___ | |__   _   _   __ _ 
    '| |  | | / _ \| '_ \ | | | | / _` |
    '| |__| ||  __/| |_) || |_| || (_| |
    '|_____/  \___||_.__/  \__,_| \__, |
    '                              __/ |
    '                             |___/ 
    '

#Region "debug"





    Dim objWriter_debug As New System.IO.StreamWriter("debugLog.txt", False)
    Dim debugFileIsOpen As Boolean = False

    Private Sub openDebugLogFile()
        'Dim filename_debug As String = "debugLog.txt"
        If (System.IO.File.Exists("debugLog.txt") = False) Then
            System.IO.File.Create("debugLog.txt").Dispose()
        End If

        Dim objCurrentDate As Date = DateTime.Today
        Dim currentDate As String = Format(objCurrentDate, "dd/MM/yyyy")
        Dim objCurrentTime As Date = TimeOfDay
        Format(DateTime.Today, "dd/MM/yyyy")

        objWriter_debug.WriteLine("dropController V3: debug log File")
        objWriter_debug.WriteLine("Saved: " & currentDate & " " & objCurrentTime)

        debugFileIsOpen = True
    End Sub

    Private Sub closeDebugLogFile()

        debugTextBox.AppendText(vbCrLf & "Close debug file)" & vbCrLf)
        objWriter_debug.WriteLine("END")
        objWriter_debug.Close()
        debugFileIsOpen = False
    End Sub


    Private Sub debug(text As String)
        Dim txt As String = ""

        If (useDebugLogFile) Then
            If (debugFileIsOpen) Then
                objWriter_debug.WriteLine(text)
            End If

        End If


        If (text = "<RESET>") Then
            txt = "<RESET>" & vbCrLf & vbCrLf
        Else
            txt = text & vbCrLf
        End If

        debugTextBox.AppendText(txt)

    End Sub


    Private Sub turnDebugOn()
        Me.Width = widthDebug
        'debugTextBox.Visible = True
        SET_DEBUG_BTN.Text = "ON"
        checkConnected_Timer.Enabled = True
    End Sub

    Private Sub turnDebugOff()
        Me.Width = widthNormal
        'debugTextBox.Visible = False
        SET_DEBUG_BTN.Text = "OFF"
        checkConnected_Timer.Enabled = False

    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles checkConnected_Timer.Tick
        checkConnected_Timer.Enabled = False
        Dim tmp As Boolean
        tmp = SerialPort1.IsOpen
        If (tmp) Then
            Connected_Flag.Text = "TRUE"
        Else
            Connected_Flag.Text = "FALSE"
        End If
        checkConnected_Timer.Enabled = True
    End Sub


#End Region ' "debug"










    Private Sub sendCommandToDropController(command As String)

        If (SerialPort1.IsOpen) Then
            SerialPort1.Write(command)
            'SerialPort1.Write(vbCrLf)
            debug("send com = " & command)
        End If



    End Sub




    ' _____              _                       _____              _         _    _____          _         
    '|  __ \            (_)                     / ____|            (_)       | |  |  __ \        | |        
    '| |__) | ___   ___  _   ___ __   __ ___   | (___    ___  _ __  _   __ _ | |  | |  | |  __ _ | |_  __ _ 
    '|  _  / / _ \ / __|| | / _ \\ \ / // _ \   \___ \  / _ \| '__|| | / _` || |  | |  | | / _` || __|/ _` |
    '| | \ \|  __/| (__ | ||  __/ \ V /|  __/   ____) ||  __/| |   | || (_| || |  | |__| || (_| || |_| (_| |
    '|_|  \_\\___| \___||_| \___|  \_/  \___|  |_____/  \___||_|   |_| \__,_||_|  |_____/  \__,_| \__|\__,_|
    '


    Private Sub Timer_recieveSerialData_Tick(sender As Object, e As EventArgs) Handles Timer_recieveSerialData.Tick

        ' receivedData is the buffer used to store what ever data is received via the serial port
        Timer_recieveSerialDataOff()

        Dim Incoming As String = ""

        If (SerialPort1.IsOpen) Then
            Try
                Incoming = SerialPort1.ReadExisting()
                If Incoming Is Nothing Then
                    Incoming = ""
                End If
            Catch ex As TimeoutException
                Incoming = "Error: Serial Port read timed out."
            End Try

            If (Incoming = "Error: Serial Port read timed out.") Then
                MsgBox(Incoming, "COM PORT ERROR")
                Incoming = ""
            End If
        End If

        receivedData = receivedData + Incoming
        If (receivedData <> "") Then
            debug("RD=" & receivedData)
        End If




        checkReceivedData()

        Timer_recieveSerialDataOn()
    End Sub




    Private Sub checkReceivedData()

        ' uses the global variable receivedData

        Dim pos1 As Integer
        Dim pos2 As Integer
        Dim length As Integer
        Dim newCommand As String
        Dim done As Boolean = False

        While (Not done)

            pos1 = receivedData.IndexOf("[") + 1
            pos2 = receivedData.IndexOf("]") + 1


            '  debug("RD=" & receivedData) : debug("pos1=" & pos1) : debug("pos2=" & pos2)


            ' do we have a START MARKER and an END MARKER?
            If (pos1 = 0 Or pos2 = 0) Then
                ' we do not have both START and END MARKERS so we are done
                done = True
            End If



            If (Not done) Then

                ' We have a START MARKER and an END MARKER but are they in the correct order?
                ' Occasionally we may not get complete data and the end marker will be in front of the start marker
                ' for example "xx><xxxxx><xx"

                ' if pos2 <pos1 then remove the first part of the string from receivedData
                ' for example.  "xx><xxxxx><xx" to "<xxxxx><xx"

                If (pos1 <> 0 And pos2 <> 0) Then
                    If (pos2 < pos1) Then
                        receivedData = Microsoft.VisualBasic.Mid(receivedData, pos2 + 1)
                        pos1 = receivedData.IndexOf("[") + 1
                        pos2 = receivedData.IndexOf("]") + 1
                    End If
                End If

                ' We may have removed the only END MARKER so need to check again.
                ' This is not the best code but this way keeps the flow easy to see and makes it easier to edit.
                ' (The first check is not really required).


                pos1 = receivedData.IndexOf("[") + 1
                pos2 = receivedData.IndexOf("]") + 1

                If (pos1 = 0 Or pos2 = 0) Then
                    ' we do not have both start and end markers and we are done
                    done = True
                End If


            End If



            ' If we still have a START MARKER and an END MARKER we should have a command
            If (Not done) Then

                length = pos2 - pos1 + 1
                If (length > 0) Then

                    ' get the data from between the first START MARKER and the first END MARKER
                    newCommand = Mid(receivedData, pos1 + 1, length - 2)


                    'remove the command (including MARKERS)from receivedData
                    receivedData = Mid(receivedData, pos2 + 1)


                    debug("New cmd=" & newCommand)



                    If (newCommand = "HELLO") Then

                        ' HELLO received
                        Timer_ConnectionTimeoutOFF()


                        If (SET_SOUND_BTN.Text = "ON") Then
                            My.Computer.Audio.Play(My.Resources.complete, AudioPlayMode.Background)
                        End If

                        startBTNon()
                        refreshCOM_BTN.Enabled = False
                        connect_BTN.Text = "Dis-connect"
                        connect_BTN.Enabled = True
                        COMport_CB.Enabled = False

                        activateValveDrainButtons()
                        TestConnection_BTN.Enabled = True



                        ' firmwareVersion_LBL
                    ElseIf (newCommand(0) = "V") Then

                        ' version received
                        ' [V,0001,May  5 2018]
                        Dim tmpSplit() As String = Split(newCommand, ",", -1, CompareMethod.Text)

                        firmwareVersion_LBL.Text = "Build " & tmpSplit(1) & vbCrLf & "Compiled and uploaded on " & tmpSplit(2)
                        firwareUpdated = True



                    ElseIf (newCommand = "FTS") Then

                        Timer_dropAckTimeoutOFF()

                        ' drop sequence completed
                        ' reset for the next drop
                        debug("FTS received")

                        If (sequenceAborted = False) Then
                            debug("if (sequenceAborted = False) ")

                            If (SET_SOUND_BTN.Text = "ON") Then
                                My.Computer.Audio.Play(My.Resources.ready, AudioPlayMode.Background)
                            End If

                            initForNextDrop()
                        Else
                            debug("if (sequenceAborted = True) ")
                            sequenceAborted = False
                            debug("SequenceAborted = False ")
                        End If




                    ElseIf (newCommand = "YIA") Then
                        Timer_TestConnection_TimeoutOFF()
                        MsgBox("The dropController is connected.",, "Test Connection")
                        TestConnection_BTN.Text = "Test Connection"
                        TestConnection_BTN.Enabled = True



                    ElseIf (newCommand(0) = "M") Then
                        debug("MESSAGE: " & newCommand)




                    Else

                        '  debug(">>" & newCommand & "<<")







                    End If





                End If ' (length > 0) 

            End If

        End While

    End Sub






    Function getSerialInData() As String

        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub TAB_ABOUT_Click(sender As Object, e As EventArgs) Handles TAB_ABOUT.Click

    End Sub

    Private Sub About04_LBL_Click(sender As Object, e As EventArgs) Handles About04_LBL.Click

    End Sub

    Private Sub About02_LBL_Click(sender As Object, e As EventArgs) Handles About02_LBL.Click

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub COMport_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMport_CB.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles light_Combo.SelectedIndexChanged

    End Sub
End Class

