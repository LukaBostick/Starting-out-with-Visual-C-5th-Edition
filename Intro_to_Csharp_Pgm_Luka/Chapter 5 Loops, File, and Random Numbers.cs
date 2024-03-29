	
namespace Chapter5LoopsFileandRandomNumbers
{
	class Test
	{
		static void Main(string[] args)
		{

		}
	}
}

/* /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				Chapter 5 Loops, Files and Random Numbers
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *							Topics
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	*5.1 More about ListBoxes
 *	
 *	*5.2 The while Loop
 *	
 *	*5.3 The ++ and -- operators
 *	
 *	*5.4 The for Loop
 *	
 *	*5.5 The do-while Loop
 *	
 *	*5.6 Using Files for Data Storage
 *	
 *	*5.7 The OpenFIleDialog and SaveFileDialog Controls
 *	
 *	*5.8 Random Numbers
 *	
 *	*5.9 The Load Event
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				5.1 More about ListBoxes
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *		Concept ListBox controls have various methods and properties that
 *		you can use in code to manipulate the ListBox's contents.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Chapter 4, we introduced the ListBox control, which displays a 
 * list of items and allows the user to select one or more items from the
 * list. In this chapter, we will use ListBox controls to display output.
 * Many of the algorithms that you will see in this chapter generate lists
 * of data and then display those lists in ListBox controls.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Recall from Chapter 4 that you add items to a ListBox control's Items
 * property, and those are displayed in the ListBox. At design time, you
 * can use the Properties window to add items to the control's Item
 * property. You can also write code that adds items to a ListBox control
 * at run time. To add an item to a ListBox control with code, you call the
 * control's Items.Add method. Here is the method's general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					ListBoxNames.Add(Item);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ListBoxName is the name of ListBox control. Item is the value to be 
 * added to the Items property. For example, in the Chap05 folder of 
 * this book's Student Sample Programs, you will find a project named
 * Name List. Figure 5-1 shows the application's form at run time. As 
 * shown in the image on the left, the ListBox's name is nameListBox and
 * the Button control's name is addButton. At run time, when you click
 * the addButton control, the names shown in the image on the right are
 * added to the nameListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-1 The Name List application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  Here is the code for the addButton_Click event handler:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void addButton_Click(object sender, EventArgs e)
 * {
 *		namesListBoxes.Items.Add("Chris");
 *		namesListBoxes.Items.Add("Alicia");
 *		namesListBoxes.Items.Add("Justin");
 *		namesListBoxes.Items.Add("Holly");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can add values of other types as well. In the chap5 folder 
 * of the book's Student Sample Program, you will find a project named
 * Number List. Figure 5-2 shows the application's form. As shown in the 
 * image on the left, the ListBox's name is numberListBox and the Button
 * control's name is addButton. At run time, when you click the addButton
 * control, the numbers shows in the image on the right are added to the 
 * numberListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *				Figure 5-2 The Number List application 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the code for addButton_CLick event handler:
 * 
 * private void addButton_Click(object sender, EventArgs e)
 * {
 *		namesListBoxes.Items.Add(10);
 *		namesListBoxes.Items.Add(20);
 *		namesListBoxes.Items.Add(30);
 *		namesListBoxes.Items.Add(40);
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					The Items.Count Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ListBox controls have an Items.Count property that reports the number
 * of items stored in the ListBox. If the ListBox is empty, the Items.
 * Count property equals 0. For example, assume an application has a 
 * ListBox control named employeesListBox. The following if statement
 * displays a message box if there are no items in the ListBox:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(employeesListBox.Items.Count == 0)
 * {
 *		MessageBox.Show("There are no items in the list!");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Items.Count property haolds an integer value. Assuming
 * numEmployees is an int variable, the following statement assigns the 
 * number of items in the employeesListBox to the numEmployees variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	numEmployees = employeesListBox.Items.Count;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Items.Clear Method
 * /////////////////////////////////////////////////////////////////////
 * ListBox controls have an Items.Clear method that erases all the items
 * in the property. Here is the method's general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ListBoxName.Items.Clear();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * For example, assume an application has a ListBox control named 
 * employeesListBox. The following statement clears all the items in the
 * list:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * employeesListBox.Items.Clear();
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *						5.2 The while Loop
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: The while loop causes a statement or a set of statements to
 * repeat as long as a Boolean expression is true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The while loop gets its name from the way it works: While a Boolean
 * expression is true, do some task. 
 * The loop has two parts:(1) a Boolean expression that is tested for a 
 * true or false value and (2) a statement or set of statements that is 
 * repeated as long as the Boolean expression is true. Figure 5-3 shows
 * the logic of a while loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-3 The logic of a while loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The diamond symbol represents the Boolean expression that is tested.
 * Notice what happens if the expression is true: one or more statements 
 * are executed and the program's execution flows back to the point just
 * above the diamond symbol. The Bollean expression is tesed again, and 
 * if it is true, the preocess repeats. If the Boolean expression is false,
 * the program exits the loop. Each time the loop executes its statement 
 * or statements, we say the loop is iterating, or preforming an iteration
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the general format of the while loop:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(Boolean Expression)
 * {
 *		statement;
 *		statement;
 *		etc.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We refer to the first line as the while clause. The while clause begins
 * with the word while, followed by a Boolean expression that is enclosed 
 * in parentheses. Beginning on the next line is a set of statements 
 * enclosed in curly braces. THis block od statements is known as the
 * body of the loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the while loop executes, the Boolean expression is tested. If 
 * the Boolean expression is true, the statements that appear in the 
 * body of the loop are executed, and then the loop starts over. If the
 * Boolean expression is false, the loop ends and the program resumes
 * execution at the statement immediately following the loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We say that the statements in the body of the loop are conditionally
 * executed because they are executed only under the condition that the 
 * Boolean expression is true. if you are writing a while loop that has 
 * only one statement in its body, you do not have to enclose the
 * statement  inside curly braces. Such a loop can be written in the 
 * following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(BooleanExpression)
 *	statement;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a while loop written in this format executes, the Boolean
 * expression is tested. If it is true, the one statement that appears
 * on the next line is executed, and then the loop starts over. IF the 
 * Boolean expression if false, however, the loop ends.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Althought the curly braces are not required when there is only one 
 * statement in the loop's body, it is still a good idea to use them,
 * as shown in the following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(BooleanExpression)
 * {
 *		statement;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When we discussed the various if statements in Chapter 4, we mentioned
 * that this is a good style of programming because it cuts down on errors.
 * 
 * IF you have more than one statement in the body of a loop, those
 * statements must be enclosed in curly braces. IF you get into the habit
 * of always enclosing the conditionally executed statements in a set of 
 * curly braces, it's less likely that you will forget them.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You should also notice that the statments in the body of the loop
 * are indented. As with if statements, the indentation makes the code 
 * easier to read and debug. By indenting the statements in the body
 * of the loop, you visually set them apart from the surronding code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at an example. In the CHap 5 folder of this book's Student
 * Sample Programs, you will find a project named while Loop Demo. Figure
 * 5-4 shows the application's form at run time. As shown in the image
 * on the left, the Button control's name is goButton. At run time, when 
 * you click the goButton control, the message box shown in the image on 
 * the right is displayed. When you click the OK button to close the 
 * message box, another identical message bos is displayed. The message
 * box is displayed a total of five times.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-4 The while Loop Demo application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Were is the code for the goButton_Click event handler:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *		// Declare a variable to count the loop iterations.
 *		int count = 1;
 *		
 *		// Display "Hello" in a message box five times.
 *		
 *		while(count <= 5)
 *		{
 *			//Display the message box.
 *			MessageBox.Show("Hello");
 *			
 *			// Add one to count.
 *			count = count + 1;
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at this code. In line 4 an int variable 
 * named count is declared and initialized with the value 1. A while loop
 * begins in line 7. Notice that the while loop tests the expression
 * count <= 5. The statementes in the body of the while loop repeat as 
 * long as the count variable is less than or equal to 5. Inside the body
 * of the loop, line 10 displays "Hello" in a message box, and then line
 * 13 adds one to the count variable. This is the last statement in the
 * body of the loop, so after it executes, the loop starts over. IT tests
 * the Boolean expression again, and if it is true, the statements in the 
 * body of the loop are executed. This cycle repeats until the Boolean
 * expression count <=5 is false, as illustrated in Figure 5-5. A 
 * flowchart for the loops is shown in Figure 5-6.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-5 The while Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-6 Flowchart for the while Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The while Loop Is a Pretest Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The while loop is known as a pretest loop, which means it tests its
 * condition before performing an iteration. Because the test is done at
 * the beginning of the loop, you usually have to perform some steps
 * prior to the loop to make sure that the loop executes at least once.
 * Notice the declarations of the count variable in the while loop Demo 
 * program:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int count = 1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The count variable is initialized with the value 1. If count had been
 * initialized with a value that is greater than 5, as shown in the 
 * following program sample, the loop would never execute:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *		// Declare a variable to count the loop iterations.
 *		int count = 6;
 *		
 *		// Display "Hello" in a message box five times.
 *		
 *		while(count <= 5)
 *		{
 *			//Display the message box.
 *			MessageBox.Show("Hello");
 *			
 *			// Add one to count.
 *			count = count + 1;
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * An important characteristic of the while loop is that the loop will 
 * never iterate if the Boolean expression is false to start with. If you
 * want to be sure that a while loop executes the first time, you must
 * initialize the relevant data in such a way that the Boolean expression
 * starts out true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	Counter Variables
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the while Loop Demo application, the variable count is initialized
 * with the value 1, and then 1 is added to the variable count during 
 * each loop iteration. The loop executes as long as count is less than
 * or equal to 5. The variable count is used as a counter variable, which
 * means it is regularly incremented in each loop iteration. In essence,
 * the count variable keeps count of the number of iterations of the 
 * loop performed. Counter variables are commonly used to control the 
 * number of times that a loop iterates.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-1 will give you some practive writing a loop and using 
 * a counter variable. In the tutorial, you will write a while loop that 
 * calculates the amount of interest earned by a bank account each month
 * for a number of months.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-1: Using a Loop to Calculate an Account Balance
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Ending Balance application. The 
 * project has already been started for you and is located in the Chap05
 * folder of this book's Student Sample Programs.
 * The application's form is shown in Figure 5-7
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-7 The Ending Balance form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you complete the application, it will allow the user to enter an
 * account's starting balance into the startingBalTextBox control and the
 * number of months that the account will be left to earn interest into
 * the monthsTextBox control. When the user clicks the calculateButton
 * control, the application calculates the account's balance at the end
 * of the time period. The account's monthly interest rate is 0.005 and 
 * the interest is compounded monthly.
 * 
 * Step 1: Start Visual Studio. Open the project named Ending Balance in
 * the Chap05 folder of this book's Student Sample Programs.
 * 
 * Step 2: Open the Form1 form in the Designer. The form is shown, along
 * with the names of the important controls, in Figure 5-7.
 * 
 * Step 3:Now you will create the Click event handlers for the Button 
 * controls. At the end of this tutoral, Program 5-1 shows the 
 * completed code for the form. you will be instructed to refer to 
 * Program 5-1 as you write the event handlers.
 * 
 * In the Designer, double-click the calculateButton control. This opens
 * the code editor, and you will see an empty event handler named
 * calculateButton_Click. Complete the calculateButton_Click event
 * handler by typing the code shown in lines 22-59 in Programs 5-1.
 * 
 * Let's take a closer look at the code:
 * 
 * Line 23: This statement declares a constant decimal named 
 * INTEREST_RATE, set to the value 0.005. THis is the monthly interest
 * rate.
 * 
 * Lines 26-28: These statements declare the following variables:
 *		* balance, a decimal variable to hold the account balance.
 *		
 *		* months, an int variable to hold the number of months that the 
 *		  account will be left to earn intrest.
 *		
 *		* count, an int that is used to count the months as as a loop
 *		  iterates. Notice that the count variable is initialied with
 *		  the value 1.
 *		  
 * Line 31: This if statement tries to convert startingBalTextBox.Text to
 *			a decimal. If the conversion is successful, the result is 
 *			stored in the balance variable, and the program continues
 *			executing at line 33. If the conversion is not successful, 
 *			the program jumps to the else clause in line 55, and line 58
 *			displays the error messsage invalid value for starting 
 *			balance.
 *			
 * Line 34: This if statement tries to convert monthsTextBox.Text to an
 * int. IF the conversion is successful, the result is stored in the 
 * months variable, and the program continues executing at line 36. If 
 * the conversion is not successful, the program jumps to the else clause
 * in line 49, and line 52 displays the error message invalid value for
 * months.
 * 
 * Line 37: This is the beginning of a while loop. The loop executes as
 * long as the expression count <= months is true.
 * 
 * Lines 39-43: These statements are the body of the loop. Line 40 
 * calculates the monthly interest and adds it to the balance variable.
 * Line 43 adds 1 to the count variable.
 * 
 * Line 47: This statement executes after the loop has finished all of 
 * its iterations. It converts the value of the balance variable to a
 * string (formatted as currency) and assigns the resulting string to
 * the endingBalanceLabel control's Text property.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Switch your view back to the Designer and double-click the
 * clearButton control. In the code editor you will see an empty event
 * handler named clearButton_Click. Complete the clearButton_Click event
 * handler by typing the code shown in lines 64-70 in Program 5-1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Switch your view back to the Designer and double-click the 
 * exitButton control. In the code editor you will see an empty event
 * handler named exitButton_CLick. Complete the exitButton_Click event
 * handler by typing the code shown in lines 75-76 in Program 5-1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 6: Save the project. Then, press f5 on the keyboard, or click
 * the Start Debugging button(|>) on the toolbar to compile and run the 
 * application. First, enter 1000 as the starting balance and 48 as the 
 * number of months. Click the Calculate Average button and $1,270.49
 * should appear as the ending balance. Think about the value that you 
 * entered for the number of months. How many times did the while loop
 * in line 36 iterate? (Answer: 48 times.)
 * 
 * Next click the Clear button to clear the TextBoxes and the ending
 * balance. How many times did the while loop iterate this time?
 * (Answer: 1 time.) Continue to test the application as you wish.
 * When you finished, click the Exit button and the form should close.
 * 
 * (IF you plan to continue to the next tutorial, leave this project open
 * in Visual Studio.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-2: Enhancing the Ending Balance Application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you enhance the Ending Balance application that
 * you created in Tutorial 5-1. First, add a ListBox control to the 
 * application's form, as shown in Figure 5-8. Then modify the
 * calculateButton_Click event handler so it displays each month's ending
 * balance in the ListBox. Figure 5-9 shows as example of how the form will
 * appear at run time, when the user has entered 1000 for the starting
 * balance and 8 for the months.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-8 The modified Ending Balance form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-9 Example output
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio and open the Ending Balance project that
 * you completed in Tutotial 5-1.
 * 
 * Step 2: Enlarge the form so it is roughly the size shown in Figure
 * 5-8. (310 x 325.)
 * 
 * Step 3: Create a ListBox control named detailListBox. Resize the 
 * ListBox as shown in Figure 5-8.
 * 
 * Step 4:Switch to the code editor and insert the code shown in lines
 * 42-45 in Program 5-2.) (The new lines of code are shown in bold.) The
 * statement in lines 43-45 adds a string to the detailListBox control.
 * If you examine the statement carefully, you will see that is uses 
 * concatenation to create a string in the following format:
 * The ending balance for month count is balance.
 * IN the actual string that is created, count will be the value of the 
 * count variable and balance will be the value of the balance variable,
 * formatted as currency.
 * 
 * Step 5:Find the clearButton_Click event handler in the code editor. 
 * Update the comment as shown in lines 69-70, and insert the line of
 * code shown in line 74. (The lines are shown in bold.) The statement in
 * line 74 clears the contents of the detailListBox control.
 * 
 * Step 6: Save the project. Then, press F5 on the keyBoard or click the 
 * Start Debugging button(|>) on the toolbar to compile and run the
 * application. As shown in Figure 5-9, enter 1000 as the starting 
 * balance and 8 as the number of months. Click the Calculate Average
 * button. Your output should look like that shown in Figure 5-9. Click
 * the Clear button and enter any other values you wish to test the 
 * application further. When you are finished, click the Exit button and
 * the form should close.
 * /////////////////////////////////////////////////////////////////////
 * 
 *  * /////////////////////////////////////////////////////////////////////
 * Program 5-1 Completed Form1 code for the Ending Balance application
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Ending_Blance
 * {
 *		public partial class Form1 : form
 *		{
 *			public Form1()
 *			{
 *				InitializeComponent();
 *			}
 *			
 *			private void calculateButton_Click(object sender, EventAtgs e)
 *			{
 *				// Constant for the monthly insterest rate.
 *				
 *				const decimal INTREST_RATE = 0.005m;
 *				
 *				// Local variables
 *				decimal balacnce;// The account balance
 *				
 *				
 *				int months; // The number of months
 *				
 *				int count = 1;// Loop counter, initialized with 1
 *				
 *				if(decimal.Tryparse(startingBalTextBox.Text, out balance))
 *				{
 *					// Get the number of months.
 *					if(int.TryParse(monthsTextBox.Text, out months))
 *					{
 *						// The following loop calculates the ending balance.
 *						while(count <= months)
 *						{
 *							// Add this month's intrest to the balance.
 *							balance = balance + (INTREST_RATE * balance);
 *							
 *							// Display this month's ending balance.
 *							
 *							detailListBox.Items.Add("The ending balance " +
 *							"for month " + count + " is " + balance.ToString("c"));
 *							
 *							// Add one to the loop counter.
 *							count = count+1;
 *							
 *						}
 *						
 *						// Display the ending balance.
 *						endingBalanaceLAbel.Text = balance.ToString("c");
 *						
 *					}
 *					else
 *					{
 *						Invalid number of months was entered.
 *						MessageBox.Show("Invalid value for months.");
 *					}
 *				}
 *				else
 *				{
 *					//Invalid starting balance was enterd.
 *					MEssageBox.Show("Invalid valuje for starting balance.");
 *				}
 *			}
 *			
 *			private void clearButton_Click(object sender, EventArgs)
 *			{
 *				// Clear the TextBoxes, the endingBlanceLAbel control,
 *				// and the ListBox
 *				
 *				startingBalTextBox.Text="";
 *				monthsTextBox.Text = "";
 *				endingBalanceLAbel.Text = "";
 *				detailListBox.Items.Clear();
 *				
 *				//Reset the focus.
 *				startingBalTextBox.Focus();
 *			}
 *			
 *			private void exitButton_Click(object sender, EventArgs)
 *			{
 *				// Close the form.
 *				this.Colse();
 *			}
 *		}
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 *							Infinite Loops
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In all but rare cases, loops must contain a way to terminate within
 * themselves. This means that something inside the loop must eventually
 * make the loop's Boolean expression false. The loop in Program 5-2
 * stops when the expression count <= months is false. 
 * 
 * If a loop does not have a way of stopping, it is called an infinite loop.
 * An infinite loop continues to repeat until the program is interrupted.
 * Infinite loops usually occur when the programmer forgets to write code
 * inside the loop that makes the test condition false.
 * In most circumstances, you should avoid writing infinite loops.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code sample demonstrates an infinite loop. In line 1, 
 * the count variable is declared and initialied with the value 1.
 * The while loop that begins in line 5 executes as long as count is less
 * than or equal to 5. There is no code inside the loop to change the 
 * count variable's value, so the expression count <= 5 in line 5 is
 * always true. As a consequence, the loop has no way of stopping.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * / /Declare a variable to count the loop iterations 
 * int count = 1;
 * 
 * / / How mant times will this loop iterate?
 * 
 * while(count <= 5)
 * {
 *	/ / Display the message box.
 *	MessageBox.Show("Hello");
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *						5.3 The ++ and -- operators
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: To increment a variable means to increase its value, and to
 * decrement a variable means to decrease its value. C# provides special
 * operators to increment and decrement variables.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To increment a variable means to increase its value and to decrement
 * a variable means to decrease its value.
 * 
 * Both of the following statements increment the variable num by 1:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num = num + 1;
 * num += 1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * And num is decremented by 1 in both the following statements:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num = num - 1;
 * num -= 1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Incrementing and decrementing is so commonly done in programs that C#
 * provides a set of simple unary operators designed just for
 * incrementing and decrementing variables. The increment operator is ++,
 * and the decrement ioerator is --. The following statement uses the ++
 * operator to add 1 to num:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num++;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this statement executes, the value of num is increased by 1. 
 * The following statement uses the -- operator to subtract 1 from num:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num--;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: The ++ operator is pronounced "plus plus," and the -- operator
 * is pronounced "minus minus." THe expression num++ is pronounced
 * "num plus plus", and the expression num-- is pronounced
 * "num minus minus."
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In these examples, we have written the ++ and -- operators after their
 * operands (or, on the right side of their operands). This is called 
 * postfix mode. The operators can also be written before (or, on the 
 * left side) of their operands, which is called prefix mode. Here are
 * examples:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ++num;
 * --num;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you write a simple statement to increment or decrement
 * a variable, such as the ones shown here, it doesn't matter if you use
 * prefix mode or postfix mode. The operators do the same thing in either
 * mode; however, if you write statements that mix these operators with 
 * other operators or with other operations or with other operations, 
 * there is a difference in the way the two modes work. Such complex
 * code can be difficult to understand and debug. When we use the 
 * increment and decrement operators, we will do so only in ways that are
 * straightforwars and easy to understand, such as the statements
 * previously shown. 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We introduce these operators at this point because they are commonly
 * used in loops. THe following code segment shows an example.
 * In the code, the count variable is initialized with the value 1. The
 * while loop that begins in line 5 iterates as long as count is less 
 * than or equal to 5. The statement in line 11 increments count. The
 * loop will iterate 5 times.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // DEclare a variable to count the loop iterations.
 *  int count = 1;
 *  
 *  // Display "Hello" in a message box five times.
 *  while(count <= 5)
 *  {
 *		// Display the message box.
 *		MessageBox.Show("HEllo");
 *		
 *		// Increment count.
 *		count++;
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the next section, which discusses the for loop, you will see
 * these operators used often.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *							5.4 The for Loop
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: The for loop is ideal for performing a know number of
 * iterations.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The for loop is specifically designed for situations requiring a
 * counter variable to control the number of tiems that a loop iterates.
 * When you write a for loop, you specify three actions:
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Initialization: This action take place when the loop begins. It
 * Happens only once.
 * 
 * *Test: A Boolean expression is tested. IF the expression is true, the
 * loop iterates. Otherwise, the loop stops.
 * 
 * *Update: This action takes place at the end of each loop iteration.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-10 shows how these three actions are used in the logic of a 
 * for loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-10 Logic of a for loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the general format of the for loop:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(InitializationExpression; TestExpression; UpdateExpression)
 * {
 *		statement;
 *		statement;
 *		etc.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The statements that appear inside the curly braces are the body of 
 * the loop. These are the statements that are executed each time the 
 * loop iterates. As with other control structures, the curly braces are
 * optional if the body of the loop contains only one statement, as 
 * shown in the following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(InitializationExpression; TestExpression; UpdateExpression
 * statement;)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first line of the for loop is the loop header. After the key word
 * for, there are three expressions inside the parentheses, separated by
 * semicolons. (Notice that there is not a semicolon after the third 
 * expression.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first expression is the initialization expression. IT is normally
 * used to initialize a counter variable to its starting value. This is 
 * the first action performed by the loop, ans it is only done once.
 * The second expression is the test expression. This is a Boolean 
 * expression that controls the execution of the loop. As long as the 
 * expression is true, the body of the for loop will repeat. The for
 * loop is a pretest loop, as it evaluates the test expressiomn before 
 * each iteration. The third expression is the update expression, IT 
 * executes at the end of each iteration. Typically, this is a statement
 * that increments the loop's counter variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's assume that count is an int variable that has already been 
 * declared. Here is an example of a simple for loop that displays
 * "Hello" in a message box 5 times:
 * ////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(count = 1; count <= 5; count++)
 * {
 *		MessageBox.Show("Hello");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this loop, the initialization expression is count = 1, the test 
 * expression is count <= 5, and the increment expression is ccount++.
 * The body of the loop has one statement, which is the call to
 * MEssage.Show method. This is a summary of what happens when this loop
 * executes:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 1. The initialization expression count = 1 is executed. This assigns
 * 1 to the count variable.
 * 
 * 2. The expression count <= 5 is tested. If the expression is true, 
 * continue which Step 3. Otherwise, the loop is finished.
 * 
 * 3. The statemetn MEssageBox.Show("Hello"); is executed.
 * 
 * 4. The update expression count++ is executed.
 * This adds 1 to the count variable.
 * 
 * 5. Go back to Step 2.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-11 illustrates this sequence of events. Notice that Steps
 * 2-4 are repeated as long as the test expression is true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-12 shows the logic of the loop as a flowchart.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-11 Sequence of events in the for loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-12 Logic of the for loop 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at a complete application that uses a for loop. IN the 
 * Chap05 fold of this book's Student Programs, you will find a project
 * named Squares.
 * 
 * The purpose of the the application is to display the numbers 1-10
 * and their sequares. Figure 5-13 shows the application's form at run 
 * time. As shown in the image on the left, the ListBox's name is
 * outputListBox and the Buton control's name is goButton. At run
 * time, when you click the goButton control, the outputListBox control
 * displays the program's output, as shown in the image on the right.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-13 The Seqares application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the code for the goButton_Click event handler:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *		// Contrant for the maximum number
 *		
 *		const int MAX_VALUE = 10;
 *		
 *		// Loop counter
 *		int number;
 *		
 *		// Display the list of number and their squares.
 *		for(number = 1; number <= MAX_VALUE; number++)
 *		{
 *		
 *		// yay we have are first cool code optimization!
 *		
 *		// it is faster, if you a variable in scope, to 
 *		multiply the local variable by it's self
 *		instead of using pow() method.
 *		
 *		outputListBox.Items.Add("The seqare of "
 *		+number + " is " + (number * number));
 *		}
 * 
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a close look at the code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Line 4 declares an int constant named MAX_VALUE, set to the value 10.
 *   This is the maximum number that we will use to calculate a square.
 *   
 * *Line 7 declares an int variable named number. This variable is used
 * both as a counter variable and in the calculation of squares.
 * 
 * *Line 10 is the beginning of a for loop. You can see form this line that
 * the loop works in the following way:
 *		
 *		Initialiation: The number variable is initialized with the value 1.
 *		
 *		Test: The expression number <= MAX_VALUE is tested at thebegginning of each iteration.
 *		
 *		Update: The expression number++ is executed at the end of each iteration.
 *		
 *	*Since the MAX_VALUE constant is set to the value 10, the number variable will
 *	be assigned the values 1 through 10 as the loop iterates.
 *	
 *	*Lines 13 and 13: This statement adds a line to the ListBox showing the current
 *	value of the number variable, and the square of that value.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					The for Loop Is a Pretest Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because the for loop tests its Boolean expression before it preforms
 * an itertion, is a pretest loop. it is a pretest loop. IT is possible 
 * to write a for loop in such a way that it will never iterate. Here is
 * an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because the variable count is initialized to a value that makes the
 * Boolean expression false form the beginning, this loop terminates as 
 * soon as it begins.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Declaring the Counter Variable in the Initialization Expression
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Not only may the counter variable be initialized in the initialization
 * expression, but it may also be declared there.
 * The following code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for (int count = 1; count <= 5; count++)
 * {
 *	MessageBox.Show("Hello");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this loop, the count variable is both declared and initialized in
 * the initialization expression. If the variable is used only in the 
 * loop, it makes sense to define it in the loop header. This makes the
 * variable's purpose clearer.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a variable is declared in the initializaed expression of a for
 * loop, the scope of the variable is limited to the loop. This means 
 * you cannot access the variable in statements outside the loop. For 
 * example, the following code would caise a compiler error bacause the 
 * statement in line 6 cannot access the count variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					Other Forms of the Update Expression
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the update expression, the counter variable is typically incremented 
 * by 1. This makes it convenient to use the ++ operator in the increment
 * expression. This is not a requirement, however. You can write virtually
 * any expression you wish as the update expression.
 * For example, the following loop increments count by 10:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for (int count = 0; count <= 100; count += 10)
 * {
 *	MessageBox.Show(count,ToString());
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that in this example the increment expression is count+= 10.
 * This means that at the end of each iteration, 10 is added to count.
 * During the first iteration count set to 0, during the second iteration
 * count is set to 10, during the third iteration count is set to 20, and
 * so forth.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Counting Backward by Decrementing the Count Variable
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Although the counter variable is usually incremented in a
 * count-controlled loop, you can alternatively decrement the counter
 * variable.
 * 
 * For example, loop at the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for (int count = 10; count >= 0; count--)
 * {
 *	MessageBox.Show(count.ToString());
 * }
 * MessageBox.Show("Blastoff!");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IN this loop, the count variable is initialized with the value 10. 
 * The loop iterates as ling as count is greater than or equal to 0.
 * At the end of each iteration, count is decremented by 1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * During the first iteration count is 10, during the second iteration
 * count is 9, and so forth, down to 0, and then display Blastoff!
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Avoiding Modifying the Counter Variable in the Body of the fot Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Be careful not to place a statement that modifies the counter variable 
 * in the body of the for loop. All mdifucations of the control variable 
 * should take place in the update expressiom, which is automatically 
 * executed at the end of each iteration. If a statement in the body of 
 * the also modifies the counter variable, the loop probably will not
 * termainate when you exprect it to. The following loop, for example,
 * increments count twice for each iteration:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(int count = 1; count <= 10; count ++)
 * {
 * MessageBox.Show(count.ToString());
 * count++; // Wrong!
 * |
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You have seen several examples of the loop. Tutorial 5-3 gives you an
 * opportunity to write one. In the tutorial you will complete an
 * application that uses a for loop to conver a series of measurements 
 * from the metic system to the English system.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tuorial 5-3: Using the for Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Your firend Amanda just inherited a European sports car from her 
 * uncle. Ananda lives in the United States, and she is afraid she will 
 * get a speeding ticket becausse the car's speedometer works in 
 * Kilometers per hour. She has asked you to write a program that
 * displays a table of speed in kilometers per hour with their values
 * converted to miles per hour. The formula for converting kilometers per
 * hour to miles per hour is:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *							MPH = KPH * 60.6214
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the formula, MPH is the speed in miles per hour and KPH is the
 * speed in kilometers per hour.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The table that your program displays should show speeds from 60
 * kilometers per hour throught 130 kilometers per hour, in increments of 10
 * along  with their converted to miles per hour. The table should look
 * somthing like this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * _________________
 * ||KPH|	|MPH|  | 
 * |---------------|
 * |60  |	|37.284|
 * |70  |	|43.498|
 * |80  |	|49.712|
 * |etc |	|      |
 * -----------------
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * AFter thinking about this table of values, you decide that you will
 * write a for loop that uses a counter variable to hold the kilometers 
 * per hour speeds. The counter's starting value will be 60, its ending
 * value will be 130, and you will increase its value by 10 in the update
 * expression. Inside the loop will use the counter variable to calculate 
 * a speed in miles per hour.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The project, which is named Speed Converter, has already been started 
 * for you. it is located in the Chap05 folder of this book's Sudent Sa
 * -mple Program. The application's form, at run time, is shown in Figure
 * 5-14. The image on the left in the figure shows the names of the
 * controls. The image on the right shows how the form appears after the 
 * user clicks the Display Speeds button.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-14 The Speed Converter form 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Speed Converter in
 * the Chap05 folder of this book's Student Sample Programs.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 2: Open the Form1 form in the Designer.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 3: IN the Designer, double-click the displayButton control.
 * This opens the code editor, and you will see an empty event handler
 * named disokayButton_Click. Complete the displayButton_CLick event handler 
 * by typing the code shown in lines 22-42 in Program 5-3 (at the end of 
 * this tutorial). Let's take a closer look at the code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Line 23-26L These statements declare the following named constants:
 * 
 *  * START_SPEED, 
 *  an int constant set to 60. This is the starting speed
 *	
 *	* END_SPEED, 
 *	an int constant set to 130. This is the ending for the list
 *	  of conversions. When the counter variable exceeds this value, the 
 *	  loop star
 *	
 *	*INTERVAL,
 *	an int constant set to 10. This is the amount that you
 *	add to loop's counter variuable after each iteration.
 *	
 *	*CONVERSION_FACTOR,
 *	a double constant set to 0.6214. This is the 
 *	conversion factor that you use in the firmula to convert KPH to MPH.
 *	
 *	Lines 29-30: These statements declare the following variables:
 *	
 *		kph, an int variable to hold the speed in kilometers per hour.
 *		mph, a double variable to hold the speed in miles per four.
 *		
 *	Line 33: This is the beginning of a for loop that works in the 
 *	following way:
 *	
 *	Initializarion: The kph variable is initialized with value of
 *	START_SPEED, which is 60.
 *	
 *	Test: The expression kph <= END_SPEED is tested at the beginning of 
 *	each iteration.
 *	
 *	Update: The exoression kph += INTERVAL is executed at the end of each iteration.
 *	This adds the value of INTERVAL (10) to the kph variable.
 *	As the loop iterates, the kph variable is assigned the values 60,70,80,
 *	and so forth, throught 130.
 *	
 *	Line 36: This statement converts the value of the kph variable to
 *	miles per hour and assigns the result to the mph variable.
 *	
 *	Line 39-40: This statement adds a line to the outputListBox control
 *	showing the current value of the kph variable and the equivalent value 
 *	in miles per hour
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Switch your view back to the Designer and double-click the
 * exitButton control.
 * 
 * In the code editor you will see an empty event handler named 
 * exitButton_Click event handler by typing the code shown in 
 * lines 46-47 in Program 5-3.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Save the project, Then press F5 on the keyboard or click the 
 * Start Debugging button(|>) on the toolbar to compile and run tghe 
 * application. Click the Display Speed button, and you should see the 
 * output shown in the image on the right in Figure 5-14. Click the Exit
 * button to close the form.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 5-3 Completed Form1 code for the Speed Converter application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Speed_converter
 * {
 *	public partial class Form1 : Form
 *	{
 *		public Form1()
 *		{
 *			InitializeComponent();
 *		}
 *		
 *		private void displayButton_Click(object sender, EventArgs e)
 *		{
 *			// Constants
 *			const int START_SPEED = 60;
 *			const int END_SPEED = 130;
 *			const int INTERVAL = 10;
 *			const double CONVERSION_FACTOR = 0.6214;
 *			
 *			// Variables
 *			int kph;	// Kilometers per hour
 *			double mph;	// Miles per hour
 *			
 *			// Display the table of speeds
 *			for(kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
 *			{
 *				// Calculate miles per hour.
 *				mph = kph * CONVERSION_FACTOR;
 *				
 *				// Display the conversion.
 *				outputListBox.Items.Add(kph + " KPH is the same as " + mph + " MPH");
 *			}
 *		}
 *		
 *		private void exitButton_Click(object sender, EventArgs e)
 *		{
 *			// Close the form.
 *			this.Close();
 *		}
 *		
 *	}
 * }
 * ///////////////////////////////////////////////////////////////////// 
 * 
 * /////////////////////////////////////////////////////////////////////
 *					5.5 The do-while Loop
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: The do-while loop is a posttest loop, which means it 
 * perfomrs an iteration before testing its Bollean expreassion.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You have learned that the while loop and the for are pretest loops,
 * which means they test their Boolean expressions before performing 
 * an iteration. The do-while loop is a posttest loop. This means it
 * performs an iteration before testing its Boolean expression. As a 
 * result, the do-while loop always performs at least one iteration,
 * even if its Boolean expression is false to begin with. The logic
 * of a do-while loop is shown in Figure 5-15.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-15 The logic of a do-while loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the flowchart, one or more statements are executed, and then a 
 * Boolean expression is tested. If the Boolean expression is true, the
 * program's execution flows back to the point just above the first 
 * statement in the body of the loop, and this process repeats. If the
 * Boolean expression is false, the program exits the loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In code, the do-while loop looks something like an inverted while 
 * loop. Here is the general format of the do-while loop:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * do
 * {
 *		statment;
 *		statment;
 *		etc.
 * } while (BooleanExpression);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * As with the while loop, the braces are optional if there is only one
 * statement in the body of the loop. This is the general format of the 
 * do-while loop with only one conditionally executed statemet:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * do
 *		statement;
 *	while (BooleanExpression);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that a semicolon appears at the very end of the do-while 
 * statement. The semicolon is required; leaving it out is a common error.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The do-while loop is a posttest loop. This means it does not test its
 * Boolean expression until it has completed an iteration. As a result,
 * the do-while loop always perform at least one iteration, event if the 
 * expression is false to begin with. This differs from the behavior of a
 * while loop. For example, in the following while loop, the statement that
 * calls MessageBox.Show will not execute at all:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int number = 1;
 * while(number < 0)
 * {
 *		MessageBox.Show(number.ToString());
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * But, the statment that calls MessageBox.Show in the following 
 * do-while loop executes one time because the do-while loop does not 
 * test the expression number < 0 until the end of the iteration.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int num = 1;
 * do
 * {
 * MessageBox.Show(number.ToString());
 * 
 * }while(number < 0);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				5.6 Using Files for Data Storage
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: When a program need to save data for later use, it writes the
 * data in a file. The data can be read from the file at a later time.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The programs you have written so far require the user to reenter
 * data each time the program runs because data kept in variables 
 * and control properties is stored in RAM and disappears once the
 * program stops running. If a program is to retain date between the
 * times it runs, it must have a way of saving it.
 * 
 * Data is saved in a file, which is usually stored in a computer's
 * disk.
 * 
 * Once the data is saved in a file, it will remain there after 
 * the prgram stops running.
 * 
 * Data that is stored in a file can be retrieved and used at a
 * later time.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Most of the commercial software that you use on a day-to-day basis
 * store data in files. The following are a few examples: 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * WORD PROCESSORS: Word processing programs are used to write letters,
 * memos, reports, and other documents. The documents are than saved in
 * files so they can be editeed and printed.
 * 
 * *IMAGE EDITORS: Image-editiing programs are used to draw graphics
 * and edit images, such as the ones that you take with a digital carmera.
 * The images that you care or edit with an image editor are saved in files. 
 * 
 * *SPREADSHEETS: Spreadsheet programs are used to work with numerical data.
 * Numbers and mathermatical formulas can be inserted into the rows and
 * columns of the spreadsheet.
 * The spreadsheet can then be saved in a file for use later. 
 * 
 * *GAMES: Many computer games keep data stored in files. For example,
 * some games keep a list of player names with their scores stored in
 * a file. 
 * These games typically display the players' names in order of their
 * scores, from highest to lowest.
 * Some games also allow you to save your current games satus in a
 * fike so you quit the games and then resume playing it later without 
 * having to start your current game status in a file so you quit their
 * scores, from hightest to lowest. Some games also allow you yto save
 * your current game status in a file so you can quit the game and then
 * resume playing it later without having to start from the beginning.
 * 
 * *WEB BROWSERS: Sometimes when you visit a Web page, the browser
 * stores s small file known as a cookie on your computer. Cookies 
 * typically contain information about the browsing seassion, such as \
 * the contents of a shopping cart.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Programs that are used in a daily business operations rely extensively
 * on files. Payroll programs keep employee data in files, inventory programs
 * keep data about a company's products in files, accounting systems keep 
 * about a company's financial operations in files, and so forth.
 * /////////////////////////////////////////////////////////////////////
 * *-
 * /////////////////////////////////////////////////////////////////////
 * Programmers usually refer to the process of saving data in a file as
 * writing data to the file. When a piece of data is written to a file,
 * it is copied from a variable in RAM to the file. This is illustrated
 * in Figure 5-16. The term output file is usaed to decsribe a file to
 * which data is written.
 * 
 * It is called an output file because the program stores output in it.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-16 Writing data to a file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The process of retrieving data from a file is know as reading data
 * from the file. When a priec of data is read from a file, it is copied
 * from the file into a variable in RAM. Figure 5-17 illustrates this.
 * The term input file is ued to describe a file from which data is 
 * read. It is called an input file because the program gets input from
 * the file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-17 Reading data from a file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this section, we discuss ways to create programs that write data to
 * files and read data from files. There are always three steps that must
 * be taken when a file is used by a program.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 1. OPEN THE FILE - Opening a file creates a connection between the file 
 * and the program. Opening an output file usually creates the file on the disk 
 * and allows the program to write data to it. Opening an input file allows the 
 * program to read data from the file.
 * 
 * 2. PROCESS THE FILE - In this step, data is either written to the file
 * (if it is an output file) or read from the file (if it is an input file)
 * 
 * 3. CLOSE THE FILE - When the program is finished using the file, the file
 * must be closed. Closing a file disconnects the file from the program.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *						TYPES of Files
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In general, there are two types of files: text and binary.
 * 
 * A text file
 * contains data has been encoded as test using a schemen such as Unicode.
 * 
 * Even if the file contains numbers, those numbers are stored in the file
 * as a series of characters. 
 * 
 * As a result, the file may be opened and viewed in a text editor such
 * as Notepad.
 * 
 * A binary file contains data that has not been converted to text.
 * 
 * As a consequence, you cannot view the contents of a binary file with
 * a text editor. 
 * 
 * In this chapter, work only with text files.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *							File Access Methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Most programming languages provide two different ways to access data
 * in a stored in a file: sequential access and direct access.
 * 
 * When you work with a sequential access file, you acess data from the 
 * beginning of the file to the end of the file. If you want to read a
 * piece of data that is stored at the very end of the file, you have to
 * read all the data that comes before it-you cannot jump directly to the 
 * desired data. This is similar to the way cassette tape players work.
 * If you want to listen to the last song on a cassette tape, you have 
 * to either fast-forward over all of the songs that come before it - 
 * you cannot jump directly to the desired data. This is similar to the
 * way cassette tape players work. If you want to listen to the last
 * song on a cassette tape, you have to either fast-forward over all
 * of the songs that come before it or listen to them. There is no way
 * to jump directly to a specific song.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you work with a direct access file (which is also known as a 
 * random access file), you can jump directly to any piece
 * of data in the file without reading the data that comes before it.
 * 
 * This is similar to the way a CD player or an MP3 player works. You 
 * can jump directly to any somg you want to listen to. 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This chapter focuses on sequential access files. Sequential access 
 * files are easy to work with, and you can use them to gain an 
 * understanding of basic file operations.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Filenames and File Objects
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Files on a disk are identified by a filename.
 * For example, when youcreate a document with a word processor and then
 * save the document in a file, you have to specify a filename.
 * 
 * When you use a utility such as Windows Explorer to examine the 
 * contents of your disk, you see a list of filenames. Figure 5-18 shows
 * how three files named cat.jpg, notes.txt. and resume.docx might be 
 * represented in Windows Explorer.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-18 Three files
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Each operating system has its own rules for naming files.
 * Many systems, including Windows, support the use of filename
 * extensions, which are short sequences of characters that appear at 
 * the end of a filename and are preceded by a period (which is know as
 * a "dot"). For example, the files depicted in Figure 5-18 have the 
 * extensions .jpg, .txt, and .docx. The extension usually indicates the
 * type of data stored in the file. For example, the .jpg extension usually
 * indicates that the file contains a grphic image that is compressed 
 * according to the JPEG image standard. The .txt extension usually indicates
 * that the file indicates that the file contains text. The .docx extension
 * usually indicates that the file contains a Microsoft Word document.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In order for a program to work with a file on the conputer's disk, the
 * program must create a file object in memory. A file object is an object
 * that is associated with a specidic file and provides a way for the program
 * to work with the file. In the program, a variable is linked with the 
 * file object. We say that the variable references the object. This variable
 * is used to carry out any operations that are performed on the file.
 * 
 * This concept is shown in Figure 5-19.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figuire 5-19 A variable referencing a file object that is associated
 * with a file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You will be using two classes from the .NET Framework to create file
 * objects. When you want to write data to a text file, you use the 
 * StreamWriter class, and when you want to read data from a text file
 * you use the StreamReader class. These classes are in the System.IO
 * namespace in the .NET Framework, so you will need to write the 
 * following directive at the top of your programs:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * using System.IO;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: In programming terminology, files are considered streams of
 * data. In C#, you use a StreamWriter object to open a stream, such
 * as a file, and write data to it. You use a StreamReader object to open
 * a stream, such as a file, and read data from it.

 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Writing Data to a File with a StreamWriter Object
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the StreamWriter class's WriteLine method to write a line
 * of text to a file. Let's suppose you want to write a program that creates
 * a text file named course.txt and writes the names of the courses you are
 * taking to the file. The following codesample shows how you can do this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamWriter outputFile;
 * outputFile = File.CreateText("courses.txt");
 * 
 * outputFile.WriteLine("Intro to Computer Science");
 * outputFile.WriteLine("English Composition");
 * outputFile.WriteLine("Calculus I");
 * outputFile.WriteLine("Music Appreciation");
 * 
 * outputFile.Close();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at each line of code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Line 1: This statement declares a variable named outputfile, which
 * can be used to reference a StreamWriter object.
 * 
 * Line 2: In a nutshell, this statement opens the ffile to which you will
 * be writting data. It does so by calling the FileCreateText method,
 * passing the string "courses.txt" as an argument. The File.CreateText
 * method does the following:
 * 
 *	*It creates a text file with the name specified by the argument.
 *	if the file already exists, its contents are erased.
 *	
 *	*It creates a StreamWriter object in memory, associated with the file.
 *	
 *	*It returns a reference to the StreamWriter object.
 *	
 *	Notice that an assignment operator assigns the value returned from the
 *	File.CreateText method to the outputFile variable. This causes the 
 *	outputFIle variable to reference the StreamWriter object that was 
 *	created by the method.
 *	
 *	After the statement in line 2 executes, the courses.txt file is
 *	created on the disk, a StreamWriter object associated with the 
 *	file exists in memory, and the outputFile variable references
 *	that object.
 * 
 * Line 4: This statement writes the string "Intro to Computer Science"
 * to the courses.txt file. It does that by calling the StreamWriter
 * class's WriteLine method, passing the string that is to be written
 * to the file as an argument. When the WriteLine method writes data
 * to a file, ot writes a newline character immediately following the data.
 * A newline character is an invisible character that specidides the 
 * end of a line of text.
 * 
 * Line 5:This statement writes the string "English Conposition" to
 * the course.txt file.
 * 
 * Line 6:This statement writes the string "Calculus I" to
 * the course.txt file.
 * 
 * Line 7:This statement writes the string "Music Appreciation" to the
 * course.txt file.
 * 
 * Line 9:This statement closes the course.txt file. It does that by 
 * calling the StreamWriter class's Close method.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this code has executed, we can open the course.txt file using
 * a text editor and look at its contents. Figure 5-20 show how the 
 * file's contents will appear in Notepad.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-20 Contents of the course.txt file shown in Notepad
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *				Writing Data with the Write Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Earlier you read that the StreamWriter class's WriteLine method writes
 * an item of data to a file and then writes a newline character. The 
 * newline character specifies the end of a line of text. For example,
 * the following code sample opens a file named Example.txt and then
 * uses the WriteLine method to write the strings "One","Two",and "Three"
 * to the file. BEcause a newline character is written after each string,
 * the strings appear on sepatare lines when viewed in a text editor.
 * The screen shown on the left in Figure 5-21 shows how the file would
 * appear in Notepad.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-21 items written with WriteLine and Write methods
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamWriter outputFile;
 *  // This is so cool omg, this syntax is amazing
 * outputFile = File.CreateText("Example.txt");
 * 
 * outputFile.WriteLine("One");
 * outputFile.WriteLine("Two");
 * outputFile.WriteLine("Three");
 * 
 * outputFile.Close();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In some situations, you wight want to write an item to a file without
 * a newline character immediayely following it. The StreamWriter class
 * provides the Write method for this purpose. It writes an item of data
 * to a text file without writing a newline character. The following code
 * sample demonstrates. The screen shown on the right in Figure 5-21 shows
 * how the resulting file would appear in Notepad.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamWriter outputFile;
 * outputFile = File.CreateText("Example.txt");
 * 
 * outputFile.Write("One");
 * outputFile.Write("Two");
 * outputFile.Write("Three");
 * 
 * outputFile.Close();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Handling File-Related Exceptions
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Unexpected problems can potentially occur when working with files.
 * For example, your program mught not have sufficient rights to create
 * a file when it calls the File.CreateText method, or the disk might
 * be full when you call the StreamWriter class's WriteLine method.
 * 
 * When unexpected errors such as these occur, an exception is thrown.
 * To handle such exceptions, you can write a try-catch statement, with
 * code that performs file operations placed in the try block. Here
 * is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * try
 * {
 *		StreamWriter outputFile;
 *		
 *		outputFile = File.CreateText("courses.txt");
 *		
 *		outputFile.WriteLine("Intro to Computer Science");
 *		outputFile.WriteLine("English Composition");
 *		outputFile.WriteLine("Calculus I");
 *		outputFile.WriteLine("Music Appreciation");
 * 
 *		outputFile.Close();
 * }
 * catch(Exception ex)
 * {
 *	// Display an error message.
 *	MessageBox.Show(ex.Message);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Tutorial 5-4, you will complete an application that reads input 
 * from a TextBox control and write the input to a file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-4: Writing Data to a Text File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Friend File application.
 * The project has already been started for you and is located in the 
 * Chap05 folder of this book's Student Sample Programs.
 * The application's form is shown in Figure 5-22.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-22 The Friend File form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you complete the application, it will allow the user to enter
 * a name into the nameTextBox control. 
 * 
 * When the user clicks the writeNameButton control, the application opens
 * a text file named Friend.txt, writes the name that was entered into the 
 * TextBox control to the file, and then closes the file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Ending Balance
 * in the Chap05 folder of this book's Student Sample programs.
 * 
 * Step 2:Open the Form1 form's code in teh code editor. Insert the 
 * using System.io; directive shown in line 10 of Program 5-4 at the
 * end pf this tutorial. This statement is necessary because the
 * StreamWriter class is part of the System.IO namespace in the .NET Framework
 * 
 * 
 * Step 3:Open the Form1 form in the Designer. The form is shown, along with the
 * names of the important controls, in Figure 5-22.
 * 
 * Double-click the writeNameButton control. This open the code editor, and you will 
 * see an empty event handler named writeNameButton_Click.
 * Complete the writeNameButton_Click event handler by typing the code shown in lines
 * 22-44 in Program 5-4. Let's take a closer look at the code:
 * 
 * Line 23: This is the beginning of a try-catch statement. The try block appear in
 * lines 42-43. If an exception is thrown by any statement in the try block, the 
 * program jumps to the catch block, and line 43 displays an error message.
 * 
 * Line 26: This statement declares a StreamWriter variable named outputFile. 
 * You use this variable to reference a StreamWriter object.
 * 
 * Line 29: This statement calls the File.CreateText method to create a text file
 * named Firend.txt. The method also creates a StreamWriter object in memory 
 * associated with the file. The method returns a reference to that object,
 * which is assigned to the outputFile variable. As a result, the outputFile
 * variable references the StreamWriter object. You will be able to use the 
 * outputFile variable to perform operations on the Firend.txt file.
 * 
 * Line 32: This statement uses the outputFile variable to call the
 * StreamWriter class;s WriteLine method. The nameTextBox control's Text
 * property is passed as an argument. As a result, the value entered into the
 * TextBox is written to the Firend.txt file.
 * 
 * Line 35: This statement closes the Friend.txt file.
 * 
 * Line 38: This statement displays a message box to let the user know that the name
 * was written to the file.
 * 
 * 
 * Step 4: Switch your view back to the Designer and double-click the exitButton control
 * . In the code editor you will see an emprt event handler named exitButton_Click.
 * Complete the exitButton_Click event handler by typing the code shown in lines 49-50 in
 * Program 5-4.
 * 
 * 
 * Step 5:Save the project. Then, oress F5 on the keyboard or click the Start Debugging 
 * button(|>) in the toolbar to compile and run the application. Enter a name into the 
 * nameTextBox control, and then click the Write Name button. You should see a message
 * box appear letting you know that the name was written to the file. Click the OK button
 * to dismiss the Enter a name into the nameTextBox control, and then click the Write 
 * Name button. You should see a message box appear letting you know that the name was 
 * written to the file. Click the OK button to dismiss the message box; then click the
 * Exit button on the application's form to end the application.
 * 
 * 
 * Step 6: Now you will at the contents of the Firend.txt file that the application created.
 * Click on the menu bar, then click open, and them click file...
 * 
 * 
 * Step 7:You should now see the Open File window, viewing the contents of the Friend File
 * project folder. As shown if Figure 5-23, open the bin folder, then
 * open the Debug folder,
 * and then select the file Friend.txt. (You might not see the .txt
 * extension, depending on hoe your system is set up) Click the Open
 * button.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-23 Opening the Firend.txt file in the Open File window
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 3-4 Completed Form1 code for the Friend File application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Friend_File
 * {
 * 
 *		public partial class Form1 : Form
 *		{
 *			InitializeComponent();
 *		}
 *		
 *		private void writeNameButton_Click(object sender, EventArgs e)
 *		{
 *			try
 *			{
 *				// Declare a StreamWriter variable.
 *				StreamWeiter outputFIle;
 *				
 *				// Create a File and get a StreamWriter object
 *				
 *				outputFile =File.CreateText("Friend.txt");
 *				
 *				// Write the firend's name to the file.
 *				outputFile.WriteLine(nameTextBox.Text);
 *				
 *				// Close the files
 *				outputFile.Close();
 *				
 *				// Let the user know the name was written.
 *				MessageBox.Show("The name was written.");
 *			}
 *			catch (Exception ex)
 *			{
 *				//Display an error message
 *				MessageBox.Show(ex.Message);
 *			}
 *		}
 * 
 *		private void exitButton_Click(object sender, EverArgs)
 *		{
 *			// Close the form.
 *			this.Close();
 *		}
 * 
 * 
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 8: You should now see the contents of the Friend.txt file in 
 * Visual Studio, as shown in Figure 5-24. (The example in the figure
 * shows the contents of the file after the user has written Tim Owens to
 * the file.) When you are sinished examining the contents of the file
 * , you can close its tab. We come back to this project in the next
 * tutorial.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-24 Sample contents of the Firend.txt file shown in Visual
 * Studio
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *				Writing Numeric Data to a Text File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can use the StreamWriter class's WriteLine or Write method to 
 * write numbers (such as int s, double s, and decimals) to a text file,
 * but the numbers are coverted to strings. For example, look at the 
 * following sample code (taken from the Number File project in the 
 * Chap05 filder of Student Sample Programs):
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void writeNumbersButton_Click(object sender, EventArgs e)
 * {
 *		try
 *		{
 *			// Declare a StreamWriter variable.
 *			StreamWriter outputFile;
 *			
 *			// Create a file and get a StreamWriter object.
 *			outputFile = File.CreateText("Numbers.txt");
 *			
 *			// Write the numbers 1 through 10 to the file.
 *			for(int count = 1; count <= 10; count++)
 *			{
 *				outputFile.WriteLine(count);
 *			}
 *			
 *			// Close the file.
 *			outputFile.Close();
 *		}
 *		catch(Exception ex)
 *		{
 *			// Display an error message.
 *			MessageBox.Show(ex.Message);
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When this event handler executes, line 9 creates a text file named 
 * Numbers.txt, and the loop in line 12-15 writes the number 1-10 to the 
 * file. Figure 5-25 shows how the file appears when opened with Notepad.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-25 The Numbers.txt file opened in Notepad
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Appending Data to an Existing File 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call the File.CreateTExt method to open a file specified
 * by the argument aleady exists, it is erased and a new empty file
 * with the same nuame is created. For example, when you run the Friend
 * FIle application that you completed in Tutorial 5-4, each time you 
 * click the Write Name button, the Friend.txt file is erased and a new
 * file is created.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Sometimes you want to preserve an existing file and append new data to 
 * its current contents. To append data to an existing file, you open it
 * with the File.AppendText method. It works like the File.CreateText 
 * method, but the file is not erased if it already exists. Any data
 * written to the file is appened to the file's existing contents.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * For example, assime the file Names.txt exists and contains the data
 * shown in Figure 5-26.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-26 Name.txt file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code opens the file and appends additional data to its
 * exising contents:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamWriter outputFile;
 * outputFile = File.AppendText("Names.txt");
 * 
 * outputFile.WriteLine("Lynn");
 * outputFile.WriteLine("Lynn");
 * outputFile.WriteLine("Lynn");
 * 
 * outputFile.Close();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this code executes, the Names.txt file contains the data shown
 * in Figure 5-27.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-27 Names.txt file after data has been appended
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-5: Appending Data to the Friend.txt File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you will nodify the Friend File application so it 
 * appends data to the Friend.txt file. When the user clicker the Write 
 * Name button, instead of erasing the file's current contents, the 
 * application adds the contents of the nameTextBox control to the 
 * Friend.txt file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: IF the Friend File project from Tutorial 5-4 is not
 * currently open in Viual Studio, oppen it now.
 * 
 * Step 2:Open the Form1 form's code in the code editor. 
 * You will make modification to the writeNameButton_Click event
 * handler. 
 * Program 5-5, at the end of this tutorial, shows how the event
 * handler code will appear after you make the following changes:
 * 
 * Line 8 and 9: Change the comments as shown to reflect the way the
 * Friend.tx file will be opened in line 10.
 * 
 * Step 3: Save the project. Then, press F5 on the keyboard or
 * click the Write Name button. You should see a message box letting
 * you know that the name was written to the file. When you click
 * the OK button to dismiss the messafe box, notice that the
 * nameTextBox is cleared, and the focus is given to the TextBox.
 * Enter another name, and click the Write Name button. Again, you
 * see the message box. Click the OK button to dismiss the message
 * box and then click the Exit button to end the application 
 * 
 * Step 4:Now you will look at the contents of the Firend.txt file.
 * Click File on the menue bar, then click Open, and then click File.
 * You should see the Open File window, viewing the contents of the
 * Friend File project folder. Open the bin folder, then open the
 * Debug folder, and then select the file Friend.txt. (You might 
 * not see the .txt extension, depending on how your system is set
 * up.) Click the Open button.)
 * 
 * Step 5: You should now see the contents of the Friend.txt file in
 * Visual Studio. Figure 5-28 shows an example.
 * 
 * Notice that the names that you entered were appended to the 
 * file each time you clicked the Write Name button.
 * 
 * When you are finished examining the contents of the file,
 * you can close its tab.
 * 
 * We come back to this project in the next tutorial.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-28 Sample contents of the friend.txt file shown in Visual
 * Studio
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 5-5 Partial code for Form1 in the Firend File application 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void writeNameButton_Click(object sender, EventArgs e)
 * {
 *		try
 *		{
 *			//Declare a SreamWriter variable.
 *			StreamWriter outputFile;
 *			
 *			//Open the Friend.txt file for appending,
 *			// and get a StreamWriter object.
 *			outputFile = File.AppendText("Friend.txt");
 *			
 *			// Write the firend's name to the file.
 *			outputFileWriteLine(nameTextBox.Text);
 *			
 *			// Close the file.
 *			outputFIle.Close();
 *			
 *			// Let the user know the name was written.
 *			MessageBox.Show("The name was written.");
 *			
 *			// Clear the nameTextBox control.
 *			nameTextBox.Text = "";
 *			
 *			// Give the focus to the nameTextBox control.
 *			nameTextBox.Focus();
 *			
 *		}
 *		
 *		catch (Exception ex)
 *		{
 *			// Display an error message.
 *			MessageBox.Show(ex.Message);
 *		}
 *		
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Specifying The Location of an Output File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you call the File.CreateText or File.AppendText methods to open
 * a file, you pass the filename as a string argument. If ht filename
 * that you pasas an argument does not contain the file's path, the 
 * file's location will be the bin\Debug folder, under the
 * application's project folder. You saw this in Tutorials 5-4 and 5-5 
 * when you opened the Friend.txt file in Visual Studio.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IF you want to open a file in a different location, you can specify
 * a path as well as a filename in the argument that you pass to the 
 * File.CreateText or FileAppendText method.  if you specify a path in a string 
 * literal, be sure to prefix the string with the @ character.
 * Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamWriter outputFile();
 * outputFile = File.CreateText(@"C:\Users\Chris\Documents\Names.txt");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tip: You can also let the user specify the file location. See 
 * Selction 5.7 for more information on the SaveFileDialog control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Reading Data from a FIle with a StreamReader Object
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To read data from a text file, you create a StreamReader object. You
 * can then use the StreamReader class's ReadLine method to read a line
 * of text from a file. For example, suppose a file named Students.txt
 * exists and contains the four names shown in Figure 5-29.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-29 Contents of the Student.txt file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's suppose you want to write a program that reads the four names
 * from the Students.txt file and displays them in message boxes. The
 * following code sample shows how you can do this. (This code sample
 * is taken from Student Names project, in the Chap05 folder of this
 * book's Student Sample Programs.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * try
 * {
 *		// Declare a var to hold an item read for the file.
 *		string studentName;
 *		
 *		//Declare a StreamReader variable.
 *		StreamReader inputFile;
 *		
 *		// Open the file and get a StreamReader object.
 *		inputFile = File.OpenText("Student.txt");
 *		
 *		//Read and display the first name.
 *		studentName = inputFile.ReadLine();
 *		MessageBox.Show(studentName);
 *		
 *		//Read and display the second name.
 *		studentName = inputFile.ReadLine();
 *		MessageBox.Show(studentName);
 *		
 *		//Read and display the third name.
 *		studentName = inputFile.ReadLine();
 *		MessageBox.Show(studentName);
 *		
 *		//Read and display the fourth name.
 *		studentName = inputFile.ReadLine();
 *		MessageBox.Show(studentName);
 *		
 *		// Close the file.
 *		inputFile.Close();
 * }
 * catch(Exception ex)
 * {
 *	//Display an error message.
 *	MessageBox.Show(ex.Message);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at the code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * Line 1:This is the beginning of a try-catch statement. 
 * An exception will be thrown in the try black of a problem occurs
 * while the file is being opend or while an item is being read from
 * the file. If that happens,
 * the program jumps to the catch clause in line 31.
 * 
 * Line 4:This statement declares a string variable named studentName.
 * Each time we read a line of text from the file, we assign it to the
 * variable.
 * 
 * Line 7:This statement declares a variable named inputFile that can 
 * be used to reference a StreamReader object.
 * 
 * Line 10:This statement opens the file from which we will be reading data
 * . It does so by calling the FIle.OpenText method, passing the string 
 * "Student.txt" as an argument. The File.OpenText method does the following:
 * 
 * *It opens an existing text file with the name specified by the argument.
 * If the file does not exist, an exception is thrown.
 * *It creates a StreamReader object in memory associated with the file.
 * *It returns a reference to the StreamReader object.
 * 
 * 
 * Line 13: THis statement calls the inputFile.ReadLine method,
 * which reads a line of text from the file. The line of text is
 * returned as s string from the method anssigned to the studentName 
 * variable. Since this statement reads the first line of text from 
 * the file, the studentName variable is assigned the string "Joe Merrell".
 * 
 * Line 14: This statement calls the inputFile.ReadLine method, which
 * reads a line of text from the file. The line of text is returned as
 * a string from the method and assigned to the studentName variable.
 * Since this statement reads the first line of text from the file,
 *  the studentName variable is assigned the string "Joe Merrell".
 * 
 * Line 17 and 18: The statement in line 17 reads the nect line of text 
 * from the file and assigns it to the studentName variable.
 * 
 * After this line executes, the studentName variable is assigned the
 * string "Kathryn Stevens". The statement in line 22 displays the
 * contents of the studentName variable in a message box.
 * 
 * Line 25 and 26: The statement in line 25 reads the next line of
 * text from the file and assigns it to the studentName variable.
 * 
 * After this line executes, the studentName variable is assigned
 * the string "Carly Colombo". The statement in line 26 displays
 * the contents of the studentName variable in a message box.
 * 
 * Line 29:This statement closes the Students.txt file.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Read Position
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a program works with an input file, a special value known as a 
 * read position is internally maintained for that file. A file's read
 * position marks the location of the next item that will be read from
 * the file. When an input file is opened, it's read position is
 * initially set to the first item in the file. As items are read
 * from the file, the read position moves forward, toward the end of
 * the file. Let's see how this works in the previous code sample
 * (from the Student Names project).
 * After the statement in line 10 executes, the read position for
 * the Student.tst file is position for the Students.txt file is 
 * positioned as shown in Figure 5-30.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-30 The initial read position
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The ReadLine method call in line 13 reads an item from the file's 
 * current read position and assigns that item to the studentName variable.
 * Once this statement executes, the studentNames variable is assigned the 
 * string "Jow Merrell". In addition, the file's read position is advanced to
 * the next item in the file, as shown in Figure 5-31
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-31 Read postion after the first ReadLine method call
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The ReadLine method call in line 17 reads an item from the file's
 * current read position and assigns that value to the studentName
 * variable. Once this statement exectues, the studentName variable
 * is assigned the string "Chris Rich". The file's read position is 
 * advanced to the next item, as shown in Figure 5-32.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-32 Read position after the second ReadLine method call 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The ReadLine method call in line 21 reads an item from the file's
 * current read position and assigns that value to the studentName
 * variable. Once this statement executes, the studentName variable is 
 * assigned the string "Kathryn Stevents". The file's read position is
 * advanced to the next item, as shown in Figure 5-33.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-33 Read position after the third ReadLine method call
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The last ReadLine method call appears in line 25. It reads an item from
 * the file's current read position and assigns that value to the
 * studentName variable. Once this statement executes, the studentName
 * variavble is assigned the string "Carly Colombo". The file's read
 * position is advanced to the end of the file, as shown in Figure 5-34.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-34 Read position after the fourth ReadLine method call
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: Did you notice that the previous code sample read the items in
 * the Students.txt file in sequence, from the beginning of the file to
 * the end of the file? Recall from out discussion at the beginning of
 * the section that this is the nature of a dequrntial access file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Reading Numeric Data from a Text File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Remember that when data is stored in a text file, it is encoded as
 * text, using a scheme such as Unicode. Even if the file contains 
 * numbers, those numbers, those numbers are stored in the file as a 
 * series of characters. Furthermore, when you read an item from a 
 * text file with the StreaReader class's ReadLine method, that item
 * is returning a string.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Suppose a text file contains numeric data, sych as that shown in 
 * Figure 5-35. When we use the ReadLine method to read the items from
 * the file, we get the strings "10","20", and "30". IF we need to
 * perform math with these values, we must convert each value 
 * from a string to a numeric data type. We can use the Parse or TryParse
 * families of methods that you already know about to perfrom this
 * conversion.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-35 A text file containing numeric data
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's suppose you want to write a program that reads the three numbers
 * from the NumericData.txt file shown on Figure 5-35 and displays their
 * total in a message box. The following code sample shows a simple 
 * demonstration. (This code sample is taken from the Numeric Data project
 * in the Chap05 folder of this book's Student Sample Program.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * try
 * {
 *		// Variables to hold the numbers read from the file
 *		// and their total
 *		int number1, number2, number3, total;
 *		
 *		// A StreamReader variable.
 *		StreamReader inoutFile;
 *		
 *		// Open the file and get a StreamReader object.
 *		intputFIle = File.OpenText("NumericData.txt");
 *		
 *		// Read three numbers from the file.
 *		number1 = int.Parse(inputFile.ReadLine());
 *		number2 = int.Parse(inputFile.ReadLine());
 *		number3 = int.Parse(inputFile.ReadLine());
 *		
 *		// Calculate the total of the numbers.
 *		total = number + number2 + number3;
 *		
 *		// Display the total.
 *		MessageBox.Show("The total is " + total);
 *		
 *		// Close the file.
 *		inputFile.Close()'
 * }
 * catch(Exception ex)
 * {
 *		// Display an error message.
 *		MessageBox.Show(ex.Message);
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at the code.
 * 
 * Line 1: This is the beginning of a try-catch statement. Various exceptions
 * can be thrown by the code in the try block, which cause the program to
 * jump to the catch clacue in line 27.
 * 
 * Line 5: This statement declares the int variables number1, number2, number3, and total.
 * These variables hold the three values read from the file and their total.
 * 
 * Line 8-11: After these statements have executed, the NumericData.txt
 * file is opened for reading and the inputFile variable references a
 * StreamReader object that is associated with the file.
 * 
 * Line 14: This statement does the following:
 * 
 *		* It calls the inputFile.ReadLine method to read a line from the file.
 *		
 *		*The value that is returneed from the inputFile.ReadLine method
 *		(a string) is passed as an argument to the int.Parse method.
 *		
 *		*The value that is returned from the int.Parse method is assigned
 *		to the number1 variable.
 *		
 *After this statement executes, the number1 variable is assigned the
 *value read from the file, converted to an int.
 *(The number1 variable is assigned the value 10.))
 *
 *Line 15: This statement reads the next value from the file, converts it 
 *to an int, and assigns the result to the number2 variable. (THe number2
 *variable is assigned the value 20.)
 *
 *Line 16: This statements reads the next value from the file, converts
 *it to an int, and assings the result to the number3 variable.
 *(The number3 variable is assigned the value 30.)
 *
 *Line 19: This statement calculate the sum of number1, number2, and 
 *number3, and assigns the result to total.
 *
 *Line 22: This statement displays the sum of the numbers in a message
 *box.
 *
 *Line 25: This statement closes the file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Reading a File with a Loop and Detaching the End of the File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Quite often a program must read the contents of a file without knowing 
 * the number of items that are stored in the file. For example, suppose 
 * you need to write a program that displays all the items in a file, but
 * you do not know how many items the file contains. You can open the file
 * use a loop to repeatedly read an item from the file and display it. 
 * However, an exception will be thrown of the program attemps to read 
 * byond the end of the file. The program needs some way of knowing 
 * when the end of the file has been reached so it will not try to read
 * beyond it. The following pseudocode shows the logic:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Open the file
 * While not at the end of the file:
 *  Read an item from the file
 *  Display an item
 * End While 
 *  Close the file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamReader objects have a Boolean property named EndOfStream that 
 * signals whether the end of the file has been reached. If the file's
 * read position is at the end of the file(and there is not more data to
 * read), the EndOfStream property is set to true. Otherwise, it is set to 
 * false. Whe nyou need to read all the items in a file without knowing
 * how many items the file contains, you can write a loop that iterates as
 * long as the EndOfStream property is false.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's assume inputFile references a StreamReader object that is
 * associates with a file that is already open. You can write the loop in the
 * following manner:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(inputFile.EndOfStream == false)
 * {
 *	 // Read an item from the file.
 *	 // Process the item
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Recall that the ! operator is the logical NOT operator. When you read 
 * the first line of this loop, you naturally think while NOT at the end
 * of the stream. Im Tutorial 5-6, you will complete an application that 
 * uses this tecgnique to display all the items in a file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-6: Using a Loop to Read to the End of a File
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the South America application that is 
 * found in the Chap05 folder of this book's Student Sample Programs. The
 * application's form has already been created and is shown in Figure 5-36.
 * The application also has an accompanying text file named Countries.txt
 * that is stored in the bin\Debug folder under the project folder. The 
 * Countries.txt file contanins the names of the countries of South
 * America. Figure 5-37 shows the file as it appears in Notepad.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-36 The South America application's form 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-37 The Countries.txt file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the completed application runs and the user clicks the Get Countries
 * button, the application reads each country name from the file and adds each 
 * one to the countriesListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Step Visual Studio. Open the project named South America in 
 * the Chap05 folder of this book's Student Sample Programs.
 * 
 * Step 2: OPen the Form1 form's code in the code editor.
 * Insert the using System.IO; directive shown in line 10 of Program
 * 5-6 at the end of this tutorial.
 * 
 * This statement is necessary because the StreamReader class is part of
 * the System.IO namespace in the .NET Framework.
 * 
 * Step 3: Open the Form1 form in the Designer. The form is shown, along
 * with the names of important controls, in Figure 5-36. Double-click the 
 * getCountriesButton control. This opens the code editor, and you will 
 * see an empty event handler named getCountriesButton_Click. Complete 
 * the getCountriesButton_CLick event handler by typing the code shown in
 * line 23-46 in Program 5-6. Let's take a closer look at the code: 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Line 23:This is the beginning of a try-catch statement, which handles 
 * any exceptions that are thown while the file is being processed. if 
 * an exception is thrown by any statement in the try block, the program
 * jumps to the catch clause in line 50. 
 * 
 * Line 26:This statement declares the string variable countryName, which holds the 
 * lines of text that are read from the fole.
 * 
 * Lines 29-32: After these statements have executed, the Countires.txt file is opened for reading, and the inputFile variable references a StreamReader object that is associated with the file.
 * 
 * Line 35:This statement clears anything that might be displayed in the countriesListBox control. (This prevents the names of the countries from appearing multiple times in the ListBox if the user clicks the Get Countries button multiple times.))
 * 
 * Line 38:This is the beginning of a while loop that iterates as long as the end of the Countries.txt file has not been reached.
 * 
 * Line 41:This statement reads a line of text from the file and assigns it to the countryName variable.
 * 
 * Line 44:This statement adds the countents of the countryName variable to the ListBox
 * 
 * Line 48:This statement closese the file
 * 
 * Step 4: Switch your view back to the Designer and double-click the 
 * exitButton control. in the codeeditor you will see an empty event handler
 * named exitButton_Click. Complete the exitButton_Click event handler by
 * typing the code shown in lines 59-60 in Program 5-6.
 * 
 * Step 5: Save the project. Then press F5 on the keyboard or click the Start Debugging button(|>) on the toolbar to compile and run the application. When the application runs, click the Get Countries button. This should fill the ListBox with the names of the countries from the Countries from the Countries.txt file, as shown in Figure 5-38. Click the Exit button to exit the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-38 The South America application displaying the list of 
 * countries
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 5-6 Completed code for Form1 in the South America application
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace South_America
 * {
 *		public partial class Form1 : Form
 *		{
 *			public Form1()
 *			{
 *				InitializeComponent();
 *			}
 *			
 *			private void getContriesButton_Click(object sender, EventArgs e)
 *			{
 *				try
 *				{
 *					// Declare a variable to hold a country name.
 *					string countryName;
 *					
 *					// Declare a StreamReader variable.'
 *					StreamReader inpoutFile.
 *					
 *					// Open the file and get a Streamreader object.
 *					
 *					inputFile = File.OpenText("Countrues.txt");
 *					
 *					// Clear anything currently in the ListBox.
 *					countriesListBox.Items.Clear();
 *					
 *					// Read the file's contents.
 *					while(!inputFile.EndOFStream)
 *					{
 *						// Get a country name.
 *						countryName = inputFile.ReadLine();
 *						
 *						// Add the country name.
 *						countryName = inputFile,ReadLine();
 *						
 *						// Add the country name to the ListBox.
 *						countryName = inputFile.ReadLine();
 *						
 *						// Add the country name to the ListBox.
 *						countriesListBox.Items.Ass(countryName);
 *					}
 *					
 *					// Close the file.
 *					inoutFile.Close();
 *				}
 *				
 *				catch(Exception ex)
 *				{
 *					// Display an error message.
 *					MessageBox.Show(ex.Message);
 *				}
 *			}
 *			
 *			private void exitButton_Click(object sender, EventArgs e)
 *			{
 *				// Close the form.
 *				this.Close();
 *			}
 *			
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * Calculating a Running Total
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Many programming tasks require you to calculate the total of a series
 * of numbers. In this secion you learn how to calculate the total of a
 * serires of numbers that are stored in a file. For example, suppose
 * you have a file that contains a business's sales for each day of a 
 * week and you need to write a program that calcualtes the total of 
 * all the amounts in the file. The program would read the values in
 * the file and keep a total of the values as they are read. 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Programs that calculate the total of a series of numbers typically use
 * two elements:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * A loop that reads each number in the series
 * 
 * *A variable that accumulates the total of the numbers as they are read
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The variable that is used to accumulate the total of the number is
 * called an accumulator. IT is often said that the loop keeps a running
 * total because it accumulates the total as it reads each number in the
 * series. Figure 5-39 shows the general logic of a loop that calculates
 * a running total.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-39 Logic for calculating a running total
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the loop finishes, the accumulator will contain the total of the
 * numbers that were read by the loop. Notice that the first step in the 
 * flowchart is to set the accumulator variable to 0. This is a critial
 * step. Each time the loop reads a number, it adds it to the accumulator.
 * If the accumulator starts with any value other than 0, it will not contain the 
 * correct total when the loop finishes.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Tutorial 5-7, you will complete an application that calculates a
 * running total of the values in a file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-7: Calculating a Running Total
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Total Sales application that is found
 * in the Chap05 folder of this book's Student Sample Programs.
 * The application's form has already been created and is shown in
 * Figure 5-40. The application also has an accompanying text file named
 * Sales.txt that is stored in the bin\Debug folder, under the project
 * folder. The Sales.txt file contains the amounts shown in Figure5-41.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-40 The Total Sales application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-41 Contents of the Sales.txt file
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the completed application runs and the user clicks the Read Sales
 * & Calculate Total button, the application calculates the total of the 
 * values in the Sales.txt file and displays the total in the totalLabel
 * control.
 * 
 * Step 1: Start Visual Studio. Open the project named Total Sales in
 * the Chap05 folder of this book's Student Sample Programs.
 * Step 2: Open the Form1 form's code in the code editor. Insert the 
 * using System.IO; directive shows in line 10 of Program 5-7 at the
 * end of this tutorial.
 * Step 3: Open the form in the Designer.
 * The form is shown, along 
 * with the names of the important controls, in Figure 5-40.
 * 
 * Double-click the calculateButton control. 
 * 
 * This opens the codeeditor, and you will see an empty handler 
 * named calculateButton_Click.
 * 
 * Complete the calculateButton_Click event
 * handler by typing the code shown in lines 23-56 in Program 5-7.
 * Let's take a closer look at the code:
 * 
 * Line 23: This is the beginning of a try-catch statement, which 
 * handles any exception that are thrown while the file is being 
 * processed.
 * if an exception is thrown by any statement in the try block, 
 * the program jumps to the catch clause in line 52.
 * 
 * 
 * Lines 26-27: These statements declare the decimal variables sales
 * and total. The sales variable holds each value that is read from 
 * the file, and the total variable is used as an accumulator.
 * Notice that the total variable is explicitly initialized to 0.
 * 
 * Lines 30-33:After these statements have executed, the Sales.txt file
 * is opened for reading, and the inputFile variable references a 
 * StreamReader object that is associated with the file.
 * 
 * Line 36: This is the beginning of a while loop that iterates as long
 * as the end of the Countries.txt file has not been reached.
 * 
 * Line 39: This statement reads a line of text from the file, converts
 * it to a decimal, and assigns the result to the sales variable.
 * 
 * Line 42: This statement adds the sales variable to the total variable.
 * 
 * Line 46:This statement closes the file.
 * 
 * Line 49:This statement displays the total, formatted as currency,
 * in the totalLabel control.
 * 
 * Step 4:Switch your view back to the Designer and double-click the
 * exitButton control. 
 * 
 * In the code editor you will see an empty event handler named
 * exitButton_Click. Complete the exitButton_Click event handler
 * by typing the code shown in lines 61-62 in Program 5-7.
 * 
 * Step 5:Save the project. Then, press f5 on the keyboard or click 
 * the Start Debugging button(|>) on the toolbar to compile and run
 * the application. When the application runs, click the Read Sales 
 * & Calculate Total button. The total sales should be calculated and
 * displayed, as shown in Figure 5-42. Click the Exit button to exit 
 * the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-42 The Total Sales application displaying the total sales
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 5-7 Completed code for Form1 in the Total Sales applicartion
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Total_Sales
 * {
 *		public partial class Form1 : Form
 *		{
 *			public Form1()
 *			{
 *				InitializedComponent();
 *			}
 *			
 *			private void calculateButton_Click(object sender, EventArgs e)
 *			{
 *				try
 *				{
 *					// Variables
 *					decimal sales;	// To hold a sales amount
 *					
 *					decimal total = 0m; // Accumulator, set to 0
 *					
 *					//Declare a StreamREader variable.
 *					StreamReader inputFile;
 *					
 *					// Open the file and get a Streamreader object.
 *					
 *					inputFile = File.OpenText("Sales.txt"");
 *					
 *					// Read the file's contents.
 *					while(!inputFile.EndOfStream)
 *					{
 *						// Get a sales amount.
 *						sales = decimal.Parse(inputFile.ReadLine());
 *						
 *						// Add the sales amount to total.
 *						total += sales;
 *						
 *					}
 *					
 *					// Close the file.
 *					inputFile.Close();
 *					
 *					// Display the total.
 *					totalLabel.Text=total.ToString("C");
 *				}
 *				catch (Exception ex)
 *				{
 *					// Display an error message
 *					MessageBox.Show(ex.Message);
 *				}
 *			}
 *			
 *			private void exitButton_Click(object sender, EventArgs e)
 *			{
 *				// Close the form.
 *				this.Close();
 *			}
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 5.7 The OpenFileDialog and SaveFileDialog Controls
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: The OpenFileDialog and SaveFileDialog controls allow your
 * application to display standard Windows dialog boxes for opening and
 * saving files. These allow the user to easily a file's name and
 * location
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * So far, the applications in this chapter that open a file specify the 
 * filename as a string literal. Most Windows users, however, are
 * accustomed to using a dialog box to browse their disk for a file to 
 * open or for a location to save a file. You can use the
 * OpenFileDialog and SaveFileDialog controls to equip applications
 * with standard Windows dialog boxes for these purposes.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The OpenFileDialog Control
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The OpenFileDialog control displays a standard Windows Open dialog box,
 * such as the one shown in Figure 4-43. The Open dialog box is useful in 
 * applications that must open an existing file because it allows the user
 * to browse the system and select the file.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-43 Windows Open dialog box
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Adding the OpenFileDialog Control to Your Project
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To add an OpenFileDialog control to a form, double-click the
 * OpenFileDialog tool under the Dialogs group in the Toolbox window. When
 * the control is created, it does not appear on the form, but in an area
 * at the bottom of the Designer known as the component tray. Figure 5-44
 * shows an example of how an OpenFileDialog control appears in the component
 * tray. The control's default name is OpenFileDialog1. As wish
 * other controls,
 * you can change the contro's Name property to change its name.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-44 An OpenFileDialog control in the component tray
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Displaying an Open Dialog Box
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In code, you can display an Open dialog box by calling the
 * OpenFileDialog control's ShowDialog method. For example, assume 
 * that we have create an OpenFileDialog control and change its name to
 * openFile. The following statement calls the control's ShowDialog method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * openFile.ShowDialog();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In most cases, however, you will want to know whether the user clicked
 * the Open button or the Cancel button to dismiss the Open dialog box.
 * If the user clicked the Open button, it means that the user has
 * selected a file and he or she can open it. If the user clicked the Cancel 
 * button, it means that the user dose not want to proceed.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The ShowDialog method returns a value that indicates which button the 
 * user clicked to dismiss the dialog box. If the clicked the Open button
 * , the value DialogResult.OK is returned. If the user clicked the Cancel
 * button, the value DialogResult.Cancel is returned.  Assuming openFile
 * is the name of an OpenFileDialog control, the following is an example of
 * an if-else statement that calls the ShowDialog method and determines
 * whether the user click the Open button or the Cancel button.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(openFile.ShowDialog() == DialogResult.OK)
 * {
 *	  MessageBox.Show("You clicked the Open button.");
 * }
 * else
 * {
 *		MessageBox.Show("You clicked the Cancel button.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Filename Property
 * /////////////////////////////////////////////////////////////////////
 * When the user selects a file with the Open dialog box, the file's 
 * path and filename are stored in the control's Filename property.
 * Assume openFile is the name of an OpenFileDialog control. The following 
 * code is an example of how you can display an Open dialog box and, if the
 * user clicks the Open button to dismiss the dialog box, open the selected
 * file:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamReader inputFile;
 * 
 * if(openFile.ShowDialog() == DialogResult.OK)
 * {
 *	// Open the selected file.
 *	inputFile = File.OpenText(openFile.Filename);
 *	
 *	// Continue processing the file...
 * }
 * else
 * {
 *	MessageBox.Show("Operation canceled.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at the code. The statement in line 1 declares
 * a StreamReader variable named inputFile. The if statement in line 3 
 * calls the openFile control's ShowDialog method to display an Open
 * dialog box.
 * If the user clicks the Open button to dismiss the dialog box, the 
 * program continues to line 6, when the name of the selected file is
 * retrieved from the control's Filename property and that file is
 * opened. Otherwise (if the user clicks the Cancel button),
 * the program jumps to the else clause in line 10. 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tip When you create an OpenFileDialog control, its Filename property
 * is initially set to the control's default name. For example, it the
 * control's default name is openFileDialog1, then the Filename property 
 * is also set to openFileDialog1. Always be sure to delete the default
 * value of the Filename property.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The InitialDirectory Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * By default, the Open dialog box displays the contents of the user's
 * Documents directory(or folder). You can specify another direct to be
 * initially displayed by storing its path in the InitialDirectory property.
 * For example, the following code stores the path C:\Data in the
 * openFile control's InitialDirectory property before displaying an Open dialog box:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * openFile.InitialDirectory = "C:\Data";
 * if(openFile.ShowDialog() == DialogResult.OK)
 * {
 *	// Continue to process the selected file..
 * }
 * else
 * {
 *		//The operation was canceled.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this example, when the Open dialog box is displayed it shows the 
 * contents of the directory C:\Data.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Title Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * By default, the word Open is displayed in an Open dialog box's title
 * bar. You can change the default text displayed in the title bar by 
 * changing the control's Title property.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The SaveFileDialog Control
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The SaveFileDialog control displays a standard Windows Save As
 * dialog box, such as the one shown in Figure 5-45.
 * 
 * The Save As dialog box allows the user to browse the system and
 * select a location and name for a file that is about to be saved.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-45 Windows Save As dialog box
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Adding the SaveFileDialog Controls to Your Project
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The SaveFileDialog control has mush in common with the OpenFileDialog
 * control. To add a SaveFileDialog control to a form, double-click the 
 * SaveFileDialog tool under the Dialogs group in the Toolbox window. 
 * When the control is created, it appears in the component tray at the 
 * bottom of the Designer. The control will be given a default name such as
 * saveFileDialog1, but you can change the name with the Name property.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Displaying a Save As Dialog Box
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In code, you can display a Save As dialog box by calling the
 * SaveFileDialog contro's ShowDialog method.
 * For example, assume that we have created a SaveFileDialog control and 
 * changed its name to saveFile. The following statement calls
 * the control's ShowDialog method:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * saveFile.ShowDialog();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The method returns a value indicating whether the user clicked the 
 * saved button or the Cancel button to dismis the Save As dialog box.
 * If the user clicks the Save button, the value DialogResult.OK is
 * returned.
 * If the user clicks the Cancel button, the value DialogResult.Cancel
 * is returned. Assume saveFile is the name of a SaveFileDialog control.
 * The following is an example of an if-else statement that calls the
 * ShowDialog method and determines whether the user clicked the
 * Save button or Cancel button:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(saveFile.ShowDialog() == DialogResult.OK)
 * {
 *	MessageBox.Show("You clicked the Save button.");
 * }
 * else
 * {
 *	MessageBox.Show("You clicked the Cancel button.");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Filename Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the user specifies a location and filename with the Save As
 * dialog box, the file's path and filename are stored in the control's
 * Filename property. Assume saveFile is the name of a SaveFileDialog
 * control. The following code is an example of how you can display a 
 * Save As dialog box, and if the user clicks the Save button to dismiss
 * the dialog box, open the selected file:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * StreamWriter outputFile;
 * 
 * if(saveFile.ShowDialog() == DialogResult.OK)
 * {
 *	// Create the selected file.%
 *  outputFile = File.CreateText(saveFile.Filename);
 *  // Write data to the file 
 * }
 * else
 * {
 *		MessageBox.Show("Operation canceled.")
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at the code. The statement in line 1 declares a 
 * StreamWriter variable named outputFile. The if statement in line
 * 3 calls the saveFile control's ShowDialog method to display a 
 * Save As dialog box. if the user clicks the Save button to dismiss
 * the dialog box, the program contrinues to line 6, when the selected
 * name and path are retrieved from the control's Filename property, 
 * and that file is created. Otherwise(if the user clicks the Cancel button),
 * the program jumps to the else clause in line 10.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * ///////////////////////////////////////////////////////////////////// 
 * The InitialDirectory Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * By default, the Save As dialog box displays the contents of the user's
 * Documents directory (or folder). You can specify another directory to
 * be initially displayed by storing its path in the IntialDirectory
 * property. The following code stores the path C:\Data in the saveFile
 * control's InitialDirectory property before displaying a Save As dialog box:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * saveFile.InitialDirectory = "C:\ Data";
 * if(saveFile.ShowDialog() == DialogResult.OK)
 * {
 *		// Continue to process the file
 * }
 * else
 * {
 *		// The operation was cancelled.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this example, when the Save As dialog box is displayed, it
 * shows the contents of the directory C:\Date.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Title Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * By default the word Save As are displayed in a Save As dialog box's
 * title bar. You can change the default text displayed in teh title bar
 * by changing the control's Title property.
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
 * 5.8 Random Numbers
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Conceot Random numbers are used in a variety of applications. The
 * .NET Framework provides the Random class that you can use in C# to
 * generate random numbers.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Random numbers are useful for lots of different prgramming tasks.
 * The following are just a few examples:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * * Random numbers are commonly used in games. For example, computer 
 * games that let the player roll dice use random numbers to represent
 * the values of the dice Program tha show cards being drawn from a 
 * shuffled deck use random numbers to represent the face values of 
 * the cards.
 * 
 * * Random numbers are useful in simulation programs. In some simulations
 * , the computer must randomly decided how a person, animal, insect, or
 * other living being will behave. Formulas can be constructed in which a
 * random number is used to determine various actions and events that take
 * place in the program.
 * 
 * *Random numbers are useful in simulation programs that must randomly select 
 * data for analysis.
 * 
 * *Random numbers are commonly used in computer security to encrypt
 * sensitive data.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The .NET Framework provides a class named Random that you can use in
 * C# to generate random numbers. First you create an object from the 
 * Random class with a statement such as this:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Random rand = new Random();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's dissect the statement into two parts. The first part of the 
 * statement, appearing on the left side of the = operator, it as follows:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Random rand = new Random();
 * |_________|
 *		|
 *	This declares a
 *	var named rand that 
 *	can reference a Random 
 *	object
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Random rand = new Random();
 *				 |___________|
 *					   |
 *				 This creates a 
 *				 Random object
 *				 in memory.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The expression new Random() causes an object of the Random class 
 * to be created in memory. The = operator causes the rand variable
 * to reference the Random object, as illustrated in Figure 5-46.
 * After this statement has executed, we can use the rand variable to
 * work with the Random object.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-46 The rand variable references a Random object
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Next Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Once you have created a Random object, you can call its Next method
 * to get a random integer number. The following code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Declare an int variable.
 *  int number;
 *  // Create a Random object.
 *  Random rand = new Random();
 *  
 *  // Get a random integer and assign it to number.
 *  number = rand.Next();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this code executes, the number variable contains a random integer.
 * If the call the Next method with no arguments, as shown in this
 * example, the returned integer is somewhere between 0 and 
 * 2,147,483,647. Alternatively, you can pass an argument that specifies
 * an upper limit to the generated number's range. In the following
 * statement, the value assigned to number is somewhere between 1 and 99:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number = rand.Next(100);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can also specify a lower limit for the range of numbers. In the 
 * following statement, the value assigned to number is somewhere between
 * 100 and 199:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number = rand.Next(100, 200);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following statement shows another example. It assigns a random
 * integer to number between -50 and +49:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * number = rand.Next(-50,50);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The NextDouble Method
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can call a Random object's NextDouble to ger a random floating-
 * point number between 0.0 and 1.0 (not including 1.0). The following
 * code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // Declare a Double variable.
 *  double number;
 *  
 *  // Create a Random object.
 *  Random rand = new Random();
 *  
 *  // Get a random number and assign it to number.
 *  number = rand.NextDouble();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this code executes, the number variable will contain a random
 * floating-point number in the range of 0.0 up to (but not including)
 * 1.0.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Tutorial 5-8, you will use random numbers to determine whether
 * the heads or tails side of a coin is facing up after the coin has
 * been tossed.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-8: Simulating Coin Tosses
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you create an application that simulates the 
 * tossing of a coin. Each time the user tosses the coin, the application
 * uses a Random object to get a random integer in the range of 0 through
 * 1. If the random number is 0, it means the tails side of the coin is
 * up, and if the random number is 1, it means the heads side is up. The 
 * application displays an image of a coin showing wither heads or tails
 * , depending on the value of the random number.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio and begin a new Windows Forms Application 
 * project named coin toss.
 * 
 * Step 2: Set up the application's form as shown in Figure 5-47. Notce
 * that the form's Text property is set to Coin Toss. The names of the 
 * controls are shown in the figure. As you place each of the conmtrols
 * on the form, refer to Table 5-1 for the relevant property settings.
 * (Make sure the headsPictureBox control's Visible property is set to
 * True, and the tailsPictureBox control's Visable property is set to
 * False. This will cause the coin to initially appear heads up when the
 * application runs.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-47 Initial setup of the Coin Toss form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Table 5-1 Control property settings
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 3: After you have set all of the control properties as shown in 
 * Table 5-1, move the PictureBox controls so one is on top of the 
 * other, as show in Figure 5-48. (In the figure, the headsPictureBox
 * control is on top, but it really doesn't matter which is on top.) Also
 * , reduce the width of the form and position the button controls as 
 * shown in the figure.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-48 The controls repositioned and the form size adjusted
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Now you will create the Click event handlers for the Button
 * controls. At the end of this tutorial, Program 5-8 shows the completed
 * code for the form. You will be instructed to refer to Program 5-8 as 
 * you write the event handlers.
 * In the Designer, double-click the tossButton control. This opens the 
 * code editor, and you will see an empty event handler named tossButton
 * _Click. Complete the tossButton_Click event handler by typing the code
 * shown in lines 22-44 in Programs 5-8. Let's take a closer look at the
 * code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Line 23: This statement declares an int variable named sideup. This 
 * variable is used to hold a random number that indicates which side of
 * the coin is up.
 * 
 * Line 26: This statement does the following:
 *		
 *		*It declares a variable named rand that can be used to reference a
 *		Random object.
 *		
 *		* It creates a Random object in memory.
 *		
 *		* The = operator causes the rand variable to reference the Random
 *		object.
 * 
 * Line 30: This statement gets a random integer in the range of 0 through 1
 * and assigns it to the sideup variable. The random integer represents
 * which side of the coin is facing up. The value 0 means that the tails
 * side is facing up, and the value 1 means that the heads side is facing up.
 * 
 * Lines 33-44: This if-else statement displays the side of the coin that 
 * is facing up. If sideUp equals 0, then the statements in line 36 and 
 * 37 display the tailsPictureBox control and hide the headsPictureBox
 * control. If sideup equals 1, then the statements in lines 42 and 43
 * display the headsPictureBox control and hide the tailsPictureBox.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Switch your view back to the Designer and double-click the 
 * exitButton control. In the code editor you will see an empty event
 * handler named exitButton_Click. Complete the exitButton_Click event 
 * handler by typing the code shown in lines 49-50 in Program 5-8.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 6: Save the project. Then, press F5 on the keyboard or click the
 * Start Debugging button(|>) on the toolbar to compile and run the
 * application. When the application runs, click the Toss button several
 * times to simulate several coin tosses. When you are finished, click
 * the Exit button to exit the application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 5-8 Completed code for Form1 in the Coin Toss application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Coin_Toss
 * {
 *		public partial class Form1 : Form
 *		{
 *			public Form1()
 *			{
 *				InitializeComponen();
 *			}
 *			
 *			private void tossButton_Click(object sender, EventArgs e)
 *			{
 *				// Variable to indicate which side is up
 *				int sideUp;
 *				
 *				// Create a Random object.
 *				Random rand = new Random();
 *				
 *				// Get a random integer in the range of 0 through 1.
 *				// 0 means tails up, 1 means heads up.
 *				sideUp = rand.Next(2);
 *				
 *				// Display the side that is up.
 *				
 *				if(sideUp == 0)
 *				{
 *					// Display tails up.
 *					tailsPictureBox.Visible = true;
 *					headsPictureBox.Visible = false;
 *				}
 *				else
 *				{
 *					// Display heads up.
 *					headsPictrueBox.Visible = true;
 *					tailsPictureBox.Visible = false;
 *				}
 *			}
 *			
 *			private void exitButton_Click(object sender, EventArgs e)
 *			{
 *				// Close the form.
 *				this.Close();
 *			}
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *						Random Number Seeds
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The numbers that are generated by the Random class are not truly
 * random. Indtead, they are pseudorandom numbers that are calculated by
 * a formula. The formula used to generate random numbers has to be 
 * initialized with a value know as the seed value. The seed value is 
 * used in the calculation that returns the next random number in the 
 * series. When a Random object is created in memory, it retrieves
 * the system time from the computer's internal clock and uses that as
 * the seed value. The system time is an integer that represents the 
 * current date and time, down to a hundredth of a second.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * If a Random object uses the same sed value each time it is created,
 * it always generates the same series of random numbers. Because the 
 * system time changes every hundredth of a second, it is the preferred
 * value to use as the seed in most cases. However, you can specify a
 * different integer value as the seed, if you desire, when you create a
 * Random object. Here is an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Random rand = new Random(1000);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this example, the Random object that is created uses 1000 as the 
 * seed value. Each time a Random object is created with this statement
 * , it generates the same series of random numbers. That may be desirable
 * in some applications, when you always want to produce the same set of 
 * pseudorandom numbers,
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *							5.9 The Load Event 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept:
 * When an application's form loads into memory, an event
 * known as the Load event takes place. You can write an event handler
 * for the Load event, and that handler will execute just before the 
 * form is displayed.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you run an application, the application's form loaded into
 * memory and an event known as the Load event takes place.
 * The Load event takes place before the form is displayed on the
 * screen. If you want execute some code at this point, you can write
 * a Load event handler containing the desired code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To create a Load event handler for a form, simply double-click any
 * area of the form in the Designer window where there is no other
 * control. The code editor will open with an empty Load event handler.
 * If the form is named Form1, the event handler is named Form1_Load.
 * 
 * Any code that you write inside the event handler executes when the 
 * form's Load event takes place. Here is an example of a Load event
 * handler in a form named Form1:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void Form1_Load(object sender, EventArgs e)
 * {
 *		MessageBox.Show("Prepare to see the form!");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Keep in mind that the Load event happens before the form is displayed
 * on the screen. When the application containing this event handler runs,
 * the message box is displayed before the form appears.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Load event handler are useful for performing setup operations.
 * In Tutorial 5-9, you will complete an application that uses a Load
 * event handler to read items from a text file and adds those items
 * to a ListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-9: Creating a Load Event Handler
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Load Event application that is 
 * found in the Chap05 folder of this book's Student Sameple Programs.
 * 
 * This application is a variation of the South America application that
 * you created in Tutorial 5-6. This version of the application uses a 
 * Load event handler to read the contents of the Conutries.txt file and
 * adds those items to a ListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The application's form has already been created and is shown in 
 * Figure 5-49. The application also has an accompanying text file named
 * Countries.txt that is stored in the bin\Debug folder, under the 
 * project folder. The Countries.txt file contains the names of the
 * countries 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-49 The Load Event application's form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio. Open the project named Load Event in the 
 * Chap05 folder of this book's Student Sample Programs.
 * 
 * Step 2: Open the Form1 form's code in the code editor. Insert the 
 * using System.IO; directive shown in line 10 of Program 5-9 at the
 * end of this tutorial. This statement is necessary because you will
 * be using the StreanReader class, which is part of the System.IO
 * namespace in the .NET Framework.
 * 
 * Step 3: Open the Form1 form in the Designer. The form is shown,
 * along with the names of the important controls, in Figure 5-49.
 * Double-click any part of the form that does not contain a control.
 * (Be sure not to click the Label control, the ListBox control, 
 * or the Button control.)
 * 
 * This opend the code editor, and you will see an empty handler
 * named Form1_Load. 
 * Complete the Form1_Load event handler by typing the code shown 
 * in lines 23-46 in Program 5-9.
 * Let's take a closer look at the code: 
 * 
 * Line 23:This is the beginning of a try-catch statement,
 * which handles any exceptions that are thrown while the
 * file is being processed. if an exception is thrown by
 * any statement in the try block, the program jumps to 
 * the catch clauses in line 47.
 * 
 * Line 26: This statement declares the string variable countryName,
 * which holds the lines of text that are read from the file.
 * 
 * Lines 29-32: After these statements have executed, the Countries.txt
 * file is opened for reading, and the inputFile variable references
 * a StreamReader object that is associated with the file.
 * 
 * 
 * Line 35: this is the beginning of a while loop that iterates as
 * long as the end of the Countries.txt file has not been reached.
 * 
 * Line 38: This statement reads a line of text from the file and 
 * assigns it to the countryName variable.
 * 
 * Line 41:This statemetn adds the contents of the countryName
 * variable to the ListBox.
 * 
 * Line 45: This statement closes the file.
 * 
 * 
 * Step 4:Switch your view back to the Designer and double-click the 
 * exitButton control. In the code editor you will see an empty event
 * handler named exitButton_Click. Complete the exitButton_Click event
 * handler by typing the code shown in lines 56-57 in Program 5-9.
 * 
 * Step 5: Save the project. Then, press f5 on the keyboard or click the 
 * start Debugging button (|>) on the toolbar to compiler and run the
 * application. When the application runs, the ListBox should appear 
 * filled with the names of the countries from the Countries.txt file,
 * as shown in Figure 5-50. Click the Exit button to exit the
 * application.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-50 The Load Event application displaying the list of 
 * countries
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * namespace Load_Event
 * {
 *		public partial class Form1 : Form
 *		{
 *			public Form1()
 *			{
 *				InitializeComponent();
 *			}
 *			
 *			private void Form1_Load(object sender, EventArgs e)
 *			{
 *				try
 *				{
 *				
 *				}
 *				catch(Exception ex)
 *				{
 *					// Display an error message.
 *					MessageBox.Show(ex.Message);
 *				}
 *			}
 *			
 *			private void exitButton_Click(object sender, EvebtArgs e)
 *			{
 *				// Close the form.
 *				this.Close();
 *			}
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Program 5-9 Completed code for Form 1 in the Load Event applicaion
 * /////////////////////////////////////////////////////////////////////
