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
При запуске приложения необходимо ответить на список вопросов, позволяющих выбрать или отказаться от определенного ингредиента. 
Чтобы отказаться от добавления, нажмите Enter. Чтобы добавить продукт, введите любой символ или строку.

Пример:

```bash
$ /path/to/Pizza.exe

Cheese?(to pass press enter) 
Tomatoes?(to pass press enter) 
Olives?(to pass press enter) Yes
Meat?(to pass press enter) Yes
```

#### Вывод 
Состав сконструированной пиццы.

Пример:

```
Your choice:
Cheese: No
Tomatoes: No
Olives: Yes
Meat: Yes
```