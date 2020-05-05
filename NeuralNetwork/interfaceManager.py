
def PrintDelimiter():
    print("\n*******************************************************************")

def RequestWorkingMode():
    print("\nSelect working mode: \n   Type \"new\" or \"n\" for training new model \n   Type \"load\" or \"l\" for continue training of existing model \n")
    mode = input()
    if (mode == "new" or mode == "n"):
        return 1
    if (mode == "load" or mode == "l"):
        return 2
    print("   Wrong mode")
    return RequestWorkingMode()

def RequestAccuracy():
    print("\nEnter desired accuracy (value from 0 to 1):")
    acc = float(input())
    if (acc > 1.0 or acc < 0.0):
        print("   Wrong accuracy")
        return RequestAccuracy
    return acc

def RequestEpochLimit():
    print("\nEnter epoch count maximum:")
    epMax = int(input())
    return epMax