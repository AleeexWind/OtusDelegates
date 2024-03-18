namespace OtusDelegates
{
    public class FileFinder
    {
        public event EventHandler<FileArgs>? FileFound;
        private bool _cancel;

        public void SearchFiles(string dir)
        {
            foreach (var file in Directory.GetFiles(dir))
            {
                FileFound?.Invoke(this, new FileArgs(file));
                if (_cancel)
                {
                    Console.WriteLine("The search has been canceled");
                    return;
                }
            }
        }
        public void Cancel() => _cancel = true;
    }

    public class FileArgs : EventArgs
    {
        public string FileName { get; set; }
        public FileArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}
