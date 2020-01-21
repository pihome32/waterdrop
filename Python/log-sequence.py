import gspread
from oauth2client.service_account import ServiceAccountCredentials
import datetime
import sys
import os

scope = ['https://spreadsheets.google.com/feeds',
         'https://www.googleapis.com/auth/drive']
cred_file = os.path.join(sys.path[0], "google.json");
creds = ServiceAccountCredentials.from_json_keyfile_name(cred_file, scope)
client = gspread.authorize(creds)

# Find a workbook by name and open the first sheet

googlesheet = client.open("WaterDrop-sequence")
sheet = googlesheet.worksheet("logs")

file_name = os.path.join(sys.path[0], "sequence.txt")
sequence_file = open(file_name,"r")
file_content = sequence_file.readlines()

arduino_sequence = file_content[0]

human_sequence = file_content[1]

now = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")


col_values = sheet.col_values(1)

row = len(col_values)+1
sheet.update_cell(row  ,1, now)
sheet.update_cell(row ,2, arduino_sequence)
sheet.update_cell(row ,3, human_sequence)

print("log finished")