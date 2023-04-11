/** 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *                            Chapter 9
 *          Structures, Enumerated Types, and Dictionaries
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Topics
 * 
 * 9.1 Introduction
 * 9.2 Structures
 * 9.3 The DataTime and TimeSpan Structures
 * 9.4 Enumerated Types
 * 9.5 Dictionaries
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *                          9.1 Introduction
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Now that you have studied the fundamentals of programming using 
 * Visual C#, you can use the topics presented in this chapter to perfrom
 * move adcanced operations. First, we discuss structures, which allows 
 * you to encapsulate several variables into a single item. After that 
 * we discuss enumerated types, whch are data types that can create, 
 * consisting of specified values. Last, we discuss dictionaries, which
 * are data structures for storing items known as key-value pairs. With
 * dictionary, you use a key to locate a specific value.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *                             9.2 Structures
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: C# allows you to group several variables together into a
 * single item known as a structure.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * So, far you have created application that keep data in individual 
 * variables. Sometimes, a relationship exists between different items
 * of data. For example, a used-car dealer's inventory system might use
 * the variables shown in the following declaration statements:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * string make; // The car's make
 * int year; // The car's year model
 * double milegae; // The car's mileage
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * All these variables are related because they will hold data about
 * the same car. Their declaration statements, however, do not make it 
 * clear that they belong together. TO create a relationship between
 * variables, C# gives you the ability to package them together into 
 * a single item known as a structure. A structure is a data type you
 * can create that contains one or more variables know as fields. The 
 * fields can be of different data types.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Before a structure can be used, it must be declared. Here is the 
 * general format that we use for declaring a structure:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * struct StructureName
 * {
 *      Field Declarations
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The First line of the structure declaration begins with the keyword
 * struct, followed by the structure name. A set of braces appears next,
 * and the braces contain one or more field declarations. Here is an 
 * example of a structure declaration:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  struct Automobile
 *  {
 *      public string make;
 *      public int year;
 *      public double mileage;
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  The name of this structure is Automobile. In this book we always
 *  begin structure with an uppercase letter. This is not required, by
 *  many programmers follows this practice because it helps distinguish
 *  structure names from variable names.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: Strctures in C# are capable of much more than we discuss in this
 * book. For ex, in addition to declaring fields you can also write
 * methods inside of structures. We use structure for more than this, you
 * should consider using a class instead. We discuss classes in Chapter 10.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Chapter 2, we dicussed the way that C# code is organized in
 * namespaces, classes, and methods.
 * Structure declarations can be written in a variety of places.
 * For ex, a structure declaration can appear in these locations:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Outside the application's namespace
 * 
 * *Inside the application's namespace
 * 
 * *Inside a class
 * 
 * *Inside another structure
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this book, we always declare structures inside an application's
 * namespace but not inside of a class. Figure 9-1 shows where, in a 
 * form's code, that we typically write structure declarations. In the
 * figure, we have written the declaration of the Automobile structure 
 * inside the application's namespace but not inside the Form1 class.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-1 Where we typically write structure declarations
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Keep in mind that a structure declaration does not create anything
 * in memory. It simply tells the C# compiler what the structure is made
 * of. Before you can use the structure to store data, you must create
 * an instance of the structure in memory. (In programming terms, an 
 * instance and an object are the same thing. When you create an instance
 * of a structure, you are creating an object.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * At the beginning of Chapter 7, we discussed value types and reference
 * types. Structures are value types, so creating an instance of a
 * structure is as simple as declaring a variable. For ex, suppose we
 * want to create an instance of the Automobile structure and we want
 * the name of the instance to be sportsCar. We would write this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Automobile sportsCar;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this statement executes, an instance of the Automobile
 * structure in exits in memory. The name of the instance is sportsCar.
 * As illustrated in Figure 9-2, the sportsCar object has three fields:
 * make, year, and mileage.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-2 The sportsCar object as an instance of the Automobile
 * structure.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can create multiple instances of a structure with a declatation
 * statement, as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Automobile sportsCar, pickupTruck;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement creates two instances of the Authmobile structure.
 * The objects are named sportsCar and pickupTruck. As illustrated in
 * Figure 9-3, each object has its own make, year, and mileage fields.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-3 Two instances of the Automobile structue
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Using the new Operator to Create Structure Instances
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you create a structure object with a simple declatation
 * statement, as previously shown, the object's fields are
 * uninitialized, and if you attempt to use any of them before assigning
 * them a value, a compiler error occurs.
 * As an alternative, you can use the new operator to create an instance
 * of a structure, as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Automobile sportsCar = new Automobile();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This is the recommended technique for creating structure instances
 * because the the new operator not only creates the instance in memory,
 * but it also initializes the object's fields with the default value of
 * 0. (If the structure contains any fields that are reference variables,
 * they are initialized with the special value null.) Here is an example
 * of creating two intences of the Automobile structure using the new
 * operator:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Automobile sportsCar = new Automobile();
 * Automobile pickupTruck = new Automobile();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * If you know the values that you wany to store in a structure's fields
 * at the time you instantiate the structure, you can use object initializer
 * syntax to initialize the object's fields. Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Automobile truck = new Automobile{make = "Dodge Ram",
 * year = 2014, 
 * mileage = 85000.0
 * };
 * /////////////////////////////////////////////////////////////////////
 * This statement creates an instance of the Automobile structure in 
 * memory. The object's name is truck. The object's fields will be
 * initialized with the following values: the make fields will be
 * initialized with the string "Dodge Ram," the year fields will be 
 * initialized with the value 2014, and the mileage field will be
 * initialized with the value 85000.0.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *                  Accessing a Structure's Fields
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Once you have created an instance of a structure, you can access its
 * fields using the dot operator (a period). For example, suppose an 
 * application contains the Sutomobile structure declaration previously
 * shown and the following code appears in a method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Automobile spotsCar = new Automobile();
 * sportsCar.make = "Ford Mustang";
 * sportsCar.year = 1965;
 * sports.mileage = 67500.0;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code shows another example using the same sportsCar
 * object. These statements display the values of the object's fields in 
 * message boxes.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * MessageBox.Show(sportsCar.make);
 * MessageBox.Show(sportsCar.year.ToString());
 * MessageBox.Show(sportsCar.mileage.ToString());
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following is another example. This statement displays a message
 * such as "1965 Ford Mustang with 67500 miles"
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * MessageBox.Show(sportsCar.year+ "" +sportsCar.mileage+
 * " with "+sportsCar.mileage + " miles.");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Assigning One Structure Object to Another
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the assignment operator (=) to assign one structure
 * object to another. For ex, assume that car1 and car2 are both
 * instances of the Automobile structure. The following statement assigns
 * car1 to car2:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * car2 = car1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this statement executes, the car2 object's fields contain the 
 * same values as the car1 object's fields
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Passing Structure Objects to Methods
 * /////////////////////////////////////////////////////////////////////
 *
 * /////////////////////////////////////////////////////////////////////
 * As with other types objects, you can pass a structure object as an
 * argument to a method. The following code shows a method named
 * DisplayAuto that has been written to accept an instance of the
 * Automobile structure as an argument:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void DisplayAuto(Automobile auto)
 * {
 *      MessageBox.Show(auto.year + " " + auto.make + " with "
 *      + auto.mileage + " miles.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice in line 1 the the method has a parameter variable named auto,
 * and its data type is Automobile. When we call this method, we pass an
 * Automobile object as an argument, as shown in the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create an instance of the Automobile structure.
 *  Automobile sportsCar = new Automobile();
 *  
 *  // Assign values to the object's fields.
 *  sportsCar.make = "Chevy Corvette";
 *  sportsCar.year = 1970;
 *  sportsCar.mileage = 50000.0;
 *  
 *  // Display the object's fields.
 *  DisplayAuto(sportsCar);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In line 10 the sportsCar object is passes as an argument to the
 * DisplayAuto method. Inside the DisplayAuto method, the auto parameter
 * contains a copy of the sportsCar object.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Structure objects can be passes by value or by reference. Normally,
 * structure objects are passes by value. The parameter variable contains
 * a copy of the argument, and any changes that are made to the parameter
 * do not affect the original argument. If the receiving method needs to
 * changes the contents of the original argument, however, the ref or out
 * the Automobile type. Assume that the application's form has TextBox
 * controls named makeTextBox, yearTextBox, and mileageTextBox.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void GetData(ref Automobile auto)
 * {
 *      try
 *      {
 *          // Get the data from the TextBoxes.
 *          auto.make = makeTextBox.Text;
 *          auto.year = int.Parse(yearTextBox.Text);
 *          auto.mileage = double.Parse(mileageTextBox.Text);
 *      }
 *      catch (Exception ex)
 *      {
 *          // Display the exception message.
 *          MessageBox.Show(ex.Message);
 *      }
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When we call this method, we pass an Automobile object by reference,
 * as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create an instance of the Automobile structure.
 *  Automobile car = new Automobile();
 *  
 *  // Get data for the object.
 *  GetData(ref car);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *                      Compating Structure Objects
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You cannot perfrom comparison operations directly on structure
 * objects. For example, assume that sportsCar and raceCar are instances
 * of the Automobile structure. The following statement will cause an 
 * error:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(sportsCar == raceCar) // Error
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In order to compare two structure objects, you must compare the 
 * individual fields, as shown in the follwing code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(sportsCar.make == raceCar.make && sportsCar.year == raceCar.year
 *                                   && sportsCar.year == raceCar.year)
 *    {
 *      MessageBox.Show("The two are equal.");
 *    }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Arrays of Structure Objects
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Structure objects can be stored in an array. For ex, assume the 
 * Automobile structure previously shown exitsts in an application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * const int SIZE = 5;
 * Automobile[] cars = new Aytomobile[SIZE];
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you create a structure array, each element of the array is a structure
 * instance and the fields of each instance are initialized to 0. 
 * (If any field is a reference variable, it is initialized to the value null.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Each element of a structure array may be accessed through a subscript.
 * For example, car[0] is the first obj in the array, cars[1] is the 
 * second, and so forth. To access a field of any element, simply place
 * the dot operator and field name after the subscript. For example, the 
 * following expression refers to the mileage member of cars[2]
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * cars[2].mileage
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following for loop steps through the cars array, displaying the
 * data stored in each element:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(int index = 0; index < cars.Length; index++)
 * {
 *      MessageBox.Show(cars[index].year + " "
 *      + cars[index].make + " with "
 *      + cars[index].mileage + " miles.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can also use the foreach loop to iterate over all of the elements
 * in a structure array, as shown in the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * foreach (Automobile aCar in cars)
 * {
 *      MessageBox.Show(aCar.year + " " 
 *      + aCar.make + " with "
 *      + aCar.mileage
 *      +" miles.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Storing Structure Objects in a List
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Chapter 7, we discussed the List class, which is a container for
 * storing a collection of objects. Here is an ex of how you would create
 * a List that can hold Automobile objects:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * List<Automobile> carList = new List<Automobile>();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement creates a List object, referenced by the carList
 * variable. Notice that the word Automobile is written inside angled
 * brackets, <>, immediately after the word List. This specifiees that
 * the List can hold only hold objects of the Automobile data type.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To add a structure object to a List, you use the Add method. The 
 * follwing code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create a List to hold Automobile objects.
 *  
 *  List<Automobile> carList = new List<Automobile>();
 *  
 *  // Create an instance of the Automobile structure.
 *  Automobile sportsCar = new Automobile();
 *  
 *  // Assign values to the object's fields
 *  sportsCar.make = "Chevy Corvette"
 *  sportsCar.year = 1970;
 *  sportsCar.mileage = 50000.0;
 *  
 *  // Add the object to the List
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Keep in mind that structure instances are value type objects, and 
 * when you add a value type object to a List, the List will contain a
 * copy of an object. For example, look at the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create a List to hold Automobile objects.
 *  List<Automobile> carList = new List<Automobile>();
 *  
 *  // Create an instance of the Automobile structure.
 *  Automobile sportsCar = new Automobile();
 *  
 *  // Assign values to the object's fields.
 *  sportsCar.make = "Chevy Corvette"
 *  sportsCar.year = 1970;
 *  sportsCar.mileage = 50000.0;
 *  
 *  // Add the object to the List
 *  carList.Add(sportsCar);
 *  
 *  // Assign new values to the object's fields
 *  SportsCar.make = "Ford Mustang";
 *  SportsCar.make = "1965";
 *  SportsCar.make = "65700.0";
 *  
 *  // Add the object to the List.
 *  carList.Add(sportsCar);
 *  
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-4 The Car List application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you run the application, you can enter data about a car into the 
 * TextBox controls. When you click the addButton control, that data is
 * assigned to an Automobile object and then added to a List. You can do
 * this as many times as you wish. When you click the displayButton
 * control, the data from each object in the List is displayed in the 
 * carListBox control. Figure 9-5 shows an example of the application's
 * form after four objects have been added to the List and the displayButton
 * control has been clicked.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-5 The Car List application's form with data displayed
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 9-1 Code for Form1 in the CarList application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ...
 * namespace Car_List
 * {
 *      struct Automobile
 *      {
 *          public string make;
 *          public int year;
 *          public double mileage;
 *      }
 *      
 *      public partial class Form1 : Form
 *      {
 *          // Create a List as a field.
 *          private List<Automobile> carList = new List<Automobile>();
 *          
 *          public Form1()
 *          {
 *              InitializeComponent();
 *          }
 *          
 *          // The GetData method gets the data entered
 *          // by the user and assignes it to the parameter
 *          // object's fields.
 *          
 *          private void GetData(ref Automobile auto)
 *          {
 *              try
 *              {
 *                  // Get the data from the TextBoxes.
 *                  auto.make = makeTextBox.Text;
 *                  auto.year = int.Parse(yearTextBox.Text);
 *                  auto.mileage = double.Parse(mileageTextBox.Text);
 *              }
 *              catch(Exception ex)
 *              {
 *                  // Display the exception message.
 *                  MessageBox.Show(ex.Message);
 *              }
 *          }
 *          
 *          private void addButton_Click(object sender, EventArgs e)
 *          {
 *              // Create an instance of the Automobile structure.
 *              Automobile car = new Automobile();
 *              
 *              // Get the data entered by the user.
 *              GetData(ref car);
 *              
 *              // Add the car object to the List.
 *              carList.Add(car);
 *              
 *              // Clear the TextBoxes.
 *              makeTextBox.Clear();
 *              yearTextBox.Clear();
 *              mileageTextBox.Clear();
 *              
 *              // Reset the focus.
 *              makeTextBox.Focus();
 *          }
 *          private void displayButton_Click(object sender, EventArgs e)
 *          {
 *              // Declare a string to hold a line of output.
 *              string output;
 *              
 *              // Clear the ListBox's current contents.
 *              carListBox.Items.Clear();
 *              
 *              // Display the car info in the ListBox.
 *              foreach (Automobile aCar in carList)
 *              {
 *                  // Make a line of output.
 *                  output = aCar.year + " "
 *                  + aCar.make 
 *                  +" with "
 *                  + aCar.mileage 
 *                  + " miles.";
 *                  
 *                  // Add the line of output to the ListBox.
 *                  carListBox.Items.Add(output);
 *              }
 *          }
 *      }
 *      
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Tutorial 9-1, you complete a phone book application that uses a 
 * List of strycture objects.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 9-1: Completing the PhoneBook Application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Phonebook application. When the 
 * application is complete, it will let you select a person's name from
 * a ListBox control, and then it will display that person's phone number.
 * Figure 9-6 shows an example of how the form will appear at run time.
 * In the figure, Kevin Brown has been selected in the ListBox control,
 * and Kevin's phone number is displayed in a Label control.
 * The application's form has already been created for you and is shown
 * in Figure 9-7 with the names of some of its controls.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-6 The Phonebook application's form with a name selected
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-7 The Phonebook application's form in the Designer
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Before you start writing code, let's go over a summary of how the 
 * application will work. A file named PhoneList.txt, containing several
 * names and corresponding phone nubmers, has been created for you.
 * (project's bin\debug folder.) its contents are shown in Figure 9-8.
 * Notice that each line in the file contains a name, followed by a comma,
 * followed by a phone number.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-8 The contents of the PhoneList.txt file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the applications starts, the form's Load event handler calls a 
 * method named ReadFile. The ReadFile method reads the contents of the 
 * PhoneList.txt file. Each line that is read from the file will be
 * tokenized, using the comma character as a delimiter. This will result
 * in two string tokens: one containing a person's name and the other
 * containing a phone number. The tokens are stored in an instance of 
 * the following PhoneBookEntry structure:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * struct PhoneBookEntry
 * {
 *      public string name;
 *      public string phone;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The PhoneBookEntry object is then added to a List. When the ReadFile
 * method is finished, the List will contain a PhoneBookEntry object for
 * each line in the PhoneList.txt file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Load event handler then calls another method named DisplayNames.
 * The DisplayNames methods steps through the List, getting the name
 * field of each object and adding the name to the ListBox control. When
 * the DisplayNames method is finished, the ListBox control will display
 * all the names that are contained in the List.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the user clicks a name in the ListBox control,
 * a SelctedIndexChanged event occurs. You are to write an event handler
 * that responds to this event. The event handler gets the index of the 
 * selected item in the ListBox control, and it uses that index to
 * retrieve an object from the List. The object contains the pone number
 * for the selected name, which is displayed in a Label control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-9 A summary of Lines 54-64
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-10 Objects in phoneList and names in nameListBox as related 
 * by their indexes
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: When the item in two data structures are related by their
 * indexes, it is said that a parallel relationship exists between the 
 * data structures.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 9-2 Completed code for Form1 in the Phonebook application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ...
 * namespace Phonebook
 * {
 *  struct PhoneBookEntry
 *  {
 *      public string name;
 *      public string phone;
 *  }
 *  
 *  public partial class Form1 : Form
 *  {
 *      // Field to hold a list of PhoneBooksEntry objects.
 *      private List<PhoneBookEntry> phoneList 
 *      = new List<PhoneBookEntry>();
 *      
 *      public Form1()
 *      {
 *          InitializeComponent();
 *      }
 *      
 *      // The ReadFile method reads the contents of the
 *      // PhoneList.txt file and stores it as PhoneBookEntry
 *      // objects in the phoneList
 *      
 *      private void readList()
 *      {
 *          try
 *          {
 *              StreamReader inputFile; // To read the file
 *              string line;    // To hold a line from the file
 *              
 *              // Create an instance of the PhoneBookEntry structure.
 *              
 *              PhoneBookEntry entry = new PhoneBookEntry();
 *              
 *              // Create a delimiter array
 *              char[] delim = {','};
 *              
 *              // Open the PhoneList file.
 *              inputFile = File.OpenText("PhoneList.txt");
 *              
 *              // Read the lines from the file.
 *              while(!inputFile.EndofStream)
 *              {
 *                  // Read a line from the file.
 *                  line = inputFile.ReadLine();
 *                  
 *                  // Tokenize the line 
 *                  string[] tokens = line.Split(delim);
 *                  
 *                  // Store the tokens in the entry object.
 *                  entry.name = tokens[0];
 *                  entry.phone = tokens[1];
 *                  
 *                  // Add the entry object to the List.
 *                  phoneList.Add(entry);
 *              }
 *          }
 *          catch (Exception ex)
 *          {
 *              // Display an error message
 *              MessageBox.Show(ex.Message);
 *          }
 *      }
 *      
 *      // The DisplayNames method displays the list of names
 *      // in the namesListBox control.
 *      private void DisplayNames()
 *      {
 *          foreach(PhoneBookEntry entry in phoneList)
 *          {
 *              nameListBox.Items.Add(entry.name);
 *          }
 *      }
 *  
 *  
 *  private void Form1_Load(object sender, EventArgs e)
 *  {
 *      // Read the PhoneList.txt file.
 *      ReadFile();
 *      
 *      // Display the names.
 *      DisplayNames();
 *  }
 *  
 *  private void nameListBos_SelectedIndexChanged(object sender, EventArgs e)
 *  {
 *      // Get the index of the selected item.
 *      int index = nameListBox.SelectedIndex;
 *      
 *      // Display the correspoding phone number.
 *      phoneLabel.Text = phoneList[index].phone;
 *  }
 *  
 *  privatevoid exitButton_Click(object sender, EventArgs e)
 *  {
 *      // Close the form
 *      this.Close();
 *  }
 *  
 * }
 *
 *}
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 9.3 The DataTime and TimeSpan Structures
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: In the .NET Framework, the DateTime structure stores a date,
 * a time, or both. The TimeSpan structure stores information about a
 * time interval.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The DataTime structure, which is defined in the .NET Framework,
 * allows you to create objects that store data avout an instant in time.
 * A DateTime object object both data and time. Internally, the data and
 * time values are stored in the following properties:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Month-an integer in the range of 1-12
 * *Day-an integer in the range of 1-31
 * *Year-an integer in the range of 1-9999
 * *Hour-an integerin the range of 0-23
 * *Minute-an integer in the range of 0-59
 * *Second-an integer in the range of 0-59
 * *Millisecond-an integer in the range of 0-999
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that the Hour property is set according to the 24-hour clock.
 * For example, the hour 1 is 1:00AM, and the hour 13 is 1:00PM.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * There are several ways to create an instance of the DataTime
 * structure. The follwing statement creates a DataTime instance named
 * dt, set to default data January 1, 0001 and the default time 12:00:00 AM,
 * 0 milliseconds:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DataTime();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can change the individual data and time properties as shown in 
 * the following code sample:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DataTime dt = new DataTime();
 * dt.Month = 12;
 * dt.Day = 15;
 * dt.Year = 2019;
 * dt.Hour = 13;
 * dt.Minute = 30;
 * dt.Second = 0;
 * dt.Millisecond = 0;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this example, the dt instance is set to the data December 15, 2019
 * and the time 1:00:00 PM.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you create a DateTime instance, you can optionally initialize it 
 * with specific data, time, or both. Here are the general formats:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime instanceName = new DateTime(Year, Month, Day);
 * 
 * DateTime instanceName = new DateTime(Year, Month, Day, Hour, Minute,
 * Second);
 * 
 * DateTime instanceName = new DateTime(Year, Month, Day, Hour, Minute,
 * Second,Millisecond);
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The values for Year, Month, Day, Hour, Minute, Second, and
 * Millisecond are integers. The following example creates DateTime instance
 * named dt, set to the data November 5, 2000. The Hour, Minute, Second,
 * and Millisecond properties are set to the default value of 0, which is
 * midnight:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DateTime(2000,11,5);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following example creates a DateTime instance named dt, sets to the 
 * data November 5, 2000, and the time 8:30 AM. The Second property is 
 * set to 15, and the Millisecond property is set to the default value of
 * 0:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DateTime(2000, 11,5,8,30,15)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following example creates a DateTime instance named dt, sets to the 
 * data November 5, 2000, and the time 8:30 AM. The Second property is 
 * set to 15, and the Millisecond property is set to 500:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DateTime(2000, 11,5,8,30,15,500);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Displaying a DateTime Object
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can retrieve any of a DateTime object's individua; properties and
 * use them in your program's output. For example, the following code
 * sample display a message using the DateTime object's Month and Year 
 * properties:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DateTime(2000, 11, 5);
 * MessageBox.Show(dt.Month.ToString() + ", " + dt.Year.ToString());
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In many cases, the easiest way to display a DateTime object is to 
 * call its ToString method. You can use format string to format it as 
 * a short data, long date, short time, long time, and so on. Table 9-1
 * lists the most commonly uses format strings for dates and times.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Table 9-1 Common DateTime format strings used with the ToString
 * method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code sample shows an example of the long time format.
 * When this code runs, the string 8:30:15 AM will be displayed in a 
 * message box:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DateTime(200, 11, 5, 8, 30, 15, 500);
 * MessageBox.Show(dt.ToString("T"));
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code sample shows an example of the full data and time
 * format. When this code runs, the stringSunday, November 5, 2000
 * 8:30:15 AM will be displayed in a message box:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime dt = new DateTime(2000, 11,5,8,30,15,500);
 * MessageBox.Show(dt.ToString("F"));
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The DateTime structure also supports the following methods for 
 * formatting.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *ToShortDateString()-Returns the data formatted as a short data, which is the same as ToString("d")
 * 
 * *ToLongDateString()-Returns the data formatted as a long data, which is the same as ToString("D")
 * 
 * *ToShortTimeString()-Returns the data formatted as a short time, which is the same as ToString("t")
 * 
 * *ToLongTimeString()-Returns the data formatted as a short time, which is the same as ToString("D")
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Getting the Current Date and Time from the System
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The expression DateTime.Now gives you the current data and time from
 * the system. Here is an example of how you can assign the system's
 * current date and time to a DateTime variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime currentDateTime = DateTime.Now;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The expression DateTime.Today gives you the current date, but not the 
 * time. Here is an example of how you can assign the current date to a
 * DateTime variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime currentDate = DateTime.Today;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this statement is executed, the currentDate object will be set
 * to the current date, but the object's time properties will be set 
 * to the default value of 12:00 AM.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Converting String to DateTime Structures
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You are already familiar with the TryParse method, and how to use it 
 * to convert to convert a string to a DateTime object.
 * Here is the general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DateTime.TryParse(string, out targetVariable)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the general format, string is the string that you want to convert,
 * and the targetVariable is the name of a DateTime object. The method
 * tryes to convert the string argument to a DateTime
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-11 The DateTimePicker control
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-12 The DateTime Demoi application form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-13 The DateTime Demo application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 9-3 The DateTime Demo application's Form1 code
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 9-3 The DateTime Demo application's Form1 code
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace DeteTime_Demo
 * {
 *      public partial class Form1: Form
 *      {
 *          public Form1()
 *          {
 *              InitializeComponent();
 *          }
 *          
 *          private void myDateTimePicker_ValueChanged(object sender, EventArgs e)
 *          {
 *              // Get the date selected by the user.
 *              DateTime selected = myDateTimePicker.Value;
 *              
 *              // Display the date.
 *              dateLabel.Text = selected.ToString("F");
 *          }
 *      }
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *                     Comparing DateTime Objects
 * /////////////////////////////////////////////////////////////////////
 * Note: this is somthing that java cannot do, when you use the comparision 
 * operator in java in order for it to return true, the object must be 
 * the exact same as object that is comparing.
 * /////////////////////////////////////////////////////////////////////
 * You can use C#'s relational operators to compare two DateTime objects
 * , and determine whether one of the objects is later than, earlier than,
 * or equal to the other object. When used with DateTime objects, the
 * reational operators work like this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Suppose we have the following setucture declaration in a program:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * struct Person
 * {
 *  public string name;
 *  public DateTime birthdate;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create the person1 object.
 *  Person person1 = new Person();
 *  person1.name = "Emily";
 *  person1.birthdate = new DateTime(1996, 10, 7);
 *  
 *  // Create the person2 object.
 *  Person2.name = "Dave";
 *  person2.birthday = new DateTime(1994, 4,12);
 *  
 *  // Determine who is the oldest.
 *  if(person1.birthdate > person2.birthdate)
 *  {
 *      MessageBox.Show(person2.name + " is older than " + person1.name);
 *  }else if (person2.birthdate > person1.birthdate)
 *  {
 *  MessageBox.Show(person1.name + " is older than " + person2.name);
 *  }
 *  else if(person1.birthday == person2.birthdate)
 *  {
 *      MessageBox.Show(person1.name, + " is the same age as " 
 *      + person2.name);
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The TimeSpan Structure
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The TimeSpan structure allows you to create objects that store about
 * an ammount of time, such as five days, or 20 hours.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A TimeSpan object stores time values in the following properties:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Days-an integer, positive or nagative
 * Hours-an integer in the range of -23 through 23
 * Minutes-an integer in the range of -59 through 59
 * Seconds-an integer in the range of -59 through 59
 * Milliseconds-an integer in the range of -999 through 999
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * There are several ways to create an instance of the TimeSpan
 * structure. The following statements creates a TimeSpan instance named
 * tspan, set to the default value of 0 days, 0 hours, 0 mines, 0 seconds
 * , and 0 milliseconds:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * TimeSpan tspan = new TimeSpan();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can change the individual properties as shown in the following
 * code sample:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * TimeSpan tspan = new TimeSpan();
 * tspan.Days = 15;
 * tspan.Hours = 6;
 * tspan.Minutes = 30;
 * tspan.Seconds = 10;
 * tspan.Milliseconds = 500;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * the tspan object is set to 15 days, 6 hours, 30 minutes, 10 seconds,
 * and 500 milliseconds.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you create a TimeSpan object, you can optionally initialize it 
 * with specific values. Here are three general formats:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * TimeSpan instanceName = new TimeSpan(Hours, Minutes, Seconds);
 * TimeSpan instanceName = new TimeSpan(Days, Hours, Minutes, Seconds);
 * TimeSpan instanceName = new TimeSpan(Days, Hours, Minutes, Seconds,
 * Mulliseconds);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * in the general formats, the values for Days, Hours, Minutes, Seconds,
 * and Muilliseconds are integers.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Performing Math with DateTime and TimeSpan Objects
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can perform math with DateTime and TimeSpan objects in the following
 * ways:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *You can add a TimeSpan to a DateTime object to get another DateTime
 * objects that is later than the first object. For example, suppose we
 * have a DateTime object that is set to April 5, and we have a TimeSpan
 * object is set to 10 days. If we add the TimeSpan object to the DateTime
 * object, we will get another DateTime objects that is set to April 15.
 * 
 * *You can subtract one DateTime object from another DateTime object to 
 * get a TimeSpan object repersenting the amount of time between the two
 * DateTime objects. For ex, suppose we have a DateTime object that is 
 * set to January 20, and we subtract from it another DateTime object
 * that is set to January 15. The result would be a TimeSpan object that
 * is set to 5 days.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is an example of how we can create a TimeSpan object that 
 * repersents 10 days, and then add that object to a DateTime object:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create a DateTime object for Augest 15, 2019.
 *  DateTime dt = new DateTime(2019, 8, 15);
 *  
 *  // Create a TimeSpan object for 10 days.
 *  TimeSpan tspan = new TimeSpan(10,0,0,0);
 *  
 *  // Add the TimeSpan object to the DateTime object.
 *  DateTime futureDate = dt + tspan;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code sample shows how we can subtract one DateTime object
 * from another DateTime object. The result is a TimeSpan object
 * repersenting the amount of time between the two DateTime object:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create two DateTime objects.
 *  DateTime date1 = new DateTime(2019, 8, 15);
 *  DateTime date2 = new DateTime(2019, 8, 30);
 *  
 *  // Get the amount of time between the two dates.
 *  TimeSpan tspan = date2 - date1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this code is executed, the tspan object will be set to 15 days.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Table 9-2 shows several methods that you can also use to mathematically
 * adjust the value of a DateTime object.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Table 9-2 DateTime math methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *                      9.4 Enumerated Types
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: An enumerated data type is a programmer-defined date type.
 * It consists of predefined constants, know as enumerators, that repersent
 * integer values.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Sometimes, in a program, you need a way to repesent values that 
 * cannot be stored in memory in a straightforward manner. For ex,
 * suppose you use writing a program that works with the days of the 
 * week (Sunday, Monday, Tuesday, etc,), and you need some way to
 * repersent each day of the week in memory. One solutuion is to let the 
 * integers 0 through 6 repersent the days of the week; 0 could represent
 * Sunday, 1 could repersent Monday, and so forth. Although this approach
 * will work, it has some drawbacks.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for ex, it may not be clear to anyone else reading the code that the
 * values 0 through 6 repersent the days of the week. Also, you might 
 * decide that Sunday is the first day of the week, whereas someone
 * else assumes that Monday is the first day of the week. When that other
 * person sees the value 0, he or she might think it repersents Monday.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A better solution for dealing with this type of data is to create an
 * enumerated data type. An enumerated data type is a data type that can
 * create. When you create an enumerated data type, you specify a set of 
 * symbolic values that belong to that data type. Here is an example of 
 * an enumerated data type declaration:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * enum Day{Sunday, Monday, Tuesday, Wednesday, Thursday, Firday,
 * Saturday}
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * An enumerated data type declaration begins with the keyword enum,
 * followed by the name of the type, followed by a list of identifiers
 * inside braces. The example declaration creates an enumerated data type
 * named Day. The identifiers Sunday, Monday, Tuesday, Wednesday,
 * Thursday, Friday, and Saturday, which are listed inside the braces,
 * are known as enumerators. They repersent the values that belong
 * to the Day data type.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: Notice that the enumerators are not enclosed in qoutation marks;
 * therefore, they are not strings. Enumerators must be legal C#
 * identifiers.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The enumerators are constants that represent integer values. When you
 * declare an enumerated type, the enumerators are assigned integer
 * values, sstarting with 0. For ex, in the Day data type, the Day.Sunday
 * enumerator is assigned the value 0, and so forth.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * An enum declaration can appear in any of the following places:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Outside the application's namespace
 * 
 * *Inside the application's namespace
 * 
 * *Inside a class
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * in this book we always write enum declarations in the same region we
 * write structure declarations: inside an application's namespace but 
 * not inside a class.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Once you have created an enumerated data type in your program, you 
 * can declare variable of that type. For example, the following statement
 * declares workDay as a variable of the Day type:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day workDay;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We refer to this as an enum variable. Because workDay is a variable
 * of the Day type, the values that we can assign to it are the Day
 * type's enumerators. For ex, the following statement assigns the 
 * value Day.Wednesday to the workDAy variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * workDay = Day.Wednesday;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that we assigned Day.Wednesday instead of just Wednesday. The
 * name Day.Wednesday is the fully qualified name of the Day type's
 * Wednesday enumerator. You have to use an enumerator's fully qualified
 * name because it is possible to have the same enumerator appear in 
 * multiple enumerated types. Here is another example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day weekendDay = Day.Saturday;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement declares a Day variable named weekendDay and
 * initializes it with the value Day.Saturday.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code shows another example.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day selectedDay;
 * if (mondayRadioButton.Checked)
 * {
 *      selectedDay = Day.Monday;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can make comparisons with enum variables and enumerators. The 
 * following code shows an example.
 * (Assunme selectedDAy is a Day variable)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(selectedDay==Day.Wednesday)
 * {
 *      MessageBox.Show("Halfway through the week!");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code shows how an enum variable can be tested in a 
 * switch statement.(Assunme selectedDAy is a Day variable)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * switch (selectedDay)
 * {
 *      case Day.Sunday:
 *          MessageBox.Show("Rest.");
 *          break;
 *     
 *     case Day.Monday:
 *          MessageBox.Show("Back to work.");
 *          break;
 *     
 *     case Day.Tuesday:
 *          MessageBox.Show("Just a regulare work day.");
 *          break;
 *     
 *     case Day.Wednesday:
 *          MessageBox.Show("Halfway through the week");
 *          break;
 *    
 *    case Day.Thursday:
 *          MessageBox.Show("Almost there.");
 *          break;
 *     
 *     case Day.Firday:
 *          MessageBox.Show("Last day!");
 *          break;
 *     
 *     case Day.Saturday:
 *          MessageBox.Show("Sleep late today.");
 *          break;
 *     
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * Using an Enumerator's or enum Variable's ToString Method
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Enumerators and enum variables have a ToString method. When you call
 * an enumerator's ToString method, it returns the name of the enumerator
 * as a string. For example, the following code will display the string
 * "Sunday" in a message box:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * MessageBox.Show(Day.Sunday.ToString());
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call an enum variable's ToString method, it returns the 
 * value that the variable contains, as a string. For example,
 * the following code will display the string "Thursday" in a message box:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day today = Day.Thrusday;
 * MessageBox.Show(today.ToString());
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you use the + operator with a string and an enum, the enum
 * variable's ToString method is implicitly called. (The same thing
 * happens when you use the + operator with an int variable. The int
 * variable's ToString method is imokucuty called.) Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day today = Day.Thursday;
 * MessageBox.Show("Today is" + today);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This code will display the string "Today is Thursday" in a message box.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 9-2 Completing the Color Spectrum Application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The mnemonic ROY G BIV is commonly used to help remember the following
 * sequence of colors of the visible spectrum:
 * red, organge, yellow, green, blue, indigo, and vilot. In this tutorial
 * you complete the Color Spectrum application, which shows these colors. 
 * The application will display the name of a color you click it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The application's form, which has already been created, is shown in
 * figure 9-14. The colors are actully a set of Label controls with 
 * their BackColor properties set to the appropriate color.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-14 The Color Spectrum application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Color_Spectrum
 * {
 *  enum Spectrum
 *  {
 *      Red, Orange, Yellow, Green,
 *      Blue, Indigo, Violet
 *  }
 *  
 *  public partial class Form1 : Form
 *  {
 *      public Form1()
 *      {
 *          InitializeComponent();
 *      }
 *      
 *      // The DisplayColor method display the 
 *      // name of a color.
 *      
 *      private void Display Color(Spectrum color)
 *      {
 *          colorLabel.Text = color.ToString();
 *      }
 *      
 *      private void redLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrum.Red);
 *      }
 *      
 *      private void orangeLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrum.Orange);
 *      }
 *      
 *      private void yellowLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrum.Yellow);
 *      }
 *      
 *      private void greenLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrm.Green);
 *      }
 *      
 *      private void blueLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrm.Blue);
 *      }
 *      
 *       private void indigoLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrum.Indigo);
 *      }
 *      
 *        private void violetLabel_Click(object sender, EventArgs e)
 *      {
 *          DisplayColor(Spectrum.Violet);
 *      }
 *  }
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Getting an Enumerator's or enum Variable's Integer Value
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You cannot assign an enumerator directly to an int variable, but you
 * can cenert an enumerator to its underlying integer type by using a
 * case operator.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int value = (int)Day.Friday;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement declares an int variable named value and initializes
 * it with the integer value of Day.Firday. After this statement 
 * executes, value will equal 5. Here is another ex:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day workDay = Day.Monday;
 * int value = (int)workDay;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement declares a Day variable named workDay,
 * initialized with Day.Monday. The second statement declares an in 
 * declares an int variable named value and initializes it with the
 * integer value of the workDay variable. After this statement executes,
 * value will equal 1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Specifying Integer Values for Enumerators
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * by default, the enumerators in an enumerated data type are assigned
 * the integer values 0,1,2, and so forth. If this is not appropriate,
 * you can specify the values to be assigned, as in the following
 * example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * enum Water { Freezing = 32, Boiling = 212}
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The integer values that you assign to enumerators do not have to be 
 * unique. For ex, the following code shows an enumerated type named
 * MonthDays. It enumerators are January, February, March, and so forth.
 * Notice that the values assigned to the enumerators are the days of the
 * months (January has 31 days, February has 28 days, etc.). This data
 * type might appear in an application that uses the days of each 
 * month.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * enum MonthDays
 * {
 *    January = 31. February = 28, March = 31,
 *    April = 30, May = 31, June = 30,
 *    July = 31, August = 31, September = 30,
 *    October = 31, November = 30, December = 31
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Comparing Enumerators and enum Variables
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Previously you saw that enumerators and enum variables can be 
 * compared using the equality operator(==). You can also compare
 * enumerators and enum variables with the other relational operators.
 * For ex, using the Day data type we have been discussing,
 * the following expression is true:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day.Firday > Day.Monday
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The expression is true because the enumerator Day.Firday is stored
 * in memory as 5 enumerator Day.Monday is stored as 1. The following
 * code displays the message "Firday is greater than Monday"
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(Day.Friday > Day.Monday)
 * {
 *  MessageBox.Show("Friday is greater than Monday");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code shows another example that compares two enum
 * variables. This code displays the message "Friday is greater than 
 * Monday."
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Day day1 = Day.Firday;
 * Day day2 = Day.Monday;
 * 
 * if(day1 > day2)
 * {
 *  MessageBox.Show(day1 + " is greater than " + day2);
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Enumerators and enum variables can be compared directly with integer
 * values. For example, the following code displays the message 
 * "Sunday is equal to zero."
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(Day.Sunday == 0)
 * {
 *  MessageBox.Show("Sunday is equal to zero.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Using an enum Variable to Step through an Array's Elements
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because enumerators represent integer values, they can be used in a 
 * loop to step through the elements of an array. For example, loop at
 * the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * decimal[] sales = {1000, 2000, 3000, 4000, 5000, 6000, 7000};
 * 
 * for(Day dayCount = Day.Sunday; dayCount <= Day.Saturday; dayCount++)
 * {
 *  MessageBox.Show("Sales for " + dayCount + " were " + sales[(int)dayCount].ToString("c"));
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Lines 1 and 2 create a decimal array named sales. The for loop that
 * begins in line 4 uses an enum variable named dayCount as its counter 
 * variable. Notice the following about the loop:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  * The dayCount variable is initialized with the value Day.Sunday.
 *  
 *  * The loop iterates as long as dayCount is less than or equal to
 *    Day.Saturday.
 *  
 *  *At the end of each iteration, dayCount is incremented.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In line 7 the expression (int)dayCount is used as an array subscript.
 * As the loop executes, it displays the following messages:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * "Sales for Sunday were $1,000.00"
 * * "Sales for Monday were $1,000.00"
 * * "Sales for Tuesday were $1,000.00"
 * * "Sales for Wednesday were $1,000.00"
 * * "Sales for Thursday were $1,000.00"
 * * "Sales for Friday were $1,000.00"
 * * "Sales for Saturday were $1,000.00"
 * 
 *
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *                      9.5 Dictionaries
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: A dictionary is an object that stores a collection of data.
 * Each element in a dictionary has two parts: a key and a value. Each
 * key is associated with a specific value and can be used to locate 
 * that value.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you hear the word "dictionary," you probably think about a large 
 * book such as the Merriam-Webster dictionary, containing words and 
 * their definitions. If you want to know the meaning of a particular
 * word, you locate it in the dictionary to find its definition.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In programming, a dictionary is an object that stores a collection
 * of data. Each element that is stored in a dictionary has two
 * parts: a key and a value. In fact, dictionary elements are commonly
 * referred to as key-value pairs. When you want to retrieve a specific
 * value from a dictionary, you use the key that is associated with 
 * that value. This is similar to the process of looking up a word in 
 * Merriam-Webster dictionary, where the words are keys and
 * definitions are values.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * For ex, suppiose each employee in a company has an ID number, and we
 * want to write a program that lets us look up an employee's name by
 * entering that employee's ID number. We could create a dictionary in 
 * which each element contains an employee ID number as the key and that
 * employee's name as the value. This is illustrated in Figure 9-15. If
 * we know an employee's ID number, then we can retrieve that
 * employee's name.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-15 Key-value pairs
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Another example would be a program that lets us enter a peron's
 * name and gives us that person's phone number. The program could use a
 * dictionary in which each element contains a person's name as the key
 * and that person's phone number as the value. If we know a person's
 * name, then we can retrieve that person's phone number.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Dictionary Class
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The .NET Framework provides a Dictionary class that you can use to 
 * implement a dictionary container in your programs. The Dictionary
 * class provides many methods for storing elements, retrieving elements,
 * deleting elements, iterating over the dictionary, and much more.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To use the Dictionary class, you need the following using statement
 * in the program:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * using System.Collections.Generics;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Then, you can declare a Dictionary object. Here is the general format
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<KeyType, ValueType> DName = Dictionary<KeyType, ValueType>
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *     where:
 *     *KeyType is the data type of each element's key
 *     
 *     *ValueType is the data type of each element's value
 *     
 *     *DName is the name of the Dictionary
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is an example of how you might declare a Dictionary to hold 
 * employees ID numbers (as int s) and their corresponding employee
 * names (as string s):
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement declares a Dictionary named employees. Inside the 
 * angled brackets <>, the first data type(int) is the type of each key,
 * which in this case are the employeee ID number. The second data type
 * (string) is the type of the corresponding values, which in this case 
 * are the employee names. So, each element of this Dictionary will be
 * a key-value pair where the key is an int and the value is a string.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * If you are delaring a Dictionary variable locally inside a method, you
 * can simplify the declaration with the var keyword, as shown here
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * var employees = new Dictionary<int, string>();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The keys in a Dictionary must be unique. No two elements in a
 * Dictionary can have the same key value.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Initializing a Dictionary
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can initialize a Dictionary with an initialization list.
 * The following code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary <int, string> employees = new Dictionary<int, string>()
 * {
 *  {101, "Chris Jones"},
 *  {102, "Chris Jones"},
 *  {103, "Chris Jones"},
 *  {104, "Chris Jones"},
 * };
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice the following aspects of the initalization list:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * The initialization list is enclosed in a set of curly braces {};
 * 
 * *Each element is enclosed in its own set of curly braces, with the key
 *  and the value separated by a comma;
 * 
 * *The elements are separated by commas;
 * 
 * *After the last curly brace, the declaration ends with a semicolon.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * As previously mentioned, the keys in a Dictionary must be unique. 
 * two or more elements in an initialization list have the same key, an
 * exception will occur at runtime.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Adding Elements to an Existing Dictionary
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can add an element to a Dictionary with an assignment in the
 * following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * dictionaryName[key] = value;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the general format, dictionaryName is the name of the Dictionary,
 * and key is a key. If key already exists in the Dictionary, its
 * associated value will be changed to value. If the key does not exist,
 * it will be added to the Dictionary, along with value as its associated
 * value. The follwing code shows an example:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement creates an empty Dictionary named employees. The
 * statements that follow then add the following elements to the
 * Dictionary:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *      *Key=110, Value = "Beth Young"
 *      
 *      *Key=111, Value = "Jake Brown"
 *      
 *      *Key=112, Value = "Emily Davis"
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Remember that the keys in a Dictionary must be unique. If you assign
 * a new value to an existing key, the new value will replace the 
 * previously stored value. For example, look at the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>();
 * employees[110] = "Beth Young";
 * employees[110] = "Jake Brown";
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement creates an empty Dictionary named employees. The
 * second statement adds an element with the key 110 and the value 
 * "Beth Young". The third statement assigns the value "Jake Brown" to
 * the element with the key 110.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Adding Elements with the Add Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IN addition to using the [] operator, you can also use the Add method
 * to add an element to a Dictionary. Here is the general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * dictionaryName.Add(key, value);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the general format, dictionaryName is the same of the Dictionary,
 * and the key is a key. If the key does not exist, it will be added to the
 * Dictionary, along with value as its associated value. If key already
 * exists in the Dictionary, an exception will be thrown. The follwwing
 * code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>();
 * employees.Add(110, "Beth Young");
 * employees.Add(111, "Jake Brown");
 * employees.Add(112, "Emily Davis");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement creates an empty Dictionary named employees.
 * The statements that follow then add the follwing elements to the 
 * Dictionary:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Retrieving Values from a Dictionary
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To retrieve a value from a Dictionary, you can use an expression in 
 * the following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * dictionaryName[key]
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the general format, dictionaryName is the variable that 
 * references the Dictionary, and the key is a key. If the key exists in
 * the Dictionary, the expression returns the value that is associated
 * with the key. If the key does not exist, an exception will occur. The
 * following code snippet demonstrates.
 * /////////////////////////////////////////////////////////////////////
  * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>();
 * employees[101] = "Chris Jones";
 * employees[102] = "Jessica Smith";
 * employees[103] = "Amanda Stevens
 * employees[104] = "Will Osborn";
 * 
 *  // Display the elements 
 *  for(int key = 101; key < 105; key++)
 *  {
 *      employeesListBox.Items.Add(employees[key]);
 *  }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  Removing Elements
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can remove an element from a Dictionary using the Remove method.
 * You call the Remove method, passing the key that is associated with 
 * the element you want to remove. The following code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>();
 * 
 *  // Add elements to the Dictionary
 *  
 *  employees[101] = "Chris Jones";
 *  employees[102] = "Jessica Smith";
 *  employees[103] = "Amanda Stevens";
 *  employees[104] = "Will Osborn";
 *  
 *  // Delete the emplyee with the user ID 102
 *  employees.Remove(102);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Remove method returns true if the specified element was
 * successfully removed, or false if it was not found. Here is an example
 * of using the returned value to determine whether an element was
 * removed:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(!employees.Remove(102))
 * {
 *  MessageLabel.Text = "Element not found";
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Iterating over a Dictionary with the foreach Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When an element is stored in a Dictionary, it is stored as an object
 * of the KeyValuePair type. The KeyValuePair type is a struct that has
 * two properties: Key and Value. The element's Key is stored in the Key
 * propery, and the element's value is stored in the Value property.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the Foreach loop to iterate over all the KeyValuePair 
 * elements in a Dictionary. The following code shows an example of
 * how to display all of the elements in a Dictionary. Assume this code 
 * is in an application that has a ListBox control named emplyeesListBox.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>()
 * {
 *  {101, "Chris Jones"},
 *  {102, "Jessica Smith"},
 *  {103, "Amanda Stevens"},
 *  {104, "Will Osborn"}
 * };
 * 
 *  // Display each element.
 *  foreach(KeyValuePair<int, string> element in employees)
 *  {
 *      employeesListBox.Items.Add("ID: " + element.Key + " Name: " + element.Value);
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the foreach loop header, we are declaring element as the iteration
 * variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * KeyValuePair<int, string> element
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This declaration specifies that element is a KeyValuePair object, and
 * that its Key property is an int, and its Value property is a string.
 * As long as we understand these charcteristics of the element variable
 * , we can simplify its declaration be using the var keyword:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * foreach(var element in employees)
 * {
 *  emplyeesListBox.Items.Add("ID: " + element.Key + " Name: " + element.Value);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The ContainsKey, ContainsValue, and Contains Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the ContainsKey method to determine whether a specific 
 * key exits in a dictionary. The ContainsKey method accepts a key as its
 * argument, and retuens true if the key was found, or false othewise.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(!employees.ContainsKey(103))
 * {
 *  MeassageBox.Show("Employee 103 was not found.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the ContainsValue method to determine whether a speciic 
 * value exists in a dictionary. The ContainsVAlue methods accepts a 
 * value as it argumet, and returns true if the value was found, or 
 * false otherwise.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(!employees.ContainsValue("Chris Jones"))
 * {
 *  MeassageBox.Show("Chris Jones was not found.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the Contains method to determine whether a specific
 * element exists as a KeyValuePair in a Dictionay. The Contains method
 * accepts a KeyValuePair aas its argument, and returns true if the 
 * element was found, or false otherwise.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * KeyValuePair<int, string> element = 
 * new KeyValuePair<int, string>(101, "Chris Jones");
 * 
 * if(!employees.Contains(element))
 * {
 *      MessageBox.Show("Chris Jones was not found.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Retieving a Value with the TryGetValue Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call the TryGetValue method, you pass two arguments:(1) the
 * key that you are searching for, and (2) an output variable in which
 * you want to store the valur associated with the Key. Here is the 
 * general format of how the TryGetValue method is called:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * dictionaryName.TryGetValue(key, out targetVariable)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IN the general format, dictionaryName is the name of a Dictionary,
 * key is the key that you are searching for, and targetVariavble is
 * the nane of a variable. The method searches for key in the Dictionary,
 * and if it is found, the value associated with key is stored in the
 * targeVariable and returns false to indicate the key was not found.
 * The following code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create a Dictionary with employee information
 *  Dictionary<int, string> employees = new Dictionary<int, string>()
 *  {
 *      {101, "Chris Jones"},
 *      {102, "Jessica Smith"},
 *      {103, "Amanda Stevens"},
 *      {104, "Will Osborn"}
 *  };
 *  // Variable to hold an employees's name 
 *  string name;
 *  
 *  // Search for employee 104
 *  if(employees.TryGetValue(104, out name))
 *  {
 *      MessageBox.Show(name);
 *  }
 *  else
 *  {
 *      MessageBox.Show("Emplyee 104 was not found.")
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *          The Count Property and the ElementAt Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary objects have a Count property that is set to the number
 * of elements in the Dictionary.
 * The Count property can be used along wit the ElementAt method 
 * to iterate other the elements in aDictionary using a for loop.
 * Here is the general format of the ElementAt method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * dictionaryName.ElementAt(index)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the general format, disctionaryName is a Disctionary and index is 
 * a position within the Dicttionary, wit h0 begins the first element.
 * The method returns the element at the specified position as a 
 * KeyValuePair object. If the index is out of bounds, the method throws
 * an exception. The following code shows an example. Assume this code is 
 * an application that has a ListBox control named emplyeesListBox.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<int, string> employees = new Dictionary<int, string>()
 * {
 *  {101, "Chris Jones"},
 *  {102, "Jessica Smith"},
 *  {103, "Amanda Stevens"},
 *  {104, "Will Oberson"}
 * };
 * 
 * for(int i = 0; i < employees.Count; i++)
 * {
 *      // Get a KeyValuePair element
 *      var element = employees.ElementAt(i);
 *      
 *      // Display the element 
 *      employeesListBox.Items.Add(element.key + "" + element.Value);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *                         The Clear Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Clear method delates all the elements in a Dictionary, leaving
 * the Dictionary empty. The method's general format is:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * dictionaryName.Clear();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Storing List s as Values in a Dictionary
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IN the following code snippet, we create a Dictionary in which the 
 * keys are student names(as strings), and the values are List s
 * containing test scores. Assume this code is in an application
 * that has a ListBox conteol named scoresListBox.
 * The outPut of the code (the contents of teh ListBox) is shown in
 * Figure 9-16.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Dictionary<string, List<int>> testScores = 
 * new Dictionary<string, List<int>>()
 * {
 *  {"Kayla", new List<int> {88, 92, 100}},
 *  {"Luis", new List<int> {95, 74, 81}},
 *  {"Sophie", new List<int> {72, 88, 91}},
 *  {"Ethan", new List<int> {70, 75, 78}},
 * };
 * 
 *  // Display each student's text score.
 *  foreach(var student in textScores)
 *  {
 *      scoresListBox.Item.Add(student.Key);
 *      foreach(int score in student.Value)
 *      {
 *          scoresListBox.Item.Add(score);
 *      }
 *      scoresListBox.Items.Add("---------------");
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 9-3 Storing Names and Brithdays in a Dictionary
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete an application that stores names and 
 * birthdays in a Dictionary. Each entry in the dictionary uses a
 * person's name as the key, and that person's birthday will be retrived
 * from the Dictionary and displayed in the birthdatyLable control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 9-5 Complete Form1 code for the Birthday application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Birthdays
 * {
 *      public partial class Form1 : Form
 *      {
 *          // Dictionary with names and birthdays
 *          private Dictionary<string, string> birthdays
 *          = new Dictionary<string, string>()
 *          {
 *              {"Cameron", "4/17/1998"},
 *              {"Kathryn", "5/7/1996"},
 *              {"Jason", "1/22/1997"},
 *              {"Lola", "5/5/1995"},
 *              {"Wesley", "10/4/1999"},
 *          };
 *          
 *          public Form1()
 *          {
 *              InitializeComponent();
 *          }
 *          
 *          private void Form1_Load(object sender, EventArgs e)
 *          {
 *              // Display the names in the LisBox.
 *              foreach(var element in birthdays)
 *              {
 *                  namesListBox.Items.Add(elements.Key);
 *              }
 *              
 *          }
 *          
 *          private void namesListBox_SelectedIndexChanges(object sender, EventArgs e)
 *          {
 *              // Get the selected name.
 *              string name = nameListBox.SelectedItem.ToString();
 *              
 *              // Get the selected person's birthday.
 *              string birthdat = birthfays[name];
 *              
 *              // Display the selected person's birthday.
 *              birthdayLabel.Text = birthday;
 *          } 
 *      }
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 9-4 Using a Dictionary to Simulate a Deck of Cards
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In some games inviling poker cards, the cards are assigned numeric 
 * values. For example, in the game of BlackJack, the cards are given the 
 * following numeric values:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * Numeric cards are assigned the value they have printed on them. For
 * example, the value of the 2 of spades is 2, and the value of the 5 of
 * diamonds is 5.
 * 
 * * Jacks, queens, and kings are valued at 10.
 * 
 * *Aces are valued at either 1 or 11, depending on the player's
 * choice.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete an application that uses a Dictionary
 * to simulate a standard deck of poker cards, where the cards are
 * assigned numeric values simuilar to those used in Blackjack. (In the 
 * program, you will assign the value 1 to all aces.) The key-value pairs
 * used the name of the card as the key, and the card's numeric value as
 * the value. For example, the key-value pair for the queen of hearts is
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * "Queen of Hears", 10 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * and the key-value pair for the 8 of diamonds is
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * "8 of Diamonds", 8
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The application's form is shown in Figure 9-18, and the completed
 * code for the application is shown in Program 9-6. The completed 
 * application will work like this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  * The user enters the number of cards to detal into the numCardsTextBox control
 *  
 *  * The user clicks the dealButton control to deal a hand of that
 *  many cards from the deck. To simulate dealing the cards, the application will
 *  randomly select elements from the Dictionary. The randomly selected elements
 *  will be removed from the Dictionary so they can't be dealt more than once.
 *  
 *  *The names of the randomly selected cards will be displayed in the
 *  dealtCardsListBox control.
 *  
 *  *The total numeric value of the hand will display in the valueLabel control.
 *  
 *  *The number of cards that are left in the deck will be displayed in
 *  the cardsLeftLabel control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 9-18 The Car Dealer application's Form1 form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 9-6 Completed Form1 code for the Card Dealer application
 * 
 * Note: This code sucks
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Card_Deler
 * {
 *      public partial class Form1: Form
 *      {
 *          // Dicttionary to simulate a deck of cards
 *          private Dictionary<string, int> deck = new Dictionary<string, int>()
 *          {
 *              // Spades
 *              
 *              // Hearts
 *              
 *              // Clubs
 *              
 *              // Diamonds
 *          };
 *          
 *          public Form1()
 *          {
 *              InitializeComponent();
 *          }
 *          private void Form1_Load(object sender, EventArgs e)
 *          {
 *              // Update the number of cards left in the deck.
 *              cardsLeftLAbel.Text = deck.Count.ToString();
 *          }
 *          
 *          private void dealButton_Click(object sender, EventArgs w)
 *          {
 *              int numCards = 0;           // Number of cards tp deal
 *              int handValue = 0;          // Value of the dealt cards
 *              Random rand = new Random(); // Random number generator
 *              
 *              // Clear the hand value
 *              valueLabel.Text = "";
 *              
 *              // Get the number of cards to deal
 *              if(int.TryParse(numCardsTextBox.Text, out numCards))
 *              {
 *                  // Make sure the number is within range.
 *                  if(numCard > 0 && numCards <= deck.Count)
 *                  {
 *                      // Deal the cards
 *                      for(int count = 0; count < numCards; count++)
 *                      {
 *                          // Get a random number.
 *                          int randNumber = rand.Next(deck.Count);
 *                          
 *                          // Get the card at the random position.
 *                          var card = deck.ElementAt(randNumber);
 *                          
 *                          // Display the card.
 *                          dealtCardsListBox.Items.Add(card.Key);
 *                          
 *                          // Update and display the hand value.
 *                          handValue += card.Value;
 *                          valueLabel.Text = handValue.ToString();
 *                          
 *                          // Remove the delected card from the deck.
 *                          deck.Remove(card.Key);
 *                          
 *                          // Update the number of cards left in the deck.
 *                          cardsLeftLabel.Text = deck.Count.ToString();
 *                      }
 *                  }
 *                  else
 *                  {
 *                      // Error message for number out of range
 *                      if(deck.Count == 0)
 *                      {
 *                          MessageBox.Show("The deck is empty!");
 *                      }else
 *                      {
 *                          MessageBox.Show("Enter a number in the range of "
 *                          + "1 thorough " + deck.Count.ToStrimg    )
 *                      }
 *                  }
 *              }
 *              else
 *              {
 *                  // Error message for noninteger value
 *                  MessageBox.Show("Enter an integer.")
 *              }
 *          }
 *      }   
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 */