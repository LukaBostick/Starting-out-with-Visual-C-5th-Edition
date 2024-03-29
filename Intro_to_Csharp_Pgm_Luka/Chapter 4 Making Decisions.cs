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
/// Otherwise, if the test score is less than 80, than the grade is "B."
/// Otherwise, the grade is "A."
///////////////////////////////////////////////////////////////////////
//
/// /////////////////////////////////////////////////////////////////////
/// This logic requires seceral nested decision structures, as shown in 
/// the flowchart in Figure 4-16. 
////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////Figure 4-16 Nested decision structure to determine a grade
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
///Open the code editor and look at the determineGradeButton_Click event
///handler, shown in the following code sample. The nested decision
///structure appears in 12-41.
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
///				The if-else-if Statement
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
///Even though the Grader application previously shown is a simple ex, 
///the logic of the nested decision structure is fairly complex. C#
///provides a special version of decision structure know as the if-else-if
///statement, which makes this type of logic simpler to write. You write
///the the if-else-if statement using the following general format:
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
////When the statement executes, BooleanExpression_1 is tested. If 
///BooleanExpression_1 is true, the set of statements that immediately
///follows is executed, and the rest of the structure is skipped. If
///BooleanExpression_1 is false, however, the program jumps to the very
///next else if clause and tests BooleanExpression_2. If it is true, the
///set of statements that immediately follows is executed, and the rest of
///the structure is then skipped. This process continues until a
///Boolean expression is found to be true, or no more else if clauses
///are left. If none of the Boolean expressions are true, the set of
///statements following the final else clause is executed.
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
///	For example, look at the Grader2 application in the Chap04 folder of 
///	this book's Student Sample Programs. This application works just like
///	the Grader application that was previously discussed.
///	
/// The user enters a numeric test score, and the application displays a grade.
/// 
/// Its form is identical to the form shown in Figure 4-15. The Grader 2 
/// application, however, uses an if-else-if statement to determine the 
/// grade instead of nested if-else statements. The Grader2 application's
/// determineGradeButton_Click event handler is shown here:
/// /////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// Notice the alignment and indentation that us used with the if-else-if
/// statement: The if, else if, and else clauses are all aligned, and the 
/// conditionally executed statements are indented.
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// You never have to use the if-else-if statement because its logic 
/// can be coded with nested if-else statements; however, a long series
/// of nested if-else statements has two particular disadvantages when
/// you are debugging code:
///////////////////////////////////////////////////////////////////*
/////
///
/// /////////////////////////////////////////////////////////////////////
/// * The code can grow complex and become difficult to understand.
/// 
/// * Because indenting is important in nested statements, a long series
/// of nested if-else statements can become to long to be displayed on
/// the computer screen without horizontal scrolling. Also, long 
/// statements tend to wrap around when printed on paper, making the code
/// event more difficult to read.
///////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// The logic of an if-else-if statement is usually easier to follow than
/// a long series of nested if-else statements. And, because all the
/// clauses are aligned if an if-else-if statement, the lengths of the 
/// lines in the statement tend to be shorter.
///////////////////////////////////////////////////////////////////////
///
///
///////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
///						4.4 Logical Operators
/// /////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////
///
///////////////////////////////////////////////////////////////////////
///Concept: The logical AND operator (&&) and the logical OR operator
///(||) allow you to connect multiple Boolean expressions to create a 
///compound expression. The logical NOT operator (!) reverses the truth
///of a Boolean expression.
/// /////////////////////////////////////////////////////////////////////
////
///////////////////////////////////////////////////////////////////////
///The C# language provides a set of operators known as logical operators,
///which you can use to create complex Boolean expressions. Table 4-3 
///describes these operators.
/// /////////////////////////////////////////////////////////////////////
 *	
 *	/////////////////////////////////////////////////////////////////////
 *	
/////////////////////////////////////////////////////////////////////
				Table 4-3 Logical operators
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
Table 4-4 shows examples of several compound Boolean expressions that
use logical operators.
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
	Table 4-4 Compound Boolean expressions using logical operators
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
The && Operator
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
The && operator is the logical AND operator. It takes two Boolean
expressions as operands and creates a compound Boolean expression 
that is true only when both subexpressions are true. The following 
is an example of an if statement that uses the && operator:
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
if(temperature < 20 && minutes > 12)
{
	MessageBox.Show("The temperature is in the danger zone.");
}
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
In this statement, the two Boolean expression temperature < 20 and
minutes > 12 are combined into a compound expression.

The MessageBox.Show statement is executed only if temperature is less
than 12.

