from xml.etree.ElementTree import parse

tree = parse('test2.xml')
root = tree.getroot()
item = root.findall("item")

name = [x.findtext("ITEM_NAME") for x in item]
doc = [x.findtext("ETC_OTC_CODE") for x in item]
valid = [x.findtext("VALID_TERM")for x in item]
effect = [x.findtext("EE_DOC_DATA") for x in item]
dosage = [x.find("UD_DOC_DATA")for x in item]
#effect = [x.findtext("CDATA") for x in item]


'''
import xml.etree.ElementTree as ET
tree = ET.parse('test.xml')
root = tree.getroot()
root = ET.fromstring(country_data_as_string)
print(root.tag, root.attrib)
'''