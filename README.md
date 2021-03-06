# Pizza
### Функциональные требования
Кафе (Cafe) должно иметь возможность предоставлять конструктор пиццы для посетителей, где
они могут добавить компоненты в пиццу по своему вкусу и получать это продукт.
<table>
    <tr>
        <th>Pizza</th>
        <th>Cheese</th>
        <th>Tomatoes</th>
        <th>Olives</th>
        <th>Meat</th>
    </tr>
    <tr>
        <th>Margarita</th>
        <td>+</td>
        <td>+</td>
        <td>+</td>
        <td></td>
    </tr>
    <tr>
        <th>Carbonara</th>
        <td>+</td>
        <td>+</td>
        <td></td>
        <td>+</td>
    </tr>
    <tr>
        <th>Italian</th>
        <td>+</td>
        <td>+</td>
        <td>+</td>
        <td>+</td>
    </tr>
    <tr>
        <th>Pepperoni</th>
        <td>+</td>
        <td>+</td>
        <td></td>
        <td>+</td>
    </tr>
</table>

Реализовать решение, позволяющее клиенту (Cafe) предоставлять такую возможность.

### Нефункциональные требования:
1. Платформа: Консольное приложение для OS Windows.
2. Язык реализации: C# / Java / C++.

### Реализация
#### Ввод
При запуске приложения необходимо ввести наименование желаемой пиццы из предложенных вариантов.

Пример:

```bash
$ /path/to/Pizza.exe
Enter pizza's name: 
Margarita
Carbonara
Italian
Pepperoni

Italian
```

#### Вывод 
Выводится процесс создания и состав сконструированной пиццы.

Пример:

```
Add cheese
Add tomatoes
Add olives
Add meat

Pizza: Italian
Cheese: Yes
Tomatoes: Yes
Olives: Yes
Meat: Yes
```