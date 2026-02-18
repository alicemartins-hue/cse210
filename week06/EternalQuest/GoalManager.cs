using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    CreateGoal();
                    break;

                case "2":
                    Console.Clear();
                    ListGoalNames();
                    break;

                case "3":
                    Console.Clear();
                    RecordEvent();
                    break;

                case "4":
                    Console.Clear();
                    SaveGoals();
                    break;

                case "5":
                    Console.Clear();
                    LoadGoals();
                    break;
            }
        }
    }

    public void DisplayPayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }

        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }


    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = _goals[index];

        selectedGoal.RecordEvent();

        int pointsEarned = selectedGoal.GetPoints();
        if (selectedGoal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                pointsEarned += checklist.GetBonus();
            }
        }

        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        List<string> lines = new List<string>();

        lines.Add(_score.ToString());

        foreach (Goal g in _goals)
        {
            lines.Add(g.GetStringRepresentation());
        }

        File.WriteAllLines(filename, lines);
    }



    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], parts[3]);

                bool isComplete = bool.Parse(parts[4]);
                goal.SetComplete(isComplete);           

                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    parts[3],
                    int.Parse(parts[5]),   
                    int.Parse(parts[6])   
                );

                int amountCompleted = int.Parse(parts[4]);
                goal.SetAmountCompleted(amountCompleted);

                _goals.Add(goal);
            }

        }
    }





}