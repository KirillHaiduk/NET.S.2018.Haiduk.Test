# NET.S.2018.Haiduk.Test
1.	Дана система типов (Task1)  для верификации пароля согласно некоторым фиксированным правилам и его сохранения, в случае валидности, в хранилище. Какие  проблемы возникнут при использовании данного кода, если множество клиентов класса PasswordCheckerService захотят его использовать для различных комбинаций условий валидации (существующих и новых), используя при этом разные хранилища? Выполнить рефакторинг данного кода, устранив обнаруженную проблему (решение поместить в проект Task1.Solution), проверить работу новой системы типов в консоли (проект Task1.Console) или реализовать юнит-тесты (проект Task1.Tests).

2.	Дана система типов (Task2) для генерации файлов с рандомным содержимым. Выполнить рефакторинг типов (решение поместить в проект Task2.Solution), выделив необходимые/(ую) абстракции/(ю). Проверить работу новой системы типов в консоли (проект Task2.Console).

3.	Дана система типов (Task3), моделирующие фондовую биржу. Изменить код, используя механизм событий (решение поместить в проект Task3.Solution),  проверить работу новой системы типов в консоли (проект Task3.Console). 

4.	Дана система типов (Task4) для расчета различных вариантов среднего арифметического значения для набора вещественных чисел. Выполнить рефакторинг типов с учетом возможности изменения/дополнения алгоритма подсчета  среднего значения (решение поместить в проект Task4.Solution), проверить работу новой системы типов для тестов (проект Task4.Tests). Предложить, различные варианты решения данной задачи.

5.	Дана система типов (Task5) для описания документа - класс Document, состоящего из различного вида частей документа DocumentPart - BoldText, Hyperlink, PlainText (3 типа для краткости). Какие  проблемы возникнут при использовании данного кода, если часто будет возникать необходимость добавления конвертирования документа в новый формат (например, обычный текст, html, LaTeX и т.д.)? Выполнить рефакторинг данного кода, устранив обнаруженную проблему (решение поместить в проект Task5.Solution), проверить работу новой системы типов в консоли (проект Task5.Console).

6.	Реализовать (решение поместить в проект Task6.Solution) обобщенный генератор n-первых членов последовательности, заданной рекуррентной формулой для элементов типа T по правилу. 
Проверить работу построенного генератора  (решение поместить в проект Task6.Tests) на примере следующих последовательностей.
