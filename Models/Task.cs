using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models;

public class Task: INotifyPropertyChanged
{
    public string Filename { get; set; }
    private bool _completed;
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public bool Completed
    {
        get => this._completed;
        set
        {
            _completed = value;
            this.BgColor = _completed ? Colors.LightGray : Colors.White;
            OnPropertyChanged(nameof(Completed));
            OnPropertyChanged(nameof(BgColor));
        }
    }
    private Color _bgColor;
    public Color BgColor
    {
        get => _bgColor;
        set
        {
            if (!Equals(_bgColor, value))
            {
                _bgColor = value;
                OnPropertyChanged(nameof(BgColor));
            }
        }
    }


    public Task(string title)
    {
        Filename = $"{Path.GetRandomFileName()}.tasks.txt";
        Title = title;
        Date = DateTime.Now;
        Completed = false;
        BgColor = Colors.White;
    }

    public Task()
    {
        Filename = $"{Path.GetRandomFileName()}.tasks.txt";
        Title = "";
        Date = DateTime.Now;
        Completed = false;
        BgColor = Colors.White;
    }

    public void Save()
    {
        var appDatePath = FileSystem.AppDataDirectory;

        File.WriteAllText(Path.Join(appDatePath, Filename), Title);
    }

    public void Delete()
    {
        File.Delete(Path.Join(FileSystem.AppDataDirectory, Filename));
    }

    public static IEnumerable<Models.Task> LoadAll()
    {
        var appDataPath = FileSystem.AppDataDirectory;

        return Directory
            .EnumerateFiles(appDataPath, "*.tasks.txt")
            .Select(filename => new Task
            {
                Title = File.ReadAllText(filename),
                Filename = Path.GetFileName(filename)
            })
            .OrderBy(task => task.Date);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}