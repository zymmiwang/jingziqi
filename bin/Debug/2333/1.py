from simplified_html.request_render import RequestRender
from simplified_scrapy.simplified_doc import SimplifiedDoc
import requests


str0 = ''


def callback(html,url,data):
doc = SimplifiedDoc()
div = doc.getElementByClass('img-box',html)
global str0

try:
str0 = (doc.listImg(div.innerHtml,url))[0]['url']
except:
pass

#print(type(str0))


def down(str0):
re = requests.get(str0)


with open('%s'%str0[-29:-21] + '%s'%str0[-20:-6],'wb') as f:
f.write(re.content)


for i in range(0,999):
req = RequestRender({ 'executablePath': r'C:\Program Files (x86)\Google\Chrome\Application\chrome.exe'})

try:
req.get('https://www.bilibili.com/video/av76509567/',callback)
print(str0)
down(str0)
except:
i = i - 1


req.close()
