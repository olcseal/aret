<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.tboxTestExpression = New System.Windows.Forms.TextBox()
        Me.lblTestExpression = New System.Windows.Forms.Label()
        Me.tboxTestData = New System.Windows.Forms.TextBox()
        Me.lblTestData = New System.Windows.Forms.Label()
        Me.tboxResults = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnTestExpression = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tboxTestExpression
        '
        Me.tboxTestExpression.Location = New System.Drawing.Point(12, 39)
        Me.tboxTestExpression.Name = "tboxTestExpression"
        Me.tboxTestExpression.Size = New System.Drawing.Size(382, 20)
        Me.tboxTestExpression.TabIndex = 0
        '
        'lblTestExpression
        '
        Me.lblTestExpression.AutoSize = True
        Me.lblTestExpression.Location = New System.Drawing.Point(12, 23)
        Me.lblTestExpression.Name = "lblTestExpression"
        Me.lblTestExpression.Size = New System.Drawing.Size(139, 13)
        Me.lblTestExpression.TabIndex = 1
        Me.lblTestExpression.Text = "Regular Expression to test..."
        '
        'tboxTestData
        '
        Me.tboxTestData.AcceptsReturn = True
        Me.tboxTestData.Location = New System.Drawing.Point(12, 108)
        Me.tboxTestData.Multiline = True
        Me.tboxTestData.Name = "tboxTestData"
        Me.tboxTestData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tboxTestData.Size = New System.Drawing.Size(460, 200)
        Me.tboxTestData.TabIndex = 2
        Me.tboxTestData.WordWrap = False
        '
        'lblTestData
        '
        Me.lblTestData.AutoSize = True
        Me.lblTestData.Location = New System.Drawing.Point(12, 92)
        Me.lblTestData.Name = "lblTestData"
        Me.lblTestData.Size = New System.Drawing.Size(207, 13)
        Me.lblTestData.TabIndex = 3
        Me.lblTestData.Text = "Enter text to apply Regular Expression to..."
        '
        'tboxResults
        '
        Me.tboxResults.AcceptsReturn = True
        Me.tboxResults.Location = New System.Drawing.Point(12, 352)
        Me.tboxResults.Multiline = True
        Me.tboxResults.Name = "tboxResults"
        Me.tboxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tboxResults.Size = New System.Drawing.Size(460, 200)
        Me.tboxResults.TabIndex = 4
        Me.tboxResults.Visible = False
        Me.tboxResults.WordWrap = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(12, 336)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(140, 13)
        Me.lblResults.TabIndex = 5
        Me.lblResults.Text = "Regular Expression Match..."
        Me.lblResults.Visible = False
        '
        'btnTestExpression
        '
        Me.btnTestExpression.Location = New System.Drawing.Point(405, 38)
        Me.btnTestExpression.Name = "btnTestExpression"
        Me.btnTestExpression.Size = New System.Drawing.Size(60, 22)
        Me.btnTestExpression.TabIndex = 6
        Me.btnTestExpression.Text = "Test"
        Me.btnTestExpression.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(405, 324)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(60, 22)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 321)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTestExpression)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.tboxResults)
        Me.Controls.Add(Me.lblTestData)
        Me.Controls.Add(Me.tboxTestData)
        Me.Controls.Add(Me.lblTestExpression)
        Me.Controls.Add(Me.tboxTestExpression)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATAC Regular Expression Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tboxTestExpression As TextBox
    Friend WithEvents lblTestExpression As Label
    Friend WithEvents tboxTestData As TextBox
    Friend WithEvents lblTestData As Label
    Friend WithEvents tboxResults As TextBox
    Friend WithEvents lblResults As Label
    Friend WithEvents btnTestExpression As Button
    Friend WithEvents btnReset As Button
End Class
