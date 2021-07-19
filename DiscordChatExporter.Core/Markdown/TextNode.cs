﻿namespace DiscordChatExporter.Core.Markdown
{
    internal class TextNode : MarkdownNode
    {
        public string Text { get; }

        public TextNode(string text)
        {
            Text = text;
        }

        public override string ToString() => Text;
    }
}