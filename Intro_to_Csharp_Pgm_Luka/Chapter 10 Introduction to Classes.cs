/*
 * //////////////////////////////////////////////////////////////////////////
 *                  Chapter 10 Introduction to Classes
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *                               Topics
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *      * 10.1 Introduction to Classes
 *      * 10.2 Properties
 *      * 10.3 Parameterized Constructors and Overloading
 *      * 10.4 Storing Class Type Objects in Arrays and Lists s
 *      * 10.5 Finding the Classes and Their Responsibilities in a Problem
 *      * 10.6 Application of Classes: Creating multiple Forms in a Project.
 *      * 10.7 Static Methods
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 *  10.1 Introduction to Classes
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Concept: A class is the blueprint for an object. IT specifies the fields
 * and methods a partivular type of object has. Form the class, one or more
 * objects may be created.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * As you have works through this book, you have used objects extensively in 
 * all the programs that you have written. Some object, such as the controls
 * that you place on a form, are visual. 
 * 
 * Other objects, such as Random objects, arrays, List objects, and ImageList
 * controls, cannot be seen on the screen but exist in memory and perform
 * important tasks.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * We mentioned in Chap 1 that objs do not just magically appear in your 
 * program. Before a specific type of object can be used, that object has to 
 * be created in memory. And, before an object can be created in memory, you
 * must have a class for the object.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A class is code that describes a particular type of object. IT specifies
 * the data that an object can hold (fields and properties) and the actions
 * that an object can perform (methods). You can think of a class as a Code
 * "blueprint" that can be used to create a particular type of object. It
 * servers a similar purpose as the blueprint for a house.
 * The blueprint itself is not a house but is detailed description of a 
 * house. When we use it to build an actual house, we could say we are
 * buliding an instance of the house described by the buleprint. This 
 * idea is illustrated in Figure 10-1.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * 
 * //////////////////////////////////////////////////////////////////////////
 *            Figure 10-1 A blueprint and house built from it.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * So, a clss is not an object but a description of an object.
 * When the program is running, it can use the class to create, in memory,
 * as many objects of a specific type as needed. Each object that is created 
 * from a class is called an instance of the class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * For example, Jessica is an entomologist(someone who studies insects),
 * and she also enjoys writing computer programs. She designs a program to
 * catalog different types of insects. As part of the program, she creates
 * a class named Insect, which specifies fields, properties, and methods for
 * holding and manipualing data common to all types of insects. The Insect
 * class is not object but a specification that objects may be created from.
 * Next, she writes programming statements that create housefly object, which
 * is an instance of the Insect class. The housefly object is an entity that
 * occupies computer memory and stores data about a housefly.
 * It has the fields, properties, and methods specified by the Insect class.
 * Then she writes programming statements that createa mosquite object. THe 
 * mosquito about is also an instance of the Insect class. It has it own 
 * area in memory and stores data about a mosquito. Although the housefly and
 * mosquito objects are two separate entities in the computer's memory, they
 * were both created from the Insect class. This means that each object has
 * fields, properties, and methods described by the Insect class.
 * This is illustrated in Figure 10-2
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-2 The housefly and mosquito objects as instances of the Insect
 * class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Creating a Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You create a clss by writing a class declaration.
 * This is the general format of a class declaration:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class ClassName
 * {
 *      Member declarations go here...
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The first line of a class declaration is known as the class header.
 * It starts with the word class, followed bu the name of the class. The
 * same rules for naming variables apply to naming classes. Most programmers
 * follow the convention of beginning class names with an uppercase letter.
 * This helps to easily distinguish class names from variable names when
 * reading code.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Following the class header is an opening curly brace.
 * Next, you write the class's member declarations. These are statements that
 * define the class's fields, properties, and methods. A closing curly brace
 * appears at the end of the class declaration.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Let's look at a simple example. Suppose we are writing a program to
 * simulate the tossing of a coin. In the program, we need to repeatly toss
 * a coin and each time determine whether it landed heads up or tails up.
 * First, we write a class named Coin that can perform the behaviors of the
 * coin. The following code sample shows the Coin class.
 * (Note that this class is only part of the application's code.
 * In a moment, you will see where it should appear in the project,
 * but for now, we concentrate only on this class.)
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Coin
 * {
 *  // Field to represent the side facing up;
 *  private string sideUp;
 *  
 *  // Constructor
 *  public Coin()
 *  {
 *      side = "Heads";
 *  }
 *  
 *  // the toss method simulates tossing the coin.
 *  
 *  public void Toss()
 *  {
 *      // Create a Random object.
 *      Random rand = new Random();
 *      
 *      // Use a random number to determien
 *      // the side of the coin is facing up.
 *      // 0 = Heads, 1 = Tails
 *      if(rand.Next(2) == 0)
 *      {
 *          sideUp = "Heads";
 *      }
 *      else
 *      {
 *      sideUp = "Tails";
 *      }
 *  }
 *  
 *  // The GetSideUp method returns the value
 *  // of the sideUp field.
 *  
 *  public string GetSideUp()
 *  {
 *      return sideUp;
 *  }
 *  
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Creating an Object
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Remember, a class is not an object but a description of an object. The Coin
 * class specifies what Coin object is made of, but is does not create a Coin
 * object in memeory. To create a Coin object, we must write a statemenet such
 * as this:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Coin my Coin = new Coin();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * At this point in your studies, you have created plenty of objects, so this
 * type of statement will be familiar to you. For example, Random object,
 * arrays, and List s are all created this way.
 * Let's look at the different parts
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * The first part of the statement, appearing on the left side of
 * the = opertor,reads Coin myCoin. This declars a variable named myCoin that
 * can be used to reference an object of the Coin class.
 * 
 * *The second part of the statement, appearing on the reight side of the 
 * operator, returns Coin().
 * This experssion creates an instance of the Conin class cand calls the
 * class's concetuctor. The new operator returns a referecnce to the object.
 * 
 * * The = operator assigns the reference that was returend from the new operator to the myCoin variable.
 * 
 * 
 *
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * After this astatement executes, the myCoin variable will reference a Coion
 * object, as shown in Figure 10-13. Notice in the figrue that the objetc's
 * sideUp field is set ot "Heads", as a result of the constructor.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-3 The myCoin variable references a Coin object
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Note Class are reference types. When you create an object from a class,
 * you use a reference variable to reference that object. When you want to work
 * with the object, you use the variable that references it.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Once we create a Coin object, wea can perform operations with it. For example,
 * saauming the variable myCoin references a Coin object, the follwoing statement
 * calls the object's Toss method:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * myCoin.Toss();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * And, the following statement displays the side of the coin that is facing
 * up:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Message.Show(myCoin.GetSideUp());
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Where to Write Class Declarations
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In C#, you have some flexablity in choosing where to write clss declarations.
 * When you start writing youe own classes in a project, it is possible to
 * write them in the same file that contains the form's class. Figure 10-4
 * shows an example of how the Coin class can be writtn in the same file as a 
 * project's Form1 class. Notice in the figure that the Conin class is writtn inside
 * the project namespace. This is not required, but it is a good idea since the
 * class is part of the project. (It does not matter if the class is written
 * before or after the Form1 class.)
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-4 The form1 class and the Coin class in the same source code file
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Although this approach might be acceptable for small classes, it is
 * recommended that you write each class in its own separate file.
 * Doing so makes your code more organized and helps your source code files to
 * a manageable size. IT also makes it easy for you to reuse classes in other
 * projects. In this bookm we always store classes in their own file.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Visual Studio automates the process of adduing a new class file to a project
 * . When you are ready to write a new class, follow theses steps to create a
 * sources files for the class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 1. Whith the project open in Visual Studio, click Peoject on the menu bar;
 * then select Add Class...This is shown Figure10-5.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * File 10-4 Selecting Add Class...on the Project menu
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 2. The Add New Item window, show in Fire 10-6, shold appear. Make sure Class
 * is selected as the type of item. Notice in the figure that Class1.cs appears
 * in the Name text box. This is the default filename that Visual Studio provides.
 * Change the name to match the names of the class that you are creating. For ex
 * , if you are creating a class named Coin, you change the name to Coin.cs
 * (Be sure the the filename ends with the .cs extension.)
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-6 The Add New item window
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 3.Click the Add button.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * After performing these step, the specified source code file will be created
 * in the project and will be displayed in the code editor. The souce code
 * file already contaubs several using directuves and an empty class declaration
 * that you can edit. Figure 10-7 shows an example. You will also see an entry for 
 * the new source file already contains several using directuves and an empty
 * class declaration that you can edit. Figure 10-7 shows an example, You will
 * also see ab entry for the new souce code file in the Soution Explorer, as 
 * shown in Figure 10-8.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-7 A new class file displayed in the code editor
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-8 Solution Exprlorer window
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutorial 10-1 leads you through the process of creating the Coin class in 
 * an applcaiton that uses ut to simualte a coin that can be tossed.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutoral 10-1 Creating and Using the Coin Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In this tutorial, you completed the Coin Toss application.
 * The application's form, which has already been created for you, is shown
 * in Figure 10-9. When you run the compleated application, you can click the
 * Toss Five Times button and the application with simulate a coin being tossed
 * file times. The result of each coin toss are displayed in the list box.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-9 The Coin Toss application's form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-11 The Coin.cs file in the code editor
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-12 Example output of the Coin Toss application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-1 COmpleted code for the COin.cs file in the Coin TOss applcation
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Coin_Toss
 * {
 *      class Coin
 *      {
 *          // Field to reperent the side facing up:
 *          ptivate string sideup;
 *          
 *          // Random number generator
 *          Random rand = new Random();
 *          
 *          // Constructor
 *          public Coin()
 *          {
 *              sideUp = "Heads";
 *          }
 *          
 *          // THe toss method simulates tossing the coin
 *          public void Toss()
 *          {
 *              // Use a random number to determine
 *              // the side of the coin is facing up.
 *              // 0 = Heads, 1 = Tails
 *              if(rand.Next(2) == 0)
 *              {
 *                  sideUp = "Heads";
 *              }
 *              else
 *              {
 *                  sideUp = "Tails"
 *              }
 *          }
 *          
 *          // The GetSideUp method returns the value
 *          // of the sideUp field.
 *          public string GetSideUp()
 *          {
 *              return sideUp;
 *          }   
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Coin_Toss
 * {
 *  public paratial class Form1 : Form
 *  {
 *      public Form1()
 *      {
 *          InitializeComponent();
 *      }
 *      private void tossButton_Click(object sender, EventArgs e)
 *      {
 *          // Create a Coin object.
 *          Coin myCoin = new Coin();
 *          
 *          // Clear the ListBox.
 *          outputListBox.Items.Clear();
 *          
 *          // Toss the coin five times.
 *          for(int count = 0; count < 5; count++)
 *          {
 *              // Toss the coin.
 *              myCoin.Toss();
 *              
 *              // Display the side that is up.
 *              outputListBox.Items.Add(myCoins.GetSideUp());
 *          }
 *      }
 *      
 *      priavte void exitButton_Click(object sender, EventArgs e)
 *      {
 *          // Close the form.
 *          this.Close();
 *      }
 *      
 *  }
 *      
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Passing an Object to a Method 
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * When you are devloping applications that work with object, you often need
 * to write methods that accept objects as arguments. For example, the following
 * code shows a method named ShowCoinStatus that accepts a Coin object as an
 * argument:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * private void ShowCoinStatus(Coin coin)
 * {
 *  MessageBox.Show("This side of the coin is up: " + coin.GetSideUp());
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The following code sample shows how we might create a Coin object and then
 * pass it as an argument to the ShowCoinStatus method:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Coin myCoins = new Coin();
 * ShowCoinStatus(myCoin);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Becayse classes are reference types, object that are instanves of a 
 * class are always passed by reference. When you pass an object that is an
 * instance of a class as ab argument, the thing that is passed into the
 * parameter variable is a reference to the object.
 * As a result, the method that receives the object as an argument has access
 * to the actual object (AUTO PASSING DEEP COPY CONSTRUCTOR SWAG :) )
 * (not a cooy if the object). For example, look at the follwoing Flip method:
 * 
 * //////////////////////////////////////////////////////////////////////////
 * private void Flip(Coin coin)
 * {
 *  coin.Toss();
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This method accepts a Coin object as an atgument, and it calls the
 * object's Toss method.
 * The following code demonstrates the method being called
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Create a Coin object.
 *  
 *  Coin myCoin = new Coin();
 *  
 *  // This will display "Heads".
 *  MessageBox.Show(myCoin.GetSideUp());
 *  
 *  // Pass the object to the Filp method.
 *  Filp(myCoin);
 *  
 *  // This might display "Heads", or is might
 *  // display "Tail".
 *  MessageBox.Show(myCoin.GetSideUp());
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 *                          10.2 Properties
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Concept A property is a class member that holds a piece of data about an
 * object. Properties are implemented as special methods that set and get the
 * values of corresponding fields.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A property is a special type of class member that allows an object to store
 * and retrieve a piece of data. You already familar with properties because
 * you have used them extensively when creating forms. GUI controls have properties
 * that determine their characteristics. For example, assume messageLabel is the
 * name of a Label control. You can assign value a specific value to the control's
 * Text property, as shown here:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * messageLabel.Text = "Hello";
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Also, you can assign a property to a variable. The following statement
 * intitalizes the variable str with the messageLabel control's Text property
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * string str = messageLabel.Text;
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * From these examples, you can see that a preoperty is a class memner that 
 * behaves like a public field. A property is not a publuic field however.
 * It is a special set of methods, know as accessors, which works in
 * conjunction with a priave field. The private field, which is known as
 * the property's backing field, holds any data that is assigned to the 
 * property. The accessors allow code outside the class to get the property's
 * value and assign values to the peroperty.
 * //////////////////////////////////////////////////////////////////////////
 * Let's look at an example of a simple class that has a property. Suppose
 * you want to create a class named Pet that represents the family pet. The 
 * calss will have a Name property to hold the pet's name. The following ocde
 * showns how the the Pet class might be written:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Pet
 * {
 *      // Field for the pet's name
 *      priavte string _name;
 *      
 *      // Cponstructor
 *      public Pet()
 *      {
 *          _name = "";
 *      }
 *      
 *      // Name property
 *      public string Name
 *      {
 *          get{return _name;}
 *          set{_name=value;}
 *      }   
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The following code shows how you can use the Pet Class's Name property:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Create two pet objects
 *  Pet myDog = new Pet();
 *  Pet myCat = new Pet();
 *  
 *  // Set their Name properties.
 *  myDog.Name = "Fido";
 *  myCat.Name = "Sylvester";
 *  
 *  // Display their name.
 *  MessageBox.Show("My dog's name is " + myDog.Name);
 *  MessageBox.Show("My cat's name is " + myCat.Name);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-13 setting the myDog object's Name property to "Fido"
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When an accessor contains only a single statement, many programmes perfer
 * to write the entire accessor in one line of code. For example, the Name
 * property in the Pet class could have been written like this:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Name property
 *  public string Name
 *  {
 *      get {return _name;}
 *      set {_name = value;}
 *  } 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The concise style of writting accessor reduces the number of lines code 
 * in a class declarartion without sacificing the code's readabilty. From this
 * point forward in the book's, we will use this style when an accessor has
 * only one statement.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Properties versus Public Fields
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * At this point, you might be wondering why you should go to the troube of 
 * creating a property when it would be easier to simply create a public 
 * feild. For ex, in the Pet class, could't we have just declared a public 
 * string field named Name? if the field is public, if can be directly
 * accessed by code outside the class without the need for accessors.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * It is possivle to take that appeoach, but it is not recommended. Class
 * fields are almost always declared private in order to protect them from
 * accidental corruption. When code outside the class needs to access a field,
 * it does so through public methods
 * (or, in the case of a property, through accessors.) This ensures that the 
 * object owning the fields is in control of all changes being made to them.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Passing Properties as Arguments
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You can pass a property as an argument to a method. For exampel, line 8 in
 * the following code sample passes a Pet object's Name property as an argument
 * to the MessageBox.Show method:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Create a Pet objects.
 *  Pet myDog = new Pet();
 *  
 *  // Set the object's Name property.
 *  myDog.Name = "Fido";
 *  
 *  // Display the Name property.
 *  MessageBox.Show(myDog.Name);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When you pass a property as an argument to a method, there is one 
 * restriction: Properties can passed only by value.
 * If you try to pass a property to a ref or an out  parameter, and error
 * occues.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Read-Only Properties
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * Sometimes it is useful to makle a property read-only. A read-only property
 * can be read, but it cannot be modified. If you need to make a property 
 * read-only, you  simply do not write a set accessor for property. The 
 * following Circle class show an example
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Circle
 * {
 *  // Field
 *  private double _diameter;
 *  
 *  // Constructor
 *  public Circle()
 *  {
 *      _diameter = 0.0;
 *  }
 *  
 *  // Diameter property
 *  public double Diameter
 *  {
 *      get{return _diameter;}
 *      set{_diameter = value;}
 *  }
 *  
 *  // Radius property (read-only)
 *  public double Radius
 *  {
 *      get {return _diameter / 2;}
 *  }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Notice that the Radiys property has a accessor but does not have a set 
 * acessor but does not have a set accessor. The RAdius property is read-only.
 * Theregfore, if we create an object of the Circle class, we can get the 
 * value of the Radius property, but an error will cccure if we try to assign a 
 * valur to the Radius property.
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 *                          Avoiding Stale Date
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In the Circle class example, previously shown, notice that the Radius
 * property does not have its own backing field, as the Diamter property 
 * does. Ratherm the Radius prioerty;s get accessor returns the value of a
 * calculation. The radius is not stored in a field because a circle's radius
 * is depend on the circle's diameter. If we store both the diameter and the
 * radius in their own fields, the radius fields will become incorrect as 
 * soon as the diameter field changes.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When a field's value is tightly dependent on the other data and that field
 * is not updateed when the other data is changed, it is said that the field 
 * has become stale. When designing a class, you should take cate not to store
 * in a field any calculated data that can potentially become stale. Instead,
 * provide a read-only property, or a method, that retuens the value of the 
 * calculation.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Auto-Properties
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Sometomes a property simply get and sets the value of a backing field,
 * without performing any other operatrion. For ex. recall the Pet class that
 * we discussed earlier in this section. The classhas a NAme property that gets
 * and sets the value of a backing field named _name. Here is the relevent code
 * from the Pet class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * private string _name;
 * public string Name
 * {
 *  get
 *  {
 *      return _name;
 *  }
 *  set
 *  {
 *      _name = value;
 *  }
 * }
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * This code can be greatly simplified if we implement the property as an 
 * auto-property. Auto-properties allow you create simple properties without
 * declaring a backiong field, and without writing code to get  and set the
 * property's value. Here is an example of how the Name property in the Pet
 * class can be written as an auto-property:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * public string Name
 * {
 *      get
 *      set;
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When the property is written this way, the C# compiler automatically creates
 * a hidden backing field, as  well as the code for the get and set methods.
 * In fact, most programmers prefer to write an even shorts version of the 
 * property, like this:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * public string Name { get; set;}
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Uninitialized auto properties will be automatically set to the default
 * for their data type. (Numeric types will be set to 0. Strings, structs, 
 * and classes variables will be set to null.) If you want to initalize an 
 * auto-property to a particular value, you can do so in the following manner:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * public strin Name {get; set;} = "Fido";

 * //////////////////////////////////////////////////////////////////////////
 * 
 * class Pet
 * {
 *  // Name property
 *  public string Name {get; set; } = "";
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Read-Only Auto-Properties
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * If you leave out the set keyword in an auto-property, the property becomes
 * read-only here is an ex of how we can make the Pet class's Name property
 * read-only:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Pet
 * {
 *  // Name property
 *  public string Name{get;} = "Fido";
 * } 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * We can get the property's value, but we cannot set the property's value.
 * If necessary, you can assign a value ti a read-only auto-property in the 
 * classes conctructor, as shown here:
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * class Pet
 * {
 *  // Constructor
 *  public Pet()
 *  {
 *      Name="Fido";
 *  }
 *  // Name property
 *  publuc string name {get;}
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutotial 10-2: Creating and Using the CellPhone Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Suppose you work as a programmer for a companty that sells cell phones and
 * wirless services. Youe department is creating an application to manage the 
 * company's inventory of cell phones. You have been asked to created a class
 * that repersents a cell phone. The class should keep the following data about 
 * the cell phone:
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * * The phone's brand name
 * * The phone's model
 * * The phone's retail price
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * Brand - a string property that will store the phone's brand name 
 * 
 * * Model - a string property that will store the phone's model
 * 
 * * Price - a decimal property that will store the phone's retail price
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The class should also have a constructor that initializes the properties.
 * The Brand and Model properties will be initialized with empty string, and
 * the Price property will be initalized with the value 0. 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You created the CellPhone cell in a project that will create an objecct 
 * and test the object's propertues. THe prokect is named Cell Phone test and
 * has already been started for you; it is locaed in the Chap10 folder of the 
 * Student Sample Programs. Figure 10-14 shows the applciation's form. AT 
 * run time, you already been strarted for you; It is located in the Chap10
 * folder of the Student Sample Programs. Figure 10-14 shows the application's
 * form. At runtime , you enter sample cell phone data into the text boxes
 * and then click the create object's properties. It then reads and displays 
 * the values of the object's properties in the brandLabel, modelLabel, and 
 * priceLabel controls.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-14 The Cell Phone Test application's form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-3 Completed code for the CellPhone.cs file in the Cell Phone
 * Test application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Cell_Phone_Test
 * {
 *  class CellPhone
 *  {
 *      
 *  
 *      // Constructor
 *      public CellPhone()
 *      {
 *          Brand = "";
 *          Model = "";
 *          Price = 0m;
 *      }
 *      
 *      // Cran property
 *      public string Brand{get; set;}
 *      
 *      // Model property
 *      public strinf Model {get; set;}
 *      
 *      // Price property
 *      public decimal Price{get; set;}
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * Program 10-4 Completed code for Form1 in the Cell Phone Test application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  namespace Cell_Phone_Test
 *  {
 *      public partial class Form1 : Form
 *      {
 *      
 *      
 *      
 *      public Form1()
 *      {
 *          InitializeComponent();
 *      }
 *      
 *      // GetPhoneData method accepts a CellPhone object
 *      // as an argrument. It assigns the data entered by the 
 *      // user to the object's properties
 *      private void GetPhoneData(CellPhone phone)
 *      {
 *          // Temporary variable to hold the price
 *          deciaml price;
 *          
 *          // Get the phone's brand.
 *          phone.Brand = brandTextBox.Text;
 *          
 *          // Get the phone's model.
 *          phone.Model = modelTextBox.Text;
 *          
 *          // Get the phone's price.
 *          if(decimal.TryParse(priceTextBox.Text, out price))
 *          {
 *              phone.Price = price;
 *          }
 *          else
 *          {
 *              // Display an error message.
 *              MessageBox.Show("Invalid price")
 *          }
 *      }
 *      
 *      private void createObjectButton_Click(object sender, EventArgs e)
 *      {
 *          // Create a CellPhone object
 *          CellPhone myPhone = new CellPhone();
 *          
 *          // Get the phone data.
 *          GetPhoneDAta(myPhone);
 *          
 *          // Display the phone data.
 *          brandLabel.Text = myPhone.Brand;
 *          modelLabel.Text = myPhone.Model;
 *          priceLabel.Text = myPhone.Price.ToString("c");
 *      }
 *   }
 *}
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *              10.3 Parameterized Constructors and Overloading
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Concept: A constructor that accepts arguments is known as a pearmeterized
 * constructor. A class can have multiple versions of the same method, which
 * are known as overloaded methods.
 * //////////////////////////////////////////////////////////////////////////

 * //////////////////////////////////////////////////////////////////////////
 * Constructors can accepts arguments in the same way as other methods. A 
 * constructor that accepts arguments is known as a parameterized constructor
 * because it has parameter variables. When a class has a parameterized 
 * constructor, you can pass intialization values to the constructor when you
 * create an object. In Tutorial 10-3, you write a class that simulates a bank
 * account. The class's constructor will accept an argument that specifies the 
 * account's starting balance.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutoral 10-3: Creating and Usiing the BankAccount Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In this tutorial, you write a class named BankAccount that simulates a bank
 * account. When you create an instance of the class, you pass the account;s 
 * starting balance as an argument to the constructor. The class will have a 
 * Deposit method that adds an amount to the balance and a Withdraw method that 
 * subtracts an amount from the balance. The class will also have a read-only
 * Blance property that reports the account's balance.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The BankAccount class is part of the Account Simulator application, which 
 * has already been started for you. Figure 10-15 shows the application's form.
 * When the completed applications runs, it creates a BankAccount object with a 
 * starting balance 0f 1,000.00. The balance is displayed in the balanceLabel 
 * control. If you want to make a deposit, you can enter the amount into the
 * depositTextBox, and click the Deposit button.
 * If you want to make a withdrawl, you can enter the amount into the
 * withdrawTextBox and click the Withdraw button. Each time you perform one of
 * these actions, the new account balance is displayed.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-15 The Account Simulator application's form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-5 Completed code for the BankAccount.cs file in the Account 
 * Simulator application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Account_Simulator
 * {
 *      class BankAccount
 *      {
 *          //Field 
 *          pricate decimal _balance;
 *          
 *          // Constructor
 *          publuc BankAccount(decimal startingBalance)
 *          {
 *              _balance=startingBalance;
 *          }
 *          
 *          // Blance property (read-only)
 *          public decimal Balance
 *          {
 *              get{return _blance; }
 *          }
 *          
 *          // Desposit method
 *          public void Deposit(decimal amount)
 *          {
 *              _balance += amount;
 *          }
 *          
 *          // Withdraw method
 *          public void Withdraw(decimal amount)
 *          {
 *              _balance -= amount;
 *          }
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-6 Completed code for Form1 in the Account Simulator application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Account_Simulator
 * {
 *  public partial class Form1 : Form
 *  {
 *      // BankAccount field with a $1000 starting balance
 *      priave BankAccount account = new BankAccount(1000);
 *      
 *      public Form1()
 *      {
 *          InitializeComponent();
 *      }
 *      
 *      private void Form1_Load(object sender, EventArgs e)
 *      {
 *          // Display the string balance.
 *          balanceLabel.Text = account.Balance.ToString("c");
 *      }
 *      
 *      private void depositButton_Click(object sender, EventArgs e
 *      {
 *          decimal amount; // To hold the amount of deposit
 *          
 *          // Convert the amount to a decimal.
 *          if(decimal.TryParse(depositTextBox.Text, out amount ))
 *          {
 *              // Deposit the amount into the account.
 *              account.Deposit(amount);
 *              
 *              //Display the new balance.
 *              balanceLabel.Text = account.Balance.ToString("c");
 *              
 *              // Clear the text box.
 *              depositTextBox.Clear();
 *          }
 *          else
 *          {
 *              // Display an error mesasge.
 *              MessageBox.Show("Invalid amount");
 *          }   
 *      }
 *      
 *      private void withdrawButton_Click(object sender, EventArgs e)
 *      {
 *          decimal amount; // To hold the amount of withdrawl
 *          
 *          // Convert the amount to a decimal.
 *          if(decimal.TryParse(withdrawTextBox.Text, out amount))
 *          {
 *              // Withdraw the amount from teh account.
 *              account.Withdraw(amount);
 *              
 *              // Display the new balance.
 *              balanceLabel.Text = account.Balance.ToString("c");
 *              
 *              // Clear the text box.
 *              withdrawTextBox.Clear();
 *          }
 *          else
 *          {
 *              //Display an error message.
 *              MessageBox.Show("Invalid amount");
 *          }
 *      }
 *      private void exitButton_Click(object sender, EventArgs e)
 *      {
 *          // Close the form.
 *          this.Close();
 *      }
 *  }   
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Overloaded Methods
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Sometimes you need different ways to perform the same operation. For example,
 * the BankAccount class that you wrote in Tutorial 10-3 has a Deposit method
 * that accepts a decimal arguments. Suppose you are using the class in an 
 * application that needs to pass a double variable to the metyhod instead of 
 * a decimal variable. In this application, before you call the Deposit method,
 * you have to convert the double variable to a decimal so it can be passed to 
 * the method. It would be nice of the Deposit method could accept either a 
 * decimal argument or a double argument. Then, it would be unnecessary to 
 * convert a double variable before passing it to a method.
 * This can be accomplished with overloading.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When a method is overloaded, it means that multiple methods in the same 
 * class have the same name but use different types of paramters. Here is an
 * ex, of how we might overload the Deposit method inside the BankAccount
 * class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Deposit method
 *  public void Deposit(decimal amount)
 *  {
 *      _balance += amount;
 *  }
 *  
 *  // Disposit method
 *  public void Deposit(double amount)
 *  {
 *      _balance += (decimal)amount;
 *  }   
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When you write a call to the Deposit method, the compiler must determine 
 * which one of the overloaded methods you intended to call. The process of 
 * matching a method call with the correct method is know as binding. When
 * an overloaded method is called, the compiler uses the method's name and 
 * parameter list to determine to which method to bind the call. If we call
 * the Deposit method is called, the compiler uses the methods's name and 
 * parameter list to determine to which method to bind the call. If we call
 * the Deposit method and pass a double argument, the version of the method
 * that has a double parameter is called.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The compiler uses a method's signature to distinguish it from other methods
 * of the same name. A method's signature consists of the method's name and 
 * the datatype and argument kind (by value, ref, or out) of the method's 
 * parameters, from left to right. For example, here are the signature of the
 * Deposit methods that we previously showed:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Deposit(decimal)
 * Deposit(double)
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Note that the method's return type is not part of the signature. For this
 * reason, you cannot overload methods by giving them different return types.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Overloaded Constructors
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Constructors can also be overloaded, which means that a class can have
 * more than one constructor. The rules for overloading constructors are the 
 * same for overloading other methods: Each version of the constructor must
 * have a different parameter list. As long as each cconstructor has a unituq
 * signature, the compiler can tell them aprt/
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Here is an example of how we might overload the BankAccount class 
 * constructor:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Constructor
 *  public BankAccount()
 *  {
 *      _blance =0;
 *  }
 *  // Constructor
 *  public BankAccount(decimal startingBalance)
 *  {
 *      _blance= startingBlance;
 *  }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The following statement calls the parameterless constructor, which means it
 * accepts no arguments. The following statemnts calls the parameterless
 * constructor as it creates a BankAccount object:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * BankAcount account = new BankAccount();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The second constructor (lines 8-11) because an integer value can be 
 * implicitly converted to a decimal:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * BankAccount account = new BankAccount(500);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The following code will cause an error, however, because there is not 
 * constructor that accepts a double argument:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Error
 *  BankAccount account = new BankAccount(500.0);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Default Constructors
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * It is perfectly legal to write a class without any constructors. If you 
 * write a class with no constructor whatsoever, the compiler provides a 
 * default constructor.  is a parameterless constructor
 * (it accepts no argumetns), and it initializes the object's fields with the
 * value 0. (If any fields are reference variables, the are initialized with 
 * the special value null.)
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *                      Object Initializer Syntax
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * IF you know the value that you want to store in an object's properties at
 * the time you create the object, you can use object initializer syntax
 * to initialize the object's properties.
 * For example, suppose we have the follwoing Circle class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Circle
 * {
 *  public int CenterX {get; set;}
 *  public int CenterY {get; set;}
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * We can use object initializer syntax to initialize and instance of the 
 * class like this:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Circle ring = new circle {Center = 100, CenterY = 50};
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This statemet creates an instance of the Circle class in memory. The object's
 * name is ring. The object's CenterX property will be initialized with the 
 * value 100, and the CenterY propertu will be initialized with the value 50.
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Let's look at another example, Suppose we have the follwing Person class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Person
 * {
 *  public string Name {get; set;}
 *  public string Email{get; set;}
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * We can use object initialier syntax to initialize an instance of the class
 * like this:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Person person = new Person {Name = "Janet Smith",
 *                            Email = "janet@example.com"};
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This statement creates an instance of the Person class in memory.
 * The object's name is person. The object's Name property will be
 * initialized with "Janet Smith" and the Email property will be initialized
 * with "janet@example.com".
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When using oject initializers, you do not have to provide an initializer for
 * every property. The follwoing example creates a Person object,
 * initializing  only the Name property. The email property will be initialized
 * null, which is the default string value.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Person person = new Person {Name = "Janet Smith"};
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * If you are using object initializers, and the object's class has a
 * constructor, the constructir is always called before the object
 * initializers are assignesd to the object's properties. For ex, look at the
 * following Person class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Person
 * {
 *      public Person()
 *      {
 *          Name = "unknown";
 *          Email = "unknown";
 *      }
 *      
 *      public string Name {get; set;}
 *      public string Email{get; set;}
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Suppose we create an instance of the class with the following statement:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Person person = new Person {Name = "Janet Smith",
 *                            Email = ""janet@example.com};
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * First, the constructor is called and the Next and Email properties are
 * initialized with the string "unknown". Then, the object initializers are
 * applied, and the object's Name property will be assigned "Janet Smith" and
 * the Email property will be assigned "janet@example.com"
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Let's look at another example: Suppose we have the follwoing Person class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Person
 * {
 *  public Person(string n, string e)
 *  {
 *      Name = n;
 *      Email = e;
 *      PhoneNumber = "";
 *  }
 *  
 *  public string Name {get; set;}
 *  public string Email {get; set;}
 *  public string PhoneNumber {get; set;}
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This class has three perperties: Name, Email, and PhoneNumber.
 * The constructor, however, has only two parameters: n and e.
 * These parameters are assigned to the Name and Email properties in line 5
 * and 6. Line 7 assigns an empty string to the PhoneNumber property. So, when
 * we instantiate the class, we can use the constructor to set values for 
 * Name and Email, but not PhoneNumber. To set the PhoneNumber property, we have
 * to write a separate statement, as shown in this example:
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Person person = new Person("Janet Smith", "janet@example.com");
 * person.PhoneNumber = "555-1212";
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Alternatively, we could apply an object initializer to the PhoneNumber
 * property, like this:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Person person = new Person("Janet Smith", "janet@example.com")
 * {
 *  PhoneNumber = "555-1212"};
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * After this statement executes, the person object's Name property is
 * initialized with the string janet@example.com, and the PhoneNumber property
 * is assigned "555-1212".
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 10.4 Storing Class Type Object in Array and List s
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Concept: You can store a collection of class type objects in an array or
 * a List.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Arrays of Class Type Objects
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Objects that are instances of a class can be stored in an array. For ex,
 * assume the CellPhone class previously shown exists in an application. The 
 * following code creates a CellPhone array with four elements:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * const int SIZE = 4;
 * Cellphone[] phones = new CellPhone[SIZE];
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Although this code creates an array, it does not yer contain any objects.
 * When you create an array of a class type, each element of the array is a 
 * reference variable. By default, each element will be initalized with thet 
 * value null. The next step is to create the object that each element will 
 * reference. This can be done one element at a time, as shown here:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * phones[0] = new CellPhone();
 * phones[1] = new CellPhone();
 * phones[2] = new CellPhone();
 * phones[3] = new CellPhone();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Or, it can be done with a loop, as shown here:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * for(int index = 0; index < phones.Length; index++)
 * {
 *  phones[index] = new CellPhone();
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Alternatively, you can initialize the array elements in the declararion
 * statement:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * CellPhone[] phones = 
 * {
 *  new CellPhone(), new CellPhone(),
 *  new CellPhone(), new CellPhone()
 * };
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The follwing shows another example. This code creates a BankAccount array
 * and initializes its elements with references to four BankAccount objects.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * BankAccount[] accounts =
 * {
 *  new BankAccount(1000),
 *  new BankAccount(2000),
 *  new BankAccount(3000),
 *  new BankAccount(4000)
 * };
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Notice the arguments that are passed to the BankAccount constructor for 
 * each object. If the follwoing code were executed, it would display
 * "The balance is 1000", The balance is 2000", and so forth:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * for(int index = 0; index < accounts.Length; index++)
 * {
 *  MessageBox.Show("The blance is " +
 *  accounts[index].Balance);
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The following code performs the same operation using a foreach loop:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * foreach(BankAccount acct in accounts)
 * {
 *  MessageBox.Show("The balance is " + acct[index].Blance);
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * List s of Class Type Object
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In Chapter 7, we discussed the List class, which is a container for 
 * storing a collection of objects. Here is an example of how you would create
 * a List that can hold CellPhone objects:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * List<CellPhone> phoneList = new List<CellPhone>();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This statement creates a List object, referenced by the phoneList variable.
 * Notice that the word CellPhone is written inside angled brackets, <>,
 * immediately after the word List. This specifies that the List can hold only
 * object of the CellPhone class type.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * To add an object to a List, you use the Add method. The follwoing 
 * code shows an example:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Create a List to hold CellPhone objects.
 *  List<CellPhone> phoneList = new List<CellPhone>();
 *  
 *  // Create an instance of teh CellPhone class.
 *  CellPhone myPhone = new CellPhone();
 *  
 *  // Assign values to the object's properties.
 *  myPhone.Brand = "Acme Electronics";
 *  myPhone.Model = "M1000";
 *  myPhone.Price = 199;
 *  
 *  // Add the object to the List.
 *  phoneList.Add(myPhone);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In tutorial 10-4, you complete an application that uses a List to hold a
 * collection of CellPhone objects.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutorial 10-4: Completing the Cell Phone Inventory Application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Cell Phone Inventory application. Figure
 * 10-16 shows the application's form, which has already been created for you.
 * When you run the completed application, you can enter data about a cell 
 * phone into the TextBox controls. When you click the Add Phone button, that
 * data is assigned to a CellPhone object's properties and then the object is
 * added to a List. You can do this as many times as you wish. Each time you 
 * add a cell phone, its brand and mobel is displayed in the listBox. If you 
 * select a phone in the list box, the application displays that phone's price.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-16 The Cell Phone Inventory application's form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-17 shows an example of the application at run time.
 * In the figure, five cell phones have been added, and Atlantic Mobil s2 has
 * been selected in the list box. The selected phone's price is displayed in
 * the message Box.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-17 The Cell Phone Inventory application running
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-7 Completed code for Form1 in the Cell Phone Inventory
 * application
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Cell_Phone_Inventory
 * {
 *  public partial class Form1 : Form
 *  {
 *      // List to hold CellPhone objects
 *      List<CellPhone> phoneList = new List<CellPhone>();
 *      
 *      public Form1()
 *      {
 *          InitializeComponent();
 *      }
 *      
 *      // The GetPhoneData method accepts a CellPhone object
 *      // as an argument. It assigns teh data entered by the 
 *      // user to the object's properties.
 *      
 *      private void GetPhoneData(CellPhone phone)
 *      {
 *          // Temporary variable to hold price.
 *          decimal price;
 *          
 *          // Get the phone's brand.
 *          phone.Brand = brandTextBox.Text;
 *          
 *          // Get the phone's model.
 *          phone.Model = modelTextBox.Text;
 *          
 *          // Get the phone's price.
 *          if(decimal.TryParse(priceTextBox.Text, out price))
 *          {
 *              phone.Price = price;
 *          }
 *          else
 *          {
 *              // Display an error message.
 *              MessageBox.Show("Invalid price");
 *          }
 *      }
 *      
 *      private void assPhoneButton_Click(object sender, EventArgs e)
 *      {
 *          // Create a CellPhone object
 *          CellPhone myPhone = new CellPhone();
 *          
 *          // Get the Phone data.
 *          GetPhoneData(myPhone);
 *          
 *          // Add the CellPhone object to the list
 *          phoneList.Add(myPhone);
 *          
 *          // Add an entry to the list box.
 *          phoneListBox.Items.Add(myPhone.Brand + " "+
 *          myPhone.Model);
 *          
 *          // Clear the TextBox controls.
 *          brandTextBox.Clear();
 *          modelTextBox.Clear();
 *          priceTextBox.Clear();
 *          
 *          // Rest the focus
 *          brandTextBox.Focus();
 *      }
 *      
 *      private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
 *      {
 *          // Get the index of the selected item.
 *          int index = phoneListBox.SelectedIndex;
 *          
 *          // Display the selected item's price.
 *          MessageBox.Show(phoneList[index].Price.ToString("c"));
 *      }
 *      
 *      private void exitButton_Click(object sender, EventArgs e)
 *      {
 *          // Close the form.
 *          this.Close();
 *      }
 *  }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 * 10.5 Finding the Classes and Their Responsibilities in a Problem
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When developing an object-oriented program, one of your first tasks is to 
 * identufy the classes that you will need to create. Typically, your goal is
 * to idenfify the different types of real-world objects that are present in 
 * the problem and then create classes in a given problem. One simple and 
 * popular technique involves the follwing steps:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 1. Get a written description of the problem domain.
 * 
 * 2.Identify all the norms (including and noun phrases) in the description.
 * Each of these is a potential class.
 * 
 * 3.Refine the list to include only classes that are relvant to the problem.
 * 
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Let's take a closer look at each of these steps
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Writing a Descritption of the Problem Domain
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The problem domain is the set of real-world objects, parties, and major 
 * events related to the problem. If you adequately understand the neture of 
 * the problem you are tyring to solve, you can write a description of the problem
 * domain yourself. IF you do not throughly understand the nature of the 
 * prblem, you should have an expert write the description for you.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * For ex, suppose we are programming an application that the manger og Joe's
 * Automotive Shop will use to print service qoutes for customers. Here is a
 * description that an expert, perhaps joe himself, might have written:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Joe's Automative Shop services foreign cars and specializes in servicing
 * cars made by Mercedes Benz, Porsche, and BMW. When a customer brtings a 
 * car to the shop, the manger gets the customer's name, address,
 * and telephone number. The manager then determines the make, model, and year
 * of the car and gives the customer a service quote. The service quote shows
 * the estimated parts charges, estimated labor charges, sales tax, and total
 * estimated charges.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The problem domain description should include any of the following:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * Physical objects such vehicles, machines, or products
 * 
 * * Any role played by a person, such as manager, employee, customer,
 *   teacher, student, and so forth
 * 
 * * The results of a business event, such as a customer order or,
 *   in this case, a service qoute
 * 
 * *Record-Keeping items, such as customer histories and payroll records
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Identify All of the Nouns
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The next step is to identify all of the mounes and noun phrases. (if the 
 * description contains pronouns, include them, too.) Here's another look at
 * the previous problem domain description. This time the nouns and noun
 * phrases appear in bold.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Notice that some of the nouns are repeated. The following list shows 
 * all the nouns without duplicating any of them:
 * 
 * address
 * 
 * BMW
 * 
 * car
 * 
 * customer
 * 
 * estimated labor charges
 * 
 * estimated parts charges
 * 
 * foreign cars
 * 
 * Joe's Automotive Shop
 * 
 * make 
 * 
 * manager 
 * 
 * Mercedes Benz
 * 
 * model
 * 
 * name 
 * 
 * Porsche
 * 
 * sales tax
 * 
 * service qoute
 * 
 * shop
 * 
 * telephone number
 * 
 * total estimated charges
 * 
 * year
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Refining the List of Nouns
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The nouns that appear in the problem description are merely candidates
 * to become classes. It might not be necessary to make classes for them all.
 * The next step is to refine the list to include only the classes that are
 * neccessary to solve the particular problem at hand. We look at the common
 * reasons that a noun can be eliminated from the list of potential classes.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 1. Some of the nouns really mean the same thing.
 *  In this example, the following sets of nouns refer to the same thing:
 *      * car, cars and foreign cars
 *      These all refer to the general concept of a car.
 *      
 *       * Joe's Automative Shop and shop
 *       Both of these refer to the company "Joe's Automotive Shop."
 *       We can settle on a single class for each of these. In this example,
 *       we arbitaraily eliminate cars and foreign cars from the list and 
 *       use the word car. Likewise, we eliminate Joe's Automotive Shop from the
 *       list and use the word shop. The updated list of potential classes is
 *       as follows:
 *       
 *       address 
 *       BMW
 *       car
 *       customer
 *       estimated labor charges
 *       estimated parts charges
 *       make 
 *       manager
 *       Mercedes Benz
 *       model
 *       name 
 *       Porsche
 *       sales tax
 *       service quote
 *       shop
 *       telephone number
 *       total estimated charges
 *       year
 *       
 *       
 *2. Some nouns might represent items that we do not need to be concerned
 *  with in order to solve the problem.
 *  
 *  A quick review of the problem description reminds us of what our application
 *  shovuld do: print a service quote. In this example, we can eliminate two
 *  unnecessary classes from the list:
 *  
 *  *We can cross shop off the list because our application needs to be concerned
 *  only with indivifual service quotes. If does not need to work with or determine
 *  any companywide information. If the problem decription asked us to keep a total of 
 *  all service qoutes, then it would make sense to have a class for the shop.
 *  
 *  *We will not need a class for the manager because the problem statement does
 *  not direct us to process any information about the manager. If there were 
 *  multiple shop menagers because the problem statement does not direct us to
 *  process any information about the manager.
 *  
 *  The updated list of potential classes at this point is as follows:
 *  address
 *  BMW
 *  customer
 *  estimated labor charges
 *  estimated parts charges
 *  make
 *  Mercedes Benz
 *  model
 *  name
 *  Porsche
 *  sales tax
 *  service qoute
 *  telephone number
 *  total estimated charges
 *  year
 *  
 *  3. Some of the nouns might represent objects, not classes.
 *  
 *  we can eliminate Mercedes, Porsche, and BMW as classes because, in this 
 *  example, they all represent specific cars and can be considered instances 
 *  of a car class. At this point, the update list of potential classes is as
 *  follows:
 *  
 *  address
 *  car
 *  customer
 *  estimated labor charges
 *  estimated parts charges
 *  make
 *  model
 *  name
 *  sales tax
 *  service quote
 *  telephone number
 *  total estimated charges
 *  year
 *  
 *  4. Some of the nouns might represent simple values that can be assigned
 *  to a variable and do not require a class. 
 *  A claa contains data attributes and methods. Data attributes are the 
 *  field and properties that degine the object's state. Methods are actions or
 *  behaviors that can be performed by an object of the class.
 *  
 *  If a noun represents a type of item that would not have any identifiable
 *  data attributes or methods, then it can probably be eliminated from the 
 *  list. To help determine whether a noun represents an item that would 
 *  have data attrbutes and methods, ask the following questions about it: 
 *  
 *  * Would you use a group of related values to represent the item's sate?
 *  
 *  * Are there any obvious actions to be performed by the item?
 *  
 *  IF the answers to both of these questions are no, then the noun probably
 *  represent a value that can be stored in a simple variable.
 *  If we apply this test answer to both of these questions are no, then
 *  the noun probably represents a value that can be stored in a simple
 *  variable.
 *  If we apply this test to each noun that remains in our list, we can
 *  conclude that the following are probably not
 *  classes: address, estimated labor charges, estimated parts charges, make,
 *  model, name, sales tax, telephone number, total estimated charges,-
 *  and year.
 *  These are all simple string or numeric values that can be stored in
 *  variables. Here is the updated list of potential classes"
 *  
 *  car
 *  Customer
 *  service qoute
 *  
 *  We have eliminate address, labor charges, estimated parts charges, make
 *  ,model, name, sales tax, telephone number, total estimated charges, and 
 *  year as classes because they represent simple values that can be stored
 *  in variables.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Note: Some object-oriented designers take nore of whether a noun is plural
 * or singular. Sometime a plural noun wiill indicare a class and a singular
 * noun will indicate an object.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * As you can see from the list, we have eliminated everything except car,
 * customer, and service qoute. This means that in our application, we need
 * classes to represent cars, customers, and servuce qoutes. ultimately, we
 * will write a Car class, a Customer class, and a ServiceQuote class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *              Identifying a Class's Responsibilities
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Once the classes have idenfigied, the next task is to identify each class's
 * responsibilities. A class's responsibilites are as follows:
 * 
 * * The things that the class is responsible for knowing
 * * The actions that the class is responsible for doing
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When you have identified the things that a class is responsible for knowing,
 * then you have identified the class's fields and /or properties. Likewise, 
 * when you have identified the actions that a class is responsible for doing,
 * you have identified its methods. 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * It is often helpful to ask these questions: In the contex of this problem,
 * what must the class know? What must the class do? The first palce to look
 * for answers is in the description of the problem domain. Many of the things
 * that a class must know and do will be mentioned. Some class responsibilities,
 * however, might not be directly mentioned in the problem domain, so brainstoring
 * is often required. Let's apply the methodology to the classes we previously
 * identified from our problem domain.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The Customer class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In the context of our problem domain, what must the Customer claa know?
 * The description directly mentions the following items:
 * 
 * * The customer's name
 * * The customer's address
 * * The customer's telephone number
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * These are all values that can be represented as strings as string and 
 * stored as properties. The Customer class can potentially know many other
 * things. One mistake tha can be made at this point is to identify too many
 * things that can object is responsible for knowing. In some applications, a
 * Customer class might know the customer's e-mail address. This particular 
 * problem domain does not mention that the customer's e-mail address is used 
 * for any purpose, so we should not include it as a responsibility.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Now let's identify the class's methods. In the context of the problem 
 * domain, what must the Customer class do? The only obvious actions are
 * these:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * Create and initialize an object of the Customer class.
 * * Get and set the customer's name.
 * * Get and set the customer's address.
 * * Get and set the customer's telephone number.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * These are all values that can be represented as strings and stores as
 * properties. The Customer class can potentially know many other things. One
 * mistake that can be made at this point is to identify too many things that
 * an object is responsible for knowing. In some applications, a Customer
 * class might know the customer's e-mail address. This particular problem
 * domain does not mention that the customer's e-mail address is used for any
 * purpose, so we should not include it as a responsibility.
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Now let's identify the class's methods. In the context of our problem domain,
 * what must the Customer class do? The only obvious action are these:
 * 
 * *Create an initialize an object of the Customer class.
 * *Get and set the customer's name.
 * *Get and set the customer's address.
 * *Get and set the cystomer's telephone number.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * From this list we can see that the Customer class will have a constructor
 * as well as fields and properties for the data attributes. The following code
 * shows how the Customer class might be written:
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * class Customer
 * {
 *      // Fields
 *      private string _name;
 *      private string _address;
 *      private string _phone;
 *      
 *      // Constructor
 *      public Customer(string name, string address, string phone)
 *      {
 *          _name = name;
 *          _address = addres;
 *          _phone = phone;
 *      }
 *      
 *      // Name property
 *      public string Name
 *      {
 *          get {return _name;}
 *          set {_name = value;}
 *      }
 *      
 *      // Address property
 *      public string Address
 *      {
 *          get {return _address;}
 *          set {_address = value;}
 *      }
 *      
 *      // Phone property
 *      public string Phone
 *      {
 *          get{return _phone;}
 *          set {_phone = value;}
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The Car Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In the context of our problem domain, what must an object of the Car class
 * know? The follwoing items are all data attributes of a car and are mentioned
 * in the problem domain:
 * 
 * * The car's make
 * 
 * * The car's model
 * 
 * * The car's year
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Now let's identify the class's methods. In the context of our problem
 * domain, what must the Car class do? 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * Create and initialize an object of the Car class.
 * *Get and set the car's make
 * *Get and set the car's model
 * *Get and set the car's year
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Car
 * {
 *      // Fields
 *      private string _make;
 *      private string _model;
 *      private int _year;
 *      
 *      // Constructor
 *      public Car(string make, string model, int year)
 *      {
 *          _make = make;
 *          _model = model;
 *          _year = year;
 *      }
 *      
 *      // Make property
 *      public string Make
 *      {
 *          get{return _make;}
 *          set{_make = value;}
 *      }
 *      
 *      // Model property
 *      public string Model
 *      {
 *          get{return _model; }
 *          set{_model = value; }
 *      }
 *      
 *      // Year property
 *      public int Year
 *      {
 *          get {return _model; }
 *          set {_model = value; }
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The ServiceQuote Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In the context of our problem domain, what must an object of the
 * ServiceQuote class know? The problem domain mentions the follwoing items:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * The estimated parts charges
 * * The estimated labor charges
 * * The sales tax
 * * The total estimated charges
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Careful thought and a little brainstorming reveals that two of these items 
 * are the results of calculations: sales tax and total estimated charges.
 * Furthermore, to calulate the sales tax, the class must also know the sales
 * tax rate.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Now let's identify the class's method. In the context of our problem domain,
 * what must the ServiceQuote class do? Once again, the only obvious actions
 * are the standard set of methods that we will find in most classes.
 * Specifically, the actions are these:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * * Create and initialize an object of the ServiceQoute class
 * * Get and set the estimated parts charges.
 * * Get and set the estimated labor charges.
 * * Get and set the sales tax rate.
 * * Get the sales tax.
 * * Get the total estimated charges.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The following code shows how the ServiceQoute class might be written:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class ServiceQoute
 * {
 *  // Fields
 *  private decimal _partsCharges;
 *  private decimal _laborCharges;
 *  private decimal _taxRate;
 *  
 *  // Constructor
 *  public ServiceQuote(decimal partsCharges, decimal laborCharges, decimal taxRate)
 *  {
 *      _partsCharges = partsCharges;
 *      _laborCharges = laborCharges;
 *      _taxRate = taxRate;
 *  }
 *  
 *  // PartsCharges property
 *  public decimal PartsCharges
 *  {
 *      get{return _partsCharges;}
 *      set{_partsCharges = value;}
 *  }
 *  
 *  // LaborCharges property
 *  public decimal LaborCharges
 *  {
 *      get{return _laborCharges;}
 *      set{_laborCharges = value;}
 *  }
 *  
 *  // TaxRate property
 *  public decimal TaxRate
 *  {
 *      get{return _taxRate;}
 *      set{_taxRate = value;}
 *  }
 *  
 *  // SalesTax property (read-only)
 *  public decimal TotalCharges
 *  {
 *      get
 *      {
 *          return _partsCharges + _laborCharges +
 *          (_partsCharges * _taxRate);
 *      }
 *  }
 *  
 * }    
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This Is Only the Begining 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You should look at the process that we have discussed in this section 
 * merely as a starting point. It's important to relize that designing an
 * object-oriented application is an iterative process. It may take you several
 * attempts to identify all the classes that you will need and determine all 
 * their responsibilities. As the design process unfolds, you will gain a 
 * deeper understanding of the problem, and consequently you will see ways to
 * improve the design.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 * 10.6 Application of Classes: Creating Multiple Forms in a Project
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Concept: A Visual C# project can have multiple forms. Each form has its
 * own class that can be instantiaed and displayed on the screen.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The applications you have created so far have used only one form, named 
 * Form1. The form1 form is displayed when the application runs, and when
 * the Form1 form closes, the application ends. You are not limited to one 
 * foem in a project, however. You may create multiple forms in a project to
 * use as dialog boxes, to display error messages, and so forth. Then you can
 * display these forms as they are nedded.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Every form in a Visual C# project has a class. For ex, if a project has a 
 * form named Form1, then the project has a class named Form1, which is stored
 * in a file named Form1.cs When you add additional forms to a project, you 
 * add additional classes, which are stored in their own files. When you create
 * event handlers for a specific form's controls, you write them as methods in
 * that form's class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Renaming the Form1 Form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When you add forms to a Visual C# project, they are given default names 
 * such as Form1, Form2, and so forth. If you have only one form in a project,
 * there is no compelling reason to change the form's name. However, when you 
 * have multiple forms in a project, you should give each form a meaningful name 
 * that describes its purpose.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Before you add a new form to a project it is a good idea to change the 
 * name of Foem1 form. In this book, we always change the name of the Form1
 * form to MainForm because it is usually the main form in an applciation. To
 * change the form's name, you use the Solution Explorer to change the name 
 * of the Form1.cs file to MainForm.cs. When you do this, Visual Studio
 * automatically changes the name of the Form1 form to MainForm.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-18 Right-click the form file in the Solution Explorer
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-19 Clicking Yes to rename the form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-20 Form file renamed as MainForm.cs
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Adding a New Form to a Project
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-21 Add New item window
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * After completing this, a new blank form is added to your project. The 
 * new form is displayed in the Designer, and an entry for the new form's
 * file appears in teh Solution Explorer. Figure 10-22 shows an example of
 * the Solution Explorer with two form files: ErrorForm.cs and MainForm.cs.
 * Once you have added a form to a project, you can place any control on it 
 * that you desire and write the necessary event handlers for it.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-22 Solution Explorer window showing two forms
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Switching between Form and Form Code
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In Visual Studio, you can easilt switch your view to anothe from by 
 * double-clicking the form's entry in the Solution Explorer window. The form
 * is then displayed in the Designer. You can also use the tabs that appear
 * for a project with two forms: ErrorForm and MainForm. The tabs that display
 * the [Design] designator cause a form to be displayed in the Design window.
 * The tabs that appear without the designator cause a form's code to be
 * displayed in the code editor.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-23 Designer tabs
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When you open a form in the code editor, you will see everal using
 * directives, a namespace declaration, and the form's class. Figure 10-24
 * shows an ex. The file in the figure contains the code for a form named 
 * ErrorForm. Notice that the form's class is named ErrorForm.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-24 A source code file containing a form class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Removing a Form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * If you wish to remove a form from a project and delete its file form the 
 * disk, follow these steps.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 1. Right-click the form's entry in the Solution Explorer window.
 * 
 * 2. on the pop-up menu, click Delete.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Displaying a Form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In your application's code, the first step in displaying a form is to
 * create an instance of the form's class. For ex, suppose a project has a
 * form named ErrorForm. The following statement creates an instance of the 
 * ErrorForm class:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * ErrorForm myErrorForm = new ErrorForm();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This statement declares a refence variable named myErrorForm. It also 
 * creates an object of the FrrorForm class in memory and assigns a reference
 * to the object t othe myErrorForm variable. After this statement executes,
 * you will be able to use the myErrorForm variable to perform operations with 
 * the form.
 * /////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Creating an instance of a form's class does not display the form on the 
 * screen. The next step is to call the form's ShowDialog method. Here is an
 * example:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * myErrorForm.ShowDialog();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The ShowDialog method displays a form on the screen, and it gives that 
 * form the focus. This means that control of the application transfers to
 * the form. When the user close the form, control of the application returns
 * to the point where the ShowDialog method was called, and executes resumes.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Now that we've covered the basic concepts of creating and displaying a 
 * form, go through the steps in Tutorial 10-5. In this tuorial, you create a
 * simple application that has two forms.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutorial 10-5: Creating an Application with Two Forms
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-25 Solution Explorer after changing Form1.cs to MainForm.cs
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-26 The MainForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-27 MessageForm added to the project
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-28 MessageForm
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-29 The MainForm and the MessageForm forms displayed
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-8 Completed code for the MessageForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Multiform_Practice
 * {
 *      public partial class MessageForm : Form
 *      {
 *          public MessageForm()
 *          {
 *              initializeComponent();
 *          }
 *          
 *          private coid closeButton_Click(object sender, EventArgs e)
 *          {
 *              // Close the form.
 *              this.Close();
 *          }
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-9 Completed code for the MainForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Multiform_Practice
 * {
 *      public partial class MainForm : Form
 *      {
 *          public MainForm()
 *          {
 *              initializeComponent();
 *          }
 *          
 *          private void displayFormButton_Click(object sender, EventArgs e)
 *          {
 *              // Create an instance of the MessageForm class.
 *              MessageForm myMessageForm = new MessageFoerm();
 *              
 *              // Display the form
 *              myMessageForm.ShowDialog();
 *          }
 *          
 *          private void exitButton_Click(object sender, EventArgs e)
 *          {
 *              // Close the form.
 *              this.Close();
 *          }
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Modal and Modeless Forms
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A form can be either modal or modeless. The ShowDialog method displays a 
 * form in modal fashion. When a modal form is displayed, no other form in 
 * the application can receive the focus until the modal form is closed. The
 * user must close the modal form before he or she can work with any other form
 * in the application. A modeless form, on the other hand, allows the user to 
 * switch focus to another form while it is displayed. The user does not have to
 * close a modeless form to switch focus to another form. If you want to display
 * a form in modeless form to switch focus to another form. If you want to 
 * display a form in modeless fashion, call its Show method.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * There is another important difference between modal and modeless forms.
 * When you call the ShowDialog method to display a modal form, control of 
 * the program is transferred to the form, and no statements appearing after
 * the ShowDialog method called will execute until the form is closed.
 * Figure 10-30 illustrates this concept.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-30 Execution of statements after displaying a modal form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When you call the Show method to display a modeless form, however, the 
 * statement that appear after the Show method call continue to execute while
 * the form is displayed. The application does not wait until the modesless
 * form is closed before executing these statements. Figure 10-31 illustrates 
 * this concept.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-31 Execution of statementes after displaying a modesless form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tip: Modeless form are typically used in special situations.
 * In most multiform applications, you will want to display forms in modal
 * fashon.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Accessing Controls on a Different Form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The controls that you place on a form have private access by default. This
 * means that a control that exists on a particaulat form can be accessed only
 * by code that is written in that form's class. With private access, you 
 * cannot write code in one form that accesses a control on another form.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You can change the access of a control by changing its Modifiers property
 * in the Properties window. If you change a control's Modifiers property to
 * Public, the control can be accessed by code outside the form's class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * For ex, suppose an application has a form named GreetingsForm, and 
 * GreetingsForm has a Label control named massageLabel. Furthermore, let's
 * assume that the messageLabel control's Modifiers property has been set
 * to Public. The following code shows how you can create an instance of
 * GreetingsForm, assigns a value to the MessageLabel control's Text property,
 * and then display the form:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * GreetingsForm greetingsForm = new GreetingsForm();
 * greetingsForm.messageLabel.Text = "Good day!";
 * greetingsForm.ShowDialog();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In Tutorial 10-6, you get a chance to create a multiform application in 
 * which code on one form creates an instance of another form and assigns 
 * values to controls on that form.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutorial 10-6 Accessing a Control on a Different Form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In this tutorial, you will create an application that allows the user to
 * select a food from the applications's main form, and then display a second
 * form that shows the selected food's nutritional information.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-32 The MainForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-33 The NutritionForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-34 The MainForm and the NutritionForm forms displayed at
 * run time
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-10 Completed code for the NutritionForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Food_Facts
 * {
 *  public partial class NutritionForm : Form
 *  {
 *      public NutritionForm()
 *      {
 *          initializeComponent();
 *      }
 *      
 *      private void closebutton_Click(object sender, EventArgs e)
 *      {
 *          //Close the form
 *          this.Close();
 *      }   
 *  }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-11 Completed code for the MainForm form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace Food_Facts
 * {
 *   public partial class MainForm : Form
 *   {
 *      public MainForm()
 *      {
 *          InitializeComponent();
 *      }
 *      
 *      private void displayButton_Click(object sender, EventArgs e)
 *      {
 *          // Create an instance of the NutririonForm class.
 *          NutritionForm nutriForm = new NutritionForm();
 *          
 *          // Find the selected radio button.
 *          if(bananaRadioButton.Checked)
 *          {
 *              nutriForm.foodLabel.Text = "1 banana";
 *              nutriForm.caloriesLabel.Text = "100";
 *              nutriForm.fatLabel.Text = "0.4";
 *              nutruForm.carbLabel.Text = "27";
 *          }
 *          else if (muffinRadioButton.Checked)
 *          {
 *              nutriForm.FoodLabel.Text = "1 large blueberry muffin";
 *              nutriForm.caloriesLabel.Text = "385";
 *              nutriForm.fatLabel.Text = "9";
 *              nutriForm.carbLabel.Text = "67";
 *          } else if (popcornRadioButton.Checked)
 *          {
 *              nutriForm.FoodLabel.Text = "1 cup air-popped popcorn";
 *              nutriForm.caloriesLabel.Text = "31";
 *              nutriForm.fatLabel.Text = "0.4";
 *              nutriForm.carbLabel.Text = "6";
 *          }
 *          
 *          // Display the NutritionForm.
 *          nutriForm.ShowDialog();
 *      }
 *    }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 10.7 Static Class Members
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Concept: A static class memeber belongs to the class, not objects
 * instantiaed from the class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A Quick Review of Instance Fields and Instance Methods
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Recall that each instance of a class has its own set of fields, which are
 * known as instance fields. You can create several instances of a class 
 * and store different values in each instance's fields. For ex, the Coin class
 * that we created earlier in this chapter has a field named sideUp. When you
 * call the calass's Toss method, the sideUp field, which is a string, is
 * randomly set to either "Heads" or "Tails". Let's say that myCoin references
 * an instance of the Coin class and we execute the follwoing statement:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * myCoin.Toss();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This statement stores a value in the sideUp field that belongs to the instance
 * that is referenced by myCoin. You can think of instance fields as belonging
 * to a specific instance of a class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You will also recall that classes may have instance methods as well. When 
 * you call an instance method, it performs an operation on a specific instance
 * of the class. For ex, assuming that myCoin references an instance of the Coin
 * class, look at the following statment:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * status = myCoin.SetSideUp();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * This statement calls the SetSideUp method, which returns the value of the 
 * sideup field that belongs to a specific instance of the Coin class: the one
 * referenced by myCoin. Both instance fields and instance methods are
 * associated with a specific instance of a class, and they cannot be used until
 * an instance of the class is created.
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Static Members
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * It is possible to create a field, property, or method that does not belong
 * to any instance of a class. Such members are know as static fields, static
 * properties, and static methods. When a value is stored in a static field
 * or static property, it is not stored in an instance of the class. In fact, 
 * an instance of the class doesn't even have to exist for values to be stored
 * in a static fields and static properties. Likewise, static methods do not 
 * operate on the fields or properties that belong to any instance of the class.
 * Instated, they can operate only on statc fields and static properties.
 * You can think of static fields, static properties, and static methods
 * as belonging to the class instead of an instance of the class. In this
 * section, we will take a closer look at static members. First we will examine
 * static fields.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Static Fields
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When a field is declared with the static keyword, there will be only one 
 * copy of the field in memory, regardless of the number of instances of the
 * class that might exist. A single copy of a class's static field is shared
 * by all instances of the class. For ex, the Countable class shown in the 
 * following code snippet uses a static field to keep count of the number of
 * instances of the class that are created
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Countable
 * {
 *      // Static field
 *      private static int instanceCount = 0;
 *      
 *      // Constructor
 *      public Countable()
 *      {
 *          instanceCount++;
 *      }
 *      
 *      // Method to get the value of instanceCount
 *      public int GetInstanceCount()
 *      {
 *          return instanceCount;
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Create three Countable objects.
 *  Countable obj1 = new Countable();
 *  Countable obj2 = new Countable();
 *  Countable obj3 = new Countable();
 *  
 *  // Get the number of instances.
 *  int numObjects = obj3.GetInstanceCount();
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-35 All instances share the static instanceCount field
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Note: C# automatically stores 0 in all uninitialized value-tyoe static fields
 * (or false in uninitialized static boolean fields), and null in uninitialized 
 * reference-type static fields. The instaceCount fields in the Countable class
 * is explicitly is explicitly intialized so it is clear to anyone reading the
 * code that the field starts with the value 0.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Static Properties
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A property can also be static. When a property is declaraed with the static
 * keyword, there will be only one copy of the property's value in memory,
 * regardless of the number of instances of the class that might exist. All 
 * instances of the class will share that one copy of the property's data. For
 * example, the following code snippet shows another version of the Countable
 * class. This version of the class uses a static property to keep count of the number
 * of instances of the class that are created.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Countable
 * {
 *     // Static property
 *     public static int InstanceCount{get; set;} = 0;
 *     
 *     // Constructor
 *     public Countable()
 *     {
 *      instanceCount++;
 *     }
 * }    
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When a static property, the code outside the class cannot use an instance
 * of the class to access that property. For ex, the following code snippet 
 * will cause an error.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Countable obj = new Countable();     // Create an instance of Countable
 * int numObjects = obj.InstanceCount;  // ERROR!
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When this code executes, the numObjects variable will be assigned the 
 * value 1. Another example follows. When this code excutes the numObjects
 * variable will be assigned the value 3.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *  // Create three Countable objects.
 *  Countable obj1 = new Countable();
 *  Countable obj2 = new Countable();
 *  Countable obj3 = new Countable();
 *  
 *  int numObjects = Countable.InstanceCount;
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * If you explicity declare the backing field for a static property, keep in
 * mind that mind that both the property and the backing field must be
 * declared static. Here is another example of the Countable class.
 * In this version of the class, the InstanceCount property is not implemented
 * as an auto-property. Its backing field is explicitly declared. Notice that 
 * in line 4 the _instanceCount backing field is declared static and in line
 * 7 the InstanceCount property is also ddeclared static.
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Countable
 * {
 *      // Backing field for the InstanceCount property
 *      private static int _instanceCount = 0;
 *      
 *      // InstanceCount property
 *      public static int InstanceCount
 *      {
 *          get{return _instanceCount;}
 *          set{_instanceCount = value;}
 *      }
 *      
 *      // Constructor
 *      public Countable()
 *      {
 *          InstanceCount++;
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Static Methods
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * When a class contains a static method, you don't have to create an instance
 * of the class in order to execute the method. The follwoing code snippet
 * shows an example of a class with static methods.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * class Metric
 * {
 *      // The following method converts miles to kilometers.
 *      public static double MilesToKilometers(double m)
 *      {
 *          return m * 1.609;
 *      }
 *      
 *      // The following method converts kilometers to miles.
 *      public static double KilometersToMiles(double k)
 *      {
 *          return k/1.609;
 *      }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A static method is created by placing the key word static after the access
 * specifier in the method header. The Metric class has two static methods:
 * MilesToKilometers and KilometersToMiles.
 * Because they are declared as static, they belong to the class and may be 
 * called without any instances of the class being in existence. You simply
 * write the name of the class before the dot operator in the method call. 
 * Here is an example:
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * double kilometers = Metric.MilesToKilometers(10.0);
 * double miles = Metric.KilometersToMiles(1606.0);
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The value that is returned from the method is assigned to the miles
 * variable. Notice that both the methods are called directly from the Metric
 * class, not from an instance of the class.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Static methods are convenient for many tasks because they can be called
 * directly from the class, as needed. They are most ofter used to create
 * utility classes that perform operations on data but have no need to collect
 * and store data. The Metric class is a good example.
 * It is used as a container to hold methods that convert miles to kilometers
 * and vice versa but is not intended to store data.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The only limitation that static methods have is that they cannot refer to
 * nonstatic of the class. This means that any method called from a static
 * method must also be static. It also means that if the method uses any of 
 * the class's fields or properties, they must be static as well.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Static Classes
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * You've seen that the static keyword can be used to declared fields,
 * properties, and methods as static. You can also use the static keyword to
 * declare a class as static. If you declare a class as static, then all the
 * members of the class must also be static. If a static class contains a 
 * nonstatic field, propertu, or method, a compiler error will occur.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * If a class is declared static, the compiler will not allow you to
 * instantiate the class. Also, static classes cannot have constructors. This
 * restriction makes sense because constructors are responsible for initializing
 * instances, and because static classes cannot be instantiated, there's no reason
 * for them to have constructors.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Tutorial 10-7: Creating a Simple Logging Utility with a Static Class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A logging utility is a class or set of classes that record information 
 * about a program's activity to a log file.
 * Log files are used for various purposes. For example, an audit log records
 * information about how a program is used, who uses it, when the program is
 * used, etc. A debugging log records diagonstic messages that can be used to 
 * track down and resolve errors in a program's code.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * In this tutorial, you will write a static class that works as a simple
 * logging utility. The class will have methods to open a log file, write
 * messages to the log file, and close the log file. You will then insert
 * statements into an application that uses the logging utility to record
 * information describing various events that take place during the program's
 * execution.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * The application that you will modify is the CredentialLogger application.
 * Its form is shown in Figure 10-36. The user enters a password into the 
 * passwordTextBox control and then clicks the continueButton control to check
 * the password. IF the password matches any of the passowords found in an 
 * array, the message "Password accepted" is displayed. Otherwise, the message
 * "Password not found" is displayed
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-36 The CredentialLoggger application's Form1 form
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Figure 10-37 Opening the log file
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-12 The Log class
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace CredentialLogger
 * {
 *  static class Log
 *  {
 *      // Write a message to the log file.
 *      public static void WriteLog(string filename, string str)
 *      {
 *          // Open the file.
 *          StreamWriter logFile = File.AppendText(filename);
 *          
 *          // Write the log entry.
 *          logFile.WriteLine(str);
 *          
 *          // Close the log file
 *          logFile.Close();
 *      }
 *      
 *      // Clear an existing log file.
 *      public static void ClearLogFile(string filename)
 *      {
 *          // Create a new log file.
 *          StreamWriter logFile = File.CreateText(filename);
 *          
 *          // Close the log file.
 *          logFile.Close();
 *      }
 *  }
 * }
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * Program 10-13 The completed Form1 code
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * namespace CredentialLogger
 * {
 *  public partial class Form1 : Form
 *  {
 *      // Array containing valid passwords
 *      private string[] passwords = {"019273u","oiahsd",
 *                                    "alished","uioh1234"};
 *      // Log file name
 *      private string logName = "logfile.txt";
 *      
 *      public Form1()
 *      {
 *          initializeComponent();
 *      }
 *      
 *      private void continueButton_Click(object sender, EventArgs e)
 *      {
 *          // Flag for validity
 *          bool valid = false;
 *          
 *          // Make an entry in the log file.
 *          Log.WriteLog(logName, "ContinueButton clicked.");
 *          
 *          Log.WriteLog(logName, "The user entered: " + passwordtextBox.Text);
 *          
 *          // Check the password
 *          foreach(string password in passwords)
 *          {
 *              if(passwordtextBox.Text == password)
 *              {
 *                  valid = true;
 *                  
 *                  // Make an entry in the log file.
 *                  Log.WriteLog(logName, password + " found in the array.");
 *              }
 *          }
 *          
 *          // Make an entry in the log file.
 *          Log.WriteLog(logName, "valid =" + valid.ToString());
 *          
 *          // Display the result
 *          if(valid)
 *          {
 *              MessageBox.Show("Password accepted");
 *          }
 *          else
 *          {
 *              MessageBox.Show("Password not found");
 *          }
 *      }
 *      
 *      private void Form1_Load(object sender, EventArgs e)
 *      {
 *          // Clear the log file.
 *          Log.ClearLogFile(logName);
 *      }
 *  }
 * }
 * //////////////////////////////////////////////////////////////////////////
 */