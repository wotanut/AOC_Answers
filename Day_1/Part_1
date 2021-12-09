import os


bigger_than = 0



THIS_FOLDER = os.path.dirname(os.path.abspath(__file__))

my_file = os.path.join(THIS_FOLDER, 'day1_codes.txt')

f = open(my_file)

contents = f.readlines()
#for line in contents:
    #print(line)    # this works
    #print(contents[line]) ### but these two don't
    #print(contents[line-1])

current_line = 0
loops = 0

for line in contents:
    previous_line = current_line
    current_line = int(line)
    try:
        if loops == 0:
            print(current_line + "(N/A)")
        elif current_line > previous_line and line != 0:
            print(f"{current_line} (increased)")
            bigger_than = bigger_than + 1
        else:
            print(f"{current_line} (decreased)")
    except Exception as e:
        print(e)
    
    loops = loops + 1
    
print(bigger_than)
number_of_lines = len(contents)
#print(number_of_lines)
    
#print(number_of_lines - bigger_than)
    
f.close()
