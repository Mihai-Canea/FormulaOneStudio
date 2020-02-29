import sys
import getopt
import getpass
import json


def PrintOutput(sqlQuery, QueryName):
    """ text_file = open("Output/Output.txt", "w")
    text_file.write(sqlQuery)
    text_file.close() """

    sqlFile = open("C:/Users/" + getpass.getuser() +
                   "/Documents/MSSQLDatabase/FormulaOne/{}.sql".format(QueryName), "w")
    sqlFile.write(sqlQuery)
    sqlFile.close()


def SQLtable(TableName, JsonFile):
    queryContent = ""
    print("Table name:", TableName, "| JSON file:", JsonFile)
    with open('../FormulaOneScrapy/{}.json'.format(JsonFile)) as data_file:
        data = json.load(data_file)
    # print("Data:\n",json.dumps(data, indent=4))

    print("ROWS: ", len(data))
    print("COLUMNS: ", len(data[0]))

    for drivers in data:
        sqlQuery = "INSERT INTO [dbo].[{}](\n".format(TableName)
        for num, items in enumerate(drivers, start=1):
            if num == len(data[0]):
                sqlQuery += "\t{}".format(items)
            else:
                sqlQuery += "\t{},\n".format(items)
        break

    for rows, drivers in enumerate(data, start=1):
        queryContent += "("
        for num, items in enumerate(drivers, start=1):
            # Check if exist single quotation mark
            if drivers[items].find("'") != -1:
                drivers[items] = drivers[items].replace("'", "''")
            if num == len(data[0]):
                queryContent += "'{}'".format(drivers[items])
            else:
                queryContent += "'{}',".format(drivers[items])
        queryContent += ");" if rows == len(data) else "),\n"

    sqlQuery += "\n)\nVALUES\n{}".format(queryContent)
    PrintOutput(sqlQuery, TableName)
    print("---\nFile generato correttamente\n---")
    # print(sqlQuery)

#
# ──────────────────────────────────────────────── I ──────────
#   :::::: M A I N : :  :   :    :     :        :          :
# ──────────────────────────────────────────────────────────
#


def main(argv):
    inputfile = ''
    outputfile = ''
    try:
        opts, args = getopt.getopt(argv, "t:o:", ["iTable=", "ofile="])
        # print("OPTS: ", opts, "ARGS ", args)
    except getopt.GetoptError:
        # print('main.py -t <DB table name> -o <Output.txt>')
        print('main.py -t <DB table name>')
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-help':
            print('main.py -t <DB table name>')
            sys.exit()
        elif opt in ("-t", "--iTable"):
            # print("OPT ", opt, "ARG ", arg)
            inputfile = arg
        elif opt in ("-o", "--ofile"):
            # print("OPT ", opt, "ARG ", arg)
            outputfile = arg

    SQLtable(inputfile, inputfile.casefold())
    # print('Input file is "', inputfile)
    # print('Output file is "', outputfile)


if __name__ == "__main__":
    main(sys.argv[1:])
