# StudentRegistration

# Briefly summarize the requirements and goals of the application you developed. What user needs was this application designed to address?

The program was designed to allow for students to register for classes. The requirements included creating a functioning GUI that allowed for students to select and add classes. Classes had 3 credit hours and the program had to stop the user from adding more than 9 credit hours to their work load. The program was also required to throw an error if the user tried adding a class that was already on their list of selected courses. 

# What did you do particularly well in developing this application?

My code was designed to be easily readable and scalable based on more courses being added or removed. The program also handles errors without crashing and informing the user about changes that needed to be made.

# Compare and contrast the Console and WPF application designs. What screens and features were necessary to support user needs and produce a user-centered UI for the app? How did your UI designs keep users in mind? Why were your designs successful?

The console design was clunky and didn't have a user centric feeling to the design. The GUI design allowed for buttons that guided the user in how to use the program, which could lead to less errors being thrown as it removes the typing part of a console program. The error throwing section of the program also comes through in red to get the user's attention on actions performed or things that needed to be changed.

# How did you approach the process of debugging and coding your application? What techniques or strategies did you use? How could you use those techniques or strategies in the future?

I utilized Visual Studio's IntelliSense and debugging tools to clear errors and any other bugs in the code. Stepping through the code was a beneficial tool that allowed me to find the exact lines the code went haywire and from there I used IntelliSense to iron out the issues. For future coding, I will try to always use a coding editor that has a step through feature as it is extremely beneficial in moving through the code to find issues.

# Where did you have to be innovative to overcome a challenge in the full application development process?
 
I had to innovate by replacing pop-up message boxes with a real-time error message displayed directly above the course list in red text, making the user interface more intuitive and less intrusive. Additionally, I implemented dynamic credit hour validation, ensuring that users couldn't register for more than 9 credit hours while keeping the interface updated with the current registration status.
