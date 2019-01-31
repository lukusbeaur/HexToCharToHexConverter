# Hex_Calibration_Tester


Opens a text file containing Hex values, splits them from the address column and removiing any literals with in the line. 
This is done with a stream of inputs. While streaming the program takes two inputs. One is the hex values you're searching 
for, and two is the hex values you are going to change them to. So during the stream, the hex values are casted to a int and 
then compared with the first input(The search string). If it finds the search input, it will change those values to the second input
the desired values. This will remake a new file, with the "desired values _+new" as the file name with the ext = *.txt. 
