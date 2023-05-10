Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData(dgvAttendance)
        SearchData(Main.txtSEARCH.Text, dgvAttendance)
    End Sub
End Class