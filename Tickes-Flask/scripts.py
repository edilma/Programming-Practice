def add_member(members,email):
    
    if email not in members.keys():
        members[email]=email
    return members


def main():
    members={}
    print (add_member(members,'edilmaria@hotmail.com'))



if __name__ == '__main__':
    main()
    