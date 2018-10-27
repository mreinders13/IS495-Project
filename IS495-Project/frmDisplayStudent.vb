Public Class frmDisplayStudent
    Dim Status, Accepted, Denied, Bridged As String
    Dim DecisionAccept, DecisionDeny, DecisionBridge As Boolean

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click

    End Sub

    Private Sub frmDisplayStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        'Save Accept decision
        Status = Accepted
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionAccept = True
        'DecisionDeny = False
        'DecisionBridge = False

    End Sub

    Private Sub btnBridge_Click(sender As Object, e As EventArgs) Handles btnBridge.Click
        'Save Bridge Decision
        Status = Bridged
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionBridge = True
        'DecisionAccept = False
        'DecisionDeny = False

    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        'Save Deny Decision 
        Status = Denied
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionBridge = False
        'DecisionAccept = False
        'DecisionDeny = True


    End Sub
End Class
