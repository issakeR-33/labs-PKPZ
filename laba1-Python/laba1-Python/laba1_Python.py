import random

def perevirka(x, y, R):
    if x <= 0 and y >= 0 and x >= -R and y <= R:
        d1 = (x + R) ** 2 + (y - R) ** 2
        if d1 > R ** 2:
            return "Так"
        if d1 == R ** 2:
            return "На межі"
        return "Ні"

    if x >= 0 and y <= 0 and x <= R and y >= -R:
        d2 = (x - R) ** 2 + (y + R) ** 2
        if d2 > R ** 2:
            return "Так"
        if d2 == R ** 2:
            return "На межі"
        return "Ні"

    return "Ні"


def main():
    R = int(input("Введіть радіус мішені R = "))

    print("\nСерія пострілів по мішені:")
    print("-------------------------------------------------")
    print("| № |     x     |     y     |    Результат      |")
    print("-------------------------------------------------")

    hits = 0  

    for i in range(1, 11):
        if i % 2 == 1:  
            x = random.randint(-R // 2, 0)
            y = random.randint(0, R // 2)
        else:  
            x = random.randint(0, R // 2)
            y = random.randint(-R // 2, 0)

        result = perevirka(x, y, R)
        if result in ("Так", "На межі"):
            hits += 1

        print(f"| {i:2} | {x:7} | {y:7} | {result:14} |")

    print("-------------------------------------------------")
    print(f"Влучань у мішень: {hits} з 10")


if __name__ == "__main__":
    main()
