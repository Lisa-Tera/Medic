with open('C:/Users/eun01/Desktop/새 폴더/api/새 폴더/a1.xml', 'rt',encoding='UTF8') as f:              # file을 열고 알아서 닫아 줌
    lines = []
    a =[]
    for line in f:
        if(line.startswith('</items>')):
            a = lines[:line]+lines[line+14:]
        else:
            lines = lines + [line]
f.seek(0)                                      # file pointer 위치를 처음으로 돌림
f.writelines(lines)                            # 수정한 lines를 파일에 다시 씀
f.truncate()                