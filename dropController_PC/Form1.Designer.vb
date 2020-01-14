<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.timerConnectFlag = New System.Windows.Forms.Label()
        Me.timerConnect_LBL = New System.Windows.Forms.Label()
        Me.CT_IncDecTime_TB = New System.Windows.Forms.TextBox()
        Me.CT_IncDec_BTN = New System.Windows.Forms.Button()
        Me.FT1_IncDecTime_TB = New System.Windows.Forms.TextBox()
        Me.FT1_IncDec_BTN = New System.Windows.Forms.Button()
        Me.CT_StartTime_TB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FT1_Time_TB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumDrops_CB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer_recieveSerialData = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ConnectionTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.debugTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStripForm1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timer_updateConnectButton = New System.Windows.Forms.Timer(Me.components)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Connected_Flag = New System.Windows.Forms.Label()
        Me.checkConnected_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GraphTabControl = New System.Windows.Forms.TabControl()
        Me.TAB_DROPS = New System.Windows.Forms.TabPage()
        Me.FT3_BUTTON = New System.Windows.Forms.Button()
        Me.FT3_IncDecTime_TB = New System.Windows.Forms.TextBox()
        Me.FT3_IncDec_BTN = New System.Windows.Forms.Button()
        Me.FT3_Time_TB = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CT_BUTTON = New System.Windows.Forms.Button()
        Me.BulbMode_BTN = New System.Windows.Forms.Button()
        Me.BulbMode_LBL = New System.Windows.Forms.Label()
        Me.FT2_BUTTON = New System.Windows.Forms.Button()
        Me.FT1_BUTTON = New System.Windows.Forms.Button()
        Me.FT2_IncDecTime_TB = New System.Windows.Forms.TextBox()
        Me.FT2_IncDec_BTN = New System.Windows.Forms.Button()
        Me.FT2_Time_TB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.D3StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.D1Row_LBL = New System.Windows.Forms.Label()
        Me.D1Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D1Separator01_LBL = New System.Windows.Forms.Label()
        Me.D1StartTime_TB = New System.Windows.Forms.TextBox()
        Me.D1StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.D1StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D1Separator02_LBL = New System.Windows.Forms.Label()
        Me.D1Size_TB = New System.Windows.Forms.TextBox()
        Me.MainStart_BTN = New System.Windows.Forms.Button()
        Me.D1SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D1SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D9SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D2Row_LBL = New System.Windows.Forms.Label()
        Me.D9SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D2Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D9Size_TB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.D2StartTime_TB = New System.Windows.Forms.TextBox()
        Me.D9StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D2StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.D9StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.D2StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D9StartTime_TB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.D2Size_TB = New System.Windows.Forms.TextBox()
        Me.D9Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D2SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D9Row_LBL = New System.Windows.Forms.Label()
        Me.D2SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D8SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D3Row_LBL = New System.Windows.Forms.Label()
        Me.D8SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D3Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D8Size_TB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.D3StartTime_TB = New System.Windows.Forms.TextBox()
        Me.D8StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D3StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D8StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.D8StartTime_TB = New System.Windows.Forms.TextBox()
        Me.D3Size_TB = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.D3SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D8Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D3SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D8Row_LBL = New System.Windows.Forms.Label()
        Me.D4Row_LBL = New System.Windows.Forms.Label()
        Me.D7SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D4Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D7SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.D7Size_TB = New System.Windows.Forms.TextBox()
        Me.D4StartTime_TB = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.D4StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.D7StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D4StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D7StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.D7StartTime_TB = New System.Windows.Forms.TextBox()
        Me.D4Size_TB = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.D4SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D7Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D4SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D7Row_LBL = New System.Windows.Forms.Label()
        Me.D5Row_LBL = New System.Windows.Forms.Label()
        Me.D6SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D5Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D6SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.D6Size_TB = New System.Windows.Forms.TextBox()
        Me.D5StartTime_TB = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.D5StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.D6StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D5StartIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D6StartIncDec_BTN = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.D6StartTime_TB = New System.Windows.Forms.TextBox()
        Me.D5Size_TB = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.D5SizeIncDec_BTN = New System.Windows.Forms.Button()
        Me.D6Sol_CB = New System.Windows.Forms.ComboBox()
        Me.D5SizeIncVal_TB = New System.Windows.Forms.TextBox()
        Me.D6Row_LBL = New System.Windows.Forms.Label()
        Me.TAB_SETTINGS = New System.Windows.Forms.TabPage()
        Me.light_Combo = New System.Windows.Forms.ComboBox()
        Me.laser_Combo = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Version_ComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FT3_Pulse_lbl = New System.Windows.Forms.Label()
        Me.FT3_Pulse_TB = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.mirrorLockupOnOff_BTN = New System.Windows.Forms.Button()
        Me.ML_Time_LBL = New System.Windows.Forms.Label()
        Me.mirrorLockupTime_TB = New System.Windows.Forms.TextBox()
        Me.FT1_Pulse_lbl = New System.Windows.Forms.Label()
        Me.CT_Pulse_lbl = New System.Windows.Forms.Label()
        Me.SET_LEO_BUT = New System.Windows.Forms.Button()
        Me.FT1_Pulse_TB = New System.Windows.Forms.TextBox()
        Me.SET_LEO_LBL = New System.Windows.Forms.Label()
        Me.BulbStartOffset_Time_TB = New System.Windows.Forms.TextBox()
        Me.CT_Pulse_TB = New System.Windows.Forms.TextBox()
        Me.BulbStart_LBL = New System.Windows.Forms.Label()
        Me.BulbStopOffset_Time_TB = New System.Windows.Forms.TextBox()
        Me.SET_SOUND_LBL = New System.Windows.Forms.Label()
        Me.BulbStop_LBL = New System.Windows.Forms.Label()
        Me.SET_SOUND_BTN = New System.Windows.Forms.Button()
        Me.FT2_Pulse_lbl = New System.Windows.Forms.Label()
        Me.FT2_Pulse_TB = New System.Windows.Forms.TextBox()
        Me.LP_waitTimeVal_TB = New System.Windows.Forms.TextBox()
        Me.lp_TimerOrButton_BTN = New System.Windows.Forms.Button()
        Me.waitTime_LBL = New System.Windows.Forms.Label()
        Me.timerButton_LBL = New System.Windows.Forms.Label()
        Me.LoopMode_BTN = New System.Windows.Forms.Button()
        Me.LoopMode_LBL = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ResetAll_BTN = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TestConnection_BTN = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.COMport_CB = New System.Windows.Forms.ComboBox()
        Me.refreshCOM_BTN = New System.Windows.Forms.Button()
        Me.SET_DEBUG_BTN = New System.Windows.Forms.Button()
        Me.SET_DEBUG_LBL = New System.Windows.Forms.Label()
        Me.lbl_VD4 = New System.Windows.Forms.Label()
        Me.valve4Drain_BTN = New System.Windows.Forms.Button()
        Me.lbl_VD3 = New System.Windows.Forms.Label()
        Me.lbl_VD2 = New System.Windows.Forms.Label()
        Me.lbl_VD1 = New System.Windows.Forms.Label()
        Me.valve3Drain_BTN = New System.Windows.Forms.Button()
        Me.valve2Drain_BTN = New System.Windows.Forms.Button()
        Me.valve1Drain_BTN = New System.Windows.Forms.Button()
        Me.ValveDrain_LBL = New System.Windows.Forms.Label()
        Me.TAB_GRAPH = New System.Windows.Forms.TabPage()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TAB_ABOUT = New System.Windows.Forms.TabPage()
        Me.About05_LBL = New System.Windows.Forms.Label()
        Me.About04_LBL = New System.Windows.Forms.Label()
        Me.About03_LBL = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.firmwareVersion_LBL = New System.Windows.Forms.Label()
        Me.ABOUT_LINK_LBL = New System.Windows.Forms.Label()
        Me.About02_LBL = New System.Windows.Forms.Label()
        Me.About01_LBL = New System.Windows.Forms.Label()
        Me.AboutTab_Picture1 = New System.Windows.Forms.PictureBox()
        Me.AboutTab_Picture2 = New System.Windows.Forms.PictureBox()
        Me.AboutTab_Picture3 = New System.Windows.Forms.PictureBox()
        Me.G_CAM_LBL = New System.Windows.Forms.Label()
        Me.G_T2_LBL = New System.Windows.Forms.Label()
        Me.G_T1_LBL = New System.Windows.Forms.Label()
        Me.G_D4_LBL = New System.Windows.Forms.Label()
        Me.G_D3_LBL = New System.Windows.Forms.Label()
        Me.G_D2_LBL = New System.Windows.Forms.Label()
        Me.G_D1_LBL = New System.Windows.Forms.Label()
        Me.Timer_LoopDelay = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_dropAckTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Timer_LoopDelay_LBL = New System.Windows.Forms.Label()
        Me.TimerACK_LBL = New System.Windows.Forms.Label()
        Me.Timer_LoadImages = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Loop_FT3_LBL = New System.Windows.Forms.Label()
        Me.LP_FT3_LBL = New System.Windows.Forms.Label()
        Me.LP_STOP_BTN = New System.Windows.Forms.Button()
        Me.LP_Sequence_LBL = New System.Windows.Forms.Label()
        Me.Loop_Title_LBL = New System.Windows.Forms.Label()
        Me.Loop_FT2_LBL = New System.Windows.Forms.Label()
        Me.LP_FT2_LBL = New System.Windows.Forms.Label()
        Me.progressBar_LBL = New System.Windows.Forms.Label()
        Me.LP_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.sizeHead_LBL = New System.Windows.Forms.Label()
        Me.stopHead_LBL = New System.Windows.Forms.Label()
        Me.startHead_lbl = New System.Windows.Forms.Label()
        Me.solHead_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum1_LBL = New System.Windows.Forms.Label()
        Me.Loop_seq_LBL = New System.Windows.Forms.Label()
        Me.LP_ML_LBL = New System.Windows.Forms.Label()
        Me.Loop_CT_LBL = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.LP_CT_LBL = New System.Windows.Forms.Label()
        Me.Loop_FT1_LBL = New System.Windows.Forms.Label()
        Me.LP_FT1_LBL = New System.Windows.Forms.Label()
        Me.drop9_LBL = New System.Windows.Forms.Label()
        Me.drop8_LBL = New System.Windows.Forms.Label()
        Me.drop7_LBL = New System.Windows.Forms.Label()
        Me.drop6_LBL = New System.Windows.Forms.Label()
        Me.drop5_LBL = New System.Windows.Forms.Label()
        Me.drop4_LBL = New System.Windows.Forms.Label()
        Me.drop3_LBL = New System.Windows.Forms.Label()
        Me.drop2_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum9_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum8_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum7_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum6_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum5_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum4_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum3_LBL = New System.Windows.Forms.Label()
        Me.LP_dropNum2_LBL = New System.Windows.Forms.Label()
        Me.drop1_LBL = New System.Windows.Forms.Label()
        Me.LP_EXIT_BTN = New System.Windows.Forms.Button()
        Me.LP_RESET_BTN = New System.Windows.Forms.Button()
        Me.LP_START_BTN = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.STATUS_LBL = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Timer_SD_IN_LBL = New System.Windows.Forms.Label()
        Me.Timer_TestConnection_Timeout = New System.Windows.Forms.Timer(Me.components)
        Me.Label28 = New System.Windows.Forms.Label()
        Me.SaveConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripForm1.SuspendLayout()
        Me.GraphTabControl.SuspendLayout()
        Me.TAB_DROPS.SuspendLayout()
        Me.TAB_SETTINGS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TAB_GRAPH.SuspendLayout()
        Me.TAB_ABOUT.SuspendLayout()
        CType(Me.AboutTab_Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AboutTab_Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AboutTab_Picture3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerConnectFlag
        '
        Me.timerConnectFlag.AutoSize = True
        Me.timerConnectFlag.Location = New System.Drawing.Point(956, 65)
        Me.timerConnectFlag.Name = "timerConnectFlag"
        Me.timerConnectFlag.Size = New System.Drawing.Size(27, 13)
        Me.timerConnectFlag.TabIndex = 536
        Me.timerConnectFlag.Text = "OFF"
        '
        'timerConnect_LBL
        '
        Me.timerConnect_LBL.AutoSize = True
        Me.timerConnect_LBL.Location = New System.Drawing.Point(843, 65)
        Me.timerConnect_LBL.Name = "timerConnect_LBL"
        Me.timerConnect_LBL.Size = New System.Drawing.Size(94, 13)
        Me.timerConnect_LBL.TabIndex = 535
        Me.timerConnect_LBL.Text = "Con timeout timer="
        '
        'CT_IncDecTime_TB
        '
        Me.CT_IncDecTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CT_IncDecTime_TB.Location = New System.Drawing.Point(715, 170)
        Me.CT_IncDecTime_TB.MaxLength = 3
        Me.CT_IncDecTime_TB.Name = "CT_IncDecTime_TB"
        Me.CT_IncDecTime_TB.Size = New System.Drawing.Size(55, 26)
        Me.CT_IncDecTime_TB.TabIndex = 632
        Me.CT_IncDecTime_TB.Text = "000"
        Me.CT_IncDecTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CT_IncDec_BTN
        '
        Me.CT_IncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CT_IncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CT_IncDec_BTN.Location = New System.Drawing.Point(656, 168)
        Me.CT_IncDec_BTN.Name = "CT_IncDec_BTN"
        Me.CT_IncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.CT_IncDec_BTN.TabIndex = 631
        Me.CT_IncDec_BTN.Text = "INC"
        Me.CT_IncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CT_IncDec_BTN.UseVisualStyleBackColor = False
        '
        'FT1_IncDecTime_TB
        '
        Me.FT1_IncDecTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT1_IncDecTime_TB.Location = New System.Drawing.Point(717, 246)
        Me.FT1_IncDecTime_TB.MaxLength = 3
        Me.FT1_IncDecTime_TB.Name = "FT1_IncDecTime_TB"
        Me.FT1_IncDecTime_TB.Size = New System.Drawing.Size(53, 26)
        Me.FT1_IncDecTime_TB.TabIndex = 626
        Me.FT1_IncDecTime_TB.Text = "000"
        Me.FT1_IncDecTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FT1_IncDec_BTN
        '
        Me.FT1_IncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FT1_IncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT1_IncDec_BTN.Location = New System.Drawing.Point(656, 244)
        Me.FT1_IncDec_BTN.Name = "FT1_IncDec_BTN"
        Me.FT1_IncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.FT1_IncDec_BTN.TabIndex = 625
        Me.FT1_IncDec_BTN.Text = "INC"
        Me.FT1_IncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FT1_IncDec_BTN.UseVisualStyleBackColor = False
        '
        'CT_StartTime_TB
        '
        Me.CT_StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CT_StartTime_TB.Location = New System.Drawing.Point(589, 170)
        Me.CT_StartTime_TB.MaxLength = 4
        Me.CT_StartTime_TB.Name = "CT_StartTime_TB"
        Me.CT_StartTime_TB.Size = New System.Drawing.Size(51, 26)
        Me.CT_StartTime_TB.TabIndex = 630
        Me.CT_StartTime_TB.Text = "0000"
        Me.CT_StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(585, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 437
        Me.Label10.Text = "Camera Trigger"
        '
        'FT1_Time_TB
        '
        Me.FT1_Time_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT1_Time_TB.Location = New System.Drawing.Point(589, 246)
        Me.FT1_Time_TB.MaxLength = 4
        Me.FT1_Time_TB.Name = "FT1_Time_TB"
        Me.FT1_Time_TB.Size = New System.Drawing.Size(51, 26)
        Me.FT1_Time_TB.TabIndex = 624
        Me.FT1_Time_TB.Text = "0000"
        Me.FT1_Time_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(589, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 436
        Me.Label9.Text = "Flash Trigger 1"
        '
        'NumDrops_CB
        '
        Me.NumDrops_CB.AllowDrop = True
        Me.NumDrops_CB.DropDownWidth = 40
        Me.NumDrops_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDrops_CB.FormattingEnabled = True
        Me.NumDrops_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.NumDrops_CB.ItemHeight = 20
        Me.NumDrops_CB.Items.AddRange(New Object() {" 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9"})
        Me.NumDrops_CB.Location = New System.Drawing.Point(724, 56)
        Me.NumDrops_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.NumDrops_CB.Name = "NumDrops_CB"
        Me.NumDrops_CB.Size = New System.Drawing.Size(46, 28)
        Me.NumDrops_CB.TabIndex = 424
        Me.NumDrops_CB.Text = " 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(585, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 435
        Me.Label8.Text = "Number of Drops"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_recieveSerialData
        '
        Me.Timer_recieveSerialData.Interval = 200
        '
        'Timer_ConnectionTimeout
        '
        Me.Timer_ConnectionTimeout.Interval = 4000
        '
        'debugTextBox
        '
        Me.debugTextBox.Location = New System.Drawing.Point(846, 120)
        Me.debugTextBox.Multiline = True
        Me.debugTextBox.Name = "debugTextBox"
        Me.debugTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.debugTextBox.Size = New System.Drawing.Size(249, 435)
        Me.debugTextBox.TabIndex = 537
        '
        'MenuStripForm1
        '
        Me.MenuStripForm1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStripForm1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripForm1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStripForm1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripForm1.Name = "MenuStripForm1"
        Me.MenuStripForm1.Size = New System.Drawing.Size(1159, 24)
        Me.MenuStripForm1.TabIndex = 538
        Me.MenuStripForm1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveConfigToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Visit the website"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem1.Text = "Forum"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'timer_updateConnectButton
        '
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(843, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 542
        Me.Label22.Text = "COMportStatus ="
        '
        'Connected_Flag
        '
        Me.Connected_Flag.AutoSize = True
        Me.Connected_Flag.Location = New System.Drawing.Point(943, 52)
        Me.Connected_Flag.Name = "Connected_Flag"
        Me.Connected_Flag.Size = New System.Drawing.Size(40, 13)
        Me.Connected_Flag.TabIndex = 543
        Me.Connected_Flag.Text = "FALSE"
        '
        'checkConnected_Timer
        '
        Me.checkConnected_Timer.Interval = 1000
        '
        'GraphTabControl
        '
        Me.GraphTabControl.Controls.Add(Me.TAB_DROPS)
        Me.GraphTabControl.Controls.Add(Me.TAB_SETTINGS)
        Me.GraphTabControl.Controls.Add(Me.TAB_GRAPH)
        Me.GraphTabControl.Controls.Add(Me.TAB_ABOUT)
        Me.GraphTabControl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphTabControl.Location = New System.Drawing.Point(12, 40)
        Me.GraphTabControl.Name = "GraphTabControl"
        Me.GraphTabControl.SelectedIndex = 0
        Me.GraphTabControl.Size = New System.Drawing.Size(810, 520)
        Me.GraphTabControl.TabIndex = 544
        '
        'TAB_DROPS
        '
        Me.TAB_DROPS.Controls.Add(Me.FT3_BUTTON)
        Me.TAB_DROPS.Controls.Add(Me.FT3_IncDecTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.FT3_IncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.FT3_Time_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label31)
        Me.TAB_DROPS.Controls.Add(Me.CT_BUTTON)
        Me.TAB_DROPS.Controls.Add(Me.BulbMode_BTN)
        Me.TAB_DROPS.Controls.Add(Me.BulbMode_LBL)
        Me.TAB_DROPS.Controls.Add(Me.FT2_BUTTON)
        Me.TAB_DROPS.Controls.Add(Me.FT1_BUTTON)
        Me.TAB_DROPS.Controls.Add(Me.FT2_IncDecTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.FT2_IncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.FT2_Time_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label16)
        Me.TAB_DROPS.Controls.Add(Me.Label1)
        Me.TAB_DROPS.Controls.Add(Me.Label2)
        Me.TAB_DROPS.Controls.Add(Me.Label3)
        Me.TAB_DROPS.Controls.Add(Me.Label4)
        Me.TAB_DROPS.Controls.Add(Me.Label5)
        Me.TAB_DROPS.Controls.Add(Me.Label6)
        Me.TAB_DROPS.Controls.Add(Me.Label7)
        Me.TAB_DROPS.Controls.Add(Me.D3StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D1Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D1Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D1Separator01_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D1StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D1StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.CT_IncDecTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D1StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label10)
        Me.TAB_DROPS.Controls.Add(Me.CT_IncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.CT_StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D1Separator02_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D1Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.MainStart_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D1SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D1SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.FT1_IncDecTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D9SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.FT1_IncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D2Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D9SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.FT1_Time_TB)
        Me.TAB_DROPS.Controls.Add(Me.D2Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.Label9)
        Me.TAB_DROPS.Controls.Add(Me.D9Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label12)
        Me.TAB_DROPS.Controls.Add(Me.Label32)
        Me.TAB_DROPS.Controls.Add(Me.NumDrops_CB)
        Me.TAB_DROPS.Controls.Add(Me.D2StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label8)
        Me.TAB_DROPS.Controls.Add(Me.D9StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D2StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D9StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D2StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D9StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label11)
        Me.TAB_DROPS.Controls.Add(Me.Label33)
        Me.TAB_DROPS.Controls.Add(Me.D2Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.D9Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D2SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D9Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D2SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D8SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D3Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D8SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D3Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D8Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label15)
        Me.TAB_DROPS.Controls.Add(Me.Label20)
        Me.TAB_DROPS.Controls.Add(Me.D3StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D8StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D3StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D8StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.Label14)
        Me.TAB_DROPS.Controls.Add(Me.D8StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D3Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label21)
        Me.TAB_DROPS.Controls.Add(Me.D3SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D8Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D3SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D8Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D4Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D7SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D4Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D7SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.Label18)
        Me.TAB_DROPS.Controls.Add(Me.D7Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.D4StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label23)
        Me.TAB_DROPS.Controls.Add(Me.D4StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D7StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D4StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D7StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.Label17)
        Me.TAB_DROPS.Controls.Add(Me.D7StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D4Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label24)
        Me.TAB_DROPS.Controls.Add(Me.D4SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D7Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D4SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D7Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D5Row_LBL)
        Me.TAB_DROPS.Controls.Add(Me.D6SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D5Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D6SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.Label30)
        Me.TAB_DROPS.Controls.Add(Me.D6Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.D5StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label26)
        Me.TAB_DROPS.Controls.Add(Me.D5StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D6StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D5StartIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D6StartIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.Label29)
        Me.TAB_DROPS.Controls.Add(Me.D6StartTime_TB)
        Me.TAB_DROPS.Controls.Add(Me.D5Size_TB)
        Me.TAB_DROPS.Controls.Add(Me.Label27)
        Me.TAB_DROPS.Controls.Add(Me.D5SizeIncDec_BTN)
        Me.TAB_DROPS.Controls.Add(Me.D6Sol_CB)
        Me.TAB_DROPS.Controls.Add(Me.D5SizeIncVal_TB)
        Me.TAB_DROPS.Controls.Add(Me.D6Row_LBL)
        Me.TAB_DROPS.Location = New System.Drawing.Point(4, 25)
        Me.TAB_DROPS.Name = "TAB_DROPS"
        Me.TAB_DROPS.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_DROPS.Size = New System.Drawing.Size(802, 491)
        Me.TAB_DROPS.TabIndex = 0
        Me.TAB_DROPS.Text = "Drops"
        Me.TAB_DROPS.UseVisualStyleBackColor = True
        '
        'FT3_BUTTON
        '
        Me.FT3_BUTTON.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FT3_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT3_BUTTON.Location = New System.Drawing.Point(715, 361)
        Me.FT3_BUTTON.Name = "FT3_BUTTON"
        Me.FT3_BUTTON.Size = New System.Drawing.Size(55, 28)
        Me.FT3_BUTTON.TabIndex = 638
        Me.FT3_BUTTON.Text = "ON"
        Me.FT3_BUTTON.UseVisualStyleBackColor = False
        '
        'FT3_IncDecTime_TB
        '
        Me.FT3_IncDecTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT3_IncDecTime_TB.Location = New System.Drawing.Point(717, 396)
        Me.FT3_IncDecTime_TB.MaxLength = 3
        Me.FT3_IncDecTime_TB.Name = "FT3_IncDecTime_TB"
        Me.FT3_IncDecTime_TB.Size = New System.Drawing.Size(53, 26)
        Me.FT3_IncDecTime_TB.TabIndex = 637
        Me.FT3_IncDecTime_TB.Text = "000"
        Me.FT3_IncDecTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FT3_IncDec_BTN
        '
        Me.FT3_IncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FT3_IncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT3_IncDec_BTN.Location = New System.Drawing.Point(656, 395)
        Me.FT3_IncDec_BTN.Name = "FT3_IncDec_BTN"
        Me.FT3_IncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.FT3_IncDec_BTN.TabIndex = 636
        Me.FT3_IncDec_BTN.Text = "INC"
        Me.FT3_IncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FT3_IncDec_BTN.UseVisualStyleBackColor = False
        '
        'FT3_Time_TB
        '
        Me.FT3_Time_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT3_Time_TB.Location = New System.Drawing.Point(589, 396)
        Me.FT3_Time_TB.MaxLength = 4
        Me.FT3_Time_TB.Name = "FT3_Time_TB"
        Me.FT3_Time_TB.Size = New System.Drawing.Size(51, 26)
        Me.FT3_Time_TB.TabIndex = 635
        Me.FT3_Time_TB.Text = "0000"
        Me.FT3_Time_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(589, 366)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 20)
        Me.Label31.TabIndex = 634
        Me.Label31.Text = "Flash Trigger 3"
        '
        'CT_BUTTON
        '
        Me.CT_BUTTON.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CT_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CT_BUTTON.Location = New System.Drawing.Point(715, 102)
        Me.CT_BUTTON.Name = "CT_BUTTON"
        Me.CT_BUTTON.Size = New System.Drawing.Size(55, 28)
        Me.CT_BUTTON.TabIndex = 633
        Me.CT_BUTTON.Text = "ON"
        Me.CT_BUTTON.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CT_BUTTON.UseVisualStyleBackColor = False
        '
        'BulbMode_BTN
        '
        Me.BulbMode_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BulbMode_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BulbMode_BTN.Location = New System.Drawing.Point(715, 136)
        Me.BulbMode_BTN.Name = "BulbMode_BTN"
        Me.BulbMode_BTN.Size = New System.Drawing.Size(55, 28)
        Me.BulbMode_BTN.TabIndex = 629
        Me.BulbMode_BTN.Text = "OFF"
        Me.BulbMode_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BulbMode_BTN.UseVisualStyleBackColor = False
        '
        'BulbMode_LBL
        '
        Me.BulbMode_LBL.AutoSize = True
        Me.BulbMode_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BulbMode_LBL.Location = New System.Drawing.Point(589, 138)
        Me.BulbMode_LBL.Name = "BulbMode_LBL"
        Me.BulbMode_LBL.Size = New System.Drawing.Size(85, 20)
        Me.BulbMode_LBL.TabIndex = 631
        Me.BulbMode_LBL.Text = "Bulb Mode"
        '
        'FT2_BUTTON
        '
        Me.FT2_BUTTON.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FT2_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT2_BUTTON.Location = New System.Drawing.Point(715, 287)
        Me.FT2_BUTTON.Name = "FT2_BUTTON"
        Me.FT2_BUTTON.Size = New System.Drawing.Size(55, 28)
        Me.FT2_BUTTON.TabIndex = 629
        Me.FT2_BUTTON.Text = "ON"
        Me.FT2_BUTTON.UseVisualStyleBackColor = False
        '
        'FT1_BUTTON
        '
        Me.FT1_BUTTON.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FT1_BUTTON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT1_BUTTON.Location = New System.Drawing.Point(715, 211)
        Me.FT1_BUTTON.Name = "FT1_BUTTON"
        Me.FT1_BUTTON.Size = New System.Drawing.Size(55, 28)
        Me.FT1_BUTTON.TabIndex = 623
        Me.FT1_BUTTON.Text = "ON"
        Me.FT1_BUTTON.UseVisualStyleBackColor = False
        '
        'FT2_IncDecTime_TB
        '
        Me.FT2_IncDecTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT2_IncDecTime_TB.Location = New System.Drawing.Point(717, 322)
        Me.FT2_IncDecTime_TB.MaxLength = 3
        Me.FT2_IncDecTime_TB.Name = "FT2_IncDecTime_TB"
        Me.FT2_IncDecTime_TB.Size = New System.Drawing.Size(53, 26)
        Me.FT2_IncDecTime_TB.TabIndex = 628
        Me.FT2_IncDecTime_TB.Text = "000"
        Me.FT2_IncDecTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FT2_IncDec_BTN
        '
        Me.FT2_IncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FT2_IncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT2_IncDec_BTN.Location = New System.Drawing.Point(656, 321)
        Me.FT2_IncDec_BTN.Name = "FT2_IncDec_BTN"
        Me.FT2_IncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.FT2_IncDec_BTN.TabIndex = 627
        Me.FT2_IncDec_BTN.Text = "INC"
        Me.FT2_IncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FT2_IncDec_BTN.UseVisualStyleBackColor = False
        '
        'FT2_Time_TB
        '
        Me.FT2_Time_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT2_Time_TB.Location = New System.Drawing.Point(589, 322)
        Me.FT2_Time_TB.MaxLength = 4
        Me.FT2_Time_TB.Name = "FT2_Time_TB"
        Me.FT2_Time_TB.Size = New System.Drawing.Size(51, 26)
        Me.FT2_Time_TB.TabIndex = 626
        Me.FT2_Time_TB.Text = "0000"
        Me.FT2_Time_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(589, 292)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 20)
        Me.Label16.TabIndex = 624
        Me.Label16.Text = "Flash Trigger 2 "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 526
        Me.Label1.Text = "SOL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 529
        Me.Label2.Text = "START"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 41)
        Me.Label3.TabIndex = 532
        Me.Label3.Text = "INC / DEC"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 41)
        Me.Label4.TabIndex = 530
        Me.Label4.Text = "INC/DEC TIME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 531
        Me.Label5.Text = "SIZE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(446, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 41)
        Me.Label6.TabIndex = 528
        Me.Label6.Text = "INC / DEC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(492, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 41)
        Me.Label7.TabIndex = 527
        Me.Label7.Text = "INC/DEC TIME"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'D3StartIncDec_BTN
        '
        Me.D3StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D3StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3StartIncDec_BTN.Location = New System.Drawing.Point(234, 133)
        Me.D3StartIncDec_BTN.Name = "D3StartIncDec_BTN"
        Me.D3StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D3StartIncDec_BTN.TabIndex = 557
        Me.D3StartIncDec_BTN.Text = "INC"
        Me.D3StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D3StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D1Row_LBL
        '
        Me.D1Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1Row_LBL.Location = New System.Drawing.Point(13, 59)
        Me.D1Row_LBL.Name = "D1Row_LBL"
        Me.D1Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D1Row_LBL.TabIndex = 533
        Me.D1Row_LBL.Text = "Drop 1"
        Me.D1Row_LBL.UseWaitCursor = True
        '
        'D1Sol_CB
        '
        Me.D1Sol_CB.AllowDrop = True
        Me.D1Sol_CB.DropDownWidth = 40
        Me.D1Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1Sol_CB.FormattingEnabled = True
        Me.D1Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D1Sol_CB.ItemHeight = 20
        Me.D1Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D1Sol_CB.Location = New System.Drawing.Point(97, 57)
        Me.D1Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D1Sol_CB.Name = "D1Sol_CB"
        Me.D1Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D1Sol_CB.TabIndex = 535
        Me.D1Sol_CB.Text = " 1"
        '
        'D1Separator01_LBL
        '
        Me.D1Separator01_LBL.AutoSize = True
        Me.D1Separator01_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1Separator01_LBL.Location = New System.Drawing.Point(150, 62)
        Me.D1Separator01_LBL.Name = "D1Separator01_LBL"
        Me.D1Separator01_LBL.Size = New System.Drawing.Size(14, 18)
        Me.D1Separator01_LBL.TabIndex = 534
        Me.D1Separator01_LBL.Text = "-"
        '
        'D1StartTime_TB
        '
        Me.D1StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1StartTime_TB.Location = New System.Drawing.Point(170, 57)
        Me.D1StartTime_TB.MaxLength = 4
        Me.D1StartTime_TB.Name = "D1StartTime_TB"
        Me.D1StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D1StartTime_TB.TabIndex = 536
        Me.D1StartTime_TB.Text = "0000"
        Me.D1StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D1StartIncDec_BTN
        '
        Me.D1StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D1StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1StartIncDec_BTN.Location = New System.Drawing.Point(234, 57)
        Me.D1StartIncDec_BTN.Name = "D1StartIncDec_BTN"
        Me.D1StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D1StartIncDec_BTN.TabIndex = 537
        Me.D1StartIncDec_BTN.Text = "INC"
        Me.D1StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D1StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D1StartIncVal_TB
        '
        Me.D1StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1StartIncVal_TB.Location = New System.Drawing.Point(297, 57)
        Me.D1StartIncVal_TB.MaxLength = 3
        Me.D1StartIncVal_TB.Name = "D1StartIncVal_TB"
        Me.D1StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D1StartIncVal_TB.TabIndex = 538
        Me.D1StartIncVal_TB.Text = "000"
        Me.D1StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D1Separator02_LBL
        '
        Me.D1Separator02_LBL.AutoSize = True
        Me.D1Separator02_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1Separator02_LBL.Location = New System.Drawing.Point(356, 62)
        Me.D1Separator02_LBL.Name = "D1Separator02_LBL"
        Me.D1Separator02_LBL.Size = New System.Drawing.Size(14, 18)
        Me.D1Separator02_LBL.TabIndex = 539
        Me.D1Separator02_LBL.Text = "-"
        '
        'D1Size_TB
        '
        Me.D1Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1Size_TB.Location = New System.Drawing.Point(380, 57)
        Me.D1Size_TB.MaxLength = 4
        Me.D1Size_TB.Name = "D1Size_TB"
        Me.D1Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D1Size_TB.TabIndex = 540
        Me.D1Size_TB.Text = "0030"
        Me.D1Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MainStart_BTN
        '
        Me.MainStart_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MainStart_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainStart_BTN.Location = New System.Drawing.Point(17, 420)
        Me.MainStart_BTN.Name = "MainStart_BTN"
        Me.MainStart_BTN.Size = New System.Drawing.Size(536, 56)
        Me.MainStart_BTN.TabIndex = 623
        Me.MainStart_BTN.Text = "S T A R T"
        Me.MainStart_BTN.UseVisualStyleBackColor = False
        '
        'D1SizeIncDec_BTN
        '
        Me.D1SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D1SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1SizeIncDec_BTN.Location = New System.Drawing.Point(442, 57)
        Me.D1SizeIncDec_BTN.Name = "D1SizeIncDec_BTN"
        Me.D1SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D1SizeIncDec_BTN.TabIndex = 541
        Me.D1SizeIncDec_BTN.Text = "INC"
        Me.D1SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D1SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D1SizeIncVal_TB
        '
        Me.D1SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D1SizeIncVal_TB.Location = New System.Drawing.Point(505, 57)
        Me.D1SizeIncVal_TB.MaxLength = 3
        Me.D1SizeIncVal_TB.Name = "D1SizeIncVal_TB"
        Me.D1SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D1SizeIncVal_TB.TabIndex = 542
        Me.D1SizeIncVal_TB.Text = "000"
        Me.D1SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D9SizeIncVal_TB
        '
        Me.D9SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9SizeIncVal_TB.Location = New System.Drawing.Point(505, 361)
        Me.D9SizeIncVal_TB.MaxLength = 3
        Me.D9SizeIncVal_TB.Name = "D9SizeIncVal_TB"
        Me.D9SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D9SizeIncVal_TB.TabIndex = 622
        Me.D9SizeIncVal_TB.Text = "000"
        Me.D9SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2Row_LBL
        '
        Me.D2Row_LBL.AutoSize = True
        Me.D2Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2Row_LBL.Location = New System.Drawing.Point(13, 97)
        Me.D2Row_LBL.Name = "D2Row_LBL"
        Me.D2Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D2Row_LBL.TabIndex = 543
        Me.D2Row_LBL.Text = "Drop 2"
        '
        'D9SizeIncDec_BTN
        '
        Me.D9SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D9SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9SizeIncDec_BTN.Location = New System.Drawing.Point(442, 361)
        Me.D9SizeIncDec_BTN.Name = "D9SizeIncDec_BTN"
        Me.D9SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D9SizeIncDec_BTN.TabIndex = 621
        Me.D9SizeIncDec_BTN.Text = "INC"
        Me.D9SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D9SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D2Sol_CB
        '
        Me.D2Sol_CB.AllowDrop = True
        Me.D2Sol_CB.DropDownWidth = 40
        Me.D2Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2Sol_CB.FormattingEnabled = True
        Me.D2Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D2Sol_CB.ItemHeight = 20
        Me.D2Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D2Sol_CB.Location = New System.Drawing.Point(97, 95)
        Me.D2Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D2Sol_CB.Name = "D2Sol_CB"
        Me.D2Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D2Sol_CB.TabIndex = 545
        Me.D2Sol_CB.Text = " 1"
        '
        'D9Size_TB
        '
        Me.D9Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9Size_TB.Location = New System.Drawing.Point(380, 361)
        Me.D9Size_TB.MaxLength = 4
        Me.D9Size_TB.Name = "D9Size_TB"
        Me.D9Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D9Size_TB.TabIndex = 620
        Me.D9Size_TB.Text = "0030"
        Me.D9Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(150, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 18)
        Me.Label12.TabIndex = 544
        Me.Label12.Text = "-"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(356, 366)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 18)
        Me.Label32.TabIndex = 619
        Me.Label32.Text = "-"
        '
        'D2StartTime_TB
        '
        Me.D2StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2StartTime_TB.Location = New System.Drawing.Point(170, 95)
        Me.D2StartTime_TB.MaxLength = 4
        Me.D2StartTime_TB.Name = "D2StartTime_TB"
        Me.D2StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D2StartTime_TB.TabIndex = 546
        Me.D2StartTime_TB.Text = "0000"
        Me.D2StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D9StartIncVal_TB
        '
        Me.D9StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9StartIncVal_TB.Location = New System.Drawing.Point(297, 361)
        Me.D9StartIncVal_TB.MaxLength = 3
        Me.D9StartIncVal_TB.Name = "D9StartIncVal_TB"
        Me.D9StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D9StartIncVal_TB.TabIndex = 618
        Me.D9StartIncVal_TB.Text = "000"
        Me.D9StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D2StartIncDec_BTN
        '
        Me.D2StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D2StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2StartIncDec_BTN.Location = New System.Drawing.Point(234, 95)
        Me.D2StartIncDec_BTN.Name = "D2StartIncDec_BTN"
        Me.D2StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D2StartIncDec_BTN.TabIndex = 547
        Me.D2StartIncDec_BTN.Text = "INC"
        Me.D2StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D2StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D9StartIncDec_BTN
        '
        Me.D9StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D9StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9StartIncDec_BTN.Location = New System.Drawing.Point(234, 361)
        Me.D9StartIncDec_BTN.Name = "D9StartIncDec_BTN"
        Me.D9StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D9StartIncDec_BTN.TabIndex = 617
        Me.D9StartIncDec_BTN.Text = "INC"
        Me.D9StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D9StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D2StartIncVal_TB
        '
        Me.D2StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2StartIncVal_TB.Location = New System.Drawing.Point(297, 95)
        Me.D2StartIncVal_TB.MaxLength = 3
        Me.D2StartIncVal_TB.Name = "D2StartIncVal_TB"
        Me.D2StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D2StartIncVal_TB.TabIndex = 548
        Me.D2StartIncVal_TB.Text = "000"
        Me.D2StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D9StartTime_TB
        '
        Me.D9StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9StartTime_TB.Location = New System.Drawing.Point(170, 361)
        Me.D9StartTime_TB.MaxLength = 4
        Me.D9StartTime_TB.Name = "D9StartTime_TB"
        Me.D9StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D9StartTime_TB.TabIndex = 616
        Me.D9StartTime_TB.Text = "0000"
        Me.D9StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(356, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 18)
        Me.Label11.TabIndex = 549
        Me.Label11.Text = "-"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(150, 366)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(14, 18)
        Me.Label33.TabIndex = 614
        Me.Label33.Text = "-"
        '
        'D2Size_TB
        '
        Me.D2Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2Size_TB.Location = New System.Drawing.Point(380, 95)
        Me.D2Size_TB.MaxLength = 4
        Me.D2Size_TB.Name = "D2Size_TB"
        Me.D2Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D2Size_TB.TabIndex = 550
        Me.D2Size_TB.Text = "0030"
        Me.D2Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D9Sol_CB
        '
        Me.D9Sol_CB.AllowDrop = True
        Me.D9Sol_CB.DropDownWidth = 40
        Me.D9Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9Sol_CB.FormattingEnabled = True
        Me.D9Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D9Sol_CB.ItemHeight = 20
        Me.D9Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D9Sol_CB.Location = New System.Drawing.Point(97, 361)
        Me.D9Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D9Sol_CB.Name = "D9Sol_CB"
        Me.D9Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D9Sol_CB.TabIndex = 615
        Me.D9Sol_CB.Text = " 1"
        '
        'D2SizeIncDec_BTN
        '
        Me.D2SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D2SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2SizeIncDec_BTN.Location = New System.Drawing.Point(442, 95)
        Me.D2SizeIncDec_BTN.Name = "D2SizeIncDec_BTN"
        Me.D2SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D2SizeIncDec_BTN.TabIndex = 551
        Me.D2SizeIncDec_BTN.Text = "INC"
        Me.D2SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D2SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D9Row_LBL
        '
        Me.D9Row_LBL.AutoSize = True
        Me.D9Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D9Row_LBL.Location = New System.Drawing.Point(13, 363)
        Me.D9Row_LBL.Name = "D9Row_LBL"
        Me.D9Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D9Row_LBL.TabIndex = 613
        Me.D9Row_LBL.Text = "Drop 9"
        '
        'D2SizeIncVal_TB
        '
        Me.D2SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D2SizeIncVal_TB.Location = New System.Drawing.Point(505, 95)
        Me.D2SizeIncVal_TB.MaxLength = 3
        Me.D2SizeIncVal_TB.Name = "D2SizeIncVal_TB"
        Me.D2SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D2SizeIncVal_TB.TabIndex = 552
        Me.D2SizeIncVal_TB.Text = "000"
        Me.D2SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D8SizeIncVal_TB
        '
        Me.D8SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8SizeIncVal_TB.Location = New System.Drawing.Point(505, 323)
        Me.D8SizeIncVal_TB.MaxLength = 3
        Me.D8SizeIncVal_TB.Name = "D8SizeIncVal_TB"
        Me.D8SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D8SizeIncVal_TB.TabIndex = 612
        Me.D8SizeIncVal_TB.Text = "000"
        Me.D8SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3Row_LBL
        '
        Me.D3Row_LBL.AutoSize = True
        Me.D3Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3Row_LBL.Location = New System.Drawing.Point(13, 135)
        Me.D3Row_LBL.Name = "D3Row_LBL"
        Me.D3Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D3Row_LBL.TabIndex = 553
        Me.D3Row_LBL.Text = "Drop 3"
        '
        'D8SizeIncDec_BTN
        '
        Me.D8SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D8SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8SizeIncDec_BTN.Location = New System.Drawing.Point(442, 323)
        Me.D8SizeIncDec_BTN.Name = "D8SizeIncDec_BTN"
        Me.D8SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D8SizeIncDec_BTN.TabIndex = 611
        Me.D8SizeIncDec_BTN.Text = "INC"
        Me.D8SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D8SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D3Sol_CB
        '
        Me.D3Sol_CB.AllowDrop = True
        Me.D3Sol_CB.DropDownWidth = 40
        Me.D3Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3Sol_CB.FormattingEnabled = True
        Me.D3Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D3Sol_CB.ItemHeight = 20
        Me.D3Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D3Sol_CB.Location = New System.Drawing.Point(97, 133)
        Me.D3Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D3Sol_CB.Name = "D3Sol_CB"
        Me.D3Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D3Sol_CB.TabIndex = 555
        Me.D3Sol_CB.Text = " 1"
        '
        'D8Size_TB
        '
        Me.D8Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8Size_TB.Location = New System.Drawing.Point(380, 323)
        Me.D8Size_TB.MaxLength = 4
        Me.D8Size_TB.Name = "D8Size_TB"
        Me.D8Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D8Size_TB.TabIndex = 610
        Me.D8Size_TB.Text = "0030"
        Me.D8Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(150, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 18)
        Me.Label15.TabIndex = 554
        Me.Label15.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(356, 328)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 18)
        Me.Label20.TabIndex = 609
        Me.Label20.Text = "-"
        '
        'D3StartTime_TB
        '
        Me.D3StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3StartTime_TB.Location = New System.Drawing.Point(170, 133)
        Me.D3StartTime_TB.MaxLength = 4
        Me.D3StartTime_TB.Name = "D3StartTime_TB"
        Me.D3StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D3StartTime_TB.TabIndex = 556
        Me.D3StartTime_TB.Text = "0000"
        Me.D3StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D8StartIncVal_TB
        '
        Me.D8StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8StartIncVal_TB.Location = New System.Drawing.Point(297, 323)
        Me.D8StartIncVal_TB.MaxLength = 3
        Me.D8StartIncVal_TB.Name = "D8StartIncVal_TB"
        Me.D8StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D8StartIncVal_TB.TabIndex = 608
        Me.D8StartIncVal_TB.Text = "000"
        Me.D8StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3StartIncVal_TB
        '
        Me.D3StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3StartIncVal_TB.Location = New System.Drawing.Point(297, 133)
        Me.D3StartIncVal_TB.MaxLength = 3
        Me.D3StartIncVal_TB.Name = "D3StartIncVal_TB"
        Me.D3StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D3StartIncVal_TB.TabIndex = 558
        Me.D3StartIncVal_TB.Text = "000"
        Me.D3StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D8StartIncDec_BTN
        '
        Me.D8StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D8StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8StartIncDec_BTN.Location = New System.Drawing.Point(234, 323)
        Me.D8StartIncDec_BTN.Name = "D8StartIncDec_BTN"
        Me.D8StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D8StartIncDec_BTN.TabIndex = 607
        Me.D8StartIncDec_BTN.Text = "INC"
        Me.D8StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D8StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(356, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 18)
        Me.Label14.TabIndex = 559
        Me.Label14.Text = "-"
        '
        'D8StartTime_TB
        '
        Me.D8StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8StartTime_TB.Location = New System.Drawing.Point(170, 323)
        Me.D8StartTime_TB.MaxLength = 4
        Me.D8StartTime_TB.Name = "D8StartTime_TB"
        Me.D8StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D8StartTime_TB.TabIndex = 606
        Me.D8StartTime_TB.Text = "0000"
        Me.D8StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D3Size_TB
        '
        Me.D3Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3Size_TB.Location = New System.Drawing.Point(380, 133)
        Me.D3Size_TB.MaxLength = 4
        Me.D3Size_TB.Name = "D3Size_TB"
        Me.D3Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D3Size_TB.TabIndex = 560
        Me.D3Size_TB.Text = "0030"
        Me.D3Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(150, 328)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 18)
        Me.Label21.TabIndex = 604
        Me.Label21.Text = "-"
        '
        'D3SizeIncDec_BTN
        '
        Me.D3SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D3SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3SizeIncDec_BTN.Location = New System.Drawing.Point(442, 133)
        Me.D3SizeIncDec_BTN.Name = "D3SizeIncDec_BTN"
        Me.D3SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D3SizeIncDec_BTN.TabIndex = 561
        Me.D3SizeIncDec_BTN.Text = "INC"
        Me.D3SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D3SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D8Sol_CB
        '
        Me.D8Sol_CB.AllowDrop = True
        Me.D8Sol_CB.DropDownWidth = 40
        Me.D8Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8Sol_CB.FormattingEnabled = True
        Me.D8Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D8Sol_CB.ItemHeight = 20
        Me.D8Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D8Sol_CB.Location = New System.Drawing.Point(97, 323)
        Me.D8Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D8Sol_CB.Name = "D8Sol_CB"
        Me.D8Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D8Sol_CB.TabIndex = 605
        Me.D8Sol_CB.Text = " 1"
        '
        'D3SizeIncVal_TB
        '
        Me.D3SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D3SizeIncVal_TB.Location = New System.Drawing.Point(505, 133)
        Me.D3SizeIncVal_TB.MaxLength = 3
        Me.D3SizeIncVal_TB.Name = "D3SizeIncVal_TB"
        Me.D3SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D3SizeIncVal_TB.TabIndex = 562
        Me.D3SizeIncVal_TB.Text = "000"
        Me.D3SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D8Row_LBL
        '
        Me.D8Row_LBL.AutoSize = True
        Me.D8Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D8Row_LBL.Location = New System.Drawing.Point(13, 325)
        Me.D8Row_LBL.Name = "D8Row_LBL"
        Me.D8Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D8Row_LBL.TabIndex = 603
        Me.D8Row_LBL.Text = "Drop 8"
        '
        'D4Row_LBL
        '
        Me.D4Row_LBL.AutoSize = True
        Me.D4Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4Row_LBL.Location = New System.Drawing.Point(13, 173)
        Me.D4Row_LBL.Name = "D4Row_LBL"
        Me.D4Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D4Row_LBL.TabIndex = 563
        Me.D4Row_LBL.Text = "Drop 4"
        '
        'D7SizeIncVal_TB
        '
        Me.D7SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7SizeIncVal_TB.Location = New System.Drawing.Point(505, 285)
        Me.D7SizeIncVal_TB.MaxLength = 3
        Me.D7SizeIncVal_TB.Name = "D7SizeIncVal_TB"
        Me.D7SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D7SizeIncVal_TB.TabIndex = 602
        Me.D7SizeIncVal_TB.Text = "000"
        Me.D7SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4Sol_CB
        '
        Me.D4Sol_CB.AllowDrop = True
        Me.D4Sol_CB.DropDownWidth = 40
        Me.D4Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4Sol_CB.FormattingEnabled = True
        Me.D4Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D4Sol_CB.ItemHeight = 20
        Me.D4Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D4Sol_CB.Location = New System.Drawing.Point(97, 171)
        Me.D4Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D4Sol_CB.Name = "D4Sol_CB"
        Me.D4Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D4Sol_CB.TabIndex = 565
        Me.D4Sol_CB.Text = " 1"
        '
        'D7SizeIncDec_BTN
        '
        Me.D7SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D7SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7SizeIncDec_BTN.Location = New System.Drawing.Point(442, 285)
        Me.D7SizeIncDec_BTN.Name = "D7SizeIncDec_BTN"
        Me.D7SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D7SizeIncDec_BTN.TabIndex = 601
        Me.D7SizeIncDec_BTN.Text = "INC"
        Me.D7SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D7SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(150, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 18)
        Me.Label18.TabIndex = 564
        Me.Label18.Text = "-"
        '
        'D7Size_TB
        '
        Me.D7Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7Size_TB.Location = New System.Drawing.Point(380, 285)
        Me.D7Size_TB.MaxLength = 4
        Me.D7Size_TB.Name = "D7Size_TB"
        Me.D7Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D7Size_TB.TabIndex = 600
        Me.D7Size_TB.Text = "0030"
        Me.D7Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4StartTime_TB
        '
        Me.D4StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4StartTime_TB.Location = New System.Drawing.Point(170, 171)
        Me.D4StartTime_TB.MaxLength = 4
        Me.D4StartTime_TB.Name = "D4StartTime_TB"
        Me.D4StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D4StartTime_TB.TabIndex = 566
        Me.D4StartTime_TB.Text = "0000"
        Me.D4StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(356, 290)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 18)
        Me.Label23.TabIndex = 599
        Me.Label23.Text = "-"
        '
        'D4StartIncDec_BTN
        '
        Me.D4StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D4StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4StartIncDec_BTN.Location = New System.Drawing.Point(234, 171)
        Me.D4StartIncDec_BTN.Name = "D4StartIncDec_BTN"
        Me.D4StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D4StartIncDec_BTN.TabIndex = 567
        Me.D4StartIncDec_BTN.Text = "INC"
        Me.D4StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D4StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D7StartIncVal_TB
        '
        Me.D7StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7StartIncVal_TB.Location = New System.Drawing.Point(297, 285)
        Me.D7StartIncVal_TB.MaxLength = 3
        Me.D7StartIncVal_TB.Name = "D7StartIncVal_TB"
        Me.D7StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D7StartIncVal_TB.TabIndex = 598
        Me.D7StartIncVal_TB.Text = "000"
        Me.D7StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4StartIncVal_TB
        '
        Me.D4StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4StartIncVal_TB.Location = New System.Drawing.Point(297, 171)
        Me.D4StartIncVal_TB.MaxLength = 3
        Me.D4StartIncVal_TB.Name = "D4StartIncVal_TB"
        Me.D4StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D4StartIncVal_TB.TabIndex = 568
        Me.D4StartIncVal_TB.Text = "000"
        Me.D4StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D7StartIncDec_BTN
        '
        Me.D7StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D7StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7StartIncDec_BTN.Location = New System.Drawing.Point(234, 285)
        Me.D7StartIncDec_BTN.Name = "D7StartIncDec_BTN"
        Me.D7StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D7StartIncDec_BTN.TabIndex = 597
        Me.D7StartIncDec_BTN.Text = "INC"
        Me.D7StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D7StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(356, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 18)
        Me.Label17.TabIndex = 569
        Me.Label17.Text = "-"
        '
        'D7StartTime_TB
        '
        Me.D7StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7StartTime_TB.Location = New System.Drawing.Point(170, 285)
        Me.D7StartTime_TB.MaxLength = 4
        Me.D7StartTime_TB.Name = "D7StartTime_TB"
        Me.D7StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D7StartTime_TB.TabIndex = 596
        Me.D7StartTime_TB.Text = "0000"
        Me.D7StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D4Size_TB
        '
        Me.D4Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4Size_TB.Location = New System.Drawing.Point(380, 171)
        Me.D4Size_TB.MaxLength = 4
        Me.D4Size_TB.Name = "D4Size_TB"
        Me.D4Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D4Size_TB.TabIndex = 570
        Me.D4Size_TB.Text = "0030"
        Me.D4Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(150, 290)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 18)
        Me.Label24.TabIndex = 594
        Me.Label24.Text = "-"
        '
        'D4SizeIncDec_BTN
        '
        Me.D4SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D4SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4SizeIncDec_BTN.Location = New System.Drawing.Point(442, 171)
        Me.D4SizeIncDec_BTN.Name = "D4SizeIncDec_BTN"
        Me.D4SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D4SizeIncDec_BTN.TabIndex = 571
        Me.D4SizeIncDec_BTN.Text = "INC"
        Me.D4SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D4SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D7Sol_CB
        '
        Me.D7Sol_CB.AllowDrop = True
        Me.D7Sol_CB.DropDownWidth = 40
        Me.D7Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7Sol_CB.FormattingEnabled = True
        Me.D7Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D7Sol_CB.ItemHeight = 20
        Me.D7Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D7Sol_CB.Location = New System.Drawing.Point(97, 285)
        Me.D7Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D7Sol_CB.Name = "D7Sol_CB"
        Me.D7Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D7Sol_CB.TabIndex = 595
        Me.D7Sol_CB.Text = " 1"
        '
        'D4SizeIncVal_TB
        '
        Me.D4SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4SizeIncVal_TB.Location = New System.Drawing.Point(505, 171)
        Me.D4SizeIncVal_TB.MaxLength = 3
        Me.D4SizeIncVal_TB.Name = "D4SizeIncVal_TB"
        Me.D4SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D4SizeIncVal_TB.TabIndex = 572
        Me.D4SizeIncVal_TB.Text = "000"
        Me.D4SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D7Row_LBL
        '
        Me.D7Row_LBL.AutoSize = True
        Me.D7Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D7Row_LBL.Location = New System.Drawing.Point(13, 287)
        Me.D7Row_LBL.Name = "D7Row_LBL"
        Me.D7Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D7Row_LBL.TabIndex = 593
        Me.D7Row_LBL.Text = "Drop 7"
        '
        'D5Row_LBL
        '
        Me.D5Row_LBL.AutoSize = True
        Me.D5Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5Row_LBL.Location = New System.Drawing.Point(13, 211)
        Me.D5Row_LBL.Name = "D5Row_LBL"
        Me.D5Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D5Row_LBL.TabIndex = 573
        Me.D5Row_LBL.Text = "Drop 5"
        '
        'D6SizeIncVal_TB
        '
        Me.D6SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6SizeIncVal_TB.Location = New System.Drawing.Point(505, 247)
        Me.D6SizeIncVal_TB.MaxLength = 3
        Me.D6SizeIncVal_TB.Name = "D6SizeIncVal_TB"
        Me.D6SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D6SizeIncVal_TB.TabIndex = 592
        Me.D6SizeIncVal_TB.Text = "000"
        Me.D6SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5Sol_CB
        '
        Me.D5Sol_CB.AllowDrop = True
        Me.D5Sol_CB.DropDownWidth = 40
        Me.D5Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5Sol_CB.FormattingEnabled = True
        Me.D5Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D5Sol_CB.ItemHeight = 20
        Me.D5Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D5Sol_CB.Location = New System.Drawing.Point(97, 209)
        Me.D5Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D5Sol_CB.Name = "D5Sol_CB"
        Me.D5Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D5Sol_CB.TabIndex = 575
        Me.D5Sol_CB.Text = " 1"
        '
        'D6SizeIncDec_BTN
        '
        Me.D6SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D6SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6SizeIncDec_BTN.Location = New System.Drawing.Point(442, 247)
        Me.D6SizeIncDec_BTN.Name = "D6SizeIncDec_BTN"
        Me.D6SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D6SizeIncDec_BTN.TabIndex = 591
        Me.D6SizeIncDec_BTN.Text = "INC"
        Me.D6SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D6SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(150, 214)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 18)
        Me.Label30.TabIndex = 574
        Me.Label30.Text = "-"
        '
        'D6Size_TB
        '
        Me.D6Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6Size_TB.Location = New System.Drawing.Point(380, 247)
        Me.D6Size_TB.MaxLength = 4
        Me.D6Size_TB.Name = "D6Size_TB"
        Me.D6Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D6Size_TB.TabIndex = 590
        Me.D6Size_TB.Text = "0030"
        Me.D6Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5StartTime_TB
        '
        Me.D5StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5StartTime_TB.Location = New System.Drawing.Point(170, 209)
        Me.D5StartTime_TB.MaxLength = 4
        Me.D5StartTime_TB.Name = "D5StartTime_TB"
        Me.D5StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D5StartTime_TB.TabIndex = 576
        Me.D5StartTime_TB.Text = "0000"
        Me.D5StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(356, 252)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 18)
        Me.Label26.TabIndex = 589
        Me.Label26.Text = "-"
        '
        'D5StartIncDec_BTN
        '
        Me.D5StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D5StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5StartIncDec_BTN.Location = New System.Drawing.Point(234, 209)
        Me.D5StartIncDec_BTN.Name = "D5StartIncDec_BTN"
        Me.D5StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D5StartIncDec_BTN.TabIndex = 577
        Me.D5StartIncDec_BTN.Text = "INC"
        Me.D5StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D5StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D6StartIncVal_TB
        '
        Me.D6StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6StartIncVal_TB.Location = New System.Drawing.Point(297, 247)
        Me.D6StartIncVal_TB.MaxLength = 3
        Me.D6StartIncVal_TB.Name = "D6StartIncVal_TB"
        Me.D6StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D6StartIncVal_TB.TabIndex = 588
        Me.D6StartIncVal_TB.Text = "000"
        Me.D6StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5StartIncVal_TB
        '
        Me.D5StartIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5StartIncVal_TB.Location = New System.Drawing.Point(297, 209)
        Me.D5StartIncVal_TB.MaxLength = 3
        Me.D5StartIncVal_TB.Name = "D5StartIncVal_TB"
        Me.D5StartIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D5StartIncVal_TB.TabIndex = 578
        Me.D5StartIncVal_TB.Text = "000"
        Me.D5StartIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6StartIncDec_BTN
        '
        Me.D6StartIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D6StartIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6StartIncDec_BTN.Location = New System.Drawing.Point(234, 247)
        Me.D6StartIncDec_BTN.Name = "D6StartIncDec_BTN"
        Me.D6StartIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D6StartIncDec_BTN.TabIndex = 587
        Me.D6StartIncDec_BTN.Text = "INC"
        Me.D6StartIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D6StartIncDec_BTN.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(356, 214)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 18)
        Me.Label29.TabIndex = 579
        Me.Label29.Text = "-"
        '
        'D6StartTime_TB
        '
        Me.D6StartTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6StartTime_TB.Location = New System.Drawing.Point(170, 247)
        Me.D6StartTime_TB.MaxLength = 4
        Me.D6StartTime_TB.Name = "D6StartTime_TB"
        Me.D6StartTime_TB.Size = New System.Drawing.Size(52, 26)
        Me.D6StartTime_TB.TabIndex = 586
        Me.D6StartTime_TB.Text = "0000"
        Me.D6StartTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D5Size_TB
        '
        Me.D5Size_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5Size_TB.Location = New System.Drawing.Point(380, 209)
        Me.D5Size_TB.MaxLength = 4
        Me.D5Size_TB.Name = "D5Size_TB"
        Me.D5Size_TB.Size = New System.Drawing.Size(52, 26)
        Me.D5Size_TB.TabIndex = 580
        Me.D5Size_TB.Text = "0030"
        Me.D5Size_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(150, 252)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 18)
        Me.Label27.TabIndex = 584
        Me.Label27.Text = "-"
        '
        'D5SizeIncDec_BTN
        '
        Me.D5SizeIncDec_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.D5SizeIncDec_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5SizeIncDec_BTN.Location = New System.Drawing.Point(442, 209)
        Me.D5SizeIncDec_BTN.Name = "D5SizeIncDec_BTN"
        Me.D5SizeIncDec_BTN.Size = New System.Drawing.Size(55, 28)
        Me.D5SizeIncDec_BTN.TabIndex = 581
        Me.D5SizeIncDec_BTN.Text = "INC"
        Me.D5SizeIncDec_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.D5SizeIncDec_BTN.UseVisualStyleBackColor = False
        '
        'D6Sol_CB
        '
        Me.D6Sol_CB.AllowDrop = True
        Me.D6Sol_CB.DropDownWidth = 40
        Me.D6Sol_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6Sol_CB.FormattingEnabled = True
        Me.D6Sol_CB.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D6Sol_CB.ItemHeight = 20
        Me.D6Sol_CB.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.D6Sol_CB.Location = New System.Drawing.Point(97, 247)
        Me.D6Sol_CB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.D6Sol_CB.Name = "D6Sol_CB"
        Me.D6Sol_CB.Size = New System.Drawing.Size(46, 28)
        Me.D6Sol_CB.TabIndex = 585
        Me.D6Sol_CB.Text = " 1"
        '
        'D5SizeIncVal_TB
        '
        Me.D5SizeIncVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D5SizeIncVal_TB.Location = New System.Drawing.Point(505, 209)
        Me.D5SizeIncVal_TB.MaxLength = 3
        Me.D5SizeIncVal_TB.Name = "D5SizeIncVal_TB"
        Me.D5SizeIncVal_TB.Size = New System.Drawing.Size(48, 26)
        Me.D5SizeIncVal_TB.TabIndex = 582
        Me.D5SizeIncVal_TB.Text = "000"
        Me.D5SizeIncVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D6Row_LBL
        '
        Me.D6Row_LBL.AutoSize = True
        Me.D6Row_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6Row_LBL.Location = New System.Drawing.Point(13, 249)
        Me.D6Row_LBL.Name = "D6Row_LBL"
        Me.D6Row_LBL.Size = New System.Drawing.Size(66, 24)
        Me.D6Row_LBL.TabIndex = 583
        Me.D6Row_LBL.Text = "Drop 6"
        '
        'TAB_SETTINGS
        '
        Me.TAB_SETTINGS.Controls.Add(Me.light_Combo)
        Me.TAB_SETTINGS.Controls.Add(Me.laser_Combo)
        Me.TAB_SETTINGS.Controls.Add(Me.Label45)
        Me.TAB_SETTINGS.Controls.Add(Me.Label36)
        Me.TAB_SETTINGS.Controls.Add(Me.Label44)
        Me.TAB_SETTINGS.Controls.Add(Me.Label43)
        Me.TAB_SETTINGS.Controls.Add(Me.Label37)
        Me.TAB_SETTINGS.Controls.Add(Me.Version_ComboBox)
        Me.TAB_SETTINGS.Controls.Add(Me.GroupBox2)
        Me.TAB_SETTINGS.Controls.Add(Me.LP_waitTimeVal_TB)
        Me.TAB_SETTINGS.Controls.Add(Me.lp_TimerOrButton_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.waitTime_LBL)
        Me.TAB_SETTINGS.Controls.Add(Me.timerButton_LBL)
        Me.TAB_SETTINGS.Controls.Add(Me.LoopMode_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.LoopMode_LBL)
        Me.TAB_SETTINGS.Controls.Add(Me.Label19)
        Me.TAB_SETTINGS.Controls.Add(Me.ResetAll_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.Label35)
        Me.TAB_SETTINGS.Controls.Add(Me.TestConnection_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.connect_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.Label13)
        Me.TAB_SETTINGS.Controls.Add(Me.COMport_CB)
        Me.TAB_SETTINGS.Controls.Add(Me.refreshCOM_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.SET_DEBUG_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.SET_DEBUG_LBL)
        Me.TAB_SETTINGS.Controls.Add(Me.lbl_VD4)
        Me.TAB_SETTINGS.Controls.Add(Me.valve4Drain_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.lbl_VD3)
        Me.TAB_SETTINGS.Controls.Add(Me.lbl_VD2)
        Me.TAB_SETTINGS.Controls.Add(Me.lbl_VD1)
        Me.TAB_SETTINGS.Controls.Add(Me.valve3Drain_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.valve2Drain_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.valve1Drain_BTN)
        Me.TAB_SETTINGS.Controls.Add(Me.ValveDrain_LBL)
        Me.TAB_SETTINGS.Location = New System.Drawing.Point(4, 25)
        Me.TAB_SETTINGS.Name = "TAB_SETTINGS"
        Me.TAB_SETTINGS.Size = New System.Drawing.Size(802, 491)
        Me.TAB_SETTINGS.TabIndex = 2
        Me.TAB_SETTINGS.Text = "Settings"
        Me.TAB_SETTINGS.UseVisualStyleBackColor = True
        '
        'light_Combo
        '
        Me.light_Combo.FormattingEnabled = True
        Me.light_Combo.Items.AddRange(New Object() {"OFF", "ON", "Auto"})
        Me.light_Combo.Location = New System.Drawing.Point(703, 375)
        Me.light_Combo.Name = "light_Combo"
        Me.light_Combo.Size = New System.Drawing.Size(79, 24)
        Me.light_Combo.TabIndex = 658
        '
        'laser_Combo
        '
        Me.laser_Combo.FormattingEnabled = True
        Me.laser_Combo.Items.AddRange(New Object() {"OFF", "ON", "Auto"})
        Me.laser_Combo.Location = New System.Drawing.Point(703, 345)
        Me.laser_Combo.Name = "laser_Combo"
        Me.laser_Combo.Size = New System.Drawing.Size(79, 24)
        Me.laser_Combo.TabIndex = 657
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(583, 375)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(44, 20)
        Me.Label45.TabIndex = 656
        Me.Label45.Text = "Light"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(583, 345)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 20)
        Me.Label36.TabIndex = 655
        Me.Label36.Text = "Laser pointer"
        '
        'Label44
        '
        Me.Label44.AllowDrop = True
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(34, 254)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(105, 13)
        Me.Label44.TabIndex = 654
        Me.Label44.Text = "device you are using"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(34, 241)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(190, 13)
        Me.Label43.TabIndex = 653
        Me.Label43.Text = "Match the version of the dropController"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(34, 214)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(111, 20)
        Me.Label37.TabIndex = 652
        Me.Label37.Text = "Device version"
        '
        'Version_ComboBox
        '
        Me.Version_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Version_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version_ComboBox.FormattingEnabled = True
        Me.Version_ComboBox.Items.AddRange(New Object() {"2", "3"})
        Me.Version_ComboBox.Location = New System.Drawing.Point(173, 211)
        Me.Version_ComboBox.Name = "Version_ComboBox"
        Me.Version_ComboBox.Size = New System.Drawing.Size(57, 28)
        Me.Version_ComboBox.TabIndex = 651
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FT3_Pulse_lbl)
        Me.GroupBox2.Controls.Add(Me.FT3_Pulse_TB)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.mirrorLockupOnOff_BTN)
        Me.GroupBox2.Controls.Add(Me.ML_Time_LBL)
        Me.GroupBox2.Controls.Add(Me.mirrorLockupTime_TB)
        Me.GroupBox2.Controls.Add(Me.FT1_Pulse_lbl)
        Me.GroupBox2.Controls.Add(Me.CT_Pulse_lbl)
        Me.GroupBox2.Controls.Add(Me.SET_LEO_BUT)
        Me.GroupBox2.Controls.Add(Me.FT1_Pulse_TB)
        Me.GroupBox2.Controls.Add(Me.SET_LEO_LBL)
        Me.GroupBox2.Controls.Add(Me.BulbStartOffset_Time_TB)
        Me.GroupBox2.Controls.Add(Me.CT_Pulse_TB)
        Me.GroupBox2.Controls.Add(Me.BulbStart_LBL)
        Me.GroupBox2.Controls.Add(Me.BulbStopOffset_Time_TB)
        Me.GroupBox2.Controls.Add(Me.SET_SOUND_LBL)
        Me.GroupBox2.Controls.Add(Me.BulbStop_LBL)
        Me.GroupBox2.Controls.Add(Me.SET_SOUND_BTN)
        Me.GroupBox2.Controls.Add(Me.FT2_Pulse_lbl)
        Me.GroupBox2.Controls.Add(Me.FT2_Pulse_TB)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 462)
        Me.GroupBox2.TabIndex = 646
        Me.GroupBox2.TabStop = False
        '
        'FT3_Pulse_lbl
        '
        Me.FT3_Pulse_lbl.AutoSize = True
        Me.FT3_Pulse_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT3_Pulse_lbl.Location = New System.Drawing.Point(36, 244)
        Me.FT3_Pulse_lbl.Name = "FT3_Pulse_lbl"
        Me.FT3_Pulse_lbl.Size = New System.Drawing.Size(157, 20)
        Me.FT3_Pulse_lbl.TabIndex = 641
        Me.FT3_Pulse_lbl.Text = "Flash Trigger 3 Pulse"
        '
        'FT3_Pulse_TB
        '
        Me.FT3_Pulse_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT3_Pulse_TB.Location = New System.Drawing.Point(216, 240)
        Me.FT3_Pulse_TB.MaxLength = 3
        Me.FT3_Pulse_TB.Name = "FT3_Pulse_TB"
        Me.FT3_Pulse_TB.Size = New System.Drawing.Size(45, 26)
        Me.FT3_Pulse_TB.TabIndex = 640
        Me.FT3_Pulse_TB.Text = "050"
        Me.FT3_Pulse_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FT3_Pulse_TB.WordWrap = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(96, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 25)
        Me.Label25.TabIndex = 263
        Me.Label25.Text = "Settings"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(37, 63)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(105, 20)
        Me.Label34.TabIndex = 243
        Me.Label34.Text = "Mirror Lockup"
        '
        'mirrorLockupOnOff_BTN
        '
        Me.mirrorLockupOnOff_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.mirrorLockupOnOff_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mirrorLockupOnOff_BTN.Location = New System.Drawing.Point(202, 59)
        Me.mirrorLockupOnOff_BTN.Name = "mirrorLockupOnOff_BTN"
        Me.mirrorLockupOnOff_BTN.Size = New System.Drawing.Size(60, 30)
        Me.mirrorLockupOnOff_BTN.TabIndex = 235
        Me.mirrorLockupOnOff_BTN.Text = "OFF"
        Me.mirrorLockupOnOff_BTN.UseVisualStyleBackColor = False
        '
        'ML_Time_LBL
        '
        Me.ML_Time_LBL.AutoSize = True
        Me.ML_Time_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ML_Time_LBL.Location = New System.Drawing.Point(37, 96)
        Me.ML_Time_LBL.Name = "ML_Time_LBL"
        Me.ML_Time_LBL.Size = New System.Drawing.Size(69, 20)
        Me.ML_Time_LBL.TabIndex = 244
        Me.ML_Time_LBL.Text = "ML Time"
        '
        'mirrorLockupTime_TB
        '
        Me.mirrorLockupTime_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mirrorLockupTime_TB.Location = New System.Drawing.Point(201, 93)
        Me.mirrorLockupTime_TB.Name = "mirrorLockupTime_TB"
        Me.mirrorLockupTime_TB.Size = New System.Drawing.Size(61, 26)
        Me.mirrorLockupTime_TB.TabIndex = 236
        Me.mirrorLockupTime_TB.Text = "1000"
        Me.mirrorLockupTime_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FT1_Pulse_lbl
        '
        Me.FT1_Pulse_lbl.AutoSize = True
        Me.FT1_Pulse_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT1_Pulse_lbl.Location = New System.Drawing.Point(37, 176)
        Me.FT1_Pulse_lbl.Name = "FT1_Pulse_lbl"
        Me.FT1_Pulse_lbl.Size = New System.Drawing.Size(157, 20)
        Me.FT1_Pulse_lbl.TabIndex = 245
        Me.FT1_Pulse_lbl.Text = "Flash Trigger 1 Pulse"
        '
        'CT_Pulse_lbl
        '
        Me.CT_Pulse_lbl.AutoSize = True
        Me.CT_Pulse_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CT_Pulse_lbl.Location = New System.Drawing.Point(37, 143)
        Me.CT_Pulse_lbl.Name = "CT_Pulse_lbl"
        Me.CT_Pulse_lbl.Size = New System.Drawing.Size(161, 20)
        Me.CT_Pulse_lbl.TabIndex = 246
        Me.CT_Pulse_lbl.Text = "Camera Trigger Pulse"
        '
        'SET_LEO_BUT
        '
        Me.SET_LEO_BUT.BackColor = System.Drawing.Color.Plum
        Me.SET_LEO_BUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SET_LEO_BUT.Location = New System.Drawing.Point(202, 298)
        Me.SET_LEO_BUT.Name = "SET_LEO_BUT"
        Me.SET_LEO_BUT.Size = New System.Drawing.Size(60, 30)
        Me.SET_LEO_BUT.TabIndex = 639
        Me.SET_LEO_BUT.Text = "NO"
        Me.SET_LEO_BUT.UseVisualStyleBackColor = False
        '
        'FT1_Pulse_TB
        '
        Me.FT1_Pulse_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT1_Pulse_TB.Location = New System.Drawing.Point(217, 172)
        Me.FT1_Pulse_TB.MaxLength = 3
        Me.FT1_Pulse_TB.Name = "FT1_Pulse_TB"
        Me.FT1_Pulse_TB.Size = New System.Drawing.Size(45, 26)
        Me.FT1_Pulse_TB.TabIndex = 237
        Me.FT1_Pulse_TB.Text = "050"
        Me.FT1_Pulse_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FT1_Pulse_TB.WordWrap = False
        '
        'SET_LEO_LBL
        '
        Me.SET_LEO_LBL.AutoSize = True
        Me.SET_LEO_LBL.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SET_LEO_LBL.Location = New System.Drawing.Point(37, 304)
        Me.SET_LEO_LBL.Name = "SET_LEO_LBL"
        Me.SET_LEO_LBL.Size = New System.Drawing.Size(83, 18)
        Me.SET_LEO_LBL.TabIndex = 638
        Me.SET_LEO_LBL.Text = "Leonardo"
        '
        'BulbStartOffset_Time_TB
        '
        Me.BulbStartOffset_Time_TB.Enabled = False
        Me.BulbStartOffset_Time_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BulbStartOffset_Time_TB.Location = New System.Drawing.Point(201, 390)
        Me.BulbStartOffset_Time_TB.Name = "BulbStartOffset_Time_TB"
        Me.BulbStartOffset_Time_TB.Size = New System.Drawing.Size(61, 26)
        Me.BulbStartOffset_Time_TB.TabIndex = 546
        Me.BulbStartOffset_Time_TB.Text = "0100"
        Me.BulbStartOffset_Time_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CT_Pulse_TB
        '
        Me.CT_Pulse_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CT_Pulse_TB.Location = New System.Drawing.Point(217, 140)
        Me.CT_Pulse_TB.MaxLength = 3
        Me.CT_Pulse_TB.Name = "CT_Pulse_TB"
        Me.CT_Pulse_TB.Size = New System.Drawing.Size(45, 26)
        Me.CT_Pulse_TB.TabIndex = 238
        Me.CT_Pulse_TB.Text = "050"
        Me.CT_Pulse_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CT_Pulse_TB.WordWrap = False
        '
        'BulbStart_LBL
        '
        Me.BulbStart_LBL.AutoSize = True
        Me.BulbStart_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BulbStart_LBL.ForeColor = System.Drawing.Color.Gray
        Me.BulbStart_LBL.Location = New System.Drawing.Point(37, 393)
        Me.BulbStart_LBL.Name = "BulbStart_LBL"
        Me.BulbStart_LBL.Size = New System.Drawing.Size(157, 20)
        Me.BulbStart_LBL.TabIndex = 547
        Me.BulbStart_LBL.Text = "Bulb Pre-Start Offset"
        '
        'BulbStopOffset_Time_TB
        '
        Me.BulbStopOffset_Time_TB.Enabled = False
        Me.BulbStopOffset_Time_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BulbStopOffset_Time_TB.Location = New System.Drawing.Point(201, 419)
        Me.BulbStopOffset_Time_TB.Name = "BulbStopOffset_Time_TB"
        Me.BulbStopOffset_Time_TB.Size = New System.Drawing.Size(61, 26)
        Me.BulbStopOffset_Time_TB.TabIndex = 544
        Me.BulbStopOffset_Time_TB.Text = "0100"
        Me.BulbStopOffset_Time_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SET_SOUND_LBL
        '
        Me.SET_SOUND_LBL.AutoSize = True
        Me.SET_SOUND_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SET_SOUND_LBL.Location = New System.Drawing.Point(37, 337)
        Me.SET_SOUND_LBL.Name = "SET_SOUND_LBL"
        Me.SET_SOUND_LBL.Size = New System.Drawing.Size(64, 20)
        Me.SET_SOUND_LBL.TabIndex = 247
        Me.SET_SOUND_LBL.Text = "Sounds"
        '
        'BulbStop_LBL
        '
        Me.BulbStop_LBL.AutoSize = True
        Me.BulbStop_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BulbStop_LBL.ForeColor = System.Drawing.Color.Gray
        Me.BulbStop_LBL.Location = New System.Drawing.Point(37, 422)
        Me.BulbStop_LBL.Name = "BulbStop_LBL"
        Me.BulbStop_LBL.Size = New System.Drawing.Size(164, 20)
        Me.BulbStop_LBL.TabIndex = 545
        Me.BulbStop_LBL.Text = "Bulb Post-Stop Offset"
        '
        'SET_SOUND_BTN
        '
        Me.SET_SOUND_BTN.BackColor = System.Drawing.Color.Plum
        Me.SET_SOUND_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SET_SOUND_BTN.Location = New System.Drawing.Point(202, 332)
        Me.SET_SOUND_BTN.Name = "SET_SOUND_BTN"
        Me.SET_SOUND_BTN.Size = New System.Drawing.Size(60, 30)
        Me.SET_SOUND_BTN.TabIndex = 239
        Me.SET_SOUND_BTN.Text = "OFF"
        Me.SET_SOUND_BTN.UseVisualStyleBackColor = False
        '
        'FT2_Pulse_lbl
        '
        Me.FT2_Pulse_lbl.AutoSize = True
        Me.FT2_Pulse_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT2_Pulse_lbl.Location = New System.Drawing.Point(37, 209)
        Me.FT2_Pulse_lbl.Name = "FT2_Pulse_lbl"
        Me.FT2_Pulse_lbl.Size = New System.Drawing.Size(157, 20)
        Me.FT2_Pulse_lbl.TabIndex = 543
        Me.FT2_Pulse_lbl.Text = "Flash Trigger 2 Pulse"
        '
        'FT2_Pulse_TB
        '
        Me.FT2_Pulse_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FT2_Pulse_TB.Location = New System.Drawing.Point(217, 205)
        Me.FT2_Pulse_TB.MaxLength = 3
        Me.FT2_Pulse_TB.Name = "FT2_Pulse_TB"
        Me.FT2_Pulse_TB.Size = New System.Drawing.Size(45, 26)
        Me.FT2_Pulse_TB.TabIndex = 542
        Me.FT2_Pulse_TB.Text = "050"
        Me.FT2_Pulse_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FT2_Pulse_TB.WordWrap = False
        '
        'LP_waitTimeVal_TB
        '
        Me.LP_waitTimeVal_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_waitTimeVal_TB.Location = New System.Drawing.Point(193, 356)
        Me.LP_waitTimeVal_TB.MaxLength = 2
        Me.LP_waitTimeVal_TB.Name = "LP_waitTimeVal_TB"
        Me.LP_waitTimeVal_TB.Size = New System.Drawing.Size(37, 26)
        Me.LP_waitTimeVal_TB.TabIndex = 642
        Me.LP_waitTimeVal_TB.Text = "10"
        Me.LP_waitTimeVal_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lp_TimerOrButton_BTN
        '
        Me.lp_TimerOrButton_BTN.BackColor = System.Drawing.Color.PaleGreen
        Me.lp_TimerOrButton_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lp_TimerOrButton_BTN.Location = New System.Drawing.Point(141, 320)
        Me.lp_TimerOrButton_BTN.Name = "lp_TimerOrButton_BTN"
        Me.lp_TimerOrButton_BTN.Size = New System.Drawing.Size(89, 30)
        Me.lp_TimerOrButton_BTN.TabIndex = 641
        Me.lp_TimerOrButton_BTN.Text = "TIMER"
        Me.lp_TimerOrButton_BTN.UseVisualStyleBackColor = False
        '
        'waitTime_LBL
        '
        Me.waitTime_LBL.AutoSize = True
        Me.waitTime_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitTime_LBL.Location = New System.Drawing.Point(34, 360)
        Me.waitTime_LBL.Name = "waitTime_LBL"
        Me.waitTime_LBL.Size = New System.Drawing.Size(79, 20)
        Me.waitTime_LBL.TabIndex = 645
        Me.waitTime_LBL.Text = "Wait Time"
        '
        'timerButton_LBL
        '
        Me.timerButton_LBL.AutoSize = True
        Me.timerButton_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerButton_LBL.Location = New System.Drawing.Point(34, 325)
        Me.timerButton_LBL.Name = "timerButton_LBL"
        Me.timerButton_LBL.Size = New System.Drawing.Size(100, 20)
        Me.timerButton_LBL.TabIndex = 644
        Me.timerButton_LBL.Text = "Timer/Button"
        '
        'LoopMode_BTN
        '
        Me.LoopMode_BTN.BackColor = System.Drawing.Color.PaleGreen
        Me.LoopMode_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoopMode_BTN.Location = New System.Drawing.Point(176, 286)
        Me.LoopMode_BTN.Name = "LoopMode_BTN"
        Me.LoopMode_BTN.Size = New System.Drawing.Size(55, 28)
        Me.LoopMode_BTN.TabIndex = 640
        Me.LoopMode_BTN.Text = "ON"
        Me.LoopMode_BTN.UseVisualStyleBackColor = False
        '
        'LoopMode_LBL
        '
        Me.LoopMode_LBL.AutoSize = True
        Me.LoopMode_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoopMode_LBL.Location = New System.Drawing.Point(34, 289)
        Me.LoopMode_LBL.Name = "LoopMode_LBL"
        Me.LoopMode_LBL.Size = New System.Drawing.Size(89, 20)
        Me.LoopMode_LBL.TabIndex = 643
        Me.LoopMode_LBL.Text = "Loop Mode"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(23, 447)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(220, 16)
        Me.Label19.TabIndex = 636
        Me.Label19.Text = "Reset all settings and drop data"
        '
        'ResetAll_BTN
        '
        Me.ResetAll_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ResetAll_BTN.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetAll_BTN.ForeColor = System.Drawing.Color.Black
        Me.ResetAll_BTN.Location = New System.Drawing.Point(38, 408)
        Me.ResetAll_BTN.Name = "ResetAll_BTN"
        Me.ResetAll_BTN.Size = New System.Drawing.Size(193, 37)
        Me.ResetAll_BTN.TabIndex = 635
        Me.ResetAll_BTN.Text = "Reset All"
        Me.ResetAll_BTN.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(73, 30)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(131, 25)
        Me.Label35.TabIndex = 541
        Me.Label35.Text = "Connection"
        '
        'TestConnection_BTN
        '
        Me.TestConnection_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestConnection_BTN.Location = New System.Drawing.Point(53, 150)
        Me.TestConnection_BTN.Name = "TestConnection_BTN"
        Me.TestConnection_BTN.Size = New System.Drawing.Size(165, 31)
        Me.TestConnection_BTN.TabIndex = 540
        Me.TestConnection_BTN.Text = "Test Connection"
        Me.TestConnection_BTN.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(53, 111)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(165, 31)
        Me.connect_BTN.TabIndex = 539
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(49, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 20)
        Me.Label13.TabIndex = 538
        Me.Label13.Text = "COM"
        '
        'COMport_CB
        '
        Me.COMport_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_CB.FormattingEnabled = True
        Me.COMport_CB.Location = New System.Drawing.Point(98, 71)
        Me.COMport_CB.Name = "COMport_CB"
        Me.COMport_CB.Size = New System.Drawing.Size(88, 28)
        Me.COMport_CB.TabIndex = 536
        '
        'refreshCOM_BTN
        '
        Me.refreshCOM_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshCOM_BTN.Location = New System.Drawing.Point(193, 73)
        Me.refreshCOM_BTN.Name = "refreshCOM_BTN"
        Me.refreshCOM_BTN.Size = New System.Drawing.Size(25, 25)
        Me.refreshCOM_BTN.TabIndex = 537
        Me.refreshCOM_BTN.Text = "R"
        Me.refreshCOM_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.refreshCOM_BTN.UseVisualStyleBackColor = True
        '
        'SET_DEBUG_BTN
        '
        Me.SET_DEBUG_BTN.BackColor = System.Drawing.Color.Plum
        Me.SET_DEBUG_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SET_DEBUG_BTN.Location = New System.Drawing.Point(686, 430)
        Me.SET_DEBUG_BTN.Name = "SET_DEBUG_BTN"
        Me.SET_DEBUG_BTN.Size = New System.Drawing.Size(60, 30)
        Me.SET_DEBUG_BTN.TabIndex = 262
        Me.SET_DEBUG_BTN.Text = "OFF"
        Me.SET_DEBUG_BTN.UseVisualStyleBackColor = False
        '
        'SET_DEBUG_LBL
        '
        Me.SET_DEBUG_LBL.AutoSize = True
        Me.SET_DEBUG_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SET_DEBUG_LBL.Location = New System.Drawing.Point(623, 435)
        Me.SET_DEBUG_LBL.Name = "SET_DEBUG_LBL"
        Me.SET_DEBUG_LBL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SET_DEBUG_LBL.Size = New System.Drawing.Size(57, 20)
        Me.SET_DEBUG_LBL.TabIndex = 261
        Me.SET_DEBUG_LBL.Text = "Debug"
        '
        'lbl_VD4
        '
        Me.lbl_VD4.AutoSize = True
        Me.lbl_VD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VD4.Location = New System.Drawing.Point(623, 197)
        Me.lbl_VD4.Name = "lbl_VD4"
        Me.lbl_VD4.Size = New System.Drawing.Size(18, 20)
        Me.lbl_VD4.TabIndex = 256
        Me.lbl_VD4.Text = "4"
        '
        'valve4Drain_BTN
        '
        Me.valve4Drain_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valve4Drain_BTN.Enabled = False
        Me.valve4Drain_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valve4Drain_BTN.Location = New System.Drawing.Point(656, 193)
        Me.valve4Drain_BTN.Name = "valve4Drain_BTN"
        Me.valve4Drain_BTN.Size = New System.Drawing.Size(92, 28)
        Me.valve4Drain_BTN.TabIndex = 255
        Me.valve4Drain_BTN.Text = "CLOSED"
        Me.valve4Drain_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.valve4Drain_BTN.UseVisualStyleBackColor = False
        '
        'lbl_VD3
        '
        Me.lbl_VD3.AutoSize = True
        Me.lbl_VD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VD3.Location = New System.Drawing.Point(623, 155)
        Me.lbl_VD3.Name = "lbl_VD3"
        Me.lbl_VD3.Size = New System.Drawing.Size(18, 20)
        Me.lbl_VD3.TabIndex = 254
        Me.lbl_VD3.Text = "3"
        '
        'lbl_VD2
        '
        Me.lbl_VD2.AutoSize = True
        Me.lbl_VD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VD2.Location = New System.Drawing.Point(623, 116)
        Me.lbl_VD2.Name = "lbl_VD2"
        Me.lbl_VD2.Size = New System.Drawing.Size(18, 20)
        Me.lbl_VD2.TabIndex = 253
        Me.lbl_VD2.Text = "2"
        '
        'lbl_VD1
        '
        Me.lbl_VD1.AutoSize = True
        Me.lbl_VD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VD1.Location = New System.Drawing.Point(623, 74)
        Me.lbl_VD1.Name = "lbl_VD1"
        Me.lbl_VD1.Size = New System.Drawing.Size(18, 20)
        Me.lbl_VD1.TabIndex = 252
        Me.lbl_VD1.Text = "1"
        '
        'valve3Drain_BTN
        '
        Me.valve3Drain_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valve3Drain_BTN.Enabled = False
        Me.valve3Drain_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valve3Drain_BTN.Location = New System.Drawing.Point(656, 152)
        Me.valve3Drain_BTN.Name = "valve3Drain_BTN"
        Me.valve3Drain_BTN.Size = New System.Drawing.Size(92, 28)
        Me.valve3Drain_BTN.TabIndex = 251
        Me.valve3Drain_BTN.Text = "CLOSED"
        Me.valve3Drain_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.valve3Drain_BTN.UseVisualStyleBackColor = False
        '
        'valve2Drain_BTN
        '
        Me.valve2Drain_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valve2Drain_BTN.Enabled = False
        Me.valve2Drain_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valve2Drain_BTN.Location = New System.Drawing.Point(656, 113)
        Me.valve2Drain_BTN.Name = "valve2Drain_BTN"
        Me.valve2Drain_BTN.Size = New System.Drawing.Size(92, 28)
        Me.valve2Drain_BTN.TabIndex = 250
        Me.valve2Drain_BTN.Text = "CLOSED"
        Me.valve2Drain_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.valve2Drain_BTN.UseVisualStyleBackColor = False
        '
        'valve1Drain_BTN
        '
        Me.valve1Drain_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valve1Drain_BTN.Enabled = False
        Me.valve1Drain_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valve1Drain_BTN.Location = New System.Drawing.Point(656, 73)
        Me.valve1Drain_BTN.Name = "valve1Drain_BTN"
        Me.valve1Drain_BTN.Size = New System.Drawing.Size(92, 28)
        Me.valve1Drain_BTN.TabIndex = 249
        Me.valve1Drain_BTN.Text = "CLOSED"
        Me.valve1Drain_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.valve1Drain_BTN.UseVisualStyleBackColor = False
        '
        'ValveDrain_LBL
        '
        Me.ValveDrain_LBL.AutoSize = True
        Me.ValveDrain_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValveDrain_LBL.Location = New System.Drawing.Point(621, 30)
        Me.ValveDrain_LBL.Name = "ValveDrain_LBL"
        Me.ValveDrain_LBL.Size = New System.Drawing.Size(134, 25)
        Me.ValveDrain_LBL.TabIndex = 248
        Me.ValveDrain_LBL.Text = "Valve Drain"
        '
        'TAB_GRAPH
        '
        Me.TAB_GRAPH.Controls.Add(Me.Label42)
        Me.TAB_GRAPH.Location = New System.Drawing.Point(4, 25)
        Me.TAB_GRAPH.Name = "TAB_GRAPH"
        Me.TAB_GRAPH.Size = New System.Drawing.Size(802, 491)
        Me.TAB_GRAPH.TabIndex = 5
        Me.TAB_GRAPH.Text = "Graph"
        Me.TAB_GRAPH.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(253, 41)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(333, 23)
        Me.Label42.TabIndex = 31
        Me.Label42.Text = "Drop Times By Solenoid Valve"
        '
        'TAB_ABOUT
        '
        Me.TAB_ABOUT.Controls.Add(Me.About05_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.About04_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.About03_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.Label41)
        Me.TAB_ABOUT.Controls.Add(Me.firmwareVersion_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.ABOUT_LINK_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.About02_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.About01_LBL)
        Me.TAB_ABOUT.Controls.Add(Me.AboutTab_Picture1)
        Me.TAB_ABOUT.Controls.Add(Me.AboutTab_Picture2)
        Me.TAB_ABOUT.Controls.Add(Me.AboutTab_Picture3)
        Me.TAB_ABOUT.Location = New System.Drawing.Point(4, 25)
        Me.TAB_ABOUT.Name = "TAB_ABOUT"
        Me.TAB_ABOUT.Size = New System.Drawing.Size(802, 491)
        Me.TAB_ABOUT.TabIndex = 4
        Me.TAB_ABOUT.Text = "About"
        Me.TAB_ABOUT.UseVisualStyleBackColor = True
        '
        'About05_LBL
        '
        Me.About05_LBL.AutoSize = True
        Me.About05_LBL.Location = New System.Drawing.Point(318, 160)
        Me.About05_LBL.Name = "About05_LBL"
        Me.About05_LBL.Size = New System.Drawing.Size(93, 16)
        Me.About05_LBL.TabIndex = 10
        Me.About05_LBL.Text = "About05_LBL"
        '
        'About04_LBL
        '
        Me.About04_LBL.AutoSize = True
        Me.About04_LBL.Location = New System.Drawing.Point(507, 93)
        Me.About04_LBL.Name = "About04_LBL"
        Me.About04_LBL.Size = New System.Drawing.Size(74, 16)
        Me.About04_LBL.TabIndex = 9
        Me.About04_LBL.Text = "for details"
        '
        'About03_LBL
        '
        Me.About03_LBL.AutoSize = True
        Me.About03_LBL.Location = New System.Drawing.Point(310, 93)
        Me.About03_LBL.Name = "About03_LBL"
        Me.About03_LBL.Size = New System.Drawing.Size(33, 16)
        Me.About03_LBL.TabIndex = 8
        Me.About03_LBL.Text = "See"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(313, 293)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(113, 16)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "Device firmware"
        '
        'firmwareVersion_LBL
        '
        Me.firmwareVersion_LBL.AutoSize = True
        Me.firmwareVersion_LBL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firmwareVersion_LBL.Location = New System.Drawing.Point(313, 309)
        Me.firmwareVersion_LBL.Name = "firmwareVersion_LBL"
        Me.firmwareVersion_LBL.Size = New System.Drawing.Size(346, 13)
        Me.firmwareVersion_LBL.TabIndex = 6
        Me.firmwareVersion_LBL.Text = "Connect to the dropController to read the firmware version"
        '
        'ABOUT_LINK_LBL
        '
        Me.ABOUT_LINK_LBL.AutoSize = True
        Me.ABOUT_LINK_LBL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABOUT_LINK_LBL.ForeColor = System.Drawing.Color.Blue
        Me.ABOUT_LINK_LBL.Location = New System.Drawing.Point(338, 93)
        Me.ABOUT_LINK_LBL.Name = "ABOUT_LINK_LBL"
        Me.ABOUT_LINK_LBL.Size = New System.Drawing.Size(168, 16)
        Me.ABOUT_LINK_LBL.TabIndex = 5
        Me.ABOUT_LINK_LBL.Text = "www.dropController.com"
        '
        'About02_LBL
        '
        Me.About02_LBL.AutoSize = True
        Me.About02_LBL.Location = New System.Drawing.Point(310, 71)
        Me.About02_LBL.Name = "About02_LBL"
        Me.About02_LBL.Size = New System.Drawing.Size(490, 16)
        Me.About02_LBL.TabIndex = 2
        Me.About02_LBL.Text = "Arduino ddddbased solenoid valve controller for water drop photography."
        '
        'About01_LBL
        '
        Me.About01_LBL.AutoSize = True
        Me.About01_LBL.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About01_LBL.Location = New System.Drawing.Point(310, 47)
        Me.About01_LBL.Name = "About01_LBL"
        Me.About01_LBL.Size = New System.Drawing.Size(136, 18)
        Me.About01_LBL.TabIndex = 1
        Me.About01_LBL.Text = "dropController"
        '
        'AboutTab_Picture1
        '
        Me.AboutTab_Picture1.BackColor = System.Drawing.Color.White
        Me.AboutTab_Picture1.ErrorImage = Nothing
        Me.AboutTab_Picture1.Image = Global.dropController.My.Resources.Resources.MartynCurrey_WaterDrop_1
        Me.AboutTab_Picture1.InitialImage = Global.dropController.My.Resources.Resources.MartynCurrey_WaterDrop_1
        Me.AboutTab_Picture1.Location = New System.Drawing.Point(27, 42)
        Me.AboutTab_Picture1.Name = "AboutTab_Picture1"
        Me.AboutTab_Picture1.Size = New System.Drawing.Size(246, 368)
        Me.AboutTab_Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AboutTab_Picture1.TabIndex = 0
        Me.AboutTab_Picture1.TabStop = False
        '
        'AboutTab_Picture2
        '
        Me.AboutTab_Picture2.Image = Global.dropController.My.Resources.Resources.MartynCurrey_WaterDrop_2
        Me.AboutTab_Picture2.Location = New System.Drawing.Point(27, 42)
        Me.AboutTab_Picture2.Name = "AboutTab_Picture2"
        Me.AboutTab_Picture2.Size = New System.Drawing.Size(246, 368)
        Me.AboutTab_Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AboutTab_Picture2.TabIndex = 3
        Me.AboutTab_Picture2.TabStop = False
        '
        'AboutTab_Picture3
        '
        Me.AboutTab_Picture3.Image = Global.dropController.My.Resources.Resources.MartynCurrey_WaterDrop_3
        Me.AboutTab_Picture3.Location = New System.Drawing.Point(27, 42)
        Me.AboutTab_Picture3.Name = "AboutTab_Picture3"
        Me.AboutTab_Picture3.Size = New System.Drawing.Size(246, 368)
        Me.AboutTab_Picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AboutTab_Picture3.TabIndex = 4
        Me.AboutTab_Picture3.TabStop = False
        '
        'G_CAM_LBL
        '
        Me.G_CAM_LBL.AutoSize = True
        Me.G_CAM_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_CAM_LBL.Location = New System.Drawing.Point(1101, 309)
        Me.G_CAM_LBL.Name = "G_CAM_LBL"
        Me.G_CAM_LBL.Size = New System.Drawing.Size(39, 17)
        Me.G_CAM_LBL.TabIndex = 13
        Me.G_CAM_LBL.Text = "CAM"
        '
        'G_T2_LBL
        '
        Me.G_T2_LBL.AutoSize = True
        Me.G_T2_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_T2_LBL.Location = New System.Drawing.Point(1101, 292)
        Me.G_T2_LBL.Name = "G_T2_LBL"
        Me.G_T2_LBL.Size = New System.Drawing.Size(26, 17)
        Me.G_T2_LBL.TabIndex = 12
        Me.G_T2_LBL.Text = "T2"
        '
        'G_T1_LBL
        '
        Me.G_T1_LBL.AutoSize = True
        Me.G_T1_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_T1_LBL.Location = New System.Drawing.Point(1101, 275)
        Me.G_T1_LBL.Name = "G_T1_LBL"
        Me.G_T1_LBL.Size = New System.Drawing.Size(26, 17)
        Me.G_T1_LBL.TabIndex = 11
        Me.G_T1_LBL.Text = "T1"
        '
        'G_D4_LBL
        '
        Me.G_D4_LBL.AutoSize = True
        Me.G_D4_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_D4_LBL.Location = New System.Drawing.Point(1101, 224)
        Me.G_D4_LBL.Name = "G_D4_LBL"
        Me.G_D4_LBL.Size = New System.Drawing.Size(46, 17)
        Me.G_D4_LBL.TabIndex = 5
        Me.G_D4_LBL.Text = "SOL4"
        '
        'G_D3_LBL
        '
        Me.G_D3_LBL.AutoSize = True
        Me.G_D3_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_D3_LBL.Location = New System.Drawing.Point(1101, 207)
        Me.G_D3_LBL.Name = "G_D3_LBL"
        Me.G_D3_LBL.Size = New System.Drawing.Size(46, 17)
        Me.G_D3_LBL.TabIndex = 4
        Me.G_D3_LBL.Text = "SOL3"
        '
        'G_D2_LBL
        '
        Me.G_D2_LBL.AutoSize = True
        Me.G_D2_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_D2_LBL.Location = New System.Drawing.Point(1101, 190)
        Me.G_D2_LBL.Name = "G_D2_LBL"
        Me.G_D2_LBL.Size = New System.Drawing.Size(46, 17)
        Me.G_D2_LBL.TabIndex = 3
        Me.G_D2_LBL.Text = "SOL2"
        '
        'G_D1_LBL
        '
        Me.G_D1_LBL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_D1_LBL.Location = New System.Drawing.Point(1101, 173)
        Me.G_D1_LBL.Name = "G_D1_LBL"
        Me.G_D1_LBL.Size = New System.Drawing.Size(46, 17)
        Me.G_D1_LBL.TabIndex = 2
        Me.G_D1_LBL.Text = "SOL1"
        '
        'Timer_LoopDelay
        '
        '
        'Timer_dropAckTimeout
        '
        Me.Timer_dropAckTimeout.Interval = 5000
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(998, 81)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(59, 13)
        Me.Label50.TabIndex = 548
        Me.Label50.Text = "Delay timer"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(842, 78)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(116, 13)
        Me.Label52.TabIndex = 547
        Me.Label52.Text = "dropAckTimeout timer="
        '
        'Timer_LoopDelay_LBL
        '
        Me.Timer_LoopDelay_LBL.AutoSize = True
        Me.Timer_LoopDelay_LBL.Location = New System.Drawing.Point(1057, 81)
        Me.Timer_LoopDelay_LBL.Name = "Timer_LoopDelay_LBL"
        Me.Timer_LoopDelay_LBL.Size = New System.Drawing.Size(27, 13)
        Me.Timer_LoopDelay_LBL.TabIndex = 546
        Me.Timer_LoopDelay_LBL.Text = "OFF"
        '
        'TimerACK_LBL
        '
        Me.TimerACK_LBL.AutoSize = True
        Me.TimerACK_LBL.Location = New System.Drawing.Point(956, 78)
        Me.TimerACK_LBL.Name = "TimerACK_LBL"
        Me.TimerACK_LBL.Size = New System.Drawing.Size(27, 13)
        Me.TimerACK_LBL.TabIndex = 545
        Me.TimerACK_LBL.Text = "OFF"
        '
        'Timer_LoadImages
        '
        Me.Timer_LoadImages.Interval = 2500
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Loop_FT3_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_FT3_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_STOP_BTN)
        Me.GroupBox1.Controls.Add(Me.LP_Sequence_LBL)
        Me.GroupBox1.Controls.Add(Me.Loop_Title_LBL)
        Me.GroupBox1.Controls.Add(Me.Loop_FT2_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_FT2_LBL)
        Me.GroupBox1.Controls.Add(Me.progressBar_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_ProgressBar)
        Me.GroupBox1.Controls.Add(Me.sizeHead_LBL)
        Me.GroupBox1.Controls.Add(Me.stopHead_LBL)
        Me.GroupBox1.Controls.Add(Me.startHead_lbl)
        Me.GroupBox1.Controls.Add(Me.solHead_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum1_LBL)
        Me.GroupBox1.Controls.Add(Me.Loop_seq_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_ML_LBL)
        Me.GroupBox1.Controls.Add(Me.Loop_CT_LBL)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.LP_CT_LBL)
        Me.GroupBox1.Controls.Add(Me.Loop_FT1_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_FT1_LBL)
        Me.GroupBox1.Controls.Add(Me.drop9_LBL)
        Me.GroupBox1.Controls.Add(Me.drop8_LBL)
        Me.GroupBox1.Controls.Add(Me.drop7_LBL)
        Me.GroupBox1.Controls.Add(Me.drop6_LBL)
        Me.GroupBox1.Controls.Add(Me.drop5_LBL)
        Me.GroupBox1.Controls.Add(Me.drop4_LBL)
        Me.GroupBox1.Controls.Add(Me.drop3_LBL)
        Me.GroupBox1.Controls.Add(Me.drop2_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum9_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum8_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum7_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum6_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum5_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum4_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum3_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_dropNum2_LBL)
        Me.GroupBox1.Controls.Add(Me.drop1_LBL)
        Me.GroupBox1.Controls.Add(Me.LP_EXIT_BTN)
        Me.GroupBox1.Controls.Add(Me.LP_RESET_BTN)
        Me.GroupBox1.Controls.Add(Me.LP_START_BTN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 590)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(810, 520)
        Me.GroupBox1.TabIndex = 599
        Me.GroupBox1.TabStop = False
        '
        'Loop_FT3_LBL
        '
        Me.Loop_FT3_LBL.AutoSize = True
        Me.Loop_FT3_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop_FT3_LBL.Location = New System.Drawing.Point(648, 248)
        Me.Loop_FT3_LBL.Name = "Loop_FT3_LBL"
        Me.Loop_FT3_LBL.Size = New System.Drawing.Size(118, 18)
        Me.Loop_FT3_LBL.TabIndex = 701
        Me.Loop_FT3_LBL.Text = "0000 [-123]"
        '
        'LP_FT3_LBL
        '
        Me.LP_FT3_LBL.AutoSize = True
        Me.LP_FT3_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_FT3_LBL.Location = New System.Drawing.Point(598, 248)
        Me.LP_FT3_LBL.Name = "LP_FT3_LBL"
        Me.LP_FT3_LBL.Size = New System.Drawing.Size(48, 18)
        Me.LP_FT3_LBL.TabIndex = 700
        Me.LP_FT3_LBL.Text = "FT3:"
        '
        'LP_STOP_BTN
        '
        Me.LP_STOP_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LP_STOP_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_STOP_BTN.Location = New System.Drawing.Point(258, 420)
        Me.LP_STOP_BTN.Name = "LP_STOP_BTN"
        Me.LP_STOP_BTN.Size = New System.Drawing.Size(160, 48)
        Me.LP_STOP_BTN.TabIndex = 699
        Me.LP_STOP_BTN.Text = "S T O P"
        Me.LP_STOP_BTN.UseVisualStyleBackColor = False
        '
        'LP_Sequence_LBL
        '
        Me.LP_Sequence_LBL.AutoSize = True
        Me.LP_Sequence_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_Sequence_LBL.Location = New System.Drawing.Point(747, 131)
        Me.LP_Sequence_LBL.Name = "LP_Sequence_LBL"
        Me.LP_Sequence_LBL.Size = New System.Drawing.Size(19, 20)
        Me.LP_Sequence_LBL.TabIndex = 336
        Me.LP_Sequence_LBL.Text = "1"
        '
        'Loop_Title_LBL
        '
        Me.Loop_Title_LBL.AutoSize = True
        Me.Loop_Title_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop_Title_LBL.Location = New System.Drawing.Point(344, 38)
        Me.Loop_Title_LBL.Name = "Loop_Title_LBL"
        Me.Loop_Title_LBL.Size = New System.Drawing.Size(145, 29)
        Me.Loop_Title_LBL.TabIndex = 335
        Me.Loop_Title_LBL.Text = "Loop Mode"
        '
        'Loop_FT2_LBL
        '
        Me.Loop_FT2_LBL.AutoSize = True
        Me.Loop_FT2_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop_FT2_LBL.Location = New System.Drawing.Point(648, 228)
        Me.Loop_FT2_LBL.Name = "Loop_FT2_LBL"
        Me.Loop_FT2_LBL.Size = New System.Drawing.Size(118, 18)
        Me.Loop_FT2_LBL.TabIndex = 334
        Me.Loop_FT2_LBL.Text = "0000 [-123]"
        '
        'LP_FT2_LBL
        '
        Me.LP_FT2_LBL.AutoSize = True
        Me.LP_FT2_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_FT2_LBL.Location = New System.Drawing.Point(598, 228)
        Me.LP_FT2_LBL.Name = "LP_FT2_LBL"
        Me.LP_FT2_LBL.Size = New System.Drawing.Size(48, 18)
        Me.LP_FT2_LBL.TabIndex = 333
        Me.LP_FT2_LBL.Text = "FT2:"
        '
        'progressBar_LBL
        '
        Me.progressBar_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressBar_LBL.Location = New System.Drawing.Point(82, 367)
        Me.progressBar_LBL.Name = "progressBar_LBL"
        Me.progressBar_LBL.Size = New System.Drawing.Size(63, 18)
        Me.progressBar_LBL.TabIndex = 332
        Me.progressBar_LBL.Text = " Timer"
        Me.progressBar_LBL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LP_ProgressBar
        '
        Me.LP_ProgressBar.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LP_ProgressBar.Location = New System.Drawing.Point(161, 363)
        Me.LP_ProgressBar.Name = "LP_ProgressBar"
        Me.LP_ProgressBar.Size = New System.Drawing.Size(600, 25)
        Me.LP_ProgressBar.TabIndex = 331
        '
        'sizeHead_LBL
        '
        Me.sizeHead_LBL.AutoSize = True
        Me.sizeHead_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeHead_LBL.Location = New System.Drawing.Point(253, 102)
        Me.sizeHead_LBL.Name = "sizeHead_LBL"
        Me.sizeHead_LBL.Size = New System.Drawing.Size(50, 20)
        Me.sizeHead_LBL.TabIndex = 330
        Me.sizeHead_LBL.Text = "SIZE"
        '
        'stopHead_LBL
        '
        Me.stopHead_LBL.AutoSize = True
        Me.stopHead_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopHead_LBL.Location = New System.Drawing.Point(485, 102)
        Me.stopHead_LBL.Name = "stopHead_LBL"
        Me.stopHead_LBL.Size = New System.Drawing.Size(55, 20)
        Me.stopHead_LBL.TabIndex = 329
        Me.stopHead_LBL.Text = "STOP"
        '
        'startHead_lbl
        '
        Me.startHead_lbl.AutoSize = True
        Me.startHead_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startHead_lbl.Location = New System.Drawing.Point(375, 102)
        Me.startHead_lbl.Name = "startHead_lbl"
        Me.startHead_lbl.Size = New System.Drawing.Size(66, 20)
        Me.startHead_lbl.TabIndex = 328
        Me.startHead_lbl.Text = "START"
        '
        'solHead_LBL
        '
        Me.solHead_LBL.AutoSize = True
        Me.solHead_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solHead_LBL.Location = New System.Drawing.Point(173, 102)
        Me.solHead_LBL.Name = "solHead_LBL"
        Me.solHead_LBL.Size = New System.Drawing.Size(44, 20)
        Me.solHead_LBL.TabIndex = 327
        Me.solHead_LBL.Text = "SOL"
        '
        'LP_dropNum1_LBL
        '
        Me.LP_dropNum1_LBL.AutoSize = True
        Me.LP_dropNum1_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum1_LBL.Location = New System.Drawing.Point(93, 133)
        Me.LP_dropNum1_LBL.Name = "LP_dropNum1_LBL"
        Me.LP_dropNum1_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum1_LBL.TabIndex = 302
        Me.LP_dropNum1_LBL.Text = "Drop 1"
        '
        'Loop_seq_LBL
        '
        Me.Loop_seq_LBL.AutoSize = True
        Me.Loop_seq_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop_seq_LBL.Location = New System.Drawing.Point(597, 131)
        Me.Loop_seq_LBL.Name = "Loop_seq_LBL"
        Me.Loop_seq_LBL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Loop_seq_LBL.Size = New System.Drawing.Size(151, 20)
        Me.Loop_seq_LBL.TabIndex = 326
        Me.Loop_seq_LBL.Text = "Next Sequence = "
        '
        'LP_ML_LBL
        '
        Me.LP_ML_LBL.AutoSize = True
        Me.LP_ML_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_ML_LBL.Location = New System.Drawing.Point(648, 169)
        Me.LP_ML_LBL.Name = "LP_ML_LBL"
        Me.LP_ML_LBL.Size = New System.Drawing.Size(48, 18)
        Me.LP_ML_LBL.TabIndex = 325
        Me.LP_ML_LBL.Text = "1000"
        '
        'Loop_CT_LBL
        '
        Me.Loop_CT_LBL.AutoSize = True
        Me.Loop_CT_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop_CT_LBL.Location = New System.Drawing.Point(648, 188)
        Me.Loop_CT_LBL.Name = "Loop_CT_LBL"
        Me.Loop_CT_LBL.Size = New System.Drawing.Size(118, 18)
        Me.Loop_CT_LBL.TabIndex = 324
        Me.Loop_CT_LBL.Text = "0000 [-123]"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(598, 169)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(38, 18)
        Me.Label39.TabIndex = 322
        Me.Label39.Text = "ML:"
        '
        'LP_CT_LBL
        '
        Me.LP_CT_LBL.AutoSize = True
        Me.LP_CT_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_CT_LBL.Location = New System.Drawing.Point(598, 188)
        Me.LP_CT_LBL.Name = "LP_CT_LBL"
        Me.LP_CT_LBL.Size = New System.Drawing.Size(38, 18)
        Me.LP_CT_LBL.TabIndex = 321
        Me.LP_CT_LBL.Text = "CT:"
        '
        'Loop_FT1_LBL
        '
        Me.Loop_FT1_LBL.AutoSize = True
        Me.Loop_FT1_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop_FT1_LBL.Location = New System.Drawing.Point(648, 208)
        Me.Loop_FT1_LBL.Name = "Loop_FT1_LBL"
        Me.Loop_FT1_LBL.Size = New System.Drawing.Size(118, 18)
        Me.Loop_FT1_LBL.TabIndex = 323
        Me.Loop_FT1_LBL.Text = "0000 [-123]"
        '
        'LP_FT1_LBL
        '
        Me.LP_FT1_LBL.AutoSize = True
        Me.LP_FT1_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_FT1_LBL.Location = New System.Drawing.Point(598, 208)
        Me.LP_FT1_LBL.Name = "LP_FT1_LBL"
        Me.LP_FT1_LBL.Size = New System.Drawing.Size(48, 18)
        Me.LP_FT1_LBL.TabIndex = 320
        Me.LP_FT1_LBL.Text = "FT1:"
        '
        'drop9_LBL
        '
        Me.drop9_LBL.AutoSize = True
        Me.drop9_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop9_LBL.Location = New System.Drawing.Point(184, 293)
        Me.drop9_LBL.Name = "drop9_LBL"
        Me.drop9_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop9_LBL.TabIndex = 319
        Me.drop9_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop8_LBL
        '
        Me.drop8_LBL.AutoSize = True
        Me.drop8_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop8_LBL.Location = New System.Drawing.Point(184, 273)
        Me.drop8_LBL.Name = "drop8_LBL"
        Me.drop8_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop8_LBL.TabIndex = 318
        Me.drop8_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop7_LBL
        '
        Me.drop7_LBL.AutoSize = True
        Me.drop7_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop7_LBL.Location = New System.Drawing.Point(184, 253)
        Me.drop7_LBL.Name = "drop7_LBL"
        Me.drop7_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop7_LBL.TabIndex = 317
        Me.drop7_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop6_LBL
        '
        Me.drop6_LBL.AutoSize = True
        Me.drop6_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop6_LBL.Location = New System.Drawing.Point(184, 233)
        Me.drop6_LBL.Name = "drop6_LBL"
        Me.drop6_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop6_LBL.TabIndex = 316
        Me.drop6_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop5_LBL
        '
        Me.drop5_LBL.AutoSize = True
        Me.drop5_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop5_LBL.Location = New System.Drawing.Point(184, 213)
        Me.drop5_LBL.Name = "drop5_LBL"
        Me.drop5_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop5_LBL.TabIndex = 315
        Me.drop5_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop4_LBL
        '
        Me.drop4_LBL.AutoSize = True
        Me.drop4_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop4_LBL.Location = New System.Drawing.Point(184, 193)
        Me.drop4_LBL.Name = "drop4_LBL"
        Me.drop4_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop4_LBL.TabIndex = 314
        Me.drop4_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop3_LBL
        '
        Me.drop3_LBL.AutoSize = True
        Me.drop3_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop3_LBL.Location = New System.Drawing.Point(184, 173)
        Me.drop3_LBL.Name = "drop3_LBL"
        Me.drop3_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop3_LBL.TabIndex = 313
        Me.drop3_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'drop2_LBL
        '
        Me.drop2_LBL.AutoSize = True
        Me.drop2_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop2_LBL.Location = New System.Drawing.Point(184, 153)
        Me.drop2_LBL.Name = "drop2_LBL"
        Me.drop2_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop2_LBL.TabIndex = 312
        Me.drop2_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'LP_dropNum9_LBL
        '
        Me.LP_dropNum9_LBL.AutoSize = True
        Me.LP_dropNum9_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum9_LBL.Location = New System.Drawing.Point(93, 293)
        Me.LP_dropNum9_LBL.Name = "LP_dropNum9_LBL"
        Me.LP_dropNum9_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum9_LBL.TabIndex = 311
        Me.LP_dropNum9_LBL.Text = "Drop 9"
        '
        'LP_dropNum8_LBL
        '
        Me.LP_dropNum8_LBL.AutoSize = True
        Me.LP_dropNum8_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum8_LBL.Location = New System.Drawing.Point(93, 273)
        Me.LP_dropNum8_LBL.Name = "LP_dropNum8_LBL"
        Me.LP_dropNum8_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum8_LBL.TabIndex = 310
        Me.LP_dropNum8_LBL.Text = "Drop 8"
        '
        'LP_dropNum7_LBL
        '
        Me.LP_dropNum7_LBL.AutoSize = True
        Me.LP_dropNum7_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum7_LBL.Location = New System.Drawing.Point(93, 253)
        Me.LP_dropNum7_LBL.Name = "LP_dropNum7_LBL"
        Me.LP_dropNum7_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum7_LBL.TabIndex = 309
        Me.LP_dropNum7_LBL.Text = "Drop 7"
        '
        'LP_dropNum6_LBL
        '
        Me.LP_dropNum6_LBL.AutoSize = True
        Me.LP_dropNum6_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum6_LBL.Location = New System.Drawing.Point(93, 233)
        Me.LP_dropNum6_LBL.Name = "LP_dropNum6_LBL"
        Me.LP_dropNum6_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum6_LBL.TabIndex = 308
        Me.LP_dropNum6_LBL.Text = "Drop 6"
        '
        'LP_dropNum5_LBL
        '
        Me.LP_dropNum5_LBL.AutoSize = True
        Me.LP_dropNum5_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum5_LBL.Location = New System.Drawing.Point(93, 213)
        Me.LP_dropNum5_LBL.Name = "LP_dropNum5_LBL"
        Me.LP_dropNum5_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum5_LBL.TabIndex = 307
        Me.LP_dropNum5_LBL.Text = "Drop 5"
        '
        'LP_dropNum4_LBL
        '
        Me.LP_dropNum4_LBL.AutoSize = True
        Me.LP_dropNum4_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum4_LBL.Location = New System.Drawing.Point(93, 193)
        Me.LP_dropNum4_LBL.Name = "LP_dropNum4_LBL"
        Me.LP_dropNum4_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum4_LBL.TabIndex = 306
        Me.LP_dropNum4_LBL.Text = "Drop 4"
        '
        'LP_dropNum3_LBL
        '
        Me.LP_dropNum3_LBL.AutoSize = True
        Me.LP_dropNum3_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum3_LBL.Location = New System.Drawing.Point(93, 173)
        Me.LP_dropNum3_LBL.Name = "LP_dropNum3_LBL"
        Me.LP_dropNum3_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum3_LBL.TabIndex = 305
        Me.LP_dropNum3_LBL.Text = "Drop 3"
        '
        'LP_dropNum2_LBL
        '
        Me.LP_dropNum2_LBL.AutoSize = True
        Me.LP_dropNum2_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_dropNum2_LBL.Location = New System.Drawing.Point(93, 153)
        Me.LP_dropNum2_LBL.Name = "LP_dropNum2_LBL"
        Me.LP_dropNum2_LBL.Size = New System.Drawing.Size(68, 18)
        Me.LP_dropNum2_LBL.TabIndex = 304
        Me.LP_dropNum2_LBL.Text = "Drop 2"
        '
        'drop1_LBL
        '
        Me.drop1_LBL.AutoSize = True
        Me.drop1_LBL.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop1_LBL.Location = New System.Drawing.Point(184, 133)
        Me.drop1_LBL.Name = "drop1_LBL"
        Me.drop1_LBL.Size = New System.Drawing.Size(358, 18)
        Me.drop1_LBL.TabIndex = 303
        Me.drop1_LBL.Text = "0   0000 [-123]  0000 [-123]  00000"
        '
        'LP_EXIT_BTN
        '
        Me.LP_EXIT_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LP_EXIT_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_EXIT_BTN.Location = New System.Drawing.Point(600, 420)
        Me.LP_EXIT_BTN.Name = "LP_EXIT_BTN"
        Me.LP_EXIT_BTN.Size = New System.Drawing.Size(160, 48)
        Me.LP_EXIT_BTN.TabIndex = 693
        Me.LP_EXIT_BTN.Text = "E X I T"
        Me.LP_EXIT_BTN.UseVisualStyleBackColor = False
        '
        'LP_RESET_BTN
        '
        Me.LP_RESET_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LP_RESET_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_RESET_BTN.Location = New System.Drawing.Point(429, 420)
        Me.LP_RESET_BTN.Name = "LP_RESET_BTN"
        Me.LP_RESET_BTN.Size = New System.Drawing.Size(160, 48)
        Me.LP_RESET_BTN.TabIndex = 691
        Me.LP_RESET_BTN.Text = "R E S E T"
        Me.LP_RESET_BTN.UseVisualStyleBackColor = False
        '
        'LP_START_BTN
        '
        Me.LP_START_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LP_START_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LP_START_BTN.Location = New System.Drawing.Point(87, 420)
        Me.LP_START_BTN.Name = "LP_START_BTN"
        Me.LP_START_BTN.Size = New System.Drawing.Size(160, 48)
        Me.LP_START_BTN.TabIndex = 690
        Me.LP_START_BTN.Text = "S T A R T"
        Me.LP_START_BTN.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(998, 51)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(49, 13)
        Me.Label38.TabIndex = 550
        Me.Label38.Text = "Status = "
        '
        'STATUS_LBL
        '
        Me.STATUS_LBL.AutoSize = True
        Me.STATUS_LBL.Location = New System.Drawing.Point(1057, 51)
        Me.STATUS_LBL.Name = "STATUS_LBL"
        Me.STATUS_LBL.Size = New System.Drawing.Size(22, 13)
        Me.STATUS_LBL.TabIndex = 551
        Me.STATUS_LBL.Text = "NA"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(998, 65)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(47, 13)
        Me.Label40.TabIndex = 553
        Me.Label40.Text = "Serial IN"
        '
        'Timer_SD_IN_LBL
        '
        Me.Timer_SD_IN_LBL.AutoSize = True
        Me.Timer_SD_IN_LBL.Location = New System.Drawing.Point(1057, 65)
        Me.Timer_SD_IN_LBL.Name = "Timer_SD_IN_LBL"
        Me.Timer_SD_IN_LBL.Size = New System.Drawing.Size(27, 13)
        Me.Timer_SD_IN_LBL.TabIndex = 552
        Me.Timer_SD_IN_LBL.Text = "OFF"
        '
        'Timer_TestConnection_Timeout
        '
        Me.Timer_TestConnection_Timeout.Interval = 4000
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(333, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(185, 23)
        Me.Label28.TabIndex = 634
        Me.Label28.Text = "dropController"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveConfigToolStripMenuItem
        '
        Me.SaveConfigToolStripMenuItem.Name = "SaveConfigToolStripMenuItem"
        Me.SaveConfigToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveConfigToolStripMenuItem.Text = "Save config"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 1031)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.G_CAM_LBL)
        Me.Controls.Add(Me.Timer_SD_IN_LBL)
        Me.Controls.Add(Me.G_T2_LBL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.G_T1_LBL)
        Me.Controls.Add(Me.STATUS_LBL)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.G_D4_LBL)
        Me.Controls.Add(Me.G_D3_LBL)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.G_D2_LBL)
        Me.Controls.Add(Me.Timer_LoopDelay_LBL)
        Me.Controls.Add(Me.G_D1_LBL)
        Me.Controls.Add(Me.TimerACK_LBL)
        Me.Controls.Add(Me.GraphTabControl)
        Me.Controls.Add(Me.Connected_Flag)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.debugTextBox)
        Me.Controls.Add(Me.timerConnectFlag)
        Me.Controls.Add(Me.timerConnect_LBL)
        Me.Controls.Add(Me.MenuStripForm1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.dropController.My.MySettings.Default, "dropController", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripForm1
        Me.Name = "mainForm"
        Me.Text = Global.dropController.My.MySettings.Default.dropController
        Me.MenuStripForm1.ResumeLayout(False)
        Me.MenuStripForm1.PerformLayout()
        Me.GraphTabControl.ResumeLayout(False)
        Me.TAB_DROPS.ResumeLayout(False)
        Me.TAB_DROPS.PerformLayout()
        Me.TAB_SETTINGS.ResumeLayout(False)
        Me.TAB_SETTINGS.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TAB_GRAPH.ResumeLayout(False)
        Me.TAB_GRAPH.PerformLayout()
        Me.TAB_ABOUT.ResumeLayout(False)
        Me.TAB_ABOUT.PerformLayout()
        CType(Me.AboutTab_Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AboutTab_Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AboutTab_Picture3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerConnectFlag As System.Windows.Forms.Label
    Friend WithEvents timerConnect_LBL As System.Windows.Forms.Label
    Friend WithEvents CT_IncDecTime_TB As System.Windows.Forms.TextBox
    Friend WithEvents CT_IncDec_BTN As System.Windows.Forms.Button
    Friend WithEvents FT1_IncDecTime_TB As System.Windows.Forms.TextBox
    Friend WithEvents FT1_IncDec_BTN As System.Windows.Forms.Button
    Friend WithEvents CT_StartTime_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FT1_Time_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumDrops_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer_recieveSerialData As System.Windows.Forms.Timer
    Friend WithEvents Timer_ConnectionTimeout As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents debugTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStripForm1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timer_updateConnectButton As System.Windows.Forms.Timer
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Connected_Flag As System.Windows.Forms.Label
    Friend WithEvents checkConnected_Timer As System.Windows.Forms.Timer
    Friend WithEvents GraphTabControl As TabControl
    Friend WithEvents TAB_DROPS As TabPage
    Friend WithEvents TAB_SETTINGS As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents D3StartIncDec_BTN As Button
    Friend WithEvents D1Row_LBL As Label
    Friend WithEvents D1Sol_CB As ComboBox
    Friend WithEvents D1Separator01_LBL As Label
    Friend WithEvents D1StartTime_TB As TextBox
    Friend WithEvents D1StartIncDec_BTN As Button
    Friend WithEvents D1StartIncVal_TB As TextBox
    Friend WithEvents D1Separator02_LBL As Label
    Friend WithEvents D1Size_TB As TextBox
    Friend WithEvents MainStart_BTN As Button
    Friend WithEvents D1SizeIncDec_BTN As Button
    Friend WithEvents D1SizeIncVal_TB As TextBox
    Friend WithEvents D9SizeIncVal_TB As TextBox
    Friend WithEvents D2Row_LBL As Label
    Friend WithEvents D9SizeIncDec_BTN As Button
    Friend WithEvents D2Sol_CB As ComboBox
    Friend WithEvents D9Size_TB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents D2StartTime_TB As TextBox
    Friend WithEvents D9StartIncVal_TB As TextBox
    Friend WithEvents D2StartIncDec_BTN As Button
    Friend WithEvents D9StartIncDec_BTN As Button
    Friend WithEvents D2StartIncVal_TB As TextBox
    Friend WithEvents D9StartTime_TB As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents D2Size_TB As TextBox
    Friend WithEvents D9Sol_CB As ComboBox
    Friend WithEvents D2SizeIncDec_BTN As Button
    Friend WithEvents D9Row_LBL As Label
    Friend WithEvents D2SizeIncVal_TB As TextBox
    Friend WithEvents D8SizeIncVal_TB As TextBox
    Friend WithEvents D3Row_LBL As Label
    Friend WithEvents D8SizeIncDec_BTN As Button
    Friend WithEvents D3Sol_CB As ComboBox
    Friend WithEvents D8Size_TB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents D3StartTime_TB As TextBox
    Friend WithEvents D8StartIncVal_TB As TextBox
    Friend WithEvents D3StartIncVal_TB As TextBox
    Friend WithEvents D8StartIncDec_BTN As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents D8StartTime_TB As TextBox
    Friend WithEvents D3Size_TB As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents D3SizeIncDec_BTN As Button
    Friend WithEvents D8Sol_CB As ComboBox
    Friend WithEvents D3SizeIncVal_TB As TextBox
    Friend WithEvents D8Row_LBL As Label
    Friend WithEvents D4Row_LBL As Label
    Friend WithEvents D7SizeIncVal_TB As TextBox
    Friend WithEvents D4Sol_CB As ComboBox
    Friend WithEvents D7SizeIncDec_BTN As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents D7Size_TB As TextBox
    Friend WithEvents D4StartTime_TB As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents D4StartIncDec_BTN As Button
    Friend WithEvents D7StartIncVal_TB As TextBox
    Friend WithEvents D4StartIncVal_TB As TextBox
    Friend WithEvents D7StartIncDec_BTN As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents D7StartTime_TB As TextBox
    Friend WithEvents D4Size_TB As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents D4SizeIncDec_BTN As Button
    Friend WithEvents D7Sol_CB As ComboBox
    Friend WithEvents D4SizeIncVal_TB As TextBox
    Friend WithEvents D7Row_LBL As Label
    Friend WithEvents D5Row_LBL As Label
    Friend WithEvents D6SizeIncVal_TB As TextBox
    Friend WithEvents D5Sol_CB As ComboBox
    Friend WithEvents D6SizeIncDec_BTN As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents D6Size_TB As TextBox
    Friend WithEvents D5StartTime_TB As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents D5StartIncDec_BTN As Button
    Friend WithEvents D6StartIncVal_TB As TextBox
    Friend WithEvents D5StartIncVal_TB As TextBox
    Friend WithEvents D6StartIncDec_BTN As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents D6StartTime_TB As TextBox
    Friend WithEvents D5Size_TB As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents D5SizeIncDec_BTN As Button
    Friend WithEvents D6Sol_CB As ComboBox
    Friend WithEvents D5SizeIncVal_TB As TextBox
    Friend WithEvents D6Row_LBL As Label
    Friend WithEvents TAB_ABOUT As TabPage
    Friend WithEvents FT2_IncDecTime_TB As TextBox
    Friend WithEvents FT2_IncDec_BTN As Button
    Friend WithEvents FT2_Time_TB As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents FT1_BUTTON As Button
    Friend WithEvents SET_DEBUG_BTN As Button
    Friend WithEvents SET_DEBUG_LBL As Label
    Friend WithEvents lbl_VD4 As Label
    Friend WithEvents valve4Drain_BTN As Button
    Friend WithEvents lbl_VD3 As Label
    Friend WithEvents lbl_VD2 As Label
    Friend WithEvents lbl_VD1 As Label
    Friend WithEvents valve3Drain_BTN As Button
    Friend WithEvents valve2Drain_BTN As Button
    Friend WithEvents valve1Drain_BTN As Button
    Friend WithEvents ValveDrain_LBL As Label
    Friend WithEvents SET_SOUND_BTN As Button
    Friend WithEvents SET_SOUND_LBL As Label
    Friend WithEvents CT_Pulse_TB As TextBox
    Friend WithEvents FT1_Pulse_TB As TextBox
    Friend WithEvents CT_Pulse_lbl As Label
    Friend WithEvents FT1_Pulse_lbl As Label
    Friend WithEvents mirrorLockupTime_TB As TextBox
    Friend WithEvents ML_Time_LBL As Label
    Friend WithEvents mirrorLockupOnOff_BTN As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents FT2_Pulse_TB As TextBox
    Friend WithEvents FT2_Pulse_lbl As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents TestConnection_BTN As Button
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents COMport_CB As ComboBox
    Friend WithEvents refreshCOM_BTN As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents TAB_GRAPH As TabPage
    Friend WithEvents G_D4_LBL As Label
    Friend WithEvents G_D3_LBL As Label
    Friend WithEvents G_D2_LBL As Label
    Friend WithEvents G_D1_LBL As Label
    Friend WithEvents G_CAM_LBL As Label
    Friend WithEvents G_T2_LBL As Label
    Friend WithEvents G_T1_LBL As Label
    Friend WithEvents BulbMode_BTN As System.Windows.Forms.Button
    Friend WithEvents BulbMode_LBL As System.Windows.Forms.Label
    Friend WithEvents FT2_BUTTON As System.Windows.Forms.Button
    Friend WithEvents BulbStartOffset_Time_TB As System.Windows.Forms.TextBox
    Friend WithEvents BulbStart_LBL As System.Windows.Forms.Label
    Friend WithEvents BulbStopOffset_Time_TB As System.Windows.Forms.TextBox
    Friend WithEvents BulbStop_LBL As System.Windows.Forms.Label
    Friend WithEvents AboutTab_Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents About01_LBL As System.Windows.Forms.Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ResetAll_BTN As Button
    Friend WithEvents About02_LBL As System.Windows.Forms.Label
    Friend WithEvents Timer_LoopDelay As System.Windows.Forms.Timer
    Friend WithEvents Timer_dropAckTimeout As System.Windows.Forms.Timer
    Friend WithEvents Timer_ProgressBar As System.Windows.Forms.Timer
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Timer_LoopDelay_LBL As System.Windows.Forms.Label
    Friend WithEvents TimerACK_LBL As System.Windows.Forms.Label
    Friend WithEvents Timer_LoadImages As System.Windows.Forms.Timer
    Friend WithEvents AboutTab_Picture2 As System.Windows.Forms.PictureBox
    Friend WithEvents AboutTab_Picture3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LP_EXIT_BTN As Button
    Friend WithEvents LP_RESET_BTN As Button
    Friend WithEvents LP_START_BTN As Button
    Friend WithEvents Loop_Title_LBL As Label
    Friend WithEvents Loop_FT2_LBL As Label
    Friend WithEvents LP_FT2_LBL As Label
    Friend WithEvents progressBar_LBL As Label
    Friend WithEvents LP_ProgressBar As ProgressBar
    Friend WithEvents sizeHead_LBL As Label
    Friend WithEvents stopHead_LBL As Label
    Friend WithEvents startHead_lbl As Label
    Friend WithEvents solHead_LBL As Label
    Friend WithEvents LP_dropNum1_LBL As Label
    Friend WithEvents Loop_seq_LBL As Label
    Friend WithEvents LP_ML_LBL As Label
    Friend WithEvents Loop_CT_LBL As Label
    Friend WithEvents Loop_FT1_LBL As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents LP_CT_LBL As Label
    Friend WithEvents LP_FT1_LBL As Label
    Friend WithEvents drop9_LBL As Label
    Friend WithEvents drop8_LBL As Label
    Friend WithEvents drop7_LBL As Label
    Friend WithEvents drop6_LBL As Label
    Friend WithEvents drop5_LBL As Label
    Friend WithEvents drop4_LBL As Label
    Friend WithEvents drop3_LBL As Label
    Friend WithEvents drop2_LBL As Label
    Friend WithEvents LP_dropNum9_LBL As Label
    Friend WithEvents LP_dropNum8_LBL As Label
    Friend WithEvents LP_dropNum7_LBL As Label
    Friend WithEvents LP_dropNum6_LBL As Label
    Friend WithEvents LP_dropNum5_LBL As Label
    Friend WithEvents LP_dropNum4_LBL As Label
    Friend WithEvents LP_dropNum3_LBL As Label
    Friend WithEvents LP_dropNum2_LBL As Label
    Friend WithEvents drop1_LBL As Label
    Friend WithEvents LP_Sequence_LBL As Label
    Friend WithEvents LP_STOP_BTN As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents STATUS_LBL As Label
    Friend WithEvents SET_LEO_BUT As Button
    Friend WithEvents SET_LEO_LBL As Label
    Friend WithEvents LP_waitTimeVal_TB As TextBox
    Friend WithEvents lp_TimerOrButton_BTN As Button
    Friend WithEvents waitTime_LBL As Label
    Friend WithEvents timerButton_LBL As Label
    Friend WithEvents LoopMode_BTN As Button
    Friend WithEvents LoopMode_LBL As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ABOUT_LINK_LBL As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents CT_BUTTON As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents Timer_SD_IN_LBL As Label
    Friend WithEvents firmwareVersion_LBL As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Timer_TestConnection_Timeout As Timer
    Friend WithEvents About03_LBL As Label
    Friend WithEvents About05_LBL As Label
    Friend WithEvents About04_LBL As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Version_ComboBox As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents FT3_Pulse_lbl As Label
    Friend WithEvents FT3_Pulse_TB As TextBox
    Friend WithEvents Loop_FT3_LBL As Label
    Friend WithEvents LP_FT3_LBL As Label
    Friend WithEvents FT3_BUTTON As Button
    Friend WithEvents FT3_IncDecTime_TB As TextBox
    Friend WithEvents FT3_IncDec_BTN As Button
    Friend WithEvents FT3_Time_TB As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label36 As Label
    Friend WithEvents laser_Combo As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents light_Combo As ComboBox
    Friend WithEvents SaveConfigToolStripMenuItem As ToolStripMenuItem
End Class
