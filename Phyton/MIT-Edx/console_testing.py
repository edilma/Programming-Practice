def workout_coach(lift_name, wt):
    print("Time to", lift_name, wt, "pounds! You got this!")

def max_weight(lift_name,wt,end_now):
        
    if lift_name == "deadlift" and wt>=200:
        end_now=True
        return 
    else:
        wt=wt+10


def new_set(lift_name,wt):
    more_wt = input('want to continue exercising ? ')
    if more_wt == 'yes':
        workout_coach(lift_name,wt)
        load_more_weight(lift_name,wt )

    else:
        return False

def load_more_weight(lift_name,wt ):
    print ('Keep doing the ', lift_name)
    keep_loading=True
    while keep_loading:

        more_load =input ('Enter yes for the next set ')
        if more_load =='yes':
            wt= wt+10
            workout_coach(lift_name, wt)
            if ((wt >=60) and (lift_name =='deadlift')): #check if the user has a weight too heavy
                break
                
        else:
            keep_loading =False

 




def main():
    lifts = ["squat", "bench", "deadlift"]
    more_wt = True
    wt = 10
    
    for i in lifts:
        new_set(i,wt)
        

if __name__ == "__main__":
    main()