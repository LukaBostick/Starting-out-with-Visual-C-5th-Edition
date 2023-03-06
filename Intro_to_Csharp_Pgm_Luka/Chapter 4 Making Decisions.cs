using System

namespace Chapter4MakingDecisions
{
	class testing
	{
		static void Main(string[] args)
		{
			string s1 = "asjdasdj";
			Console.WriteLine(s1);
		}
	}
}

/*
 /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *					Chapter 4 Making Decisions
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 *								Topics
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 4.1 ~ Decision Structures and the if Statement
 * 
 * 4.2 ~ The if-else Statement
 * 
 * 4.3 ~ Nested Decision Structures
 * 
 * 4.4 ~ Logical Operators
 * 
 * 4.5 ~ bool Variables and Flags
 * 
 * 4.6 ~ Comparing Strings
 * 
 * 4.7 ~ Preventing Data Conversion Exceptions with the TryParse Methods
 * 
 * 4.8 ~ Input Validation
 * 
 * 4.9 ~ Radio Buttons and Check Boxes
 * 
 * 4.10 ~ The switch Statement
 * 
 * 4.11 ~ Introdution to List Boxes
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *			4.1 Decision Structures and the if Statement
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	Concept A decision structure allows a program to preform actions only
 *	under certain conditions. In code, you can use the if statement to 
 *	write a simple decision structure.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * A control structure is a logical design that controls the order in
 * which a set of statements execute. So far in this book, we have used
 * only the simplest type of control structure: the sequence structure.
 * 
 * A sequence structure is a set of statements that execute in the order
 * that they appear. For ex, the following code sample is a sequence 
 * structure because the statements execute from top to bottom.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int ageInYears, ageInDays;
 * ageInYears = int.PArse(ageTextBox.Text);
 * ageInDays = ageInYears * 365;
 * daysLabel = ageInDays.ToString();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Although the sequence structure is heavily used in programming, it
 * cannot handle every type of task.
 * 
 * Some problems simply cannotbe solved by performing a set of ordered
 * steps, one after the other. For example, consider a pay-calculating
 * program that determines whether an employee has worked overtime.
 * IF the employee has worked more than 40 hours, he or she gets paid
 * extra for all hours over 40. Otherwise, the overtime calculation
 * should be skipped. Programs like this require a different type of
 * control structure: one that can execute a set of statements only user
 * certain circumstances. 
 * 
 * This can be accompliched with a decision structure. 
 * (Decision structures are also know as selection structures.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In a decision structure's simplest form, a specific action is 
 * preformed only if certain conditions exists. IF the condition does
 * not exist, the action is not preformed.
 * 
 * The flowchart shown in Figure4-1 shows how the logic of an everyday
 * decision can be diagrammed as a decision structure.
 * 
 * The diamond symbol represents a true-false condition.
 * 
 * If the condition is true, we follow one path, which leads to an
 * action being preformed.
 * 
 * IF the conditions is false, we follow another path, which skips the
 * action.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 4-1 A simple decision structure
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the flowchart, the diamond symbol indicates some condition that
 * must be tested.
 * 
 * IN this case, we are determining whether the condition Cold outside
 * is true or false.
 * 
 * If this condition is true, the action Wear a coat is perfromed. 
 * 
 * IF the conditrion is false, the action is skipped.
 * 
 * The action is conditionally executed because it is performed only
 * when a certain condition is true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Programmers call the type of decision structure show in Figure 4-1
 * a single-alternative decision structure because it provides only
 * one alternative path of execution. IF the condition in the diamaond
 * symbol is true, we take the alternative path. Otherwise, we exit
 * the structure. Figure 4-2 shows a more elaborate example, where three
 * actions are taken only when it is cold outside.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 4-2 A decision structure that performs three actions if it is
 * cold outside
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IN C#, you use the if statement to write a single-alternative decision
 * structure. Here is the general format of the if statement:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(expression)
 * {
 *		statement;
 *		statement;
 *		etc.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The statement begins with the word if, followed by an expression 
 * enclosed in a set of parentheses. BEginning on the nect line is a set
 * of statements enclosed in curly braces.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The expression that appears inside the parentheses is a Boolean
 * expression.
 * 
 * A Boolean expression is one that can be evaluated as either
 * true or false.
 * 
 * When the if statement executes, the Boolean expression is tested.
 * 
 * If it is true, the statements that appear inside the curlt
 * braces are executed. 
 * 
 * If the Boolean expression is false, however, the statements inside
 * the curlt braces are skipped. We say that the statements inside the 
 * curly braces are conditionally executed becauses they are executed
 * only if the Boolean expression is true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * If  you are writing an if statement that has only one conditionally
 * executed statement, you do not have to enclose the conditionlly 
 * executed statement inside curly braces. Such an if statement can be
 * written in the following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if (expression) 
 *	  statement;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When an if statement written in this format executes, the Boolean
 * expression is tested. If it is true, the one statement that appears 
 * on the next line is executed. If the Boolean expression is false,
 * however, that one statement is skipped.
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * Although the curly braces are not required when there is only one 
 * conditionally executed statement, it is still a good idea to use them
 * , as shown in the following general format:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if (expression)
 * {
 *		statement;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * This is a good style for writing if statements because it minimizes 
 * errors. Remember, if you have more than one conditionally executed 
 * statement, those statements must be enclosed in curly braces. If you
 * get into the habit of always enclosing the conditionally executed 
 * statementsin a set of curlt braces, it's less likely that you will
 * forget them.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Boolean Expression and Relational Operators
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Boolean expressions are named in honor of the English mathmaticaian
 * George Boole. In the 1800s, Boole invented a system of mathematics in
 * which the abstract concepts of true and false can be used in
 * computations.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Typically, the Boolean expression that is tested by an if statement
 * is formed with a relational operator. A relational operator determines
 * wheather a specific relationship exists between two values.
 * 
 * For example, the greater than operator (>) determines whether one 
 * value is greater than another. The equal to operator (==) determines
 * whether two values are equal. Table 4-1 lists the relational
 * operators that are available in C#
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Table 4-1 Relational operators
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Operator						Meaning
 * 
 *	* >		~				  Greater than
 *	* <		~				  Less than
 *	* >=	~				  Greater than or equal to
 *	* <=	~				  Less than or equal to 
 *	* ==	~				  Equal to
 *	* !=	~				  Not equal to
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	The following is an example of an expression that uses the greater
 *	than (>) operator to compare two variables, length and width:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *				length > width	
 *	//////////////////////////////////////////////////////////////////////
 *	This expression determiens whether the value of the length variable
 *	is greater than the value of the width var. IF the length is greater
 *	than width, the value of the expression is true. Otherwise, the value
 *	of the expression is false. The following expresion uses the less 
 *	than operator (<) to determine whether length is less than width:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *				length < width
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Table 4-2 shows examples of several Boolean expressions that compare 
 *	the variables x and y. 
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *				Table 4-2 Boolean expressions using relational
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	x > y~ Is x greater than y?
 *	
 *	x < y~ Is x less than y?
 *	
 *	x >= y~ Is x greater than or equal to y?
 *
 *	x <= y~ Is x less than or equal to y?
 *	
 *	x == y~ Is x equal to y?
 *	
 *	x != y~ Is x not equal to y?
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	The >= and <= Operators
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Two of the operators, >= and <=, test for more than one relationship.
 *	
 *	The >= operator determiens whether the operand on its left is greater 
 *	than ot equal to the ...
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	//////////////////////////////////////////////////////////////////////
 *						4.2 The if-else Statement
 *	//////////////////////////////////////////////////////////////////////
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Concept An if-else statement will execute one block of statements if
 *	its Boolean expression is true or another block if its boolean
 *	expression.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	The previous section introdices the single-alternative decision
 *	structure(the if statement), which has one alternative path of
 *	execution. Now, we will look at the dual-alternative decision
 *	structure, which has two possible paths of execution is false.
 *	Figue 4-8 shows an example flowchart for a dual-alternative
 *	decision structure.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Figure 4-8 A dual-alternative decision structure
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	The decision structure in the flowchart test the expression
 *	temperature < 40. if this expression is true, the message "A little 
 *	cold, isn't it" is displayed. If the expression is false, the message
 *	"Nice weather we're having." is displayed.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	In code, we write a dual-alternative dexiasion strucure as an if-else
 *	statement. Here is the general format of the if-else statement:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	if(expression)
 *	{
 *	statement; ]
 *	statement; | ---- If the Boolean expression is true,
 *	etc.	   ]        this set of statements is executed.
 *	}
 *	else
 *	{
 *	statement; ]
 *	statement; | ---- If the Boolean expression is false, this set of
 *	etc.       ]       statements is executed.
 *	}
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	An if-else statement has two parts: an if calause and an else clause.
 *	Just like a regular if statement, the if-else statement tests a 
 *	Boolean expression. IF the Boolean expression is true, the set if
 *	statements following the if clause is executed.
 *	
 *	If the Boolean expression is false, the set of statements following the
 *	else clause is executed.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	If either set of conditionally executed statements contains only one 
 *	statement, the curly braces are not required. For example, the following
 *	general format shows only one statement following statement following
 *	the else clause:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	if (expression)
 *		statement;
 *	else
 *		statement;
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Although the curly braces are npt required when there is only one
 *	conditionally executed statement, it is still a good idea to use them,
 *	as shown in the following general format:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	if(expression)
 *	{
 *		statement;
 *	}
 *	else
 *	{
 *		statement;
 *	{
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	When we discussed the regulat if statement, we mentioned that this is a
 *	good style of proframming because ut cuts down on errors. IF there is
 *	more than one conditionally executed statement following either the if 
 *	clause of the else clause, those statements must be enclosed in curly
 *	braces. If you get into the habit of always enclosing the conditionally
 *	executed statements in a set of curly braces, it's less likely that you
 *	will forget them.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	In Tutorial 4-2, you complete an application that uses an if-else
 *	statement.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Tutorial 4-2: Completing the Payroll with Overtime Application
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	At a particular business, if an employee works more than 40 hours in a
 *	week, it is said that the employee has worked overtime. For example,
 *	an employee that has worked 45 hours in a week has worked 5 overtime
 *	hours. Employees that work overtime get paid their regular hourl pay
 *	rate for the first 40 hours plus 1.5 their regular hourly pay rate
 *	for all hours over 40. In this tutorial, you complete a payroll
 *	application that calculates an employee's gross pay, including
 *	overtime pay.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	The application allows the user to enter the number of hours worked
 *	and the hourly pay rate into TextBoxes. When the user clicks a button,
 *	the gross pay iis calculated in the following manner:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	If the hours worked is greater than 40:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	base pay = hourly pay rate x 40
 *	overtime hours = hours worked - 40
 *	overtime pay = overtime hours x hourly pay rate x 1.5
 *	gross pay = base pay x overtime pay 
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Else:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	gross pay = hours worked x hourly pay rate
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	To save time, the project has already been started for you, and the
 *	application's form has already been created.
 *	
 *	To complete the project, follow the steps in this tutorial.
 *	
 *	Step 1:	Start Visual Studio. Open the project named Payroll with
 *	Overtime in the Chap04 folder of this book's Student Sample Programs.
 *	
 *	Step 2: Open the Form1 form in the Designer. The form is shown, along
 *	with the names of the important controls, In figure 4-9.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Figure 4-9 The Payroll with Overtime form
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Step 3: Now, you will create the Click event handlers for the Button
 *	controls.
 *	
 *	At the end of this tutorial, Program 4-2 shows the completed
 *	code for the form.
 *	
 *	You will be instructed to refer to Program 4-2 asyou write the event
 *	handlers.
 *	
 *	In the Designer, double-click the calculateButton conrol.
 *	
 *	This opens the code editor, and you see an empty event handler named
 *	calculateButton_Click.
 *	
 *	Complete thecalculateButton_Click event handler by typing the code
 *	shown in lines 22- 69 in Program 4-2. 
 *	
 *	Let's take a closer look at the code:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Line 22: This is the beginning of a try-catch statement. The try block
 *	appears in lines 24-63, and the catch block appears in lines 67-68.
 *	
 *	The purpose of this try-catch statement is to gracefully respond if
 *	the user enters invalid input. IF an exception is thrown by any
 *	statment inside the try block,
 *	the program jumps to the catch block,
 *	and line 68 displays an error message.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Lines 25-26: These statments declare the following named constants:
 *	
 *		*BASE_HOURS, a constant secimal set tot he value 40.
 *		THis is the number of hours an employee can work in a week without
 *		getting overtime pay.
 *		
 *		*OT_MULTIPLIER, a constant decimal set to the value 1.5.
 *		This is the pay rate multiplier for overtime hours.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Line 29-34 Theses statements declare the following variables:
 *	
 *	*hoursWorked, a decimal variable to hold the number of hours worked
 *	
 *	*hourlyPayRate, a decimal variable to hold the hourly pay rate
 *
 *	*basePay, a decimal variable to hold the pay for 40 or less hours
 *	
 *	*overtimeHours. a decimal variable to hold the number of overtime hours worked
 *	
 *	*overtimePay, a decimal variable to hold the amount of overtime pay
 *	
 *	*grossPay, a decimal variable to hold the gross pay
 *	//////////////////////////////////////////////////////////////////////
 *
 *	//////////////////////////////////////////////////////////////////////
 *	Line 37: This statement  converts the hoursWorkedTextBox control's
 *	Text property to a decimal and assigns the result to the hoursWorked
 *	variable.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Line 38: This statement converts the hourlyPayRateTextBox
 *	control's Text property to a decimal and assigns the result to the 
 *	hourlyPayRate variable.
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Line 41: This if state,emt determines whether hoursWorked is greater 
 *	than BASE_HOURS (40). If so, the statements in lines 43-54 are 
 *	executed. Otherwise the statements in lines 58-59 are executed.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Lines 43-54: Theses statements, which are executed only if the hours
 *	worked are greater than 40, make all the necessary calculations to
 *	determine gross pay with overtime:
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	*Line 44 calcuates the base pay, which is the amount of pay for the first
 *		40 hours.
 *		
 *	*Line 47 calculates the number of overtime hours, which is the number
 *	of hours over 40.
 *	
 *	*Lines 50 and 51 calcuate the amount of overtime pay, which is the pay
 *	for the hours over 40.
 *	
 *	*Line 54 calculates the gross pay, which is the amount of base pay plus
 *	the amount of overtime pay. The result is assigned to the grossPay
 *	variable.
 *	
 *	*Line 59: This statement, which is executed only if the hours worked 
 *	are 40 or less, calcuates the gross pay and assigns the result to the 
 *	grossPay variable.
 *	
 *	
 *	Line 63: This statement converts the value of the grossPay variable to a 
 *	string, formatted as surrency, and assigns the result to the
 *	grossPayLabel control's Text property.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Step 4: Switch your view back to the Designer and double-click the
 *	clearButton control.
 *	
 *	In the code editor you see an empty event handler named clearButton_Click.
 *  Complete the clearButton_Click event handler by typing the code shown
 *  in lines 74-80 in Program 4-2. These statments clear the TextBoxes and 
 *  the grossPayLAbel control and sets the focus to the hoursWorkedTextBox
 *  control.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Step 5: Switch your view back to the Designer and double-click the
 *	exitButton control. In the code editor you see an empty event handler
 *	named exitButton_Click. Complete the exitButton_Click event handler by
 *	typing the code shown lines 85-86 in Program 4-2.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Step 6: Save the project and run the application. First, enter 40 for
 *	the number of hours worked and 20 for the hourly pay rate.
 *	
 *	Click the Calculate Gross Pay button, and the application should display
 *	$800.00 as the gross pay.
 *	
 *	No overtime hours were worked, so the grosspay is simply calcuated as
 *	hours worked x hourly pay rate.
 *	
 *	Click the clear button. 
 *	
 *	Enter 50 for the number of hours worked and 20 for the hourly pat rate.
 *	
 *	Click the Calculate Gross Pay button, and the application should display
 *	$1,100.00 as the gross pay.
 *	
 *	This time, more than 40 hours were worked, so the application calculated
 *	the gross pay to include overtime pay.
 *	
 *	Continue to test the application as you wish. When you are finshed, 
 *	click the Exit button, and the form, should close.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	//////////////////////////////////////////////////////////////////////
 *						4.3 Nested Decision Structures
 *	//////////////////////////////////////////////////////////////////////
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Concept To test more than one condition, a decision structure can
 *	be nested inside another decision structure.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	In Section 4.1, we mentioned that a control structure determines the 
 *	order in which a set of statements execute. Programs are usually designed
 *	as combinations of different control structures. For example, Figure
 *	4-10 shows a flowchart that combines a decision structure with two
 *	sequence structures.
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Figure 4-10 Combining sequence structures with a decision structure
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	The flowchart in Figure 4-10 starts with a sequence strcture. Assuming
 *	you have an outdoor thermometer in your window, the first step is Go 
 *	to the window, and the next step is Read thermometer. A decision 
 *	structure appears next, testing the condition Cold outside. IF this 
 *	is true, the action Wear a coat is preformed. Another sequence
 *	structure appears next.
 *	The step Open the door is performed, followed by Go outside.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Quite often, structures must be nested inside other structures.
 *	
 *	For example, look at the partial flowchart in Figure 4-11.
 *	IT shows a decision structure with a sequence structure nested inside. 
 *	
 *	The decision structure test the condition Cold outside. If that condition
 *	is true, the steps in the sequence structure are executed.
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Figure 4-11 A sequence structure nested inside a decision structure
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	You can also have nested decision structures, which are decision
 *	structures that appear inside other decision structures. 
 *	This is commonly done in programs that need to test more than one
 *	condition.
 *	For ex, consider a program that determines whether a bank customer 
 *	qualifies for a loan. To qualify, two conditions must exist:(1) 
 *	THe customer must earn at least $40,000 per year, and (2) the customer
 *	must have been employed at his or her current job for at least 2 years.
 *	
 *	Figure 4-12 shows a flowchart for an algorithm that could be used in such 
 *	a program. Assume that the salary variable contrins the customer's
 *	annual salary, and the yearsOnJob variable contrins the number of 
 *	years that the customer has worked on his or her current job.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Figure 4-12 A nested decision structure
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	IF we follow the flow of execution, we see that the Boolean
 *	expression salary >= 40000 is tested. if thus expression is false,
 *	there is no need to perfrom further tests; we know that the customer
 *	does not qualify for the  loan. If the expression is true, however, we 
 *	need to test the second condition. This is done with a nesteed decision
 *	structure that tests the Boolean expression yearsOnJob >= 2. IF this 
 *	expression is true, then the customer qualifies for the loan. If this
 *	expression is false, then the customer does not qualify. In Tutorial
 *	4-3, you create an application that perfroms this algorithm.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Tutorial 4-3: Completing the Loan Qualifier Application
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	In this tutorial, you complete an application that determines whether
 *	a person qualifies for a loan. 
 *	
 *	To qualify for the loan, the person must earn a salary of at least
 *	$40,000 and must have been employed at this or her current job for
 *	at least 2 years.
 *	
 *	To save time, the project has already been started for you, and
 *	the applciation's form has aleady been created. To complete the project,
 *	follow the steps in this tutorial.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Step 1: Start Visual Studio. Open the project named Loan Qualifier in 
 *	the Chap04 folder of this book's Student Sample Programs.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Step 2: Open the Form1 form in the Designer. The form is shown, along
 *	with the names of the inmpoerant controls, in Figure 4-13.
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	//////////////////////////////////////////////////////////////////////
 *	Figure 4-13 The Loan Qualifier form
 *	//////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Step 3: Now, you will create the Click event handlers for the Button
 *	controls. At the end of this tutorial, Program 4-3 shows the completed
 *	code for the form. You will be instructed to refer to Program 4-3 as
 *	you write the event handlers.
 *	
 *	In the Designer, double-click the checkButton control.
 *	This opens the code editor, and you see an empty event handler named
 *	checkButton_Click. Complete the checkButton_CLick event handler by
 *	typing the code shown in lines 22-62 in Program 4-3.
 *	
 *	Let's take a closer look at the code:
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Line 22: This is the beginning of a try-catch statement. The try block
 *	appears in lines 60-61. The purpose of this try-catch statement is to
 *	gracefully respond if the user enters invalid input.
 *	
 *	If an exception is thrown by any statement inside the try block, 
 *	the program jumps to the catch block, and line 61 displays
 *	an error message.
 *	
 *	Lines 25-26: These statements declare the following named constants:	
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	* MINIMUM_SALARY, a constant decimal set to the value 40,000, which is 
 *	the minimum salary a person must earn to qualify for the loan
 *	
 *	* MINIMUM_YEARS_ON_JOB, a constant int set to the value 2,
 *	which is the minimum number of years a person must have been at his or
 *	her current job to qualify for the loan
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Lines 29-30: These statements declare the following variables:
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	* salary, a decimal variable to hold the salary
 *	
 *	* yearsOnJob, an int variable to hold the number of years at the 
 *	current job
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Lines 33-34: These statements get the salary and years at the current
 *	job from the TextBox controls and assign those values to the salary
 *	and yearsOnJob variables.
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Line 37: This if statement determines whether salary is greater than
 *	equal to MINIMUN_SALARY. If so, the program contrinues at line 39.
 *	Otherwise, the program jumps to the else caluse on line 51, and in 
 *	lines 54-55 the string "Minimum salary requirement not met." is 
 *	assigned to teh decisionLabel control's Text property. 
 *	
 *	Line 39: THis if statement determiens whether yearsOnJob is greater
 *	than or equal to MINIMUM_YEARS_ON_JOB. If so , the program continues
 *	at line 42, where the string "You qualify for the loan."
 *	
 *	is assigned to teh decisionLAbel control's Text property.
 *	
 *	Otherwise, the program jumps to the else clause in line 44,
 *	and in lines 47-48 the string "Minimum years at current job not met."
 *	
 *	is assigned to the decisionLAbel control's Text property.
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Step 4: Switch your view back to the Designer and double-click the
 *	clearButton control. IN the code editor you see an empty event handler
 *	named clearButton_CLick. Complete the clearButton_Click event handler
 *	by typing the code shown in lines 67-73 in program 4-3.
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Step 5: Switch your view back to the Designer and double-click the 
 *	exitButton control. In the code editor you see an empty event handler
 *	named exitButton_Click.
 *	Complete the exitButton_Click event handler by typing the code shown
 *	in lines 78-79 in Program 4-3.
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	Step 6: Save the project and run the application. First, enter 45000
 *	for the salary and 1 for the years at current job. Click the Check
 *	Qualifications button, and the application should display the message
 *	"Minimum years at current job not met."
 *	Click the Clear button. Enter 35000 for the salary and 5 for the years
 *	current job. Click the Check the Clear button, and the applcation should
 *	display the message "Minimum salary requirement not met."
 *	
 *	Click the Clear button. Enter 45000 for the salary and 5 for the years
 *	at current job. Click the Check Qualifications button, and the
 *	application should display the message "You qualify for the loan."
 *	
 *	Continue to test the application as you wish. When you are finished,
 *	click the Exit buitton, and the form should close.
 *	/////////////////////////////////////////////////////////////////////

///  ////////////////////////////////////////////////////////////////////
///	 Indentation and Alighment in Nested Decision Structures
///  /////////////////////////////////////////////////////////////////////
///  
///  ////////////////////////////////////////////////////////////////////
///	 For debugging purposes, it's important to use proper alignment and 
///	 indentation in a nested if statement. This makes it easier to see
///	 which actions are performed by each part of the structure.
///	 
/// For example, the following code is funcationally equivalent
/// to lines 37-56 in Program 4-3.
/// 
/// Although this code is logically correct ,it would be very difficult
/// to debug because it is not properly indented.
///  /////////////////////////////////////////////////////////////////////
///	 skip....
//// ///////////////////////////////////////////////////////////////////
///		
/// /////////////////////////////////////////////////////////////////////
///	Testing a Series of Conditions
/// ////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// In Tutorial 4-3, you saw how a program can use nested decision 
/// structures to test more than one Boolean expression.
/// 
/// It is not uncommon for a program to have a series of Boolean
/// expression to test and the preform an action, depending on which
/// expression is true.
/// 
/// One way to accomplish this it to have a decision structure with
/// numerous other decision structures nested insude it. For example, 
/// look at the Grader application in the Chap04 folder of this book's
/// Sample Programs.
/// 
///  ////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// Figure 4-15 shows the application's form, with the names of several
/// control. When you run the application, you enter a numeric test score 
/// into the testScoreTexBox control and click the determineGradeButton
/// control; a grade is then displayed in the gradeLAbel control.
/// ////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
///	Figure 4-15 The Grader application's form
/// ////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// The following 10-point grading scale is used to determine the grade:
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////	Test Score				Grade
///		90 and above			  A
///		80-89					  B
///		70-79					  C
///		60-69					  C
///		Below 60				  F
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// The logic of determining the grade can be expressed like this:
/// 
/// If the test score is less than 60, then the grade is "F."
///	Otherwise, if the test score is less than 70, than the grade is "D."
/// Otherwise, if the test score is less than 80, than the grade is "C."
/// Otherwise, if the test score is less than 80, than the grade is "."
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *	
 *//////////////////////////////////////////////////////////////////////
*/