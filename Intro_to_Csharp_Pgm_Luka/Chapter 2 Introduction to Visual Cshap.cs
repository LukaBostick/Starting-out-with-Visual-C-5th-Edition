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
///  When you run the application, the form appears as shown on the left in Figure 2-58. Click the Show the Anser button and the answer to the trivia question appears as shown on the right in the figure.
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
/// //////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////
///  //////////////////////////////////////////////////////////////////
///  //////////////////////////////////////////////////////////////////
/// //////////////////////////////////////////////////////////////////