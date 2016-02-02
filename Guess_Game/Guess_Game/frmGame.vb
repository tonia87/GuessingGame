Public Class frmGame
    'δοκιμάστε τη χρήση του Enter αντί για το button click 
    'στην ιδιότητα φόρμας AcceptButton, με κλικ ανοίγει drop down menu
    'στο οποίο επιλέγετε ποιο κουμπί θέλετε να κλικάρεται αυτόματα
    'όταν ο χρήστης πατάει το Enter

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'επιλογή εικόνας και layout
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources._8
        'αρχικοποίηση κεμένου ετικέτας
        lblMsg.Text = "Guess a number between 0 and 20..."

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'μεταβλητή τύπου integer για αποθήκευση αριθμού που εισάγει ο χρήστης
        Dim userNumber As Integer
        'εκχώρηση από το text του textbox---casting με τη χρήση της Val()
        userNumber = Val(txtNumber.Text)

        'ένδειξη κουμπιού check your input--άρα το παιχνίδι τρέχει
        If btnCheck.Text = "Check Your Input" Then

            If userNumber = number Then
                lblMsg.Text = "Congrats!!!"
                txtNumber.Text = "" 'σβήνω τo κείμενο του textbox
                btnCheck.Text = "New Game" 'αλλαγή ένδειξης--το παιχνίδι τελείωσε
                'χρήση της συνάρτησης για απόλυτη τιμή αριθμού
            ElseIf Math.Abs(userNumber - number) <= 5 Then
                lblMsg.Text = "You are very close..."
            ElseIf Math.Abs(userNumber - number) <= 10 Then
                lblMsg.Text = "You are close..."
            Else
                lblMsg.Text = "Not close at all..."
            End If

        Else 'ένδειξη κουμπιού New Game--ξεκινάει νέο γύρο
            lblMsg.Text = "Guess a number between 0 and 20..."
            btnCheck.Text = "Check Your Input"
            'το πρόγραμμα "σκέφτεται" νέο αριθμό
            number = generator.Next(0, 20)

        End If


    End Sub
End Class
