Public Class Form1
    Dim Minggu As String
    Dim persen As Integer

    '  My.Settings.MKe = "15-41-67-93-108-115-115-130-145-145-145-145-145-145-150-150-150-150-150-150-170"

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.MKe =
           TextBox1.Text + "-" +
           TextBox2.Text + "-" +
           TextBox3.Text + "-" +
           TextBox4.Text + "-" +
           TextBox5.Text + "-" +
           TextBox6.Text + "-" +
           TextBox7.Text + "-" +
           TextBox8.Text + "-" +
           TextBox9.Text + "-" +
           TextBox10.Text + "-" +
           TextBox11.Text + "-" +
           TextBox12.Text + "-" +
           TextBox13.Text + "-" +
           TextBox14.Text + "-" +
           TextBox15.Text + "-" +
           TextBox16.Text + "-" +
           TextBox17.Text + "-" +
           TextBox18.Text + "-" +
           TextBox19.Text + "-" +
           TextBox20.Text + "-" +
           TextBox21.Text
        My.Settings.PJag = Val(TextBox22.Text)
        My.Settings.pDed = Val(TextBox23.Text)
        My.Settings.pKons = Val(TextBox24.Text)
        'harga pakan
        My.Settings.hDOD = Val(TextBox26.Text)
        My.Settings.hJag = Val(TextBox27.Text)
        My.Settings.hDed = Val(TextBox28.Text)
        My.Settings.hKon = Val(TextBox29.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Minggu = My.Settings.MKe
        TextBox1.Text = Minggu.Split("-")(0)
        TextBox2.Text = Minggu.Split("-")(1)
        TextBox3.Text = Minggu.Split("-")(2)
        TextBox4.Text = Minggu.Split("-")(3)
        TextBox5.Text = Minggu.Split("-")(4)
        TextBox6.Text = Minggu.Split("-")(5)
        TextBox7.Text = Minggu.Split("-")(6)
        TextBox8.Text = Minggu.Split("-")(7)
        TextBox9.Text = Minggu.Split("-")(8)
        TextBox10.Text = Minggu.Split("-")(9)
        TextBox11.Text = Minggu.Split("-")(10)
        TextBox12.Text = Minggu.Split("-")(11)
        TextBox13.Text = Minggu.Split("-")(12)
        TextBox14.Text = Minggu.Split("-")(13)
        TextBox15.Text = Minggu.Split("-")(14)
        TextBox16.Text = Minggu.Split("-")(15)
        TextBox17.Text = Minggu.Split("-")(16)
        TextBox18.Text = Minggu.Split("-")(17)
        TextBox19.Text = Minggu.Split("-")(18)
        TextBox20.Text = Minggu.Split("-")(19)
        TextBox21.Text = Minggu.Split("-")(20)
        TextBox22.Text = My.Settings.PJag
        TextBox23.Text = My.Settings.pDed
        TextBox24.Text = My.Settings.pKons
        TextBox26.Text = My.Settings.hDOD
        TextBox27.Text = My.Settings.hJag
        TextBox28.Text = My.Settings.hDed
        TextBox29.Text = My.Settings.hKon

    End Sub

   
    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.TextChanged

        persen = Val(TextBox22.Text)
        If persen > 100 Then
            MsgBox("Nilai ini harus <= 100 ")
            TextBox22.Text = 100
        Else
            TextBox23.Text = CInt((100 - persen) / 2)
            TextBox24.Text = 100 - (Val(TextBox22.Text) + Val(TextBox23.Text))
           
        End If
    End Sub
    Private Sub proses()
        'Awal Usaha
        Dim awal As Date = DateTimePicker1.Value.Date
        Dim akhir As Date = DateTimePicker2.Value.Date
        Dim umur As String = Val(TextBox30.Text)
        Dim hari As Integer = 1
        Dim pakan1ekor As Integer
        Dim jmlItik = Val(TextBox25.Text)

        Label75.Text = ""
        Label76.Text = ""
        Label77.Text = ""
        Label78.Text = ""
        Label68.Text = ""

        Label74.Text = ""
        Label79.Text = ""
        Label80.Text = ""
        Label81.Text = ""
 
        Label49.Text = Format(awal.Date, "dddd ") & Format(awal.Date, "dd/MMMM/yyyy")
        Label50.Text = Format(akhir.Date, "dddd ") & Format(akhir.Date, "dd/MMMM/yyyy")
        Label55.Text = TextBox25.Text
        Label57.Text = TextBox30.Text
        Dim sDOD As Integer = 0
        Dim sDedak As Integer = 0
        Dim sJagung As Integer = 0
        Dim sKonsentrat As Integer = 0
        Dim mDOD As Integer = 0
        Dim mDedak As Integer = 0
        Dim mJagung As Integer = 0
        Dim mKonsentrat As Integer = 0
        Dim mTotalHarga As Decimal = 0
        Dim subTBer As Decimal = 0
        Dim berat As Decimal = 0

        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        While awal <= akhir
            'variabel pakan\
            Dim pDOD As Integer = 0
            Dim pDedak As Integer = 0
            Dim pJagung As Integer = 0
            Dim pKonsentrat As Integer = 0

            
            '================================
            'variabel harga
            Dim hDOD As Integer = 0
            Dim hDedak As Integer = 0
            Dim hJagung As Integer = 0
            Dim hKonsentrat As Integer = 0
            Dim subTotalHarga As Decimal = 0

            If umur <= 7 Then
                pakan1ekor = Val(TextBox1.Text)
            ElseIf umur <= 14 Then
                pakan1ekor = Val(TextBox2.Text)
            ElseIf umur <= 21 Then
                pakan1ekor = Val(TextBox3.Text)
            ElseIf umur <= 28 Then
                pakan1ekor = Val(TextBox4.Text)
            ElseIf umur <= 35 Then
                pakan1ekor = Val(TextBox5.Text)
            ElseIf umur <= 42 Then
                pakan1ekor = Val(TextBox6.Text)
            ElseIf umur <= 49 Then
                pakan1ekor = Val(TextBox7.Text)
            ElseIf umur <= 56 Then
                pakan1ekor = Val(TextBox8.Text)
            ElseIf umur <= 63 Then
                pakan1ekor = Val(TextBox9.Text)
            ElseIf umur <= 70 Then
                pakan1ekor = Val(TextBox10.Text)
            ElseIf umur <= 77 Then
                pakan1ekor = Val(TextBox11.Text)
            ElseIf umur <= 84 Then
                pakan1ekor = Val(TextBox12.Text)
            ElseIf umur <= 91 Then
                pakan1ekor = Val(TextBox13.Text)
            ElseIf umur <= 98 Then
                pakan1ekor = Val(TextBox14.Text)
            ElseIf umur <= 105 Then
                pakan1ekor = Val(TextBox15.Text)
            ElseIf umur <= 112 Then
                pakan1ekor = Val(TextBox16.Text)
            ElseIf umur <= 119 Then
                pakan1ekor = Val(TextBox17.Text)
            ElseIf umur <= 126 Then
                pakan1ekor = Val(TextBox18.Text)
            ElseIf umur <= 133 Then
                pakan1ekor = Val(TextBox19.Text)
            ElseIf umur <= 140 Then
                pakan1ekor = Val(TextBox20.Text)
            ElseIf umur <= 147 Then
                pakan1ekor = Val(TextBox21.Text)
            End If

            If umur <= 14 Then
                pDOD = jmlItik * pakan1ekor
                hDOD = (pDOD / 1000) * Val(TextBox26.Text)
                sDOD += pDOD
                mDOD += hDOD
                subTotalHarga = hDOD
                berat = pDOD
            Else
                pDedak = ((jmlItik * pakan1ekor) / 100) * Val(TextBox23.Text)
                pJagung = ((jmlItik * pakan1ekor) / 100) * Val(TextBox22.Text)
                pKonsentrat = ((jmlItik * pakan1ekor) / 100) * Val(TextBox24.Text)
                hDedak = (pDedak / 1000) * Val(TextBox28.Text)
                hJagung = (pJagung / 1000) * Val(TextBox27.Text)
                hKonsentrat = (pKonsentrat / 1000) * Val(TextBox29.Text)
                mDedak += hDedak
                mJagung += hJagung
                mKonsentrat += hKonsentrat

                'sDOD = 0
                sDedak += pDedak
                sJagung += pJagung
                sKonsentrat += pKonsentrat
                subTotalHarga = hDedak + hJagung + hKonsentrat
                berat = pDedak + pJagung + pKonsentrat
            End If
            'subTotalHarga = hDOD + hDedak + hJagung + hKonsentrat
            mTotalHarga += subTotalHarga
            subTBer += berat
            'Format(bufT1, "HH:mm:ss")
            DataGridView1.Rows.Add(umur, Format(awal.Date, "dddd ") & Format(awal.Date, "dd/MMMM/yyyy"), pDOD, pDedak, pJagung, pKonsentrat, hDOD, hDedak, hJagung, hKonsentrat, subTotalHarga)
            DataGridView2.Rows.Add(umur, subtBer, Format(awal.Date, "dddd ") & Format(awal.Date, "dd/MMMM/yyyy"), sDOD, sDedak, sJagung, sKonsentrat, mDOD, mDedak, mJagung, mKonsentrat, mTotalHarga)
            Label75.Text = mDOD
            Label76.Text = mJagung
            Label77.Text = mDedak
            Label78.Text = mKonsentrat
            Label68.Text = mTotalHarga

            Label74.Text = sDOD & " gram = " & sDOD / 1000 & " kg"
            Label79.Text = sJagung & " gram = " & sJagung / 1000 & " kg"
            Label80.Text = sDedak & " gram = " & sDedak / 1000 & " kg"
            Label81.Text = sKonsentrat & " gram = " & sKonsentrat / 1000 & " kg"
            Label82.Text = sDOD + sJagung + sDedak + sKonsentrat & " gram = " & (sDOD + sJagung + sDedak + sKonsentrat) / 1000 & " kg"
            Label85.Text = hari & " Hari"


            umur += 1
            hari += 1
            awal = DateAdd(DateInterval.Day, 1, awal)
        End While
    End Sub

    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.TextChanged
        persen = Val(TextBox23.Text)
        If (persen + Val(TextBox22.Text)) > 100 Then
            MsgBox("Nilai ini harus <= " & 100 - Val(TextBox22.Text))
            TextBox23.Text = 100 - Val(TextBox22.Text)
            TextBox24.Text = 100 - (Val(TextBox22.Text) + Val(TextBox23.Text))
        Else
            TextBox24.Text = 100 - (Val(TextBox22.Text) + Val(TextBox23.Text))

        End If
    End Sub



    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        proses()
    End Sub


    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
