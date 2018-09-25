# MBAco
Water Treatment for Chemical plant Customer System Monitoring.
More information about the Mohafezan Company is available on mbaco.co website.

This project is designed to improve monthly and annual report of customers based on the condition of the circulated water inside the chemical plant in order to normalize the condition for higher maintainability of piping structures.

![alt text](https://github.com/matinmlk/MBAco.ir/blob/master/showpic%20(2).jpeg)

System is only available for the authurized users and they can have different roles to interact with it. Membership manager in this system was based on the .Net memebership provider and as an extension Customers and contacts of the system created the hiararchy of the users manager makes it possible to define any number of users with different roles with admin role. Each roles in the system has different access from sending parameters by ANALYSER to approve the parameters by APPROVER and make it available to report by TECHHEAD. And finally each customer should view the monthly report by email or direct access with CUSTOMER access to the system.

Parameters were different in each site and they may have different threshold for the notification system to announce warning or critical situation from the result of the parameters. The system is completely dynamic in order to define seperated parameter set and analysing procedure for ANLYSERS and finally prepare the annual and monthly report.

Creating a Dynamic Chart from Dynamic parameters was one of the important challenges of this system. This kind of preparing report based on user added values may put the system in the risk of unforseened views and unreadable reports. But, with the power of the chart.js and fully adopted interface for this application this system has no issue in preparing reports over the course of three years data.


Solution is consists of different projects to separate the concern of the steps from Back-end related data preparation tasks to front-end Presentation of the codes.

MBAco DAL - Data Access Layer 

MBAco BLL - Business Logic Layer 

MBAco Business Model Layer

MBAco Common - Data Access Layer 

MBAco BLL.Test - Data Access Layer 

MBAco - MVC.Net Web project 

