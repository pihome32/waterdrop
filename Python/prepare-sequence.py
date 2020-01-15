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

table=[]





for line in range(2,15):
    cell = 'B' + str(line)
    time = sheet.acell(cell).value
    if time != '':
        cell = 'C' + str(line)
        func = sheet.acell(cell).value
        cell = 'D' + str(line)
        duration = int(sheet.acell(cell).value)
        table.append([int(time),func])
        if duration > 0 :
            func = func + "_OFF"
            end = duration + int(time)
            table.append([end,func])


#Sort table by time
table.sort()

#Determine the end time with the last element in the table
end_time=table[-1][0]



print(table)
