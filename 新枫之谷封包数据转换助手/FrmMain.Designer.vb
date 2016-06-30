<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonHex = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDec = New System.Windows.Forms.RadioButton()
        Me.TextBoxCalResult = New System.Windows.Forms.TextBox()
        Me.ButtonCal = New System.Windows.Forms.Button()
        Me.TextBoxCal2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxCal1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.TextBoxInputData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAsciiString = New System.Windows.Forms.TextBox()
        Me.RadioButtonBinaryToDec = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToBinary = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToDec = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToHex = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToMapleAsciiString = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToAsciiString = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToChar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToLong = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToInt = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToShort = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextBoxCalResult)
        Me.GroupBox1.Controls.Add(Me.ButtonCal)
        Me.GroupBox1.Controls.Add(Me.TextBoxCal2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBoxCal1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "="
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonHex)
        Me.GroupBox3.Controls.Add(Me.RadioButtonDec)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 47)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'RadioButtonHex
        '
        Me.RadioButtonHex.AutoSize = True
        Me.RadioButtonHex.Location = New System.Drawing.Point(242, 20)
        Me.RadioButtonHex.Name = "RadioButtonHex"
        Me.RadioButtonHex.Size = New System.Drawing.Size(71, 16)
        Me.RadioButtonHex.TabIndex = 1
        Me.RadioButtonHex.Text = "十六进制"
        Me.RadioButtonHex.UseVisualStyleBackColor = True
        '
        'RadioButtonDec
        '
        Me.RadioButtonDec.AutoSize = True
        Me.RadioButtonDec.Checked = True
        Me.RadioButtonDec.Location = New System.Drawing.Point(64, 20)
        Me.RadioButtonDec.Name = "RadioButtonDec"
        Me.RadioButtonDec.Size = New System.Drawing.Size(59, 16)
        Me.RadioButtonDec.TabIndex = 0
        Me.RadioButtonDec.TabStop = True
        Me.RadioButtonDec.Text = "十进制"
        Me.RadioButtonDec.UseVisualStyleBackColor = True
        '
        'TextBoxCalResult
        '
        Me.TextBoxCalResult.BackColor = System.Drawing.Color.White
        Me.TextBoxCalResult.Location = New System.Drawing.Point(279, 20)
        Me.TextBoxCalResult.Name = "TextBoxCalResult"
        Me.TextBoxCalResult.ReadOnly = True
        Me.TextBoxCalResult.Size = New System.Drawing.Size(115, 21)
        Me.TextBoxCalResult.TabIndex = 4
        '
        'ButtonCal
        '
        Me.ButtonCal.Location = New System.Drawing.Point(410, 20)
        Me.ButtonCal.Name = "ButtonCal"
        Me.ButtonCal.Size = New System.Drawing.Size(75, 52)
        Me.ButtonCal.TabIndex = 3
        Me.ButtonCal.Text = "计算"
        Me.ButtonCal.UseVisualStyleBackColor = True
        '
        'TextBoxCal2
        '
        Me.TextBoxCal2.Location = New System.Drawing.Point(168, 20)
        Me.TextBoxCal2.Name = "TextBoxCal2"
        Me.TextBoxCal2.Size = New System.Drawing.Size(89, 21)
        Me.TextBoxCal2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.ComboBox1.Location = New System.Drawing.Point(118, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(44, 20)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBoxCal1
        '
        Me.TextBoxCal1.Location = New System.Drawing.Point(23, 20)
        Me.TextBoxCal1.Name = "TextBoxCal1"
        Me.TextBoxCal1.Size = New System.Drawing.Size(89, 21)
        Me.TextBoxCal1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TextBoxResult)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ButtonCalculate)
        Me.GroupBox2.Controls.Add(Me.ButtonClear)
        Me.GroupBox2.Controls.Add(Me.TextBoxInputData)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 453)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TextBoxResult
        '
        Me.TextBoxResult.BackColor = System.Drawing.Color.White
        Me.TextBoxResult.Location = New System.Drawing.Point(92, 183)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ReadOnly = True
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxResult.Size = New System.Drawing.Size(393, 260)
        Me.TextBoxResult.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "换算结果："
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(410, 22)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalculate.TabIndex = 4
        Me.ButtonCalculate.Text = "计算"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(329, 22)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 3
        Me.ButtonClear.Text = "清空"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'TextBoxInputData
        '
        Me.TextBoxInputData.Location = New System.Drawing.Point(92, 24)
        Me.TextBoxInputData.Name = "TextBoxInputData"
        Me.TextBoxInputData.Size = New System.Drawing.Size(219, 21)
        Me.TextBoxInputData.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "输入数据："
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxAsciiString)
        Me.GroupBox4.Controls.Add(Me.RadioButtonBinaryToDec)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToBinary)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToDec)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToHex)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToMapleAsciiString)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToAsciiString)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToChar)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToLong)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToInt)
        Me.GroupBox4.Controls.Add(Me.RadioButtonToShort)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(479, 114)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'TextBoxAsciiString
        '
        Me.TextBoxAsciiString.Location = New System.Drawing.Point(358, 19)
        Me.TextBoxAsciiString.Name = "TextBoxAsciiString"
        Me.TextBoxAsciiString.ReadOnly = True
        Me.TextBoxAsciiString.Size = New System.Drawing.Size(109, 21)
        Me.TextBoxAsciiString.TabIndex = 10
        '
        'RadioButtonBinaryToDec
        '
        Me.RadioButtonBinaryToDec.AutoSize = True
        Me.RadioButtonBinaryToDec.Location = New System.Drawing.Point(358, 85)
        Me.RadioButtonBinaryToDec.Name = "RadioButtonBinaryToDec"
        Me.RadioButtonBinaryToDec.Size = New System.Drawing.Size(107, 16)
        Me.RadioButtonBinaryToDec.TabIndex = 9
        Me.RadioButtonBinaryToDec.Text = "二进制到十进制"
        Me.RadioButtonBinaryToDec.UseVisualStyleBackColor = True
        '
        'RadioButtonToBinary
        '
        Me.RadioButtonToBinary.AutoSize = True
        Me.RadioButtonToBinary.Location = New System.Drawing.Point(358, 63)
        Me.RadioButtonToBinary.Name = "RadioButtonToBinary"
        Me.RadioButtonToBinary.Size = New System.Drawing.Size(95, 16)
        Me.RadioButtonToBinary.TabIndex = 8
        Me.RadioButtonToBinary.Text = "转换为二进制"
        Me.RadioButtonToBinary.UseVisualStyleBackColor = True
        '
        'RadioButtonToDec
        '
        Me.RadioButtonToDec.AutoSize = True
        Me.RadioButtonToDec.Location = New System.Drawing.Point(189, 85)
        Me.RadioButtonToDec.Name = "RadioButtonToDec"
        Me.RadioButtonToDec.Size = New System.Drawing.Size(95, 16)
        Me.RadioButtonToDec.TabIndex = 7
        Me.RadioButtonToDec.Text = "转换到十进制"
        Me.RadioButtonToDec.UseVisualStyleBackColor = True
        '
        'RadioButtonToHex
        '
        Me.RadioButtonToHex.AutoSize = True
        Me.RadioButtonToHex.Location = New System.Drawing.Point(189, 63)
        Me.RadioButtonToHex.Name = "RadioButtonToHex"
        Me.RadioButtonToHex.Size = New System.Drawing.Size(107, 16)
        Me.RadioButtonToHex.TabIndex = 6
        Me.RadioButtonToHex.Text = "转换到十六进制"
        Me.RadioButtonToHex.UseVisualStyleBackColor = True
        '
        'RadioButtonToMapleAsciiString
        '
        Me.RadioButtonToMapleAsciiString.AutoSize = True
        Me.RadioButtonToMapleAsciiString.Location = New System.Drawing.Point(189, 41)
        Me.RadioButtonToMapleAsciiString.Name = "RadioButtonToMapleAsciiString"
        Me.RadioButtonToMapleAsciiString.Size = New System.Drawing.Size(155, 16)
        Me.RadioButtonToMapleAsciiString.TabIndex = 5
        Me.RadioButtonToMapleAsciiString.Text = "换算成MapleAsciiString"
        Me.RadioButtonToMapleAsciiString.UseVisualStyleBackColor = True
        '
        'RadioButtonToAsciiString
        '
        Me.RadioButtonToAsciiString.AutoSize = True
        Me.RadioButtonToAsciiString.Location = New System.Drawing.Point(189, 20)
        Me.RadioButtonToAsciiString.Name = "RadioButtonToAsciiString"
        Me.RadioButtonToAsciiString.Size = New System.Drawing.Size(125, 16)
        Me.RadioButtonToAsciiString.TabIndex = 4
        Me.RadioButtonToAsciiString.Text = "换算成AsciiString"
        Me.RadioButtonToAsciiString.UseVisualStyleBackColor = True
        '
        'RadioButtonToChar
        '
        Me.RadioButtonToChar.AutoSize = True
        Me.RadioButtonToChar.Location = New System.Drawing.Point(17, 85)
        Me.RadioButtonToChar.Name = "RadioButtonToChar"
        Me.RadioButtonToChar.Size = New System.Drawing.Size(83, 16)
        Me.RadioButtonToChar.TabIndex = 3
        Me.RadioButtonToChar.Text = "换算成Char"
        Me.RadioButtonToChar.UseVisualStyleBackColor = True
        '
        'RadioButtonToLong
        '
        Me.RadioButtonToLong.AutoSize = True
        Me.RadioButtonToLong.Location = New System.Drawing.Point(17, 63)
        Me.RadioButtonToLong.Name = "RadioButtonToLong"
        Me.RadioButtonToLong.Size = New System.Drawing.Size(83, 16)
        Me.RadioButtonToLong.TabIndex = 2
        Me.RadioButtonToLong.Text = "换算成Long"
        Me.RadioButtonToLong.UseVisualStyleBackColor = True
        '
        'RadioButtonToInt
        '
        Me.RadioButtonToInt.AutoSize = True
        Me.RadioButtonToInt.Location = New System.Drawing.Point(17, 41)
        Me.RadioButtonToInt.Name = "RadioButtonToInt"
        Me.RadioButtonToInt.Size = New System.Drawing.Size(77, 16)
        Me.RadioButtonToInt.TabIndex = 1
        Me.RadioButtonToInt.Text = "换算成Int"
        Me.RadioButtonToInt.UseVisualStyleBackColor = True
        '
        'RadioButtonToShort
        '
        Me.RadioButtonToShort.AutoSize = True
        Me.RadioButtonToShort.Checked = True
        Me.RadioButtonToShort.Location = New System.Drawing.Point(17, 20)
        Me.RadioButtonToShort.Name = "RadioButtonToShort"
        Me.RadioButtonToShort.Size = New System.Drawing.Size(89, 16)
        Me.RadioButtonToShort.TabIndex = 0
        Me.RadioButtonToShort.TabStop = True
        Me.RadioButtonToShort.Text = "换算成Short"
        Me.RadioButtonToShort.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(515, 606)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "新枫之谷封包数据转换助手"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxCal2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBoxCal1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonHex As RadioButton
    Friend WithEvents RadioButtonDec As RadioButton
    Friend WithEvents TextBoxCalResult As TextBox
    Friend WithEvents ButtonCal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents TextBoxInputData As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBoxAsciiString As TextBox
    Friend WithEvents RadioButtonBinaryToDec As RadioButton
    Friend WithEvents RadioButtonToBinary As RadioButton
    Friend WithEvents RadioButtonToDec As RadioButton
    Friend WithEvents RadioButtonToHex As RadioButton
    Friend WithEvents RadioButtonToMapleAsciiString As RadioButton
    Friend WithEvents RadioButtonToAsciiString As RadioButton
    Friend WithEvents RadioButtonToChar As RadioButton
    Friend WithEvents RadioButtonToLong As RadioButton
    Friend WithEvents RadioButtonToInt As RadioButton
    Friend WithEvents RadioButtonToShort As RadioButton
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Label3 As Label
End Class
