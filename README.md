# _Word Counter_

#### _A C# program that will count the number of times a word appears in a sentence, July 26, 2019_

#### By _**Aaron Whang**_

## Description

_This program was created for the Eighth Friday project assigned to the students of Epicodus Seattle May 28th class. This is a program that will prompt the user to input a word and a sentence. The program will check how many times that word appears in the setence._

## Setup/Installation Requirements

* _clone repository off of Github_
* _go to parent directory using terminal for Mac, git.bash for Windows_
* _type in 'dotnet run' to run the program_




## Known Bugs



## Specifications

* ___Spec:___ The program returns a false.
          * ___Input:___ "The dog barks at the kids", "cat"
          * ___Output:___ "false"

* ___Spec:___ The program returns a true
          * ___Input:___ "The dog barks at the kids", "dog"
          * ___Output:___ "true"

* ___Spec:___ The program returns a false when string is present within a word
          * ___Input:___ "cathedral", "cat"
          * ___Output:___ "false"

* ___Spec:___ The program returns the number of times the word appears
          * ___Input:___ "cat cat dog dog cat dog cat dog dog cat dog", "dog"
          * ___Output:___ "6"

* ___Spec:___ The program will ignore case
          * ___Input:___ "Cat cat cAt CaT", "cat"
          * ___Output:___ "4"          

* ___Spec:___ The program will check for spaces in the second string
          * ___Input:___ "How do you do, ma'am?", "do you"
          * ___Output:___ "Please enter one word to check. No Spaces please."   


## Support and contact details

_For any questions about the website, code or content, please contact me at tlbhibiki@gmail.com_

## Technologies Used

_Written in C#_

### License

_All code are created and owned by Aaron Whang_

Copyright (c) 2019 **_Aaron Whang_**
