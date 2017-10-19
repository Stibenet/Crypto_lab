object Form1: TForm1
  Left = 184
  Top = 237
  BorderIcons = [biSystemMenu]
  BorderStyle = bsSingle
  Caption = #1047#1072#1096#1080#1092#1088#1086#1074#1072#1085#1080#1077'/'#1088#1072#1089#1096#1080#1092#1088#1086#1074#1072#1085#1080#1077' '#1090#1077#1082#1089#1090#1072' '#1072#1083#1075#1086#1088#1080#1090#1084#1086#1084' '#1055#1083#1077#1081#1092#1077#1088#1072
  ClientHeight = 438
  ClientWidth = 800
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label4: TLabel
    Left = 648
    Top = 424
    Width = 150
    Height = 13
    Caption = #1042#1089#1077' '#1087#1088#1072#1074#1072' '#1079#1072#1097#1080#1097#1077#1085#1099' '#169' 2006'
  end
  object GroupBox1: TGroupBox
    Left = 8
    Top = 0
    Width = 529
    Height = 233
    Caption = #1048#1089#1093#1086#1076#1085#1099#1081' '#1090#1077#1082#1089#1090
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    object Label1: TLabel
      Left = 8
      Top = 200
      Width = 37
      Height = 16
      Caption = #1050#1083#1102#1095':'
    end
    object Label2: TLabel
      Left = 312
      Top = 16
      Width = 64
      Height = 16
      Alignment = taRightJustify
      Caption = 'Quantity'
      Font.Charset = RUSSIAN_CHARSET
      Font.Color = clBlack
      Font.Height = -13
      Font.Name = 'Courier New'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Memo1: TMemo
      Left = 8
      Top = 32
      Width = 369
      Height = 153
      Hint = #1048#1089#1093#1086#1076#1085#1099#1081' '#1090#1077#1082#1089#1090', '#1082#1086#1090#1086#1088#1099#1081' '#1042#1099' '#1074#1074#1077#1083#1080' '#1080#1083#1080' '#1079#1072#1075#1088#1091#1079#1080#1083#1080' '#1080#1079' '#1092#1072#1081#1083#1072
      ParentShowHint = False
      ScrollBars = ssVertical
      ShowHint = True
      TabOrder = 0
    end
    object Button1: TButton
      Left = 392
      Top = 96
      Width = 121
      Height = 25
      Hint = #1053#1072#1078#1084#1080#1090#1077', '#1095#1090#1086#1073#1099' '#1086#1090#1082#1088#1099#1090#1100' '#1090#1077#1082#1089#1090#1086#1074#1099#1081' '#1092#1072#1081#1083
      Caption = #1054#1090#1082#1088#1099#1090#1100' '#1090#1077#1082#1089#1090
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 1
      OnClick = Button1Click
    end
    object Edit1: TEdit
      Left = 56
      Top = 200
      Width = 321
      Height = 24
      Hint = 
        #1050#1083#1102#1095#1077#1074#1086#1077' '#1089#1083#1086#1074#1086', '#1089' '#1087#1086#1084#1086#1097#1100#1102' '#1082#1086#1090#1086#1088#1086#1075#1086' '#1087#1088#1086#1080#1089#1093#1086#1076#1080#1090' '#1096#1080#1092#1088#1086#1074#1072#1085#1080#1077' '#1080#1083#1080' '#1076#1077#1096 +
        #1080#1092#1088#1086#1074#1072#1085#1080#1077' '#1090#1077#1082#1089#1090#1072
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -13
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 2
      Text = 'Edit1'
    end
    object Button2: TButton
      Left = 392
      Top = 128
      Width = 121
      Height = 25
      Hint = #1053#1072#1078#1084#1080#1090#1077', '#1095#1090#1086#1073#1099' '#1085#1072#1095#1072#1090#1100' '#1096#1080#1092#1088#1086#1074#1072#1090#1100'/'#1076#1077#1096#1080#1092#1088#1086#1074#1072#1090#1100' '#1090#1077#1082#1089#1090
      Caption = #1057#1090#1072#1088#1090
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 3
      OnClick = Button2Click
    end
    object ProgressBar1: TProgressBar
      Left = 392
      Top = 200
      Width = 121
      Height = 25
      Min = 0
      Max = 100
      TabOrder = 4
    end
    object Button5: TButton
      Left = 392
      Top = 168
      Width = 121
      Height = 17
      Hint = #1053#1072#1078#1084#1080#1090#1077', '#1095#1090#1086#1073#1099' '#1086#1095#1080#1089#1090#1080#1090#1100' '#1087#1086#1083#1077' '#1080#1089#1093#1086#1076#1085#1086#1075#1086' '#1090#1077#1082#1089#1090#1072
      Caption = #1054#1095#1080#1089#1090#1080#1090#1100' '#1092#1086#1088#1084#1091
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 5
      OnClick = Button5Click
    end
  end
  object RadioGroup1: TRadioGroup
    Left = 400
    Top = 24
    Width = 121
    Height = 65
    Caption = #1044#1077#1081#1089#1090#1074#1080#1077
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
  end
  object RadioButton1: TRadioButton
    Left = 408
    Top = 40
    Width = 97
    Height = 17
    Hint = #1042#1099#1073#1077#1088#1080#1090#1077' '#1101#1090#1091' '#1086#1087#1094#1080#1102', '#1095#1090#1086#1073#1099' '#1079#1072#1096#1080#1092#1088#1086#1074#1072#1090#1100' '#1090#1077#1082#1089#1090
    Caption = #1047#1072#1096#1080#1092#1088#1086#1074#1072#1090#1100
    ParentShowHint = False
    ShowHint = True
    TabOrder = 2
    OnClick = RadioButton1Click
  end
  object RadioButton2: TRadioButton
    Left = 408
    Top = 56
    Width = 97
    Height = 17
    Hint = #1042#1099#1073#1077#1088#1080#1090#1077' '#1101#1090#1091' '#1086#1087#1094#1080#1102', '#1095#1090#1086#1073#1099' '#1076#1077#1096#1080#1092#1088#1086#1074#1072#1090#1100' '#1090#1077#1082#1089#1090
    Caption = #1056#1072#1089#1096#1080#1092#1088#1086#1074#1072#1090#1100
    ParentShowHint = False
    ShowHint = True
    TabOrder = 3
    OnClick = RadioButton2Click
  end
  object GroupBox2: TGroupBox
    Left = 8
    Top = 240
    Width = 529
    Height = 193
    Caption = #1056#1077#1079#1091#1083#1100#1090#1072#1090
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 4
    object Label3: TLabel
      Left = 312
      Top = 16
      Width = 64
      Height = 16
      Alignment = taRightJustify
      Caption = 'Quantity'
      Font.Charset = RUSSIAN_CHARSET
      Font.Color = clBlack
      Font.Height = -13
      Font.Name = 'Courier New'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Memo2: TMemo
      Left = 8
      Top = 32
      Width = 369
      Height = 153
      Hint = 
        #1058#1077#1082#1089#1090', '#1082#1086#1090#1086#1088#1099#1081' '#1073#1099#1083' '#1087#1086#1083#1091#1095#1077#1085' '#1074' '#1088#1077#1079#1091#1083#1100#1090#1072#1090#1077' '#1074#1099#1087#1086#1083#1085#1077#1085#1080#1103' '#1086#1087#1077#1088#1072#1094#1080#1080' '#1096#1080#1092#1088 +
        #1086#1074#1072#1085#1080#1103' '#1080#1083#1080' '#1076#1077#1096#1080#1092#1088#1086#1074#1072#1085#1080#1103
      ParentShowHint = False
      ReadOnly = True
      ScrollBars = ssVertical
      ShowHint = True
      TabOrder = 0
    end
    object Button3: TButton
      Left = 392
      Top = 32
      Width = 121
      Height = 25
      Hint = #1053#1072#1078#1084#1080#1090#1077', '#1095#1090#1086#1073#1099' '#1089#1086#1093#1088#1072#1085#1080#1090#1100' '#1088#1077#1079#1091#1083#1100#1090#1072#1090' '#1074' '#1090#1077#1082#1089#1090#1086#1074#1086#1084' '#1092#1072#1081#1083#1077
      Caption = #1057#1086#1093#1088#1072#1085#1080#1090#1100
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 1
      OnClick = Button3Click
    end
    object Button4: TButton
      Left = 392
      Top = 160
      Width = 123
      Height = 25
      Hint = #1053#1072#1078#1084#1080#1090#1077', '#1095#1090#1086#1073#1099' '#1087#1086#1089#1084#1086#1090#1088#1077#1090#1100' '#1089#1074#1077#1076#1077#1085#1080#1103' '#1086' '#1087#1088#1086#1075#1088#1072#1084#1084#1077
      Caption = #1054' '#1087#1088#1086#1075#1088#1072#1084#1084#1077
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = True
      TabOrder = 2
      OnClick = Button4Click
    end
    object Button6: TButton
      Left = 392
      Top = 64
      Width = 121
      Height = 25
      Caption = #1050#1086#1087#1080#1088#1086#1074#1072#1090#1100
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
      TabOrder = 3
      OnClick = Button6Click
    end
  end
  object GroupBox3: TGroupBox
    Left = 544
    Top = 0
    Width = 249
    Height = 233
    Caption = #1064#1080#1092#1088#1086#1074#1072#1083#1100#1085#1072#1103' '#1088#1077#1096#1077#1090#1082#1072
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 5
    object Memo3: TMemo
      Left = 8
      Top = 32
      Width = 230
      Height = 160
      Font.Charset = RUSSIAN_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Courier New'
      Font.Style = []
      ParentFont = False
      ReadOnly = True
      TabOrder = 0
    end
  end
  object OpenDialog1: TOpenDialog
    Left = 400
    Top = 368
  end
end
