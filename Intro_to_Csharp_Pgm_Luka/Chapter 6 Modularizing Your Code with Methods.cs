namespace Chapter6ModularizingYourCodewithMethods
{
	class Text
	{
		static void Main(string[] args)
		{

		}
	}
}
/* /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * Chapter 6 Modularzing Your Code with Methods
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Topics
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 6.1 Introduction to Methods
 * 
 * 6.2 void Methods
 * 
 * 6.3 Passing Arguments to Methods
 * 
 * 6.4 Passing Arguments by Reference 
 * 
 * 6.5 Value-Returning Methods
 * 
 * 6.6 Debugging Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 6.1 Introduction to Methods
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: Methods can be used to break a complex program into small,
 * manageable pices. A void methods simply executes a group of statements 
 * and the terminates. A value-returing method returns a value of the 
 * statements that called it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In a general sense, a method is a collection of statements that performs
 * a specific task. So far, you have experienced methods in the following 
 * two ways:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *You have created event handlers. An event handler is a special type 
 * of method that responds to events.
 * 
 * * You have executed predefined methods from the .NET Framework,
 * such as MessageBox.Show and the TryParse methods.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this chapter, you will learn how to create your own methods that 
 * can be executed just as you execute the .NET Framework methods.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Methods are commonly used to break a problem into small, manageable
 * pieces. Instead of writing one long method that contains all the 
 * statements neccessary to solve a problem, you can write several small
 * methods that each solve a specific part of the problem. These small 
 * methods can then be executed in the desired order to slove the problem
 * . THis approach is sometimes called divide and conquer because a large 
 * problem is divided into several smaller problems that are easily solved.
 * Figures 6-1 and 6-2 Illistrate this idea by comparing two programs:
 * one that uses a long, complex event handler containing all the 
 * statements necessary to solove a problem and another that divides a
 * problem into smaller problems, each of which are handled by a separate
 * method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-1 Using one long sequence of statements to perfrom a tasl
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-2 Using methods to divide and conquer a problem
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In general terms, a program that is broken into smaller units of 
 * code, such as methods, is known as a modularied program. Modularization
 * tends to simplify code. If a specific task is preformed in everal places
 * in a program, a method can be written once to perform that task and then
 * be executed any time it is nedded. This benefit of using methods is know 
 * as code reuse because you are writing once to perform a task once and 
 * than reusing it each time you need to perform the task.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * void Methods and Value-Returning Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this chapter, you will learn to write two types of methods:
 * void methods and value-returing methods. When you call a void methods,
 * it simply executes the statements it contains and then terminates.
 * When you call a value-returning methods, it executes the statements that
 * is contains and then it returns a value back to the statement that 
 * called it. The Parse methods are good examples of value-returning 
 * methods. The first type of methods that you will learn to write is the void
 * method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 6.2 Void Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: A void method performs a task and then terminates. It does
 * not return a value back to the statement that called it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To create a methods you write its definition. A method definition has
 * two parts: a header and a body. The method header, which appears at 
 * the beginning of a method definition, lists several important things
 * about the method, including the method's name. The method body is a 
 * collection of statements that are performed when the method is 
 * executes. These statements are encloed inside a set of curly braces.
 * Here is an example of a method definition:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void DisplayMessage()
 * {
 *		MessageBox.Show("This is the DisplayMessage method.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Method Header
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Using the previously shown method definition, Figure 6-3 points out
 * the different parts of the method header, which is the first line.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Fogure 6-3 Parts of the method header
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at the parts identified in the figure:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *ACCESS MODIFIER - The keyeword private is an access modifier. When a 
 * method is declared as private, it can be can be called only by code 
 * inside the same class as the method. Alternatively, a method that is 
 * declared as public can be called by code that is outside the class. 
 * This is important because some spplications have multiple classes,
 * and unless you speifically intend a method to be avilable code outside
 * the class, you should declare it private.
 * 
 * *RETURN TYPE - Recall our previous discussion of void and value-returning
 * methods. When the keyword void appears here, it means that the method
 * is a void method and does not return a value. A you will see later in this
 * chapter, a value-returning method lists a data type here.
 * 
 * *METHOD NAME - You should give each method a decriptive name. In general,
 * the same rules that apply to variable names also apply to methods names.
 * The method in this example is nameed DisplayMessage, so we can easily
 * guess what the method does: It displays a message. In this book, we use
 * Pascal case for method names. Pascal case it like camelCase (The 
 * converntion we have been using for variable names), except in a Pascal
 * case name the firsr character is always uppercase. It is a standard 
 * convertion among C# programmers to use Pascal case for method names 
 * becaise it differentiates method names from variable and field names.
 * 
 * *PARENTHESES - In the header, the method name is always followed by a
 * set of parenthses. As you will see later in the chapter, you somtimes write
 * declarations inside the parentheses, but for now, the parentheses will 
 * be empty.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note : the method header is never terminated with a semicolon.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Method Body
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Beginning at the line after the method header one or more statemetns
 * appear indide a set of curly braces ({ }). These statements are the 
 * method's body are are perfomred any time the module is execited.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you write a method definition, Visual Studio sutomatically 
 * indents the statements in the method body. The indentation is not 
 * required, nut it makes the code easier to read and debug. By indenting
 * the statements in the body of the method, you visually set them apart 
 * from the surrounding code. This allows you to tell at a glance what
 * part of the program is part of the method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Declaring Methods Inside a Class
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Methods usually belong to a class, so you must write a method's 
 * definition inside the class to which it is supposed to belong. In
 * this chapter, all the methods that you will write will belong to 
 * an applicaion's Form1 class. When you write a method's definition,
 * you write it inside it the Form1 class, as shown in Figure 6-4.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-4 Write method definitions inside the Form1 class
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * calling a Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A method executes when it is called. Event handlers are called when 
 * specific events take place, but other methods are executed by method
 * calls statements. When a method is called, the program branches to 
 * that method and executes the statements in its body. Here is an 
 * example of a method call statement that calls the DisplayMessage 
 * method we previous examined:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DisplayMessage();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The statement is simply the name of the method followed by a set of
 * parentheses. Because it is a complete statement, it is terminated with
 * a semicolon. 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look a complete program that uses DisplayMessage method. In the 
 * Chap06 folder of this book's Student Sample Programs is a project named
 * Simple Method. Figure 6-5 shows the application's form in the Designer
 * , and Program 6-1 shows the form's code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-5 The Simple Method application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-1 Code for the Simple Method application's Form1 form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * LEt's setp through the code. When the user clicks the Go button, the
 * goButton_Click event handler executes. Inside the event handler
 * the statement in line 22 displays This is the goButton_Click method
 * in a message box. Then, line 32 calls the DisplayMessage method.
 * As is shown in Figure 6-6, the program jumps to the DisplayMessage
 * method and executes the statements in its body. There is only one 
 * statement in the body of the DisplayMessage method, which is line 29.
 * THis statement displays This is the DisplayMessage method, and then 
 * the method ends. As shown in Figure 6-7, the program jumps back to the
 * part of the program that called the DisplayMessage method and resumes
 * execution from that point. In this case, the program resumes execition
 * at line 24, which displays Back in the goButton_Click method. The go
 * Button_Click event handler ends at line 25.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-6 Calling the DisplayMessage method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-7 The DisplayMessage method returns
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a method is called, some operations are performed "behind the
 * scenes" so the system will know to where the program should return 
 * after the method ends. First, the system saves the memory address of
 * the location to which is should return. This is typically the
 * statement that appears immeduatly after the method call. This memory
 * location is known as the return point. Then, the system jumps to the
 * method and executes the statements in its body. When the method ends,
 * the system jumps back to the return point and resumes executiom.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: When a program calls a method, programmers commonly say that 
 * the control of the program transfers to that method. This simply means
 * that the method takes control of the program's execution.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Tutoria; 6-1, you will get hands-on practice writing and calling
 * methods.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 6-1: Creating and Calling Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Chap06 folder in this book's Student Programs contains a
 * partially created project named Lights. In this tutorial, you
 * complete the project so it simulates a light being turned off or on.
 * The project's form, in its initial setup, is shown in Figure 6-8.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-8 The Lights project's form in its initial setup
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here are some details about specfic property settings:
 * 
 * * The lightOnPictureBox control's Visible property is initially
 *   set to true.
 * 
 * * The lightOffPictureBox control;s Visible property is initially set
 *   to false
 * 
 * * The lightStateLabel displays either ON or OFF while the application
 * runs to indicate whether the light is on or off. Initially, this
 * control's Text property is set to ON.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * At run time, when the user clicks the Switch Light button, the state
 * of the light is reversed. In other words, if the light is currently 
 * on, it will be turned off. If the light is currently off, it will be 
 * turned on.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the light is turned on, the following actions take place:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * The lightOnPictureBox control's Visible property is set to true.
 * 
 * * The lightOfPictureBox control's Visible property is set to false.
 * 
 * *The lightStateLabel label's Text property is assigned the string "ON".
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the light is turned off, the following actions take place:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * The lightOffPictureBox control's Visible property is set to true.
 * 
 * * The lightOnPictureBox control's Visible property is set to false.
 * 
 * * The lightStateLabel label's Text property is assigned the string "OFF".
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To modularize the code, you create a method named TurnLightOn 
 * (containing the code to turn the light on), another method named
 * TurnLightOff(containing the code to turn the light off). When you need
 * to turn the light on, you call the TurnLightOn method and when 
 * you need to turn the light off you call the TurnLightOff method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Lights in the
 * Chap06 folder of this book's Student Sample Programs.
 * 
 * Step 2: Open the Form1 form in the Designer. The form is shown, along
 * with the names of the important controls, in Figure 6-8.
 * 
 * Step 3:Move the PictureBox controls so one is on top of the other, as
 * shown in Figure 6-9. (in the figure, the lightOnPictureBox control is on
 * top, but it really does not matter which is on top.) Also, reduce
 * the width of the form and position the button controls as shown in the
 * figure.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-9 The controls repositioned and the form size adjusted
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Program 6-2, at the end of this tutorial, shows the form's 
 * completed code. Open the code editor and type the code for the 
 * TurnLightOn and the TurnLightOff method, shown in lines 20-42
 * of Program 6-2.
 * Let's take a closer look at the code. Line 20 is the beginning of the
 * method named TurnLightOn. The purpose of this method is to simulate the
 * light turning on. When this method executes, line 23 makes the 
 * lightOnPictureBox control visible, line 26 makes the lightOffPicture
 * Box control invisible, and line 29 sets the lightStateLabel control's
 * Text property to "ON". Line 32 is the beginning of a method named 
 * TurnLightOff. The purpose of this method is to simulate the light
 * turning off. When this method executes, lines 35 makes the 
 * lightOffPictureBox control visible, line 38 makes the
 * lightOnPictureBox control invisible, and line 41 sets the
 * lightStateLabel control's Text property to "OFF".
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Next, you create the Click event handlers for the Button 
 * controls. Switch back to the Designer and double-click switchButton
 * control. This opens the code editor, and you will see an empty event 
 * handler named switchButton_Click. Complete the switchButton_CLick
 * event handler by typing the code shown in lines 46-54 in Program 6-2.
 * 
 * Let's review this code. The if statement in line 47 determines whether
 * the lightOnPictureBox control is visible. If it is, it means the light
 * is turned on, so the statement in line 49 calls the TurnLightOff
 * method to turn the light off. Otherwise, the else clause in line 51
 * takes over, and the TurnLightOn method is called on line 52 to turn
 * the light on.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 6: Switch your view back to the Designer and double-click the 
 * exitButton control. In the code editor you will see an empty event
 * handler named exitButton_Click. Complete the exitButton_Click event
 * handler by typing the code shown in lines 59-60 in Program 6-2.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 7: Save the project. Then, press F5 on the keyboard, or click
 * the Start Debugging button (|>) on the toolbar to compile and run
 * the application. When the application runs, click the Switch Light
 * button several times to simulate several coin tosses. When you are
 * finished, click the Exit button to exit the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-2 Completed code for Form1 in the Lights application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *							Top-Down Design
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this secion, we have discussed and demonstrated how methods work.
 * You have seen how the program jumps to a method when it is called and
 * returns to the part of the program that calls the method when the 
 * method ends. It is important that you understand these mechanical
 * aspects of methods.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Just as important as understanding how methods work is understanding
 * how to use methods to modularise a program. Programmers commonly use
 * a technique known as top-down design to break down an algorithm into
 * methods. The process of top-down design is performed in the follwing 
 * manner:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *The overall task that the program is to perform is broken down into
 * a series of subtasks.
 * 
 * *Each subtask is examined to determine whether it can be further broken
 * down into more subtasks. This step is repeated until no more subtasks
 * can be identified.
 * 
 * *Once all of the subtasks have been identified, they are written in code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This process is called top-down design because the programmer begins
 * by looking at the topmost level od tasks that must be preformed and
 * then breaks down thoes tasks into lower levels of subtasks.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: The top-down design process is somtimes called stopwise
 * refinement.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 6.3 Passing Arguments to Methods
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: An argument is any piece of data that is passed into a method
 * when the method is called. A parameter is a variable that receives an
 * argument that is passed into a method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Sometimes it is useful not to call a method, but also to send one or
 * more pieces of data into the method. Pieces of data that are sent into
 * a method are known as arguments. The method can use its argument in
 * calculations or other operations.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You are already familiar with how to use arguments in a method call.
 * For example, loop at the following statement:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * MessageBox.Show("Hello");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement calls the MessageBox.Show method and passes the string
 * "Hello" as an argument. Here is another example.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number = int.Parse(str);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Assume that number is an int variable and str is a string variable. 
 * This statement calls the int.Parse method, passing the str varialbe
 * as an argument.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * If you are writing a method and you want to receive arguments when it 
 * is called, you must equip the method with one or more parameter
 * variables. A parameter variable, often simply called a paramrer, is a
 * special variable that receives an argument when a method is called.
 * Here is an example of a method that has a parameter variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void DisplayValue(int value)
 * {
 *		MessageBox.Show(value.ToString());
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice the int variable declaration that appears inside the parentheses
 * (int value). This is the seclaration of a parameter variable, which 
 * enables the DisplayValue method to accept an int value as an argument.
 * Here is an example of a call to the DisplayValue method, passing 5 as
 * an argument:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DisplayValue(5);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement executes the DisplayValue method. The argument that is
 * listed indise that parentheses is assigned to the method's parameter
 * variable, value. This is illustrated in Figure 6-10.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-10 Passing the value 5 to the DisplayValu method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Inside the DisplayValue method, the variable value will contain the 
 * value of whatever argument was passed into it. If we pass 5 as the 
 * argument, the method will display the value 5 in a message box.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You may also pass the contents of variables and the values of expression
 * as arguments. For example, the following statements call the DisplayValue
 * method with various arguments passed:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DisplayValue(x);
 * DisplayValue(x * 4);
 * DisplayValue(int.Parse("700"));
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement is simple. It passes the value of the variable x
 * as the argument to the DisplayValue method. The second statement is 
 * also simple, but it does a little more work: it passes the result of the
 * expression x * 4 as the argument to the DisplayValue method. The third
 * statement does even more work. It passes the value returned from
 * the int.Parse method as the argument to the DisplayValue method. (The
 * int.Parse method is called first, and its return value is passed
 * to the DisplayValue method.) 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the Chap06 folder of this book's Student Sample Programs, you will
 * find a project named Argument Demo that demonstrates this method. 
 * Figure 6-11 shows the application's form, and Program 6-3 shows 
 * the form's code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-11 The Argument Demo application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-3 Code for the Argument Demo application's Form1 form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The form has four button controls, and a Click event hand;er has been 
 * written for each one. In addition to the event handlers, the code contains the 
 * DisplayVAlue method, which we discussed earlier, int lines 20-23
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IF you run the application and click the Demo1 button,
 * the demo1Button_Click event handler executes. In the 35 the
 * DisplayValue method is called, passing the expression as an argrumet.
 * 
 * This causes a message box to appear showing the value 8.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * If you click the Demo3 button, the demo3Button_Click event handlers
 * executes. In line 41 a for loop executes five time, each time passing
 * the count variable as an argument. This causes a message box to appear
 * five times, showing the values 0 through 4.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: When calling a method and passing a variale as an arguemnt,
 * simply write the variable name inside the parenthese of the method call.
 * Do not write the data type of the argument in the method call. For 
 * example, the folllowing stantement causes an error:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DisplayValue(int x), //Error!
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The method call should appar as follows:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * DisplayValue(x); // Correct
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: In this text, the values that are passed into a method are
 * called arguments, and the variables that receive those values are
 * called parameters. There are several variations of these terms in 
 * use. In some circles these terms are switched in meaning. Also, some
 * call the arguments actual parameters and call the parameters formal
 * parameters. Other use the terms actual arguments and formal argument.
 * Regardless of which set of terms you use, it is important to be 
 * consistent.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Tutorial 6-2, you complete an application that calls a method
 * and passes an argument to it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 6-2: Passing an Argument to a Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Cards project in the Chap06 folder
 * of this book's Student Sample Programs. The project's form, shown in
 * Figure 6-12, as already been created for you. The PictureBox controls
 * show the images of three cards. Each PictureBox control's Visible
 * property is set to False, so they do not initially appear when the 
 * applicaions runs. After you complete the application, the user can
 * select a card's name from the ListBox, click the Show Card button, 
 * and the image of the selected card will appear.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-12 The Cards project's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Cards in the ch06
 * folder of this book's Student Sample Programs.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 2: Program 6-4, at the end of thise tutorial, shows the form's
 * completed code. Open the code editor and type the comments and code
 * for the ShowCard method, shown in lines 20-36 of Programs 6-4.
 * 
 * The purpose of the ShowCard method is to display one of the card
 * PictureBox conmtrols. Let's take a closer look at the code.
 * 
 * Line 22: This is the beginning of the method. The method has a
 * string parameter named card. When we call the method, we pass
 * the item that the user selecetd in the ListBox as an argument,
 * and the method displays the specified card.
 * 
 * Lines 24-35:This is a switch statement that tests the value of the 
 * card parameter.
 * 
 * IF card is equal to "Ace of Spaces", the program
 * jumps to the case statemetn in line 26 and calld the ShowAceSpades
 * method in line 27.
 * 
 * IF card is equal to "10 of Hearts", the program
 * jumps to the case statemetn in line 29 and calld the ShowTenHearts
 * method in line 30.
 * 
 * IF card is equal to "King of Clubs", the program
 * jumps to the case statemetn in line 32 and calld the ShowKingClubs
 * method in line 33.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 3: Type the comments and code for the ShowAceSpades method, shown
 * in lines 38-45 of Program 6-4.
 * This method makes the aceSpadesPictureBox control visible, and the 
 * other PictureBox controls invisible.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Type the commands and code for the ShowTenHearts method, 
 * shown in lines 47-54 of Program 6-4.
 * This method makes the tenHeartsPictureBox control visible and the 
 * other PictureBox controls invisible.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Type the comments and code for the ShowKingClubs method,
 * shown in lines 56-63 of Program 6-4.
 * This method makes the KingClubsPictureBox control visible, and the 
 * other PictureBox controls invisible.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 6: Next, you create the Click event handlers for the Button 
 * controls. Switch back to the Designer and double-click the
 * showCardButton control. This opens the code editor and you will see
 * an empty event handler named showCardButton_Click. Complete the 
 * showCardButton_Click event handler by typing the code shown in lines
 * 67-76 in Program 6-4.
 * 
 * Let's review this code. The if statment in line 68 determines whether
 * the user has selected in the ListBox (converted to a string) is 
 * passed as an argument. If the user has not selected an item in the 
 * cardListBox control, the else clause in line 72 takes over, and lines 
 * 74-75 display a message box telling the user to select a card.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 7: Switch your view back to the Designer and double-click the
 * exitButton control. In the code editor you will see an empty event 
 * handler named exitButton_Click. Complete the exitButton_Click event
 * handler by typing the code shown in lines 81-82 in Program 6-4.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 8: Save the project. Then, press F5 on the keyboard or click the
 * Start Debugging button (|>) on the toolbar to compile and run the
 * application. Test the spplication by selecting each card's name in the
 * ListBox and clicking the Show Card button. When you are finished,
 * click the Exit button to exit the applicaiton.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-4 Completed code for Form1 in the Cards application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Argument and Paramenter Data Type Compatibility
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you pass an argument to a method, the argument's data type must
 * be assigned compatible with the receiving parameter's data type.
 * Otherwise, an error occurs when you try to compile the code.
 * We discussed assignment compatibility in Chapter 3.
 * Here is a summary of how it applies to argument passing when using
 * string s, int s, double s, and decimal s:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * You can pass only string arguments into string parameterts
 * 
 * *You can pass int arguments into int parmeters, but you cannot pass
 * double or decimal arguments into int parameters.
 * 
 * *You can pass either double or int arguments into double parameters,
 * but you cannot pass decimal values into double parameters.
 * 
 * *You can pass either decimal or int arguments to decimal parameters,
 * but you cannot pass double arguments into decimal parameters.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Parameter Variable Scope
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Recall from Chapter 3 that a variable's scope is the part of the 
 * program where the variable may be accessed. A variable is visible
 * only to statements inside the variable's scope. A parameter variable's
 * scope is the method in which the parameter is declared. No statement
 * outside the method can access the parameter variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Passing Multiple Arguments
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Often it is useful to pass more than one argument to a method. The 
 * following code sample shows a method that accepts two arguments.
 * The name of the method is ShowMax. It accepts two int arguments
 * and displays the value of the of the argument that is the 
 * greatest, If the arguments are equal, it displays a message saying
 * so.
 * (This method can be found in the Max project in the Chap06 folder
 * of this book's Student Sameple Programs.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void ShowMax()
 * {
 *		if(num1 == num2)
 *		{
 *			MessageBox.Show("The numbers are equal.");
 *		}
 *		else if(num1 > num2)
 *		{
 *			MessageBox.Show(num1 + " is the greatest.");
 *		}
 *		else
 *		{
 *			MessageBox.Show(num2 + " is the greatest.");
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that two parameters variables, num1 and num2, are declared inside
 * the parentheses in the method header (line 1). This is often referred to as 
 * a parameter list. Also notice that a comma separates the declarations.
 * Here is an example of a statement that calls the method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * ShowMax(5,10);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement passes the arguments 5 and 10 to the method. The 
 * arguments are passed into the parameter variable according to their
 * positions. In other words, the first argument is passed into the 
 * first paramenter variable, the second is passed into the second
 * parameter variable, and so forth. So, this statement causes 5 to be
 * passed into the num1 parameter and 10 to be passed into the num2
 * parameter. This is illustrated in Figure 6-13.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-13 Two arguments passed according to position to a method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Suppose we were tp reverse the order in which the arguments are 
 * listed in the method call, as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  ShowMax(10,5);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This causes 10 to be passed into the num2 parameter. The following code
 * sample shows one more example. This time we are passing variables
 * as arguments.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int value1 = 2;
 * int value2 = 3;
 * ShowMax(value1, value2);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the ShowMax method execute as a result of this code, the 
 * num1 parameter contains 2 and the num2 parameter contains 3.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: You have to write the data type for each parameter variable
 * that is declared in a parameter list. For example, a compiler error
 * would occur if the parameter list for the ShowMax method were 
 * written as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void ShowMax(int num1, num2)// Error!
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A data type for both the num1 and num2 parameter variables must be 
 * listed, as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void ShowMax(int num1, int num2)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Named Arguments
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In addition to the convertional approach of positional argument passing
 * (where the first argument is passed into the method's first parameter,
 * the second argument is passed into the method's second parameter, so 
 * so forth), C# also allows you to specify which parameter an argument 
 * should be passed into. To specify which parameter variable the argument
 * should be passed to, you use the following format to write the argument
 * in the method call:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * parameterName : value
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this format parameterName is the name of a parameter variable
 * and valuie is the value being passed to that parameter. An argument
 * that is written using this syntax is known as a named argument. To
 * demonstrate, look at the following method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void ShowName(string fileName, string lastName)
 * {
 *		MessageBox.Show(firstName + " " + lastName);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following statement shows how the method can be called using named
 * arguments:
 * /////////////////////////////////////////////////////////////////////
 *  //kinda cool
 * /////////////////////////////////////////////////////////////////////
 * ShowName(lastName : "Smith", firstName : "Suzanne");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement specifies that "Smith" should be passed into the 
 * lastName parameter and "Suzanne" should be passed into the firstName
 * parameter. You get the same result as if you had called the method
 * like this, using positional arguments:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ShowNames("Suzanne", "Smith");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Default Arguments
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * C# allows you to provide a default argument for a method parameter.
 * When a default argument is provided for a parameter, it becomes possible to 
 * call the method without ecplicityly passing an argument into the 
 * parameter. Here is an example of a method that has a parameter with
 * a default argument:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void ShowTax(decimal price, decimal taxRate = 0.07m)
 * {
 *		// Calculate the tax.
 *		decinmal tax = price * taxRate;
 *		// Display the tax.
 *		MessageBox.Show("The tax is " + tax.ToString("c"));
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this method definition, a default argument is provided for the 
 * taxRAte parameter. Notice that the parameter name is followed by an 
 * equal sign and a value. The value that follows the equal sign is the 
 * default argument. In this case, the value 0.07m is teh dafault argument 
 * for the taxRate parameter. Because the taxRate parameter has a default
 * argument, we have the option of omitting an argument for it when 
 * we call the method. Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ShowTax(100.0m);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statement calls the ShowTax method, passing the value 100.0m as 
 * the argument for the price parameter. Because we did not pass an 
 * argument into taxRate parameter, its value will be 0.07m. If we
 * want the taxRate parameter to have a different value, we can specify
 * an argument for it when we call the method, as shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ShowTax(100.0m, 0.08m);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This statment calls the ShowTax method, passing 100.0m as the 
 * argument for the price parameter and 0.8m as the argument for the 
 * taxRate parameter.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here are some details to keep in mind when using default arguments:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * Default arguments must be literals or constants. You cannot specify
 * a variable as a default argument.
 * 
 * *You can provide default arguments for all of the parameters in a
 * method. Howeverm when only some of the parameters have a default 
 * argument (as in the previous example), you must declare the 
 * parameters with the default arguments last. For example, a compiler
 * error would occur if we were to write the ShowTax method header as 
 * shown here:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Illegal method header!
 *  private void ShowTax(decimal taxRate = 0.07m, decimal price)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * When a method has several parameters with default arguments and
 * you leave out one of the arguments when you call the method, you have
 * to leave out all the arguments that come after it as well.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Passing Arguments by Value
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * All the example programs that you have looked at so far pass
 * arguments by value. Arguments and paraments variables are separate 
 * items in memory. When an argument is passed by value, only a copy
 * of the argument's value is passed into the parameter variable. If
 * the contents of the parameter variable are changed inside the method
 * , it has no effect on the argument in the calling part of the
 * program.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * For example, the following code comes from the Pass By Value project
 * in the Chap06 folder of this book's Student Sample Programs. When you
 * run the application and click the Go button, you see the sequence
 * of message boxes shown in Figure 6-14.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-14 Sequence of messages displayed by the Pass By Value 
 * application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *	int number = 99;
 *	
 *	// Display the value of number.
 *	MessageBox.Show("The value of number is " + number);
 *	
 *	// Call ChangeMe, passing number as an argument.
 *	ChangeMe(number);
 *	
 *	// Display the value of number again.
 *	MessageBox.Show("The value of number of number is " + number);
 * }
 * 
 * private void ChangeMe(int myValue)
 * {
 *		// Change the value of the myValue parameter.
 *		myValue = 0;
 *		
 *		//Display the value of myValue.
 *		MessageBox.Show("in ChangeMe, myValue is"+myValue);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Inside the goButton_Click event handler, a local variable named 
 * number is declared in line 3 and initialized with the value 99.
 * As a result, the statement in line 6 displays The value of number is 99
 * . The number variable's value is then passed as an argument to the
 * ChangeMe method in line 9. This means that in the ChangeMe method, the
 * value 99 is assigned to the myValue parameter variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After the ChangeMe method finishes, control of the program returns to
 * the goButton_Click event handler. When the statement in line 12
 * executes, the message The value of number is 99 is displayed. Even
 * though the parameter variable myValue was changed in the ChangeMe
 * method, the number variable in the goButton_Click event handler was
 * not modified.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Passing by value works in most situations because arguments are 
 * usually sent to methods for informational purposes only. Typically,
 * when you pass a variable as an argument to a method, you want that 
 * variable to have the same value before and after the method call.
 * Passing an argument by value guarantees that the argument will not
 * be changed by the method it is passed into. Sometimes, however, you 
 * want a method to be able to change the value of a variable that was 
 * passed as an argument to it. This requires a slightly different type
 * of argument passing, which is discussed in the next section.
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				6.4 Passing Arguments by Reference
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * Concept: When an argument is passed by reference to a method can 
 * change the value of the argument in the calling part of the program.
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you want a method to be able to change the value of a variable
 * that is passed to it as an argument, the variable must be passed by
 * reference. In C#, there are two ways to pass an argument by 
 * reference:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	* You can use a reference parameter in the method.
 *	
 *	* You can use an output parameter in the method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Using Reference Parameters
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A reference patameter is a special type of parameter variable. When
 * you pass an argument into a reference parameter, the reference
 * parameter does not receive a copy of the argument's value.
 * 
 * Instead,it becomes a reference to the argument that was passed into
 * it.
 * 
 * Anything that is done to the reference parameter is actually done
 * to the argument that is references.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Refereence parameters are useful for esatablising two-way communication
 * between methods. When a method calls another method and pases an
 * arguemnt by reference, communication between the methods can take
 * place in following ways:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * The calling method can communicate with the called method by
 * passing argument.
 * 
 * * The called method can communicate with the calling method by
 * modifying the value of the argument via the reference parameter.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In C, you declare a reference parameter by writing there keyword
 * before the parameter variable's data type. For example, look at the
 * following method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void SetToZero (ref int number)
 * {
 *		number = 0;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Inside the parentheses, the keyword ref indicates that the number is 
 * a reference variable. The method assigns 0 to the number parameter.
 * Because number is a reference parameter, this action is actully performed on the varable that was passed ti the method as an argument.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call a method that has a reference parameter, you must also write the keyword ref before the argument. THe following code sample shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int myVat = 99; 
 * SetToZero(ref myVar);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement declares myVar as an int variable, initialized
 * with the value 99. Thhe second seatement calls the SettoZero method
 * , passing myVar by reference, After the method call, the myVar
 * variable is set to the value 0.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you pass an argument to a ref parameter, that argument must already
 * be set to some value. For example, if a variable has not been
 * initialized or assigned a value, you cannot pass it as an argument
 * into a ref parameter. The following code sample causes a compiler
 * error
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int myVar;			// Declare myVar With no initial value.
 * SetToZero(refmyVar); // Error! myVar is not set to a value.	
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at a complete protram that uses the SetToZero method,
 * In the Chap06 folder of this book's Student Sample Programs, you
 * will find a project named Pass By Ref. Figure 6-15 shows the 
 * application's form, and Program 6-5 shows thge form's code
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-15 The Pass By Ref application's form
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-5 Code for the Pass By Ref application's form1 form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that the form has a ListBox control named ouputListBox. This
 * ListBox is used to display the program's output. The SetToZero method
 * that we previously discussed appears in line 22-25. The method 
 * accepts an int argument by reference and assigns the value 0 to the
 * argument.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the goButton_Click method, line 30 declares the int variable 
 * x,y, and z and initializes them to the values 99, 100, and 101, 
 * respectively. Line 33 clears the outputListBox control, and lines 34-
 * 36 display the values of the x,y, and z variables in the ListBox.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In lines 39-41 x,y, and z variables are passed as arguments, by 
 * reference, to the SetToZero method. Each time SetToZero
 * is called, the variable that passed as an argument is assigned the 
 * value 0. This is shown when the x, y, and z variables are displayed again
 * in lines 45-47. Figure 6-16 shows the application's form after the Go
 * button has been clicked.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-16 The Pass By Ref application's output
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 *					Using Output Parameters
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * An output parameter works like a reference parameter. When you pass an
 * argument into an output parameter, the output parameter becomes a
 * reference to the argument that is passed into it.
 * Anything that is done to the output parameter is actually done to
 * the argument that it references. Output parameters are different
 * form reference parameters in the following ways:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  *An argument does not have to be set to a value before it is passed
 *  into an output parameter. For example, an uninitialized variable 
 *  can be passed into an output parameter.
 *  
 *  *A method that has an output parameter must set the output
 *  parameter to some value before it finishes executing.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In C#, you declare an output parameter by writing the out keyword
 * before the parameter variable's data type. For example, we could modify
 * the SetToZero method in the following way to make the number
 * parameter an output parameter:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private voude SetToZero(out int number)
 * {
 *		number = 0;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call a method that has an output parameter, you must also
 * write the keyword out before the argument.
 * 
 * The following code sample shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * int myVar;
 * SetToZero(out myVar);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first statement declares myVar as an uninitialized int variable.
 * The second statement calls the SetToZero method, passing myVar into 
 * the output parameter. After the method call, the myVar variable is
 * set to the value 0.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 6-3 gives you some experience writing a method that uses an
 * output parameter.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Turoial 6-3: Using an Output Parameter
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the North America application that is 
 * found in the Chap06 folder of this book's Student Sample Programs.
 * The application's form has already been created ans is shown in 
 * Figure 6-17. The application also has an accompanying text file named
 * NorthAmerica.txt that is stored in the Chap06 folder.
 * The NorthAmerica.txt file contains the names of the countries of 
 * north America.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-17 The North America application;s form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the completed application runs an d the user clicks the Get
 * Countries button, the application uses an OpenFIleDialog control
 * to let the user select a file.
 * 
 * The application reads each country named from the file and adds each
 * one to the countriesListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named North America in
 * the Chap06 folder of this book's Student Sample Programs.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 2: Open Form1 in the Designer and add an OpenFIleDialog control
 * to the form.
 * Change the contol's name to openFile and clear the contents of the
 * control's Filename property.
 * /////////////////////////////////////////////////////////////////////
 *
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 3: Open the form1 form's code in the code editor. Insert the 
 * using System.IO; directive shown in line 10 of Program 6-6 at the
 * end of this tutorial. This statement is necessary because you will
 * be using the StreamReader class, which is part of the System.IO
 * namespace in the .NET Framework.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Type the comments and code for the GetFileName method, shown in 
 * lines 21-34 of Programs 6-6. The purpose of the GetFileName method is
 * to let the user select the file that should be opened. Let's take
 * a closer look at the code.
 * 
 *	Line 24: This is the beginning of the method. The method has a string
 *	output parameter named selectedFile. When we call the method, we pass
 *	a string variable as an argument. The method lets the user select 
 *	the file that should be opened and stores its filename and path in 
 *	the selectedFile parameter.
 *	
 *	Line 26-33: This if statement calls the openFile control's
 *	ShowDialog method. If the user clicks the Open button, the method 
 *	returns the value DialogResult.OK, and line 28 assigns the name of the
 *	selected file to the selectedFile parameter. If the user clicks the
 *	Cancel button  line 32 assigns an empty string to  the selectedFile
 *	parameter.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Type the comments and code for the GetCountries method, shown
 * in lines 36-70 of Program 6-6. In a nutshell, this method accepts a
 * filename as an argument, reads the contents of the specified file,
 * and adds them to the countruesListBox control. Here is a more
 * detailed description of each part of the method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Line 41: This statement declares the string variable countryName,
 * which holds the lines of text that are read from the file.
 * 
 * Line 44: Thisi statement declares the string variable countryName,
 * which holds the lines of text that are read from the file.
 * 
 * Line 47: This statement declares the StreanReader variable inputFile.
 * 
 * Line 50: After this statement has executed, the file specified by
 * the filename parameter is opened for reading, and the inputFile
 * variable references a StreamReader object that is associated with
 * the file
 * 
 * Line 53: This statement clears anything that might be displayed 
 * in the countriesListBox control.
 * 
 * Line 56: This is the beginning of a while loop that iterates as
 * long as the end of the file has bot been reached.
 * 
 * Line 59: This statment reads a line of text from the file assigns
 * it to the countryName variable.
 * 
 * Line 62: This statement adds the contents of the countryName
 * variable to the ListBox.
 * 
 * Line 66: This statement closes the file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step: 6 Open the Form in the Deigner. Double-click the
 * getCountriesButton control. This opens the code editor,
 * and you will see an empty event handler named
 * getCountriesButton_Click.
 * 
 * Complete the getCountriesButton_Click event handler by typing the
 * code shown in lines 77-83 in Program 6-6. :et's take a closer look
 * at the code: 
 * 
 * Line 77: This statement declares a string variable named filename.
 * 
 * Line 80: This state,emt calls the GetFileName method, passing the 
 * filename variable as an argument. When the method returns, the 
 * filename variable contains the name of the file selected by the 
 * user.
 * 
 * Line 83: This statement calls the GetCountries method, passing the
 * filename variable as an argument, The method opens the specified
 * file and fills the countriesListBox control with its contents.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step: 7 Switch your view back to the Designer and double-click the 
 * exitButton control. In the code editor you will see an empty event
 * handler named exitButton_Click. Complete the exitButton_Click
 * evenbt hgandler by typing the code shown in lines 88-89 in Program
 * 6-6.
 * /////////////////////////////////////////////////////////////////////
 *
 * /////////////////////////////////////////////////////////////////////
 * Step 8: Save the project. Then, press F5 on the keyboard or click the
 * Start Debugging button (|>) on the toobar to compile and run the 
 * application. When the application runs, click the Get Countries button
 * . An Open dialog box should appear. Navigate to the Chap06 folder in the
 * Student Sample Programs, select the NorthAmerica.txt file, and click
 * the Open button. This should fill the ListBox with the names of the
 * countries from the selected file, as shown in Figure 6-18.
 * 
 * Click the
 * Exit button to exit the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-18 The North America application displaying the list of
 * countries
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *			 6.5 Value-Returning Methods
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: A value-returning method that returns a value to the part
 * of the program that called it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A value-returing method is like a void method in the flllowing ways:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	*It contains a group of statements that perform a specific task.
 *	
 *	* When you want to execute the method, you call it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a value-returning method finishes, however, it returns a value to 
 * the statement that called it. The value that is returned from a method
 * can be used like any other value: It can be assigned to a variable,
 * displayed on the screen, used in a mathemeatical expression (If is a 
 * number), and so forth.
 * /////////////////////////////////////////////////////////////////////
 *
 * /////////////////////////////////////////////////////////////////////
 * You have already used many of the value-returning methods that are
 * in the .NET Framework, For example, the int.Parse method accepts a 
 * string as an argument and returns the value of the string converted
 * to an int.
 * 
 * Let's review how that method works. In the following statment,
 * assume number is an int variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number = int.Parse("100");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The part of the statement that reads int.Parse("100") is a call to the
 * int.Parse method, with the string "100" passed as an argument. Figure
 * 6-19 illustrates this part of the statement.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-19 A statement that calls the int.Parse method
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that the call to the int.Parse method appears on the right side
 * of an = operator. When the method is called, it returns an integer. The
 * integer that is returned is assigned to the number variable, as shown
 * in Figure 6-20.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-20 The int.Parse method returns a value
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Writing Your Own Value-Returning Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You write a value-returning method in the same way that you write a 
 * void method, with two exceptions:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * You must specify a data type for a value-returning method.
 *   The value that i sreturned from the method must be of 
 *   the specified data type.
 * 
 * * A value-returning method must have a return statement. The return
 * statement causes a value to be returned from the method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the general format of a value-returning methods definition
 * in C#:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * AccessModifier DataType MethodName (ParameterList)
 * {
 *		Statement;
 *		Statement;
 *		etc.
 *		return expression;
 * 
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * AcessModifier is an access modifier such as private or public
 * 
 * * DataTypes is the data types of the value that the method returns. 
 * we commonly call this the method's return type. For example, if the 
 * the method returns an integer, the word int appears here, If the method
 * returns a double value, then the word double appears here. Likewise, if
 * the method returns a decimal value, the word decinmal appears here.
 * 
 * * MethodName is the name of the method.
 * 
 * * ParameterList is an optional parameter list. If the method does not accept
 * arguments, then an empty set of parentheses appears.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * One of the statements inside the method must be a return statement,
 * which takes the following form:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * return expression;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The value of the expression that follows the keyword return is sent 
 * to the statment that cfalled the method. This can be any value, or
 * expression that has a value (such as a math expression). The value 
 * that is returned must be the same data type as that specified in the 
 * method header or a compiler error will occur.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is an example of a value-returning method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private int Sum (int num1, int num2)
 * {
 *		return num1+num2;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-21 illustrares the various parts of the method header. 
 * Notice that thet method returnd an int, the mehtod's name is sum, and
 * the method has two int parameters named num1 and num2.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-21 Parts of the method header
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The purpose of this method is to accept two int values as arguments and 
 * return their sum. Notice that the return statement returns the value of the 
 * expression num1+num2. When the return statement executes, the method
 * ends its execution and sends the value back to the part of the
 * progran that called the method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at a comlete program that demonstrates the Sum method. In
 * the Chap06 folder of this book's Students Sample Programs, you will 
 * find a project named Sum. Figure 6-22 shows the application;s form,
 * and Program 6-7 shows thge form's code. When you run the application,
 * you enter two integer into the age1TextBox and age2TextBpx controls.
 * When you click the Calculate Age button, the sum of the two integers is 
 * displayed in the combinedAgeLabel control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-22 The Sum application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-7 Code for the Sum application's Form1 form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In line 33, the value entered into the age1TextBox control is converted 
 * to an int and stored in the userAge variable,. In line 36, the 
 * value entered into the age2TextBox control is converted to an int and 
 * stored in the firendAge variable.
 * 
 * Line 39 passes the userAge and
 * firendAge varialbes as arguments to the Sum method. 
 * The sum of the two variables is returned from the method and
 * assigned to the combinedAge variable.
 * 
 * In line 42 the value of the combinedAge variable is converted to a 
 * string and fisplayed in the combinedAgeLAbel control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-23 Arguments passed to sum and a value returned
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call a value-returning method, you usually want to do 
 * something meaningful with the value it returns. In line 39 of Program
 * 6-7 the value that is returned from the Sum method is assigned to a
 * variable. This commonly how return values are used, but you can do
 * many other things with them. For example, the following code shows
 * a math expression that uses a call to the Sum method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int x = 10, y = 15;
 * double average;
 * average = Sum(x,y) / 2.0;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the last statement, the Sum method is called with x and y as its 
 * arguments. The method's return value, which is 25, is divided by 2.0.
 * The result, 12.5, is assigned to average. Here is another example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int = 10, y=15;
 * MessageBox.Show("The sum is " + Sum(x,y));
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This code sends the Sum method's return value to MessageBox.Show,
 * so it can be displayed on the screen. The message The sum is 25 is
 * diplayed. Remember, a value-returning method returns a value of a
 * specific data type. You can use the method's return value anywhere
 * that you can use a regular value of the same data type. This means
 * that anywhere an int value can be used , a call to an int value-returning
 * method can be used. Likewise, anywhere a double value can be used, a call
 * to a double value value-returning method can be used. The same is true
 * for all other data types.
 *
 * /////////////////////////////////////////////////////////////////////
 * In Tutorial 6-4, you complete an application that converts a value
 * from one unit of measurement to another. The code will use a value-
 * returning method to perform the conversion.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 6-4: Writing a Value-Returning Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Cups and fluid ounces are common units of measurment of food items.
 * Sometimes, when a recipe for an item measured in cups, you find in the 
 * frocery store the item is sold in fluid ounces. To know how much you 
 * need to purchase for the recipe, you need to convert the required
 * number of cups to fluid onces. The formula is:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-24 The Cups To Ounces application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Cups to Ounces
 * in the Chap06 folder of this book's Student Sample Program.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 2: Open the Form1 form in the Designer. The form is shown, along
 * with names of important contols, in Figure 6-24.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 3: Program 6-8, at the end of this tutorial, shows the form's
 * completed code. Open the code editor and type the comments and code for the 
 * CupsToCounces method shown in lines 20-26 of Programs 6-8. The purpose
 * of the method is to accept a number of cups as an argument and return
 * that value converted to fluid ounces. You can see in line 23 that the
 * method has a double parameter named cups, and in line 25 method
 * returns the value of cups multiplied by 8.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Now you will create the click event handlers for Button
 * controls. Switch back to the Designer and double-click the
 * convertButton control. This opens the code editor, and you will see
 * an empty event handler named convertButton_Click. Complete the
 * convertButton_Click event handler by typing the code shown in lines
 * 30-46 in Program 6-8. Let's review this code:
 * 
 * Line 31: This statement declares the cups and ounces variables, which
 * hold the number of cups and ounces.
 * 
 * Lines 34-46: The if statement in line 34 converts the cupsTextBox control's
 * Text property to a double, and the result is stored in the sups variable.
 * If the conversion is successful, line 37 calls the CupsToOunces method,
 * passing cups as an argument. The value that is returned from the method
 * is assigned to the ounces variables, and in line 40 the value of the ounces
 * variable is displayed in the ouncesLabel control. If the conversion is not
 * sucessful, line 45 displays an error message.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Switch your view back to the Designer and double-click the
 * exitButton control.
 * 
 * In the code editor you will see an empty handler named
 * exitButton_Click. Complete the exitButton_Click event 
 * handler by typing the code shown in lines 51-52
 * in Program 6-8.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 6: Save the project. Then, press F5 on the keyboard, or click
 * the Start Debugging button (|>) on the toolbar to compile and run 
 * the application. When the application runs enter the value 1 into the
 * cupsTextBox control and click the Convert button. The application
 * should display 8.0 as the number of fluid ounces. Continue to test 
 * the application with other values. When you are finished, click the
 * exit the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-8 Completed from Form1 in the Cups To Ounces application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Boolean Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A Boolean method returns either true or false. You can use a Boolean
 * method to text condition, and then return either true or false to indicare 
 * wither the codition exists. Boolean method are useful for simplifying
 * complex conditions that are tested in decision and reptition structures
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * For example, suppose you are writing a program that will ask the user enter
 * a number and then determine whether that number is even or odd. the
 * following code shows how can you make that determination. Assume number
 * is an int variable containing the number entered by the user.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(number % 2 == 0)
 * {
 *		MessageBox.Show("The number is even.");
 * }
 * else
 * {
 *		MessageBox.Show("The number is odd.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The meaning of the Boolean expression being tested by this if-else
 * statement is not clear, so let's take a closer look at it:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number % 2 == 0
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This expression uses the % operator, which was introduced in Chapter
 * 3. Recall that the % operator divides two integers and returns the remainder
 * of the division. So, this code is saying, if the remainder of 
 * number divided by 2 is equal to 0, then display a message indicating a
 * message indicating the number is event, or else display a message
 * indicating the number is odd.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because dividing an even number by 2 always gives a remainder of 0,
 * this logic work. The code would be easier to understand, however, if
 * you could somehow rewrite it to say, if the number is even, then display a 
 * message indcating it is even, or else display a message indicating
 * it is odd. As it turns out, this can be done with a Boolean method. In this
 * example, you could write a Boolean method named IsEven that accepts an int as
 * an argument and returns true id the number is even or false otherwise. Here
 * is an example how the IsEven method might be written:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private bool IsEven(int number)
 * {
 *		// Locala variable to hold true or false
 *		bool numberIsEven;
 *		
 *		// Deterkine whether the number is even
 *		if(number % 2 == 0)
 *		{
 *			numberIsEven = true;
 *		}
 *		else
 *		{
 *			numberIsEven = false;
 *		}
 *		
 *	// Return the result.
 *	return numberIsEven;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 6-5: Modularizing Inupt Validation with a Boolean Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In addition to regular pay, a company pays its employee an annual
 * bonus. The company also contributes 5 percent of an employee's total
 * compensation(gross pay plus bonus) to a retirement account. In this
 * tutorial, you complete an application that lets you enter an
 * employee's gross pay and bonus amount and calculates the amount of 
 * retirement contribution. The project is named Pay and Bonus and is 
 * found in the Chap06 folder of this book's Student Sample Programs.
 * Figure 6-25 shows the application's form, which has already been created 
 * for you.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-25 The Pay and Bonus application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Pay and Bonus in
 * the Chap06 folder of this book's Student Sample Programs.
 * 
 * Step 2: Open the Form1 form's code in the code editor. Insert the 
 * comment and constant field declaration shown in lines 15 and 16 of 
 * Program 6-9. This constant, which is set to the value 0.05, is used in
 * the calculation of the retirement account contribution.
 * 
 * Step 3: Type the comments and code for the InputIsValid mehod is to get
 * the values entered by the user, convert them to decimal values, and 
 * assign them to the parameter variables. If the pay and the bonus amount.
 * The purpose of the method is to get the values entered by the user, convert
 * them to decimal values, and assign them to the parameter variables. If the 
 * input us successfully converted, the method returns true. Otherwise an error
 * message is displayed and the method returns false to indicate that the input is 
 * not valid.
 * 
 * Step 4: Open the Form1 form in the Designer. Double-click the calculateButton control.
 * THis open the code efitor, and you will see an empty event handler named 
 * calculateButton_CLick. Complete the calcuateButton_Click event handler by typing 
 * 'the code shown in lines 58-69 in Program 6-9. Let's take a closer look at the code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Line 59: This statment declares decmimal variables to hold the 
 * gross pay, bonus amount , and contiibution amount.
 * 
 * Lines 61 - 68: This if statement calls the InputIsValid method, passing the 
 * grosspaty and bonus variables by reference, as arguments. If the method 
 * returns true, the variables will contain the gross pay and bonus amount
 * entered by the user. In that case, line 64 calcuates the amount of
 * contribution to the retirement account, and line 67 displays that
 * amount.
 * 
 * Step 5: Switch your view back to the Designer and double-click the 
 * exitButtonb control. In the code editor you will see an empty handler
 * named exitButton_CLick. Complete the exitButton_Click event handler
 * by typing the code shown in lines 73-74 in Program 6-9.
 * 
 * Step 6: Save the project. THen, press F5 on the keyboard or click the
 * Start Debugging button(|>) on the toolbar to compiler and run the application.
 * 
 * When the applcaiton runs, enter 80000 for the gross pay and 20000 for the bonus amount. 
 * Click the Calculate Contribution button. The applcation should display $5,000.oo as 
 * the amount of contribution. Try other values if you wish. Click the Exit button
 * to exit the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-9 Completed code for Form1 in the Pay abd Bonus application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Returning a String from a Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * So far, you've seen examples of methods that return numbers and 
 * Boolean values. You can write methods that retuen any type of data.
 * Let's look at an example program that uses a string-returing method.
 * 
 * The Chap06 folder of this book's Student Sample Programs contains 
 * a project named Full Name. Figure 6-26 shows the application's form,
 * and Program 6=10 shows the form's code. When you run the applcation,
 * you enter your first name, middle name, and last name into the 
 * TextBox controls. When you click the ShowFullName button, your full name
 * is displayed in the fullNameLabel control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  Figure 6-26 The Full Name application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 6-10 Code for the Full Name application's Form 1 form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Lines 23-26 define a method named FullName. Notice the following things 
 * about the method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *return type is string.
 * 
 * *It has three string parameters:first, middle, and last. When we call 
 * the method we pass a first name, a middle name, and a last name as 
 * arguments.
 * 
 * 
 * *In line 25 it returns a string that is the concatenation of the
 * fitst middle, and last parameters, with spaces inserted between each.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-27 shows an example of the application's form after the user
 * has entered names into each TextBox and click the Show FUll Name
 * button.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 6-27 Example output of the Full Name application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *						6.6 Debugging Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: Visual Studio debugging commands allow you to single-step
 * through applications with methods. The Step Intp commanee allows you 
 * you single-step through a called method. The Step Over command allows 
 * you to execute a method call without single-stepping through its lines
 * The Step Out command allows you to execute all remaining liens of a method 
 * that you are debugging without stepping through them.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Chapter 3, you learned to set a breakpoint in your application's
 * code and to single-step through the code's execution. Let's find out
 * how to step into or step over a method, and step out of a method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When an application is in break mode, the Step Into command causes
 * the current highlighted line (the execition point) to execute. If 
 * that line contains a call to a method, the next hightlighhted line
 * is the first line in that method. IIn other words, the Step Into
 * command allows you to single-step through a method when it is 
 * called. Activate the Step Into comman using one of the following 
 * procedures:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Press the F11 key
 * 
 * *Select Debug from the menu bar, and then select Step Into from the
 * Debug menu
 * 
 * *Click the Step Into button (;) on the Debug Toolbar, if the toolbar is
 * visible
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Like the Step Into command, the Step Over command causes the currently
 * highlighted line to execute. If the line contains a method call, however
 * , the method is executed without stepping through its statements. Activate
 * the Step Over command using one of the followiong procedures:
 * 
 *		*Press the F11 key.
 *		
 *		* Select Debug from the menu bar, and then select Step into from the
 *		Debug menu.
 *		
 *		*Click the Step Into button (;) on the Debug Toolbar, if the toolbar
 *		is visable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Like the Step Into command, the Step Over command causes the
 * currently highlighted line to execute. If the line contains 
 * a method call, however, the method executed without stepping through its
 * statements. Activate the Step Over command using One of the
 * following precedures:
 * 
 * * Press the F11 key
 * 
 * * Select Debug from the menu bar, and then select Step Into from the Debug menu
 * 
 * *Click the Steo into button (;) on the Debug Toolbar, if the toolbar is 
 * visible
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Like the Step Into command, the Step Over command causes the currently
 * highlighted line to execute. If the line contains a method call,
 * however, the method is executed without stepping through its
 * statements. Activate the Step Over command using one of the following
 * precedures:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * Press the F10 key
 * 
 * *Select Debug from the menu bar, and then select Step Over from the
 * Debug menu.
 * 
 * *Click the Step Over button (.->) on the Debug Toolbar if the toolbar
 * is visible.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Use the Step Out command when single-stepping through a method if you
 * want the remainder of the method to complete execution without
 * single-stepping. After the method has completed, the line following 
 * the method call is heighlighted, and you may resume single-stepping.
 * Activate the Step Out command using one of the following procedures:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Press the Shift + F11 keys
 * 
 * *Select Debug from the menu bar, and then select Step Out from the
 * Debug menu.
 * 
 * *Click the Step Out button (^) on the Debug Toolbar if the toolbar is
 * visible.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tip: Visual Studio can be configured in different ways. Under some
 * configurations, the Step Into command might be activate by the F8
 * function key. Similarly, under some congfigurations the Step Over
 * command
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////