using NAudio.Lame;
using NAudio.Wave;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json;


public class SpeechToText
{
    private Form _form;

    private WaveInEvent _waveIn;

    private WaveFileWriter _writer;

    private string _currentFileName;

    private Guid guid;
    public void StartRecordingAudio(Form form)
    {
        _form = form;

        _waveIn = new WaveInEvent();
        _waveIn.DeviceNumber = 0;
        _waveIn.DataAvailable += waveIn_DataAvailable;
        //_waveIn.RecordingStopped += waveIn_RecordingStopped;
        _waveIn.WaveFormat = new WaveFormat(8000, 1);

        guid = Guid.NewGuid();
        _currentFileName = Directory.GetCurrentDirectory() + "\\Records\\record-" + guid;
        _writer = new WaveFileWriter(_currentFileName+".wav", _waveIn.WaveFormat);

        _waveIn.StartRecording();
    }

    public void StopRecordingAudio()
    {
        if (_waveIn != null)
        {
            _waveIn.StopRecording();
        }
    }

    private void ConvertWavToOgg()
    {
        ProcessStartInfo info = new ProcessStartInfo();
        info.FileName = "ffmpeg.exe";
        info.WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Records");
        info.Arguments = $"-i record-{guid}.wav record-{guid}.ogg";
        info.UseShellExecute = false;
        Process.Start(info).WaitForExit();
    }

    public string GetTextFromSpeech()
    {
        var audioFileByteArray = ConvertWavToOgg(_currentFileName);
        
        var request = (HttpWebRequest) WebRequest.Create(
                "https://stt.api.cloud.yandex.net/speech/v1/stt:recognize?topic=general&lang=ru-RU&folderId=b1gn2tudjjpvhi9a7ncm");
        var accessToken =
        "t1.9euelZqTlZLNyZXKkI6emZyPjMqMlu3rnpWal86Ym8vGi82czI2QyMfMlcjl9PdTBjpt-e8kWlWJ3fT3EzU3bfnvJFpViQ.zBKyLUeuJdkFw96PT8tj97AtMapvt8MYkraclIJVAu_D_5ZPAJmsFs5yidhj2mANmGSob8dsnrt0Ci8iamfSAw";
        request.Method = "POST";
        //request.ContentType = "audio/x-wav";
        byte[] oggFile = File.ReadAllBytes(Directory.GetCurrentDirectory() + $"\\Records\\record-{guid}.ogg");
        request.ContentLength = oggFile.Length;
        request.PreAuthenticate = true;
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Accept = "application/json";

        var requestStream = request.GetRequestStream();
        requestStream.Write(oggFile, 0, oggFile.Length);

        var response = request.GetResponse();
        var responseStream = response.GetResponseStream();

        var streamReader = new StreamReader(responseStream, Encoding.Default);
        var json = streamReader.ReadToEnd();
        Result result = JsonSerializer.Deserialize<Result>(json)!;

        responseStream.Close();
        response.Close();
        return result.result;
    }
    protected class Result
    {
        public string result { get; set; }
    }

    private void waveIn_DataAvailable(object? sender, WaveInEventArgs e)
    {
        if (_form.InvokeRequired)
        {
            _form.BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
        }
        else
        {
            _writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
    }

    //private void waveIn_RecordingStopped(object? sender, EventArgs e)
    //{
    //    if (_form.InvokeRequired)
    //    {
    //        _form.BeginInvoke(new EventHandler(waveIn_RecordingStopped), sender, e);
    //    }
    //    else
    //    {
    //        _waveIn.Dispose();
    //        _writer.Close();
    //    }
    //}
}