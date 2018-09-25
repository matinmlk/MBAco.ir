# MBAco
Water Treatment for Chemical plant Customer System Monitoring.
More information about the Mohafezan Company is available on mbaco.co website.

This project is designed to improve monthly and annual report of customers based on the condition of the circulated water inside the chemical plant in order to normalize the condition for higher maintainability of piping structures.

![alt text](https://github.com/matinmlk/MBAco.ir/blob/master/showpic%20(2).jpeg)

System is only available for the authurized users and they can have different roles to interact with it. Membership manager in this system was based on the .Net memebership provider and as an extension Customers and contacts of the system created the hiararchy of the users manager makes it possible to define any number of users with different roles with admin role. Each roles in the system has different access from sending parameters by ANALYSER to approve the parameters by APPROVER and make it available to report by TECHHEAD. And finally each customer should view the monthly report by email or direct access with CUSTOMER access to the system.

Parameters were different in each site and they may have different threshold for the notification system to announce warning or critical situation from the result of the parameters. The system is completely dynamic in order to define seperated parameter set and analysing procedure for ANLYSERS and finally prepare the annual and monthly report.

Creating a Dynamic Chart from Dynamic parameters was one of the important challenges of this system. This kind of preparing report based on user added values may put the system in the risk of unforseened views and unreadable reports. But, with the power of the chart.js and fully adopted interface for this application this system has no issue in preparing reports over the course of three years data.


Solution is consists of different projects to separate the concern of the steps from Back-end related data preparation tasks to front-end Presentation of the codes.

#MBAco DAL - Data Access Layer 

Important task in this layer is creating database object of each table or stored procedure to make it available to do more data manipulation. objects of this layer mostly started with "tbl" prefix and showing the differences of them with business objects.

The dbml file inside the project is available in pdf format from this address. this project used Linq to SQL to connect and run queries on the backend side. Most of the classes are inherited from the base class to perform the CRUD operation and they are partial for special queries needed in different interactions.

https://github.com/matinmlk/MBAco.ir/blob/master/mbaco%20database%20design.pdf

#MBAco BLL - Business Logic Layer 

This Layer is responsible to interact with the DAL to prepare and fill data in the lists and objects of Businiess Model to use inside the MVC web application. All methods inside BLL needs to be optimized and well tested before using inside the application. 

#MBAco Business Model Layer
The Definition of the Classes inside the application which are the main reference for passing and creating objects. This project is also the Model definition for MVC architecture but extracted as a project.

#MBAco Common

Codes which may use in other projects as common reusable sources like email configuration, MD5 security and ...

#MBAco BLL.Test - Data Access Layer 

Unit tests needed to be implemented for the BLL.

#MBAco - MVC.Net Web project 

Presentation and mostly front-end coding without any data manipulation for represent to users.
