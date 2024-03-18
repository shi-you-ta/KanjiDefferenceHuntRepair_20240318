<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGame
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
        components = New ComponentModel.Container()
        SplitContainer1 = New SplitContainer()
        ButtonStart = New Button()
        Label3 = New Label()
        TextTimer = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextHunt = New TextBox()
        Button25 = New Button()
        Button20 = New Button()
        Button15 = New Button()
        Button10 = New Button()
        Button5 = New Button()
        Button24 = New Button()
        Button19 = New Button()
        Button14 = New Button()
        Button9 = New Button()
        Button4 = New Button()
        Button23 = New Button()
        Button18 = New Button()
        Button13 = New Button()
        Button8 = New Button()
        Button3 = New Button()
        Button22 = New Button()
        Button17 = New Button()
        Button12 = New Button()
        Button7 = New Button()
        Button2 = New Button()
        Button21 = New Button()
        Button16 = New Button()
        Button11 = New Button()
        Button6 = New Button()
        Button1 = New Button()
        Timer1 = New Timer(components)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(ButtonStart)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(TextTimer)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(TextHunt)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Button25)
        SplitContainer1.Panel2.Controls.Add(Button20)
        SplitContainer1.Panel2.Controls.Add(Button15)
        SplitContainer1.Panel2.Controls.Add(Button10)
        SplitContainer1.Panel2.Controls.Add(Button5)
        SplitContainer1.Panel2.Controls.Add(Button24)
        SplitContainer1.Panel2.Controls.Add(Button19)
        SplitContainer1.Panel2.Controls.Add(Button14)
        SplitContainer1.Panel2.Controls.Add(Button9)
        SplitContainer1.Panel2.Controls.Add(Button4)
        SplitContainer1.Panel2.Controls.Add(Button23)
        SplitContainer1.Panel2.Controls.Add(Button18)
        SplitContainer1.Panel2.Controls.Add(Button13)
        SplitContainer1.Panel2.Controls.Add(Button8)
        SplitContainer1.Panel2.Controls.Add(Button3)
        SplitContainer1.Panel2.Controls.Add(Button22)
        SplitContainer1.Panel2.Controls.Add(Button17)
        SplitContainer1.Panel2.Controls.Add(Button12)
        SplitContainer1.Panel2.Controls.Add(Button7)
        SplitContainer1.Panel2.Controls.Add(Button2)
        SplitContainer1.Panel2.Controls.Add(Button21)
        SplitContainer1.Panel2.Controls.Add(Button16)
        SplitContainer1.Panel2.Controls.Add(Button11)
        SplitContainer1.Panel2.Controls.Add(Button6)
        SplitContainer1.Panel2.Controls.Add(Button1)
        SplitContainer1.Size = New Size(682, 703)
        SplitContainer1.SplitterDistance = 70
        SplitContainer1.TabIndex = 0
        ' 
        ' ButtonStart
        ' 
        ButtonStart.Font = New Font("メイリオ", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        ButtonStart.Location = New Point(443, 10)
        ButtonStart.Name = "ButtonStart"
        ButtonStart.Size = New Size(211, 55)
        ButtonStart.TabIndex = 5
        ButtonStart.Text = "スタート"
        ButtonStart.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(377, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 20)
        Label3.TabIndex = 4
        Label3.Text = "秒"
        ' 
        ' TextTimer
        ' 
        TextTimer.Font = New Font("メイリオ", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        TextTimer.Location = New Point(203, 12)
        TextTimer.Name = "TextTimer"
        TextTimer.Size = New Size(160, 48)
        TextTimer.TabIndex = 3
        TextTimer.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(143, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 2
        Label2.Text = "記録："
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 20)
        Label1.TabIndex = 1
        Label1.Text = "を探せ"
        ' 
        ' TextHunt
        ' 
        TextHunt.Font = New Font("メイリオ", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        TextHunt.Location = New Point(12, 12)
        TextHunt.Name = "TextHunt"
        TextHunt.Size = New Size(55, 48)
        TextHunt.TabIndex = 0
        ' 
        ' Button25
        ' 
        Button25.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button25.Location = New Point(544, 517)
        Button25.Name = "Button25"
        Button25.Size = New Size(125, 100)
        Button25.TabIndex = 0
        Button25.UseVisualStyleBackColor = True
        ' 
        ' Button20
        ' 
        Button20.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button20.Location = New Point(544, 387)
        Button20.Name = "Button20"
        Button20.Size = New Size(125, 100)
        Button20.TabIndex = 0
        Button20.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button15.Location = New Point(544, 259)
        Button15.Name = "Button15"
        Button15.Size = New Size(125, 100)
        Button15.TabIndex = 0
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button10.Location = New Point(544, 131)
        Button10.Name = "Button10"
        Button10.Size = New Size(125, 100)
        Button10.TabIndex = 0
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button5.Location = New Point(544, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(125, 100)
        Button5.TabIndex = 0
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button24
        ' 
        Button24.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button24.Location = New Point(411, 517)
        Button24.Name = "Button24"
        Button24.Size = New Size(125, 100)
        Button24.TabIndex = 0
        Button24.UseVisualStyleBackColor = True
        ' 
        ' Button19
        ' 
        Button19.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button19.Location = New Point(411, 387)
        Button19.Name = "Button19"
        Button19.Size = New Size(125, 100)
        Button19.TabIndex = 0
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button14.Location = New Point(411, 259)
        Button14.Name = "Button14"
        Button14.Size = New Size(125, 100)
        Button14.TabIndex = 0
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button9.Location = New Point(411, 131)
        Button9.Name = "Button9"
        Button9.Size = New Size(125, 100)
        Button9.TabIndex = 0
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button4.Location = New Point(411, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 100)
        Button4.TabIndex = 0
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button23
        ' 
        Button23.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button23.Location = New Point(278, 517)
        Button23.Name = "Button23"
        Button23.Size = New Size(125, 100)
        Button23.TabIndex = 0
        Button23.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button18.Location = New Point(278, 387)
        Button18.Name = "Button18"
        Button18.Size = New Size(125, 100)
        Button18.TabIndex = 0
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button13.Location = New Point(278, 259)
        Button13.Name = "Button13"
        Button13.Size = New Size(125, 100)
        Button13.TabIndex = 0
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button8.Location = New Point(278, 131)
        Button8.Name = "Button8"
        Button8.Size = New Size(125, 100)
        Button8.TabIndex = 0
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button3.Location = New Point(278, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 100)
        Button3.TabIndex = 0
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button22
        ' 
        Button22.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button22.Location = New Point(145, 517)
        Button22.Name = "Button22"
        Button22.Size = New Size(125, 100)
        Button22.TabIndex = 0
        Button22.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button17.Location = New Point(145, 387)
        Button17.Name = "Button17"
        Button17.Size = New Size(125, 100)
        Button17.TabIndex = 0
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button12.Location = New Point(145, 259)
        Button12.Name = "Button12"
        Button12.Size = New Size(125, 100)
        Button12.TabIndex = 0
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button7.Location = New Point(145, 131)
        Button7.Name = "Button7"
        Button7.Size = New Size(125, 100)
        Button7.TabIndex = 0
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button2.Location = New Point(145, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 100)
        Button2.TabIndex = 0
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button21
        ' 
        Button21.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button21.Location = New Point(12, 515)
        Button21.Name = "Button21"
        Button21.Size = New Size(125, 100)
        Button21.TabIndex = 0
        Button21.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button16.Location = New Point(12, 387)
        Button16.Name = "Button16"
        Button16.Size = New Size(125, 100)
        Button16.TabIndex = 0
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button11.Location = New Point(12, 259)
        Button11.Name = "Button11"
        Button11.Size = New Size(125, 100)
        Button11.TabIndex = 0
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button6.Location = New Point(12, 131)
        Button6.Name = "Button6"
        Button6.Size = New Size(125, 100)
        Button6.TabIndex = 0
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("メイリオ", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button1.Location = New Point(12, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 100)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 20
        ' 
        ' FormGame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(682, 703)
        Controls.Add(SplitContainer1)
        Name = "FormGame"
        Text = "間違い探し"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents TextTimer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextHunt As TextBox
    Friend WithEvents ButtonStart As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer

End Class
