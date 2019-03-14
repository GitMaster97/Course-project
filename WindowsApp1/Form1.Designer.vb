<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.IPDest = New System.Windows.Forms.TextBox()
        Me.PortDest = New System.Windows.Forms.NumericUpDown()
        Me.IshodMessage = New System.Windows.Forms.TextBox()
        Me.KnopkaOtpravkiMsg = New System.Windows.Forms.Button()
        Me.FileOtpravka = New System.Windows.Forms.Button()
        Me.LocalIPLabel = New System.Windows.Forms.Label()
        Me.ServerPort = New System.Windows.Forms.NumericUpDown()
        Me.StartStopKnopka = New System.Windows.Forms.Button()
        Me.IncomingMessage = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PortDest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IPDest
        '
        Me.IPDest.Location = New System.Drawing.Point(12, 12)
        Me.IPDest.Name = "IPDest"
        Me.IPDest.Size = New System.Drawing.Size(100, 20)
        Me.IPDest.TabIndex = 0
        Me.IPDest.Text = "0.0.0.0"
        '
        'PortDest
        '
        Me.PortDest.Location = New System.Drawing.Point(118, 12)
        Me.PortDest.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.PortDest.Name = "PortDest"
        Me.PortDest.Size = New System.Drawing.Size(56, 20)
        Me.PortDest.TabIndex = 1
        Me.PortDest.Value = New Decimal(New Integer() {6767, 0, 0, 0})
        '
        'IshodMessage
        '
        Me.IshodMessage.Location = New System.Drawing.Point(12, 38)
        Me.IshodMessage.Name = "IshodMessage"
        Me.IshodMessage.Size = New System.Drawing.Size(162, 20)
        Me.IshodMessage.TabIndex = 2
        '
        'KnopkaOtpravkiMsg
        '
        Me.KnopkaOtpravkiMsg.Location = New System.Drawing.Point(180, 12)
        Me.KnopkaOtpravkiMsg.Name = "KnopkaOtpravkiMsg"
        Me.KnopkaOtpravkiMsg.Size = New System.Drawing.Size(102, 46)
        Me.KnopkaOtpravkiMsg.TabIndex = 3
        Me.KnopkaOtpravkiMsg.Text = "Send message"
        Me.KnopkaOtpravkiMsg.UseVisualStyleBackColor = True
        '
        'FileOtpravka
        '
        Me.FileOtpravka.Location = New System.Drawing.Point(180, 64)
        Me.FileOtpravka.Name = "FileOtpravka"
        Me.FileOtpravka.Size = New System.Drawing.Size(102, 23)
        Me.FileOtpravka.TabIndex = 4
        Me.FileOtpravka.Text = "Send file"
        Me.FileOtpravka.UseVisualStyleBackColor = True
        '
        'LocalIPLabel
        '
        Me.LocalIPLabel.AutoSize = True
        Me.LocalIPLabel.Location = New System.Drawing.Point(12, 96)
        Me.LocalIPLabel.Name = "LocalIPLabel"
        Me.LocalIPLabel.Size = New System.Drawing.Size(46, 13)
        Me.LocalIPLabel.TabIndex = 5
        Me.LocalIPLabel.Text = "Local IP"
        '
        'ServerPort
        '
        Me.ServerPort.Location = New System.Drawing.Point(118, 122)
        Me.ServerPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.ServerPort.Name = "ServerPort"
        Me.ServerPort.Size = New System.Drawing.Size(54, 20)
        Me.ServerPort.TabIndex = 6
        Me.ServerPort.Value = New Decimal(New Integer() {6767, 0, 0, 0})
        '
        'StartStopKnopka
        '
        Me.StartStopKnopka.Location = New System.Drawing.Point(178, 122)
        Me.StartStopKnopka.Name = "StartStopKnopka"
        Me.StartStopKnopka.Size = New System.Drawing.Size(104, 23)
        Me.StartStopKnopka.TabIndex = 7
        Me.StartStopKnopka.Text = "Start"
        Me.StartStopKnopka.UseVisualStyleBackColor = True
        '
        'IncomingMessage
        '
        Me.IncomingMessage.FormattingEnabled = True
        Me.IncomingMessage.Location = New System.Drawing.Point(12, 151)
        Me.IncomingMessage.Name = "IncomingMessage"
        Me.IncomingMessage.Size = New System.Drawing.Size(270, 108)
        Me.IncomingMessage.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Server is not running"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 300)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IncomingMessage)
        Me.Controls.Add(Me.StartStopKnopka)
        Me.Controls.Add(Me.ServerPort)
        Me.Controls.Add(Me.LocalIPLabel)
        Me.Controls.Add(Me.FileOtpravka)
        Me.Controls.Add(Me.KnopkaOtpravkiMsg)
        Me.Controls.Add(Me.IshodMessage)
        Me.Controls.Add(Me.PortDest)
        Me.Controls.Add(Me.IPDest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PortDest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IPDest As TextBox
    Friend WithEvents PortDest As NumericUpDown
    Friend WithEvents IshodMessage As TextBox
    Friend WithEvents KnopkaOtpravkiMsg As Button
    Friend WithEvents FileOtpravka As Button
    Friend WithEvents LocalIPLabel As Label
    Friend WithEvents ServerPort As NumericUpDown
    Friend WithEvents StartStopKnopka As Button
    Friend WithEvents IncomingMessage As ListBox
    Friend WithEvents Label2 As Label
End Class
