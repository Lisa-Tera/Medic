import requests,xmltodict,json

key = "uwWl8RM4JM1SaTB2iU%2F%2F9RNeq0wvT3Gq%2BFFCv3Tp3LNCWi4VSx%2BYObACE5mLzi7GKfSVf963H%2BcQLbL7QwKFYw%3D%3D"
for i in range(2,500):
    url = "http://apis.data.go.kr/1471057/MdcinPrductPrmisnInfoService/getMdcinPrductItem?ServiceKey={0}&numOfRows=100&pageNo={1}".format(key,i) #&numOfRows=3&pageNo=1
    content =requests.get(url).content

#dict = xmltodict.parse(content)
jsonString = json.dumps(dict['response']['body'],ensure_ascii = False)
jsonObj = json.loads(jsonString)
dic =[]
i=0
for item in jsonObj['items']['item']:
    dic.append([item['ITEM_NAME'],item['ETC_OTC_CODE'],item[ 'VALID_TERM']],item['EE_DOC_DATA'])
    a = item['EE_DOC_DATA']#[2][1]#item['UD_DOC_DATA'],item['NB_DOC_DATA']])
    #print(dic[i])
    i+=1
print(a['SECTION'])
    

#2개 이상이면 SECTION에서 리스트로 표현됨
