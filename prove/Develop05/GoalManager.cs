using System;

class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Star()
    {
        bool closeProgram = false;
        while (!closeProgram)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();   

            switch (choice)
            {
                case "1":
                CreateGoal();
                break;

                case "2":
                ListGoalDetais();
                break;

                case "3":
                SaveGoals();
                break;

                case "4":
                LoadGoals();
                break;

                case "5":
                RecordEvent();
                break;

                case "6":
                closeProgram = true;
                break;
            }     
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points\n");
    }
    public void ListGoalNames()
    {   
        int indice = 1;
        foreach(Goal i in _goals)
        {
            Console.WriteLine($"{indice}. {i.GetGoalName()}");
            indice++;
        }
    }
    public void ListGoalDetais()
    {
        int indice = 1;
        string mark;
        foreach(Goal i in _goals)
        {
            if (i.IsComplete() == true)
            {
                mark = "X";
            }
            else mark = " ";
            Console.WriteLine($"{indice}. [{mark}] {i.GetDetailsString()}");
            indice++;
        }
    }
    public void CreateGoal()
    {
        string name, description, points;
        int timesPerBonus, bonus;

        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");
        string choice = Console.ReadLine();
        switch(choice)
        {
            case "1":
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associeated with this goal? ");
            points = Console.ReadLine();
            SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(newSimpleGoal);
            break;

            case "2":
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associeated with this goal? ");
            points = Console.ReadLine();
            EternalGoal newEternalgoal = new EternalGoal(name, description, points);
            _goals.Add(newEternalgoal);
            
            break;

            case "3":
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associeated with this goal? ");
            points = Console.ReadLine();
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            timesPerBonus = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it? ");
            bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, timesPerBonus, bonus);
            _goals.Add(newChecklistGoal);
            break;
        }    
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        int goalSelected = int.Parse(Console.ReadLine());
        _goals[goalSelected-1].RecordEvent();
        _score += _goals[goalSelected-1].GetPoints();
    }
    public void SaveGoals()
    {

        Console.Write("Enter a name for the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(fileName))
            {
                saveFile.WriteLine(_score);
                foreach (Goal i in _goals)
                {
                    saveFile.WriteLine(i.GetStringRepresentation());
                }
            }
        Console.WriteLine("File saved successfully.");
    }
    public void LoadGoals()
    {
        Console.Write("Enter a name for the file: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (line.StartsWith("SimpleGoal"))
                {
                    string[] parts = line.Split(",");
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];
                    string isComplete = parts[4];
                    
                    if (isComplete == " True ")
                    {   
                        bool Complete = true;
                        SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points, Complete);
                        _goals.Add(newSimpleGoal);
                    }
                    else
                    {
                        SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(newSimpleGoal);
                    }
                    
                    
                }
            else if(line.StartsWith("EternalGoal"))
            {
                string[] parts = line.Split(",");
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                EternalGoal newEternalgoal = new EternalGoal(name, description, points);
                _goals.Add(newEternalgoal);

            }
            else if(line.StartsWith("CheckListGoal"))
            {
                string[] parts = line.Split(",");
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amount = int.Parse(parts[6]);
                ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus, amount);
                _goals.Add(newChecklistGoal);

            }
            else 
            {
                _score = int.Parse(line);
            }

        }
        
    
    }


}
