def score(dice):
    points={
        {1:{1:100,3:1000}},2:{3:200},3:{3:300},4:{3:400},5:{1:50,3:500},6:{3:600}
    }
    dices = [1,2,3,4,5,6,]


def main():
    dice = [2, 4, 4, 5, 4]
    print (score(dice))


if __name__ == "__main__":
    main()