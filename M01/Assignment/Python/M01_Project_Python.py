#!usr/bin/env python 3

import random # import random module so that we can use the random functions


def main():
    '''Main Function'''
    print("Welcome to Peter's College Lookup App") # Welcome line outputted
    print() #Blank line
    userinput = input("Please enter a college and I will return the city (x to exit, random to get a Random College/City): ") 
    # Asks the user to input a college that they want the city for

    collegeCityDict = {} # declare the empty dictionary list
    with open("Python/collegeCity.txt") as file: # opens the text file to read it
        file.readline() # reads the first line so that it doesn't read the "College,City" header
        for line in file: # reading each line one at a time in file
            line = line.replace("\n","") # replacing every blank line in the txt file to a blank string
            tempstatecap = line.split(",") # splitting the "college,city" entry in the array to "college" and "city" in the array
            collegeCityDict.update({tempstatecap[0]:tempstatecap[1]}) # updates the dictionary array index to have the college be 0 and city be 1


    while userinput.lower() != "x": # checks to see if the lower case userinput is equal to x or not. continues if it's not x

        if userinput.lower() != "random": # Checks to see if the user's input is random. If it's not, then it continues
            userCollege = userinput.title() # capitalizes the first character in the input given

            if userCollege in collegeCityDict: # if the user's input is in the dictionary, continue
                print(f"The city of {userCollege} is {collegeCityDict[userCollege]}") # Prints the college and city
                print() # blank line
            
            else: # if the user's input isn't in the dictionary, asks the user to input another college
                print(f"Couldn't find {userCollege} in the database.") # tells the user it wasn't in the dictionary
                print() # blank line
            userinput = input("Please enter a state and I will return the capital (x to exit): ") # asks the user for the next input, x with exit

        else: # runs if the user's input is random
            randCollege, city = random.choice(list(collegeCityDict.items())) # gets the random college from the dictionary and puts it into randcollege and city

            print(f"The city of {randCollege} is {city}") # Prints the random college and city
            print() # blank line
            userinput = input("Please enter a state and I will return the capital (x to exit): ") # asks the user for the next input, x with exit

    print("Thanks for coming!") # Exit message

    


if __name__ == "__main__" : main() # runs the main funtion when it's run