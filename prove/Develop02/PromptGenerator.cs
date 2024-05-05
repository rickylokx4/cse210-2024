    using System;
    class PromptGenerator
    {
        public List<string> _prompts;
        public static string GetRandomPrompt(List<string> _prompts)
        {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
        }
    }