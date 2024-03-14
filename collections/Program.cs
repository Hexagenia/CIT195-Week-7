using System;
using System.Collections.Generic;

class Collections
{
    static void Main(string[] args)
    {
        // My Top 5 Favorite NASCAR Cup Series Drivers (for the 2024 season)
        Queue<string> nascarDrivers = new Queue<string>();
        nascarDrivers.Enqueue("Kyle Busch");
        nascarDrivers.Enqueue("Denny Hamlin");
        nascarDrivers.Enqueue("Chase Elliott");
        nascarDrivers.Enqueue("Christopher Bell");
        nascarDrivers.Enqueue("Martin Truex Jr.");

        Console.WriteLine("Here are my top 5 favorite NASCAR Cup Series drivers in the 2024 season");

        Console.WriteLine("NASCAR Cup Series Drivers:");
        foreach (var driver in nascarDrivers)
        {
            Console.WriteLine(driver);
        }
        Console.WriteLine();

        // Most used guns in CS:GO (not CS2)
        PriorityQueue<string> csgoGuns = new PriorityQueue<string>();
        csgoGuns.Enqueue("AK-47");
        csgoGuns.Enqueue("M4A4");
        csgoGuns.Enqueue("AWP");
        csgoGuns.Enqueue("Desert Eagle");
        csgoGuns.Enqueue("P250");

        Console.WriteLine("Most used gun in CS:GO: " + csgoGuns.Dequeue());
        Console.WriteLine("The AK is #1 because of its ability to get a kill with only one shot to the head, regardless of if a helmet is purchased. The Deagle is in the same boat, and the AWP can get a kill in one shot to any part of the player model, regardless of a helmet and armor.");
        Console.WriteLine("Here's the rest in order:");
        while (csgoGuns.Count > 0)
        {
            Console.WriteLine(csgoGuns.Dequeue());
        }
        Console.WriteLine();

        // Fastest production cars of the 2000s
        Stack<string> fastestCars2000 = new Stack<string>();
  
        fastestCars2000.Push("2004 Koenigsegg CCR - 241 mph");
        fastestCars2000.Push("2005 Saleen S7 Twin Turbo - 248 mph");
        fastestCars2000.Push("2006 Koenigsegg CCX - 249 mph");
        fastestCars2000.Push("2005 Bugatti Veyron - 253 mph");
        fastestCars2000.Push("2005 SSC Ultimate Aero - 256 mph");

        Console.WriteLine("Here's the fastest production cars of the 2000s:");
        Console.WriteLine("Congrats to the US and Sweden for making the list with two separate entries!");
        foreach (var car in fastestCars2000)
        {
            Console.WriteLine(car);
        }
    }
}

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> data;

    public PriorityQueue()
    {
        this.data = new List<T>();
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        int ci = data.Count - 1; 
        while (ci > 0)
        {
            int pi = (ci - 1) / 2; // parent index
            if (data[ci].CompareTo(data[pi]) >= 0) break;
            T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
            ci = pi;
        }
    }

    public T Dequeue()
    {
        
        int li = data.Count - 1; 
        T frontItem = data[0];   
        data[0] = data[li];
        data.RemoveAt(li);



        --li; 
        int pi = 0; 

        while (true)
        {
            int ci = pi * 2 + 1; 
            if (ci > li) break;  
            int rc = ci + 1;     
            if (rc <= li && data[rc].CompareTo(data[ci]) < 0) 
                ci = rc;
            if (data[pi].CompareTo(data[ci]) <= 0) break; 
            T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
            pi = ci;
        }
        return frontItem;
        //return;
    }

    public int Count
    {
        get { return data.Count; }
        //get { return data.Count+1;
    
    }
}