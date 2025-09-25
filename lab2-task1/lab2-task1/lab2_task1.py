def input_array():
    """Введення масиву з клавіатури"""
    n = int(input("Введіть розмірність масиву: "))
    arr = []
    for i in range(n):
        element = int(input(f"arr[{i}] = "))
        arr.append(element)
    return arr


def process_array(arr):
    """Обробка масиву згідно умови"""
    arr = arr.copy()

    # множина тих абсолютних значень, для яких є і +, і -
    pairs = set()

    for x in arr:
        if x > 0 and -x in arr:
            pairs.add(x)

    # тепер змінюємо знаки тільки для чисел, які в цих парах
    for i in range(len(arr)):
        if abs(arr[i]) in pairs:
            arr[i] = -arr[i]

    return arr


def output_array(arr):
    """Виведення масиву"""
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
