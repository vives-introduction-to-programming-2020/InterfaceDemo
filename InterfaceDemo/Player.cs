using ConsoleGraphicsEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class Player : IJsonRepresentable, IDrawable
    {
        public Player(string nickname)
        {
            Nickname = nickname;
            Score = 0;
        }

        public void AddScore(int delta)
        {
            Score += delta;
        }

        public override string ToString()
        {
            return $"Player {Nickname} has a score of {Score}";
        }

        public string ToJson()
        {
            return $"{{ \"nickname\": \"{Nickname}\", \"score\": {Score} }}";
        }

        public string Draw()
        {
            return $"{Nickname} - {Score}";
        }

        public int Score { get; private set; }
        public string Nickname { get; private set; }
    }
}
