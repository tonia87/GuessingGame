Module ModuleNewNumber
    'δηλώνω public μεταβλητή τύπου συνάρτησης random()
    Public generator As New Random()
    'δηλώνω friend μεταβλητή τύπου ακεραίου, που θα παίρνει τυχαία τιμή
    Friend number As Integer = generator.Next(0, 20)
End Module
