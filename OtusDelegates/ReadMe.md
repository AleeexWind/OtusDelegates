��������/��������� ���������� ���������� ��������� �������:

	1. �������� ���������� ������� ����������, ��������� � ������������ ������������ ������� ���������.
	������� ������ ��������� �� ���� �������, ������������� ������� ��� � ����� ��� ����������� ������ ������������� ��������.
	public static T GetMax(this IEnumerable collection, Func<T, float> convertToNumber) where T : class;
			CollectionExtention.cs
	2. �������� �����, ��������� ������� ������ � �������� ������� ��� ���������� ������� �����;
			FileFinder.cs
	3. �������� ������� � ��� ��������� � �������������� .NET ����������:
	public event EventHandler FileFound;
	FileArgs � ����� ��������� ��� ����� � ������������� �� EventArgs
			FileFinder.cs -> public event EventHandler<FileArgs>? FileFound;   and  FileArgs
	4.�������� ����������� ������ ����������� ������ �� �����������;
            FileFinder.cs -> private bool _cancel;
	5.������� � ������� ���������, ����������� ��� ������������ ������� � ��������� ������ ������������� ��������.
            FileFinder:
                Program.cs -> ff.FileFound += (s, e) =>
                {
                    Console.WriteLine($"File has been found. File name: {e.FileName}");
                };
            CollectionExtention:
                Program.cs -> Console.WriteLine($"The biggest digit is: {numbersAsString.GetMax(convertToNumber)}");