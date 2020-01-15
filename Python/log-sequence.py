import gspread
from oauth2client.service_account import ServiceAccountCredentials
import datetime
import sys


scope = ['https://spreadsheets.google.com/feeds',
         'https://www.googleapis.com/auth/drive']
creds = ServiceAccountCredentials.from_json_keyfile_name('google.json', scope)
client = gspread.authorize(creds)

# Find a workbook by name and open the first sheet
# Make sure you use the right name here.
file = client.open("WaterDrop-sequence")
logsheet = file.worksheet("logs")


file1 = open("sequence.txt","r")
file_content = file1.readlines()

arduino_sequence = file_content[0]

human_sequence = file_content[1]

now = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")


col_values = logsheet.col_values(1)

row = len(col_values)+1
logsheet.update_cell(row  ,1, now)
logsheet.update_cell(row ,2, arduino_sequence)
logsheet.update_cell(row ,3, human_sequence)