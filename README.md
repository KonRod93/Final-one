## Итоговая проверочная работа

### Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

__Примеры__:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] 


### Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)


#### Блок-схема алгоритма
![Блок-схема алгоритма решения задания](https://user-images.githubusercontent.com/115852634/205860429-276360f8-8e1b-4756-8995-a68a93f810a2.png)

В папке Flowchart находится графическое представление метода в двух файлах в разных расширениях.

#### Описание алгоритма решения задачи
1. Сначала задаём строковый массив
2. Делаем перебор значений из исходного массива
3. Проверяем каждое значение из массива на соответствие условию: _"длина строки меньше или равна трем"_
4. Если строка удовлетворяет условию кладем значение в новый массив
5. Повторяем пункты 2 и 3 до тех пор пока не достигнем конца исходного массива
6. Возвращаем новый заполненый массив как результат

В папке Task находится решение задачи на C#.