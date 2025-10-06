import tkinter as tk
from tkinter import simpledialog, messagebox
import re

# Функція пошуку всіх Gmail адрес у тексті
def find_gmail_addresses(text):
    pattern = r'\b[A-Za-z0-9._%+-]+@gmail\.com\b'
    return re.findall(pattern, text)

# Головна функція обробки
def process_text():
    text = text_entry.get("1.0", tk.END)
    addresses = find_gmail_addresses(text)
    if not addresses:
        messagebox.showinfo("Result", "Gmail address has not found.")
        return

    # Відображаємо знайдені адреси
    addresses_text.set("\n".join(addresses))
    count_label.config(text=f"Find adress: {len(addresses)}")

# Видалити обрану адресу
def delete_address():
    addr = simpledialog.askstring("Delete", "Entered address for delete:")
    if not addr:
        return
    current_text = text_entry.get("1.0", tk.END)
    new_text = current_text.replace(addr, "")
    text_entry.delete("1.0", tk.END)
    text_entry.insert(tk.END, new_text)
    process_text()

# Замінити обрану адресу на іншу
def replace_address():
    old_addr = simpledialog.askstring("Replace", "Entered address for replace:")
    if not old_addr:
        return
    new_addr = simpledialog.askstring("Replace", "Entered new address:")
    if new_addr is None:
        return
    current_text = text_entry.get("1.0", tk.END)
    new_text = current_text.replace(old_addr, new_addr)
    text_entry.delete("1.0", tk.END)
    text_entry.insert(tk.END, new_text)
    process_text()

# --- GUI ---
root = tk.Tk()
root.title("Searching Gmail address")

# Текстове поле для введення тексту
text_entry = tk.Text(root, width=60, height=10)
text_entry.pack(pady=10)

# Кнопки
button_frame = tk.Frame(root)
button_frame.pack()

search_btn = tk.Button(button_frame, text="Find Gmail addresses", command=process_text)
search_btn.grid(row=0, column=0, padx=5)

delete_btn = tk.Button(button_frame, text="Delete address", command=delete_address)
delete_btn.grid(row=0, column=1, padx=5)

replace_btn = tk.Button(button_frame, text="Replace address", command=replace_address)
replace_btn.grid(row=0, column=2, padx=5)

# Вивід знайдених адрес
addresses_text = tk.StringVar()
addresses_label = tk.Label(root, textvariable=addresses_text, justify=tk.LEFT)
addresses_label.pack(pady=10)

# Вивід кількості
count_label = tk.Label(root, text="Find address: 0")
count_label.pack()

root.mainloop()
