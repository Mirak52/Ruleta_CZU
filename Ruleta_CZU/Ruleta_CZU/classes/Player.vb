Public Class Player

    Private _money As Integer = 100
    Private _moneyLeft As Integer = 0
    Private _win As Integer = 0
    Private _lose As Integer = 0
    Private _success As Integer = 0
    Public Property money As Integer
        Get
            Return _money
        End Get
        Set(value As Integer)
            _money = value
        End Set
    End Property
    Public Property moneyLeft As Integer
        Get
            Return _moneyLeft
        End Get
        Set(value As Integer)
            _moneyLeft = value
        End Set
    End Property
    Public Property win As Integer
        Get
            Return _win
        End Get
        Set(value As Integer)
            _win = value
        End Set
    End Property
    Public Property lose As Integer
        Get
            Return _lose
        End Get
        Set(value As Integer)
            _lose = value
        End Set
    End Property
    Public Property success As Integer
        Get
            Return _success
        End Get
        Set(value As Integer)
            _success = value
        End Set
    End Property
End Class
