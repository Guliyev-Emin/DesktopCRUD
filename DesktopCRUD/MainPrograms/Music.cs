using System.Collections.Generic;
using System.IO;
using System.Linq;
using WMPLib;

namespace DesktopCRUD.MainPrograms;

public static class Music
{
    public static bool MusicPlayerStatus;
    private static readonly WindowsMediaPlayer MusicPlayer = new();
    private static readonly string ProjectPath = new FileInfo(@"..\..\Music").DirectoryName;

    public static void StartPlay()
    {
        foreach (var name in Directory.GetFiles("../../Music"))
        {
            var musicName = name.Split('\\').Last();
            if (!musicName.Split('.')[1].Equals("mp3")) continue;
            var url = ProjectPath + @"\Music\" + musicName;
            MusicPlayer.URL = url;
            MusicPlayer.controls.play();
            MusicPlayer.settings.setMode("autoRewind", false);
            break;
        }
    }

    public static IEnumerable<string> GetAllMusics()
    {
        return Directory.GetFiles(@"..\..\Music");
    }

    public static void Play()
    {
        MusicPlayer.controls.play();
    }

    public static void Play(string name)
    {
        Pause();
        MusicPlayer.URL = ProjectPath + @"\Music\" + name;
        MusicPlayer.controls.play();
    }

    public static void Pause()
    {
        MusicPlayer.controls.pause();
    }

    public static void Volume(int volume)
    {
        MusicPlayer.settings.volume = volume;
    }
}