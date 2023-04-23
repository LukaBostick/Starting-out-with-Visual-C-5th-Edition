namespace Chapter7ArraysandLists
{
    class main
    {
        static void Main(string[] args)
        {
            
        }
    }
}

/* /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				    Chapter 7 Arrays and Lists
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *                          Topics
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 7.1 Value Types and Reference Types
 * 
 * 7.2 Array Basics
 * 
 * 7.3 Working with Files and Arrays
 * 
 * 7.4 Passing Arrays as Arguments to Methods
 * 
 * 7.5 Some Useful Array Alogrithms
 * 
 * 7.6 Advanced Algorithms for Sorting and Searching Arrays
 * 
 * 7.7 Two-Dimensional Arrays
 * 
 * 7.8 Jagged Arrays
 * 
 * 7.9 The List Collection
 * 
 * 7.10 The ImageList Control
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 7.1 Value Types and Reference Types
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///Concept The data types in C# and the .NET Framework fall into
///two categories: value types and reference types.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In this chapter, you will gain more experience working with objects.
///Specifically, you will work with arrays and collectons, which are 
///objects that store groups of data. Before we go into the details of 
///creating and working with those objects, it will be helpful for you
///to understand how objects are stored in memory. In this section, we
///discuss the ways that different types of objects are internally stored
///in memory. In this section, we discuss the ways that different types 
///of objects are internally stored bt the .NET Framework. As a result, 
///you will better understand the concepts persented in this chapter, and
///chapters to come.
///////////////////////////////////////////////////////////////////////
///
/// //////////////////////////////////////////////////////////////////
/// All the data types in C#- and the underlying .NET Framework-fall 
/// into categories: value types and reference types. Of the C# data
/// types that you have used so far, the following data types: int,
/// double, decimal, bool. (There are other value types in addition to
/// these, but these are the ones we focus on in this book.)
 * ////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you declare a value type variable, the compiler sets aside, or 
 * allocates, a chunk of memory that is big enough for that variable.
 * For example, look at the following variable declarations:
 * /////////////////////////////////////////////////////////////////////
 * 
 * ////////////////////////////////////////////////////////////////////
 * int wholeNumber;
 * double realNumber;
 * decimal moneyNumber;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Rec
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-1 Memory allocated
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The memory that is allocated for a value type variable is the actual
 * location that will hold any value that is assigned to that variable.
 * For example, suppose we use the following statements to addign values
 * to the variables shown in Figure 7-1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * wholeNumber = 99;
 * realNumber = 123.45;
 * moneyNumber = 800.0m;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-2 shows how the assigned values are stored in each variabl's
 * memory location.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-2 Values assigned to the variables
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * As you can see from these illustrations, value types are very 
 * straightforward. When you are working with a value type, you are
 * using a variable that holds a piece of data.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This is different from the way that reference types works. When you
 * are working with a reference type, you are using two things:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *An object that is created in memory
 * 
 * *A variable that references the object
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The object that is created in memory holds data of some sort and 
 * perform operations of some sort. (Exactly what the data and operations
 * are depends on what kind of object it is.) In order to work with the 
 * object in code, you need some way to refer to it. That's where the 
 * variable comes in.
 * The variable does not hold an actual piece of data with which your 
 * program will work. instead, it holds a special value know as a reference
 * , which links the variable to the object^1. When you want tot work with
 * the object, you use the variable that references it. 
 * /////////////////////////////////////////////////////////////////////
 * 1 A fererence is similar to a memory address. It is a value that 
 * identifies the object's memeory location.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A variable that is used to reference an object is commonly called a 
 * reference variable. Reference variables can be used only to reference
 * objects. Figure 7-3 illustrates two obejcts that have been created in 
 * memory, each referenced by a variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-3 Two objects referenced by variables
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To understand how reference variables and objects work together, think
 * about flying a kite. In order to fly a kite, you need a spool of string 
 * attached to it. WHen the kite is airborne, you use the spool of string
 * to hold onto the kite and control it. This is similar to the relationship
 * between an object and the variable that references the object. AS shown
 * in Figure 7-4, the object is like the kite, and the variable that references
 * the object is like the spool of string.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-4 The kite and string metaphor
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Creating a reference type object typically requires the following 
 * two steps:
 * 
 * 1. You deaclare a reference variable.
 * 2. You create the object and associate it with the reference variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After you have performed these steps, you can use the reference variable
 * to work with the object. Let's look at an example that you have already
 * learned about: creating objects of the Random calss. Recall from Chapter 5
 * that the Random class allows your program to generate random numbers. 
 * Here is an example of how you create an object from the Random class:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Random rand = new Random();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * LEt's look at the differenc parts of this statement:
 * 
 * *The first part of the statement, appearing on the left side of the
 * = operator, reads Random rand. This declares variable named rand that
 * can be used to reference an object of the Random type.
 * 
 * *The second part of the statement, appearing on the right side of the 
 * object. So, the expression new Random() creates an object from the 
 * Random class and returns a reference to that object.
 * 
 * *THe = operator assigns the reference that was returned from the new
 * operator to the rand variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this statemet executes, the rand variable references a Random
 * object, as shown in Figure 7-5. The rand variable can then be used to
 * perform operations with the object, sucj as generating random numbers.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-5 The rand variable referencing a Random object.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *                           7.4 Array Basics
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: An array allows you to store a group of items of the same 
 * data type together in memory. Processing a large number of items in an
 * array is usually easier than processing a large number of items stored
 * in separate variables.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the programs you have written so far, you have used variables to
 * store data in memory. The simplest way to store a value in memory is 
 * to store it in a variable. Variables work well in many sutuations, but
 * they have limitations. For example, they can hold only one value at a 
 * time. Considfer the following variable declaraion:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int number = 99;
 * /////////////////////////////////////////////////////////////////////
 * 
 * ////////////////////////////////////////////////////////////////////
 * This statement declares an int variable named number, initialized with
 * the value 99. Consider what happends if the following statement 
 * appears later in the program:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number = 5;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement assigns the value 5 to number, replacing the value 99
 * that was previously stored there. 
 * Because number is an ordinaty (???) variable, it can hold only value at
 * a time.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because variables hold only a single value, they can be cumbersome in
 * process lists of data. For example, suppose you are asked to write a
 * program that holds the names of 50 employees. image declaring 50 
 * variables to hold all those names:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * string employee1;
 * string employee2;
 * string employee3;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * and so forth...
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * string employee50
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Then, imagine writing the code to process all 50 names. For example,
 * if you wanted to display the contents of the variables in a ListBox,
 * you would write code such as this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * employeeListBox.Items.Add(employee1);    // Display employee 1
 * employeeListBox.Items.Add(employee2);    // Display employee 2
 * employeeListBox.Items.Add(employee3);    // Display employee 3
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * and so forth...
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * emplyeeListBox.Items.Add(emplyee50); // Display emplyee 50
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * As you can see, variables are not well suited for storing and processing
 * lists of data. Each variable is a seperate item that must be declared and
 * individually processed.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Fortunately, you can use an array as an alternative to group of
 * variables. An array is an object that can hold a group of values that
 * are all the same data type. You can have an array of int values, an 
 * array of double values, and array of decimal values, or an array of 
 * string values, but you cannot store a muxture of data types in an
 * array. Once you create an array, you can write simplea and efficient
 * code to process the values that are stored in it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * ////////////////////////////////////////////////////////////////////
 * Arrays are reference type objects. Recall from Section 7.1 that two
 * steps are required to create an use a reference type object:
 * 
 * 1. You delcare a reference variable.
 * 
 * 2. You create the object and associate it with the reference variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Suppose you want to create an array that can hold int values. Here is
 * an example of how you might declare a reference variable for the array:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int[] numbersArray;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement declares a reference variable named numbersArray. Notice
 * that this statement looks like a regulat int variable declaration except
 * for the set of brackets ([]) that appear after the keyword int. The
 * expression int[] indicates that this cariable is a reference to an int
 * array. So, we cannot use this variable to store an int value. Rather, we
 * can use it to reference ant int array.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The next step in the process is to create the array object ans associate
 * it the the numbersArray variable. The following statemenet shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * numbersArray = new int[6];
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * As previously mentioned, the new keyword creates an object in memory.
 * The expression that appers after the new keyword specified what type
 * of object to create. In this case, the expression int[6] specifies that
 * the object should be an array large enough to hold six int values. The
 * number inside the brackets is the array's size declarator. It indicates
 * the number of values that the array should be able to hold.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The new keyword also returns a reference to the object that it creates.
 * In the previously shown statement, the new keyword creates an int array
 * and returns a refenece tp that array. The = operator assigns the references
 * to numbersAray variable. After this statement executes, the numbersArray variable will reference an int array that can hold six values. This is shown in Figure 7-6.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-6 The numbers
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the prevoise examplem we used two statement to (10 decare a reference
 * variable ans (2) create an array object. These two steps can be combined 
 * into one statement, as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int[] numbersArray = new int[6];
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can create arrays of any data. The following are all valid array
 * declarartions:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * duble[] temperatures = new double[100];
 * decimal[] prices = new decimal[50];
 * string[] nameArray = new string[1200];
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * ////////////////////////////////////////////////////////////////////
 * An array's size declarator must be a nonnegative interger expression,
 * It can be a literal value, as shown in the previous examples, or a
 * variable. It is preferred practice to use a named constant as a size
 * declarator, however, Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * const int SIZE = 6;
 * int[] numberArray = new int[SIZE];
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This practice can make programs easier to maintain. As you see later 
 * in this chapter, many array-processing techniques require you to refer
 * to the array's size. When you use a named constant as an array's size 
 * declator, you can use the constant to refer to the size of the arrays
 * size. When you use a named constant as an array's sizr declarator, you
 * can use the constant to refer to the size of the array in your algorithms.
 * If you ever need ot modify the program so the array is a different size,
 * you need only change the value of the named constant.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Array Elements and Subscripts
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The storage location in an array are known as elements. In memory, an 
 * array's elements are located in consecutive memory locations. Each
 * element in an array is assigned a unique number know as a subscript.
 * Subcripts are used to identify specific elements in an array. The 
 * first element is assigned the subscript 0, the second element is 
 * assigned the subscript 1, and so forth. For example, suppose a prgram 
 * has the following seclarations:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * const int SIZE = 5;
 * int[] numbersArray = new int [SIZE];
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * As shown in Figure 7-7, the array referenced by numbersArray has five
 * elements. The elements are assigned the subscripts 0-4.
 * (Because subscript numbering starys at 0, the subscript of the last 
 * element in an array is 1 less than the total number of elements in
 * the array.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-7 Array subscripts
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Array Element Default Values
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that Figure 7-7 shows each element of the array containing the
 * value 0. When you create a numeric array in C#, its elements are set
 * to the value 0 by default.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Remember, you can create an array to hold any type of value. It is 
 * possible to create an array of reference type object. If you create an
 * array of reference type object, each element of the array acts as a
 * reference variable. By default, the elements of an array of reference
 * type objectss are set to the special value null. The value null indicates
 * that a reference variable is not set to a valid object and cannot be used for 
 * any meaningful purpose.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: As you will see in Chapter 8, strings are actully reference
 * types, so the default value of a string array's elements is null.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Working with Array Elements
 * /////////////////////////////////////////////////////////////////////
 * 
 * ////////////////////////////////////////////////////////////////////
 * You access the individual elements in an array by using their subscripts
 * . For example, the following code creates an int array with five elements
 * and assigns values to each of its elemets.
 * * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * const int SIZE = 5;
 * int[] numbersArray = new int[SIZE];
 * numbersArray[0] = 20;
 * numbersArray[1] = 30;
 * numbersArray[2] = 40;
 * numbersArray[3] = 50;
 * numbersArray[4] = 60;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The code assings the value 20 to element 0, the value 30 to element 1
 * , and so forth. Figure 7-8 shows the contents of the array after these
 * statements execute.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-8 Values assigned to each element
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: The expression numbersArray[0] is pronounced "numbersArray sub
 * zero."
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code shows another example. It creates a string array with
 * three elements and assigns strings to each of its elements.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * const int SIZE = 3;
 * string[] names = new string[SIZE];
 * names[0] = "Chris";
 * names[1] = "Laurie";
 * names[2] = "Joe";
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code sample shows how values can be assigned from TextBox
 * controls to array elements. Assusmen that an applicaior's form has 
 * three TextBox controls named amount1TextBox, amount2TextBox, and 
 * amount3TextBox and that the user has entered a numeric value into
 * each one. The following code creates a decimal array named amounts and
 * assigns each of the TextBox control's input value to an array element.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * const int SIZE = 3;
 * decimal[] amounts = new decimal[SIZE];
 * amounts[0] = decimal.Parse(amount1TextBox.Text);
 * amounts[1] = decimal.Parse(amount1TextBox.Text);
 * amounts[2] = decimal.Parse(amount1TextBox.Text);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at a complete program that demonstrates how to assign values
 * to an array and then display the values in the array. In the Chap07
 * folder of this book's Student Sample Program, you will find a prject named 
 * Display Elements. Figure 7-9 shows the application's form.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 7-9 The Display Elements application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the code for the getNameButton_Click event handler
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void getNamesButton_Click(object sender, e)
 * {
 *      // Create an array to hold strings.
 *      const int SIZE = 3;
 *      string[] names = new string[SIZE];
 *      
 *      // Get the names.
 *      
 *      names[0] = name1TextBox.Text;
 *      names[1] = name1TextBox.Text;
 *      names[2] = name1TextBox.Text;
 *      
 *      // Display the names.
 *      MessageBox.Show(names[0]);
 *      MessageBox.Show(names[1]);
 *      MessageBox.Show(names[2]);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * ////////////////////////////////////////////////////////////////////
 * Run the applicaiton, enter a name into the TextBox controls, and then
 * click the Get Names button. The following actions take place:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *In line 5, an array to hold three strings is created.
 * 
 * *In lines 8-10, the names that you entered into the TextBox controls are
 * assigned to the array elements.
 * 
 * *In lines 13-15, each element of the arrayis displayed in a message box.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Display Elements application displays the contents of a string
 * array. Because the array's elements are strings, we can pass each
 * element directly to the MessageBox.Show method without performing a date
 * type conversion. If you want to pass a numeric array element to the
 * MessageBox.Show method, however, you will have to call the element
 * , you will have to call the elment's ToString method. The following
 * code sample demonstrates: 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create an array to hold three interger.
 *  const int SIZE = 3;
 *  int[] myValues = new int [SIZE];
 *  
 *  // Assign some value to the array elements
 *  
 *  myValues[0] = 10;
 *  myValues[1] = 20;
 *  myValues[2] - 30;
 *  
 *  // Display the array elements.
 *  MessageBox.Show(myValues[0].ToString());
 *  MessageBox.Show(myValues[1].ToString());
 *  MessageBox.Show(myValues[2].ToString());
 *  
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Array Initialization
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * WHen you create an array, you can optionally initialize it with a group
 * of values. Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Const int SIZE = 5;
 * int[] numberArray = new int [SIZE]{10,20,30,40,50};
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The series of values inside the braces and separated with commas is 
 * called an initialization list. These values are stored in the array
 * elements in the order they appear in the list. (The first value, 10, is
 * stored in numbersArray[0], the second value, 20, is stored in
 * numbersArray[i], and so forth.))
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you provide an initializzation list , the size delcararion can 
 * be left out. The compiler determines the size of the array from the 
 * number of items in the initialization list. Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int[] numbersArray = new int[] {10,20,30,40,50};
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this example, the compiler determines that the array should have
 * five values appear in the initialization list. You can also leave out
 * the new operator and its subsequent experssion when an initializaiton
 * list is provided. Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int[] numberArray = {10,20,30,40,50};
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here are three separate examples that declare and initialize a string 
 * array named days. Each of these examples result in the same array:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Example 1
 *  const int SIZE = 7;
 *  string[] days = new string[SIZE] = {"Sunday","Monday",
 *  "Tuesday","Wednesday","Thursday", "Firday", "Saturday"};
 *  
 *  // Example 2
 *  string[] days = new string[] = {"Sunday","Monday",
 * "Tuesday","Wednesday","Thursday","Firday", "Saturday"};
 * 
 *  // Example 3
 *  string[] days ={"Sunday","Monday","Tuesday",
 *                  "Wendesday","Thursday","Firday"
 *                  "Saturday"};
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Using a Loop to Step through an Array
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can store a number in an int variable and then use that variable
 * as a subscript. This makes it possible to use a loop to step through
 * an array, performing the same operation on each element. For example,
 * look at the following code sample:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Create an array to hold three integers.
 *  
 *  const int SIZE = 3;
 *  int[] myValues = new int[SIZE];
 *  
 *  // Assign 99 to array element.
 *  for(int index = 0; index < SIZE; index++)
 *  {
 *      myValues[index] = 99;
 *  }
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * Line 3 creates an int array named myValues with three elements. THe
 * for loop that starts in line 6 uses an int variable named index as
 * its counter. The index variable is initialized with the value 0 and 
 * is incremented after each loop iteration. The loop iterates as long
 * as index is less than 3. So, the loop will iterate three times. As
 * it iterates, the index variable is assigned the values 0,1, and 2.
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * Inside the loop, the statement in line 8 assigns the value 99 to an
 * array element, using the index variable as the subscript. This is what
 * happens as the loop iterates:
 * 
 * * The first time thje loop iterates, index is set to 0, as 99 is
 * assigned to myValues[0].
 * 
 * * The second time the loop iterates, index is set to 1, so 99 is
 * assigned to myValue[1].
 * 
 * * The first time the loop iterates, index is set to 2, so 99 is
 * assigned to myValues[2].
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Invalid Subscripts
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When working with an array, it is important that you do not use an 
 *  invalid subscript. You cannot use a subscript that is less than 0
 *  or greater than the size of the array minus 1. For example, suppose
 *  an array has 100 elements. The valid subscripts for the array are the
 *  integers 0 through 99. If you try to use any value outside this range,
 *  an exception, will be thrown at runtime. The following code sample
 *  decmonstrates how a loop that is not carfully written can cause such an
 *  exception to be thrown:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create an array to hold three integers.
 *  const int SIZE = 3;
 *  int[] myvalues = new int[SIZE];
 *  
 *  // Will this loop cause an exception?
 *  for(int index = 0; index <= SIZE; index++)
 *  {
 *      myValue[index] = 99;
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice that the for loop iterates as long as index is less than or
 *  equal to 3. During the loop's last iteration, indexis set to 3, so the 
 *  statement in line 8 attempts to make an assignment to myValues[3]. There
 *  is no element in the array with the subscript 3, so an exception will
 *  be thrown.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The Length Property
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In C#, all arrays have Length property that is set to the number of 
 *  elements in the array. For example, consider an array created by the 
 *  following statemet:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  double[] temperatures = new double[25];
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The temperatures array's Length property will be set to 25. If we 
 *  executed the following statemet, it would display the message 
 *  "The temperatures array has 25 elements"
 *  /////////////////////////////////////////////////////////////////////
 *
 * /////////////////////////////////////////////////////////////////////
 * MessageBox.Show("The temperatures array has " + temperatures.Length
 * + " elements.");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  The Length property can be useful when processing the entire contents 
 *  of an array with a loop. The subscript of the last element is always
 *  1 less than the array's Length property. Here is an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  for(int index = 0; index < temperatures.Length; index++)
 *  {
 *      MessageBox.Show(temperatures[index].ToString());  
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Note: An array's Length property is read only, so you cannot change its
 *  value.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In Tutorial 7-1, you complete an application that generates a set of 
 *  random numbers similar to those used in lotteries. The numbers will be
 *  stored in an array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Tutorial 7-1: Using an Array to Hold a List of Random Lottery Numbers
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In this tutorial, you complete an application that randomly generates
 *  lottery numbers. The application's form is shown in Figure 7-10. When
 *  the Generate Numbers button is clicked, the application will generate
 *  five two-digit integer numbers and store them in an array. The contents
 *  of the array will then be displayed in Label controls
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-10 The Lottery Numbers application's form
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Step 1: Start Visual Studio. Open the project named Lottery Numbers in
 *  the Chapt07 folder of this book's Student Sample Programs.
 *  
 *  Step 2: Open the Form1 form in the Designer, Double-click the
 *  generateButton control. This will open the code editor, and you will
 *  see an empty event handler named generateButton_Click. Complete the
 *  generateButton_Click event handler by typing the code shown in lines
 *  22-41 in Program 7-1. Let's take a closer look at the code:
 *  
 *  Line 23:This statement declares an int constant named SIZE, set to the value 5. This used as an array size declarator.
 *  
 *  Line 24: This statement creates an int array named lotteryNumbers with five elements.
 *  
 *  Line 27: This statement creates a Random object, referenced by a variable named rand.
 *  
 *  Line 31: This for loop uses an int variable named index as its counter.
 *  The index variable is initialized with the value 0 and is incremented after each 
 *  loop iteration. The loop iterates as long as index is less than
 *  lotteryNumbers.Length (which is 5). So, the loop will iterate five times,
 *  As it iterates, the index variable is assigned the values 0,1,2,3, and 4.
 *  
 *  Line 33: THis statement gets a tandom number to lotteryNumbers[0]. The second 
 *  time the loop iterates, this statment assigns a random number to lotteryNumbers[1].
 *  This continues until the loop is finished. At that time, each element in the 
 *  array is assigned a tandom number.
 *  
 *  Lines 37-41: These statements display the array elements in the
 *  firstLabel, secondLabel, thirdLabel, fourthLAbel, and fifthLabel
 *  controls.
 *  
 *  Step 3: Switch your view back to the Designer and double-click the
 *  exitButton control. In the code editor you will see an empty event 
 *  handler named exitButton_CLick. Complete the exitButton_Click event
 *  handler by typing the code shown in lines 46-47 in Program 7-1.
 *  
 *  Step 4: Save the project. Then, press F5 on the keyboard, or click
 *  the Start Debugging button (|>) on the toolbar to compile and run the
 *  application. When the application runs, click  the Generate Number button.
 *  
 *  The application should display a set of random numbers in the Label controls.
 *  Click the Generate Numbers button several more times to see different 
 *  sets of random numbers. When you are finishedm click the Exit button 
 *  to exit the application.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Program 7-1 Completed code for Form1 in the Lottery Numbers 
 *  application 
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Watching for Off-by-One Errors
 *  /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because array subscripts star at 0 rather than 1, you have to be 
 * carful not to perform an off-by-one error. An off-by-one-error 
 * occurs when a loop iterates one time too many or one time too few. For
 * example, look at the following code sample:
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * // Create an array to hold three integers.
 * const int SIZE = 100;
 * int[] myValues = new int[SIZE];
 * 
 * // Assign 99 to each array elememt.
 * 
 * for(int index = 1; index < myValues.Length; index++)
 * {
 *      myValues[index] = 99;
 * }
 * /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 * The intent of this code is to create an int array with 100 elements and 
 * assign the value 99 to each element; however, this code has an off-by
 * -one error. During the loop's execution, the index variable is assigned the 
 * values 1 through 99 when it should be assigned the values 0 through 99. 
 * As a reseult, the first element, which is at subscript 0, is skipped.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 * Using the foreach Loop with Arrays
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  C# provides a special loop that, in many circumstances, simplifies 
 *  array processing. It is known as the foreach loop. When you use the 
 *  foreach loop with an array, the loop automatically iterates once for
 *  each element in the array. For example, if you use the foreach loop 
 *  with an eight-element array, the loop will iterate eight times.
 *  Because the foreach loop automatically knows the number of 
 *  elements in an array, you do not have to use a counter variable to
 *  control its iterations, as with a regular for loop.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The foreach loop is designed to work with a temporary, read-only 
 *  variable known as the iteration variable. Tach time the foreach loop 
 *  iterates, it copies an array element to the iteration variable.
 *  For example, the first time the loop iterates, the iteration variable
 *  will contain the value of element 0 , the second time the loop
 *  iterations, as with a regular for loop.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The foreach loop is designed to work with a temporary, read-only
 *  variable known as the iteration variable. Each time the foreach
 *  loop iterates, it copies an array element to the iteration variable.
 *  For example, the first time the loop iterates, the iteration variable will
 *  contain the value of the element 0, the second time the loop iterates, 
 *  the iteration variable will contain the value of element 1, and so forth. 
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Here is the general format of the foreach loop:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  foreach(Type VariableName in ArrayName)
 *  {
 *      statement;
 *      statement;
 *      etc.
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The statments that appear inside the curlt braces are the body of the 
 *  loop. These are the statements executed each time the loop iterates.
 *  As with other control structures, the curly braces are optional if the 
 *  body of the loop contains only one statement, as shown in the following 
 *  general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * foreach(Type VariableName in ArrayName)
 *  statement;
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at the items appearing inside the
 * parentheses:
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * * Type is the data type of the values in the array.
 * 
 * * VariableName is the name of the iteration variable.
 * 
 * * in is a keyword that must appear after the VariableName
 * 
 * *ArrayName is the name of an array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 * Suppose we have the following array declaration:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  int[] numbers = {3,6,9};
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  We can use the following foreach loop to display the contents of 
 *  the numbers array:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  foreach(int val in numbers)
 *  {
 *      MessageBox.Show(val.ToString());
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Because the numbers array has three elemets, this loop will iterate 
 *  three times. The first time it iterates, cal will contain the value
 *  of numbers[0], so a message box will display the value 3.
 *  During the second iteration, val will contain the value of numbers[1],
 *  so a message box will display the value 6. During the thrid iteration,
 *  val will contain the value of number[2], so a message box will display
 *  the value 9.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The foreach Loop versus the for Loop
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When you need to read the values that are stored in an array from the 
 *  first element to the last element, the foreach loop is simpler to
 *  use than the for loop. With the foreach loop, you do not have to be 
 *  converned about the size of the array, and you do not have to create a 
 *  counter variable to hold subscripts; however, because the iteration 
 *  varuable is read only, there are circumstances in which the foreach
 *  loop is not adequate. You cannot use the foreach loop if you need to do
 *  any of the following 
 *  
 *      * Change the contents of an aeeay element
 *      * Work through the array element in reverse order
 *      * Access some, but not all, of the array elements
 *      * Simultaneously work with two or more arrays with the loop
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In any of these circumstances, you should use the for loop to process
 *  the array.
 *  /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Reassigning an Array Reference Variable 
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 *  It is possible to reassign an array reference variable to a different
 *  array, as demonstrated by the following code sample:
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * // Create an array referenced by the numbers variable.
 * int[] numbers = new int[6];
 * 
 * // Reassign the numbers variable to a new array.
 * numbers = new int[3];
 * /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * The statement in line 2 creates a six-element int array. A reference
 * to the array is assigned to the numbers variable. Figure 7-11 Shows
 * how the numbers variable references the six-element array after this
 * statement executes.
 * /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-11 The numbers variable referencing a six-element array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Then, the statement in line 5 creates a new, three-element int array.
 *  A reference to the new array is assigned to the number variable. When
 *  line 5 executes, the reference that is currently stored in the 
 *  numbers variable will be replaced by a reference to the three-element
 *  array. After this statement executes, the numbers variable will reference
 *  the three-element array instead of the six-element array.
 *  This is illustrated in Figure 7-12.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-12 The numbers variable referencing a three-element array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice in Figure 7-12 that the six-element array stil exists in 
 *  memory, but it no longer referenced by any varialbles. Becaue it is 
 *  no longer referenced, it cannot be accessed. When an object is no
 *  longer referenced, it becomes eligible for garbagge collection. Garbage
 *  collection is a process that periodically runs, removing all
 *  unreferenced objects from memory.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *  7.3 Working with Files and Arrays
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: For some problems, files and arrays can be used together 
 *  effectively. You can easily write a loop that saves the contents of 
 *  an array to a file, and vice versa.
 *  /////////////////////////////////////////////////////////////////////
 *  
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Some tasks may require you to save the contents of an array to a file
 * so the data can be used at a later time. Likewise, some situations may
 * require you to read the data from a file into an array. For example,
 * suppose you have a file that contains a set of values and you want to
 * reverse the order of the values. One technique for doing this is to 
 * read the file's values into an array and then write the values in the
 * array back to the file from the end of the array to the beginning.
 * /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Writing an Array's Contents to a File
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Writing the contents of an array to a file is a straightforward 
 *  procedure: Open the file and use a loop to steo through each element
 *  of the array, writing its contents to the file. For examplem in the
 *  Chap07 folder of the Student Sample Programs, you will find a project 
 *  named ArrayToFile. When you click the OK button, the application
 *  writes the contents of an int array to a file. The following code
 *  shows the Click event handler for the OK button.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void okButton_Click(object sender, EventArgus e)
 *  {
 *      try
 *      {
 *          // Create an array with some value.
 *          int[] numbers = {10,20,30,40,50};
 *          
 *          // Declare a StreamWriter variable.
 *          StreamWriter outputFile;
 *          
 *          outputFile = File.CreateText("Values.txt");
 *          
 *          // Write the array's contents to the file.
 *          for(int index =0; index < numbers.Length; index++)
 *          {
 *              outputFile.WriteLine(numbers[index]);
 *          }
 *          // Closr the file
 *          outputFile.Close();
 *          
 *          //Let the user know it's done.
 *      }
 *      catch(Exception ex)
 *      {
 *          // Display an errror message.
 *          MessageBox.Show(ex.Message;)
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The try-catch statement handles any file-related errors. Here is a 
 *  summary of the code inside the try block:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  *Line 6 creates an int array with five elements, initialized to the 
 *  values 10,20,30,40, and 50,
 *  
 *  *Line 9 declares a StreamWriter variable named outputFile. (You do not
 *  see it in this code sample, but the directive using System.Io; appears at 
 *  the top of the file. This is required for the StreamWriter declaration in line 9.)
 *  
 *  * Line 12 creates a file named Values.txt for writing. After this statement
 *  executes, the outputFIle varialbe will reference a StreamWriter object
 *  that is associated withe the file.
 *  
 *  * Line 15 is the beginning of the a for loop. The loop iteratres once for 
 *  each element of the array. During the loop's iterations, the index 
 *  variable will be assigned the value 1,2,3,4, and 5.
 *  
 *  * Inside the loop, line 17 writes the array element number[index] to the 
 *  file.
 *  
 *  * Line 21 closes the file.
 *  
 *  * Line 24 displays a message box letting the user know the operation is done.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-13 shows the contents of the Values.txt file, opened in 
 *  Notepad, after the OK button has been clicked.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-13 Contents of the Values.txt file
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Reading Values from a File and Storing Them in an Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Reading the contents of a file into an array is also straightforward:
 *  Open the file and use a loop to read each item from the file, storing
 *  each item in an array element. The loop should iterate until either the
 *  array is filled or the end of the file is reached. For example, in 
 *  the Chap07 folder of the Student Sample Programs, you will find a
 *  project named FileTOArray. When you click the Get Values button,
 *  the application reads values from a file nsame Values.txt into an int
 *  array. The contents of the array are then displayed in a list box.
 *  
 *  The following code shows the Click event handler for the Get Values
 *  button.
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void getValuesButton_Click(object sender, EventArgs e)
 * {
 *      try
 *      {
 *          // Create an array to hold items read from the file.
 *          const int SIZE = 5;
 *          int[] numbers = new int[SIZE];
 *          
 *          // Cpunter variable to use in the loop
 *          int index = 0;
 *          
 *          // Declare a StreamReader variable.
 *          StreamReader inputFile;
 *          
 *          // Open the file's contents into the array.
 *          while(index < numbers.Length && !inputFile.EndOfStream)
 *          {
 *              numbers[index] = int.Parse(inputFile.ReadLine());
 *              index++;
 *          }
 *          
 *          // Close the file
 *          inputFile.Close();
 *          
 *          // Display the array elements in the list box.
 *          foreach(int value in numbers)
 *          {
 *              outputListBox.Items.Add(value);
 *          }
 *      }
 *      catch(Exception ex)
 *      {
 *          // Display an arrir message.
 *          MessageBox.Show(ex.Message);
 *      }
 * }
 * /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The try-catch statement handles any file-releated errors. Here is a 
 *  summary of the code inside the try block:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  skip
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                  Figure 7-14 The File to Array form
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *  7.4 Passing Arrays as Arguemts to Methods
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: An array can be passed as an argument to a method. To pass
 *  an array, you pass the variable that references the array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Sometimes you will want to write a method that accepts an entire 
 *  array as an argument and performs an operation on the array. For ex,
 *  the following code shows a method named ShowArray. The method accepts
 *  an array of strings as an argument and displays each element in a 
 *  message box.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void ShowArray(string[] strArray)
 *  {
 *      foreach(string str in strArray)
 *      {
 *          MessageBox.Show(str);
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice in line that the method has a parameter variable named strArray
 *  and that the parameter's data type is string[]. The expression string[]
 *  indicates that this parameter variable is a reference to a string array.
 *  When you call this  method, you must pass a string array as an argument.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When you call a method and pass an array as an argument, you simply pass
 *  the variable that references the array. The following code shows an 
 *  example of how the ShowArray method (previously shown) might be called:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *      // Create an array of strings.
 *      string[] people = {"Bill","Jill","Phil","Will"};
 *      
 *      // Pass the array to the ShowArray method.
 *      ShowArray(people);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Line 2 creates an array of strings namped people and initializes it
 *  with four strings. Line 5 calls the ShowArray method passing the
 *  people array as an argument.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Keep in mind that arrays are always passed by reference. When you pass
 *  an array as an argument, the thing that is passed into the parameter
 *  variable is a reference to the array.
 *  This is illustrated in Figure 7-15. As shown in the figure, the people 
 *  variable contains a reference to an array. When the people variable
 *  is passed to the ShowArray method, the reference to the array is passed 
 *  into the strArray parameter variable. Figue 7-16 shows that while the
 *  ShowArray method is executing, the people variable and the strArray
 *  parameter variable reference the same array in memory.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-15 An array passed as an argument
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-16 The people and strArray variables referencing the 
 *  same array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Because arrays are always passed by reference, a method that receives
 *  an array as an argument has access to the array
 *  (not a copy of the array). For example, in the Chap07 folder of the
 *  Student Sample Programs, you will find a project named Array Argument.
 *  Figure 7-17 shows the application's form just after the user has clicked
 *  the Go button. The following code shows the CLick event handler for the 
 *  Go button, and a method named SetToZero:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-17 The Array Argument application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Click event handler for the goButton control.
 *  private void goButton_Click(object sender, EventArgs e)
 *  {
 *      // Create an int array.
 *      int[] numbers = {1,2,3};
 *      
 *      // Display the array in the list box.
 *      outputListBox.Items.Add("The array's oringinal contents:");
 *      
 *      foreach(int number in numbers)
 *      {
 *          outputListBox.Items.Add(number);
 *      }   
 *      
 *      // Pass the array to the SetToZero method.
 *      SetToZero(numbers);
 *      
 *      // Display the array in the list box again.
 *      outputListBox.Items.Add("");
 *      outputListBox.Items.Add("");
 *      
 *      foreach(int number in numbers)
 *      {
 *          outputListBox.Items.Add(number);
 *      }
 *  }
 *  
 *  // SetToZero method accepts an int array as an
 *  // argument and sets its elements to 0.
 *  private void SetToZero(int[] iArray)
 *  {
 *      for(int index = 0; index < iArray.Length; index++)
 *      {
 *          iArray[index]=0;
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                 Using ref and out with Array Parameters
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You saw in the prevoius example that arrays are always passed by
 *  reference. When you pass an array as an argument to a method, the 
 *  method has direct access to the array through its parameter variable.
 *  However, the method cannot access the oringinal reference variable
 *  that was used to pass the array. For example, in the Chap07 folder of the 
 *  Student Sample Programs, you will find a project named Change Array
 *  Demo 1. Figure 7-18 shows the application's form just after the user
 *  has clicked the the Go button. The following code shows the Click event
 *  handler for the Go nutton and a method named ChangeArray:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-18 The Change Array Demo 1 application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void goButton_Click(object sender, EventArgs e)
 *  {
 *      // Create an int array.
 *      int[] numbers = {1,2,3};
 *      
 *      // Diplay the numbers array's contents.
 *      outputListBox.Items.Add("The array's oringinal contents: ")
 *      
 *      foreach(int value in numbers)
 *      {
 *          outputListBox.Items.Add(value);
 *      }
 *  }
 *  
 *  private void ChangeARray(int[] iArray)
 *  {
 *      const int NEW_AIZE = 5;
 *      
 *      // Make iArray reference a differenct array
 *      iArray = new int[NEW_SIZE];
 *      
 *      // Set the new array's elements to 99.
 *      for(int index = 0; index < iArray.LEngth; index++)
 *      {
 *          iArray[index] = 99;
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-19 After line 29 executes
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When you use either the ref or out keywords with an array parameter,
 *  the receiving method not only has access to the array, but it also has
 *  access to the reference variable that was used to pass the array. For
 *  example, the Change Array 2 project, in the Chap07 folder of the 
 *  Student Sample Programs, is identical to the Change Array 1 project,
 *  except that the iArray parameter is declared with the ref keyword in
 *  the ChangeArray method. THe following code shows the Click event
 *  handler for the Go button, and the ChangeArray method.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void  goButton_Click(object sender, EventArgs e)
 *  {
 *      // Create an int array.
 *      int[] numbers = {1,2,3};
 *      
 *      // Display the number array's contents.
 *      outputListBox.Items.Add("The array's original contents:");
 *      
 *      foreach(int value in numbers)
 *      {
 *          outputListBox.Items.Add(value);
 *      }
 *  }
 *  
 *  private void ChangeArray(ref int[] iArray)
 *  {
 *      const int NEW_SIZE = 5;
 *      
 *      // Make iArray reference a differenc array.
 *      iArray = new int[NEW_SIZE];
 *      
 *      // Set the new array's elements to 99.
 *      for(int index = 0; index < iArray.Length; index++)
 *      {
 *          iArray[index] = 99;
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice that in line 24 the iArray parameter is declared with the ref
 *  keyword, and in line 14 the ref keyword is used to pass numbers as an
 *  argument to the ChangeArray method. In this code, the iArray parameter 
 *  refers to the numbers variable. Anything that is done to the iArray
 *  parameter is actually done to the numbers variable. Figure 7-20 shows
 *  how line 29 causes the numbers variable to reference the new
 *  five-element array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-20 After line 29 executes in the Chage Array 2 application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-21 shows the application's form just after the user has 
 *  clicked the Go button. Notice from the program's output that after
 *  the ChangeArray method has been called, the numbers variable references
 *  a five-element array, and each element's value is 99.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *              7.5 Some Useful Array Algorithms
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                        The Sequential Search
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Programs commonly need to search for fata that is stored in an array.
 *  Various techniques known as search algorithms have been devloped to 
 *  locate a specific item in a larger collection of data, such as an 
 *  array. In this section, we discuess the simplest of all search
 *  algorithms - the sequential search. The sequential search algorithm
 *  uses a loop to sequentially step through an array, starting with the
 *  first element. It compares each element with the value being searched 
 *  for and stops when the value is found or at the end of the array is 
 *  encountered. If the value being searched for is not in the array,
 *  the algorithm unsuccessfully searches to the end of the array.
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Let's look at an example. In the Chap07 folder of the Student
 *  Sample Programs, you will find a project named American Colonies. The
 *  application is a game that tests your knowledge of U.S. history. As 
 *  shown in Figure 7-22, the application's form displays a list of 
 *  states in a ListBox control. Only one of the states should in the 
 *  ListBox was an original American colony. You select the state that you
 *  believe was a colony and click the OK button to see if you we're correct.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The following code is taken from the application. It shows a method named 
 *  SequentialSearch and the Click event handler for the OK button.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // The SequentialSearch method searches a string array
 *  // for a specified value. If the value is found, its position is 
 *  // returned.
 *  
 *  private int SequentialSearch(string[] sArray, string value)
 *  {
 *      bool found = false;     // Flag indicating search results
 *      int index = 0;          // Used to step through the array
 *      int position = -1;      // Position of value, is found
 *      
 *      // Search the array.
 *      while(!found && index < sArray.Length)
 *      {
 *          if(sArray[index] == value)
 *          {
 *              found = true;
 *              position = index;
 *          }
 *          index++
 *      }
 *      // Return
 *      return position;
 *  }
 *  
 *  private void okButton_Click(object sender, EventArgs e)
 *  {
 *      strign selection;   // To hold the user's selection
 *      
 *      // Create an array with the colony names.
 *      string[] colonies = {   "Delaware","Pennsulvania", "New Jeresy",
 *                              "Georgia","Connecticut", "Massachusetts",
 *                              "Maryland","South Carolina", "New Hampshire",
 *                              "Virginia","New York", "North Carolina",
 *                              "Rode Island"};
 *      
 *      if(selectionListBox.SelectIndex != -1)
 *      {
 *          // Get the selected item.
 *          selection = selectionListBox.SelectedItem.ToString();
 *          
 *          // Determine if the item is in the array.
 *          if(SequentialSearch(conlonies, selection) != -1)
 *          {
 *              MessageBox.Show("Yes, that was one of the colonies.");
 *          }
 *          else
 *          {
 *              MessageBox.Show("No, that was not one of the colonies.")
 *          }
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The SequentialSearch method, which begins in line 4, searches a string
 *  array for a specidied value. It accepts a string array and a string
 *  search value as arguments. If the search value if found in the array,
 *  the method returns the valuel's subscript. If the search value is not 
 *  found in the array the method returns -1. Let's take a closer look at the
 *  method:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *          *Line 6 declares a bool variable named found.
 *          The found variable is used as a flag.
 *          Setting found to false indicates that the search value has
 *          not been found. Notice that found is initialized with false.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                          Copying an Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Because an array is an object, there is a distinction between an array
 *  the variable that references it. The array and the reference varuable
 *  are two separate entities. This is important to remember when you wish
 *  to copy the contents of one array to another. You might be tempted to
 *  write something like the following code, thinking that you are copying 
 *  an array:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  int[] array1 = {2,4,6,8,10 };
 *  int[] array2 = array1;  // This does not copy array1.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The first statement creates an array referenced by the array1 variable.
 *  The second statement assigns array1 to array2. This does not make a copy
 *  of the array referenced by array1. Rather, it assigns the reference that 
 *  is in array1 to array2. After this statement executes, both the array1
 *  and array2 variables will reference the same array. The type of assignment
 *  operation is called a reference copy. Only a reference to the array object
 *  is copied, not the contents of the array object. This is illustrated in
 *  Figure 7-23.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-23 Both array1 and array2 referencing the same array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  If you want to make a copy of an array, you must create the second
 *  array in memory and then copy the individual elements of the first
 *  array to the second. This is usually best done with a loop, such as the
 *  following:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  const int SIZE = 5;
 *  int[] firstArray = {5,10,15,20,25 };
 *  int[] secondArray = new int[SIZE];
 *  
 *  for (int index = 0; index < firstArray.length; index++)
 *  {
 *      secondArray[index] = firstArray[index];
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The loop in this code copies each element of firstArray to the
 *  corresponding element of secondArray.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Comparing Arrays
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You cannot use the == operator to compare two array reference variables
 *  and determine whether the arrays are equal. For example, the following 
 *  code appears to compare two arrays, but in reality it does not:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  int[] firstArray = {5,10,15,20,25 };
 *  int[] secondArray = {5,10,15,20,25 };
 *  
 *  if(firstArray == secondArray)// This is a mistake
 *  {
 *      MessageBox.Show("The arrays are the same.");
 *  }
 *  else
 *  {
 *      MessageBox.Show("The arrays are not the same.");
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When you use the == operator with reference variables, the operator
 *  compares the references that the variables contain, not the contents
 *  of the objects referenced by the variables. Because the firstArray and
 *  secondArray variables in this example reference different objects in
 *  memory, the result of the Boolean expression firstArray == secondArray
 *  is false, and the code reports that the arrays are not the same.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To compare the contents of two arrays, you must compate the elements 
 *  of the two arrays. For example, look at the following code:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *      int[] firstArray = {2,4,6,8,10};
 *      int[] secondArray = {2,4,6,8,10};
 *      
 *      boolean arraysEqual = true; // Flag variable
 *      int index = 0;              // To hold array subscripts
 *      
 *      // First determine whether the arrays are the same size.
 *      if(firstArray.length != secondArray.length)
 *      {
 *          arraysEqual = false;
 *      }
 *      
 *  // Next determine whether the elements contain the same data.
 *  while(arraysEqual && index < firstArray.length)
 *  {
 *      if(firstArray[index] != secondArray[index])
 *      {
 *          arraysEqual = false;
 *      }
 *      index++
 *  }
 *  if(arraysEqual)
 *  {
 *      MessageBox.Show("The arrays are equal.");
 *  }
 *  else
 *  {
 *      MessagBox.Show("The arrays are not equal.");
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  This code determines whether firstArray and secondArray (declated in 
 *  lines 1 and 2) contain the same values. A Boolean flag variable,
 *  arraysEqual, is declared and initialized to true in line 3.
 *  The arraysEqual variable used to signal whether the arrays are equal.
 *  Another variable, index, is declared and initialized to 0 in line 4.
 *  The index variable is used in a loop to step through the arrays.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  First, the if statement in line 7 determuiens whether the two arrays
 *  are the same length. If they are not the same length, then the arrays
 *  cannot be equal, so the flag variable arraysEqual is set to false in 
 *  line 9. Then a while loop begins in line 13. The loop executes as long
 *  as arraysEqual is true and the index variable is less than
 *  firstArray.length.
 *  
 *  During each iteration, it compares a different set of
 *  corresponding elements in the arrays. When it finds two corresponding 
 *  elements that have different values, the flag variable arrayEqual is
 *  set to false.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  After the loop finishes, an if statement examines the arraysEqual
 *  variable in line 22. If the variable is true, then the arrays are equal
 *  and a message indicating so it displayed in line 24. Otherwise, they are
 *  not equal, so a different message is displayed in line 28.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Totalling the Values in an Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To calcuate the total of the values in a numeric array, you use a 
 *  loop with an accumlator.
 *  /////////////////////////////////////////////////////////////////////
 * 
 *  /////////////////////////////////////////////////////////////////////
 *  // Create an int array.
 *  int[] units = {2,4,6,8,10};
 *  
 *  // Declare and initialize an accumulator variable.
 *  int total = 0;
 *  
 *  // Step through the array, adding each element to 
 *  // the accumulator.
 *  
 *  for(int index = 0; index < units.Length; index++)
 *  {
 *      total += units[index];
 *  }
 *  
 *  // Display the total.
 *  MessageBox.Show("The total is " + total);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                  Averaging the Values in an array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The first setp in calculating the average of all the values in a 
 *  numeric array is to get the total of the values. The second step is to
 *  devide the total by the number of elements in the array. The following 
 *  code shows an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create an array.
 *  double[] scores = {92.5, 81.6 65.7 72.8 };
 *  
 *  // Declare and initialize an acculator variable.
 *  double total = 0.0;
 *  
 *  // Declare a variable to hold tehe average.
 *  double average;
 *  // Step through the array, adding each element to the accumulator.
 *  
 *  for(int index = 0; index < scores.Length; index++)
 *  {
 *      total += scores[index];
 *  }
 *  
 *  // Calculate the average.
 *  average = total / scores.Length;
 *  
 *  // Display the average.
 *  MEssageBox.Show("The average is "+ average);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Finding the Highest and Lowest Values in an Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Some programming tasks require you to find the highest value in a set
 *  of data. Examples include programs that report the highest sales
 *  amount for a given time period, the highest test scores, the highest
 *  temperature for a given set of days, and so forth.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The algorithm for finding the highest value in an array works like
 *  this: You create a variable to hold the highest value (the following
 *  example names this variable highest).
 *  
 *  Then, you assign the value at element 0 to the highest variable.
 *  
 *  Next, you use a loop to step through the rest of the array elements,
 *  beginning at the element 1. Each time the loop iterates, it compares
 *  an array element to the highest variable. OF the array element is
 *  grater than the higher varaible, then the value in the array
 *  element is assigned to the highest variable. When the loop
 *  finishes, the highest variable will contain the highest value
 *  in the array. The flowchart in Figure 7-24 illustrates this logic.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-24 Flowchart for finding the highest value in an array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The following code demonstrates this algorithm:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create an array.
 *  int[] numbers = {8,1,12,6,2};
 *  
 *  // Declare a variavle to hold the highest value, and initialize it with
 *  //the first value in the array
 *  int highest = numbers[0];
 *  
 *  // Step through the rest of the array, beginning at 
 *  // element 1. When a value greater than highest is found,
 *  // assign that value to highest.
 *  
 *  for(int index =1; index < numbers.Length; index++)
 *  {
 *      if(numbers[index] > highest)
 *      {
 *          highest = numbers[index];
 *      }
 *  }
 *  
 *  // Display the highest value.
 *  MessageBox.Show("The highest value is " + highest);
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In some programs, you are more intrested in finding the lowest value
 *  than the highest value in a set of data. For example, suppose you are
 *  'writing a program that stores several players' golf scores in an array
 *  and you need to find the best scaore. In golf, the lower the score the 
 *  better, so you need an algorithm that finds the lowedt valur in the array.
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The algorithm for finding the lowest value in an array is very similar
 *  to the algoeithm for findign the highest score.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-25 Flowchart for finding the lowest value in an array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The following code demonstrates this algorithm:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  // Create an array.
 *  int[] numbers = {8,1,12,6,2};
 *  
 *  // Declare a variable to hold the lowest value, and initialize it with the
 *  first value in the array.
 *  
 *  itn lowest = numbers[0];
 *  
 *  // Step through teh rest of the array, beginning at element 1. When a value
 *  less than lowest is found, assign that value to lowest.
 *  
 *  for(int index = 1; index < numbers.Length; index++)
 *  {
 *      if(numbers[index] < lowest)
 *      {
 *          lowest = numbers[index];
 *      }
 *  }
 *  // Display the lowest value.
 *  MessageBox.Show("The lowest value is " + lowest);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                      Partially Filled Arrays
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Somtimes you need to store a series of items in an array, but you do
 *  not know the number of items in the series. As a result, you do not 
 *  know the next exact number of elements needed for the array. One
 *  solution is to make the array large enough to hold the largest
 *  possible number of items. This can lead to another problem, however.
 *  IF the actual number of items stored in the array is less than the number
 *  of elements, the array will be only partially filled. When you process
 *  filled array, you must process only the elements contain valid data items.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  A partially filled array is normally used with an accompanying 
 *  integer variable that holds the number of items that are actully
 *  stored in teh array. If the array is empty , then 0 is stored in this
 *  variable because there are no items in the array. Each time an item is
 *  added to the array, the variable is incremented. When code steps through
 *  the array's elements, the value of this variable is used instead of the
 *  array's elements, the value of this variable is used instead of the
 *  array's size to determine the maximum subscript.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  For ex, in the Chap07 folder of the Studdent Sample Program, you 
 *  will find a program named Partially Filled Array. When you click the
 *  go button, the application reads up to 100 values from a file named 
 *  Values.txt and stores them in a 100-element int array. If the file 
 *  contains fewer than 100 values, the application's form just after the
 *  user has clicked the Go button.
 *  The following code shows the Click event handler for the Get 
 *  Values button
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 6-26 The PArtially Filled Array application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void goButton_Click(object sender, EventArgs e)
 *  {
 *      try
 *      {
 *          // Create an array to hold items read from the file.
 *          const int SIZE = 100;
 *          int[] numbers = new int[SIZE];
 *          
 *          // Variable to hold the number of items stored in the array
 *          int count = 0;
 *          
 *          // Declare a StreamReader variable.
 *          StreamReader inputFile;
 *          
 *          // Open the file and get a StreamReader object.
 *          inputFile = File.OpenText("Values.txt");
 *          
 *          // Read the file's contents into the array until the end of 
 *          the file is reached, or the array is full,
 *          
 *          while(!inputFile.EndOfStream %% count < numbers.Length)
 *          {
 *            // Read the next item from the file.
 *            numbers[count] = int.Parse(inputFile.ReadLine());
 *            
 *            // Increment count.
 *            count++;
 *          }
 *          
 *          // Close the file.
 *          inputFile.Close();
 *          
 *          // Display the array elements in the list box.
 *          outputListBox.Items.Add("The file contains " + count +
 *          " items:");
 *          
 *          for(int index = 0; index < count; index++)
 *          {
 *              outputListBox.Items.Add(numbers[index]);
 *          }
 *      }
 *      catch (Exception ex)
 *      {
 *          // Display an error message.
 *          MessageBox.Show(ex.Message);
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Tutorial 7-2: Processing an Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In this tutorial, you complete an application that reads five text
 *  scores from a file and stores the test scores in an array. The 
 *  application display the test scores as well as the highest score,
 *  the lowest score, and teh average score. Figure 7-27 shows the
 *  application's form, which has already been created for you. A set of
 *  five text scores is stored in a file named TestScores.txt, which has
 *  also been created for you.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Step 1: Start Visual Studio. Open the project named Test Average in
 *  the Chapt07 folder of the Student Sample Programs.
 *  
 *  Step 2: Open the Form1 form's code in the code editor.
 *  Insert the using System.IO; directive shown in line 10 of Program 7-2
 *  at the end of this tutorial. This statement is necessary because we
 *  will be using the StreamReader class, and it is part of the System.IO
 *  namespace in teh .NET Framework.
 *  
 *  Step 3: With the code editor still open, type the comments and code
 *  for the Average method, shown in lines 21 -40 of Program 7-2.
 *  The purpose of the Average method is to accept an int array as an
 *  argument and return the average of the values in the array.
 *  This method uses an algorithm similar to the array averaging 
 *  you saw earlier in the chapter.
 *  
 *  
 *  Step 4: Type the comments and code for the Highest method, shown in 
 *  lines 42-63 of Program 7-2. The purpose of the Highest method is to 
 *  acceot an int array as an argument and return the highest value in 
 *  the array. This method uses an algorithm similar to the algorithm 
 *  that you saw earlier in this chapter for finding the highest value in
 *  an array.
 *  
 *  Step 5: Type the comments and code for the Lowest method, shown in 
 *  lines 65 - 86 of Program 7-2. The purpose of the Lowest method is to
 *  accept an int array as an argument and return the lowest value in the 
 *  array. This method uses an algorithm similar to the algorithm that you
 *  saw earlier in this chapter for finding the lowest value in an array.
 *  
 *  Step 6: Now you create the Click event handler for the Button controls.
 *  Switch back to the Designer and double-click the getScoresButton control.
 *  This opens the code editor, and you will see an empty event handler named 
 *  getScoresButton_Click. Complete the getScoresButton_Click event handler
 *  by typing the code shown in lines 90-134 in Program 7-2.
 *  Let's review this code:
 *  
 *  Line 90: This is the beginning of a try-catch statement that handles any
 *  exceptions that are thrown while reading and processing data from the file.
 *  If an exception occurs in the try block (lines 92-128), the program 
 *  jumps to the catch block, and line 133 displays an error message.
 *  
 *  Lines 93-99: The following declarations appear in these lines:
 *      
 *      *SIZE-a constant, set to 5, for the number of text scores
 *      
 *      *scores -an int array that holds the test scores
 *      
 *      *index-an int variable, initialized to 0, that is used in a loop
 *      to step through the elements of the scores array
 *      
 *      *highestScore -an int that holds the highest score
 *      *lowestScore -an int that holds the lowest score
 *      *averageScore -a double that holds the average score
 *      *inputFile -a variable that references the StreamReader object
 *      that is used to read data from the file.
 *      
 *  Line 102: After this statement executes, the TestScores.txt will be 
 *  opened for reading, and the inputFile variable will reference
 *  a StreamReader object that is associated with the file.
 *  
 *  Line 105: This is the beginnign of a while loop that iterates as long
 *  as the end of the TextScores.txt file has not been reached as long
 *  as index is less than scores.Length. (Recall that index starts with
 *  the value 0.)
 *  
 *  Line 107: This statement reads a line of text from the file and assigns it
 *  to the array element scores[index].
 *  
 *  Line 108: This statement increments the index variable.
 *  
 *  Line 112: This statement closes the TestScores.txt file.
 *  
 *  Lines 115-118: This foreach loop displays the contents of the scores array
 *  in the testScoresListBox control.
 *  
 *  Line 121: this statement calls the Highest method, passing the
 *  scores array as an argument. The method returns the highest value
 *  in the array, which is assigbed to the highestScore variable.
 *  
 *  Line 122: This statement calls the Lowest method, passing the scores
 *  array as an argument. The method returns the lowest value in the
 *  array, shich is assigned to the lowestScore variable.
 *  
 *  Line 123: This statement calls the Average method, passing the scores
 *  array as an argument. The method returns the average of the valeus in
 *  the array, which is assigned to the averageScore variable.
 *  
 *  Line 126-128: These statements display the highest score, lowest score
 *  , and average score.
 *  
 *  Step 7: Switch your view back to the Designer and double-click the
 *  exitButton control. In the code editor you will see an empty event
 *  handler named exitButton_Click. Complete the exitButton_Click event
 *  handler by typing the code shown in lines 139-140 in Program 7-2.
 *  
 *  Step 8: Save the program. Then, press F5 on the keyboard or click the
 *  Start Debugging button (|>) on the toolbar to compiler and run the 
 *  application. When the application runs, click the Get Scores button.
 *  This should display a set of test scores in ListBox as well as the
 *  highest, lowest, and average of the test scores, as shown in
 *  Figure 7-28. Click the Exit button to exit the application.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Program 7-2 Completed code for Form1 in the Test Average application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-27 The Test Average application's form
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-28 The Text Average application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: A sorting algorithm is used to arrange data into some order.
 *  A search algorithm is a method of locating a specific item in a larger
 *  collection of data. The selection sort and the binary search are
 *  popular sorting and searching algorithms.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The Selection Sort Algorithm
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Ofter the data in an array must be sorted in some order.
 *  Customer lists, for instance, are commonly sorted in alphabetical
 *  order. Student grades might be sorted from highest to lowest. Product
 *  codes could be sorted so all the products of the same color are stored
 *  together. In this section, we explore how to write your own sorting
 *  algorithm. A sorting algorithm is a technique for scanning through an
 *  array and rearranging its contents in some specific order. The
 *  algotirhm that we explore is called the selection sort.
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The selection sort works like this: The smallest value in the array
 *  is located and moved to element 0. Then the next smallest value is 
 *  located and moved to element 1. This process continues until all the
 *  elements have been placed in their proper order. Let's see how the
 *  selection sort works when arraging the elements of the array in
 *  Figure 7-29.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-29 values in an array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The selection sort scans the array, starting at element 0, and
 *  locates the element with the smallest value. Then, the contents of
 *  this element are swapped with the contents of element 0. In this 
 *  example, the 1 stored in element 5 is swapped with the 5 stored in
 *  element 0. After the swap, the array appears as shown in Figure 7-30.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-30 Values in the array after the first swap
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Then, the algorithm repeats the process, but because element 0 
 *  already contains the smallest value in the array, it can be left
 *  out of the procedure. This time, the algorithm begins the scan at 
 *  element 1. In this example, the value in element 2 is swapped with 
 *  the value in element 1.
 *  Then, the array appears as shown in Figure 7-31.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-31 Values in the array after the two second swap
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  etc
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                      Swapping Array Elements
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  As you saw in the description of the selection sort algorithm, 
 *  certain elements are swapped as the algorithm steps through the array.
 *  Let's briefly discuss the process of swapping two items in computer 
 *  memory. Assume we have the following variable devlarations:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  int a = 1;
 *  int b = 9;
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Suppose we want to swap the values in these variable a contains 9
 *  and the variable b contains 1. At first, you might think that we need
 *  only assign the variablers to each other, like this:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // ERROR! The following does NOT swap the variables.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To understand why this does not work, let's step through the code. 
 *  The first statement is a=b. This causes the value 9 to be assigned to
 *  a. But, what happens to the value 1 that was previously stored in a?
 *  Remember, when you assign a new value to a variable, the new value
 *  replaces any value that previously stored in the variable. So, the old
 *  value, 1 is thrown away. Then the next statement is b = b. Since the
 *  variable a contains 9, this assigns 9 to b. After these statements 
 *  execute, the variables a and b both contain the value 9.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To successfully swap the contents of two variables, we need a third
 *  variable that can serve as a temporary storage location:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  int temp;
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Then we can perform the following steps to swap the values in the 
 *  variables a and b:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  * Assign the value of a to temp
 *  
 *  *Assign the value of b to a.
 *  
 *  *Assign the value of temp to b.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-35 shows the contents of these variables as we perform each
 *  of these steps. Notice that after the steps are finished,
 *  the values in a and b are swapped.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-35 Swapping the values of a and b
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Here is the code for a Swap method that we can use to swap to int 
 *  values:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void Swap(ref int a, ref int b)
 *  {
 *      int temp = a;
 *      a = b;
 *      b = temp;
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Note: It is critical that we use reference parameters in the Swap 
 *  method because the method must be able to change the values of the 
 *  items that are passed to it as arguments.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Let's look at a complete program that demonstrates the Selection Sort
 *  algorithm. In the Chap07 folder of the Student Sample Programs, you
 *  will find a project named Selction Sort. Figure 7-36 shows the
 *  application's form. On the left, you see the form in the Designer,
 *  with the names of various controls. On the right, you see the form
 *  at run time, after the Go button has been clicked. When you click the 
 *  Go button, the following action take place:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-36 The Selection Sort application's form
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  *An int array is created, initialized with unsorted values.
 *  
 *  *The contents of the array are displayed in the originalListBox control.
 *  
 *  *The array is passed as an argument to the SelectionSort method.
 *  The method uses the Selection Sort algorithm to sort the array.
 *  
 *  * The contents of the array are displayed in the sortedListBox
 *      control.
 *      
 *  Program 7-3 shows the complete code for the Selection Sort 
 *  application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Program 7-3 Complete code for Form1 in the Selection Sort application
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The BinarySearch Algorithm
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Previously in this chapter, we discussed the sequential search
 *  algorithm, which uses a loop to step sequentially through an array,
 *  starting with the first element. It compares each element with the
 *  value being searched for and stops when the value is found or the end
 *  of the array is encountered. If the value being searched for is not 
 *  in the array, the algorithm unsuccessfully searches to the end of the
 *  array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The advantage of the sequential search is its simplicity: It is very
 *  easy to understand and implement. Furthermore, it does not require the 
 *  data in the array to be stored in any particular order.
 *  Its disadvantage, however, it is inefficiency. If the array being
 *  searched contains 20,000 elements, the algorithm has to look at all
 *  20,000 elements in order to find a value stored in the last element.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In an average case, an item is just as likely to be found near the
 *  beginning of an array as near the end.
 *  Typically, for an array on n items the sequential search locates an 
 *  item in n/2 attempts. If an arrau has 50,000 elements, the sequential
 *  search makes a comparison with 25,000 of them in a typical case. This
 *  is assuming, or course, that the search item is consistently found in 
 *  the array. (n/2 is the average number of comparisons.
 *  The maximum number of comparisons is always n.)
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When the sequential search fails to locate an item,
 *  it must a comparison with every element in the array. As the number
 *  of failed search attempts increases, so does the average number of
 *  comparisons. Although the sequential search algorithm is adequate for 
 *  small arrays, it should not be used on large arrays if speed is
 *  important.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The binary search is a clever algorithm that is much more efficient
 *  than the sequential search. Its only requirement is that the values
 *  in the array must be stored in ascending order. Instead of testing
 *  the array;s first element, this algorithm starts with the element in
 *  the middle. If that element happens to contain the desired value,
 *  then the search is over. Otherwise, the value (if it is in the list)
 *  will be found somewhere in the last half of the array. In either case,
 *  half of the array's elements have been eliminated from further
 *  searching.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  If the desired value is not found in the middle element, the procedure
 *  is repeated for the half of the array that potentially contains the
 *  value. For instance, if the last half of the array is to be searched,
 *  the algorithm tests its middle element.
 *  If the desired value is not found there, the search is narrowed to the
 *  quarter of the array that resides before of after that element. This 
 *  process continues until the value being searched for is either found
 *  or there are no more elements to test.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Here is the pseudocode for a method that performs a binary search on 
 *  an array:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Method BinarySearch(array, searchValue)
 *      Set first to 0
 *      Set last to the last subscript in the array
 *      Set position to -1
 *      Set found to false
 *      
 *  While found is not true and first is less than or equal to last
 *  Set middle to the subscript half way between array[first] and array[last]
 *      if array[middle] equals searchValue
 *          Set found to true
 *          Set position to middle
 *      Else if array[middle] is greater than searchValue
 *          Set last to middle -1
 *      Else
 *          Set first to middle +1
 *      End If
 *      End While
 *      
 *      Return position
 *    End Method
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  This alsorithm uses three variables to mark positions within the 
 *  array: first, last, and middle. The first and last variables mark
 *  the boundaries of the portion of the array currently being searched.
 *  They are initialized with the subscripts of the array's first and
 *  last elements. The subsccript of the element halfway between first and 
 *  last is calcuated and stored in the middle variable. IF the element in the 
 *  middle of the array does not contain the earch value, the first of last
 *  variable is abjusted so that only the top or borrom half of the array is 
 *  searched during the next iteration. This cuts the portion of the array
 *  being searched in half each time the loop fails to locate the search value.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The following C# method performs a binary search on an integer array.
 *  The first parameter, iArray, is searched for an occurrence of the
 *  number stored in value. If the number is found, its array subscript
 *  is returned. Otherwise, -1 is returned, indicating the value did not
 *  appear in the array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private int BinarySearch(int[] iArray, int value)
 *  {
 *      int first = 0;              // First array element
 *      int last = iArray.Length-1; // Last array element
 *      int middle;                 // Midpoint of search
 *      int position = -1;          // Position of search value
 *      bool found = false;         // Flag
 *      
 *      // Search for the value.
 *      while(!found && first <= last)
 *      {
 *          // Calculate the midpoint.
 *          middle = (first+last) /2;
 *          
 *          // If value is found at midpoint...
 *          if(iArray[middle] == value)
 *          {
 *              found = true;
 *              position = middle;
 *          }
 *          // else if value is in lower half...
 *          else if(iArray[middle] > value)
 *          {
 *              last = middle - 1;
 *          }
 *          // else if value is in upper half...
 *          else
 *          {
 *              first = middle + 1;
 *          }
 *      }   
 *      
 *      // Return the position of the item, or -1
 *      // if it was not found.
 *      return position;
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  If you want to see a complete application that uses the binary
 *  search algorithm, look at the Binary Search project, located in the 
 *  Chap07 folder of the Student Sample Programs. It loads a list of names
 *  from a file into an array and then performs a binary search to find 
 *  a specific name in the array.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *                      7.7 Two-Dimensional Arrays
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: A two-dimensional array is like several identical arrays
 *  put together. It is useful for storing multiple sets of data.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The arrays that you have studied so far are known as one-dimensional 
 *  arrays. They are called one-dimensional arrays because they can hold
 *  multiple sets of data. Think of a two-dimensional array as having
 *  rows and columns of elements, as shown in Fuigure 7-37. This figure
 *  shows a two-dimensional array having three rows and four columns.
 *  Notice that the rows are numbered 0,1, and 2, and the columns are
 *  numbered 0,1,2, and 3. There is a total of 12 elements in the array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-37 A two-dimensional array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Two-dimensional arrays are useful for working with multiple sets of 
 *  data. For example, suppose you are designing a grafe averaging
 *  program for a teacher. The teacher has six students, and each
 *  student takes five exams during the semester.
 *  One approach would be to create six one-dimensional arrays, one for 
 *  each student. Each of these arrays would have five elements, of the
 *  arrays. A better approach would be to use a two-dimensional array
 *  with six rows (one for each student) and five columns
 *  (one for each exam score), as shown in Figure 7-38.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-38 Two-dimensional array with six rows a and five columns
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                  Declaring a Two-Dimensional Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To declare a two-dimensional array, two size declarators are
 *  required: The first one is for the number of rows, and the second one
 *  is for the number of columns. Here is an example declaratation of a
 *  two-dimensional array with three rows and four columns:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  double[,] scores = new double[3,4];
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice the comma that appears inside the first set of brackers. This
 *  indicates that the scores variable references a two-dimensional array.
 *  The number 3 and 4 are size declaratoes. The first size declarator 
 *  specifies the number of rows, and the second size declarator
 *  specifies the number of columns. Notice that the size declarators
 *  are separated by a comma. 
 *  
 *  As with one-dimensional arrays, it is best to use named constants as
 *  the size declarators. Here is an example:
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  const int ROWS = 3;
 *  const int COLS = 4;
 *  int[,] scores = new int [ROWS,COLS];
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When processing the data in a two-dimensional array, each element has
 *  two subscripts: one for its row and another for its column. In the 
 *  scores array, the elements in row 0 are referenced as follows:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  scores[0,0]
 *  scores[0,1]
 *  scores[0,2]
 *  scores[0,3]
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The elements in row 1 are referenced as follows:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  scores[1,0]
 *  scores[1,1]
 *  scores[1,2]
 *  scores[1,3]
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  And, the elements in row 2 are referenced as follows:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  scores[2,0]
 *  scores[2,1]
 *  scores[2,2]
 *  scores[2,3]
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-39 illustrates the array with the subscripts shown for each
 *  element.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-39 Subscripts for each element of the scores array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Accessing the Elements in a Two-Dimensional Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To access one of the elements in a two-dimensional array, you must use
 *  two subscripts. For example, suppose we have the following declarations 
 *  in a program:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  const int ROWS = 5;
 *  const int COLS = 10;
 *  int[,] values = new int[ROW,COLS];
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The following statement assigns the number 95 to values[2,1]:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  values[2,1] = 95;
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Programs ofter use nested loops to process two-dimensional arrays.
 *  For example, the following code assigns a random number to each
 *  element of the values array:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create a Random object.
 *  Random rand = new Random();
 *  
 *  // Create a two-dimensional int array
 *  const int ROWS = 5;
 *  const int COLS = 10;
 *  int[,] values = new int[ROWS,COLS];
 *  
 *  // Fill the array with random numbers.
 *  for(int row = 0; row < ROWS; row++)
 *  {
 *      for(int col = 0; col < COLS; col++)
 *      {
 *          values[row,col] = rand.Next(100);
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  And the following set of nested loops displays all the elements of 
 *  the values array in a ListBox control named outputListBox:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Display the array contents.
 *  for(int row = 0; row < ROWS; row++)
 *  {
 *      for(int col = 0; col< COLS; col++)
 *      {
 *          outputListBox.Items.Add(values[row,col].ToString());
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Implicit Sizing and Initialization of Two-Dimensional Arrays
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  As with a one-dimensional array, you may provide an initialization
 *  list for a two-dimensional array. Recall that when you provide an
 *  initialization list for an array, you cannot provide the upper
 *  subscript numbers. When initializing a two-dimensional array, you 
 *  must provide the comma to indicate the number of dimensions. The 
 *  following is an example of a two-dimensional array declaration with
 *  an initialization list:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  int[,] values = {
 *  {1,2,3},
 *  {4,5,6},
 *  {7,8,9} };
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Initialization values for each row are enclised in their own set of 
 *  braces. In this example, the initialization values for row 0 are
 *  {1,2,3}, the initialization values for row 1 are {4,5,6}, and the 
 *  initialization values for row 2 are {7,8,9}. So, this statement 
 *  declares an array with three rows and three columns. The values are 
 *  assigned to the values array in the following manner:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  values[0,0] is set to 1.
 *  values[0,1] is set to 2.
 *  values[0,2] is set to 3.
 *  values[1,0] is set to 4.
 *  values[1,1] is set to 5.
 *  values[1,2] is set to 6.
 *  values[2,0] is set to 7.
 *  values[2,1] is set to 8.
 *  values[2,2] is set to 9.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Summing all the Elements of a Two-Dimensional Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To sum all the elements of a two-dimensional array, you can use a
 *  pair of nested loops to add the contents of each element to an
 *  accumulator. The following code shows an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To sum all the elements of a two-dimensional array, you can use a
 *  pair of ested loops to add the contents of each element of an 
 *  accumulator. The following code shows an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  const int ROWS = 3;
 *  const int COLS = 3;
 *  
 *  int[,] numbers = {
 *  {1,2,3,4},
 *  {5,6,7,8},
 *  {9,10,11,12}
 *  };
 *  
 *  int total = 0; // Accumulator, set to 0
 *  
 *  // Sum the array elements.
 *  for(int row = 0; row < ROWS; row++)
 *  {
 *      for(int col = 0; col < COLS; col++)
 *      {
 *          total += number[row,col];
 *      }
 *  }
 *  // Display the sum.
 *  MessageBox.Show("The total is " + total);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Summing All the Rows of a Two-Dimensional Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Somtimes you may need to calculate the sum of each row in a
 *  two-dimensional array. For ex, suppose a two-dimensional array is 
 *  used to hold a set of test scores for a set of students. Each row in
 *  the array is a set of test scores for one student. To get the sum of
 *  a student's test scores (perhaps so an everage may be calculated),
 *  you use a loop to add all the elements in one row. The following code
 *  shows an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *   const int ROWS = 3;
 *   const int COLS = 3;
 *  
 *  int[,] numbers = {
 *  {1,2,3,4},
 *  {5,6,7,8},
 *  {9,10,11,12}
 *  };
 *  
 *  int total;  // Accumulator
 *  
 *  
 *  // Sum each row in the array.
 *  for(int row = 0; row < ROWS; row++)
 *  {
 *  
 *  total = 0;
 *  
 *  // Total the row.
 *      for(int col = 0; col < COLS; col++)
 *      {
 *          total += number[row,col];
 *      }
 *      // Display the row's total.
 *  MessageBox.Show("The total of row  " + row + " is " + total) ;
 *  }
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Summing the Columns of a Two-Dimensional Array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Sometimes you may need to calculate the sum of each column in a
 *  two-dimensional array. For example, suppose a two-dimensional array is
 *  used to hold a set of test scores for a set of students and you wish
 *  to calculate the class average for each of the test scores. To do this,
 *  you calculate the average of each column in the array.
 *  This is accomplished with a set of nested loops. The outer loop controls
 *  the column subscript, and the inner loop controls the row subscript.
 *  The inner loop calculates the sum of a column, which is stored in an
 *  accumulator. The following code demonstrates:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  const int ROWS = 3;
 *  const int COLS = 4;
 *  
 *  int[,] numbers = {
 *  {1,2,3,4},
 *  {5,6,7,8},
 *  {9,10,11,12}
 *  };
 *  int total;  // Accumulator
 *  
 *  // Sum each column in the array
 *  // Sum each row in the array.
 *  for(int col = 0; col < COLS; col++)
 *  {
 *  
 *  total = 0;
 *  
 *  // Total the row.
 *      for(int row = 0; row < ROWS; row++)
 *      {
 *          total += number[row,col];
 *      }
 *      // Display the row's total.
 *  MessageBox.Show("The total ofcolum " + col + " is " + total) ;
 *  }
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *                         7.8 Jagged Array
 *  /////////////////////////////////////////////////////////////////////
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: A jagged array is similar to a two-dimensional array, but
 *  the rows in a jagged array can have different lengths.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In a traditional two-dimensional array, each row has the same number
 *  of columns. Mentally, we visualize a two-dimensional array as a 
 *  rectangular structure. Figure 7-37, previously shown, in an example.
 *  For this reason, two-dimensional arrays are somethimes referred to as
 *  rectangular arrays.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-41 A jagged array
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Because a jagged array is an array of arrays, you set it up
 *  differently than a two-dimensional array. First you create an array,
 *  and then you create each of the arrays that are the elements of the 
 *  first array. The following code shows an example of how the jagged
 *  array in Figure 7-41 might be created and initialized.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create an array of 3 int arrays
 *  int[][] jaggedArray = new int[3][];
 *  
 *  // Create each array that is an element of the jagged array
 *  jaggedArray[0] = new int[4] {1,2,3,4};
 *  jaggedArray[1] = new int[3] {5,6,7};
 *  jaggedArray[2] = new int[5] {8,8,10,11,12};
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To access an item that is stored at a particular row and column in a
 *  jagged array, you enclose the row and column subscripts in their own
 *  sets of brackets. For example, the following statemet displays the
 *  value stored at row 1, column 2, of the jaggedArray that was previously
 *  declared:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  MessageBox.Show(jaggedArray[1][2].ToString());
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The following statement shows another example. It assigns the value
 *  99 to row 0, column 3, of jaggedArray:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  jaggedArray[0][3] = 99;
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *   A jagged array has a Length property that holds the number of rows,
 *  and then each row has its own Length property. You can use a row's 
 *  Length property to determine the number of columns in that row.
 *  For ex, the following set of nested loops displays all the values
 *  stored in the jaggedArray that was previously declared:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  for(int row = 0; row < jaggedArray.Length; row++)
 *  {
 *      for(int col = 0; col < jaggedArray[row].Length; col++)
 *      {
 *          MessageBox.Show(jagedArray[row][col].ToString());
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                      7.9 The List Collection
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: List is a class in the .NET Framework that is similar to an 
 *  array. Unlike an array, List oibject's size is automatically 
 *  abjusted to accommodata the number of items being stored in it.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The .NET Framework provides a class named List, which can be used for
 *  storing and retrieving items. Once you create a List object, you can 
 *  think of it as a container for holding other objects. A List object
 *  is similar to an array but affers many advantages over an array.
 *  Here are a few:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  * When you creare a List object, you do not have to know the number of 
 *  items that you intend to store in it.
 *  
 *  *A List object automatically expands as items are added to it.
 *  
 *  *In addition to adding items to a List, you can remove items as well.
 *  
 *  *A List object automatically shrinks as items are removed from it.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                          Creating a List
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Here is an example of how you create a List object that can be used
 *  to hold strings:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  List<string> nameList = new List<string>();
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  This statement creates a List objectm referenced by the numberList
 *  variable. Notice that in this example the word int is written inside
 *  brackets <> immediately after the word List.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                      Initializing a List
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You can optionally initialize a List object when you declare it. Here
 *  is an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  List<int> numberList = new List<int>(){1,2,3};
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  This statement creates a List object that can hold integers and
 *  initializes it with the values 1,2, and 3. Here is an example that 
 *  creates a List object to hold string and initializes it with three
 *  strings:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  List<string> nameList = new List<string>(){"Chris","Kathryn","Bill"};
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Adding Items to a List
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  To add items to an existing List object, you use the Add method. For
 *  example, the following statements create a List object and a series 
 *  of strings to it:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  List<string> nameList = new List<string>();
 *  nameList.Add("Chris");
 *  nameList.Add("Kathryn");
 *  nameList.Add("Bill");
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  After these statments execute, the nameList object will hold the 
 *  three strings"Chris","Kathryn", and "Bill".
 *  
 *  The items that are stored in a List have a corresponding index. The 
 *  index specifies the item's location in the List, so it is much like an
 *  array subscript. The first item that is added to a List is stored at
 *  index 0. The next item that is added to the List is stored at index 1,
 *  and so forth. After the previously shown statements execute, "Chris"
 *  is stored at index 0, "Kathryn" is stored at index 1, and "Bill" is 
 *  stored at index 2.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                          The Count Property
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  A List object has a Count property that hold the number of items
 *  stored in the List. For example, the following statement uses the 
 *  Count Property to display the number of items stored in nameList:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  MessageBox.Show("The List has " + nameList.Count + "
 *  objects stored in it.")
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Assuming that nameList holds the string "Chris","Kathryn", and
 *  "Bill", the following statments will be displayed in a message box:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The List has 3 objects stored in it.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Accessing Items in a List
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You can use subscript notation to access the items in a List, just
 *  as you can with an array. For example, the following for loop displays
 *  the items in the nameList object:
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  for(int index = 0; index < nameList.Count; index++)
 *  {
 *      MessageBox.Show(nameList[index]);
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice that the loop uses the List object's Count property in the text
 *  expression to control the number of iterations. Here is an example
 *  that reads values from a text file and adds them to a List:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Open the Name.txt file.
 *  StreamReader inputFile = File.Opentext("Names.txt");
 *  
 *  // Create a List object to hold strings.
 *  List<string> nameList = new List<string>();
 *  
 *  // read the file's contents
 *  while(!inputFile.EndOfStream)
 *  {
 *      // read a line and add it to the List
 *      nameList.Add(inputFile.ReadLine());
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You can also use the foreach loop to iterate over the items in a List,
 *  just as you can with an array. Here is an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  foreach(striing str in nameList)
 *  {
 *      MessageBox.Show(str);
 *  }  
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Passing a List to a Method
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Sometimes you will want to write a method that accepts a List as an
 *  agrument and display each item in List. 
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  private void DisplayList(List<string> sList)
 *  {
 *      foreach(string str in sList)
 *      {
 *          MessageBox.Show(str);
 *      }
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice in line 1 that the method has a parameter variable named
 *  sList and that the parameter's data type is List<string>. The 
 *  parameter variable is a reference to a List<string> object. When you
 *  call this method, you must pass a List<string> object as an argument.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  When you call a method and pass a List<string> object as an argument
 *  , you simply pass the variable that references the List. The following 
 *  code shows an example of how the DisplayList method (previously shown)
 *  might be called:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create a List of strings.
 *  List<string> nameList = new List<string>(){"Chris","Kathryn","Bill"};
 *  
 *  // pass the List to the DisplayList method.
 *  DisplayList(nameList);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Note: List objects, like arrays, are always passed by reference.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Removing Items from a List
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create a List of strings.
 *  List<string> nameList = new List<string>(){"Chris","Kathryn","Bill"};
 *  
 *  // Remove the item at index 0;
 *  nameList.RmoveAt(0);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The statement in lines 2 and 3 creates a List containing the string
 *  "Chris", "Kathryn", and "Bill". Then, the statement in line 6 
 *  removes the string at index 0. After this statemetn executes, the 
 *  List contains the strings "kathryn" and "Bill".
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  If you know the value of the item that you want to remove from a 
 *  List, but you do know the item's index, you can use the Remove
 *  method. You pass the item that you want to remove as an argument, and
 *  the remove method searches for that item in the List. If the item is 
 *  found, it is removed. Here is an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create a List of strings.
 *  List<string> nameList = new List<string>() {"Chris","Kathryn","Bill"};
 *  
 *  // Remove "Bill" from the List
 *  nameList.Remove("Bill");
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Note: The Remove method performs a sequential search to locate the 
 *  specified item. If the List contains a large number of items, its 
 *  performance will be slow.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  If you want to remove all the items from a List, you can call the 
 *  Clear method. Here is an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  nameList.Clear();
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  After this statemetn executes, the nameList object is empty.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Inserting an Item
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You can use the Insert method to insert an item at a specific index
 *  in a List. The following code shows an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create a List of strings.
 *  List<string> nameList = new List<string>() {"Chris","Kathryn","Bill"};
 *  
 *  // insert an item at index 0.
 *  nameList.Insert("Joanne", 0);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The statment in lines 2 and 3 creates a List containing the strings
 *  "Chris","Kathryn", and "Bill". then, the statement in line 6 insert 
 *  the string "Joanne" at index 0. After this statemetn executes, the 
 *  List contains the strings "Joanne","Chris","Kathryn", and "Bill".
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Nore: An exception will occur if the specified index is less than 0
 *  or greater than the List object's Count property.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Searching for Items in a List
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Because you can use subscript notation to access the items in a List, 
 *  you can adapt any of the array-processing algorithms that you saw
 *  earlier in this chapter so they work with a List. For example, you
 *  can write code that performs a sequential search, binary search,
 *  selection sort, and so forth, on a List.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  An easy way to search for item in a List, however, is to use the 
 *  Index method. The IndexOf method accepts a value as an argument, and
 *  it searches for that value in the List. If the value is found, the 
 *  method returns its index. IF the value is not found, the method
 *  returns -1. The following code shows an example:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  // Create a List of strings.
 *  List<string> nameList = new List<string>(){"Chris","Kathryn","Bill"};
 *  
 *  // Search for "Kathryn".
 *  int position = nameList.IndexOf("Kathryn");
 *  
 *  // Was Kathryn found in the List?
 *  if(position != -1)
 *  {
 *      MessageBox.Show("Kathryn was found as index " + position);
 *  }
 *  else
 *  {
 *      MessageBox.Show("Kathryn was not found.");
 *  }
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  There are two additional versions of the IndexOf method that allows
 *  you to specify the area of the List that should be search. The 
 *  following statemetn shows an example of one of these:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  postion = nameList.IndexOf("Diane",2);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Notice that two arguments are passed to the IndexOf method. The first
 *  argument, "Diane", is the items to search for. The second argument,
 *  2 is the starting index of the search. This specifies the search should
 *  begin at index 2 and end at the last item in the List.
 *  (The beginning index is included in the search.
 *  If you pass an invalid index as an argument, an exception occurs.)
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Here is an example of another version of the IndexOf method:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  position = nameList.IndexOf("Diane",2,5);
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In this example, three arguments are passed to the IndexOf method.
 *  The first argument, "Diane", is the item to earch for. The second
 *  argument, 2 is the starting index of the search. The third argument,
 *  5, is the ending index of the search. This specifies that the search
 *  shold begin at index 2, and end at index 5. (The beginning and ending
 *  indices are included in the search. If either index is invalid, an
 *  exception occurs.)
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Note: The IndexOf method performs a sequential search to locate the 
 *  specified item. If the List contains a large number of items, its
 *  performance will be slow.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *                     7.10 The ImageList Control
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Concept: The ImageList control allows you to store a collection of 
 *  images. At run time, you can retrieve an image from an ImageList
 *  control and display it in a PictureBox control.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  The ImageList control is a container that can hold multiple images. 
 *  As its name implies, it is a list of images. You can use an index
 *  to retrieve an image from an ImageList control and display the image
 *  in a PictureBox control.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  There are a few guidelines that you should follow as you plan to use
 *  an ImageList control in an application:
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 * *All the images stored in an ImageList control should be the same size.
 *  
 *  * The images stored in an ImageList control can be no more than 256
 *  by 256 picles in size.
 *  
 *  *ALl the images stored in an ImageList control should be in the same
 *  format (.bmp, .jpg, etc)
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Although these guidelines might seem restrictive, keep in mind that
 *  ImageList controls are designed to store small images such as icons
 *  or thumbnails. They also work well in game programs that display
 *  images such as cards.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  You will find the ImageList control in the Components section of the
 *  Toolbox. When you double-click the ImageList tool in the Toolbox, an
 *  ImageList control is created in the component tray area, at the bottom
 *  of the Designer. (The ImageList control does not appear on this form.)
 *  Figure 7-44 shows an example. When you create ImageList controls, they
 *  are given default names such as imageList1, imageList2, and so forth.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-44 An ImageList control
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  After you create an ImageList control, you should set its ImageSize
 *  property to the size of the images that you plan to store in the 
 *  control. The default size is 16,16. You can set the ImageSize property
 *  to any value from 0,0 through 256,256. (If the value of the ImageSize
 *  property does not match the size of the images that are stored in the
 *  control, the images will appear distored when you display them.)
 *  /////////////////////////////////////////////////////////////////////
 * 
 *  /////////////////////////////////////////////////////////////////////
 *  Then you can use the Images property to add images to the control.
 *  In the Properties window, click the ellipses button(...) that appears 
 *  next to the Images property. This display the Images Collection Editor
 *  window shown in Figure 7-45. Click the Add button, and an Open dialog
 *  box appears. Use the dialog box to locate and select the image file
 *  (or multiple image files that you want to the ImageList control).
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-45 The Images Collections Editor window
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-46 shows the Images Collection Editor window after four 
 *  images have been added. The names of the images, which are shown in 
 *  the Members list, are 2_Clubs.bmp   
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  If you know the index value for a particular image, you can retreve that image from the ImageList control and display it in a PictureBox. The following code shows an example. Assume myImageList is the name of an ImageList control and myPictureBox is the name of a PictureBox control.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  myPictureBox.Image = myImageList.Images[5];
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  This statement gets the image at index 5 from myImageList and assigns
 *  it to the myPictureBox control's Image property. As a result, the image is 
 *  displayed in the PictureBox.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In code, you can determine the number of images that are stored in an
 *  ImageList control by getting the value of the control's 
 *  Images.Count property.
 *  The following code shows an example.
 *  Assume myImageList is the name of an ImageList control and
 *  numberImages is the name of an int variable.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  numberImages = myImageList.Images.Count;
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  In Tutorial 7-5, you complete an application that randomly relects images 
 *  from, an ImageList control and displays then in a PictureBox.
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Figure 7-47 The Random Card application's form
 *  /////////////////////////////////////////////////////////////////////
 *  
 *  /////////////////////////////////////////////////////////////////////
 *  Tutorial 7-5: Completing the Random Card Application
 *  /////////////////////////////////////////////////////////////////////