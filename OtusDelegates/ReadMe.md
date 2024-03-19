Описание/Пошаговая инструкция выполнения домашнего задания:

	1. Написать обобщённую функцию расширения, находящую и возвращающую максимальный элемент коллекции.
	Функция должна принимать на вход делегат, преобразующий входной тип в число для возможности поиска максимального значения.
	public static T GetMax(this IEnumerable collection, Func<T, float> convertToNumber) where T : class;
			CollectionExtention.cs
	2. Написать класс, обходящий каталог файлов и выдающий событие при нахождении каждого файла;
			FileFinder.cs
	3. Оформить событие и его аргументы с использованием .NET соглашений:
	public event EventHandler FileFound;
	FileArgs – будет содержать имя файла и наследоваться от EventArgs
			FileFinder.cs -> public event EventHandler<FileArgs>? FileFound;   and  FileArgs
	4.Добавить возможность отмены дальнейшего поиска из обработчика;
            FileFinder.cs -> private bool _cancel;
	5.Вывести в консоль сообщения, возникающие при срабатывании событий и результат поиска максимального элемента.
            FileFinder:
                Program.cs -> ff.FileFound += (s, e) =>
                {
                    Console.WriteLine($"File has been found. File name: {e.FileName}");
                };
            CollectionExtention:
                Program.cs -> Console.WriteLine($"The biggest digit is: {numbersAsString.GetMax(convertToNumber)}");