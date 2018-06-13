using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
