#!usr/bin/env python3

'''
Takes the original array and sorts it ascending using bucket sort algorithm.
'''
def bucketSort(array):
    bucket = []

    # Create empty buckets (One for each 10 spot like 0-9, 10-19, etc.)
    i = 0
    while i < 10:
        bucket.append([])
        i += 1

    # Insert elements into their respective buckets
    for i in array:
        bucket_index = int(i / 10)
        bucket[bucket_index].append(i)

    # Sort the elements of each bucket
    for i in range(len(bucket)):
        bucket[i] = sorted(bucket[i])

    # Get the sorted elements and put them together
    p = 0
    for i in range(len(bucket)):
        for n in range(len(bucket[i])):
            array[p] = bucket[i][n]
            p += 1
    return array

def main():
    org_array = [34,71,13,99,81,45,5]

    sort_array = bucketSort(org_array)
    last_item = sort_array[len(sort_array)-1]

    print(f"Sorted Array: {sort_array}\n")
    print(f"Highest Rating was {last_item}!")

if __name__ == "__main__":
    main()
    
