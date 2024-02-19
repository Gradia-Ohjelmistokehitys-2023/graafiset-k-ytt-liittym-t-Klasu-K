# Task: Working with Forms in Windows Forms Application

## Goal:
Create and work with multiple forms within a Windows Forms application using C#.

## Prerequisites:
- Installed Visual Studio (any version supporting Windows Forms).
- Basic knowledge of C# programming.
- Familiarity with Windows Forms application development.

## Task Steps:

### 1. Create a New Windows Forms Project:

- Open Visual Studio.
- Create a new Windows Forms App (.NET Core) project.
- Name the project "MultipleFormsApp" and choose a suitable location.
- Click "Create" to generate the project.

### 2. Design the Main Form:

- Open the Form1.cs file in the designer.
- Design the main form with controls like buttons and labels.
- Add a button that will open the secondary form.

### 3. Create a Secondary Form:

- Add a new Windows Form to the project.
- Name the new form "SecondaryForm.cs" or any appropriate name.
- Design the secondary form with different controls than the main form.

### 4. Implement Form Navigation:

- In the main form's button click event, write code to open the secondary form.

  ```csharp
  private void btnOpenSecondaryForm_Click(object sender, EventArgs e)
  {
      SecondaryForm secondaryForm = new SecondaryForm();
      secondaryForm.Show();
  }
### 5. Pass Data between Forms (Continued):

- Implement a mechanism to pass data from the main form to the secondary form.
- This could be done using properties, constructor parameters, or public methods.

  ```csharp
  // Example: Pass a string from the main form to the secondary form using a property.
  // In SecondaryForm.cs
  public partial class SecondaryForm : Form
  {
      public string DataFromMainForm { get; set; }

      // Other code in the class...
  }
  // In the main form
  private void btnOpenSecondaryForm_Click(object sender, EventArgs e)
  {
      SecondaryForm secondaryForm = new SecondaryForm();
      secondaryForm.DataFromMainForm = "Hello from the Main Form!";
      secondaryForm.Show();
  }
In this example, a property DataFromMainForm is defined in the SecondaryForm class to receive data from the main form. You can customize this approach based on the type of data you need to pass and the design of your application.
