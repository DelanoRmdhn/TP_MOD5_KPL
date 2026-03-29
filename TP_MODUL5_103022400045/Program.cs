using System;

class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("103022400045");
        data.PrintData();

        Console.ReadLine();
    }
}