If either of the Boolean subexpressions is false,
the compound expression is false and thge message is not displayed.
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
Table 4-5 shows a truth table for the && operator. The truth table 
lists expressions showing all the possible combinations 
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///As the table shows, both sides of the && operator must be 
///true for the operator to return a true value.
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///The || Operator
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///THe || operator is the logical OR operator. It takes two Boolean
///expressions as operands and creates a compount Boolean expression
///that is true when either of the subexpression id true.
///
/// The following id an exaple of an if statement that uses the ||
/// operator:
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///if (temperature < 20 || temperture > 100) 
///{
///		MessageBox.Show("The temperature is in the danger zone.");
/// }
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///The MessageBox.Show statement executes only if temperature is less than
///20 or temperature is greater than 100.
///if either subexpression is true, the compound expression is true.
///
/// Table 4-6 shows a truth table for the || operator.
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///Table 4-6 Truth table for the || operator
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///All it takes for an || expression to be true is for one side of
///the || operator to be true. It dosen't matter if the other side
///is false or true.
/////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////
///Short-Circut Evaluation
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Both the && and || operators perform short-circuit evaluation.
///Here is how it works with the && operator: of the expression on
///the left side of the && operator is false,
///the expression on the reight side is not checked.
///
/// Because the compound expression is false if only one of the
/// subexpressions is false, it would waste CPU time to check
/// the ramaining expression. So, when the && operator finds that
/// expression on its left is false, it short-circitues and does
/// not evaluate the expression on its right.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here's how short-circut evaluation works with the || operator:
///if the expression on the left side of the || operator is true,
///the expression on the right side is not checked.
///
/// Because it is necessary for only one of the expressions to
/// be true, it would waste CPU time to check the remaining
/// expression.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The ! Operator
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The ! operator is the logical NOT operator. It is a unary
///operator that takes a Boolean expression as its operand
///and reverses its logical value. In other words, if the expression is
///true, the ! operator returns false, and if the expression is false, the
///! operator returns true.
///
/// The floowing is an if statement using the NOT operator:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(!(temperature > 100))
///{
///		MessageBox.Show("This is below the maximum temperature.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///First, the expression (temperature > 100) is tested and a value of 
///either true of false is the result.
///
/// Then the ! operator is applied to that value.
///
/// If the expression (temperature > 100) is true, the ! operator
/// returns false.
/// 
/// If the expression (temperature > 100) is false, the ! operator
/// returns true.
/// 
/// The previous code is equivalent to asking "IT the temperature not
/// greater than 100?"
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Notice that in this example, we have put parentheses around the 
///expression temperature > 100.
///
///This is necessary because the ! operator
///has higher precedence than the relational operators.
///
///If we do not put parentheses around the expression
///temperature > 100, the ! operator will be applied just to the
///temperature variable.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Table 4-7 shows a truth table for the ! oeprator.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Precedence of the Logical Operators
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///We mentioned eearlier that the ! operator has higher precedenve
///than the relational operators.
///
/// The && and || logical operators have lower precedence than the
/// relatiuonal operators.
/// 
/// For example, look at the following expression:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///creditScore > 700 || accountBalance > 9000
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When this expression is evaluated, the > operator work first,
///and then the || operator works. The expression is the same as the
///following:
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///(creditScore > 700) || (accountBalance > 9000)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Many programmers choose to enclose the expressions that are to the
///left and the right of a logical operator in parentheses, as shown
///here. Event though the parenthese are not required in many
///situations, using them makes the compound expression easier to
///understand. 
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///			Checking Numeric Ranges with Logical Operators
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Sometimes you need to write code that determiens whether a numeric
///value is within a specific range of values or outside a specific
///range of values.
///
/// When determining whether a number is inside a rangem it is best
/// to used the && operator. For example, the following if statement
/// checks the value in x to determine whether it is in the range of
/// 20 through 40:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(x > 20 && x < 40)
///{
///		MessageBox.Show("The value is in the acceptable range.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The compound Boolean expression being tested by this statement is 
///true only when x is greater than 20 and less than 40.
///The value in x must be between the values of 20 and 40 for this 
///compound expression to be true.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When determining whether a number is outside a range,
///it is best to use the || operator. The following statement determines
///whether x is outside the range of 20 through 40:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///	if(x < 20 || x > 40)
///	{
///		MessageBox.Show("The value is outside the acceptable range.");
///	}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// It is important not to get the logic of the logical operators
/// confused when testing for a range of numbers.
/// 
/// For example, the compound Boolean expression in the following
/// code would never test true:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///		// This is an error!
///		if (x < 20 && x > 40)
///		{
///			MessageBox.Show("The value is outside the acceptable range.");
///		{
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Obviously, x cannot be less than 20 and at the same tiem be greater
///than 40.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's look at an example application that checks the range of a 
///value entered by the user. Open the Range Checker application
///in the Chap04 folder of this book's Student Sample Programs.
///Figure 4-17 shows the application's form, along with the names of
///some of the controls. When you run the application, you enter an 
///integer into the inputTexVox control and click the checkButton
///control. If you enter a number in the range of 1 throuigh 10,
///a message box appeara letting you know that the number is
///acceptable. Otherwise, a message box appears letting you know that
///the number is not acceprtable. 
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-17 The Range Checker application's form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The following code sample shows thje checkButton_Click event
///handler.
///Line 7 declares an int variable named number , initialized with the
///value that has been entered into the inputTextBox control. The if
///statement that begins in line 10 determiens whether number is greater 
///than or equal to 1 AND number is less than or equal to 10. If the 
///Booelan expression is true, the statement in line 12 executes. 
///Otherwise, the statement in line 16 executes.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///private void checkButton_Click(object sender, EventArgs e)
///{
///		try
///		{
///			// Declare a variable and initialize it with 
///			// the user's input.
///			int number = int.Parse(inputTextBox.Text);
///			
///			// Check the number's range.
///			if (number >= 1 && number <= 10)
///			{
///				MessageBox.Show("That numbner is acceptable.");
///			}
///			else
///			{
///				MessaheBox.Show("That number is NOT acceptable.");
///			}
///		}
///		catch (Exception ex)
///		{
///			// Display an error message.
///			MessageBox.Show(ex.Message);
///		}
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///				4.5 bool Variables and Flags
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///You can store the values true and false in bool variables, which
///are commonly used as flags.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The C# language provides the bool datatype that you to create 
/// variables that hold true or false values. Here is an example of 
/// declaration of a BOOL variable:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///bool grandMaster;
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// This declares a bool variable named grandMaster. In the program
/// we can assign the values true or false to teh variable, as shown
/// here:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(points > 5000)
///{
///		grandMaster = true;
///}
///else
///{
///		grandMaster = false;
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Variables of the bool data type are commonly used as flags. 
///
/// A flag
///is a variable that signals when some condition exists in the
///program. 
///
/// When the flag variable is set to false, it indicates that
///the condition does not yet exist.
///
/// When the flag variable is set totrue, it means the condidtion
/// does exist.
///
/// For example, the previous code might be used in a game to
/// determine whether the user is a "Grand master".
/// 
/// IF he or she has earned more than 5,000 points, we set the 
/// grandMAster variable to true. Other wise, we set the variable 
/// to false. Later in the program we can test the grandMaster var,
/// like this:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(grandMaster)
///{
///		powerLevel += 500;
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///This code preforms the follownig: if grandMAster is true, add 500 to 
///powerLevel. Here is another example:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if (!grandMaster)
///{
///		powerLevel = 100;
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///This code preforms the following: if granfMaster is not true, 
///set powerLevel to 100.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///					4.6 Comparing Strings
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///Concept
///You can use certain relational operators and methods to compare
///strings
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///You can use the == operator to compare two strings. 
///For example, look at the following code simple:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///string name1 = "Mary";
///string name2 = "Mark";
///
/// if(name1 == name2)
/// {
///		MessageBox.Show("The names are the same.");
/// }
/// else
/// {
///		MessageBox.Show("The names are NOT the same.");
/// }
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The == operator compares name1 and name2 to determine whether
///they are equal.
///
/// Because the strings "Mary" and "Mark" are not equal, the else
/// clause displays the message "The names are NOT the same."
/// 
/// You can compare string variables with string literals as well.
/// Assume month is a string variable. The following code sample uses
/// the != operator to determine whether month is not equal to
/// "October".
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(month != "October")
///{
///		statement;
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Look at the Secret Word application in the Chap04 folder of this
///book's Student Sample Programs.
///
/// Figure 4-18 shows the application's
///form, with the names of some of the controls.
///
/// The form prompts you
///to enter the secret word into the inputTexBox control.
///
///When you click the 
///checkButton control, the applicattion compares the string that
///you entered to "Ariel."
/// //////////////////////////////////////////////////////////////////
/// 
/////////////////////////////////////////////////////////////////////
///Figure 4-18 THe Secret World application's form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The following code sample shows the checkButton_Click event
///handler.
///
///Line 5 declares a string variable named secretWord, initialized
///with the value that has been entered into the inputTextBox control.
///
///The if statement that begins in line 8 compares the secretWord
///variable to the string literal "Ariel". If the two equal, the
///statement in line 10 executes. 
///
///Otherwise, the statement in line 14 executes.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///private void checkButton_Click(object sender, EventArgs e)
///{
///		// Declare a string variable and ionitialize it with
///		// the user's input.
///		string secretWord = inputTextBox.Text;
///		
///		// Did the user enter the correct secret word?
///		if(secretWord == "Ariel")
///		{
///			MessageBox.Show("That is the correct secret word.");
///		}
///		else
///		{
///			MessageBox.Show("Sorry, that is NOT the secret word.");	
///		}
///	}
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///					Other String Comparisons
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In addition to determining whether strings are equal or not equal,
///you can use the String.Compare method to determine whether one 
///string is greater than or less than another string.
///
///This is a useful capability because somethimes you need to sort 
///string in some order. Before we look at how the method works, we
///should review how characters are stored in memory.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Recall from Chapter 1 that computers do not actullay store
///characters, such as A, B, C, and so forth, in memory. Instead,
///they store numeric codes that represent the characters.
///
///We mentioned in Chapter 1 that C# uses Unicode to represent
///characters. Here are some facts about the Unicode system:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///		* The uppercase characters A through Z are represented by 
///			the numbers 65 through 90.
///		
///		* The lowercase characters a through z are represented by
///			the numbers 97 through 122.
///			
///		*When the digits 0 through 9 are stored in memory as
///		characters, they are represented by the numeric codes 48
///		through 57.
///		(For example, the string "For example, the string "abc123"
///		is stored in memory as the codes 97, 98, 99, 49, 50, and 51.)
///		
///		*A blank space is represented by the number 32.
///		
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In addition at establishing a set of numeric codes to represent 
///characters in memory, Unicode also establishes an order for
///characters.
///
///The character A comes before the character B, which comes before
///the character C, and so forth.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When a program compares characters, it actully compares the codes
///for the characters.
///
///The character A would be considered less than
///the character B becaues the character A's numeric code is less than
///the chatacter B's numeric code.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's look at how strings containing more than one character are
///compared. Suppose we have the strings "Mary" and "Mark" stored in
///memory, as follows:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///string name1 = "Mary";
///string name2 = "Mark";
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-19 shows how the strings "Mary" and "Mark" are stored in
///memory using character codes.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-19 Character codes for the strings "Mary" and "Mark"
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When you compare these strings in a program, they are compared
///character by character, beginning with the first, or leftmost,
///characters. This is shown in Figure 4-20.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-20 Comparing each character in a string
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here is how the comparsion takes place:
///
/// 1. The M in "Mary" is compared with the M in "Mark".
///	    These are the same, so the next characters are compared.
/// 
/// 2.The a in "Mary" is compated with the a in "Mark".
///		Because these are the same, the next characters are compared.
/// 
/// 3.The r in "Mary" is compated with the r in "Mark".
///		These are the same, so teh next characters are compared.
/// 
/// 4.The y in "Mary" is compated with the k in "Mark".
/// Because these are not the same, the two string are not equal.
/// The character u has a higher character code (121) than k (107),
/// so it is determined that the string "Mary" is greater than the
/// string "Mark"
/// 
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Of one of the string in a comparsion is shorter than the other,
///only the corresponding characters are compared.
///
/// If the corresponding characters are identical, then the shorter 
/// string is considered less than the longer string. For example,
/// suppose the strings "High" and "Hi" are compared. The string "Hi"
/// is considered less than "High" because it is shorter.
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In C# you cannot use relational operators to determine whether one
///string is greater then or less than another string. Instead, you
///use the String.Compare method. You ise the following general format
///to call the method:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///String.Compare(string1, string2)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In the general format, string1 and string2 are the strings that 
///are the strings that are being compared. The method returns an 
///integer value indicating the result of the comparsion.
///
///The integer value will be one of the following:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///* Greater than zero if string1 is greater than string2
///* Zero if string1 is equal to string2.
///* Less than zero if string1 is less than string2
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here is a code sampel that uses the method to display two names in
///alphabetical order:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///string str1 = "Joe";
///string str2 = "ketty";
///
/// if(String.Compare(str1, str2) < 0)
/// {
///		MessageBox.Show(str1 + " " + str2);
///	}
///	else
///	{
///		MessageBox.Show(str2 + " " + str1);
/// }
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// The if statement in line 4 calls the String.Comapre method,
/// passing str1 and str2 as arguments.
///
/// If we execute this code, the method will return a value that is
/// less than 0 because the string "Joe" is less than the string
/// "Kerry". As a result, the statement in line 6 will display joe
/// Kerry.
/////////////////////////////////////////////////////////////////////
///
/// /////////////////////////////////////////////////////////////////////
/// The String.Compare method preforms a case sensitive comparison, which
/// means that uppercase character are not considered the same as their
/// lowercase counterpasrts. For example, the strings "Joe" and "joe" are
/// not equal because the case of the first character is different in each.
/// You can pass the Boolean value true as an potional third argument to the 
/// String.Compare method if you want it to perform a case insensitive 
/// comparision. Here is an example:
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// //this is pretty cool c#
/// 
///string str1 = "JOE";
///string str2 = "joe";
///
/// if (String.Compare(str1, str2, true) == 0)
/// {
///		MessageBox.Show(str1 + " and " + str2 "are equal.");
///	}
///	else
///	{
///		MessageBox.Show(str1 + " and " + str2 + " are NOT equal.");
/// }
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Notice that the if statement in line 4 passes true as the third
///argument to the String.Compare method.
///
///This specifies that we want a case insensitive comparison.
///
/// As a result, the method will return 0 and the
/// statement in line 6 will display JOE and joe are equal.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///4.7 Preventing Data Conversion Exceptions with the TryParseMethods
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///	Concept Exceptions should be prevented when possible. You can
///	use the TryParse methods to prevent exceptions as a result of
///	the user entering invalid data.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In Chapter 3, you learned that the Parse methods throw an
///exception when you try to use them to convert nonnumeric data to a
///numeric data you. If you use of the Parse methods to convert a
///TextBox control's Yexy property to a number, there is always the 
///possibility of an exception being thrown. After all, the user is free
///to enter anything he or she wants into TextBox control. 
///
/// To handle the exceptions that are caused by the Parse mathods, we have
/// been using the try-catch statement.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Although many execptions happen for reasons that the programmer 
///cannot anticipate (such as a system malfuncation), some exceptions
///are predictable.
///
///For example, you know that using a Parse method to
///convert nonnumeric input to a numeric data type will throw an 
///exception.
///
///It is a better programming practice to prevent an 
///exception instead of allowing it to happen and then letting a
///try-catch statement react to it. You should use try-catch
///statements primarily for those exceptions that are beyond your
///control.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Note Until now, we've simply been allowing exception to happen and
///letting a try-catch statement respond to them. 
///
///After reading the previous paragraph, you might be wondering why
///we haven't been preventing exceptions all along. The reason is 
///that you need to know how to write if statements to perform the
///techniques that we discuss in this section. Now that you know how
///to write if statement, you can add more sophistication to your
///code.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Now that you know how to write if statements, you can use a family
///of methods in the .NET Framework known as the tryParse methods.
///
/// Whith the TryParse methods, you can determine whether a string
/// (such as a control's Text property) contains a value that can be
/// converted to a specific data type before it is converted to that 
/// data type. The tryParse methods do not throw an exception, so you
/// can use them without a try-catch statement.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///There are several TryParse methods in the .NET Framework.
///For now, we are using the int, double, and decimal numeric data
///types, so we will discuss three of them:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///	*We use the int.TryParse method to convert a string to an int.
///	
/// *We use the double.TryParse method to convert a string to a double.
/// 
/// *We use the decimal.TryParse method to convert a string to a decimal.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When you call one of the TryParse methods, you pass two arguments:
///(1) the string that you want to convert, and (2) the name of the 
///variable in which yoy want to store the converted value.
///
/// First, let's look at the int.TryParse method.
/// 
/// Here is the general format of how the int.TryParse method
/// is called:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///			int.TryParse(string, out targetVariable)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In the general format, string is the string that you want to
///convert, and targetVariable is the same of an int variable.
///The method tries to convert the string argument to an int.
///
/// If the conversion is successful, the converted value is stored
/// in the targetVariable, and the method returns the Boolean value
/// true to indicate that the conversion was sucessful.
/// 
/// If the conversion is npt successful, the method does not throw an exception.
/// 
/// Instead, it stores 0 in the targetVariable and returns the Boolean
/// value false to indicate that the string could not be converted.
/// 
/// Look carefully at the general format and notice that the word
/// wappears before the targetVariable.
/// 
/// The out keyword is requied
/// , and it specifies that the targetVariable is an output variable.
/// 
/// An output variable is a variable that is pass as an argument to a 
/// method, and when the method is finished,
/// a value is stored in the variable.
/// 
/// Because the TryParse methods return either true or false, they
/// are commonly called as the Boolean expression in an if statement.
/// 
/// The following code shows an example using the int.Tryparse method.
/// 
/// In the ex, assunme that the inputTextBox is the name of a TextBox
/// control.
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///int number;
///
///if (int.TryParse(inputTextBox.Text, out number))
///{
///		MessageBox.Show("Success!");
///}
///else
///{
///		MessageBox.Show("Enter a valid integer.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The purpose of this code sample is to convert the value of the 
///inputTextBox control's Text property to an int and assign the 
///value to the number variable. In line 3, the if statement calls the
///int.TryParse method, passing inputTextBox.Text as argument 1 and
///number 2. Here's what happenes:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///*IF inputTextBox.Text is sucessfully converted to an an int, the
///resulting value is assigned to the number variable, and the method
///returns true. That causes the statement in line 5 to execute.
///
///*IF inputTextBox.Text cannot be converted to an int, the value 0 
///is assigned to the number variable, and the method returns false.
///That causes the statement in line 9 (after thge else clause) to
///execute.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The other TryParse methods work in a simliar manner. Here is the general 
///format of how the double.TryPArse method is called.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///double.TryParse(string, out targetVariable)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In the general format string is the string that you want to convert, 
///and targerVariable is the name of a double variable.
///
///If the string can be converted to a double, its value is stored in
///the targetVariable, and the method returns the Boolean value true
///to indicate that the conversion was successful. 
///
///If the conversion was not successful, the method stores 0 in the 
///targetVariable and retuens the Boolean value false to indicate that
///the string could not be converted.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// The following code shows an example using the double.TryParse
/// method. In the example, assume that inputTextBox is the name of a
/// TextBox control.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///double number;
///
/// if(double.TryParse(inputTextBox.Text, out number))
/// {
///		MessageBox.Show("Success!");
/// }
/// else
/// {
///		MessageBox.Show("Enter a valid double.");
/// }
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here is the general format of how the decimal.TryParse method is called.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///decimal.TryParse(string, out targetVariable)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In the general format, string is the sttring that you want to convert,
///and targetVariable is the name of a decimal variable.
///
///If the string can be converted to a decimal, its value is 
///stored in thetargetVariable, and the method returns the 
///Boolean value true toindicate that the conversion was successful.
///
/// IF the conversion was successful, the method stores 0 in the 
/// targetVariable and returns the Boolean value false to indicate
/// that the string could not be converted.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The following code shows an example using the decimal.TryParse
///method. In the example, assume that inputTextBox is the name of a
///TextBox control.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///decimal number;
///
///if(decimal.TryParse(inputTextBox.Text, out number))
///{
///		MessageBox.Show("Success!");
///}
///else
///{
///		MessageBox.Show("Enter a valid decimal.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// Validating the Data in multiple TextBoxes
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///If a form has multiple TextBoxes, then the user has multiple
///opportunities to enter an invalid piece of data. A well-designed
///program shold validata that contents of each TextBox individually.
///When a piece of invalid data is found, the program should display an
///error message that tells the iser specifically which TextBox contains the 
///bad input.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///This technique requires a set of nesated if statements. For rx, suppose
///a form has two TextBoxes. The following pseudocode shows the logic for
///validating each TextBox. (In the pesudocode, set of dotted lines
///conntects each if statement with its corresponding Else
///clause and its eding.)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's see how that logic looks in actual C# code. In the Chap04
///folder of this book Student Sample PRograms, you will find a project
///named Add Two Numbers. The application's form is shown in Figure 
///4-21. When you run the application, enter an integer into each
///of the TextBox controls and then click the Add button. 
///
/// A message box will appear showing the sum of the two numbers. IF 
/// you enter anything other than an integer into wither TextBox, an
/// error message will appear telling you shich TextBox contrins
/// the invalid data.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-21 The Add Two Numbers form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here is the code for the addButton_Click event handler:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///private void addButton_Click(object sender, EventArgs e)
///{
///		// Local variables
///		int first, second, sum;
///		
///		if(int.TryParse(firstTextBox.Text, out first))
///		{
///			if(int.TryParse(secondTextBox.Text, out second))
///			{
///				// Add the two numbers and display the sum.
///				sum = first + second;
///				MessageBox.Show(sum.ToString());
///			}
///			else
///			{
///				// Display an error message about the second TextBox.
///				MessageBox.Show("The second TextBox contrains invalid data.");
///			}
///		}
///		else
///		{
///			// Display an error message about the first TextBox.
///			MessageBox("The first TextBox contains invalid data.");
///		}
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's take a closer look:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///* Line 4 declares three int vars: first, second, and sum.
///
///* The if statement in line 6 tries to convert firstTextBox.Text to
/// an int.
/// If the conversion is successful, the result is stored in the
/// first variable, and the program continues executing at line 8.
/// If the conversion is not successful, the program jumps to the
/// else clause in line 20, and line 23 displays an error message
/// regarding the first TextBox control.
///
///*The if statement in line 8 tries to convert secondTextBox.Text to
///an int. Of the conversion is successful, the result is stored in the 
///second variable, adn the program continues executing at line 10. IF the 
///conversion is not successful, the program jumps to the else caluse
///in line 14, and line 17 displays an error message regarding the
///second TextBox control.
///
///*The statements in lines 11 and 12 execute only if both TextBox
///controls contain valid integer values.
///These statements add the first and second variables and display
///their sum.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///If you need to validata three TextBox controls, you will write a set
///of three nested if statements. Here's the pesudocode:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In Tutorial 4-4, you complete an application that uses the TryParse
///methods to validata data entered into two TextBox controls.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///			Tutotial 4-4: Calculating Fuel Economy
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In Tutotial 3-2, you created an application that calcualtes a
///car's fuel economy in miles per gallon (MPG).
///
///Recall that the
///application lets the user enter the number of miles he or she
///has driven and the gallons of gas used.
///
/// The application calculates and displays the car's MPG.
/// 
/// In this tutorial, you create a new version of the application
/// that validates the data entered by the user.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///To save time, the project has already been stared for you, and the 
///application's form has already been created. To complete the project,
///follow the steps in this tutorial.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 1: Start Visual Studio. Open the project named Fule Economy
///with TryParse in the Chap04 folder of this book's Student Sample
///Programs.
///
///Step 2: Open the Form1 form in the Designer. The form is shown, along
///with the names of the important controls, in Figure 4-22.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-22 The Fuel Economy Form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 3: Now, you will create the Click event handlers for the 
///Button controls.
///
/// At the end of this tutorial, Program 4-4 shows the completed code
/// for the form, You will be instructed to refer to Program 4-4 as
/// you write the event handlers.
///
/// IN the Designer, double-click the calculate button control.
/// This willopen the code editor, and you see an empty event handler
/// named calculateButton_Click. Complete the calculateButton_Click
/// event handler by typing the code shown in lines 22-48 in Program 4-4.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Lets' take a cloer look at the code:
///
///Lines 22-24: These lines declare the double variables miles,
///gallons, and mpg. The variables hold the niles driven, the gallons
///of gas used , and the MPG, reprectively.
///
///Line 27: This if statememet tries to conver milesTextBox.Text to a
///double. If the conversion is successful, the result is stored in
///miles variable, and the program continues executing at line 29. If
///the conversion is not successful, the program jumps to the else 
///clause in line 44, and line 47 displays the error message
///"Invalid Input for miles.""
///
///Line 30: This if statement tries to convert gallonsTextBox.Text
///to a double. If the conversion is successful, the result is
///stored in the gallons variable, and the program continues
///executing at line 32.
///If the conversion is successful, the program jumps to the else
///clause in line 38, and line 41 displays the error message
///"Invalid input for gallons."
///
/// Line 32-36 These lines are executed only if both the
/// milesTextBox and gallonsTextBox contain valid data.
/// Line 3 calculates MPG and assigns the result to the mpg variable,
/// and the line 36 displays the value of the mpg variable in the 
/// mpgLabel control.
/// 
/// 
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 4: Switch your view back to the Designer and double-click
///the exitButtion control. In the code editor you see an empty event
///handler namef exitButton_Click. Complete the exitButton_Click event
///handler by typing the code shown in lines 53-54 in Program 4-4.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 5: Save the project and run the application. First, enter 300
///for the miles and 10 for the gallons. Click the Calculate MPG
///button, and the application should display 30.0 as the MPG.
///Now, change the miles to an invalid entry, such as 123xyz, 
///and click the Calculate MOG button. The message "Invalid input
///for miles."
///should appear in a message box, as shown on the left in Figure 4-23.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-23 Invalid input entered and the resulting error messages
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Now change the miles back to 300, change the gallons to an invalid
///entry, such as 123xyz, and click the Calculate MPH button.
///
///The message""Invalid input for gallons." should appear in a
///message box, as shown on the right in Figure 4-23.
/// 
/// Continue to test the applicvation as you wish. When you finished,
/// click the Exit button, and the form should close.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////
///						4.8 Input Validation
/////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Concept: Input validation is the process of inspecing data that 
///has been input to a program to make sure it is valid before it is 
///used in a computation.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///IN the previous section you leatned about using the TryParse methods
///to validate the type of data entered by the user.
///
///You 
///should also validate the accuracy of the data that is entered by the 
///user. 
///
/// One of the most famous sayings among computers programmers is 
///"garbage in, garbage out." This saying by the user. 
///
///This saying,
///comtines abbreviated as GIGO, refers to the fact that computers
///cannot tell the difference between good inout and bad input.
///
///If a user provides bad data as input to a program, the program 
///will process that bad data and , as a result, will produce bad
///data as output.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///For example, consider a payroll program tha taccepts the number of
///hours that an employee has worled in a given week as input.
///
/// If the payroll clerk accidentally enters 400 hours instead of 40
///hours, and unusually large check will be written because there
///are less than 400 hours in a week!!! The computer, however, is
///unaware of this fact, and unless the prgram is written to catch
///such errors, it will process the bad data as if it were good data.
///
/// 
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Sometimes stories are reported in the news about computer errors
///that mistankely cause people to be charged thousands of dollars
///for small purches or to receive large tax refunds to which the
///y were not entitled.
///These "computer error" are rarely caused by a computer; however,
///they are more commonly caused by software bugs or bad data that
///was read into a program as input.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The integrity of a program's output is only as good as the
///integerity of its input.
///
/// For this reason, you should write your programs in such a way
/// that bad input is invalid, the program should discard it and 
/// prompt the user to enter the correct data. This provess is known as
/// input validation.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///For example, in a payroll program we might validate the number of
///hours worked like this:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(int.TryParse(hoursWorkedTextBox.Text, out hours))
///{
///		if (hours > 0 && hours <= 168)
///		{
///			// Contine to process the input.
///		}
///		else
///		{
///			MessageBox.Show("Invalid number of hours entered.");
///		}
///}
///else
///{
///		MessageBox.Show("The hours worked must be an integer.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's suume the application uses a TextBox named hoursWorkedTextBox
///to get the hours worked. Also assume that the variable hours has
///already been declared as an int. The outer if statement (line 1)
///uses the int.Parse method to make sure the user has entered an
///integer. If so, the valueis stored in the hours variable and the 
///v program contrinues to the inner if statement (line 3). The inner
///if statement ensures that we cannot write a paycheck for 0 hours
///worked, and 168 is the maximum number of hours in a week.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///LEt's look at another example.
///The following code comes from an application that gets a test
///score as input. A valid test score is an integer in the range of
///0 through 100.
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(int.TryParse(testScoreTextBox.Text, out testScore))
			{
		if(testScore >= && testScpre <= 100)
			{
				// Continue to precess the input
			}
			else
			{
				MessageBox.Show("Test score must be in the range 0-100.");
			}
		}
