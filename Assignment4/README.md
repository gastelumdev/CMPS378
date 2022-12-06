## Overview
This is a Windows Form app built to calculate the area and perimeter (or circumference) of either a square, rectangle, circle, or ellipse. This app runs on Visual Studio as a Windows Form application which is also the only dependency.

Along with the Windows Form classes for the GUI, there is a Shape Interface and five class inherited from it. The Interface requires a `getArea()` and `getPerimeter()` method to be implemented by in the child classes. The classes are then later referenced by the Windows Form GUI application. Each one gets called depending on the action chosen followed by the methods that calculate the area and perimeter of the shape.



## Output Sample
The GUI app let the user select an shape from a dropdown. Based on the selection the appropriate type and number of labels and inputs are displayed for the user to enter their shape measurements. Also dispalyed upon selection is a button to display the results.
#### Square
![Selecting square shape from dropdown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/square1.png)
![Input measurements to inputs](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/square2.png)
![CLick button to get output](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/square3.png)
#### Rectangle
![Selecting rectangle shape from dropdown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/rectangle1.png)
![Input measurements to inputs](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/rectangle2.png)
![CLick button to get output](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/rectangle3.png)
#### Triangle
![Selecting triangle shape from dropdown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/triangle1.png)
![Input measurements to inputs](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/triangle2.png)
![CLick button to get output](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/triangle3.png)
#### Circle
![Selecting circle shape from dropdown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/circle1.png)
![Input measurements to inputs](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/circle2.png)
![CLick button to get output](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/circle3.png)
#### Ellipse
![Selecting ellipse shape from dropdown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/ellipse1.png)
![Input measurements to inputs](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/ellipse2.png)
![CLick button to get output](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/ellipse3.png)

## Error and Exception Handling
Error and exception handling was implemented to ensure the inputs had the correct values going in. A try and catch block was implemented so that an Format Exception was caught in the case that the user entered a non numerical value. The input was then checked to ensure that the number was positive. In either scenario, an error is displayed and the user does not see any other output unless all the required outputs check out.
![Error shown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/exceptionHandling.png)
![Error shown](https://github.com/gastelumdev/CMPS378/blob/main/Assignment4/images/errorHandling.png)
