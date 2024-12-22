using NAudio.Wave;
using System;

namespace Audioeditor.MVVM.Model
{
    [Serializable]
    public class SerializableWaveFormat
    {
        public int SampleRate { get; set; }
        public int Channels { get; set; }
        public int BitsPerSample { get; set; }

        public SerializableWaveFormat(WaveFormat waveFormat)
        {
            if (waveFormat == null)
                throw new ArgumentNullException(nameof(waveFormat));

            SampleRate = waveFormat.SampleRate;
            Channels = waveFormat.Channels;
            BitsPerSample = waveFormat.BitsPerSample;
        }

        public WaveFormat ToWaveFormat()
        {
            return WaveFormat.CreateCustomFormat(
                WaveFormatEncoding.Pcm, 
                SampleRate,
                Channels,
                SampleRate * Channels * BitsPerSample / 8,
                Channels * BitsPerSample / 8,
                BitsPerSample);
        }
    }

    [Serializable]
    public class AudioData
    {
        public float[] LeftChannel { get; set; }
        public float[] RightChannel { get; set; }

        public int Length
        {
            get => LeftChannel?.Length ?? 0;
            set { } 
        }

        [NonSerialized]
        private WaveFormat audioFormat;

        public WaveFormat AudioFormat
        {
            get => audioFormat;
            set => audioFormat = value;
        }

        public SerializableWaveFormat SerializableAudioFormat
        {
            get => audioFormat != null ? new SerializableWaveFormat(audioFormat) : null;
            set => audioFormat = value?.ToWaveFormat();
        }

        public AudioData()
        {
        }

        public AudioData(float[] leftChannel, float[] rightChannel, WaveFormat audioFormat)
        {
            LeftChannel = leftChannel;
            RightChannel = rightChannel;
            AudioFormat = audioFormat;
        }
    }
}
