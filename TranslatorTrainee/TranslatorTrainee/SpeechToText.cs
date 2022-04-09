using System.Net;
using System.Text;
using NAudio.Wave;

namespace TranslatorTrainee;

public class SpeechToText
{ 
    private WaveIn _waveIn;

    private WaveFileWriter _writer;

    private string _currentFileName;

    private string _textFromSpeech;

    public void StartRecordingAudio()
    {
        _waveIn = new WaveIn();
        _waveIn.DeviceNumber = 0;
        _waveIn.DataAvailable += waveIn_DataAvailable;
        _waveIn.RecordingStopped += waveIn_RecordingStopped;
        _waveIn.WaveFormat = new WaveFormat(8000, 1);

        _currentFileName = "../../../TempAudioFiles/" + Guid.NewGuid() + ".wav";
        _writer = new WaveFileWriter(_currentFileName, _waveIn.WaveFormat);

        _waveIn.StartRecording();
    }

    public void StopRecordingAudio()
    {
        _waveIn.StopRecording();
    }

    private void GetTextFromSpeech()
    {
        var audioFileByteArray = ConvertWavToOgg(_currentFileName);
        
        var request = (HttpWebRequest) WebRequest.Create(
                "https://stt.api.cloud.yandex.net/speech/v1/stt:recognize?topic=general&lang=ru-RU&folderId=b1gn2tudjjpvhi9a7ncm");
        var accessToken =
            "t1.9euelZqTlZLNyZXKkI6emZyPjMqMlu3rnpWal86Ym8vGi82czI2QyMfMlcjl9PdTBjpt-e8kWlWJ3fT3EzU3bfnvJFpViQ.zBKyLUeuJdkFw96PT8tj97AtMapvt8MYkraclIJVAu_D_5ZPAJmsFs5yidhj2mANmGSob8dsnrt0Ci8iamfSAw";
        request.Method = "POST";
        request.ContentLength = audioFileByteArray.Length;
        request.PreAuthenticate = true;
        request.Headers.Add("Authorization", "Bearer " + accessToken);
        request.Accept = "application/json";
        
        var requestStream = request.GetRequestStream();
        requestStream.Write(audioFileByteArray, 0, audioFileByteArray.Length);

        var response = request.GetResponse();
        var responseStream = response.GetResponseStream();

        var streamReader = new StreamReader(responseStream, Encoding.Default);
        var json = streamReader.ReadToEnd();
        
        responseStream.Close();
        response.Close();
    }

    private void waveIn_DataAvailable(object? sender, WaveInEventArgs e)
    {
        _writer.Write(e.Buffer, 0, e.BytesRecorded);
    }

    private void waveIn_RecordingStopped(object? sender, EventArgs e)
    {
        _waveIn.Dispose();
        _waveIn = null;
        _writer.Close();
        _writer = null;
        
        GetTextFromSpeech();
    }
}