import requests
from bs4 import BeautifulSoup
import re
import pycountry
# # Open file
# url = "index.html"
# with open(url) as openLinks:
#     soup = BeautifulSoup(openLinks,'html.parser')

# # print(soup)
# #open link, get all source html

open_link = 'http://satisfiability.org/SAT24/'
soup_link = requests.get(open_link)
get_content = BeautifulSoup(soup_link.content,'html.parser')
# print(get_content)

# #get tag
# example_tag = BeautifulSoup('<b>Extremely bold</b>', 'html.parser')
# get_tag = example_tag.b
# print(get_tag)
data_links = []
date_link = ''
get_specific = get_content.find_all('a') 
if get_specific:
    for get_link in get_specific:
      data_links.append(get_link.get('href'))  
print('-----')

#Open link and get Notification 
#get link from dates_link in get_link array
for link in data_links:
   if link == 'dates.php':
      date_link = open_link + link
    
new_open = requests.get(date_link)
get_data = BeautifulSoup(new_open.content,'html.parser')

find_data = get_data.find('ul')
for item in find_data:
   if 'Notification of decisions:' in item.text :
     newstring = item.get_text().replace('Notification of decisions:',"")
     print(newstring.replace(' AoE',''))

  # find next tag 'ul'
find_next = find_data.find_next_sibling('ul')
for confer in find_next:
   if 'SAT Conference' in confer.text:
    conference = confer.get_text().replace('SAT Conference:','')
    print(conference)

# Get Deadline in template
get_start = ''
get_deadline=''
for item in find_data:
   if 'Abstract Submission' in item.text:
      if 'AoE CLOSED' in item.text:
         newstring = item.get_text().replace('Abstract Submission:','')
         get_start = newstring.replace('AoE CLOSED','')
      
   if 'Paper Submission' in item.text:
      new_string = item.get_text().replace('Paper Submission:','')
      get_deadline = new_string.replace(' AoE March 17, 2024 AoE CLOSED','')
      
      
find_start = re.findall('[0-9][0-9]',get_start.strip())
find_deadline = re.findall('[0-9][0-9]',get_deadline.strip())

find_month = re.findall('\D[A-Za-z]+\S',get_deadline.strip())
deadline = find_start[0]+ '-' + find_deadline[0]+' '+find_month[0] +' '+ find_deadline[1]+find_deadline[2]
print(deadline)
    
#Get City, Country
countries = [country.name for country in pycountry.countries]
location = get_content.find('div',class_='banner-content')
for item in location:
   text_item = item.get_text().strip()
   for country in countries:
      if country in text_item:
         get_locationContent = text_item.strip()
         get_location = re.findall('\D[A-Za-z]+\S',get_locationContent)
         print(get_location[1]+get_location[2])
#Get conference
if get_specific:
    for get_link in get_specific:
      if 'SAT' in get_link.text:
        get_reference = get_link.get_text().replace(get_link.get_text(),'SAT')
        print(get_reference)