// This is a simple C# program demonstrating function usage.
Console.WriteLine("Function practice is ready.");

// ComparisonExamples.RunDemo();
// ComparisonExamples.Show(10);

// ComparisonExamples.DemoSwitch("green");

// Loops
// ComparisonExamples.DemopForLoop();

// Array
// NewCollections.DemoArray();

//Array List
// NewCollections.ArryList();

// HashTable vs Dictonary
// NewCollections.HashTable();
// NewCollections.DicTable();

// NewCollections.Stack();
// NewCollections.Queue();

// DataTypes and Variables
// Company googleObj = new Company();
// googleObj.DisplayCompanyDetails();

// Company youtubeObj = new Company();
// youtubeObj.id = 2;
// youtubeObj.name = "Youtube";
// youtubeObj.DisplayCompanyDetails();

// CompanySetter googleObj = new CompanySetter();
// googleObj.SetName("Oyo");
// Console.WriteLine($"Name: {googleObj.name}");

// CompanySetter googleObj2 = new CompanySetter();
// Console.WriteLine($"Name: {googleObj2.name}");

// Create a new CompanySetter2 object. Its private Name property starts as "RK".
// CompanySetter2 googleObj3 = new CompanySetter2();

// // GetName() is public, so it lets us read the private Name property safely.
// Console.WriteLine(googleObj3.GetName()); // RK

// // SetName() is public, so it lets us update the private Name property.
// googleObj3.SetName("Oyo");

// // Read the updated name. This now prints "Oyo".
// Console.WriteLine(googleObj3.GetName()); // Oyo

// MyConstructorClass data = new MyConstructorClass(1, "kk");
// data.DisplayData();

// MyConstructorClass data2 = new MyConstructorClass(3);
// data2.DisplayData();

EmpInheritance employee = new EmpInheritance(1, "Microsoft", 101, "Ranjith");

Console.WriteLine($"Company ID: {employee.CompanyId}");
Console.WriteLine($"Company Name: {employee.CompanyName}");
Console.WriteLine($"Employee ID: {employee.EmpId}");
Console.WriteLine($"Employee Name: {employee.EmpName}");