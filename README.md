# LoanCalculatorTask
Loan Calculator : Task 2

Use of interfaces and abstract classes to create a console application which enables calculation of loan payment for different types of loans. 
log4net is used to log data onto the console, text files and the event viewer. 


Interface : 'ILoanCal' sets the properties and methods
Base Abstract Class : 'Loans' Inherits from ILoanCalc and defines the funtionality of the method
Derived classes : 3 derived classes each inherit the abstract base class and the only difference between them being the rate of interest


**Running the application**
Upon running the application the user is given the choice to pick between the 3 types of loans following which the user has to give the input for principle amount and time. The application will then return the total payable amount and the interest costs to the user. 
Everything that happens during the runtime is logged. 
