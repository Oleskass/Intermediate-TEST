# Описание решения задачи итоговой работы

## ***Задача:***
Написать программу, которая из имеющегося массива строк формаирует массив из строк, длина которых меньше либо равна 3 символам.
<br>
<br>

### *<u>Метод ShortElemArray()</u>*
1. Для начала определим длину нового массива: запускаем цикл для подсчёта количества элементов в новом массиве, то есть строки с количеством символов 3 и менее.
2. Создаём новый массив newArr с новой длиной, которую мы узнали в предыдущем пункте.
3. Создаём счётчик элементов нового массива count.
4. Запускаем цикл и записываем строки с 3 и менее символами в новый массив.
5. Возвращаем новый массив.
<br>
<br>

### *<u>Метод Print1DArray()</u>*
Для корректного отображения квадратных скобок и запятых для печати одномерного массива прописываем __3 возможных случая__:
>когда длина массива > 1;

>когда длина массива == 1;

>когда длина массива == 0; 

<br>

### *<u>Программа, решающая вышепоставленную задачу</u>*
- Создаём массив строк с некоторыми данными array.
- Печатаем текст, сообщающий, что это исходный массив.
- Печатаем исходный массив с помощью метода Print1DArray().
- Создаём новый массив строк с новыми данными, которые создаст метод ShortElemArray().
- Печатаем текст, сообщающий, что это новый массив.
- Печатаем новый массив с помощью метода Print1DArray().
