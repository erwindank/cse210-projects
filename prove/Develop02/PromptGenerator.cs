class PromptGenerator
{
    private List<string> prompts = new List<string>();

    public void AddPrompt(string prompt)
    {
        prompts.Add(prompt);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Count);
        return prompts[index];
    }
}
