Imports System.Threading

Module Module1

    Sub Main()

        Dim fruits As New List(Of String)
        fruits.Add("Apple")
        fruits.Add("Banana")
        fruits.Add("Bilberry")
        fruits.Add("Blackberry")
        fruits.Add("Blackcurrant")
        fruits.Add("Blueberry")
        fruits.Add("Cherry")
        fruits.Add("Coconut")
        fruits.Add("Cranberry")
        fruits.Add("Date")
        fruits.Add("Fig")
        fruits.Add("Grape")
        fruits.Add("Guava")
        fruits.Add("Jack-fruit")
        fruits.Add("Kiwi fruit")
        fruits.Add("Lemon")
        fruits.Add("Lime")
        fruits.Add("Lychee")
        fruits.Add("Mango")
        fruits.Add("Melon")
        fruits.Add("Olive")
        fruits.Add("Orange")
        fruits.Add("Papaya")
        fruits.Add("Plum")
        fruits.Add("Pineapple")
        fruits.Add("Pomegranate")

        regular_foreach(fruits)

        parallel_foreach(fruits)

        Console.Read()

    End Sub

    Private Sub regular_foreach(f1 As List(Of String))

        Console.WriteLine("Printing list using foreach loop" & vbCrLf)

        Dim swClock1 = Stopwatch.StartNew()
        For Each fruit In f1
            Console.WriteLine("Fruit Name: {0}, Thread Id = {1}", fruit, Thread.CurrentThread.ManagedThreadId)
        Next

        Console.WriteLine("foreach loop execution time = {0} seconds" & vbCrLf, swClock1.Elapsed.TotalSeconds)

    End Sub

    Private Sub parallel_foreach(f2 As List(Of String))

        Console.WriteLine("Printing list using Parallel.ForEach" & vbCrLf)

        Dim swClock2 = Stopwatch.StartNew()

        Parallel.ForEach(f2, Sub(fruit2)

                                 Console.WriteLine("Fruit Name: {0}, Thread Id = {1}", fruit2, Thread.CurrentThread.ManagedThreadId)

                             End Sub)

        Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", swClock2.Elapsed.TotalSeconds)

    End Sub

End Module
