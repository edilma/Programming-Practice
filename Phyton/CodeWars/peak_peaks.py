def pick_peaks(arr):
    original = arr
    #print (arr)
    #arr.sort()
    #max =arr[-1]
    maximo = max(arr)
    answer = arr.index(maximo)
    #print(answer)
    #return answer
    return (maximo,answer)

def main():
    #arr = [5,3,6,4,1,20,6,7,8]
    arr = [0, 1, 2, 5, 1, 0]
    print (pick_peaks(arr))
    print ("{pos: ["{0}"], peaks: ["{1}"]}",pick_peaks(arr))
if __name__ == "__main__":
    main()
