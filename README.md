# FinalHome
## *Задача:*

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## *Описание алгоритма:*

Создаем два массива. Первый заполняется с клавиатуры пользователем. Второй массив будет содержать итоговую строку с элементами первого массива меньше, либо равных трем символам.
Длина второго массива равна длине первого массива.
В цикле перебираем элемента первого массива с нулевого до последнего элемента ( с индексом равным длине массива). При соблюдении условия- длина i-го элемента меньше или равна трем, записываем его во второй массив.
Далее выводим на печать массив с итоговыми значениями.
