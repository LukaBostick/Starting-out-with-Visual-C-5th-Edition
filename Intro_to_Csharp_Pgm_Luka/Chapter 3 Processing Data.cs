using System;

namespace Chapter3ProcessingData
{
    static void Main(string[] args)
    {

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
/// THis works for the obvious reason that string variables are compatible with other string variables.
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
/// Let's consider a hypothetical situation. Suppose you've written an application that uses a double var, and for some reason, you need to assign the contents of the double var to an int var. IN this particular situation, you know that the double var's value is somthing that can be safely converted to an int without any loss of data(sucj as 3.0, or 98.0). However,  the C# compiler will not allow you to make the assignment because double values are not assignment compatible with int vars. Isn;t there a way to override the C# rules in this particular sitation and make the assignment anyway?
/// 
/// //////////////////////////////////////////////////////////////////////////
/// The answer is yes, there is a way. You can use a cast operator to
/// explicitly convert a value from one numeric data type to another,
/// even if the conversion might result in a loss of data.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
//////////////////////////////////////////////////////////////////////////