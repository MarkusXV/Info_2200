
#/usr/bin/env python3
import random

FILENAME = "MyNums.txt"

def main():
    welcome()
    mynums = readfile()

    userinput = ""
    while userinput != "x":
        
        userinput = input("Enter a menu item (x to exit): ")
        if userinput == "list":
            print(mynums)
        if userinput == "add":
            newNum = input("Enter number: ")
            mynums.append(newNum)
            writefile(newNum)
            print(mynums)
        if userinput == "random":
            random.shuffle(mynums)
            print(mynums)
    print("Thanks! Please come again!")
    


def welcome():
    print("Welcome to Peter's favorite numbers")
    print("-----------------------------------")
    print("Menu:\n\
    list - Display all saved numbers\n\
    add - Add a new favorite number\n\
    random - Randomize numbers")
    print("-----------------------------------")
    
def readfile():
    """"""
    mynums = []
    with open(FILENAME) as file:
        for line in file:
            line = line.replace("\n","")
            mynums.append(line)
    return mynums

def writefile(newNum):
    with open(FILENAME, "a") as file:
        file.write(f"{newNum}\n")


if __name__ == "__main__" : main()