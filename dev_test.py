import pandas as pd

def NameIndex(csvfile, columnname):
    dataset = pd.read_csv(csvfile)
    columnindex = dataset.columns.get_loc(columnname)
    print(f'{columnname} = {columnindex + 1}')
NameIndex("data.csv", "Stamp Duty")