else
{
	MessageBox.Show("The test score must be an integer.");
}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's assume the application uses a TextBox named testScoreTextBox 
///to get the test score.
///
///Also assume that the variable testScore has already been declared
///as an int.
///
/// The outer if statement (line 1)uses the int.TryParse method to 
/// make sure the user has entered an integer. if so, the value is
/// stored in the testScore variable and the program continues to 
/// the inner if statement (line 3). The inner if statement ensures
/// that we process the only if the testScore is greater than or
/// equal to 0 and testScore is less than or equal to 100.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///4.9 Radio Buttons and Check Boxes
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// Concept GUIs commonly use radio buttons and check boxes to let the
/// user select items.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Radio buttons are useful when you want the user to select one 
///choice from several possible choices. Figure 4-24 shows a form, at
///run time, with a group of three radio buttons. The radio buttons
///in the figure allows the user to select Coffee, tea, soft Drink/
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-24 Radio buttons
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///A radio button may either selected or deselected. Each radio button 
///has a small circle that appears filled in when the radio button is
///selected, and appears empty when the radio button is deselected. In
///Figure 4-24, the Coffee radio is selected and the other radio
///buttons are deselected.
/////////////////////////////////////////////////////////////////////
///
///
/////////////////////////////////////////////////////////////////////
///At run time, only one radio button in a group may be selected at a
///time. Clicking on a radio button selects it, and automatically 
///deselects any other radio button in the same group. We call this
///mutually exclusive selection.
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Note The name radio button refers to the old car radios that had 
///push buttons for selecting stations. Only one button could be pushed 
///in at a time. When you push a button, it automatically popped out
///the currently selected button.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When you want to create a group of radio button on a form, you use 
///the RadioButton control, which is found in the Common Controls
///section of the Toolbox. RadioButton controls are normally grouped
///in one of the following ways:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///* You place them inside a GroupBox control. All RadioButton controls
///that are inside a GroupBox are memners of the same group.
///
///*You place them inside a Panel control. All RadioButton controls that are
///inside a PAnnel are members of the same group.
///
///*You place them on a but not inside a GroupBox or a Panel. All
///RadioButton controls that are on a form but not inside a GroupBox
///or Panel are members of the same group.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-25 shows a form, at run time, we two groups of
///RadioButton controls. The group on the left is inside a GroupBox
///control, and the group on the right is inside a Panel control.
///When the application runs, the user will be able to select only
///one RadioButton from each group. In the figure, Coffee is selected
///in the left group and Lunch is selected in the right group.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-25 A form with two groups of RadioButton controls
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The RadioButton Control's Text Property
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///RadioButton controls have a Text property, which holds the tezt 
///that is displayed next to the radio button's circle. For example,
///the radio buttons shown in Figure 4-24 have their Text properties 
///set to Coffee, Tea, and Soft Drink.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The RadioButton Control's Checked Property
/////////////////////////////////////////////////////////////////////
///RadioButton controls have a Checked propert that determines whether
///the controls is selected or deselected.
///
/// The Checked property is a Boolean property, Which means that it
/// may be set to either True or False. When the Checked property is
/// set to True, the RadioButton is selected, and when the Checked
/// property is set to False, the RadioButton is deselected. By 
/// default, the Checked property is set to False.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///You can use the Prioerties window to set the initial value of a 
///RadioButton control's Checked property. Keep in mind that the
///Checked property of only one RadioButton in a group can be set to 
///True at a given time. When you set a RadioButton control's Checked
///property to True in the Properties window, the Checked properties
///of all the other RadioButtons in the same group automatically 
///are set to False.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Tip When you create a group of RadioButtons controls, you should
///always set one of the control's Checked property to True in the 
///Properties window. If all the RadioButtons in a group have their
///Checked property set to False, then the Checked property of the 
///RadioButton with the lowest TabIndex value will automatically
///be set to True when you run the application.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Working with Radio Buttons in Code
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In code, you can determine whether a RadioButton control is
///selected by testing its Checked property. For example, suppose a 
///form has a RadioButton control named choice1RadioButton. The 
///following if statement determines whether it is selected:
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(choice1RadioButton.Checked)
///{
///		MessageBox.Show("You selected Choice 1");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Notice that we did not have to use the == operator to explicitly
///compare the Checked property to the value true.
///
///This code is equivalent to the following:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(choice1RadioButton.Checked == true)
///{
///		MessageBox.Show("You selected Choice 1.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's look at an example using multiple RadioButton controls. Open
///the RadioButton project in the Chap04 folder of this book's Student
///Sample Programs. THe application's form is shown in Figure 4-26. 
///When you run the application, select one of the radio buttons and 
///then click the OK button. A message box appears showing the 
///spot that you selected.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-26 The RadioButtonExample form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here is the code for the okButton_Click event handler:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///private void okButton_Click(object sender, EventArgs e)
///{
///		if(footballRadioButton.Checked)
///		{
///			MessageBox.Show("You selected Football.");
///		}
///		else if(basketballRadioButton.Checked)
///		{
///			MessageBox.Show("You selected Basketball.")
///		}
///		else if(baseballRadioButton.Checked)
///		{
///			MessageBox.Show("You selected Baseball.");
///		}
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///When the event handler executes, the if statement in line 3 
///setermines whether the footballRadioButton control's Checked 
///property is true.
///
///If it is, the message you selected Football. is 
///displayed in line 5.
///
///Otherwise, line 7 determines whether the basketballRadioButton 
///control's Checked property is true. If it is, the message you
///selected Basketball. is displayed in line 9. Otherwise, line 11
///determines whether the baseballRadioButton control's Checked 
///property is true. If it is, the message You selected Baseball. is
///displayed in line 13.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Check Boxes
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///A check box appears as a small box with some accompanying text.
///Figure 4-27 shows an example. They are called check boxes because
///clicking on an empty check box causes a check mark to appear in it.
///If a check mark already appears in a check box, clikcking it removes the check mark.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-27 A check box
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Check boxes are sinlar to radio buttons, exceot that check boxes
///are not mutually exclusive. You can have one or more check boxes
///in a group, and any number of them can be selected at any given 
///time. When you want to create a check box a form, you use the 
///CheckBox control, which is found in the Common Controls section
///of the Toolbox.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The CheckBox Control's Text Property
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///CheckBox controls have a Text property, which hides the text that
///is displayed next to the check box. For example, the CheckBox 
///control shown in Figure 4-27 has it Text property set to Pepperoni.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The CheckBox Control's Checked Property
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Like radio buttons, CheckBox controls have a Checked properpty.
///When a CheckBox control is selected, or checked, its checked
///property is set to True. When a CheckBox control is deselected, or
///unchecked, its Checked property is set to False.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Working with CheckBox Controls in Code
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In code, you can determine whether a CheckBox control is selected:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///if(operionalCheckBox.Checked)
///{	
///		MessageBox.Show("You selected Option 1.");
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Let's look at an example program. Open the CheckBox Example project
///in the Chap04 folder of book's Stadent Sample Programs. The 
///application's form is shown in Figure 4-28. When you run the application,
///select any of the check boxes and then click the Ok button. One
///or more message boxes will appear, showing you the items that you selected.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-28 The CheckBox Example form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Here is the code for the okButton_Click event handler:
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///private void okButton_Click(object sender, EventArgs e)
///{
///	if(pepperoniCheckBox.Checked)
///	{
///		MessageBox.Show("You selected Pepperoni.");
/// }
/// if(cheeseCheckBox.Checked)
///	{
///		MessageBox.Show("You selected Cheese.");
/// }
/// 
/// if(anchoviesCheckBox.Checked)
/// {
///		MessageBox.Show("You selected Anchovies.");
/// }
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Notice that we have three separate if statements. The if statement
///in line 3 determines whether the pepperoniCheckBox control is
///selected.
///If so, line 5 displays the message You selected Pepperoni. The if
///statement in line 8 determiens whether the cheeseCheckBox control
///is seleceted. IF so, line 10 displays the message You selected 
///Cheese. The if statement in line 13 determines whether the 
///anchoviesCheckBox controls is selected. IF so, line 15 displays 
///the message You selected Anchovies.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The CheckedChanged Event
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Any time a RadioButton or a CheckBox control's Checked property 
///changes, a CheckedChanged event happens for that control. If you 
///want some action to immediately take place when the user selects
///(or dceselcts) a RadioButton or CheckBox, you can create a
///CheckedChanged event handler for the control and write the desired
///code in that event handler.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///To create a CheckedChanged event handler for a RadioButton or a 
///CheckBox, simply double-click the control in the Designer. An 
///empty CheckedChange event handleris created in the code editor. You
///can then write code inside the event handler. 
///
///Tutorial 4-5 leads you through the process.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/// Tutorial 4-5: Creating the Color Theme Application
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In this tutorial, you ctrate an application that allows the user to
///select a color using RadioButton controls. When the user selects a 
///color, the form's background color is changed to that color immediately
///Figure 4-29 shows the application's form, with the names of all the
///controls.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-29 The Color Theme form
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 1: Once you have set up the form with its controls, you can 
///create the CheckedChanged event handlers for the RAdioButton. 
///At the end of this tutorial, Programs 4-5 shows the completed code
///for the form. You will be instructed to refer to program 4-5 as you
///write the event handlers. In the Designer, double-click the yellow
///RadioButton control. This operns the code editor, and you see an 
///empty event handler named yellowRadioButton_CheckedChanged. 
///Complete the yellowRadioButton_CheckedChanged event handler by 
///typing the code shown in lines 22-25 in Prgram 4-5.
///
///The event handler is easy to understand. The if statement in
///line 22 determine whether the yellowRadioButton_CheckedChanged
///event handler by typing the code show in lines 22-25 in Program 4-5.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 2:Set up the application's form as shown in Figure 4-29.
///Notice that the form's Text property is set to Color Theme. 
///The names of the controls are shown in the figures. 
///As you place each of the controls on the form, refer to Table 4-8
///for the relevant property settings.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Table 4-8 Control property settings
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 3:Once you have set up the form with its controls, you can 
///create the CheckedChanged event handlers for the RAdioButton. 
///At the end of this tutorial, Programs 4-5 shows the completed code
///for the form. You will be instructed to refer to program 4-5 as you
///write the event handlers. In the Designer, double-click the yellow
///RadioButton control. This operns the code editor, and you see an 
///empty event handler named yellowRadioButton_CheckedChanged. 
///Complete the yellowRadioButton_CheckedChanged event handler by 
///typing the code shown in lines 22-25 in Prgram 4-5.
///
///The event handler is easy to understand. The if statement in
///line 22 determine whether the yellowRadioButton_CheckedChanged
///event handler by typing the code show in lines 22-25 in Program
///4-5.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 4: Switch your view back to the designer and double-click
///redRadioButton control. This operns the code editor, and you see 
///an empty event handler named redRadioButton_CheckedChanged. 
///Complete the redRadioButton_CheckChanged event handler by typing
///the code shown in lines 30-33 in Program 4-5
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 5: Switch your view back to the Designer and double-click
///the whiteRAdioButton control. This opern the code editor, and you
///see an empty event handler named whiteRadioButton_CheckedChange. 
///
///Complete the whiteRadioButton_CheckedChanged event handler by typing
///the code shown in lines 38-41 in Program 4-5.
/////////////////////////////////////////////////////////////////////
///
///
/////////////////////////////////////////////////////////////////////
///Step 6:Switch your view back to the Designer And double-click the 
///normalRadioButton_CheckedChanged event handler by typing the code
///shown in lines 46-49 in Program 4-5.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 7:Switch your view back to the Designer and double-click
///the exit control. In the code editor you see an empty event handler
///named exitButton_Click. Complete the exit_Button_Click event handler
///by typing the code shown in lines 54-55 in Program 4-5.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Step 8: Save the project and run the application. Notice that the 
///Back to Normal radio button is initially selected. That's because 
///you set its Checked property to True in the Properties window.
///Click the other Radio buttons and notice that the form's background
///color changes immediately. When you are finshed testing the application,
///click the Exit button to close it. 
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///					4.10 The switch Statement 
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Concept The switch statement lets the value of a variable or an 
///expression determine which path of execution the program will take.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The switch statement is a multiple-alernative decision structure.
///It allows you to test the value of a variable or an expression and 
///then use that value t odetermine which statement or set of
///statements to execute. Figure 4-30 shows an example of how a
///multiple-alternative decision structure looks in a flowchart.
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Figure 4-30 A multiple-alternative decision structure
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///In the flowchart, the diamond symbol shows month, which is the name
///of a variable. If the month variable contains the value 1, the
///program displays "January." If the month variable contains the
///value 2, the program displays "February". If the month variable 
///contains the value 3, the program display "March." If the month
///variable contains none of these values, the action that is labeled 
///Default is executed. In this case, the program
///dispalays "Error: Invalid month."
///
/// Here is the general format of a switch statement in C# code:
/////////////////////////////////////////////////////////////////////
///
///
/////////////////////////////////////////////////////////////////////
///switch(testExpression)
///{
/// case value_1:
/// statement;
/// statement;
/// etc.
/// break.
/// 
/// case value_2:
/// statement;
/// statement;
/// etc.
/// break.
/// 
/// case value_N:
/// statement;
/// statement;
/// etc.
/// break.
/// 
/// default:
/// statement;
/// statement;
/// etc.
/// break.
///}
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///The first line of the statement starts with the word switch,
///followed by a testExpression, which is enclosed in parenthese.
///THe testExpression is a variable or an expression that gives an
///integer, string, or bool value. (Several other data types that we 
///have not discussed yet are also permissible. The important thing
///to remember is that the testExpression cannot be a floating-point 
///or a deciaml value.)
/////////////////////////////////////////////////////////////////////
///
/////////////////////////////////////////////////////////////////////
///Beginning at the next line is a block of code enclosed in curly
///braces. Inside this block of code are one or more case sections. 
///
/// A case section begins with the word case, followed by a value,
/// followed by a colon. Each case section contains one or more
/// statements, followed by a break statement. Each case section must
/// end with a break statement. At the end is an optional default
/// section.
/// 
/// The default section must also end with a break statement.
/////////////////////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////////////////
///When the switch statement executes, it compares the value of the
///of the testExpression with the values that follow each of the
///case statements (from top to bottom). When it finds a case value
///that matches the testExpression's value, the program branches to
///the case statement. The statements that follow the case
///statement are executed, until a break statement is encountered.
///
/// At that point the program jumps out of the switch statement. If
/// the testExpression does not match ant of the case values, the 
/// program branches to the default statement and executes the 
/// statements that immediately follow it.
/// 
/// For example, The following code performs the same operation as
/// the flowchart in Figure 4-30:
//////////////////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////////////////
///switch(month)
///{
///	case 1:
///	MessageBox.Show("January")
/// break;
/// 
/// case 2:
/// MessageBox.Show("February")
/// break;
/// 
/// case 3:
/// MessageBox.Show("March")
/// break;
/// 
/// default:
/// MessageBox.Show("Error: Invalid month")
/// break;
///}
//////////////////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////////////////
///In this ex the testExpression in the month variable.
///
///If the value in the month variable is 1, the program branches
///to the case 1: section and executes the
///MessageBox.Show("January") statement that immediatly follows it.
///
///If the value in the month
///variable is 2, the program branches to the case 2: section and 
///executes the MessageBox.Show("February") statement that
///immediately follows it. If the value in the month variable is 
///not 1,2, or 3, the program branches to the default: section and
///executes the MessageBoxShow("Error: Invalid month") statement
///that immediately follows it.
//////////////////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////////////////
///The switch statement can be used as an alternative to an if-else
///-if statement that tests the same variable or expression for 
///several different values. For example, the previously shown 
///switch statement worlds like this if-else-if statemet:
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// if (month == 1)
/// {
///		MessageBox.Show("January")
/// }
/// else if (month == 2)
/// {
/// MessageBox.Show("Fedruary");
/// }
/// else if (month == 3)
/// {
/// MessageBox.Show("March");
/// }
/// else
/// {
///		MessageBox.Show("Error: Invalid month");
/// }
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// To see an application that uses a seitch statement, look at the
/// Switch Example project in the Chap04 folder of this book's
/// Student Sample Programs.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////
///				4.11 Introduction to List Boxes
//////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////////////////
/// Concept: List boxes display a list of items and allow the 
/// user to select an item from the list.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// A list box displays a list of items and allows the user to 
/// select one or more items from the list. In Visual C# you use
/// the ListBox control to create a list box on an application's 
/// form. Figure 4-31 shows a form, at run time, with ListBox
/// controls. At run time, the user may select one of the items,
/// causing the item to appear selected.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Figure 4-31 ListBox examples
/// //////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// The topmost ListBox in Figure 4-31 does not have a scroll bar,
/// but the bottom one does. A scrool bar appears when a ListBox
/// contains more items than can be displayed in the space provided.
/// 
/// In the figure, the top ListBox has four items 
/// (Poodle, Great Dane, German Shepherd, and Terrier), and all
/// items are displayed. The Bottom ListBox shows four items 
/// (Siamese, Persian, Bobtail, and Burmese), But because it has
/// a scroll bar, we know there are more items in the ListBox than
/// those four.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// You will find the ListBox control in the Common Controls
/// Section of the ToolBox. Once you create a ListBox control, you
/// add items to its Items property. The items that you add to a 
/// ListBox's Items property are displayed in the ListBox.
//////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////
/// To store values in the Items property at design time, follow 
/// these steps:
/// 
/// 1. Select the ListBox control in the Designer window.
/// 
/// 2.In the Properties window, the settings for the items property is displayed as (Collection).
/// When you select the Items property, an ellipses button (...) appears.
/// 
/// 3.Click the ellipses button. The String Collection Editor dialog box appears, as shown in Figure 4-32.
/// 
/// 4. Type the values that are to appear in the ListBox into the String Collection Editor dialog box.
/// Type each value on a separate line by pressing the Enter key after each entry.
/// 
/// 5. When you have entered all the values, click the OK button
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Figure 4-32 The String Collection Editor dialog box
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///Note: Once you acquire the necessary skills, you will be able
///to fill the Items collection of list boxes from exteranl 
///data sources (such as databases).
/////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///The SelectedItem Property
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// When the user selects an item in a ListBox, the item is stored  
/// in the ListBox's SelectedItem property. For example, suppose
/// an application has a ListBox control named fruitListBox and a 
/// string variable named selectedFruit. The fruitListBox control
/// contains the items Apples, Pear, and Bananas. If the user has
/// selected Pears, the following statement assigns the string 
/// "Pears" to the variable selectedFruit:
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///
/// selectedFruit = fruitListBox.SelectedItem.ToString();
/// 
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Notice that you have to call the SelectedItem property's
/// ToString method to retrieve the value as a string.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Determining Whether an Item Is Selected
//////////////////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////////////////
///An exceprion will occur if you try to get the value of a
///ListBox's SelectedItem property when no item is selected in the
///ListBox. For that reason, you should always make sure that an 
///item is selected before reading the SelectedItem property. You
///do this with the SelectedIndex property.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///The items that are stored in a ListBox each have an index. The
///index is simply a number of items in the ListBox. When the user
///selects an item in a ListBox, the item's index is stored in the 
///ListBox's SelectedIndex property. If noitem is selected in the 
///ListBox, the SelectedIndex property is set to -1.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///You can use the SelectedIndex property to make sure that an item
///is selected in a ListBox before you try to get the value of the 
///SelectedItem property. You simply make sure the SelcetedIndex
///property is not set to -1 before trying to read the SelectedItem
///property. Here is an example:
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///if (fruitListBox.SelectedIndex != -1)
///{
///	selectedFruit = fruitListBox.SelectedItem.ToString();
///}
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///In Tutorial 4-6, you create an application that lets the user
///select an item from a ListBox control.
/////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Tutorial 4-6: Creating the Time Zone Application
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// In this tutorial, you create an application that allows the 
/// user to select a city from a ListBox control. When the user
/// clicks a button, the application displays the names of the 
/// city's time zone. Figure 4-33 shows the application's form,
/// whith the names of all the controls.
//////////////////////////////////////////////////////////////////
/// 
/////////////////////////////////////////////////////////////////
/// Figure 4-33 The Color Theme form
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///Step 1: Start Visual Studio and begin a new Windows Form 
///Application project named Time Zone.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///Step 2: Set up the application's form, as shown in Figure 4-33.
///Notice that the form's Text property is set to Time Zone. The 
///names of the controls are shown in the figure.
///As you place each of the controls on the form, refer to Table
///4-9 for the relevant property settings.
/////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Table 4-9 Control property settings
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
///Step 3: Once you have set up the form with its controls,
///you can create the Click event handlers for the Button contrls.
///At the end of this tutorial, Program 4-6 shows the completed 
///code for the form. You will be instructed to refer to 
///Program 4-6 as you write the event handlers. In the Designer,
///double-click the okButton control. This opens the code editor,
///and you see an empty event handler named okButton_Click. 
///Complete the okButton_Click event handler by typing the 
///code shown in lines 22-53 in Program 4-6. Let's take a closer
///look at the code:
///
///Line 22:
///This line declares a string variable named city.
///It is used to hold the name of the city that the user
///selects form the ListBox.
///
///Line 24:
///This if statement determiens whether the user has selected
///an item in the cityListBox control. If an item is selected,
///the control's SelectedIndex property is set to -1, and the 
///program jumps to the else clause in line 49.
///
///Line 27: This statement gets the selected item from the 
///ListBox and assigns it to the city variable.
///
///Line 30: This switch statement tests the city variable and 
///branches to one of its case statements, depending on the 
///variable's value:
///
///	*If the city variable equals "Honolulu", the program jumps
///	to the case statement in line 32.
///		
/// *If the city variable equals "San Francisco", the program jumps
/// to the case statement in line 35.
///		
/// *If the city variable equals "Denver", the program jumps
/// to the case statement in line 38.
///		
/// *If the city variable equals "Minneapolis", the program jumps
/// to the case statement in line 41.
///		
/// *If the city variable equals "New York", the program jumps
/// to the case statement in line 44.
//////////////////////////////////////////////////////////////////
/// 
/////////////////////////////////////////////////////////////////
/// Step 4: Switch your view back to the Designer and double-click
/// the exitButton control. In the code editor you see an empty
/// event handler named exitButton_CLick.
/// Complete the exitButton_Click event handler by typing the code
/// shown in lines 58-59 in Program 4-6.
//////////////////////////////////////////////////////////////////
/// 
//////////////////////////////////////////////////////////////////
/// Step 5: Save the project and run the application. Select a city
/// in the ListBox control and click the OK button to see its time
/// zone. Test each city, and when you are finished, click the 
/// Exit button, and the form should close.
//////////////////////////////////////////////////////////////////
 *//////////////////////////////////////////////////////////////////////