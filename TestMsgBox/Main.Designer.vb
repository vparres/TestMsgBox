<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Exclamation = New System.Windows.Forms.Button()
        Me.Information = New System.Windows.Forms.Button()
        Me.Critical = New System.Windows.Forms.Button()
        Me.Question = New System.Windows.Forms.Button()
        Me.about = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Exclamation
        '
        Me.Exclamation.Location = New System.Drawing.Point(12, 37)
        Me.Exclamation.Name = "Exclamation"
        Me.Exclamation.Size = New System.Drawing.Size(105, 47)
        Me.Exclamation.TabIndex = 0
        Me.Exclamation.Text = "Exclamation"
        Me.Exclamation.UseVisualStyleBackColor = True
        '
        'Information
        '
        Me.Information.Location = New System.Drawing.Point(167, 37)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(105, 47)
        Me.Information.TabIndex = 1
        Me.Information.Text = "Information"
        Me.Information.UseVisualStyleBackColor = True
        '
        'Critical
        '
        Me.Critical.Location = New System.Drawing.Point(12, 124)
        Me.Critical.Name = "Critical"
        Me.Critical.Size = New System.Drawing.Size(105, 47)
        Me.Critical.TabIndex = 2
        Me.Critical.Text = "Critical"
        Me.Critical.UseVisualStyleBackColor = True
        '
        'Question
        '
        Me.Question.Location = New System.Drawing.Point(167, 124)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(105, 47)
        Me.Question.TabIndex = 3
        Me.Question.Text = "Question"
        Me.Question.UseVisualStyleBackColor = True
        '
        'about
        '
        Me.about.Location = New System.Drawing.Point(12, 226)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(75, 23)
        Me.about.TabIndex = 4
        Me.about.Text = "About"
        Me.about.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(196, 226)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 5
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.about)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.Critical)
        Me.Controls.Add(Me.Information)
        Me.Controls.Add(Me.Exclamation)
        Me.Name = "Main"
        Me.Text = "TestMsgBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Exclamation As System.Windows.Forms.Button
    Friend WithEvents Information As System.Windows.Forms.Button
    Friend WithEvents Critical As System.Windows.Forms.Button
    Friend WithEvents Question As System.Windows.Forms.Button
    Friend WithEvents about As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button

End Class
