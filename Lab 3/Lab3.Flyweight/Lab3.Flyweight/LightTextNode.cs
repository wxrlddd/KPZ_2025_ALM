﻿namespace Lab3.Flyweight
{
    public class LightTextNode : LightNode
    {
        private readonly string _text;
        public LightTextNode(string text) => _text = text;

        public override string InnerHTML() => _text;
        public override string OuterHTML() => _text;
    }
}
