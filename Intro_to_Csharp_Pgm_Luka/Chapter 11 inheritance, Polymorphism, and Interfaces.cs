namespace ch11
{
    
}

/*/////////////////////////////////////////////////////////////////////
*
* /////////////////////////////////////////////////////////////////////
* Chapter 11: Inheritance, Polymorphism, and Interfaces
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Topics:
* 
* 11.1 Inheritance
* 11.2 Polymorphism
* 11.3 Abstract Classes
* 11.4 Extension Methods
* 11.5 Interfaces
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: Inheritance allows a new class to extend an existing class.
* The new class inherits the members of the class it extends.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Generalization and Specialization
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In the real world, you can find many objects that are specialized 
* varsions of other more general objects. For ex, the term insect
* desctibes a very general type of creature with numerous characteristics.
* Because grasshoppers and bumblebees are insects, they have all the 
* general characteristics of an insect. In addition, they have special
* characteristics of their own. For ex, the grasshopper has its jumping
* ability, and the bumblebee has its stiner. Grasshoppers and bumblebees
* are specialized versions of insects. This is illustrated in Figure 11-1.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-1 Bummblebees and grasshoppers, specialized versions of
* insects
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Inheritance and the "Is a" Relationship
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When one object is a specialized version of another object, there is 
* an "is a" relationship between them. For ex, a grasshopper is an insect.
* Here are a few other examples of the "is a" relationship:
* 
*  * A poodle is a dog
*  * A car is a vehicle.
*  * A flower is a plant
*  * A rectangle is a shape
*  * A football player is an althlete.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When an "is a" relationship exists between objects, it means that the 
* specialized object has all of the characteristics of the general
* object, plus additional characteristics that make it special. In 
* object-oriented programming inheritance is used to create an "is a"
* relationship among classes. This allows you to extend the
* capabilities of a class by creating another class that is a 
* Specialized version of it.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Inheritance involves a base class and a derived class. The base class 
* is the general class and ther derived class is the specialized class.
* You can think of the derived class as an extended version of the base
* class. Ther derived class inherites fields, properties, amd methods 
* from the base class without any of them having to be rewritten.
* Furthermore, new fields, properties, and methods may be added to the
* derived class, and that is what makes it a specialied version of the 
* base class.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: Base classes are somethimes called superclasses, and derived
* classes are somethimes callled subclasses. Either set of terms is
* correct. For consistency, this text uses the terms base class and 
* derived class.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Let's look at an example of how inheritance can be used. Suppose we 
* are developing an applicagtion that a dealership can use to manage
* its inverntory of used cars. The dealership's inverntory inclludes three
* types of automobiles: cars, pickup, trucks, and sport-utility vehicles
* (SUVs). Regardless of the type, the dealerrship keeps the following data
* about each automobile:
* 
* * Make
* * Year model
* * Mileage
* * Price
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Each type of vehicle that is kept in inventory has these general
* characteristices plus its iwn soecialized characteristics. For cars, 
* the dealership keeps the following additional data.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* *Number of doors (2 or 4)
* /////////////////////////////////////////////////////////////////////
* 
* For pickup trucks, the dealership keeps the following additional data:
* 
* *Deive type (two-wheel drive or four-wheel drive)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* And, for SUVs, the dealership keeps the following additional data:
* 
*   *Passenger capacity
*   
*   In designing this program, one approach would be to write the following
*   three classes:
*   
*   A Car class with properties for the make, year model, milage, price
*   , and the numbler of doors
*   
*   A Truck class with properties for the make, year model, mileage price
*   and drive type
*   
*   A SportUtility class with prioertues for the make, year model, mileage, 
*   price, and passenaer capacity
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This is an inefficient approach, however all three classes have a largs
* nuber of common properties. As a result, the classes would contains a 
* lot duplicated code. In addition, if we discover later that we need 
* to add more common attributes, we would have to modify all three 
* classes.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A better approach woulf be to write an Automobile base class to hold 
* all the general data about an automaibilr and then write derived 
* classes for each specified type of automobile. The following code shows
* the Automobile class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Automobile
* {
*   // Constructor
*   public Automobile()
*   {
*       Make = "";
*       Model = "";
*       Mileage = 0;
*       Price = 0m;
*   }
*   
*   // Properties
*   public string Make {get; set;}
*   public string Model {get; set;}
*   public int Mileage {get; set;}
*   public decimal Price {get; set;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Automobile class is a complete class for which we can create
* objects. However, the Automobile class holds only general data about
* ab automobile. It does not hold any of the specific pices of data that
* the dealership wants to keep about cars, pickup trucks, and SUVs. To
* hold data about those specific types of automobiles, we write derieved
* classes that inherit from the Automobile class. The following code 
* shows the Car class, which is derived from the Automobile class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Car : Automobile
* {
*   // Constructor
*   public Car()
*   {
*       Doors = 0;
*   }
*   
*   // Doors property
*   public int Doors {get; set;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Car : Automobile
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This line of code has some new notations. After the name of the class,
* Car, a colon appears, followed by the name of another class,
* Automobile, This line indicates that we are defining a class named Car,
* and it is derieved from the Automobile class. 
* The Car class is the derived class and the Automobile class is the
* base class.
* Figure 11-2 illustrates this notation.
* If we want to express the relationship between the Car class and
* Automobile class, we cam way that a Car os am Automobile.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-2 Inheritance notation in the class header
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Because the Car class is derived from the Auromobile class, the Car
* class inherits all the Automobile class's members, except its 
* constructor.
* (The purpose of the base class's constructor is to create an instance
* of the base class, so it makes sense that the derived class does not 
* inherit the base class's constructor.)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: Although the derieved class inherits the base class's private
* memners, it cannot directly access them. Only methods in the base class
* can directly access the base class's private members.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*
* /////////////////////////////////////////////////////////////////////
* * The base class constructor executes first. In this case, the 
* Automobile class's constructor is called, and it assigns empty strings
* to the Make and Model properties and 0 to the Milleage and Price 
* properties.
* 
* * The derived class constructor exectues next. In this case, 0 is assigned
* to the Doors property.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-3 The Car Demo project's Form1 form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When you run this app, enter sample car data into the text boxes and
* then click the Create Object button. The application will create an 
* object of the Car class and assign the data from the text boxes to the
* objcet's properties. It will then read and display the values of the 
* object's properties in the makeLabel, modelLabel, mileageLabel,
* piceLabel, and doorsLabel controls. Figure 11-4 shows an example of the 
* application's form, at run time, after the user has entered some data 
* and clicked the Create Object button.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-4 The car Demo application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-1 Form1 code in the Car Demo project
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Car_Demo
* {
*   public partial class Form1 : Form
*   {
*       public Form()
*       {
*           InitializeComponent();
*       }
*       
*       // The GetCarDAta method accepts a Car object as an 
*       // argument. It assigns the data enterend by the 
*       // user to the object's properties.
*       
*       private void GetCarData(Car car)
*       {
*           // Temporary variables to hold mileage, Price,
*           // and number or doors
*           
*           int mileage;
*           decimal price;
*           int doors;
*           
*           // Get the car's make.
*           
*           car.Make = makeTextBox.Text;
*           
*           // Get the car's model.
*           car.Model = modelTextBox.Text;
*           
*           // Get the car's mileage.
*           if(int.TryParse(mileageTextBox.Text, out mileage))
*           {
*               car.Mileage = mileage;
*               
*               // Get the car's price
*               if(decimal.TyrParse(priceTextBox.Text, out price))
*               {
*                   car.Price = price;
*                   
*                   if(int.TryParse(doorsTextBox.Text, out doors))
*                   {
*                       car.Doors = doors;
*                   }
*                   else
*                   {
*                       // Display an error message.
*                       MessageBox.Show("invalid number of doors");
*                   }
*               }
*               else
*               {
*                   // Display an error message.
*                   MessageBox.Show("Invalid price");
*               }
*           }
*           
*           else
*           {
*               // Display an error message.
*               MessageBox.Show("Invalid mileage");
*           }
*       }
*       
*       private voic createObjectButton_Click(object sender, EventArgs e)
*       {
*           // Create a Car object.
*           
*           Car myCar = new Car();
*           
*           // Get the car data.
*           GetCarData(myCar);
*           
*           // Display the car data.
*           makeLabel.Text = myCar.Make;
*           modelLabel.Text = myCar.Model;
*           mileageLabel.Text = myCar.mileage.ToString();
*           priceLabel.Text = myCar.Price.ToString("c");
*           doorsLabel.Text = myCar.Doors.ToString();
*       }
*       
*       private void exitButton_Click(object sender, EvenArgs e)
*       {
*           // Close the form.
*           this.Close();
*       }
*   }   
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Now let's take a look at the Truck and SportUtility classes, which
* are also derived from the Automobike class. Here is the code for the
* Truck class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Truck : Automobile
* {
*   // Constructor
*   publuc Truck()
*   {
*       Drive = "";
*   }
*   
*   // Frive property
*   public string Drive {get; set;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Truck class has a string property named Drive. This property
* holds a value such as "Four-Wheel Drive" or "Two-Wheel Drive." The 
* construvtors, which appears in line 4-7, assigns an empty string to
* the Drive property.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Now, let's look at the SportUtility class, which is also derived from
* the Automobile class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class SportsUtility : Automobile
* {
*   // Constructor
*   public Sportsutility()
*   {
*       Passengers = 0;
*   }
*   
*   // Passengers property
*   public int Passenger {get; get;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-5 The Car Truck SUV Demo project's Form1 form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-2 Form1 code in the Car Truck SUV Demo project
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Car_Truck_SUV_Demo
* {
*   public partial class Form1 : Form
*   {
*       public Form1()
*       {
*           initializeComponent();
*       }
*       
*       
*       private void createObjectButton_Click(object sender, EventArgs e)
*       {
*           // Create a Car object for a used 2001 BMW with 70,000
*           // miles, priced at $15,000, with doors.
*           
*           Car myCar = new Car();
*           myCar.Make = "BMW";
*           myCar.Model = "2001";
*           myCar.Mileage = 70000;
*           myCar.Price = 15000;
*           myCar.Doors = 4;
*           
*           // Create a Truck object for a used 2002 Tyota
*           // pickup with 40,000 miles, priced at $12,000,
*           // with four wheel drive.
*           Truck myTruck = new Truck();
*           myTruck.Make = "Toyota";
*           myTruck.Model = "2002";
*           myTruck.Mileage = 4000;
*           myTruck.Price = 12000;
*           myTruck.Drive = "Four Wheel Drive";
*           
*           // create a SportUtility object for a used 2000
*           // Volvo with 30,000 miles, priced at $15,500,
*           // with a passenger capacity of 5.
*           SportsUtility mySUV = new SportsUtility();
*           mysuv.Make = "Volvo";
*           mysuv.Model = "2000";
*           mysuv.Mileage = 3000;
*           mysuv.Price = 15500;
*           mysuv.Passengers = 5;
*           
*           // Display data about the truck.
*           MessageBox.Show(myTruck.Model + " "+ myTruck.Make +
*           " with " + myTruck.Mileage + " miles, priced at" +
*           myTruck.Price.ToString("c") + ", with " +
*           myTruck.Drive);
*           
*           // Display data about the SUV.
*           MessageBox.Show(mySUV.Model + " "+ mySUV.Make +
*           " with " + mySUV.Mileage + " miles, priced at" +
*           mySUV.Price.ToString("c") + ", with " + mySUV.Passengers +
*           " Passengers.");
*       } 
*       
*       private void exitButton_Click(object sender, EventArgs e)
*       {
*           // Close the form
*           this.Close();
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-6 Message boxes displayed by the Car Truck SUV Demo project
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 11-1: Creating and Testing the SavingsAccount and CDAccount
* Classes
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Bank Financial Systems, Inc., develops fincial software for banks and
* credit unions. The company is developing a new system that manages 
* customer accounts. Once of your tasks is to develope a class that 
* represents a savings account. The data that must be held by an
* object of this class 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * The account number
* * The interesnt rate
* * The account balance
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You must also develop a class that reprsnets a cetificate of deposit
* (CD) account. The data that must be help by an object of this class is
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* * The account number
* * The intrest rate
* * The account balance
* * The account maturity date
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* As you analyze these requirments, you realize that a DC account is really a specialized version of a savings account. The class that represents a CD will hold all the same data as the class that represents a savings account, pluse an extra propertu for the maturity date. You decide to create a SavingsAccount class to represent a savings account and then create a class that is derived from SavingsAccount, named CDAccount, to represesnt a CD account.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* To test classes, you will use them in an application that lets the 
* user enter data about a CD account, creates an object of the CDAccount 
* class, sets the object's properties to the data that the user entered,
* and then displauys the object's data. The application's form, which
* has already been created for you.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-7 The CD Account Test application's form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-8 The CD Account Test application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: The MaturityDate propertu in the CDAccount class implemented as
* a string. If you prefer, you can use the DateTime date type that we 
* discussed in Chapter 8.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-3 Completed code for the SavingsAccount.cs file in the 
* CS Account Test application
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* name CD_Account_Test
* {
*   class SavingsAccount
*   {
*       // Constructor 
*       public SavingsAccount()
*       {
*           AccountNumber = "";
*           IntrestRate = 0;
*           Balance = 0;
*       }
*       
*       // Properties
*       public string AccountNumber{get; set;}
*       public decimal IntrestRate{get; set;}
*       public decimal Balance {get; set;}
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-4 Completed code for the CDAccount.cs file in the CD
* AccountTest application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace CD_Account_Test
* {
*   class CDAccount()
*   {
*       MaturityDate = "";
*   }
*   
*   // MaturityDate property
*   public string MaturityDate {get; set;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-5 Completed code for Form1 in the CD Account Test application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace CD_Account_Test
* {
*  public partial class Form1 : Form
*  {
*   
*   public Form1()
*   {
*       InitializeComponent();
*   }
*   
*   // The GetCDDate method accepts a CDAccount object
*   // as an argument. It assigns the data entered by
*   // the user to the object;s properties.
*   
*   private void GetCDData (CDAccount account)
*   {
*       // Temporarty variables to hold interest rate
*       // and blance
*       
*       decimal interestsRate;
*       decimal balance;
*       
*       // Get the account number.
*       account.AccountNumber = accountNumberTextBox.Text;
*       
*       // Get the maturity date.
*       account.MaturityDate = maturityDateTextBox.Text;
*       
*       // Get the intrest rate.
*       if(decimal.TryParse(interestRateTextBox.Text, out intresetRate))
*       {
*           account.IntrestRate = interestRate;
*           
*           // Get the balance.
*           if(decimal.TryParse(balanceTextBox.Text, out balance))
*           {
*               account.Balance = balance;
*           }
*           else
*           {
*               // Display an error message
*               MessageBox.Show("Invalid balance");
*           }
*       }
*       else
*       {
*       MessageBox.Show("Invalid interest rate");
*       }
*   }
*   
*   private void createObjectButton_Click(object sender, EventArgs e)
*   {
*       // Create a DCAccount object
*       CDAccount myAccount = new CDAccount();
*       
*       // Get the CD account data.
*       GetCDDate(myAccount);
*       
*       // Display the CD account data.
*       accountNumberLabel.Text = myAccount.AccountNumber;
*       interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
*       balanceLabel.Text = myAccount.Balance.ToString("c");
*       maturityDateLabel.Text = myAccount.MaturityDate;
*   }
*   
*   private void exitButton_Click(object sender, EventArges e)
*   {
*       // Close the form
*       this.Close();
*   }
* }
*}
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Base Class and Derived Class Constructors
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When you create an instance of a derived class, the base class 
* constructor is executed. In all the examples that we have discussed
* so far, the base class and the derived class have parameterless 
* constructors. When you create an instance of a derived class, by default
* the base class's parameterless constructor is automatically executed.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* But what happens if the base class's constructor has parameters?
* or , what happens if the base class has multiple, overloaded
* constructors and you want to make sure a specific one callled? in either
* of theses situations, the derived class constructor must explicity call
* the base class constrictor.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* for ex, look at the following Rectangle class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Rectangle
* {
*   // Constructor
*   public Rectangle();
*   {
*       Length = 0;
*       Wide = 0;
*   }
*   
*   // Constructor
*   public Rectangle(int length, int width)
*   {
*       Length = length;
*       Width = width;
*   }
*   
*   // Properties
*   public int Length{get; set;}
*   public int Width {get; set;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following Box class is derived from the Rectangle class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Box : Rectangle
* {
*   // Constructor
*   public Box()
*   {
*       Height = 0;
*   }
*   
*   // Constructor
*   public Box (int length, int width, int height : base(length, width))
*   {
*       Height = height;
*   }
*   
*   // Height property
*   public int Height {get; set;}
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* IF you create an instance of the Box class, calling its parameterless
* constructor, the Rectangle class's parametersless constructor will be
* executed. Here is an another exanple:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Box myBox = new Box();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* After this statemetn executes, the myBox object's Length, Width, and
* Height properties will be set to 0.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* publuc Box(int length, int width, int height)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The constructor has three parameters: length, width, and height.
* Notice the following code in line 11:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* : base(length, width)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The base keyword refers to the base class. This is an explicit call 
* to the base class's parameterized constructor, passing length and 
* width as arguments. To understand how this works, consider the 
* following
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Box myBox = new Box(100, 200, 300);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This statement creates an instance of the Box class, passing 100 into
* the length paramter, 200 into the width parameter, and 300 into the 
* height parameter.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Summary of Constructor Issues in Inheritance
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* *When you create an instance of a derived class, the base class
* constructor is executed first and then the derived class constructor
* is executed.
* 
* *When you create an instance of a derived class, by default the base
* class's parameterless constrictor is automatically executed.
* 
* *IF you want to parameterized constructor in the base class to
* execute, you must explicitly call it from the derieved class's
* constructor. 
* You do this by writing the notation : base (parameterList) in
* the derieved class's constructor header.
* 
* 
* *IF the base class does not have a parameterless constructor,
* the derived class constructor must use the notation : base
* (parameterList) to call one og the base class's parameterized
* constructors.
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Restricting Inheritance with sealed Keyword
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You can use the sealed keyword to make sure that a class is not 
* inherited from, or that a method is not overridden. Here is an 
* example of a sealed class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* sealed class YourClass
* {
*   //Member declarations
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Because YourClass is sealed, a compiler error will occur if any 
* other class tries to use it as a base class. ALthough a sealed class
* cannot be inherited from, it can inherit from a base class. ex
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class MyClass
* {
*   // Member declarations
* }
* sealed class YourClass : MyClass
* {
*   // Member declarations
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When a method is declared with the sealed keyword, it cannot be
* overridden in a subclass. method header example:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class MyClass
* {
*   public virtual void Message()
*   {
*       // Code goes here
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class YourClass : MyClass
* {
*   public sealed void Message()
*   {
*       // Code goes here
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this example, YourClass inherits from MyClass and overrides the
* Message method. YourClass is not sealed so other classes may inherit from it.
* However, in YourClass, the MWessage method is sealed,
* so it cannot be overridden in any class that inherirs from YouClass.
* Technique can be used to to make sure that a particukar base class 
* method is used by subclasses and not a modified version of it.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
*                           11.2 Polymorphism
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: Polymorphism allows classes to have methods with the same 
* names as methods in their base classes. It gives the ability for a 
* program to call the method, depending on the type of object that is
* used to call it.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The term polymorphism refers to an object's ability to take different
* forms. It is a powerful feature of object-oriented programming. In 
* this section, we look at two essential ingredients of polymorphic
* behavior:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 1.The ability to define a method in a base class and then define a
* method with the same name in a derived class. When a derived class
* method has the same name as a base case method, it is often said
* that thederived class methods overrides the base class method.
* 
* 2.The ability to call the correct version of an overridden method, 
* depending on the type of object that is used to call it. IF a derived
* class object is used tp call an overriddent method, then the derieved
* class's version of the method is the one that executes. If a base 
* class object is used to call an overridden method, then the base
* class's version of the method is the one that executes.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Perhaps the best way to describe polymorphism is to demonstrate it, 
* so let's consicer a simple example. Look at the following code for
* the Animal class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Animal
* {
*   // Constructor
*   public Animal(string species)
*   {
*       Species = species;
*   }
*   
*   // Species property
*   public string Species {get; set;}
*   
*   // MakeSound method
*   public virtual void MamkeSound()
*   {
*       MessageBox.Show("Gerrrrrr");
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Here is an example of code that uses an instance of the Animal class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Animal myAnimal = new Animal("regular animal");
* MessageBox.Show("The species is " + myAnimal.Species);
* myAnimal.MakeSound();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Overriding Properties
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Properties in a base can be overridden in the same way that methods 
* can be overridden. In the base class, you write the virtual keyword
* in the property delcaration, as shown here:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Rectangle
* {
*   // Properties
*   public int Length{get; set;}
*   public int Width {get; set}
*   
*   public virtual int Area
*   {
*       get{return Length * Width;}
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Rectangle class declares LEngth and Width properties, and a
* virtual read-only Property named Area (notice the virtual keyword).
* The Area property returns the area of the rectangle, which is 
* calcualted as Length * Width.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Suppose we need a Box class to represent a box that has a length, 
* a width and a height. However, in the Box class, we will have to 
* override the Area property because the area of the three-dimensional
* box is calculated differently than the area of a two-dimensional
* rectangle. Here is an ex:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Box : Rectangle
* {
*   // Properties
*   public int Height {get, set;}
*   
*   public override int Area
*   {
*       get {return base.Area * Height;}
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Base Class Refernce Variables Know about Base Class Member Only
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A base class reference variable can reference an object of any class
* that is derived from the base class; however, there is a limit to what
* the base class variable can do with thowa objects. A base class reference
* varaible knows only about the member that are declared in the base class.
* If the derived class inttoduces methods, properties, or fields, a base 
* class reference variable cannot access them. For ex, look at the 
* following code:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Animal myAnimal = new Dog("Fido");
* MessageBox.Show("The species is " + myAnimal.Species);
* MessageBox.Show("The animal's name is " + myAnimal.Name); // ERROR!
* myAnimal.MakeSound();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The "Is a" Relationship Does Not Work in Reverse
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* It is important to understand that the "is a" relatoinship does work
* in reverse. Although the statement "a dog is an animal" is true, the
* statement "an animal is a dog" is not true. This is because all dogs
* are animals, but not all animals are dogs. So, the following statement
* will not compiler:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Dog myDog = new Animal("Dog");
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You cannot assign an Animal reference to a Dog variable. This makes
* sense because Dog object have capabilities that go beyond those of an
* Animal object
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: Interestingly, the C# compiler will allow you to make such an 
* assignment if you use a cast operator, as shown here:
* 
* Dog myDog = (Dog) new Animal("Dog");
* 
* However, an exception will be thrown at run time when the assignment
* takes place.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Passing Objects to Base Class Parameters
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Polymorphism gives you a great deal of flexibilty when designing
* applications. For ex, look at the following method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Private void ShowAnimalInfo(Animal animal)
* {
*   MessageBox.Show("Species: " + animal.Species);
*   animal.MakeSound();
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This method displayed information about an animal. Because it has an
* Animal variable as its parameter, you can pass an Animal object to the
* method when you call it. The method then displays the object's Species
* property and calls its MakeSound method.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The ShowAnimalInfo method works with an Animal object, but what if you 
* also need methods that display the same information about Dog objects
* and Cat objects? Do you need to write additional methods for each
* of these types? Because of polymorphism, the answer is no. In addition
* to Animal objects, you can also pass Dog objects or Cat objects as 
* arguments to the ShowAnimalInfo method previously shown.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In Tutorial 11-2, you complete an application that uses the Animal, 
* Dog, Cat classes to demonstrate polymorphism.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 11-2 Completing the Polymorphism Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this tutorial you complete the Polymorphism application, which
* demonstrates the Animal, Dog, and Cat classes shown in this section.
* The application also incorporates the ShowAnimalInfor method previously
* described.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The application's form, which has already been created for you, is 
* shown in Figure 11-9. When you run the completed application, clicking
* the Create an Animal button creates an object of the Animal class and
* passes the object to the ShowAnimalInfo method. Clicking the create a
* Dog button creates an object of the Dog class and passes that objec
* t to the ShowAnimalInfo method.
* Clicking a Cat button creates an object of the Cat class and passes
* that object to the ShowAnimalInfo method.
* /////////////////////////////////////////////////////////////////////
* 
* 
* /////////////////////////////////////////////////////////////////////
* Figure 22-9 The Polymorphism application's form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Progrm 11-6 Completed code for the Animal.cs file in the
* Polymorphism application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Polymorphism
* {
*   class Animal
*   {
*       // Constructor
*       public Animal (string species)
*       {
*           Species = species;
*       }
*       
*       // Species property
*       public string Species {get; set;}
*       
*       // MakeSound method
*       public virtual void makeSound()
*       {
*           MessageBox.Show("Grrrrrrrr";)
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-7 Completed code for the Dog.cs file in the Polymorphism
* application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Polymorphism
* {
*   class Dog : Animal
*   {
*       // Constructor
*       public Dog(string name) : base("Dog")
*       {
*           Name = name;
*       }
*       
*       // Name property
*       public string Name{get; set;}
*       
*       // MakeSound method
*       public override void MakeSound()
*       {
*           MessageBox.Show("Woof! Woof!");
*       }   
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-8 Completed .code for the Cat.cs file in the Polymorphism
* application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Polymorphism
* {
*   class Cat : Animal
*   {
*       // Constructor
*       public Cat (string name) : base("Cat")
*       {
*           Name = name;
*       }
*       
*       // name property
*       publuc string Name {get; set;}
*       
*       // MakeSound method
*       public override void MakeSound()
*       {
*           MessageBox.Show("Meow");
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-9 Completed code Form1 in the Polymorphism application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Polymorphism
* {
* public partial class Form1 : Form
* {
* 
*   public Form1()
*   {
*       InitializeComponent();
*   }   
*   
*   // The ShowAnimalInfo method accepts an Animal object as an argument.
*   // It displays the object's species and cells its MakeSound method.
*   
*   private void ShowAnimalInfo(Animal animal)
*   {
*       MessageBox.Show("Species: " + animal.Species);
*       animal.MakeSound();
*   }
*   
*   private void createAnimalButton_Click(object sender, EventArgs e)
*   {
*       Animal myAnimal = new Animal("Regular animal");
*       ShowAnimalInfo(myAnimal);
*   }
*   
*   private void createDogButton_Click(object sender, EvnetArgs e)
*   {
*       Dog myDog = new Dog("Fido");
*       MessageBox.Show("The dog's name is " + myDog.Name);
*       ShowAnimalInfo(myDog);
*   }
*   
*   private void createCatButton_Click(object sender, EvnetArgs e)
*   {
*       Cat myCat = new Cat("Kitty");
*       MessageBox.Show("The cat's name is " + myCat.Name);
*       ShowAnimalInfo(myCat);
*    }
*    
*    ptivate void exitButton_Click(object sender, EventAargs e)
*    {
*       // Close the form
*       this.Close();
*    }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
*                       11.3 Abstract Classes
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: An abstract class serves as a base class but is not instantiaed
* itself. An abstract method has no body and must be overridden in a 
* serived class.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Sometimes it does not make sense to instantiate a base class. For ex,
* consider a factory that manufactures airplanes. The factory does not
* make a generic airplane but makes two specific types of airplanes: a
* prop-driven plan and a commuter jet. The computer software that
* catalogs the planes might use a class named Airplane. The Airplane
* class has membersrepresenting the common characteristics of all
* airplanes. In addition, the software has a class named PropPlane
* and a class named CoummuterJet. Theses classes represents the
* two specific airplane models the factory manufactures and are derived
* from the Airplane class. The Airplane class is never instantiated but
* is used as a base class for the other classes.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* A class that is intenede to ne instantiated but is to be used only as
* a base class is called an abstract class. An abstract class serves as 
* a starting point, provifing some members for its ferived classes. 
* To declare a class as abstract, you use the abstract keyword in the 
* class header. Here is the gernal format:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* abstract class ClassName
* {
*   // Member declarations
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The primary difference between an abstact class and a regular class
* (which is sometimes called a concreate class) is that the abstract
* calass cannot be instantiated. A statement that tries to use the new
* operator to instantiate an abstract class will not compile
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Abstract classes can also contain abstract methods. An abstract
* method is a method that appears in a base class but expects to be
* overridden in a derived class. An abstract method has only a header
* and no body. In the header, the abstract keyword appearas before the 
* return type. Here is a very simple example of an abtract class that
* contains an abstract method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* abstract class Person
* {
*   public abstract void soSomething();
* } 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When an abstract method appears in a class it must be overridden in 
* any class that is dericed from the class. In this example, if a class
* if derived for the Person class, the derived class must override the
* DoSomething method.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Abstract classes can also contain abstract prperties. An abstract
* property is a property that appears in a base class but expects to be
* overridden in a derived class. In the property header, the abstract
* keyword appears before the property type. Here is a very simple
* example of an abstract class that contains an abstract method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* abstract class Person
* {
*   public abstract string JobTitle
*   {
*       get;
*       set;
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Notice that the abstract propery shows get and set accessors, but it
* does not specify what those accessors do. When an abstract property
* appears in a class, it must be overridden in any class that is 
* derived from the class. In this example, if a class is derived from the 
* Person class, the derived class must override the JobTitle property
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: If you want to create an abstrct read-only property, leave out
* the set accessor.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In Tutorial 11-3, you complete an application that uses an abstract
* base class with an abstract property.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 11-3: Completing the Computer Science Student Application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* IN this tutorial, you write an abstract class named Student. The Student
* class holds data that is common to all students, but does not hold
* all data needed for students of specific majors. The Student class
* is intended to be a base class that can be derived by other classes that
* represent student of specific majors.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The Student class has a Name property to hold a student's name and an 
* ID proeprty to hold a student's ID number. IT also has an abstract
* read-only property named RequiredHours. The purpose of the RequiredHours
* property it to hold the number of required hours for a specific major.
* Any class that is derived from the Student class must ooverride the
* RequiredHours property.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You also write a class naemd CompSciStudent, which is derived from 
* the Student class. The CompSciStudent class has a field named
* AcademicTrack,which holds the name of the student's academic track.
* It also overrides the RequiredHours property to calculate and return
* the number of houes required for a computer science major.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You will demonstrare the classes in the Computer Science Student
* application. The application's form, which has already been created 
* for you, is shown in Figure 11-10. When you run the completed application,
* you will enter a student's name and ID number into thw text boxes, and 
* you will select an academic track using the radio buttons. When you
* click the Set Required Hours button, the application will create a 
* CompSciStudent object, initialized with the data you enrtered. It will
* then get the value of the RequiredHours property and display it on the 
* form.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-10 The Computer Science Student applcaiton's form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-10 Completed code for the Student.cs file in the Computer
* Sience Student application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Computer_Science_Student
* {
*   abstract class Student
*   {
*       // Constructor
*       public Student(string name, string id)
*       {
*           Name = name;
*           ID = id;
*       }
*       
*       // Concreate Properties
*       public string Name {get; set;}
*       public string ID {get; set;}
*       
*       // RequiredHours property (abstract)
*       public abstract double RequiredHours {get;}
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-11 Completed code for the CompSciStudent.cs file in the 
* Computer Science Student applcaition
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Computer_Science_Student
* {
*   class CompSciStudent : Student
*   {
*       // Constants 
*       private double MATH_HOURS = 20;
*       private double CS_HOURS = 40;
*       private double GEN_HOURS = 60;
*       
*       //Fields
*       
*       private string _acedemicTrack;
*       
*       // Constructor
*       public CompSciStudent (string name, string id, string track) : base (name, id)
*       {
*           AcademicTrack = track;
*       }
*       
*       // AcademicTrack property
*       public string AcademicTrack {get; set;}
*       
*       // RequiredHours property
*       public override double RequiredHours
*       {
*       get {return MATH_HOURS + CS_HOURS + GEN_HOURS;}
*       }
*       
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* PRogram 11-12 Completed code for Form1 in the ComputerSCience Student
* application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Computer_science_Student
* {
*   public partial class Form1 : Form
*   {
*       public Form1()
*       {
*           InitalizeComponent();
*       }
*       
*       private void getHoursButton_Click(object sender, EventArgs e)
*       {
*           // Variables to hold input.
*           string name, id, track;
*           
*           // Get the student's name and ID
*           name = nameTextBox.Text;
*           id=idTextBox.Text;
*           
*           // Get the student's academic track.
*           if(infoSystemsRadioButton.Checked)
*           {
*               track = "Information Systems";
*           }
*           else
*           {
*               track = "Software Engineering";
*           }
*           
*           // Create a compSciStudent object
*           CompSciStudent csStudent = new CompSciStudent(name, id, track);
*           
*           // Display the student's required hours.
*           requiredHoursLabel.Text = csStudent.RequredHours.ToString("n1");
*           
*       }
*       
*       private void exitButton_Click(object sender, EventArgs e)
*       {
*           //Close this form
*           this.Close();
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
*                       11.4 Extension Methods
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: An extension method is a static method that extends classes
* and types in the .NET Framwork.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Suppose you want to extend a class, but you cannot inherit from it 
* because it is sealed. This might be the case when the class you want
* to extend is in the .NET Framework, or was written by someone other 
* than you. In this situation, you can use extension methods to exend
* the class. AN extendion method is a method that you can add onto a
* class without modifying the class or inheriting from it.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Extension methods can be applicaed to classes, structs, and
* interfaces (which are discussed later in this chapter). They can even
* be applied to primitive types like int and double.
* In fact, let's look at how can apply an extension method to the
* primatice int data type.
* Suppose we want int variables to have a method that wells us whether
* the variable is odd or even. For ex, we would like to do somthing
* like this
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* int number = 4;
* if(number.IsEven())
* {
*   MessageBox.Show("The number is even.");
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* To accomplish this, we need to define an extension method for the
* int type named isEven. The extensiomn method will return true of the
* number it is evaluating is event, or false otherwise
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Here are the key things to know about implementing an extendion method:
* 
* /////////////////////////////////////////////////////////////////////
* 
* *An extension method is a static method, stored in a static class.
* You can write multiple extension methods in the same static class.
* 
* *It is recommended to put the extension method's class in its own namespace,
* separeate from your project's namespce.
* 
* *An extension always has at least one parameter. The method's first
* parameter must be an object of the class or type that the method is
* extending. The declaration of the first parameter must begin with
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Here's an example of how we might implement the IsEven extension
* method previously shown:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace ExtensionMethods
* {
*   public static class Extension
*   {
*       public static bool IsEven(this int i)
*       {
*       returns (i % 2) ==0;
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This code ddefines a namesapce named ExtenMEthods, and inside that
* namespace is a static class named Extensions.
* (Any program that uses the exntension method will need need to have
* the statement using ExtensionMethod; in order to access the method.)
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*               this int 1
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The this keyword singnals the compiler that the method is an
* extension method.
* 
* The parameter i is an int, so the compiler knows that we are defining
* an extension method for the int data type. 
* 
* When the method executes, 
* the i parameter will reference the int variable that the method is
* working on.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-11 myValue is passed implicity ontp the i parameter
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note:
* An extension method can have multiple parameters. 
* The this keyword appearts only before the first parameter, however.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Extension method must have at least one parameter, preceded by the
* this keyword, to refer to the object that the method is working on. 
* If you need to explicity pass other arguments into an extension method, 
* just decalre additional parameters after the first paramter.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* public static bool IsGreaterThan(this int a, int b)
* {
*       return a > b;   
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-12 num1 is passed implicitly into the a parameter, and 
* num2 is passed explicilty into the b parameter
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: in an extension method, only the first parameter begins with 
* the this keyword.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Let's look at a complete application that demonstrates extension method.
* In chap11 fold of this book's Student Sample Programs, you will find
* a project named Extension methods.
* Figure 11-13 shows the application's form in the Designer.
* When the application runs, the user enters an integer into the 
* numberTextBox control and then clicks the goButton control.
* The application displays information about the number in the
* resultsListBox control. 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-13 The Extension Methods form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-13 The Extension class The Extensions class
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace ExtensionMethods
* {
*   public static class Extensions 
*   {
*       public static bool IsEvent(this int i)
*       {
*           return(i % 2) == 0;
*       }
*       
*       public static bool IsMultipleOf(this int a, int b)
*       {
*           return (a % b) == 0;
*       }
*       
*       public static bool IsWhileNumber(this double d)
*       {
*           return (d - (int)d) == 0;
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-14 The Form1 code for the Integer Extension Methods 
* application
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace Integer_Extension_Methods
* {
*   public partial class Form1 : Form
*   {
*       public Form1()
*       {
*            InitializeComponent();
*       }
*       
*           private void goButton_Click(object sender, EventArgs e)
*           {
    *           // Clear the ListBox
    *           resultsListBox.Items.Clear();
    *           
    *           // Make sure the number is an integer
    *       
    *           double dnum = double.Parse(numberTextBox.Text);
    *           if(dnum.IsWhileNumber())
    *           {
    *               resultsListBox.Items.Add("numberTextBox.Text");
    *               
    *               int inum = int.Parse(numberTextBox.Text);
    *               
    *               // Is inum even>
    *               if (inum.IsEven()) {
    *               resultsListBox.Items.Add("The nunber is even.");
    *               } else
    *                   {
    *                   resultsListBox.Items.Add("The nunber is odd.");
    *                }
    *               
    *               // Is the number a multiple of 5?
    *               if(inum.IsMultipleof(5))
    *               {
    *                   resultsListBox.Items.Add("The number is a multiple of 5.");
    *               }
    *               else
    *               {
    *                   resultsListBox.Items.Add("The number is not a multiple of 5.");
    *                   
    *               }
*             }  
*           }
*       }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 11- 4 Creating Extension Methods
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-15 The European DAte application's Form1 form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-17 The application's form at runtime
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-15 The Extension class
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace ExtensionMethods
* {
*       static class Extensions
*       {
*           public static string EuroDate(this string str)
*           {
*               string euroFormat;
*               char[] delim={'/'};
*               string[] tokens = str.Split(delim);
*               
*               // Validate the number of tokens and return the result.
*               if(tokens.Length == 3)
*                   euroFormat = toekns[1] + "/" + toekns[0] +"/"+toekns[2];
*               else
*                   euroFormat = str;
*                   
*               return euroFormat;
*           }
*       }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-16 The Form1 code
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace European_Dates
* {
*           public partial class Form1 : Form
*           {
*                   public Form1()
*                       {
*                            InitializeComponent();
*                       }
*               private void convertButton_Click(object sender, EventArgs e)
*                   {
*                       // Get the input enderted by the user.
*                       string input = dateTextBox.Text;
*                       
*                       // Display the converted output
*                       outputLabel.Text = input.EuroDate();
*                       
*                   }           
*           }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
*                         11.5 Interfaces
* /////////////////////////////////////////////////////////////////////
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Concept: An interface specifies behavior for a class.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An interface is like a class that contains only abstract methods and
* or abstaract properties. An interface cannot be instantiated.
* 
* Instead, it is implemented by other classes. When a class implements
* an interface.the class must provide all the methods and properties
* that are specifieds by the interface.
* 
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An interface declaration look similar to a class, except the keyword
* interface is used instead of the keyword class, and the methods that
* are specified in an interface have no bodies, only headers that are 
* terminated by semicolons. Also, any properties that are specified in an
* interface are abstract, and cannot contain any code other than the get and/
* or set keywords. Here is the general format of an interface definition.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* public interface InterfaceName
* {
*       Method headers and/or Properties..
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following shows an ex on an interface named IDisplayable.
* The interface specifies a void method named display(). 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   interface IDisplayable
*   {
*       void Display();
*   }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Notice that the Display method header in line 3 does not have an
* access specifier.
* This is because all methods and properties declared in an interface 
* are implicitly public.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Any class that implements the IDisplayable interface must provide an 
* implementation of the Display method (with the exact signature 
* specified by the interface, and with the same return type).
* 
* The Person class shown in the follwoing code snippet is an ex:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Class Person : IDisplayable
* {
*   // Name property
*   public string Name {get; set;}
*   
*   // Constructor
*   public Person(string n)
*   {
*       Name = n;
*   }
*   
*   // Display method, required by IDisplayable
*   public void Display()
*   {
*       MessageBox.Show("My name is " + name);
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The frst line of the class declararion is written as:
* 
* class Person : IDisplayable
* 
* also known as an interface header
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* After the name of the class, Person, a colon appears, followed by the
* name of the interface IDisplayable. This line indicates that we are 
* defining a class named Person, and it implements the IDisplauable interface.
* (This is the same syntax as delcaring a class that inherits from
* another class.) Because the Person class implements the IDisplayab;e
* interface, it must provide an implementation of the interface's 
* Display method.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   // Create an instance of the Psrson class.
*   Person p = new Person("Antonio");
*   
*   // Call the object's Display method.
*   p.Display();
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Note: IT is a common practive to begin the name of an interface
* with "I"
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Propertues in Interfaces
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* It is important to remember that an interface speficies methods and 
* properties that a class must have, but an interface never speficies 
* how a class class must implement thoes methods and properties. So,
* properties that are listed in an interface cannot ontain any code that
* the get and set keywords. If a property has both the get and 
* set keywords, then any class that implements the interface must 
* provifr the specified property with both a get acessor and a set
* accessor.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You can also specify read-only properties in an interface by omitting
* the set keyword. Here is an ex:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* interface IInventory
* {
*   decimal Cost { get; }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* This interface a read-only property named Cost. If a class implements 
* this interface, it too must provide a read-only property named Cost.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* An Interface is a Contract
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When a class implements an interface, it is agreeing to provide all 
* the methods and/or properties that are specified by the interface. It
* is often said that an interface is like contract, and when a class 
* implements an interface it must adhere to contract.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Creating an Interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-17 Example of a new interface source code file
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace InterfaceDemo
* {
*       interface IDisplayable
*       {
*       
*       }
* }
* 
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Tutorial 11-5: Writing and Implementing an Interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Board games, and other physical games, commonly have devices that are
* "tossed" in order to get a random value. For ex, a six-sided die can 
* be tossed to get a random value in the range of 1-6. A coin can be 
* tossed to get one of two values: heads or tails. You can think of 
* dice and coins as random-number generators for physical games. When
* used in games, dice and coins both have the following behaviors in
* common:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   *   They can be tossed
*   *   Tossing them generates a random value
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In this tutorial, you complete the CoinDice application. You will write
* a Die class to simulate a six-sided die, and a Coin class to simulate
* a coin. You will also write an interface named ITossable that both the
* the Die class and the Coin class will implement. The ITossable interface
* will specify the following members:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   *A method named Toss. The Toss method will cause the implementing 
*   object to generate a random value.
*   
*   *An int property named Value. This property will hold the most recent
*   value that the implementing object generated.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The application's form, which has already been created for you, is 
* shown in Figure 11-19. When you run the completed application, you 
* can click the Toss and Coin button and the application will simulate
* a coin being tossed, displaying either Heads or Tails in the CoinLabel
* control. You can click the Toss and Die button and the application 
* will simulate a 6-sided die being tossed, displaying its value in
* the dieLabel control.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-19 The CoinDice application's form
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Figure 11-20 The ITossable interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-18 The completed ITossable interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace CoinDice
* {
*   interface ITossable
*   {
*       int Value {get; set;}
*       void Toss();
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-19 The completed Dice class
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace CoinDice
* {
*   class Die : ITossable
*   {
*       public int Value {get; set; } = 1;
*       
*       public void Toss()
*       {
*           Rand rand = new Random();
*           Value = rand.Next(6)+1;
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-20 The completed Coin class
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace CoinDice
* {
*   class Coin : ITossable
*   {
*       public int Value {get; set; } = 0;
*       
*       public void Toss()
*       {
*           Random rand = new Random();
*           Value = rand.Next(2);
*       }
*       
*       public string HeadsorTails()
*       {
*           if(Value == 0)
*           return "Heads";
*           else
*           return "Tails";
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Program 11-21 COmpleted code for the Form1.cs file in the CoinDice
* applciation
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* namespace CoinDice
* {
*   public partial class Form1 : Form
*   {
*       // Fields for the coin and the die
*       private Coin coin = new Coin();
*       private Die die = new Die();
*       
*       public Form1()
*       {
*           InitializeComponent();
*       }
*       
*       private void tossCoinButton_Click(object sender, EventArgs e)
*       {
*           // Toss the coin.
*           coin.Toss();
*           
*           // Display the side that is up.
*           coinLabel.Text = coin.HeadsorTails();
*       }  
*       
*       private void tossDieButton_Click(object sender, EventArgs e)
*       {
*           // Toss the die
*           die.Toss();
*           
*           // Display the side that is up.
*           dieLabel.Text = die.Value.ToString();
*       }
*   }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*                 Implementing Multiple Interfaces
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* You might be wondering why we need both abstract classes and interfaces,
* since theu are so similar to each other. One reason is that a class
* can inherit for only one base class, but c# allows a class to
* implement multiple interfaces. When a class implements multiple
* interfaces, it must provide the methods and properties specified by 
* all the interfaces.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* To specify multiple interfaces in a class declaration, simply list 
* the names of the interfaces, sepated by commas, after the colon. Here
* is an example of a class that implements mnuttiple interfaces:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class MYClass : IDisplayable, IComparable, IRelatable
* {
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The name of the class is MyClass, and it implements three interfaces:
* IDisplayable, IComparable, and IRelatable.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Declaring a Derived Class that implements an Interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* When you are declaring a class that inherits from a base class and 
* implements an interface, the name of the base class must appear
* first after the colon in the derived class header. If the name of 
* the base class does not appear first, and error will occur at compile
* -time.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* For ex, suppose we have a class named Person and an interface named
* IDisplayable. Here is the declaration of a class named Customer that
* is derieved from the Person class and implements the IDisplayable
* interface
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Customer : Person, IDisplayable
* {
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code shows the declaration of a class named Customer
* that is derived from the Person class 
* and implementes three interfaces: IDisplayable, IComparable, and 
* IRelatable:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class Customer : Person, IDisplayable, IComparable, IRelatable
* {
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Polymorphism and Interfaces
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Just as you can create reference variables of a class type, C# allows
* you to create reference variables of an interface type. An interface
* reference variable can reference any object that implements that 
* interface, regardless of its class type. This is another example
* of polymorphism. For ex recall ITossable interface and the Die and 
* Coin classes that you wrote in Tutorial 11-5. Look at the following 
* code sinippet:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ITossable tossable = new Die();
* tossable.Toss();
* MessageBox.Show(tossable.Value.ToString());
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Line 1 creates a Die object and assigns that object to the tossable
* variable. Even though tossable in an ITossable variable, it can 
* reference Die objects because the Die class implements the ITossable
* interface. Line 2 calls the tossable object's Toss method, and line 3 
* displays the tossable object's Value property in a message box.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code sinppet demonstrates the same steps can be taken 
* with a Coin object:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ITossable tossable = new Coin();
* tossable.Toss();
* MessageBox.Show(tossable.Value.ToString());
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Although an ITossable variable can reference objects of any class that 
* timplements the ITossable interface, there is a limit to what the 
* variable can do with those objects. Recall that the ITossable interface
* specifies only two things: a property named Value and a method named
* Toss. So, an ITossable variable can be used only to access the Value 
* property and call the Toss method, regardless of the type of object 
* the variable references. For example, look at the following code:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* ITossable tossable = new Coin();          // This works
* tossable.Toss();                          // This works
* MessageBox.Show(tossable.HeadsOrTails()); // ERROR!
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The last statement in this code snippet causes a compiler error because
* it attempts to use the tossable variable to call the HeadsOrTails
* method. Event though the tossable variable references a Coin object,
* the variable does not know about any of the object's methods or
* properties other than the ones declared in the ITossable interface.
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The ability to refernce an object with anb interface variable is
* particulary useful when passing objects to methods. For ex, suppose
* a business sells digital songs and movies, for download, on their
* website. The business' e-commerce software uses two classes:
* DigitalSong and DigitalMovie. Each of these classes implements the 
* following implements the following IRetail interface:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* interface IRetail
* {
*   decimal RetailPrice(get; set;)
* }
* 
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The IRetail interface specifies a decimal property named RetailPrice.
* So, the DigitalSong and DigitalMovie classes must each have this
* property. Here is the DigitalSong class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class DigitalSong : IRetail
* {
*   public string Title {get; set;}         // Song title
*   public string Artist {get; set;}        // Name of artist
*   public decimal RetailPrice{get; set;}   // Retail Price
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* And here is the DigitalMoview class:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* class DigitalMovie : IRetail
* {
*   public string Title {get; set;}         // Movie title
*   public int RunningTime {get; set;}      // Length in minutes
*   public decimal RetailPrice {get; set;}  // Retail Price
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Suppose we need a method that displays the retail price of either a 
* digital song or a difital movie. We could write two separate methods,
* one that has a DigitalSong parameter, and another that has a
* DigitalMovie paramter. However, since we need only the object's retail
* price, a better approach would be to write one method that has an
* IRetail parameter. Cecause an IRetail variable can refernce either
* a DigitalSong object or a DigitalMovie object, we can use the variable
* to retrieve the retail price of either type of object. Here is an ex of
* such a method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* static void DisplayRetail(IRtail item)
* {
*   MessageBox.Show(item.RetailPrice.ToString());
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet shows how we can pass either a
* DigitalSong object or a DigitalMovie object as an argument to the 
* DisplayRetail method:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
*   // Create a DigitalSong object.
*   DigitalSong song = new DigitalSong()
*   {
*       Title = "Wipe The Tears From My Eyes",
*       Artist = "Billy Nelson",
*       RetailPrice = 1.0m
*   };
*   
*   // Create a DigitalMovie object.
*   DigitalMovie movie = new DigitalMovie()
*   {
*       Title = "It Came From Planent X",
*       RunningTime = 102,
*       RetailPRice = 14.95m
*   };
*   
*   // Display each object's retail price.
*   DisplayRetail(song);
*   DisplayRetail(movie);
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Array and List of Interface References
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Polymorphism allows us to create arrays and List s of interface
* references. The following code snippet creates an array of IRetail
* object that is initialized with both DigitalSong and DigitalMovie
* objects:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* IRetail[] items = {
*       new DigitalSong()
*       {
*           Title = "Sunshine On My shoulder",
*           Artist = "Joe Looney",
*           RetailPrice = 0.99m
*       },
*       new DigitalSong()
*       {
*           Title = "Sunshine On My shoulder",
*           Artist = "Joe Looney",
*           RetailPrice = 0.99m
*       },
*       new DigitalMovie()
*       {
*           Title = "It Came From Planet X",
*           RunningTime = 102,
*           RetailPRice = 14.95m
*       }, new DigitalMovie()
*       {
*           Title = "A Nighjt in Paris",
*           RunningTime = 124,
*           RetailPrice = 16.95m
*       }
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* In the RetailItem array, elements 0 and 1 are DigitalSong objects, 
* and elements 2 and 3 DigitalMovie objects. The following code snippet
* shows how we can use a foreach loop to iterate over the arrays
* elements, passing each one to the DisplayRetail method that was
* previously shown:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* foreach (IRetail item in items)
* {
*   DisplayRetail(item);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet creates a List of IRetail objects that is
* initialized with both DigitalSong and DigitalMovie objects:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* List <IRetail> itemList = new List<IRetail>
* {
*   new DigitalSong()
*       {
*           Title = "Sunshine On My shoulder",
*           Artist = "Joe Looney",
*           RetailPrice = 0.99m
*       },
*       new DigitalSong()
*       {
*           Title = "Sunshine On My shoulder",
*           Artist = "Joe Looney",
*           RetailPrice = 0.99m
*       },
*       new DigitalMovie()
*       {
*           Title = "It Came From Planet X",
*           RunningTime = 102,
*           RetailPRice = 14.95m
*       }, new DigitalMovie()
*       {
*           Title = "A Nighjt in Paris",
*           RunningTime = 124,
*           RetailPrice = 16.95m
*       }
* };
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* The following code snippet shows how we can use a foreach loop to 
* iterate over the List elements, passing each one to the DisplayRetail
* method that was previously shown:
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* foreach (IRetail item in itemList)
* {
*   DisplayRetail(item);
* }
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Restrictiions of Interfaces
* /////////////////////////////////////////////////////////////////////
* 
* /////////////////////////////////////////////////////////////////////
* Interfaces are restricted in several ways. Here are some important
* limitations to keep in mind:
* 
*   * You cannot declare any fields within an interface. Only properties
*   and methods are allowed.
*   
*   * Properties that are declared in an interface are abstract, so they
*   cannot contain any code other than the get and/or set keywords.
*   
*   *Methods that are declared in an interface are abstract, so they
*   cannot contain any code.
*   
*   *All the members of an interface are public, so you cannot list an
*   access modifier with any property or methods in an interface.
*   
*   *Interfaces cannot have a constructor.
*   
*   *You cannot declare a class, structure, enumeration or other
*   interfaces inside of an interface.
*   
*   *Interfaces can only inherit from other interfaces. An interface 
*   cannot inherit from a class.
* /////////////////////////////////////////////////////////////////////
* 
*/
