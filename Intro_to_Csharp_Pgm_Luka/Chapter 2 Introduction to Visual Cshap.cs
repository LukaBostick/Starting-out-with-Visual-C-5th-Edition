/* //////////////////////////////////////////////////////////////////////////
 *
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 * //////////////////////////////////////////////////////////////////////////
 *	Chapter 2 Intorduction to Visual C#
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *                          Topics
 *
 * 2.1 Getting started with Forms and Controls
 *
 * 2.2 Creating the GUI for Your First Visual C# Application: The Hello World Application
 *
 * 2.3 Introduction to C# Code
 *
 * 2.4 Writting Code for the Hellow World Application
 *
 * 2.5 Label Controls
 *
 * 2.6 Making Sense of IntelliSense
 *
 * 2.7 PictureBox Controls
 *
 * 2.7 Comments, Black Lines, and Indentation
 *
 * 2.9 Writing the Code to CLose an Application's FOrm
 *
 * 2.10 Dealing with Syntax Errors
 * //////////////////////////////////////////////////////////////////////////
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 *              ^2.1 Getting Started with Forms and Controls
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *              #Concept
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * The first step in creating a Visual C# application is creating the
 * application's GUI. You use the Visual Studio Designer, Toolbox, and Prop
 * erties window to build the application's form with the desired controls
 * and set each control's properties.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * In this chapter, you will create your first Visual C# application. Before
 * you start, however, you need to learn some fundamental consepts about
 * creating a GUI in Visual Studio. This section shows the basics of
 * editing forms and creating controls.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *                      #The Application's Form
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * When you start a new Visual C# project, Visual Studio automatically
 creates an  empty form and displays it in the Designer.
 Figure 2-1 shows an example. Think of empty form as a blank canas that can
 be used to create the application's user interface. You can add controls to
 the form, the form's size, and modify many of its characteristics. When the
 application runs, the form will be displayed on the screen.
 * //////////////////////////////////////////////////////////////////////////
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 * @Figure 2-1 A new project with a blank form displayed in the Designer
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * IF you take a closer look at the form, you will notice that it is enclosed
 * by a thin dotted line, known as a bounding box. As shown in Figure 2-2, the
 * bounding box has small sizing handles, which appear on the form's right edge,
 * bottom edge, and lower-right corner. When a boundsing box appears around
 * an object in the Designer, it indicates that the object is selected and
 * ready for editing.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *  @Figure 2-2 The form's bounding box and sizing handles
 * //////////////////////////////////////////////////////////////////////////
 *
 *
 * //////////////////////////////////////////////////////////////////////////
 * You can easily resize the form with the mouse. When you position the mouse
 cursor any edge or corner that has a sizing handle, the cursor changes to
 a two-headed arrow(<->). Figure 2-3 shows examples.

 When the mouse cursor becomes a two-headed arrow, you can click and drag
 the mouse to resize form.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * @Figure 2-3 Using the mouse to redize the form
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * #Identifying Forms and Controls by Their Names
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * An application's GUI is made of forms and various controls.
  Each form and control in an application's GUI must have a name that
  identifies it. The blank form that Visual Studio initially creates
  in a new project is named Form1.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * #Note
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 * Later in this book, you will learn how to change a form's name, but for now
 * , you will keep the default name, Form1.
 * //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
 *							The Priperties Window
 * //////////////////////////////////////////////////////////////////////////
 *

	//////////////////////////////////////////////////////////////////////////
	The apperance and other carasteristics of a GUI objet are determined by
	the object's properties. When you select an object in the Designer, that object's
	properties are displayed in the Properties window. For example, when the
	Form1 form is selected, its properties are displayed in the Properties
	window, as shown in Figure 2-4.
	//////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 @Figure 2-4 The properties window, showing the selected objetc's properties
 5202 alic dr
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
			#Tip
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 Recall from Chapter 1 that if the Properties window is in Auto Hide mode,
 you can click its tab to open it. If you do not see the Properties window,
 click View on the menu bar. On the View menu, click Properties Window.
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 The area at the top of the Properties window shows the name of the object
 that is currently selected.

 You can see in Figure 2-4 that the name of the selected is Form1.
 B that is a scrollable list of properties.
 The list of properties has two columns: the left colimn shows each
 property's name, and the right column shows each property's value.

 For example, look at the form's Size property in Figure 2-4.
 Its value is 300, 300. This means that the form's size is 300 pixels wide
 by 300 pixels high. Next look at the form's Text property. The Text property
 determines the text that is displayed in the form's title bar.
 //////////////////////////////////////////////////////////////////////////
 *
 *
 //////////////////////////////////////////////////////////////////////////
 When a form is crated, its Text property is initially set to the same
 value as the form's name.

 When you start a new project, the blank form that appears in the Designer
 will always be named Form1, so the text Form1 will always appear in the
 form's title bar.
 In most cases, you want to change the value of the form's Text property
 to something more meaningful. For example, assume the Form1 form is
 currently selected. You can perform the following steps to change
 its test property to My First Program.
 //////////////////////////////////////////////////////////////////////////
 *
 * //////////////////////////////////////////////////////////////////////////
	~Steps
 //////////////////////////////////////////////////////////////////////////
 *

 //////////////////////////////////////////////////////////////////////////
 Step 1: In the Properties window, locate the Text property.

 Step 2: Double-click the word Form1 that currently appears as the Text
 property's value, and then use the Delete key to delete it.

 Step 3: Type My First Program in its place and press the enter key.
 The text My First Program will now appear in the form's title bar,
 as shown in Figure 2-5.
 //////////////////////////////////////////////////////////////////////////
 *
 *
 //////////////////////////////////////////////////////////////////////////
 @Figure 2-5 The form's Text property value displayed in the form's title bar
 //////////////////////////////////////////////////////////////////////////
 *
 //////////////////////////////////////////////////////////////////////////
		#Note
 //////////////////////////////////////////////////////////////////////////
 * 
 //////////////////////////////////////////////////////////////////////////
 Changing an object's Text property does not change the object's name. For
 example, if you change the Form1 form's Text property to My First Program,
 the form's name is still Form1. You have changed only the text that is 
 displayed in the form's title bar.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Earlier, we discussed how to use the moyse to resize a form in the Designer.
 An alternative method is to change the form's Size property in the
 Properties window.
 For example, assume the Form1 form is currently selected.
 You can perform the following steps to change its size to 400
 pixels wide by 100 pixels high.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 ~Steps
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Step 1: In the Properties window, locate the Size property.

 Step 2: Click inside the area that holds the Size property's
 value, and then delete the current value.

 Step 3: Type 400, 100 in its place and press the enter key.
 The form will be resized as shown in Figure 2-6
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 @Figure 2-6 The form's size changed to 400 by 100
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 #Note
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Notice in Figure 2-6 that the Alphabetical button is selected near the top
 of the properties window. This causes the properties to be displayed in 
 alphabetical order. Alternatively, the Categorized button can be selected,
 which causes the properties to be displayed in groups. The alphabetical
 listing is the default selection, and most of the time, it makes it easier
 to locate specific properties.
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 #Adding Controls to a Form
 //////////////////////////////////////////////////////////////////////////
 
 When you are ready to create controls on the application's form, you use the
 Toolbox. Recall from Chapter 1 that the Toolbox usually appeats on the left
 side of the Visual Studio environment. If the Toolbox is in Auto Hide mode,
 you can click its tab to open it. Figure 2-7 shows an example of how the 
 Toolbox typically appears when it is open.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 @Figure 2-7 The Toolbox
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 #Tip
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Recall from chapter 1 that if you do not see the Toolbox or its tab,
 click View on the menue bar and then click Toolbox.
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 The Toolbox shows a scrollable list of controls that you can add to a form.
 Top add a control to a form, you simply find it in the Toolbox
 and then double-click it. The control will be created on the form. For ex
 , suppose you want to create a Button control on the form. You find it in 
 the Toolbox, as shown in Figure 2-8, double-click it, and a Button control
 will appear on the form.
 

 //////////////////////////////////////////////////////////////////////////
 @Figure 2-8 Creating a Button control
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
								#Tip
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 You can also click and drage controls from the Toolbox onto the form.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
					#Resizing and Moving Controls
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Take a closer look at the Button control that is shown on the form in FiFigure 2-8.
 Notice that it is enclosed in a bounding box with sizing handles. This indicates 
 that the control is currently selected. When a control is selected, you can use
 the mouse to resize it in the same way that you learned to resize a form earlier. 

 You can also use the mouse to move a control to a new location on the form. 

 Position the mouse cursor inside the control, and when the mouse curso
 r becaomes a four-headed arrow, you can click and drag the control
 to a new location.
 Figure 2-9 shows a form with a Button control that has been enlarged and moved.
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 @Figure 2-9 A Button control resized and moved
 //////////////////////////////////////////////////////////////////////////



 //////////////////////////////////////////////////////////////////////////
 #Deleting a Control
 //////////////////////////////////////////////////////////////////////////
 Deleting a contril is simple: you select it and then press the Delete key
 on the keyboard.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 #More about Button Controls
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 You learned earlier that each form and each control on an application's GUI
 must have a name that identifies it. When you create Button controls,
 they are automatically given default names such as button1, button2 and so
 forth. Button controls have a Text property, which holds the text that is
 displayed on the face of the button. When a button control is created,
 its Text property is initiallt set to the dame value as the Button
 control's name. As a result, when you create a button contril, its name
 will be displayed on the face of the button. For example, the form in
 Figure 2-10 controls three Button controls
 named button1, button2, and button3.

 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Figure 2-10 A form with three Button controls
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 After you create a Button control, you should always change its Text
 property. The text that is displayed on a button should indicate what
 the button will do when it is clicked.
 For ex, a button that calculates an average might have the text Calculate
 Average display on it, and a button that prints a report might have the
 text Print Report displayed on it. Here are the steps you perform to
 change a Button control's Text property:

 //////////////////////////////////////////////////////////////////////////
 Steps
 //////////////////////////////////////////////////////////////////////////
 Step 1: Make sure the Button control is selected. (IF you don't see the 
bounding box and sizing handles around the control, just click the
contril to select it.)

 Step 2: In the Properties window, locate the Text property.

 Step 3: Click inside the area that holds the Text property's value,
 and then delete the current value. Then, type the new text in its place
 and press the enter key.  The new text will be displayed on the button.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Figure 2-11 shows an example of how changing a Button control's Text property
 changes the text display on the face of the button.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Figure 2-11 A Button control's Text property changed
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Changing a Control's Name
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 A control's name identifies the control in the application's code and in 
 the Visual Studio environment. When you create a contril on an
 application's form, you should always change the control's name to
 something that is more meaningful than the dafult name that Visual Studio
 gives it. A controls name should reflect the purpose of the control.
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 For example, suppose you've created a Button control to calculate an amount
 of tax. A default name such as button1 does not convey the button's purpose.
 A name such as calculatetaxButton would be much better
 . When you are working with the application's code and you see the name
 calculateTaxButton, you will know percisely which button the code is
 referring to.

 You can change a control's name by changeing its name propertly. Here are the steps:


 //////////////////////////////////////////////////////////////////////////
 Step1: Make sure the controls is selected. (If you do not see the bounding
box and sizing handles around the control, just click the control to select it.)

 Step 2: In the Properties window, scroll up to the top of the list if 
properties. You should see the Name property, as shown in Figure 2-12. 
(The Name property is enclosed in parenthese to make it appear near the
top of the alphabetical list of properties. This makes it easier to find.)

 Step 3: Click inside the area that holds the Name property's value and 
then delete the current name. Then, type the new name in its place and 
press the Enter key. You have successfully changed the name of the control

 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 Figure 2-12 The Name property
 //////////////////////////////////////////////////////////////////////////
 

 //////////////////////////////////////////////////////////////////////////
 Figure 2-13 shows the Properties window after a Button control's name has
 been changed to calculateTaxButton
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Figure 2-13 The Name property changed to calculateTaxButton
 //////////////////////////////////////////////////////////////////////////



 //////////////////////////////////////////////////////////////////////////
 Rules for Naming Controls
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Control names are also know as identifiers. When nameing a control, 
you must follow these rules for C# identifiers:

 * The first character muct be one of the letters a through z or A 
 * through Z or an underscore character(_).
 * 
 * After the first character, you may use the letters a through z or
 * A through Z, the digits 0 through 9, or underscores.

 *The name cannot contain spaces.

 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Table 2-1 lists some identifiers that might be used for Button control
 names and indicates whether each is a legal or illegal identifier in C#
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Table 2-1 Legal and illgal identifiers
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 Because a control's name should reflect the control's purpose, programmers
often find themselves creating names that are made of multiple words. 
For ex, consider the following button control names:
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 calculatetaxbutton
 printreportbutton
 displayeanimationbutton
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
Unfortunately, these names are not easily read by the human sys because the
words are not separated. Because we cannot have spaces in contril names,
we need to find another way to separate the words in a multiword control
names to make it more readable to the human eye.
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 Most C# programmers address this problem by using the camelCase naming
convention for controls. camelCase names are written in the following manner:

 * you begin writing the name with lowercase letters.
 * 
 * The first character of the second and subsequent words is written in uppercase
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 for ex, the following control names are written in camelCase:

 calculateTaxButton
 orintReportButton
 displayAnimationButton
 //////////////////////////////////////////////////////////////////////////


 //////////////////////////////////////////////////////////////////////////
 note
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 This stlt of naming is called camelCase because the uppercase charactrers
 that appear in a name are sometimes reminiscent of a camel's humps.
 //////////////////////////////////////////////////////////////////////////
 
 //////////////////////////////////////////////////////////////////////////
 2.2 Creating the GUI for Your First Visual C# Application: The Hello World Application
 
 //////////////////////////////////////////////////////////////////////////
 When a student is learing computer programming, it is traditional to start
 by learning to write a Hello World program.
 A Hello World program is a simple program that merely displays the words
 "Hello World" on the screen. In this chapter you will create your first
 Visual C# application, which will be an event-driven Hello World program.
 When the finished application runs, it will display the form shown on the
 left in Figure 2-14. Notice that the form contains a button that reads
 Display Message. When you click the button, the window shown on the right
 in the figure will appear.
 //////////////////////////////////////////////////////////////////////////
 Figure 2-14 Screens displayed by the completed Hello World program
 //////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
 The process of creating this application is divided into two parts. First,
 you create the application's GUI, and second, you write the code that causes
 the Hello World message to appear when the user clicks the Display Message button.
Tutorial 2-1 leads you through the process of creatring the GUI
//////////////////////////////////////////////////////////////////////////

 //////////////////////////////////////////////////////////////////////////
	Tutorial 2-1: Creating the GUI for the HELLO WORLD Application
 //////////////////////////////////////////////////////////////////////////
 
//////////////////////////////////////////////////////////////////////////
///Step 1: Start Visual Studio.
///
/// Step 2: start a new project by clicking FIle on the menu bar and then selecting New project...
/// 
/// Step 3: The New project window should appear.
/// At the left of the window, under Unstalled > Templates,
/// make sure Visual C# is selected. Then, select Windows
/// Forms App (.NET Framework) as the type of application.
/// In the Name text box (at the bottom of the window), change the name
/// of the project to Hello World, and click the Ok button.
/// 
/// Step 4: Make sure the Toolbox, the Solution Explorer, and the Properties
/// window are visible and that Suto Hide is turned off for each of these
/// windows. The Visual Studio environment should appear
/// as shown in Figure 2-15.
/// 
/// Step 5: Change the Form1 form's Text property to My First Program,
/// as shown in Figure 2-16.
/// 
/// Step 6: The form's default size is too large for this application,
/// so you need to make it smaller. Use the technique discussed in the
/// previous section to adjust the form's size with the mouse. The form
/// should appear similar to that shown in Figure 2-17. (Don't worry
/// about the form's exact size. Just make it appear similar to Figure 2-17.)
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-17 The form resized
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 7: New you are ready to add a Button control to the form.
/// Locate the Button tool in the Toolbox and double-click it. A 
/// Button control should ap[pear on the form, as shown in Figure 
/// 2-18. Move the Button control so it appears approximately in 
/// the center of the form, as shown in Figure 2-19.
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-18 A Button control created on the form
/// //////////////////////////////////////////////////////////////////////////
/// 
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-19 The Button control moved
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 8: Change the value of the Button control's Text property to
/// display Message. After doing this, notice that the text displayed
/// on teh button has changed, as shown in Figure 2-10.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-20 The Button control's Text property changed
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 9: The Button control isn't quiew large enough to accommodate
/// all of the text that you typed into its Test property, so enlarge 
/// the Button control, as shown in Figure 2-21
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-21 The Button control enlarged
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 9: The Button control isn't quite large enough to accommodate all
/// of the text that you typed into its property, so enlarge the Button 
/// control, as shown in Figure 2-21. 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
///  Figure 2-21 The Button control enlarged
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 10: As discueed in the previous section, a control's name should
/// reflect the puropse of the control. The Button control that you created
/// in this application will cause a message to be displayed when it is
/// clicked. The name button1 does not convey that purpose, however. Change 
/// the Button control's Name property to message Button. The Properties 
/// window should appear as shown in Figure 2-2
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-22 The Button control's Name property changed to messageButton
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 11: Click file on the Visual Studio menu bar and
/// then click saved all to save the project.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Step 12: You're only partially finished with the application, but you can
/// run it now to see how the GUI looks on the screen. To run the application,
/// press the F5 key on the keyboard or click the Start Debugging button() 
/// on the toolbar. This causes the application to be comiled and executed.
/// You will notice the appearance of the Visual Studio environment change 
/// somewhat, and you will see the application's form appear on the screen
/// as shown in Figure 2-12.
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-23 The application running
/// //////////////////////////////////////////////////////////////////////////
/// Although the application is running, it is not capable of doing anything
/// other than displaying the form. If you click the Display Message button,
/// nothing will happen. That is because you have not yet written the code
/// that executes when the button is clicked. You will do that in the next
/// tutorial. To end the application, click the standard Windows close 
/// button(X) in the form's upper-right corner.
/// //////////////////////////////////////////////////////////////////////////
/// 
/// //////////////////////////////////////////////////////////////////////////
/// 2.3 Introduction to C# Code
/// //////////////////////////////////////////////////////////////////////////
/// Concept
/// //////////////////////////////////////////////////////////////////////////
/// You use the Visual Studio code editor to write an application's code.
/// Much of the code that you will write in an application wil be event
/// hanflers. Even handlers respond to speficic events that take place
/// while an application is running.
/// //////////////////////////////////////////////////////////////////////////
/// In the previous sections of this chapter, you learned the basics
/// of creatiing an application's GUI. An application is more than
/// a user interface, however. If you want your application 
/// to pteform any meaningful actions, you have to write code.
/// This section introduces you to Visual C# code and shows how
/// to program an application to respond to button clicks. 
/// A file that contains program code is called a cource code file.
/// When you start a C# windows Forms Application project. If you look at
/// the Solution Expolrer, as shown in Fiogure 2-24, you will see the names
/// of two source code files: Form1.cs and Program.cs. (C# source code files
/// always end with the .cs extension.)
/// //////////////////////////////////////////////////////////////////////////
/// Figure 2-24 Source code files shown in the Solution Explorer
/// 
/// //////////////////////////////////////////////////////////////////////////
/// Here is a brief description of the two files:
/// //////////////////////////////////////////////////////////////////////////
 // * The Program.cs files contains the application's start-up code,
which executes when the application runs. The code in this files 
performs behind-the-scenes initialization tasks that are necessary
to get the application up and running. It is important that you do
not modify the contents of this file because doing so could prevent 
the application from executing.
 /// //////////////////////////////////////////////////////////////////////
 /// * The Form1.cs file contrains code that is associated with the 
 /// Form1 form. When you write code that defines some action related
 /// to Form1(such as responding to a button click), you will write 
 /// the code in this file.
 /// //////////////////////////////////////////////////////////////////////
 /// Note You might see additional source code files in the Solution
 /// Explorer, other than those whown in Figure 2-24
//////////////////////////////////////////////////////////////////////
///	 The Form1/cs files alreadu contains code that was generated by
///	 Visual Studio when the project was created. You think of this
///	 auto-generated code as an outline to which you can add your
///	 own code as you develop the application.
/// //////////////////////////////////////////////////////////////////////
/// Let's take a look at the code. If you still have the Hello World
/// program open from the previous tutorial, right-click Form1.cs in
/// the Solution Explorer. A pop-up menu will appear, as shown in
/// Figure 2-25. On the pop-up menu, click View Code. The file's 
/// contents will be displayed in the Visual Studio code editor, 
/// as shown in Figure 2-26.
/////////////////////////////////////////////////////////////////////////
///Figure 2-25 Opening Form1.cs in the code editor
/////////////////////////////////////////////////////////////////////////
///2-26 Form1.cs code displayed in the Visual Studio code editor
/////////////////////////////////////////////////////////////////////////
///At this point, it's not necessary for you to understand the meaning
///of the statements that you see in this code. It will be helpful for
///you to know how this code is organized, however, because later will
///add your own code to this file. C# code is primarily organized in
///three ways: namespaces, classes, and methods. Here's a summary:
/////////////////////////////////////////////////////////////////////////
///* A namespace is a container that holds classes.
///
/// //////////////////////////////////////////////////////////////////////
/// A class is a container that holds methods (among other things).
/// //////////////////////////////////////////////////////////////////////
/// *A method is a group of one or more programming statements that performs some operation.
/// //////////////////////////////////////////////////////////////////////
/// So, C# code is organized as methods, which are caontained inside
/// classes, which are contrained inside namespaces. With this
/// organization atructure in mind, look at Figure 2-17.
/// 
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-17 Organization of the Form1.cs code
/// //////////////////////////////////////////////////////////////////////
/// The figure shows four different sections of the code, marked with the
/// numbers 1,2,3, and 4. Let's discuss each section of code.
/// //////////////////////////////////////////////////////////////////////
/// 1. Recall from Chapter 1 that C# applications rely heavily on the .NET
/// Framework, which is a collection of classes and other code. The code
/// in the .NET Framework is organized into namespaces. The series of
/// using directives that appears at the top of a C# sour ce code files
/// indicate which namespaces in the .NET Framework the program will use.
/// //////////////////////////////////////////////////////////////////////
/// 2. This section of code creates a namespace for the project. The line
/// that reads namespace Hello_World marks the beginning of a namespace
/// named Hello_World. Notice that the next line contains an opening 
/// brace({) and that the last line in the file contains a corresponding
/// closing brace (}). All the code that appears between these braces is 
/// inside the Hello_World namespace.
/// //////////////////////////////////////////////////////////////////////
/// 3. This section of code is a class declaration. The line that reads
/// public partial class, and so forth marks the beginning of the class.
/// The next line contains an opening brace is ({), and the last line in
/// this section of code contains a corresponding closing brace(}). All
/// the code that appears between these braces is inside the class
/// //////////////////////////////////////////////////////////////////////
/// 4. This section of code is a method. The line that reads public
/// Form1() marks the beginning of the method. The next line contains
/// an opening brace(}), and the last line in this section of code 
/// contains a corresponding closing brace(}). The code that appears 
/// between these braces is inside the method.
/// //////////////////////////////////////////////////////////////////////
/// It's important to point out that code containser, such as namespcace,
/// classes, and methods, use braces(}) to enclose code. Each opening
/// brace ({) must have a corresponding closeing brace(}) at some point
/// later point in the program. Figure 2-18 shows how the braces in
/// Form1.cs are paired.
/// //////////////////////////////////////////////////////////////////////
/// Switching between the COde Editor and the Designer
/// //////////////////////////////////////////////////////////////////////
/// When you open the code editor, it appears in the same part of the
/// screen as the designer. While devloping a Visual C# application,
/// you will often find yourself needing to switch back and forth between
/// the Designer and the code editor. One way to quickly switch between
/// the two windows is to use the tabs shown in Figure 2-29. In the 
/// figure, notice that the leftmost tab reads Form1.cs. That is the 
/// tab for the code editor. The rightmost tab reads Form1.cs [Design].
/// That is the tab for the Designer. (The tabs may not always appear in
/// this order.) To switch between the Designer and the code editor, you
/// simply click the tab for the desired window.                       
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-29 Code editor and Designer tabs
/// //////////////////////////////////////////////////////////////////////
/// You can also detach the code editor and move it to another part of the
/// screen. This allows you to see the code tab and drag it to the desired
/// location on the screen. (If you have multiple monitors connected to
/// your computer, you can even drag the code editor to a different
/// monitor.) To return the code editor to its position within the IDE,
/// right-click the tab for the source code file in the code editor window 
/// and select Move to Main Document Grcument Group.
/// This is shown in Figure 2-31.
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-30 Detaching the code editor by clicking and dragging
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-31 Returning the code editor to its docked position
/// //////////////////////////////////////////////////////////////////////
/// Add Your Own Code to a Project
/// //////////////////////////////////////////////////////////////////////
/// Now you are ready to learn how to add your own code to a project.
/// Suppose you have created a project named Code Demo and set up the
/// project's form with a Button control, as shown in Figure 2-32. The
/// Button control's name is myButton, and its Text property is set to Click me!.
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-32 A form with a Button control
/// //////////////////////////////////////////////////////////////////////
/// Suppose you want the application to display the message Thanks for
/// clicking the button! When the user click the button. To accomplish
/// that, you need to write a special type of method known as an event
/// handler. An event handler is a method that executes when a specified
/// event takes plcace while an application is runnung. In this project
/// you need to write an event handler that will execute when the user
/// clicks the myButton control. To create the event handler, you
/// double-click the myButton control in the Designer. This opens the
/// Form1.cs file in the code editor, as shown in Figure 2-33, with
/// some new code added to it.
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-33 The code window opened with event handler code generated
/// //////////////////////////////////////////////////////////////////////
/// When an application is running and the user clicks a control, we say
/// that a Click event has occurred on the control. The code that has been
/// added to the Form1.cs file (shown in Figure 2-33) is an event hanfler
/// that will execute when a click event occurs on the myButton control.
/// For now you do not need to understand all parts of the event handler
/// code. At this point, you need to understand only the following concepts:
/// //////////////////////////////////////////////////////////////////////
/// * As shown in Figure 2-34, the event handler's name is myButton_Click.
/// The myButton portion of the name indicates that the event handler is
/// associated with the myButton control, and the Click portion of the
/// name indicates thatthe event handler responds to Click events.
/// This is the typical naming convention that Visual Studio uses when
/// it generates event handler code. When you see the name myButton_Click,
/// you understand that it is an event handler that executes when a click
/// event occurs on the myButton control.
/// //////////////////////////////////////////////////////////////////////
/// * The event handler that Visual Studio generates dosen't actually do
/// anything. You can think of it as an empty container to which uyou can
/// add your own code. Notice that the second lione of the event handler
/// is an opening brace({) and the last line is a closing brace(}).
/// Any code that you want executed when the user clicks the myButton
/// control must be written between these braces.
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-34 A closer look at the event handler code
/// //////////////////////////////////////////////////////////////////////
/// Now you know how to create an empty Click event handler for a Button
/// control. But what code do you write inside the event handler? in this
/// examplw, we write code that displays the message Thanks for clicking
/// the button! in a message box, which is a small pop=up window.
/// //////////////////////////////////////////////////////////////////////
/// Message Boxes
/// //////////////////////////////////////////////////////////////////////
///  A message box is a small window, sometimes referred to as a dialog
///  box, that displays a messasge. Figure 2-35 shows an example of a
///  message box displaying the message  Thanks for clicking the button!
///  Notice that the message box also has an OK button. When the user
///  clicks the OK button, the message closes. 
/// //////////////////////////////////////////////////////////////////////
/// Figure 2-35 A message box
/// //////////////////////////////////////////////////////////////////////
/// The .NET Framework provides a method named MessageBox.Show that you
/// can use in Visual C# to display a message box, If you want to execute
/// the MEssageBox.Show method, you write a statement known as a
/// method call. (Programmers refer to the action of excuting a method
/// as calling the method.) The following statement shows an example of
/// how you would call the MessaegBox.Show method to display the message
/// box shown in Figure 2-35:
/// //////////////////////////////////////////////////////////////////////
/// MessageBox.Show("Thanks for clicking the button!");
/// //////////////////////////////////////////////////////////////////////
/// When you call the MessageBox.Show method, you write a string of
/// characters inside the parentheses. (In ptogramming, we use the
/// term string to mean string of characters.) The tring that is
/// wrtten inside the parentheses will be displayed in the message
/// box. in this example, the string ""Thanks for clicking the button!"
/// is written in the parentheses.
/// //////////////////////////////////////////////////////////////////////
/// Notice that the string is enclosed in double quotation marks in
/// the code. When the message is displayed (as shown in Figure 2-35),
/// however, the double quotation marks do not appear. The double
/// marks are required in the code to indicate the beginning and 
/// end of the string.
/// 
/// //////////////////////////////////////////////////////////////////
/// Also notice that a smenicolon appears at the end of the statement.
/// This is required bhy C# syntax. Just as a period marks the end of
/// a sentence, a semicolon marks the end of a programming
/// statement in C#
/// //////////////////////////////////////////////////////////////////
/// Getting back to our Code Demo example project, Figure 2-36 shows
/// how you can call the MessageBox.Show method form the
/// myButton_Click event handler. After typing the statement as shown
/// in the figure, you can press the F5 key on the keyboard, or click
/// the Start Dubugging button on the tollbar to compile and run the
/// application. When the application runs, it will display the form
/// shown on the left in Figure 2-37. When you click the button, the
/// message box shown on the right in the figure will appear. You can
/// click the OK button on the message box to close it.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-36 Event handler code for displaying a message box
/// //////////////////////////////////////////////////////////////////
/// Figure 2-37 The COde Demo project running 
/// //////////////////////////////////////////////////////////////////
/// Note When writing a Click event handler for a Button control, you
/// might be wondering if it is necesssary to first double-click the
/// Button control in the Designer, creating the empty event handler
/// code. After all, couldn;t you just skip this step and instead open
/// the code editor and write all the event handler code yourself?
/// The answer is no, you cannot skip this step. When you double-clik
/// a control in the Designer, Visual Studio not only creates an empty
/// event handler, but it also writes some code that you don't see
/// elsewhere in the project. this other code is neccssary for the 
/// event handler to properly function.
/// //////////////////////////////////////////////////////////////////
/// String Literals  
/// //////////////////////////////////////////////////////////////////
/// Programs almost always work with data of some type. For example,
/// the code shown in Figure 2-36 uses the following string when it
/// calls the MEssageBox.Shown method:
/// //////////////////////////////////////////////////////////////////
/// "Thanks for clicking the button!"
/// //////////////////////////////////////////////////////////////////
/// This string is the data that is displayed by the program. When a piece
/// of data is written into a program's code, it's called a literal
/// (because the data is literally written into the program).
/// When a string is wrtten into a program's code, it's called a
/// string literal. In C# string literals must be enclosed
/// in double quotation marks.
/// //////////////////////////////////////////////////////////////////
/// Note: Programmer sometimes say that literals are values that are hard
/// coded into a program because the value of a literal cannot change
/// while the program is running.
/// 
/// //////////////////////////////////////////////////////////////////
/// Multiple Buttons with event Handlers
/// //////////////////////////////////////////////////////////////////
/// The Code Demo project previously shown has only one button with
/// a Click event handler. Many of the application that will develop
/// will have multiple buttons, each with its own CLick event handler.
/// For example, the form shown in Figure 2-38 has three Button
/// controls. As shown in the figure, the controls are named
/// firstButton, secondButton, and thirdButton.
/// //////////////////////////////////////////////////////////////////
/// To create Click event handlers for the button, you simply
/// double-click each Button control in the Designer and an empty
/// event handler will be created in the form's source code file.
/// The names of the Click event handlers will be firstButton_CLick,
/// secondButton_Click, and thridButton_Click. Figure 2-39 shows an 
/// example of the form;s source code after the three event handlers
/// have been created and MessageBos.Shown statement has been added
/// to each one.
/// //////////////////////////////////////////////////////////////////
/// Design Time and Run Time
/// //////////////////////////////////////////////////////////////////
/// When you have a project open in Visual Studio, the time during
/// which you build the GIU and write the application's code is
/// reffered to as design time. During design time, you can use the
/// Designer and the Toolbox to place controls on the form, use the
/// Properties window to set property values, use the code editor
/// to write code, and so forth. This is the phase during which
/// you create or modify the application.
/// //////////////////////////////////////////////////////////////////
/// When you are ready to run a project that you have open in visual
/// studio, you press F5 key on the keyboard or click the Start
/// Debugging button on the toolbar. The project will be compiled,
/// and if there were no errors, it will be executed. The time during
/// which an application is executing is referred to as run time.
/// During run time, you can can interact with the running
/// application, but you cannot use the Designer, the Toolbox, the
/// Properties window, the code editor, or parts of Visual Studio
/// to make changes to it.
/// //////////////////////////////////////////////////////////////////
/// Note: In computing literature and on the Web, you will see the
/// term run time also spelled as runtime or run-time. All these 
/// variations typically mean the same thing.
/// //////////////////////////////////////////////////////////////////
/// 2.4 Writing Code for the Hello World Application
/// //////////////////////////////////////////////////////////////////
/// Now you know everthing necessary to complete the Hello World
/// project. In Tutorial 2-2, you will open the project and add
/// a Click event handler for the messageButton control.
/// The event handler will call the MessageBox.Shown method to display
/// a message box with the message Hello World.
/// //////////////////////////////////////////////////////////////////
/// Tutorial 2-2: Writing COde for the Hello World Application
/// //////////////////////////////////////////////////////////////////
/// Step 1:	If visual Studio is not already running, start it.
/// Open the Hello World project that you started in Tutorial 2-1.
/// //////////////////////////////////////////////////////////////////
/// Step 2: Make sure Form 1 form is visible in the Designer, as shown
/// in Figure 2-40 if it is not, right-click Form1.cs in the COlution
/// Explorer and the nselect View Designer from the pop-up menu.
/// //////////////////////////////////////////////////////////////////
/// Step 3: IN the Designer, double-click the messageButton control.
/// This should cause the code editor to appear as shown in Figure
/// 2-41. Notice that an empty event handler named
/// messageButton_Click has been created.
/// //////////////////////////////////////////////////////////////////
/// Inside the messageButton_Click event handler, type the following
/// statement exactly as it is shown:
/// //////////////////////////////////////////////////////////////////
/// MessageBox.Show("Hello World");
/// //////////////////////////////////////////////////////////////////
/// Don't forget to type the semicolon at the end of the statement!
/// When you have finished, the code window should look like Figure 2-42.
/// //////////////////////////////////////////////////////////////////
///	Step 5 Save the project 
/// //////////////////////////////////////////////////////////////////
/// Step 6: Press the F5 key on the keyboard, or click the Start
/// Dubugging button on the toolbar to compile and run the application.
/// //////////////////////////////////////////////////////////////////
/// Note If you typed the statement correctly inside the messageButton_Click
/// event handler (in Step 4), the application should run. IF you did
/// not type the statement correctly, however, a window will appear
/// reporting build errors. If that statement correctly, however, a 
/// window will appear reporting build errors. If that happens, click 
/// the No button in the window and then correct the statement so
/// it appears exactly as shown in Figure 2-24.
/// //////////////////////////////////////////////////////////////////
/// When the application runs, it will display the form shown on the 
/// left in Figure 2-43. When you click the Display Message button,
/// the message box shown on the right in the figure will appear.
/// You can click OK button on the message box to close it.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-43 The Hello World application running
/// //////////////////////////////////////////////////////////////////
/// 2.5 Label Controls
/// //////////////////////////////////////////////////////////////////
/// Concept : A Label control displays text on a form. Label controls
/// have various properties that affect the control's appearance.
/// Label controls can be used to display unchanging text,
/// or program output.
/// //////////////////////////////////////////////////////////////////
/// When you want to display test on a form, you use a Label control. 
/// Figure 2-44 shows an example of a form with two Label controls. 
/// Once you have placed a Label control on a form, you set its Text
/// property to the text that you want to display. For example,
/// in Figure 2-44, the upprt Label control's Text property is
/// set to Number of Hours Worked, and the lower LAbel control's 
/// Text property is set to Hourly Pay Rate.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-44 A form with Label controls
/// //////////////////////////////////////////////////////////////////
/// You'll find Label control tool in the common Controls group of the 
/// Toolbox, as shown in Figure 2-45. To Create a Label control on a
/// form, you double-click the Label control tool in the Toolbox. As
/// shown in Figure 2-45, a Label control will be created on the form.
/// (Alternatively, you can click and frag the Label control tool from
/// the Toolbox onto the form.) Notice that a bounding box appears
/// around the Label control in the figure. This inducates that the
/// control is currently selected.)
/// //////////////////////////////////////////////////////////////////
/// Figure 2-45 Creating a LAbel control
/// //////////////////////////////////////////////////////////////////
/// When you create Label controls, they are automatically given
/// default names such as label1, label2, and so forth. A Label 
/// control's Test property is initially set to the same value as the
/// Label control's name. So, a LAbel control will display its own
/// name when it is created, as shown by the example in Figure 2-45.
/// When a LAbel control is selected in the Designer, you can use the
/// Properties window to change its Text property. Figure 2-46 shows
/// a Label control after its Text property has been changed to
/// Programming in Visual C# is fun! 
/// 
/// //////////////////////////////////////////////////////////////////
/// Figure 2-46 A LAbel control displaying a message
/// //////////////////////////////////////////////////////////////////
/// You can also use the Properties window to change a Label control's
/// name. It's always a good idea to change a control's name to
/// something that is more meaningful than the default name that
/// Visual Studio gives it.
/// //////////////////////////////////////////////////////////////////
/// The Font Property
/// //////////////////////////////////////////////////////////////////
/// If you want to change the apperance of a LAbel control's text,
/// you can change the control's Font property. The Font property
/// allows you to set the font, font style, and size of the control's
/// text. When you select the Font property in the Properties window,
/// you will notice that an ellipses button (...) appears next to the
/// property's value, as shown in Figure Figure 2-47. When you click
/// the ellipses button, the Font dialog box appears next to the 
/// property's value, as shown in Figure Figure 2-48. Select a font,
/// font style, and size, and click OK. The text displayed by the
/// control will be updated with the selected attributes. For example,
/// Figure 2-49 shows a Label control with the following Font property
/// attributes:
/// //////////////////////////////////////////////////////////////////
/// Font: Lucida Handwriting
/// 
/// Font Style: Italic
/// 
/// Size: 10 point
/// //////////////////////////////////////////////////////////////////
/// Figure 2-47 The Font property
/// 
/// //////////////////////////////////////////////////////////////////
/// Figure 2-48 The Font dialog box
/// 
/// //////////////////////////////////////////////////////////////////
/// Figure 2-49 A label's appearance with altered font attributes
/// //////////////////////////////////////////////////////////////////
/// The BorderStyke Prioerty
/// //////////////////////////////////////////////////////////////////
/// Label controls have a BorderStyle property that allows you to 
/// display a boarder around the control's text. The BorderStyle
/// property may have one of three values: None, FixedSingle, or
/// Fixed3D. The property is set to None dy default, which means
/// that no border will appear arounf the control's text. If the
/// BorderStyle propertyis set to Fixed3D, the control's text will
/// have a recessed 3D appearance. Figure 2-50 shows an example of
/// Label control with each BoarderStyle setting. The inage on the
/// left in the figure shows the form in the Designer, and the image
/// on the right shows the form at runtime.
/// //////////////////////////////////////////////////////////////////
/// Figure shows the form in the Designer, and the image on the
/// right shows the form in the Designer, and the image on the right
/// shows the form at runtime.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-50 BoarderStyle examples
/// //////////////////////////////////////////////////////////////////
/// To change the BoarderStyle property, select it in the Properties
/// windows and then click the down arrow button that appears next
/// to the property's value. AS shown in Figure 2-51, a drop-down
/// list will appear containing the three possible values for this
/// property. Select the desired value and the control's text 
/// will be updated.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-51 BoarderStyle selections
/// //////////////////////////////////////////////////////////////////
/// The AutoSize Property
/// //////////////////////////////////////////////////////////////////
/// Label controls have an AutoSize property that controls the way
/// they cam be resized. The AutoSized property is a Boolean property,
/// which means that it can be set to one of two possible values:
/// True or False. By default, a Label control's AutoSize property
/// is set to True, which means that the control automatically resizes
/// itseld to accommodate the size of the text it displays.
/// For example, look at the three Label controls in Figure
/// 2-52. Each of the controls displays different amounts of text
/// at different font sizes. Because each control's BoarderStyle
/// property is set to Fized Single, you can see that each control
/// is just large enough to accommodate its text.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-52 Label controls with AutoSize set to True
/// //////////////////////////////////////////////////////////////////
/// When a LAbel control's SutoSize property is set to True, you
/// cannot manuially change the size of the control by clicking and
/// dragging its bounding box. If you want to manually change the
/// size of a Label control you have to set its AutoSize property
/// to False. WHen AutoSize is set to False, sizing handles will
/// appear around the control, allowing you click and drag the
/// bounding box to resize the control. Figure 2-53 shows an example.
/// In the figure, the Label control has been resized so it is much
/// larger than the text it displays.
/// //////////////////////////////////////////////////////////////////
/// 
/// Figure 2-53 Label control with AutoSize set to False
/// //////////////////////////////////////////////////////////////////
/// Note WHen a LAbel control's AutoSize property is set to True,
/// the label's text will always appear on one line. When the AutoSize
/// property is set to False, the label's text will wrap across
/// multiple line if it is too long to fit one line.
/// //////////////////////////////////////////////////////////////////
/// The TextAlign Property
/// //////////////////////////////////////////////////////////////////
/// When you set a LAbel control's AutoSize property to False and
/// the nmanually resize the control, it sometimes becaomes necessary
/// to change the way the label's text is aligned. By default, a
/// label's text is aligned with the top and left edges of the
/// label's bounding box. For example, look at the label shown
/// in Figure 2-53. Notice how the text is positioned in the the
/// lower-right cornner? We can change the text's alignmetn in the
/// label with the TextAlign property. The TextAlign property may
/// be set to any of the following values: TopLeft, TopCenter,
/// TopRight, MiddleLeft, MiddleCenter, MiddleRight, BottomLeft,
/// BottomCenter, or BottomRight. Figure 2-54 shows nine Label
/// controls, each with a different TextAlign value.
/// //////////////////////////////////////////////////////////////////
///		Figure 2-54 Text alignments
/// //////////////////////////////////////////////////////////////////
/// To change the TextAlign property, elecet it in the Properties
/// window and the click the down-arrow button that appears next 
/// to its value. This causes a dialog box with nine buttons, as
/// shown in the left image in Figure 2-55, to appear. As shown
/// on the right image in the figure, the nine buttons represent
/// the valid settings of the TextAlign property.
/// //////////////////////////////////////////////////////////////////
/// Using Code to Display Output in a Label Control
/// //////////////////////////////////////////////////////////////////
/// In addition to displaying unchanging text on a form, Label
/// controls are also useful for displaying ooutput while an
/// application is running. For example, suppose you are creating
/// an application that performs a calculation and you want to
/// display the result of the calculation at a specific location
/// on the form. Using a Label control to display the output would
/// be an ideal solution. Here are the general
/// steps that you would follow:
/// //////////////////////////////////////////////////////////////////
/// Step 1: While creating the application's GUI, you plae a Label
/// control on the form at the locatuion where you want the result
/// to be displayed. Then, in the PRoperties window, you erase the
/// contrents of the Label control's Text property. Because the
/// control's Text property is empty, control will initially display
/// anything when the application runs.
/// 
/// Step 2: IN the application's code, you write the necessary 
/// statements to preform the calculation and then you store the 
/// results of the calculation in the Label control's Text property.
/// This causes the result to be displayed on the form in the Label
/// control.
/// //////////////////////////////////////////////////////////////////
/// Note We do not discuss calculations until Chapter 3, so in this
/// chapter we looks at examples that display nonmathematical
/// data as output in Label controls.
/// //////////////////////////////////////////////////////////////////
/// In code, you use an assignment statement to store a value in a
/// control's property. For Example, suppose you have created a Label
/// control and named it outputLabel. The following assignment 
/// statement stores the string "Thank you very much" in the controls
/// Text property.
/// //////////////////////////////////////////////////////////////////
/// outputLabel.Text = "Thank you very much";
/// //////////////////////////////////////////////////////////////////
/// The equal sign (=) is know as the assignment operator. It assigns the
/// value that appears on its right side to the item that appears on its
/// left side. In this example, the item is on the left of the
/// assignment operator is the expression outputLabel.Text. This is
/// simply the outputLabel control's Text property. The value on the
/// right side of the assignment operator is the string ""Thank you
/// very much". When this statement executes, the string "Thank you
/// very much" is assigned to the outputLabel control's Text property.
/// When this statement executes, the text Thank you very much is
/// displayed in the Label control.
/// //////////////////////////////////////////////////////////////////
/// WARNING! When writing assignment statements, remeber that the item
/// receiving the value much be on the left side of the = operator.
/// The following statement, for example, is wrong and will cause an
/// error when you compile the program:
/// "Thank you very much" = outputLabel; <- ERROR!
/// //////////////////////////////////////////////////////////////////
/// Note The standard notation for referring to a control's property in code is:
/// //////////////////////////////////////////////////////////////////
/// ControlName.PropertyName
/// //////////////////////////////////////////////////////////////////
/// Let's look at an example application that uses a Label control to display output.
/// Make sure you have downloaded the student sample programs from the book's companion Web site ()
/// https://media.pearsoncmg.com/ph/esm/ecs_gaddis_sowvcsharp_5/cw/index.php#videonotes
/// https://media.pearsoncmg.com/ph/esm/ecs_gaddis_sowvcsharp_5/cw/index.php.
/// In the Chap02 folder, you will find a project named Presidential
/// Trivia. The purpose of the application is to display a trivia
/// question about a former U.S. president. When the user clicks
/// a button, the answer to the trivia question is displayed on 
/// the form. The project's form appears as shown in Figure 2-56.
///  //////////////////////////////////////////////////////////////////
///  As shown in the figure, the form has the three controls:
///  
///	 * A LAbel control named questionLabel.
///	 This label displays the trivia question.
///	 
///  * A LAbel control named answerLabel.
///  This label initially appears empty, but will be used to display
///  the answer to the trivia question.
///  
/// * A Button control named showAnswerButton. When the user clicks
///  this button, the answer to the trivia question is displayed.
///  //////////////////////////////////////////////////////////////////
///  Table 2-2 lists the property settings for each control of which you should take note.
///  //////////////////////////////////////////////////////////////////
///  __________________________________________________________________
///  |Control Name		Control Type			Property Settings	  |													     	  |
///  |----------------------------------------------------------------|
///  |questionLabel1|    LAbel    |AutoSize:False 					  |
///  |				|			  |BorderStyle: None	              |
///  |				|			  |Font: Microsoft Sans Serif         |
///	 |              |			  |	(Style: Regular, Size: 10 point)  |
///  |              |             |Text: What former U.S president is |
///	 |				|			  |known for going on an African      |
///  |	    		|			  |TextAlign: MiddleCenter            |
///  |              |             |                                   |
///  |--------------|-------------|-----------------------------------|
///  |answerLAbel   |   Label     |AutoSize:False                     |
///  |				|			  |BorderStyle: FixedSingle           |
///  |				|			  | Font: Microsoft Sans Serif        |
///	 |				|			  |	 (Style: Bold, Size: 10 point)    |
///  |				|			  |Text(the contents of the Text      |
///  |				|    		  |		property have been erased.)   |
///	 |				|	    	  |	TextAlign: MiddleCenter           |
///  |			    |		      |             					  |
///  |--------------|-------------|-----------------------------------|
///  |showAnswer    | Button      |   Size: 110,23                    |
///  | Button       |             |   Text: Show the Answer           |
///  |              |             |                                   |
///  ------------------------------------------------------------------
///  //////////////////////////////////////////////////////////////////
/// If we open the Form1.cs files in the vode editor, we see the code
/// shown in Figure 2-57. (To open the file in the code window,
/// right-click Form1.cs in the Solution Explorer and then select
/// View Code.) Notice the method na,ed showAnswerButton_Click.
/// This is the Click event handler for the showAnswerButton control.
/// It contains the following statement:
///  
///  //////////////////////////////////////////////////////////////////
///  answerLabel.Text = "Theodore Roosevelt";
///  //////////////////////////////////////////////////////////////////
///  When this statement executes, it assigns the string
///  "Theodore Roosevelt" to the answerLabel control's Text property.
///  As a result, Theodore Roosevelt is displayed in the label control.
///  //////////////////////////////////////////////////////////////////
///  When you run the application, the form appears as shown on the left
///  in Figure 2-58. Click the Show the Anser button and the answer to
///  the trivia question appears as shown on the right in the figure.
///  //////////////////////////////////////////////////////////////////
///             The Text Property Accepts Strings Only
///  //////////////////////////////////////////////////////////////////
///  it is importans to point out the LAbel control's Text property 
///  can accept strings only. You cannot assign a number to tthe Text
///  property. For example, let's assume that an application has a
///  Label control named resultLabel. The following statement will
///  cause an error because it is attempting to store the number 5
///  in the resulyLabel control's Text property:
///  //////////////////////////////////////////////////////////////////
///				resultLAbel.Text = 5; <-- ERROR!
///  //////////////////////////////////////////////////////////////////
///  This does not mean that you cannot display a number in a label,
///  however. If you put quotation mark around the number,
///  it becomes a string. The following statement will work:
/// //////////////////////////////////////////////////////////////////
///					resultLabel.Text = "5"
/// //////////////////////////////////////////////////////////////////
///						Clearing a Label
/// //////////////////////////////////////////////////////////////////
/// In code, if you want to clear the text that is displayed in a
/// Label control, simply assign an empty string ("") to the control's
/// Text property, as shown here:
/// //////////////////////////////////////////////////////////////////
///						answerLabel.Text = "";
/// //////////////////////////////////////////////////////////////////
/// In Tutorial 2-3, you work with some of the LAbel control
/// properties that we have discussed in this section.
/// //////////////////////////////////////////////////////////////////
/// Tutorial 2-3: Creating the Language Translator Application
/// //////////////////////////////////////////////////////////////////
/// In this tutorial, you create an application that displays the
/// phrase"Good Morning" in different languages. The form will have 
/// three buttons: one for Italian, one for Spanish, and oone for
/// German. When the user clicks any of these buttons, the translated
/// phrase will appear in a Label control.
/// 
/// //////////////////////////////////////////////////////////////////
/// Step1: Start Visual Studio and begin a new Windows Forms
/// Application project named Language Translator.
/// //////////////////////////////////////////////////////////////////
/// Step 2: Set up the application's form as shown in Figure 2-59.
/// Notice that the form's Text property is set to Language Translator.
/// The form has two LAbel controls and three Button controls.
/// The names of the controls are shown in the figure. As you place 
/// each of the controls on the form, refer to Tabel 2-3 for the
/// relevant property settings.
/// //////////////////////////////////////////////////////////////////
/// Step 3: Once you have the form and its controls set up, you can
/// create the click event handlers for the Button controls. In the
/// Designer, double-click the italianButton control. This will open
/// the code editor, and you will see an empty event handler named
/// italianButton_Click. Write the following statement inside 
/// the event handler:
/// //////////////////////////////////////////////////////////////////
///				translationLabel.Text = "Buongiorno";
/// //////////////////////////////////////////////////////////////////
/// Step 4: Switch your view back to the Designer and double-click
/// the spanishButton control. In the code editot you will see an
/// empty event handler named spanishButton_CLick. Write the
/// following statment inside the event handler:
/// 
/// //////////////////////////////////////////////////////////////////
///				translationLabel.Text = "Buenos Dias";
/// //////////////////////////////////////////////////////////////////
/// Step 5: Switch your view back to the Designer and double-click the
/// germanButton control. IN the code editor you will see an empty
/// event handler named germanButton_Click. Write the fllowing
/// statement inside the event handler:
/// //////////////////////////////////////////////////////////////////
///				translationLabel.Text = "Guten Morgen";
/// //////////////////////////////////////////////////////////////////
/// Step 6: The form's code should now appear as shown in Program 2-1.
/// Note that the line numbers are not part of the code. The line
/// numbers are shown so that you and your instructor can more easily
/// refer to different parts of the program. The lines that appear
/// in boldface are the ones that you typed. Make sure the code you
/// typed appears exactly as shown here. (Don't forget the
/// semicolons!))
/// //////////////////////////////////////////////////////////////////
/// Step 7: Save the project. Then, press the f5 key on the keyboard
/// or click the Start Debugging button on the toolbar to compile
/// and run the application.
/// //////////////////////////////////////////////////////////////////
/// Note If you typed the statements correctly inside the event
/// handlers, the application should run. If you did not type the
/// statements correctly inside the event handlers, a window will
/// appear reporting build errors. if that happens, click the No
/// button in the window and then correct the code so it appears
/// exactly as previously shown. 
/// //////////////////////////////////////////////////////////////////
/// Figure 2-60 shows the application's form when it starts running
/// and after you have clicked each of the Button controls. After
/// you have tested each button, close the application's form.
/// //////////////////////////////////////////////////////////////////
///				2.6 Making Sense of IntelliSense
///	//////////////////////////////////////////////////////////////////
///							Concept 
///	//////////////////////////////////////////////////////////////////
///	As you type codein the Visual Studio editor, IntellSense
///	boxes pop up to assist you. You can use the IntelliSense boxes 
///	to automatically complete some programming statements after typing
///	only the first few characters.
/// //////////////////////////////////////////////////////////////////
/// IntelliSense is a festure of Visual Studio that provides automatic
/// code completion as you write programming statements. Once you
/// learn how to use IntelliSense, it helps you write code faster.
/// If you've worked through the previous tutorials in this chapter,
/// you've already encountered IntelliSense. For ex, in  Step 3 of 
/// Tutorial 2-3, you were instructed to write the following statement
/// in the italianButton_Click event handler:
/// //////////////////////////////////////////////////////////////////
/// translationLabel.Text = "Buongiorno";
///  //////////////////////////////////////////////////////////////////
///  Did you notice that as soon as you started typing the statement,
///  a box popped up on the screen? This is known as an IntelliSense
///  list box. The contents of the list box changes as you type. Figure
///  2-61 shows the IntelliSense list box after you have typed the
///  characters tra.
///  //////////////////////////////////////////////////////////////////
///  The IntelliSense system is anticipating what you are about to
///  type, and as you type characters, the context of the list box is
///  reduced. The list box shown in Figure 2-61 shows all the names
///  starting with tra that might be a candidate for the statement you
///  are typing. Notice that translationLabel is selected in the list
///  box. With that item selected, you can press the Tab key on the
///  keyboard, and the tra that you previously typed becomes
///  translationLabel.
/// //////////////////////////////////////////////////////////////////
/// Next when you type a period, an IntelliSense list pops up showing
/// every property and method belonging to the translationLabel
/// control. Type te and the Text property becomes selected, as
/// shown in Figure 2-62. When you press the Tab key to select the 
/// Text property, your statement automatically becomes
/// translationLabel.Text. At this point, you can continue typing
/// until you have completed the statement.
/// //////////////////////////////////////////////////////////////////
/// Now that you have an idea of how IntelliSense works, you are
/// encouraged to experiment with it as you write code in future
/// projects. Which a little practice, it will become intuitive.
/// //////////////////////////////////////////////////////////////////
///						2.7 PictureBox Controls
/// //////////////////////////////////////////////////////////////////
/// Cencept: A PictureBox control displays a graphic image on a form.
/// PictureBox controls have properties fpr controlling the way the image
/// is displayed. A PictureBox controls can have a Click event handler
/// that responds when the user clicks the controls at runtime.
/// //////////////////////////////////////////////////////////////////
/// You can use a PictureBox control to display a graphic image
/// on a form. A pictureBox control can display images that have been
/// saved in the bitmap, GIF, JPEG, metafile, or icon graphics formats.
/// //////////////////////////////////////////////////////////////////
/// In the Toolbox, the PictureBox tool is located in the Common
/// Controls  groups. When you doublee-click the tool, an empty
/// PictureBox control is created on teh from, as shown in Figure
/// 2-63. Althought the controls dose not yet display an image, it has
/// a bounding box that shows its size and location, as well as sizing
/// handles. When you create PictureBox controls, they are
/// automatically given default names such as pictureBox1,
/// pictureBox2, and so forth. You should always change the default
/// name to something more meaningful.
/// //////////////////////////////////////////////////////////////////
/// Once you have created a PictureBox control, you use its Image
/// property to spicify the image that it will display.
/// Follow these steps:
/// //////////////////////////////////////////////////////////////////
/// Step 1: CLick the Image property in the Properties window. An
/// ellipses button (...) will appear, as shown on the left in
/// Figure 2-64
/// 
/// Step 2: Click the ellipses button and the Select Resource window,
/// shown on the right in Figure 2-64, will appear.
/// 
/// Step 3: In the Select Resource window, click the Import button.
/// An Open dialog box will appear. Use the dialog box to locate and
/// select the image file that you want to display.
/// 
/// Step 4: After you select an image file, you will see its contents
/// displayed in the Select Resource window. This inddicates that the
/// image has been impoerted into the project. Figure 2-65 shows an
/// example of the Select Resource window after we have selected and
/// imported an image.
/// 
/// Step 5: Click the OK button in the Select Resource window, and the
/// selected image will appear in the PIctureBox control. Figure 2-66
/// shows an example. Depending on the size of the image, you might
/// see only part of it displayed. This is this case in Figure 2-66
/// beccause the image is larger than the PictureBox control. Your
/// next step is to set the SizeMode property and adjust the size
/// of the control.
/// //////////////////////////////////////////////////////////////////
/// The SizeMode Property
/// //////////////////////////////////////////////////////////////////
/// The PictureBox control's SizeMode property specifies how the
/// control's image is to be displayed. It can be set to one of the
/// following values.
/// 
/// *NORMAL
/// Normal is the ddefault value. The image will be positioned in 
/// the uipper-left coner of the PictureBox control. If the image is
/// too big to fit in the PictureBox control, it will be clipped.
/// 
/// *STRETCHIMAGE
/// StretchImage resizes the image both horizontally and vertically 
/// to fit in the PictureBox control. If the image is resized more
/// in one direction than the other, it will appear stretched.
/// 
/// *AUTOSIZE
/// With AutoSize, the PictureBox control is sutomatically resized
/// to fit the size of the image.
/// 
/// *CENTERIMAGE
/// CenterImage centers the image in the PictureBox control without resizing it.
/// 
/// *ZOOM
/// Zoom uniformaly resizes the image to fit in the PictureBox without
/// losing its original aspect ratio. (Aspect ratio is the image's
/// width to height ratio.) This causes the image to be resized
/// without appearing stretched.
/// 
/// Figure 2-67 shows an example of an image displayed in a PictureBox
/// control. The control's SizeMode is set to Zoom, so it can be
/// resized without appearing streched.
/// //////////////////////////////////////////////////////////////////
/// Note PictureBox controls also have a BoarderStyle property that
/// works just like a Label control's BoarderStyle property.
/// //////////////////////////////////////////////////////////////////
/// Creating Clickable Images
/// //////////////////////////////////////////////////////////////////
/// Buttons aren't the only controls that can respond to Click events.
/// PictureBox controls can, too. That means an application can display
/// an image and preform some action when the user clicks the image.
/// 
/// To make an image clickable, you can simply have to create a Click
/// event handler for the  PictureBox control that displays the image.
/// You create a Click event handler for a PictireBox control in the
/// same way that you create a Click event handler
/// for a Button control:
/// //////////////////////////////////////////////////////////////////
///		*You double-click the PictureBOx control in the Designer.
///		THis cretaes an empty Click event handler in the
///		form's source code file.
///		
/// * In the code editor you write statements inside the event handler
/// that you want to execute when the image is clicked.
/// //////////////////////////////////////////////////////////////////
/// AS an example, look at the cat project that is in the Chap02
/// folder of the Student Sample programs that accompany this
/// textbook. Figure 2-68 shows the application's form. The PictureBox
/// control's name is catPictureBox. Its image is the Cat.jpg file,
/// which is also found in the Chap02 folder of the Student Sample
/// Programs. The SizeMode property is set to Zoom, and the 
/// BoarderStly property is set to FixedSingle.
/// //////////////////////////////////////////////////////////////////
/// OPen the Form1.cs file in the code editor and you will see that
/// we have already created a Click event handler for the 
/// catPictureBox control, as shown in Figure 2-69. If you run the 
/// application and click the PictureBox, a message box will appear 
/// displaying the string Meow.
/// //////////////////////////////////////////////////////////////////
/// Tutorial 2-4 gives you a chance to practice using PictireBox
/// controls. In the tutorial, you crate an application with three
/// clickable PictureBox controls, displaying images that are 
/// provided in the Student Sample Program files that accompant
/// this book.
/// //////////////////////////////////////////////////////////////////
/// Tutorial 2-4: Creating the Flags Application
/// //////////////////////////////////////////////////////////////////
/// In this tutorial, you create an application that displays the
/// flags of finland, France, and Germany in Picture controls. When
/// the user clicks any of these PictureBOxes, the name of the flag's
/// country will appear in a Label control.
/// 
/// Step 1: Start Visual Studio and begin a new Windows Forms
/// Application project named Flags.
/// 
/// Step 2: Set up the application's form as shown in Figure 2-70.
/// Notice that the form's Text property is set to Flags. The name of
/// the controls are shown in the figure. Refer to Tabel 2-4 foreach
/// control's relevant property settings.
/// 
/// Step 3: Once you have the form and its controls set up, you can
/// create the CLick event handlers for the PictureBox controls. In 
/// the Designer, double-click the finlandPictureBox control. THis
/// will open the code editor, and you will see an empty event
/// handler named finlandPictureBox_Click, Write the following 
/// statement inside the event handler:
/// 
/// Step 4: Switch your view back to the Designer and double-click 
/// the francePictureBox control. This will open the code editor, 
/// and you will see an empty event handler named francePictureBox_Click.
/// Write the following statement insode the event handler:
/// 
/// Step 5: Switch your view back to the Designer and double-click
/// the germantPictureBox control. This will open the code editor,
/// and you will see an empty event handler named 
/// germanyPictureBox_CLick. Write the following statement inside 
/// the event handler:
/// 
/// Step 6: The form's code should now appear as shown in Program 2-2.
/// As was mentioned in the previous tutorial, the line numbers are 
/// shown for reference only, and are not part of the code. The line
/// that appear in boldface are the ones that you typed. Make sure 
/// the code you typed appears exactly as shown here. (Don't forget
/// the semicolons!)
/// //////////////////////////////////////////////////////////////////
/// Step 7: Save the project. Then, press the f5 key on the keyboard,
/// or click the Start Debigging button on the toolbar to compile
/// and run the application.
/// //////////////////////////////////////////////////////////////////
/// Note if you typed the statements correctly inside the event
/// handlers, the application should run. If you did type the
/// statements inside the events handlers correctly, a window will
/// appear reporting build errors. If that happens, click the No
/// button in the window, the correct the code so it appears
/// exactly as previously shown.
/// //////////////////////////////////////////////////////////////////
/// Figure 2-71 shows the application's form when it starts
/// running and then after you have clicked each of the PictureBox
/// controls. After you have clicked each flag to make sure the
/// application works correctly, close the form.
/// //////////////////////////////////////////////////////////////////
/// The Visible Property
/// //////////////////////////////////////////////////////////////////
/// Most controls have a Visible property that determines whether the
/// control is visible on the form at run time. The Visuble property
/// is a Boolean property, which means it can be set only to the 
/// values Trye or False. If a control's Visible property is set to
/// False, however, the controls will not be visible at run time. 
/// By default, the Visuble property is set to True.
/// //////////////////////////////////////////////////////////////////
/// When you use the Properties window to change a control's Visible
/// property at design time, the control will still be visible in the
/// Designer. When you run the application, however, the control will
/// not be visible on the form. For example, the image on the left in 
/// Figure 2-72 shows a form in the Designer. The PictureBox conrol's 
/// Visuble property is set to False, but the control can still be sen
/// in the Designer. The image on the right shows the form while the 
/// application is running. At run time, the control is not visible.
/// //////////////////////////////////////////////////////////////////
/// A control's Visuble property can also be modified in code by an 
/// assignment statement, which makes it possible to hide or display a 
/// control while the application is running. For ex, the PictureBox
/// shown in Figure 2-72 is named spiderPictureBox. The following
/// statement sets the control's Visible property to true:
/// //////////////////////////////////////////////////////////////////
/// SpiderPictureBox.Visible = true;
/// //////////////////////////////////////////////////////////////////
/// When this statement executes, the spiderPictureBox control will
/// become visible. Likewise, the following statement sets the control's
/// Visible property to false:
/// //////////////////////////////////////////////////////////////////
/// spiderPicture.Visible = false;
/// //////////////////////////////////////////////////////////////////
/// When this statement executes, the spiderPictureBox control will become 
/// invisible.
/// //////////////////////////////////////////////////////////////////
/// Note When you write the values true and false in code, as shown
/// in the previous assignment statement, they musy be written in all
/// lowercase letters. The words true and false are C# keywords, and
/// an error will occur of you don't write them in lowercase. However,
/// when you use the Properties window to set a Boolean property, such
/// as Vsible, the values True and False will be shown with an initial
/// capital Try not let this inconsistency cobnfuse you!
/// //////////////////////////////////////////////////////////////////
/// Tutorial 2-5: Creating the Card Flip Application
/// //////////////////////////////////////////////////////////////////
/// In this tutorial, you create an application that simulates a card
/// being flipped over. When the application runs, it will display the
/// form shown on the left in Figure 2-73. The form initially displays
/// the back of a poker card. When the user clicks the Show the Card
/// Face button, the card will be flipped over to show its face, as
/// shown in the form on the right. WEHen the user clicks the Show
/// the Card Back buttonm, the car is flipped back over to show its
/// back.
/// //////////////////////////////////////////////////////////////////
/// The simulation of the card being flipped will be accomplished using the following logic:\
/// 
/// * When the user clicks the Show the Card Face buutton, the
/// PictureBox showing the card's back will be made invisible and the
/// PictureBox showing the card's face will be made visible.
/// 
/// * When the user clicks the Show the Card Back button,
/// the PictureBox showing the card's face will be made invisible
/// and the PictureBox showing the card's back will be made visible.
/// //////////////////////////////////////////////////////////////////
/// Step 1: Start Visual Studio and begin a new Windows Forms Application project named Card Flip.
/// 
/// Step 2: Set up the application's form as shown in Figure 2-74.
/// Notice that the form's Text property is set to Card Flip. The names
/// of the controls are shown in the figure. Use the Properties window
/// to make the property settings shown in Tabel 2-5. (In particaular,
/// note that the cardBAckPictureBox control's Visible property is set
/// to True, and the cardFacePictureBox control's Visible property is
/// set to False.)
/// 
/// Step 3: Once you have the form and its controls set up, you can
/// create the click event handlers for the Button controls. In the
/// Designer, double-click the showBackButton control. This will open
/// the code editor, and you will see an empty event handler named
/// showBackButton_Click. Write the following statments inside the 
/// event hander:
/// 
/// cardBackPictureBox.Visible = true;
/// cardFacePictureBox.Visible = false;
/// 
/// Step 4: Switch your view backto the Designer and double-click the
/// showFaceButton control. This will open the code editor, and you
/// will see an empty event handler named showFaceButton_Click. 
/// Write the following statments inside the event handler:
/// 
/// cardBackPictureBox.Visible = false;
/// 
/// cardFacePictureBox.Visble = true;
/// 
/// Step 5: The form's code should now appear as shown in the
/// Program 2-3. Remember, the line numbers are shown for reference
/// only and are not part of the code. The lines that appear in
/// boldface are the ones that you typed. Make sure the code you
/// typed appears exactly as shown here (Don't forget the semicolons!)
/// 
/// Step 6: Save the project. Then press the F5 key on the keyboard,
/// or click the Start Debugging button on the toolbar to compile and
/// run the application. Test the application.
/// //////////////////////////////////////////////////////////////////
/// Note If you typed the statments correctly inside the event
/// handlers, the application should run. If you did not type the
/// statements inside the event handlers correctly, a window will
/// appear reportying build errors. IF that happens, click the No
/// button in the window and then correct the code so it appears
/// exactly as previously shown. 
/// //////////////////////////////////////////////////////////////////
/// Note In addition to PictireBoxes, many other types of
/// controls have a Visible property. For example, you can make a
/// Label control visible or invisible bt setting the value of its
/// visuble property.
/// //////////////////////////////////////////////////////////////////
/// Sequrntial Execution of Statements
/// //////////////////////////////////////////////////////////////////
/// IN Tutorial 2-5, the event handlers that you created each
/// contained more than one statement. For example, here is the
/// showBackButton_Click method: 
/// //////////////////////////////////////////////////////////////////
/// private voide showBackButton_Click(object sender, EventArgs e)
/// {
///		cardBackPictureBox.Visible = true;
///		cardFacePictureBox.Visible = false;
/// }
/// //////////////////////////////////////////////////////////////////
/// This method has two assignment statments. When the method executes,
/// the statments in the method execute in the order that they appear,
/// form the beginning of the method to the end of the method. This 
/// statment eXEcutes first:
/// //////////////////////////////////////////////////////////////////
/// cardBackPictureBox.Visible = true;
/// //////////////////////////////////////////////////////////////////
/// Then this statement executes:
/// //////////////////////////////////////////////////////////////////
/// cardFacePictureBox.Visible = false;
/// //////////////////////////////////////////////////////////////////
/// When the application is running, however, you can't really tell
/// that the statements are executing in this order simply by watching
/// the asction take place on the screen. When you click the
/// showBackButton control, the Click event handler executes so
/// quickly that it appears as though b0th statements execute
/// simultaneously. It's important for you to understand, however,
/// that the statments execute one at a time, in the order that they
/// appear in the method.
/// //////////////////////////////////////////////////////////////////
/// In this particular method, it doesn't really matter which
/// assignment statement is written first. If we reverse the order
/// of the statements, we will not be able to see the difference on
/// the screen because the application executes so quickly. In most
/// applications, however, the order in which you write event handlers
/// that preform several steps, and in most cases, the steps must
/// preformed in a specific order. Otherwise, the program will not
/// produce the correct result.
/// //////////////////////////////////////////////////////////////////
/// 2.8 Comments, Blank Lines, and Indentation
/// //////////////////////////////////////////////////////////////////
/// Concept Comments are brief notes that are placed in a program's
/// code to explain how parts of the program work. Programmers commonly
/// use black lines and indentation in program code to give the code
/// visual organization and it easier to read.
/// //////////////////////////////////////////////////////////////////
/// Comments
/// //////////////////////////////////////////////////////////////////
/// Comments are short notes that are placed in different parts of a 
/// program, explaining how those parts of the prgram work. Comments
/// are not intended for the compiler. They are intended for any
/// person who is reading the code and trying to understand what
/// it does.
/// //////////////////////////////////////////////////////////////////
/// In C#, there are three types of comments: line comments, block
/// comments, and documentation comments. A line comment appears on 
/// one line in a program. You begin a line comment with two forward
/// slashes (//). Everything written after the slashes, to the send of
/// the line, it ignored by the compiler. The following code sample
/// shows how we might use line comments in the showBackButton_Click
/// event handler form Tutorial 2-5. Each line comment explains what
/// the very next line of code does.
/// //////////////////////////////////////////////////////////////////
/// private voide showBackButton_Click(object sender, EventArgs e)
/// {
///	  // Make the image of the back of the card visible.
///		cardBackPictureBox.Visible = true;
///  // Make the image of the face of the card invisible.
///		cardFacePictureBox.Visible = false;
/// }
/// //////////////////////////////////////////////////////////////////
/// A line comment does not have to occupy an entire line. Anything 
/// appearing after the // symbol, to the end of the line, is ignored.
/// 
/// So, a comment can appear after an executable statement. The
/// following code sample shows an example.
/// //////////////////////////////////////////////////////////////////
/// private voide showBackButton_Click(object sender, EventArgs e)
/// {
///	  
///		cardBackPictureBox.Visible = true; // Show the card back
///  
///		cardFacePictureBox.Visible = false; // Hide the card face.
/// }
/// //////////////////////////////////////////////////////////////////
/// A block comment can occupy multiple consecutive lines in a program.
/// A block comment starts with /* (a forward slash followed by an 
/// asterisk) and ends with * / (an asterisk followed by a forward
/// slash). Everything between these markers is ignored. The following
/// code sample shows how block comments may be used.  
/// //////////////////////////////////////////////////////////////////
/// /* a
/// s
/// d
/// a
/// s
/// d
/// a* /
/// 
/// //////////////////////////////////////////////////////////////////
/// The first five lines in this code sample are a block comment that 
/// explains what the showBackButton_Click method does. Block comments make
/// it easier to write long explanations because you do not have to mark
/// every line with a comment symbol.
/// //////////////////////////////////////////////////////////////////
/// The third type of comment is known as a documentation comment.
/// Documentation comments are used by professional programmers to 
/// embed extensive documentation in a program's source code.
/// Visual Studio can extract information from the documentation 
/// comments and generate external documentation file.
/// Single - line documentation comments begin with three forward
/// slashes (///)/ Block documentation comments begin with / ** and end with * /.
/// although documentation comments are useful for professional programmers
/// , we do not use them in this book.
/// //////////////////////////////////////////////////////////////////
/// As a beginning programmer, you might resist the idea of writing a 
/// lot of comments in your programs. After all, it's a lot more 
/// interesting to write code that actully does something; however, it's
/// crucial that you take the extra time to write comments. They will
/// almost certainly save you time in the future when you have to
/// modify or debig the program. Even large and complex programs can
/// be made easy to read and understand if they have proper comments.
/// //////////////////////////////////////////////////////////////////
/// Using Blank Line and Indentation to Make Your COde Easier to Read
/// //////////////////////////////////////////////////////////////////
/// Programmers commonly use blank lines and indentations in their
/// code to create a sense of visual organization. This is similar to 
/// the way that authors visually arrange the text on the pages of the 
/// a book. Instead of writting each chapters as one long series of sentences
/// , they break the text into paragraphs that are visually separated
/// on the page. This does not change the information in the book, but
/// it makes it easier to read.
/// //////////////////////////////////////////////////////////////////
/// For example, in the following code sample, we have inserted a
/// blank line inside the method to visuallt seprate the code into two
/// sets of statements. The blank line is not required, but it makes
/// the code easier for humans to read.
/// //////////////////////////////////////////////////////////////////
/// Programemrs also use in
/// //////////////////////////////////////////////////////////////////
///  private voide showBackButton_Click(object sender, EventArgs e)
/// {
///	 // Make the image of the back of the card visible.
///		cardBackPictureBox.Visible = true;
///  // Make the image of the face of the card invisible.
///		cardFacePictureBox.Visible = false;
/// }
/// //////////////////////////////////////////////////////////////////
/// Programmers also use indentations to visually organize code. You
/// may have noticed that code editor, all the statements that appear
/// inside a set of braces({}) are indented. For example, all the 
/// statements inside a namespace are indented, all the statements inside
/// a class are indented, and all the statements inside a method are
/// indented. In fact, Visual Studio is normally set up to
/// automatically indent the code that you write in this fashion.
/// //////////////////////////////////////////////////////////////////
/// Although the indentation is not required, it makes your code much
/// easier to read. By indenting the statements are inside the method.
/// The same is true for classes and namespaces. This practice of 
/// indentation is a convention that vitrually all programmers follow.
/// //////////////////////////////////////////////////////////////////
/// 2.9 Writing the Code to Close an Application's Form
/// //////////////////////////////////////////////////////////////////
/// Concept To close an application's form in code, you use the statement this.Close();
/// //////////////////////////////////////////////////////////////////
/// All the applications that you created in this chapter's tutorials
/// required the user to click the standerd Windows close button(X) to
/// close the application. The standard Windows close button appears
/// in the upper-right corner of almost every window. In many
/// application, however, you will want to give the user an
/// alternative way to close the applcation. For example, you might
/// want to create an Exit button that closes the application when
/// it is clicked
/// //////////////////////////////////////////////////////////////////
/// To close an application's form, you execute the followign statment:
/// //////////////////////////////////////////////////////////////////
/// this.Close();
/// //////////////////////////////////////////////////////////////////
/// Let's look at an example of how this statement can be used.
/// Figure 2-75 shows the form and code from a project named Exit
/// Button Demo. The Button control that you see on the form is named
/// exitButton. In the form's code you can see that we have crated a
/// Click event handler for the button. When the user clicks the
/// button, it closes the form, thus closing the application.
/// //////////////////////////////////////////////////////////////////
/// 2.10 Dealing with Syntax Errors
/// //////////////////////////////////////////////////////////////////
/// Concept The Visual Studio code editor examines each statement as 
/// you type it and reports any syntax errors that are found. This
/// allows you to quickly correct syntax errors.
/// //////////////////////////////////////////////////////////////////
/// Writting code requirs a lot of percision. Even small errors, such 
/// as using an uppercase letter where you are supposed to use a 
/// lowercase letter or forgetting to end a statement with a semicolon,
/// will prevent an application's code from compiling and executing.
/// Recall form Chapter 1 that these types of mistakes are know as 
/// syntax errors.
/// //////////////////////////////////////////////////////////////////
/// The Visual Studio code editor does a good job of reporting syntax
/// errors soon after you type them. When you enter a statement into 
/// the editor, Visual Studio analyzes it, and if a syntax error is
/// found, it is underlined with a jagged line. Figure 2-76 shows an
/// example. If you hold the mouse cursor over the jagged a line, a
/// description of the wrror will pop up in a ToolTip window. The
/// description usually gives you enough information to determine
/// the cause of the error and how to fix it.
/// //////////////////////////////////////////////////////////////////
/// if a syntax error exists in a project's code and you attempt to 
/// compile and execute it , you will see the window shown in Figure
/// 2-77, reporting build error List shown in Figure 2-78
/// //////////////////////////////////////////////////////////////////
/// Notice that the Error List window shows a description of the error, 
/// the source code file that contains the error, the line number and
/// column number of the error, and the name of the project. If you
/// double-click the error message that is displayed in the Error List
/// window, the code editor will highlight the code that caused the error
/// //////////////////////////////////////////////////////////////////
/// 