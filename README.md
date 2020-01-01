# Documentation for Laptop Inventory Program v1.0 (LTPConsole)

## Program Function & Purpose
The following code is for the laptop checkout program used by the EUS team to reduce the number of lost laptops being loaned out
to users, reduce the redundancy of manually keeping track of assets, and to be able to generate a summary of all the loaning statistics in MS Access database and Excel spreadsheet.

## Source Code
The source code for the program can be found in the Main.cs, Feature.cs, and Inventory.cs files.

*Main.cs is the form where the user can enter check out and returns only after they have been entered in inventory.
This form also assigns a technician and expected date of return for the laptop.
Once the submit button is clicked, the program will save this information to a log file with a time stamp and to the MS Access
database.*

*Inventory.cs is the form where the user will be able to add new models of laptops along with their corresponding asset tag which will then return a laptop ID number to be used in the Check in/ Check out phase of the program. Laptop models that are to be disposed of can be removed.*

*Features.cs
Displays and summarizes the contents in the Access database and allows user to see what is in the database. This can be accessed via the stats tab.*

## Records & Data
The records tab allows the user to navigate directly to the Access database as well as load the Excel spreadsheet that summarizes all of the laptop entries.
The summarized data should include the ID for the laptops, its corresponding asset tag, and whether or not the item is within inventory.
