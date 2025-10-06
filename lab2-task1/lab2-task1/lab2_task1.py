def input_array():
    "Розмір масиву"
    n = int(input("Розмір масиву: "))
    arr = []
    for i in range(n):
        element = int(input(f"arr[{i}] = "))
        arr.append(element)
    return arr


def process_array(arr): 
    arr = arr.copy()

    #for +x , -x 
    pairs = set()

    for x in arr:
        if x > 0 and -x in arr:
            pairs.add(x)


    # change simbols 
    for i in range(len(arr)):
        if abs(arr[i]) in pairs:
            arr[i] = -arr[i]

    return arr


def output_array(arr):
    "Виведення масиву"
    print("Результуючий масив:")
    for el in arr:
        print(el, end=" ")
    print()


def main():
    arr = input_array()
    result = process_array(arr)
    output_array(result)


if __name__ == "__main__":
    main()
