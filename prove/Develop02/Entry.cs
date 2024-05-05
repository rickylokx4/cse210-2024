using System;

class Entry
{
  public string _prompt { get; set; }
  public string _answer { get; set; }
  public DateTime _date { get; set; }

  public Entry(string _input, string _response)
  {
    _prompt = _input;
    _answer = _response;
    _date = DateTime.Now;
  }

  public override string ToString()
  {
    return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_answer}\n";
  }
}