// This is a simple C# program demonstrating function usage.
Console.WriteLine("Function practice is ready.");

// // ComparisonExamples.RunDemo();
// // ComparisonExamples.Show(10);

// // ComparisonExamples.DemoSwitch("green");

// // // Loops
// // ComparisonExamples.DemopForLoop();

// // Array
// // NewCollections.DemoArray();

// //Array List
// // NewCollections.ArryList();

// // HashTable vs Dictonary
// // NewCollections.HashTable();
// // NewCollections.DicTable();

// // NewCollections.Stack();
// // NewCollections.Queue();

// // DataTypes and Variables
// // Company googleObj = new Company();
// // googleObj.DisplayCompanyDetails();

// // Company youtubeObj = new Company();
// // youtubeObj.id = 2;
// // youtubeObj.name = "Youtube";
// // youtubeObj.DisplayCompanyDetails();

// // CompanySetter googleObj = new CompanySetter();
// // googleObj.SetName("Oyo");
// // Console.WriteLine($"Name: {googleObj.name}");

// // CompanySetter googleObj2 = new CompanySetter();
// // Console.WriteLine($"Name: {googleObj2.name}");

// // Create a new CompanySetter2 object. Its private Name property starts as "RK".
// // CompanySetter2 googleObj3 = new CompanySetter2();

// // // GetName() is public, so it lets us read the private Name property safely.
// // Console.WriteLine(googleObj3.GetName()); // RK

// // // SetName() is public, so it lets us update the private Name property.
// // googleObj3.SetName("Oyo");

// // // Read the updated name. This now prints "Oyo".
// // Console.WriteLine(googleObj3.GetName()); // Oyo

// // MyConstructorClass data = new MyConstructorClass(1, "kk");
// // data.DisplayData();

// // MyConstructorClass data2 = new MyConstructorClass(3);
// // data2.DisplayData();

// // Run examples of single, multiple (through interfaces), multilevel, and hierarchical inheritance.
// // InheritanceTypesDemo.RunAll();

// using System;
// using System.Collections;
// using System.Collections.Generic;

// public class Mobile
// {
//     public string Brand { get; set; }
//     public string Model { get; set; }
//     public decimal Price { get; set; }
//     public bool Is5G { get; set; }

//     public Mobile(string brand, string model, decimal price, bool is5G)
//     {
//         Brand = brand;
//         Model = model;
//         Price = price;
//         Is5G = is5G;
//     }

//     public override string ToString()
//     {
//         return $"{Brand} {Model} | ₹{Price:N0} | 5G: {Is5G}";
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         // Dictionary: serial number must be string and value must be Mobile.
//         Dictionary<string, Mobile> mobileInventory = new()
//         {
//             ["IMEI-1001"] = new Mobile("Apple", "iPhone 16", 79900, true),
//             ["IMEI-1002"] = new Mobile("Samsung", "Galaxy S25", 74999, true),
//             ["IMEI-1003"] = new Mobile("Google", "Pixel 9", 64999, true)
//         };

//         string serialNumber = "IMEI-1002";

//         if (mobileInventory.TryGetValue(serialNumber, out Mobile? mobile))
//         {
//             Console.WriteLine($"Found: {mobile}");
//         }

//         // Find phones within a budget.
//         Console.WriteLine("\nMobiles below ₹75,000:");

//         foreach (KeyValuePair<string, Mobile> item in mobileInventory)
//         {
//             if (item.Value.Price < 75000)
//             {
//                 Console.WriteLine($"{item.Key}: {item.Value}");
//             }
//         }

//         // Hashtable accepts any type—this is risky.
//         Hashtable oldInventory = new();
//         oldInventory["IMEI-2001"] = new Mobile("OnePlus", "13", 69999, true);

//         // Hashtable permits accidental invalid data:
//         oldInventory["IMEI-2002"] = "Phone data unavailable";

//         // We need casting, which can fail at runtime.
//         try
//         {
//             Mobile oldMobile = (Mobile)oldInventory["IMEI-2002"]!;
//             Console.WriteLine(oldMobile);
//         }
//         catch (InvalidCastException)
//         {
//             Console.WriteLine("\nHashtable error: value was not a Mobile object.");
//         }
//     }
// }