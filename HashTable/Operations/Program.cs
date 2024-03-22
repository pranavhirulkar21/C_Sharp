using System;
using System.Collections;

namespace Operations
{
    internal class Program
    {
        public static void display(Hashtable hashtable) 
        {
            Console.WriteLine("HashTable Contains : ");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(key + " - " + hashtable[key]);
            }
            Console.WriteLine();
        }
        
        public static void displayKeys(Hashtable hashtable) 
        {
            Console.WriteLine("Keys in HashTable are : ");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();
        }
            
        public static void displayValues(Hashtable hashtable)
        {
            Console.WriteLine("Values in HashTable are : ");
            foreach (var value in hashtable.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(6);

            ht.Add(1, "C#");
            ht.Add(2, "Java");
            ht.Add(3, "Python");
            ht.Add(4, "JavaScript");
            ht.Add(5, "Kotlin");
            ht.Add(6, "C++");

            display(ht);


            //  REMOVING AN ELEMENT
            //ht.Remove(3);
            //display(ht);

            Console.WriteLine("Total elements present in Hashtable are : " + ht.Count);
            Console.WriteLine();
            Console.WriteLine("Checking Whether HashTable is ReadOnly? : " + ht.IsReadOnly);
            Console.WriteLine();
            Console.WriteLine("Checking if Hashtable has a fixed size : " + ht.IsFixedSize);
            Console.WriteLine();

            Hashtable sht = Hashtable.Synchronized(ht); // sht is Synchronized HashTable whereas ht is Not Synchronized HashTable
            Console.WriteLine("ht is {0}", ht.IsSynchronized ? "Synchronized" : "Not Synchronized");
            Console.WriteLine("sht is {0}", sht.IsSynchronized ? "Synchronized" : "Not Synchronized");
            Console.WriteLine();

            // GET COLLECTION OF VALUES ONLY
            ICollection value = ht.Values;
            Console.WriteLine("Values in HashTable are : ");
            foreach (string str in value)
            {
                Console.WriteLine(str + ht[str]);
            }
            Console.WriteLine();
            //.....FOLLOWING ARE THE METHODS FOR THE SAME PURPOSE

            displayKeys(ht);
            displayValues(ht);

            //  ADDING VALUE TO A SPECIFIC KEY
            ht[7] = "Ruby";
            display(ht);
            Console.WriteLine();

            // Hashtable.GetEnumerator Method is used to returns an IDictionaryEnumerator that iterates through the Hashtable.
            IDictionaryEnumerator enumerator = ht.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Key+" --> "+enumerator.Value);
            }
            Console.WriteLine();


            Console.WriteLine("Checking Whether Key present or not : " + ht.Contains(3));
            Console.WriteLine();

            //CHECKING IF SPECIFIC VALUE PRESENT OR NOT
            if (ht.ContainsValue("C++"))
            {
                Console.WriteLine("Given value is present");
            }
            else
            {
                Console.WriteLine("Given value is not present");
            }
            Console.WriteLine();

            // REMOVING ALL ELEMENTS FROM HASHTABLE
            //ht.Clear();
            //display(ht);

            //REMOVAL OF ELEMENT WITH SPECIFIC KEY FROM HASHTABLE
            //ht.Remove(3);
            //display(ht);

            DictionaryEntry[] Arr = new DictionaryEntry[ht.Count];
            ht.CopyTo(Arr, 0);
            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(Arr[i].Key+" -> " + Arr[i].Value);
            }
            Console.WriteLine();

            // TO CHECK WHETHER TWO HASHTABLES ARE EQUAL OR NOT
            Console.WriteLine(ht.Equals(ht));
            Console.WriteLine();

            Hashtable shallow_ht = new Hashtable();
            shallow_ht = (Hashtable)ht.Clone();
            Console.WriteLine("This is shallow copied Hashtable  ");
            display(shallow_ht);
        }
    }
}


