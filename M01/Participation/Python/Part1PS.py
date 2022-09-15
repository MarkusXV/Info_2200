#!usr/bin/env python 3

def main():
    '''Main Function'''
    print("Welcome to Peter's State Capital Lookup App") # Welcome line outputted
    print() #Blank line
    userinput = input("Please enter a state and I will return the capital (x to exit): ") # Asks the user to input a state that they want the capital for

    stateCapDict = {} # declare the empty dictionary list
    with open("//Mac/Home/Desktop/Part1PS/statecaps.txt") as file: # opens the text file to read it
            file.readline() # reads the first line so that it doesn't read the "state,capital" header
            for line in file: # reading each line one at a time in file
                line = line.replace("\n","") # replacing every blank line in the txt file to a blank string
                tempstatecap = line.split(",") # splitting the "state,cap" entry in the array to "state" and "cap" in the array
                stateCapDict.update({tempstatecap[0]:tempstatecap[1]}) # updates the dictionary array index to have the state be 0 and capital be 1


    while userinput.lower() != "x": # checks to see if the lower case userinput is equal to x or not. continues if it's not x
        userState = userinput.title() # capitalizes the first character in the input given
        if userState in stateCapDict: # if the user's input is in the dictionary, continue. Otherwise, tell the user
            print() # blank line
            print(f"State: {userState}") # Prints the State
            print(f"Capital: {stateCapDict[userState]}") # Prints the Capital
            print() # blank line
            
            
            
        else: # if the user's input isn't in the dictionary, asks the user to input another state
            print() # blank line
            print(f"Couldn't find {userState} in the database.") # tells the user it wasn't in the dictionary
        userinput = input("Please enter a state and I will return the capital (x to exit): ") # asks the user for the next input, x with exit
    


if __name__ == "__main__" : main() # runs the main funtion when it's run