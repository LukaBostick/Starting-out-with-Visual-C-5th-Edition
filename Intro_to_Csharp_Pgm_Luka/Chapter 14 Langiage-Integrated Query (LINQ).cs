/*/////////////////////////////////////////////////////////////////////
*
* /////////////////////////////////////////////////////////////////////
* Chapter 14: Language-Integrated Query (LINQ)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Topics
* 
* 14.1 Introduction to LINQ
* 
* 14.2 LINQ Method Syntax
* 
* 14.3 More LINQ Extension Methods
* 
* 14.4 Using LINQ to Query a Database
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 14.1 Introiduction to LINQ
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: LINQ (Language-Integrated Query) is a query language that is 
* built into C# and can be used to query data from many sources.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In Chapter 12 you learned about SQ (Structured Query Language), which
* allows you to query the data in a database. The .Net Framework also 
* provides several LINQ tools that allows you to query many types of
* data. In this section, we will use a tool called LINQ to Objects,
* which allow you to query data that are stored in collections, such as
* arrays and lists.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A statement that uses a LINQ query is written in the following general
* format:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var resultVaruable = LINQquery;
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In the general format, resultVariable is a variable that we are 
* declaring to hold the results of the LINQ query, and LINQquery is the
* LINQ query. Notice that instead of specifying a data type for 
* resultVariable, we are using the var key word in the declaration. The
* C# compiler will automatically determine that data for the variable
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Let's look at an example. Suppose we have declared the following 
* array of integers:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {4,104,2,102,1,101,3,103};
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* If we want to query this array to get all the values that are greater
* than 100, we can write the following statement:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var results = form item in numbers
*               where item > 100
*               select item;
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This statement declares a variable named results, which will hold the 
* results of the LINQ quert. On the right side of the = operator is the
* LINQ query. The = operator will assign the results of the LINQ query 
* to the results variable. The LINQ query reads:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* from item in numbers
* where item > 100
* select item
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This query will return all the items in the numbers array that are
* greater than 100. To understand how the query works, let's look at 
* each line of code in the query. The first line reads:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* from item in numbers
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This expression works like a foreach look that starts like this:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* foreach(item in numbers)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In the code, item is the name of an iteration variable, and numbers
* is the name of an array. The query iterates once for each element of 
* the numbers array. Each time it iterates, it copies an array element 
* to the item variable. The first time the query iterates, the item 
* variable will contain the value of element 0, the second time the 
* quert iterates , the item variable will contain the vale of element
* 1 and so forth.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The second and third lines of the query reads as follow:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* where item > 100
* select item
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This code is similar to an SQL Select statement, except than in LINQ
* the shere clauses appears before the select clause. The where clause
* specifies a Boolean search criterion (in this case, item > 100), and 
* select clause causes the value of the item variable to be retrieved 
* if the search criterion is true. In plain English, the expression says
* "select each item that is greater than 100."
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* After the statement execites, we can use a loop to examine the values
* in the results variable. For ex, the following code segment shows how
* we can add the values to a list box named resultsListBox. After the 
* code executes, the list box will contain the value 104,102,101,and103.
* 
* /////////////////////////////////////////////////////////////////////
* int [] numbers = {4,104,2,102,1,101,3,103};
* var results = for item in numbers
*               where item > 100
*               select item;
* foreach (var value in results)
* {
*   resultsListBox.Item.Add(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* you can also use LINQ to query the data in a List, as shown in the 
* following code snippet:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* List<int> numbers = new List<int>(){4,104,2,102,1,101,3,103};
* 
* var results (var value in resutls)
* {
*   resultsListBox.Items.Add(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The IEnumberable<T> Interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You use LINQ queries to search for, and retrieve, specific pieces of
* data from a source of data. The source can be an in-memoy collection,
* such as an array or a List, or it can be larager repository of data
* such as a database. When you excute a LINQ query, the query retuens
* its results as an IEnumerable<T> collection, where T is the data type
* of the individual elements in the source of data, such as a database.
* When you excecute a LINQ query, the query returns its results as an 
* IEnumerable<T> collection, where T is the data type of te individual
* elements in the source of data.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* For example, if the query's data is an array of int s, the query will
* return an IEnumerable<int> collection. Or, if the query's data source
* is a List of string s, the query will return an IEnumerable<string>
* collection. This is illustrated in Figure 14-1.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-1 LINQ queries returned their results as an IEnumerable<T>
* colection
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* IEnumerable<T> is an interfave that is defined in the .NET Framework.
* An IEnumerable<T> collection is simply a collection, like a List, 
* that you can interate over. So, querying data with LINQ is usually a 
* process of executing a query on a data source, getting the results as
* a collection, and then iterating over the collection to perfrom some
* operation with its elements.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* At this point, you would have perhaps realized that in the two previous
* LINQ examples, you did not see the world IEnumerable in any of the code
* . Here is the previously shown code that queries an int array:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {4,104,2,102,1,101,3,103};
* var results = from item in numbers
*               where item > 100
*               select item;
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* In this statement, the results variable is an IEnumerable<int> 
* collection, nut instead of declaring it as IEnumerable<int>, we used
* the var keyword. Recall that the var keyword causes the compiler to 
* determine a variable's data type from tts initialization value. So, in
* this example the data type of the results variable will be the data 
* type of the value that is returned from the LINQ expression, which is 
* IEnumerable<int>. It is the same as if we had written: 
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* IEnumerable<int> results = from item in numbers
*                            when item > 100
*                            select item;
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* As you can see, the var keyword simplifies the code. For that reason,
* most  programmers perfer to use it.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*                   More about the select Operator
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* LINQ quries begain with a from clause, and they usually end with a 
* select clause. The from clause iterates over a collectionm of data
* elements, assigning each element to an iteration variable. The select
* clause determines what will be included in the results of the qurey, 
* and it returns the results as an IEnumerable<T> collection. The select
* clause also determines what data type T will be. For example, look at 
* the following code snippet:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {4,104,2,102,1,101,3,103};
* 
* var results = from item in numbers select item;
* 
* foreach (var value in results)
* {
*   MessageBox.Show(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The LINQ query that appears in line 3 and 4 is very simply. Since there
* is no where clause to filter the data, it retieves enery item in the
* number array. The data types of the carious variables used in the 
* statment will be as follow:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *The query is searching an int array, so in line 3 that data type of 
* the item variable will be int.
* 
* *In line 4, the select statement is selecting an int (the item variable),
* so the query will return an IEnumerable<int> collection. This also means that
* in line 3 the data type of the results variable will be IEnumerable<int>
* 
* *In line 6, the data type of the value variable array:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Here is an example that works with a string array:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* string[] names = {"Joe", "Jill", "John", "Jennifer"};
* 
* var results = from item in names
*               where String.Compare(item, "Joe") < 0
*               select item;
*               
* foreach (var value in results)
* {
*   MessageBox.Show(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this examplem the LINQ query returns all strings in the names array
* that are less than "Joe". The query will return an IEnumerable<string>
* collection. So, the data type in the statement will be as follow:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * The query is searching s string array, so in line 3 the data type
* of the item variable will be string.
* 
* *In line 5, the select statement is selecting a string (the item variable),
* so the query will return an IEnumerable<string> collection. This also 
* means that in line 3 the data type of the results variable will 
* be IEnumerable<string>.
* 
* * In line 7, the data type of the value variable will be a string.
* 
* Let's look at another example. Suppose we have the following Contact
* class that stores a person's name and phone number:
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Contact
* {
*       // Properties 
*       public string Name{get; set;}
*       public string PhoneNumber{get; set;}
*       
*       // Constructor 
*       public Contact (string n, string ph)
*       {
*           Name = n;
*           PhoneNumber = ph;
*       }
* }
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Suppose we want to search an array of Contact objects for a specific
* person's phone number. The following code snippet shows an example of 
* how we might seatch for Jill Ammons' phone number:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Conract[] contacts =
* {
*   new Contact("Katie Allen", "555-1234"),
*   new Contact("Jill Ammons", "555-5678"),
*   new Contact("Keven Brown", "555-9012")
* };
* 
* var results = from item in contacts
*               where item.Name == "Jill Ammons"
*               select item;
*               
* foreach (var value in results)
* {
*   MessageBox.Show(value.PhoneNumber);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this example, the LINQ query searches the contacts array for all
* Contact objects where their Name property set to "Jill Ammons". The
* query will return a collection that is an IEnumerable<Contact> 
* collection. So, the data types in the statement will be as follows:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * The query is searching an aeeay of Contact object, so in line 8, 
* item will be a Contact object.
* 
* *In line 10, the select statement is selecting a Contact object(item),
* so the query will return an IEnumerable<Contact> collection. This also
* means that in line 8, the data type of the results variable will be 
* Contact.
* 
* *In line 12, the data type of the value variable will be Contact.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Sometimes we want the select clause to "shape" the data that is 
* returned for a query in a particular way. For example, suppose we 
* have the following retailItem class that stores a retail item's
* description and price:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class RetailItem
* {
*   // Properties
*   public string Description {get; set;}
*   public decimal Price {get; set;}
* 
*   // Constructor
*   
*   public RetailItem(string d, decimal p)
*   {
*       Description = d;
*       Price = p;
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Suppose we want to search an arrah of RetailItem objects for all 
* items with a price grater than 100, we want the query to return only
* description of the item. The following code snippet shows an example:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
*   
* };
* 
* var results = forn item in retailItems
*               where item.Price > 100m
*               select item.Description;
*
*foreach (var value in results)
*{
*   MessageBox.Show(value);
*}
*
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this example, the LINQ query searches the retailItems array for all
* RetailItems object with a Price property grater than 100.
* Notice that in line 11, the select statement selects item.Description,
* which is a string. So the qurty will return an 
* IEnumerable<string> collection. This also means that in line 9, the 
* data type of the results variable will be IEnumerable<string>.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Using Multiple where Clauses
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You can use multiple clasues in a LINQ expression to specify multiple
* search criteria. The following code snipped shows an example:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = from item in retailItems
*               where item.Price > 90m
*               where item.Price < 120m
*               select item.Description;
*               
* foreach(var value in results)
* {
*   MessageBox.Show(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Notice that in LINQ query has two where clauses in line 10 and 11. 
* The first where clasues causes the query to retrieve the items a price
* that is greater than 90. Then, from that set of results, the second
* where clause causes the query to retrieve the items with a price 
* that is greater than 90. Then, from the set of results, the second
* where clause causes the query to retrieve the items with a price 
* that is less than 120. We would get the same results if we had written
* the query like this:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var results = from item in retailItems
*               where item.Price > 90m && item.Price < 120,
*               select item.Description;
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The orderdy Clause
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* If you wish to sort the results of a LINQ query, you can use the 
* orderby clause. The following code snippet shows an example.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*  int[] numbers = {4,104,2,102,1,101,3,103};
* 
* var results = from item in numbers select item;
* 
* foreach (var value in results)
* {
*   MessageBox.Show(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The orderby item clause in line 4 causes the query results to be
* sorted in ascending order (lowest to heighest). The loop in lines 
* 7-10 will display the value 4,104,2,102,1,101,3,and 103 in message 
* boxes
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Here is an example that uses the previously shown RetailItem class
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* * RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = from item in retailItems
*               where item.Price < 150m
*               orderby item.Price
*               select item.Description;
*  foreach (var value in results)
* {
*   MessageBox.Show(value);
* }    
*               
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The query in line 9-12 searches the retailItems array and retrieves 
* the description of the RetailItem objects with a price less than 150.
* The orderby clause in line 11 sorts the results by their Price property,
* so the descriptions will be displaued in order of price, from
* lowest to highest.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* If you want to sort the results of a query in descending order
* (highest to lowest), use the descending keyword, as shown in line 3
* in the following code snippet.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var results = from item in retailItems
*               where item,Price < 150m
*               orderby item.Price descending
*               select item.Description;
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 14-1: Completing the Student Roseter Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this tutorial, you complete the Student Roster application. The
* application displaus a list of student names in a ListBox control. 
* Figure 14-2 shows the application;s form, which 
* has already been created for you. The user cabn click the
* displayAllButton and all the student names will be displayed
* in the ListBox. The user can also search for students by entering a
* last name in the searchTextBox control and then clicking the 
* SearchButton control.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-2 The form1 form
* 
* /////////////////////////////////////////////////////////////////////
* The application stores each student's first and last name in a 
* Student class, which has already been written and is included in the
* project. The Student class is shown in Program 14-1. Here is a 
* summary of class:
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* *Line 6 is the LastName property, a string. This property holds a 
* strudent's first name.
* 
* *Line 7 is the FirstName property, a string. This property holds a
* student's last name.
* 
* *Line 8-11 is the FullName property, a read-only string. This property
* returns the student's first and last name as a string.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-1 The Student Class
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace StudentRoster
* {
*   class Student
*   {
*       // Properties
*       public string LastName {get; set;}
*       public string LastName {get; set;}
*       
*       public string FullName
*       {
*           get{return LastName + ", " + FirstName;}
*       }
*       
*       // Constructor
*       public Student(string last, string first)
*       {
*           LastName = last
*           FirstName = first;
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-2 Complete Form1 code for the Student Roster application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace StudentRoster
* {
*   public partial class Form1: Form
*   {
*       List<Student> students = new List<Student>()
*       {
*           new Student("Adams", "Susan"),
*           new Student("Adams", "James"),
*           new Student("Watson", "Earl"),
*           new Student("Lee", "Tina"),
*           new Student("Lee", "Austin"),
*           new Student("Brooks", "Gary"),
*           new Student("Brooks", "Lisa"),
*           new Student("Compbell", "Patrick"),
*           new Student("Gonzales", "Annie"),
*           new Student("Anderson", "Ashley"),
*       };
*       
*       public Form1()
*       {
*           InitializeComponent();
*       }
*       
*       private void displayAllButton_Click(object sender, EventArgs e)
*       {
*           // Get all the Student objects in the List,
*           // ordered by last name.
*           var results = from student in students
*                         orderby student.LastName
*                         select student;
*       }
*       
*       // Display the results in the ListBox.
*       foreach(Student s in results)
*       {
*           studentListBox.Items.Add(s.FullName);
*       }
*   }
*   
*   private void searchButton_Click(object sender, EventArgs e)
*   {
*       // Get all the Student objects with the specified 
*       // last name, ordered by first name.
*       var results = from student in students
*                     where student.LastName == searchedTextBox.Text
*                     orderby student.FirstName
*                     select student;
*                     
*                   
*      // Clear the ListBox
*      studentListBox.Items.Clear();
*      
*      // DIsplay the results in the ListBox.
*      foreach(Student s in results)
*      {
*       studentListBox.Items.Add(s.FullName);
*      }
*   }
*   
*   private void exitButton_Click(object sender, EventArgs e)
*   {
*       // Close the application
*       this.Close();
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 14.2 LINQ Method Syntax
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: You can write a LINQ query using wither query syntax or 
* method syntax. If you use query suntax, the C# compiler translates 
* your queries into method calls that invoke extension methods that 
* are defined in the .NET Framework. If you use method syntax, you are
* calling those extension methods directly
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* There are two ways to write a LINQ query: you can use query syntax or
* method syntax. All the prebious examples were writtn in query sytax,
* which resembles an SQL query. Queries that re written in method 
* syntax take the form of a method call.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The .NET Framework defines a set of LINQ extension method that work
* with all collections in the framework. The extension methods correspond
* to the variouys clasuses that appear in a LINQ query. For ex, there 
* is Where method, there us an OrderBy method, and there is a Select
* method. When you compiler a C# program that containb a quiery
* written in query syntax, the compiler translates the query into method
* syntax. If you wish, you can perform LINQ queries by calling the 
* LINQ extension methods directly, instead of using query syntax.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Where Method
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This is the general format of the Where method
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* collection.Where(FuncDelegate)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* in the general format, collection is the collection you are seaching 
* and FuncDelegate if a Func delegate (or lambda expression) that has
* one parameter and retuens a bool value. The where method usees the 
* Func delegate to dertermine which element will be included in the query results. 
* Each element of the collection will be passed as an argument to the 
* Func delegate. If the Func delegate returns true, the element will be
* included. If the Func delegate returns false, the elements will not
* be included
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* The where method returns its query results as an IEnumeralble<T>
* collection. The elements in the collection will be of the same data
* type as the element of the collection that is being searched for.
* So, if the Where method executes on an int array, the method will
*  return its query results as an IEnumerable<int> collection.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet shows a ex
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {4,104,2,102,1,101,3,103};
* 
* var results = numbers.Where(item => item > 100);
* 
* foreach (var value in results)
* {
*   MessageBox.Show(value);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*  In this ex, the LINQ query appears in line 3. The lambda expression
*  that we are passing to the query has one parameter naemd item. The 
*  lambds expression returns true if item is greater than 100, or false
*  otherwise. So, the LINQ query returns all elements of the numbers
*  array that are greater than 100.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following chode snippet shows an example using the RetailItem 
* class shown eariler in this chapter.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = retailItems.Where(item => item.Price < 100m);
*               
* foreach(var value in results)
* {
*   MessageBox.Show(value);
* }
* 
* /////////////////////////////////////////////////////////////////////
* In this exaple, the LINQ query in line 9 return all the elements
* of the retailsItems array with a price that is less than 100.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The OrderBy and OrderByDescending Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* If you want to sort the elements of a collection in ascending order,
* you can use the OrderBy method.  This is general format of the OrderBy
* method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* collection.OrderBy(FuncDelegate)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In the general format, collection is the collection you are seaching
* for and Funcdelegate is a Func delegre (or lambda expression) that
* has one parameter and resutns a value. Each element of the collection
* will be passed as an arguemnt to the Func delegate. The delegate returns
* the field of the element that the results should be sorted on. The 
* OrderBy  method returns the query results as an IEnumerable<T> 
* collection.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code shows an example of sortiung all the elements of 
* an array of RetailItem objects.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = retaiItems.OrderBy(item => item.Price);
*               
* foreach(var value in results)
* {
*   MessageBox.Show(value.Price.ToString());
* }
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Take a closer look at the lambda expression we are passing to the 
* OrderBy method on 9:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* items => item.Price
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The item parameter receives an element of the array, and then returns
* the element's Price property. As a reults, the query will give us the
* element of the array sorted by their Price property, in ascening order.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* If you want to see results sorted in descending order, you cannot use
* the OrderBy method. Instead, you use the OrderByDescending method, as
* shown here:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Quite ofter you will need to combine calls to the extension methods
* in a LINQ query. For example, suppose you have a RetailItem array,
* and you want to get all the items with a price that is less than 100,
* and you want the results sorted by price in ascending order. THis 
* requires that you call both the Where method and the OrderBy method.
* The following code snippet shows one way to accomplish this.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * * RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = retaiItems.Where(item => item.Price < 100m);
* var results2 = retaiItems.OrderBy(item => item.Price);
*               
* foreach(var value in results2)
* {
*   MessageBox.Show(value.Price);
* }
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* Rather than executing multiple, separate queries, LINQ supports a 
* technique know as method chaining that allows you to call the 
* necessary extension method in one statement. Here is an example:
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = retailItems.Where(item => item.Price < 100m).OrderBy(int => int.Price);
*               
* foreach(var value in results)
* {
*   MessageBox.Show(value.Price);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this ex, the Where method is called first to het all the elements 
* that have a Price value less than 100. The Where method returns its
* results as an IEnumberable<RetailItem> collection. Then, the ORderBy
* method is called on the colelction that was retuened from the Where 
* method The IEnumberable<RetailItem>
* collection that is returned from the OrderBy method is assigned to the
* results variable.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Select Method
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You probably noticed that in the previous method syntax examples, we
* didnt use the Selct method. That's because the Select method is optional
* when you are writing quries in method syntax. You only need to use it
* if you want to reshape the data that are returned from the query. Here
* is the general format of the Select method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* collection.Selct(FuncDelegate)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In the general format, colelction is the collection you are searching
* for and FuncDelegate is a Func delegate (or lambda expression) that
* has one paramter and retursn a value. Each element of the collection
* will be passed as an argument to the Func delegate. The delegte returns
* the data that should be included in the search results. For ex, look
* at the following snippet:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* string[] name = {"Jake","Allison","Will","Sara"}
* var results = names.Select(item => item.ToUpper());
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The query in line 2 returns an IEnumerable<string> collection
* containing all the elements of the names collection, converted to
* uppercase. Here is another ex:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var results = names.Where(item => item.Contains("ill"))
*                    .Select(item => item.ToUpper());
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The query in line 2 returns an IEnumerable<string> collection
* containing the strings "BILL" and "WILL". The following is one more
* ex:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   * * RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* var results = retailItems.Where(item => item.Price < 100m)
*                          .OrderBy(int => int.Price)
*                          .Select(item => item.Description);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The query in lines 9 and 10 returns a IEnumerable<string> collection
* containing the Description property of each item that is priced less
* than 150, sorted by price in ascending order.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 14-2: Modifying the Student Roser Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this tutorial, you midify the Student Roster application that 
* you completed in Tutorial 14-1. In that tutorial, you used query
* syntax to write two LINQ queries that retrieve data from a List of 
* Students objects. In this tutorial, you rewrite the queries using 
* method syntax. Program 14-3 shows the completed Form1 source code,
* as it appears after you make the chagnes in this tutorial.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-3 Completed Form1 code for the Student Roster application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* using System;
* using System.Collections.Generic;
* using System.Data;
* using System.Linq;
* using System.Windows.Forms;
* 
* namespace StudentRoser
* {
*   public partial class Form1: Form
*   {
*       List<Student> students = new List<Student>()
*       {
*           new Student("Adams","Susan"),
*           new Student("Adams ","James"),
*           new Student("Watson","Earl"),
*           new Student("Lee","Tina"),
*           new Student("Lee","Austin"),
*           new Student("Brooks","Gary"),
*           new Student("Brooks","Lisa"),
*           new Student("Campbell","Patrick"),
*           new Student("Geonzales","Annie"),
*           new Student("Anderson","Ashely")
*       };
*       
*       public Form1()
*       {
*           InitializedComponent();
*       }
*       
*       private void displayAllButton_Click(object sender, EventArgs e)
*       {
*           // Get all the Student objects in the List,
*           // ordered by last name.
*           var results = students.OrderBy(stu => stu.LastName);
*           
*           // Display the results in the ListBox.
*           foreach(Student s in results)
*           {
*               studentListBox.Items.Add(s.FullName);
*           }
*       }
*       
*       private void searchButton_Click(object sender, EventArgs e)
*       {
*           // Get all the Student objects with the specified 
*           // last name, ordered by first name.
*           var results = students.Where(stu => stu.LastName==
*            searchTextBox.Text.OrderBy()stu => stu.FirstName);
*            
*            // Clear the ListBox.
*            studentListBox.Items.Clear();
*            
*            //Display the results in the ListBox.
*            foreach(Student s in results)
*            {
*               studentListBox.Items.Add(s.FullName);
*            }
*       }
*       
*       private void exitButton_Click(object sender, EventArgs e)
*       {
*           // Closre the application.
*           this.Close();
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 14.3 More LINQ Extension Methods
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept:
* There are numerous LINQ extendion method in the .NET Freamework that 
* perform useful operations but cannot be invoked with LINQ query suntax.
* You must use LINQ method syntac to call them.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* There are several LINQ ectension methods ddefined in the .NET Framework
* that cannot be invoked using LINQ query syntax. They can be called 
* only in queries that are written in method syntax. In this section,
* we will look at many of those extendion methods.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Quantifier Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A quantifier method is a method that returns true or false to 
* indicate whether one or meore elements in a collection match a condition.
* LINQ provides the quantifier method listed in Table 14-1.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Table 14-1 LINQ quantifier methods
* 
* Method        Description
* All           Summary: returns true of all the elements of a collection
*               match a condition. Returns false otherwise.
*               
*               General format: collection.All(FuncDelegate)
*               
*               Description: In the general format, collection is the 
*               collection you are searcing and FunDelegate is a 
*               Func delegate (or lambda expression) that has one parameter 
*               and returns a bool value. EAch element of the 
*               collection will be passed as an argument to the
*               Func delegate. IF the Func delegate returns true
*               for all the elements, the All method returns true.
*               Otherwise, the All method returns false.
* 
*               
* Any           Summary: Returns true if any of the elements of a
*               collection match a condition.
*               Returns false otherwise.
*               
*               General Format: collection.Any(FuncDelegate)
*               
*               Description: In the general format, collection is the collection you
*                are searching and FuncDelegate is a Func delegate(or lambda expression)
*                that has one parameter and returns a bool value. Each element of the
*                collection will be passed as an argument to the Func delegate. 
*                if the Func delegate returns true for any of the elements, the Any
*                method returns true. Otherwise, the any method returns false.
* 
* 
* Contains      Summary: Returns true if a collection contains a
*               particular element. Returns false otherwise.
*               
*               General Format: collection.Contains(value)
*               
*               Description: In the general format, collection is the collection
*               you are searching and value is a value that you are searching 
*               for.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Each of the methods in Table 14-1 takes, as an argument, a Func
* delegate(or lambda expression) that has one parameter and returns a
* bool value. Let's look at some examples tht use the RetailItem
* class presented eariler. The following code snipped demonstrates the
* All and Any methods:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *   * * RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
* if(retailItem.Add(item => item.price < 200m))
*   MessageBox.Show("All items are less than $200.");
*   
* if(retailItems.Any(item => item.Price < 100m))
*   MessageBox.Show("Some times are less than $100.")
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The if statement in 9 uses the All method to determine whether all
* the elements of the retailItem array have a Price value that is less
* 200. Then, the if statement in 12 uses the Any method to determine
* whether any of the elements of the retailItems array have a Price 
* value that is less than 100.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Constains method, which was first mentioned in Chapter 8, returns
* true if a collection contains a specified value. Otherwise it returns
* false. The following code snipped demonstrates.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Aggregation Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An aggregation method is a method that calculates a single value from
* a collection of values. LINQ provides the aggregation methods listed
* in Table 14-2
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Table 14-2 LINQ aggregation methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Method            Description
* Average
* Count
* Max
* Min
* Sum
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the simplest form of each of 
* these methods:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {1,2,3,4,5};
* 
* MessageBox.Show("Average: " + numbers.Average());
* MessageBox.Show("Count: " + numbers.Count());
* MessageBox.Show("Max: " + numbers.Max());
* MessageBox.Show("Min: " + numbers.Min());
* MessageBox.Show("Sum: " + numbers.Sum());
* 
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* You can get more focued results from each of these methods by passing 
* an argument. The following code snippet demonstrates this:
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
 RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
* 
*   // Get the average price
*   var avg = retailItems.Average(item => item.Price);
*       MessageBox.Show("Average Price: " + avg);
*       
*        // get the number of items priced less than $100.
*   var lessThan100 = retailItems.Count(item => item.Price);
*       MessageBox.Show("items priced less than $100" + lessThan100);
*       
*        // Get the highest price.
*   var mostExpensive = retailItems.Average(item => item.Price);
*       MessageBox.Show("the highest price: " + mostExpensive);
*       
*        // Get the lowest price.
*   var leastExpensive = retailItems.Average(item => item.Price);
*       MessageBox.Show("the lowest pric: " + leastExpensive);
*       
*        // Get sum of all the prices
*   var sum = retailItems.Average(item => item.Price);
*       MessageBox.Show("sum of all the prices: " + sum);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Element Methods 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An element method is a method that returns a specific element
* from a collectio. LINQ provides the element method listed in Table
* 14-3.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Table 14-3 LINQ element methods
* 
* Method        Description
* 
* ElementAt
* 
* ElementAtOrDefault
* 
* First
* 
* FirstIrDefault
* 
* Last
* 
* LastORDefault
* 
* Single
* 
* SingleOrDefault
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The follwong code snippet demonstrates each of these methods:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*  RetailItem[] retailItems =
* {
*   new RetailItem("Headphones", 199.99m),
*   new RetailItem("Color Printer", 99.99m),
*   new RetailItem("Security Camera", 129.99m),
*   new RetailItem("Bluetooth Speaker", 79.99m)
* };
*  // Get the average price
*   var element = retailItems.ElementAt(2);
*       MessageBox.Show("At index 2: " + element.Description);
*       
*        // Try to get an invalid element.
*   element = retailItems.ElementAtOrDefault(4);
*        if(element==null)
*           MessageBox.Show("Position 4 is invalid.");
*       
*       // Get the first element where Price < 100
*        element = retailItems.First(item => item.Price < 100m);
*       MessageBox.Show("First item less than $100: " + element.Description);
*       
*        // Get the first element where Price > 200. (Invalid)
*   element = retailItems.FirstOrDefault(item => item.Price < 100m);
*        if(element==null)
*           MessageBox.Show("No item greater than $200.");
*           
*          // Get the last element where Price < 100
*   element = retailItems.Last(item => item.Price < 100m);
*       MessageBox.Show("Last item less than 100" + element.Description);
*       
*        // Get the last element where Price > 200. (Invalid)
*   element = retailItems.LastOrDefault(item => item.Price < 100m);
*        if(element==null)
*           MessageBox.Show("No item greater than 200.");
*       
*       // Get the one element where price == 79.99.
*   element = retailItems.Single(item => item.Price == 79.99m);
*       MessageBox.Show("The only item at 79.99: " + element.Description);
*       
*        // Get the one element where Price == 200. (invalid)
*   element = retailItems.SingleOrDefault(item => item.Price == 200m);
*        if(element==null)
*           MessageBox.Show("No items priced at $200");
*       
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Generation Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A generation method is a method that generates a new collection of 
* values. LINQ provides the generation method listed in Table 12-4.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Table 14-4 LINQ generation methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Method            Description
* 
* DefaultEmpty
* Enumerable.Empty
* Enumerable.Rang
* Enumerable.Repeat
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the DefaultIfEmpty and 
* enumerable.Empty methods. In this code, both numbers and nums will
* reference empty IEnumerable<int> collections. The defaultsNums
* collection will have one element, set to have value 99:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   // Create an empty int collection.
*   var numbers = Enumerable.Empty<>();
*   
*   // Create another empty int collection.
*   vat nums = numbers.DefaultIfEmpty();
*   
*   // Create an int collection with 1 element
*   // set to the value 99.
*   var defaultNums = numbers.DefaultIfEmpty(99);
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following statement demonstrates the Enumerable.Range method. 
* The numbers collection will have five elements set to the values 
* 100,101,102,103,and 104:
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var numbers = Enuerable.Rang(100,5);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following statement demosnstrates the Enumerable.Repeat method.
* The numbers collection will have 10 int elements with each element 
* set to the value 99:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following statement also demonstrates the Enumerable.Repeat 
* method. The retailItems collection will have three RetailItem 
* elements. Each element will have a Description property set to 
* "unknown" and a Price property set to ):
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* var retailItems=Enumerable.Repeat<RetailItem>
* (new RetailItem("unknown", 0m), 3);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Set Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A set method is a method that perfroms a mathematical set operation
* on two collections of values. (the Distinct method works with only
* one collection.) LINQ provides the set me thods listed in Table 14-5.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* table 14-5 Set methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Methods       Description
* Distinct  
* 
* Except
* 
* Intersect
* 
* Union
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: The methods in table 14-5 work as described with primitive
* date types. If you want to use them with cillections of class objects,
* however, the methods will work with the objects' references, not the 
* data that the objects contain. If you want to use these methods with 
* collections of objects, based on the data that the objects contain,
* you will have to implement a custom comparator for those objects.
* We do not discuss custom comparators in this book.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the Distinct method. The 
* resilt collection will have four elements set to the values 1,2,3,
* and 4:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] set1={1,2,2,3,3,3,4,4,4,4,};
* var result- set1Distinct();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the Except method. The result
* collection will have two elements set to the values 1 and 2:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] set1 = {1,2,3,4};
* int[] set2 = {3,4,5,6};
* 
* var result = set1.Except(set2);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the Intersect method. The
* result collection will have two elements set to the values 3 and 4:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] set1 = {1,2,3,4};
* int[] set2 = {3,4,5,6};
* 
* var result = set1.Intersect(set2);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the Union method. The result
* collection will have six elements set to the values 1,2,3,4,5 and 6.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * int[] set1 = {1,2,3,4};
* int[] set2 = {3,4,5,6};
* 
* var result = set1.Union(set2);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Partitioning Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A paritioning method is a method that divides a collection into two
* section and returns one of the sections. LINQ provides the generation
* methods listed in Table 14-6.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Table 14-6 LINQ partitioning methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Method        Description
* 
* Skip
* SkipWhile
* Take
* TakeWhile
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the Skip method. The result
* collection will have six elements set to the values 4,5,6, and 7:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {1,2,3,4,5,6,7};
* var result = numbers.Skip(3);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the SkipWhile method. The 
* result collection will have four elements set to the values 5,6, 
* and 7:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
int[] numbers = {1,2,3,4,5,6,7};
* var result = numbers.SkipWhile(item => item < 5);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the Take method. The result
* collection will have three elements set to the values 1,2,and 3:
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {1,2,3,4,5,6,7};
* var result = numbers.Take(3);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the TakeWhile method. The 
* result collection will have four elements set to the values 1,2,3,and
* 4:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers = {1,2,3,4,5,6,7};
* var result = numbers.TakeWhile(item => item < 5);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Miscellaneous Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* LINQ provides the miscellaneous methods listed in Table 14-7
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Method        Description
* Concat
* SequenceEqual
* 
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates Concat method. The result
* collection will have six elements set the values 1,2,3,4,5, and 6.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers1 = {1,2,3};
* int[] numbers1 = {4,5,6};
* var result = number1.Concat(numbers2);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet demonstrates the SewuenceEqual method.
* The code will display both the message "number1 and number2 are not 
* the same" and "numbers1 and numbers3 are NOT the same".
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int[] numbers1 = {1,2,3};
* int[] numbers2 = {1,2,3};
* int[] numbers3 = {4,5,6};
* 
* if(numbers1.SequenceEqual(numbers2))
*   MessageBox.Show("numbers1 and numbers2 are the same");
*   
* if(!numbers1.SequenceEqual(numbers3))
*   MessageBox.Show("numbers1 and numbers3 are NOT the same");
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 14-3 Completing the Team Player Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this tutorial, you complete the Team Plater application. The 
* application creates two lists: one that ho;ds the names of the students
* on the baseball team, and another that holds the names of students on
* the basketball tean. When you complete the application, it will
* perform the following set operations of the two lists
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *It Finds the intersection of the lists to display the names of students 
* who play both sports.
* 
* *It finds the union the lists to display the names of students who play
* either sport. 
* 
* *It finds the difference of the baseball list from the backball list to
* display the names of students who play baseball but not basketball.
* 
* *It finds the difference of the baseball list form the basketball list
* to displat the names of students who plat basketball but not baseball
* . It also finds the difference of the basketball list from the baseball
* list to display the names of students who play baseball but not 
* baskeball.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-3 shows the application's form, which has already been 
* created for you. Program 14-4 shows the application's code as it will
* appears when you have completed this tutorial
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-3 The Team Players application Form1 form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-4 Completed Form1 code for the Team player application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* using System;
* using System.Collections.Gerneric;
* using System.Data;
* using System.Linq;
* using System.Windows.Forms;
* 
* namespave TeamPlayers
* {
*   public partial class Form1 : Form
*   {
*       // Baseball team members
*       List<string> baseball = new List<string>()
*       {
*           "Jodi","Carmen","Alicia","Aida"
*       };
*       
*        // Basketball team members
*       List<string> basketball = new List<string>()
*       {
*           "Eva","Carmen","Alicia","Sarah"
*       };
*       
*       public Form1()
*       {
*           InitializeConponent();
*       }
*       
*       private void Form1_Load(object sender, EventArgs e)
*       {
*           // Get the basebass sorted in ascennging order.
*           var baseballPlayers = baseball.OrderBy(str => str);
*           
*           // Get the basketball players sorted in ascending order.
*           
*           var basketballPlaters = basketball.OrderBy(str=>str);
*           
*           // Display the baseball players.
*           foreach(string player in baseballPlayers)
*           {
*               baseballListBox.Items.Add(player);
*           }
*           
*           // Display the basketball players.
*           foreach(string player in basketballPlayers)
*           {
*               basketballListBox.Items.Add(player);
*           }
*       }
*       
*       private void intersectionButton_Click(object sender, EventArgs e)
*       {
*           // Get the elements that are in both lists, storeted.
*           var result = baseball.Intersect(basketball).OrderBy(str => str);
*           
*           // Clear the Results ListBox.
*           resultsListBox.Items.Clear();
*           
*           // Display the result
*           foreach(string player in result)
*           {
*               resultsListBox.Items.Add(player);
*           }
*       }
*       
*       private void unionButton_Click(object sender EventArgs e)
*       {
*           // Get the elements that are in wither list sorted.
*           
*           var result = baseball.Union(baseball).OrderBy(str => str);
*           
*            // Clear the Results ListBox.
*           resultsListBox.Items.Clear();
*           
*           // Display the result
*           foreach(string player in result)
*           {
*               resultsListBox.Items.Add(player);
*           }
*       }
*       
*       private void diff1Button_Click(object sender, EventArgs e)
*       {
*           // Get the elements that are in the baseball
*           //but not in the basketball list, sorted.
*           
*           var result = baseball.Except(basketball).OrderBy(str => str);
*           
*           // Clear the Results ListBox.
*           resultsListBox.Items.Clear();
*           
*           // Display the result
*           foreach(string player in result)
*           {
*               resultsListBox.Items.Add(player);
*           }
*       }
*       
*       private void diff2Button_Click(object sender EventArgs e)
*       {
*           // Get the elements that are in the basketball list
*           // but not in the baseball list, stored
*           
*           var result = basketball.Except(baseball).OrderBy(str => str);
*           
*            // Clear the Results ListBox.
*           resultsListBox.Items.Clear();
*           
*           // Display the result
*           foreach(string player in result)
*           {
*               resultsListBox.Items.Add(player);
*           }
*       }
*       
*       private void closeButton_Click(object sender, EventArgs e)
*       {
*           this.Close();
*       }
*   }
* }
* 
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 14.4 Using LINQ to Query a Database
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* Concept: By using an Object relational Mapping tool, or ORM, you can
* use LINQ to query a database.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Previously in this chapter, we discussed LINQ as a tool for querying
* data in arrays and lists. Using a tool called LINQ to SQL, you can
* also use LINQ to query database. LINQ to SQL is database into objects.
* The programmer can then write LINQ queries that work with theses objects
* , and behind the scenes, LINQ to SQL translates the LINQ queries into 
* SQL queries.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* There are three types of objects that we will work with in this 
* section: datacontext object , table objects and entitly objects.
* Let's take a closer look at each of these.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Data Context Objects
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A data context object represents a database. It has the abulity to
* connecty to a database, translates LINQ queries into SQL quries, and 
* execute those SQL queries on the basebase. When you set up LINQ to 
* SQL to work with a specific database, Visual Stidio will 
* automatically generate a class in your project that is derived from the
* DataContext class in the .NET Freamework. In your code, you can create
* an object that is an instance of the Table class in the .NET Framework.
* It is essentially an IEnumerables<T> collection that contains the rowws
* od a database table as its elements. In code, you can iterate ovwe
* the elements of a table object in the same way that you can iterate over 
* a List or an array. You can also execute LINQ querries on table objects.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When Visual Stido generates a derived DataContext class to reperesnet
* a specific database, the derived DataContext class will contain table
* objcests as properties, reach represenging a table in the datebase. 
* For ex, if you are working with a database that contains two tables,
* the object that represernts the database will have two table peoperties,
* one for each table in the database.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Entity Objects
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An entity object representes a row in a table. It has preoperties
* that represente the columns in the row. For ex, let's way we are 
* wroking with a tablem and each row in the table has the following 
* three columns:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *An int column named EmployeeID
* 
* *An nvarchar(50) column named Name
* 
* *A money column named PayRate
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An entity object that represents this row have the following three
* properties:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * An int property named EmployeeID
* 
* * A string property named Name
* 
* * A decimal property named PayRate
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An entity object that represents this row will have the following
* three properties:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *An int property named EmployeeID
* 
* *A string property named Name
* 
* *A decimal property named PayRate
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-4 illustrates a data context object that contains two
* two table objects. Each table objects is a collection of entity objects.
* This corresponds to a database that has two tables.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   Figure 14-4 Data context, table, and entity objects 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Installing LINQ to SQL 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* LINQ to SQL is not automatcally installed with Visual Studio. Bdefore
* you can use it, you must use the Visual Studio Installer to download and 
* install it. See Appendix E for instructions.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Setting Up LINQ to SQL to Work with a Database
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* To set up LINQ to SQL to work with a database, you should typically
* follow these steps: 
* 
* 1. ADD A CONNECTION TO THE DATABASE THAT YOU WANT TO WORK WITH
* 
* There are different ways to accomplish this. One way is to open the 
* Server Explorer and click the Connect to Database icon, as shown in 
* Figure 14-5. This causes the Add Connection window to appear, as 
* shown in Figure 14-6, which lets you browse your file system and select
* the desired database file.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-5 Connect to Database
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 2. ADD A DBML TO THE PROJECT.
* In this step, you create a DBML file in your project. DBML stands for
* Database Markup Language. Visual Studio uses the DBML file to 
* automatically generate the classes needed for LINQ to SQL. Here are the
* steps for adding a DBML file to the project:
* 
* *Click Project on the menu bar, then click Add New Item...
* 
* *The Add New Item window appears next. As show in Figure 14-7, select
* Data in the left pane, select LINQ to SQL Classes in the cemter pane.
* 
* *In the Name text box, change the default name of the DBML file to 
* something more descriptive, and click the Add button to add the file
*  to the project.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-6 The Add Conncetion window
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-6 The Add New Item window
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 3. USE THE OBJECT RELATIONAL DESIGNER TO SELECT THE DATABASE TABLES
* YOU WANT TO WORK WITH.
* 
* The Object Relational Designer, shown in Figure 14-8, will appear
* as soon as you add the DBML file to your project. The Object 
* Relational Designer is a visual designer tool that you to create the
* classes needed for LINQ to SQL to work with a particular database.
* In the simpletet case, you drag a table from the Server Explorer and
* drop it into the Object Relational Designer. The LINQ to SQL classes 
* needed to repesent the table will automattically be created in the
* project.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-8 The object relational Designer window
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Once you have performed these steps, the following classes will auto-
* matically be created in your project:
* 
* * A data context to represent the database. This class is derived 
* form the DataContext class in the .NET Framework.
* 
* *The data context class contains one or more table objects
* (as properties) that represent the tables in the databaes. Each table
* object is an instance of the Table class in the .NET Framework. Each
* table object is an collection of entity objects that represent the
* rows in the table.
* 
* *The entity objects contains properties that represent the columns in
* the table.
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* LINQ to SQL Naming Conventions
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When Visual Studio generates a data context class, the naming
* convention is strightforward: The name of the data context class is 
* based on the name of the DBML file. For example, if the DBML file is
* named Personnel.dbml, then the data context class will be named 
* PersonnelDataContext.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The naming conbention for table objects and their associated entity
* class is not quite as simple. By default, a table object's name is 
* the plural version of the database table's name. For ex, suppose our 
* database table is named Employee. Visual Studio will name the table
* object Employee and the entity class Employee. This means that the
* Employees object (a table object) will be a collection of Employee
* objects (entity objects).
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Let's look at another example. Suppose a database contains the inventory
* of a used car dealer. The database is named UsedCars.mdf, and it has
* a table named Car. Each row in the Car table contains data about a 
* car in the inventory. We are creating an application to work with the
* database, so our DBML file is named UsedCars.dbml. Visual Studio will
* use the following names for our LINQ to SQL classes:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * The data context class will be named UsedCarsDataContext.
* 
* *The UsedCarsDataContext class will have a table property named
*   Cars(the plural version of the database table name).
* 
* *The entity class for the table will be named Car (the 
*   singular version of the database table name.)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Wokring with the Data Context Object
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Once you have used the Object Relational Designer to generate the 
* desired LINQ to SQL classes, you are ready to write code that works
* with the database. The first step is to create an instance of the data 
* context class. For ex, suppose we are working with the used car database
* previously described. To create an instance of the UsedCarsDataContext
* class, we would write a statement such as this:
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* UsedCarsDataContext db = new UsedCarsDataContext();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This statement creates a UsedCarsDataContext object named db. We can
* use the db object to access the database's table, as shown in the 
* following code snippet. Assumen the database table a column Mileage.
* This code iterates over each row in the table, adding the Milage 
* column to a ListBox.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* foreach(Car c in db.Cars)
* {
*   mileageListBox.Items.Add(c.Mileage.ToString());
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In Tutorial 14.4, you will complete an application by connecting it 
* to a database, creating the LINQ to SQL classes needed to represent 
* the database, and writing code that iterates over a table in the 
* database.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 14-4: Completing the Phonelist Names Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* recall that the Phonelist database has a table named Person with the
* following columns:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* *PersonID - an int identity column containing a unique ID for each row
* 
* *Name - an nvarchar(50) column containing a peron's name
* 
* *Phone - an nvarchar(50) column containing a person's phone number
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Our application will be simple. It will use a LINQ query to retrieve
* all the names in the Person table, and display those names in a ListBox
* named personListBox.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 1: If you have not already done so, intall the LINQ to SPL 
* component (as described in Appendix E.)
* 
* Step 2: Oper the project named Phonelist Names in the CHap14 folder
* of this book's Student Sample Program
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-9 The Phonelist Names application Form1 form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 4: Perform the following steps to connect the application to the
* Phonelist.mdf database:
* 
*   *If you do not see the Server Explorer window, click View on the 
*   menu bar, and then click Server Explorer.
*   
*   *In the Server Explorer window. click the Connect to Database icon
*   as previously shown in Figure 14-4.
*   
*   *The Add connection window should appear next, as previouslt shown
*   in Figure 14-7. Make sure Microsoft SQL Server Database FIle 
*   (SqlClient) is selected under Data Source. Then click the Browse...
*   button to select the database file. Navigate to the 
*   Chap14\Databases folder of the Student Sample Programs and select
*   the Phonelist.mdf file.
*   
*   *Click the Test Connection button to text the connection. You should
*   see the message Test Connection Succeede. Click the OK button to 
*   complete the connection.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 5: Now you will add the LINQ to SQL classes to the project.
* Perform the following steps:
*   *Click Project on the menu bar, then click Add New item...
*   
*   *The Add New item window appears next. As shown in Figure 14-10,
*   select Data in the left pane, select LINQ to SQL Classes in the
*   center pane, and change the name of the file to Phonelist.dbml. 
*   Click the Add button to the classes to the project.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-10 The Add Item window
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Now you will create the classes you need to access the database.
*   
*   Step 6:The object Relational Designer should be open,as shown in
*   Figure14-11.
*   
*   In the Server Ecplorer window, expans the Phonelist.mdf entry,
*   and then expand the Tables Entry, as shown in FIgure 14-12.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-11 The Object Relational Designer
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-12 Expand Tables in the Server Explorer
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *Drag the Person table from the Server Explorer window and drop it in
* the Object Relational Designer. You will see the window showm in 
* Figure 14-13. Click Yes.
*
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-13 Message about copying the database to the project
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* *The Object Relational Designer now shows a visual representation of
* a class named Person, as shown in Figure 14-14. Notice that the class
* has properties named PersonID, Name, an Phone. The class is the entity
* class that represents a row in the Person table.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-14 The Person Class Created in the Object Relational 
* Designer
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* At this point, your project now has a data context class named 
* PhonelistDataContext. The PhonelistDataContext class contains table
* object property named Persons. (Notice the pluralization of the name.)
* The Persons object is a collection of Person objects. Each Person 
* object represents a row in the database table.
* 
* Step 7: Open the Form form in the Designer. The form, along with the 
* names of the important controls, was oreviously shown in Figure 14-15
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-15 The application's form at runtime-
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 8: Double-click any part of the form that does not contain a
* control. (Be sure not to click the ListBox control or the Button 
* control.)This opens the code editor, and you will see an empty event
* handler named Form1_Load.
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-5 Completed Form1 code for the Phonelist Names application
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* using System;
* using System.Windows.Forms;
* 
* namespave PhonelistNames
* {
*  public pertial class Form1 : Form
*  {
*   public Form1()
*   {
*       InitializeConponent();
*   }
*   
*   private void Form1_Load(object sender, EventArgs e)
*   {
*       // Create a Data Context object.
*       PhonelistDataContext db = new PhonelistDataContext();
*       
*       // Display all the names in the ListBox.
*       foreach(Person item in db.Persons)
*       {
*           personListBox.Items.Add(item.Name);
*       }
*   }
*   
*   private void closeButton_Click(object sender, EventArgs e)
*   {
*       //Close the form.
*       this.Close();
*   }
* }
*}
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Writing LINQ to SQL Queries
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In Tutorial 14-4 you used a simple foreach loop to iterate over a table
* object. However, the point of creating the LINQ to SQL classes is to
* use LINQ queries with the database! Using LINQ to retrieve data from a 
* database is just easy as using LINQ to reterieve data from a List or
* an array. Let's continue to use the Phonelist database (form Tutorial
* 14-4) as our example. The following code snippet creates a data 
* context object ans then uses a LINQ query to reterieve all the phone
* numbers from the Persons table object. The results are sorted by name.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* PhonelistDataContext db = new PhonelistDataContext();
* var results = from person in db.Persons
*               orderby person.Name
*               select person.Phone;
*               select person.Phone;'
*               
* foreach(string name in results)
* {
*   resultsListBox.Items.Add(name);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code shows another example. This code retrieves the
* phone numbers of all the rows in which the Name property contains
* "Smith":
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*  PhonelistDataContext db = new PhonelistDataContext();
* var results = from person in db.Persons
*               where person.Name.Contains("Smith")
*               select person.Phone;
*               
* foreach(string phin results)
* {
*   resultsListBox.Items.Add(ph);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In tutoeial 14-5, you will complete an application by connecting it 
* to a database, creating the LINQ to SQL classes needed to represent
* the database, and writing various LINQ queries to retrieve data from
* the database.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 14-5: Completing the Product Reports Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Recall that the ProductDB database has a table named Product with the
* following columns:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* -Product_Number - an nchar(5) column, primary key, containing a product number
* 
* -Description - an nvarchar(50) colum containing a product description 
* 
* -Units_On_Hand -an int column containing the numbers of units on hand
* 
* -Price -a money column containing the product's price
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The application's form os shown in Figure 14-16. The Button controls
* perform the following action:
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* -The priceGT100Button executes a LINQ query to get all the items from
* the database with Price greater than $100.
* 
* -The qtyGT100Button executes a LINQ query to get all the items from 
* the database with Units_On_Hand greater than 100.
* 
* -The priceLT100Button executes a LINQ query to get all the items from 
* the database with Price less than $100.
* 
* -The qtyLT100Button executes a LINQ query to get all the items from 
* the database with Units_On_Hand less than 100.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 1: Open the project named Project Reports in the Chap14 folder
* of this book's Student Sample Programs
* 
* Step 2: Open the Form1 form in the Designer. The form is shown, along
* with the names of the important conttrols, in Figure 14-16.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-16 The Product Reports Application Form1 Form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 3: Now you will create a connection to the ProductDB.mdf 
* database, which is in the Chap14 folder of this books's Student Sample
* Program
* 
* *If you do not see the Server Explorer window, click View on the menu
* bar, and then click Server Explorer.
* 
* *In the Server Explorer window, click the Connent to Database icon as
* previously shown in Figure 14-4.
* 
* *The Add Connection window should appear next, as previously shown in 
* Figure 14-7. Make sure Microsoft SQL Server Database File (SqlClient)
* is selected under Data Source.  Then click the Browse...button to 
* select the database file. Navigate to the Chap14\Databases folder of 
* the Student Sameple Program and select the ProductDB.mdf file.
* 
* *Click the Test Connection button to test the connection. You should 
* see the message Test Connection Succeeded. Click the OK button to 
* complete the connection.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 4: Now you will add the LINQ to SQL classes to the project. 
* Perform the following steps:
* 
*   *Click Project on the menu bar, then clock Add New Item...
*   
*   *The Add New item window appears next. Select Data in the left pane,
*   select LINQ to SQL Classes in the center pane, and change the name 
*   of the file to ProductDB.dbml. Click the Add button to add the 
*   classes to the project.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 5: Now you will use the Object Relational Designer to create 
* the classes you need to access the database.
* 
*   *The Object Relational Designer should be open. In the Server 
*   Explorer window, expand the PeoductDB.mdf entry, and then expand
*   the Tables Enrty.
*   
*   *Drag the Product table from the Server Explorer window and drop it
*   in the Object relational Designer. You will see a window displaying
*   a message indicating that you have selected a database file located
*   outside the prohjecy folder, and you are asked if you want to copy 
*   the project. Click Yes.
*   
*   *The Object Relational Designer now shows a visual representation 
*   of a class named Product, as shown in Figure 14-17. Notice that the
*   classes has properties named Product_Number, Description,
*   Units_On_Hand, and Price. This class is the entity class that
*   represents a row in the Product table.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-17 The Product class created in the Object 
* Relational Designer
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* At this point, your project now has a data context class named
* ProductDBDataContext. The PRoductDBDataContext class contains table
* object property named Products. (Notice the pluralization of the 
* name.) The Products object is a collection of Product objects. Each
* Product object represents a row in the database table.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 6: Open the Form1 form in the Designer. The form, along with the
* names of the important controls, was previously shown in Figure 14-16.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 7: Double-click the priceGT100Button control. This opents the 
* code editor, and you will see an empty event handler named 
* priceGT100Button_Click. Complete the priceGT100Button_Click event 
* handler by tying the code shown in lines 17-32 in Program 14-6. Let's
* take a closer look at the code:  
* 
* Line 18: This statement creates a ProductDBDataContext object named db.
* We chose the name db because the object represents the database. 
* 
* Lines 21-23: This statement executes a LINQ query that return the 
* descriptions of all the items in the db.Products collection with a 
* price greater than 100. The results of the query are assigned to the
* results variable.
* 
* Line 26: This foreach loop iterates over the query results and adds 
* each description to the descriptionListBox control.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 8: Open the Form1 for in the Designer and double-click the 
* priceLT100Button control. This operns the code editor, and you will
* see an empty event handler named priceLT100Button_Click.
* 
* Complete the priceLT100Button_Click event handler by typing the code
* shown in lines 37-52 in Program 14-6. Let's take a closer look at the
* code:
* 
* Line 38: This statement creates a PRoductDBDataContext object named 
* db. We chose the name db because the object represents the database.
* 
* Line 41-43: This statement executes a LINQ query that returns the 
* descriptions of all the items in the db.Products collection with a 
* price less than 100. The results of the query are assigned to the 
* results variable.
* 
* Line 46: This statement clears the contents of the descriptionListBox
* control.
* 
* Lines 49-52: This foreach loop iterates over the query results and
* adds each description to the descriptionListBox control.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 9: Open the Form1 form in the Designer and double-click the 
* qtgt100Button control. This opens the code editor, and you will see 
* an empty event handler named qtyGT100Button_Click.
* Complete the qtyGT100Button_Click event handler by typing the code
* shown in lines 57-72 in Program 14-6. Let's take a closer look at the
* code:
* 
* Line 58: This statement creates a PRoductDBDataContext object named
* db. We chose the name db because the object represents the database.
* 
* Lines 61-63: This statement executes a LINQ query that returns the 
* descriptions of all the items in the db.Products collection with 
* units on hand greater than 100. The results of the query are 
* assigned to the results variable.
* 
* Line 66: This statement clears the contents of the descriptionListBox
* control.
* 
* Lines 69-72: This foreach loop iterates over the query results and
* adds each description to the descriptionListBox control.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 10: Open the Form1 form in the Designer and double-click the 
* qtLT100Button control. This opens the code editor, and you will see 
* an empty event handLer named qtyLT100Button_Click. Complete the 
* qtyLT100Button_Click event handler by typing the code shown in lines
* 77-94 in Program 41-6. Let's take a closer look at the code:
* 
* Line 78: This statment creates a Program DBDataContext objecy named
* db. We chose the name db because the objecy represents the database.
* 
* Lines 81-83: This statement exeutes a LINQ queru that returns the descriptions
* of all the items in the db.products collection with units on hand less
* than 100. The results of teh query are assigned to teh results variable.
* 
* Line 86: This statement clears the contents of the descriptionListBox
* control.
* 
* Lines 89-92: This foreach loop iterates over the query results and adds
* each description to the descriptionListBox control
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 11:: Open the Form1 form in the Desigener and double-click the 
* closeButton control. This opents the code editor, and you will see an 
* empty event handler named closeButton_Click. Complete the 
* closeButton_Click event handler by typing the code shown in lines 97 
* and 98 in Program 14-6.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-18 The application's form at runtime
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-6 Completed Form1 code for the Product Resports application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* using System;
* using System.Data;
* using System.Linq;
* using System.Windows.Forms;
* using System.Windows.Forms;
* 
* namespace Product_Reports
* {
*   public partial class Form1 : Form
*   {
*       public Form1()
*       {
*           InitializeComponent();
*       }
*       
*       private void priceGT100Button_Click(object sender, EventArgs e)
*       {
*           // Create a data context object.
*           ProductDBDataContext db = new ProductDBDataContext();
*           
*           //Get the products with a price > 100.
*           var results = from product in db.Products
*                         where products.Price > 100m
*                        select product.Description;
*                        
*           // Clear the ListBox.
*           descirptionListBox.Items.Clear();
*           
*           // Display those products' descriptions.
*           foreach(string description in results)
*           {
*               descirptionListBox.Items.Add(description);
*           }
*       }
*       
*       private void priceLT100Button_Click(object senderm EventArgs e)
*       {
*           // Create a data context object
*           ProductDBDataContext db = new ProductDBDataContext();
*           
*           // Get the products with a price < 100.
*           var results = from products in db.Prducts
*                         where products in db.Products
*                         where products.Price < 100m
*                         select products.Description;
*                         
*           // Clear the ListBox.
*           descriptionListBox.Item.Clear();
*           
*            // Display those products' descriptions.
*           foreach(string description in results)
*           {
*               descirptionListBox.Items.Add(description);
*           }
*           
*       }
*       
*       private void qtgt100Button_Click(object sender, EventArgs e)
*       {
*           // Create a data context object
*           ProductDBDataContext db = new ProductDBDataContext();
*           
*           // Get the products with units on hand > 100.
*           var results = from products in db.Products
*                         where products.Units_On_Hand > 100
*                         select product.Description;
*                        
*                         
*           // Clear the ListBox.
*           descriptionListBox.Item.Clear();
*           
*            // Display those products' descriptions.
*           foreach(string description in results)
*           {
*               descirptionListBox.Items.Add(description);
*           }
*       }
*       
*        private void qtyLT100Button_Click(object sender, EventArgs e)
*       {
*           // Create a data context object
*           ProductDBDataContext db = new ProductDBDataContext();
*           
*           // Get the products with units on hand < 100.
*           var results = from products in db.Products
*                         where products.Units_On_Hand < 100
*                         select product.Description;
*                        
*                         
*           // Clear the ListBox.
*           descriptionListBox.Item.Clear();
*           
*            // Display those products' descriptions.
*           foreach(string description in results)
*           {
*               descirptionListBox.Items.Add(description);
*           }
*       }
*       
*       private void closeButton_Click(object sender, EventArgs e)
*       {
*           // Close the form.
*           this.Close();
*       }
*   }
*   
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Using LINQ Queries with Data-Bound Controls
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You learned in Chapter 12 that a data.bound controls is a user
* interface control that is connected to a data source. DAta-bound
* control is a user interface control that is connected to a data source.
* Data-bound controls automatically display data from the data source
* can be used to change the data that they are bound to. One of the 
* simplest and most powerful data-bound controls is the DataGridView
* controls. A DataGridView control can display an entire database table
* in a scrollable grid on an application's form.
* 
* /////////////////////////////////////////////////////////////////////
* Data-bound controls can also be used to display the results of a 
* LINQ query. These are the steps to follow if you want to use LINQ
* to query a database table, and then display those results in a data
* -bound control:
* 
* 1.In Visual Studio, connect the project to the database and use the
* Object Relational Designer to create an entity class for the table
* you wish to query.
* 
* 2.Add a new data source to the project, and select Object as the data
* source type.
* 
* 3.Select the entity class as the data object.
* 
* 4.In the Designer, open a form and create the desired data-bound
* control (such as a DataGridView).
* 
* 5.In code, write a LINQ query that returns a collection of objects that
* instances of the entity class you selected in step 3.
* 
* 6.Assign the result of the LINQ query to the data-bound control's 
* DataSource property.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You will pratice these steps in Tutorial 14-6. In the tutorial, you
* create an application that uses LINQ to query a database table, and
* display results in a DataGridView control.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 14-6: Completing the QueryDataSource Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this tutorial, you create an application that uses a DataGridView
* control to display the results of a LINQ query that is exectued on the 
* ProductDB database.
* 
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* In this tutorial, you create an application that uses a DataGridView
* controls to display the results of a LINQ query that is executed on
* the ProductDB database.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 1: Lanuch Visual Studio and start a new Windows Desktop Application
* projecy named Query Data Source. Set the Form1 form's Text property
* to Products.
* 
* Step 2: Create a connectioon to the PRoductDB.mdf databasem which is in
* the Chap14 folder of this book's Student Sample Program.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 3: In this step, you will add the LINQ to SQL classes to the 
* project, for which you need to perform the following steps:
* 
*       *Click Project on the menu bar, then click Add New Item....
*       *The Add new Item window appears next. Select Data in the
*       left pane, select LINQ to SQL Classes in the center pane, 
*       and change the name of the file to ProductDB.dbml. Click the
*       Add button to add the classes to the project.
*       
* Step 4: Now you will use the Object Relational Designer to create
*         the classes you need to access the database.
*         
*         *The Object Relational Designer should be open. In the 
*         Server Explorer window, expand the ProductDB.mdf entry,
*         and then expand the Tables Entry. 
*         
*         *Drag the Product table from the Server Explorer window and 
*         drop it in the Object Pelational Designer. You will see a
*         window displaying a message indicating that you have 
*         selected a database file location outside the program folder,
*         and you would be asked if you want to copy the file into the
*         project. Click Yes.
*         
*         *The Object Relational Designer now shows a visual 
*         representation of a class named Product. Notice that the class
*         has properties named Product_Number, Description, Units_On_Hand,
*         and Price. This class is the entity class that represents a row
*         in the Product table.
*         
* At this point, your project now has a data context class named 
* ProducyDBDataContext. THe ProductDBDataContext class contains table
* object property named Products. (Notice the plurialzation of the name.)
* The Products object is a colection of Product objects. Each Product
* object represents a row in the database table.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 5:Click the Save All button() to save the project.
* 
* Step 6: If the Data Sources window is not already opened, open it by
* selecting View > Other Windows...> Data Sources.
* 
* Step 7: In the DAta Soirces window, click the Add New Data Soruce button,
* as shown in Figure 14-19. This displays the Choose a Data Source Type
* window shown in Figure 14-20. Select Object and then click Next. 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-19 Add New Data Source
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-20 Choose a Data Source Type
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 8: The Select the Data Objects window, shown in Figure 14-21,
* appears next. Look at the figure carefully. Expand the 
* QueryDataSource entries as shown in the figure and select Product.
* This action selects the Product class (the entity class) that you 
* created in Step 4. Click Finsh. The Data Sources window should now
* appear as shown in Figure 14-22. Notice that the Product class is 
* shown as a data source.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-21 Select the Data Object
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-22 The updata Data Sources window
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 9: Open the Form1 form in the Designer.
* 
* Step 10: In the Data Soruces window, click the down arrow that 
* appears next to Product, and select DataGrdiView, as shown in 
* Figure 14-23. This selects the DataGridView controls as the default
* data-bound controls for the Product data source.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-23 Select DataGridView
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 11: Click and drag the Product data source from the Data 
* Sources window onto the form, as shown in Figure 14-24. This creates
* a DataGridView control on the form. Notice in the Properties window
* that the control's name. Adjust the size of the DataGridView control
* so you can see all the columns (Product_Number, Description, 
* Units_On_Hand, Price).
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-24 Creating the DataGridViewcontrols
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 12: Double-click any part of the form that does not contain
* a control. (Be sure not to click any part of the DataGridView control
* or its navigation bar.) This opens the code editor, and you will see 
* an empty event handler named Form1_Load. Complete the Form1_Load 
* event handler by typing the code shown in lines 17-27 in Program 14-7.
* Let's take a closer look at the code:
* 
* Line 18: This statement creates a data context object named db.
* 
* Lines 22 and 23: This statement executes a LINQ query on the 
* db.Products table collection. It retrieves all the Product objects
* from the table. At the database level, this causes all the rows in 
* the Product table to be retrieved. They are returned from the query
* as a collection of Product objects, and assigned to the results
* variable.
* 
* Line 27: This statement assigns the results variable to DataGridView
* control's DataSource property. As a results, the contents of the 
* results collection will be displayed in the DataGridView control's
* DataSource property. As a result, the contents of the results 
* collection will be displayed in the DataGridView.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 13: Open the Form1 form in the Designer and adjust the size of 
* the form and the position of the DataGridView control to appear 
* similar to Figure 14-25.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-25 The final appearance of the form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Step 14: Save the project. Then, press F5 on the keyboard or click 
* the Start Debugging (<|) on the toolbar to compile and run the 
* application. The application's form should appear as shown in 
* Figure 14-25. When you are finishedm click the close button to 
* close the application.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 14-26 The application's form at runtime
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 14-7 Completed Form1 code for the QueryDataSource application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* using System;
* using System.Data;
* using System.LINQ;
* using System.Windows.Forms;
* 
* namespace QueryDataSource
* {
*   public partial class Form1 : Form
*   {
*       public Form1()
*       {
*           InitializeComponent();
*       }
*       
*       private void Form1_Load(object sender, EventArgs e)
*       {
*           // Create a data context object.
*           ProductDBDataContext db = new ProductDBDataContext();
*           
*           // Get all the Product objects from the 
*           // Products collection.
*           var results = from product in db.Products
*                         select product;
*                         
*           // Assign the results of the query to the 
*           // DataGridView control.
*           
*           productDataGridView.DataSoruce = results;
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* Updating, Inserting, and Deleting Rows with LINQ
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In addition to retrieving rows from a database table, LINQ also 
* allows you to update rows, insert rows, and delete rows. In the 
* following examples, we will assume that we are working with the 
* PRoductDB database. Our data context class is named
* ProductDBDataContext, and it has a table property named Products.
* Our entity class is named Product.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The first example, shown below, gets the product with Product_Number
* set to 10-04. It changes the product's price to 99.99, and then 
* updates the database with the new row.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ProductDBDataContext db = new ProductDBDataContext();
* 
* Product prod = db.Products.FirstOrDefault(item => 
*                                           item.Product_Number 
*                                           == "10-04");
*                                           
* if(prod != null)
* {
*   prod.Price = 99.99m;
*   db.SubmitChanges();
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Let's take a closer look at the code. Linw 1 creates a data context
* object. Lines 3-4 use the FirstorDefault extension method to get the
* first item in the db.Products collection that has its Product_Number
* Property set to "10-04". If the item is found, it will be assigned
* to the prod variable. If is is not found, the prod variable will be
* set null. If prod is not set to null, the statement in line 8
* assigns 99.99 to its Price property, and the statement in line 9
* calls the db.SubmitChanges() to update the database with the new data.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code shows another example. In this example, the LINQ
* query in line 3-5 returns all of the products that have a 
* Product_Number property containing the string "10-". The foreach loop
* in lines 7-10 iterates over all the perducts that were returned from
* the query, changeing their Units_On_Hand property to 0. The statement
* in line 8 calls the db.SubmitChanges() to updata the database with
* the new data.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ProductDBDataContext db = new ProductDBDataContext();
* 
* var results = from prod in db.Products
*               where prod.Product_Number.Contains("10-")
*               select prod;
*               
* foreach(Product p in results)
* {
*   p.Units_On_Hand = 0;
* }
* 
* db.SubmitChanges();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following example shown a new row being inserted into the database
* table:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ProductDBDataContext db = new ProductDBDataContext();
* 
* Product prod = new Product();
* prod.Price_Number = "40-01";
* prod.Description = "Hiking Boots"
* prod.Units_On_Hand = 10;
* prod.Price = 299m;
* 
* db.Products.InertOnSubmit(prod);
* db.SubmitChanges();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this code lines 3-7 create an instance of the Product entity class
* and assign values to the object's properties. Line 9 calls the
* db.Products.InsertOnSubmit method, passing the object as an argument.
* When the db.SubmitChanges() method is called in line 10, the object
* is inserted into the database.
* 
* The following example shows how to delete an item from a database
* table:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ProductDBDataContext db = new ProductDBDataContext();
* 
* Product prod = db.Products.FirstOrDefault(item => item.Product_Number
* == "10-04");
* 
* if(prod != null)
* {
*   db.Products.DeleteOnSubmit(prod);
*   db.SubmitChanges();
* 
* }
* 
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Lines 3-4 use the FirstOrDefault extension method to get the first
* item in the db.Products collection that has its Product_Number proerty
* set to "10-4", If the item is found, it will be assigned to the prod
* variable. If it is not found, the prod variable will be set to null.
* If prod is not set to null, the statement in line 8 calls for the 
* db.Products.DeleteOnSubmit method, passing the prod object as an
* argument. When the db.SubmitChanges() method is called in line 9, the
* object is deleted from the database.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*/