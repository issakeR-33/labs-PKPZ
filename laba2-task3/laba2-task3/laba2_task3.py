import random

num_groups = 3
num_students = 10
num_exams = 4

min_grade = 1
max_grade = 100


groups = []
for g in range(num_groups):
    group = []
    for s in range(num_students):
        # one student 
        grades = [random.randint(min_grade, max_grade) for _ in range(num_exams)]
        group.append(grades)
    groups.append(group)

# average score of group
group_averages = []
for g_index, group in enumerate(groups):
    total = 0
    count = 0
    for student in group:
        total += sum(student)
        count += len(student)
    average = total / count
    group_averages.append(average)
    print(f"Group {g_index + 1} average: {average:.2f}")

best_group_index = group_averages.index(max(group_averages))
print(f"\nBest group is group {best_group_index + 1} with average {group_averages[best_group_index]:.2f}")

