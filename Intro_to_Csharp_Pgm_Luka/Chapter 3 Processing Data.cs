using System;

namespace Chapter3ProcessingData
{
    static void Main(string[] args)
    {
        string s1 = "this is a string";
        Console.WriteLine(s1);



    }
}

/* //////////////////////////////////////////////////////////////////////////
 *                      Chapter 3 Processing Data
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *                      Topics
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 * 3.1 Reading Input with TextBox Controls
 * 3.2 A First Look at Variables
 * 3.3 Numeric Data Types and Variables
 * 3.4 Performing Calculations
 * 3.5 Inputting and Outputting Numeric Values
 * 3.6 Formatting Numbers with ToString Method
 * 3.7 Simple Exception Handling
 * 3.8 Using Named Constrants
 * 3.9 Declaring Variables as Fields
 * 3.10 Using the Math class
 * 3.11 More GUI Details
 * 3.12 Using the Debugger to Locate Logic Errors
 * //////////////////////////////////////////////////////////////////////////
 * Concept The TextBox control is a rectangular area that can accept
 * keyboard input from the user.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * Many of  the programs that you will form this point forward will require
 * the user to enter data.
 * The data entered by the user will then be used in some sort of operation.
 * One of the primary controls that you will use to get data from the user
 * is the TextBox control.
 * 
 * //////////////////////////////////////////////////////////////////////////
 * A TextBox control appears as a rectangular area on a form. When the
 * application is running, the user can type into a TextBox control.
 * The program can then retrieve the text that the user entered and
 * use that text in any necessary opertaions.
 * //////////////////////////////////////////////////////////////////////////
 * IN the Toolbox, the TextBox tool is located in teh Common Controls group.
 * When you double-click the tool, a TextBox control is created on the form,
 * as shown in Figure 3-1. When you create TextBox controls, they are
 * sutomatically given default names such as textBox1, textBox2, and so
 * forth. As you learned in Chapter 2, you should always change a controls
 * default name to something more meaningful.
 * //////////////////////////////////////////////////////////////////////////
 * When the user types into a TextBox control, the text is stored in the
 * control's Text property.
 * //////////////////////////////////////////////////////////////////////////
 * Note When you retrive the contrents of the Text property, you always
 * get a string. Any operation that can be preformed on a string can be
 * prefomed on a control's Text property.
 * //////////////////////////////////////////////////////////////////////////
 * Let's look at an example. Make sure you have downloaded the student
 * sample proghrams from the book's compantion Web site
 * (at www.peasrsionHighered.com/gaddis). In the Chap03 folder, you will find
 * a project named TextBox Demo. Figure 3-2 shows the form, with most of
 * the control names epecified, and Figure 3-3 shows the form's code. 
 * (in Figure 303, to conserve space on the page, we have scrolled past 
 * the using directives that appear at the top of the code file.)
 * //////////////////////////////////////////////////////////////////////////
 * Notice in Figure 3-3 that the readInputButton control's Click
 * event handler performs the following assignment statement:
 * //////////////////////////////////////////////////////////////////////////
 * outputLabel.Text = nameTextBox.Text;
 * //////////////////////////////////////////////////////////////////////////
 * This statement assigns the value of the nameTextBox control's Text
 * property to the outputLabel contro's Text property. In other words, 
 * it gets any text that has been entered by tge user into the nameTextBox 
 * control and displays it in the outputLAbel control. IF you run the 
 * application, Figure3-4 shows an example of how the form appears after
 * you have enterd Kayhrym Smith and clicked the readInputButton control.
 * //////////////////////////////////////////////////////////////////////////
 * Clearing the Contents of a TextBox Control
 * //////////////////////////////////////////////////////////////////////////
 * You can clear the contents of a TextBox control in the same way that you
 * clear the contents of a Label control: you assign an empty string("") to
 * control's Text property. For example, the following statment clears the 
 * contrnts of the nameTextBox control:
 * //////////////////////////////////////////////////////////////////////////
 * When this statement executes, the nameTExtBox control will appear empty
 * son the application's form.
 * //////////////////////////////////////////////////////////////////////////
 * 
 * //////////////////////////////////////////////////////////////////////////
 *                      3.2 A First Look at Variables
 * //////////////////////////////////////////////////////////////////////////
 * Concept A variable is a storeage location in memory that is represented by a name.
 * //////////////////////////////////////////////////////////////////////////
 * Most programs store data in the computer's memory and preform operations on
 * that data. For example, consider the typical online shopping experiencce:
 * you browse a Web site and add the items that you want to purchase to the
 * shopping cart. As you add items to the shopping cart, data about those
 * items is stored in memory. Then when you click the checkout button,
 * a program running on the Web site's computer calculates the cost of 
 * all the items you have in your shopping cart, applicable sales taxes,
 * chipping costs, and the total of all these charges. When the program
 * performs these calculations, it stores the result im the computer's memory.
 * //////////////////////////////////////////////////////////////////////////
 * Programs use variables to store data in memory. A variable is a storage
 * location in memory that is represented by a name. For example, a program
 * that manages a compan'y customer mailing lisyt might use a variable named
 * lastName to hold a customer's last name, a variable named firstName to
 * hold the customer's first name, a variavbe named address to hold the
 * customer's mailing address, and so forth.
 * 
 * #//////////////////////////////////////////////////////////////////////////
 * In C#, you must declare a variable in a program before you can use it to 
 * store data. You do this with a variable declaration, which specifies two
 * things about the variable:
 * 
 * 1. The variable's data type, which is the type of data the variable woll hold.
 * 
 * 2. The variable's name // Otherwise know as a memory address
 * //////////////////////////////////////////////////////////////////////////
 * A variable declaration statement is written in the general format:
 * //////////////////////////////////////////////////////////////////////////
 * DataType VAriableName
 * #//////////////////////////////////////////////////////////////////////////
 * Let's take a closer look at each of these.
 * //////////////////////////////////////////////////////////////////////////
 * Data Type
 * //////////////////////////////////////////////////////////////////////////
 * A variable's data type indicates the type of data that the variable will hold.
 * BEfore you declare a variable, you need to think about the type of value that
 * will be stored in the variable. For example, will the variable hold a 
 * string or a number? IF it will hold a number, what kind of number will it
 * be, an integer or a real number? When you have determined the kind of data 
 * that the variable will hold, you select one of the data types that C#
 * provides for a variable.
 * //////////////////////////////////////////////////////////////////////////
 * The C# language provides many data types for storing fundamental types
 * of data, such as strings, integers, and real numbers. These data types 
 * are known as primitive data types. We will look at several of them in this chapter.
 *
 *#//////////////////////////////////////////////////////////////////////////
 * VAriable Name
 * //////////////////////////////////////////////////////////////////////////
 * A variable name identifies a variable in the programn code. When namin
 * g a variable, you should always choose a meaningful name that indicates
 * what the variable is used for. For example, a variable that holds teh
 * temperture might be named temperature, and a variables short, nondescript
 * names such as x or b2, but names such as thses give no clue as to the
 * purpose of the variable.
 * //////////////////////////////////////////////////////////////////////////
 * In addition, there are some specific rules that you must follow when 
 * naming a variable. The same rules for identifiers that apply to control 
 * names also apply to variable names. We discussed these rules in CHapter
 * 2, but we review them now:
 * //////////////////////////////////////////////////////////////////////////
 *      * The first character must be one of the letters a through z
 *      or A through Z or an underscore character( _ ).
 *      
 *      * After the first character, you may use the letters a through z or
 *      A through Z, the digits 0 through 9, or underscores.
 * //////////////////////////////////////////////////////////////////////////
 * When nameing variables, we use the same camelCase naming convention that
 * we introduced in Chapter 2 for control names. For example, if we are
 * declaring a variable to hold an employee's gross pay, we might name it
 * grossPay. Or, if are declaring a variable to a customer number,
 * we might name it customerNumber.
 * #//////////////////////////////////////////////////////////////////////////
 * string Variables
 * //////////////////////////////////////////////////////////////////////////
 * The first primative data type we consider is the string data type.
 * A variable of the string data type can hold any string of characters,
 * such as person's name, address,password, and so forth. Here is an
 * example of a statement that declares a string variable named productDescription:
 * //////////////////////////////////////////////////////////////////////////
 * string productDescription
 * //////////////////////////////////////////////////////////////////////////
 * After the variable has been declared, you can use the assignment operator
 * (=) to store a value in the variable. Here is an  example:
 * //////////////////////////////////////////////////////////////////////////
 * productDescription = "Italian Espresso Machine";
 * //////////////////////////////////////////////////////////////////////////
 * When this statement executes, the string literal "Italian Espresso Machine"
 * os assigned to the productDescription varible. When writing an assignment
 * statement, remeber that the assignment operator assigns the value that
 * appears on its right side to the variable that appears on its left side.
 * //////////////////////////////////////////////////////////////////////////
 * Once you have assigned a value to a variable, you can use the variable
 * in other operations. For example, assume productLabel is the name of a
 * Label control. The following statement assigns the productDescription 
 * string to the productLAbel control's Text property: 
 * //////////////////////////////////////////////////////////////////////////
 * productLabel.Text = productDescription:
 * //////////////////////////////////////////////////////////////////////////
 * After this statement executes, the string that is stored in the
 * productDescription variable is displayed in the productLabel control.
 * The following statement shows another example:
 * //////////////////////////////////////////////////////////////////////////
 * MessageBox.SHow(productDescription);
//////////////////////////////////////////////////////////////////////////
///When this statement executes, the string that is stored in the 
///productDescription variable is displayed in a message box.
/// 
/// #//////////////////////////////////////////////////////////////////////////
/// String Concatenation 
/// //////////////////////////////////////////////////////////////////////////
/// A common operation that performed on strings is concatenation, or appending 
/// one string to the end of another string. IN C# you ise the + operator to
/// concatenate strings. The + operator produces a string that is the
/// combination of the two strings used as its operands. The following
/// code shows an example:
/// //////////////////////////////////////////////////////////////////////////
/// string message;
/// message = "HEllo" +"world";
/// messageBox.Show(message);
/// #//////////////////////////////////////////////////////////////////////////
/// The first statement declares a string variable named message. The second 
/// statement combines the strings "Hello " and "world" to produce the string
/// "Hello world". The string "Hello world" is then assigned to the message
/// variable. The third statement displays the contents of the message
/// variable in a message box. When the message box is displayed,
/// it shows the string Hello world.
/// //////////////////////////////////////////////////////////////////////////
/// Let's look at an application that further demonstrates string concatenation.
/// Figure 3-5 shows the form , with most of the control names specified, and 
/// Figure 3-6 shows the form's code. (IN Figure 3-6, to conserve space on
/// the page, we have scrolled past using directives that appear at the 
/// top of the code file)
/// //////////////////////////////////////////////////////////////////////////
/// IN Figure 3-6, three statements in the showNAmeButton_Click event handler
/// are pointed out:
/// //////////////////////////////////////////////////////////////////////////
/// 1 This statement is a variable declaration. It declars a string variable
/// named fullName.
/// //////////////////////////////////////////////////////////////////////////
/// 2 this statement assigns the result of a string concatenation to the 
/// fullName variable. The string that is assigned to the variable begins
/// with the value of the firstNAmeTextBox control's Text property. For
/// example, if the user has entered joe into the firstNameText control
/// and smith into the lastNameTextBox control, this statement will assign
/// the string "Joe Smith to the fullName variable.
/// //////////////////////////////////////////////////////////////////////////
/// 3. This statement assigns the fullName variable to the fullNameLAbel
/// control's Text property. As a result, the string that is stored in the 
/// fullName variable is dusplayed in the fullNAmeLabel control.
/// //////////////////////////////////////////////////////////////////////////
/// If you run the application, Figure 3-7 shows an example of how the form
/// appears after you have entered Chris for the first name and Jones for the
/// last name and clicked the showNameButton control.
/// #//////////////////////////////////////////////////////////////////////////
/// Declaring Variables before Using Them
/// //////////////////////////////////////////////////////////////////////////
/// The purpose of a variable declaration statement is to tell the compiler
/// that you plan to use a variab;e of a specified name to store a paticular
/// type of data in the program. A variable declaration statement must appear
/// before any other statements in the method that use the variable. This makes
/// perfect sense because you cannot store a value in a var if the var has not
/// been created in mem.
/// #//////////////////////////////////////////////////////////////////////////
/// Local Variables
/// //////////////////////////////////////////////////////////////////////////
/// Notice that the fullName var inFigure 3-6 is declared inside the event
/// handler method. Variables that are declared inside a method are known as 
/// local var. A local var belongs to the method to the method in which it is
/// declared, and only statements inside that method can access the variable.
/// (The term local is ment to indicate that the variable can be used only
/// locally, within the method in which it is declared.)
/// 
/// An error will occur if a statement in one method tries to access a local
/// variable that belongs to another method. FOr example let's go over the
/// sample code shown in Figure 3-8.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 1. This statement declares a string variable named myName. The variable
/// is declared inside the firstButton_CLick event handler, so it is local 
/// to that method.
/// 
/// 2.This statement, which is also on the firstButton_CLick event handler,
/// assigns the nameTextBox control's Text property to the myName variable.
/// 
/// 3.This statement, which is in the secondButton_Click event handler,
/// attempts to assign the myName var to the outputLAbel control's Text
/// property. This statement will not work, howeber, becaise the myName
/// var is local to the firstButton_CLick event handler, and statements
/// in the secondButton_CLick event handler cannot access it.
/// #//////////////////////////////////////////////////////////////////////////
/// Scope of a Variable 
/// //////////////////////////////////////////////////////////////////////////
/// Programmers use the trem scope to describe the part a program in which
/// a var may be accessed. A var is visible only to statements inside the 
/// variable's scope.
/// 
/// A local variable's scope begins at the var's declaration and ends at the 
/// end of the method in whhich the variable is declared. As you saw in the 
/// previous example, a local variable cannot be accessed by statements that 
/// are outside the method. In addition, a local variable cannot be accessed
/// by code that is inside the method but before the variable's declaration.
/// //////////////////////////////////////////////////////////////////////////
/// Lifetime of a Variable
/// //////////////////////////////////////////////////////////////////////////
/// A variable's lifetime is the time period buring which the variable exists
/// in memory while the program is executing. A local variable is created in
/// memory when the method in which it is declared starts executing. When the
/// method ends, all the method's local variables are destroyed. So, a local
/// variable's lifetime is the time during which the method in which it is
/// declated is executing.
/// //////////////////////////////////////////////////////////////////////////
/// Duplicate Variable Names
/// //////////////////////////////////////////////////////////////////////////
/// You cannot declare two variables with the same name in the same scope. For
/// example, if you declare a variable named productDescription in an event
/// handler, you cannot declare another variable with that name in the same 
/// event handler. You can, however, have variablesof the same name declared
/// in different methods.
/// //////////////////////////////////////////////////////////////////////////
/// Assignment Compatibility
/// //////////////////////////////////////////////////////////////////////////
/// YOu can assign a value to a var only if the value is compatible with the
/// variable's data type. Only string are compatible with the string date
/// type, so all the assignments in the following code sample work:
/// 
/// //////////////////////////////////////////////////////////////////////////
/// // Declare and initialize a string variable.
/// string productDescription = "Chocolate Truffle"
/// 
/// //Declare another string variable
/// string myFAvoriteProduct;
/// 
/// //Assign a value to a string variable
/// myFavoriteProduct = productDescription;
/// 
/// //Assign a value from a TextBox to a string variable.
/// productDescription = userInputTextBox.Text;
/// //////////////////////////////////////////////////////////////////////////
/// 
/// The following comments explain these line of code:
/// //////////////////////////////////////////////////////////////////////////
/// In line 2 we initialize a string variable with a string literal.
/// THis works because string literals are assignment compatible with string varibles.
/// //////////////////////////////////////////////////////////////////////////
/// In line 8, we assign a string variable to another string variable.
/// THis works for the obvious reason that string variables are compatible
/// with other string variables.
/// //////////////////////////////////////////////////////////////////////////
/// Assume that the application has a TextBox control named userInputTextBox.
/// In line 11, we assign the value of the TextBox control's Text property to
/// a string variable. This works because the value in a control's Text
/// property is always a string.
/// //////////////////////////////////////////////////////////////////////////
/// The following code will now work, however, because it attempts to assign
/// a nonstring value to a string variable:
/// //////////////////////////////////////////////////////////////////////////
/// //Declare a string variable.
/// string employeeID;
/// 
/// // Assign a value to the variable. Will this work?
/// emplpyeeID = 125; <- ERROR!
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// In line 5, we are attempting to assign the number 125 to a string
/// variable. Numbers are not assignment compatible with string variables
/// , so this statement will cause an error when the code is compiled.
/// //////////////////////////////////////////////////////////////////////////
/// Note ALthough you cannot store the number 125 in a string variable, you
/// can store the string literal "125" in a string var.
/// //////////////////////////////////////////////////////////////////////////
/// A Variable Holds One Value at a Time
/// //////////////////////////////////////////////////////////////////////////
/// Vars can hold different values while a program is running, but they can
/// hide one value at a time. When you assign a valie to a variable, that
/// value will remain in the variable until you assign a different value
/// to the var. for ex, look at the following code sample:
/// //////////////////////////////////////////////////////////////////////////
/// // Declare a string variable.
/// string productDescription;
/// 
/// // Assign a value to the variable.
/// productDescription = "Large Medium-Rost Coffee";
/// 
/// // Display the variable's value.
/// MessageBox.Show(productDescription);
/// //////////////////////////////////////////////////////////////////////////
/// the following comments explain what we did:
/// //////////////////////////////////////////////////////////////////////////
/// *Line 2 declares a string variable named productDescription.
/// *Line 5 assigns the string "Large Medium-Rost Coffee" to the productDescription var.
///
/// *Line 8 displays the value of the productDescription variable in a
/// message box. (The message box will display Large Medium-Roast Coffee.)
/// 
/// *Line 11 assigns a different value to the productDescription variable.
/// After this statement executes, the productDescription variable will hold
/// the string "Chocolate Truffle"
/// 
/// *Line 17 displays the value of the productDescription variable in a
/// message box. (The message box will display Chocolate Truffle.)
/// //////////////////////////////////////////////////////////////////////////
/// This code sample illustrates two important characteristics of variables:
/// //////////////////////////////////////////////////////////////////////////
/// *A variable holds only one value at a time.
/// 
/// *When you store a value in a variables, that value replaces the
/// previous value that was in the variable.
/// //////////////////////////////////////////////////////////////////////////
/// Tutorial 3.1 Gives you some practice using variables. You will create an
/// application that uses TextBox controls to get input values, stores those
/// values in variables, and uses the mariables in operations.
/// //////////////////////////////////////////////////////////////////////////
/// Tutorial 3-1: The Birth Data String Application
/// //////////////////////////////////////////////////////////////////////////
/// In this tutorial, you create an application that lets the user enter the
/// following information about his or her birthday:
/// 
/// *The day of week(Monday, Tuesday, etc.)
/// 
/// *The name of the month (January, Febuary, etc.)
/// 
/// *The numeric day of the month
/// 
/// *THe year
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-9 shows the application's form, along with the names of all the
/// controls. When the application runs, the user enters each piece of data
/// into a separate TextBox. When the user clicks the SHow Data button, the
/// application concatenates the contents of the TextBoxes and the 
/// dateOutoutLabel control are cleared. The Exit button closes the
/// application's form.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio and begin a new Windows Forms Application
/// project named Birth Data String.
/// 
/// Step 2: Set up the application's form as shown in Figure 3-9. Notice that
/// the form's Text property is set to Birth Date String. The names of the
/// controls are shown in the figure. As you place each control on the form,
/// refer to Table 3.1 for the relevant property settings
/// 
/// Once you have set up the form with its controls, you can create the click
/// event handlers for the Button controls. At the end of this tutorial,
/// Program 3.1 shows the completed code for the form. You will be instructed
/// to refer to Program 3.1 as you write the event handlers. (Remember, the
/// line numbers that are shown in Program 3.1 are not part of the program.
/// They are shown for reference only._ In the SDwesigner, double-click the
/// showDataButton control. This will open the code editor, and you will see
/// an empty event handler named showDataButton_CLick. Compleate the 
/// showDataButton_Click event handler by typing the code shown in lines 
/// 22-32 Program 3.1 Lets take a closer look at the code:
/// 
/// Line 23: THis statement declars a string variable named output.
/// Line 26-29: These lines are actually one large statement, broken up into
/// multiple lines. The statment concatenates the Text propertyes of the
/// TextBox controls, along with appropriatly placed commsa and spaces, to
/// create the data string. The resulting string is assigned to the output variable.
/// 
/// For example, suppose the user has entered the following input:
/// 
///     * Firday in the dayof WeekTextBox control.
///     
///     * June in the monthTextBox control.
///     
///     * 1 in the dayOfMonthTextBox control.
///     
///     * 1990 in the yearTextBox control
///     
///    The concatenation in the statment produces the string "June 1, 1990";
///    it is assignws to the output Variable.
///    Line 32: This statement assigns the output variable to the
///    deateOutputLabel control's Text property. When this statement 
///    executes, the contents of the output variable are displayed in
///    the dataOutputLabel control.
///    
/// Step 4: Switch your view back to the Designer and double-click the
/// clearButton control. In the code editor, you will see an empty event
/// handler named clearButton_CLick. Compleate the clearButton_CLick event 
/// handler by clearButton_click. Complete the clearButton_CLick ebent handler
/// by typing the code shown in the line 37 - 44 in the Program 3.1.
/// 
/// Let's take a closer look at the code:
/// 
/// Lines 38-41: Each statement an empty string ("") to the Text property of
/// one of the TextBox controls.When these statments have finished executing 
/// , the TextBox controls will appear empty. 
/// 
/// Line 44: This statement assigns an empty string ("") to the dateOutputLAbel
/// control's Text property/ After the statement has executed, the label
/// appears empty.
/// 
/// Step 5: Switch your view back to the Designer and double-click the
/// exitButton control. IN the code editor, you will see an empry event
/// handler named exitButton_Click. Complete the exitButton_Click event 
/// handler by typing the code shown in line 49-50 in Program 3.1. 
/// 
/// Step 6: Save the project. Then, press the F5 key on the keyboard, or
/// click the Start Debugging button on the toolbar to compile and run the
/// application, The form will appear as shown in the inage on the left in
/// Figure 3-10. TEst the application by entering values into the TextBoxes
/// and clicking  the Show DAta button. The data should be displayed , similer
/// to the images shown on the right in the figure. Click the Clear button, 
/// and the contents of the TExtBoxes and the Label control should clear. 
/// Click the Edit button and the form should close
///    
/// //////////////////////////////////////////////////////////////////////////
/// Note  In Tutorial 3.1, the statement in the lines 26-29 shows an example
/// of how you can break up a statement into multiple line. Quite often, you
/// will find yourself writing statments that are too long to fit entirely
/// inside the COde window. Your code will be hard to read if you have to 
/// horizontally scroll the code window to view long statements. In addition,
/// if you or your instructor choosaes to print your code, the statements that
/// are too long to fit on one line of the page will wrap around to the next
/// line and make your code look unorganized. For these reasons, it is usually 
/// best to break a long statement into multiple lines. When typing most
/// statements, you can simply press the Enter key when you reach an
/// appropriate point to continue the statment on the next line. Remember,
/// however, that you cannot break up a keyword, a quoted string, or an 
/// iderfifier (such as a variable name or a control name).
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Initializing VAriables
/// 
/// In C#, a varuable must be assigned a value before it can be used. for
/// example, look at the code:
/// 
/// string productDescription;
/// MessageBox.Show(productDescription);
/// 
/// This code declars a string variable named productDescription and then tries
/// to display the variable;s value in message box. The only problem is that we
/// have not asigned a value to the variable. When we compile the application
/// contrining this code, we will get an erroe message such as User of unassigned 
/// local variable 'productDescription'. The C# compiler will not compile code
/// that tries to use an unassigneed variable.
/// 
/// One way to makle sure that a variable has been assigned a value is to
/// initialieze the variable with a value when you declare it. For example,
/// the following statement declares a string variable named producDescription
/// and immediately assigns the string literal "Chocolate Truffle" to it: 
/// /// //////////////////////////////////////////////////////////////////////////
/// string productDescription = "Chocolate Truffle";
/// //////////////////////////////////////////////////////////////////////////
/// We say that this statement initializes the productDescription variable
/// with the string "Chocolate Truffle". Here is another example:
/// //////////////////////////////////////////////////////////////////////////
/// string lastName = lastNameTextBox.Text;
/// //////////////////////////////////////////////////////////////////////////
/// Assume that this statement belongs to an appliocation that has a TextBox
/// named lastNameTextBox. The statement declars a string variable named
/// lastName and initalizes it whith the value of the lastNameTextBox. The
/// statement declats a string variable named lastName adn initializes it
/// with the value of the lastNameTextBox control's Text property
/// //////////////////////////////////////////////////////////////////////////
/// Declaring Multiple Varables with One Statement
/// //////////////////////////////////////////////////////////////////////////
/// You can declate multiple cvariables of the same data type with one
/// declaration statement Here is an example:
/// //////////////////////////////////////////////////////////////////////////
/// string lastNAme, firstNAame, middleName
/// //////////////////////////////////////////////////////////////////////////
/// This statement daclares three string variables named lastName, firstName, and 
/// middleName. Notice that commas seperate the variavle names. Here is an 
/// example how we can declare and initialize the variables with one statement:
/// //////////////////////////////////////////////////////////////////////////
/// string lastNAme = "Jones", firstNAme = "jill", middleNAme = "Rebecca";
/// //////////////////////////////////////////////////////////////////////////
/// Remember, you can break up a long statement so it spreads across two or
/// more lines. Sometimes you will see long variable declarations written
/// multiple lines, like this:
/// //////////////////////////////////////////////////////////////////////////
/// string lastName = "Jones"
///        fistName = "Jill",
///        middleName = "Rebecca";
/// //////////////////////////////////////////////////////////////////////////
/// Checkpoint
///     3.5 What is the purpose of a variable
/// //////////////////////////////////////////////////////////////////////////
///     3.6 Give an example of a variable declaration that will store the name
///     of your favorite food
/// //////////////////////////////////////////////////////////////////////////
///     3.7 For each of the following items, determine whether the data type
///     should be an integer, string, or real number.
///             a. pet name
///             b. sales tax
///             c. mailing address
///             d. video game score
/// //////////////////////////////////////////////////////////////////////////
///     3.8 Indicate whether each of the following is a legal variable name.
///     IF it is not, explain why.
///             a. pay_Rate
///             b. speed of sound
///             c. totalCost
///             d. 2ndPlaceName
/// //////////////////////////////////////////////////////////////////////////
///     3.9 What will be stored in the messagte variable after the following
///     statement is executed?
/// //////////////////////////////////////////////////////////////////////////
///                     string message = "HE" + "ll" + "o!";
/// //////////////////////////////////////////////////////////////////////////
/// 3.10 What is the lifetime of a variable that is declared inside
///     of a Click event handler?
/// //////////////////////////////////////////////////////////////////////////
/// 3.11 Assuming the variable greeting has not been assigned a value,
///     what will be the result of the follwing statement?
/// //////////////////////////////////////////////////////////////////////////
///                     MessageBox.Show(greeting);
/// //////////////////////////////////////////////////////////////////////////
/// 3.12 Will the following statement cause an error? Why or why not?
/// //////////////////////////////////////////////////////////////////////////
/// string luckyNumber = 7;
/// //////////////////////////////////////////////////////////////////////////
/// 3.13 Write a single declaration statement for the variables name,
/// city, and state.
/// //////////////////////////////////////////////////////////////////////////
///
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
///                     3.3 Numeric Data Types and Variables
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Concept IF you need to store a number in a variable and use that number
/// in a mathematical opertation, the variable must be of a numeric data type.
/// You selected a numberic data type that is appropriate for the type of 
/// number that you need to store.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// IN the previous section, you read about string variables. Variavbles of
/// the string data type can be used to store text, but they cannot store
/// numeric data for the purpose of performing mathematical operations, IF
/// you need to store numbers and perform mathematical operations on them,
/// you have to ise a numeric data type.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The C# language provides several primitive data types. You can read about
/// all the C# primitive data types in Appendic A. Many of the data types
/// provided by C# are for specialized purposes byond the scope of this book.
/// When it comes to numeric data, most of the time you will use the three
/// numeric primtive data types described in Table 3.2
/// //////////////////////////////////////////////////////////////////////////
/// Here are examples of declaring variables of each data type :
/// //////////////////////////////////////////////////////////////////////////
/// int speed;
/// double distence;
/// decimal grossPay;
/// //////////////////////////////////////////////////////////////////////////
/// The first statement declates an int variable named speed. The second
/// example declares a double variable named distance. The third statement
/// declares a variable named grossPay.
/// //////////////////////////////////////////////////////////////////////////
/// NUmeric Literals 
/// //////////////////////////////////////////////////////////////////////////
/// You learned in Chapter 2 that a literal is a piece of data written into
/// a program;s code. When you know, at the time that you are writting a
/// program's code, that you want to store a specfic value in a variable,
/// you can assign that value as a literal to the variable.
/// //////////////////////////////////////////////////////////////////////////
/// A numeric literal is a number that is written into a program's code. For
/// example, the follwoing statement declares an int variable named
/// hoursWorked and initializes it with the value 40:
/// //////////////////////////////////////////////////////////////////////////
/// int hoursWorked = 40;
/// //////////////////////////////////////////////////////////////////////////
/// IN this statement, the number 40 is a numeric literal. The following shows another example:
/// //////////////////////////////////////////////////////////////////////////
/// double temperature = 87.6;
/// //////////////////////////////////////////////////////////////////////////
/// This statement declates a double variable named temperature and
/// initializes it with the value 87.6 The number 87.6 is a numeric literal.
/// //////////////////////////////////////////////////////////////////////////
/// When you write a numeric literal in a program's code, the numeric literal
/// is assigned a data type. In C#, if a numeric literal is an integer(not 
/// writen with a deciamal point) and it fits within the range of an int (see
/// Table 3.2 for the minimum and maximum values), then the numeric literal 
/// is treated as an int. A numeric literal that is treated as an int is 
/// called an integer literal. For example, each of the following statements
/// initalizes a variable with an integer literal:
/// //////////////////////////////////////////////////////////////////////////
/// int hoursWorked = 40;
/// int unitsSold = 650;
/// int score = -23;
/// //////////////////////////////////////////////////////////////////////////
/// if a numeric literal is written with a decimal point and it fits within
/// the range of a double (see Table 3.2 for the minimum and maximun values
/// , then the numeric luteral is treated as a double. A numeric literal that
/// is treated as a double is called a double literal. For example, each of 
/// the following statements initalizes a variable with a double literal:
/// //////////////////////////////////////////////////////////////////////////
/// double distense = 28.75;
/// dobule speed = 87.3;
/// double temperature = -10.0
/// //////////////////////////////////////////////////////////////////////////
/// When you append the letter M or m to a numeric literal, it is treated
/// as a decimal and its referred as a deciaml literal. Here are some examples
/// //////////////////////////////////////////////////////////////////////////
/// decimnal payRate = 29.75m
/// decimnal price = 8.9M
/// decimal profit = -50m;
/// //////////////////////////////////////////////////////////////////////////
/// Tip
/// Because decimal is the preferred data type for storing monetary amounts,
/// remembering that "m" stands for "money" might help you remember that
/// decimal literals must end with the letter M or m.
/// //////////////////////////////////////////////////////////////////////////
/// Assignment Compatibility for int Variables
/// //////////////////////////////////////////////////////////////////////////
/// You can assign int values to int variables. For example, look at the 
/// following declarations:
/// //////////////////////////////////////////////////////////////////////////
/// int hoursWorked = 40; <- THis works
/// int uniteSold = 650ma <- ERROR!
/// int score = -25.5; <-- Error!
/// //////////////////////////////////////////////////////////////////////////
/// The first declaration works because we are initalizing an int variable
/// with an int value. The second declaration caises an error, however 
/// because you cannot assign a decimal value to an int variable. 
/// The third declaration also causes an error because you cannot
/// assign a double value to an int variable.
/// //////////////////////////////////////////////////////////////////////////
/// You cannot assign a double or a decimal value to an int variable bacause
/// such an assignment could result in a loss of data. Here are the reasons:
/// //////////////////////////////////////////////////////////////////////////
/// The double and decimal values may be fractional, but int variables can
/// hold only integers. IF you were allowed to store a fractional value in
/// an int variable, the fractional part of the value would have to be
/// discarded.
/// //////////////////////////////////////////////////////////////////////////
///  The double and decimal values may be much larger or much smaller than
///  allowed by the range of an int variable. A double or a decimal number
///  can potentially be so large or so small that it will not fit i
///  an int variable
/// //////////////////////////////////////////////////////////////////////////
/// Assignment Compatibility for double Variables
/// //////////////////////////////////////////////////////////////////////////
/// You can assign either double or int values to double variables, but you
/// cannot assign decimal values to double variables. For example, look at 
/// the following declarations: 
/// //////////////////////////////////////////////////////////////////////////
/// double distance = 28.75; <- THis works
/// double speed = 75;       <- THis works
/// double sales = 6500.0m;  <- ERROR!
/// //////////////////////////////////////////////////////////////////////////
/// The first declaration works because we are initializing a double variable
/// with a double value. The second declaration works because we are 
/// initializing a double variable with an int value. The third declaration
/// causes an error, however, bacause you cannot assign a decimal value 
/// to a double variable.
/// //////////////////////////////////////////////////////////////////////////
/// It makes sense that you are allowed to assign an int value to a double
/// variable bacause any number that can be stored as an int can be converted
/// to a double with no loss of data. When you assign an int value to a double
/// variable, the int value is implicaitly converted to a double.
/// //////////////////////////////////////////////////////////////////////////
/// You cannot assign a decimal value to a double variable because the decimal
/// data type allows for much greater precision than the double data type. A
/// decimal value can have up to 28 digits of precision, whereas a double can
/// provide only 15 digits of precision. Storing a decimal value in a double
/// variable could potentially result in a loss of data
/// //////////////////////////////////////////////////////////////////////////
/// Assignment Compatibility for decimal Variables
/// //////////////////////////////////////////////////////////////////////////
/// You can assign either decimal or int values to decimal variables, but you
/// cannot assign double values to decimal variables. For example, look at
/// the following declarations:
/// //////////////////////////////////////////////////////////////////////////
/// decimal balance = 9280.73m; <- This works
/// decimal price = 50;         <- This works
/// decimal sales = 6500.0;     <- ERROR!
/// //////////////////////////////////////////////////////////////////////////
/// The first declaration works because we are initialing a decimal variable
/// with a decimal value. The second declaration works because we are
/// initializing a decimal variable with an int value. When you assign
/// an int value to a decimal variable, the int value is implicitly
/// converted to a decima; whith no loss of data. The third declaration 
/// causes an error, however, bevause you cannot assign a double value to 
/// a decimal variable. A double value can potentially be much larger or
/// much smaller than allowed by the range of a decimal.
/// //////////////////////////////////////////////////////////////////////////
/// Explicitly Converting Values with Cast Operators
/// //////////////////////////////////////////////////////////////////////////
/// Let's consider a hypothetical situation. Suppose you've written an 
/// application that uses a double var, and for some reason, you need 
/// to assign the contents of the double var to an int var. IN this
/// particular situation, you know that the double var's value is 
/// somthing that can be safely converted to an int without any loss 
/// of data(such as 3.0, or 98.0). However,  the C# compiler will not 
/// allow you to make the assignment because double values are not
/// assignment compatible with int vars. Isn;t there a way to override
/// the C# rules in this particular sitation and make the assignment
/// anyway?
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The answer is yes, there is a way. You can use a cast operator to
/// explicitly convert a value from one numeric data type to another,
/// even if the conversion might result in a loss of data. A cast operator
/// is the name of the desired data type, written inside parentheses and 
/// placed to the left of the valur that you want ot convert. The following
/// code sample demonstrates:
/// //////////////////////////////////////////////////////////////////////////
/// // Declare an int variable.
/// 
/// int wholeNumber;
/// 
/// // Declare a double variable.
/// double realNumber = 3.0;
/// 
/// // Assign the double to the int.
/// wholeNumber = (int)realNumber;
/// //////////////////////////////////////////////////////////////////////////
/// The following points describe the code:
/// 
///     *Line 2 declares an int var named wholeNumber.
///     
///     * Line 5 declares a double variable named realNumber, initialized 
///     with the value 3.0.
///     
///     *Line 8 users a cast operator to convert the value of realNUmber to an
///     int and assigns the converted valie to wholeNUmber. After this statement
///     executes, the whileNumber variable is assigned the value 3.
///     
/// Table 3.3 shows other code examples involving different types of cast operators.
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When you use a castoperator, you are essentially telling the compiler 
/// that you know what you are doing and you are willing to accept the 
/// consequences of the conversion. IT is still possible that a loss of 
/// data can occur. FOr ex, look at the following code:
/// //////////////////////////////////////////////////////////////////////////
/// int while Number;
/// 
/// double realNumber = 8.9;
/// whileNumber = (int)realNumber;
/// //////////////////////////////////////////////////////////////////////////
/// IN this example, the souble variable contrins a fractional number.
/// When the cast operator converts the fractional number to an int, the part
/// of the number that appears after the decimal point is dropped. The process
/// of dropping a number's fractional part is called truncation. After this
/// code executes, the wholeNumber variable contrins the value 8.
/// //////////////////////////////////////////////////////////////////////////
/// It's important to realize that when a cast operator is applied to a var, 
/// it does not change the contents of the var. The cast operator merely
/// returns the value that is stored in the var, converted to the specifed
/// data type. In the prevoise code sample, when the (int) cast operator is
/// applied to the realNumber var, the cast opertor retues the value 8. The 
/// realNumber variable remains unchanged, however, still containing the 
/// value 8.9
/// //////////////////////////////////////////////////////////////////////////
/// Declaring Local Variables with the var Keyword
/// //////////////////////////////////////////////////////////////////////////
/// C# provides an alternative way to declare local variables, using the 
/// keywond and an initialization value. Here is an example:
/// //////////////////////////////////////////////////////////////////////////
/// var amount = 100;
/// //////////////////////////////////////////////////////////////////////////
/// Notice that this statement uses the word var instead of a data type. 
/// The var keyword tells the compiler to determine the variabl's data type 
/// from the initialization value. In this example, the initialization value 
/// 100 is an int, so amount will be an int variable. Here are other examples:
/// //////////////////////////////////////////////////////////////////////////
/// var interestRate = 12.0;
/// var stockCode = "D465U";
/// var accountBalance = 1000.0m;
/// //////////////////////////////////////////////////////////////////////////
/// IN this code, the InterestRate variable will be a double because the 
/// initialization value 12.0 is a doudle. THe stockCode variable will be a 
/// string because the initialization value "D465U" is a string. The accountBalance
/// variable will be a decimal because the initialization value 1000.0m
/// is a decimal.
/// //////////////////////////////////////////////////////////////////////////
/// var x,y,z = 99;        // ERROR!
/// //////////////////////////////////////////////////////////////////////////
/// YOu must provide an initialization value when you declare a variable with
/// the var, keyword. The following statement will cause an error:
/// //////////////////////////////////////////////////////////////////////////
/// var myvalue;
/// //////////////////////////////////////////////////////////////////////////
/// These examples show how to use the var keyword, but they don't really show
/// its usefulness. The var keyword is intended to simplify the syntax of
/// declarations that are more comples than the onces shown here. Later in
/// the book, you will see examples of how the var key can improve the 
/// readablity of complex definition statements.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 3.4 Preforming Calculations
/// //////////////////////////////////////////////////////////////////////////
/// Concept You can use math operators to preform simple calculations. Math
/// expressions can be written using the math operators and parenthese as 
/// grouping sybols. The result of a math expression can be assigned to a 
/// variable.
/// //////////////////////////////////////////////////////////////////////////
/// Most programs require calculations of some sort to be performed. A 
/// programmer's tools for performing calculations are math operatios. C# 
/// provides the math operators shown in Table 3.4.
/// //////////////////////////////////////////////////////////////////////////
/// Programmers use the operators shown in Table 3.4 to create math
/// expressions A math experession preforms a calculation and gives a value.
/// The following is an example of a simple math expression:
/// //////////////////////////////////////////////////////////////////////////
/// 12*2
/// //////////////////////////////////////////////////////////////////////////
/// The values on the right and left of the * operator are called oprands. 
/// THese are values that the * operator multiples together. The value
/// that is given by this expression is 24.
/// //////////////////////////////////////////////////////////////////////////
/// VAriables may also be used in a math expression. Forexample, suppopse we have
/// two variables may also be usaed in a math expression. For example, suppose 
/// we have two variables named houtresWorked and payRate. The following
/// math expression uses the * operator to multiply the value in the 
/// hoursWorked variable by the value in the payRate variable:
/// //////////////////////////////////////////////////////////////////////////
/// hoursWorked * payRate 
/// //////////////////////////////////////////////////////////////////////////
/// When we use a math expression to calculate a value, we have to do
/// something with the value. Normally we want to save the value in memory so 
/// we can use irt again in the program.
/// We do this with an assignment statement. Foe example, suppose we have 
/// another variable named grossPay. The following statement assigns the 
/// value hoursWorked times payRate to the grossPay variable:
/// //////////////////////////////////////////////////////////////////////////
/// total = price + tax;
/// sale = price - discount;
/// commission = sales * percent;
/// half = number / 2; 
/// //////////////////////////////////////////////////////////////////////////
/// The modulus operator (%) preforms division between two integers, but 
/// instead of returing the quotient, it returns the remainder. The follwing
/// statment assigns 2 to leftOver: 
/// //////////////////////////////////////////////////////////////////////////
/// leftOver = 17 % 3;
/// //////////////////////////////////////////////////////////////////////////
/// The statement assigns 2 to leftover because 17 divided by 3 is 5 with a 
/// remainder of 2. You will not use the modulus opeerator refquently, but
/// it it useful in some situations. It is commonly used in calculations 
/// that detect odd or even numbers, determine the day of the week, or measure
/// the passge of time and in oither speclized operations.
/// //////////////////////////////////////////////////////////////////////////
/// The Order of Operations
/// //////////////////////////////////////////////////////////////////////////
/// You can write mathmatical expressions wil several operators. The 
/// following statement assigns the sum of 17, the variable x, 21 and the
/// variable y to the variable anwser.
/// //////////////////////////////////////////////////////////////////////////
/// answer = 17 + x + 21 + y;
/// //////////////////////////////////////////////////////////////////////////
/// Some expressions are not that straightforward, however. Consider the
/// following statemet:
/// //////////////////////////////////////////////////////////////////////////
/// outcome = 12 + 6 / 3;
/// //////////////////////////////////////////////////////////////////////////
/// What value will be stored in outcome? The number 6 is used as an operand 
/// for both the assition and division operators. The outcome var could be 
/// assigned either 6 or 14, depending on when the division takes place.
/// The answer is 14 because the order of operations dictates that the 
/// divison operator works before addition operator does.
/// //////////////////////////////////////////////////////////////////////////
/// The order of operations can be summarized as follows:
/// 
/// 1. Preform any operations that are enclosed in parentheses.
/// 2. Preform any multiplications, divisions, or modulus operations as they
///    appear from left to right.
/// 3. Perform any additions or subtractions as they appear from left to right.
/// //////////////////////////////////////////////////////////////////////////
/// Mathematical expressions are evaluated from left to right. Mulitplication
/// and division are always performed before addition and subtraction, so the
/// statement
/// //////////////////////////////////////////////////////////////////////////
/// outcome = 12 + 6 / 3;
/// //////////////////////////////////////////////////////////////////////////
/// works like this:
/// //////////////////////////////////////////////////////////////////////////
///     1. 6 is divided by 3, yielding a result of 2.
///     2. 12 is added to 2, yielding a result of 14.
/// //////////////////////////////////////////////////////////////////////////
/// IT could be diagramemd as shown in Figure 3-11.
/// //////////////////////////////////////////////////////////////////////////
/// Table 3.5 shows some other sample expressions with their values.
/// //////////////////////////////////////////////////////////////////////////
/// Grouping with Parentheses
/// //////////////////////////////////////////////////////////////////////////
/// Parts of a mathematical expression may be grouped with parentheses to force
/// some operations to be preformed before other. IN the fikkiwubng statent,
/// the vars a and b are added together, and their sum is diviede by 4:
/// //////////////////////////////////////////////////////////////////////////
/// result = (a+b)/4;
/// //////////////////////////////////////////////////////////////////////////
/// But what if we left the parentheses out, as shown here?
/// //////////////////////////////////////////////////////////////////////////
/// result = a + b / 4;
/// //////////////////////////////////////////////////////////////////////////
/// We would get a different result. Without the parentheses, b would be 
/// devided by 4 and the result added to a. Table 3.6 shows some math expressions
/// that use parentheses and their values.
/// //////////////////////////////////////////////////////////////////////////
/// Mixing Data Types in a Math Expression
/// //////////////////////////////////////////////////////////////////////////
/// When you preform a math operation on two operands, the data types of the 
/// result will depend on the type of the operands. IF the operands are of the 
/// same data type, the result will also be of that data type. For ex:
/// 
///     *When an operations is performmed on two int values, the esult will be an int.
///     *When an operation is performed on two double values, the result will 
///     be a double.
///     *When an operation is performed on two decimal values, the result will 
///     be a decimal values.
///     
/// //////////////////////////////////////////////////////////////////////////
/// It's not uncommon, however, for a math expression to have operands of
/// diferent data types. C# handles operations involving int, double, and 
/// decimal operands in the following ways:
/// //////////////////////////////////////////////////////////////////////////
/// *When a math expression invilves an int and a double, the int is 
/// temporarily converted to a double, and the result is a double.
/// *When a math expression involves an int and a decimal, the int is 
/// temporarily converted to a decimal, and the result is a decimal.
/// *Math expressions involving a double and a decimal are not allowed unless
/// a cast operator is used to convert one of the operands.
/// //////////////////////////////////////////////////////////////////////////
/// For example, suppose a pay-calculating program has the follwoing
/// -variable declarations:
/// 
/// int hoursWorked;    // To hold the number of hours worked
/// decimal payRate:
/// deciamal grossPay;  // To hold the gross pay
/// //////////////////////////////////////////////////////////////////////////
/// Then, later in the program this statement appears:
/// //////////////////////////////////////////////////////////////////////////
/// grossPay = hoursWorked * payRate;
/// //////////////////////////////////////////////////////////////////////////
/// The math expression on the right side of the = operator multiplies an int
/// by a decimal. When the statement executes, and then multiplied by the payRate
/// variable. The result is a decimal and is assigned to the grossPay variable.
/// //////////////////////////////////////////////////////////////////////////
/// When possible, you should avoid math operations that use a mixture of double
/// and decimal operands. C# does not allow operations involving these two types
/// unless you a cast operator to explicitly conver one of the operands. For 
/// ex, suppose a program that calculates the cost of a product has the following 
/// variable declatations:
/// //////////////////////////////////////////////////////////////////////////
/// double weight;          // The product weight
/// decimal pricePerPound;  // The proce per pound
/// decimal total;          // The ritak cost
/// //////////////////////////////////////////////////////////////////////////
/// Later in the program you need to calculate the total cost, like this:
/// //////////////////////////////////////////////////////////////////////////
/// total = weight * pricePerPound; <- ERROR!
/// //////////////////////////////////////////////////////////////////////////
/// The compiler will not allow this statement because weight is a double and
/// PricePerPound is a decimal. To fix the statement, you can insert a cast
/// operator, as shown here:
/// //////////////////////////////////////////////////////////////////////////
/// total = (decimal)weight * pricePerPound;
/// //////////////////////////////////////////////////////////////////////////
/// The cast operator converts the value of the weight variable to a decimal,
/// and the converted value is multiplied by pricePerPound. The result of the
/// expression is a decimal and is assigned to total.
/// //////////////////////////////////////////////////////////////////////////
/// Integer Division
/// //////////////////////////////////////////////////////////////////////////
/// When you devide an integer by an integer in C#, the result is always
/// given as an integer. IF the result has a fractional part, it is truncated.
/// For ex, look at the following code:
/// //////////////////////////////////////////////////////////////////////////
/// int length;         //Declare length as an int
/// double half;        //Declare half as a double
/// length = 75;        //Assign 75 to length
/// half = length / 2;  // Calculate half the length
/// //////////////////////////////////////////////////////////////////////////
/// The last statement divides the value of length by 2 and assigns the
/// result to half. Mathematically, the result of 75 divided by 2 is 37.5
/// However, that is not the result that we get from the math expression.
/// The length variable is an int, and it is being devived by the numeric
/// leiteral 2, which is also treated as an int. The result of the division
/// is truncated, which gives the value 37. This is the value that is assigned
/// to the half variable. IT does not matter that the half variable is 
/// declared as a double. The fractional part of the result is truncated 
/// before the siignment takes place.
/// //////////////////////////////////////////////////////////////////////////
/// Combined Assignment Operators
/// //////////////////////////////////////////////////////////////////////////
/// Sometimes you want to increase a variable's value by a certain amount. 
/// For example, suppose toy have a variable named number and you want to 
/// increase its value by 1. You can accomplish that with 
/// the following statement:
/// //////////////////////////////////////////////////////////////////////////
/// number = number + 1;
/// //////////////////////////////////////////////////////////////////////////
/// The expression on the right side of the assignemnt operator calculates
/// the value of number plus 1. The result is then assigned to number, replacing
/// the value that was previously stored there statement executes, it is equal
/// to 7 after the statement executes.
/// //////////////////////////////////////////////////////////////////////////
/// Similarly, the following statement substracks 5 from number:
/// //////////////////////////////////////////////////////////////////////////
/// number = number - 5;
/// //////////////////////////////////////////////////////////////////////////
/// IF number is equal to 15 before this statement executes, it is equal to 10
/// after the statement executes. Here's another example. The following statement
/// doublwa the value of number variable:
/// //////////////////////////////////////////////////////////////////////////
/// num = num*2
/// //////////////////////////////////////////////////////////////////////////
/// If number is equal to 4 before this statement executes, it is equal to 8 after
/// the statement executes.
/// //////////////////////////////////////////////////////////////////////////
/// These types of operations are very common in programming. For convenience,
/// C# offers a special set of operators know as combined assignment operators
/// that are designed specificallt for these jobs. Table 3.7 shows the
/// combined assignment operators.
/// //////////////////////////////////////////////////////////////////////////
/// AS you can see, the combined assignment operators do not require the
/// programmer to type the variable name twice. Also, they give a clear
/// indication of what is happening in the statement.
/// //////////////////////////////////////////////////////////////////////////
/// 3.5 Inputting and Outputting Numeric Values
/// //////////////////////////////////////////////////////////////////////////
/// Concept If the user has entered a number into a TextBox, the number will be
/// stored as a string in the TextBox's Text property. IF you want ot store that
/// number in a numeric variable, you have to convert it to the appropriate 
/// numeric data type. When you want to display the value of a numeric variable 
/// in a Label control or a message box, you have to convert it to a string.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Getting a Number from a TextBox
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Graphical User (GUI) applications typically use TextBox controls to read
/// keyboard input.
/// 
/// Any data that the user enters into a TextBox control is
/// stored in the control's Text property as a string, even if it is a number.
/// 
/// For example, if the user enters the number 72 into a TextBox control, 
/// the input is stored as the string "72" in the control's Text property
/// to the desired numberic data type.Unfortunatelty, you cannot use a 
/// cast operator to convert a string to a numeric type.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// To convert a string to any of the numeric data types, we use a family of
/// methods in the .NET Framework known as the Parse method. In computer science, 
/// the term parse typically means to analyze a string of characters for some
/// purpose. The Parse method sre used to convert a string to a specific
/// data type. There are several Parse methods in the .NET Framework, but
/// because we are primarily using the int, double, and decimal numeric 
/// data types, we need only three of them:
/// //////////////////////////////////////////////////////////////////////////
/// * WE use the int.Parse method to convert a string to an int.
/// * We use the double.Parse method to convert a string to a double.
/// * We use the decimal.Parse method to convert a string to a decimal
/// //////////////////////////////////////////////////////////////////////////
/// When you call one of the Parse methods, you pass a piece of data known as
/// an argument into the method, and the method returns a piece of data back to you.
/// The srgument that you pass to the method is the string that you want to convert, 
/// and the piece of data that the method returns back to you is the converted value.
/// Figure 3-12 illustrates this concept using the int.PArse method as an example.
/// //////////////////////////////////////////////////////////////////////////
/// The following code sameple shows how to use the int.Parse method to convert
/// a control's Text property to an int. Assumes that hoursWorkedTextBox is the
/// name of a TextBox control.
/// //////////////////////////////////////////////////////////////////////////
/// // Declare an int variable to hold the hours worked.
/// int hoursWorked;
/// 
/// // Get the hours worked from the TextBox.
/// hoursWorked = int.PArse(hoursWorkedTExtBox.Text);
/// //////////////////////////////////////////////////////////////////////////
/// Let's assume that the user has entered the value 40 into the 
/// hoursWorkedTextBOx control. In line 5 of the code sample, on the right side
/// of the = operator is the expression int.Parse(hoursWorkedTextBox.Text). This
/// expression calls the int.PArse method, passing the value of
/// hoursWorkTextBox.Test as an argument. Because the user has entered 40 into
/// the TExtBox, the string "40" is the value is passed as the argument. The
/// method converts the string "40" to the int value 40. The int value 40 is 
/// returned from the method and the = operator assigns  it to the hoursWorked
/// variable Figure 3-13 illustates this processs.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-13 Converting TextBox input to an int
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The following code sample demonstates the double.Parse method. Assume that
/// temperatureTextBox is the name of a TextBox control.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 1 // Declare a double variable to hold the temperature.
/// 2 double temperature;
/// 3
/// 4 // Get the temperature form the TextBox.
/// 5 temperature = double.Parse(temperatureTextBox.Text);
/// //////////////////////////////////////////////////////////////////////////
    
Line 5 passes temperatureTextBox.Text as an argumrnt to the double.Parse
method. That value is converted to a double, returned from the double.parse
method, and assigned to the temperature variable.
//////////////////////////////////////////////////////////////////////////
///
/// The Following code sample demonstrates the decimal.Parse method.
/// Assume that moneyTextBox is the name of a TextBox control.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 1 // Declare a decimal variable to hold an amount of money.
/// 2 decimal money;
/// 3
/// 4 // Get an ammount from the TextBox.
/// 5 money = decimal.Parse(moneyTextBox.Text);
/// //////////////////////////////////////////////////////////////////////////
/// 
/// Line 5 passes moneyTextBox.Text as an argument to the decimal.PArse method
/// That value is converted to a decimal, returned from the decimal.parse
/// method, and assigned to the money variable.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Note
/// //////////////////////////////////////////////////////////////////////////
/// If you look at the top of a form's source code editor, you should see a 
/// directive that reads using System; .That directive is required for any
/// program that uses the Parse methods.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Invalid Conversions
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The Parse methods work only if the string that is being converted
/// contains a valid numeric value.  IF the string contains invalid
/// characters orcontains a number that cannot be converted to the specified
/// data typean error known as an exception occurs. An exception is an unexpected 
/// wrror that occurs while a program is running, causing the program to 
/// halt if the error is not properly delt with.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// For example, assume that hoursWorked is an int variable and
/// hoursWorkedTextBox is a TextBox control. Suppose the user has entered xyz
/// into the TextBox and the following statement executes:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// hours Worked = int.Parse(hoursWorkedTextBox.Text);
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// OBviously, the string "xyz" cannot be converted to an int, so an 
/// exception occurs. (When an exception occurs, programmers say an exception
/// is "thrown.") Depending on how you execute the application, you will see
/// one of the windows displayed in Figure 3-14 or Figure 3-15.
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-14 Exception reported
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-15 Exception reported
/// //////////////////////////////////////////////////////////////////////////
/// 
/// *If you see the window in Figure 3-14, you can stop the application by
/// clicking the stop Debugging button ([]), or by pressing shift + f5, or by
/// clicking Debug and then Stop Debugging.
/// 
/// *When you see the window shown in Figure 3-15, in most situations you
/// should click the Quit button to stop the application.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// Later in this chapter, you will learn how to catch errors like this and 
/// prevent the program from halting
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Displaying Numeric Values
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// Suppose an application has a decimal variable named grossPay and a Label
/// control named grossPayLabel. You want to display the variable into the
/// grossPayLabel control's Text  property. The following assignment
/// statement will not work, however:
/// //////////////////////////////////////////////////////////////////////////
/// grossPAyLabel.Text = grossPay; <- ERROR!
/// //////////////////////////////////////////////////////////////////////////
/// You cannot assign a numeric value to a control's TExt property because
/// only strings can be assigned to the Text property. If you want to display
/// the value of a numeric variable in a label control, you have to convert
/// the variable's value to a string.
/// //////////////////////////////////////////////////////////////////////////
/// You cannot assign a numeric value to a control's Text property because
/// only strings can be assigned to the Text property. IF you want to display
/// the value of a numeric variable in a Label control, you have to convert
/// the variable's value to a string.
/// //////////////////////////////////////////////////////////////////////////
/// Luckily, all variables have a ToString method that you can call to convert 
/// the variable's value to a string. You call the ToString method using
/// the follwoing general format:
/// //////////////////////////////////////////////////////////////////////////
/// variableNAme.ToString()
/// //////////////////////////////////////////////////////////////////////////
/// In the general format, variableNAme is the name of any variable. The
/// expression returns the variable's value as a string. Here is a code 
/// sample that demonstrates:
/// //////////////////////////////////////////////////////////////////////////
/// decimal grossPay = 1550.0m;
/// grossPayLAbel.Text = grossPay.ToString();
/// //////////////////////////////////////////////////////////////////////////
/// The first statement declares a decimal varible named grossPay 
/// initalized with the value 1,550.0. IN the second statement, the expression
/// on the right side of the = operator calls the gorsspay var's ToString
/// method. The mathod, returns the string "1550.0" The = operator then 
/// assigns the string "1550.0" to the grossPayLabel control's text property.
/// 
/// As a result, the value 1550.0 is displayed in the grossPayLabel control. 
/// The method returns the string "1550.0". The = operator then assigns the
/// string "1550.0" to the grossPayLabel control's Text property. As a result,
/// the value 1550.0 is displayed in the grossPayLAbel control. This process
/// is illustrated in Figure 3-16. 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// You must also convert a numeric varible to a string before passing it to
/// the MessageBox.Show method. The following example shows how an int
/// variable's value can be converted to a string and displayed in a message box:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// int myNumber = 123;
/// MessageBox.Show(myNumber.ToString());
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The first statement declares an int variable named myNumber, initalized
/// with the value 123. In the second statement the following takes place: 
/// //////////////////////////////////////////////////////////////////////////
/// * The myNumber variable's ToString method is called. The method returns
/// the string "123".
/// 
/// * The string "123" is passed to the MessageBox.Show method. As a result,
/// the values 123 is displayed in a message box:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// int myNumber = 123;
/// MessageBox.Show(myNumber.ToString());
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The first statement declares an int variable named myNumber, initialized
/// with the value 123. In the secind statement the following takes place:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
///     * The myNUmber variable's ToString method is called.
///       The method returns the string "123".
///       
///     * The string "123" is passed to the MessageBox.Show method. As a result, the value 123 is displaed in a message box.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Implicaite String Convertion with the + OPerator
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// IN this ch, you've learned that the + operator has two uses: string
/// concatenation and numeric addition. IF you write an expression using the
/// + operator and both operands are string, the + operator concatenates the
/// string. IF both operands are numbers of compativle types, then the +
/// operator adds the two numbers. But what happends if one operand is a
/// string and the other operand is a number? The number will be implicitly
/// converted to a string, and both operands will be concatenated. Here's an 
/// example.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// int idNumber = 1044;
/// string output = "Your ID number is " + idNumber;
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
//// In the second statement, the string var output is init with string " Your
/// ID Numer is 1044". Here is another example:
///
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// double testScore = 88.5;
/// MessageBox.Show ("Your test score is " + testScore);
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The second statement displays a message box showing the string "Your test
/// score is 88.5".
/// 
/// In Tutorial 3.2, you will use some of the techniques discissed in this
/// secion. You will create an application that reads numeric input form
/// TextBox controls, and displays numeric output in a Label control.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Tutorial 3-2: Calculating Fuel Economy
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// In the United States, a car's fuel economy is measured in miles per 
/// gallon, or MPG. You use the following fprmula formula to calculate a 
/// car's MPG:
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// MPG = Miles driven / Gallons of gas used
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// In this tutorial, you will create an application that lets the user
/// enter the number of miles he or she has drive and the gallons of gas used.
/// The application will calculate and display the car's MPG.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-17 shows the applcation's form, with the names of all the
/// controls.
/// 
/// When the application runs, the user enter the number of miles
/// driven into the milesTextBox control and the gallons of gas used the
/// gallonsTextBox control. 
/// 
/// When the user clicks the calculateButton control,
/// the application calculates the car's MPG and displays the result in the
/// mpgLabel control.
/// 
/// The exitButton control closes the spplication's form.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio and begin a new Windows Form Application
///         project named Fuel Economy.
///         
/// Step 2: Set up the application's form as shown in Figure 3-17.
///         Notice that the forms's Text property is set to Fuel Economy. 
///         The names of the controls are shown in the figure. 
///         As you place each the controls on the form, refer to Table 3.8
///         for the relevant property settings.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
///  Table 3.8 Control property settings
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
///     Step 3: Once you have set up the form with its controls, you can 
///     create the click event handlers for the button At the end of this
///     tutorial, Program 3.2 shows the completed code for the form. You will
///     be instructed to refer to program 3.2 as you write the event handlers.
///     (Remember, the line numbers that are shown in Program 3.2 are not part
///     of the program. They are shown for feference only.)
///     
///     In the Designer, double-click the calculateButton control. This
///     opens the code editor, and you will see an empty event handler named
///     calculateButton_Click. Complete the calculateButton_Click event 
///     handler by typing the code shown in lines 22-38 in Program 2.3.
///     
///     Let's take a closer look at the code:
///         
///         Line 22: THis statement declares a double variable named miles.
///         This variable ios used to hold the number of miles driven.
///         
///         Line 23: This statement declates a double var named gallons. This
///         var is usead to hol;d the number of gallons used.
///         
///         Line 24: This statement declates a double var named mpg. This var 
///         is used to hold MPG, which will be calculated.
///         
///         Line 28: This statement convertys the milesTextBox control's Text property to a double and assigns the result to the miles var.
///         
///         Line 32: This statement convers the gallonsTextBox control's Text property to a double and assigns the result to the gallons variable.
///         
///         Line 35: THis statement calculates MPG. it divides the miles var by the gallons var and assigns the result to the mpg var.
///         
///         Line 38: this statement converts the mpg var to a string and assigns the reult to the mpgLabel
///                  control's Text property. This couses the value of the mpg variable to be displayed 
///                  in the mpgLabel control.
///         
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 4 : Switch your view back to the Designer and double-click the 
///          exitButton control. IN the code editor you will see an empty 
///          event handler named exitButton_Click. Complete the 
///          exitButton_Click event handler by typing the code whoen in 
///          lines 43-44 in Program 3.2.
///          
/// Step 5: Save the project. Then, press the F5 key on the keyboard or click the
/// Start Debugging button (|>) on the toolbar to compiler and run the application.
/// Test the application by entering values into the TextBoxes and clicking
/// the Calculate MPG button. The MPG should be displayed, similar to
/// Figure 3-18. Click the Exit button and the form should close.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-18 The Fuel Economy application
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 3.6 Formatting Numbers with the ToString Method
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
///     Concept
///     The ToString method can optionally format a number to appear
///                 in a spacific way.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When you display large numbers, you usually want to format them with 
/// commas so they are easy to read. For ex, 487,634,789.0 is easier to 
/// read than 487634789.0. Also, when you display amounts of money, 
/// usully want to round them to two decimal places and display a currency 
/// symbol, such as a dollar sign($). 
///
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When you call the ToString method, you can optionally pass a formatting
/// string as an argument to the method. The formatting string indicates
/// that you want the number to appear formatted in a specific way when 
/// it is returned as a string from the method. 
/// 
/// For example, when you pass the formatting string "c" to the ToString
/// method, the number is returned formatted as currency.
/// 
/// Assuming that you are in the UNited States, numbers formatted as currency
/// are preceded by a dollar sign($), are rounded to two decimal places
/// and have comma separators as neccessary.
/// 
/// The following code sameple demonstrates:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// decimal amount = 123456789.4568m;
/// MEssageBox.Show(amount.ToString("c"));
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Notice in the decond statement that the "c" formatting string is passed to the amount variable's ToString method. The maeesage box that the statement display appears as shown in Figure 3-19.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-19 A number formatted as currency
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// There are several other format strings that you can use with the ToString
/// method, and each produces a different type of formatting. Table 3.9 shows a few of them.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Table 3.9 A few of the formatting strings
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Number Format
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Number format ("n" or "N") displays numeric values with comma separators and
/// a decimal point. By default, two digits display to the right of the decimal point. Negative values are displayed with a leading minus sign. As example is -2,345.67.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Fixed-Point Format
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Fixed-point format ("f" or "F") displays numeric values with no thousands
/// separator and a decimal point. By default, two digits display to the right
/// of the decimal point. Negative values are displayed wth a leading minus
/// (-) sign. An example is -2345.67.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Exponential Format
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Exponential format ("e" or "E") displays numeric values in scientific 
/// notation. The number is displayed with a single digit to the left of the 
/// decimal point. The letter e appears in for of the exponent, and the
/// exponent has a leading + or - sign. By defailt, six digits display t
/// o the right of the decimal point, and a leading minus sign is used
/// if the number is negative.
/// 
/// An example is -2.345670e+003.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Currency Format
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Currency format ("c" or "C") displays a leading currency symbol 
/// (such as $), digits, comma separators, and a decimal point. By default, 
/// two digits display to the right of the decimal point. Negative values 
/// are surrounded by parentheses. An example of a negative value is
/// ($2,345.67).
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Using Percent Format
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Percent format ("p" or "P") causes the number to be multiplied by 100 
/// and displayed with a trailing space and % sign. By default, two digits
/// display to the right of the decimal point. Negative values are displayed
/// with a leading minus sign. For example, the number 0.125 would be 
/// formatted as 12.5 % and the number -0.2345 would be formatted as -23.45 %.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Specifying the Percision
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Each numeric format string can optionally be followed by an integer that
/// indicates how many digits to display after the decimal point.
/// 
/// Table 3.10 shows a variety of numeric formatting examples, 
/// based on the North American locale.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Table 3.10 Numeric formatting examples (North American locale)
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Rounding
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Rounding can occur when the number of digits you have sepcified after
/// the decimal point in the format string is smaller than the precision
/// of the numeric value. Suppose, for example, that the value 1.235 were
/// displayed with a format string of "n2". Then the displayed value would 
/// ne 1.24. IF the next digit after the last displayed digit is 5 higher,
/// the last displayed digit is rounded away from zero. Table 3.11 shows 
/// examples of rounding using a format string of "n2".
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Table 3.11 Rounding examples using the "n2" display format string
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// USing Leding Zreos with Integer Values
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// You can use the "d" or "D" formatting strings with integers to specify the
/// minimus width for displaying the number. Leading zeros are inserted if
/// neccessary. Table 3.12 shows examples.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Table 3.12 Formatting integers using the "d" or "D" formatting strings
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// In Tutorial 3.3, you will create an application that uses currency
/// formatting to display a doller amount.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Tutorial 3-3: Creating the Sale Price Calculator Application with
///                 Currency Formatting
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// IF you are writing a program that works with a percentage, you have to 
/// make sure that the percentage's decimal point is in the currect location
/// before doing any math with the percentage. This is especially true when 
/// the user enters a percentage as input. Miost users will enter the number 
/// 50 to mean 50 percent, 20 to mean 20 percent, and so forth. Before you 
/// preform any calculations with such a percentage, you have to divide it
/// by 100 to move its decimal point to the left two places.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Suppose a retail business is planning to have a storewide sale in 
/// which the prices of all items will be reduced by a specified percentage.
/// 
/// In the tutorial, you will create an application to calculate the sale 
/// price of an item after the disciund is subtracted. 
/// 
/// Here is the algorithm, expressed as pseudocode:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 1. Get the original price of the item.
/// 2. Get the discount percentage. (for example, 20 is entered for 20 percent.)
/// 3. Divide the percentage amount by 100 to move the decimal point to the corrcect location.
/// 4. Multiply the percentage bu the original price. This is the amount of the discount.
/// 5. Subtract the discount form the original price. This is the sale price.
/// 6. Display the sale price.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-20 shows the application's form, with the names of all the controls. 
/// When the application runs, the user enters an item's orinal price into
/// the originalPriceTextBox control and the discount pertage into the 
/// discountPercentageTextBox control. 
/// 
/// When the user clicks the calculateButton control, the application 
/// calculates the item's sale price and displays the result in the 
/// salePriceLAbel control.
/// 
/// The exitButton control closes the application's form.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-20 The Sale Price Calculator form
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio and begin a new Windows Forms Application project named Sale Price Calculator.
/// 
/// Step 2: Set up the application's form, as shown in Figure 3-20. notice 
/// that the form's Text property is set to Sale Price Calculator. The
/// names of the controls are shown in the figure. As you place each of
/// the controls on the form, refer to Table 3.13 for there relevant
/// property settings 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Table 3.13 Control property settings
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 3: Once you have set up the form with its controls, you can create 
/// the Click event handlers for the Button controls. AT the end of this
/// tutorial, Program 3.2 shows the completed code for the form. You will 
/// instructed to refer to Program 3.2 are not part of the program they 
/// are shown for reference only.)
/// 
/// In the Designer, double-click the calculateButton control. This will
/// open the code edito, and you will see an empty event handler named 
/// calculateButton_Click. Complete the calculateButton_Click event handler
/// by typing the code shown in line 22-43 in Program 3.3
/// 
/// Let's take a closer loopk at the code.
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Line: 22 This statement declares a decimal variable named orinalPrice. This var will hold the item's price.
/// 
/// Line:23 This statement declares a decimal var named discountedPercentage. this var will hold the discount percentage.
/// 
/// Line:24 This statement declares a decimal var named discountAmount. THis var will hold the amount of discount that will be taken from the item's original price. This amount will be calculated.
/// 
/// Line:25 This statement declars a decimal var named salePrice. This var will hold the item's sale price. This amount will be calculated.
/// 
/// Line:28 This statement converts the originalPriceTextBox control's Text
///     property to a decimal and assigns the result to the originalPrice var
/// 
/// Line:31 This statement converts the discountPercentageTextBox control's 
///     Text property to a decimal and assigns the result to the 
///     discountPercentage var. 
/// 
/// Line:34 This statement converts the discountPercentageTextBox by 100 
///     and stores the result back in discountPercentage. This moves the 
/// decimal point in the discountPercentage variable to the left two places.
/// 
/// Line:37 This statement calculates the item's sale price. IT subtracts 
///     the discountAmount var from the originalPrice var and assigns the 
///         result to the salePrice var.
/// 
/// Line:40 This statement calculates the item's sale price. 
///     It subtacts the discountAmount variable from the originalPrice var
///     and assigns the result to the salePrice var.
/// 
/// Line:43 This statement displays the item's sale price as a currency
///     amount. 
///     It converts the salePrice var to a string and assigns the 
///     result to the salePRiceLAbel control's Text property. 
///     
/// Notice that the format string "c" is passed to the salePrice 
///     var's ToString method.
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 4: Switch your view bacl to the Designer and double-click the 
/// exitButton control. In the code editor you will see an empty event
/// handler named exitButton_Click. Compleate the exsitButton_Click event 
/// handler by typing the code shown in lines 48-49 in PRogram 3.3.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 5: Same the project. Then, press the F5 key on the keyboard or click
/// the Starting Debigging button (|>) on the toolbar to compiler and run the
/// application. Test the application by entering values into the TextBpx and
/// clicking the Calculate Sale Price button. The sale price is displayed, 
/// similar to Figure 3-21. Click the exit button and the form closes.    
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////////////
///                     3.7 Simple Exception Handling 
/// //////////////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Concept An exception is an unexpected error that happens while a program 
/// is running. IF an exceprion is not handled by the program, 
/// the program will abruptly halt.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// An exception is an unexpected error that occurs while a program is
/// running, causing the program to halt if the error is not properly 
/// dealt with. 
/// 
/// Exceptions are usually caused by circumstances that are beyond
/// the programmer's control. 
/// 
/// For example, suppose the user has entered a 
/// value into a TextBox, and that value is expected to be a number.
/// 
/// The program uses one of the Parse methods to convert the control's 
/// TExt property to a numeric data type, but the string contains invalid 
/// characters and it cannot be converted. The PArse method cannot continue,
/// so an exception occurs. (TO use the proper terminology, we say that a 
/// method throws an exception when an unexpected error occurs and it 
/// cannot continue operating.)
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Let's look at an example.
/// 
/// IF you have completed the Fuel Exonomy project from Tutorial 3.2, open
/// it in Visual Studio and then either click the Start Debugging button
/// (|>) or press F5 to run the application. 
/// 
/// ON theapplication's form, enter 3-- for the number of miles driven and then 
/// enter a nonnumeric sequence of characters for the gallons of gas used. 
/// 
/// Figure 3-22 shows an example where the user has entered wxyz, Then,
/// 
/// click the Calculate MPG button. 
/// 
/// BEcause the invalid string that you entered for the gallons of gas
/// cannot be converted to a double, an exceotion is thrown. 
/// 
/// The application stops running and Visual Studio 
/// goes into a special mode know as break mode. 
/// 
/// The window shown in Figure 3-23 is displayed, and the line of code
/// 
/// that was executing when the exception was thrown is highlighted. 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-22 Invalid data entered for gallons
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-23 Exceprion reported
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////                                                                                                                                                                                                                                                             _
/// THe exception window that is showin Figure 3-23 displays a lot of 
/// information, but if you look at the line just below the window's
/// title bar, you see the message Inout string was not in a correct
/// format.
/// 
/// That is a description of what happened to cause the
/// exception. To get out of break mode, click the Stop Debugging
/// button ([_]), or press Shift + F5. 
/// 
/// Visual Studio then returns to its normal mode. 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Handleing Exveotions
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// C#, like most modern programming languages, allows you to write code 
/// that responds to exceptions when they are thrown and prevents the prgram
/// from abruptly crashing. 
/// 
/// Such code is called an exceotion handler, and is written with the 
/// try-catch statement. 
/// 
/// There are several ways to write a try-catch statement, but the
/// following general format is the simplest variation:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
///  try
///  {
///     statement;
///     statement;
///     etc.
///  }
///  catch
///  {
///     statement;
///     statement;
///     etc.
///  }
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// First the keyword try appears, followed by a group of one or more
/// statements that appears inside a set of braces. 
/// 
/// This group of statements is known as a try block.
/// 
/// One or more of the statements inside the try block can porentially 
/// throw an exception.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// After the try block, a catch clause appears.
/// 
/// The catch clause is followed by a group of one or more statements
/// enclosed inside a set of braces. 
/// 
/// This group of statements is known as a catch block.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When a try-catch statement executes, the statements in the try block
/// are executed in the order that they appear.
/// 
/// if a statement in the try black throws an exception, the program 
/// immeditely jumps to the catch calues and executes the statements
/// in the catch block.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When a try-catch statementexcutres, the statements in the try block are
/// executed in the order that they appear. 
/// 
/// If a statement in the try block throws an exception, the program
/// immediately jumps to the catch clause and executes the statements
/// in the catch block. 
/// 
/// If all the statements in the try block execute with no exception, 
/// the catch block is skipped. 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Let's see how a try-catch statement can be used in the Fuel Economy 
/// application. Here is a modified version of the application's 
/// calculateButton_CLick event handler:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// private void calculateButton_Click(object sender, EventArgs e)
/// {
///     try
///     {
///         double miles;   // To hold miles driven
///         double gallons; // To hold gallons used
///         double mpg;     // To hold MPG
///         
/// 
///         // Get the miles driven and assign it to
///         // the miles variable.
///         miles = double.Parse(milesTextBox.Text);
///         
///         // Get the gallons used and assign it to
///         // the gallons variable.
///         gallons = double.PArse(gallonsTextBox.Text);
///         
///         // Calculate MPG.
///         mpg = miles / gallons;
///         
///         // Display the MPG in the mpgLabel control.
///         mpgLabel.Text = mpg.ToString();
///        
/// }
///         catch
///         {
///             //  Display an the error message.
///              MessageBox.Show("Invalid data was entered.");
///         }
///     }
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When you write a try-catch statement, you put all the code that might
/// throw an exception inside the try block. In this version of the event
/// handler, try block appears in lines 5-21. (In this example, we have 
/// put all the statements that previously appeared in the event handler
/// inside the try block.) If any statement inside the try block throws 
/// an exception, the program will immeditely jump to the catch clause in Line 
/// 23. Then , the statements in the catch block (lines 25-26) will execute.
/// 
/// Le's say that the application is running and the user enters invalid
/// input into the milesTextBox control. 
/// 
/// When the event handlers executes, the statement in line 11 throws
/// an excetion because the double.Parse method is not able to convert 
/// the control's Text property to a double.
/// 
/// 
/// The proghram will immediately jump to the catch clasuse in line 23 and 
/// then execute the statements inside the catch block. 
/// 
/// Line 26 displays a message box with an error message.
/// 
/// Figure 3-24 illustrates this process. 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 3-24 Handling an exception
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// On the other hand, if all the statements indide the try block execute and
/// no exceptions are thrown, the catch block will be skipped.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Displaying an Exception's Default Error Message
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// When an exception is thrown, and object known as an exception object is 
/// created in memory/ The exception object has various properties that contain
/// data about the exception.
/// 
/// When you write a catch clause, you can optionally assign a name to 
/// the exception object, as shown here:
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
///          catch (Exception ex)
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The expression that appears inside the parentheses specifies that we are
/// assigning the name ex for the exceorion object.
/// 
/// (There is nothing special
/// about the name ex.
/// 
/// That is simply the name that we've chosen for
/// the examples.
/// 
/// You can ise any name that you wish.)
/// 
/// Inside the catch 
/// block, we can use the name ex to access the exception object's properties.
/// 
/// 
/// One of these is the Message property, which contrins the exception's
/// default error message.
/// 
/// The following code shows how thios can be done.
/// This another modification of the Fuel Economy project's
/// calculateButton_Click event handler.
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// private void calculateButton_Click(object sender, EventArgs e)
/// {
///     try
///         { // miles driven   gallons used  mpg
///            double miles,     gallons,   mpg;            
///         // Get the miles driven and assign it to
///          //  The miles variable.
///         miles = double.Parse(milesTextBox.Text);
///       // Get the gallons isaed and assign it to
///        //  the gallons var.
///          miles = double.Parse(milesTextBox.Text);
///         // Calculate MPG.
///         mpg = miles / gallons;
///        // Display the MPG int the mpgLabel control.
///         mpgLAbel.Text = mpg.ToString();      
///        }
///        catch (Exception ex)
///        {
///             // Display the default error message.
///             MessageBox.Show(ex.MEssage);
///         }
///  }
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// The statement in line 26 simply passes the exception object's 
/// Message property to the MEssageBox.Show method. This causes the 
/// default error message to be displayed in a message box.
/// 
/// Figure 3-25 shows an example of the message that is displayed as
/// a result of the user entering invalid input for either the
/// milesTextBox or the gallonsTextBox or the gallonsTextBox, controls.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-25 A message box showing an exception's default error message
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In Tutorial 3.4, you create an application that uses a try-catach
/// statement to handle exceptions that are thrown when the user
/// enter invalid data into a TextBox control.
/// /////////////////////////////////////////////////////////////////////            
/// 
/// /////////////////////////////////////////////////////////////////////
/// Tutorial 3-4: Creating the Test Average
///                Application with Exception Handling
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Determing the average of a group of values is a simple calculation:
/// You all the vales and then divide the sum by the number of values. 
/// 
/// Although this is a strightforward calculation, it is easy to make
/// a mistake when writing a program that calculates an average.
/// For example, let's assume that the variables a,b, and c each hold
/// a value and we want to calculate the average of those values. 
/// 
/// If we are careless, we might write a statement such as the 
/// following to preform the calculation:
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// average = a + b + c / 3.0;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Can you see the error in this statement?   When it executes, the
/// division will take place first. The value in c will de divided by
/// 3, and then the result will be added to a + b.
/// 
/// That is not the correct way to calculate an average.
/// 
/// To correct this error we need to put parentheses around a + b + c, 
/// as shown here:
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// average = (a + b + c) / 3.0;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In this tutorial, you will create an 
/// application that calculates the average of three test scores.
/// 
/// Figure 3-26 shows the application's form, with the names
/// of all the controls.
/// 
/// When the application runs, the user will enter the test scores into
/// the TextBox controls.
/// 
/// When the user clicks the calculateButton control, the application
/// will calculate the average test score and display the result in
/// the averageLabel control.
/// 
/// The clearButton control will clear the contents of the TextBoxes and
/// averageLabel control.
/// 
/// The exitButton control closes the application's form.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-26 The Test Average form
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio and begin a new Windows Forms Application
/// project named Test Average.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 2:Set up the application's fprm as shpwn ion Figure 3-26. Notice that the form's Text property is set to Test Average. The names of  the controls are shown in the figure. As you place each of the controls on the form, refer to Table 3.14 for the relevan property settings.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 3:Once you have set up the form with its controls, you can 
/// create the CLick event handler for the Button controls. 
/// 
/// At the end of this tutorial, Program 3.4 showsa the completed 
/// code for the form. You will be instructed to refer to Program 3.4 as
/// you write the eveny handlers. 
/// 
/// (Remember, the line numbers that are shown in Program 3.4 are not 
/// part of the program. They are shown for reference only)
/// 
/// In the Designer, double-click the calculateButton control.
/// 
/// This will open the code editor, and you will see an empty event
/// handler named calculateButton_Click.
/// 
/// Complete the calculateButton_Click event handler by typing the code
/// shown in lines 22-45 in Program 3.4.
/// 
/// Let's take a closer look at the code:
/// 
///     Line 22: This is the beginning of a try-catch statement.
///             The try block appears in lines 24-39, 
///             and the catch block appears in lines 43-44.
///             
///     Line 24-27: These statments declare the following double
///     variables: test1, test2, test3, and average.
///     
///         The variables will hold the three test scores
///             and average test score.
///     Line 30: This statement coverts the test1TestBox control's Test 
///     property to a double and assigns the result to the test1 variable.
///     
///     Line 31: This statement converts the test2TextBox control's Text
///     property to a double and assigns the result to the test2 var.
///     
///     Line 32: This statement calculates the average of the test1,
///     test2, and test3 variables and assigns the result to the 
///     test3 variable.
/// 
///     Line 35: This statement calculates the average of the
///             test1, test2, and test3 variables and
///             assigns the result to the average variable.
///             
///     Line 39: This statement converts the average variable to a string
///     and assigns the result to the averageLabel control's Test
///     property. 
///     
/// Notice that the "n1" format string is passed as an argument to the
/// ToString method. 
/// 
/// This causes the number to be rounded to one decimal point.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 4: Switch your view back to the Designer and double-click the 
/// clearButton control. In the code editor you will see an empty event
/// handler named clearButton_Click.
/// 
/// Complete the clearButton_Click event handler by typing the code shown
/// in lines 50-54 in Program 3.4.
/// 
/// Lines 51-53: Each of these statements assigns an empty strign ("")
/// to the Text property of one of the TextBox controls. When these
/// statements have finisahed executing, the TextBox controls appear empty.
/// 
/// Line 54: This statment assigns an empty string ("") to the 
/// averageLabel control's Text property. After the statement
/// as executed, the label appears empty.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 5: Switch your view back to the Designer and double-click the
/// exitButton control.
/// 
/// IN the code editor you will see an empty event handler named 
/// exitButton_Click.
/// 
/// Complete the exitButton_Click event handler by typing the code
/// shown in lines 59-60 in Program 3.4.
/// /////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////
/// Step 6: Save the project. Then, press the  f5 key on the keyboard
/// or click the Start Debugging button(|>) on the toolbar to
/// compiler and run the applicaition First, test the application 
/// by enteriing valid numeric values into the TextBoxes and clicking
/// the Calculate Average button. A test average should be displayed,
/// similar to the image shown on the left in Figure 3-27.
/// ////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-27 The Text Average application
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Next, click the clear button to clear the TExtBoxes and the average.
/// 
/// Then enter a nonnumeric value for test 1, and click the Calculate 
/// Average button. An exception will be thrown, and you should see the 
/// message box shown in the image on the right in Figure 3-27.
/// 
/// Continue to test the application as you wish. When you are finished, 
/// click the button and the form should close.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Program 3-4 Completed Form1 code for the Test Average applicaion
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
///                         3.8 Using Named Constants
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
///       Concept: A named constant is a name that represents a value that
///       cannot be changed during program's execution.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Assume that the following statement appears in a banking program
/// that calculates data pertaining to loans:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// amount = balance * 0.069;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In such a program, two potential problems arise. First, it is not
/// clear to anyone other than the original programmer what 0.069 is.
/// 
/// It appears to be an intrest rate, but in some situations, there 
/// are fees associated with loan payments. How can the purpose of this
/// statement be determined without painstakingly checking the rest of
/// the program?
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The second problem occurs if this number is used in other
/// calculations throughout the program and must be changed periodically.
/// 
/// Assuming the number is an interest rate, what if the rate changes from
/// 6.9 percent to 7.2 percent? The programmier would have to search through
/// the source code for every occurrence of the number.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Both these problems can be addressed by using named constants. 
/// 
/// A named constant is a name that represents a value that cannot be changed
/// during the program's execution. The following is an example of how you can
/// declare a named constant in C#:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// const double INTEREST_RATE = 0.129;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// This statement declares a named constant named INTEREST_RATE
/// initialized with the value 0.129. 
/// 
/// It looks like a regular variable
/// declaration, except that the word const appears before the data type name
/// and the name of the var is written in uppercase characters. 
/// 
/// The key word const is a qualifier that tells the compiler to make the
/// variable read only. If a statement attempts to change the constant's
/// value, an error will occur when the program is being compiled.
/// 
/// When you declare a named constant, an initialization value is 
/// required.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// It is not required that the constant name be written in uppercase
/// letters, but many programmers prefer to write them this way so they
/// are easily distinguishable from regular variable names.
/// 
/// When you are reading a program's code and you see an uppercase
/// identifier, you know instantly that it is a constant.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note Writting the names of constants in uppercase letters is
/// traditional in many programming languages, and that practice is 
/// followed in this book. Within the C# community, some programmers adhere
/// to this practice and some do not. In the classroom, you should use the 
/// naming convention that your instructor prefers.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// An advantage of using named constants is that they make programs more
/// self-explanatory. The statement
/// 
/// //////////////////////////////////////////////////////////////////
/// amount = balance * 0.069;
/// ////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// can be changed to read
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// amount = balance * INTEREST_RATE;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// A new programmer can read the second statement 
/// and know what is happening. It is evident that balance is being
/// multiplied by the instrest rate.
/// 
/// Another advantage to this approach is that widespread changes can 
/// easily be made to the program. Let's way the interest rate appears
/// in a dozen different statements throughout the program. 
/// 
/// When the rate changes, the initialization value in the declaration 
/// of the named constant is the only value that needs to be modified.
/// 
/// If the rate increases to 7.2 percent, the declaration can be 
/// changed to the following:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// const double INTEREST_RATE = 0.072;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The new value of 0.072 will then be used in each statement that uses
/// the INTEREST_RATE constant. In Tutorial 3.5, you will create an 
/// application that uses maned constatnts.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
///                 3.9 Declaring Variables as Fields
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// Concept: A field is a variable that is declared at the class level.
///        A field's scope is the entire class.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// So far in this chapter, all the variables with which we have worked have
/// been local variables.
/// 
/// A local variable is declared inside a method and is visible only to
/// statements in that method. Another type of variable is a field, which
/// is a variable that is declared inside a class but not inside
/// of any method. A field's scope is the entire class, so when you
/// declare a field, all the methods in the class can access the variable.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Typically, field are declared at the top of a class declaration,
/// before any methods. Figure 3-28 shows where you would write field 
/// declarations inside a form class. When you are about to write a field
/// declaration, you can insert some blank lines after the class's opening
/// brace({) and write the field declararion in that space.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-28 Where to insert field declarations
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Let's look at an example of a field declaration.
/// 
/// Assume that the following statement appears inside a class
/// declaration but not inside any methods.
/// 
/// This statement declares an int field named number,
/// initialized with the value 0:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// private int number = 0;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Field declarations are written like any other variable declarartion,
/// except that an access modifier usually appears before the data type.
/// 
/// In this ex, the keyword private is the sccess modifier. 
/// 
/// An access modifier specifies how a class member can be accessed
/// by code outside the class. 
/// 
/// When you use the private access modifier in a field declaration,
/// the field cannot be accessed by code outside the class.
/// 
/// It can be accessed only by the methods that are inside the class.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// It is a  good programming practice to make field private because
/// private field are hidden from code outside the class.
/// 
/// That prevents code outside the class from changing the values of a 
/// class's field and helps prevent bugs from creeping into your programs.
/// 
/// You will learn more about this in Chapter 10. Until then, if you 
/// declare fields in a class, you should get in the habit of making
/// them private.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In the previous field-declaration example, the number field is
/// initialized with the value 0. If a field is a variable of a numeric
/// data tyoe (such as int, double, or decimal), it will be initialized
/// to 0 by default if you do not explicitly initialize it with a value.
/// 
/// It is always a good idea to explicitly initialized a field, however,
/// event if you want it to begin with value 0. This clearly indicates
/// the field's starting value for anyone reading code.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Warning! : If you do not initialize a string field, it begins with
/// a special value know as null. An error will occur if you attenmpt
/// to use a string that is set to null.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note: You cannot use the var keyword to delcare a field.
/// The var keyword can be used only to declare local variables. 
/// /////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////
/// In a form, fields are useful for storing pieces of data that must
/// be shared amoung the form's event handlers.
/// 
/// For examnple, in the Chap03 folder of this book's student sameple
/// programs, you will find a project named FieldDemo.
/// 
/// Figure 3-29 shows the application's form, along with the names
/// of the Button controls.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-29 The Field Demo form
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Program 3.5 shows the Form1 code.
/// 
/// Notice that in line 16 a string variable named name is declared as
/// a field and initialized with the value "Charles".
/// 
/// Next, look at the button event handlers:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// * IN the showNameButton_Click event handler, line 25 displays a message box showing the value of the name variable.
/// 
/// * In the chrisButton_click event handler, line 30 changes the value of the name variable to "Chris"
/// 
/// * In the carmenButton_Click event handler, line 35 changes the value of the name variable to "Carmen". 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// As you can see, all of the event handlers in the Form1 class have
/// access to the names variable. IF you run the application and click
/// the Show Name button, a message box will appear displaying Charles,
/// which is the name field's initial value.
/// 
/// IF you click the Change Name to Chris button and then click the Show
/// Name button, a message box will appear displaying Chris If you click
/// the Change Name to Carmen button and then click the Show Name button,
/// a message box will appear displaying Crmen.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Program 3-5 Form1 code for the Files Demo application
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The Lifetime of a Field in a Form Class
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// When you declare afield in a form class, the field's lifetime is the
/// time during which the form exists.
/// 
/// This means that the field will exist in memory as long as the form
/// exists. 
/// 
/// This is different than the lifetime of a local variable, which exists
/// onmy while the method in which it is declared in executing. 
/// 
/// Local variables come and go in memory, but a form's fields exist as
/// long as the form exist.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// You can see this in the Field Demo application. The name field is 
/// created in memory when the Form1 form is created, and it continues
/// to exist as long as Form1 exists.
/// When one of the event handlers stores a values in the field, that 
/// values remains in the field until it is changed again, perhaps by
/// a different event handler. 
/// 
/// So, fields give you a way of storing 
/// values that must not disappear when a partucular method ends.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                        Precautions
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// ALthough fields make it wasy to share data amoung the methods in a
/// class, you should be careful about using them.
/// 
/// The overuse of fields can make debugging a class's code diffucult,
/// especially of the class has many methods.
/// 
/// IF an incorrect valye is being stored in a field, you will have
/// to track down every statement in the class that accesses the field
/// to determine where the incorrect value is coming from.
/// 
/// In most cases, fields should be used only for data that must be
/// shared among multiple methods and must continue to exist in memory
/// when the methods are not executing.
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Constant Fields
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// A constant field is a field that cannot be changed by any statement
/// 
/// in the class. An error will occur if the compiler finds a statement
/// that tries to change the value of a constant field.
/// 
/// A constant field is deckared with the const keyword and initialized 
/// with a value Here is an example:
/// /////////////////////////////////////////////////////////////////////
 ///
 /// //////////////////////////////////////////////////////////////////
/// private const decimal INTEREST_RATE = 0.075m;
/// ////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// This statement declares a constant decimal field named INTEREST_RATE,
/// initialized with the value 0.075. Constant fields are typically used
/// to represent unchanging values that are needed by many of a class's
/// methods.
/// 
/// For example, suppose a banking poogram uses a constant field to
/// represent an interest rate.
/// 
/// IF the instrest rate is used in several methods, it is easier to
/// create a constant field, rather than a local named
/// constant in each method. 
/// 
/// This also simplifies maintenance of the code. 
/// 
/// IF the interest rate changes, only the declaration of the constant
/// field has to be changed, instead of several local declarations.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note: Because a constant field's value cannot be changed by other
/// statements in the class, you do not have to worry about many of the
/// potential debugging problems that are associated with the overuse of 
/// regular, nonconstant fields.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// IN Tutorial 3.5, you will create an application that uses a field 
/// in a form class to hold data, well as constant fields to
/// represent nonchanging values.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Tutorial 3-5: Creating the Change Counter Application
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In this tutorial, you will create the Change Counter application.
/// 
/// The application displays image of four coins, having the values 5
/// center, 10 cents, and 50 cents.
/// 
/// Each time the user clicks on a conin image, the value of that coin is 
/// assed to a total, and the total is displayed. Figure 3-30 shows the 
/// application's form, with the names of all the controls.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-30 The Change Counter form
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Tutorial 3.5
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio and begin a new Windows Forms Application
///         project named Sale Price Calculator.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 2: Set up the application's form as shown in Figure 3-30.
/// 
/// Notice that the form's Text property is set to Change Counter.
/// 
/// The names of the controls are shown in the figure.
/// 
/// As you place each of the controls on the form, refer to Table 3.15 
/// for the relevant property settings.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///     Table 3.15 Control property settings
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 3: Once you set the form with its controls, you can begin
/// writting code.
/// 
/// At the end of this tutorial, Program 3.6 shows the completed code
/// for the form. 
/// 
/// You will be instructed to refer to Prgram 3.6 as you write the 
/// form's code.
/// 
/// (Remember, the line number that are shown in Program 3.6 are not
/// part of the program. They are shown for reference only)
/// 
/// 
/// First, you write the declarations for the fields. Switch your view to
/// the code editor (right-click Form1.cs in the Solution Explorer and 
/// select View Conde from the pop-up menu).
/// 
/// Write the declarations shown in lines 16-23 in Program 3.6.
/// 
/// Let's take a closer look at the code: 
/// 
/// Line 16: This statement declares a constant decimal field named
/// FIVE_CENTS_VALUE, initialized with the value 0.05.
/// This constant represents the value of the 5-cent coin.
/// 
/// Line 17: This statement declares a constant decimal field named
/// TEN_CENTS_VALUE, initialized with the values 0.10.
/// This constant represents the value of the 10-cent coin.
/// 
/// Line 18: This statement declares a constant decimal field named
/// TWENTY_FIVE_CENTS_VALUE, inirialized with the value 0.25. 
/// This constant represents the value of the 25-cent coin.
/// 
/// Line 19: This statement declares a constant decimal field named
/// FIFTY_CENTS_VALUE, initialized with the value 0.50.
/// This constant represents the value of the 50-cent coin.
/// 
/// Line 23: This statement declares a decimal field named total,
/// initialized with the value 0. This field is used to keep the 
/// total value of the coints that the user clicks.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 4: Now, you can create the Click event handlers for the 
/// PictureBox controls.
/// 
/// Switch your view back to the Designer and double-click the
/// fiveCEntsPictureBox control.
/// 
/// This opens the code editor, and you will see an empty event handler 
/// named fiveCentsPictureBox_Click. 
/// 
/// Complete the fiveCentsPictureBox event handler by typing the code
/// shown in lines 32-36 in Program 3.6.
/// 
/// Let's take a closer look at the code:
/// 
/// Line 33: This statement adds the value of the FIVE_CENTS_VALUE 
/// constant to the total field.
/// 
/// Line 36: This statement converts the total variables to a string
/// and assigns the resukt to the totalLabel control's Text property.
/// The "c" format string causes the number to be formatted as currency.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 5: Switch your view back to the Designer and double-click the 
/// tenCentsPictureBOx control. 
/// 
/// This opens the code editor, and you will
/// see an empty event handler named tenCentsPictureBox_Click.
/// 
/// Complete the tenCentsPictureBox_Click event handler by typing the 
/// code shown in lines 41-45 in Program 3.6. Let's take a closer look
/// at the code:
/// 
/// Line 42: This statement adds the value of the TEN_CENTS_VALUE
/// constant to the total field.
/// 
/// Line 45: This statement converts the total variable to a string
/// and assigns the result to the toalLabel control's Text property.
/// 
/// The "c" format string causes the number to be formatted as currency.
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 6: Switch your view back to the Designer and double-click the 
///    twentyFiveCentsPictureBOx control. Opens the code editor, and you
///    will see an empty event handler named 
///    twentyFiveCentsPictureBox_Click. 
///    
/// Complete the twentyFiveCEntsPictureBox_CLick event handler by typing
/// the code shown in lines 50-54 in Prgram 3.6.
/// 
/// Let's take a closer look at the code:
/// 
/// Line 51: This statement adds the value of the TWENTY_FIVE_CENTS_VALUE
/// constant to the total field.
/// 
/// Line 54: This statement converts the total variable to a string and
/// assigns the result to the totalLAbel control's property. 
/// 
/// The "c" format string causes the number to be formatted as currency.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 7: Switch your view back to Designer and double-click the fifty
/// CentsPictureBox control. This opens the code editot, and you will see
/// fiftyCentsPictureBox_Click event handler by typing the code shown
/// in lines 59-63 in Program 3.6. Let's take a closer look at the code:
/// 
/// Line 60: This statement adds the value of the FIFTY_CENTS_VALUE
/// constant to the total field.
/// 
/// Line 63: This statement converts the total variable to a string and
/// assigns the result to the totalLabel control's property.
/// 
/// The "c" format string causes the number to be formatted as currency.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 8: Now you write the event handler for the Exit button. Switch your
/// view back to the Designer and double-click the exitButton control.
/// 
/// This opens the code editor, and you will see an empty event handler
/// named exitButton_Click.
/// 
/// Complete the exitButton_Click event handler by typing the code
/// shown in line 68-69 in Program 3.6
 /// //////////////////////////////////////////////////////////////////
/// 
/// ////////////////////////////////////////////////////////////////////
/// Step 9: Save the project. Then, press the f5 key on the keyboard 
/// or click the Start Debugging button(|>) on the toolbar to compile
/// and run the application. Test teh application by click the coin 
/// images in any order you wish. The total shown on the form should
/// update by the correct amount each time you click a coin. When you
/// are finished, click the Exit button and the form should close.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
///             3.10 Using the Math Class
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// Concept The .NET Framework's Math class provides deveral methods
/// for performing complex mathematical calculations.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The .NET Framework provides a class named Math, witch contrins
/// numerous methods that are useful for performing advance mathematical
/// operations.
/// 
/// Table 3.16 gives a summary of several of the Math class methods. 
/// 
/// (For a comprehensive list of all the methods provided by the Math
/// class and more details on any of the methods, just search for Math
/// class in the MSDN help system.)
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Table 3.16 Many of the Math class methods
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Math class Methods                  Description
/// /////////////////////////////////////////////////////////////////////
/// 
/// Math.Abs(x)  ~ Returns the absolute value of x.                         
/// /////////////////////////////////////////////////////////////////////
/// Math.Acos(x) ~ Returns the arccosine of x, in radians. The argument x
///               is a double, and the value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Asin(x) ~ Returns the arcsine of x, in radians.   The argument x
///               is a double, and the value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Atan(x) ~ Returns the arctangent of x, in radians.The argument x
///               is a double, and the value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Ceiling(x) ~ Returns the least integer that is greater than equal
///                 to x (a decimal or a double).
/// /////////////////////////////////////////////////////////////////////
/// Math.Cos(x) ~ Returns the cosine of x in radians. The argument x is a
///             double, and the value that us returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Exp(x) ~ Returns e^x. The argument x is a double, and the value
///             that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Floor(x) ~ Returns the greatest integer that is less than or equal to x (a decimal or a double).
/// /////////////////////////////////////////////////////////////////////
/// Math.Log(x) ~ Returns the natural logarithm of x. The argument x is a
///             double, and the value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Log10(x) ~ Returns the base-10 logarithm of x. The argument x is a
///             double, and the value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Max(x,y) ~ Returns the greater of the two values x and y.
/// /////////////////////////////////////////////////////////////////////
/// Math.Min(x,y) ~ Returns the lesser of the two values x and y.
/// /////////////////////////////////////////////////////////////////////
/// Math.Pow(x,y) ~ Returns the value of x (a double) raised to the power
/// of y (also a double). The value that is returnd is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Round(x) ~ Returns the value of x (a double or a decimal) rounded
///             to the nearest integer.
/// /////////////////////////////////////////////////////////////////////
/// Math.Sin(x)   ~ Returns the sine of x in radians.
/// /////////////////////////////////////////////////////////////////////
/// Math.Sqrt(x)  ~ Returns the square root of x (a double).
/// The value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Tan(x) ~ Returns the tangent of x in radians. The arguments x is
///             a double, and the value that is returned is a double.
/// /////////////////////////////////////////////////////////////////////
/// Math.Truncate(x) ~ Returns the integer part of x (a double or a decimal)
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// These methods typically accept one or more values as argumes,
/// perform a mathematical operation using the arguments, and return
/// the result. 
/// 
/// For ex, the MAth.Pow method raises a number to a power.
/// 
/// Here is an example of how the methodws is called:
/// ////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// double result;
/// result = Math.Sqrt(4.0,2.0);
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The method takes two double arguments. it raises the first argument
/// to the power of the second argument and returns the result as a double.
/// 
/// In this example, 4.0 is raised to the power of 2.0. This statement is 
/// equivalent to thge following algebraic statement:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// result = 4^2
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The following code sample shows another example of a statement using
/// the Math.Pow method. it assigns 3 times 6^3 to x:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// double x;
/// x = 3 * Math.pow(6.0,3.0);
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The Math.sqrt method accepts an argument and returns the square root
/// or the argument. Here is an example of how it is used: 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// double result;
/// result = Math.Sqrt(16.0);
/// /////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// The statement that calls the Math.Sqrt method passes 16.0 argument.
/// The method returns the square root of 16.0 (as a double), which is 
/// then assigned to the result variable.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                 The Math.PI and Math.E Named Constants
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The Math class also provides two predefined named constants, Math.PI
/// and Math.E, which are assigned mathematical values for pi and e. You
/// can use these variables in equations that require their values. For
/// example, the following statement whic hcalculates the area of a circle
/// uses Math.PI.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// area = Math.PI * radius * radius;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note If you look at the top form's scource code in the editor, you
/// should see a directive that reads using System;. That directive is
/// required for any program that uses the Math class.
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
/// 3.11 More GUI Details
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In Chapter 2, you learned the basics of creating a GUI by placing
/// controls on a form and setting various properties. In this section,
/// you learn to fine-turn many aspecrs of an applicatrions's gui
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Controlling a Form's Tab Order
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// When an application is running and a form is displayed, one of the 
/// form's controls always has the focus.
/// 
/// The control having the focus
/// is the one that receives the user's keyboard input.
/// 
/// For example, 
/// when a TextBox control has the focus, it receives the characters that 
/// the user enters on the keyboard. 
/// 
/// When a button has the focus,
/// it receives teh characters that the user enters on the keyboard.
/// 
/// When a button has focus, pressing the Enter key executes the button's
/// Click event handler.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Only controls capable of receiving some sort of input, such as text
/// boxes and buttons, may have the focus.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// You can tell which control has the focus by looking at the form at 
/// run time.
/// 
/// When a TextBox control has the focus, a blicking text
/// cursor appears inside it, or the text inside the TextBox control 
/// might appear heighlighted.
/// 
/// When a button has the focus, a thin dotted line usually appears
/// around the control.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// When an application is running, pressing the Tab key changes the focus
/// from one constrol to another.
/// 
/// The order in which controls recieve the focus is called the tab order.
/// 
/// When you place controls on a form in Visual C#, the tab order is in 
/// the same sequence in which you create controls.
/// 
/// IN many cases this is the tab order you want, but sometimes you
/// rearrange controls on a form, delete controls, and add new ones.
/// 
/// These modifications often leads to a disorganized tab order, which
/// 
/// can confuse and irritate the user of your applicaion.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Users want to tab smoothly from one control to the next, in a logical sequence.
/// 
/// You can modify the tab order by changing a control's
/// position in the tab order.
/// 
/// When you create a control, Visual C# automatically assigns a value to
/// its TabIndex property.
/// 
/// The first control you create on a form has a TabIndex of 0, the
/// second has a TabIndex of 1, and so forth.
/// 
/// The control with a TabIndex of 0 is the first control in the tab 
/// order. 
/// 
/// The next control in the tab order is the ine with a TabIndex of 1.
/// 
/// The tab order continues in this sequence. 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// You may change the tab order of a form's controls by sekecting them,
/// one by one, and changing their TabIndex property in the Properties 
/// window. 
/// An easier method, however, is to click View on the Visual Studio
/// menu bar and then click Tab Order.
/// This causes the foram to be displayed in the tab order selection 
/// mode.
/// 
/// The image on the left in Figure 3-31 shows a form in the normal view,
/// and the image on the right shows the form in tab order
/// selection mode. 
/// 
/// We have also inserted the names of the TextBos and Button controls
/// in the image of the right for reference purposes.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-31 A form displayed in tab order selection mode
/// /////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// In tab order selection mode, each contro's existing TabIndex value is
/// displayed in a smaller box in the contro;s upper-left corner. Notice
/// the following in the image on the right in Figure 3-31.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///     *The nameTextBox control's TabIndex is 2.
///     *The addressTextBox control's TabIndex is 3.
///     *The cityTextBox control's TabIndex is 0.
///     *The stateTextBox control's TabIndex is 4.
///     *The zipTextBox control's TabIndex is 1.
///     *The clearButton control's TabIndex is 8.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note
/// //////////////////////////////////////////////////////////////////
/// Although the LAbel controls have TabIndex values, those values are
/// irrelvant in this example because LAbel controls cannot recieve the
/// focus.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// As you look at Figure 3-31, think about the order in which the
/// controls will receive the focus when the applications runs.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// *The cityTextBox control has the lowest TabIndex value (0), 
/// so it will receive the focus first.
/// 
/// *IF you press the Tab key, the focus will jump to the zipTextBox
/// control because it has the next lowest tabIndex value(1).
/// 
/// *Press the Tab key, the focus will jump to the nameTextBox control
/// because it has the next lower TabIndex value(2).
/// 
/// *Press the Tab key again and the focus will jump at the 
/// addressTextBox control(TabIndex is set to 3).
/// 
/// *Press the Tab key again and the focus will jump at the stateTextBox
/// control(TabIndex is set to 4).
/// 
/// *Press the Tab key again and the focus will jump at the clearTextBox 
/// control(TabIndex is set to 8).
/// 
/// /////////////////////////////////////////////////////////////////////
/// This is a very confusing tab order and should be rearranged. 
/// 
/// When a form is displayed in tab order selection mode
/// ,you establish a newtab order by simply clicking the control with 
/// the mouse in in the order you want. 
/// 
/// To fix the disoraganized tab order shown in Figure 3-31, we perform 
/// the following:
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// *First, click the NameTextBox control. The control's TAbIndex value changes to 0.
/// 
/// *Next, click the addressTextBox control. The control's TAbIndex value changes to 1.
/// 
/// *Then, click the cityTextBox control. The control's TAbIndex value changes to 2.
/// 
/// *Next, click the stateTextBox control. The control's TAbIndex value changes to 3.
/// 
/// *Then, click the zipTextBox control. The control's TAbIndex value changes to 4.
/// 
/// *Finally, click the clearbutton control. The control's TAbIndex value changes to 5.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// When you are finished, exit tab order selection
/// mode by pressing the Esc key. 
/// 
/// Now when the application runs,the focus will shift smoothly in an
/// order that makes sense to the user.
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// Changing the focus with the Focus Mathod
/// /////////////////////////////////////////////////////////////////////
/// Often, you want to make sure particular control has the focus.
/// 
/// For example, look at the form shown in Figure 3-31. The purpose of
/// the Clear button is to clear any input that the user has entered and
/// rest the form so it is ready to accept a new set of input.
/// 
/// When the Claer button is clicked, the TextBox controls should be
/// cleared and the focus should return to the nameTextBox control.
/// 
/// This would make it unnecessary for the user to click the TextBox 
/// control in order to start entering another set of information.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In code, you move the focus to a control by calling the focus method.
/// The method's general syntax is:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// ControlName.Focus();
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// where ControlName is the name of the control. For instance, you move
/// the focus to the nameTextBox control with this statement:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// nameTextBox.Focus();
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// After the statement executes, the nameTextBox control will have the
/// focus. 
/// 
/// Here is an example of how the clearButton control's Click event
/// handler could be written: 
/// /////////////////////////////////////////////////////////////////////
/// 
/// 1   private void clearButton_Click(object sender, EventArgs e)
/// 2  {
/// 3       // Clear the TextBox controls.
/// 4       nameTextBox.Text = "";
/// 5       addressTextBox.Text = "";
/// 6       cityTestBox.Text ="";
/// 7       stateTextBox.Text = "";
/// 8       zipTextBox.Text = "";
/// 9       
/// 10      // Set the focus to nameTextBox.
/// 11      nameTextBox.Focus();
/// 12 }
/// /////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// The statements in line 4-8 clear the contents of the TextBox controls.
/// 
/// Then, the statemenet in line 11 sets the focus to the nameTextBox
///     control.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// An access key, also know as a mnemonic, is a key that is pressed in
/// combination with the Alt key to access quickly a control such as a button.
/// 
/// When you assign an access key to a button, the user can trigger a
/// CLick event either by clickign the button with the mouse or by using 
/// the access key.
/// 
/// Users who are quick with the keyboard prefer to use acceess keys
/// instead of the mouse.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// You assign an access key to a button through its Text property. For ex,
/// assume an application has a button whose Text property is set to Exit.
/// You wish to assign the access key Alt + X to the button so the user may
/// trigger the button's CLick event by pressing Alt+X on the keyboard. 
/// 
/// To make the assignment, place an ampersand (&) before the letter x 
/// in the button's Text property: Exit.
/// 
/// Figure 3-32 shows how the Text property appearsin the Properties
/// window.
/// /////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////
/// Figure 3-32 Text property E&xit
/// /////////////////////////////////////////////////////////////////////
/// 
/// ////////////////////////////////////////////////////////////////////
/// ALthough the ampersand is part of the Button control's Text property,
/// it is not displayed on the button.
/// 
/// With the ampersand in form of the letter x, the letter will appear
/// underlined as shown in Figure 3-33.
/// This indicates that the button may be clicked by pressing Alt-X on
/// the keyboard.
/// 
/// (You will see the underlining at Design time. At run time, however,
/// the underlining may not appear until the user presses the Alt key.)
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// Figure 3-23 Button control with E&xit Text property
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note Access keys do not distinguish between uppercase and lowercase
/// characters. There is no difference between Alt+X and Alt + x.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Suppose we store the value &Exit in the button's Text property. The 
/// ampersand is in front of the letter E, so Alt + E becomes the access
/// key.
/// 
/// The button will appear as shown in Figure 3-34.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-34 Button control with &Exit Text property
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Assigning the Same Access Key to Multiple Buttons
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Be careful not to assign the same access key to two or more buttons
/// on the same form.
/// 
/// If two or more buttons share the same access key,
/// a Click event is triggered for the first button created when the user
/// presses the access key.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Displaying the & Character on a Button
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// IF you want to tdisplay an ampersand character on a button, use two
/// ampersands (&&) in the Text property. USing two ampersands causes a 
/// sigle ampersand to display and does not define an access key. For ex,
/// if a button's Text property is set to Save && Exit , the button will 
/// appear as shown in Figure 3-35.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-35 Button control with Save && Exit Text property
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Accept Buttons and Cancel Buttons
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// An accept button is a button on a form that is automatically clicked
/// when the user presses the Enter key. A cancel button is a button on a 
/// form that is automatically clicked when the yser presses the Exc key.
/// 
/// Forms have two properties, AcceptButton and CancelButton, which allow
/// you to designate an accept button and a cancel button. When you select
/// these properties in the Properties window, a down-arrow button (V)
/// appears, which displays a drop-down list when clicked. The list contains
/// the names of all the buttons on the form. You select the button that you
/// want to designate as the accept button ot cancel button.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Any button that is frequently clicked should probably be selected as
/// the accept button. This will allow keyboard users top access the button 
/// quickly and easily. Exit or Cancel button are likely candidates to
/// become cancel buttons.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The BackColor Property
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Forms and most controls have a BackColor property that allows you to
/// change the object's background color. When you select an object's
/// BackColor property in the Properties window, a down-arrow button
/// 
/// (V) appers, which displays a drop-down list of available colors
/// when clicked, as shown in Figure 3-36.
/// //////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///             Figure 3-36 Drop-down list of colors
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The drop-down list has three tabs: Custom, Web, and System. The System
/// tab lists colors defined in the current Windows configuration. The Web
/// tab lists colors displayed with consistency in Web browsers. The
/// Custom tab displayed a color palette. Select a color form one of the 
/// tabs and the object's background color will be set to the color.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// THe ForeColor Property
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Controls that display test have a ForeColor property that allows you
/// to change the color of the text.
/// 
/// When you select a control's ForceColor property in the Properties
/// window, a down- arrow button (V) appears,
/// which displayed the drop-down list of available colors shown in 
/// Figure 3-36 when clicked. 
/// 
/// Select a color from one of the tabs and the text that is displayed
/// by the control will be set to that color.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                 Setting Colors in Code
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In addition to using the Properties window, you can also set the
/// values of the BlackColor and ForeColor properties with code. The .NET
/// Framework provides numerous values that represents colors and can
/// be assigned to the ForeColor and BackColor properties in code.
/// 
/// The following are a few of the values: 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Color.Black
/// Color.Blue
/// Color.Cyan
/// Color.Green
/// Color.Magenta
/// Color.Red
/// Color.White
/// Color.Yellow
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// For example, assume an application has a Label control named
/// messageLabel1. The following code sets the label's background color to
/// black and foreground color to yellow:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// messageLabel.BackColor = Color.Black;
/// messageLAbel.ForeColor = Color.Yellow;
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The .NET Framework also provides values that represent default colors
/// on your system.
/// 
/// For example, the value SystemColors.Control represents the default 
/// control background color and SystemColors.ControlText represents the
/// default control text color.
/// 
/// The following statements set themessageLabel control's background and
/// foreground to the default colors:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// messageLabel.BackColor = SystemColors.Control
/// messageLabel.ForeColor = SystemColors.ControlText
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///     Note ~ If you have an event handler in a form's source code file
///     and you want the event handler to change the form's BackColor
///     property, use the this keyword to refer to the form. For ex,
///     the following statement changes the color of the form to blue:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                 this.BackColor = Color.Blue;
/// /////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
///                 Background Images for Forms
/// /////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////
/// In CHapter 2, you learned about displaying images with PictureBox 
/// controls. An image can also be displayed as the background for a form.
/// 
/// Forms have a property named BackgroundImage that allows you to import
/// and display an image on the form.
/// 
/// If you know how to use the PictureBox control's Image property, then
/// you already know how to use a form's BackgroundImage property.
/// They both work the same way:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// * Click the BackgroundImage property in the Properties window. An
///     ellipses button (...) will appear.
/// 
/// * Click the ellipses button and the Select Resource window will 
///     appear.
///     
/// * In the Select Resource window, click the Import button. 
///     An Open dialog box will appear. Use the dialog box to locate and 
///     select the image file that you want to display.
///     
/// * Click the OK button in the Select Resource window, and the selected
///     image will appear as the form's baclground.
/// /////////////////////////////////////////////////////////////////////
/// 
/// ////////////////////////////////////////////////////////////////////
/// A form's BackgroundImageLayout property is similar to the PictureBox
/// control's SizeMode property.
/// 
/// It specifies how the background image is to be displayed.
/// 
/// It can be set to once of the following values:
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// * NONE ~ The image is positioned in the upper-left corner of the form.
///          If the image is too big to fit in the form, it is clipped.
/// 
/// * TILE ~ This is the default value. 
///          The image is tiled (repeatedly displayed) across the form.
/// 
/// * CENTER ~ The image is centered in the form without being resized.
/// 
/// * STRETCH ~ The image is resized both horizontally and vertically
///             to fit in the form. IF the image is resized more in one
///             direction than the other, it appears stretched.
/// 
/// * ZOOM ~ The image is uniformaly resized to fit the form without losing
///          its original aspect ratio. This causes the image to be resized
///          without appearing stretched.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-37 shows examples of each of these settings.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-37 Different settings for the BackgroundImageLayout property
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///         Organizing COntrols with GroupBoxes and Panels
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// A GroupBox control is a retangular control that appears with a thin
/// border and an optional title in its upper-left corner.
/// 
/// It is a container that hold other controls.
/// 
/// You can use GroupBoxes to create a sense of visual organization on a 
/// form.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The GroupBox control is found in the Toolbox, in the Contriners 
/// section. 
/// 
/// When you create a GroupBox control, you can set its Tile
/// property to the text that you want displayed in the GroupBox's
/// upper-left contner. IF you don't want a title displated on the 
/// GroupBox, you can clear the contrents of its Text Property.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-38 shows a form with a GroupBox control. 
/// 
/// The control's Textproperty is set to Personal Data, and several other
/// controls are inside the GroupBox.
/// 
/// The image on the left shows how the form appears in the Designer, and
/// the image on the shows how the form appears at run time.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-38 A GroupBox containing other controls
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Creating a GroupBox and Adding Controls to It
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Suppose you've just created a GroupBox control.
/// 
/// To add another control to the GroupBox, select the GroupBox control
/// and then double-click the desired tool in the Toolbox  to place
/// another control inside the group box.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///             Moving an Existing Controls to a GroupBox
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// If an exising control is not inside a GroupBox but you want to move 
/// it to the GroupBox, follow these steps:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// 1. Select the control you wish to add to the GroupBox.
/// 2. Cut the control to the clipboard.
/// 3. Select the GroupBox.
/// 4. Paste the control.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                 Moving and Resizing a GroupBox
/// //////////////////////////////////////////////////////////////////
/// 
/// ////////////////////////////////////////////////////////////////////
/// IF a GroupBox is selected in the Designer, 
/// a four-headed arrow () will appear in the GroupBox's
/// upper-left corner,Click and draw the four-headed arrow to move
/// the GroupBox. 
/// 
/// Any controls indie the GroupBox move with it.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                      Deleting a GroupBox
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// To delete a GroupBox, simply select it in the Designer and then press
/// the Delete key. Any controls inside the GroupBox are deleted as well.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                     Group Box Tab Order
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// The value of a control's TabIndex property is handled differently when
/// the control is placed inside a GroupBox control.
/// 
/// GroupBox controls have their own TabIndex property, and the TabIndex
/// value of the controls inside the group box are relative to the
/// GroupBox control's TabIndex property. 
/// 
/// For ex, Figure 3-39 shows a GroupBox control displayed in tab order
/// selection mode.
/// 
/// As you see, the GroupBox control's TabIndex is set to 0.
/// 
/// The TabIndex of the controls inside the group box is displayed as 0.0
/// , 0.1, 0.2, and so forth.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///              Figure 3-39 GroupBox TabIndex values
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///         Note The TabIndex properties of the controls inside the group
///         box will not appear this way in the Properties window. They
///         will appear as 0,1,2, and so forth.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// A Panel control is a rectangular container for other controls, like a
/// GroupBox. There are aeveral primary defferences between a Panel and
/// GroupBox:
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// * A Panel cannot display a title and does not have a Text property.
/// 
/// * A Panel's border can be specified by its BoarderStyle property. The
///   available settings None, FixedSingle, and Fixed3D. The property is 
///   set to None by default, which means that no boarder will appear.
///   If the BorderStyle property is set to FixedSingle, the control will
///   be outlined with a thin boarder. IF the BorderStyle property is set
///   to Fixed3D, the control will have a recessed 3D appearance.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///           Figure 3-40 A Panel containing other controls
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
///          3.12 Using the Debugger to Locate Logic Errors
/// /////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Concept ~ The Visual Studio debugger allows you to pause a program
/// and then execute statements one at a time.
/// 
/// After each statement executes, you may wxamine variable contents
/// and property values.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// A logic srror is a mistake that does not prevent an application
/// from running, but causes the application to produce incorrect results.
/// 
/// Mathematical mistakes, assigning a value to the wrong variable, or
/// assigning the wrong value to a variable are examples of logic errors.
/// 
/// Logic wrrors can be difficult to find. Finding and fixing a logic
/// error usually requires a bit of detective work on the part of the 
/// programmer.
/// 
/// Fortunately, Visual Studio provides you with debugging tools that
/// make locating logic errors easier.
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Visual Studio allows you to set breakpoints in your program code. 
/// A breakpoint is a line you select in your source code. When the 
/// application is running and it reaches a breakpoint, the application
/// pauses and enters break mode. While the applicaion is paused, you
/// may examine variable contents and the value stored in certain
/// control properties.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Visual Studio allows you to single-step through an application's code
/// once its execution has been paused by a breakpoint. 
/// 
/// This means that the applicaion's statements execute one at a time, 
/// under your control. After each statement executes, you can examine 
/// variable and property values. This process allows you to identify the 
/// line or lines of code causing the error. In Tutorial 3.6, you single
/// -step through an application's code.
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
 ///
 /// //////////////////////////////////////////////////////////////////
/// Tutorical 3-6: Single-stepping through an Application's Code at 
/// Runtime
/// ////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// In this tutorial, you will open the Average Race Times application,
/// and test it for logic errors.
/// 
/// The applcation is simple: it letsthe user enter the finishing time
/// for the three runners, and then click a button to calculate their
/// average time.
/// 
/// To determinewhether the application correctly calculates an average,
/// you will perform a simple test.
/// 
/// You will enter the value 25 for eachrunner, and then click the button 
/// to calculate the average.
/// 
/// The result should also be 25. If the application produces any other
/// value, then you know that a logic error exists somewhere in the 
/// application's code.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio.
/// 
/// Open the project named Average Race Times in the Chap03 folder of 
/// the Student Sample Programs.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 2: Run the application. The application's form appears, as shown
/// in Figure 3-41.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-41 The Average Race Times application running
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 3: This application allows you to enter the finishing times of
/// three runners in a race, and then see their average time. Enter 25
/// as the time for all three runners.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 4:CLick the Calculate Average button. The application displays
/// the incorrect value 58.3 as the average time. 
/// 
/// (the correct value should be 25.)
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 5: Click the Exit button to stop the application.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 6: Open the code editor
/// (click View on the menu bar, and then select code) and locate the 
/// following line of code, which appears in the calculateButton_CLick
/// event handler:
/// 
/// runner1 = double.Parse(runner1TextBox.Text);
/// 
/// This line of code is where we want to pause the execution of the 
/// application. We must make this line a breakpoint.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 7: Click the mouse in the left margin of the code editor, next
/// to the line of code, as shown in Figure 3-42.
/// 
/// Notice that a red dot appears next to the line in the left margin, 
/// and the line of code becomes highlighted.
/// 
/// The dot indicates that a breakpoint has been set on this line.
/// 
/// Another way to set a breakpoint is to move the text cursor to the
/// line you wish to set as a breakpoint, and then press F9
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                 Figure 3-42 Setting a breakpoint
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 8: Now that you have set the breakpoint, run the application.
/// 
/// When the form appears, enter 25 as the time for each runner.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 9: Click the Calculate Average button. When program execution 
/// reaches the breakpoint, it goes into break mode and the code editor
/// reappears.
/// 
/// The breakpoint line is shown with yellow highlighting and
/// a small yellow arrow appears in the left margin, as shown in Figure
/// 3-43.
/// 
/// The yellow highlighting and small arrow indicate the application's
/// current execution point. The execution point is the next line of code
/// that will execute. (The line has nor yet executed.)
/// /////////////////////////////////////////////////////////////////////
/// 
/// 
/// 
/// /////////////////////////////////////////////////////////////////////
/// Figure 3-43 Breakpoint reached
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Note If the highlighting and arrow appear in a color other then yellow
/// , the color options on ur system may have been changed.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 10: To examine the contents of a variable of control property,
/// hover the cursor over the variable or the property's name in the code
/// editor.
/// 
/// A small box will appear showing the variable or property's contents.
/// For example, Figure 3-44 shows the result of hovering the mouse pointer
/// over the expression runner1TextBox.Text in the highlighted line.
/// 
/// The box indicares that the priperty is current set to 25 
/// 
/// 
/// //////////////////////////////////////////////////////////////////
/// 
/// ////////////////////////////////////////////////////////////////////
/// Figure 3-44 runner1TextBox.Text property contents revealed
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 11: Now, hover the mouse pointer over the variable name runner1.
/// A box appears indicatiing that the vartiable is set to 0. Because the 
/// highlighted statement has not yet executed, no value has been 
/// assigned to the variable.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 12: You may also examine the contents of variables with the
/// Autos, Locals, and Watch windows.
/// 
/// (The Immediate window is beyond of this chapter.)
/// 
/// A description of each window follows:
/// 
/// *The Autos window displays a list of a variabeles appearing in
/// the current statement, the three statements before, and three
/// statements after the current statement.
/// The current value and the data type of each variable are also
/// displayed.
/// 
/// *The Immediate window allows you to type debugging commands using
/// the keyboard.
/// This window is generally used by advanced programmers.
/// 
/// *The Locals window displays a list of all the variables in the
/// current procedure. 
/// The current value and the data type of each variable are also
/// displayed.
/// 
/// *The Watch window allows you to add the names of variables
/// you want to watch.
/// This window displays only the variavles you have added. 
/// Visual Studio lets you open multiple Wach windows.
/// 
/// You can open any of these windows by clicking Debug on the menu bar,
/// then selecting Windows, and then selecting the windos that you want 
/// to open. Use this technique to open the Locals window now.
/// 
/// The Locals window should appear, similar to Figure 3-45.
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///  Figure 3-45 Locals window displayed
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 13: Now you are ready to single-step through each statement in
/// the event handler. To do this, is covered in Chapter 6.)
/// 
/// You activate the Step into command by one of the following methods:
/// 
///     *Press the F11 key.
///     
///     *Click Debug on the menu bar, and then select Step into from the 
///     Debug menu.
///     
/// When you activate the Step into command, the heighlighted statement
/// is executed.
/// 
/// Press the F11 key now. Look at the Watch window and notice that the
/// runner1 variable is now set to 25. Also notice that the next line of
/// code is now highlighted.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 14: Press the F11 key more times.
/// The variables runner1, runner2, and runner3 should display values of 
/// 25 in the Locals window.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 15:The following statement, which is supposed to calculate the 
/// average of the three scores, is now highlighted: 
/// 
/// average = runner1 + runner2 + runner3 / 3.0;
/// 
/// After this statement executes, the average of the three numbers
/// should display next to average. Press F11 to execute the statement.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 16: Notice that the Locals window now reports that average holds
/// the value 58.333333333333336.
/// 
/// This is not the correct value, so there
/// must be a problem with the math statement that just executed.
/// 
/// Can you find it?
/// 
/// The math statement does not calculate the correct value
/// because the devidion operation takes place before any of the addition
/// operations.
/// 
/// You must correct the statement by inserting a set of parentheses.
/// 
/// From the menu, select Debug, and then click Stop Debugging
/// to the application. In the Code window, insert a set of parentheses
/// into math statement so it appears so follows:
/// 
/// average = (runner1 + runner2 + runner3) / 3.0;
/// 
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 17: Next, you will clear the breakpoint so the
/// application will not pause again when it reaches that line of code.
/// To clear the breakpoint, use one of the following methods:
/// 
/// *Click the mouse on the breakpoint dot in the left margin of the code editor.
/// 
/// *Press Control + Shift + F9.
/// 
/// *Select Debug from the menu bar, and then select Delete All
///  Breakpoints from the Debug menu.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 18: Run the application again. Enter 25 as each runner's time, 
/// and then click the Calculate Average button. This time the correct
/// average, 25.0, is displayed.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Step 19: Click the Exit to stop the application.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Debugging Commands in the Toolbar
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
/// Visual Studio provides a toolbar for debugging commands, as shown
/// in Figure 3-46.
/// /////////////////////////////////////////////////////////////////////
/// 
/// /////////////////////////////////////////////////////////////////////
///                 Figure 3-46 Debug toolbar commands
/// /////////////////////////////////////////////////////////////////////