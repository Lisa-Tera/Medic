import pandas as pd
from bs4 import BeautifulSoup
import requests
startnumber=1
endnumber=1
CommerceInfor = {}

ITEM_NAME = []		
ETC_OTC_CODE = []	
CHART = []			
EE_DOC_DATA = []	
UD_DOC_DATA = []	
NB_DOC_DATA = []	
VALID_TERM = []		

#key = "uwWl8RM4JM1SaTB2iU%2F%2F9RNeq0wvT3Gq%2BFFCv3Tp3LNCWi4VSx%2BYObACE5mLzi7GKfSVf963H%2BcQLbL7QwKFYw%3D%3D"
while endnumber<=52426:
    url = "http://apis.data.go.kr/1471057/MdcinPrductPrmisnInfoService/getMdcinPrductItem?ServiceKey=uwWl8RM4JM1SaTB2iU%2F%2F9RNeq0wvT3Gq%2BFFCv3Tp3LNCWi4VSx%2BYObACE5mLzi7GKfSVf963H%2BcQLbL7QwKFYw%3D%3D&pageNo={0}".format(endnumber) 
    req = requests.get(url)
    html = req.text
    soup = BeautifulSoup(html, 'html.parser')
    ITEM = soup.find_all('ITEM_NAME')	
    ETC = soup.find_all('ETC_OTC_CODE')
    chart = soup.find_all('CHART')		
    EE= soup.find_all('EE_DOC_DATA')
    UD = soup.find_all('UD_DOC_DATA')
    NB= soup.find_all('NB_DOC_DATA')	
    VALID = soup.find_all('VALID_TERM')	
	
    for code in ITEM:
        ITEM_NAME.append(code.text)
    for code in ETC:
        ITEM_NAME.append(code.text)
    