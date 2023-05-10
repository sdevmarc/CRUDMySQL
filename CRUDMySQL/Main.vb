Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB("con")
        form("atshow")
        tsDT.Text = Now
    End Sub

    Sub form(fr As Object)
        If (fr = "atshow") Then
            fr = New Attendance
            fr.MdiParent = Me
            fr.Show()
        End If
    End Sub

    Private Sub EditModToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditModeON.Click
        txtID.ReadOnly = False
        txtLN.ReadOnly = False
        txtFN.ReadOnly = False
        txtCOURSE.ReadOnly = False
        txtYEAR.ReadOnly = False
        txtADD.ReadOnly = False

        txtID.Cursor = Cursors.IBeam
        txtLN.Cursor = Cursors.IBeam
        txtFN.Cursor = Cursors.IBeam
        txtCOURSE.Cursor = Cursors.IBeam
        txtYEAR.Cursor = Cursors.IBeam
        txtADD.Cursor = Cursors.IBeam
    End Sub

    Private Sub DisbleEdit_Click(sender As Object, e As EventArgs) Handles DisbleEdit.Click
        txtID.ReadOnly = True
        txtLN.ReadOnly = True
        txtFN.ReadOnly = True
        txtCOURSE.ReadOnly = True
        txtYEAR.ReadOnly = True
        txtADD.ReadOnly = True

        txtID.Cursor = Cursors.Arrow
        txtLN.Cursor = Cursors.Arrow
        txtFN.Cursor = Cursors.Arrow
        txtCOURSE.Cursor = Cursors.Arrow
        txtYEAR.Cursor = Cursors.Arrow
        txtADD.Cursor = Cursors.Arrow
    End Sub

    Private Sub AddRec_Click(sender As Object, e As EventArgs) Handles AddRec.Click
        AddFields(txtID.Text, txtLN.Text, txtFN.Text, txtCOURSE.Text, txtYEAR.Text, txtADD.Text)
        form("atshow")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSEARCH.Text = ""
        txtID.Text = ""
        txtLN.Text = ""
        txtFN.Text = ""
        txtCOURSE.Text = ""
        txtYEAR.Text = ""
        txtADD.Text = ""

        form("atshow")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (txtSEARCH.Text = "") Then
            MessageBox.Show("Please fill in the box!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Attendance.dgvAttendance.Rows.Clear()
            SearchData(txtSEARCH.Text, Attendance.dgvAttendance)
            RetrieveTxt(txtSEARCH.Text)
            form("atshow")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtID.Text = "") Then
            MessageBox.Show("Please identify the id number you want to update!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (MessageBox.Show("Are you sure you want to make changes on this data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                UpdateData()
                form("atshow")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (txtID.Text = "") Then
            MessageBox.Show("Please identify the id number you want to delete!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (MessageBox.Show("Are you sure you want to permanently delete this data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                DeleteData()
                form("atshow")
            End If
        End If



    End Sub
End Class