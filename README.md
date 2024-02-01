# ИТОГОВАЯ КОНТРОЛЬНАЯ РАБОТА
## Задание:
1. Создать репозиторий на GitHub.

Решение: На GitHub создан репозиторий, доступный по ссылке: https://github.com/ANICD/FinalTest.git

2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)

Решение: Блок-схема алгоритма представлена в файле Algoritm.drawio.

3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)

Решение: Создан файл Readme.md и выложен в репозиторий на GitHub.

4. Написать программу, решающую поставленную задачу

Решение: Текст программы представлен в файле Program.cs

5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Решение: Используется контроль версий с промежуточными коммитами.

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение: 
1. Для решения этой сначала предлагаем пользователю ввести количество элементов массива строк. Это число далее будет определять длину массива и количество запросов на ввод строк. Далее, исползуя эти исходные данные формируем массив строк и выводим его на экран.
2. Далее в цикле перебираем элементы входного массива (строки) и сравниваем по количеству символов. Если символов 3 или меньше, то записываем этот элемент в новый массив.
3. Выводим результирующий массив на экран и завершаем работу программы.