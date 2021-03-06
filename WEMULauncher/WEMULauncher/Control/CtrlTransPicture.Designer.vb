﻿Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlTransPicture
    Inherits PictureBox

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        ''transparency
        Me.SetStyle(ControlStyles.Opaque, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, False)
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
    End Sub
#Region "transparency"


    'Public Sub New()
    '    InitializeComponent()
    '    SetStyle(ControlStyles.Opaque, True)
    '    ''transparency
    '    SetStyle(ControlStyles.Opaque, True)
    '    SetStyle(ControlStyles.OptimizedDoubleBuffer, False)
    '    SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
    'End Sub

    'Public Sub New(con As IContainer)

    '    con.Add(Me)
    '    InitializeComponent()
    'End Sub

    Private Const WS_EX_TRANSPARENT As Integer = &H20
    Protected Overrides ReadOnly Property CreateParams() _
            As CreateParams

        Get
            Dim cpar As CreateParams = MyBase.CreateParams

            cpar.ExStyle = cpar.ExStyle Or WS_EX_TRANSPARENT

            Return cpar

        End Get

    End Property
    Private iopacity As Integer = 50

    <DefaultValue(50)>
    Public Property Opacity() As Integer

        Get

            Return Me.iopacity

        End Get

        Set

            If Value < 0 OrElse Value > 100 Then

                Throw New ArgumentException("value must be between _
                  0 and 100")

            End If

            Me.iopacity = Value

        End Set

    End Property
#End Region
End Class
