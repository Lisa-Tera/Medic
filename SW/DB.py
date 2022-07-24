f = open("C:\SW\\d2d.txt", 'r',encoding='utf-8')
lines = f.readlines()
for line in lines:
    if "포도당" in line:
        print(line)
