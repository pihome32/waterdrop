import gspread
from oauth2client.service_account import ServiceAccountCredentials
import os
import sys

# use creds to create a client to interact with the Google Drive API

scope = ['https://spreadsheets.google.com/feeds',
         'https://www.googleapis.com/auth/drive']

file = os.path.join(sys.path[0], "google.json");

creds = ServiceAccountCredentials.from_json_keyfile_name(file, scope)
client = gspread.authorize(creds)

# Find a workbook by name and open the first sheet
# Make sure you use the right name here.
file = client.open("WaterDrop-sequence")
sheet = file.worksheet("sequence")


human_table=[]
arduino_sequence='['

for line in range(2,15):
    time = sheet.cell(line,2).value
    if time != '':
        func = sheet.cell(line,3).value
        duration = int(sheet.cell(line,4).value)
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
        arduino_sequence = arduino_sequence + str(step[0]) + ':' + switcher.get(func,'XXXXX') + ','

arduino_sequence = arduino_sequence +  ']'
#Determine the end time with the last element in the table
end_time=human_table[-1][0]

print(arduino_sequence)

#Convert human table to single string
human_sequence = '['
i = 0
while i < len(human_table):
    human_sequence = human_sequence + str(human_table[i][0]) + ':' + human_table[i][1] + ','
    i += 1

human_sequence = human_sequence + ']'
print(human_sequence)
file1 = open("sequence.txt","w")
file1.write(arduino_sequence)
file1.write('\n')
file1.write(human_sequence)

file1.close()
