import gspread
from oauth2client.service_account import ServiceAccountCredentials
import os
import sys
import time
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
arduino_sequence='[N'

def main():
    return("arduino_sequence")


print("Start reading google sheet")

for line in range(2,15):
    millis = sheet.cell(line,2).value
    if millis != '':
        func = sheet.cell(line,3).value
        duration = int(sheet.cell(line,4).value)
        human_table.append([int(millis),func])
        if duration > 0 :
            func = func + "_OFF"
            end = duration + int(millis)
            human_table.append([end,func])

#Sort table by time
human_table.sort()
print("Reading OK")


#Convert to arduino readable sequence
i = 1

for step in human_table:
        func = step[1]
        func = func[0:3] #take the first 3 letters
        switcher={'SO1':'D7','SO2':'D6','SO3':'D5','FL1':'B2','FL2':'B1','FL3':'B0','CAM':'B4','FO':'B5'}
        arduino_sequence = arduino_sequence + str(step[0]+1000) + switcher.get(func,'XXXXX') +','
        i = 1 + i


arduino_sequence = arduino_sequence[:-1] +  ']'
#Determine the end time with the last element in the table
end_time=human_table[-1][0]

#print(arduino_sequence)

#Convert human table to single string
human_sequence = '['
i = 0
while i < len(human_table):
    human_sequence = human_sequence + str(human_table[i][0]) + ':' + human_table[i][1] + ','
    i += 1

human_sequence = human_sequence + ']'
print("human table : " + human_sequence)
print(arduino_sequence)
sequence_filename = os.path.join(sys.path[0], "sequence.txt");
sequence_file = open(sequence_filename,"w")
sequence_file.write(arduino_sequence)
sequence_file.write('\n')
sequence_file.write(human_sequence)

sequence_file.close()
#main()
