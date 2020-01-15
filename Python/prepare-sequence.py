import gspread
from oauth2client.service_account import ServiceAccountCredentials
import sys

# use creds to create a client to interact with the Google Drive API

scope = ['https://spreadsheets.google.com/feeds',
         'https://www.googleapis.com/auth/drive']
creds = ServiceAccountCredentials.from_json_keyfile_name('client_secret.json', scope)
client = gspread.authorize(creds)

# Find a workbook by name and open the first sheet
# Make sure you use the right name here.
sheet = client.open("Drop").sheet1


human_table=[]
arduino_sequence='['

for line in range(2,15):
    cell = 'B' + str(line)
    time = sheet.acell(cell).value
    if time != '':
        cell = 'C' + str(line)
        func = sheet.acell(cell).value
        cell = 'D' + str(line)
        duration = int(sheet.acell(cell).value)
        human_table.append([int(time),func])
        if duration > 0 :
            func = func + "_OFF"
            end = duration + int(time)
            human_table.append([end,func])

#Sort table by time
human_table.sort()

#Convert to arduino readable sequence
for step in human_table:
        func = step[1]
        func = func[0:3] #take the first 3 letters
        switcher={'SO1':'D7','SO2':'D6','SO3':'D5','FL1':'B2','FL2':'B1','FL3':'B0','CAM':'B4','FO':'B5'}
        arduino_sequence = arduino_sequence + str(step[0]) + '/' + switcher.get(func,'XXXXX') + '/'

arduino_sequence = arduino_sequence +  ']'
#Determine the end time with the last element in the table
end_time=human_table[-1][0]

print(arduino_sequence)

print(human_table)
