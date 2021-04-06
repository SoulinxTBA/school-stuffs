a = True

while a == True:
    #1 Insertion Sort
    def insertion_sort(nlist):
        print("\nThis is the process:")
        print(nlist)
        for index in range(1,len(nlist)):
            currentvalue = nlist[index]
            position = index

            while position > 0 and nlist[position-1]>currentvalue:
                nlist[position]=nlist[position-1]
                position = position-1
            nlist[position]=currentvalue
            print(nlist)
        print(nlist)

    #2 Selection Sort
    def selection_sort(nlist):
        print("\nThis is the process:")
        print(nlist)
        for i in range (0, len(nlist) - 1):
            minIndex = i
            for j in range (i+1, len(nlist)):
                if nlist[j] < nlist[minIndex]:
                    minIndex = j
            if minIndex != i:
                nlist[i], nlist[minIndex] = nlist[minIndex], nlist[i]
                print(nlist)

    #3 Bubble Sort
    def bubble_sort(nlist):
        print("\nThis is the process:")
        print(nlist)
        for passnum in range(len(nlist)-1, 0, -1):
            for i in range(passnum):
                if nlist[i]>nlist[i+1]:
                    temp = nlist[i]
                    nlist[i] = nlist[i+1]
                    nlist[i+1] = temp
                    print(nlist)

    #4 Quick Sort
    def quick_sort(nlist):
        length = len(nlist)
        if length <= 1:
            return nlist
        else:
            pivot = nlist.pop()
        lesser = []
        greater = []
        for i in nlist:
            if i < pivot:
                lesser.append(i)
            else:
                greater.append(i)
        print(lesser, pivot, greater)
        print(nlist)
        return quick_sort(lesser) + [pivot] + quick_sort(greater)

    #5 Merge Sort
    def merge_sort(nlist):

        if len(nlist)>1:
            mid = len(nlist)//2
            lefthalf = nlist[:mid]
            righthalf = nlist[mid:]

            merge_sort(lefthalf)
            merge_sort(righthalf)
            i=j=k=0
            while i < len(lefthalf) and j < len(righthalf):
                if lefthalf[i] < righthalf[j]:
                    nlist[k]=lefthalf[i]
                    i=i+1
                else:
                    nlist[k]=righthalf[j]
                    j=j+1
                k=k+1

            while i < len(lefthalf):
                nlist[k]=lefthalf[i]
                i=i+1
                k=k+1

            while j < len(righthalf):
                nlist[k]=righthalf[j]
                j=j+1
                k=k+1
            print(lefthalf,righthalf)
            print(nlist)
    #6 Shell Sort
    def shell_sort(nlist):
        sublistcount = len(nlist)//2
        while sublistcount > 0:
          for start_position in range(sublistcount):
            gap_InsertionSort(nlist, start_position, sublistcount)

          sublistcount = sublistcount // 2

    def gap_InsertionSort(nlist, start, gap):
        print("\nThis is the process:")
        for i in range(start+gap, len(nlist), gap):

            current_value = nlist[i]
            position = i

            while position >= gap and nlist[position-gap] > current_value:
                nlist[position] = nlist[position-gap]
                position = position-gap

            nlist[position] = current_value
            print(nlist)



    el = input("\nHow many Elements are you going to input? ")
    limit = int(el)

    print("\nNumber of elements to input are " + el)
    print("\nPlease input the numbers")

    nlist = [5] * limit

    for index in range(0, len(nlist)):
        nlist[index] = int(input("Enter element number " + str(index+1) + ": "))

    print("\nThis is the unsorted list: \n" , nlist)

    ##Insert the Choices for Sorting
    print("\n[1] - Insertion Sort")
    print("[2] - Selection Sort")
    print("[3] - Bubble Sort")
    print("[4] - Quick Sort")
    print("[5] - Merge Sort")
    print("[6] - Shell Sort")


    option = int(input("\nInput the number of the Sorting Algorithm you want: "))

    if option == 1:
        insertion_sort(nlist)
        print("\nThis is the sorted list \n", nlist)
    elif option == 2:
        selection_sort(nlist)
        print("\nThis is the sorted list \n", nlist)
    elif option == 3:
        bubble_sort(nlist)
        print("\nThis is the sorted list \n", nlist)
    elif option == 4:
        print("\nThis is the process:")
        print("\nThis is the sorted list \n", quick_sort(nlist))
    elif option == 5:
        print("\nThis is the process:")
        merge_sort(nlist)
        print("\nThis is the sorted list \n", nlist)
    elif option == 6:
        shell_sort(nlist)
        print("\nThis is the sorted list \n", nlist)
    else:
        print("Sorting Algorithm doesn't exist")

    answer = input("\nSort another list? [Y/N] ")
    if answer == "y":
        continue
    else:
        exit()