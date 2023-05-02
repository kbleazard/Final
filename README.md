# Final
This code is a cow sorter and record keeper. It helps us to keep track of certain details of the cow and its offspring. I wanted to make this project because it would be very useful for our farm and would help us keep accurate records. 

This project interested me because it would be useful for us. Its somewhat boring but it helps us keep track of things. It also was interesting for me because the code was a bit challenging to me. 

I completed most of this code that I wanted to. It is able to display all of the cows, their age, docility, # of calves, seach for them by eartag number, add new cows, add notes to an existing cow, and write it all to a file. I couldnt do any more because of how busy finals week was. 

I learned a whole lot from this project. I learned that there is a whole lot more to a program than I first thought. This was a pretty simple project but it took a lot more than I thought to make it work. I learned a lot about methods and adding more of them to add more functionality to a program. I also learned that it takes a lot of work to make code "work."

Here is my psudocode that I used and developed over the course of the assignment. I had to add a bit to it at the end. 

start -> check if file "cowdata.txt" is there
       -> if yes, read data from the file into a list called "database"
       -> loop the main menu
           -> display the menu options:
               -> search for a cow
               -> add a new cow
               -> add notes to a cow
               -> display all cows
               -> exit
           -> read the persons choice
           -> if the person chooses to search for a cow
               -> ask for a cow number to search for
               -> if the cow number exists in the database
                   -> get the cow data from the list
                   -> display the cow's information
               -> if the cow number does not exist in the database
                   -> display an error message
           -> if the user chooses to add a new cow
               -> ask for cow number, number of calves, age, and docility
               -> add the cow's data to the database list
           -> if the user chooses to add notes to a cow
               -> ask for a cow number to add notes to
               -> if the cow number exists in the database
                   -> ask for notes to add
                   -> update the cow's notes in the database list
               -> if the cow number does not exist in the database
                   -> display an error message
           -> if the user chooses to display all cows
               -> display all cow stuff in the database list
           -> if the user chooses to exit
               -> exit the loop
           -> if the user enters an invalid option
               -> display an error message
       -> write the database list to the "cowdata.txt" file
       -> stop

I used many different things in this code.  
1. I had to read from a file (cowdata.txt) and use that csv to read in the cow data.
2. I had to then write that file back when I was done updating and changing it. 
3. I used a while loop for my main menu so That it would always come up when a user is using it. It stops when someone picks option 5.
4. I used a lot of input from a user using Console.Readlines. then I used those ints and strings in the code. 
5. I used a lot of if/else statements. One of them was if you search for a number it would pull it up, but if it doesnt exist it uses the else statement to say there isnt a cow with that number. I used a couple of these.
6. I used quite a few methods for this code. I used one for displaying all the cows. I used another one to search up a cow. I used a few others but I used these methods to simplify the code and call it in ther driver method. 
7. I had to use a couple foreach loops so I could bring strings back together. I used them so I could join the split up file parts back together. 
8. I used a list to add the cow data to it. then once it was in the list I was able to change that data or write new data.
9. I had 2 other methods. I had an update cowNotes method to make it easy to add notes to a cow. I also had another method to add a cow to the database. Then I could add another cow to the file. 
10. I used a for loop to go through all of the cows and split them up.



