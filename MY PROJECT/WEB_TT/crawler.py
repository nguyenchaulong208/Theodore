import requests
from bs4 import BeautifulSoup
import re

url = "http://satisfiability.org"
response = requests.get(url)  # Lấy nội dung từ URL
soup = BeautifulSoup(response.content, 'html.parser')  # Phân tích nội dung HTML
page_p = soup.find("p")
print(page_p.contents[0])

page_content = soup.find_all(href=re.compile("SAT"))
# print(f"{page_content}")
for tag_a in page_content:
    print(tag_a)
