<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPaper = New System.Windows.Forms.Button()
        Me.cmdRock = New System.Windows.Forms.Button()
        Me.cmdScissors = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(87, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jankenpo"
        '
        'cmdPaper
        '
        Me.cmdPaper.Location = New System.Drawing.Point(93, 141)
        Me.cmdPaper.Name = "cmdPaper"
        Me.cmdPaper.Size = New System.Drawing.Size(75, 23)
        Me.cmdPaper.TabIndex = 1
        Me.cmdPaper.Text = "Paper"
        Me.cmdPaper.UseVisualStyleBackColor = True
        '
        'cmdRock
        '
        Me.cmdRock.Location = New System.Drawing.Point(12, 141)
        Me.cmdRock.Name = "cmdRock"
        Me.cmdRock.Size = New System.Drawing.Size(75, 23)
        Me.cmdRock.TabIndex = 2
        Me.cmdRock.Text = "Rock"
        Me.cmdRock.UseVisualStyleBackColor = True
        '
        'cmdScissors
        '
        Me.cmdScissors.Location = New System.Drawing.Point(174, 141)
        Me.cmdScissors.Name = "cmdScissors"
        Me.cmdScissors.Size = New System.Drawing.Size(75, 23)
        Me.cmdScissors.TabIndex = 3
        Me.cmdScissors.Text = "Scissors"
        Me.cmdScissors.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 171)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdScissors)
        Me.Controls.Add(Me.cmdRock)
        Me.Controls.Add(Me.cmdPaper)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPaper As Button
    Friend WithEvents cmdRock As Button
    Friend WithEvents cmdScissors As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
