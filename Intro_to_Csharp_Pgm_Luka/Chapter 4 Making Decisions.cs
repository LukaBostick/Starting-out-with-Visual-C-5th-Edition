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

*/

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
 * wheather a specific relationship exists between two values
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 *//////////////////////////////////////////////////////////////////////
*/