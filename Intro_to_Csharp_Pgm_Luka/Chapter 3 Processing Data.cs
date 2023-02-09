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
/// to refer to Program 3.1 as you write the event handlers. 
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
//////////////////////////////////////////////////////////////////////////