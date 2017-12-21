Imports System.Text.RegularExpressions

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        tboxTestData.Width = Me.Width - 40
    End Sub

    Sub showMatch(ByVal text As String, ByVal expr As String)
        Dim mc As MatchCollection = Regex.Matches(text, expr)
        Dim m As Match
        For Each m In mc
            tboxResults.Text = tboxResults.Text & vbCrLf & m.ToString()
        Next m
    End Sub

    Private Sub btnTestExpression_Click(sender As Object, e As EventArgs) Handles btnTestExpression.Click

        If tboxTestExpression.Text = "" Then
            MsgBox("Please provide a valid Regular Expression!", MsgBoxStyle.Critical, "Missing Regex")
        ElseIf tboxTestData.Text = "" Then
            MsgBox("Please provide data to apply the provide Regular Expression to!!", MsgBoxStyle.Critical, "Data required")
        Else
            Me.Height = 600
            lblResults.Visible = True
            tboxResults.Visible = True
            tboxResults.Text = "Matches found.."
            btnReset.Visible = True
            btnTestExpression.Enabled = False
            showMatch(tboxTestData.Text, tboxTestExpression.Text)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Height = 360
        lblResults.Visible = False
        tboxResults.Visible = False
        tboxResults.Text = ""
        btnReset.Visible = False
        btnTestExpression.Enabled = True
    End Sub
End Class
